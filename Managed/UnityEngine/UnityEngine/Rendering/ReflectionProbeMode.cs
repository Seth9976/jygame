using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Reflection probe's update mode.</para>
	/// </summary>
	// Token: 0x02000293 RID: 659
	public enum ReflectionProbeMode
	{
		/// <summary>
		///   <para>Reflection probe is baked in the Editor.</para>
		/// </summary>
		// Token: 0x04000A6F RID: 2671
		Baked,
		/// <summary>
		///   <para>Reflection probe is updating in realtime.</para>
		/// </summary>
		// Token: 0x04000A70 RID: 2672
		Realtime,
		/// <summary>
		///   <para>Reflection probe uses a custom texture specified by the user.</para>
		/// </summary>
		// Token: 0x04000A71 RID: 2673
		Custom
	}
}
