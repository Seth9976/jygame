using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Shadow casting options for a Light.</para>
	/// </summary>
	// Token: 0x02000267 RID: 615
	public enum LightShadows
	{
		/// <summary>
		///   <para>Do not cast shadows (default).</para>
		/// </summary>
		// Token: 0x04000909 RID: 2313
		None,
		/// <summary>
		///   <para>Cast "hard" shadows (with no shadow filtering).</para>
		/// </summary>
		// Token: 0x0400090A RID: 2314
		Hard,
		/// <summary>
		///   <para>Cast "soft" shadows (with 4x PCF filtering).</para>
		/// </summary>
		// Token: 0x0400090B RID: 2315
		Soft
	}
}
