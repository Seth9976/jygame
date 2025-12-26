using System;
using System.Collections;

namespace System.Net
{
	// Token: 0x02000308 RID: 776
	internal class DigestClient : IAuthenticationModule
	{
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0004EDE8 File Offset: 0x0004CFE8
		private static Hashtable Cache
		{
			get
			{
				object syncRoot = DigestClient.cache.SyncRoot;
				lock (syncRoot)
				{
					DigestClient.CheckExpired(DigestClient.cache.Count);
				}
				return DigestClient.cache;
			}
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x0004EE38 File Offset: 0x0004D038
		private static void CheckExpired(int count)
		{
			if (count < 10)
			{
				return;
			}
			DateTime dateTime = DateTime.MaxValue;
			DateTime now = DateTime.Now;
			ArrayList arrayList = null;
			foreach (object obj in DigestClient.cache.Keys)
			{
				int num = (int)obj;
				DigestSession digestSession = (DigestSession)DigestClient.cache[num];
				if (digestSession.LastUse < dateTime && (digestSession.LastUse - now).Ticks > 6000000000L)
				{
					dateTime = digestSession.LastUse;
					if (arrayList == null)
					{
						arrayList = new ArrayList();
					}
					arrayList.Add(num);
				}
			}
			if (arrayList != null)
			{
				foreach (object obj2 in arrayList)
				{
					int num2 = (int)obj2;
					DigestClient.cache.Remove(num2);
				}
			}
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x0004EF8C File Offset: 0x0004D18C
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			if (credentials == null || challenge == null)
			{
				return null;
			}
			string text = challenge.Trim();
			if (text.ToLower().IndexOf("digest") == -1)
			{
				return null;
			}
			HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
			if (httpWebRequest == null)
			{
				return null;
			}
			int num = httpWebRequest.Address.GetHashCode() ^ credentials.GetHashCode();
			DigestSession digestSession = (DigestSession)DigestClient.Cache[num];
			bool flag = digestSession == null;
			if (flag)
			{
				digestSession = new DigestSession();
			}
			if (!digestSession.Parse(challenge))
			{
				return null;
			}
			if (flag)
			{
				DigestClient.Cache.Add(num, digestSession);
			}
			return digestSession.Authenticate(webRequest, credentials);
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x0004F040 File Offset: 0x0004D240
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
			if (httpWebRequest == null)
			{
				return null;
			}
			if (credentials == null)
			{
				return null;
			}
			int num = httpWebRequest.Address.GetHashCode() ^ credentials.GetHashCode();
			DigestSession digestSession = (DigestSession)DigestClient.Cache[num];
			if (digestSession == null)
			{
				return null;
			}
			return digestSession.Authenticate(webRequest, credentials);
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00013844 File Offset: 0x00011A44
		public string AuthenticationType
		{
			get
			{
				return "Digest";
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x000025B7 File Offset: 0x000007B7
		public bool CanPreAuthenticate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0400105D RID: 4189
		private static readonly Hashtable cache = Hashtable.Synchronized(new Hashtable());
	}
}
