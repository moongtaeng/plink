/*
 * SharpDevelop으로 작성되었습니다.
 * 사용자: easylogic
 * 날짜: 2012-03-16
 * 시간: 오후 1:06
 * 
 * 이 템플리트를 변경하려면 [도구->옵션->코드 작성->표준 헤더 편집]을 이용하십시오.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Fiddler;
using PLinkCore;

namespace PLink
{
	/// <summary>
	/// Description of PLinkOne.
	/// </summary>
	public class PLink : PLinkCore.PLink
	{
		MainForm mainForm;
		
		private int port = 8888;
		private bool disabledCache = false;
		
		public int Port {
			get { return port; }
			set {
				port = value;
				FiddlerApplication.Prefs.SetInt32Pref("plink.remote.port", port);
				Restart();
			}
		}
		
		public bool DisabledCache {
			get { return DisabledCache; }
			set {
				disabledCache = value;
				FiddlerApplication.Prefs.SetBoolPref("plink.disabled.cache", disabledCache);
			}
		}
		
		public PLink(MainForm form) : base()
		{
			mainForm = form;
			hostTab.setPLink(this);
		}
		
		public override void log(string str) {
			System.Diagnostics.Debug.WriteLine(str);
		}
		
		public void FiddlerApplication_Log_OnLogString (object sender, LogEventArgs e) {
			log(e.LogString);
		}

		public override void initializeUI()
		{
			this.port = FiddlerApplication.Prefs.GetInt32Pref("plink.remote.port", 8888);
			
			mainForm.DisabledCache = FiddlerApplication.Prefs.GetBoolPref("plink.disabled.cache", false);
			
			FiddlerApplication.BeforeRequest += AutoTamperRequestBefore;
			FiddlerApplication.BeforeReturningError += OnBeforeReturningError;
			FiddlerApplication.BeforeResponse += AutoTamperResponseBefore;
			FiddlerApplication.AfterSessionComplete += AutoTamperResponseAfter;
			FiddlerApplication.ResponseHeadersAvailable += OnPeekAtResponseHeaders;
			FiddlerApplication.RequestHeadersAvailable += OnPeekAtRequestHeaders;
			
			//hostTab.OnStart += OnStartUp;
		}

		public void StopCapture()
		{
			if (FiddlerApplication.IsStarted()) {
				FiddlerApplication.Shutdown();
				log("shutdown");
				mainForm.CapturePLinkToolStripMenuItem.Checked = false;
				mainForm.CapturePLinkToolStripMenuItem.Text = "Capture Stop!";
			}
		}
		
		public void StartCapture()
		{
			if (!FiddlerApplication.IsStarted()) {
				FiddlerApplication.Startup(port, true, false, true);
				log("startup");
				mainForm.CapturePLinkToolStripMenuItem.Checked = true;
				mainForm.CapturePLinkToolStripMenuItem.Text = "Capture Start!";
			}
		}
		
		public void Restart() {
			StopCapture();
			StartCapture();
		}
		
		public void OnStartUp(object sender, EventArgs e)  {
			StartCapture();
			
			CheckBox cb = (CheckBox)sender;
			
			if (cb.Checked) {
				StartCapture();
			} else {
				StopCapture();
			}
			
		}
		
		public void StartButton() {
			hostTab.StartState = true;
		}
		
		public void StopButton() {
			hostTab.StartState = false;
		}
		
		
		public void AutoTamperRequestBefore(Session oSession)
		{
			// 캐쉬 적용하지 않기
			if (disabledCache){ SetDiabledCache(oSession); }
			
			// http:443 프로토콜 체크
			if (PLinkCore.PLink.host.isHttpsFilter) { checkHttpsFilter(oSession); }
			
			log(getSessionString(oSession));
			
			// api 모드 적용
			if (oSession.HostnameIs("api.plink")) {
				runApiMode(oSession);
				return;
			}
			
			// PLink host 변조 적용
			if (PLinkCore.PLink.host.StartState) {
				checkHost(oSession);
			}

			log(oSession.fullUrl);
		}
		
		// HOST, URL, REAL 타입체크
		void checkHost(Session oSession)
		{
			HostCheck patternCheck = PLinkCore.PLink.host.checkPattern(oSession.fullUrl);
			
			// 패턴 체크를 하고 
			if (patternCheck != null && patternCheck.Checked) {
				// 패턴이 체크 되어 있으면 , fullUrl 을 바꾸고 
				bool isCheck = checkUrlType(patternCheck, oSession);
				
				if (!isCheck) return;
				//return;
			}
			
			HostCheck check = PLinkCore.PLink.host.checkUrl(oSession.hostname, oSession.PathAndQuery);
			
			if (check == null) return;
			if (!check.Checked) return;
			
			// Host, Real 적용
			if (check.isHost() || check.isReal()) {
				if (oSession.HTTPMethodIs("CONNECT")) {
					oSession.hostname = check.afterHost();
				} else {
					oSession.bypassGateway = true;
					oSession["x-overrideHost"] = check.After;
				}
			}
			// URL, PATTERN 적용
			else if (check.isUrl() || check.isPattern()) {
				if (oSession.HTTPMethodIs("CONNECT")) {
					oSession.hostname = check.afterHost();
				} else {
					
					// 캐쉬된 정책 적용 
					string redirect = check.getHostItem().Redirect;
					if (!string.IsNullOrEmpty(redirect)) { 
						check.After = redirect;
					}
					oSession.fullUrl = check.afterUrl(oSession.fullUrl);
				}
			}
		}
		
		void sendResponse(Session oSession, int code, string content_type, byte[] data) {
			oSession.utilCreateResponseAndBypassServer();			
			oSession.oResponse.headers.HTTPResponseCode = code;
			
			string status = Util.getStatus(code);
			
			oSession.oResponse.headers.HTTPResponseStatus = status;
			
			oSession.oResponse.headers["Content-Type"] = content_type;
			//oSession.oResponse.headers["Content-Length"] = data.Length.ToString();
			
			log(data.ToString());
			
			oSession.ResponseBody = data;
		}		

		// 패턴 체크 실행
		bool checkUrlType(HostCheck patternCheck, Session oSession)
		{
			if (oSession.HTTPMethodIs("CONNECT")) {
				oSession.hostname = patternCheck.afterHost();

			} else {
				
				if (patternCheck.isStatus()) { 
					int code = patternCheck.getStatusCode();
					
					sendResponse(oSession, code, "text/html", new byte[0]);
					
					return false; 
				}				
				
				if (patternCheck.isFolder() || patternCheck.isFile()) {
					string url = oSession.fullUrl;
					int idx = url.LastIndexOf(patternCheck.Before);
					
					FileInfo file;
					string target;

					if (patternCheck.isFolder()) { 
					
						string first = url.Substring(0, idx);
						string second = patternCheck.Before;
						string last = url.Replace(first, "").Replace(second, "");
						
						log(first + " : " + second + " : " + last);
						
						if (string.IsNullOrEmpty(last) || last.Equals("/")) {
							last = "/index.html";	
						}
						
						if (last[0] != '/') {  last = "/" + last; }
					
						target = patternCheck.After + last;						
					} else { 
						target = patternCheck.After;	
					}

					file = new FileInfo(target);
					
					if (file.Exists) { 
						string content_type = MimeType.Get(file.Extension);
						byte[] data = File.ReadAllBytes(file.FullName);
						
						sendResponse(oSession, 200, content_type, data);
						
						return false; 

					}
					
					
				} else { 				
					oSession.fullUrl = patternCheck.afterUrl(oSession.fullUrl);

				}

			}
				
			return true;			
		}

		// api 모드 실행
		void runApiMode(Session oSession)
		{
			PLinkApiType data = router(oSession.PathAndQuery);
			
			if (data == null) {
				oSession.oRequest.pipeClient.End();
			} else {
				SetDiabledCache(oSession);
				// 새로운 응답 만들기
				oSession.utilCreateResponseAndBypassServer();
				oSession.oResponse.headers.HTTPResponseCode = 200;
				oSession.oResponse.headers.HTTPResponseStatus = "200 OK";
				oSession.oResponse.headers["Content-Type"] = data.ContentType;
				SetDiabledCacheAfter(oSession);
				oSession.utilSetResponseBody(data.Body);
			}
		}

		// Https 필터 실행
		void checkHttpsFilter(Session oSession)
		{
			if (Regex.IsMatch(oSession.fullUrl, "^(http)://(.*):443/")) {
				oSession.fullUrl = Regex.Replace(oSession.fullUrl, "^(http)://(.*):443/", delegate(Match match) {
                 	string change = string.Format("{0}s://{1}/", match.Groups[1].ToString(), match.Groups[2].ToString());
                 	return change;
                 });
			}
		}

		// Disabled Cache 적용 - Request 
		void SetDiabledCache(Session oSession)
		{
			oSession.oRequest.headers.Remove("If-None-Match");
			oSession.oRequest.headers.Remove("If-Modified-Since");
			oSession.oRequest["Pragma"] = "no-cache";
		}
		
		// Disabled Cache 적용 - Response
		void SetDiabledCacheAfter(Session oS)
		{
			oS.oResponse.headers.Remove("Expires");
			oS.oResponse["Cache-Control"] = "no-cache";
		}		
		
		string getSessionString(Session oSession)
		{
			string url = oSession.fullUrl;
			string host = oSession.host;
			int port = oSession.port;
			string method = oSession.oRequest.headers.HTTPMethod;
			string version = string.Format(@"{0} {1} {2}", oSession.oRequest.pipeClient.LocalPort, oSession.oRequest.pipeClient.LocalProcessID, oSession.oRequest.pipeClient.LocalProcessName);
			string clientIp = oSession.clientIP;
			int clientPort = oSession.clientPort;
			
			return string.Format("ip : {0}, port : {1}, method : {2}, version : {3}, host  : {4}, port : {5}, url : {6}", clientIp, clientPort, method, version, host, port, url);
		}
		
		public void AutoTamperRequestAfter(Session oSession) {
			
		}
		public void AutoTamperResponseBefore(Session oSession) {
			
			
		}
		public void AutoTamperResponseAfter(Session oSession) {

		}
		public void OnBeforeReturningError(Session oSession) {
			
		}
		
		void OnPeekAtResponseHeaders(Session oS)
		{
			if (disabledCache) {
				SetDiabledCacheAfter(oS);
			}
			
			if (oS.oResponse.headers.Exists("Content-Length"))
			{
				int iLen = 0;
				if (int.TryParse(oS.oResponse["Content-Length"], out iLen))
				{
					if (iLen > 5000000)
					{
						oS.bBufferResponse = false;
						oS["log-drop-response-body"] = "save memory";
					}
				}
			}
		}

		
		void OnPeekAtRequestHeaders(Session oSession)
		{
			if (oSession.oRequest.headers.Exists("Content-Length")) {
				int iLen = 0;
				if (int.TryParse(oSession.oRequest["Content-Length"], out iLen)) {
					if (iLen > 1000000) {
						oSession["log-drop-request-body"] = "save memory for request";
					}
				}
			}
		}

		
		public override void OnTabStateChange(TabPage tab)
		{
			return ;
		}
		
		public override TabControl.TabPageCollection getTabPages()
		{
			return mainForm.tabsViews.TabPages;
		}
		
		public override ContextMenuStrip getMenuStrip()
		{
			return mainForm.mnuNotify;
		}
		
		public override void SetConfig(string key, string value)
		{
			if (key.StartsWith("HeaderEncoding")) {
				CONFIG.oHeaderEncoding = Encoding.GetEncoding(value);
			}
		}
		
		public override void initCapture()
		{
			Restart();
		}
		
		public override string getAppName()
		{
			return Util.APP_PLINK;
		}
	}
}
