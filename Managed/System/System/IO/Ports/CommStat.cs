using System;
using System.Runtime.InteropServices;

namespace System.IO.Ports
{
	// Token: 0x020002B2 RID: 690
	[StructLayout(LayoutKind.Sequential)]
	internal class CommStat
	{
		// Token: 0x04000F22 RID: 3874
		public uint flags;

		// Token: 0x04000F23 RID: 3875
		public uint BytesIn;

		// Token: 0x04000F24 RID: 3876
		public uint BytesOut;
	}
}
