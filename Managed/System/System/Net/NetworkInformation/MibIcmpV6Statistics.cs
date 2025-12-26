using System;
using System.Collections.Specialized;
using System.Globalization;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200037D RID: 893
	internal class MibIcmpV6Statistics : IcmpV6Statistics
	{
		// Token: 0x06001F3A RID: 7994 RVA: 0x0001698C File Offset: 0x00014B8C
		public MibIcmpV6Statistics(global::System.Collections.Specialized.StringDictionary dic)
		{
			this.dic = dic;
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x0001699B File Offset: 0x00014B9B
		private long Get(string name)
		{
			return (this.dic[name] == null) ? 0L : long.Parse(this.dic[name], NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x000169CB File Offset: 0x00014BCB
		public override long DestinationUnreachableMessagesReceived
		{
			get
			{
				return this.Get("InDestUnreachs");
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x000169D8 File Offset: 0x00014BD8
		public override long DestinationUnreachableMessagesSent
		{
			get
			{
				return this.Get("OutDestUnreachs");
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x000169E5 File Offset: 0x00014BE5
		public override long EchoRepliesReceived
		{
			get
			{
				return this.Get("InEchoReplies");
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x000169F2 File Offset: 0x00014BF2
		public override long EchoRepliesSent
		{
			get
			{
				return this.Get("OutEchoReplies");
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x000169FF File Offset: 0x00014BFF
		public override long EchoRequestsReceived
		{
			get
			{
				return this.Get("InEchos");
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x00016A0C File Offset: 0x00014C0C
		public override long EchoRequestsSent
		{
			get
			{
				return this.Get("OutEchos");
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x00016A19 File Offset: 0x00014C19
		public override long ErrorsReceived
		{
			get
			{
				return this.Get("InErrors");
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001F43 RID: 8003 RVA: 0x00016A26 File Offset: 0x00014C26
		public override long ErrorsSent
		{
			get
			{
				return this.Get("OutErrors");
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x00016A33 File Offset: 0x00014C33
		public override long MembershipQueriesReceived
		{
			get
			{
				return this.Get("InGroupMembQueries");
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x00016A40 File Offset: 0x00014C40
		public override long MembershipQueriesSent
		{
			get
			{
				return this.Get("OutGroupMembQueries");
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x00016A4D File Offset: 0x00014C4D
		public override long MembershipReductionsReceived
		{
			get
			{
				return this.Get("InGroupMembReductiions");
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x00016A5A File Offset: 0x00014C5A
		public override long MembershipReductionsSent
		{
			get
			{
				return this.Get("OutGroupMembReductiions");
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001F48 RID: 8008 RVA: 0x00016A67 File Offset: 0x00014C67
		public override long MembershipReportsReceived
		{
			get
			{
				return this.Get("InGroupMembRespons");
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x00016A74 File Offset: 0x00014C74
		public override long MembershipReportsSent
		{
			get
			{
				return this.Get("OutGroupMembRespons");
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x00016A81 File Offset: 0x00014C81
		public override long MessagesReceived
		{
			get
			{
				return this.Get("InMsgs");
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x00016A8E File Offset: 0x00014C8E
		public override long MessagesSent
		{
			get
			{
				return this.Get("OutMsgs");
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001F4C RID: 8012 RVA: 0x00016A9B File Offset: 0x00014C9B
		public override long NeighborAdvertisementsReceived
		{
			get
			{
				return this.Get("InNeighborAdvertisements");
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x00016AA8 File Offset: 0x00014CA8
		public override long NeighborAdvertisementsSent
		{
			get
			{
				return this.Get("OutNeighborAdvertisements");
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x00016AB5 File Offset: 0x00014CB5
		public override long NeighborSolicitsReceived
		{
			get
			{
				return this.Get("InNeighborSolicits");
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x00016AC2 File Offset: 0x00014CC2
		public override long NeighborSolicitsSent
		{
			get
			{
				return this.Get("OutNeighborSolicits");
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x00016ACF File Offset: 0x00014CCF
		public override long PacketTooBigMessagesReceived
		{
			get
			{
				return this.Get("InPktTooBigs");
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x00016ADC File Offset: 0x00014CDC
		public override long PacketTooBigMessagesSent
		{
			get
			{
				return this.Get("OutPktTooBigs");
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x00016AE9 File Offset: 0x00014CE9
		public override long ParameterProblemsReceived
		{
			get
			{
				return this.Get("InParmProblems");
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x00016AF6 File Offset: 0x00014CF6
		public override long ParameterProblemsSent
		{
			get
			{
				return this.Get("OutParmProblems");
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001F54 RID: 8020 RVA: 0x00016B03 File Offset: 0x00014D03
		public override long RedirectsReceived
		{
			get
			{
				return this.Get("InRedirects");
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x00016B10 File Offset: 0x00014D10
		public override long RedirectsSent
		{
			get
			{
				return this.Get("OutRedirects");
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x00016B1D File Offset: 0x00014D1D
		public override long RouterAdvertisementsReceived
		{
			get
			{
				return this.Get("InRouterAdvertisements");
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x00016B2A File Offset: 0x00014D2A
		public override long RouterAdvertisementsSent
		{
			get
			{
				return this.Get("OutRouterAdvertisements");
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001F58 RID: 8024 RVA: 0x00016B37 File Offset: 0x00014D37
		public override long RouterSolicitsReceived
		{
			get
			{
				return this.Get("InRouterSolicits");
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x00016B44 File Offset: 0x00014D44
		public override long RouterSolicitsSent
		{
			get
			{
				return this.Get("OutRouterSolicits");
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x00016B51 File Offset: 0x00014D51
		public override long TimeExceededMessagesReceived
		{
			get
			{
				return this.Get("InTimeExcds");
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x00016B5E File Offset: 0x00014D5E
		public override long TimeExceededMessagesSent
		{
			get
			{
				return this.Get("OutTimeExcds");
			}
		}

		// Token: 0x0400130F RID: 4879
		private global::System.Collections.Specialized.StringDictionary dic;
	}
}
