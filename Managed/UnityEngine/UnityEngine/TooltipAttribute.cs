using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Specify a tooltip for a field.</para>
	/// </summary>
	// Token: 0x020002C5 RID: 709
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public class TooltipAttribute : PropertyAttribute
	{
		/// <summary>
		///   <para>Specify a tooltip for a field.</para>
		/// </summary>
		/// <param name="tooltip">The tooltip text.</param>
		// Token: 0x060021B4 RID: 8628 RVA: 0x0000D811 File Offset: 0x0000BA11
		public TooltipAttribute(string tooltip)
		{
			this.tooltip = tooltip;
		}

		/// <summary>
		///   <para>The tooltip text.</para>
		/// </summary>
		// Token: 0x04000ADD RID: 2781
		public readonly string tooltip;
	}
}
