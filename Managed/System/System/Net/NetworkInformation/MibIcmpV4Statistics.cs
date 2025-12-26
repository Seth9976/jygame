using System;
using System.Collections.Specialized;
using System.Globalization;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000378 RID: 888
	internal class MibIcmpV4Statistics : IcmpV4Statistics
	{
		// Token: 0x06001EE2 RID: 7906 RVA: 0x0001666D File Offset: 0x0001486D
		public MibIcmpV4Statistics(global::System.Collections.Specialized.StringDictionary dic)
		{
			this.dic = dic;
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x0001667C File Offset: 0x0001487C
		private long Get(string name)
		{
			return (this.dic[name] == null) ? 0L : long.Parse(this.dic[name], NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x000166AC File Offset: 0x000148AC
		public override long AddressMaskRepliesReceived
		{
			get
			{
				return this.Get("InAddrMaskReps");
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x000166B9 File Offset: 0x000148B9
		public override long AddressMaskRepliesSent
		{
			get
			{
				return this.Get("OutAddrMaskReps");
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x000166C6 File Offset: 0x000148C6
		public override long AddressMaskRequestsReceived
		{
			get
			{
				return this.Get("InAddrMasks");
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x000166D3 File Offset: 0x000148D3
		public override long AddressMaskRequestsSent
		{
			get
			{
				return this.Get("OutAddrMasks");
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x000166E0 File Offset: 0x000148E0
		public override long DestinationUnreachableMessagesReceived
		{
			get
			{
				return this.Get("InDestUnreachs");
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x000166ED File Offset: 0x000148ED
		public override long DestinationUnreachableMessagesSent
		{
			get
			{
				return this.Get("OutDestUnreachs");
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001EEA RID: 7914 RVA: 0x000166FA File Offset: 0x000148FA
		public override long EchoRepliesReceived
		{
			get
			{
				return this.Get("InEchoReps");
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001EEB RID: 7915 RVA: 0x00016707 File Offset: 0x00014907
		public override long EchoRepliesSent
		{
			get
			{
				return this.Get("OutEchoReps");
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001EEC RID: 7916 RVA: 0x00016714 File Offset: 0x00014914
		public override long EchoRequestsReceived
		{
			get
			{
				return this.Get("InEchos");
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001EED RID: 7917 RVA: 0x00016721 File Offset: 0x00014921
		public override long EchoRequestsSent
		{
			get
			{
				return this.Get("OutEchos");
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001EEE RID: 7918 RVA: 0x0001672E File Offset: 0x0001492E
		public override long ErrorsReceived
		{
			get
			{
				return this.Get("InErrors");
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x0001673B File Offset: 0x0001493B
		public override long ErrorsSent
		{
			get
			{
				return this.Get("OutErrors");
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x00016748 File Offset: 0x00014948
		public override long MessagesReceived
		{
			get
			{
				return this.Get("InMsgs");
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x00016755 File Offset: 0x00014955
		public override long MessagesSent
		{
			get
			{
				return this.Get("OutMsgs");
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x00016762 File Offset: 0x00014962
		public override long ParameterProblemsReceived
		{
			get
			{
				return this.Get("InParmProbs");
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x0001676F File Offset: 0x0001496F
		public override long ParameterProblemsSent
		{
			get
			{
				return this.Get("OutParmProbs");
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x0001677C File Offset: 0x0001497C
		public override long RedirectsReceived
		{
			get
			{
				return this.Get("InRedirects");
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x00016789 File Offset: 0x00014989
		public override long RedirectsSent
		{
			get
			{
				return this.Get("OutRedirects");
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x00016796 File Offset: 0x00014996
		public override long SourceQuenchesReceived
		{
			get
			{
				return this.Get("InSrcQuenchs");
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x000167A3 File Offset: 0x000149A3
		public override long SourceQuenchesSent
		{
			get
			{
				return this.Get("OutSrcQuenchs");
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x000167B0 File Offset: 0x000149B0
		public override long TimeExceededMessagesReceived
		{
			get
			{
				return this.Get("InTimeExcds");
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x000167BD File Offset: 0x000149BD
		public override long TimeExceededMessagesSent
		{
			get
			{
				return this.Get("OutTimeExcds");
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x000167CA File Offset: 0x000149CA
		public override long TimestampRepliesReceived
		{
			get
			{
				return this.Get("InTimestampReps");
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001EFB RID: 7931 RVA: 0x000167D7 File Offset: 0x000149D7
		public override long TimestampRepliesSent
		{
			get
			{
				return this.Get("OutTimestampReps");
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x000167E4 File Offset: 0x000149E4
		public override long TimestampRequestsReceived
		{
			get
			{
				return this.Get("InTimestamps");
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001EFD RID: 7933 RVA: 0x000167F1 File Offset: 0x000149F1
		public override long TimestampRequestsSent
		{
			get
			{
				return this.Get("OutTimestamps");
			}
		}

		// Token: 0x040012FD RID: 4861
		private global::System.Collections.Specialized.StringDictionary dic;
	}
}
