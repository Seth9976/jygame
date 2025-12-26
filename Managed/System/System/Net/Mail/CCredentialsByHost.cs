using System;

namespace System.Net.Mail
{
	// Token: 0x0200035D RID: 861
	internal class CCredentialsByHost : ICredentialsByHost
	{
		// Token: 0x06001E41 RID: 7745 RVA: 0x00015E3E File Offset: 0x0001403E
		public CCredentialsByHost(string userName, string password)
		{
			this.userName = userName;
			this.password = password;
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00015E54 File Offset: 0x00014054
		public NetworkCredential GetCredential(string host, int port, string authenticationType)
		{
			return new NetworkCredential(this.userName, this.password);
		}

		// Token: 0x040012A0 RID: 4768
		private string userName;

		// Token: 0x040012A1 RID: 4769
		private string password;
	}
}
