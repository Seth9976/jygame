using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003A3 RID: 931
	internal class MacOsIPv4InterfaceStatistics : IPv4InterfaceStatistics
	{
		// Token: 0x060020B7 RID: 8375 RVA: 0x000177F3 File Offset: 0x000159F3
		public MacOsIPv4InterfaceStatistics(MacOsNetworkInterface parent)
		{
			this.macos = parent;
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long BytesReceived
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long BytesSent
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long IncomingPacketsDiscarded
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long IncomingPacketsWithErrors
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long IncomingUnknownProtocolPackets
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long NonUnicastPacketsReceived
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x060020BE RID: 8382 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long NonUnicastPacketsSent
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long OutgoingPacketsDiscarded
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long OutgoingPacketsWithErrors
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long OutputQueueLength
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long UnicastPacketsReceived
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long UnicastPacketsSent
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x04001394 RID: 5012
		private MacOsNetworkInterface macos;
	}
}
