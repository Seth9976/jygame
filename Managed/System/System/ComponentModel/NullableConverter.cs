using System;
using System.Collections;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides automatic conversion between a nullable type and its underlying primitive type.</summary>
	// Token: 0x02000196 RID: 406
	public class NullableConverter : TypeConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.NullableConverter" /> class.</summary>
		/// <param name="type">The specified nullable type.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> is not a nullable type.</exception>
		// Token: 0x06000E19 RID: 3609 RVA: 0x0000BB61 File Offset: 0x00009D61
		public NullableConverter(Type nullableType)
		{
			if (nullableType == null)
			{
				throw new ArgumentNullException("nullableType");
			}
			this.nullableType = nullableType;
			this.underlyingType = Nullable.GetUnderlyingType(nullableType);
			this.underlyingTypeConverter = TypeDescriptor.GetConverter(this.underlyingType);
		}

		/// <summary>Returns whether this converter can convert an object of the given type to the type of this converter, using the specified context.</summary>
		/// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" />  that provides a format context.</param>
		/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type you want to convert from.</param>
		// Token: 0x06000E1A RID: 3610 RVA: 0x0000BB9E File Offset: 0x00009D9E
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (sourceType == this.underlyingType)
			{
				return true;
			}
			if (this.underlyingTypeConverter != null)
			{
				return this.underlyingTypeConverter.CanConvertFrom(context, sourceType);
			}
			return base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Returns whether this converter can convert the object to the specified type, using the specified context.</summary>
		/// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to.</param>
		// Token: 0x06000E1B RID: 3611 RVA: 0x0000BBCF File Offset: 0x00009DCF
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (destinationType == this.underlyingType)
			{
				return true;
			}
			if (this.underlyingTypeConverter != null)
			{
				return this.underlyingTypeConverter.CanConvertTo(context, destinationType);
			}
			return base.CanConvertFrom(context, destinationType);
		}

		/// <summary>Converts the given object to the type of this converter, using the specified context and culture information.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use as the current culture.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06000E1C RID: 3612 RVA: 0x00034BE8 File Offset: 0x00032DE8
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value == null || value.GetType() == this.underlyingType)
			{
				return value;
			}
			if (value is string && string.IsNullOrEmpty((string)value))
			{
				return null;
			}
			if (this.underlyingTypeConverter != null)
			{
				return this.underlyingTypeConverter.ConvertFrom(context, culture, value);
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Converts the given value object to the specified type, using the specified context and culture information.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use as the current culture.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the value parameter to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="destinationType" /> is null.</exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06000E1D RID: 3613 RVA: 0x00034C50 File Offset: 0x00032E50
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == this.underlyingType && value.GetType() == this.nullableType)
			{
				return value;
			}
			if (this.underlyingTypeConverter != null && value != null)
			{
				return this.underlyingTypeConverter.ConvertTo(context, culture, value, destinationType);
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <returns>An <see cref="T:System.Object" /> representing the given <see cref="T:System.Collections.IDictionary" />, or null if the object cannot be created. This method always returns null.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="propertyValues">An <see cref="T:System.Collections.IDictionary" /> of new property values. </param>
		// Token: 0x06000E1E RID: 3614 RVA: 0x0000BC00 File Offset: 0x00009E00
		public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			if (this.underlyingTypeConverter != null)
			{
				return this.underlyingTypeConverter.CreateInstance(context, propertyValues);
			}
			return base.CreateInstance(context, propertyValues);
		}

		/// <returns>true if changing a property on this object requires a call to <see cref="M:System.ComponentModel.TypeConverter.CreateInstance(System.Collections.IDictionary)" /> to create a new value; otherwise, false.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		// Token: 0x06000E1F RID: 3615 RVA: 0x0000BC23 File Offset: 0x00009E23
		public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			if (this.underlyingTypeConverter != null)
			{
				return this.underlyingTypeConverter.GetCreateInstanceSupported(context);
			}
			return base.GetCreateInstanceSupported(context);
		}

		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties that are exposed for this data type, or null if there are no properties.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="value">An <see cref="T:System.Object" /> that specifies the type of array for which to get properties. </param>
		/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> that is used as a filter. </param>
		// Token: 0x06000E20 RID: 3616 RVA: 0x0000BC44 File Offset: 0x00009E44
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			if (this.underlyingTypeConverter != null)
			{
				return this.underlyingTypeConverter.GetProperties(context, value, attributes);
			}
			return base.GetProperties(context, value, attributes);
		}

		/// <returns>true if <see cref="M:System.ComponentModel.TypeConverter.GetProperties(System.Object)" /> should be called to find the properties of this object; otherwise, false.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		// Token: 0x06000E21 RID: 3617 RVA: 0x0000BC23 File Offset: 0x00009E23
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			if (this.underlyingTypeConverter != null)
			{
				return this.underlyingTypeConverter.GetCreateInstanceSupported(context);
			}
			return base.GetCreateInstanceSupported(context);
		}

		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> that holds a standard set of valid values, or null if the data type does not support a standard set of values.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context that can be used to extract additional information about the environment from which this converter is invoked. This parameter or properties of this parameter can be null.</param>
		// Token: 0x06000E22 RID: 3618 RVA: 0x00034CBC File Offset: 0x00032EBC
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			if (this.underlyingTypeConverter != null && this.underlyingTypeConverter.GetStandardValuesSupported(context))
			{
				TypeConverter.StandardValuesCollection standardValues = this.underlyingTypeConverter.GetStandardValues(context);
				if (standardValues != null)
				{
					return new TypeConverter.StandardValuesCollection(new ArrayList(standardValues) { null });
				}
			}
			return base.GetStandardValues(context);
		}

		/// <returns>true if the <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> returned from <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> is an exhaustive list of possible values; false if other values are possible.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		// Token: 0x06000E23 RID: 3619 RVA: 0x0000BC69 File Offset: 0x00009E69
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			if (this.underlyingTypeConverter != null)
			{
				return this.underlyingTypeConverter.GetStandardValuesExclusive(context);
			}
			return base.GetStandardValuesExclusive(context);
		}

		/// <returns>true if <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> should be called to find a common set of values the object supports; otherwise, false.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		// Token: 0x06000E24 RID: 3620 RVA: 0x0000BC8A File Offset: 0x00009E8A
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			if (this.underlyingTypeConverter != null)
			{
				return this.underlyingTypeConverter.GetStandardValuesSupported(context);
			}
			return base.GetStandardValuesSupported(context);
		}

		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to test for validity. </param>
		// Token: 0x06000E25 RID: 3621 RVA: 0x0000BCAB File Offset: 0x00009EAB
		public override bool IsValid(ITypeDescriptorContext context, object value)
		{
			if (this.underlyingTypeConverter != null)
			{
				return this.underlyingTypeConverter.IsValid(context, value);
			}
			return base.IsValid(context, value);
		}

		/// <summary>Gets the nullable type.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the nullable type.</returns>
		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x0000BCCE File Offset: 0x00009ECE
		public Type NullableType
		{
			get
			{
				return this.nullableType;
			}
		}

		/// <summary>Gets the underlying type.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the underlying type.</returns>
		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x0000BCD6 File Offset: 0x00009ED6
		public Type UnderlyingType
		{
			get
			{
				return this.underlyingType;
			}
		}

		/// <summary>Gets the underlying type converter.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> that represents the underlying type converter.</returns>
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x0000BCDE File Offset: 0x00009EDE
		public TypeConverter UnderlyingTypeConverter
		{
			get
			{
				return this.underlyingTypeConverter;
			}
		}

		// Token: 0x04000409 RID: 1033
		private Type nullableType;

		// Token: 0x0400040A RID: 1034
		private Type underlyingType;

		// Token: 0x0400040B RID: 1035
		private TypeConverter underlyingTypeConverter;
	}
}
