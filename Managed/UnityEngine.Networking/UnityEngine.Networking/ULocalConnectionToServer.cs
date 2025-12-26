using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000013 RID: 19
	internal class ULocalConnectionToServer : NetworkConnection
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00004724 File Offset: 0x00002924
		public ULocalConnectionToServer(NetworkServer localServer)
		{
			this.address = "localServer";
			this.m_LocalServer = localServer;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004740 File Offset: 0x00002940
		public override bool Send(short msgType, MessageBase msg)
		{
			return this.m_LocalServer.InvokeHandlerOnServer(this, msgType, msg, 0);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004754 File Offset: 0x00002954
		public override bool SendUnreliable(short msgType, MessageBase msg)
		{
			return this.m_LocalServer.InvokeHandlerOnServer(this, msgType, msg, 1);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004768 File Offset: 0x00002968
		public override bool SendByChannel(short msgType, MessageBase msg, int channelId)
		{
			return this.m_LocalServer.InvokeHandlerOnServer(this, msgType, msg, channelId);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000477C File Offset: 0x0000297C
		public override bool SendBytes(byte[] bytes, int numBytes, int channelId)
		{
			if (numBytes <= 0)
			{
				Debug.LogError("LocalConnection:SendBytes cannot send zero bytes");
				return false;
			}
			return this.m_LocalServer.InvokeBytes(this, bytes, numBytes, channelId);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000047AC File Offset: 0x000029AC
		public override bool SendWriter(NetworkWriter writer, int channelId)
		{
			return this.m_LocalServer.InvokeBytes(this, writer.AsArray(), (int)((short)writer.AsArray().Length), channelId);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000047D8 File Offset: 0x000029D8
		public override void GetStatsOut(out int numMsgs, out int numBufferedMsgs, out int numBytes, out int lastBufferedPerSecond)
		{
			numMsgs = 0;
			numBufferedMsgs = 0;
			numBytes = 0;
			lastBufferedPerSecond = 0;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000047E8 File Offset: 0x000029E8
		public override void GetStatsIn(out int numMsgs, out int numBytes)
		{
			numMsgs = 0;
			numBytes = 0;
		}

		// Token: 0x0400003E RID: 62
		private NetworkServer m_LocalServer;
	}
}
