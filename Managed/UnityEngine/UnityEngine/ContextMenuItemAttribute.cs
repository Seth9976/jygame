using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Use this attribute to add a context menu to a field that calls a  named method.</para>
	/// </summary>
	// Token: 0x020002C4 RID: 708
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class ContextMenuItemAttribute : PropertyAttribute
	{
		/// <summary>
		///   <para>Use this attribute to add a context menu to a field that calls a  named method.</para>
		/// </summary>
		/// <param name="name">The name of the context menu item.</param>
		/// <param name="function">The name of the function that should be called.</param>
		// Token: 0x060021B3 RID: 8627 RVA: 0x0000D7FB File Offset: 0x0000B9FB
		public ContextMenuItemAttribute(string name, string function)
		{
			this.name = name;
			this.function = function;
		}

		/// <summary>
		///   <para>The name of the context menu item.</para>
		/// </summary>
		// Token: 0x04000ADB RID: 2779
		public readonly string name;

		/// <summary>
		///   <para>The name of the function that should be called.</para>
		/// </summary>
		// Token: 0x04000ADC RID: 2780
		public readonly string function;
	}
}
