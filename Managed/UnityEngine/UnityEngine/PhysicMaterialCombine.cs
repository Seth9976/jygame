using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes how physic materials of colliding objects are combined.</para>
	/// </summary>
	// Token: 0x020000FC RID: 252
	public enum PhysicMaterialCombine
	{
		/// <summary>
		///   <para>Averages the friction/bounce of the two colliding materials.</para>
		/// </summary>
		// Token: 0x040002ED RID: 749
		Average,
		/// <summary>
		///   <para>Uses the smaller friction/bounce of the two colliding materials.</para>
		/// </summary>
		// Token: 0x040002EE RID: 750
		Minimum = 2,
		/// <summary>
		///   <para>Multiplies the friction/bounce of the two colliding materials.</para>
		/// </summary>
		// Token: 0x040002EF RID: 751
		Multiply = 1,
		/// <summary>
		///   <para>Uses the larger friction/bounce of the two colliding materials.</para>
		/// </summary>
		// Token: 0x040002F0 RID: 752
		Maximum = 3
	}
}
