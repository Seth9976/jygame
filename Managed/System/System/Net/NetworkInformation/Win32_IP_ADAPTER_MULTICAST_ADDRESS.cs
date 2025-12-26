using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003EC RID: 1004
	internal struct Win32_IP_ADAPTER_MULTICAST_ADDRESS
	{
		// Token: 0x040014F3 RID: 5363
		public Win32LengthFlagsUnion LengthFlags;

		// Token: 0x040014F4 RID: 5364
		public IntPtr Next;

		// Token: 0x040014F5 RID: 5365
		public Win32_SOCKET_ADDRESS Address;
	}
}
