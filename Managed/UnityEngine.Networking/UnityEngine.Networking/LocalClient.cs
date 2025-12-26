using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	// Token: 0x02000010 RID: 16
	internal sealed class LocalClient : NetworkClient
	{
		// Token: 0x06000067 RID: 103 RVA: 0x0000426C File Offset: 0x0000246C
		public override void Disconnect()
		{
			ClientScene.HandleClientDisconnect(this.m_Connection);
			if (this.m_Connected)
			{
				this.PostInternalMessage(33);
				this.m_Connected = false;
			}
			this.m_AsyncConnect = NetworkClient.ConnectState.Disconnected;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000042A8 File Offset: 0x000024A8
		internal void InternalConnectLocalServer()
		{
			if (this.m_FreeMessages == null)
			{
				this.m_FreeMessages = new Stack<LocalClient.InternalMsg>();
				for (int i = 0; i < 64; i++)
				{
					LocalClient.InternalMsg internalMsg = default(LocalClient.InternalMsg);
					this.m_FreeMessages.Push(internalMsg);
				}
			}
			this.m_LocalServer = NetworkServer.instance;
			this.m_Connection = new ULocalConnectionToServer(this.m_LocalServer);
			base.SetHandlers(this.m_Connection);
			this.m_Connection.connectionId = this.m_LocalServer.AddLocalClient(this);
			this.m_AsyncConnect = NetworkClient.ConnectState.Connected;
			NetworkClient.SetActive(true);
			base.RegisterSystemHandlers(true);
			this.PostInternalMessage(32);
			this.m_Connected = true;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004354 File Offset: 0x00002554
		internal override void Update()
		{
			this.ProcessInternalMessages();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000435C File Offset: 0x0000255C
		internal void AddLocalPlayer(PlayerController localPlayer)
		{
			if (LogFilter.logDev)
			{
				Debug.Log(string.Concat(new object[]
				{
					"Local client AddLocalPlayer ",
					localPlayer.gameObject.name,
					" conn=",
					this.m_Connection.connectionId
				}));
			}
			this.m_Connection.isReady = true;
			this.m_Connection.SetPlayerController(localPlayer);
			NetworkIdentity unetView = localPlayer.unetView;
			if (unetView != null)
			{
				ClientScene.SetLocalObject(unetView.netId, localPlayer.gameObject);
				unetView.SetConnectionToServer(this.m_Connection);
			}
			ClientScene.InternalAddPlayer(unetView, localPlayer.playerControllerId);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004408 File Offset: 0x00002608
		private void PostInternalMessage(byte[] buffer, int channelId)
		{
			LocalClient.InternalMsg internalMsg;
			if (this.m_FreeMessages.Count == 0)
			{
				internalMsg = default(LocalClient.InternalMsg);
			}
			else
			{
				internalMsg = this.m_FreeMessages.Pop();
			}
			internalMsg.buffer = buffer;
			internalMsg.channelId = channelId;
			this.m_InternalMsgs.Add(internalMsg);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000445C File Offset: 0x0000265C
		private void PostInternalMessage(short msgType)
		{
			NetworkWriter networkWriter = new NetworkWriter();
			networkWriter.StartMessage(msgType);
			networkWriter.FinishMessage();
			this.PostInternalMessage(networkWriter.AsArray(), 0);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000448C File Offset: 0x0000268C
		private void ProcessInternalMessages()
		{
			if (this.m_InternalMsgs.Count == 0)
			{
				return;
			}
			List<LocalClient.InternalMsg> internalMsgs = this.m_InternalMsgs;
			this.m_InternalMsgs = this.m_InternalMsgs2;
			foreach (LocalClient.InternalMsg internalMsg in internalMsgs)
			{
				if (this.s_InternalMessage.reader == null)
				{
					this.s_InternalMessage.reader = new NetworkReader(internalMsg.buffer);
				}
				else
				{
					this.s_InternalMessage.reader.Replace(internalMsg.buffer);
				}
				this.s_InternalMessage.reader.ReadInt16();
				this.s_InternalMessage.channelId = internalMsg.channelId;
				this.s_InternalMessage.conn = base.connection;
				this.s_InternalMessage.msgType = this.s_InternalMessage.reader.ReadInt16();
				this.m_Connection.InvokeHandler(this.s_InternalMessage);
				this.m_FreeMessages.Push(internalMsg);
				base.connection.lastMessageTime = Time.time;
			}
			this.m_InternalMsgs = internalMsgs;
			this.m_InternalMsgs.Clear();
			foreach (LocalClient.InternalMsg internalMsg2 in this.m_InternalMsgs2)
			{
				this.m_InternalMsgs.Add(internalMsg2);
			}
			this.m_InternalMsgs2.Clear();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004644 File Offset: 0x00002844
		internal void InvokeHandlerOnClient(short msgType, MessageBase msg, int channelId)
		{
			NetworkWriter networkWriter = new NetworkWriter();
			networkWriter.StartMessage(msgType);
			msg.Serialize(networkWriter);
			networkWriter.FinishMessage();
			this.InvokeBytesOnClient(networkWriter.AsArray(), channelId);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004678 File Offset: 0x00002878
		internal void InvokeBytesOnClient(byte[] buffer, int channelId)
		{
			this.PostInternalMessage(buffer, channelId);
		}

		// Token: 0x04000034 RID: 52
		private const int k_InitialFreeMessagePoolSize = 64;

		// Token: 0x04000035 RID: 53
		private List<LocalClient.InternalMsg> m_InternalMsgs = new List<LocalClient.InternalMsg>();

		// Token: 0x04000036 RID: 54
		private List<LocalClient.InternalMsg> m_InternalMsgs2 = new List<LocalClient.InternalMsg>();

		// Token: 0x04000037 RID: 55
		private Stack<LocalClient.InternalMsg> m_FreeMessages;

		// Token: 0x04000038 RID: 56
		private NetworkServer m_LocalServer;

		// Token: 0x04000039 RID: 57
		private bool m_Connected;

		// Token: 0x0400003A RID: 58
		private NetworkMessage s_InternalMessage = new NetworkMessage();

		// Token: 0x02000011 RID: 17
		private struct InternalMsg
		{
			// Token: 0x0400003B RID: 59
			internal byte[] buffer;

			// Token: 0x0400003C RID: 60
			internal int channelId;
		}
	}
}
