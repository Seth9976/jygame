using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003DC RID: 988
	internal class Win32UdpStatistics : UdpStatistics
	{
		// Token: 0x060021D1 RID: 8657 RVA: 0x00018162 File Offset: 0x00016362
		public Win32UdpStatistics(Win32_MIB_UDPSTATS info)
		{
			this.info = info;
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x00018171 File Offset: 0x00016371
		public override long DatagramsReceived
		{
			get
			{
				return (long)((ulong)this.info.InDatagrams);
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x0001817F File Offset: 0x0001637F
		public override long DatagramsSent
		{
			get
			{
				return (long)((ulong)this.info.OutDatagrams);
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x0001818D File Offset: 0x0001638D
		public override long IncomingDatagramsDiscarded
		{
			get
			{
				return (long)((ulong)this.info.NoPorts);
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x0001819B File Offset: 0x0001639B
		public override long IncomingDatagramsWithErrors
		{
			get
			{
				return (long)((ulong)this.info.InErrors);
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x000181A9 File Offset: 0x000163A9
		public override int UdpListeners
		{
			get
			{
				return this.info.NumAddrs;
			}
		}

		// Token: 0x04001483 RID: 5251
		private Win32_MIB_UDPSTATS info;
	}
}
