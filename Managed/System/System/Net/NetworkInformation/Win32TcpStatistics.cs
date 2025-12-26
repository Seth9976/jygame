using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003D8 RID: 984
	internal class Win32TcpStatistics : TcpStatistics
	{
		// Token: 0x060021B5 RID: 8629 RVA: 0x0001800E File Offset: 0x0001620E
		public Win32TcpStatistics(Win32_MIB_TCPSTATS info)
		{
			this.info = info;
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x0001801D File Offset: 0x0001621D
		public override long ConnectionsAccepted
		{
			get
			{
				return (long)((ulong)this.info.PassiveOpens);
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x0001802B File Offset: 0x0001622B
		public override long ConnectionsInitiated
		{
			get
			{
				return (long)((ulong)this.info.ActiveOpens);
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x00018039 File Offset: 0x00016239
		public override long CumulativeConnections
		{
			get
			{
				return (long)((ulong)this.info.NumConns);
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x00018047 File Offset: 0x00016247
		public override long CurrentConnections
		{
			get
			{
				return (long)((ulong)this.info.CurrEstab);
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x00018055 File Offset: 0x00016255
		public override long ErrorsReceived
		{
			get
			{
				return (long)((ulong)this.info.InErrs);
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x00018063 File Offset: 0x00016263
		public override long FailedConnectionAttempts
		{
			get
			{
				return (long)((ulong)this.info.AttemptFails);
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x00018071 File Offset: 0x00016271
		public override long MaximumConnections
		{
			get
			{
				return (long)((ulong)this.info.MaxConn);
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x0001807F File Offset: 0x0001627F
		public override long MaximumTransmissionTimeout
		{
			get
			{
				return (long)((ulong)this.info.RtoMax);
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x0001808D File Offset: 0x0001628D
		public override long MinimumTransmissionTimeout
		{
			get
			{
				return (long)((ulong)this.info.RtoMin);
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x0001809B File Offset: 0x0001629B
		public override long ResetConnections
		{
			get
			{
				return (long)((ulong)this.info.EstabResets);
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x000180A9 File Offset: 0x000162A9
		public override long ResetsSent
		{
			get
			{
				return (long)((ulong)this.info.OutRsts);
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x000180B7 File Offset: 0x000162B7
		public override long SegmentsReceived
		{
			get
			{
				return (long)((ulong)this.info.InSegs);
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x000180C5 File Offset: 0x000162C5
		public override long SegmentsResent
		{
			get
			{
				return (long)((ulong)this.info.RetransSegs);
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x000180D3 File Offset: 0x000162D3
		public override long SegmentsSent
		{
			get
			{
				return (long)((ulong)this.info.OutSegs);
			}
		}

		// Token: 0x04001472 RID: 5234
		private Win32_MIB_TCPSTATS info;
	}
}
