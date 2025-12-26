using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Status of path.</para>
	/// </summary>
	// Token: 0x02000147 RID: 327
	public enum NavMeshPathStatus
	{
		/// <summary>
		///   <para>The path terminates at the destination.</para>
		/// </summary>
		// Token: 0x04000381 RID: 897
		PathComplete,
		/// <summary>
		///   <para>The path cannot reach the destination.</para>
		/// </summary>
		// Token: 0x04000382 RID: 898
		PathPartial,
		/// <summary>
		///   <para>The path is invalid.</para>
		/// </summary>
		// Token: 0x04000383 RID: 899
		PathInvalid
	}
}
