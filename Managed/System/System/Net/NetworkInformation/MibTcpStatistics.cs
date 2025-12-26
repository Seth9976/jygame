using System;
using System.Collections.Specialized;
using System.Globalization;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003D7 RID: 983
	internal class MibTcpStatistics : TcpStatistics
	{
		// Token: 0x060021A5 RID: 8613 RVA: 0x00017F19 File Offset: 0x00016119
		public MibTcpStatistics(global::System.Collections.Specialized.StringDictionary dic)
		{
			this.dic = dic;
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00017F28 File Offset: 0x00016128
		private long Get(string name)
		{
			return (this.dic[name] == null) ? 0L : long.Parse(this.dic[name], NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00017F58 File Offset: 0x00016158
		public override long ConnectionsAccepted
		{
			get
			{
				return this.Get("PassiveOpens");
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x00017F65 File Offset: 0x00016165
		public override long ConnectionsInitiated
		{
			get
			{
				return this.Get("ActiveOpens");
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x00017F72 File Offset: 0x00016172
		public override long CumulativeConnections
		{
			get
			{
				return this.Get("NumConns");
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x00017F7F File Offset: 0x0001617F
		public override long CurrentConnections
		{
			get
			{
				return this.Get("CurrEstab");
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x00017F8C File Offset: 0x0001618C
		public override long ErrorsReceived
		{
			get
			{
				return this.Get("InErrs");
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x00017F99 File Offset: 0x00016199
		public override long FailedConnectionAttempts
		{
			get
			{
				return this.Get("AttemptFails");
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x00017FA6 File Offset: 0x000161A6
		public override long MaximumConnections
		{
			get
			{
				return this.Get("MaxConn");
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x00017FB3 File Offset: 0x000161B3
		public override long MaximumTransmissionTimeout
		{
			get
			{
				return this.Get("RtoMax");
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x00017FC0 File Offset: 0x000161C0
		public override long MinimumTransmissionTimeout
		{
			get
			{
				return this.Get("RtoMin");
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x00017FCD File Offset: 0x000161CD
		public override long ResetConnections
		{
			get
			{
				return this.Get("EstabResets");
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00017FDA File Offset: 0x000161DA
		public override long ResetsSent
		{
			get
			{
				return this.Get("OutRsts");
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x00017FE7 File Offset: 0x000161E7
		public override long SegmentsReceived
		{
			get
			{
				return this.Get("InSegs");
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x00017FF4 File Offset: 0x000161F4
		public override long SegmentsResent
		{
			get
			{
				return this.Get("RetransSegs");
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x00018001 File Offset: 0x00016201
		public override long SegmentsSent
		{
			get
			{
				return this.Get("OutSegs");
			}
		}

		// Token: 0x04001471 RID: 5233
		private global::System.Collections.Specialized.StringDictionary dic;
	}
}
