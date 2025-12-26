using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Attribute to make a string be edited with a height-flexible and scrollable text area.</para>
	/// </summary>
	// Token: 0x020002CA RID: 714
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class TextAreaAttribute : PropertyAttribute
	{
		/// <summary>
		///   <para>Attribute to make a string be edited with a height-flexible and scrollable text area.</para>
		/// </summary>
		/// <param name="minLines">The minimum amount of lines the text area will use.</param>
		/// <param name="maxLines">The maximum amount of lines the text area can show before it starts using a scrollbar.</param>
		// Token: 0x060021BB RID: 8635 RVA: 0x0000D885 File Offset: 0x0000BA85
		public TextAreaAttribute()
		{
			this.minLines = 3;
			this.maxLines = 3;
		}

		/// <summary>
		///   <para>Attribute to make a string be edited with a height-flexible and scrollable text area.</para>
		/// </summary>
		/// <param name="minLines">The minimum amount of lines the text area will use.</param>
		/// <param name="maxLines">The maximum amount of lines the text area can show before it starts using a scrollbar.</param>
		// Token: 0x060021BC RID: 8636 RVA: 0x0000D89B File Offset: 0x0000BA9B
		public TextAreaAttribute(int minLines, int maxLines)
		{
			this.minLines = minLines;
			this.maxLines = maxLines;
		}

		/// <summary>
		///   <para>The minimum amount of lines the text area will use.</para>
		/// </summary>
		// Token: 0x04000AE3 RID: 2787
		public readonly int minLines;

		/// <summary>
		///   <para>The maximum amount of lines the text area can show before it starts using a scrollbar.</para>
		/// </summary>
		// Token: 0x04000AE4 RID: 2788
		public readonly int maxLines;
	}
}
