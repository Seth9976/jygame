using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 8-bit unsigned integer objects to and from a string.</summary>
	// Token: 0x020001AA RID: 426
	public class SByteConverter : BaseNumberConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.SByteConverter" /> class. </summary>
		// Token: 0x06000EE3 RID: 3811 RVA: 0x0000C52D File Offset: 0x0000A72D
		public SByteConverter()
		{
			this.InnerType = typeof(sbyte);
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x000025B7 File Offset: 0x000007B7
		internal override bool SupportHex
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0003642C File Offset: 0x0003462C
		internal override string ConvertToString(object value, NumberFormatInfo format)
		{
			return ((sbyte)value).ToString("G", format);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0000C545 File Offset: 0x0000A745
		internal override object ConvertFromString(string value, NumberFormatInfo format)
		{
			return sbyte.Parse(value, NumberStyles.Integer, format);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0000C554 File Offset: 0x0000A754
		internal override object ConvertFromString(string value, int fromBase)
		{
			return Convert.ToSByte(value, fromBase);
		}
	}
}
