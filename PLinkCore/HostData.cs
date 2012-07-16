/*
 * SharpDevelop으로 작성되었습니다.
 * 사용자: easylogic
 * 날짜: 2012-02-17
 * 시간: 오전 10:44
 * 
 * 이 템플리트를 변경하려면 [도구->옵션->코드 작성->표준 헤더 편집]을 이용하십시오.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;

namespace PLinkCore
{

	/// <summary>
	/// Description of HostData.
	/// </summary>
	public sealed class HostData
	{

		public string HOST_ROOT = System.Environment.SystemDirectory ;		
		
		public const int ERROR_OPEN_FILE = -1;
		public const int OK = 1;	
		
		private const string WEB_POLICY_DIR = "http://neowizgames.github.com/plink/list.html";
		private const string WEB_POLICY_FILE = "http://neowizgames.github.com/plink/get?pcy=";
		
		private ArrayList titleList;
		private Dictionary<string, HostItem> list;
		private Dictionary<string, string> patternList;		
		private Dictionary<string, string> hostListTable;
		private ArrayList fileList;
		private ArrayList webList;		
		private ArrayList customList;	
		
		
		
		/**
		 * UI 상태 동기화 
		 * 
		 */ 
		private bool _isStart;
		private int _current;
		private int _webIndex = -1;
		private int _localIndex = -1;
		private int _bookmarkIndex = -1;
		private bool _isHttpsFilter;
		private string _rootDir;
		private string _version;
		private string _versionUrl;
		private string _noticeUrl;			
		private string _updateVersion;
		private string _appName;
		private string _headerEncoding = "UTF-8";
		private string _web_policy_dir;
		private string _web_policy_file;		
		private bool _autoStart = false;
		
		

		public HostData()
		{
			list = new Dictionary<string, HostItem>();
            fileList = new ArrayList();
            webList = new ArrayList();
            customList = new ArrayList();
            titleList = new ArrayList();
            patternList = new Dictionary<string, string>();
            hostListTable = new Dictionary<string, string>();
		}
		
		/**
		 * 상태저장 
		 * 
		 */ 
		[CategoryAttribute("PLink 설정"),DescriptionAttribute("상태 저장")]
		public bool AutoStart { 
			get { return _autoStart; }
			set { _autoStart = value; }
		}
		
		/**
		 * 피들러 헤더 인코딩 지정 
		 * 
		 */ 
		[CategoryAttribute("PLink 설정"),DescriptionAttribute("HTTP 헤더 인코딩 적용")]
		public string HeaderEncoding { 
			get { return _headerEncoding;	}
			set { _headerEncoding = value; }
		}
		
		/**
		 * 웹 정책 리스트 
		 */
		public string POLICY_DIR { 
			get { 
				if (string.IsNullOrEmpty(_web_policy_dir)) { 
					_web_policy_dir = Util.getDefaultPref("URL", "policy", WEB_POLICY_DIR);
				}
				
				return _web_policy_dir;
			}
		}
		
		/**
		 * 웹 정책 데이타 URL 
		 * 
		 */ 
		public string POLICY_FILE { 
			get { 
				if (string.IsNullOrEmpty(_web_policy_file)) { 
					_web_policy_file = Util.getDefaultPref("URL", "policy_data", WEB_POLICY_FILE);
				}
				
				return _web_policy_file;		
			}
		}
		
		public string AppName { 
			get { return _appName; }
			set { _appName = value; }
		}		
		
		public string UpdateVersion { 
			get { return _updateVersion; }
			set { _updateVersion = value; }
		}
		
		public string Version { 
			get { return _version; }
			set { _version = value; }
		}
		
		public string VersionUrl { 
			get { return _versionUrl; }
			set { _versionUrl = value; }
		}
		
		public string NoticeUrl { 
			get { return _noticeUrl; }
			set { _noticeUrl = value; }
		}			
		

		public int SelectBookmarkIndex { 
			get { return _bookmarkIndex; }
			set { _bookmarkIndex = value; }
		}	
		
		public int SelectWebIndex { 
			get { return _webIndex;  }
			set { _webIndex = value;  }
		}
		
		public int SelectLocalIndex { 
			get { return _localIndex; } 
			set { _localIndex = value; }
		}
		
		public bool StartState {  
			get { return _isStart; }
			set { _isStart = value; }
		}		
		
		[CategoryAttribute("PLink 설정"),DescriptionAttribute("Https 필터 적용")]
		public bool isHttpsFilter { 
			get { return _isHttpsFilter; }
			set { _isHttpsFilter = value; }
		}		
		
		public string RootDir { 
			get { return _rootDir; }
			set { _rootDir = value; }

		}		
		
		public int Current { 
			get { return _current; }
			set { _current = value; }
		}
		
		public int loadDir(string fullpath) { 
			FileInfo file = new FileInfo(fullpath);
			
			if (!file.Exists) { 
				return ERROR_OPEN_FILE;
			}
			
			FileInfo[] files = file.Directory.GetFiles("*" + HostItem.FILE_EXT);
			fileList.Clear();
			
			foreach(FileInfo f in files) { 
				fileList.Add(new KeyValuePair<string, string>(f.Name, f.FullName));
			}
			
			return OK;
		}
		
		private ArrayList getFileData(string fullpath) { 
			FileInfo file = new FileInfo(fullpath);
			// file root 
			
			if (!file.Exists) { 
				return new ArrayList();
			}
	
			// file content 
			FileStream fs = file.OpenRead();
			StreamReader sr = new StreamReader(fs);
			ArrayList list = new ArrayList(sr.ReadToEnd().Split('\n'));			                
			sr.Close();
			
			return list;
		}
		
		public void loadFile(string fullpath) { 
			setDictionary(getFileData(fullpath));
		}
		
		// real time load 
		public void loadHttp(string policy) { 
			loadHttp(POLICY_FILE + policy, false);
		}
		
		//
		// if cached is false, real time load but cached file load
		//
		public void loadHttp(string url, bool cached) { 
			setDictionary(Util.getHttpData(url));
		}
		
		private void setDictionary(ArrayList arr) { 
			list.Clear();
			titleList.Clear();
			patternList.Clear();
			
			foreach(string temp in arr) { 
				
				if (string.IsNullOrEmpty(temp)) break;
				if (temp.Trim().IndexOf(Util.DELIMITER_INFO) == 0) { 
					titleList.Add(temp.Trim());
					continue;
				}

				HostItem it = new HostItem(temp.Trim().Split(','));
				
				if (it.error == 0) { 
					list[it.Before] = it;
					
					if (it.isPattern()) { 
						patternList[it.Before] = it.After;
					}
				}				
			}			
		}
		
		public int setHost(HostItem it) { 
			int ret = 0;
			if (list.ContainsKey(it.Before)) { 
				ret = 1;
			}
			
			list[it.Before] = it;
			if (it.isPattern()) { 
				patternList[it.Before] = it.After;
			}
			return ret;
		}
		
		
		
		public void loadPolicyList()
		{
			loadHttpRoot(POLICY_DIR);
		}		
		
		public void loadHttpRoot(string url) { 
			webList.Clear();
			webList = Util.getHttpData(url);
		}
		
		public ArrayList getWebList() { 
			return webList;	
		}
		
		public ArrayList getFileList() { 
			return fileList;	
		}
		
		public ArrayList getTitleList() { 
			return titleList;	
		}
		
		private void setData(Dictionary<string, HostItem> itemList) { 
			list = itemList;
		}
		
		public ArrayList getData() { 
			ArrayList temp = new ArrayList();
			ArrayList tempPattern = new ArrayList();
			
			foreach(KeyValuePair<string, HostItem> item in list) { 
				temp.Add(item);
				
				if (item.Value.isPattern()) { 
					tempPattern.Add(item);
				}
			}
			
			temp.Sort(new HostSorter());
			tempPattern.Sort(new HostSorter());
			
			patternList.Clear();
			
			foreach(KeyValuePair<string, HostItem> item in tempPattern) { 
				patternList[item.Value.Before] = item.Value.After;
			}
			
			return temp;		
		}
		
		public void refreshHost(string key, bool state) { 
			if (list.ContainsKey(key)) {
				list[key].Checked = state;
			}
		}
		
		public void removeHost(string key) { 
			list.Remove(key);
			if (patternList.ContainsKey(key)) { 
				patternList.Remove(key);
			}
		}
		
		public HostItem getHostItem(string key) { 
			if (list.ContainsKey(key)) { 
				return list[key];
			}
			
			return new HostItem();
		}
		
		
		
		// get ip address by hostname 
		public string getIp(string hostname) { 
			
			if (hostListTable.ContainsKey(hostname)) {
        		return hostListTable[hostname].ToString();
			}
			
			try { 
					
				IPAddress[] ip = System.Net.Dns.GetHostAddresses(hostname);
				
				if (ip != null) { 
					object value = ip.GetValue(0);
					if (value != null) {
						hostListTable.Add(hostname, value.ToString());
						return hostListTable[hostname].ToString();
					}
				} else { 
					hostListTable.Add(hostname, "");
					return hostListTable[hostname].ToString();
				}
			} catch (Exception ex) { 
				System.Diagnostics.Debug.WriteLine(ex.Message);
			}
			
			return hostname;
		}  		
		
		
        public void changeHostFile() { 

			try {         	
				
				if (!Util.canModifyHosts()) return; 
				
				if (list == null) return;
				
				StringBuilder sb = new StringBuilder();
				foreach(KeyValuePair<string, HostItem> item in list) { 
					if (!item.Value.isSaveHost()) continue;

					string temp_host = getIp(item.Value.After);
					if (string.IsNullOrEmpty(temp_host)) {
						sb.Append(Util.DELIMITER_INFO);
					}
					sb.Append(temp_host).Append("\t\t\t\t\t").AppendLine(item.Value.Before);
				}
	
				string text = "\r\n### PLink Host Policy ###\r\n" +  sb.ToString();				
				
        		File.WriteAllText(HOST_ROOT + Util.HOST_SOURCE, text);
        	} catch (Exception ex) { 
				System.Diagnostics.Debug.WriteLine(ex.Message);
        	}
        }  
		
		public void initHostFile() { 
			if (!Util.canModifyHosts()) return; 			
			
			File.WriteAllText(HOST_ROOT + Util.HOST_SOURCE, "");
			File.WriteAllText(HOST_ROOT + Util.HOST_TARGET, "");
			
			this.changeHostFile();
		}
		
        
        public void rollbackHostFile() { 
			if (!Util.canModifyHosts()) return; 			
			
        	try { 
       			File.Copy(HOST_ROOT + Util.HOST_TARGET, HOST_ROOT + Util.HOST_SOURCE, true);
        	} catch (Exception ex) { 
				System.Diagnostics.Debug.WriteLine(ex.Message);
        	}
        }   		
		
		/**
		 * 현재는 패턴 체크를 하나만 하도록 되어 있음 
		 * 
		 */
		public HostCheck checkPattern(string url) { 
			foreach(KeyValuePair<string, string> it in patternList) { 
				
				HostItem item = getHostItem(it.Key);
				
				if (item.isPattern()) { 
					// 문자열 매칭 
					if (url.IndexOf(item.Before) > -1) { 	
						if (item.Checked) { 
							return new HostCheck(true, item.type, item.Before, item.After);
						}
					}
				}
			}
			
			return null;
		}
		
		public List<HostCheck> checkPatternList(string url) { 
			List<HostCheck> list = new List<HostCheck>();
			
			foreach(KeyValuePair<string, string> it in patternList) { 
				
				HostItem item = getHostItem(it.Key);
				
				if (url.IndexOf(item.Before) > -1) { 	
					if (item.Checked) { 
						list.Add(new HostCheck(true, item.type, item.Before, item.After));
					}
				}
				
			}
			
			return list;
		}
		
		public HostCheck checkUrl(string host, string path) { 
			if (list == null) return null;
			
			// hostname 체크 
			if (list.ContainsKey(host)) { 
				HostItem item = list[host];

				if (item.Checked) { 
					return new HostCheck(true, item.type, item.Before, item.After);
				}
			}
			
			return null;
		}
		
		public void backupHostFile()
		{
			if (!Util.canModifyHosts()) return; 						
        	try { 
       			File.Copy(HOST_ROOT + Util.HOST_SOURCE, HOST_ROOT + Util.HOST_TARGET, true);
        	} catch (Exception ex) { 
				System.Diagnostics.Debug.WriteLine(ex.Message);
        	}
		}		
		
		public bool export(string path)
		{
			StringBuilder sb = new StringBuilder();
			
			foreach (string title in titleList) { 
				sb.AppendLine(title);
			}
			
			foreach(KeyValuePair<string, HostItem> item in list) { 
				sb.AppendLine(item.Value.ToString());
			}
			
			try { 
				File.WriteAllText(path, sb.ToString());
				return true;
			} catch (Exception ex) { 
				System.Diagnostics.Debug.WriteLine(ex.Message);
				return false; 
			}
		}
		
		public void setBookmark(string key, string value)
		{
			Util.setBookmark(key,value);
		}
		
		public void deleteBookmark(string key)  { 
			Util.deleteBookmark(key);
		}
		
		public ArrayList getBookmarkList() {
			return Util.getBookmarkList();
		}		

	}

}
