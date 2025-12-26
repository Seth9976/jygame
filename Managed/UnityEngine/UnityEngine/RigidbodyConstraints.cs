using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Use these flags to constrain motion of Rigidbodies.</para>
	/// </summary>
	// Token: 0x020000EF RID: 239
	public enum RigidbodyConstraints
	{
		/// <summary>
		///   <para>No constraints.</para>
		/// </summary>
		// Token: 0x040002AE RID: 686
		None,
		/// <summary>
		///   <para>Freeze motion along the X-axis.</para>
		/// </summary>
		// Token: 0x040002AF RID: 687
		FreezePositionX = 2,
		/// <summary>
		///   <para>Freeze motion along the Y-axis.</para>
		/// </summary>
		// Token: 0x040002B0 RID: 688
		FreezePositionY = 4,
		/// <summary>
		///   <para>Freeze motion along the Z-axis.</para>
		/// </summary>
		// Token: 0x040002B1 RID: 689
		FreezePositionZ = 8,
		/// <summary>
		///   <para>Freeze rotation along the X-axis.</para>
		/// </summary>
		// Token: 0x040002B2 RID: 690
		FreezeRotationX = 16,
		/// <summary>
		///   <para>Freeze rotation along the Y-axis.</para>
		/// </summary>
		// Token: 0x040002B3 RID: 691
		FreezeRotationY = 32,
		/// <summary>
		///   <para>Freeze rotation along the Z-axis.</para>
		/// </summary>
		// Token: 0x040002B4 RID: 692
		FreezeRotationZ = 64,
		/// <summary>
		///   <para>Freeze motion along all axes.</para>
		/// </summary>
		// Token: 0x040002B5 RID: 693
		FreezePosition = 14,
		/// <summary>
		///   <para>Freeze rotation along all axes.</para>
		/// </summary>
		// Token: 0x040002B6 RID: 694
		FreezeRotation = 112,
		/// <summary>
		///   <para>Freeze rotation and motion along all axes.</para>
		/// </summary>
		// Token: 0x040002B7 RID: 695
		FreezeAll = 126
	}
}
