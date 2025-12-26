using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Provides Internet Control Message Protocol for Internet Protocol version 6 (ICMPv6) statistical data for the local computer.</summary>
	// Token: 0x0200037C RID: 892
	public abstract class IcmpV6Statistics
	{
		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) messages received because of a packet having an unreachable address in its destination.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Destination Unreachable messages received.</returns>
		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001F1A RID: 7962
		public abstract long DestinationUnreachableMessagesReceived { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) messages sent because of a packet having an unreachable address in its destination.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Destination Unreachable messages sent.</returns>
		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001F1B RID: 7963
		public abstract long DestinationUnreachableMessagesSent { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Echo Reply messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of number of ICMP Echo Reply messages received.</returns>
		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001F1C RID: 7964
		public abstract long EchoRepliesReceived { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Echo Reply messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of number of ICMP Echo Reply messages sent.</returns>
		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001F1D RID: 7965
		public abstract long EchoRepliesSent { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Echo Request messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of number of ICMP Echo Request messages received.</returns>
		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001F1E RID: 7966
		public abstract long EchoRequestsReceived { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Echo Request messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of number of ICMP Echo Request messages sent.</returns>
		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001F1F RID: 7967
		public abstract long EchoRequestsSent { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) error messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of ICMP error messages received.</returns>
		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001F20 RID: 7968
		public abstract long ErrorsReceived { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) error messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of ICMP error messages sent.</returns>
		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001F21 RID: 7969
		public abstract long ErrorsSent { get; }

		/// <summary>Gets the number of Internet Group management Protocol (IGMP) Group Membership Query messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Group Membership Query messages received.</returns>
		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001F22 RID: 7970
		public abstract long MembershipQueriesReceived { get; }

		/// <summary>Gets the number of Internet Group management Protocol (IGMP) Group Membership Query messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Group Membership Query messages sent.</returns>
		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001F23 RID: 7971
		public abstract long MembershipQueriesSent { get; }

		/// <summary>Gets the number of Internet Group Management Protocol (IGMP) Group Membership Reduction messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Group Membership Reduction messages received.</returns>
		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001F24 RID: 7972
		public abstract long MembershipReductionsReceived { get; }

		/// <summary>Gets the number of Internet Group Management Protocol (IGMP) Group Membership Reduction messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Group Membership Reduction messages sent.</returns>
		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001F25 RID: 7973
		public abstract long MembershipReductionsSent { get; }

		/// <summary>Gets the number of Internet Group Management Protocol (IGMP) Group Membership Report messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Group Membership Report messages received.</returns>
		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001F26 RID: 7974
		public abstract long MembershipReportsReceived { get; }

		/// <summary>Gets the number of Internet Group Management Protocol (IGMP) Group Membership Report messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Group Membership Report messages sent.</returns>
		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001F27 RID: 7975
		public abstract long MembershipReportsSent { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of ICMPv6 messages received.</returns>
		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001F28 RID: 7976
		public abstract long MessagesReceived { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of ICMPv6 messages sent.</returns>
		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001F29 RID: 7977
		public abstract long MessagesSent { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Neighbor Advertisement messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of ICMP Neighbor Advertisement messages received.</returns>
		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001F2A RID: 7978
		public abstract long NeighborAdvertisementsReceived { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Neighbor Advertisement messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Neighbor Advertisement messages sent.</returns>
		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001F2B RID: 7979
		public abstract long NeighborAdvertisementsSent { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Neighbor Solicitation messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Neighbor Solicitation messages received.</returns>
		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001F2C RID: 7980
		public abstract long NeighborSolicitsReceived { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Neighbor Solicitation messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Neighbor Solicitation messages sent.</returns>
		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001F2D RID: 7981
		public abstract long NeighborSolicitsSent { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Packet Too Big messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of ICMP Packet Too Big messages received.</returns>
		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001F2E RID: 7982
		public abstract long PacketTooBigMessagesReceived { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Packet Too Big messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of ICMP Packet Too Big messages sent.</returns>
		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001F2F RID: 7983
		public abstract long PacketTooBigMessagesSent { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Parameter Problem messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of ICMP Parameter Problem messages received.</returns>
		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001F30 RID: 7984
		public abstract long ParameterProblemsReceived { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Parameter Problem messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of ICMP Parameter Problem messages sent.</returns>
		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001F31 RID: 7985
		public abstract long ParameterProblemsSent { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Redirect messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of ICMP Redirect messages received.</returns>
		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001F32 RID: 7986
		public abstract long RedirectsReceived { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Redirect messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of ICMP Redirect messages sent.</returns>
		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001F33 RID: 7987
		public abstract long RedirectsSent { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Router Advertisement messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Router Advertisement messages received.</returns>
		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001F34 RID: 7988
		public abstract long RouterAdvertisementsReceived { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Router Advertisement messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Router Advertisement messages sent.</returns>
		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001F35 RID: 7989
		public abstract long RouterAdvertisementsSent { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Router Solicitation messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Router Solicitation messages received.</returns>
		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001F36 RID: 7990
		public abstract long RouterSolicitsReceived { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Router Solicitation messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of Router Solicitation messages sent.</returns>
		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001F37 RID: 7991
		public abstract long RouterSolicitsSent { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Time Exceeded messages received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of ICMP Time Exceeded messages received.</returns>
		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001F38 RID: 7992
		public abstract long TimeExceededMessagesReceived { get; }

		/// <summary>Gets the number of Internet Control Message Protocol version 6 (ICMPv6) Time Exceeded messages sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of ICMP Time Exceeded messages sent.</returns>
		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001F39 RID: 7993
		public abstract long TimeExceededMessagesSent { get; }
	}
}
