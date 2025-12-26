using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003AB RID: 939
	internal struct sockaddr_ll
	{
		// Token: 0x040013A8 RID: 5032
		public ushort sll_family;

		// Token: 0x040013A9 RID: 5033
		public ushort sll_protocol;

		// Token: 0x040013AA RID: 5034
		public int sll_ifindex;

		// Token: 0x040013AB RID: 5035
		public ushort sll_hatype;

		// Token: 0x040013AC RID: 5036
		public byte sll_pkttype;

		// Token: 0x040013AD RID: 5037
		public byte sll_halen;

		// Token: 0x040013AE RID: 5038
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] sll_addr;
	}
}
