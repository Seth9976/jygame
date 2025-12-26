using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Networking
{
	// Token: 0x02000225 RID: 549
	internal sealed class ConnectionConfigInternal : IDisposable
	{
		// Token: 0x06001F57 RID: 8023 RVA: 0x000021D6 File Offset: 0x000003D6
		private ConnectionConfigInternal()
		{
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x000262F8 File Offset: 0x000244F8
		public ConnectionConfigInternal(ConnectionConfig config)
		{
			if (config == null)
			{
				throw new NullReferenceException("config is not defined");
			}
			this.InitWrapper();
			this.InitPacketSize(config.PacketSize);
			this.InitFragmentSize(config.FragmentSize);
			this.InitResendTimeout(config.ResendTimeout);
			this.InitDisconnectTimeout(config.DisconnectTimeout);
			this.InitConnectTimeout(config.ConnectTimeout);
			this.InitMinUpdateTimeout(config.MinUpdateTimeout);
			this.InitPingTimeout(config.PingTimeout);
			this.InitReducedPingTimeout(config.ReducedPingTimeout);
			this.InitAllCostTimeout(config.AllCostTimeout);
			this.InitNetworkDropThreshold(config.NetworkDropThreshold);
			this.InitOverflowDropThreshold(config.OverflowDropThreshold);
			this.InitMaxConnectionAttempt(config.MaxConnectionAttempt);
			this.InitAckDelay(config.AckDelay);
			this.InitMaxCombinedReliableMessageSize(config.MaxCombinedReliableMessageSize);
			this.InitMaxCombinedReliableMessageCount(config.MaxCombinedReliableMessageCount);
			this.InitMaxSentMessageQueueSize(config.MaxSentMessageQueueSize);
			this.InitIsAcksLong(config.IsAcksLong);
			byte b = 0;
			while ((int)b < config.ChannelCount)
			{
				this.AddChannel(config.GetChannel(b));
				b += 1;
			}
		}

		// Token: 0x06001F59 RID: 8025
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitWrapper();

		// Token: 0x06001F5A RID: 8026
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern byte AddChannel(QosType value);

		// Token: 0x06001F5B RID: 8027
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern QosType GetChannel(int i);

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001F5C RID: 8028
		public extern int ChannelSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06001F5D RID: 8029
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitPacketSize(ushort value);

		// Token: 0x06001F5E RID: 8030
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitFragmentSize(ushort value);

		// Token: 0x06001F5F RID: 8031
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitResendTimeout(uint value);

		// Token: 0x06001F60 RID: 8032
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitDisconnectTimeout(uint value);

		// Token: 0x06001F61 RID: 8033
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitConnectTimeout(uint value);

		// Token: 0x06001F62 RID: 8034
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMinUpdateTimeout(uint value);

		// Token: 0x06001F63 RID: 8035
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitPingTimeout(uint value);

		// Token: 0x06001F64 RID: 8036
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitReducedPingTimeout(uint value);

		// Token: 0x06001F65 RID: 8037
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitAllCostTimeout(uint value);

		// Token: 0x06001F66 RID: 8038
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitNetworkDropThreshold(byte value);

		// Token: 0x06001F67 RID: 8039
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitOverflowDropThreshold(byte value);

		// Token: 0x06001F68 RID: 8040
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMaxConnectionAttempt(byte value);

		// Token: 0x06001F69 RID: 8041
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitAckDelay(uint value);

		// Token: 0x06001F6A RID: 8042
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMaxCombinedReliableMessageSize(ushort value);

		// Token: 0x06001F6B RID: 8043
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMaxCombinedReliableMessageCount(ushort value);

		// Token: 0x06001F6C RID: 8044
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMaxSentMessageQueueSize(ushort value);

		// Token: 0x06001F6D RID: 8045
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitIsAcksLong(bool value);

		// Token: 0x06001F6E RID: 8046
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Dispose();

		// Token: 0x06001F6F RID: 8047 RVA: 0x00026414 File Offset: 0x00024614
		~ConnectionConfigInternal()
		{
			this.Dispose();
		}

		// Token: 0x04000898 RID: 2200
		internal IntPtr m_Ptr;
	}
}
