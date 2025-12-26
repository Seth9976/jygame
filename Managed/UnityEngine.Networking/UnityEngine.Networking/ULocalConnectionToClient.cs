using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000012 RID: 18
	internal class ULocalConnectionToClient : NetworkConnection
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00004684 File Offset: 0x00002884
		public ULocalConnectionToClient(LocalClient localClient)
		{
			this.address = "localClient";
			this.m_LocalClient = localClient;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000046A0 File Offset: 0x000028A0
		public LocalClient localClient
		{
			get
			{
				return this.m_LocalClient;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000046A8 File Offset: 0x000028A8
		public override bool Send(short msgType, MessageBase msg)
		{
			this.m_LocalClient.InvokeHandlerOnClient(msgType, msg, 0);
			return true;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000046BC File Offset: 0x000028BC
		public override bool SendUnreliable(short msgType, MessageBase msg)
		{
			this.m_LocalClient.InvokeHandlerOnClient(msgType, msg, 1);
			return true;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000046D0 File Offset: 0x000028D0
		public override bool SendByChannel(short msgType, MessageBase msg, int channelId)
		{
			this.m_LocalClient.InvokeHandlerOnClient(msgType, msg, channelId);
			return true;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000046E4 File Offset: 0x000028E4
		public override bool SendBytes(byte[] bytes, int numBytes, int channelId)
		{
			this.m_LocalClient.InvokeBytesOnClient(bytes, channelId);
			return true;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000046F4 File Offset: 0x000028F4
		public override bool SendWriter(NetworkWriter writer, int channelId)
		{
			this.m_LocalClient.InvokeBytesOnClient(writer.AsArray(), channelId);
			return true;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000470C File Offset: 0x0000290C
		public override void GetStatsOut(out int numMsgs, out int numBufferedMsgs, out int numBytes, out int lastBufferedPerSecond)
		{
			numMsgs = 0;
			numBufferedMsgs = 0;
			numBytes = 0;
			lastBufferedPerSecond = 0;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000471C File Offset: 0x0000291C
		public override void GetStatsIn(out int numMsgs, out int numBytes)
		{
			numMsgs = 0;
			numBytes = 0;
		}

		// Token: 0x0400003D RID: 61
		private LocalClient m_LocalClient;
	}
}
