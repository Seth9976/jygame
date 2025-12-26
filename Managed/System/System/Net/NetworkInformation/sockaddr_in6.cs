using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003A9 RID: 937
	internal struct sockaddr_in6
	{
		// Token: 0x040013A2 RID: 5026
		public ushort sin6_family;

		// Token: 0x040013A3 RID: 5027
		public ushort sin6_port;

		// Token: 0x040013A4 RID: 5028
		public uint sin6_flowinfo;

		// Token: 0x040013A5 RID: 5029
		public in6_addr sin6_addr;

		// Token: 0x040013A6 RID: 5030
		public uint sin6_scope_id;
	}
}
