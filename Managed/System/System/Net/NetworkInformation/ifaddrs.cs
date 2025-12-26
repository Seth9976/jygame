using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003A7 RID: 935
	internal struct ifaddrs
	{
		// Token: 0x04001398 RID: 5016
		public IntPtr ifa_next;

		// Token: 0x04001399 RID: 5017
		public string ifa_name;

		// Token: 0x0400139A RID: 5018
		public uint ifa_flags;

		// Token: 0x0400139B RID: 5019
		public IntPtr ifa_addr;

		// Token: 0x0400139C RID: 5020
		public IntPtr ifa_netmask;

		// Token: 0x0400139D RID: 5021
		public ifa_ifu ifa_ifu;

		// Token: 0x0400139E RID: 5022
		public IntPtr ifa_data;
	}
}
