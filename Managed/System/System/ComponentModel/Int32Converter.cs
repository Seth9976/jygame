using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 32-bit signed integer objects to and from other representations.</summary>
	// Token: 0x0200016D RID: 365
	public class Int32Converter : BaseNumberConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Int32Converter" /> class. </summary>
		// Token: 0x06000CD5 RID: 3285 RVA: 0x0000ACA1 File Offset: 0x00008EA1
		public Int32Converter()
		{
			this.InnerType = typeof(int);
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x000025B7 File Offset: 0x000007B7
		internal override bool SupportHex
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00032118 File Offset: 0x00030318
		internal override string ConvertToString(object value, NumberFormatInfo format)
		{
			return ((int)value).ToString("G", format);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0000ACB9 File Offset: 0x00008EB9
		internal override object ConvertFromString(string value, NumberFormatInfo format)
		{
			return int.Parse(value, NumberStyles.Integer, format);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		internal override object ConvertFromString(string value, int fromBase)
		{
			return Convert.ToInt32(value, fromBase);
		}
	}
}
