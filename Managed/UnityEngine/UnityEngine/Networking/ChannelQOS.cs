using System;

namespace UnityEngine.Networking
{
	/// <summary>
	///   <para>Defines parameters of channels.</para>
	/// </summary>
	// Token: 0x02000220 RID: 544
	[Serializable]
	public class ChannelQOS
	{
		/// <summary>
		///   <para>UnderlyingModel.MemDoc.MemDocModel.</para>
		/// </summary>
		/// <param name="value">Requested type of quality of service (default Unreliable).</param>
		/// <param name="channel">Copy constructor.</param>
		// Token: 0x06001F0E RID: 7950 RVA: 0x0000C3CB File Offset: 0x0000A5CB
		public ChannelQOS(QosType value)
		{
			this.m_Type = value;
		}

		/// <summary>
		///   <para>UnderlyingModel.MemDoc.MemDocModel.</para>
		/// </summary>
		/// <param name="value">Requested type of quality of service (default Unreliable).</param>
		/// <param name="channel">Copy constructor.</param>
		// Token: 0x06001F0F RID: 7951 RVA: 0x0000C3DA File Offset: 0x0000A5DA
		public ChannelQOS()
		{
			this.m_Type = QosType.Unreliable;
		}

		/// <summary>
		///   <para>UnderlyingModel.MemDoc.MemDocModel.</para>
		/// </summary>
		/// <param name="value">Requested type of quality of service (default Unreliable).</param>
		/// <param name="channel">Copy constructor.</param>
		// Token: 0x06001F10 RID: 7952 RVA: 0x0000C3E9 File Offset: 0x0000A5E9
		public ChannelQOS(ChannelQOS channel)
		{
			if (channel == null)
			{
				throw new NullReferenceException("channel is not defined");
			}
			this.m_Type = channel.m_Type;
		}

		/// <summary>
		///   <para>Channel quality of service.</para>
		/// </summary>
		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x0000C40E File Offset: 0x0000A60E
		public QosType QOS
		{
			get
			{
				return this.m_Type;
			}
		}

		// Token: 0x04000878 RID: 2168
		[SerializeField]
		internal QosType m_Type;
	}
}
