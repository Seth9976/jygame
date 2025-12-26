using System;

namespace System.Text.RegularExpressions
{
	/// <summary>Represents the results from a single subexpression capture. </summary>
	// Token: 0x0200048A RID: 1162
	[Serializable]
	public class Capture
	{
		// Token: 0x060028EC RID: 10476 RVA: 0x0001C7E3 File Offset: 0x0001A9E3
		internal Capture(string text)
			: this(text, 0, 0)
		{
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x0001C7EE File Offset: 0x0001A9EE
		internal Capture(string text, int index, int length)
		{
			this.text = text;
			this.index = index;
			this.length = length;
		}

		/// <summary>The position in the original string where the first character of the captured substring was found.</summary>
		/// <returns>The zero-based starting position in the original string where the captured substring was found.</returns>
		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x0001C80B File Offset: 0x0001AA0B
		public int Index
		{
			get
			{
				return this.index;
			}
		}

		/// <summary>The length of the captured substring.</summary>
		/// <returns>The length of the captured substring.</returns>
		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x0001C813 File Offset: 0x0001AA13
		public int Length
		{
			get
			{
				return this.length;
			}
		}

		/// <summary>Gets the captured substring from the input string.</summary>
		/// <returns>The actual substring that was captured by the match.</returns>
		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x0001C81B File Offset: 0x0001AA1B
		public string Value
		{
			get
			{
				return (this.text != null) ? this.text.Substring(this.index, this.length) : string.Empty;
			}
		}

		/// <summary>Gets the captured substring from the input string.</summary>
		/// <returns>The actual substring that was captured by the match.</returns>
		// Token: 0x060028F1 RID: 10481 RVA: 0x0001C849 File Offset: 0x0001AA49
		public override string ToString()
		{
			return this.Value;
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x0001C851 File Offset: 0x0001AA51
		internal string Text
		{
			get
			{
				return this.text;
			}
		}

		// Token: 0x0400192B RID: 6443
		internal int index;

		// Token: 0x0400192C RID: 6444
		internal int length;

		// Token: 0x0400192D RID: 6445
		internal string text;
	}
}
