using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 16-bit signed integer objects to and from other representations.</summary>
	// Token: 0x0200016C RID: 364
	public class Int16Converter : BaseNumberConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Int16Converter" /> class. </summary>
		// Token: 0x06000CD0 RID: 3280 RVA: 0x0000AC6C File Offset: 0x00008E6C
		public Int16Converter()
		{
			this.InnerType = typeof(short);
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x000025B7 File Offset: 0x000007B7
		internal override bool SupportHex
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000320F4 File Offset: 0x000302F4
		internal override string ConvertToString(object value, NumberFormatInfo format)
		{
			return ((short)value).ToString("G", format);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0000AC84 File Offset: 0x00008E84
		internal override object ConvertFromString(string value, NumberFormatInfo format)
		{
			return short.Parse(value, NumberStyles.Integer, format);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0000AC93 File Offset: 0x00008E93
		internal override object ConvertFromString(string value, int fromBase)
		{
			return Convert.ToInt16(value, fromBase);
		}
	}
}
