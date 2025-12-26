using System;
using System.Collections.Generic;
using UnityEngine.Networking.Match;
using UnityEngine.Networking.NetworkSystem;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking
{
	// Token: 0x0200004B RID: 75
	public sealed class NetworkServer
	{
		// Token: 0x06000342 RID: 834 RVA: 0x00010190 File Offset: 0x0000E390
		private NetworkServer()
		{
			NetworkTransport.Init();
			if (LogFilter.logDev)
			{
				Debug.Log("NetworkServer Created version " + Version.Current);
			}
			this.m_MsgBuffer = new byte[49152];
			this.m_RemoveList = new HashSet<NetworkInstanceId>();
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00010268 File Offset: 0x0000E468
		public static Dictionary<short, NetworkMessageDelegate> handlers
		{
			get
			{
				return NetworkServer.instance.m_MessageHandlers.GetHandlers();
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0001027C File Offset: 0x0000E47C
		public static List<NetworkConnection> connections
		{
			get
			{
				return NetworkServer.instance.m_Connections.connections;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00010290 File Offset: 0x0000E490
		public static List<NetworkConnection> localConnections
		{
			get
			{
				return NetworkServer.instance.m_Connections.localConnections;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000347 RID: 839 RVA: 0x000102A4 File Offset: 0x0000E4A4
		public static Dictionary<NetworkInstanceId, NetworkIdentity> objects
		{
			get
			{
				return NetworkServer.s_NetworkScene.localObjects;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000348 RID: 840 RVA: 0x000102B0 File Offset: 0x0000E4B0
		// (set) Token: 0x06000349 RID: 841 RVA: 0x000102BC File Offset: 0x0000E4BC
		public static bool useWebSockets
		{
			get
			{
				return NetworkServer.instance.m_UseWebSockets;
			}
			set
			{
				NetworkServer.instance.m_UseWebSockets = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600034A RID: 842 RVA: 0x000102CC File Offset: 0x0000E4CC
		// (set) Token: 0x0600034B RID: 843 RVA: 0x000102D8 File Offset: 0x0000E4D8
		public static bool sendPeerInfo
		{
			get
			{
				return NetworkServer.instance.m_SendPeerInfo;
			}
			set
			{
				NetworkServer.instance.m_SendPeerInfo = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600034C RID: 844 RVA: 0x000102E8 File Offset: 0x0000E4E8
		public static Type networkConnectionClass
		{
			get
			{
				return NetworkServer.s_NetworkConnectionClass;
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000102F0 File Offset: 0x0000E4F0
		public static void SetNetworkConnectionClass<T>() where T : NetworkConnection
		{
			NetworkServer.s_NetworkConnectionClass = typeof(T);
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00010304 File Offset: 0x0000E504
		internal static NetworkServer instance
		{
			get
			{
				if (NetworkServer.s_Instance == null)
				{
					object obj = NetworkServer.s_Sync;
					lock (obj)
					{
						if (NetworkServer.s_Instance == null)
						{
							NetworkServer.s_Instance = new NetworkServer();
						}
					}
				}
				return NetworkServer.s_Instance;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00010370 File Offset: 0x0000E570
		public static bool active
		{
			get
			{
				return NetworkServer.s_Active;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00010378 File Offset: 0x0000E578
		public static bool localClientActive
		{
			get
			{
				return NetworkServer.s_LocalClientActive;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00010380 File Offset: 0x0000E580
		public static int numChannels
		{
			get
			{
				return NetworkServer.instance.m_HostTopology.DefaultConfig.ChannelCount;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00010398 File Offset: 0x0000E598
		// (set) Token: 0x06000353 RID: 851 RVA: 0x000103A4 File Offset: 0x0000E5A4
		public static float maxDelay
		{
			get
			{
				return NetworkServer.instance.m_MaxDelay;
			}
			set
			{
				NetworkServer.instance.InternalSetMaxDelay(value);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000354 RID: 852 RVA: 0x000103B4 File Offset: 0x0000E5B4
		public static HostTopology hostTopology
		{
			get
			{
				return NetworkServer.instance.m_HostTopology;
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000103C0 File Offset: 0x0000E5C0
		public static bool Configure(ConnectionConfig config, int maxConnections)
		{
			HostTopology hostTopology = new HostTopology(config, maxConnections);
			return NetworkServer.Configure(hostTopology);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000103DC File Offset: 0x0000E5DC
		public static bool Configure(HostTopology topology)
		{
			NetworkServer.instance.m_HostTopology = topology;
			return true;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000103EC File Offset: 0x0000E5EC
		public static void Reset()
		{
			NetworkTransport.Shutdown();
			NetworkTransport.Init();
			NetworkServer.s_NetworkConnectionClass = typeof(NetworkConnection);
			NetworkServer.s_Instance = null;
			NetworkServer.s_Active = false;
			NetworkServer.s_LocalClientActive = false;
			NetworkServer.s_ExternalConnections = new HashSet<int>();
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00010428 File Offset: 0x0000E628
		public static void Shutdown()
		{
			if (NetworkServer.s_Instance != null)
			{
				NetworkServer.s_Instance.InternalDisconnectAll();
				if (NetworkServer.s_Instance.m_ServerId != -1)
				{
					NetworkTransport.RemoveHost(NetworkServer.s_Instance.m_ServerId);
					NetworkServer.s_Instance.m_ServerId = -1;
				}
				NetworkServer.s_Instance = null;
			}
			NetworkServer.s_ExternalConnections = new HashSet<int>();
			NetworkServer.s_Active = false;
			NetworkServer.s_LocalClientActive = false;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0001049C File Offset: 0x0000E69C
		public static bool Listen(MatchInfo matchInfo, int listenPort)
		{
			if (!matchInfo.usingRelay)
			{
				return NetworkServer.instance.InternalListen(null, listenPort);
			}
			NetworkServer.instance.InternalListenRelay(matchInfo.address, matchInfo.port, matchInfo.networkId, Utility.GetSourceID(), matchInfo.nodeId, listenPort);
			return true;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000104EC File Offset: 0x0000E6EC
		public static void ListenRelay(string relayIp, int relayPort, NetworkID netGuid, SourceID sourceId, NodeID nodeId)
		{
			NetworkServer.instance.InternalListenRelay(relayIp, relayPort, netGuid, sourceId, nodeId, 0);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0001050C File Offset: 0x0000E70C
		internal void InternalListenRelay(string relayIp, int relayPort, NetworkID netGuid, SourceID sourceId, NodeID nodeId, int listenPort)
		{
			if (this.m_HostTopology == null)
			{
				ConnectionConfig connectionConfig = new ConnectionConfig();
				connectionConfig.AddChannel(QosType.Reliable);
				connectionConfig.AddChannel(QosType.Unreliable);
				this.m_HostTopology = new HostTopology(connectionConfig, 8);
			}
			this.m_ServerId = NetworkTransport.AddHost(this.m_HostTopology, listenPort);
			if (LogFilter.logDebug)
			{
				Debug.Log("Server Host Slot Id: " + this.m_ServerId);
			}
			NetworkServer.Update();
			byte b;
			NetworkTransport.ConnectAsNetworkHost(this.m_ServerId, relayIp, relayPort, netGuid, sourceId, nodeId, out b);
			this.m_RelaySlotId = 0;
			if (LogFilter.logDebug)
			{
				Debug.Log("Relay Slot Id: " + this.m_RelaySlotId);
			}
			if (b != 0)
			{
				Debug.Log("ListenRelay Error: " + b);
			}
			NetworkServer.s_Active = true;
			this.m_MessageHandlers.RegisterHandlerSafe(35, new NetworkMessageDelegate(NetworkServer.OnClientReadyMessage));
			this.m_MessageHandlers.RegisterHandlerSafe(5, new NetworkMessageDelegate(NetworkServer.OnCommandMessage));
			this.m_MessageHandlers.RegisterHandlerSafe(6, new NetworkMessageDelegate(NetworkTransform.HandleTransform));
			this.m_MessageHandlers.RegisterHandlerSafe(16, new NetworkMessageDelegate(NetworkTransformChild.HandleChildTransform));
			this.m_MessageHandlers.RegisterHandlerSafe(40, new NetworkMessageDelegate(NetworkAnimator.OnAnimationServerMessage));
			this.m_MessageHandlers.RegisterHandlerSafe(41, new NetworkMessageDelegate(NetworkAnimator.OnAnimationParametersServerMessage));
			this.m_MessageHandlers.RegisterHandlerSafe(42, new NetworkMessageDelegate(NetworkAnimator.OnAnimationTriggerServerMessage));
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00010690 File Offset: 0x0000E890
		public static bool Listen(int serverPort)
		{
			return NetworkServer.instance.InternalListen(null, serverPort);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000106A0 File Offset: 0x0000E8A0
		public static bool Listen(string ipAddress, int serverPort)
		{
			return NetworkServer.instance.InternalListen(ipAddress, serverPort);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000106B0 File Offset: 0x0000E8B0
		internal bool InternalListen(string ipAddress, int serverPort)
		{
			if (this.m_HostTopology == null)
			{
				ConnectionConfig connectionConfig = new ConnectionConfig();
				connectionConfig.AddChannel(QosType.Reliable);
				connectionConfig.AddChannel(QosType.Unreliable);
				this.m_HostTopology = new HostTopology(connectionConfig, 8);
			}
			if (LogFilter.logDebug)
			{
				Debug.Log("Server Listen. port: " + serverPort);
			}
			if (string.IsNullOrEmpty(ipAddress))
			{
				if (this.m_UseWebSockets)
				{
					this.m_ServerId = NetworkTransport.AddWebsocketHost(this.m_HostTopology, serverPort);
				}
				else
				{
					this.m_ServerId = NetworkTransport.AddHost(this.m_HostTopology, serverPort);
				}
			}
			else if (this.m_UseWebSockets)
			{
				this.m_ServerId = NetworkTransport.AddWebsocketHost(this.m_HostTopology, serverPort, ipAddress);
			}
			else
			{
				this.m_ServerId = NetworkTransport.AddHost(this.m_HostTopology, serverPort, ipAddress);
			}
			if (this.m_ServerId == -1)
			{
				return false;
			}
			this.m_ServerPort = serverPort;
			NetworkServer.s_Active = true;
			NetworkServer.maxPacketSize = NetworkServer.hostTopology.DefaultConfig.PacketSize;
			this.m_MessageHandlers.RegisterHandlerSafe(35, new NetworkMessageDelegate(NetworkServer.OnClientReadyMessage));
			this.m_MessageHandlers.RegisterHandlerSafe(5, new NetworkMessageDelegate(NetworkServer.OnCommandMessage));
			this.m_MessageHandlers.RegisterHandlerSafe(6, new NetworkMessageDelegate(NetworkTransform.HandleTransform));
			this.m_MessageHandlers.RegisterHandlerSafe(16, new NetworkMessageDelegate(NetworkTransformChild.HandleChildTransform));
			this.m_MessageHandlers.RegisterHandlerSafe(38, new NetworkMessageDelegate(NetworkServer.OnRemovePlayerMessage));
			this.m_MessageHandlers.RegisterHandlerSafe(40, new NetworkMessageDelegate(NetworkAnimator.OnAnimationServerMessage));
			this.m_MessageHandlers.RegisterHandlerSafe(41, new NetworkMessageDelegate(NetworkAnimator.OnAnimationParametersServerMessage));
			this.m_MessageHandlers.RegisterHandlerSafe(42, new NetworkMessageDelegate(NetworkAnimator.OnAnimationTriggerServerMessage));
			return true;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0001087C File Offset: 0x0000EA7C
		internal void InternalSetMaxDelay(float seconds)
		{
			for (int i = this.m_Connections.LocalIndex; i < this.m_Connections.Count; i++)
			{
				NetworkConnection networkConnection = this.m_Connections.Get(i);
				if (networkConnection != null)
				{
					networkConnection.SetMaxDelay(seconds);
				}
			}
			this.m_MaxDelay = seconds;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000108D0 File Offset: 0x0000EAD0
		internal int AddLocalClient(LocalClient localClient)
		{
			this.m_LocalClients.Add(localClient);
			ULocalConnectionToClient ulocalConnectionToClient = new ULocalConnectionToClient(localClient);
			ulocalConnectionToClient.SetHandlers(this.m_MessageHandlers);
			ulocalConnectionToClient.InvokeHandlerNoData(32);
			return this.m_Connections.AddLocal(ulocalConnectionToClient);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00010914 File Offset: 0x0000EB14
		internal void SetLocalObjectOnServer(NetworkInstanceId netId, GameObject obj)
		{
			if (LogFilter.logDev)
			{
				Debug.Log(string.Concat(new object[] { "SetLocalObjectOnServer ", netId, " ", obj }));
			}
			NetworkServer.s_NetworkScene.SetLocalObject(netId, obj, false, true);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00010968 File Offset: 0x0000EB68
		internal void ActivateLocalClientScene()
		{
			if (NetworkServer.s_LocalClientActive)
			{
				return;
			}
			NetworkServer.s_LocalClientActive = true;
			foreach (NetworkIdentity networkIdentity in NetworkServer.objects.Values)
			{
				if (!networkIdentity.isClient)
				{
					if (LogFilter.logDev)
					{
						Debug.Log(string.Concat(new object[] { "ActivateClientScene ", networkIdentity.netId, " ", networkIdentity.gameObject }));
					}
					ClientScene.SetLocalObject(networkIdentity.netId, networkIdentity.gameObject);
					networkIdentity.OnStartClient();
				}
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00010A40 File Offset: 0x0000EC40
		public static bool SendToAll(short msgType, MessageBase msg)
		{
			if (LogFilter.logDev)
			{
				Debug.Log("Server.SendToAll msgType:" + msgType);
			}
			ConnectionArray connections = NetworkServer.instance.m_Connections;
			bool flag = true;
			for (int i = connections.LocalIndex; i < connections.Count; i++)
			{
				NetworkConnection networkConnection = connections.Get(i);
				if (networkConnection != null)
				{
					flag &= networkConnection.Send(msgType, msg);
				}
			}
			return flag;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00010AB0 File Offset: 0x0000ECB0
		private static bool SendToObservers(GameObject contextObj, short msgType, MessageBase msg)
		{
			if (LogFilter.logDev)
			{
				Debug.Log("Server.SendToObservers id:" + msgType);
			}
			bool flag = true;
			NetworkIdentity component = contextObj.GetComponent<NetworkIdentity>();
			if (component == null || component.observers == null)
			{
				return false;
			}
			int count = component.observers.Count;
			for (int i = 0; i < count; i++)
			{
				NetworkConnection networkConnection = component.observers[i];
				flag &= networkConnection.Send(msgType, msg);
			}
			return flag;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00010B38 File Offset: 0x0000ED38
		public static bool SendToReady(GameObject contextObj, short msgType, MessageBase msg)
		{
			if (LogFilter.logDev)
			{
				Debug.Log("Server.SendToReady id:" + msgType);
			}
			if (contextObj == null)
			{
				for (int i = NetworkServer.s_Instance.m_Connections.LocalIndex; i < NetworkServer.s_Instance.m_Connections.Count; i++)
				{
					NetworkConnection networkConnection = NetworkServer.s_Instance.m_Connections.Get(i);
					if (networkConnection != null && networkConnection.isReady)
					{
						networkConnection.Send(msgType, msg);
					}
				}
				return true;
			}
			bool flag = true;
			NetworkIdentity component = contextObj.GetComponent<NetworkIdentity>();
			if (component == null || component.observers == null)
			{
				return false;
			}
			int count = component.observers.Count;
			for (int j = 0; j < count; j++)
			{
				NetworkConnection networkConnection2 = component.observers[j];
				if (networkConnection2.isReady)
				{
					flag &= networkConnection2.Send(msgType, msg);
				}
			}
			return flag;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00010C44 File Offset: 0x0000EE44
		public static void SendWriterToReady(GameObject contextObj, NetworkWriter writer, int channelId)
		{
			if (writer.AsArraySegment().Count > 32767)
			{
				throw new UnityException("NetworkWriter used buffer is too big!");
			}
			NetworkServer.SendBytesToReady(contextObj, writer.AsArraySegment().Array, writer.AsArraySegment().Count, channelId);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00010C98 File Offset: 0x0000EE98
		public static void SendBytesToReady(GameObject contextObj, byte[] buffer, int numBytes, int channelId)
		{
			if (contextObj == null)
			{
				bool flag = true;
				for (int i = NetworkServer.s_Instance.m_Connections.LocalIndex; i < NetworkServer.s_Instance.m_Connections.Count; i++)
				{
					NetworkConnection networkConnection = NetworkServer.s_Instance.m_Connections.Get(i);
					if (networkConnection != null && networkConnection.isReady && !networkConnection.SendBytes(buffer, numBytes, channelId))
					{
						flag = false;
					}
				}
				if (!flag && LogFilter.logWarn)
				{
					Debug.LogWarning("SendBytesToReady failed");
				}
				return;
			}
			NetworkIdentity component = contextObj.GetComponent<NetworkIdentity>();
			try
			{
				bool flag2 = true;
				int count = component.observers.Count;
				for (int j = 0; j < count; j++)
				{
					NetworkConnection networkConnection2 = component.observers[j];
					if (networkConnection2.isReady)
					{
						if (!networkConnection2.SendBytes(buffer, numBytes, channelId))
						{
							flag2 = false;
						}
					}
				}
				if (!flag2 && LogFilter.logWarn)
				{
					Debug.LogWarning("SendBytesToReady failed for " + contextObj);
				}
			}
			catch (NullReferenceException)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("SendBytesToReady object " + contextObj + " has not been spawned");
				}
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00010DFC File Offset: 0x0000EFFC
		public static void SendBytesToPlayer(GameObject player, byte[] buffer, int numBytes, int channelId)
		{
			ConnectionArray connections = NetworkServer.instance.m_Connections;
			NetworkConnection networkConnection;
			if (connections.ContainsPlayer(player, out networkConnection))
			{
				networkConnection.SendBytes(buffer, numBytes, channelId);
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00010E2C File Offset: 0x0000F02C
		public static bool SendUnreliableToAll(short msgType, MessageBase msg)
		{
			if (LogFilter.logDev)
			{
				Debug.Log("Server.SendUnreliableToAll msgType:" + msgType);
			}
			ConnectionArray connections = NetworkServer.instance.m_Connections;
			bool flag = true;
			for (int i = connections.LocalIndex; i < connections.Count; i++)
			{
				NetworkConnection networkConnection = connections.Get(i);
				if (networkConnection != null)
				{
					flag &= networkConnection.SendUnreliable(msgType, msg);
				}
			}
			return flag;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00010E9C File Offset: 0x0000F09C
		public static bool SendUnreliableToReady(GameObject contextObj, short msgType, MessageBase msg)
		{
			if (LogFilter.logDev)
			{
				Debug.Log("Server.SendUnreliableToReady id:" + msgType);
			}
			if (contextObj == null)
			{
				for (int i = NetworkServer.s_Instance.m_Connections.LocalIndex; i < NetworkServer.s_Instance.m_Connections.Count; i++)
				{
					NetworkConnection networkConnection = NetworkServer.s_Instance.m_Connections.Get(i);
					if (networkConnection != null && networkConnection.isReady)
					{
						networkConnection.SendUnreliable(msgType, msg);
					}
				}
				return true;
			}
			bool flag = true;
			NetworkIdentity component = contextObj.GetComponent<NetworkIdentity>();
			int count = component.observers.Count;
			for (int j = 0; j < count; j++)
			{
				NetworkConnection networkConnection2 = component.observers[j];
				if (networkConnection2.isReady)
				{
					flag &= networkConnection2.SendUnreliable(msgType, msg);
				}
			}
			return flag;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00010F90 File Offset: 0x0000F190
		public static bool SendByChannelToAll(short msgType, MessageBase msg, int channelId)
		{
			if (LogFilter.logDev)
			{
				Debug.Log("Server.SendByChannelToAll id:" + msgType);
			}
			ConnectionArray connections = NetworkServer.instance.m_Connections;
			bool flag = true;
			for (int i = connections.LocalIndex; i < connections.Count; i++)
			{
				NetworkConnection networkConnection = connections.Get(i);
				if (networkConnection != null)
				{
					flag &= networkConnection.SendByChannel(msgType, msg, channelId);
				}
			}
			return flag;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00011000 File Offset: 0x0000F200
		public static bool SendByChannelToReady(GameObject contextObj, short msgType, MessageBase msg, int channelId)
		{
			if (LogFilter.logDev)
			{
				Debug.Log("Server.SendByChannelToReady msgType:" + msgType);
			}
			if (contextObj == null)
			{
				for (int i = NetworkServer.s_Instance.m_Connections.LocalIndex; i < NetworkServer.s_Instance.m_Connections.Count; i++)
				{
					NetworkConnection networkConnection = NetworkServer.s_Instance.m_Connections.Get(i);
					if (networkConnection != null && networkConnection.isReady)
					{
						networkConnection.SendByChannel(msgType, msg, channelId);
					}
				}
				return true;
			}
			bool flag = true;
			NetworkIdentity component = contextObj.GetComponent<NetworkIdentity>();
			int count = component.observers.Count;
			for (int j = 0; j < count; j++)
			{
				NetworkConnection networkConnection2 = component.observers[j];
				if (networkConnection2.isReady)
				{
					flag &= networkConnection2.SendByChannel(msgType, msg, channelId);
				}
			}
			return flag;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000110F8 File Offset: 0x0000F2F8
		public static void DisconnectAll()
		{
			NetworkServer.instance.InternalDisconnectAll();
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00011104 File Offset: 0x0000F304
		internal void InternalDisconnectAll()
		{
			for (int i = this.m_Connections.LocalIndex; i < this.m_Connections.Count; i++)
			{
				NetworkConnection networkConnection = this.m_Connections.Get(i);
				if (networkConnection != null)
				{
					networkConnection.Disconnect();
					networkConnection.Dispose();
				}
			}
			NetworkServer.s_Active = false;
			NetworkServer.s_LocalClientActive = false;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00011164 File Offset: 0x0000F364
		internal static void Update()
		{
			if (NetworkServer.s_Instance != null)
			{
				NetworkServer.s_Instance.InternalUpdate();
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00011180 File Offset: 0x0000F380
		internal void UpdateServerObjects()
		{
			foreach (NetworkIdentity networkIdentity in NetworkServer.objects.Values)
			{
				try
				{
					networkIdentity.UNetUpdate();
				}
				catch (NullReferenceException)
				{
				}
			}
			if (this.m_RemoveListCount++ % 100 == 0)
			{
				this.CheckForNullObjects();
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0001122C File Offset: 0x0000F42C
		private void CheckForNullObjects()
		{
			foreach (NetworkInstanceId networkInstanceId in NetworkServer.objects.Keys)
			{
				NetworkIdentity networkIdentity = NetworkServer.objects[networkInstanceId];
				if (networkIdentity == null || networkIdentity.gameObject == null)
				{
					this.m_RemoveList.Add(networkInstanceId);
				}
			}
			if (this.m_RemoveList.Count > 0)
			{
				foreach (NetworkInstanceId networkInstanceId2 in this.m_RemoveList)
				{
					NetworkServer.objects.Remove(networkInstanceId2);
				}
				this.m_RemoveList.Clear();
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00011340 File Offset: 0x0000F540
		internal void InternalUpdate()
		{
			if (this.m_ServerId == -1 || !NetworkTransport.IsStarted)
			{
				return;
			}
			int num = 0;
			byte b;
			if (this.m_RelaySlotId != -1)
			{
				NetworkEventType networkEventType = NetworkTransport.ReceiveRelayEventFromHost(this.m_ServerId, out b);
				if (networkEventType != NetworkEventType.Nothing && LogFilter.logDebug)
				{
					Debug.Log("NetGroup event:" + networkEventType);
				}
				if (networkEventType == NetworkEventType.ConnectEvent && LogFilter.logDebug)
				{
					Debug.Log("NetGroup server connected");
				}
				if (networkEventType == NetworkEventType.DisconnectEvent && LogFilter.logDebug)
				{
					Debug.Log("NetGroup server disconnected");
				}
			}
			NetworkConnection networkConnection;
			for (;;)
			{
				int num2;
				int num3;
				int num4;
				NetworkEventType networkEventType = NetworkTransport.ReceiveFromHost(this.m_ServerId, out num2, out num3, this.m_MsgBuffer, (int)((ushort)this.m_MsgBuffer.Length), out num4, out b);
				if (networkEventType != NetworkEventType.Nothing && LogFilter.logDev)
				{
					Debug.Log(string.Concat(new object[] { "Server event: host=", this.m_ServerId, " event=", networkEventType, " error=", b }));
				}
				switch (networkEventType)
				{
				case NetworkEventType.DataEvent:
					networkConnection = this.m_Connections.Get(num2);
					if (b != 0)
					{
						goto Block_15;
					}
					if (networkConnection != null)
					{
						networkConnection.TransportRecieve(this.m_MsgBuffer, num4, num3);
					}
					else if (LogFilter.logError)
					{
						Debug.LogError("Unknown connection data event?!?");
					}
					break;
				case NetworkEventType.ConnectEvent:
				{
					if (LogFilter.logDebug)
					{
						Debug.Log("Server accepted client:" + num2);
					}
					if (b != 0)
					{
						goto Block_13;
					}
					string text;
					int num5;
					NetworkID networkID;
					NodeID nodeID;
					byte b2;
					NetworkTransport.GetConnectionInfo(this.m_ServerId, num2, out text, out num5, out networkID, out nodeID, out b2);
					NetworkConnection networkConnection2 = (NetworkConnection)Activator.CreateInstance(NetworkServer.s_NetworkConnectionClass);
					networkConnection2.SetHandlers(this.m_MessageHandlers);
					networkConnection2.Initialize(text, this.m_ServerId, num2, this.m_HostTopology);
					networkConnection2.SetMaxDelay(this.m_MaxDelay);
					this.m_Connections.Add(num2, networkConnection2);
					networkConnection2.InvokeHandlerNoData(32);
					if (this.m_SendPeerInfo)
					{
						this.SendNetworkInfo(networkConnection2);
					}
					NetworkServer.SendCrc(networkConnection2);
					break;
				}
				case NetworkEventType.DisconnectEvent:
				{
					NetworkConnection @unsafe = this.m_Connections.GetUnsafe(num2);
					if (b != 0)
					{
						if (b != 6)
						{
							this.GenerateDisconnectError(@unsafe, (int)b);
						}
					}
					this.m_Connections.Remove(num2);
					if (@unsafe != null)
					{
						@unsafe.InvokeHandlerNoData(33);
						for (int i = 0; i < @unsafe.playerControllers.Count; i++)
						{
							if (@unsafe.playerControllers[i].gameObject != null && LogFilter.logWarn)
							{
								Debug.LogWarning("Player not destroyed when connection disconnected.");
							}
						}
						if (LogFilter.logDebug)
						{
							Debug.Log("Server lost client:" + num2);
						}
						@unsafe.RemoveObservers();
						@unsafe.Dispose();
					}
					else if (LogFilter.logDebug)
					{
						Debug.Log("Connection is null in disconnect event");
					}
					if (this.m_SendPeerInfo)
					{
						this.SendNetworkInfo(@unsafe);
					}
					break;
				}
				case NetworkEventType.Nothing:
					break;
				default:
					if (LogFilter.logError)
					{
						Debug.LogError("Unknown network message type received: " + networkEventType);
					}
					break;
				}
				if (++num >= 500)
				{
					goto Block_28;
				}
				if (networkEventType == NetworkEventType.Nothing)
				{
					goto IL_039D;
				}
			}
			Block_13:
			this.GenerateConnectError((int)b);
			return;
			Block_15:
			this.GenerateDataError(networkConnection, (int)b);
			return;
			Block_28:
			if (LogFilter.logDebug)
			{
				Debug.Log("kMaxEventsPerFrame hit (" + 500 + ")");
			}
			IL_039D:
			this.UpdateServerObjects();
			for (int j = this.m_Connections.LocalIndex; j < this.m_Connections.Count; j++)
			{
				NetworkConnection networkConnection3 = this.m_Connections.Get(j);
				if (networkConnection3 != null)
				{
					networkConnection3.FlushChannels();
				}
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00011738 File Offset: 0x0000F938
		private void GenerateConnectError(int error)
		{
			if (LogFilter.logError)
			{
				Debug.LogError("UNet Server Connect Error: " + error);
			}
			this.GenerateError(null, error);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00011764 File Offset: 0x0000F964
		private void GenerateDataError(NetworkConnection conn, int error)
		{
			if (LogFilter.logError)
			{
				Debug.LogError("UNet Server Data Error: " + (NetworkError)error);
			}
			this.GenerateError(conn, error);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0001179C File Offset: 0x0000F99C
		private void GenerateDisconnectError(NetworkConnection conn, int error)
		{
			if (LogFilter.logError)
			{
				Debug.LogError(string.Concat(new object[]
				{
					"UNet Server Disconnect Error: ",
					(NetworkError)error,
					" conn:[",
					conn,
					"]:",
					conn.connectionId
				}));
			}
			this.GenerateError(conn, error);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00011800 File Offset: 0x0000FA00
		private void GenerateError(NetworkConnection conn, int error)
		{
			NetworkMessageDelegate handler = this.m_MessageHandlers.GetHandler(34);
			if (handler != null)
			{
				ErrorMessage errorMessage = new ErrorMessage();
				errorMessage.errorCode = error;
				NetworkWriter networkWriter = new NetworkWriter();
				errorMessage.Serialize(networkWriter);
				NetworkReader networkReader = new NetworkReader(networkWriter);
				conn.InvokeHandler(34, networkReader, 0);
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00011850 File Offset: 0x0000FA50
		public static void RegisterHandler(short msgType, NetworkMessageDelegate handler)
		{
			NetworkServer.instance.m_MessageHandlers.RegisterHandler(msgType, handler);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00011864 File Offset: 0x0000FA64
		public static void UnregisterHandler(short msgType)
		{
			NetworkServer.instance.m_MessageHandlers.UnregisterHandler(msgType);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00011878 File Offset: 0x0000FA78
		public static void ClearHandlers()
		{
			NetworkServer.instance.m_MessageHandlers.ClearMessageHandlers();
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0001188C File Offset: 0x0000FA8C
		public static void ClearSpawners()
		{
			NetworkScene.ClearSpawners();
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00011894 File Offset: 0x0000FA94
		public static void GetStatsOut(out int numMsgs, out int numBufferedMsgs, out int numBytes, out int lastBufferedPerSecond)
		{
			numMsgs = 0;
			numBufferedMsgs = 0;
			numBytes = 0;
			lastBufferedPerSecond = 0;
			ConnectionArray connections = NetworkServer.instance.m_Connections;
			for (int i = connections.LocalIndex; i < connections.Count; i++)
			{
				NetworkConnection networkConnection = connections.Get(i);
				if (networkConnection != null)
				{
					int num;
					int num2;
					int num3;
					int num4;
					networkConnection.GetStatsOut(out num, out num2, out num3, out num4);
					numMsgs += num;
					numBufferedMsgs += num2;
					numBytes += num3;
					lastBufferedPerSecond += num4;
				}
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0001190C File Offset: 0x0000FB0C
		public static void GetStatsIn(out int numMsgs, out int numBytes)
		{
			numMsgs = 0;
			numBytes = 0;
			ConnectionArray connections = NetworkServer.instance.m_Connections;
			for (int i = connections.LocalIndex; i < connections.Count; i++)
			{
				NetworkConnection networkConnection = connections.Get(i);
				if (networkConnection != null)
				{
					int num;
					int num2;
					networkConnection.GetStatsIn(out num, out num2);
					numMsgs += num;
					numBytes += num2;
				}
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0001196C File Offset: 0x0000FB6C
		public static void SendToClientOfPlayer(GameObject player, short msgType, MessageBase msg)
		{
			ConnectionArray connections = NetworkServer.instance.m_Connections;
			NetworkConnection networkConnection;
			if (connections.ContainsPlayer(player, out networkConnection))
			{
				networkConnection.Send(msgType, msg);
			}
			else if (LogFilter.logError)
			{
				Debug.LogError("Failed to send message to player object '" + player.name + ", not found in connection list");
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000119C4 File Offset: 0x0000FBC4
		public static void SendToClient(int connectionId, short msgType, MessageBase msg)
		{
			ConnectionArray connections = NetworkServer.instance.m_Connections;
			NetworkConnection networkConnection = connections.Get(connectionId);
			if (networkConnection != null)
			{
				networkConnection.Send(msgType, msg);
			}
			else if (LogFilter.logError)
			{
				Debug.LogError("Failed to send message to connection ID '" + connectionId + ", not found in connection list");
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00011A1C File Offset: 0x0000FC1C
		public static bool ReplacePlayerForConnection(NetworkConnection conn, GameObject player, short playerControllerId, NetworkHash128 assetId)
		{
			NetworkIdentity networkIdentity;
			if (NetworkServer.GetNetworkIdentity(player, out networkIdentity))
			{
				networkIdentity.SetDynamicAssetId(assetId);
			}
			return NetworkServer.instance.InternalReplacePlayerForConnection(conn, player, playerControllerId);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00011A4C File Offset: 0x0000FC4C
		public static bool ReplacePlayerForConnection(NetworkConnection conn, GameObject player, short playerControllerId)
		{
			return NetworkServer.instance.InternalReplacePlayerForConnection(conn, player, playerControllerId);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00011A5C File Offset: 0x0000FC5C
		public static bool AddPlayerForConnection(NetworkConnection conn, GameObject player, short playerControllerId, NetworkHash128 assetId)
		{
			NetworkIdentity networkIdentity;
			if (NetworkServer.GetNetworkIdentity(player, out networkIdentity))
			{
				networkIdentity.SetDynamicAssetId(assetId);
			}
			return NetworkServer.instance.InternalAddPlayerForConnection(conn, player, playerControllerId);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00011A8C File Offset: 0x0000FC8C
		public static bool AddPlayerForConnection(NetworkConnection conn, GameObject player, short playerControllerId)
		{
			return NetworkServer.instance.InternalAddPlayerForConnection(conn, player, playerControllerId);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00011A9C File Offset: 0x0000FC9C
		internal bool InternalAddPlayerForConnection(NetworkConnection conn, GameObject playerGameObject, short playerControllerId)
		{
			NetworkIdentity networkIdentity;
			if (!NetworkServer.GetNetworkIdentity(playerGameObject, out networkIdentity))
			{
				if (LogFilter.logError)
				{
					Debug.Log("AddPlayer: playerGameObject has no NetworkIdentity. Please add a NetworkIdentity to " + playerGameObject);
				}
				return false;
			}
			if (!NetworkServer.CheckPlayerControllerIdForConnection(conn, playerControllerId))
			{
				return false;
			}
			PlayerController playerController = null;
			GameObject gameObject = null;
			if (conn.GetPlayerController(playerControllerId, out playerController))
			{
				gameObject = playerController.gameObject;
			}
			if (gameObject != null)
			{
				if (LogFilter.logError)
				{
					Debug.Log("AddPlayer: player object already exists for playerControllerId of " + playerControllerId);
				}
				return false;
			}
			PlayerController playerController2 = new PlayerController(playerGameObject, playerControllerId);
			conn.SetPlayerController(playerController2);
			networkIdentity.SetConnectionToClient(conn, playerController2.playerControllerId);
			NetworkServer.SetClientReady(conn);
			if (this.SetupLocalPlayerForConnection(conn, networkIdentity, playerController2))
			{
				return true;
			}
			if (LogFilter.logDebug)
			{
				Debug.Log(string.Concat(new object[]
				{
					"Adding new playerGameObject object netId: ",
					playerGameObject.GetComponent<NetworkIdentity>().netId,
					" asset ID ",
					playerGameObject.GetComponent<NetworkIdentity>().assetId
				}));
			}
			NetworkServer.FinishPlayerForConnection(conn, networkIdentity, playerGameObject);
			if (networkIdentity.localPlayerAuthority)
			{
				networkIdentity.SetClientOwner(conn);
			}
			return true;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00011BC4 File Offset: 0x0000FDC4
		private static bool CheckPlayerControllerIdForConnection(NetworkConnection conn, short playerControllerId)
		{
			if (playerControllerId < 0)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("AddPlayer: playerControllerId of " + playerControllerId + " is negative");
				}
				return false;
			}
			if (playerControllerId > 32)
			{
				if (LogFilter.logError)
				{
					Debug.Log(string.Concat(new object[] { "AddPlayer: playerControllerId of ", playerControllerId, " is too high. max is ", 32 }));
				}
				return false;
			}
			if (playerControllerId > 16 && LogFilter.logWarn)
			{
				Debug.LogWarning("AddPlayer: playerControllerId of " + playerControllerId + " is unusually high");
			}
			return true;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00011C74 File Offset: 0x0000FE74
		private bool SetupLocalPlayerForConnection(NetworkConnection conn, NetworkIdentity uv, PlayerController newPlayerController)
		{
			if (LogFilter.logDev)
			{
				Debug.Log("NetworkServer SetupLocalPlayerForConnection netID:" + uv.netId);
			}
			ULocalConnectionToClient ulocalConnectionToClient = conn as ULocalConnectionToClient;
			if (ulocalConnectionToClient != null)
			{
				if (LogFilter.logDev)
				{
					Debug.Log("NetworkServer AddPlayer handling ULocalConnectionToClient");
				}
				if (uv.netId.IsEmpty())
				{
					uv.OnStartServer();
				}
				uv.RebuildObservers(true);
				this.SendSpawnMessage(uv, null);
				ulocalConnectionToClient.localClient.AddLocalPlayer(newPlayerController);
				uv.ForceAuthority(true);
				uv.SetLocalPlayer(newPlayerController.playerControllerId);
				return true;
			}
			return false;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00011D10 File Offset: 0x0000FF10
		private static void FinishPlayerForConnection(NetworkConnection conn, NetworkIdentity uv, GameObject playerGameObject)
		{
			if (uv.netId.IsEmpty())
			{
				NetworkServer.Spawn(playerGameObject);
			}
			conn.Send(4, new OwnerMessage
			{
				netId = uv.netId,
				playerControllerId = uv.playerControllerId
			});
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00011D60 File Offset: 0x0000FF60
		internal bool InternalReplacePlayerForConnection(NetworkConnection conn, GameObject playerGameObject, short playerControllerId)
		{
			NetworkIdentity networkIdentity;
			if (!NetworkServer.GetNetworkIdentity(playerGameObject, out networkIdentity))
			{
				if (LogFilter.logError)
				{
					Debug.LogError("ReplacePlayer: playerGameObject has no NetworkIdentity. Please add a NetworkIdentity to " + playerGameObject);
				}
				return false;
			}
			if (!NetworkServer.CheckPlayerControllerIdForConnection(conn, playerControllerId))
			{
				return false;
			}
			if (LogFilter.logDev)
			{
				Debug.Log("NetworkServer ReplacePlayer");
			}
			PlayerController playerController;
			if (conn.GetPlayerController(playerControllerId, out playerController))
			{
				playerController.unetView.SetNotLocalPlayer();
			}
			PlayerController playerController2 = new PlayerController(playerGameObject, playerControllerId);
			conn.SetPlayerController(playerController2);
			networkIdentity.SetConnectionToClient(conn, playerController2.playerControllerId);
			if (LogFilter.logDev)
			{
				Debug.Log("NetworkServer ReplacePlayer setup local");
			}
			if (this.SetupLocalPlayerForConnection(conn, networkIdentity, playerController2))
			{
				return true;
			}
			if (LogFilter.logDebug)
			{
				Debug.Log(string.Concat(new object[]
				{
					"Replacing playerGameObject object netId: ",
					playerGameObject.GetComponent<NetworkIdentity>().netId,
					" asset ID ",
					playerGameObject.GetComponent<NetworkIdentity>().assetId
				}));
			}
			NetworkServer.FinishPlayerForConnection(conn, networkIdentity, playerGameObject);
			if (networkIdentity.localPlayerAuthority)
			{
				networkIdentity.SetClientOwner(conn);
			}
			return true;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00011E7C File Offset: 0x0001007C
		private static bool GetNetworkIdentity(GameObject go, out NetworkIdentity view)
		{
			view = go.GetComponent<NetworkIdentity>();
			if (view == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("UNET failure. GameObject doesn't have NetworkIdentity.");
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00011EB8 File Offset: 0x000100B8
		public static void SetClientReady(NetworkConnection conn)
		{
			NetworkServer.instance.SetClientReadyInternal(conn);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00011EC8 File Offset: 0x000100C8
		internal void SetClientReadyInternal(NetworkConnection conn)
		{
			if (conn.isReady)
			{
				if (LogFilter.logDebug)
				{
					Debug.Log("SetClientReady conn " + conn.connectionId + " already ready");
				}
				return;
			}
			if (conn.playerControllers.Count == 0 && LogFilter.logDebug)
			{
				Debug.LogWarning("Ready with no player object");
			}
			conn.isReady = true;
			ULocalConnectionToClient ulocalConnectionToClient = conn as ULocalConnectionToClient;
			if (ulocalConnectionToClient != null)
			{
				if (LogFilter.logDev)
				{
					Debug.Log("NetworkServer Ready handling ULocalConnectionToClient");
				}
				foreach (NetworkIdentity networkIdentity in NetworkServer.objects.Values)
				{
					if (networkIdentity != null && networkIdentity.gameObject != null)
					{
						bool flag = networkIdentity.OnCheckObserver(conn);
						if (flag)
						{
							networkIdentity.AddObserver(conn);
						}
						if (!networkIdentity.isClient)
						{
							if (LogFilter.logDev)
							{
								Debug.Log("LocalClient.SetSpawnObject calling OnStartClient");
							}
							networkIdentity.OnStartClient();
						}
					}
				}
				return;
			}
			ObjectSpawnFinishedMessage objectSpawnFinishedMessage = new ObjectSpawnFinishedMessage();
			objectSpawnFinishedMessage.state = 0U;
			conn.Send(12, objectSpawnFinishedMessage);
			foreach (NetworkIdentity networkIdentity2 in NetworkServer.objects.Values)
			{
				if (networkIdentity2 == null)
				{
					if (LogFilter.logWarn)
					{
						Debug.LogWarning("Invalid object found in server local object list (null NetworkIdentity).");
					}
				}
				else
				{
					if (LogFilter.logDebug)
					{
						Debug.Log(string.Concat(new object[]
						{
							"Sending spawn message for current server objects name='",
							networkIdentity2.gameObject.name,
							"' netId=",
							networkIdentity2.netId
						}));
					}
					bool flag2 = networkIdentity2.OnCheckObserver(conn);
					if (flag2)
					{
						networkIdentity2.AddObserver(conn);
					}
				}
			}
			objectSpawnFinishedMessage.state = 1U;
			conn.Send(12, objectSpawnFinishedMessage);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00012110 File Offset: 0x00010310
		internal static void ShowForConnection(NetworkIdentity uv, NetworkConnection conn)
		{
			if (conn.isReady)
			{
				NetworkServer.instance.SendSpawnMessage(uv, conn);
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0001212C File Offset: 0x0001032C
		internal static void HideForConnection(NetworkIdentity uv, NetworkConnection conn)
		{
			conn.Send(13, new ObjectDestroyMessage
			{
				netId = uv.netId
			});
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00012158 File Offset: 0x00010358
		public static void SetAllClientsNotReady()
		{
			ConnectionArray connections = NetworkServer.instance.m_Connections;
			for (int i = connections.LocalIndex; i < connections.Count; i++)
			{
				NetworkConnection networkConnection = connections.Get(i);
				if (networkConnection != null)
				{
					NetworkServer.SetClientNotReady(networkConnection);
				}
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000121A0 File Offset: 0x000103A0
		public static void SetClientNotReady(NetworkConnection conn)
		{
			NetworkServer.instance.InternalSetClientNotReady(conn);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x000121B0 File Offset: 0x000103B0
		internal void InternalSetClientNotReady(NetworkConnection conn)
		{
			if (conn.isReady)
			{
				if (LogFilter.logDebug)
				{
					Debug.Log("PlayerNotReady " + conn);
				}
				conn.isReady = false;
				conn.RemoveObservers();
				NotReadyMessage notReadyMessage = new NotReadyMessage();
				conn.Send(36, notReadyMessage);
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00012200 File Offset: 0x00010400
		private static void OnClientReadyMessage(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("Default handler for ready message from " + netMsg.conn);
			}
			NetworkServer.SetClientReady(netMsg.conn);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00012238 File Offset: 0x00010438
		private static void OnRemovePlayerMessage(NetworkMessage netMsg)
		{
			netMsg.ReadMessage<RemovePlayerMessage>(NetworkServer.s_RemovePlayerMessage);
			PlayerController playerController = null;
			netMsg.conn.GetPlayerController(NetworkServer.s_RemovePlayerMessage.playerControllerId, out playerController);
			if (playerController != null)
			{
				netMsg.conn.RemovePlayerController(NetworkServer.s_RemovePlayerMessage.playerControllerId);
				NetworkServer.Destroy(playerController.gameObject);
			}
			else if (LogFilter.logError)
			{
				Debug.LogError("Received remove player message but could not find the player ID: " + NetworkServer.s_RemovePlayerMessage.playerControllerId);
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000122C0 File Offset: 0x000104C0
		private static void OnCommandMessage(NetworkMessage netMsg)
		{
			int num = (int)netMsg.reader.ReadPackedUInt32();
			NetworkInstanceId networkInstanceId = netMsg.reader.ReadNetworkId();
			GameObject gameObject = NetworkServer.FindLocalObject(networkInstanceId);
			if (gameObject == null)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("Instance not found when handling Command message [netId=" + networkInstanceId + "]");
				}
				return;
			}
			NetworkIdentity component = gameObject.GetComponent<NetworkIdentity>();
			if (component == null)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("NetworkIdentity deleted when handling Command message [netId=" + networkInstanceId + "]");
				}
				return;
			}
			bool flag = false;
			foreach (PlayerController playerController in netMsg.conn.playerControllers)
			{
				if (playerController.gameObject != null && playerController.gameObject.GetComponent<NetworkIdentity>().netId == component.netId)
				{
					flag = true;
					break;
				}
			}
			if (!flag && component.clientAuthorityOwner != netMsg.conn)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("Command for object without authority [netId=" + networkInstanceId + "]");
				}
				return;
			}
			if (LogFilter.logDev)
			{
				Debug.Log(string.Concat(new object[] { "OnCommandMessage for netId=", networkInstanceId, " conn=", netMsg.conn }));
			}
			component.HandleCommand(num, netMsg.reader);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00012474 File Offset: 0x00010674
		internal void SpawnObject(GameObject obj)
		{
			if (!NetworkServer.active)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("SpawnObject for " + obj + ", NetworkServer is not active. Cannot spawn objects without an active server.");
				}
				return;
			}
			NetworkIdentity networkIdentity;
			if (!NetworkServer.GetNetworkIdentity(obj, out networkIdentity))
			{
				if (LogFilter.logError)
				{
					Debug.LogError(string.Concat(new object[] { "SpawnObject ", obj, " has no NetworkIdentity. Please add a NetworkIdentity to ", obj }));
				}
				return;
			}
			networkIdentity.OnStartServer();
			if (LogFilter.logDebug)
			{
				Debug.Log(string.Concat(new object[] { "SpawnObject instance ID ", networkIdentity.netId, " asset ID ", networkIdentity.assetId }));
			}
			networkIdentity.RebuildObservers(true);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00012540 File Offset: 0x00010740
		internal void SendSpawnMessage(NetworkIdentity uv, NetworkConnection conn)
		{
			if (uv.serverOnly)
			{
				return;
			}
			if (uv.sceneId.IsEmpty())
			{
				ObjectSpawnMessage objectSpawnMessage = new ObjectSpawnMessage();
				objectSpawnMessage.netId = uv.netId;
				objectSpawnMessage.assetId = uv.assetId;
				objectSpawnMessage.position = uv.transform.position;
				NetworkWriter networkWriter = new NetworkWriter();
				uv.UNetSerializeAllVars(networkWriter);
				if (networkWriter.Position > 0)
				{
					objectSpawnMessage.payload = networkWriter.ToArray();
				}
				if (conn != null)
				{
					conn.Send(3, objectSpawnMessage);
				}
				else
				{
					NetworkServer.SendToReady(uv.gameObject, 3, objectSpawnMessage);
				}
			}
			else
			{
				ObjectSpawnSceneMessage objectSpawnSceneMessage = new ObjectSpawnSceneMessage();
				objectSpawnSceneMessage.netId = uv.netId;
				objectSpawnSceneMessage.sceneId = uv.sceneId;
				objectSpawnSceneMessage.position = uv.transform.position;
				NetworkWriter networkWriter2 = new NetworkWriter();
				uv.UNetSerializeAllVars(networkWriter2);
				if (networkWriter2.Position > 0)
				{
					objectSpawnSceneMessage.payload = networkWriter2.ToArray();
				}
				if (conn != null)
				{
					conn.Send(10, objectSpawnSceneMessage);
				}
				else
				{
					NetworkServer.SendToReady(uv.gameObject, 3, objectSpawnSceneMessage);
				}
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00012660 File Offset: 0x00010860
		public static void DestroyPlayersForConnection(NetworkConnection conn)
		{
			if (conn.playerControllers.Count == 0)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("Empty player list given to NetworkServer.Destroy(), nothing to do.");
				}
				return;
			}
			if (conn.clientOwnedObjects != null)
			{
				HashSet<NetworkInstanceId> hashSet = new HashSet<NetworkInstanceId>(conn.clientOwnedObjects);
				foreach (NetworkInstanceId networkInstanceId in hashSet)
				{
					GameObject gameObject = NetworkServer.FindLocalObject(networkInstanceId);
					if (gameObject != null)
					{
						NetworkServer.DestroyObject(gameObject);
					}
				}
			}
			foreach (PlayerController playerController in conn.playerControllers)
			{
				if (playerController.IsValid)
				{
					if (!(playerController.unetView == null))
					{
						NetworkServer.DestroyObject(playerController.unetView, true);
					}
					playerController.gameObject = null;
				}
			}
			conn.playerControllers.Clear();
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000127A4 File Offset: 0x000109A4
		private static void UnSpawnObject(GameObject obj)
		{
			if (obj == null)
			{
				if (LogFilter.logDev)
				{
					Debug.Log("NetworkServer UnspawnObject is null");
				}
				return;
			}
			NetworkIdentity networkIdentity;
			if (!NetworkServer.GetNetworkIdentity(obj, out networkIdentity))
			{
				return;
			}
			NetworkServer.UnSpawnObject(networkIdentity);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000127E8 File Offset: 0x000109E8
		private static void UnSpawnObject(NetworkIdentity uv)
		{
			NetworkServer.DestroyObject(uv, false);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000127F4 File Offset: 0x000109F4
		private static void DestroyObject(GameObject obj)
		{
			if (obj == null)
			{
				if (LogFilter.logDev)
				{
					Debug.Log("NetworkServer DestroyObject is null");
				}
				return;
			}
			NetworkIdentity networkIdentity;
			if (!NetworkServer.GetNetworkIdentity(obj, out networkIdentity))
			{
				return;
			}
			NetworkServer.DestroyObject(networkIdentity, true);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00012838 File Offset: 0x00010A38
		private static void DestroyObject(NetworkIdentity uv, bool destroyServerObject)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("DestroyObject instance:" + uv.netId);
			}
			if (NetworkServer.objects.ContainsKey(uv.netId))
			{
				NetworkServer.objects.Remove(uv.netId);
			}
			if (uv.clientAuthorityOwner != null)
			{
				uv.clientAuthorityOwner.RemoveOwnedObject(uv);
			}
			ObjectDestroyMessage objectDestroyMessage = new ObjectDestroyMessage();
			objectDestroyMessage.netId = uv.netId;
			NetworkServer.SendToObservers(uv.gameObject, 1, objectDestroyMessage);
			uv.ClearObservers();
			if (NetworkClient.active && NetworkServer.s_LocalClientActive)
			{
				uv.OnNetworkDestroy();
				ClientScene.SetLocalObject(objectDestroyMessage.netId, null);
			}
			if (destroyServerObject)
			{
				Object.Destroy(uv.gameObject);
			}
			uv.SetNoServer();
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0001290C File Offset: 0x00010B0C
		public static void ClearLocalObjects()
		{
			NetworkServer.objects.Clear();
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00012918 File Offset: 0x00010B18
		public static void Spawn(GameObject obj)
		{
			NetworkServer.instance.SpawnObject(obj);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00012928 File Offset: 0x00010B28
		public static bool SpawnWithClientAuthority(GameObject obj, GameObject player)
		{
			NetworkIdentity component = player.GetComponent<NetworkIdentity>();
			if (component == null)
			{
				Debug.LogError("SpawnWithClientAuthority player object has no NetworkIdentity");
				return false;
			}
			if (component.connectionToClient == null)
			{
				Debug.LogError("SpawnWithClientAuthority player object is not a player.");
				return false;
			}
			return NetworkServer.SpawnWithClientAuthority(obj, component.connectionToClient);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00012978 File Offset: 0x00010B78
		public static bool SpawnWithClientAuthority(GameObject obj, NetworkConnection conn)
		{
			NetworkServer.Spawn(obj);
			NetworkIdentity component = obj.GetComponent<NetworkIdentity>();
			return !(component == null) && component.isServer && component.AssignClientAuthority(conn);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000129B4 File Offset: 0x00010BB4
		public static bool SpawnWithClientAuthority(GameObject obj, NetworkHash128 assetId, NetworkConnection conn)
		{
			NetworkServer.Spawn(obj, assetId);
			NetworkIdentity component = obj.GetComponent<NetworkIdentity>();
			return !(component == null) && component.isServer && component.AssignClientAuthority(conn);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000129F0 File Offset: 0x00010BF0
		public static void Spawn(GameObject obj, NetworkHash128 assetId)
		{
			NetworkIdentity networkIdentity;
			if (NetworkServer.GetNetworkIdentity(obj, out networkIdentity))
			{
				networkIdentity.SetDynamicAssetId(assetId);
			}
			NetworkServer.instance.SpawnObject(obj);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00012A1C File Offset: 0x00010C1C
		public static void Destroy(GameObject obj)
		{
			NetworkServer.DestroyObject(obj);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00012A24 File Offset: 0x00010C24
		public static void UnSpawn(GameObject obj)
		{
			NetworkServer.UnSpawnObject(obj);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00012A2C File Offset: 0x00010C2C
		internal bool InvokeBytes(ULocalConnectionToServer conn, byte[] buffer, int numBytes, int channelId)
		{
			NetworkReader networkReader = new NetworkReader(buffer);
			networkReader.ReadInt16();
			short num = networkReader.ReadInt16();
			NetworkMessageDelegate handler = this.m_MessageHandlers.GetHandler(num);
			if (handler != null)
			{
				NetworkConnection networkConnection = this.m_Connections.Get(conn.connectionId);
				if (networkConnection != null)
				{
					ULocalConnectionToClient ulocalConnectionToClient = (ULocalConnectionToClient)networkConnection;
					ulocalConnectionToClient.InvokeHandler(num, networkReader, channelId);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00012A90 File Offset: 0x00010C90
		internal bool InvokeHandlerOnServer(ULocalConnectionToServer conn, short msgType, MessageBase msg, int channelId)
		{
			NetworkMessageDelegate handler = this.m_MessageHandlers.GetHandler(msgType);
			if (handler == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("Local invoke: Failed to find message handler for message ID " + msgType);
				}
				return false;
			}
			NetworkConnection networkConnection = this.m_Connections.Get(conn.connectionId);
			if (networkConnection != null)
			{
				ULocalConnectionToClient ulocalConnectionToClient = (ULocalConnectionToClient)networkConnection;
				NetworkWriter networkWriter = new NetworkWriter();
				msg.Serialize(networkWriter);
				NetworkReader networkReader = new NetworkReader(networkWriter);
				ulocalConnectionToClient.InvokeHandler(msgType, networkReader, channelId);
				return true;
			}
			if (LogFilter.logError)
			{
				Debug.LogError("Local invoke: Failed to find local connection to invoke handler on [connectionId=" + conn.connectionId + "]");
			}
			return false;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00012B40 File Offset: 0x00010D40
		public static GameObject FindLocalObject(NetworkInstanceId netId)
		{
			return NetworkServer.s_NetworkScene.FindLocalObject(netId);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00012B50 File Offset: 0x00010D50
		public static Dictionary<short, NetworkConnection.PacketStat> GetConnectionStats()
		{
			ConnectionArray connections = NetworkServer.instance.m_Connections;
			Dictionary<short, NetworkConnection.PacketStat> dictionary = new Dictionary<short, NetworkConnection.PacketStat>();
			for (int i = connections.LocalIndex; i < connections.Count; i++)
			{
				NetworkConnection networkConnection = connections.Get(i);
				if (networkConnection != null)
				{
					foreach (short num in networkConnection.packetStats.Keys)
					{
						if (dictionary.ContainsKey(num))
						{
							NetworkConnection.PacketStat packetStat = dictionary[num];
							packetStat.count += networkConnection.packetStats[num].count;
							packetStat.bytes += networkConnection.packetStats[num].bytes;
							dictionary[num] = packetStat;
						}
						else
						{
							dictionary[num] = networkConnection.packetStats[num];
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00012C70 File Offset: 0x00010E70
		public static void ResetConnectionStats()
		{
			ConnectionArray connections = NetworkServer.instance.m_Connections;
			for (int i = connections.LocalIndex; i < connections.Count; i++)
			{
				NetworkConnection networkConnection = connections.Get(i);
				if (networkConnection != null)
				{
					networkConnection.ResetStats();
				}
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00012CB8 File Offset: 0x00010EB8
		public static bool AddExternalConnection(NetworkConnection conn)
		{
			return NetworkServer.instance.AddExternalConnectionInternal(conn);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00012CC8 File Offset: 0x00010EC8
		private bool AddExternalConnectionInternal(NetworkConnection conn)
		{
			if (this.m_Connections.Get(conn.connectionId) != null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("AddExternalConnection failed, already connection for id:" + conn.connectionId);
				}
				return false;
			}
			if (LogFilter.logDebug)
			{
				Debug.Log("AddExternalConnection external connection " + conn.connectionId);
			}
			this.m_Connections.Add(conn.connectionId, conn);
			conn.SetHandlers(this.m_MessageHandlers);
			NetworkServer.s_ExternalConnections.Add(conn.connectionId);
			return true;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00012D68 File Offset: 0x00010F68
		public static void RemoveExternalConnection(int connectionId)
		{
			NetworkServer.instance.RemoveExternalConnectionInternal(connectionId);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00012D78 File Offset: 0x00010F78
		private bool RemoveExternalConnectionInternal(int connectionId)
		{
			if (!NetworkServer.s_ExternalConnections.Contains(connectionId))
			{
				if (LogFilter.logError)
				{
					Debug.LogError("RemoveExternalConnection failed, no connection for id:" + connectionId);
				}
				return false;
			}
			if (LogFilter.logDebug)
			{
				Debug.Log("RemoveExternalConnection external connection " + connectionId);
			}
			this.m_Connections.Remove(connectionId);
			return true;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00012DE4 File Offset: 0x00010FE4
		public static bool SpawnObjects()
		{
			if (NetworkServer.active)
			{
				NetworkIdentity[] array = Resources.FindObjectsOfTypeAll<NetworkIdentity>();
				foreach (NetworkIdentity networkIdentity in array)
				{
					if (networkIdentity.gameObject.hideFlags != HideFlags.NotEditable && networkIdentity.gameObject.hideFlags != HideFlags.HideAndDontSave)
					{
						if (!networkIdentity.sceneId.IsEmpty())
						{
							if (LogFilter.logDebug)
							{
								Debug.Log(string.Concat(new object[]
								{
									"SpawnObjects sceneId:",
									networkIdentity.sceneId,
									" name:",
									networkIdentity.gameObject.name
								}));
							}
							networkIdentity.gameObject.SetActive(true);
						}
					}
				}
				foreach (NetworkIdentity networkIdentity2 in array)
				{
					if (networkIdentity2.gameObject.hideFlags != HideFlags.NotEditable && networkIdentity2.gameObject.hideFlags != HideFlags.HideAndDontSave)
					{
						if (!networkIdentity2.sceneId.IsEmpty())
						{
							if (!networkIdentity2.isServer)
							{
								if (!(networkIdentity2.gameObject == null))
								{
									NetworkServer.Spawn(networkIdentity2.gameObject);
									networkIdentity2.ForceAuthority(true);
								}
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00012F54 File Offset: 0x00011154
		private static void SendCrc(NetworkConnection targetConnection)
		{
			if (NetworkCRC.singleton == null)
			{
				return;
			}
			if (!NetworkCRC.scriptCRCCheck)
			{
				return;
			}
			CRCMessage crcmessage = new CRCMessage();
			List<CRCMessageEntry> list = new List<CRCMessageEntry>();
			foreach (string text in NetworkCRC.singleton.scripts.Keys)
			{
				list.Add(new CRCMessageEntry
				{
					name = text,
					channel = (byte)NetworkCRC.singleton.scripts[text]
				});
			}
			crcmessage.scripts = list.ToArray();
			targetConnection.Send(14, crcmessage);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00013024 File Offset: 0x00011224
		public void SendNetworkInfo(NetworkConnection targetConnection)
		{
			PeerListMessage peerListMessage = new PeerListMessage();
			List<PeerInfoMessage> list = new List<PeerInfoMessage>();
			for (int i = 0; i < this.m_Connections.Count; i++)
			{
				NetworkConnection networkConnection = this.m_Connections.Get(i);
				if (networkConnection != null)
				{
					PeerInfoMessage peerInfoMessage = new PeerInfoMessage();
					string text;
					int num;
					NetworkID networkID;
					NodeID nodeID;
					byte b;
					NetworkTransport.GetConnectionInfo(this.m_ServerId, networkConnection.connectionId, out text, out num, out networkID, out nodeID, out b);
					peerInfoMessage.connectionId = networkConnection.connectionId;
					peerInfoMessage.address = text;
					peerInfoMessage.port = num;
					peerInfoMessage.isHost = false;
					peerInfoMessage.isYou = networkConnection == targetConnection;
					list.Add(peerInfoMessage);
				}
			}
			if (NetworkServer.localClientActive)
			{
				list.Add(new PeerInfoMessage
				{
					address = "HOST",
					port = this.m_ServerPort,
					connectionId = 0,
					isHost = true,
					isYou = false
				});
			}
			peerListMessage.peers = list.ToArray();
			for (int j = 0; j < this.m_Connections.Count; j++)
			{
				NetworkConnection networkConnection2 = this.m_Connections.Get(j);
				if (networkConnection2 != null)
				{
					networkConnection2.Send(11, peerListMessage);
				}
			}
		}

		// Token: 0x0400016A RID: 362
		private const int k_MaxEventsPerFrame = 500;

		// Token: 0x0400016B RID: 363
		private const int k_RemoveListInterval = 100;

		// Token: 0x0400016C RID: 364
		private static Type s_NetworkConnectionClass = typeof(NetworkConnection);

		// Token: 0x0400016D RID: 365
		private static bool s_Active;

		// Token: 0x0400016E RID: 366
		private static volatile NetworkServer s_Instance;

		// Token: 0x0400016F RID: 367
		private static object s_Sync = new Object();

		// Token: 0x04000170 RID: 368
		private static bool s_LocalClientActive;

		// Token: 0x04000171 RID: 369
		private static HashSet<int> s_ExternalConnections = new HashSet<int>();

		// Token: 0x04000172 RID: 370
		private int m_ServerId = -1;

		// Token: 0x04000173 RID: 371
		private int m_ServerPort = -1;

		// Token: 0x04000174 RID: 372
		private int m_RelaySlotId = -1;

		// Token: 0x04000175 RID: 373
		private NetworkMessageHandlers m_MessageHandlers = new NetworkMessageHandlers();

		// Token: 0x04000176 RID: 374
		private ConnectionArray m_Connections = new ConnectionArray();

		// Token: 0x04000177 RID: 375
		private static NetworkScene s_NetworkScene = new NetworkScene();

		// Token: 0x04000178 RID: 376
		private HostTopology m_HostTopology;

		// Token: 0x04000179 RID: 377
		private byte[] m_MsgBuffer;

		// Token: 0x0400017A RID: 378
		private bool m_SendPeerInfo = true;

		// Token: 0x0400017B RID: 379
		private bool m_UseWebSockets;

		// Token: 0x0400017C RID: 380
		private float m_MaxDelay = 0.1f;

		// Token: 0x0400017D RID: 381
		private List<LocalClient> m_LocalClients = new List<LocalClient>();

		// Token: 0x0400017E RID: 382
		private HashSet<NetworkInstanceId> m_RemoveList;

		// Token: 0x0400017F RID: 383
		private int m_RemoveListCount;

		// Token: 0x04000180 RID: 384
		internal static ushort maxPacketSize;

		// Token: 0x04000181 RID: 385
		private static RemovePlayerMessage s_RemovePlayerMessage = new RemovePlayerMessage();
	}
}
