using System;

namespace System
{
	// Token: 0x020004F5 RID: 1269
	internal interface IUriData
	{
		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002C78 RID: 11384
		string AbsolutePath { get; }

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002C79 RID: 11385
		string AbsoluteUri { get; }

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002C7A RID: 11386
		string AbsoluteUri_SafeUnescaped { get; }

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002C7B RID: 11387
		string Authority { get; }

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002C7C RID: 11388
		string Fragment { get; }

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002C7D RID: 11389
		string Host { get; }

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002C7E RID: 11390
		string PathAndQuery { get; }

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002C7F RID: 11391
		string StrongPort { get; }

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002C80 RID: 11392
		string Query { get; }

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002C81 RID: 11393
		string UserInfo { get; }
	}
}
