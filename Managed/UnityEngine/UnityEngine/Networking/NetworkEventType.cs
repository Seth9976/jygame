using System;

namespace UnityEngine.Networking
{
	/// <summary>
	///   <para>Type of events returned from Receive() function.</para>
	/// </summary>
	// Token: 0x0200021C RID: 540
	public enum NetworkEventType
	{
		/// <summary>
		///   <para>New data come in.</para>
		/// </summary>
		// Token: 0x04000859 RID: 2137
		DataEvent,
		/// <summary>
		///   <para>New connection has been connected.</para>
		/// </summary>
		// Token: 0x0400085A RID: 2138
		ConnectEvent,
		/// <summary>
		///   <para>Connection has been disconnected.</para>
		/// </summary>
		// Token: 0x0400085B RID: 2139
		DisconnectEvent,
		/// <summary>
		///   <para>Nothing happened.</para>
		/// </summary>
		// Token: 0x0400085C RID: 2140
		Nothing,
		/// <summary>
		///   <para>Broadcast discovery event received. To obtain sender connection info and possible complimentary message from him call GetBroadcastConnectionInfo() and GetBroadcastConnectionMessage() functions.</para>
		/// </summary>
		// Token: 0x0400085D RID: 2141
		BroadcastEvent
	}
}
