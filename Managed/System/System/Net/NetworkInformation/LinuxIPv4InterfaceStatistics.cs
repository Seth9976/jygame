using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003A2 RID: 930
	internal class LinuxIPv4InterfaceStatistics : IPv4InterfaceStatistics
	{
		// Token: 0x060020A9 RID: 8361 RVA: 0x00017767 File Offset: 0x00015967
		public LinuxIPv4InterfaceStatistics(LinuxNetworkInterface parent)
		{
			this.linux = parent;
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x00060E68 File Offset: 0x0005F068
		private long Read(string file)
		{
			long num;
			try
			{
				num = long.Parse(NetworkInterface.ReadLine(this.linux.IfacePath + file));
			}
			catch
			{
				num = 0L;
			}
			return num;
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x00017776 File Offset: 0x00015976
		public override long BytesReceived
		{
			get
			{
				return this.Read("statistics/rx_bytes");
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x00017783 File Offset: 0x00015983
		public override long BytesSent
		{
			get
			{
				return this.Read("statistics/tx_bytes");
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x00017790 File Offset: 0x00015990
		public override long IncomingPacketsDiscarded
		{
			get
			{
				return this.Read("statistics/rx_dropped");
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x0001779D File Offset: 0x0001599D
		public override long IncomingPacketsWithErrors
		{
			get
			{
				return this.Read("statistics/rx_errors");
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long IncomingUnknownProtocolPackets
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x000177AA File Offset: 0x000159AA
		public override long NonUnicastPacketsReceived
		{
			get
			{
				return this.Read("statistics/multicast");
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x000177AA File Offset: 0x000159AA
		public override long NonUnicastPacketsSent
		{
			get
			{
				return this.Read("statistics/multicast");
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x000177B7 File Offset: 0x000159B7
		public override long OutgoingPacketsDiscarded
		{
			get
			{
				return this.Read("statistics/tx_dropped");
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x000177C4 File Offset: 0x000159C4
		public override long OutgoingPacketsWithErrors
		{
			get
			{
				return this.Read("statistics/tx_errors");
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x000177D1 File Offset: 0x000159D1
		public override long OutputQueueLength
		{
			get
			{
				return 1024L;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x000177D9 File Offset: 0x000159D9
		public override long UnicastPacketsReceived
		{
			get
			{
				return this.Read("statistics/rx_packets");
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x000177E6 File Offset: 0x000159E6
		public override long UnicastPacketsSent
		{
			get
			{
				return this.Read("statistics/tx_packets");
			}
		}

		// Token: 0x04001393 RID: 5011
		private LinuxNetworkInterface linux;
	}
}
