using System;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000480 RID: 1152
	internal enum Position : ushort
	{
		// Token: 0x04001915 RID: 6421
		Any,
		// Token: 0x04001916 RID: 6422
		Start,
		// Token: 0x04001917 RID: 6423
		StartOfString,
		// Token: 0x04001918 RID: 6424
		StartOfLine,
		// Token: 0x04001919 RID: 6425
		StartOfScan,
		// Token: 0x0400191A RID: 6426
		End,
		// Token: 0x0400191B RID: 6427
		EndOfString,
		// Token: 0x0400191C RID: 6428
		EndOfLine,
		// Token: 0x0400191D RID: 6429
		Boundary,
		// Token: 0x0400191E RID: 6430
		NonBoundary
	}
}
