using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>ReflectionProbeBlendInfo contains information required for blending probes.</para>
	/// </summary>
	// Token: 0x02000294 RID: 660
	public struct ReflectionProbeBlendInfo
	{
		/// <summary>
		///   <para>Reflection Probe used in blending.</para>
		/// </summary>
		// Token: 0x04000A72 RID: 2674
		public ReflectionProbe probe;

		/// <summary>
		///   <para>Specifies the weight used in the interpolation between two probes, value varies from 0.0 to 1.0.</para>
		/// </summary>
		// Token: 0x04000A73 RID: 2675
		public float weight;
	}
}
