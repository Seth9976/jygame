using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003A8 RID: 936
	internal struct sockaddr_in
	{
		// Token: 0x0400139F RID: 5023
		public ushort sin_family;

		// Token: 0x040013A0 RID: 5024
		public ushort sin_port;

		// Token: 0x040013A1 RID: 5025
		public uint sin_addr;
	}
}
