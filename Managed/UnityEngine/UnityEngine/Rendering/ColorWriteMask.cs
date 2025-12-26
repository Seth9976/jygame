using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Specifies which color components will get written into the target framebuffer.</para>
	/// </summary>
	// Token: 0x02000284 RID: 644
	[Flags]
	public enum ColorWriteMask
	{
		/// <summary>
		///   <para>Write alpha component.</para>
		/// </summary>
		// Token: 0x040009F9 RID: 2553
		Alpha = 1,
		/// <summary>
		///   <para>Write blue component.</para>
		/// </summary>
		// Token: 0x040009FA RID: 2554
		Blue = 2,
		/// <summary>
		///   <para>Write green component.</para>
		/// </summary>
		// Token: 0x040009FB RID: 2555
		Green = 4,
		/// <summary>
		///   <para>Write red component.</para>
		/// </summary>
		// Token: 0x040009FC RID: 2556
		Red = 8,
		/// <summary>
		///   <para>Write all components (R, G, B and Alpha).</para>
		/// </summary>
		// Token: 0x040009FD RID: 2557
		All = 15
	}
}
