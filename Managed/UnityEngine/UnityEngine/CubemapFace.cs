using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Cubemap face.</para>
	/// </summary>
	// Token: 0x02000278 RID: 632
	public enum CubemapFace
	{
		/// <summary>
		///   <para>Cubemap face is unknown or unspecified.</para>
		/// </summary>
		// Token: 0x04000987 RID: 2439
		Unknown = -1,
		/// <summary>
		///   <para>Right facing side (+x).</para>
		/// </summary>
		// Token: 0x04000988 RID: 2440
		PositiveX,
		/// <summary>
		///   <para>Left facing side (-x).</para>
		/// </summary>
		// Token: 0x04000989 RID: 2441
		NegativeX,
		/// <summary>
		///   <para>Upwards facing side (+y).</para>
		/// </summary>
		// Token: 0x0400098A RID: 2442
		PositiveY,
		/// <summary>
		///   <para>Downward facing side (-y).</para>
		/// </summary>
		// Token: 0x0400098B RID: 2443
		NegativeY,
		/// <summary>
		///   <para>Forward facing side (+z).</para>
		/// </summary>
		// Token: 0x0400098C RID: 2444
		PositiveZ,
		/// <summary>
		///   <para>Backward facing side (-z).</para>
		/// </summary>
		// Token: 0x0400098D RID: 2445
		NegativeZ
	}
}
