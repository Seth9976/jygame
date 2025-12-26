using System;

namespace System.Net.Mail
{
	/// <summary>Specifies the level of access allowed to a Simple Mail Transport Protocol (SMTP) server.</summary>
	// Token: 0x02000356 RID: 854
	public enum SmtpAccess
	{
		/// <summary>No access to an SMTP host.</summary>
		// Token: 0x0400126C RID: 4716
		None,
		/// <summary>Connection to an SMTP host on the default port (port 25).</summary>
		// Token: 0x0400126D RID: 4717
		Connect,
		/// <summary>Connection to an SMTP host on any port.</summary>
		// Token: 0x0400126E RID: 4718
		ConnectToUnrestrictedPort
	}
}
