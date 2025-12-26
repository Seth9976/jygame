using System;
using System.Collections.Specialized;
using System.Globalization;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000391 RID: 913
	internal class MibIPGlobalStatistics : IPGlobalStatistics
	{
		// Token: 0x06002015 RID: 8213 RVA: 0x000171FA File Offset: 0x000153FA
		public MibIPGlobalStatistics(global::System.Collections.Specialized.StringDictionary dic)
		{
			this.dic = dic;
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x00017209 File Offset: 0x00015409
		private long Get(string name)
		{
			return (this.dic[name] == null) ? 0L : long.Parse(this.dic[name], NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x00017239 File Offset: 0x00015439
		public override int DefaultTtl
		{
			get
			{
				return (int)this.Get("DefaultTTL");
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x00017247 File Offset: 0x00015447
		public override bool ForwardingEnabled
		{
			get
			{
				return this.Get("Forwarding") != 0L;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x0001725B File Offset: 0x0001545B
		public override int NumberOfInterfaces
		{
			get
			{
				return (int)this.Get("NumIf");
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x00017269 File Offset: 0x00015469
		public override int NumberOfIPAddresses
		{
			get
			{
				return (int)this.Get("NumAddr");
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x00017277 File Offset: 0x00015477
		public override int NumberOfRoutes
		{
			get
			{
				return (int)this.Get("NumRoutes");
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x00017285 File Offset: 0x00015485
		public override long OutputPacketRequests
		{
			get
			{
				return this.Get("OutRequests");
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x0600201D RID: 8221 RVA: 0x00017292 File Offset: 0x00015492
		public override long OutputPacketRoutingDiscards
		{
			get
			{
				return this.Get("RoutingDiscards");
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x0001729F File Offset: 0x0001549F
		public override long OutputPacketsDiscarded
		{
			get
			{
				return this.Get("OutDiscards");
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x000172AC File Offset: 0x000154AC
		public override long OutputPacketsWithNoRoute
		{
			get
			{
				return this.Get("OutNoRoutes");
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x000172B9 File Offset: 0x000154B9
		public override long PacketFragmentFailures
		{
			get
			{
				return this.Get("FragFails");
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06002021 RID: 8225 RVA: 0x000172C6 File Offset: 0x000154C6
		public override long PacketReassembliesRequired
		{
			get
			{
				return this.Get("ReasmReqds");
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x000172D3 File Offset: 0x000154D3
		public override long PacketReassemblyFailures
		{
			get
			{
				return this.Get("ReasmFails");
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x000172E0 File Offset: 0x000154E0
		public override long PacketReassemblyTimeout
		{
			get
			{
				return this.Get("ReasmTimeout");
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x000172ED File Offset: 0x000154ED
		public override long PacketsFragmented
		{
			get
			{
				return this.Get("FragOks");
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x000172FA File Offset: 0x000154FA
		public override long PacketsReassembled
		{
			get
			{
				return this.Get("ReasmOks");
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x00017307 File Offset: 0x00015507
		public override long ReceivedPackets
		{
			get
			{
				return this.Get("InReceives");
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x00017314 File Offset: 0x00015514
		public override long ReceivedPacketsDelivered
		{
			get
			{
				return this.Get("InDelivers");
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x00017321 File Offset: 0x00015521
		public override long ReceivedPacketsDiscarded
		{
			get
			{
				return this.Get("InDiscards");
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06002029 RID: 8233 RVA: 0x0001732E File Offset: 0x0001552E
		public override long ReceivedPacketsForwarded
		{
			get
			{
				return this.Get("ForwDatagrams");
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x0001733B File Offset: 0x0001553B
		public override long ReceivedPacketsWithAddressErrors
		{
			get
			{
				return this.Get("InAddrErrors");
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x00017348 File Offset: 0x00015548
		public override long ReceivedPacketsWithHeadersErrors
		{
			get
			{
				return this.Get("InHdrErrors");
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x00017355 File Offset: 0x00015555
		public override long ReceivedPacketsWithUnknownProtocol
		{
			get
			{
				return this.Get("InUnknownProtos");
			}
		}

		// Token: 0x0400134C RID: 4940
		private global::System.Collections.Specialized.StringDictionary dic;
	}
}
