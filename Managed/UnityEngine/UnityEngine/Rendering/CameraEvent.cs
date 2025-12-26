using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Defines a place in camera's rendering to attach Rendering.CommandBuffer objects to.</para>
	/// </summary>
	// Token: 0x02000289 RID: 649
	public enum CameraEvent
	{
		/// <summary>
		///   <para>Before camera's depth texture is generated.</para>
		/// </summary>
		// Token: 0x04000A14 RID: 2580
		BeforeDepthTexture,
		/// <summary>
		///   <para>After camera's depth texture is generated.</para>
		/// </summary>
		// Token: 0x04000A15 RID: 2581
		AfterDepthTexture,
		/// <summary>
		///   <para>Before camera's depth+normals texture is generated.</para>
		/// </summary>
		// Token: 0x04000A16 RID: 2582
		BeforeDepthNormalsTexture,
		/// <summary>
		///   <para>After camera's depth+normals texture is generated.</para>
		/// </summary>
		// Token: 0x04000A17 RID: 2583
		AfterDepthNormalsTexture,
		/// <summary>
		///   <para>Before deferred rendering G-buffer is rendered.</para>
		/// </summary>
		// Token: 0x04000A18 RID: 2584
		BeforeGBuffer,
		/// <summary>
		///   <para>After deferred rendering G-buffer is rendered.</para>
		/// </summary>
		// Token: 0x04000A19 RID: 2585
		AfterGBuffer,
		/// <summary>
		///   <para>Before lighting pass in deferred rendering.</para>
		/// </summary>
		// Token: 0x04000A1A RID: 2586
		BeforeLighting,
		/// <summary>
		///   <para>After lighting pass in deferred rendering.</para>
		/// </summary>
		// Token: 0x04000A1B RID: 2587
		AfterLighting,
		/// <summary>
		///   <para>Before final geometry pass in deferred lighting.</para>
		/// </summary>
		// Token: 0x04000A1C RID: 2588
		BeforeFinalPass,
		/// <summary>
		///   <para>After final geometry pass in deferred lighting.</para>
		/// </summary>
		// Token: 0x04000A1D RID: 2589
		AfterFinalPass,
		/// <summary>
		///   <para>Before opaque objects in forward rendering.</para>
		/// </summary>
		// Token: 0x04000A1E RID: 2590
		BeforeForwardOpaque,
		/// <summary>
		///   <para>After opaque objects in forward rendering.</para>
		/// </summary>
		// Token: 0x04000A1F RID: 2591
		AfterForwardOpaque,
		/// <summary>
		///   <para>Before image effects that happen between opaque &amp; transparent objects.</para>
		/// </summary>
		// Token: 0x04000A20 RID: 2592
		BeforeImageEffectsOpaque,
		/// <summary>
		///   <para>After image effects that happen between opaque &amp; transparent objects.</para>
		/// </summary>
		// Token: 0x04000A21 RID: 2593
		AfterImageEffectsOpaque,
		/// <summary>
		///   <para>Before skybox is drawn.</para>
		/// </summary>
		// Token: 0x04000A22 RID: 2594
		BeforeSkybox,
		/// <summary>
		///   <para>After skybox is drawn.</para>
		/// </summary>
		// Token: 0x04000A23 RID: 2595
		AfterSkybox,
		/// <summary>
		///   <para>Before transparent objects in forward rendering.</para>
		/// </summary>
		// Token: 0x04000A24 RID: 2596
		BeforeForwardAlpha,
		/// <summary>
		///   <para>After transparent objects in forward rendering.</para>
		/// </summary>
		// Token: 0x04000A25 RID: 2597
		AfterForwardAlpha,
		/// <summary>
		///   <para>Before image effects.</para>
		/// </summary>
		// Token: 0x04000A26 RID: 2598
		BeforeImageEffects,
		/// <summary>
		///   <para>After image effects.</para>
		/// </summary>
		// Token: 0x04000A27 RID: 2599
		AfterImageEffects,
		/// <summary>
		///   <para>After camera has done rendering everything.</para>
		/// </summary>
		// Token: 0x04000A28 RID: 2600
		AfterEverything,
		/// <summary>
		///   <para>Before reflections pass in deferred rendering.</para>
		/// </summary>
		// Token: 0x04000A29 RID: 2601
		BeforeReflections,
		/// <summary>
		///   <para>After reflections pass in deferred rendering.</para>
		/// </summary>
		// Token: 0x04000A2A RID: 2602
		AfterReflections
	}
}
