using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>ComputeBuffer type.</para>
	/// </summary>
	// Token: 0x02000264 RID: 612
	[Flags]
	public enum ComputeBufferType
	{
		/// <summary>
		///   <para>Default ComputeBuffer type.</para>
		/// </summary>
		// Token: 0x040008FA RID: 2298
		Default = 0,
		/// <summary>
		///   <para>Raw ComputeBuffer type.</para>
		/// </summary>
		// Token: 0x040008FB RID: 2299
		Raw = 1,
		/// <summary>
		///   <para>Append-consume ComputeBuffer type.</para>
		/// </summary>
		// Token: 0x040008FC RID: 2300
		Append = 2,
		/// <summary>
		///   <para>ComputeBuffer with a counter.</para>
		/// </summary>
		// Token: 0x040008FD RID: 2301
		Counter = 4,
		/// <summary>
		///   <para>ComputeBuffer used for Graphics.DrawProceduralIndirect.</para>
		/// </summary>
		// Token: 0x040008FE RID: 2302
		DrawIndirect = 256
	}
}
