using System;

namespace System.IO.Ports
{
	// Token: 0x020002AD RID: 685
	internal enum SerialSignal
	{
		// Token: 0x04000EDD RID: 3805
		None,
		// Token: 0x04000EDE RID: 3806
		Cd,
		// Token: 0x04000EDF RID: 3807
		Cts,
		// Token: 0x04000EE0 RID: 3808
		Dsr = 4,
		// Token: 0x04000EE1 RID: 3809
		Dtr = 8,
		// Token: 0x04000EE2 RID: 3810
		Rts = 16
	}
}
