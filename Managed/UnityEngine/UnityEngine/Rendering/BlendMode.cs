using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Blend mode for controlling the blending.</para>
	/// </summary>
	// Token: 0x02000280 RID: 640
	public enum BlendMode
	{
		/// <summary>
		///   <para>Blend factor is  (0, 0, 0, 0).</para>
		/// </summary>
		// Token: 0x040009BA RID: 2490
		Zero,
		/// <summary>
		///   <para>Blend factor is (1, 1, 1, 1).</para>
		/// </summary>
		// Token: 0x040009BB RID: 2491
		One,
		/// <summary>
		///   <para>Blend factor is (Rd, Gd, Bd, Ad).</para>
		/// </summary>
		// Token: 0x040009BC RID: 2492
		DstColor,
		/// <summary>
		///   <para>Blend factor is (Rs, Gs, Bs, As).</para>
		/// </summary>
		// Token: 0x040009BD RID: 2493
		SrcColor,
		/// <summary>
		///   <para>Blend factor is (1 - Rd, 1 - Gd, 1 - Bd, 1 - Ad).</para>
		/// </summary>
		// Token: 0x040009BE RID: 2494
		OneMinusDstColor,
		/// <summary>
		///   <para>Blend factor is (As, As, As, As).</para>
		/// </summary>
		// Token: 0x040009BF RID: 2495
		SrcAlpha,
		/// <summary>
		///   <para>Blend factor is (1 - Rs, 1 - Gs, 1 - Bs, 1 - As).</para>
		/// </summary>
		// Token: 0x040009C0 RID: 2496
		OneMinusSrcColor,
		/// <summary>
		///   <para>Blend factor is (Ad, Ad, Ad, Ad).</para>
		/// </summary>
		// Token: 0x040009C1 RID: 2497
		DstAlpha,
		/// <summary>
		///   <para>Blend factor is (1 - Ad, 1 - Ad, 1 - Ad, 1 - Ad).</para>
		/// </summary>
		// Token: 0x040009C2 RID: 2498
		OneMinusDstAlpha,
		/// <summary>
		///   <para>Blend factor is (f, f, f, 1); where f = min(As, 1 - Ad).</para>
		/// </summary>
		// Token: 0x040009C3 RID: 2499
		SrcAlphaSaturate,
		/// <summary>
		///   <para>Blend factor is (1 - As, 1 - As, 1 - As, 1 - As).</para>
		/// </summary>
		// Token: 0x040009C4 RID: 2500
		OneMinusSrcAlpha
	}
}
