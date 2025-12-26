using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Networking
{
	// Token: 0x02000226 RID: 550
	internal sealed class HostTopologyInternal : IDisposable
	{
		// Token: 0x06001F70 RID: 8048 RVA: 0x00026444 File Offset: 0x00024644
		public HostTopologyInternal(HostTopology topology)
		{
			ConnectionConfigInternal connectionConfigInternal = new ConnectionConfigInternal(topology.DefaultConfig);
			this.InitWrapper(connectionConfigInternal, topology.MaxDefaultConnections);
			for (int i = 1; i <= topology.SpecialConnectionConfigsCount; i++)
			{
				ConnectionConfig specialConnectionConfig = topology.GetSpecialConnectionConfig(i);
				ConnectionConfigInternal connectionConfigInternal2 = new ConnectionConfigInternal(specialConnectionConfig);
				this.AddSpecialConnectionConfig(connectionConfigInternal2);
			}
			this.InitOtherParameters(topology);
		}

		// Token: 0x06001F71 RID: 8049
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitWrapper(ConnectionConfigInternal config, int maxDefaultConnections);

		// Token: 0x06001F72 RID: 8050 RVA: 0x0000C732 File Offset: 0x0000A932
		private int AddSpecialConnectionConfig(ConnectionConfigInternal config)
		{
			return this.AddSpecialConnectionConfigWrapper(config);
		}

		// Token: 0x06001F73 RID: 8051
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int AddSpecialConnectionConfigWrapper(ConnectionConfigInternal config);

		// Token: 0x06001F74 RID: 8052 RVA: 0x0000C73B File Offset: 0x0000A93B
		private void InitOtherParameters(HostTopology topology)
		{
			this.InitReceivedPoolSize(topology.ReceivedMessagePoolSize);
			this.InitSentMessagePoolSize(topology.SentMessagePoolSize);
			this.InitMessagePoolSizeGrowthFactor(topology.MessagePoolSizeGrowthFactor);
		}

		// Token: 0x06001F75 RID: 8053
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitReceivedPoolSize(ushort pool);

		// Token: 0x06001F76 RID: 8054
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitSentMessagePoolSize(ushort pool);

		// Token: 0x06001F77 RID: 8055
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMessagePoolSizeGrowthFactor(float factor);

		// Token: 0x06001F78 RID: 8056
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Dispose();

		// Token: 0x06001F79 RID: 8057 RVA: 0x000264A8 File Offset: 0x000246A8
		~HostTopologyInternal()
		{
			this.Dispose();
		}

		// Token: 0x04000899 RID: 2201
		internal IntPtr m_Ptr;
	}
}
