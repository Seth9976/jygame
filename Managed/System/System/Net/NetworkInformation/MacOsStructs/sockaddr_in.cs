using System;

namespace System.Net.NetworkInformation.MacOsStructs
{
	// Token: 0x020003AF RID: 943
	internal struct sockaddr_in
	{
		// Token: 0x040013C3 RID: 5059
		public byte sin_len;

		// Token: 0x040013C4 RID: 5060
		public byte sin_family;

		// Token: 0x040013C5 RID: 5061
		public ushort sin_port;

		// Token: 0x040013C6 RID: 5062
		public uint sin_addr;
	}
}
