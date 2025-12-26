using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003E8 RID: 1000
	internal struct Win32_IP_ADDR_STRING
	{
		// Token: 0x040014E5 RID: 5349
		public IntPtr Next;

		// Token: 0x040014E6 RID: 5350
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string IpAddress;

		// Token: 0x040014E7 RID: 5351
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string IpMask;

		// Token: 0x040014E8 RID: 5352
		public uint Context;
	}
}
