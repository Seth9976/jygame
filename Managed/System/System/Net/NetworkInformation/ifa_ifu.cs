using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003A6 RID: 934
	[StructLayout(LayoutKind.Explicit)]
	internal struct ifa_ifu
	{
		// Token: 0x04001396 RID: 5014
		[FieldOffset(0)]
		public IntPtr ifu_broadaddr;

		// Token: 0x04001397 RID: 5015
		[FieldOffset(0)]
		public IntPtr ifu_dstaddr;
	}
}
