using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000393 RID: 915
	internal struct Win32_MIB_IPSTATS
	{
		// Token: 0x0400134E RID: 4942
		public int Forwarding;

		// Token: 0x0400134F RID: 4943
		public int DefaultTTL;

		// Token: 0x04001350 RID: 4944
		public uint InReceives;

		// Token: 0x04001351 RID: 4945
		public uint InHdrErrors;

		// Token: 0x04001352 RID: 4946
		public uint InAddrErrors;

		// Token: 0x04001353 RID: 4947
		public uint ForwDatagrams;

		// Token: 0x04001354 RID: 4948
		public uint InUnknownProtos;

		// Token: 0x04001355 RID: 4949
		public uint InDiscards;

		// Token: 0x04001356 RID: 4950
		public uint InDelivers;

		// Token: 0x04001357 RID: 4951
		public uint OutRequests;

		// Token: 0x04001358 RID: 4952
		public uint RoutingDiscards;

		// Token: 0x04001359 RID: 4953
		public uint OutDiscards;

		// Token: 0x0400135A RID: 4954
		public uint OutNoRoutes;

		// Token: 0x0400135B RID: 4955
		public uint ReasmTimeout;

		// Token: 0x0400135C RID: 4956
		public uint ReasmReqds;

		// Token: 0x0400135D RID: 4957
		public uint ReasmOks;

		// Token: 0x0400135E RID: 4958
		public uint ReasmFails;

		// Token: 0x0400135F RID: 4959
		public uint FragOks;

		// Token: 0x04001360 RID: 4960
		public uint FragFails;

		// Token: 0x04001361 RID: 4961
		public uint FragCreates;

		// Token: 0x04001362 RID: 4962
		public int NumIf;

		// Token: 0x04001363 RID: 4963
		public int NumAddr;

		// Token: 0x04001364 RID: 4964
		public int NumRoutes;
	}
}
