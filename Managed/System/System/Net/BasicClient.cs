using System;

namespace System.Net
{
	// Token: 0x020002C9 RID: 713
	internal class BasicClient : IAuthenticationModule
	{
		// Token: 0x06001881 RID: 6273 RVA: 0x0004ABCC File Offset: 0x00048DCC
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			if (credentials == null || challenge == null)
			{
				return null;
			}
			string text = challenge.Trim();
			if (text.ToLower().IndexOf("basic") == -1)
			{
				return null;
			}
			return BasicClient.InternalAuthenticate(webRequest, credentials);
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x0004AC10 File Offset: 0x00048E10
		private static byte[] GetBytes(string str)
		{
			int i = str.Length;
			byte[] array = new byte[i];
			for (i--; i >= 0; i--)
			{
				array[i] = (byte)str[i];
			}
			return array;
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0004AC4C File Offset: 0x00048E4C
		private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
			if (httpWebRequest == null || credentials == null)
			{
				return null;
			}
			NetworkCredential credential = credentials.GetCredential(httpWebRequest.AuthUri, "basic");
			if (credential == null)
			{
				return null;
			}
			string userName = credential.UserName;
			if (userName == null || userName == string.Empty)
			{
				return null;
			}
			string password = credential.Password;
			string domain = credential.Domain;
			byte[] array;
			if (domain == null || domain == string.Empty || domain.Trim() == string.Empty)
			{
				array = BasicClient.GetBytes(userName + ":" + password);
			}
			else
			{
				array = BasicClient.GetBytes(string.Concat(new string[] { domain, "\\", userName, ":", password }));
			}
			string text = "Basic " + Convert.ToBase64String(array);
			return new Authorization(text);
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00012253 File Offset: 0x00010453
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			return BasicClient.InternalAuthenticate(webRequest, credentials);
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x0001225C File Offset: 0x0001045C
		public string AuthenticationType
		{
			get
			{
				return "Basic";
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x000025B7 File Offset: 0x000007B7
		public bool CanPreAuthenticate
		{
			get
			{
				return true;
			}
		}
	}
}
