using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Selects the source and/or target to be used by an Effector2D.</para>
	/// </summary>
	// Token: 0x02000139 RID: 313
	public enum EffectorSelection2D
	{
		/// <summary>
		///   <para>The source/target is defined by the Rigidbody2D.</para>
		/// </summary>
		// Token: 0x04000368 RID: 872
		Rigidbody,
		/// <summary>
		///   <para>The source/target is defined by the Collider2D.</para>
		/// </summary>
		// Token: 0x04000369 RID: 873
		Collider
	}
}
