using System;

namespace System.Net.NetworkInformation.MacOsStructs
{
	// Token: 0x020003AD RID: 941
	internal struct ifaddrs
	{
		// Token: 0x040013BA RID: 5050
		public IntPtr ifa_next;

		// Token: 0x040013BB RID: 5051
		public string ifa_name;

		// Token: 0x040013BC RID: 5052
		public uint ifa_flags;

		// Token: 0x040013BD RID: 5053
		public IntPtr ifa_addr;

		// Token: 0x040013BE RID: 5054
		public IntPtr ifa_netmask;

		// Token: 0x040013BF RID: 5055
		public IntPtr ifa_dstaddr;

		// Token: 0x040013C0 RID: 5056
		public IntPtr ifa_data;
	}
}
