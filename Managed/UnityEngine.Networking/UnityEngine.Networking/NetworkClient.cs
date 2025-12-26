using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UnityEngine.Networking.Match;
using UnityEngine.Networking.NetworkSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000035 RID: 53
	public class NetworkClient
	{
		// Token: 0x0600013D RID: 317 RVA: 0x00006BD0 File Offset: 0x00004DD0
		public NetworkClient()
		{
			if (LogFilter.logDev)
			{
				Debug.Log("Client created version " + Version.Current);
			}
			this.m_MsgBuffer = new byte[49152];
			this.m_MsgReader = new NetworkReader(this.m_MsgBuffer);
			NetworkClient.AddClient(this);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00006C88 File Offset: 0x00004E88
		public static List<NetworkClient> allClients
		{
			get
			{
				return NetworkClient.s_Clients;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00006C90 File Offset: 0x00004E90
		public static bool active
		{
			get
			{
				return NetworkClient.s_IsActive;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006C98 File Offset: 0x00004E98
		internal void SetHandlers(NetworkConnection conn)
		{
			conn.SetHandlers(this.m_MessageHandlers);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00006CA8 File Offset: 0x00004EA8
		public string serverIp
		{
			get
			{
				return this.m_ServerIp;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00006CB0 File Offset: 0x00004EB0
		public int serverPort
		{
			get
			{
				return this.m_ServerPort;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00006CB8 File Offset: 0x00004EB8
		public NetworkConnection connection
		{
			get
			{
				return this.m_Connection;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00006CC0 File Offset: 0x00004EC0
		public PeerInfoMessage[] peers
		{
			get
			{
				return this.m_Peers;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00006CC8 File Offset: 0x00004EC8
		public Dictionary<short, NetworkMessageDelegate> handlers
		{
			get
			{
				return this.m_MessageHandlers.GetHandlers();
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00006CD8 File Offset: 0x00004ED8
		public int numChannels
		{
			get
			{
				return this.m_HostTopology.DefaultConfig.ChannelCount;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00006CEC File Offset: 0x00004EEC
		public HostTopology hostTopology
		{
			get
			{
				return this.m_HostTopology;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00006CF4 File Offset: 0x00004EF4
		public bool isConnected
		{
			get
			{
				return this.m_AsyncConnect == NetworkClient.ConnectState.Connected;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00006D00 File Offset: 0x00004F00
		public Type networkConnectionClass
		{
			get
			{
				return this.m_NetworkConnectionClass;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00006D08 File Offset: 0x00004F08
		public void SetNetworkConnectionClass<T>() where T : NetworkConnection
		{
			this.m_NetworkConnectionClass = typeof(T);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006D1C File Offset: 0x00004F1C
		public bool Configure(ConnectionConfig config, int maxConnections)
		{
			HostTopology hostTopology = new HostTopology(config, maxConnections);
			return this.Configure(hostTopology);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00006D38 File Offset: 0x00004F38
		public bool Configure(HostTopology topology)
		{
			this.m_HostTopology = topology;
			return true;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00006D44 File Offset: 0x00004F44
		public void Connect(MatchInfo matchInfo)
		{
			this.PrepareForConnect();
			this.ConnectWithRelay(matchInfo);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00006D54 File Offset: 0x00004F54
		public void ConnectWithSimulator(string serverIp, int serverPort, int latency, float packetLoss)
		{
			this.m_UseSimulator = true;
			this.m_SimulatedLatency = latency;
			this.m_PacketLoss = packetLoss;
			this.Connect(serverIp, serverPort);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00006D74 File Offset: 0x00004F74
		private static bool IsValidIpV6(string address)
		{
			foreach (char c in address)
			{
				if (c != ':' && (c < '0' || c > '9') && (c < 'a' || c > 'f') && (c < 'A' || c > 'F'))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00006DE4 File Offset: 0x00004FE4
		public void Connect(string serverIp, int serverPort)
		{
			this.PrepareForConnect();
			if (LogFilter.logDebug)
			{
				Debug.Log(string.Concat(new object[] { "Client Connect: ", serverIp, ":", serverPort }));
			}
			this.m_ServerPort = serverPort;
			if (Application.platform == RuntimePlatform.WebGLPlayer)
			{
				this.m_ServerIp = serverIp;
				this.m_AsyncConnect = NetworkClient.ConnectState.Resolved;
			}
			else if (serverIp.Equals("127.0.0.1") || serverIp.Equals("localhost"))
			{
				this.m_ServerIp = "127.0.0.1";
				this.m_AsyncConnect = NetworkClient.ConnectState.Resolved;
			}
			else if (serverIp.IndexOf(":") != -1 && NetworkClient.IsValidIpV6(serverIp))
			{
				this.m_ServerIp = serverIp;
				this.m_AsyncConnect = NetworkClient.ConnectState.Resolved;
			}
			else
			{
				if (LogFilter.logDebug)
				{
					Debug.Log("Async DNS START:" + serverIp);
				}
				this.m_RequestedServerHost = serverIp;
				this.m_AsyncConnect = NetworkClient.ConnectState.Resolving;
				Dns.BeginGetHostAddresses(serverIp, new AsyncCallback(NetworkClient.GetHostAddressesCallback), this);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00006EF8 File Offset: 0x000050F8
		public void Connect(EndPoint secureTunnelEndPoint)
		{
			this.PrepareForConnect();
			if (LogFilter.logDebug)
			{
				Debug.Log("Client Connect to remoteSockAddr");
			}
			if (secureTunnelEndPoint == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("Connect failed: null endpoint passed in");
				}
				this.m_AsyncConnect = NetworkClient.ConnectState.Failed;
				return;
			}
			if (secureTunnelEndPoint.AddressFamily != AddressFamily.InterNetwork && secureTunnelEndPoint.AddressFamily != AddressFamily.InterNetworkV6)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("Connect failed: Endpoint AddressFamily must be either InterNetwork or InterNetworkV6");
				}
				this.m_AsyncConnect = NetworkClient.ConnectState.Failed;
				return;
			}
			string fullName = secureTunnelEndPoint.GetType().FullName;
			if (fullName == "System.Net.IPEndPoint")
			{
				IPEndPoint ipendPoint = (IPEndPoint)secureTunnelEndPoint;
				this.Connect(ipendPoint.Address.ToString(), ipendPoint.Port);
				return;
			}
			if (fullName != "UnityEngine.XboxOne.XboxOneEndPoint")
			{
				if (LogFilter.logError)
				{
					Debug.LogError("Connect failed: invalid Endpoint (not IPEndPoint or XboxOneEndPoint)");
				}
				this.m_AsyncConnect = NetworkClient.ConnectState.Failed;
				return;
			}
			byte b = 0;
			this.m_RemoteEndPoint = secureTunnelEndPoint;
			this.m_AsyncConnect = NetworkClient.ConnectState.Connecting;
			try
			{
				this.m_ClientConnectionId = NetworkTransport.ConnectEndPoint(this.m_ClientId, this.m_RemoteEndPoint, 0, out b);
			}
			catch (Exception ex)
			{
				Debug.LogError("Connect failed: Exception when trying to connect to EndPoint: " + ex);
			}
			if (this.m_ClientConnectionId == 0 && LogFilter.logError)
			{
				Debug.LogError("Connect failed: Unable to connect to EndPoint (" + b + ")");
			}
			this.m_Connection = (NetworkConnection)Activator.CreateInstance(this.m_NetworkConnectionClass);
			this.m_Connection.SetHandlers(this.m_MessageHandlers);
			this.m_Connection.Initialize(this.m_ServerIp, this.m_ClientId, this.m_ClientConnectionId, this.m_HostTopology);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000070B8 File Offset: 0x000052B8
		private void PrepareForConnect()
		{
			NetworkClient.SetActive(true);
			this.RegisterSystemHandlers(false);
			if (this.m_HostTopology == null)
			{
				ConnectionConfig connectionConfig = new ConnectionConfig();
				connectionConfig.AddChannel(QosType.Reliable);
				connectionConfig.AddChannel(QosType.Unreliable);
				this.m_HostTopology = new HostTopology(connectionConfig, 8);
			}
			if (this.m_UseSimulator)
			{
				int num = this.m_SimulatedLatency / 3 - 1;
				if (num < 1)
				{
					num = 1;
				}
				int num2 = this.m_SimulatedLatency * 3;
				if (LogFilter.logDebug)
				{
					Debug.Log(string.Concat(new object[] { "AddHost Using Simulator ", num, "/", num2 }));
				}
				this.m_ClientId = NetworkTransport.AddHostWithSimulator(this.m_HostTopology, num, num2, 0);
			}
			else
			{
				this.m_ClientId = NetworkTransport.AddHost(this.m_HostTopology, 0);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00007190 File Offset: 0x00005390
		internal static void GetHostAddressesCallback(IAsyncResult ar)
		{
			try
			{
				IPAddress[] array = Dns.EndGetHostAddresses(ar);
				NetworkClient networkClient = (NetworkClient)ar.AsyncState;
				if (array.Length == 0)
				{
					if (LogFilter.logError)
					{
						Debug.LogError("DNS lookup failed for:" + networkClient.m_RequestedServerHost);
					}
					networkClient.m_AsyncConnect = NetworkClient.ConnectState.Failed;
				}
				else
				{
					networkClient.m_ServerIp = array[0].ToString();
					networkClient.m_AsyncConnect = NetworkClient.ConnectState.Resolved;
					if (LogFilter.logDebug)
					{
						Debug.Log(string.Concat(new string[] { "Async DNS Result:", networkClient.m_ServerIp, " for ", networkClient.m_RequestedServerHost, ": ", networkClient.m_ServerIp }));
					}
				}
			}
			catch (SocketException ex)
			{
				NetworkClient networkClient2 = (NetworkClient)ar.AsyncState;
				if (LogFilter.logError)
				{
					Debug.LogError("DNS resolution failed: " + ex.ErrorCode);
				}
				if (LogFilter.logDebug)
				{
					Debug.Log("Exception:" + ex);
				}
				networkClient2.m_AsyncConnect = NetworkClient.ConnectState.Failed;
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000072C0 File Offset: 0x000054C0
		internal void ContinueConnect()
		{
			if (this.m_UseSimulator)
			{
				int num = this.m_SimulatedLatency / 3;
				if (num < 1)
				{
					num = 1;
				}
				if (LogFilter.logDebug)
				{
					Debug.Log(string.Concat(new object[]
					{
						"Connect Using Simulator ",
						this.m_SimulatedLatency / 3,
						"/",
						this.m_SimulatedLatency
					}));
				}
				ConnectionSimulatorConfig connectionSimulatorConfig = new ConnectionSimulatorConfig(num, this.m_SimulatedLatency, num, this.m_SimulatedLatency, this.m_PacketLoss);
				byte b;
				this.m_ClientConnectionId = NetworkTransport.ConnectWithSimulator(this.m_ClientId, this.m_ServerIp, this.m_ServerPort, 0, out b, connectionSimulatorConfig);
			}
			else
			{
				byte b;
				this.m_ClientConnectionId = NetworkTransport.Connect(this.m_ClientId, this.m_ServerIp, this.m_ServerPort, 0, out b);
			}
			this.m_Connection = (NetworkConnection)Activator.CreateInstance(this.m_NetworkConnectionClass);
			this.m_Connection.SetHandlers(this.m_MessageHandlers);
			this.m_Connection.Initialize(this.m_ServerIp, this.m_ClientId, this.m_ClientConnectionId, this.m_HostTopology);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000073DC File Offset: 0x000055DC
		private void ConnectWithRelay(MatchInfo info)
		{
			this.m_AsyncConnect = NetworkClient.ConnectState.Connecting;
			this.Update();
			byte b;
			this.m_ClientConnectionId = NetworkTransport.ConnectToNetworkPeer(this.m_ClientId, info.address, info.port, 0, 0, info.networkId, Utility.GetSourceID(), info.nodeId, out b);
			this.m_Connection = (NetworkConnection)Activator.CreateInstance(this.m_NetworkConnectionClass);
			this.m_Connection.SetHandlers(this.m_MessageHandlers);
			this.m_Connection.Initialize(info.address, this.m_ClientId, this.m_ClientConnectionId, this.m_HostTopology);
			if (b != 0)
			{
				Debug.LogError("ConnectToNetworkPeer Error: " + b);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00007490 File Offset: 0x00005690
		public virtual void Disconnect()
		{
			this.m_AsyncConnect = NetworkClient.ConnectState.Disconnected;
			ClientScene.HandleClientDisconnect(this.m_Connection);
			if (this.m_Connection != null)
			{
				this.m_Connection.Disconnect();
				this.m_Connection.Dispose();
				this.m_Connection = null;
				NetworkTransport.RemoveHost(this.m_ClientId);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000074E4 File Offset: 0x000056E4
		public bool Send(short msgType, MessageBase msg)
		{
			if (this.m_Connection == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkClient Send with no connection");
				}
				return false;
			}
			if (this.m_AsyncConnect != NetworkClient.ConnectState.Connected)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkClient Send when not connected to a server");
				}
				return false;
			}
			return this.m_Connection.Send(msgType, msg);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00007544 File Offset: 0x00005744
		public bool SendWriter(NetworkWriter writer, int channelId)
		{
			if (this.m_Connection == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkClient SendWriter with no connection");
				}
				return false;
			}
			if (this.m_AsyncConnect != NetworkClient.ConnectState.Connected)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkClient SendWriter when not connected to a server");
				}
				return false;
			}
			return this.m_Connection.SendWriter(writer, channelId);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000075A4 File Offset: 0x000057A4
		public bool SendBytes(byte[] data, int numBytes, int channelId)
		{
			if (this.m_Connection == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkClient SendBytes with no connection");
				}
				return false;
			}
			if (this.m_AsyncConnect != NetworkClient.ConnectState.Connected)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkClient SendBytes when not connected to a server");
				}
				return false;
			}
			return this.m_Connection.SendBytes(data, numBytes, channelId);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00007604 File Offset: 0x00005804
		public bool SendUnreliable(short msgType, MessageBase msg)
		{
			if (this.m_Connection == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkClient SendUnreliable with no connection");
				}
				return false;
			}
			if (this.m_AsyncConnect != NetworkClient.ConnectState.Connected)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkClient SendUnreliable when not connected to a server");
				}
				return false;
			}
			return this.m_Connection.SendUnreliable(msgType, msg);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00007664 File Offset: 0x00005864
		public bool SendByChannel(short msgType, MessageBase msg, int channelId)
		{
			if (this.m_Connection == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkClient SendByChannel with no connection");
				}
				return false;
			}
			if (this.m_AsyncConnect != NetworkClient.ConnectState.Connected)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkClient SendByChannel when not connected to a server");
				}
				return false;
			}
			return this.m_Connection.SendByChannel(msgType, msg, channelId);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000076C4 File Offset: 0x000058C4
		public void SetMaxDelay(float seconds)
		{
			if (this.m_Connection == null)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("SetMaxDelay failed, not connected.");
				}
				return;
			}
			this.m_Connection.SetMaxDelay(seconds);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00007700 File Offset: 0x00005900
		public void Shutdown()
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("Shutting down client " + this.m_ClientId);
			}
			this.m_ClientId = -1;
			NetworkClient.RemoveClient(this);
			if (NetworkClient.s_Clients.Count == 0)
			{
				NetworkClient.SetActive(false);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00007754 File Offset: 0x00005954
		internal virtual void Update()
		{
			if (this.m_ClientId == -1)
			{
				return;
			}
			switch (this.m_AsyncConnect)
			{
			case NetworkClient.ConnectState.None:
			case NetworkClient.ConnectState.Resolving:
			case NetworkClient.ConnectState.Disconnected:
				return;
			case NetworkClient.ConnectState.Resolved:
				this.m_AsyncConnect = NetworkClient.ConnectState.Connecting;
				this.ContinueConnect();
				return;
			case NetworkClient.ConnectState.Failed:
				this.GenerateConnectError(11);
				this.m_AsyncConnect = NetworkClient.ConnectState.Disconnected;
				return;
			}
			if (this.m_Connection != null && (int)Time.time != this.m_StatResetTime)
			{
				this.m_Connection.ResetStats();
				this.m_StatResetTime = (int)Time.time;
			}
			byte b;
			for (;;)
			{
				int num = 0;
				int num2;
				int num3;
				int num4;
				NetworkEventType networkEventType = NetworkTransport.ReceiveFromHost(this.m_ClientId, out num2, out num3, this.m_MsgBuffer, (int)((ushort)this.m_MsgBuffer.Length), out num4, out b);
				if (networkEventType != NetworkEventType.Nothing && LogFilter.logDev)
				{
					Debug.Log(string.Concat(new object[] { "Client event: host=", this.m_ClientId, " event=", networkEventType, " error=", b }));
				}
				switch (networkEventType)
				{
				case NetworkEventType.DataEvent:
					if (b != 0)
					{
						goto Block_10;
					}
					this.m_MsgReader.SeekZero();
					this.m_Connection.TransportRecieve(this.m_MsgBuffer, num4, num3);
					break;
				case NetworkEventType.ConnectEvent:
					if (LogFilter.logDebug)
					{
						Debug.Log("Client connected");
					}
					if (b != 0)
					{
						goto Block_9;
					}
					this.m_AsyncConnect = NetworkClient.ConnectState.Connected;
					this.m_Connection.InvokeHandlerNoData(32);
					break;
				case NetworkEventType.DisconnectEvent:
					if (LogFilter.logDebug)
					{
						Debug.Log("Client disconnected");
					}
					this.m_AsyncConnect = NetworkClient.ConnectState.Disconnected;
					if (b != 0)
					{
						this.GenerateDisconnectError((int)b);
					}
					ClientScene.HandleClientDisconnect(this.m_Connection);
					this.m_Connection.InvokeHandlerNoData(33);
					break;
				case NetworkEventType.Nothing:
					break;
				default:
					if (LogFilter.logError)
					{
						Debug.LogError("Unknown network message type received: " + networkEventType);
					}
					break;
				}
				if (num + 1 >= 500)
				{
					goto Block_14;
				}
				if (this.m_ClientId == -1)
				{
					goto Block_16;
				}
				if (networkEventType == NetworkEventType.Nothing)
				{
					goto IL_026B;
				}
			}
			Block_9:
			this.GenerateConnectError((int)b);
			return;
			Block_10:
			this.GenerateDataError((int)b);
			return;
			Block_14:
			if (LogFilter.logDebug)
			{
				Debug.Log("MaxEventsPerFrame hit (" + 500 + ")");
			}
			Block_16:
			IL_026B:
			if (this.m_Connection != null && this.m_AsyncConnect == NetworkClient.ConnectState.Connected)
			{
				this.m_Connection.FlushChannels();
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000079F0 File Offset: 0x00005BF0
		private void GenerateConnectError(int error)
		{
			if (LogFilter.logError)
			{
				Debug.LogError("UNet Client Error Connect Error: " + error);
			}
			this.GenerateError(error);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00007A24 File Offset: 0x00005C24
		private void GenerateDataError(int error)
		{
			if (LogFilter.logError)
			{
				Debug.LogError("UNet Client Data Error: " + (NetworkError)error);
			}
			this.GenerateError(error);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00007A5C File Offset: 0x00005C5C
		private void GenerateDisconnectError(int error)
		{
			if (LogFilter.logError)
			{
				Debug.LogError("UNet Client Disconnect Error: " + (NetworkError)error);
			}
			this.GenerateError(error);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00007A94 File Offset: 0x00005C94
		private void GenerateError(int error)
		{
			NetworkMessageDelegate networkMessageDelegate = this.m_MessageHandlers.GetHandler(34);
			if (networkMessageDelegate == null)
			{
				networkMessageDelegate = this.m_MessageHandlers.GetHandler(34);
			}
			if (networkMessageDelegate != null)
			{
				ErrorMessage errorMessage = new ErrorMessage();
				errorMessage.errorCode = error;
				byte[] array = new byte[200];
				NetworkWriter networkWriter = new NetworkWriter(array);
				errorMessage.Serialize(networkWriter);
				NetworkReader networkReader = new NetworkReader(array);
				networkMessageDelegate(new NetworkMessage
				{
					msgType = 34,
					reader = networkReader,
					conn = this.m_Connection,
					channelId = 0
				});
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00007B30 File Offset: 0x00005D30
		public void GetStatsOut(out int numMsgs, out int numBufferedMsgs, out int numBytes, out int lastBufferedPerSecond)
		{
			numMsgs = 0;
			numBufferedMsgs = 0;
			numBytes = 0;
			lastBufferedPerSecond = 0;
			if (this.m_Connection != null)
			{
				this.m_Connection.GetStatsOut(out numMsgs, out numBufferedMsgs, out numBytes, out lastBufferedPerSecond);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00007B68 File Offset: 0x00005D68
		public void GetStatsIn(out int numMsgs, out int numBytes)
		{
			numMsgs = 0;
			numBytes = 0;
			if (this.m_Connection != null)
			{
				this.m_Connection.GetStatsIn(out numMsgs, out numBytes);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00007B88 File Offset: 0x00005D88
		public Dictionary<short, NetworkConnection.PacketStat> GetConnectionStats()
		{
			if (this.m_Connection == null)
			{
				return null;
			}
			return this.m_Connection.packetStats;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00007BA4 File Offset: 0x00005DA4
		public void ResetConnectionStats()
		{
			if (this.m_Connection == null)
			{
				return;
			}
			this.m_Connection.ResetStats();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00007BC0 File Offset: 0x00005DC0
		public int GetRTT()
		{
			if (this.m_ClientId == -1)
			{
				return 0;
			}
			byte b;
			return NetworkTransport.GetCurrentRtt(this.m_ClientId, this.m_ClientConnectionId, out b);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00007BF0 File Offset: 0x00005DF0
		internal void RegisterSystemHandlers(bool localClient)
		{
			this.RegisterHandlerSafe(11, new NetworkMessageDelegate(this.OnPeerInfo));
			ClientScene.RegisterSystemHandlers(this, localClient);
			this.RegisterHandlerSafe(14, new NetworkMessageDelegate(this.OnCRC));
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00007C24 File Offset: 0x00005E24
		private void OnPeerInfo(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("OnPeerInfo");
			}
			netMsg.ReadMessage<PeerListMessage>(NetworkClient.s_PeerListMessage);
			this.m_Peers = NetworkClient.s_PeerListMessage.peers;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00007C58 File Offset: 0x00005E58
		private void OnCRC(NetworkMessage netMsg)
		{
			netMsg.ReadMessage<CRCMessage>(NetworkClient.s_CRCMessage);
			NetworkCRC.Validate(NetworkClient.s_CRCMessage.scripts, this.numChannels);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00007C7C File Offset: 0x00005E7C
		public void RegisterHandler(short msgType, NetworkMessageDelegate handler)
		{
			this.m_MessageHandlers.RegisterHandler(msgType, handler);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00007C8C File Offset: 0x00005E8C
		public void RegisterHandlerSafe(short msgType, NetworkMessageDelegate handler)
		{
			this.m_MessageHandlers.RegisterHandlerSafe(msgType, handler);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00007C9C File Offset: 0x00005E9C
		public void UnregisterHandler(short msgType)
		{
			this.m_MessageHandlers.UnregisterHandler(msgType);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00007CAC File Offset: 0x00005EAC
		public static Dictionary<short, NetworkConnection.PacketStat> GetTotalConnectionStats()
		{
			Dictionary<short, NetworkConnection.PacketStat> dictionary = new Dictionary<short, NetworkConnection.PacketStat>();
			foreach (NetworkClient networkClient in NetworkClient.s_Clients)
			{
				Dictionary<short, NetworkConnection.PacketStat> connectionStats = networkClient.GetConnectionStats();
				foreach (short num in connectionStats.Keys)
				{
					if (dictionary.ContainsKey(num))
					{
						NetworkConnection.PacketStat packetStat = dictionary[num];
						packetStat.count += connectionStats[num].count;
						packetStat.bytes += connectionStats[num].bytes;
						dictionary[num] = packetStat;
					}
					else
					{
						dictionary[num] = connectionStats[num];
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00007DD8 File Offset: 0x00005FD8
		internal static void AddClient(NetworkClient client)
		{
			NetworkClient.s_Clients.Add(client);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00007DE8 File Offset: 0x00005FE8
		internal static void RemoveClient(NetworkClient client)
		{
			NetworkClient.s_Clients.Remove(client);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00007DF8 File Offset: 0x00005FF8
		internal static void UpdateClients()
		{
			for (int i = 0; i < NetworkClient.s_Clients.Count; i++)
			{
				if (NetworkClient.s_Clients[i] != null)
				{
					NetworkClient.s_Clients[i].Update();
				}
				else
				{
					NetworkClient.s_Clients.RemoveAt(i);
				}
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00007E50 File Offset: 0x00006050
		public static void ShutdownAll()
		{
			while (NetworkClient.s_Clients.Count != 0)
			{
				NetworkClient.s_Clients[0].Shutdown();
			}
			NetworkClient.s_Clients = new List<NetworkClient>();
			NetworkClient.s_IsActive = false;
			ClientScene.Shutdown();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00007E8C File Offset: 0x0000608C
		internal static void SetActive(bool state)
		{
			if (!NetworkClient.s_IsActive && state)
			{
				NetworkTransport.Init();
			}
			NetworkClient.s_IsActive = state;
		}

		// Token: 0x040000A0 RID: 160
		private const int k_MaxEventsPerFrame = 500;

		// Token: 0x040000A1 RID: 161
		private Type m_NetworkConnectionClass = typeof(NetworkConnection);

		// Token: 0x040000A2 RID: 162
		private static List<NetworkClient> s_Clients = new List<NetworkClient>();

		// Token: 0x040000A3 RID: 163
		private static bool s_IsActive;

		// Token: 0x040000A4 RID: 164
		private HostTopology m_HostTopology;

		// Token: 0x040000A5 RID: 165
		private bool m_UseSimulator;

		// Token: 0x040000A6 RID: 166
		private int m_SimulatedLatency;

		// Token: 0x040000A7 RID: 167
		private float m_PacketLoss;

		// Token: 0x040000A8 RID: 168
		private string m_ServerIp = string.Empty;

		// Token: 0x040000A9 RID: 169
		private int m_ServerPort;

		// Token: 0x040000AA RID: 170
		private int m_ClientId = -1;

		// Token: 0x040000AB RID: 171
		private int m_ClientConnectionId = -1;

		// Token: 0x040000AC RID: 172
		private int m_StatResetTime;

		// Token: 0x040000AD RID: 173
		private EndPoint m_RemoteEndPoint;

		// Token: 0x040000AE RID: 174
		private static PeerListMessage s_PeerListMessage = new PeerListMessage();

		// Token: 0x040000AF RID: 175
		private static CRCMessage s_CRCMessage = new CRCMessage();

		// Token: 0x040000B0 RID: 176
		private NetworkMessageHandlers m_MessageHandlers = new NetworkMessageHandlers();

		// Token: 0x040000B1 RID: 177
		protected NetworkConnection m_Connection;

		// Token: 0x040000B2 RID: 178
		private byte[] m_MsgBuffer;

		// Token: 0x040000B3 RID: 179
		private NetworkReader m_MsgReader;

		// Token: 0x040000B4 RID: 180
		private PeerInfoMessage[] m_Peers;

		// Token: 0x040000B5 RID: 181
		protected NetworkClient.ConnectState m_AsyncConnect;

		// Token: 0x040000B6 RID: 182
		private string m_RequestedServerHost = string.Empty;

		// Token: 0x02000036 RID: 54
		protected enum ConnectState
		{
			// Token: 0x040000B8 RID: 184
			None,
			// Token: 0x040000B9 RID: 185
			Resolving,
			// Token: 0x040000BA RID: 186
			Resolved,
			// Token: 0x040000BB RID: 187
			Connecting,
			// Token: 0x040000BC RID: 188
			Connected,
			// Token: 0x040000BD RID: 189
			Disconnected,
			// Token: 0x040000BE RID: 190
			Failed
		}
	}
}
