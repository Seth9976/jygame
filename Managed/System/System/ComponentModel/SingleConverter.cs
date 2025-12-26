using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert single-precision, floating point number objects to and from various other representations.</summary>
	// Token: 0x020001AC RID: 428
	public class SingleConverter : BaseNumberConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.SingleConverter" /> class. </summary>
		// Token: 0x06000EED RID: 3821 RVA: 0x0000C5A5 File Offset: 0x0000A7A5
		public SingleConverter()
		{
			this.InnerType = typeof(float);
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x00002AA1 File Offset: 0x00000CA1
		internal override bool SupportHex
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0003647C File Offset: 0x0003467C
		internal override string ConvertToString(object value, NumberFormatInfo format)
		{
			return ((float)value).ToString("R", format);
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0000C5BD File Offset: 0x0000A7BD
		internal override object ConvertFromString(string value, NumberFormatInfo format)
		{
			return float.Parse(value, NumberStyles.Float, format);
		}
	}
}
