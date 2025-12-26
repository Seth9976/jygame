using System;

namespace UnityEngine.Networking
{
	/// <summary>
	///   <para>Defines global paramters for network library.</para>
	/// </summary>
	// Token: 0x02000223 RID: 547
	[Serializable]
	public class GlobalConfig
	{
		/// <summary>
		///   <para>Create new global config object.</para>
		/// </summary>
		// Token: 0x06001F49 RID: 8009 RVA: 0x0000C695 File Offset: 0x0000A895
		public GlobalConfig()
		{
			this.m_ThreadAwakeTimeout = 1U;
			this.m_ReactorModel = ReactorModel.SelectReactor;
			this.m_ReactorMaximumReceivedMessages = 1024;
			this.m_ReactorMaximumSentMessages = 1024;
			this.m_MaxPacketSize = 2000;
		}

		/// <summary>
		///   <para>Defines (1) for select reactor, minimum time period, when system will check if there are any messages for send (2) for fixrate reactor, minimum interval of time, when system will check for sending and receiving messages.</para>
		/// </summary>
		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x0000C6CC File Offset: 0x0000A8CC
		// (set) Token: 0x06001F4B RID: 8011 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		public uint ThreadAwakeTimeout
		{
			get
			{
				return this.m_ThreadAwakeTimeout;
			}
			set
			{
				if (value == 0U)
				{
					throw new ArgumentOutOfRangeException("Minimal thread awake timeout should be > 0");
				}
				this.m_ThreadAwakeTimeout = value;
			}
		}

		/// <summary>
		///   <para>Defines reactor model for the network library.</para>
		/// </summary>
		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001F4C RID: 8012 RVA: 0x0000C6EE File Offset: 0x0000A8EE
		// (set) Token: 0x06001F4D RID: 8013 RVA: 0x0000C6F6 File Offset: 0x0000A8F6
		public ReactorModel ReactorModel
		{
			get
			{
				return this.m_ReactorModel;
			}
			set
			{
				this.m_ReactorModel = value;
			}
		}

		/// <summary>
		///   <para>Defines maximum amount of messages in the receive queue.</para>
		/// </summary>
		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x0000C6FF File Offset: 0x0000A8FF
		// (set) Token: 0x06001F4F RID: 8015 RVA: 0x0000C707 File Offset: 0x0000A907
		public ushort ReactorMaximumReceivedMessages
		{
			get
			{
				return this.m_ReactorMaximumReceivedMessages;
			}
			set
			{
				this.m_ReactorMaximumReceivedMessages = value;
			}
		}

		/// <summary>
		///   <para>Defines maximum message count in sent queue.</para>
		/// </summary>
		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x0000C710 File Offset: 0x0000A910
		// (set) Token: 0x06001F51 RID: 8017 RVA: 0x0000C718 File Offset: 0x0000A918
		public ushort ReactorMaximumSentMessages
		{
			get
			{
				return this.m_ReactorMaximumSentMessages;
			}
			set
			{
				this.m_ReactorMaximumSentMessages = value;
			}
		}

		/// <summary>
		///   <para>Defines maximum possible packet size in bytes for all network connections.</para>
		/// </summary>
		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x0000C721 File Offset: 0x0000A921
		// (set) Token: 0x06001F53 RID: 8019 RVA: 0x0000C729 File Offset: 0x0000A929
		public ushort MaxPacketSize
		{
			get
			{
				return this.m_MaxPacketSize;
			}
			set
			{
				this.m_MaxPacketSize = value;
			}
		}

		// Token: 0x04000892 RID: 2194
		[SerializeField]
		private uint m_ThreadAwakeTimeout;

		// Token: 0x04000893 RID: 2195
		[SerializeField]
		private ReactorModel m_ReactorModel;

		// Token: 0x04000894 RID: 2196
		[SerializeField]
		private ushort m_ReactorMaximumReceivedMessages;

		// Token: 0x04000895 RID: 2197
		[SerializeField]
		private ushort m_ReactorMaximumSentMessages;

		// Token: 0x04000896 RID: 2198
		[SerializeField]
		private ushort m_MaxPacketSize;
	}
}
