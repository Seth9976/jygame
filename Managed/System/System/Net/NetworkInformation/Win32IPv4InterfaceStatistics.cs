using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003A1 RID: 929
	internal class Win32IPv4InterfaceStatistics : IPv4InterfaceStatistics
	{
		// Token: 0x0600209C RID: 8348 RVA: 0x000176B0 File Offset: 0x000158B0
		public Win32IPv4InterfaceStatistics(Win32_MIB_IFROW info)
		{
			this.info = info;
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x000176BF File Offset: 0x000158BF
		public override long BytesReceived
		{
			get
			{
				return (long)this.info.InOctets;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x000176CD File Offset: 0x000158CD
		public override long BytesSent
		{
			get
			{
				return (long)this.info.OutOctets;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x000176DB File Offset: 0x000158DB
		public override long IncomingPacketsDiscarded
		{
			get
			{
				return (long)this.info.InDiscards;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x000176E9 File Offset: 0x000158E9
		public override long IncomingPacketsWithErrors
		{
			get
			{
				return (long)this.info.InErrors;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x000176F7 File Offset: 0x000158F7
		public override long IncomingUnknownProtocolPackets
		{
			get
			{
				return (long)this.info.InUnknownProtos;
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x00017705 File Offset: 0x00015905
		public override long NonUnicastPacketsReceived
		{
			get
			{
				return (long)this.info.InNUcastPkts;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x00017713 File Offset: 0x00015913
		public override long NonUnicastPacketsSent
		{
			get
			{
				return (long)this.info.OutNUcastPkts;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x00017721 File Offset: 0x00015921
		public override long OutgoingPacketsDiscarded
		{
			get
			{
				return (long)this.info.OutDiscards;
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x0001772F File Offset: 0x0001592F
		public override long OutgoingPacketsWithErrors
		{
			get
			{
				return (long)this.info.OutErrors;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x0001773D File Offset: 0x0001593D
		public override long OutputQueueLength
		{
			get
			{
				return (long)this.info.OutQLen;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x0001774B File Offset: 0x0001594B
		public override long UnicastPacketsReceived
		{
			get
			{
				return (long)this.info.InUcastPkts;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x00017759 File Offset: 0x00015959
		public override long UnicastPacketsSent
		{
			get
			{
				return (long)this.info.OutUcastPkts;
			}
		}

		// Token: 0x04001392 RID: 5010
		private Win32_MIB_IFROW info;
	}
}
