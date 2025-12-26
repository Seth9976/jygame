using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Blend operation.</para>
	/// </summary>
	// Token: 0x02000281 RID: 641
	public enum BlendOp
	{
		/// <summary>
		///   <para>Add (s + d).</para>
		/// </summary>
		// Token: 0x040009C6 RID: 2502
		Add,
		/// <summary>
		///   <para>Subtract.</para>
		/// </summary>
		// Token: 0x040009C7 RID: 2503
		Subtract,
		/// <summary>
		///   <para>Reverse subtract.</para>
		/// </summary>
		// Token: 0x040009C8 RID: 2504
		ReverseSubtract,
		/// <summary>
		///   <para>Min.</para>
		/// </summary>
		// Token: 0x040009C9 RID: 2505
		Min,
		/// <summary>
		///   <para>Max.</para>
		/// </summary>
		// Token: 0x040009CA RID: 2506
		Max,
		/// <summary>
		///   <para>Logical Clear (0).</para>
		/// </summary>
		// Token: 0x040009CB RID: 2507
		LogicalClear,
		/// <summary>
		///   <para>Logical SET (1) (D3D11.1 only).</para>
		/// </summary>
		// Token: 0x040009CC RID: 2508
		LogicalSet,
		/// <summary>
		///   <para>Logical Copy (s) (D3D11.1 only).</para>
		/// </summary>
		// Token: 0x040009CD RID: 2509
		LogicalCopy,
		/// <summary>
		///   <para>Logical inverted Copy (!s) (D3D11.1 only).</para>
		/// </summary>
		// Token: 0x040009CE RID: 2510
		LogicalCopyInverted,
		/// <summary>
		///   <para>Logical No-op (d) (D3D11.1 only).</para>
		/// </summary>
		// Token: 0x040009CF RID: 2511
		LogicalNoop,
		/// <summary>
		///   <para>Logical Inverse (!d) (D3D11.1 only).</para>
		/// </summary>
		// Token: 0x040009D0 RID: 2512
		LogicalInvert,
		/// <summary>
		///   <para>Logical AND (s &amp; d) (D3D11.1 only).</para>
		/// </summary>
		// Token: 0x040009D1 RID: 2513
		LogicalAnd,
		/// <summary>
		///   <para>Logical NAND !(s &amp; d). D3D11.1 only.</para>
		/// </summary>
		// Token: 0x040009D2 RID: 2514
		LogicalNand,
		/// <summary>
		///   <para>Logical OR (s | d) (D3D11.1 only).</para>
		/// </summary>
		// Token: 0x040009D3 RID: 2515
		LogicalOr,
		/// <summary>
		///   <para>Logical NOR !(s | d) (D3D11.1 only).</para>
		/// </summary>
		// Token: 0x040009D4 RID: 2516
		LogicalNor,
		/// <summary>
		///   <para>Logical XOR (s XOR d) (D3D11.1 only).</para>
		/// </summary>
		// Token: 0x040009D5 RID: 2517
		LogicalXor,
		/// <summary>
		///   <para>Logical Equivalence !(s XOR d) (D3D11.1 only).</para>
		/// </summary>
		// Token: 0x040009D6 RID: 2518
		LogicalEquivalence,
		/// <summary>
		///   <para>Logical reverse AND (s &amp; !d) (D3D11.1 only).</para>
		/// </summary>
		// Token: 0x040009D7 RID: 2519
		LogicalAndReverse,
		/// <summary>
		///   <para>Logical inverted AND (!s &amp; d) (D3D11.1 only).</para>
		/// </summary>
		// Token: 0x040009D8 RID: 2520
		LogicalAndInverted,
		/// <summary>
		///   <para>Logical reverse OR (s | !d) (D3D11.1 only).</para>
		/// </summary>
		// Token: 0x040009D9 RID: 2521
		LogicalOrReverse,
		/// <summary>
		///   <para>Logical inverted OR (!s | d) (D3D11.1 only).</para>
		/// </summary>
		// Token: 0x040009DA RID: 2522
		LogicalOrInverted,
		/// <summary>
		///   <para>Multiply (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009DB RID: 2523
		Multiply,
		/// <summary>
		///   <para>Screen (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009DC RID: 2524
		Screen,
		/// <summary>
		///   <para>Overlay (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009DD RID: 2525
		Overlay,
		/// <summary>
		///   <para>Darken (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009DE RID: 2526
		Darken,
		/// <summary>
		///   <para>Lighten (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009DF RID: 2527
		Lighten,
		/// <summary>
		///   <para>Color dodge (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009E0 RID: 2528
		ColorDodge,
		/// <summary>
		///   <para>Color burn (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009E1 RID: 2529
		ColorBurn,
		/// <summary>
		///   <para>Hard light (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009E2 RID: 2530
		HardLight,
		/// <summary>
		///   <para>Soft light (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009E3 RID: 2531
		SoftLight,
		/// <summary>
		///   <para>Difference (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009E4 RID: 2532
		Difference,
		/// <summary>
		///   <para>Exclusion (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009E5 RID: 2533
		Exclusion,
		/// <summary>
		///   <para>HSL Hue (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009E6 RID: 2534
		HSLHue,
		/// <summary>
		///   <para>HSL saturation (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009E7 RID: 2535
		HSLSaturation,
		/// <summary>
		///   <para>HSL color (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009E8 RID: 2536
		HSLColor,
		/// <summary>
		///   <para>HSL luminosity (Advanced OpenGL blending).</para>
		/// </summary>
		// Token: 0x040009E9 RID: 2537
		HSLLuminosity
	}
}
