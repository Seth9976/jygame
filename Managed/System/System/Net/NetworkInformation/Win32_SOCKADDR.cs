using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003EE RID: 1006
	internal struct Win32_SOCKADDR
	{
		// Token: 0x04001500 RID: 5376
		public ushort AddressFamily;

		// Token: 0x04001501 RID: 5377
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
		public byte[] AddressData;
	}
}
