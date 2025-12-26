using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Determines how to snap physics joints back to its constrained position when it drifts off too much.</para>
	/// </summary>
	// Token: 0x020000F2 RID: 242
	public enum JointProjectionMode
	{
		/// <summary>
		///   <para>Don't snap at all.</para>
		/// </summary>
		// Token: 0x040002C3 RID: 707
		None,
		/// <summary>
		///   <para>Snap both position and rotation.</para>
		/// </summary>
		// Token: 0x040002C4 RID: 708
		PositionAndRotation,
		/// <summary>
		///   <para>Snap Position only.</para>
		/// </summary>
		// Token: 0x040002C5 RID: 709
		[Obsolete("JointProjectionMode.PositionOnly is no longer supported", true)]
		PositionOnly
	}
}
