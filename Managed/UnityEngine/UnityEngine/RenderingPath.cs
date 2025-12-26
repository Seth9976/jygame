using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Rendering path of a Camera.</para>
	/// </summary>
	// Token: 0x02000261 RID: 609
	public enum RenderingPath
	{
		/// <summary>
		///   <para>Use Player Settings.</para>
		/// </summary>
		// Token: 0x040008EC RID: 2284
		UsePlayerSettings = -1,
		/// <summary>
		///   <para>Vertex Lit.</para>
		/// </summary>
		// Token: 0x040008ED RID: 2285
		VertexLit,
		/// <summary>
		///   <para>Forward Rendering.</para>
		/// </summary>
		// Token: 0x040008EE RID: 2286
		Forward,
		/// <summary>
		///   <para>Deferred Lighting (Legacy).
		/// </para>
		/// </summary>
		// Token: 0x040008EF RID: 2287
		DeferredLighting,
		/// <summary>
		///   <para>Deferred Shading.
		/// </para>
		/// </summary>
		// Token: 0x040008F0 RID: 2288
		DeferredShading
	}
}
