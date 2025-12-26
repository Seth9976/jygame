using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Base class to derive custom property attributes from. Use this to create custom attributes for script variables.</para>
	/// </summary>
	// Token: 0x020002C3 RID: 707
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public abstract class PropertyAttribute : Attribute
	{
		/// <summary>
		///   <para>Optional field to specify the order that multiple DecorationDrawers should be drawn in.</para>
		/// </summary>
		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x0000D7EA File Offset: 0x0000B9EA
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x0000D7F2 File Offset: 0x0000B9F2
		public int order { get; set; }
	}
}
