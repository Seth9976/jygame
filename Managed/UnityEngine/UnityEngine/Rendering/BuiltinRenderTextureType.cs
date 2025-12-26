using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Built-in temporary render textures produced during camera's rendering.</para>
	/// </summary>
	// Token: 0x0200028B RID: 651
	public enum BuiltinRenderTextureType
	{
		// Token: 0x04000A31 RID: 2609
		None,
		/// <summary>
		///   <para>Currently active render target.</para>
		/// </summary>
		// Token: 0x04000A32 RID: 2610
		CurrentActive,
		/// <summary>
		///   <para>Target texture of currently rendering camera.</para>
		/// </summary>
		// Token: 0x04000A33 RID: 2611
		CameraTarget,
		/// <summary>
		///   <para>Camera's depth texture.</para>
		/// </summary>
		// Token: 0x04000A34 RID: 2612
		Depth,
		/// <summary>
		///   <para>Camera's depth+normals texture.</para>
		/// </summary>
		// Token: 0x04000A35 RID: 2613
		DepthNormals,
		/// <summary>
		///   <para>Deferred lighting (normals+specular) G-buffer.</para>
		/// </summary>
		// Token: 0x04000A36 RID: 2614
		PrepassNormalsSpec = 7,
		/// <summary>
		///   <para>Deferred lighting light buffer.</para>
		/// </summary>
		// Token: 0x04000A37 RID: 2615
		PrepassLight,
		/// <summary>
		///   <para>Deferred lighting HDR specular light buffer (Xbox 360 only).</para>
		/// </summary>
		// Token: 0x04000A38 RID: 2616
		PrepassLightSpec,
		/// <summary>
		///   <para>Deferred shading G-buffer #0 (typically diffuse color).</para>
		/// </summary>
		// Token: 0x04000A39 RID: 2617
		GBuffer0,
		/// <summary>
		///   <para>Deferred shading G-buffer #1 (typically specular + roughness).</para>
		/// </summary>
		// Token: 0x04000A3A RID: 2618
		GBuffer1,
		/// <summary>
		///   <para>Deferred shading G-buffer #2 (typically normals).</para>
		/// </summary>
		// Token: 0x04000A3B RID: 2619
		GBuffer2,
		/// <summary>
		///   <para>Deferred shading G-buffer #3 (typically emission/lighting).</para>
		/// </summary>
		// Token: 0x04000A3C RID: 2620
		GBuffer3,
		/// <summary>
		///   <para>Reflections gathered from default reflection and reflections probes.</para>
		/// </summary>
		// Token: 0x04000A3D RID: 2621
		Reflections
	}
}
