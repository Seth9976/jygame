using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Option for who will receive an RPC, used by NetworkView.RPC.</para>
	/// </summary>
	// Token: 0x02000064 RID: 100
	public enum RPCMode
	{
		/// <summary>
		///   <para>Sends to the server only.</para>
		/// </summary>
		// Token: 0x0400010B RID: 267
		Server,
		/// <summary>
		///   <para>Sends to everyone except the sender.</para>
		/// </summary>
		// Token: 0x0400010C RID: 268
		Others,
		/// <summary>
		///   <para>Sends to everyone except the sender and adds to the buffer.</para>
		/// </summary>
		// Token: 0x0400010D RID: 269
		OthersBuffered = 5,
		/// <summary>
		///   <para>Sends to everyone.</para>
		/// </summary>
		// Token: 0x0400010E RID: 270
		All = 2,
		/// <summary>
		///   <para>Sends to everyone and adds to the buffer.</para>
		/// </summary>
		// Token: 0x0400010F RID: 271
		AllBuffered = 6
	}
}
