using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 8-bit unsigned integer objects to and from various other representations.</summary>
	// Token: 0x020000D9 RID: 217
	public class ByteConverter : BaseNumberConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ByteConverter" /> class. </summary>
		// Token: 0x0600094A RID: 2378 RVA: 0x00008C9A File Offset: 0x00006E9A
		public ByteConverter()
		{
			this.InnerType = typeof(byte);
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x000025B7 File Offset: 0x000007B7
		internal override bool SupportHex
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0002EFC0 File Offset: 0x0002D1C0
		internal override string ConvertToString(object value, NumberFormatInfo format)
		{
			return ((byte)value).ToString("G", format);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00008CB2 File Offset: 0x00006EB2
		internal override object ConvertFromString(string value, NumberFormatInfo format)
		{
			return byte.Parse(value, NumberStyles.Integer, format);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00008CC1 File Offset: 0x00006EC1
		internal override object ConvertFromString(string value, int fromBase)
		{
			return Convert.ToByte(value, fromBase);
		}
	}
}
