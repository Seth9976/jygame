using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Shader pass type for Unity's lighting pipeline.</para>
	/// </summary>
	// Token: 0x0200028C RID: 652
	public enum PassType
	{
		/// <summary>
		///   <para>Regular shader pass that does not interact with lighting.</para>
		/// </summary>
		// Token: 0x04000A3F RID: 2623
		Normal,
		/// <summary>
		///   <para>Legacy vertex-lit shader pass.</para>
		/// </summary>
		// Token: 0x04000A40 RID: 2624
		Vertex,
		/// <summary>
		///   <para>Legacy vertex-lit shader pass, with mobile lightmaps.</para>
		/// </summary>
		// Token: 0x04000A41 RID: 2625
		VertexLM,
		/// <summary>
		///   <para>Legacy vertex-lit shader pass, with desktop (RGBM) lightmaps.</para>
		/// </summary>
		// Token: 0x04000A42 RID: 2626
		VertexLMRGBM,
		/// <summary>
		///   <para>Forward rendering base pass.</para>
		/// </summary>
		// Token: 0x04000A43 RID: 2627
		ForwardBase,
		/// <summary>
		///   <para>Forward rendering additive pixel light pass.</para>
		/// </summary>
		// Token: 0x04000A44 RID: 2628
		ForwardAdd,
		/// <summary>
		///   <para>Legacy deferred lighting (light pre-pass) base pass.</para>
		/// </summary>
		// Token: 0x04000A45 RID: 2629
		LightPrePassBase,
		/// <summary>
		///   <para>Legacy deferred lighting (light pre-pass) final pass.</para>
		/// </summary>
		// Token: 0x04000A46 RID: 2630
		LightPrePassFinal,
		/// <summary>
		///   <para>Shadow caster &amp; depth texure shader pass.</para>
		/// </summary>
		// Token: 0x04000A47 RID: 2631
		ShadowCaster,
		/// <summary>
		///   <para>Deferred Shading shader pass.</para>
		/// </summary>
		// Token: 0x04000A48 RID: 2632
		Deferred = 10,
		/// <summary>
		///   <para>Shader pass used to generate the albedo and emissive values used as input to lightmapping.</para>
		/// </summary>
		// Token: 0x04000A49 RID: 2633
		Meta
	}
}
