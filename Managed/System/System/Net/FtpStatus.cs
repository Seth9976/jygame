using System;

namespace System.Net
{
	// Token: 0x02000323 RID: 803
	internal class FtpStatus
	{
		// Token: 0x06001B94 RID: 7060 RVA: 0x00014051 File Offset: 0x00012251
		public FtpStatus(FtpStatusCode statusCode, string statusDescription)
		{
			this.statusCode = statusCode;
			this.statusDescription = statusDescription;
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x00014067 File Offset: 0x00012267
		public FtpStatusCode StatusCode
		{
			get
			{
				return this.statusCode;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x0001406F File Offset: 0x0001226F
		public string StatusDescription
		{
			get
			{
				return this.statusDescription;
			}
		}

		// Token: 0x040010EF RID: 4335
		private readonly FtpStatusCode statusCode;

		// Token: 0x040010F0 RID: 4336
		private readonly string statusDescription;
	}
}
