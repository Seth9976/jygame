using System;
using System.IO;

namespace System.Net
{
	// Token: 0x02000430 RID: 1072
	internal class WebConnectionData
	{
		// Token: 0x060025EA RID: 9706 RVA: 0x0001A9B5 File Offset: 0x00018BB5
		public void Init()
		{
			this.request = null;
			this.StatusCode = 0;
			this.StatusDescription = null;
			this.Headers = null;
			this.stream = null;
		}

		// Token: 0x0400174A RID: 5962
		public HttpWebRequest request;

		// Token: 0x0400174B RID: 5963
		public int StatusCode;

		// Token: 0x0400174C RID: 5964
		public string StatusDescription;

		// Token: 0x0400174D RID: 5965
		public WebHeaderCollection Headers;

		// Token: 0x0400174E RID: 5966
		public Version Version;

		// Token: 0x0400174F RID: 5967
		public Stream stream;

		// Token: 0x04001750 RID: 5968
		public string Challenge;
	}
}
