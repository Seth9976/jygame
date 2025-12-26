using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert double-precision, floating point number objects to and from various other representations.</summary>
	// Token: 0x02000145 RID: 325
	public class DoubleConverter : BaseNumberConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DoubleConverter" /> class. </summary>
		// Token: 0x06000BF2 RID: 3058 RVA: 0x0000A5BF File Offset: 0x000087BF
		public DoubleConverter()
		{
			this.InnerType = typeof(double);
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00002AA1 File Offset: 0x00000CA1
		internal override bool SupportHex
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0003158C File Offset: 0x0002F78C
		internal override string ConvertToString(object value, NumberFormatInfo format)
		{
			return ((double)value).ToString("R", format);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0000A5D7 File Offset: 0x000087D7
		internal override object ConvertFromString(string value, NumberFormatInfo format)
		{
			return double.Parse(value, NumberStyles.Float, format);
		}
	}
}
