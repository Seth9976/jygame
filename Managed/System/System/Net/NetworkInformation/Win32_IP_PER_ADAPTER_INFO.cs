using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200039F RID: 927
	[StructLayout(LayoutKind.Sequential)]
	internal class Win32_IP_PER_ADAPTER_INFO
	{
		// Token: 0x0400138E RID: 5006
		public uint AutoconfigEnabled;

		// Token: 0x0400138F RID: 5007
		public uint AutoconfigActive;

		// Token: 0x04001390 RID: 5008
		public IntPtr CurrentDnsServer;

		// Token: 0x04001391 RID: 5009
		public Win32_IP_ADDR_STRING DnsServerList;
	}
}
