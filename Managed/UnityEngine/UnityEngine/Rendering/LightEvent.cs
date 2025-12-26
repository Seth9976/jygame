using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Defines a place in light's rendering to attach Rendering.CommandBuffer objects to.</para>
	/// </summary>
	// Token: 0x0200028A RID: 650
	public enum LightEvent
	{
		/// <summary>
		///   <para>Before shadowmap is rendered.</para>
		/// </summary>
		// Token: 0x04000A2C RID: 2604
		BeforeShadowMap,
		/// <summary>
		///   <para>After shadowmap is rendered.</para>
		/// </summary>
		// Token: 0x04000A2D RID: 2605
		AfterShadowMap,
		/// <summary>
		///   <para>Before directional light screenspace shadow mask is computed.</para>
		/// </summary>
		// Token: 0x04000A2E RID: 2606
		BeforeScreenspaceMask,
		/// <summary>
		///   <para>After directional light screenspace shadow mask is computed.</para>
		/// </summary>
		// Token: 0x04000A2F RID: 2607
		AfterScreenspaceMask
	}
}
