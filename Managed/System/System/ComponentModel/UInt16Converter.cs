using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 16-bit unsigned integer objects to and from other representations.</summary>
	// Token: 0x020001C4 RID: 452
	public class UInt16Converter : BaseNumberConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.UInt16Converter" /> class. </summary>
		// Token: 0x06000FD8 RID: 4056 RVA: 0x0000CE98 File Offset: 0x0000B098
		public UInt16Converter()
		{
			this.InnerType = typeof(ushort);
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x000025B7 File Offset: 0x000007B7
		internal override bool SupportHex
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x000388FC File Offset: 0x00036AFC
		internal override string ConvertToString(object value, NumberFormatInfo format)
		{
			return ((ushort)value).ToString("G", format);
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0000CEB0 File Offset: 0x0000B0B0
		internal override object ConvertFromString(string value, NumberFormatInfo format)
		{
			return ushort.Parse(value, NumberStyles.Integer, format);
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0000CEBF File Offset: 0x0000B0BF
		internal override object ConvertFromString(string value, int fromBase)
		{
			return Convert.ToUInt16(value, fromBase);
		}
	}
}
