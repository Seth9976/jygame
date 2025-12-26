using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes the status of the network interface peer type as returned by Network.peerType.</para>
	/// </summary>
	// Token: 0x0200006A RID: 106
	public enum NetworkPeerType
	{
		/// <summary>
		///   <para>No client connection running. Server not initialized.</para>
		/// </summary>
		// Token: 0x0400013A RID: 314
		Disconnected,
		/// <summary>
		///   <para>Running as server.</para>
		/// </summary>
		// Token: 0x0400013B RID: 315
		Server,
		/// <summary>
		///   <para>Running as client.</para>
		/// </summary>
		// Token: 0x0400013C RID: 316
		Client,
		/// <summary>
		///   <para>Attempting to connect to a server.</para>
		/// </summary>
		// Token: 0x0400013D RID: 317
		Connecting
	}
}
