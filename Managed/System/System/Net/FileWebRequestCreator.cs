using System;

namespace System.Net
{
	// Token: 0x02000315 RID: 789
	internal class FileWebRequestCreator : IWebRequestCreate
	{
		// Token: 0x06001ACB RID: 6859 RVA: 0x000021C3 File Offset: 0x000003C3
		internal FileWebRequestCreator()
		{
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00013987 File Offset: 0x00011B87
		public WebRequest Create(global::System.Uri uri)
		{
			return new FileWebRequest(uri);
		}
	}
}
