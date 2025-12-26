using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Valid color spaces.</para>
	/// </summary>
	// Token: 0x02000272 RID: 626
	public enum ColorSpace
	{
		/// <summary>
		///   <para>Uninitialized colorspace.</para>
		/// </summary>
		// Token: 0x0400093F RID: 2367
		Uninitialized = -1,
		/// <summary>
		///   <para>Lightmap has been baked for gamma rendering.</para>
		/// </summary>
		// Token: 0x04000940 RID: 2368
		Gamma,
		/// <summary>
		///   <para>Lightmap has been baked for linear rendering.</para>
		/// </summary>
		// Token: 0x04000941 RID: 2369
		Linear
	}
}
