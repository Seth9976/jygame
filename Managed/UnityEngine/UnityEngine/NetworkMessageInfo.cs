using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>This data structure contains information on a message just received from the network.</para>
	/// </summary>
	// Token: 0x02000075 RID: 117
	public struct NetworkMessageInfo
	{
		/// <summary>
		///   <para>The time stamp when the Message was sent in seconds.</para>
		/// </summary>
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00004DFC File Offset: 0x00002FFC
		public double timestamp
		{
			get
			{
				return this.m_TimeStamp;
			}
		}

		/// <summary>
		///   <para>The player who sent this network message (owner).</para>
		/// </summary>
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00004E04 File Offset: 0x00003004
		public NetworkPlayer sender
		{
			get
			{
				return this.m_Sender;
			}
		}

		/// <summary>
		///   <para>The NetworkView who sent this message.</para>
		/// </summary>
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00004E0C File Offset: 0x0000300C
		public NetworkView networkView
		{
			get
			{
				if (this.m_ViewID == NetworkViewID.unassigned)
				{
					Debug.LogError("No NetworkView is assigned to this NetworkMessageInfo object. Note that this is expected in OnNetworkInstantiate().");
					return this.NullNetworkView();
				}
				return NetworkView.Find(this.m_ViewID);
			}
		}

		// Token: 0x06000730 RID: 1840
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern NetworkView NullNetworkView();

		// Token: 0x04000152 RID: 338
		private double m_TimeStamp;

		// Token: 0x04000153 RID: 339
		private NetworkPlayer m_Sender;

		// Token: 0x04000154 RID: 340
		private NetworkViewID m_ViewID;
	}
}
