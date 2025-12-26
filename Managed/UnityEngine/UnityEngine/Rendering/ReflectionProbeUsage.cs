using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Reflection Probe usage.</para>
	/// </summary>
	// Token: 0x02000290 RID: 656
	public enum ReflectionProbeUsage
	{
		/// <summary>
		///   <para>Reflection probes are disabled, skybox will be used for reflection.</para>
		/// </summary>
		// Token: 0x04000A64 RID: 2660
		Off,
		/// <summary>
		///   <para>Reflection probes are enabled. Blending occurs only between probes, useful in indoor environments. The renderer will use default reflection if there are no reflection probes nearby, but no blending between default reflection and probe will occur.</para>
		/// </summary>
		// Token: 0x04000A65 RID: 2661
		BlendProbes,
		/// <summary>
		///   <para>Reflection probes are enabled. Blending occurs between probes or probes and default reflection, useful for outdoor environments.</para>
		/// </summary>
		// Token: 0x04000A66 RID: 2662
		BlendProbesAndSkybox,
		/// <summary>
		///   <para>Reflection probes are enabled, but no blending will occur between probes when there are two overlapping volumes.</para>
		/// </summary>
		// Token: 0x04000A67 RID: 2663
		Simple
	}
}
