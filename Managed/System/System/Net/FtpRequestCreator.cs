using System;

namespace System.Net
{
	// Token: 0x0200031F RID: 799
	internal class FtpRequestCreator : IWebRequestCreate
	{
		// Token: 0x06001B3B RID: 6971 RVA: 0x00013CB9 File Offset: 0x00011EB9
		public WebRequest Create(global::System.Uri uri)
		{
			return new FtpWebRequest(uri);
		}
	}
}
