using System;

namespace System.Text.RegularExpressions
{
	// Token: 0x0200047E RID: 1150
	internal enum OpCode : ushort
	{
		// Token: 0x040018F5 RID: 6389
		False,
		// Token: 0x040018F6 RID: 6390
		True,
		// Token: 0x040018F7 RID: 6391
		Position,
		// Token: 0x040018F8 RID: 6392
		String,
		// Token: 0x040018F9 RID: 6393
		Reference,
		// Token: 0x040018FA RID: 6394
		Character,
		// Token: 0x040018FB RID: 6395
		Category,
		// Token: 0x040018FC RID: 6396
		NotCategory,
		// Token: 0x040018FD RID: 6397
		Range,
		// Token: 0x040018FE RID: 6398
		Set,
		// Token: 0x040018FF RID: 6399
		In,
		// Token: 0x04001900 RID: 6400
		Open,
		// Token: 0x04001901 RID: 6401
		Close,
		// Token: 0x04001902 RID: 6402
		Balance,
		// Token: 0x04001903 RID: 6403
		BalanceStart,
		// Token: 0x04001904 RID: 6404
		IfDefined,
		// Token: 0x04001905 RID: 6405
		Sub,
		// Token: 0x04001906 RID: 6406
		Test,
		// Token: 0x04001907 RID: 6407
		Branch,
		// Token: 0x04001908 RID: 6408
		Jump,
		// Token: 0x04001909 RID: 6409
		Repeat,
		// Token: 0x0400190A RID: 6410
		Until,
		// Token: 0x0400190B RID: 6411
		FastRepeat,
		// Token: 0x0400190C RID: 6412
		Anchor,
		// Token: 0x0400190D RID: 6413
		Info
	}
}
