using System;
using System.Collections.Specialized;
using System.Globalization;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003DB RID: 987
	internal class MibUdpStatistics : UdpStatistics
	{
		// Token: 0x060021CA RID: 8650 RVA: 0x000180E1 File Offset: 0x000162E1
		public MibUdpStatistics(global::System.Collections.Specialized.StringDictionary dic)
		{
			this.dic = dic;
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x000180F0 File Offset: 0x000162F0
		private long Get(string name)
		{
			return (this.dic[name] == null) ? 0L : long.Parse(this.dic[name], NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x00018120 File Offset: 0x00016320
		public override long DatagramsReceived
		{
			get
			{
				return this.Get("InDatagrams");
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x0001812D File Offset: 0x0001632D
		public override long DatagramsSent
		{
			get
			{
				return this.Get("OutDatagrams");
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x0001813A File Offset: 0x0001633A
		public override long IncomingDatagramsDiscarded
		{
			get
			{
				return this.Get("NoPorts");
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x00018147 File Offset: 0x00016347
		public override long IncomingDatagramsWithErrors
		{
			get
			{
				return this.Get("InErrors");
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x00018154 File Offset: 0x00016354
		public override int UdpListeners
		{
			get
			{
				return (int)this.Get("NumAddrs");
			}
		}

		// Token: 0x04001482 RID: 5250
		private global::System.Collections.Specialized.StringDictionary dic;
	}
}
