using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	/// <summary>
	///   <para>Class defines network topology for host (socket opened by Networking.NetworkTransport.AddHost function). This topology defines: (1) how many connection with default config will be supported and (2) what will be special connections (connections with config different from default).</para>
	/// </summary>
	// Token: 0x02000222 RID: 546
	[Serializable]
	public class HostTopology
	{
		/// <summary>
		///   <para>Create topology.</para>
		/// </summary>
		/// <param name="defaultConfig">Default config.</param>
		/// <param name="maxDefaultConnections">Maximum default connections.</param>
		// Token: 0x06001F3B RID: 7995 RVA: 0x0002622C File Offset: 0x0002442C
		public HostTopology(ConnectionConfig defaultConfig, int maxDefaultConnections)
		{
			if (defaultConfig == null)
			{
				throw new NullReferenceException("config is not defined");
			}
			if (maxDefaultConnections <= 0)
			{
				throw new ArgumentOutOfRangeException("maxDefaultConnections", "count connection should be > 0");
			}
			if (maxDefaultConnections > 65535)
			{
				throw new ArgumentOutOfRangeException("maxDefaultConnections", "count connection should be < 65535");
			}
			ConnectionConfig.Validate(defaultConfig);
			this.m_DefConfig = new ConnectionConfig(defaultConfig);
			this.m_MaxDefConnections = maxDefaultConnections;
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x0000C58C File Offset: 0x0000A78C
		private HostTopology()
		{
		}

		/// <summary>
		///   <para>Defines config for default connections in the topology.</para>
		/// </summary>
		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x0000C5C0 File Offset: 0x0000A7C0
		public ConnectionConfig DefaultConfig
		{
			get
			{
				return this.m_DefConfig;
			}
		}

		/// <summary>
		///   <para>Defines how many connection with default config be permitted.</para>
		/// </summary>
		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x0000C5C8 File Offset: 0x0000A7C8
		public int MaxDefaultConnections
		{
			get
			{
				return this.m_MaxDefConnections;
			}
		}

		/// <summary>
		///   <para>Returns count of special connection added to topology.</para>
		/// </summary>
		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		public int SpecialConnectionConfigsCount
		{
			get
			{
				return this.m_SpecialConnections.Count;
			}
		}

		/// <summary>
		///   <para>List of special connection configs.</para>
		/// </summary>
		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x0000C5DD File Offset: 0x0000A7DD
		public List<ConnectionConfig> SpecialConnectionConfigs
		{
			get
			{
				return this.m_SpecialConnections;
			}
		}

		/// <summary>
		///   <para>Return reference to special connection config. Parameters of this config can be changed.</para>
		/// </summary>
		/// <param name="i">Config id.</param>
		/// <returns>
		///   <para>Connection config.</para>
		/// </returns>
		// Token: 0x06001F41 RID: 8001 RVA: 0x0000C5E5 File Offset: 0x0000A7E5
		public ConnectionConfig GetSpecialConnectionConfig(int i)
		{
			if (i > this.m_SpecialConnections.Count || i == 0)
			{
				throw new ArgumentException("special configuration index is out of valid range");
			}
			return this.m_SpecialConnections[i - 1];
		}

		/// <summary>
		///   <para>What is the size of received messages pool (default 128 bytes).</para>
		/// </summary>
		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x0000C617 File Offset: 0x0000A817
		// (set) Token: 0x06001F43 RID: 8003 RVA: 0x0000C61F File Offset: 0x0000A81F
		public ushort ReceivedMessagePoolSize
		{
			get
			{
				return this.m_ReceivedMessagePoolSize;
			}
			set
			{
				this.m_ReceivedMessagePoolSize = value;
			}
		}

		/// <summary>
		///   <para>Defines size of sent message pool (default value 128).</para>
		/// </summary>
		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x0000C628 File Offset: 0x0000A828
		// (set) Token: 0x06001F45 RID: 8005 RVA: 0x0000C630 File Offset: 0x0000A830
		public ushort SentMessagePoolSize
		{
			get
			{
				return this.m_SentMessagePoolSize;
			}
			set
			{
				this.m_SentMessagePoolSize = value;
			}
		}

		/// <summary>
		///   <para>Library keep and reuse internal pools of messages. By default they have size 128. If this value is not enough pools will be automatically increased. This value defines how they will increase. Default value is 0.75, so if original pool size was 128, the new pool size will be 128 * 1.75 = 224.</para>
		/// </summary>
		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x0000C639 File Offset: 0x0000A839
		// (set) Token: 0x06001F47 RID: 8007 RVA: 0x0000C641 File Offset: 0x0000A841
		public float MessagePoolSizeGrowthFactor
		{
			get
			{
				return this.m_MessagePoolSizeGrowthFactor;
			}
			set
			{
				if ((double)value <= 0.5 || (double)value > 1.0)
				{
					throw new ArgumentException("pool growth factor should be varied between 0.5 and 1.0");
				}
				this.m_MessagePoolSizeGrowthFactor = value;
			}
		}

		/// <summary>
		///   <para>Add special connection to topology (for example if you need to keep connection to standalone chat server you will need to use this function). Returned id should be use as one of parameters (with ip and port) to establish connection to this server.</para>
		/// </summary>
		/// <param name="config">Connection config for special connection.</param>
		/// <returns>
		///   <para>Id of this connection, user should use this id when he calls Networking.NetworkTransport.Connect.</para>
		/// </returns>
		// Token: 0x06001F48 RID: 8008 RVA: 0x0000C675 File Offset: 0x0000A875
		public int AddSpecialConnectionConfig(ConnectionConfig config)
		{
			this.m_SpecialConnections.Add(new ConnectionConfig(config));
			return this.m_SpecialConnections.Count - 1;
		}

		// Token: 0x0400088C RID: 2188
		[SerializeField]
		private ConnectionConfig m_DefConfig;

		// Token: 0x0400088D RID: 2189
		[SerializeField]
		private int m_MaxDefConnections;

		// Token: 0x0400088E RID: 2190
		[SerializeField]
		private List<ConnectionConfig> m_SpecialConnections = new List<ConnectionConfig>();

		// Token: 0x0400088F RID: 2191
		[SerializeField]
		private ushort m_ReceivedMessagePoolSize = 128;

		// Token: 0x04000890 RID: 2192
		[SerializeField]
		private ushort m_SentMessagePoolSize = 128;

		// Token: 0x04000891 RID: 2193
		[SerializeField]
		private float m_MessagePoolSizeGrowthFactor = 0.75f;
	}
}
