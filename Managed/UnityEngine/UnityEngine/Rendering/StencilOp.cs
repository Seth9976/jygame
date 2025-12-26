using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Specifies the operation that's performed on the stencil buffer when rendering.</para>
	/// </summary>
	// Token: 0x02000285 RID: 645
	public enum StencilOp
	{
		/// <summary>
		///   <para>Keeps the current stencil value.</para>
		/// </summary>
		// Token: 0x040009FF RID: 2559
		Keep,
		/// <summary>
		///   <para>Sets the stencil buffer value to zero.</para>
		/// </summary>
		// Token: 0x04000A00 RID: 2560
		Zero,
		/// <summary>
		///   <para>Replace the stencil buffer value with reference value (specified in the shader).</para>
		/// </summary>
		// Token: 0x04000A01 RID: 2561
		Replace,
		/// <summary>
		///   <para>Increments the current stencil buffer value. Clamps to the maximum representable unsigned value.</para>
		/// </summary>
		// Token: 0x04000A02 RID: 2562
		IncrementSaturate,
		/// <summary>
		///   <para>Decrements the current stencil buffer value. Clamps to 0.</para>
		/// </summary>
		// Token: 0x04000A03 RID: 2563
		DecrementSaturate,
		/// <summary>
		///   <para>Bitwise inverts the current stencil buffer value.</para>
		/// </summary>
		// Token: 0x04000A04 RID: 2564
		Invert,
		/// <summary>
		///   <para>Increments the current stencil buffer value. Wraps stencil buffer value to zero when incrementing the maximum representable unsigned value.</para>
		/// </summary>
		// Token: 0x04000A05 RID: 2565
		IncrementWrap,
		/// <summary>
		///   <para>Decrements the current stencil buffer value. Wraps stencil buffer value to the maximum representable unsigned value when decrementing a stencil buffer value of zero.</para>
		/// </summary>
		// Token: 0x04000A06 RID: 2566
		DecrementWrap
	}
}
