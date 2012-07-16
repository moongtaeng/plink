/*
 * SharpDevelop으로 작성되었습니다.
 * 사용자: easylogic
 * 날짜: 2012-04-10
 * 시간: 오후 5:22
 * 
 * 이 템플리트를 변경하려면 [도구->옵션->코드 작성->표준 헤더 편집]을 이용하십시오.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

using Microsoft.Win32;

namespace PLinkCore
{
	/// <summary>
	/// Description of Util.
	/// </summary>
	public class Util
	{
		public const string APP_DIR = @"Software\Microsoft\Windows\CurrentVersion\App Paths\PLink.exe";
		
    	public const string REG_ROOT = @"SOFTWARE\PLink\Share\Pref";
    	public const string BOOKMARK_ROOT = @"SOFTWARE\PLink\Share\Bookmark";
    	
		public const string HOST_SOURCE = "\\drivers\\etc\\hosts";   
		public const string HOST_TARGET = "\\drivers\\etc\\hosts_plink_2012";  	    	
		
		public const string VERSION_URL = "http://neowizgames.github.com/plink/Setup/version.txt";
		public const string NOTICE_URL = "http://neowizgames.github.com/plink/notice";		
    	
		public const char DELIMITER_DEV = '|';
		public const char DELIMITER_ROOT = ',';
		public const string DELIMITER_INFO = "#";    	
    	
		public const string APP_PLINK = "PLINK";
		public const string APP_FIDDLER = "FIDDLER";
		
    	public const string NAME = "PLink";    	
    	public const string BTN_START = "▶ Start";
    	public const string BTN_END = "■ Stop";    	
    	
    	public const string DIALOG_FILTER = "PLink Rules (*.pcy)|*.pcy";
		public const string DIALOG_TITLE = "Save PLink Policy Rules";
    	
    	public const string TRUE = "TRUE";
    	public const string FALSE = "FALSE";		
    	public const int TYPE_WEB = 1;
    	public const int TYPE_FILE = 2;		
    	public const int TYPE_EMPTY = 0;
    	public const string TYPE_NAME_URL = "URL";
    	public const string TYPE_NAME_HOST = "HOST";
    	public const string TYPE_NAME_REAL = "REAL";
    	public const string TYPE_NAME_PATTERN = "PATTERN";
    	
		public const string REG_KEY_RUNNING 				= "running";
		public const string REG_KEY_AUTO 					= "auto";
		public const string REG_KEY_START 					= "start";
		public const string REG_KEY_CURRENT_POLICY 			= "current.policy";			
		public const string REG_KEY_WEB_POLICY_DIR 			= "web.policy.dir";			
		public const string REG_KEY_WEB_POLICY_SELECT 		= "web.policy.select";				
		public const string REG_KEY_LOCAL_POLICY_PATH 		= "local.policy.path";
 
		[DllImport("kernel32.dll")]
		private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
		
		[DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        
		[DllImport("kernel32.dll", CallingConvention=CallingConvention.StdCall, CharSet=CharSet.Ansi)]
		private static extern int GetPrivateProfileSection(string section, IntPtr retVal, UInt32 size, string filePath);
        
        
		public static string[] iniGetKeys(string section) {
			IntPtr pBuffer = Marshal.AllocHGlobal(32767);
			string[] strArray = new string[0];
			
        	int i = GetPrivateProfileSection(section, pBuffer, 32767, getINIPath());
        	
        	int start = pBuffer.ToInt32();
        	int end = start + i;
        	
        	while(start < end) { 
        		int size = strArray.Length;
        		Array.Resize<string>(ref strArray, size + 1);
        		
        		string strCurrent = Marshal.PtrToStringAnsi(new IntPtr(start));
        		
        		strArray[size] = strCurrent;
        		
        		int len = Encoding.GetEncoding("EUC-KR").GetByteCount(strCurrent);
        		//int len = strCurrent.Length;
        		
        		start += (len + 1);
        	}
        	
        	Marshal.FreeHGlobal(pBuffer);
        	pBuffer = IntPtr.Zero;
        	
        	return strArray;
		}
		
        public static string iniGetValue(string section, string key) {
        	StringBuilder sb = new StringBuilder(255);
        	int i = GetPrivateProfileString(section, key, "", sb, 255, getINIPath());
        	
        	return sb.ToString();
        }
        
        public static void iniSetValue(string section, string key, string value) { 
        	WritePrivateProfileString(section, key, value, getINIPath());
        }
		
		public static string getDefaultPref(string section, string key, string defaultValue)
		{
			string value = iniGetValue(section, key);
			if (string.IsNullOrEmpty(value)) {
			    iniSetValue(section, key, defaultValue);
			    value = defaultValue;
			}
			
			return value; 
		}		
        	
        public static string getINIPath() { 
        	
        	if (PLink.host.AppName.Equals(APP_FIDDLER)) { 
        		// if PLink installed 
        		string path = getRegValue(APP_DIR, "");
        		
        		path = path.Replace(@"\PLink.exe", "") + @"\Settings.ini";
        		
        		if (File.Exists(path)) { 
        			return path;	
        		}
        	}
			
			// 기본 실행 디렉토리 
			FileInfo file = new FileInfo(Application.ExecutablePath);
    		return file.Directory.FullName + @"\Settings.ini";			
        }
		
        public static void setPrefBool(string section, string key, bool value) { 	
        	iniSetValue(section, key, strTrue(value));
        }
        
        public static void setPrefBool(string key, bool value) { 
        	setPrefBool("config", key, value);
        }		
		
		
        public static void setPrefInt(string section, string key, int value) { 
        	iniSetValue(section, key, value.ToString());
        }
        
        public static void setPrefInt(string key, int value) { 
        	setPrefInt("config", key, value);
        }
		
		public static void setPref(string section, string key, int value) { 
			setPrefInt(section, key, value);
		}
        
		public static void setPref(string key, int value) { 
        	setPrefInt("config", key, value);
		}        

		public static void setPref(string key, bool value) { 
			setPrefBool("config", key, value);
		}

		public static void setPref(string section, string key, string value) { 
        	iniSetValue(section, key, value);
        }
        
        public static void setPref(string key, string value) { 
        	setPref("config", key, value);
        }
        
        public static string getPref(string key) { 
        	return getPref("config", key);
        }
        
        public static string getPref(string section , string key) { 
        	return iniGetValue(section,key);
        }
        
        public static string getRegValue(string mainkey, string key) { 
        	RegistryKey reg = Registry.LocalMachine.OpenSubKey(mainkey, true);
        	
        	if (reg == null) return string.Empty;
        	
        	object temp = reg.GetValue(key, string.Empty);
        	
        	return temp.ToString();
        }        
		
        public static bool getPrefBool(string key) { 
			return isTrue(getPref(key));
        }		
        
        public static int getPrefInt(string key) { 
			int i = 0;
			if (int.TryParse(getPref(key), out i)) { 
				return i;
			}	
			
			return -1;
        }       		
		
        public static bool isFile(int type) { 
        	return type == TYPE_FILE;	
        }
        
        public static bool isWeb(int type) { 
        	return type == TYPE_WEB;	
        }		    	
    	
		public static bool isTrue(string type) { 
			return type.Equals(TRUE);
		}
		
		public static string strTrue(bool type) { 
			return type ? TRUE : FALSE;
		}
    	
		public static string getTypeName(int type) { 
			if (type == 1) { 
				return TYPE_NAME_HOST;
			} else if (type == 2) {
				return TYPE_NAME_URL;
			} else if (type == 3) {
				return TYPE_NAME_REAL;
			} else if (type == 4) {
				return TYPE_NAME_PATTERN;				
			}			
			
			return "Empty";
		}    

    	public static string setUserConfig(string After,string key, string value) { 
				string pattern = "{"+key+"}";
				if (After.IndexOf(pattern) > -1) { 
					return After.Replace(pattern, value);
				}
				
				return After;
	    }
	    
	    public static string setKeyword(string After, string key, string value) { 
				string pattern = key;
				if (After.IndexOf(pattern) > -1) { 
					return After.Replace(pattern, value);
				}
				
				return After;
	    }
		
		public static void deletePref(string section, string key) { 
			iniSetValue(section, key, null);
		}
		
		public static void deletePref(string key) { 
			deletePref("config", key);
		}
		
		// 북마크 관련 registry 작업 

		/**
		 * registry 에 즐겨찾기 설정 
		 * 
		 */
		public static void setBookmark(string key, string value) { 
			iniSetValue("bookmark", key, value);
		}
		
		/**
		 * 즐겨찾기 정보 얻어오기 
		 * 
		 */ 
		public static string getBookmark(string key) { 
			return iniGetValue("bookmark", key);
		}
		
		/**
		 * 즐겨찾기 삭제 
		 * 
		 */
		public static void deleteBookmark(string key) { 
			iniSetValue("bookmark", key, null);
		}
		
		/**
		 * bookmark 얻어오기 
		 * 
		 * 
		 */
		public static ArrayList getBookmarkList() {
			ArrayList list = new ArrayList();
			
			string[] values = iniGetKeys("bookmark");
			

			foreach(string str in values) { 
				string[] temp = str.Split('=');
				
				list.Add(new KeyValuePair<string, string>(temp[0], temp[1]));
			}
			
			return list;
		}
		
		/**
		 * http 데이타 ArrayList 로 얻어오기 
		 * 
		 */
		public static ArrayList getHttpData(string url) { 
			ArrayList list = new ArrayList();		
			
			try { 
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
				request.KeepAlive = false;
				request.Method = "GET";
				request.Timeout = 500;
				
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				StreamReader sr = new StreamReader(response.GetResponseStream());
				
				string temp = string.Empty;
				while((temp = sr.ReadLine()) != null) {
					list.Add(temp.Trim());
				}
				
				sr.Close();
			} catch (Exception  ex) { 
				System.Diagnostics.Debug.WriteLine(ex.Message);
				
			} finally { 

			} 

			return list;			
		}		
		
		public static string checkVersion(string version) { 
			ArrayList data = getHttpData(PLink.host.VersionUrl);
			if (data.Count == 0) return version;

			// 동일 버전이면 업데이트 안함 			
			string prev = data[0].ToString().Trim();
			if (prev.Equals(version)) {  return version; 	 }
			
			// 버전 체크 
			string[] prev_list = prev.Split('.');
			string[] version_list = version.Split('.');
			
			if (int.Parse(prev_list[0]) > int.Parse(version_list[0])) { return prev; }
			if (int.Parse(prev_list[0]) == int.Parse(version_list[0])) { 
				if (int.Parse(prev_list[1]) > int.Parse(version_list[1])) { return prev; }
				if (int.Parse(prev_list[1]) == int.Parse(version_list[1])) { 
					if (int.Parse(prev_list[2]) > int.Parse(version_list[2])) { return prev; }
					if (int.Parse(prev_list[2]) == int.Parse(version_list[2])) { 
						if (int.Parse(prev_list[3]) > int.Parse(version_list[3])) { return prev; }
					}
				}
			}
			
			return version; 
		}
		
		/**
		 * 다운로드 링크 얻어오기  
		 * 
		 */
		public static string getDownloadLink(string version)
		{
			return "http://neowizgames.github.com/plink/Setup/"+version+"/PLinkSetup.exe";
		}
		
		public static ArrayList getNotice()
		{
			return getHttpData(PLink.host.NoticeUrl);
		}
		
		public static void closeApplication() { 
			closeApplication("iexplore");
		}
		
		public static void closeApplication(string program) { 
			Process[] p = Process.GetProcessesByName(program);
			foreach(Process temp in p) { 
				temp.Kill();
			}
		}
		
		public static bool canModifyHosts() { 
			return isNoneAdminOS() || ( isAdminOS() && isAdmin() );
		}
		
		public static bool isXP() { 
			return Environment.OSVersion.Version.Major == 5;	
		}
		
		public static bool isNoneAdminOS() { 
			return Environment.OSVersion.Version.Major <= 5;	
		}
		
		public static bool isAdminOS() { 
			return Environment.OSVersion.Version.Major > 5;
		}
		
		public static bool isVista() { 
			return Environment.OSVersion.Version.Major == 6;	
		}		
		
		public static bool isWin7() { 
			return Environment.OSVersion.Version.Major == 7;	
		}		
		
		public static bool isAdmin() { 
			return  new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole("Administrators");
		}
		
		public static string getStatus(int code)
		{
			if (code == 404) { 
				return "404 Not Found";	
			} else if (code == 403) {
				return "403 Forbidden";					
			} else if (code == 500) {
				return "500 Internal Server Error";	
			} 
			
			return "200 OK";
		}		
		
	}
}
