using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes network reachability options.</para>
	/// </summary>
	// Token: 0x020000A7 RID: 167
	public enum NetworkReachability
	{
		/// <summary>
		///   <para>Network is not reachable.</para>
		/// </summary>
		// Token: 0x040001FD RID: 509
		NotReachable,
		/// <summary>
		///   <para>Network is reachable via carrier data network.</para>
		/// </summary>
		// Token: 0x040001FE RID: 510
		ReachableViaCarrierDataNetwork,
		/// <summary>
		///   <para>Network is reachable via WiFi or cable.</para>
		/// </summary>
		// Token: 0x040001FF RID: 511
		ReachableViaLocalAreaNetwork
	}
}
