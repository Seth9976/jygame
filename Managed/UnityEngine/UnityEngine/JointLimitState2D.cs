using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Represents the state of a joint limit.</para>
	/// </summary>
	// Token: 0x0200012A RID: 298
	public enum JointLimitState2D
	{
		/// <summary>
		///   <para>Represents a state where the joint limit is inactive.</para>
		/// </summary>
		// Token: 0x0400035A RID: 858
		Inactive,
		/// <summary>
		///   <para>Represents a state where the joint limit is at the specified lower limit.</para>
		/// </summary>
		// Token: 0x0400035B RID: 859
		LowerLimit,
		/// <summary>
		///   <para>Represents a state where the joint limit is at the specified upper limit.</para>
		/// </summary>
		// Token: 0x0400035C RID: 860
		UpperLimit,
		/// <summary>
		///   <para>Represents a state where the joint limit is at the specified lower and upper limits (they are identical).</para>
		/// </summary>
		// Token: 0x0400035D RID: 861
		EqualLimits
	}
}
