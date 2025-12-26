using System;
using System.Collections.Generic;
using System.Text;

namespace UnityEngine.Networking
{
	// Token: 0x02000037 RID: 55
	public class NetworkConnection : IDisposable
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00007EAC File Offset: 0x000060AC
		public NetworkConnection()
		{
			this.m_Writer = new NetworkWriter();
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00007F10 File Offset: 0x00006110
		internal HashSet<NetworkIdentity> visList
		{
			get
			{
				return this.m_VisList;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00007F18 File Offset: 0x00006118
		public List<PlayerController> playerControllers
		{
			get
			{
				return this.m_PlayerControllers;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00007F20 File Offset: 0x00006120
		public HashSet<NetworkInstanceId> clientOwnedObjects
		{
			get
			{
				return this.m_ClientOwnedObjects;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00007F28 File Offset: 0x00006128
		internal Dictionary<short, NetworkConnection.PacketStat> packetStats
		{
			get
			{
				return this.m_PacketStats;
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00007F30 File Offset: 0x00006130
		public virtual void Initialize(string networkAddress, int networkHostId, int networkConnectionId, HostTopology hostTopology)
		{
			this.m_Writer = new NetworkWriter();
			this.address = networkAddress;
			this.hostId = networkHostId;
			this.connectionId = networkConnectionId;
			int channelCount = hostTopology.DefaultConfig.ChannelCount;
			int packetSize = (int)hostTopology.DefaultConfig.PacketSize;
			this.m_Channels = new ChannelBuffer[channelCount];
			for (int i = 0; i < channelCount; i++)
			{
				ChannelQOS channelQOS = hostTopology.DefaultConfig.Channels[i];
				int num = packetSize;
				if (channelQOS.QOS == QosType.ReliableFragmented || channelQOS.QOS == QosType.UnreliableFragmented)
				{
					num = (int)(hostTopology.DefaultConfig.FragmentSize * 128);
				}
				this.m_Channels[i] = new ChannelBuffer(this, num, (byte)i, NetworkConnection.IsReliableQoS(channelQOS.QOS));
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00007FF4 File Offset: 0x000061F4
		~NetworkConnection()
		{
			this.Dispose(false);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00008030 File Offset: 0x00006230
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00008040 File Offset: 0x00006240
		protected virtual void Dispose(bool disposing)
		{
			if (!this.m_Disposed && this.m_Channels != null)
			{
				for (int i = 0; i < this.m_Channels.Length; i++)
				{
					this.m_Channels[i].Dispose();
				}
			}
			this.m_Channels = null;
			if (this.m_ClientOwnedObjects != null)
			{
				foreach (NetworkInstanceId networkInstanceId in this.m_ClientOwnedObjects)
				{
					GameObject gameObject = NetworkServer.FindLocalObject(networkInstanceId);
					if (gameObject != null)
					{
						gameObject.GetComponent<NetworkIdentity>().ClearClientOwner();
					}
				}
			}
			this.m_ClientOwnedObjects = null;
			this.m_Disposed = true;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000811C File Offset: 0x0000631C
		private static bool IsReliableQoS(QosType qos)
		{
			return qos == QosType.Reliable || qos == QosType.ReliableFragmented || qos == QosType.ReliableSequenced || qos == QosType.ReliableStateUpdate;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000813C File Offset: 0x0000633C
		public bool SetChannelOption(int channelId, ChannelOption option, int value)
		{
			return this.m_Channels != null && channelId >= 0 && channelId < this.m_Channels.Length && this.m_Channels[channelId].SetOption(option, value);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00008174 File Offset: 0x00006374
		public void Disconnect()
		{
			this.address = string.Empty;
			this.isReady = false;
			ClientScene.HandleClientDisconnect(this);
			if (this.hostId == -1)
			{
				return;
			}
			byte b;
			NetworkTransport.Disconnect(this.hostId, this.connectionId, out b);
			this.RemoveObservers();
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000081C0 File Offset: 0x000063C0
		internal void SetHandlers(NetworkMessageHandlers handlers)
		{
			this.m_MessageHandlers = handlers;
			this.m_MessageHandlersDict = handlers.GetHandlers();
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000081D8 File Offset: 0x000063D8
		public bool InvokeHandlerNoData(short msgType)
		{
			return this.InvokeHandler(msgType, null, 0);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000081E4 File Offset: 0x000063E4
		public bool InvokeHandler(short msgType, NetworkReader reader, int channelId)
		{
			if (!this.m_MessageHandlersDict.ContainsKey(msgType))
			{
				return false;
			}
			this.m_MessageInfo.msgType = msgType;
			this.m_MessageInfo.conn = this;
			this.m_MessageInfo.reader = reader;
			this.m_MessageInfo.channelId = channelId;
			NetworkMessageDelegate networkMessageDelegate = this.m_MessageHandlersDict[msgType];
			if (networkMessageDelegate == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkConnection InvokeHandler no handler for " + msgType);
				}
				return false;
			}
			networkMessageDelegate(this.m_MessageInfo);
			return true;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00008278 File Offset: 0x00006478
		public bool InvokeHandler(NetworkMessage netMsg)
		{
			if (this.m_MessageHandlersDict.ContainsKey(netMsg.msgType))
			{
				NetworkMessageDelegate networkMessageDelegate = this.m_MessageHandlersDict[netMsg.msgType];
				networkMessageDelegate(netMsg);
				return true;
			}
			return false;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000082B8 File Offset: 0x000064B8
		public void RegisterHandler(short msgType, NetworkMessageDelegate handler)
		{
			this.m_MessageHandlers.RegisterHandler(msgType, handler);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000082C8 File Offset: 0x000064C8
		public void UnregisterHandler(short msgType)
		{
			this.m_MessageHandlers.UnregisterHandler(msgType);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000082D8 File Offset: 0x000064D8
		internal void SetPlayerController(PlayerController player)
		{
			while ((int)player.playerControllerId >= this.m_PlayerControllers.Count)
			{
				this.m_PlayerControllers.Add(new PlayerController());
			}
			this.m_PlayerControllers[(int)player.playerControllerId] = player;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00008318 File Offset: 0x00006518
		internal void RemovePlayerController(short playerControllerId)
		{
			for (int i = this.m_PlayerControllers.Count; i >= 0; i--)
			{
				if ((int)playerControllerId == i && playerControllerId == this.m_PlayerControllers[i].playerControllerId)
				{
					this.m_PlayerControllers[i] = new PlayerController();
					return;
				}
			}
			if (LogFilter.logError)
			{
				Debug.LogError("RemovePlayer player at playerControllerId " + playerControllerId + " not found");
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00008398 File Offset: 0x00006598
		internal bool GetPlayerController(short playerControllerId, out PlayerController playerController)
		{
			playerController = null;
			if (this.playerControllers.Count > 0)
			{
				for (int i = 0; i < this.playerControllers.Count; i++)
				{
					if (this.playerControllers[i].IsValid && this.playerControllers[i].playerControllerId == playerControllerId)
					{
						playerController = this.playerControllers[i];
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00008418 File Offset: 0x00006618
		public void FlushChannels()
		{
			if (this.m_Channels == null)
			{
				return;
			}
			foreach (ChannelBuffer channelBuffer in this.m_Channels)
			{
				channelBuffer.CheckInternalBuffer();
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00008458 File Offset: 0x00006658
		public void SetMaxDelay(float seconds)
		{
			if (this.m_Channels == null)
			{
				return;
			}
			foreach (ChannelBuffer channelBuffer in this.m_Channels)
			{
				channelBuffer.maxDelay = seconds;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00008498 File Offset: 0x00006698
		public virtual bool Send(short msgType, MessageBase msg)
		{
			return this.SendByChannel(msgType, msg, 0);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000084A4 File Offset: 0x000066A4
		public virtual bool SendUnreliable(short msgType, MessageBase msg)
		{
			return this.SendByChannel(msgType, msg, 1);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000084B0 File Offset: 0x000066B0
		public virtual bool SendByChannel(short msgType, MessageBase msg, int channelId)
		{
			this.m_Writer.StartMessage(msgType);
			msg.Serialize(this.m_Writer);
			this.m_Writer.FinishMessage();
			return this.SendWriter(this.m_Writer, channelId);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000084F0 File Offset: 0x000066F0
		public virtual bool SendBytes(byte[] bytes, int numBytes, int channelId)
		{
			if (this.logNetworkMessages)
			{
				this.LogSend(bytes);
			}
			return this.CheckChannel(channelId) && this.m_Channels[channelId].SendBytes(bytes, numBytes);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00008530 File Offset: 0x00006730
		public virtual bool SendWriter(NetworkWriter writer, int channelId)
		{
			if (this.logNetworkMessages)
			{
				this.LogSend(writer.ToArray());
			}
			return this.CheckChannel(channelId) && this.m_Channels[channelId].SendWriter(writer);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00008574 File Offset: 0x00006774
		private void LogSend(byte[] bytes)
		{
			NetworkReader networkReader = new NetworkReader(bytes);
			ushort num = networkReader.ReadUInt16();
			ushort num2 = networkReader.ReadUInt16();
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 4; i < (int)(4 + num); i++)
			{
				stringBuilder.AppendFormat("{0:X2}", bytes[i]);
				if (i > 150)
				{
					break;
				}
			}
			Debug.Log(string.Concat(new object[] { "ConnectionSend con:", this.connectionId, " bytes:", num, " msgId:", num2, " ", stringBuilder }));
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00008634 File Offset: 0x00006834
		private bool CheckChannel(int channelId)
		{
			if (this.m_Channels == null)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("Channels not initialized sending on id '" + channelId);
				}
				return false;
			}
			if (channelId < 0 || channelId >= this.m_Channels.Length)
			{
				if (LogFilter.logError)
				{
					Debug.LogError(string.Concat(new object[]
					{
						"Invalid channel when sending buffered data, '",
						channelId,
						"'. Current channel count is ",
						this.m_Channels.Length
					}));
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000086C8 File Offset: 0x000068C8
		public void ResetStats()
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000086CC File Offset: 0x000068CC
		protected void HandleBytes(byte[] buffer, int receivedSize, int channelId)
		{
			NetworkReader networkReader = new NetworkReader(buffer);
			this.HandleReader(networkReader, receivedSize, channelId);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000086EC File Offset: 0x000068EC
		protected void HandleReader(NetworkReader reader, int receivedSize, int channelId)
		{
			while ((ulong)reader.Position < (ulong)((long)receivedSize))
			{
				ushort num = reader.ReadUInt16();
				short num2 = reader.ReadInt16();
				byte[] array = reader.ReadBytes((int)num);
				NetworkReader networkReader = new NetworkReader(array);
				if (this.logNetworkMessages)
				{
					StringBuilder stringBuilder = new StringBuilder();
					for (int i = 0; i < (int)num; i++)
					{
						stringBuilder.AppendFormat("{0:X2}", array[i]);
						if (i > 150)
						{
							break;
						}
					}
					Debug.Log(string.Concat(new object[] { "ConnectionRecv con:", this.connectionId, " bytes:", num, " msgId:", num2, " ", stringBuilder }));
				}
				NetworkMessageDelegate networkMessageDelegate = null;
				if (this.m_MessageHandlersDict.ContainsKey(num2))
				{
					networkMessageDelegate = this.m_MessageHandlersDict[num2];
				}
				if (networkMessageDelegate == null)
				{
					if (LogFilter.logError)
					{
						Debug.LogError(string.Concat(new object[] { "Unknown message ID ", num2, " connId:", this.connectionId }));
					}
					break;
				}
				this.m_NetMsg.msgType = num2;
				this.m_NetMsg.reader = networkReader;
				this.m_NetMsg.conn = this;
				this.m_NetMsg.channelId = channelId;
				networkMessageDelegate(this.m_NetMsg);
				this.lastMessageTime = Time.time;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000888C File Offset: 0x00006A8C
		public virtual void GetStatsOut(out int numMsgs, out int numBufferedMsgs, out int numBytes, out int lastBufferedPerSecond)
		{
			numMsgs = 0;
			numBufferedMsgs = 0;
			numBytes = 0;
			lastBufferedPerSecond = 0;
			foreach (ChannelBuffer channelBuffer in this.m_Channels)
			{
				numMsgs += channelBuffer.numMsgsOut;
				numBufferedMsgs += channelBuffer.numBufferedMsgsOut;
				numBytes += channelBuffer.numBytesOut;
				lastBufferedPerSecond += channelBuffer.lastBufferedPerSecond;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000088F4 File Offset: 0x00006AF4
		public virtual void GetStatsIn(out int numMsgs, out int numBytes)
		{
			numMsgs = 0;
			numBytes = 0;
			foreach (ChannelBuffer channelBuffer in this.m_Channels)
			{
				numMsgs += channelBuffer.numMsgsIn;
				numBytes += channelBuffer.numBytesIn;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000893C File Offset: 0x00006B3C
		public override string ToString()
		{
			return string.Format("hostId: {0} connectionId: {1} isReady: {2} channel count: {3}", new object[]
			{
				this.hostId,
				this.connectionId,
				this.isReady,
				(this.m_Channels == null) ? 0 : this.m_Channels.Length
			});
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000089A4 File Offset: 0x00006BA4
		internal void AddToVisList(NetworkIdentity uv)
		{
			this.m_VisList.Add(uv);
			NetworkServer.ShowForConnection(uv, this);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000089BC File Offset: 0x00006BBC
		internal void RemoveFromVisList(NetworkIdentity uv, bool isDestroyed)
		{
			this.m_VisList.Remove(uv);
			if (!isDestroyed)
			{
				NetworkServer.HideForConnection(uv, this);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000089D8 File Offset: 0x00006BD8
		internal void RemoveObservers()
		{
			foreach (NetworkIdentity networkIdentity in this.m_VisList)
			{
				networkIdentity.RemoveObserverInternal(this);
			}
			this.m_VisList.Clear();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00008A4C File Offset: 0x00006C4C
		public virtual void TransportRecieve(byte[] bytes, int numBytes, int channelId)
		{
			this.HandleBytes(bytes, numBytes, channelId);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00008A58 File Offset: 0x00006C58
		public virtual bool TransportSend(byte[] bytes, int numBytes, int channelId, out byte error)
		{
			return NetworkTransport.Send(this.hostId, this.connectionId, channelId, bytes, numBytes, out error);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00008A70 File Offset: 0x00006C70
		internal void AddOwnedObject(NetworkIdentity obj)
		{
			if (this.m_ClientOwnedObjects == null)
			{
				this.m_ClientOwnedObjects = new HashSet<NetworkInstanceId>();
			}
			this.m_ClientOwnedObjects.Add(obj.netId);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00008AA8 File Offset: 0x00006CA8
		internal void RemoveOwnedObject(NetworkIdentity obj)
		{
			if (this.m_ClientOwnedObjects == null)
			{
				return;
			}
			this.m_ClientOwnedObjects.Remove(obj.netId);
		}

		// Token: 0x040000BF RID: 191
		private const int k_MaxMessageLogSize = 150;

		// Token: 0x040000C0 RID: 192
		private ChannelBuffer[] m_Channels;

		// Token: 0x040000C1 RID: 193
		private List<PlayerController> m_PlayerControllers = new List<PlayerController>();

		// Token: 0x040000C2 RID: 194
		private NetworkMessage m_NetMsg = new NetworkMessage();

		// Token: 0x040000C3 RID: 195
		private HashSet<NetworkIdentity> m_VisList = new HashSet<NetworkIdentity>();

		// Token: 0x040000C4 RID: 196
		private NetworkWriter m_Writer;

		// Token: 0x040000C5 RID: 197
		private Dictionary<short, NetworkMessageDelegate> m_MessageHandlersDict;

		// Token: 0x040000C6 RID: 198
		private NetworkMessageHandlers m_MessageHandlers;

		// Token: 0x040000C7 RID: 199
		private HashSet<NetworkInstanceId> m_ClientOwnedObjects;

		// Token: 0x040000C8 RID: 200
		private NetworkMessage m_MessageInfo = new NetworkMessage();

		// Token: 0x040000C9 RID: 201
		public int hostId = -1;

		// Token: 0x040000CA RID: 202
		public int connectionId = -1;

		// Token: 0x040000CB RID: 203
		public bool isReady;

		// Token: 0x040000CC RID: 204
		public string address;

		// Token: 0x040000CD RID: 205
		public float lastMessageTime;

		// Token: 0x040000CE RID: 206
		public bool logNetworkMessages;

		// Token: 0x040000CF RID: 207
		private Dictionary<short, NetworkConnection.PacketStat> m_PacketStats = new Dictionary<short, NetworkConnection.PacketStat>();

		// Token: 0x040000D0 RID: 208
		private bool m_Disposed;

		// Token: 0x02000038 RID: 56
		public class PacketStat
		{
			// Token: 0x060001A1 RID: 417 RVA: 0x00008AD0 File Offset: 0x00006CD0
			public override string ToString()
			{
				return string.Concat(new object[]
				{
					MsgType.MsgTypeToString(this.msgType),
					": count=",
					this.count,
					" bytes=",
					this.bytes
				});
			}

			// Token: 0x040000D1 RID: 209
			public short msgType;

			// Token: 0x040000D2 RID: 210
			public int count;

			// Token: 0x040000D3 RID: 211
			public int bytes;
		}
	}
}
