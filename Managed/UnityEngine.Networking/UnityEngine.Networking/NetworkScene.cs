using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	// Token: 0x02000049 RID: 73
	internal class NetworkScene
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0000F978 File Offset: 0x0000DB78
		internal Dictionary<NetworkInstanceId, NetworkIdentity> localObjects
		{
			get
			{
				return this.m_LocalObjects;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000F980 File Offset: 0x0000DB80
		internal static Dictionary<NetworkHash128, GameObject> guidToPrefab
		{
			get
			{
				return NetworkScene.s_GuidToPrefab;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000F988 File Offset: 0x0000DB88
		internal static Dictionary<NetworkHash128, SpawnDelegate> spawnHandlers
		{
			get
			{
				return NetworkScene.s_SpawnHandlers;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000F990 File Offset: 0x0000DB90
		internal static Dictionary<NetworkHash128, UnSpawnDelegate> unspawnHandlers
		{
			get
			{
				return NetworkScene.s_UnspawnHandlers;
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000F998 File Offset: 0x0000DB98
		internal void Shutdown()
		{
			this.ClearLocalObjects();
			NetworkScene.ClearSpawners();
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		internal void SetLocalObject(NetworkInstanceId netId, GameObject obj, bool isClient, bool isServer)
		{
			if (LogFilter.logDev)
			{
				Debug.Log(string.Concat(new object[] { "SetLocalObject ", netId, " ", obj }));
			}
			if (obj == null)
			{
				this.m_LocalObjects[netId] = null;
				return;
			}
			NetworkIdentity networkIdentity = null;
			if (this.m_LocalObjects.ContainsKey(netId))
			{
				networkIdentity = this.m_LocalObjects[netId];
			}
			if (networkIdentity == null)
			{
				networkIdentity = obj.GetComponent<NetworkIdentity>();
				this.m_LocalObjects[netId] = networkIdentity;
			}
			networkIdentity.UpdateClientServer(isClient, isServer);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000FA50 File Offset: 0x0000DC50
		internal GameObject FindLocalObject(NetworkInstanceId netId)
		{
			if (this.m_LocalObjects.ContainsKey(netId))
			{
				NetworkIdentity networkIdentity = this.m_LocalObjects[netId];
				if (networkIdentity != null)
				{
					return networkIdentity.gameObject;
				}
			}
			return null;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000FA90 File Offset: 0x0000DC90
		internal bool GetNetworkIdentity(NetworkInstanceId netId, out NetworkIdentity uv)
		{
			if (this.m_LocalObjects.ContainsKey(netId) && this.m_LocalObjects[netId] != null)
			{
				uv = this.m_LocalObjects[netId];
				return true;
			}
			uv = null;
			return false;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000FADC File Offset: 0x0000DCDC
		internal bool RemoveLocalObject(NetworkInstanceId netId)
		{
			return this.m_LocalObjects.Remove(netId);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000FAEC File Offset: 0x0000DCEC
		internal bool RemoveLocalObjectAndDestroy(NetworkInstanceId netId)
		{
			if (this.m_LocalObjects.ContainsKey(netId))
			{
				NetworkIdentity networkIdentity = this.m_LocalObjects[netId];
				Object.Destroy(networkIdentity.gameObject);
				return this.m_LocalObjects.Remove(netId);
			}
			return false;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000FB30 File Offset: 0x0000DD30
		internal void ClearLocalObjects()
		{
			this.m_LocalObjects.Clear();
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000FB40 File Offset: 0x0000DD40
		internal static void RegisterPrefab(GameObject prefab)
		{
			NetworkIdentity component = prefab.GetComponent<NetworkIdentity>();
			if (component)
			{
				if (LogFilter.logDebug)
				{
					Debug.Log(string.Concat(new object[] { "Registering prefab '", prefab.name, "' as asset:", component.assetId }));
				}
				NetworkScene.s_GuidToPrefab[component.assetId] = prefab;
				NetworkIdentity[] componentsInChildren = prefab.GetComponentsInChildren<NetworkIdentity>();
				if (componentsInChildren.Length > 1 && LogFilter.logWarn)
				{
					Debug.LogWarning("The prefab '" + prefab.name + "' has multiple NetworkIdentity components. There can only be one NetworkIdentity on a prefab, and it must be on the root object.");
				}
			}
			else if (LogFilter.logError)
			{
				Debug.LogError("Could not register '" + prefab.name + "' since it contains no NetworkIdentity component");
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000FC10 File Offset: 0x0000DE10
		internal static bool GetPrefab(NetworkHash128 assetId, out GameObject prefab)
		{
			if (!assetId.IsValid())
			{
				prefab = null;
				return false;
			}
			if (NetworkScene.s_GuidToPrefab.ContainsKey(assetId) && NetworkScene.s_GuidToPrefab[assetId] != null)
			{
				prefab = NetworkScene.s_GuidToPrefab[assetId];
				return true;
			}
			prefab = null;
			return false;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000FC68 File Offset: 0x0000DE68
		internal static void ClearSpawners()
		{
			NetworkScene.s_GuidToPrefab.Clear();
			NetworkScene.s_SpawnHandlers.Clear();
			NetworkScene.s_UnspawnHandlers.Clear();
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000FC88 File Offset: 0x0000DE88
		public static void UnregisterSpawnHandler(NetworkHash128 assetId)
		{
			NetworkScene.s_SpawnHandlers.Remove(assetId);
			NetworkScene.s_UnspawnHandlers.Remove(assetId);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000FCA4 File Offset: 0x0000DEA4
		internal static void RegisterSpawnHandler(NetworkHash128 assetId, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
		{
			if (spawnHandler == null || unspawnHandler == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("RegisterSpawnHandler custom spawn function null for " + assetId);
				}
				return;
			}
			if (LogFilter.logDebug)
			{
				Debug.Log(string.Concat(new object[]
				{
					"RegisterSpawnHandler asset '",
					assetId,
					"' ",
					spawnHandler.Method.Name,
					"/",
					unspawnHandler.Method.Name
				}));
			}
			NetworkScene.s_SpawnHandlers[assetId] = spawnHandler;
			NetworkScene.s_UnspawnHandlers[assetId] = unspawnHandler;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000FD4C File Offset: 0x0000DF4C
		internal static void UnregisterPrefab(GameObject prefab)
		{
			NetworkIdentity component = prefab.GetComponent<NetworkIdentity>();
			if (component == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("Could not unregister '" + prefab.name + "' since it contains no NetworkIdentity component");
				}
				return;
			}
			NetworkScene.s_SpawnHandlers.Remove(component.assetId);
			NetworkScene.s_UnspawnHandlers.Remove(component.assetId);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
		internal static void RegisterPrefab(GameObject prefab, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
		{
			NetworkIdentity component = prefab.GetComponent<NetworkIdentity>();
			if (component == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("Could not register '" + prefab.name + "' since it contains no NetworkIdentity component");
				}
				return;
			}
			if (spawnHandler == null || unspawnHandler == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("RegisterPrefab custom spawn function null for " + component.assetId);
				}
				return;
			}
			if (!component.assetId.IsValid())
			{
				if (LogFilter.logError)
				{
					Debug.LogError("RegisterPrefab game object " + prefab.name + " has no prefab. Use RegisterSpawnHandler() instead?");
				}
				return;
			}
			if (LogFilter.logDebug)
			{
				Debug.Log(string.Concat(new object[]
				{
					"Registering custom prefab '",
					prefab.name,
					"' as asset:",
					component.assetId,
					" ",
					spawnHandler.Method.Name,
					"/",
					unspawnHandler.Method.Name
				}));
			}
			NetworkScene.s_SpawnHandlers[component.assetId] = spawnHandler;
			NetworkScene.s_UnspawnHandlers[component.assetId] = unspawnHandler;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000FEF4 File Offset: 0x0000E0F4
		internal static bool GetSpawnHandler(NetworkHash128 assetId, out SpawnDelegate handler)
		{
			if (NetworkScene.s_SpawnHandlers.ContainsKey(assetId))
			{
				handler = NetworkScene.s_SpawnHandlers[assetId];
				return true;
			}
			handler = null;
			return false;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000FF1C File Offset: 0x0000E11C
		internal static bool InvokeUnSpawnHandler(NetworkHash128 assetId, GameObject obj)
		{
			if (NetworkScene.s_UnspawnHandlers.ContainsKey(assetId) && NetworkScene.s_UnspawnHandlers[assetId] != null)
			{
				UnSpawnDelegate unSpawnDelegate = NetworkScene.s_UnspawnHandlers[assetId];
				unSpawnDelegate(obj);
				return true;
			}
			return false;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000FF60 File Offset: 0x0000E160
		internal void DestroyAllClientObjects()
		{
			foreach (NetworkInstanceId networkInstanceId in this.m_LocalObjects.Keys)
			{
				NetworkIdentity networkIdentity = this.m_LocalObjects[networkInstanceId];
				if (networkIdentity != null && networkIdentity.gameObject != null)
				{
					if (networkIdentity.sceneId.IsEmpty())
					{
						Object.Destroy(networkIdentity.gameObject);
					}
					else
					{
						networkIdentity.gameObject.SetActive(false);
					}
				}
			}
			this.ClearLocalObjects();
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00010024 File Offset: 0x0000E224
		internal void DumpAllClientObjects()
		{
			foreach (NetworkInstanceId networkInstanceId in this.m_LocalObjects.Keys)
			{
				NetworkIdentity networkIdentity = this.m_LocalObjects[networkInstanceId];
				if (networkIdentity != null)
				{
					Debug.Log(string.Concat(new object[] { "ID:", networkInstanceId, " OBJ:", networkIdentity.gameObject, " AS:", networkIdentity.assetId }));
				}
				else
				{
					Debug.Log("ID:" + networkInstanceId + " OBJ: null");
				}
			}
		}

		// Token: 0x04000165 RID: 357
		private Dictionary<NetworkInstanceId, NetworkIdentity> m_LocalObjects = new Dictionary<NetworkInstanceId, NetworkIdentity>();

		// Token: 0x04000166 RID: 358
		private static Dictionary<NetworkHash128, GameObject> s_GuidToPrefab = new Dictionary<NetworkHash128, GameObject>();

		// Token: 0x04000167 RID: 359
		private static Dictionary<NetworkHash128, SpawnDelegate> s_SpawnHandlers = new Dictionary<NetworkHash128, SpawnDelegate>();

		// Token: 0x04000168 RID: 360
		private static Dictionary<NetworkHash128, UnSpawnDelegate> s_UnspawnHandlers = new Dictionary<NetworkHash128, UnSpawnDelegate>();
	}
}
