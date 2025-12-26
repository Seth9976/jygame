using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEngine.Networking
{
	// Token: 0x0200002F RID: 47
	[AddComponentMenu("")]
	[RequireComponent(typeof(NetworkIdentity))]
	public class NetworkBehaviour : MonoBehaviour
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00005B50 File Offset: 0x00003D50
		public bool localPlayerAuthority
		{
			get
			{
				return this.myView.localPlayerAuthority;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00005B60 File Offset: 0x00003D60
		public bool isServer
		{
			get
			{
				return this.myView.isServer;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00005B70 File Offset: 0x00003D70
		public bool isClient
		{
			get
			{
				return this.myView.isClient;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00005B80 File Offset: 0x00003D80
		public bool isLocalPlayer
		{
			get
			{
				return this.myView.isLocalPlayer;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00005B90 File Offset: 0x00003D90
		public bool hasAuthority
		{
			get
			{
				return this.myView.hasAuthority;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00005BA0 File Offset: 0x00003DA0
		public NetworkInstanceId netId
		{
			get
			{
				return this.myView.netId;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00005BB0 File Offset: 0x00003DB0
		public NetworkConnection connectionToServer
		{
			get
			{
				return this.myView.connectionToServer;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00005BC0 File Offset: 0x00003DC0
		public NetworkConnection connectionToClient
		{
			get
			{
				return this.myView.connectionToClient;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00005BD0 File Offset: 0x00003DD0
		public short playerControllerId
		{
			get
			{
				return this.myView.playerControllerId;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00005BE0 File Offset: 0x00003DE0
		protected uint syncVarDirtyBits
		{
			get
			{
				return this.m_SyncVarDirtyBits;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00005BE8 File Offset: 0x00003DE8
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00005BF0 File Offset: 0x00003DF0
		protected bool syncVarHookGuard
		{
			get
			{
				return this.m_SyncVarGuard;
			}
			set
			{
				this.m_SyncVarGuard = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00005BFC File Offset: 0x00003DFC
		private NetworkIdentity myView
		{
			get
			{
				if (this.m_MyView == null)
				{
					this.m_MyView = base.GetComponent<NetworkIdentity>();
					if (this.m_MyView == null && LogFilter.logError)
					{
						Debug.LogError("There is no NetworkIdentity on this object. Please add one.");
					}
					return this.m_MyView;
				}
				return this.m_MyView;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00005C58 File Offset: 0x00003E58
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void SendCommandInternal(NetworkWriter writer, int channelId, string cmdName)
		{
			if (!this.isLocalPlayer && !this.hasAuthority)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("Trying to send command for object without authority.");
				}
				return;
			}
			if (ClientScene.readyConnection == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("Send command attempted with no client running [client=" + this.connectionToServer + "].");
				}
				return;
			}
			writer.FinishMessage();
			ClientScene.readyConnection.SendWriter(writer, channelId);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00005CD4 File Offset: 0x00003ED4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual bool InvokeCommand(int cmdHash, NetworkReader reader)
		{
			return this.InvokeCommandDelegate(cmdHash, reader);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void SendRPCInternal(NetworkWriter writer, int channelId, string rpcName)
		{
			if (!this.isServer)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("ClientRpc call on un-spawned object");
				}
				return;
			}
			writer.FinishMessage();
			NetworkServer.SendWriterToReady(base.gameObject, writer, channelId);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00005D28 File Offset: 0x00003F28
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual bool InvokeRPC(int cmdHash, NetworkReader reader)
		{
			return this.InvokeRpcDelegate(cmdHash, reader);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00005D3C File Offset: 0x00003F3C
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void SendEventInternal(NetworkWriter writer, int channelId, string eventName)
		{
			if (!NetworkServer.active)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("SendEvent no server?");
				}
				return;
			}
			writer.FinishMessage();
			NetworkServer.SendWriterToReady(base.gameObject, writer, channelId);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00005D7C File Offset: 0x00003F7C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual bool InvokeSyncEvent(int cmdHash, NetworkReader reader)
		{
			return this.InvokeSyncEventDelegate(cmdHash, reader);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00005D90 File Offset: 0x00003F90
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual bool InvokeSyncList(int cmdHash, NetworkReader reader)
		{
			return this.InvokeSyncListDelegate(cmdHash, reader);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00005DA4 File Offset: 0x00003FA4
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected static void RegisterCommandDelegate(Type invokeClass, int cmdHash, NetworkBehaviour.CmdDelegate func)
		{
			if (NetworkBehaviour.s_CmdHandlerDelegates.ContainsKey(cmdHash))
			{
				return;
			}
			NetworkBehaviour.Invoker invoker = new NetworkBehaviour.Invoker();
			invoker.invokeType = NetworkBehaviour.UNetInvokeType.Command;
			invoker.invokeClass = invokeClass;
			invoker.invokeFunction = func;
			NetworkBehaviour.s_CmdHandlerDelegates[cmdHash] = invoker;
			if (LogFilter.logDev)
			{
				Debug.Log(string.Concat(new object[]
				{
					"RegisterCommandDelegate hash:",
					cmdHash,
					" ",
					func.Method.Name
				}));
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00005E2C File Offset: 0x0000402C
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected static void RegisterRpcDelegate(Type invokeClass, int cmdHash, NetworkBehaviour.CmdDelegate func)
		{
			if (NetworkBehaviour.s_CmdHandlerDelegates.ContainsKey(cmdHash))
			{
				return;
			}
			NetworkBehaviour.Invoker invoker = new NetworkBehaviour.Invoker();
			invoker.invokeType = NetworkBehaviour.UNetInvokeType.ClientRpc;
			invoker.invokeClass = invokeClass;
			invoker.invokeFunction = func;
			NetworkBehaviour.s_CmdHandlerDelegates[cmdHash] = invoker;
			if (LogFilter.logDev)
			{
				Debug.Log(string.Concat(new object[]
				{
					"RegisterRpcDelegate hash:",
					cmdHash,
					" ",
					func.Method.Name
				}));
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00005EB4 File Offset: 0x000040B4
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected static void RegisterEventDelegate(Type invokeClass, int cmdHash, NetworkBehaviour.CmdDelegate func)
		{
			if (NetworkBehaviour.s_CmdHandlerDelegates.ContainsKey(cmdHash))
			{
				return;
			}
			NetworkBehaviour.Invoker invoker = new NetworkBehaviour.Invoker();
			invoker.invokeType = NetworkBehaviour.UNetInvokeType.SyncEvent;
			invoker.invokeClass = invokeClass;
			invoker.invokeFunction = func;
			NetworkBehaviour.s_CmdHandlerDelegates[cmdHash] = invoker;
			if (LogFilter.logDev)
			{
				Debug.Log(string.Concat(new object[]
				{
					"RegisterEventDelegate hash:",
					cmdHash,
					" ",
					func.Method.Name
				}));
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00005F3C File Offset: 0x0000413C
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected static void RegisterSyncListDelegate(Type invokeClass, int cmdHash, NetworkBehaviour.CmdDelegate func)
		{
			if (NetworkBehaviour.s_CmdHandlerDelegates.ContainsKey(cmdHash))
			{
				return;
			}
			NetworkBehaviour.Invoker invoker = new NetworkBehaviour.Invoker();
			invoker.invokeType = NetworkBehaviour.UNetInvokeType.SyncList;
			invoker.invokeClass = invokeClass;
			invoker.invokeFunction = func;
			NetworkBehaviour.s_CmdHandlerDelegates[cmdHash] = invoker;
			if (LogFilter.logDev)
			{
				Debug.Log(string.Concat(new object[]
				{
					"RegisterSyncListDelegate hash:",
					cmdHash,
					" ",
					func.Method.Name
				}));
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00005FC4 File Offset: 0x000041C4
		internal static string GetInvoker(int cmdHash)
		{
			if (!NetworkBehaviour.s_CmdHandlerDelegates.ContainsKey(cmdHash))
			{
				return null;
			}
			NetworkBehaviour.Invoker invoker = NetworkBehaviour.s_CmdHandlerDelegates[cmdHash];
			return invoker.DebugString();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00005FF8 File Offset: 0x000041F8
		internal static void DumpInvokers()
		{
			Debug.Log("DumpInvokers size:" + NetworkBehaviour.s_CmdHandlerDelegates.Count);
			foreach (KeyValuePair<int, NetworkBehaviour.Invoker> keyValuePair in NetworkBehaviour.s_CmdHandlerDelegates)
			{
				Debug.Log(string.Concat(new object[]
				{
					"  Invoker:",
					keyValuePair.Value.invokeClass,
					":",
					keyValuePair.Value.invokeFunction.Method.Name,
					" ",
					keyValuePair.Value.invokeType,
					" ",
					keyValuePair.Key
				}));
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000060F0 File Offset: 0x000042F0
		internal bool ContainsCommandDelegate(int cmdHash)
		{
			return NetworkBehaviour.s_CmdHandlerDelegates.ContainsKey(cmdHash);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00006100 File Offset: 0x00004300
		internal bool InvokeCommandDelegate(int cmdHash, NetworkReader reader)
		{
			if (!NetworkBehaviour.s_CmdHandlerDelegates.ContainsKey(cmdHash))
			{
				return false;
			}
			NetworkBehaviour.Invoker invoker = NetworkBehaviour.s_CmdHandlerDelegates[cmdHash];
			if (invoker.invokeType != NetworkBehaviour.UNetInvokeType.Command)
			{
				return false;
			}
			if (base.GetType() != invoker.invokeClass)
			{
				if (!base.GetType().IsSubclassOf(invoker.invokeClass))
				{
					return false;
				}
			}
			invoker.invokeFunction(this, reader);
			return true;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00006174 File Offset: 0x00004374
		internal bool InvokeRpcDelegate(int cmdHash, NetworkReader reader)
		{
			if (!NetworkBehaviour.s_CmdHandlerDelegates.ContainsKey(cmdHash))
			{
				return false;
			}
			NetworkBehaviour.Invoker invoker = NetworkBehaviour.s_CmdHandlerDelegates[cmdHash];
			if (invoker.invokeType != NetworkBehaviour.UNetInvokeType.ClientRpc)
			{
				return false;
			}
			if (base.GetType() != invoker.invokeClass)
			{
				if (!base.GetType().IsSubclassOf(invoker.invokeClass))
				{
					return false;
				}
			}
			invoker.invokeFunction(this, reader);
			return true;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000061EC File Offset: 0x000043EC
		internal bool InvokeSyncEventDelegate(int cmdHash, NetworkReader reader)
		{
			if (!NetworkBehaviour.s_CmdHandlerDelegates.ContainsKey(cmdHash))
			{
				return false;
			}
			NetworkBehaviour.Invoker invoker = NetworkBehaviour.s_CmdHandlerDelegates[cmdHash];
			if (invoker.invokeType != NetworkBehaviour.UNetInvokeType.SyncEvent)
			{
				return false;
			}
			invoker.invokeFunction(this, reader);
			return true;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00006234 File Offset: 0x00004434
		internal bool InvokeSyncListDelegate(int cmdHash, NetworkReader reader)
		{
			if (!NetworkBehaviour.s_CmdHandlerDelegates.ContainsKey(cmdHash))
			{
				return false;
			}
			NetworkBehaviour.Invoker invoker = NetworkBehaviour.s_CmdHandlerDelegates[cmdHash];
			if (invoker.invokeType != NetworkBehaviour.UNetInvokeType.SyncList)
			{
				return false;
			}
			if (base.GetType() != invoker.invokeClass)
			{
				return false;
			}
			invoker.invokeFunction(this, reader);
			return true;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00006290 File Offset: 0x00004490
		internal static string GetCmdHashHandlerName(int cmdHash)
		{
			if (!NetworkBehaviour.s_CmdHandlerDelegates.ContainsKey(cmdHash))
			{
				return cmdHash.ToString();
			}
			NetworkBehaviour.Invoker invoker = NetworkBehaviour.s_CmdHandlerDelegates[cmdHash];
			return invoker.invokeType + ":" + invoker.invokeFunction.Method.Name;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000062E8 File Offset: 0x000044E8
		private static string GetCmdHashPrefixName(int cmdHash, string prefix)
		{
			if (!NetworkBehaviour.s_CmdHandlerDelegates.ContainsKey(cmdHash))
			{
				return cmdHash.ToString();
			}
			NetworkBehaviour.Invoker invoker = NetworkBehaviour.s_CmdHandlerDelegates[cmdHash];
			string text = invoker.invokeFunction.Method.Name;
			int num = text.IndexOf(prefix);
			if (num > -1)
			{
				text = text.Substring(prefix.Length);
			}
			return text;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00006348 File Offset: 0x00004548
		internal static string GetCmdHashCmdName(int cmdHash)
		{
			return NetworkBehaviour.GetCmdHashPrefixName(cmdHash, "InvokeCmd");
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00006358 File Offset: 0x00004558
		internal static string GetCmdHashRpcName(int cmdHash)
		{
			return NetworkBehaviour.GetCmdHashPrefixName(cmdHash, "InvokeRpc");
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00006368 File Offset: 0x00004568
		internal static string GetCmdHashEventName(int cmdHash)
		{
			return NetworkBehaviour.GetCmdHashPrefixName(cmdHash, "InvokeSyncEvent");
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00006378 File Offset: 0x00004578
		internal static string GetCmdHashListName(int cmdHash)
		{
			return NetworkBehaviour.GetCmdHashPrefixName(cmdHash, "InvokeSyncList");
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00006388 File Offset: 0x00004588
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void SetSyncVarGameObject(GameObject newGameObject, ref GameObject gameObjectField, uint dirtyBit, ref NetworkInstanceId netIdField)
		{
			if (this.m_SyncVarGuard)
			{
				return;
			}
			NetworkInstanceId networkInstanceId = default(NetworkInstanceId);
			if (newGameObject != null)
			{
				NetworkIdentity component = newGameObject.GetComponent<NetworkIdentity>();
				if (component != null)
				{
					networkInstanceId = component.netId;
					if (networkInstanceId.IsEmpty() && LogFilter.logWarn)
					{
						Debug.LogWarning("SetSyncVarGameObject GameObject " + newGameObject + " has a zero netId. Maybe it is not spawned yet?");
					}
				}
			}
			NetworkInstanceId networkInstanceId2 = default(NetworkInstanceId);
			if (gameObjectField != null)
			{
				networkInstanceId2 = gameObjectField.GetComponent<NetworkIdentity>().netId;
			}
			if (networkInstanceId != networkInstanceId2)
			{
				if (LogFilter.logDev)
				{
					Debug.Log(string.Concat(new object[]
					{
						"SetSyncVar GameObject ",
						base.GetType().Name,
						" bit [",
						dirtyBit,
						"] netfieldId:",
						networkInstanceId2,
						"->",
						networkInstanceId
					}));
				}
				this.SetDirtyBit(dirtyBit);
				gameObjectField = newGameObject;
				netIdField = networkInstanceId;
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000064A0 File Offset: 0x000046A0
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void SetSyncVar<T>(T value, ref T fieldValue, uint dirtyBit)
		{
			if (!value.Equals(fieldValue))
			{
				if (LogFilter.logDev)
				{
					Debug.Log(string.Concat(new object[]
					{
						"SetSyncVar ",
						base.GetType().Name,
						" bit [",
						dirtyBit,
						"] ",
						fieldValue,
						"->",
						value
					}));
				}
				this.SetDirtyBit(dirtyBit);
				fieldValue = value;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00006540 File Offset: 0x00004740
		public void SetDirtyBit(uint dirtyBit)
		{
			this.m_SyncVarDirtyBits |= dirtyBit;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00006550 File Offset: 0x00004750
		public void ClearAllDirtyBits()
		{
			this.m_LastSendTime = Time.time;
			this.m_SyncVarDirtyBits = 0U;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00006564 File Offset: 0x00004764
		internal int GetDirtyChannel()
		{
			if (Time.time - this.m_LastSendTime > this.GetNetworkSendInterval() && this.m_SyncVarDirtyBits != 0U)
			{
				return this.GetNetworkChannel();
			}
			return -1;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000659C File Offset: 0x0000479C
		public virtual bool OnSerialize(NetworkWriter writer, bool initialState)
		{
			if (!initialState)
			{
				writer.WritePackedUInt32(0U);
			}
			return false;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000065AC File Offset: 0x000047AC
		public virtual void OnDeserialize(NetworkReader reader, bool initialState)
		{
			if (!initialState)
			{
				reader.ReadPackedUInt32();
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000065BC File Offset: 0x000047BC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void PreStartClient()
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000065C0 File Offset: 0x000047C0
		public virtual void OnNetworkDestroy()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000065C4 File Offset: 0x000047C4
		public virtual void OnStartServer()
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000065C8 File Offset: 0x000047C8
		public virtual void OnStartClient()
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000065CC File Offset: 0x000047CC
		public virtual void OnStartLocalPlayer()
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000065D0 File Offset: 0x000047D0
		public virtual void OnStartAuthority()
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000065D4 File Offset: 0x000047D4
		public virtual void OnStopAuthority()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000065D8 File Offset: 0x000047D8
		public virtual bool OnRebuildObservers(HashSet<NetworkConnection> observers, bool initialize)
		{
			return false;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000065DC File Offset: 0x000047DC
		public virtual void OnSetLocalVisibility(bool vis)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000065E0 File Offset: 0x000047E0
		public virtual bool OnCheckObserver(NetworkConnection conn)
		{
			return true;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000065E4 File Offset: 0x000047E4
		public virtual int GetNetworkChannel()
		{
			return 0;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000065E8 File Offset: 0x000047E8
		public virtual float GetNetworkSendInterval()
		{
			return 0.1f;
		}

		// Token: 0x04000089 RID: 137
		private const float k_DefaultSendInterval = 0.1f;

		// Token: 0x0400008A RID: 138
		private uint m_SyncVarDirtyBits;

		// Token: 0x0400008B RID: 139
		private float m_LastSendTime;

		// Token: 0x0400008C RID: 140
		private bool m_SyncVarGuard;

		// Token: 0x0400008D RID: 141
		private NetworkIdentity m_MyView;

		// Token: 0x0400008E RID: 142
		private static Dictionary<int, NetworkBehaviour.Invoker> s_CmdHandlerDelegates = new Dictionary<int, NetworkBehaviour.Invoker>();

		// Token: 0x02000030 RID: 48
		protected enum UNetInvokeType
		{
			// Token: 0x04000090 RID: 144
			Command,
			// Token: 0x04000091 RID: 145
			ClientRpc,
			// Token: 0x04000092 RID: 146
			SyncEvent,
			// Token: 0x04000093 RID: 147
			SyncList
		}

		// Token: 0x02000031 RID: 49
		protected class Invoker
		{
			// Token: 0x06000127 RID: 295 RVA: 0x000065F8 File Offset: 0x000047F8
			public string DebugString()
			{
				return string.Concat(new object[]
				{
					this.invokeType,
					":",
					this.invokeClass,
					":",
					this.invokeFunction.Method.Name
				});
			}

			// Token: 0x04000094 RID: 148
			public NetworkBehaviour.UNetInvokeType invokeType;

			// Token: 0x04000095 RID: 149
			public Type invokeClass;

			// Token: 0x04000096 RID: 150
			public NetworkBehaviour.CmdDelegate invokeFunction;
		}

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x06000499 RID: 1177
		protected delegate void CmdDelegate(NetworkBehaviour obj, NetworkReader reader);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x0600049D RID: 1181
		protected delegate void EventDelegate(List<Delegate> targets, NetworkReader reader);
	}
}
