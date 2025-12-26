using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 64-bit signed integer objects to and from various other representations.</summary>
	// Token: 0x0200016E RID: 366
	public class Int64Converter : BaseNumberConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Int64Converter" /> class. </summary>
		// Token: 0x06000CDA RID: 3290 RVA: 0x0000ACD6 File Offset: 0x00008ED6
		public Int64Converter()
		{
			this.InnerType = typeof(long);
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x000025B7 File Offset: 0x000007B7
		internal override bool SupportHex
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0003213C File Offset: 0x0003033C
		internal override string ConvertToString(object value, NumberFormatInfo format)
		{
			return ((long)value).ToString("G", format);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x0000ACEE File Offset: 0x00008EEE
		internal override object ConvertFromString(string value, NumberFormatInfo format)
		{
			return long.Parse(value, NumberStyles.Integer, format);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0000ACFD File Offset: 0x00008EFD
		internal override object ConvertFromString(string value, int fromBase)
		{
			return Convert.ToInt64(value, fromBase);
		}
	}
}
