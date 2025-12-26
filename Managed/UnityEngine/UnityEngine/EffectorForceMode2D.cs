using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The mode used to apply Effector2D forces.</para>
	/// </summary>
	// Token: 0x0200013A RID: 314
	public enum EffectorForceMode2D
	{
		/// <summary>
		///   <para>The force is applied at a constant rate.</para>
		/// </summary>
		// Token: 0x0400036B RID: 875
		Constant,
		/// <summary>
		///   <para>The force is applied inverse-linear relative to a point.</para>
		/// </summary>
		// Token: 0x0400036C RID: 876
		InverseLinear,
		/// <summary>
		///   <para>The force is applied inverse-squared relative to a point.</para>
		/// </summary>
		// Token: 0x0400036D RID: 877
		InverseSquared
	}
}
