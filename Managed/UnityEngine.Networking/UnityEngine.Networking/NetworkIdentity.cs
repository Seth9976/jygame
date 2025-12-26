using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine.Networking.NetworkSystem;

namespace UnityEngine.Networking
{
	// Token: 0x0200003D RID: 61
	[AddComponentMenu("Network/NetworkIdentity")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public sealed class NetworkIdentity : MonoBehaviour
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00009C9C File Offset: 0x00007E9C
		public bool isClient
		{
			get
			{
				return this.m_IsClient;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00009CA4 File Offset: 0x00007EA4
		public bool isServer
		{
			get
			{
				return this.m_IsServer && NetworkServer.active && this.m_IsServer;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00009CD4 File Offset: 0x00007ED4
		public bool hasAuthority
		{
			get
			{
				return this.m_HasAuthority;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00009CDC File Offset: 0x00007EDC
		public NetworkInstanceId netId
		{
			get
			{
				return this.m_NetId;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00009CE4 File Offset: 0x00007EE4
		public NetworkSceneId sceneId
		{
			get
			{
				return this.m_SceneId;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00009CEC File Offset: 0x00007EEC
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00009CF4 File Offset: 0x00007EF4
		public bool serverOnly
		{
			get
			{
				return this.m_ServerOnly;
			}
			set
			{
				this.m_ServerOnly = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00009D00 File Offset: 0x00007F00
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00009D08 File Offset: 0x00007F08
		public bool localPlayerAuthority
		{
			get
			{
				return this.m_LocalPlayerAuthority;
			}
			set
			{
				this.m_LocalPlayerAuthority = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00009D14 File Offset: 0x00007F14
		public NetworkConnection clientAuthorityOwner
		{
			get
			{
				return this.m_ClientAuthorityOwner;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00009D1C File Offset: 0x00007F1C
		public NetworkHash128 assetId
		{
			get
			{
				return this.m_AssetId;
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00009D24 File Offset: 0x00007F24
		internal void SetDynamicAssetId(NetworkHash128 newAssetId)
		{
			if (!this.m_AssetId.IsValid() || this.m_AssetId.Equals(newAssetId))
			{
				this.m_AssetId = newAssetId;
			}
			else if (LogFilter.logWarn)
			{
				Debug.LogWarning("SetDynamicAssetId object already has an assetId <" + this.m_AssetId + ">");
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00009D94 File Offset: 0x00007F94
		internal void SetClientOwner(NetworkConnection conn)
		{
			if (this.m_ClientAuthorityOwner != null && LogFilter.logError)
			{
				Debug.LogError("SetClientOwner m_ClientAuthorityOwner already set!");
			}
			this.m_ClientAuthorityOwner = conn;
			this.m_ClientAuthorityOwner.AddOwnedObject(this);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00009DD4 File Offset: 0x00007FD4
		internal void ClearClientOwner()
		{
			this.m_ClientAuthorityOwner = null;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00009DE0 File Offset: 0x00007FE0
		internal void ForceAuthority(bool authority)
		{
			this.m_HasAuthority = authority;
			if (authority)
			{
				this.OnStartAuthority();
			}
			else
			{
				this.OnStopAuthority();
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00009E00 File Offset: 0x00008000
		public bool isLocalPlayer
		{
			get
			{
				return this.m_IsLocalPlayer;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00009E08 File Offset: 0x00008008
		public short playerControllerId
		{
			get
			{
				return this.m_PlayerId;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00009E10 File Offset: 0x00008010
		public NetworkConnection connectionToServer
		{
			get
			{
				return this.m_ConnectionToServer;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00009E18 File Offset: 0x00008018
		public NetworkConnection connectionToClient
		{
			get
			{
				return this.m_ConnectionToClient;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00009E20 File Offset: 0x00008020
		public ReadOnlyCollection<NetworkConnection> observers
		{
			get
			{
				if (this.m_Observers == null)
				{
					return null;
				}
				return new ReadOnlyCollection<NetworkConnection>(this.m_Observers);
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00009E3C File Offset: 0x0000803C
		internal static NetworkInstanceId GetNextNetworkId()
		{
			uint num = NetworkIdentity.s_NextNetworkId;
			NetworkIdentity.s_NextNetworkId += 1U;
			return new NetworkInstanceId(num);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00009E64 File Offset: 0x00008064
		private void CacheBehaviours()
		{
			if (this.m_NetworkBehaviours == null)
			{
				this.m_NetworkBehaviours = base.GetComponents<NetworkBehaviour>();
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00009E80 File Offset: 0x00008080
		internal void SetNetworkInstanceId(NetworkInstanceId newNetId)
		{
			this.m_NetId = newNetId;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00009E8C File Offset: 0x0000808C
		public void ForceSceneId(int newSceneId)
		{
			this.m_SceneId = new NetworkSceneId((uint)newSceneId);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00009E9C File Offset: 0x0000809C
		internal void UpdateClientServer(bool isClientFlag, bool isServerFlag)
		{
			this.m_IsClient = this.m_IsClient || isClientFlag;
			this.m_IsServer = this.m_IsServer || isServerFlag;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00009EBC File Offset: 0x000080BC
		internal void SetNoServer()
		{
			this.m_IsServer = false;
			this.SetNetworkInstanceId(NetworkInstanceId.Zero);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00009ED0 File Offset: 0x000080D0
		internal void SetNotLocalPlayer()
		{
			this.m_IsLocalPlayer = false;
			this.m_HasAuthority = false;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00009EE0 File Offset: 0x000080E0
		internal void RemoveObserverInternal(NetworkConnection conn)
		{
			if (this.m_Observers != null)
			{
				this.m_Observers.Remove(conn);
				this.m_ObserverConnections.Remove(conn.connectionId);
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00009F18 File Offset: 0x00008118
		private void OnDestroy()
		{
			if (this.m_IsServer)
			{
				NetworkServer.Destroy(base.gameObject);
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00009F30 File Offset: 0x00008130
		internal void OnStartServer()
		{
			if (this.m_IsServer)
			{
				return;
			}
			this.m_IsServer = true;
			if (this.m_LocalPlayerAuthority)
			{
				this.m_HasAuthority = false;
			}
			else
			{
				this.m_HasAuthority = true;
			}
			this.m_Observers = new List<NetworkConnection>();
			this.m_ObserverConnections = new HashSet<int>();
			this.CacheBehaviours();
			if (this.netId.IsEmpty())
			{
				this.m_NetId = NetworkIdentity.GetNextNetworkId();
				if (LogFilter.logDev)
				{
					Debug.Log(string.Concat(new object[] { "OnStartServer ", base.gameObject, " GUID:", this.netId }));
				}
				NetworkServer.instance.SetLocalObjectOnServer(this.netId, base.gameObject);
				for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
				{
					NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
					try
					{
						networkBehaviour.OnStartServer();
					}
					catch (Exception ex)
					{
						Debug.LogError("Exception in OnStartServer:" + ex.Message + " " + ex.StackTrace);
					}
				}
				if (NetworkClient.active && NetworkServer.localClientActive)
				{
					ClientScene.SetLocalObject(this.netId, base.gameObject);
					this.OnStartClient();
				}
				if (this.m_HasAuthority)
				{
					this.OnStartAuthority();
				}
				return;
			}
			if (LogFilter.logError)
			{
				Debug.LogError(string.Concat(new object[] { "Object has non-zero netId ", this.netId, " for ", base.gameObject, " !!1" }));
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000A0FC File Offset: 0x000082FC
		internal void OnStartClient()
		{
			if (!this.m_IsClient)
			{
				this.m_IsClient = true;
			}
			this.CacheBehaviours();
			if (LogFilter.logDev)
			{
				Debug.Log(string.Concat(new object[] { "OnStartClient ", base.gameObject, " GUID:", this.netId, " localPlayerAuthority:", this.localPlayerAuthority }));
			}
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				try
				{
					networkBehaviour.PreStartClient();
					networkBehaviour.OnStartClient();
				}
				catch (Exception ex)
				{
					Debug.LogError("Exception in OnStartClient:" + ex.Message + " " + ex.StackTrace);
				}
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000A1F0 File Offset: 0x000083F0
		internal void OnStartAuthority()
		{
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				try
				{
					networkBehaviour.OnStartAuthority();
				}
				catch (Exception ex)
				{
					Debug.LogError("Exception in OnStartAuthority:" + ex.Message + " " + ex.StackTrace);
				}
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000A26C File Offset: 0x0000846C
		internal void OnStopAuthority()
		{
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				try
				{
					networkBehaviour.OnStopAuthority();
				}
				catch (Exception ex)
				{
					Debug.LogError("Exception in OnStopAuthority:" + ex.Message + " " + ex.StackTrace);
				}
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000A2E8 File Offset: 0x000084E8
		internal void OnSetLocalVisibility(bool vis)
		{
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				try
				{
					networkBehaviour.OnSetLocalVisibility(vis);
				}
				catch (Exception ex)
				{
					Debug.LogError("Exception in OnSetLocalVisibility:" + ex.Message + " " + ex.StackTrace);
				}
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000A368 File Offset: 0x00008568
		internal bool OnCheckObserver(NetworkConnection conn)
		{
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				try
				{
					if (!networkBehaviour.OnCheckObserver(conn))
					{
						return false;
					}
				}
				catch (Exception ex)
				{
					Debug.LogError("Exception in OnCheckObserver:" + ex.Message + " " + ex.StackTrace);
				}
			}
			return true;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000A3F4 File Offset: 0x000085F4
		internal void UNetSerializeAllVars(NetworkWriter writer)
		{
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				networkBehaviour.OnSerialize(writer, true);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000A42C File Offset: 0x0000862C
		internal void HandleSyncEvent(int cmdHash, NetworkReader reader)
		{
			if (base.gameObject == null)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning(string.Concat(new object[]
					{
						"SyncEvent [",
						NetworkBehaviour.GetCmdHashHandlerName(cmdHash),
						"] received for deleted object ",
						this.netId
					}));
				}
				return;
			}
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				if (networkBehaviour.InvokeSyncEvent(cmdHash, reader))
				{
					break;
				}
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000A4C0 File Offset: 0x000086C0
		internal void HandleClientAuthority(bool authority)
		{
			if (!this.localPlayerAuthority)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("HandleClientAuthority " + base.gameObject + " does not have localPlayerAuthority");
				}
				return;
			}
			this.ForceAuthority(authority);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000A504 File Offset: 0x00008704
		internal void HandleSyncList(int cmdHash, NetworkReader reader)
		{
			if (base.gameObject == null)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning(string.Concat(new object[]
					{
						"SyncList [",
						NetworkBehaviour.GetCmdHashHandlerName(cmdHash),
						"] received for deleted object ",
						this.netId
					}));
				}
				return;
			}
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				if (networkBehaviour.InvokeSyncList(cmdHash, reader))
				{
					break;
				}
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000A598 File Offset: 0x00008798
		internal void HandleCommand(int cmdHash, NetworkReader reader)
		{
			if (base.gameObject == null)
			{
				string cmdHashHandlerName = NetworkBehaviour.GetCmdHashHandlerName(cmdHash);
				if (LogFilter.logWarn)
				{
					Debug.LogWarning(string.Concat(new object[] { "Command [", cmdHashHandlerName, "] received for deleted object [netId=", this.netId, "]" }));
				}
				return;
			}
			bool flag = false;
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				if (networkBehaviour.InvokeCommand(cmdHash, reader))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				string cmdHashHandlerName2 = NetworkBehaviour.GetCmdHashHandlerName(cmdHash);
				if (LogFilter.logError)
				{
					Debug.LogError(string.Concat(new object[] { "Found no receiver for incoming command [", cmdHashHandlerName2, "] on ", base.gameObject, ",  the server and client should have the same NetworkBehaviour instances [netId=", this.netId, "]." }));
				}
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000A6A0 File Offset: 0x000088A0
		internal void HandleRPC(int cmdHash, NetworkReader reader)
		{
			if (base.gameObject == null)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning(string.Concat(new object[]
					{
						"ClientRpc [",
						NetworkBehaviour.GetCmdHashHandlerName(cmdHash),
						"] received for deleted object ",
						this.netId
					}));
				}
				return;
			}
			if (this.m_NetworkBehaviours.Length == 0)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("No receiver found for ClientRpc [" + NetworkBehaviour.GetCmdHashHandlerName(cmdHash) + "]. Does the script with the function inherit NetworkBehaviour?");
				}
				return;
			}
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				if (networkBehaviour.InvokeRPC(cmdHash, reader))
				{
					return;
				}
			}
			string text = NetworkBehaviour.GetInvoker(cmdHash);
			if (text == null)
			{
				text = "[unknown:" + cmdHash + "]";
			}
			if (LogFilter.logWarn)
			{
				Debug.LogWarning(string.Concat(new object[] { "Failed to invoke RPC ", text, "(", cmdHash, ") on netID ", this.netId }));
			}
			NetworkBehaviour.DumpInvokers();
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000A7D8 File Offset: 0x000089D8
		internal void UNetUpdate()
		{
			uint num = 0U;
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				int dirtyChannel = networkBehaviour.GetDirtyChannel();
				if (dirtyChannel != -1)
				{
					num |= 1U << dirtyChannel;
				}
			}
			if (num == 0U)
			{
				return;
			}
			for (int j = 0; j < NetworkServer.numChannels; j++)
			{
				if ((num & (1U << j)) != 0U)
				{
					NetworkIdentity.s_UpdateWriter.StartMessage(8);
					NetworkIdentity.s_UpdateWriter.Write(this.netId);
					bool flag = false;
					for (int k = 0; k < this.m_NetworkBehaviours.Length; k++)
					{
						short position = NetworkIdentity.s_UpdateWriter.Position;
						NetworkBehaviour networkBehaviour2 = this.m_NetworkBehaviours[k];
						if (networkBehaviour2.GetDirtyChannel() != j)
						{
							networkBehaviour2.OnSerialize(NetworkIdentity.s_UpdateWriter, false);
						}
						else
						{
							if (networkBehaviour2.OnSerialize(NetworkIdentity.s_UpdateWriter, false))
							{
								networkBehaviour2.ClearAllDirtyBits();
								flag = true;
							}
							if (NetworkIdentity.s_UpdateWriter.Position - position > (short)NetworkServer.maxPacketSize)
							{
								Debug.LogWarning(string.Concat(new object[]
								{
									"Large state update of ",
									(int)(NetworkIdentity.s_UpdateWriter.Position - position),
									" bytes (max is ",
									NetworkServer.maxPacketSize,
									" for netId:",
									this.netId,
									" from script:",
									networkBehaviour2
								}));
							}
						}
					}
					if (flag)
					{
						NetworkIdentity.s_UpdateWriter.FinishMessage();
						NetworkServer.SendWriterToReady(base.gameObject, NetworkIdentity.s_UpdateWriter, j);
					}
				}
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000A984 File Offset: 0x00008B84
		internal void OnUpdateVars(NetworkReader reader, bool initialState)
		{
			if (initialState && this.m_NetworkBehaviours == null)
			{
				this.m_NetworkBehaviours = base.GetComponents<NetworkBehaviour>();
			}
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				networkBehaviour.OnDeserialize(reader, initialState);
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000A9D8 File Offset: 0x00008BD8
		internal void SetLocalPlayer(short localPlayerControllerId)
		{
			this.m_IsLocalPlayer = true;
			this.m_PlayerId = localPlayerControllerId;
			if (this.localPlayerAuthority)
			{
				this.m_HasAuthority = true;
			}
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				networkBehaviour.OnStartLocalPlayer();
				if (this.localPlayerAuthority)
				{
					networkBehaviour.OnStartAuthority();
				}
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000AA40 File Offset: 0x00008C40
		internal void SetConnectionToServer(NetworkConnection conn)
		{
			this.m_ConnectionToServer = conn;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000AA4C File Offset: 0x00008C4C
		internal void SetConnectionToClient(NetworkConnection conn, short newPlayerControllerId)
		{
			this.m_PlayerId = newPlayerControllerId;
			this.m_ConnectionToClient = conn;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000AA5C File Offset: 0x00008C5C
		internal void OnNetworkDestroy()
		{
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				networkBehaviour.OnNetworkDestroy();
			}
			this.m_IsServer = false;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000AA98 File Offset: 0x00008C98
		internal void ClearObservers()
		{
			if (this.m_Observers != null)
			{
				int count = this.m_Observers.Count;
				for (int i = 0; i < count; i++)
				{
					NetworkConnection networkConnection = this.m_Observers[i];
					networkConnection.RemoveFromVisList(this, true);
				}
				this.m_Observers.Clear();
				this.m_ObserverConnections.Clear();
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000AAFC File Offset: 0x00008CFC
		internal void AddObserver(NetworkConnection conn)
		{
			if (this.m_Observers == null)
			{
				return;
			}
			if (this.m_ObserverConnections.Contains(conn.connectionId))
			{
				if (LogFilter.logDebug)
				{
					Debug.Log(string.Concat(new object[] { "Duplicate observer ", conn.address, " added for ", base.gameObject }));
				}
				return;
			}
			if (LogFilter.logDev)
			{
				Debug.Log(string.Concat(new object[] { "Added observer ", conn.address, " added for ", base.gameObject }));
			}
			this.m_Observers.Add(conn);
			this.m_ObserverConnections.Add(conn.connectionId);
			conn.AddToVisList(this);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000ABCC File Offset: 0x00008DCC
		internal void RemoveObserver(NetworkConnection conn)
		{
			if (this.m_Observers == null)
			{
				return;
			}
			this.m_Observers.Remove(conn);
			this.m_ObserverConnections.Remove(conn.connectionId);
			conn.RemoveFromVisList(this, false);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000AC04 File Offset: 0x00008E04
		public void RebuildObservers(bool initialize)
		{
			if (this.m_Observers == null)
			{
				return;
			}
			bool flag = false;
			bool flag2 = false;
			HashSet<NetworkConnection> hashSet = new HashSet<NetworkConnection>();
			HashSet<NetworkConnection> hashSet2 = new HashSet<NetworkConnection>(this.m_Observers);
			for (int i = 0; i < this.m_NetworkBehaviours.Length; i++)
			{
				NetworkBehaviour networkBehaviour = this.m_NetworkBehaviours[i];
				flag2 |= networkBehaviour.OnRebuildObservers(hashSet, initialize);
			}
			if (!flag2)
			{
				if (initialize)
				{
					foreach (NetworkConnection networkConnection in NetworkServer.connections)
					{
						if (networkConnection != null)
						{
							if (networkConnection.isReady)
							{
								this.AddObserver(networkConnection);
							}
						}
					}
					foreach (NetworkConnection networkConnection2 in NetworkServer.localConnections)
					{
						if (networkConnection2 != null)
						{
							if (networkConnection2.isReady)
							{
								this.AddObserver(networkConnection2);
							}
						}
					}
				}
				return;
			}
			foreach (NetworkConnection networkConnection3 in hashSet)
			{
				if (networkConnection3 != null)
				{
					if (!networkConnection3.isReady)
					{
						if (LogFilter.logWarn)
						{
							Debug.LogWarning(string.Concat(new object[] { "Observer is not ready for ", base.gameObject, " ", networkConnection3 }));
						}
					}
					else if (initialize || !hashSet2.Contains(networkConnection3))
					{
						networkConnection3.AddToVisList(this);
						if (LogFilter.logDebug)
						{
							Debug.Log(string.Concat(new object[] { "New Observer for ", base.gameObject, " ", networkConnection3 }));
						}
						flag = true;
					}
				}
			}
			foreach (NetworkConnection networkConnection4 in hashSet2)
			{
				if (!hashSet.Contains(networkConnection4))
				{
					networkConnection4.RemoveFromVisList(this, false);
					if (LogFilter.logDebug)
					{
						Debug.Log(string.Concat(new object[] { "Removed Observer for ", base.gameObject, " ", networkConnection4 }));
					}
					flag = true;
				}
			}
			if (initialize)
			{
				foreach (NetworkConnection networkConnection5 in NetworkServer.localConnections)
				{
					if (!hashSet.Contains(networkConnection5))
					{
						this.OnSetLocalVisibility(false);
					}
				}
			}
			if (!flag)
			{
				return;
			}
			this.m_Observers = new List<NetworkConnection>(hashSet);
			this.m_ObserverConnections.Clear();
			foreach (NetworkConnection networkConnection6 in this.m_Observers)
			{
				this.m_ObserverConnections.Add(networkConnection6.connectionId);
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000AFD8 File Offset: 0x000091D8
		public bool RemoveClientAuthority(NetworkConnection conn)
		{
			if (!this.isServer)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("RemoveClientAuthority can only be call on the server for spawned objects.");
				}
				return false;
			}
			if (this.connectionToClient != null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("RemoveClientAuthority cannot remove authority for a player object");
				}
				return false;
			}
			if (this.m_ClientAuthorityOwner == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("RemoveClientAuthority for " + base.gameObject + " has no clientAuthority owner.");
				}
				return false;
			}
			if (this.m_ClientAuthorityOwner != conn)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("RemoveClientAuthority for " + base.gameObject + " has different owner.");
				}
				return false;
			}
			this.m_ClientAuthorityOwner.RemoveOwnedObject(this);
			this.m_ClientAuthorityOwner = null;
			this.ForceAuthority(true);
			conn.Send(15, new ClientAuthorityMessage
			{
				netId = this.netId,
				authority = false
			});
			return true;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000B0C8 File Offset: 0x000092C8
		public bool AssignClientAuthority(NetworkConnection conn)
		{
			if (!this.isServer)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("AssignClientAuthority can only be call on the server for spawned objects.");
				}
				return false;
			}
			if (!this.localPlayerAuthority)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("AssignClientAuthority can only be used for NetworkIdentity component with LocalPlayerAuthority set.");
				}
				return false;
			}
			if (this.m_ClientAuthorityOwner != null && conn != this.m_ClientAuthorityOwner)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("AssignClientAuthority for " + base.gameObject + " already has an owner. Use RemoveClientAuthority() first.");
				}
				return false;
			}
			if (conn == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("AssignClientAuthority for " + base.gameObject + " owner cannot be null. Use RemoveClientAuthority() instead.");
				}
				return false;
			}
			this.m_ClientAuthorityOwner = conn;
			this.m_ClientAuthorityOwner.AddOwnedObject(this);
			this.ForceAuthority(false);
			conn.Send(15, new ClientAuthorityMessage
			{
				netId = this.netId,
				authority = true
			});
			return true;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000B1C0 File Offset: 0x000093C0
		internal static void UNetStaticUpdate()
		{
			NetworkServer.Update();
			NetworkClient.UpdateClients();
			NetworkManager.UpdateScene();
		}

		// Token: 0x040000FC RID: 252
		[SerializeField]
		private NetworkSceneId m_SceneId;

		// Token: 0x040000FD RID: 253
		[SerializeField]
		private NetworkHash128 m_AssetId;

		// Token: 0x040000FE RID: 254
		[SerializeField]
		private bool m_ServerOnly;

		// Token: 0x040000FF RID: 255
		[SerializeField]
		private bool m_LocalPlayerAuthority;

		// Token: 0x04000100 RID: 256
		private bool m_IsClient;

		// Token: 0x04000101 RID: 257
		private bool m_IsServer;

		// Token: 0x04000102 RID: 258
		private bool m_HasAuthority;

		// Token: 0x04000103 RID: 259
		private NetworkInstanceId m_NetId;

		// Token: 0x04000104 RID: 260
		private bool m_IsLocalPlayer;

		// Token: 0x04000105 RID: 261
		private NetworkConnection m_ConnectionToServer;

		// Token: 0x04000106 RID: 262
		private NetworkConnection m_ConnectionToClient;

		// Token: 0x04000107 RID: 263
		private short m_PlayerId = -1;

		// Token: 0x04000108 RID: 264
		private NetworkBehaviour[] m_NetworkBehaviours;

		// Token: 0x04000109 RID: 265
		private HashSet<int> m_ObserverConnections;

		// Token: 0x0400010A RID: 266
		private List<NetworkConnection> m_Observers;

		// Token: 0x0400010B RID: 267
		private NetworkConnection m_ClientAuthorityOwner;

		// Token: 0x0400010C RID: 268
		private static uint s_NextNetworkId = 1U;

		// Token: 0x0400010D RID: 269
		private static NetworkWriter s_UpdateWriter = new NetworkWriter();
	}
}
