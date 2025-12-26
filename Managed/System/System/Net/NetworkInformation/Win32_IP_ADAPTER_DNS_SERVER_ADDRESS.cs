using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003EB RID: 1003
	internal struct Win32_IP_ADAPTER_DNS_SERVER_ADDRESS
	{
		// Token: 0x040014F0 RID: 5360
		public Win32LengthFlagsUnion LengthFlags;

		// Token: 0x040014F1 RID: 5361
		public IntPtr Next;

		// Token: 0x040014F2 RID: 5362
		public Win32_SOCKET_ADDRESS Address;
	}
}
