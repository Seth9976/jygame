using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Specifies the default value for a property.</summary>
	// Token: 0x020000F5 RID: 245
	[AttributeUsage(AttributeTargets.All)]
	public class DefaultValueAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a <see cref="T:System.Boolean" /> value.</summary>
		/// <param name="value">A <see cref="T:System.Boolean" /> that is the default value. </param>
		// Token: 0x060009FA RID: 2554 RVA: 0x0000950F File Offset: 0x0000770F
		public DefaultValueAttribute(bool value)
		{
			this.DefaultValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using an 8-bit unsigned integer.</summary>
		/// <param name="value">An 8-bit unsigned integer that is the default value. </param>
		// Token: 0x060009FB RID: 2555 RVA: 0x00009523 File Offset: 0x00007723
		public DefaultValueAttribute(byte value)
		{
			this.DefaultValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a Unicode character.</summary>
		/// <param name="value">A Unicode character that is the default value. </param>
		// Token: 0x060009FC RID: 2556 RVA: 0x00009537 File Offset: 0x00007737
		public DefaultValueAttribute(char value)
		{
			this.DefaultValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a double-precision floating point number.</summary>
		/// <param name="value">A double-precision floating point number that is the default value. </param>
		// Token: 0x060009FD RID: 2557 RVA: 0x0000954B File Offset: 0x0000774B
		public DefaultValueAttribute(double value)
		{
			this.DefaultValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a 16-bit signed integer.</summary>
		/// <param name="value">A 16-bit signed integer that is the default value. </param>
		// Token: 0x060009FE RID: 2558 RVA: 0x0000955F File Offset: 0x0000775F
		public DefaultValueAttribute(short value)
		{
			this.DefaultValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a 32-bit signed integer.</summary>
		/// <param name="value">A 32-bit signed integer that is the default value. </param>
		// Token: 0x060009FF RID: 2559 RVA: 0x00009573 File Offset: 0x00007773
		public DefaultValueAttribute(int value)
		{
			this.DefaultValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a 64-bit signed integer.</summary>
		/// <param name="value">A 64-bit signed integer that is the default value. </param>
		// Token: 0x06000A00 RID: 2560 RVA: 0x00009587 File Offset: 0x00007787
		public DefaultValueAttribute(long value)
		{
			this.DefaultValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class.</summary>
		/// <param name="value">An <see cref="T:System.Object" /> that represents the default value. </param>
		// Token: 0x06000A01 RID: 2561 RVA: 0x0000959B File Offset: 0x0000779B
		public DefaultValueAttribute(object value)
		{
			this.DefaultValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a single-precision floating point number.</summary>
		/// <param name="value">A single-precision floating point number that is the default value. </param>
		// Token: 0x06000A02 RID: 2562 RVA: 0x000095AA File Offset: 0x000077AA
		public DefaultValueAttribute(float value)
		{
			this.DefaultValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a <see cref="T:System.String" />.</summary>
		/// <param name="value">A <see cref="T:System.String" /> that is the default value. </param>
		// Token: 0x06000A03 RID: 2563 RVA: 0x0000959B File Offset: 0x0000779B
		public DefaultValueAttribute(string value)
		{
			this.DefaultValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class, converting the specified value to the specified type, and using an invariant culture as the translation context.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type to convert the value to. </param>
		/// <param name="value">A <see cref="T:System.String" /> that can be converted to the type using the <see cref="T:System.ComponentModel.TypeConverter" /> for the type and the U.S. English culture. </param>
		// Token: 0x06000A04 RID: 2564 RVA: 0x00030200 File Offset: 0x0002E400
		public DefaultValueAttribute(Type type, string value)
		{
			try
			{
				TypeConverter converter = TypeDescriptor.GetConverter(type);
				this.DefaultValue = converter.ConvertFromString(null, CultureInfo.InvariantCulture, value);
			}
			catch
			{
			}
		}

		/// <summary>Gets the default value of the property this attribute is bound to.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the default value of the property this attribute is bound to.</returns>
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x000095BE File Offset: 0x000077BE
		public virtual object Value
		{
			get
			{
				return this.DefaultValue;
			}
		}

		/// <summary>Sets the default value for the property to which this attribute is bound.</summary>
		/// <param name="value">The default value.</param>
		// Token: 0x06000A06 RID: 2566 RVA: 0x000095C6 File Offset: 0x000077C6
		protected void SetValue(object value)
		{
			this.DefaultValue = value;
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DefaultValueAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		// Token: 0x06000A07 RID: 2567 RVA: 0x00030248 File Offset: 0x0002E448
		public override bool Equals(object obj)
		{
			DefaultValueAttribute defaultValueAttribute = obj as DefaultValueAttribute;
			if (defaultValueAttribute == null)
			{
				return false;
			}
			if (this.DefaultValue == null)
			{
				return defaultValueAttribute.Value == null;
			}
			return this.DefaultValue.Equals(defaultValueAttribute.Value);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x000095CF File Offset: 0x000077CF
		public override int GetHashCode()
		{
			if (this.DefaultValue == null)
			{
				return base.GetHashCode();
			}
			return this.DefaultValue.GetHashCode();
		}

		// Token: 0x040002B3 RID: 691
		private object DefaultValue;
	}
}
