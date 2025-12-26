using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000379 RID: 889
	internal class Win32IcmpV4Statistics : IcmpV4Statistics
	{
		// Token: 0x06001EFE RID: 7934 RVA: 0x000167FE File Offset: 0x000149FE
		public Win32IcmpV4Statistics(Win32_MIBICMPINFO info)
		{
			this.iin = info.InStats;
			this.iout = info.OutStats;
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x00016820 File Offset: 0x00014A20
		public override long AddressMaskRepliesReceived
		{
			get
			{
				return (long)((ulong)this.iin.AddrMaskReps);
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x0001682E File Offset: 0x00014A2E
		public override long AddressMaskRepliesSent
		{
			get
			{
				return (long)((ulong)this.iout.AddrMaskReps);
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001F01 RID: 7937 RVA: 0x0001683C File Offset: 0x00014A3C
		public override long AddressMaskRequestsReceived
		{
			get
			{
				return (long)((ulong)this.iin.AddrMasks);
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x0001684A File Offset: 0x00014A4A
		public override long AddressMaskRequestsSent
		{
			get
			{
				return (long)((ulong)this.iout.AddrMasks);
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001F03 RID: 7939 RVA: 0x00016858 File Offset: 0x00014A58
		public override long DestinationUnreachableMessagesReceived
		{
			get
			{
				return (long)((ulong)this.iin.DestUnreachs);
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x00016866 File Offset: 0x00014A66
		public override long DestinationUnreachableMessagesSent
		{
			get
			{
				return (long)((ulong)this.iout.DestUnreachs);
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x00016874 File Offset: 0x00014A74
		public override long EchoRepliesReceived
		{
			get
			{
				return (long)((ulong)this.iin.EchoReps);
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x00016882 File Offset: 0x00014A82
		public override long EchoRepliesSent
		{
			get
			{
				return (long)((ulong)this.iout.EchoReps);
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x00016890 File Offset: 0x00014A90
		public override long EchoRequestsReceived
		{
			get
			{
				return (long)((ulong)this.iin.Echos);
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x0001689E File Offset: 0x00014A9E
		public override long EchoRequestsSent
		{
			get
			{
				return (long)((ulong)this.iout.Echos);
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x000168AC File Offset: 0x00014AAC
		public override long ErrorsReceived
		{
			get
			{
				return (long)((ulong)this.iin.Errors);
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x000168BA File Offset: 0x00014ABA
		public override long ErrorsSent
		{
			get
			{
				return (long)((ulong)this.iout.Errors);
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x000168C8 File Offset: 0x00014AC8
		public override long MessagesReceived
		{
			get
			{
				return (long)((ulong)this.iin.Msgs);
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x000168D6 File Offset: 0x00014AD6
		public override long MessagesSent
		{
			get
			{
				return (long)((ulong)this.iout.Msgs);
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x000168E4 File Offset: 0x00014AE4
		public override long ParameterProblemsReceived
		{
			get
			{
				return (long)((ulong)this.iin.ParmProbs);
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x000168F2 File Offset: 0x00014AF2
		public override long ParameterProblemsSent
		{
			get
			{
				return (long)((ulong)this.iout.ParmProbs);
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x00016900 File Offset: 0x00014B00
		public override long RedirectsReceived
		{
			get
			{
				return (long)((ulong)this.iin.Redirects);
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x0001690E File Offset: 0x00014B0E
		public override long RedirectsSent
		{
			get
			{
				return (long)((ulong)this.iout.Redirects);
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x0001691C File Offset: 0x00014B1C
		public override long SourceQuenchesReceived
		{
			get
			{
				return (long)((ulong)this.iin.SrcQuenchs);
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x0001692A File Offset: 0x00014B2A
		public override long SourceQuenchesSent
		{
			get
			{
				return (long)((ulong)this.iout.SrcQuenchs);
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x00016938 File Offset: 0x00014B38
		public override long TimeExceededMessagesReceived
		{
			get
			{
				return (long)((ulong)this.iin.TimeExcds);
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001F14 RID: 7956 RVA: 0x00016946 File Offset: 0x00014B46
		public override long TimeExceededMessagesSent
		{
			get
			{
				return (long)((ulong)this.iout.TimeExcds);
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x00016954 File Offset: 0x00014B54
		public override long TimestampRepliesReceived
		{
			get
			{
				return (long)((ulong)this.iin.TimestampReps);
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x00016962 File Offset: 0x00014B62
		public override long TimestampRepliesSent
		{
			get
			{
				return (long)((ulong)this.iout.TimestampReps);
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x00016970 File Offset: 0x00014B70
		public override long TimestampRequestsReceived
		{
			get
			{
				return (long)((ulong)this.iin.Timestamps);
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x0001697E File Offset: 0x00014B7E
		public override long TimestampRequestsSent
		{
			get
			{
				return (long)((ulong)this.iout.Timestamps);
			}
		}

		// Token: 0x040012FE RID: 4862
		private Win32_MIBICMPSTATS iin;

		// Token: 0x040012FF RID: 4863
		private Win32_MIBICMPSTATS iout;
	}
}
