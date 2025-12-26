using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Use these flags to constrain motion of the Rigidbody2D.</para>
	/// </summary>
	// Token: 0x02000121 RID: 289
	[Flags]
	public enum RigidbodyConstraints2D
	{
		/// <summary>
		///   <para>No constraints.</para>
		/// </summary>
		// Token: 0x0400034A RID: 842
		None = 0,
		/// <summary>
		///   <para>Freeze motion along the X-axis.</para>
		/// </summary>
		// Token: 0x0400034B RID: 843
		FreezePositionX = 1,
		/// <summary>
		///   <para>Freeze motion along the Y-axis.</para>
		/// </summary>
		// Token: 0x0400034C RID: 844
		FreezePositionY = 2,
		/// <summary>
		///   <para>Freeze rotation along the Z-axis.</para>
		/// </summary>
		// Token: 0x0400034D RID: 845
		FreezeRotation = 4,
		/// <summary>
		///   <para>Freeze motion along the X-axis and Y-axis.</para>
		/// </summary>
		// Token: 0x0400034E RID: 846
		FreezePosition = 3,
		/// <summary>
		///   <para>Freeze rotation and motion along all axes.</para>
		/// </summary>
		// Token: 0x0400034F RID: 847
		FreezeAll = 7
	}
}
