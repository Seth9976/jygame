using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The maximum number of bones affecting a single vertex.</para>
	/// </summary>
	// Token: 0x02000271 RID: 625
	public enum SkinQuality
	{
		/// <summary>
		///   <para>Chooses the number of bones from the number current QualitySettings. (Default)</para>
		/// </summary>
		// Token: 0x0400093A RID: 2362
		Auto,
		/// <summary>
		///   <para>Use only 1 bone to deform a single vertex. (The most important bone will be used).</para>
		/// </summary>
		// Token: 0x0400093B RID: 2363
		Bone1,
		/// <summary>
		///   <para>Use 2 bones to deform a single vertex. (The most important bones will be used).</para>
		/// </summary>
		// Token: 0x0400093C RID: 2364
		Bone2,
		/// <summary>
		///   <para>Use 4 bones to deform a single vertex.</para>
		/// </summary>
		// Token: 0x0400093D RID: 2365
		Bone4 = 4
	}
}
