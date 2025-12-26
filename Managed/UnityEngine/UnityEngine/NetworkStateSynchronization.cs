using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Different types of synchronization for the NetworkView component.</para>
	/// </summary>
	// Token: 0x02000069 RID: 105
	public enum NetworkStateSynchronization
	{
		/// <summary>
		///   <para>No state data will be synchronized.</para>
		/// </summary>
		// Token: 0x04000136 RID: 310
		Off,
		/// <summary>
		///   <para>All packets are sent reliable and ordered.</para>
		/// </summary>
		// Token: 0x04000137 RID: 311
		ReliableDeltaCompressed,
		/// <summary>
		///   <para>Brute force unreliable state sending.</para>
		/// </summary>
		// Token: 0x04000138 RID: 312
		Unreliable
	}
}
