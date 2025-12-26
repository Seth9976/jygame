using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Networking.NetworkSystem;

namespace UnityEngine.Networking
{
	// Token: 0x0200003F RID: 63
	[AddComponentMenu("Network/NetworkLobbyManager")]
	public class NetworkLobbyManager : NetworkManager
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000B2EC File Offset: 0x000094EC
		// (set) Token: 0x0600021C RID: 540 RVA: 0x0000B2F4 File Offset: 0x000094F4
		public bool showLobbyGUI
		{
			get
			{
				return this.m_ShowLobbyGUI;
			}
			set
			{
				this.m_ShowLobbyGUI = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000B300 File Offset: 0x00009500
		// (set) Token: 0x0600021E RID: 542 RVA: 0x0000B308 File Offset: 0x00009508
		public int maxPlayers
		{
			get
			{
				return this.m_MaxPlayers;
			}
			set
			{
				this.m_MaxPlayers = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000B314 File Offset: 0x00009514
		// (set) Token: 0x06000220 RID: 544 RVA: 0x0000B31C File Offset: 0x0000951C
		public int maxPlayersPerConnection
		{
			get
			{
				return this.m_MaxPlayersPerConnection;
			}
			set
			{
				this.m_MaxPlayersPerConnection = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000B328 File Offset: 0x00009528
		// (set) Token: 0x06000222 RID: 546 RVA: 0x0000B330 File Offset: 0x00009530
		public int minPlayers
		{
			get
			{
				return this.m_MinPlayers;
			}
			set
			{
				this.m_MinPlayers = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000B33C File Offset: 0x0000953C
		// (set) Token: 0x06000224 RID: 548 RVA: 0x0000B344 File Offset: 0x00009544
		public NetworkLobbyPlayer lobbyPlayerPrefab
		{
			get
			{
				return this.m_LobbyPlayerPrefab;
			}
			set
			{
				this.m_LobbyPlayerPrefab = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000B350 File Offset: 0x00009550
		// (set) Token: 0x06000226 RID: 550 RVA: 0x0000B358 File Offset: 0x00009558
		public GameObject gamePlayerPrefab
		{
			get
			{
				return this.m_GamePlayerPrefab;
			}
			set
			{
				this.m_GamePlayerPrefab = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000B364 File Offset: 0x00009564
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0000B36C File Offset: 0x0000956C
		public string lobbyScene
		{
			get
			{
				return this.m_LobbyScene;
			}
			set
			{
				this.m_LobbyScene = value;
				base.offlineScene = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000B37C File Offset: 0x0000957C
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0000B384 File Offset: 0x00009584
		public string playScene
		{
			get
			{
				return this.m_PlayScene;
			}
			set
			{
				this.m_PlayScene = value;
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000B390 File Offset: 0x00009590
		private void OnValidate()
		{
			if (this.m_MaxPlayers <= 0)
			{
				this.m_MaxPlayers = 1;
			}
			if (this.m_MaxPlayersPerConnection <= 0)
			{
				this.m_MaxPlayersPerConnection = 1;
			}
			if (this.m_MaxPlayersPerConnection > this.maxPlayers)
			{
				this.m_MaxPlayersPerConnection = this.maxPlayers;
			}
			if (this.m_MinPlayers < 0)
			{
				this.m_MinPlayers = 0;
			}
			if (this.m_MinPlayers > this.m_MaxPlayers)
			{
				this.m_MinPlayers = this.m_MaxPlayers;
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000B410 File Offset: 0x00009610
		private byte FindSlot()
		{
			byte b = 0;
			while ((int)b < this.maxPlayers)
			{
				if (this.lobbySlots[(int)b] == null)
				{
					return b;
				}
				b += 1;
			}
			return byte.MaxValue;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000B450 File Offset: 0x00009650
		private void SceneLoadedForPlayer(NetworkConnection conn, GameObject lobbyPlayerGameObject)
		{
			NetworkLobbyPlayer component = lobbyPlayerGameObject.GetComponent<NetworkLobbyPlayer>();
			if (component == null)
			{
				return;
			}
			if (LogFilter.logDebug)
			{
				Debug.Log(string.Concat(new object[]
				{
					"NetworkLobby SceneLoadedForPlayer scene:",
					Application.loadedLevelName,
					" ",
					conn
				}));
			}
			if (Application.loadedLevelName == this.m_LobbyScene)
			{
				NetworkLobbyManager.PendingPlayer pendingPlayer;
				pendingPlayer.conn = conn;
				pendingPlayer.lobbyPlayer = lobbyPlayerGameObject;
				this.m_PendingPlayers.Add(pendingPlayer);
				return;
			}
			short playerControllerId = lobbyPlayerGameObject.GetComponent<NetworkIdentity>().playerControllerId;
			GameObject gameObject = this.OnLobbyServerCreateGamePlayer(conn, playerControllerId);
			if (gameObject == null)
			{
				Transform startPosition = base.GetStartPosition();
				if (startPosition != null)
				{
					gameObject = (GameObject)Object.Instantiate(this.gamePlayerPrefab, startPosition.position, startPosition.rotation);
				}
				else
				{
					gameObject = (GameObject)Object.Instantiate(this.gamePlayerPrefab, Vector3.zero, Quaternion.identity);
				}
			}
			if (!this.OnLobbyServerSceneLoadedForPlayer(lobbyPlayerGameObject, gameObject))
			{
				return;
			}
			NetworkServer.ReplacePlayerForConnection(conn, gameObject, playerControllerId);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000B568 File Offset: 0x00009768
		private static bool CheckConnectionIsReadyToBegin(NetworkConnection conn)
		{
			foreach (PlayerController playerController in conn.playerControllers)
			{
				if (playerController.IsValid)
				{
					NetworkLobbyPlayer component = playerController.gameObject.GetComponent<NetworkLobbyPlayer>();
					if (!component.readyToBegin)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000B5F4 File Offset: 0x000097F4
		public void CheckReadyToBegin()
		{
			if (Application.loadedLevelName != this.m_LobbyScene)
			{
				return;
			}
			int num = 0;
			foreach (NetworkConnection networkConnection in NetworkServer.connections)
			{
				if (networkConnection != null)
				{
					if (!NetworkLobbyManager.CheckConnectionIsReadyToBegin(networkConnection))
					{
						return;
					}
					num++;
				}
			}
			foreach (NetworkConnection networkConnection2 in NetworkServer.localConnections)
			{
				if (networkConnection2 != null)
				{
					if (!NetworkLobbyManager.CheckConnectionIsReadyToBegin(networkConnection2))
					{
						return;
					}
					num++;
				}
			}
			if (this.m_MinPlayers > 0 && num < this.m_MinPlayers)
			{
				return;
			}
			this.m_PendingPlayers.Clear();
			this.OnLobbyServerPlayersReady();
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000B72C File Offset: 0x0000992C
		public void ServerReturnToLobby()
		{
			if (!NetworkServer.active)
			{
				Debug.Log("ServerReturnToLobby called on client");
				return;
			}
			this.ServerChangeScene(this.m_LobbyScene);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000B750 File Offset: 0x00009950
		private void CallOnClientEnterLobby()
		{
			this.OnLobbyClientEnter();
			foreach (NetworkLobbyPlayer networkLobbyPlayer in this.lobbySlots)
			{
				if (!(networkLobbyPlayer == null))
				{
					networkLobbyPlayer.readyToBegin = false;
					networkLobbyPlayer.OnClientEnterLobby();
				}
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000B7A0 File Offset: 0x000099A0
		private void CallOnClientExitLobby()
		{
			this.OnLobbyClientExit();
			foreach (NetworkLobbyPlayer networkLobbyPlayer in this.lobbySlots)
			{
				if (!(networkLobbyPlayer == null))
				{
					networkLobbyPlayer.OnClientExitLobby();
				}
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000B7EC File Offset: 0x000099EC
		public bool SendReturnToLobby()
		{
			if (this.client == null || !this.client.isConnected)
			{
				return false;
			}
			EmptyMessage emptyMessage = new EmptyMessage();
			this.client.Send(46, emptyMessage);
			return true;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000B82C File Offset: 0x00009A2C
		public override void OnServerConnect(NetworkConnection conn)
		{
			if (base.numPlayers >= this.maxPlayers)
			{
				conn.Disconnect();
				return;
			}
			if (Application.loadedLevelName != this.m_LobbyScene)
			{
				conn.Disconnect();
				return;
			}
			base.OnServerConnect(conn);
			this.OnLobbyServerConnect(conn);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000B87C File Offset: 0x00009A7C
		public override void OnServerDisconnect(NetworkConnection conn)
		{
			base.OnServerDisconnect(conn);
			this.OnLobbyServerDisconnect(conn);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000B88C File Offset: 0x00009A8C
		public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
		{
			if (Application.loadedLevelName != this.m_LobbyScene)
			{
				return;
			}
			int num = 0;
			foreach (PlayerController playerController in conn.playerControllers)
			{
				if (playerController.IsValid)
				{
					num++;
				}
			}
			if (num >= this.maxPlayersPerConnection)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("NetworkLobbyManager no more players for this connection.");
				}
				EmptyMessage emptyMessage = new EmptyMessage();
				conn.Send(45, emptyMessage);
				return;
			}
			byte b = this.FindSlot();
			if (b == 255)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("NetworkLobbyManager no space for more players");
				}
				EmptyMessage emptyMessage2 = new EmptyMessage();
				conn.Send(45, emptyMessage2);
				return;
			}
			GameObject gameObject = this.OnLobbyServerCreateLobbyPlayer(conn, playerControllerId);
			if (gameObject == null)
			{
				gameObject = (GameObject)Object.Instantiate(this.lobbyPlayerPrefab.gameObject, Vector3.zero, Quaternion.identity);
			}
			NetworkLobbyPlayer component = gameObject.GetComponent<NetworkLobbyPlayer>();
			component.slot = b;
			this.lobbySlots[(int)b] = component;
			NetworkServer.AddPlayerForConnection(conn, gameObject, playerControllerId);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000B9E0 File Offset: 0x00009BE0
		public override void OnServerRemovePlayer(NetworkConnection conn, PlayerController player)
		{
			short playerControllerId = player.playerControllerId;
			byte slot = player.gameObject.GetComponent<NetworkLobbyPlayer>().slot;
			this.lobbySlots[(int)slot] = null;
			base.OnServerRemovePlayer(conn, player);
			foreach (NetworkLobbyPlayer networkLobbyPlayer in this.lobbySlots)
			{
				if (networkLobbyPlayer != null)
				{
					networkLobbyPlayer.GetComponent<NetworkLobbyPlayer>().readyToBegin = false;
					NetworkLobbyManager.s_LobbyReadyToBeginMessage.slotId = networkLobbyPlayer.slot;
					NetworkLobbyManager.s_LobbyReadyToBeginMessage.readyState = false;
					NetworkServer.SendToReady(null, 43, NetworkLobbyManager.s_LobbyReadyToBeginMessage);
				}
			}
			this.OnLobbyServerPlayerRemoved(conn, playerControllerId);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000BA84 File Offset: 0x00009C84
		public override void ServerChangeScene(string sceneName)
		{
			if (sceneName == this.m_LobbyScene)
			{
				foreach (NetworkLobbyPlayer networkLobbyPlayer in this.lobbySlots)
				{
					if (!(networkLobbyPlayer == null))
					{
						NetworkIdentity component = networkLobbyPlayer.GetComponent<NetworkIdentity>();
						PlayerController playerController;
						if (component.connectionToClient.GetPlayerController(component.playerControllerId, out playerController))
						{
							NetworkServer.Destroy(playerController.gameObject);
						}
						if (NetworkServer.active)
						{
							networkLobbyPlayer.GetComponent<NetworkLobbyPlayer>().readyToBegin = false;
							NetworkServer.ReplacePlayerForConnection(component.connectionToClient, networkLobbyPlayer.gameObject, component.playerControllerId);
						}
					}
				}
			}
			base.ServerChangeScene(sceneName);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000BB34 File Offset: 0x00009D34
		public override void OnServerSceneChanged(string sceneName)
		{
			if (sceneName != this.m_LobbyScene)
			{
				foreach (NetworkLobbyManager.PendingPlayer pendingPlayer in this.m_PendingPlayers)
				{
					this.SceneLoadedForPlayer(pendingPlayer.conn, pendingPlayer.lobbyPlayer);
				}
				this.m_PendingPlayers.Clear();
			}
			this.OnLobbyServerSceneChanged(sceneName);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000BBCC File Offset: 0x00009DCC
		private void OnServerReadyToBeginMessage(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkLobbyManager OnServerReadyToBeginMessage");
			}
			netMsg.ReadMessage<LobbyReadyToBeginMessage>(NetworkLobbyManager.s_ReadyToBeginMessage);
			PlayerController playerController;
			if (!netMsg.conn.GetPlayerController((short)NetworkLobbyManager.s_ReadyToBeginMessage.slotId, out playerController))
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkLobbyManager OnServerReadyToBeginMessage invalid playerControllerId " + NetworkLobbyManager.s_ReadyToBeginMessage.slotId);
				}
				return;
			}
			NetworkLobbyPlayer component = playerController.gameObject.GetComponent<NetworkLobbyPlayer>();
			component.readyToBegin = NetworkLobbyManager.s_ReadyToBeginMessage.readyState;
			NetworkServer.SendToReady(null, 43, new LobbyReadyToBeginMessage
			{
				slotId = component.slot,
				readyState = NetworkLobbyManager.s_ReadyToBeginMessage.readyState
			});
			this.CheckReadyToBegin();
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000BC8C File Offset: 0x00009E8C
		private void OnServerSceneLoadedMessage(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkLobbyManager OnSceneLoadedMessage");
			}
			netMsg.ReadMessage<IntegerMessage>(NetworkLobbyManager.s_SceneLoadedMessage);
			PlayerController playerController;
			if (!netMsg.conn.GetPlayerController((short)NetworkLobbyManager.s_SceneLoadedMessage.value, out playerController))
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkLobbyManager OnServerSceneLoadedMessage invalid playerControllerId " + NetworkLobbyManager.s_SceneLoadedMessage.value);
				}
				return;
			}
			this.SceneLoadedForPlayer(netMsg.conn, playerController.gameObject);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000BD10 File Offset: 0x00009F10
		private void OnServerReturnToLobbyMessage(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkLobbyManager OnServerReturnToLobbyMessage");
			}
			this.ServerReturnToLobby();
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000BD2C File Offset: 0x00009F2C
		public override void OnStartServer()
		{
			if (this.lobbySlots.Length == 0)
			{
				this.lobbySlots = new NetworkLobbyPlayer[this.maxPlayers];
			}
			NetworkServer.RegisterHandler(43, new NetworkMessageDelegate(this.OnServerReadyToBeginMessage));
			NetworkServer.RegisterHandler(44, new NetworkMessageDelegate(this.OnServerSceneLoadedMessage));
			NetworkServer.RegisterHandler(46, new NetworkMessageDelegate(this.OnServerReturnToLobbyMessage));
			this.OnLobbyStartServer();
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000BD98 File Offset: 0x00009F98
		public override void OnStartHost()
		{
			this.OnLobbyStartHost();
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000BDA0 File Offset: 0x00009FA0
		public override void OnStopHost()
		{
			this.OnLobbyStopHost();
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		public override void OnStartClient(NetworkClient lobbyClient)
		{
			if (this.lobbySlots.Length == 0)
			{
				this.lobbySlots = new NetworkLobbyPlayer[this.maxPlayers];
			}
			if (this.m_LobbyPlayerPrefab == null || this.m_LobbyPlayerPrefab.gameObject == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkLobbyManager no LobbyPlayer prefab is registered. Please add a LobbyPlayer prefab.");
				}
			}
			else
			{
				ClientScene.RegisterPrefab(this.m_LobbyPlayerPrefab.gameObject);
			}
			if (this.m_GamePlayerPrefab == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkLobbyManager no GamePlayer prefab is registered. Please add a GamePlayer prefab.");
				}
			}
			else
			{
				ClientScene.RegisterPrefab(this.m_GamePlayerPrefab);
			}
			lobbyClient.RegisterHandler(43, new NetworkMessageDelegate(this.OnClientReadyToBegin));
			lobbyClient.RegisterHandler(45, new NetworkMessageDelegate(this.OnClientAddPlayerFailedMessage));
			this.OnLobbyStartClient(lobbyClient);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000BE88 File Offset: 0x0000A088
		public override void OnClientConnect(NetworkConnection conn)
		{
			this.OnLobbyClientConnect(conn);
			this.CallOnClientEnterLobby();
			base.OnClientConnect(conn);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000BEA0 File Offset: 0x0000A0A0
		public override void OnClientDisconnect(NetworkConnection conn)
		{
			this.OnLobbyClientDisconnect(conn);
			base.OnClientDisconnect(conn);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		public override void OnStopClient()
		{
			this.OnLobbyStopClient();
			this.CallOnClientExitLobby();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000BEC0 File Offset: 0x0000A0C0
		public override void OnClientSceneChanged(NetworkConnection conn)
		{
			if (Application.loadedLevelName == this.lobbyScene)
			{
				if (this.client.isConnected)
				{
					this.CallOnClientEnterLobby();
				}
			}
			else
			{
				this.CallOnClientExitLobby();
			}
			base.OnClientSceneChanged(conn);
			this.OnLobbyClientSceneChanged(conn);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000BF14 File Offset: 0x0000A114
		private void OnClientReadyToBegin(NetworkMessage netMsg)
		{
			netMsg.ReadMessage<LobbyReadyToBeginMessage>(NetworkLobbyManager.s_LobbyReadyToBeginMessage);
			if ((int)NetworkLobbyManager.s_LobbyReadyToBeginMessage.slotId >= this.lobbySlots.Count<NetworkLobbyPlayer>())
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkLobbyManager OnClientReadyToBegin invalid lobby slot " + NetworkLobbyManager.s_LobbyReadyToBeginMessage.slotId);
				}
				return;
			}
			NetworkLobbyPlayer networkLobbyPlayer = this.lobbySlots[(int)NetworkLobbyManager.s_LobbyReadyToBeginMessage.slotId];
			if (networkLobbyPlayer == null || networkLobbyPlayer.gameObject == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkLobbyManager OnClientReadyToBegin no player at lobby slot " + NetworkLobbyManager.s_LobbyReadyToBeginMessage.slotId);
				}
				return;
			}
			networkLobbyPlayer.readyToBegin = NetworkLobbyManager.s_LobbyReadyToBeginMessage.readyState;
			networkLobbyPlayer.OnClientReady(NetworkLobbyManager.s_LobbyReadyToBeginMessage.readyState);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		private void OnClientAddPlayerFailedMessage(NetworkMessage netMsg)
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkLobbyManager Add Player failed.");
			}
			this.OnLobbyClientAddPlayerFailed();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000C004 File Offset: 0x0000A204
		public virtual void OnLobbyStartHost()
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000C008 File Offset: 0x0000A208
		public virtual void OnLobbyStopHost()
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000C00C File Offset: 0x0000A20C
		public virtual void OnLobbyStartServer()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000C010 File Offset: 0x0000A210
		public virtual void OnLobbyServerConnect(NetworkConnection conn)
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000C014 File Offset: 0x0000A214
		public virtual void OnLobbyServerDisconnect(NetworkConnection conn)
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000C018 File Offset: 0x0000A218
		public virtual void OnLobbyServerSceneChanged(string sceneName)
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000C01C File Offset: 0x0000A21C
		public virtual GameObject OnLobbyServerCreateLobbyPlayer(NetworkConnection conn, short playerControllerId)
		{
			return null;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000C020 File Offset: 0x0000A220
		public virtual GameObject OnLobbyServerCreateGamePlayer(NetworkConnection conn, short playerControllerId)
		{
			return null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000C024 File Offset: 0x0000A224
		public virtual void OnLobbyServerPlayerRemoved(NetworkConnection conn, short playerControllerId)
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000C028 File Offset: 0x0000A228
		public virtual bool OnLobbyServerSceneLoadedForPlayer(GameObject lobbyPlayer, GameObject gamePlayer)
		{
			return true;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000C02C File Offset: 0x0000A22C
		public virtual void OnLobbyServerPlayersReady()
		{
			this.ServerChangeScene(this.m_PlayScene);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000C03C File Offset: 0x0000A23C
		public virtual void OnLobbyClientEnter()
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000C040 File Offset: 0x0000A240
		public virtual void OnLobbyClientExit()
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000C044 File Offset: 0x0000A244
		public virtual void OnLobbyClientConnect(NetworkConnection conn)
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000C048 File Offset: 0x0000A248
		public virtual void OnLobbyClientDisconnect(NetworkConnection conn)
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000C04C File Offset: 0x0000A24C
		public virtual void OnLobbyStartClient(NetworkClient lobbyClient)
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000C050 File Offset: 0x0000A250
		public virtual void OnLobbyStopClient()
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000C054 File Offset: 0x0000A254
		public virtual void OnLobbyClientSceneChanged(NetworkConnection conn)
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000C058 File Offset: 0x0000A258
		public virtual void OnLobbyClientAddPlayerFailed()
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000C05C File Offset: 0x0000A25C
		private void OnGUI()
		{
			if (!this.showLobbyGUI)
			{
				return;
			}
			if (Application.loadedLevelName != this.m_LobbyScene)
			{
				return;
			}
			Rect rect = new Rect(90f, 180f, 500f, 150f);
			GUI.Box(rect, "Players:");
			if (NetworkClient.active)
			{
				Rect rect2 = new Rect(100f, 300f, 120f, 20f);
				if (GUI.Button(rect2, "Add Player"))
				{
					this.TryToAddPlayer();
				}
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000C0EC File Offset: 0x0000A2EC
		public void TryToAddPlayer()
		{
			if (NetworkClient.active)
			{
				short num = -1;
				List<PlayerController> playerControllers = NetworkClient.allClients[0].connection.playerControllers;
				if (playerControllers.Count < this.maxPlayers)
				{
					num = (short)playerControllers.Count;
				}
				else
				{
					short num2 = 0;
					while ((int)num2 < this.maxPlayers)
					{
						if (!playerControllers[(int)num2].IsValid)
						{
							num = num2;
							break;
						}
						num2 += 1;
					}
				}
				if (LogFilter.logDebug)
				{
					Debug.Log(string.Concat(new object[]
					{
						"NetworkLobbyManager TryToAddPlayer controllerId ",
						num,
						" ready:",
						ClientScene.ready
					}));
				}
				if (num == -1)
				{
					if (LogFilter.logDebug)
					{
						Debug.Log("NetworkLobbyManager No Space!");
					}
					return;
				}
				if (ClientScene.ready)
				{
					ClientScene.AddPlayer(num);
				}
				else
				{
					ClientScene.AddPlayer(NetworkClient.allClients[0].connection, num);
				}
			}
			else if (LogFilter.logDebug)
			{
				Debug.Log("NetworkLobbyManager NetworkClient not active!");
			}
		}

		// Token: 0x04000111 RID: 273
		[SerializeField]
		private bool m_ShowLobbyGUI = true;

		// Token: 0x04000112 RID: 274
		[SerializeField]
		private int m_MaxPlayers = 4;

		// Token: 0x04000113 RID: 275
		[SerializeField]
		private int m_MaxPlayersPerConnection = 1;

		// Token: 0x04000114 RID: 276
		[SerializeField]
		private int m_MinPlayers;

		// Token: 0x04000115 RID: 277
		[SerializeField]
		private NetworkLobbyPlayer m_LobbyPlayerPrefab;

		// Token: 0x04000116 RID: 278
		[SerializeField]
		private GameObject m_GamePlayerPrefab;

		// Token: 0x04000117 RID: 279
		[SerializeField]
		private string m_LobbyScene = string.Empty;

		// Token: 0x04000118 RID: 280
		[SerializeField]
		private string m_PlayScene = string.Empty;

		// Token: 0x04000119 RID: 281
		private List<NetworkLobbyManager.PendingPlayer> m_PendingPlayers = new List<NetworkLobbyManager.PendingPlayer>();

		// Token: 0x0400011A RID: 282
		public NetworkLobbyPlayer[] lobbySlots;

		// Token: 0x0400011B RID: 283
		private static LobbyReadyToBeginMessage s_ReadyToBeginMessage = new LobbyReadyToBeginMessage();

		// Token: 0x0400011C RID: 284
		private static IntegerMessage s_SceneLoadedMessage = new IntegerMessage();

		// Token: 0x0400011D RID: 285
		private static LobbyReadyToBeginMessage s_LobbyReadyToBeginMessage = new LobbyReadyToBeginMessage();

		// Token: 0x02000040 RID: 64
		private struct PendingPlayer
		{
			// Token: 0x0400011E RID: 286
			public NetworkConnection conn;

			// Token: 0x0400011F RID: 287
			public GameObject lobbyPlayer;
		}
	}
}
