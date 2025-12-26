using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	/// <summary>
	///   <para>This class defines parameters of connection between two peers, this definition includes various timeouts and sizes as well as channel configuration.</para>
	/// </summary>
	// Token: 0x02000221 RID: 545
	[Serializable]
	public class ConnectionConfig
	{
		/// <summary>
		///   <para>Will create default connection config or will copy them from another.</para>
		/// </summary>
		/// <param name="config">Connection config.</param>
		// Token: 0x06001F12 RID: 7954 RVA: 0x00025F10 File Offset: 0x00024110
		public ConnectionConfig()
		{
			this.m_PacketSize = 1500;
			this.m_FragmentSize = 500;
			this.m_ResendTimeout = 1200U;
			this.m_DisconnectTimeout = 2000U;
			this.m_ConnectTimeout = 2000U;
			this.m_MinUpdateTimeout = 10U;
			this.m_PingTimeout = 500U;
			this.m_ReducedPingTimeout = 100U;
			this.m_AllCostTimeout = 20U;
			this.m_NetworkDropThreshold = 5;
			this.m_OverflowDropThreshold = 5;
			this.m_MaxConnectionAttempt = 10;
			this.m_AckDelay = 33U;
			this.m_MaxCombinedReliableMessageSize = 100;
			this.m_MaxCombinedReliableMessageCount = 10;
			this.m_MaxSentMessageQueueSize = 128;
			this.m_IsAcksLong = false;
		}

		/// <summary>
		///   <para>Will create default connection config or will copy them from another.</para>
		/// </summary>
		/// <param name="config">Connection config.</param>
		// Token: 0x06001F13 RID: 7955 RVA: 0x00025FC8 File Offset: 0x000241C8
		public ConnectionConfig(ConnectionConfig config)
		{
			if (config == null)
			{
				throw new NullReferenceException("config is not defined");
			}
			this.m_PacketSize = config.m_PacketSize;
			this.m_FragmentSize = config.m_FragmentSize;
			this.m_ResendTimeout = config.m_ResendTimeout;
			this.m_DisconnectTimeout = config.m_DisconnectTimeout;
			this.m_ConnectTimeout = config.m_ConnectTimeout;
			this.m_MinUpdateTimeout = config.m_MinUpdateTimeout;
			this.m_PingTimeout = config.m_PingTimeout;
			this.m_ReducedPingTimeout = config.m_ReducedPingTimeout;
			this.m_AllCostTimeout = config.m_AllCostTimeout;
			this.m_NetworkDropThreshold = config.m_NetworkDropThreshold;
			this.m_OverflowDropThreshold = config.m_OverflowDropThreshold;
			this.m_MaxConnectionAttempt = config.m_MaxConnectionAttempt;
			this.m_AckDelay = config.m_AckDelay;
			this.m_MaxCombinedReliableMessageSize = config.MaxCombinedReliableMessageSize;
			this.m_MaxCombinedReliableMessageCount = config.m_MaxCombinedReliableMessageCount;
			this.m_MaxSentMessageQueueSize = config.m_MaxSentMessageQueueSize;
			this.m_IsAcksLong = config.m_IsAcksLong;
			foreach (ChannelQOS channelQOS in config.m_Channels)
			{
				this.m_Channels.Add(new ChannelQOS(channelQOS));
			}
		}

		/// <summary>
		///   <para>Validate parameters of connection config. Will throw exceptions if parameters are incorrect.</para>
		/// </summary>
		/// <param name="config"></param>
		// Token: 0x06001F14 RID: 7956 RVA: 0x0002611C File Offset: 0x0002431C
		public static void Validate(ConnectionConfig config)
		{
			if (config.m_PacketSize < 128)
			{
				throw new ArgumentOutOfRangeException("PacketSize should be > " + 128.ToString());
			}
			if (config.m_FragmentSize >= config.m_PacketSize - 128)
			{
				throw new ArgumentOutOfRangeException("FragmentSize should be < PacketSize - " + 128.ToString());
			}
			if (config.m_Channels.Count > 255)
			{
				throw new ArgumentOutOfRangeException("Channels number should be less than 256");
			}
		}

		/// <summary>
		///   <para>What is a maximum packet size (in Bytes) (including payload and all header). Packet can contain multiple messages inside.</para>
		/// </summary>
		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x0000C416 File Offset: 0x0000A616
		// (set) Token: 0x06001F16 RID: 7958 RVA: 0x0000C41E File Offset: 0x0000A61E
		public ushort PacketSize
		{
			get
			{
				return this.m_PacketSize;
			}
			set
			{
				this.m_PacketSize = value;
			}
		}

		/// <summary>
		///   <para>What should be maximum fragment size (in Bytes) for fragmented messages.</para>
		/// </summary>
		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x0000C427 File Offset: 0x0000A627
		// (set) Token: 0x06001F18 RID: 7960 RVA: 0x0000C42F File Offset: 0x0000A62F
		public ushort FragmentSize
		{
			get
			{
				return this.m_FragmentSize;
			}
			set
			{
				this.m_FragmentSize = value;
			}
		}

		/// <summary>
		///   <para>Minimum timeout (in ms) which library will wait before it will resend reliable message.</para>
		/// </summary>
		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001F19 RID: 7961 RVA: 0x0000C438 File Offset: 0x0000A638
		// (set) Token: 0x06001F1A RID: 7962 RVA: 0x0000C440 File Offset: 0x0000A640
		public uint ResendTimeout
		{
			get
			{
				return this.m_ResendTimeout;
			}
			set
			{
				this.m_ResendTimeout = value;
			}
		}

		/// <summary>
		///   <para>How long (in ms) library will wait before it will consider connection as disconnected.</para>
		/// </summary>
		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x0000C449 File Offset: 0x0000A649
		// (set) Token: 0x06001F1C RID: 7964 RVA: 0x0000C451 File Offset: 0x0000A651
		public uint DisconnectTimeout
		{
			get
			{
				return this.m_DisconnectTimeout;
			}
			set
			{
				this.m_DisconnectTimeout = value;
			}
		}

		/// <summary>
		///   <para>Timeout in ms which library will wait before it will send another connection request.</para>
		/// </summary>
		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x0000C45A File Offset: 0x0000A65A
		// (set) Token: 0x06001F1E RID: 7966 RVA: 0x0000C462 File Offset: 0x0000A662
		public uint ConnectTimeout
		{
			get
			{
				return this.m_ConnectTimeout;
			}
			set
			{
				this.m_ConnectTimeout = value;
			}
		}

		/// <summary>
		///   <para>Minimal send update timeout (in ms) for connection. this timeout could be increased by library if flow control will required.</para>
		/// </summary>
		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001F1F RID: 7967 RVA: 0x0000C46B File Offset: 0x0000A66B
		// (set) Token: 0x06001F20 RID: 7968 RVA: 0x0000C473 File Offset: 0x0000A673
		public uint MinUpdateTimeout
		{
			get
			{
				return this.m_MinUpdateTimeout;
			}
			set
			{
				if (value == 0U)
				{
					throw new ArgumentOutOfRangeException("Minimal update timeout should be > 0");
				}
				this.m_MinUpdateTimeout = value;
			}
		}

		/// <summary>
		///   <para>Timeout in ms between control protocol messages.</para>
		/// </summary>
		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x0000C48D File Offset: 0x0000A68D
		// (set) Token: 0x06001F22 RID: 7970 RVA: 0x0000C495 File Offset: 0x0000A695
		public uint PingTimeout
		{
			get
			{
				return this.m_PingTimeout;
			}
			set
			{
				this.m_PingTimeout = value;
			}
		}

		/// <summary>
		///   <para>Timeout in ms for control messages which library will use before it will accumulate statistics.</para>
		/// </summary>
		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x0000C49E File Offset: 0x0000A69E
		// (set) Token: 0x06001F24 RID: 7972 RVA: 0x0000C4A6 File Offset: 0x0000A6A6
		public uint ReducedPingTimeout
		{
			get
			{
				return this.m_ReducedPingTimeout;
			}
			set
			{
				this.m_ReducedPingTimeout = value;
			}
		}

		/// <summary>
		///   <para>Defines timeout in ms after that message with AllCost deliver qos will force resend without acknowledgement waiting.</para>
		/// </summary>
		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x0000C4AF File Offset: 0x0000A6AF
		// (set) Token: 0x06001F26 RID: 7974 RVA: 0x0000C4B7 File Offset: 0x0000A6B7
		public uint AllCostTimeout
		{
			get
			{
				return this.m_AllCostTimeout;
			}
			set
			{
				this.m_AllCostTimeout = value;
			}
		}

		/// <summary>
		///   <para>How many (in %) packet need to be dropped due network condition before library will throttle send rate.</para>
		/// </summary>
		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001F27 RID: 7975 RVA: 0x0000C4C0 File Offset: 0x0000A6C0
		// (set) Token: 0x06001F28 RID: 7976 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		public byte NetworkDropThreshold
		{
			get
			{
				return this.m_NetworkDropThreshold;
			}
			set
			{
				this.m_NetworkDropThreshold = value;
			}
		}

		/// <summary>
		///   <para>How many (in %) packet need to be dropped due lack of internal bufferes before library will throttle send rate.</para>
		/// </summary>
		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x0000C4D1 File Offset: 0x0000A6D1
		// (set) Token: 0x06001F2A RID: 7978 RVA: 0x0000C4D9 File Offset: 0x0000A6D9
		public byte OverflowDropThreshold
		{
			get
			{
				return this.m_OverflowDropThreshold;
			}
			set
			{
				this.m_OverflowDropThreshold = value;
			}
		}

		/// <summary>
		///   <para>How many attempt library will get before it will consider the connection as disconnected.</para>
		/// </summary>
		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x0000C4E2 File Offset: 0x0000A6E2
		// (set) Token: 0x06001F2C RID: 7980 RVA: 0x0000C4EA File Offset: 0x0000A6EA
		public byte MaxConnectionAttempt
		{
			get
			{
				return this.m_MaxConnectionAttempt;
			}
			set
			{
				this.m_MaxConnectionAttempt = value;
			}
		}

		/// <summary>
		///   <para>How long in ms receiver will wait before it will force send acknowledgements back without waiting any payload.</para>
		/// </summary>
		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x0000C4F3 File Offset: 0x0000A6F3
		// (set) Token: 0x06001F2E RID: 7982 RVA: 0x0000C4FB File Offset: 0x0000A6FB
		public uint AckDelay
		{
			get
			{
				return this.m_AckDelay;
			}
			set
			{
				this.m_AckDelay = value;
			}
		}

		/// <summary>
		///   <para>Maximum size of reliable message which library will consider as small and will try to combine in one "array of messages" message.</para>
		/// </summary>
		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x0000C504 File Offset: 0x0000A704
		// (set) Token: 0x06001F30 RID: 7984 RVA: 0x0000C50C File Offset: 0x0000A70C
		public ushort MaxCombinedReliableMessageSize
		{
			get
			{
				return this.m_MaxCombinedReliableMessageSize;
			}
			set
			{
				this.m_MaxCombinedReliableMessageSize = value;
			}
		}

		/// <summary>
		///   <para>Maximum amount of small reliable messages which will combine in one "array of messages". Useful if you are going to send a lot of small reliable messages.</para>
		/// </summary>
		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x0000C515 File Offset: 0x0000A715
		// (set) Token: 0x06001F32 RID: 7986 RVA: 0x0000C51D File Offset: 0x0000A71D
		public ushort MaxCombinedReliableMessageCount
		{
			get
			{
				return this.m_MaxCombinedReliableMessageCount;
			}
			set
			{
				this.m_MaxCombinedReliableMessageCount = value;
			}
		}

		/// <summary>
		///   <para>Defines maximum messages which will wait for sending before user will receive error on Send() call.</para>
		/// </summary>
		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x0000C526 File Offset: 0x0000A726
		// (set) Token: 0x06001F34 RID: 7988 RVA: 0x0000C52E File Offset: 0x0000A72E
		public ushort MaxSentMessageQueueSize
		{
			get
			{
				return this.m_MaxSentMessageQueueSize;
			}
			set
			{
				this.m_MaxSentMessageQueueSize = value;
			}
		}

		/// <summary>
		///   <para>If it is true, connection will use 64 bit mask to acknowledge received reliable messages.</para>
		/// </summary>
		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x0000C537 File Offset: 0x0000A737
		// (set) Token: 0x06001F36 RID: 7990 RVA: 0x0000C53F File Offset: 0x0000A73F
		public bool IsAcksLong
		{
			get
			{
				return this.m_IsAcksLong;
			}
			set
			{
				this.m_IsAcksLong = value;
			}
		}

		/// <summary>
		///   <para>Return amount of channels for current configuration.</para>
		/// </summary>
		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x0000C548 File Offset: 0x0000A748
		public int ChannelCount
		{
			get
			{
				return this.m_Channels.Count;
			}
		}

		/// <summary>
		///   <para></para>
		/// </summary>
		/// <param name="value">Add new channel to configuration.</param>
		/// <returns>
		///   <para>Channel id, user can use this id to send message via this channel.</para>
		/// </returns>
		// Token: 0x06001F38 RID: 7992 RVA: 0x000261AC File Offset: 0x000243AC
		public byte AddChannel(QosType value)
		{
			if (this.m_Channels.Count > 255)
			{
				throw new ArgumentOutOfRangeException("Channels Count should be less than 256");
			}
			if (!Enum.IsDefined(typeof(QosType), value))
			{
				throw new ArgumentOutOfRangeException("requested qos type doesn't exist: " + (int)value);
			}
			ChannelQOS channelQOS = new ChannelQOS(value);
			this.m_Channels.Add(channelQOS);
			return (byte)(this.m_Channels.Count - 1);
		}

		/// <summary>
		///   <para>Return the QoS set for the given channel or throw an out of range exception.</para>
		/// </summary>
		/// <param name="idx">Index in array.</param>
		/// <returns>
		///   <para>Channel QoS.</para>
		/// </returns>
		// Token: 0x06001F39 RID: 7993 RVA: 0x0000C555 File Offset: 0x0000A755
		public QosType GetChannel(byte idx)
		{
			if ((int)idx >= this.m_Channels.Count)
			{
				throw new ArgumentOutOfRangeException("requested index greater than maximum channels count");
			}
			return this.m_Channels[(int)idx].QOS;
		}

		/// <summary>
		///   <para>Allow access to channels list.</para>
		/// </summary>
		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x0000C584 File Offset: 0x0000A784
		public List<ChannelQOS> Channels
		{
			get
			{
				return this.m_Channels;
			}
		}

		// Token: 0x04000879 RID: 2169
		private const int g_MinPacketSize = 128;

		// Token: 0x0400087A RID: 2170
		[SerializeField]
		private ushort m_PacketSize;

		// Token: 0x0400087B RID: 2171
		[SerializeField]
		private ushort m_FragmentSize;

		// Token: 0x0400087C RID: 2172
		[SerializeField]
		private uint m_ResendTimeout;

		// Token: 0x0400087D RID: 2173
		[SerializeField]
		private uint m_DisconnectTimeout;

		// Token: 0x0400087E RID: 2174
		[SerializeField]
		private uint m_ConnectTimeout;

		// Token: 0x0400087F RID: 2175
		[SerializeField]
		private uint m_MinUpdateTimeout;

		// Token: 0x04000880 RID: 2176
		[SerializeField]
		private uint m_PingTimeout;

		// Token: 0x04000881 RID: 2177
		[SerializeField]
		private uint m_ReducedPingTimeout;

		// Token: 0x04000882 RID: 2178
		[SerializeField]
		private uint m_AllCostTimeout;

		// Token: 0x04000883 RID: 2179
		[SerializeField]
		private byte m_NetworkDropThreshold;

		// Token: 0x04000884 RID: 2180
		[SerializeField]
		private byte m_OverflowDropThreshold;

		// Token: 0x04000885 RID: 2181
		[SerializeField]
		private byte m_MaxConnectionAttempt;

		// Token: 0x04000886 RID: 2182
		[SerializeField]
		private uint m_AckDelay;

		// Token: 0x04000887 RID: 2183
		[SerializeField]
		private ushort m_MaxCombinedReliableMessageSize;

		// Token: 0x04000888 RID: 2184
		[SerializeField]
		private ushort m_MaxCombinedReliableMessageCount;

		// Token: 0x04000889 RID: 2185
		[SerializeField]
		private ushort m_MaxSentMessageQueueSize;

		// Token: 0x0400088A RID: 2186
		[SerializeField]
		private bool m_IsAcksLong;

		// Token: 0x0400088B RID: 2187
		[SerializeField]
		internal List<ChannelQOS> m_Channels = new List<ChannelQOS>();
	}
}
