using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Attribute to make a string be edited with a multi-line textfield.</para>
	/// </summary>
	// Token: 0x020002C9 RID: 713
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class MultilineAttribute : PropertyAttribute
	{
		/// <summary>
		///   <para>Attribute used to make a string value be shown in a multiline textarea.</para>
		/// </summary>
		/// <param name="lines">How many lines of text to make room for. Default is 3.</param>
		// Token: 0x060021B9 RID: 8633 RVA: 0x0000D867 File Offset: 0x0000BA67
		public MultilineAttribute()
		{
			this.lines = 3;
		}

		/// <summary>
		///   <para>Attribute used to make a string value be shown in a multiline textarea.</para>
		/// </summary>
		/// <param name="lines">How many lines of text to make room for. Default is 3.</param>
		// Token: 0x060021BA RID: 8634 RVA: 0x0000D876 File Offset: 0x0000BA76
		public MultilineAttribute(int lines)
		{
			this.lines = lines;
		}

		// Token: 0x04000AE2 RID: 2786
		public readonly int lines;
	}
}
