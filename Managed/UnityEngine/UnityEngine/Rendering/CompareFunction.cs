using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Depth or stencil comparison function.</para>
	/// </summary>
	// Token: 0x02000282 RID: 642
	public enum CompareFunction
	{
		/// <summary>
		///   <para>Depth or stencil test is disabled.</para>
		/// </summary>
		// Token: 0x040009EB RID: 2539
		Disabled,
		/// <summary>
		///   <para>Never pass depth or stencil test.</para>
		/// </summary>
		// Token: 0x040009EC RID: 2540
		Never,
		/// <summary>
		///   <para>Pass depth or stencil test when new value is less than old one.</para>
		/// </summary>
		// Token: 0x040009ED RID: 2541
		Less,
		/// <summary>
		///   <para>Pass depth or stencil test when values are equal.</para>
		/// </summary>
		// Token: 0x040009EE RID: 2542
		Equal,
		/// <summary>
		///   <para>Pass depth or stencil test when new value is less or equal than old one.</para>
		/// </summary>
		// Token: 0x040009EF RID: 2543
		LessEqual,
		/// <summary>
		///   <para>Pass depth or stencil test when new value is greater than old one.</para>
		/// </summary>
		// Token: 0x040009F0 RID: 2544
		Greater,
		/// <summary>
		///   <para>Pass depth or stencil test when values are different.</para>
		/// </summary>
		// Token: 0x040009F1 RID: 2545
		NotEqual,
		/// <summary>
		///   <para>Pass depth or stencil test when new value is greater or equal than old one.</para>
		/// </summary>
		// Token: 0x040009F2 RID: 2546
		GreaterEqual,
		/// <summary>
		///   <para>Always pass depth or stencil test.</para>
		/// </summary>
		// Token: 0x040009F3 RID: 2547
		Always
	}
}
