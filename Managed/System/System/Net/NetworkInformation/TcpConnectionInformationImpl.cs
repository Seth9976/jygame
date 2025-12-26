using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003D4 RID: 980
	internal class TcpConnectionInformationImpl : TcpConnectionInformation
	{
		// Token: 0x06002192 RID: 8594 RVA: 0x00017EE4 File Offset: 0x000160E4
		public TcpConnectionInformationImpl(IPEndPoint local, IPEndPoint remote, TcpState state)
		{
			this.local = local;
			this.remote = remote;
			this.state = state;
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x00017F01 File Offset: 0x00016101
		public override IPEndPoint LocalEndPoint
		{
			get
			{
				return this.local;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x00017F09 File Offset: 0x00016109
		public override IPEndPoint RemoteEndPoint
		{
			get
			{
				return this.remote;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x00017F11 File Offset: 0x00016111
		public override TcpState State
		{
			get
			{
				return this.state;
			}
		}

		// Token: 0x04001460 RID: 5216
		private IPEndPoint local;

		// Token: 0x04001461 RID: 5217
		private IPEndPoint remote;

		// Token: 0x04001462 RID: 5218
		private TcpState state;
	}
}
