using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003EA RID: 1002
	internal struct Win32_IP_ADAPTER_ANYCAST_ADDRESS
	{
		// Token: 0x040014ED RID: 5357
		public Win32LengthFlagsUnion LengthFlags;

		// Token: 0x040014EE RID: 5358
		public IntPtr Next;

		// Token: 0x040014EF RID: 5359
		public Win32_SOCKET_ADDRESS Address;
	}
}
