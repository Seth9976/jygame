using System;

namespace System.Net
{
	// Token: 0x02000331 RID: 817
	internal class HttpRequestCreator : IWebRequestCreate
	{
		// Token: 0x06001C56 RID: 7254 RVA: 0x000021C3 File Offset: 0x000003C3
		internal HttpRequestCreator()
		{
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00014957 File Offset: 0x00012B57
		public WebRequest Create(global::System.Uri uri)
		{
			return new HttpWebRequest(uri);
		}
	}
}
