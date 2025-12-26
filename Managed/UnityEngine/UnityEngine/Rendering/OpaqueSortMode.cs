using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Opaque object sorting mode of a Camera.</para>
	/// </summary>
	// Token: 0x0200027D RID: 637
	public enum OpaqueSortMode
	{
		/// <summary>
		///   <para>Default opaque sorting mode.</para>
		/// </summary>
		// Token: 0x040009B0 RID: 2480
		Default,
		/// <summary>
		///   <para>Do rough front-to-back sorting of opaque objects.</para>
		/// </summary>
		// Token: 0x040009B1 RID: 2481
		FrontToBack,
		/// <summary>
		///   <para>Do not sort opaque objects by distance.</para>
		/// </summary>
		// Token: 0x040009B2 RID: 2482
		NoDistanceSort
	}
}
