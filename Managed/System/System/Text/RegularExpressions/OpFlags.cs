using System;

namespace System.Text.RegularExpressions
{
	// Token: 0x0200047F RID: 1151
	[Flags]
	internal enum OpFlags : ushort
	{
		// Token: 0x0400190F RID: 6415
		None = 0,
		// Token: 0x04001910 RID: 6416
		Negate = 256,
		// Token: 0x04001911 RID: 6417
		IgnoreCase = 512,
		// Token: 0x04001912 RID: 6418
		RightToLeft = 1024,
		// Token: 0x04001913 RID: 6419
		Lazy = 2048
	}
}
