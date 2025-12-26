using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000381 RID: 897
	internal struct Win32_MIBICMPSTATS_EX
	{
		// Token: 0x04001323 RID: 4899
		public uint Msgs;

		// Token: 0x04001324 RID: 4900
		public uint Errors;

		// Token: 0x04001325 RID: 4901
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public uint[] Counts;
	}
}
