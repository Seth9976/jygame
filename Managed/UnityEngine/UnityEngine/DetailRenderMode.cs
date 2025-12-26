using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Render mode for detail prototypes.</para>
	/// </summary>
	// Token: 0x020001A3 RID: 419
	public enum DetailRenderMode
	{
		/// <summary>
		///   <para>The detail prototype will be rendered as billboards that are always facing the camera.</para>
		/// </summary>
		// Token: 0x04000508 RID: 1288
		GrassBillboard,
		/// <summary>
		///   <para>Will show the prototype using diffuse shading.</para>
		/// </summary>
		// Token: 0x04000509 RID: 1289
		VertexLit,
		/// <summary>
		///   <para>The detail prototype will use the grass shader.</para>
		/// </summary>
		// Token: 0x0400050A RID: 1290
		Grass
	}
}
