using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200037F RID: 895
	internal class Win32IcmpV6Statistics : IcmpV6Statistics
	{
		// Token: 0x06001F5D RID: 8029 RVA: 0x00016B6B File Offset: 0x00014D6B
		public Win32IcmpV6Statistics(Win32_MIB_ICMP_EX info)
		{
			this.iin = info.InStats;
			this.iout = info.OutStats;
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001F5E RID: 8030 RVA: 0x00016B8D File Offset: 0x00014D8D
		public override long DestinationUnreachableMessagesReceived
		{
			get
			{
				return (long)((ulong)this.iin.Counts[1]);
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x00016B9D File Offset: 0x00014D9D
		public override long DestinationUnreachableMessagesSent
		{
			get
			{
				return (long)((ulong)this.iout.Counts[1]);
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x00016BAD File Offset: 0x00014DAD
		public override long EchoRepliesReceived
		{
			get
			{
				return (long)((ulong)this.iin.Counts[129]);
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x00016BC1 File Offset: 0x00014DC1
		public override long EchoRepliesSent
		{
			get
			{
				return (long)((ulong)this.iout.Counts[129]);
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x00016BD5 File Offset: 0x00014DD5
		public override long EchoRequestsReceived
		{
			get
			{
				return (long)((ulong)this.iin.Counts[128]);
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x00016BE9 File Offset: 0x00014DE9
		public override long EchoRequestsSent
		{
			get
			{
				return (long)((ulong)this.iout.Counts[128]);
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x00016BFD File Offset: 0x00014DFD
		public override long ErrorsReceived
		{
			get
			{
				return (long)((ulong)this.iin.Errors);
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x00016C0B File Offset: 0x00014E0B
		public override long ErrorsSent
		{
			get
			{
				return (long)((ulong)this.iout.Errors);
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x00016C19 File Offset: 0x00014E19
		public override long MembershipQueriesReceived
		{
			get
			{
				return (long)((ulong)this.iin.Counts[130]);
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001F67 RID: 8039 RVA: 0x00016C2D File Offset: 0x00014E2D
		public override long MembershipQueriesSent
		{
			get
			{
				return (long)((ulong)this.iout.Counts[130]);
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x00016C41 File Offset: 0x00014E41
		public override long MembershipReductionsReceived
		{
			get
			{
				return (long)((ulong)this.iin.Counts[132]);
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001F69 RID: 8041 RVA: 0x00016C55 File Offset: 0x00014E55
		public override long MembershipReductionsSent
		{
			get
			{
				return (long)((ulong)this.iout.Counts[132]);
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x00016C69 File Offset: 0x00014E69
		public override long MembershipReportsReceived
		{
			get
			{
				return (long)((ulong)this.iin.Counts[131]);
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x00016C7D File Offset: 0x00014E7D
		public override long MembershipReportsSent
		{
			get
			{
				return (long)((ulong)this.iout.Counts[131]);
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x00016C91 File Offset: 0x00014E91
		public override long MessagesReceived
		{
			get
			{
				return (long)((ulong)this.iin.Msgs);
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x00016C9F File Offset: 0x00014E9F
		public override long MessagesSent
		{
			get
			{
				return (long)((ulong)this.iout.Msgs);
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x00016CAD File Offset: 0x00014EAD
		public override long NeighborAdvertisementsReceived
		{
			get
			{
				return (long)((ulong)this.iin.Counts[136]);
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x00016CC1 File Offset: 0x00014EC1
		public override long NeighborAdvertisementsSent
		{
			get
			{
				return (long)((ulong)this.iout.Counts[136]);
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x00016CD5 File Offset: 0x00014ED5
		public override long NeighborSolicitsReceived
		{
			get
			{
				return (long)((ulong)this.iin.Counts[135]);
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x00016CE9 File Offset: 0x00014EE9
		public override long NeighborSolicitsSent
		{
			get
			{
				return (long)((ulong)this.iout.Counts[135]);
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001F72 RID: 8050 RVA: 0x00016CFD File Offset: 0x00014EFD
		public override long PacketTooBigMessagesReceived
		{
			get
			{
				return (long)((ulong)this.iin.Counts[2]);
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x00016D0D File Offset: 0x00014F0D
		public override long PacketTooBigMessagesSent
		{
			get
			{
				return (long)((ulong)this.iout.Counts[2]);
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x00016D1D File Offset: 0x00014F1D
		public override long ParameterProblemsReceived
		{
			get
			{
				return (long)((ulong)this.iin.Counts[4]);
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x00016D2D File Offset: 0x00014F2D
		public override long ParameterProblemsSent
		{
			get
			{
				return (long)((ulong)this.iout.Counts[4]);
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001F76 RID: 8054 RVA: 0x00016D3D File Offset: 0x00014F3D
		public override long RedirectsReceived
		{
			get
			{
				return (long)((ulong)this.iin.Counts[137]);
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x00016D51 File Offset: 0x00014F51
		public override long RedirectsSent
		{
			get
			{
				return (long)((ulong)this.iout.Counts[137]);
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x00016D65 File Offset: 0x00014F65
		public override long RouterAdvertisementsReceived
		{
			get
			{
				return (long)((ulong)this.iin.Counts[134]);
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x00016D79 File Offset: 0x00014F79
		public override long RouterAdvertisementsSent
		{
			get
			{
				return (long)((ulong)this.iout.Counts[134]);
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x00016D8D File Offset: 0x00014F8D
		public override long RouterSolicitsReceived
		{
			get
			{
				return (long)((ulong)this.iin.Counts[133]);
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x00016DA1 File Offset: 0x00014FA1
		public override long RouterSolicitsSent
		{
			get
			{
				return (long)((ulong)this.iout.Counts[133]);
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x00016DB5 File Offset: 0x00014FB5
		public override long TimeExceededMessagesReceived
		{
			get
			{
				return (long)((ulong)this.iin.Counts[3]);
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x00016DC5 File Offset: 0x00014FC5
		public override long TimeExceededMessagesSent
		{
			get
			{
				return (long)((ulong)this.iout.Counts[3]);
			}
		}

		// Token: 0x0400131F RID: 4895
		private Win32_MIBICMPSTATS_EX iin;

		// Token: 0x04001320 RID: 4896
		private Win32_MIBICMPSTATS_EX iout;
	}
}
