using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003DD RID: 989
	internal struct Win32_MIB_UDPSTATS
	{
		// Token: 0x04001484 RID: 5252
		public uint InDatagrams;

		// Token: 0x04001485 RID: 5253
		public uint NoPorts;

		// Token: 0x04001486 RID: 5254
		public uint InErrors;

		// Token: 0x04001487 RID: 5255
		public uint OutDatagrams;

		// Token: 0x04001488 RID: 5256
		public int NumAddrs;
	}
}
