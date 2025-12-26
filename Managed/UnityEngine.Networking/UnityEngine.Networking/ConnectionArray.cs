using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	// Token: 0x02000006 RID: 6
	internal class ConnectionArray
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00003F08 File Offset: 0x00002108
		public ConnectionArray()
		{
			this.m_Connections = new List<NetworkConnection>();
			this.m_LocalConnections = new List<NetworkConnection>();
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00003F28 File Offset: 0x00002128
		internal List<NetworkConnection> localConnections
		{
			get
			{
				return this.m_LocalConnections;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003F30 File Offset: 0x00002130
		internal List<NetworkConnection> connections
		{
			get
			{
				return this.m_Connections;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003F38 File Offset: 0x00002138
		public int Count
		{
			get
			{
				return this.m_Connections.Count;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00003F48 File Offset: 0x00002148
		public int LocalIndex
		{
			get
			{
				return -this.m_LocalConnections.Count;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003F58 File Offset: 0x00002158
		public int Add(int connId, NetworkConnection conn)
		{
			if (connId < 0)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("ConnectionArray Add bad id " + connId);
				}
				return -1;
			}
			if (connId < this.m_Connections.Count && this.m_Connections[connId] != null)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("ConnectionArray Add dupe at " + connId);
				}
				return -1;
			}
			while (connId > this.m_Connections.Count - 1)
			{
				this.m_Connections.Add(null);
			}
			this.m_Connections[connId] = conn;
			return connId;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004004 File Offset: 0x00002204
		public NetworkConnection Get(int connId)
		{
			if (connId < 0)
			{
				return this.m_LocalConnections[Mathf.Abs(connId) - 1];
			}
			if (connId < 0 || connId > this.m_Connections.Count)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("ConnectionArray Get invalid index " + connId);
				}
				return null;
			}
			return this.m_Connections[connId];
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004074 File Offset: 0x00002274
		public NetworkConnection GetUnsafe(int connId)
		{
			if (connId < 0 || connId > this.m_Connections.Count)
			{
				return null;
			}
			return this.m_Connections[connId];
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000040A8 File Offset: 0x000022A8
		public void Remove(int connId)
		{
			if (connId < 0)
			{
				this.m_LocalConnections[Mathf.Abs(connId) - 1] = null;
				return;
			}
			if (connId < 0 || connId > this.m_Connections.Count)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("ConnectionArray Remove invalid index " + connId);
				}
				return;
			}
			this.m_Connections[connId] = null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004118 File Offset: 0x00002318
		public int AddLocal(NetworkConnection conn)
		{
			this.m_LocalConnections.Add(conn);
			int num = -this.m_LocalConnections.Count;
			conn.connectionId = num;
			return num;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004148 File Offset: 0x00002348
		public bool ContainsPlayer(GameObject player, out NetworkConnection conn)
		{
			conn = null;
			if (player == null)
			{
				return false;
			}
			for (int i = this.LocalIndex; i < this.m_Connections.Count; i++)
			{
				conn = this.Get(i);
				if (conn != null)
				{
					for (int j = 0; j < conn.playerControllers.Count; j++)
					{
						if (conn.playerControllers[j].IsValid && conn.playerControllers[j].gameObject == player)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0400002C RID: 44
		private List<NetworkConnection> m_LocalConnections;

		// Token: 0x0400002D RID: 45
		private List<NetworkConnection> m_Connections;
	}
}
