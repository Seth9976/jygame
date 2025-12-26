using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine.Networking.Match;
using UnityEngine.Networking.NetworkSystem;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking
{
	// Token: 0x02000043 RID: 67
	[AddComponentMenu("Network/NetworkManager")]
	public class NetworkManager : MonoBehaviour
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000C738 File Offset: 0x0000A938
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0000C740 File Offset: 0x0000A940
		public int networkPort
		{
			get
			{
				return this.m_NetworkPort;
			}
			set
			{
				this.m_NetworkPort = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000C74C File Offset: 0x0000A94C
		// (set) Token: 0x06000273 RID: 627 RVA: 0x0000C754 File Offset: 0x0000A954
		public bool serverBindToIP
		{
			get
			{
				return this.m_ServerBindToIP;
			}
			set
			{
				this.m_ServerBindToIP = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000C760 File Offset: 0x0000A960
		// (set) Token: 0x06000275 RID: 629 RVA: 0x0000C768 File Offset: 0x0000A968
		public string serverBindAddress
		{
			get
			{
				return this.m_ServerBindAddress;
			}
			set
			{
				this.m_ServerBindAddress = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0000C774 File Offset: 0x0000A974
		// (set) Token: 0x06000277 RID: 631 RVA: 0x0000C77C File Offset: 0x0000A97C
		public string networkAddress
		{
			get
			{
				return this.m_NetworkAddress;
			}
			set
			{
				this.m_NetworkAddress = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000C788 File Offset: 0x0000A988
		// (set) Token: 0x06000279 RID: 633 RVA: 0x0000C790 File Offset: 0x0000A990
		public bool dontDestroyOnLoad
		{
			get
			{
				return this.m_DontDestroyOnLoad;
			}
			set
			{
				this.m_DontDestroyOnLoad = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000C79C File Offset: 0x0000A99C
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0000C7A4 File Offset: 0x0000A9A4
		public bool runInBackground
		{
			get
			{
				return this.m_RunInBackground;
			}
			set
			{
				this.m_RunInBackground = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0000C7B8 File Offset: 0x0000A9B8
		public bool scriptCRCCheck
		{
			get
			{
				return this.m_ScriptCRCCheck;
			}
			set
			{
				this.m_ScriptCRCCheck = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0000C7CC File Offset: 0x0000A9CC
		public bool sendPeerInfo
		{
			get
			{
				return this.m_SendPeerInfo;
			}
			set
			{
				this.m_SendPeerInfo = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000C7D8 File Offset: 0x0000A9D8
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		public float maxDelay
		{
			get
			{
				return this.m_MaxDelay;
			}
			set
			{
				this.m_MaxDelay = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000C7EC File Offset: 0x0000A9EC
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		public LogFilter.FilterLevel logLevel
		{
			get
			{
				return this.m_LogLevel;
			}
			set
			{
				this.m_LogLevel = value;
				LogFilter.currentLogLevel = (int)value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000C804 File Offset: 0x0000AA04
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0000C80C File Offset: 0x0000AA0C
		public GameObject playerPrefab
		{
			get
			{
				return this.m_PlayerPrefab;
			}
			set
			{
				this.m_PlayerPrefab = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000C818 File Offset: 0x0000AA18
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0000C820 File Offset: 0x0000AA20
		public bool autoCreatePlayer
		{
			get
			{
				return this.m_AutoCreatePlayer;
			}
			set
			{
				this.m_AutoCreatePlayer = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000C82C File Offset: 0x0000AA2C
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0000C834 File Offset: 0x0000AA34
		public PlayerSpawnMethod playerSpawnMethod
		{
			get
			{
				return this.m_PlayerSpawnMethod;
			}
			set
			{
				this.m_PlayerSpawnMethod = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000C840 File Offset: 0x0000AA40
		// (set) Token: 0x0600028B RID: 651 RVA: 0x0000C848 File Offset: 0x0000AA48
		public string offlineScene
		{
			get
			{
				return this.m_OfflineScene;
			}
			set
			{
				this.m_OfflineScene = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000C854 File Offset: 0x0000AA54
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0000C85C File Offset: 0x0000AA5C
		public string onlineScene
		{
			get
			{
				return this.m_OnlineScene;
			}
			set
			{
				this.m_OnlineScene = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000C868 File Offset: 0x0000AA68
		public List<GameObject> spawnPrefabs
		{
			get
			{
				return this.m_SpawnPrefabs;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0000C870 File Offset: 0x0000AA70
		public List<Transform> startPositions
		{
			get
			{
				return NetworkManager.s_StartPositions;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000C878 File Offset: 0x0000AA78
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0000C880 File Offset: 0x0000AA80
		public bool customConfig
		{
			get
			{
				return this.m_CustomConfig;
			}
			set
			{
				this.m_CustomConfig = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000C88C File Offset: 0x0000AA8C
		public ConnectionConfig connectionConfig
		{
			get
			{
				if (this.m_ConnectionConfig == null)
				{
					this.m_ConnectionConfig = new ConnectionConfig();
				}
				return this.m_ConnectionConfig;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000C8AC File Offset: 0x0000AAAC
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0000C8B4 File Offset: 0x0000AAB4
		public int maxConnections
		{
			get
			{
				return this.m_MaxConnections;
			}
			set
			{
				this.m_MaxConnections = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000C8C0 File Offset: 0x0000AAC0
		public List<QosType> channels
		{
			get
			{
				return this.m_Channels;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000C8C8 File Offset: 0x0000AAC8
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		public EndPoint secureTunnelEndpoint
		{
			get
			{
				return this.m_EndPoint;
			}
			set
			{
				this.m_EndPoint = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000C8DC File Offset: 0x0000AADC
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
		public bool useWebSockets
		{
			get
			{
				return this.m_UseWebSockets;
			}
			set
			{
				this.m_UseWebSockets = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0000C8F8 File Offset: 0x0000AAF8
		public bool useSimulator
		{
			get
			{
				return this.m_UseSimulator;
			}
			set
			{
				this.m_UseSimulator = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000C904 File Offset: 0x0000AB04
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0000C90C File Offset: 0x0000AB0C
		public int simulatedLatency
		{
			get
			{
				return this.m_SimulatedLatency;
			}
			set
			{
				this.m_SimulatedLatency = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000C918 File Offset: 0x0000AB18
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0000C920 File Offset: 0x0000AB20
		public float packetLossPercentage
		{
			get
			{
				return this.m_PacketLossPercentage;
			}
			set
			{
				this.m_PacketLossPercentage = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000C92C File Offset: 0x0000AB2C
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x0000C934 File Offset: 0x0000AB34
		public string matchHost
		{
			get
			{
				return this.m_MatchHost;
			}
			set
			{
				this.m_MatchHost = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000C940 File Offset: 0x0000AB40
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x0000C948 File Offset: 0x0000AB48
		public int matchPort
		{
			get
			{
				return this.m_MatchPort;
			}
			set
			{
				this.m_MatchPort = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000C954 File Offset: 0x0000AB54
		public int numPlayers
		{
			get
			{
				int num = 0;
				foreach (NetworkConnection networkConnection in NetworkServer.connections)
				{
					if (networkConnection != null)
					{
						foreach (PlayerController playerController in networkConnection.playerControllers)
						{
							if (playerController.IsValid)
							{
								num++;
							}
						}
					}
				}
				foreach (NetworkConnection networkConnection2 in NetworkServer.localConnections)
				{
					if (networkConnection2 != null)
					{
						foreach (PlayerController playerController2 in networkConnection2.playerControllers)
						{
							if (playerController2.IsValid)
							{
								num++;
							}
						}
					}
				}
				return num;
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		private void Awake()
		{
			LogFilter.currentLogLevel = (int)this.m_LogLevel;
			if (this.m_DontDestroyOnLoad)
			{
				if (NetworkManager.singleton != null)
				{
					if (LogFilter.logWarn)
					{
						Debug.LogWarning("Multiple NetworkManagers detected in the scene. Only one NetworkManager can exist at a time. The duplicate NetworkManager will not be used.");
					}
					Object.Destroy(base.gameObject);
					return;
				}
				if (LogFilter.logDev)
				{
					Debug.Log("NetworkManager created singleton (DontDestroyOnLoad)");
				}
				NetworkManager.singleton = this;
				Object.DontDestroyOnLoad(base.gameObject);
			}
			else
			{
				if (LogFilter.logDev)
				{
					Debug.Log("NetworkManager created singleton (ForScene)");
				}
				NetworkManager.singleton = this;
			}
			if (this.m_NetworkAddress != string.Empty)
			{
				NetworkManager.s_Address = this.m_NetworkAddress;
			}
			else if (NetworkManager.s_Address != string.Empty)
			{
				this.m_NetworkAddress = NetworkManager.s_Address;
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000CBBC File Offset: 0x0000ADBC
		private void OnValidate()
		{
			if (this.m_SimulatedLatency < 1)
			{
				this.m_SimulatedLatency = 1;
			}
			if (this.m_SimulatedLatency > 500)
			{
				this.m_SimulatedLatency = 500;
			}
			if (this.m_PacketLossPercentage < 0f)
			{
				this.m_PacketLossPercentage = 0f;
			}
			if (this.m_PacketLossPercentage > 99f)
			{
				this.m_PacketLossPercentage = 99f;
			}
			if (this.m_MaxConnections <= 0)
			{
				this.m_MaxConnections = 1;
			}
			if (this.m_MaxConnections > 32000)
			{
				this.m_MaxConnections = 32000;
			}
			if (this.m_PlayerPrefab != null && this.m_PlayerPrefab.GetComponent<NetworkIdentity>() == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkManager - playerPrefab must have a NetworkIdentity.");
				}
				this.m_PlayerPrefab = null;
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000CCA0 File Offset: 0x0000AEA0
		internal void RegisterServerMessages()
		{
			NetworkServer.RegisterHandler(32, new NetworkMessageDelegate(this.OnServerConnectInternal));
			NetworkServer.RegisterHandler(33, new NetworkMessageDelegate(this.OnServerDisconnectInternal));
			NetworkServer.RegisterHandler(35, new NetworkMessageDelegate(this.OnServerReadyMessageInternal));
			NetworkServer.RegisterHandler(37, new NetworkMessageDelegate(this.OnServerAddPlayerMessageInternal));
			NetworkServer.RegisterHandler(38, new NetworkMessageDelegate(this.OnServerRemovePlayerMessageInternal));
			NetworkServer.RegisterHandler(34, new NetworkMessageDelegate(this.OnServerErrorInternal));
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000CD20 File Offset: 0x0000AF20
		public bool StartServer(ConnectionConfig config, int maxConnections)
		{
			return this.StartServer(null, config, maxConnections);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000CD2C File Offset: 0x0000AF2C
		public bool StartServer()
		{
			return this.StartServer(null);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000CD38 File Offset: 0x0000AF38
		public bool StartServer(MatchInfo info)
		{
			return this.StartServer(info, null, -1);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000CD44 File Offset: 0x0000AF44
		private bool StartServer(MatchInfo info, ConnectionConfig config, int maxConnections)
		{
			this.OnStartServer();
			if (this.m_RunInBackground)
			{
				Application.runInBackground = true;
			}
			NetworkCRC.scriptCRCCheck = this.scriptCRCCheck;
			if (this.m_CustomConfig && this.m_ConnectionConfig != null && config == null)
			{
				this.m_ConnectionConfig.Channels.Clear();
				foreach (QosType qosType in this.m_Channels)
				{
					this.m_ConnectionConfig.AddChannel(qosType);
				}
				NetworkServer.Configure(this.m_ConnectionConfig, this.m_MaxConnections);
			}
			this.RegisterServerMessages();
			NetworkServer.sendPeerInfo = this.m_SendPeerInfo;
			NetworkServer.useWebSockets = this.m_UseWebSockets;
			if (config != null)
			{
				NetworkServer.Configure(config, maxConnections);
			}
			if (info != null)
			{
				if (!NetworkServer.Listen(info, this.m_NetworkPort))
				{
					if (LogFilter.logError)
					{
						Debug.LogError("StartServer listen failed.");
					}
					return false;
				}
			}
			else if (this.m_ServerBindToIP && !string.IsNullOrEmpty(this.m_ServerBindAddress))
			{
				if (!NetworkServer.Listen(this.m_ServerBindAddress, this.m_NetworkPort))
				{
					if (LogFilter.logError)
					{
						Debug.LogError("StartServer listen on " + this.m_ServerBindAddress + " failed.");
					}
					return false;
				}
			}
			else if (!NetworkServer.Listen(this.m_NetworkPort))
			{
				if (LogFilter.logError)
				{
					Debug.LogError("StartServer listen failed.");
				}
				return false;
			}
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager StartServer port:" + this.m_NetworkPort);
			}
			this.isNetworkActive = true;
			if (this.m_OnlineScene != string.Empty && this.m_OnlineScene != Application.loadedLevelName && this.m_OnlineScene != this.m_OfflineScene)
			{
				this.ServerChangeScene(this.m_OnlineScene);
			}
			else
			{
				NetworkServer.SpawnObjects();
			}
			return true;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000CF74 File Offset: 0x0000B174
		internal void RegisterClientMessages(NetworkClient client)
		{
			client.RegisterHandler(32, new NetworkMessageDelegate(this.OnClientConnectInternal));
			client.RegisterHandler(33, new NetworkMessageDelegate(this.OnClientDisconnectInternal));
			client.RegisterHandler(36, new NetworkMessageDelegate(this.OnClientNotReadyMessageInternal));
			client.RegisterHandler(34, new NetworkMessageDelegate(this.OnClientErrorInternal));
			client.RegisterHandler(39, new NetworkMessageDelegate(this.OnClientSceneInternal));
			if (this.m_PlayerPrefab != null)
			{
				ClientScene.RegisterPrefab(this.m_PlayerPrefab);
			}
			foreach (GameObject gameObject in this.m_SpawnPrefabs)
			{
				if (gameObject != null)
				{
					ClientScene.RegisterPrefab(gameObject);
				}
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000D068 File Offset: 0x0000B268
		public void UseExternalClient(NetworkClient externalClient)
		{
			if (this.m_RunInBackground)
			{
				Application.runInBackground = true;
			}
			this.isNetworkActive = true;
			this.client = externalClient;
			this.RegisterClientMessages(this.client);
			this.OnStartClient(this.client);
			NetworkManager.s_Address = this.m_NetworkAddress;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000D0B8 File Offset: 0x0000B2B8
		public NetworkClient StartClient(MatchInfo info, ConnectionConfig config)
		{
			this.matchInfo = info;
			if (this.m_RunInBackground)
			{
				Application.runInBackground = true;
			}
			this.isNetworkActive = true;
			this.client = new NetworkClient();
			if (config != null)
			{
				this.client.Configure(config, 1);
			}
			else if (this.m_CustomConfig && this.m_ConnectionConfig != null)
			{
				this.m_ConnectionConfig.Channels.Clear();
				foreach (QosType qosType in this.m_Channels)
				{
					this.m_ConnectionConfig.AddChannel(qosType);
				}
				this.client.Configure(this.m_ConnectionConfig, this.m_MaxConnections);
			}
			this.RegisterClientMessages(this.client);
			if (this.matchInfo != null)
			{
				if (LogFilter.logDebug)
				{
					Debug.Log("NetworkManager StartClient match: " + this.matchInfo);
				}
				this.client.Connect(this.matchInfo);
			}
			else if (this.m_EndPoint != null)
			{
				if (LogFilter.logDebug)
				{
					Debug.Log("NetworkManager StartClient using provided SecureTunnel");
				}
				this.client.Connect(this.m_EndPoint);
			}
			else
			{
				if (string.IsNullOrEmpty(this.m_NetworkAddress))
				{
					if (LogFilter.logError)
					{
						Debug.LogError("Must set the Network Address field in the manager");
					}
					return null;
				}
				if (LogFilter.logDebug)
				{
					Debug.Log(string.Concat(new object[] { "NetworkManager StartClient address:", this.m_NetworkAddress, " port:", this.m_NetworkPort }));
				}
				if (this.m_UseSimulator)
				{
					this.client.ConnectWithSimulator(this.m_NetworkAddress, this.m_NetworkPort, this.m_SimulatedLatency, this.m_PacketLossPercentage);
				}
				else
				{
					this.client.Connect(this.m_NetworkAddress, this.m_NetworkPort);
				}
			}
			this.OnStartClient(this.client);
			NetworkManager.s_Address = this.m_NetworkAddress;
			return this.client;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000D2F4 File Offset: 0x0000B4F4
		public NetworkClient StartClient(MatchInfo matchInfo)
		{
			return this.StartClient(matchInfo, null);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000D300 File Offset: 0x0000B500
		public NetworkClient StartClient()
		{
			return this.StartClient(null, null);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000D30C File Offset: 0x0000B50C
		public virtual NetworkClient StartHost(ConnectionConfig config, int maxConnections)
		{
			this.OnStartHost();
			if (this.StartServer(config, maxConnections))
			{
				NetworkClient networkClient = this.ConnectLocalClient();
				this.OnServerConnect(networkClient.connection);
				this.OnStartClient(networkClient);
				return networkClient;
			}
			return null;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000D34C File Offset: 0x0000B54C
		public virtual NetworkClient StartHost(MatchInfo info)
		{
			this.OnStartHost();
			this.matchInfo = info;
			if (this.StartServer(info))
			{
				NetworkClient networkClient = this.ConnectLocalClient();
				this.OnServerConnect(networkClient.connection);
				this.OnStartClient(networkClient);
				return networkClient;
			}
			return null;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000D390 File Offset: 0x0000B590
		public virtual NetworkClient StartHost()
		{
			this.OnStartHost();
			if (this.StartServer())
			{
				NetworkClient networkClient = this.ConnectLocalClient();
				this.OnServerConnect(networkClient.connection);
				this.OnStartClient(networkClient);
				return networkClient;
			}
			return null;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000D3CC File Offset: 0x0000B5CC
		private NetworkClient ConnectLocalClient()
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager StartHost port:" + this.m_NetworkPort);
			}
			this.m_NetworkAddress = "localhost";
			this.client = ClientScene.ConnectLocalServer();
			this.RegisterClientMessages(this.client);
			return this.client;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000D428 File Offset: 0x0000B628
		public void StopHost()
		{
			this.OnStopHost();
			this.StopServer();
			this.StopClient();
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000D43C File Offset: 0x0000B63C
		public void StopServer()
		{
			if (!NetworkServer.active)
			{
				return;
			}
			this.OnStopServer();
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager StopServer");
			}
			this.isNetworkActive = false;
			NetworkServer.Shutdown();
			this.StopMatchMaker();
			if (this.m_OfflineScene != string.Empty)
			{
				this.ServerChangeScene(this.m_OfflineScene);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
		public void StopClient()
		{
			this.OnStopClient();
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager StopClient");
			}
			this.isNetworkActive = false;
			if (this.client != null)
			{
				this.client.Disconnect();
				this.client.Shutdown();
				this.client = null;
			}
			this.StopMatchMaker();
			ClientScene.DestroyAllClientObjects();
			if (this.m_OfflineScene != string.Empty)
			{
				this.ClientChangeScene(this.m_OfflineScene, false);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000D528 File Offset: 0x0000B728
		public virtual void ServerChangeScene(string newSceneName)
		{
			if (string.IsNullOrEmpty(newSceneName))
			{
				if (LogFilter.logError)
				{
					Debug.LogError("ServerChangeScene empty scene name");
				}
				return;
			}
			if (LogFilter.logDebug)
			{
				Debug.Log("ServerChangeScene " + newSceneName);
			}
			NetworkServer.SetAllClientsNotReady();
			NetworkManager.networkSceneName = newSceneName;
			NetworkManager.s_LoadingSceneAsync = Application.LoadLevelAsync(newSceneName);
			StringMessage stringMessage = new StringMessage(NetworkManager.networkSceneName);
			NetworkServer.SendToAll(39, stringMessage);
			NetworkManager.s_StartPositionIndex = 0;
			NetworkManager.s_StartPositions.Clear();
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000D5AC File Offset: 0x0000B7AC
		internal void ClientChangeScene(string newSceneName, bool forceReload)
		{
			if (string.IsNullOrEmpty(newSceneName))
			{
				if (LogFilter.logError)
				{
					Debug.LogError("ClientChangeScene empty scene name");
				}
				return;
			}
			if (LogFilter.logDebug)
			{
				Debug.Log("ClientChangeScene newSceneName:" + newSceneName + " networkSceneName:" + NetworkManager.networkSceneName);
			}
			if (newSceneName == NetworkManager.networkSceneName && !forceReload)
			{
				return;
			}
			NetworkManager.s_LoadingSceneAsync = Application.LoadLevelAsync(newSceneName);
			NetworkManager.networkSceneName = newSceneName;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000D628 File Offset: 0x0000B828
		private void FinishLoadScene()
		{
			if (this.client != null)
			{
				if (NetworkManager.s_ClientReadyConnection != null)
				{
					this.OnClientConnect(NetworkManager.s_ClientReadyConnection);
					NetworkManager.s_ClientReadyConnection = null;
				}
			}
			else if (LogFilter.logDev)
			{
				Debug.Log("FinishLoadScene client is null");
			}
			if (NetworkServer.active)
			{
				NetworkServer.SpawnObjects();
				this.OnServerSceneChanged(NetworkManager.networkSceneName);
			}
			if (this.IsClientConnected() && this.client != null)
			{
				this.RegisterClientMessages(this.client);
				this.OnClientSceneChanged(this.client.connection);
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
		internal static void UpdateScene()
		{
			if (NetworkManager.singleton == null)
			{
				return;
			}
			if (NetworkManager.s_LoadingSceneAsync == null)
			{
				return;
			}
			if (!NetworkManager.s_LoadingSceneAsync.isDone)
			{
				return;
			}
			if (LogFilter.logDebug)
			{
				Debug.Log("ClientChangeScene done readyCon:" + NetworkManager.s_ClientReadyConnection);
			}
			NetworkManager.singleton.FinishLoadScene();
			NetworkManager.s_LoadingSceneAsync.allowSceneActivation = true;
			NetworkManager.s_LoadingSceneAsync = null;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000D738 File Offset: 0x0000B938
		private void OnDestroy()
		{
			if (LogFilter.logDev)
			{
				Debug.Log("NetworkManager destroyed");
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000D750 File Offset: 0x0000B950
		public static void RegisterStartPosition(Transform start)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("RegisterStartPosition:" + start);
			}
			NetworkManager.s_StartPositions.Add(start);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000D778 File Offset: 0x0000B978
		public static void UnRegisterStartPosition(Transform start)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("UnRegisterStartPosition:" + start);
			}
			NetworkManager.s_StartPositions.Remove(start);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000D7AC File Offset: 0x0000B9AC
		public bool IsClientConnected()
		{
			return this.client != null && this.client.isConnected;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000D7C8 File Offset: 0x0000B9C8
		public static void Shutdown()
		{
			if (NetworkManager.singleton == null)
			{
				return;
			}
			NetworkManager.s_StartPositions.Clear();
			NetworkManager.s_StartPositionIndex = 0;
			NetworkManager.s_ClientReadyConnection = null;
			NetworkManager.singleton.StopHost();
			NetworkManager.singleton = null;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000D804 File Offset: 0x0000BA04
		internal void OnServerConnectInternal(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager:OnServerConnectInternal");
			}
			netMsg.conn.SetMaxDelay(this.m_MaxDelay);
			if (NetworkManager.networkSceneName != string.Empty && NetworkManager.networkSceneName != this.m_OfflineScene)
			{
				StringMessage stringMessage = new StringMessage(NetworkManager.networkSceneName);
				netMsg.conn.Send(39, stringMessage);
			}
			this.OnServerConnect(netMsg.conn);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000D888 File Offset: 0x0000BA88
		internal void OnServerDisconnectInternal(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager:OnServerDisconnectInternal");
			}
			this.OnServerDisconnect(netMsg.conn);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000D8B8 File Offset: 0x0000BAB8
		internal void OnServerReadyMessageInternal(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager:OnServerReadyMessageInternal");
			}
			this.OnServerReady(netMsg.conn);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000D8E8 File Offset: 0x0000BAE8
		internal void OnServerAddPlayerMessageInternal(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager:OnServerAddPlayerMessageInternal");
			}
			netMsg.ReadMessage<AddPlayerMessage>(NetworkManager.s_AddPlayerMessage);
			if (NetworkManager.s_AddPlayerMessage.msgSize != 0)
			{
				NetworkReader networkReader = new NetworkReader(NetworkManager.s_AddPlayerMessage.msgData);
				this.OnServerAddPlayer(netMsg.conn, NetworkManager.s_AddPlayerMessage.playerControllerId, networkReader);
			}
			else
			{
				this.OnServerAddPlayer(netMsg.conn, NetworkManager.s_AddPlayerMessage.playerControllerId);
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000D968 File Offset: 0x0000BB68
		internal void OnServerRemovePlayerMessageInternal(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager:OnServerRemovePlayerMessageInternal");
			}
			netMsg.ReadMessage<RemovePlayerMessage>(NetworkManager.s_RemovePlayerMessage);
			PlayerController playerController;
			netMsg.conn.GetPlayerController(NetworkManager.s_RemovePlayerMessage.playerControllerId, out playerController);
			this.OnServerRemovePlayer(netMsg.conn, playerController);
			netMsg.conn.RemovePlayerController(NetworkManager.s_RemovePlayerMessage.playerControllerId);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
		internal void OnServerErrorInternal(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager:OnServerErrorInternal");
			}
			netMsg.ReadMessage<ErrorMessage>(NetworkManager.s_ErrorMessage);
			this.OnServerError(netMsg.conn, NetworkManager.s_ErrorMessage.errorCode);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000DA08 File Offset: 0x0000BC08
		internal void OnClientConnectInternal(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager:OnClientConnectInternal");
			}
			netMsg.conn.SetMaxDelay(this.m_MaxDelay);
			if (string.IsNullOrEmpty(this.m_OnlineScene) || this.m_OnlineScene == this.m_OfflineScene)
			{
				this.OnClientConnect(netMsg.conn);
			}
			else
			{
				NetworkManager.s_ClientReadyConnection = netMsg.conn;
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000DA7C File Offset: 0x0000BC7C
		internal void OnClientDisconnectInternal(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager:OnClientDisconnectInternal");
			}
			if (this.m_OfflineScene != string.Empty)
			{
				this.ClientChangeScene(this.m_OfflineScene, false);
			}
			this.OnClientDisconnect(netMsg.conn);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000DACC File Offset: 0x0000BCCC
		internal void OnClientNotReadyMessageInternal(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager:OnClientNotReadyMessageInternal");
			}
			ClientScene.SetNotReady();
			this.OnClientNotReady(netMsg.conn);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000DAF4 File Offset: 0x0000BCF4
		internal void OnClientErrorInternal(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager:OnClientErrorInternal");
			}
			netMsg.ReadMessage<ErrorMessage>(NetworkManager.s_ErrorMessage);
			this.OnClientError(netMsg.conn, NetworkManager.s_ErrorMessage.errorCode);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000DB2C File Offset: 0x0000BD2C
		internal void OnClientSceneInternal(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager:OnClientSceneInternal");
			}
			string text = netMsg.reader.ReadString();
			if (this.IsClientConnected() && !NetworkServer.active)
			{
				this.ClientChangeScene(text, true);
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000DB78 File Offset: 0x0000BD78
		public virtual void OnServerConnect(NetworkConnection conn)
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000DB7C File Offset: 0x0000BD7C
		public virtual void OnServerDisconnect(NetworkConnection conn)
		{
			NetworkServer.DestroyPlayersForConnection(conn);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000DB84 File Offset: 0x0000BD84
		public virtual void OnServerReady(NetworkConnection conn)
		{
			if (conn.playerControllers.Count == 0 && LogFilter.logDebug)
			{
				Debug.Log("Ready with no player object");
			}
			NetworkServer.SetClientReady(conn);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000DBBC File Offset: 0x0000BDBC
		public virtual void OnServerAddPlayer(NetworkConnection conn, short playerControllerId, NetworkReader extraMessageReader)
		{
			this.OnServerAddPlayerInternal(conn, playerControllerId);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000DBC8 File Offset: 0x0000BDC8
		public virtual void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
		{
			this.OnServerAddPlayerInternal(conn, playerControllerId);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000DBD4 File Offset: 0x0000BDD4
		private void OnServerAddPlayerInternal(NetworkConnection conn, short playerControllerId)
		{
			if (this.m_PlayerPrefab == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("The PlayerPrefab is empty on the NetworkManager. Please setup a PlayerPrefab object.");
				}
				return;
			}
			if (this.m_PlayerPrefab.GetComponent<NetworkIdentity>() == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("The PlayerPrefab does not have a NetworkIdentity. Please add a NetworkIdentity to the player prefab.");
				}
				return;
			}
			if ((int)playerControllerId < conn.playerControllers.Count && conn.playerControllers[(int)playerControllerId].IsValid && conn.playerControllers[(int)playerControllerId].gameObject != null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("There is already a player at that playerControllerId for this connections.");
				}
				return;
			}
			Transform startPosition = this.GetStartPosition();
			GameObject gameObject;
			if (startPosition != null)
			{
				gameObject = (GameObject)Object.Instantiate(this.m_PlayerPrefab, startPosition.position, startPosition.rotation);
			}
			else
			{
				gameObject = (GameObject)Object.Instantiate(this.m_PlayerPrefab, Vector3.zero, Quaternion.identity);
			}
			NetworkServer.AddPlayerForConnection(conn, gameObject, playerControllerId);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000DCE4 File Offset: 0x0000BEE4
		public Transform GetStartPosition()
		{
			if (NetworkManager.s_StartPositions.Count > 0)
			{
				for (int i = NetworkManager.s_StartPositions.Count - 1; i >= 0; i--)
				{
					if (NetworkManager.s_StartPositions[i] == null)
					{
						NetworkManager.s_StartPositions.RemoveAt(i);
					}
				}
			}
			if (this.m_PlayerSpawnMethod == PlayerSpawnMethod.Random && NetworkManager.s_StartPositions.Count > 0)
			{
				int num = Random.Range(0, NetworkManager.s_StartPositions.Count);
				return NetworkManager.s_StartPositions[num];
			}
			if (this.m_PlayerSpawnMethod == PlayerSpawnMethod.RoundRobin && NetworkManager.s_StartPositions.Count > 0)
			{
				if (NetworkManager.s_StartPositionIndex >= NetworkManager.s_StartPositions.Count)
				{
					NetworkManager.s_StartPositionIndex = 0;
				}
				Transform transform = NetworkManager.s_StartPositions[NetworkManager.s_StartPositionIndex];
				NetworkManager.s_StartPositionIndex++;
				return transform;
			}
			return null;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000DDCC File Offset: 0x0000BFCC
		public virtual void OnServerRemovePlayer(NetworkConnection conn, PlayerController player)
		{
			if (player.gameObject != null)
			{
				NetworkServer.Destroy(player.gameObject);
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000DDEC File Offset: 0x0000BFEC
		public virtual void OnServerError(NetworkConnection conn, int errorCode)
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000DDF0 File Offset: 0x0000BFF0
		public virtual void OnServerSceneChanged(string sceneName)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000DDF4 File Offset: 0x0000BFF4
		public virtual void OnClientConnect(NetworkConnection conn)
		{
			if (string.IsNullOrEmpty(this.m_OnlineScene) || this.m_OnlineScene == this.m_OfflineScene)
			{
				ClientScene.Ready(conn);
				if (this.m_AutoCreatePlayer)
				{
					ClientScene.AddPlayer(0);
				}
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000DE40 File Offset: 0x0000C040
		public virtual void OnClientDisconnect(NetworkConnection conn)
		{
			this.StopClient();
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000DE48 File Offset: 0x0000C048
		public virtual void OnClientError(NetworkConnection conn, int errorCode)
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000DE4C File Offset: 0x0000C04C
		public virtual void OnClientNotReady(NetworkConnection conn)
		{
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000DE50 File Offset: 0x0000C050
		public virtual void OnClientSceneChanged(NetworkConnection conn)
		{
			ClientScene.Ready(conn);
			if (!this.m_AutoCreatePlayer)
			{
				return;
			}
			bool flag = ClientScene.localPlayers.Count == 0;
			bool flag2 = false;
			foreach (PlayerController playerController in ClientScene.localPlayers)
			{
				if (playerController.gameObject != null)
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				flag = true;
			}
			if (flag)
			{
				ClientScene.AddPlayer(0);
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000DF00 File Offset: 0x0000C100
		public void StartMatchMaker()
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager StartMatchMaker");
			}
			this.SetMatchHost(this.m_MatchHost, this.m_MatchPort, true);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000DF2C File Offset: 0x0000C12C
		public void StopMatchMaker()
		{
			if (this.matchMaker != null)
			{
				Object.Destroy(this.matchMaker);
				this.matchMaker = null;
			}
			this.matchInfo = null;
			this.matches = null;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000DF60 File Offset: 0x0000C160
		public void SetMatchHost(string newHost, int port, bool https)
		{
			if (this.matchMaker == null)
			{
				this.matchMaker = base.gameObject.AddComponent<NetworkMatch>();
			}
			if (newHost == "localhost" || newHost == "127.0.0.1")
			{
				newHost = Environment.MachineName;
			}
			string text = "http://";
			if (https)
			{
				text = "https://";
			}
			if (LogFilter.logDebug)
			{
				Debug.Log("SetMatchHost:" + newHost);
			}
			this.m_MatchHost = newHost;
			this.m_MatchPort = port;
			this.matchMaker.baseUri = new Uri(string.Concat(new object[] { text, this.m_MatchHost, ":", this.m_MatchPort }));
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000E030 File Offset: 0x0000C230
		public virtual void OnStartHost()
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000E034 File Offset: 0x0000C234
		public virtual void OnStartServer()
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000E038 File Offset: 0x0000C238
		public virtual void OnStartClient(NetworkClient client)
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000E03C File Offset: 0x0000C23C
		public virtual void OnStopServer()
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000E040 File Offset: 0x0000C240
		public virtual void OnStopClient()
		{
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000E044 File Offset: 0x0000C244
		public virtual void OnStopHost()
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000E048 File Offset: 0x0000C248
		public virtual void OnMatchCreate(CreateMatchResponse matchInfo)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager OnMatchCreate " + matchInfo);
			}
			if (matchInfo.success)
			{
				Utility.SetAccessTokenForNetwork(matchInfo.networkId, new NetworkAccessToken(matchInfo.accessTokenString));
				this.StartHost(new MatchInfo(matchInfo));
			}
			else if (LogFilter.logError)
			{
				Debug.LogError("Create Failed:" + matchInfo);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000E0BC File Offset: 0x0000C2BC
		public virtual void OnMatchList(ListMatchResponse matchList)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager OnMatchList ");
			}
			this.matches = matchList.matches;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000E0EC File Offset: 0x0000C2EC
		public void OnMatchJoined(JoinMatchResponse matchInfo)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkManager OnMatchJoined ");
			}
			if (matchInfo.success)
			{
				Utility.SetAccessTokenForNetwork(matchInfo.networkId, new NetworkAccessToken(matchInfo.accessTokenString));
				this.StartClient(new MatchInfo(matchInfo));
			}
			else if (LogFilter.logError)
			{
				Debug.LogError("Join Failed:" + matchInfo);
			}
		}

		// Token: 0x04000126 RID: 294
		[SerializeField]
		private int m_NetworkPort = 7777;

		// Token: 0x04000127 RID: 295
		[SerializeField]
		private bool m_ServerBindToIP;

		// Token: 0x04000128 RID: 296
		[SerializeField]
		private string m_ServerBindAddress = string.Empty;

		// Token: 0x04000129 RID: 297
		[SerializeField]
		private string m_NetworkAddress = "localhost";

		// Token: 0x0400012A RID: 298
		[SerializeField]
		private bool m_DontDestroyOnLoad = true;

		// Token: 0x0400012B RID: 299
		[SerializeField]
		private bool m_RunInBackground = true;

		// Token: 0x0400012C RID: 300
		[SerializeField]
		private bool m_ScriptCRCCheck = true;

		// Token: 0x0400012D RID: 301
		[SerializeField]
		private bool m_SendPeerInfo;

		// Token: 0x0400012E RID: 302
		[SerializeField]
		private float m_MaxDelay = 0.01f;

		// Token: 0x0400012F RID: 303
		[SerializeField]
		private LogFilter.FilterLevel m_LogLevel = LogFilter.FilterLevel.Info;

		// Token: 0x04000130 RID: 304
		[SerializeField]
		private GameObject m_PlayerPrefab;

		// Token: 0x04000131 RID: 305
		[SerializeField]
		private bool m_AutoCreatePlayer = true;

		// Token: 0x04000132 RID: 306
		[SerializeField]
		private PlayerSpawnMethod m_PlayerSpawnMethod;

		// Token: 0x04000133 RID: 307
		[SerializeField]
		private string m_OfflineScene = string.Empty;

		// Token: 0x04000134 RID: 308
		[SerializeField]
		private string m_OnlineScene = string.Empty;

		// Token: 0x04000135 RID: 309
		[SerializeField]
		private List<GameObject> m_SpawnPrefabs = new List<GameObject>();

		// Token: 0x04000136 RID: 310
		[SerializeField]
		private bool m_CustomConfig;

		// Token: 0x04000137 RID: 311
		[SerializeField]
		private int m_MaxConnections = 4;

		// Token: 0x04000138 RID: 312
		[SerializeField]
		private ConnectionConfig m_ConnectionConfig;

		// Token: 0x04000139 RID: 313
		[SerializeField]
		private List<QosType> m_Channels = new List<QosType>();

		// Token: 0x0400013A RID: 314
		[SerializeField]
		private bool m_UseWebSockets;

		// Token: 0x0400013B RID: 315
		[SerializeField]
		private bool m_UseSimulator;

		// Token: 0x0400013C RID: 316
		[SerializeField]
		private int m_SimulatedLatency = 1;

		// Token: 0x0400013D RID: 317
		[SerializeField]
		private float m_PacketLossPercentage;

		// Token: 0x0400013E RID: 318
		[SerializeField]
		private string m_MatchHost = "mm.unet.unity3d.com";

		// Token: 0x0400013F RID: 319
		[SerializeField]
		private int m_MatchPort = 443;

		// Token: 0x04000140 RID: 320
		private EndPoint m_EndPoint;

		// Token: 0x04000141 RID: 321
		public static string networkSceneName = string.Empty;

		// Token: 0x04000142 RID: 322
		public bool isNetworkActive;

		// Token: 0x04000143 RID: 323
		public NetworkClient client;

		// Token: 0x04000144 RID: 324
		private static List<Transform> s_StartPositions = new List<Transform>();

		// Token: 0x04000145 RID: 325
		private static int s_StartPositionIndex;

		// Token: 0x04000146 RID: 326
		public MatchInfo matchInfo;

		// Token: 0x04000147 RID: 327
		public NetworkMatch matchMaker;

		// Token: 0x04000148 RID: 328
		public List<MatchDesc> matches;

		// Token: 0x04000149 RID: 329
		public string matchName = "default";

		// Token: 0x0400014A RID: 330
		public uint matchSize = 4U;

		// Token: 0x0400014B RID: 331
		public static NetworkManager singleton;

		// Token: 0x0400014C RID: 332
		private static AddPlayerMessage s_AddPlayerMessage = new AddPlayerMessage();

		// Token: 0x0400014D RID: 333
		private static RemovePlayerMessage s_RemovePlayerMessage = new RemovePlayerMessage();

		// Token: 0x0400014E RID: 334
		private static ErrorMessage s_ErrorMessage = new ErrorMessage();

		// Token: 0x0400014F RID: 335
		private static AsyncOperation s_LoadingSceneAsync;

		// Token: 0x04000150 RID: 336
		private static NetworkConnection s_ClientReadyConnection;

		// Token: 0x04000151 RID: 337
		private static string s_Address;
	}
}
