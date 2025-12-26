using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The various test results the connection tester may return with.</para>
	/// </summary>
	// Token: 0x02000065 RID: 101
	public enum ConnectionTesterStatus
	{
		/// <summary>
		///   <para>Some unknown error occurred.</para>
		/// </summary>
		// Token: 0x04000111 RID: 273
		Error = -2,
		/// <summary>
		///   <para>Test result undetermined, still in progress.</para>
		/// </summary>
		// Token: 0x04000112 RID: 274
		Undetermined,
		// Token: 0x04000113 RID: 275
		[Obsolete("No longer returned, use newer connection tester enums instead.")]
		PrivateIPNoNATPunchthrough,
		// Token: 0x04000114 RID: 276
		[Obsolete("No longer returned, use newer connection tester enums instead.")]
		PrivateIPHasNATPunchThrough,
		/// <summary>
		///   <para>Public IP address detected and game listen port is accessible to the internet.</para>
		/// </summary>
		// Token: 0x04000115 RID: 277
		PublicIPIsConnectable,
		/// <summary>
		///   <para>Public IP address detected but the port is not connectable from the internet.</para>
		/// </summary>
		// Token: 0x04000116 RID: 278
		PublicIPPortBlocked,
		/// <summary>
		///   <para>Public IP address detected but server is not initialized and no port is listening.</para>
		/// </summary>
		// Token: 0x04000117 RID: 279
		PublicIPNoServerStarted,
		/// <summary>
		///   <para>Port-restricted NAT type, can do NAT punchthrough to everyone except symmetric.</para>
		/// </summary>
		// Token: 0x04000118 RID: 280
		LimitedNATPunchthroughPortRestricted,
		/// <summary>
		///   <para>Symmetric NAT type, cannot do NAT punchthrough to other symmetric types nor port restricted type.</para>
		/// </summary>
		// Token: 0x04000119 RID: 281
		LimitedNATPunchthroughSymmetric,
		/// <summary>
		///   <para>Full cone type, NAT punchthrough fully supported.</para>
		/// </summary>
		// Token: 0x0400011A RID: 282
		NATpunchthroughFullCone,
		/// <summary>
		///   <para>Address-restricted cone type, NAT punchthrough fully supported.</para>
		/// </summary>
		// Token: 0x0400011B RID: 283
		NATpunchthroughAddressRestrictedCone
	}
}
