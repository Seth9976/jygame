using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 64-bit unsigned integer objects to and from other representations.</summary>
	// Token: 0x020001C6 RID: 454
	public class UInt64Converter : BaseNumberConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.UInt64Converter" /> class. </summary>
		// Token: 0x06000FE2 RID: 4066 RVA: 0x0000CF02 File Offset: 0x0000B102
		public UInt64Converter()
		{
			this.InnerType = typeof(ulong);
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x000025B7 File Offset: 0x000007B7
		internal override bool SupportHex
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00038944 File Offset: 0x00036B44
		internal override string ConvertToString(object value, NumberFormatInfo format)
		{
			return ((ulong)value).ToString("G", format);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x0000CF1A File Offset: 0x0000B11A
		internal override object ConvertFromString(string value, NumberFormatInfo format)
		{
			return ulong.Parse(value, NumberStyles.Integer, format);
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0000CF29 File Offset: 0x0000B129
		internal override object ConvertFromString(string value, int fromBase)
		{
			return Convert.ToUInt64(value, fromBase);
		}
	}
}
