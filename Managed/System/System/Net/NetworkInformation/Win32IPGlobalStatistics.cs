using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000392 RID: 914
	internal class Win32IPGlobalStatistics : IPGlobalStatistics
	{
		// Token: 0x0600202D RID: 8237 RVA: 0x00017362 File Offset: 0x00015562
		public Win32IPGlobalStatistics(Win32_MIB_IPSTATS info)
		{
			this.info = info;
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x00017371 File Offset: 0x00015571
		public override int DefaultTtl
		{
			get
			{
				return this.info.DefaultTTL;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x0001737E File Offset: 0x0001557E
		public override bool ForwardingEnabled
		{
			get
			{
				return this.info.Forwarding != 0;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x00017391 File Offset: 0x00015591
		public override int NumberOfInterfaces
		{
			get
			{
				return this.info.NumIf;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x0001739E File Offset: 0x0001559E
		public override int NumberOfIPAddresses
		{
			get
			{
				return this.info.NumAddr;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06002032 RID: 8242 RVA: 0x000173AB File Offset: 0x000155AB
		public override int NumberOfRoutes
		{
			get
			{
				return this.info.NumRoutes;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x000173B8 File Offset: 0x000155B8
		public override long OutputPacketRequests
		{
			get
			{
				return (long)((ulong)this.info.OutRequests);
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x000173C6 File Offset: 0x000155C6
		public override long OutputPacketRoutingDiscards
		{
			get
			{
				return (long)((ulong)this.info.RoutingDiscards);
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x000173D4 File Offset: 0x000155D4
		public override long OutputPacketsDiscarded
		{
			get
			{
				return (long)((ulong)this.info.OutDiscards);
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x000173E2 File Offset: 0x000155E2
		public override long OutputPacketsWithNoRoute
		{
			get
			{
				return (long)((ulong)this.info.OutNoRoutes);
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x000173F0 File Offset: 0x000155F0
		public override long PacketFragmentFailures
		{
			get
			{
				return (long)((ulong)this.info.FragFails);
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x000173FE File Offset: 0x000155FE
		public override long PacketReassembliesRequired
		{
			get
			{
				return (long)((ulong)this.info.ReasmReqds);
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x0001740C File Offset: 0x0001560C
		public override long PacketReassemblyFailures
		{
			get
			{
				return (long)((ulong)this.info.ReasmFails);
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x0001741A File Offset: 0x0001561A
		public override long PacketReassemblyTimeout
		{
			get
			{
				return (long)((ulong)this.info.ReasmTimeout);
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x00017428 File Offset: 0x00015628
		public override long PacketsFragmented
		{
			get
			{
				return (long)((ulong)this.info.FragOks);
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x00017436 File Offset: 0x00015636
		public override long PacketsReassembled
		{
			get
			{
				return (long)((ulong)this.info.ReasmOks);
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x00017444 File Offset: 0x00015644
		public override long ReceivedPackets
		{
			get
			{
				return (long)((ulong)this.info.InReceives);
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x00017452 File Offset: 0x00015652
		public override long ReceivedPacketsDelivered
		{
			get
			{
				return (long)((ulong)this.info.InDelivers);
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x00017460 File Offset: 0x00015660
		public override long ReceivedPacketsDiscarded
		{
			get
			{
				return (long)((ulong)this.info.InDiscards);
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x0001746E File Offset: 0x0001566E
		public override long ReceivedPacketsForwarded
		{
			get
			{
				return (long)((ulong)this.info.ForwDatagrams);
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x0001747C File Offset: 0x0001567C
		public override long ReceivedPacketsWithAddressErrors
		{
			get
			{
				return (long)((ulong)this.info.InAddrErrors);
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x0001748A File Offset: 0x0001568A
		public override long ReceivedPacketsWithHeadersErrors
		{
			get
			{
				return (long)((ulong)this.info.InHdrErrors);
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x00017498 File Offset: 0x00015698
		public override long ReceivedPacketsWithUnknownProtocol
		{
			get
			{
				return (long)((ulong)this.info.InUnknownProtos);
			}
		}

		// Token: 0x0400134D RID: 4941
		private Win32_MIB_IPSTATS info;
	}
}
