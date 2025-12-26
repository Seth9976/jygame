using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 32-bit unsigned integer objects to and from various other representations.</summary>
	// Token: 0x020001C5 RID: 453
	public class UInt32Converter : BaseNumberConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.UInt32Converter" /> class. </summary>
		// Token: 0x06000FDD RID: 4061 RVA: 0x0000CECD File Offset: 0x0000B0CD
		public UInt32Converter()
		{
			this.InnerType = typeof(uint);
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x000025B7 File Offset: 0x000007B7
		internal override bool SupportHex
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00038920 File Offset: 0x00036B20
		internal override string ConvertToString(object value, NumberFormatInfo format)
		{
			return ((uint)value).ToString("G", format);
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0000CEE5 File Offset: 0x0000B0E5
		internal override object ConvertFromString(string value, NumberFormatInfo format)
		{
			return uint.Parse(value, NumberStyles.Integer, format);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0000CEF4 File Offset: 0x0000B0F4
		internal override object ConvertFromString(string value, int fromBase)
		{
			return Convert.ToUInt32(value, fromBase);
		}
	}
}
