using System;
using Mono.Http;

namespace System.Net
{
	// Token: 0x020003F0 RID: 1008
	internal class NtlmClient : IAuthenticationModule
	{
		// Token: 0x06002211 RID: 8721 RVA: 0x000183CF File Offset: 0x000165CF
		public NtlmClient()
		{
			this.authObject = new Mono.Http.NtlmClient();
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x000183E2 File Offset: 0x000165E2
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			if (this.authObject == null)
			{
				return null;
			}
			return this.authObject.Authenticate(challenge, webRequest, credentials);
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00002A97 File Offset: 0x00000C97
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x00002A9A File Offset: 0x00000C9A
		public string AuthenticationType
		{
			get
			{
				return "NTLM";
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public bool CanPreAuthenticate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04001505 RID: 5381
		private IAuthenticationModule authObject;
	}
}
