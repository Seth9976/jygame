using System;

namespace System.Net.NetworkInformation.MacOsStructs
{
	// Token: 0x020003B1 RID: 945
	internal struct sockaddr_in6
	{
		// Token: 0x040013C8 RID: 5064
		public byte sin6_len;

		// Token: 0x040013C9 RID: 5065
		public byte sin6_family;

		// Token: 0x040013CA RID: 5066
		public ushort sin6_port;

		// Token: 0x040013CB RID: 5067
		public uint sin6_flowinfo;

		// Token: 0x040013CC RID: 5068
		public in6_addr sin6_addr;

		// Token: 0x040013CD RID: 5069
		public uint sin6_scope_id;
	}
}
