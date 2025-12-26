using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200037E RID: 894
	internal class IcmpV6MessageTypes
	{
		// Token: 0x04001310 RID: 4880
		public const int DestinationUnreachable = 1;

		// Token: 0x04001311 RID: 4881
		public const int PacketTooBig = 2;

		// Token: 0x04001312 RID: 4882
		public const int TimeExceeded = 3;

		// Token: 0x04001313 RID: 4883
		public const int ParameterProblem = 4;

		// Token: 0x04001314 RID: 4884
		public const int EchoRequest = 128;

		// Token: 0x04001315 RID: 4885
		public const int EchoReply = 129;

		// Token: 0x04001316 RID: 4886
		public const int GroupMembershipQuery = 130;

		// Token: 0x04001317 RID: 4887
		public const int GroupMembershipReport = 131;

		// Token: 0x04001318 RID: 4888
		public const int GroupMembershipReduction = 132;

		// Token: 0x04001319 RID: 4889
		public const int RouterSolicitation = 133;

		// Token: 0x0400131A RID: 4890
		public const int RouterAdvertisement = 134;

		// Token: 0x0400131B RID: 4891
		public const int NeighborSolicitation = 135;

		// Token: 0x0400131C RID: 4892
		public const int NeighborAdvertisement = 136;

		// Token: 0x0400131D RID: 4893
		public const int Redirect = 137;

		// Token: 0x0400131E RID: 4894
		public const int RouterRenumbering = 138;
	}
}
