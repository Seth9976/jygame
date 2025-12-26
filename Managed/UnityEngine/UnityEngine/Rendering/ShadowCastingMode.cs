using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>How shadows are cast from this object.</para>
	/// </summary>
	// Token: 0x0200028D RID: 653
	public enum ShadowCastingMode
	{
		/// <summary>
		///   <para>No shadows are cast from this object.</para>
		/// </summary>
		// Token: 0x04000A4B RID: 2635
		Off,
		/// <summary>
		///   <para>Shadows are cast from this object.</para>
		/// </summary>
		// Token: 0x04000A4C RID: 2636
		On,
		/// <summary>
		///   <para>Shadows are cast from this object, treating it as two-sided.</para>
		/// </summary>
		// Token: 0x04000A4D RID: 2637
		TwoSided,
		/// <summary>
		///   <para>Object casts shadows, but is otherwise invisible in the scene.</para>
		/// </summary>
		// Token: 0x04000A4E RID: 2638
		ShadowsOnly
	}
}
