using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System
{
	/// <summary>Converts a <see cref="T:System.String" /> type to a <see cref="T:System.Uri" /> type, and vice versa.</summary>
	// Token: 0x020004D9 RID: 1241
	public class UriTypeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06002C27 RID: 11303 RVA: 0x0001E8C1 File Offset: 0x0001CAC1
		private bool CanConvert(Type type)
		{
			return type == typeof(string) || type == typeof(global::System.Uri) || type == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor);
		}

		/// <summary>Returns whether this converter can convert an object of the given type to the type of this converter.</summary>
		/// <returns>true if <paramref name="sourceType" /> is a <see cref="T:System.String" /> type or a <see cref="T:System.Uri" /> type can be assigned from <paramref name="sourceType" />; otherwise, false.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" />  that provides a format context.</param>
		/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type that you want to convert from.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="sourceType" /> parameter is null.</exception>
		// Token: 0x06002C28 RID: 11304 RVA: 0x0001E8F4 File Offset: 0x0001CAF4
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, Type sourceType)
		{
			if (sourceType == null)
			{
				throw new ArgumentNullException("sourceType");
			}
			return this.CanConvert(sourceType);
		}

		/// <summary>Returns whether this converter can convert the object to the specified type, using the specified context.</summary>
		/// <returns>true if <paramref name="destinationType" /> is of type <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" />, <see cref="T:System.String" />, or <see cref="T:System.Uri" />; otherwise, false.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" />  that provides a format context.</param>
		/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type that you want to convert to.</param>
		// Token: 0x06002C29 RID: 11305 RVA: 0x0001E90E File Offset: 0x0001CB0E
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType != null && this.CanConvert(destinationType);
		}

		/// <summary>Converts the given object to the type of this converter, using the specified context and culture information.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" />  that provides a format context.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use as the current culture.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
		// Token: 0x06002C2A RID: 11306 RVA: 0x00090394 File Offset: 0x0008E594
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!this.CanConvertFrom(context, value.GetType()))
			{
				throw new NotSupportedException(global::Locale.GetText("Cannot convert from value."));
			}
			if (value is global::System.Uri)
			{
				return value;
			}
			string text = value as string;
			if (text != null)
			{
				return new global::System.Uri(text, global::System.UriKind.RelativeOrAbsolute);
			}
			global::System.ComponentModel.Design.Serialization.InstanceDescriptor instanceDescriptor = value as global::System.ComponentModel.Design.Serialization.InstanceDescriptor;
			if (instanceDescriptor != null)
			{
				return instanceDescriptor.Invoke();
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Converts a given value object to the specified type, using the specified context and culture information.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" />  that provides a format context.</param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If null is passed, the current culture is assumed.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="destinationType" /> parameter is null.</exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
		// Token: 0x06002C2B RID: 11307 RVA: 0x00090414 File Offset: 0x0008E614
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!this.CanConvertTo(context, destinationType))
			{
				throw new NotSupportedException(global::Locale.GetText("Cannot convert to destination type."));
			}
			global::System.Uri uri = value as global::System.Uri;
			if (uri != null)
			{
				if (destinationType == typeof(string))
				{
					return uri.ToString();
				}
				if (destinationType == typeof(global::System.Uri))
				{
					return uri;
				}
				if (destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor))
				{
					ConstructorInfo constructor = typeof(global::System.Uri).GetConstructor(new Type[]
					{
						typeof(string),
						typeof(global::System.UriKind)
					});
					return new global::System.ComponentModel.Design.Serialization.InstanceDescriptor(constructor, new object[]
					{
						uri.ToString(),
						(!uri.IsAbsoluteUri) ? global::System.UriKind.Relative : global::System.UriKind.Absolute
					});
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Returns whether the given value object is a <see cref="T:System.Uri" /> or a <see cref="T:System.Uri" /> can be created from it.</summary>
		/// <returns>true if <paramref name="value" /> is a <see cref="T:System.Uri" /> or a <see cref="T:System.String" /> from which a <see cref="T:System.Uri" /> can be created; otherwise, false.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" />  that provides a format context.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to test for validity.</param>
		// Token: 0x06002C2C RID: 11308 RVA: 0x0001E91F File Offset: 0x0001CB1F
		public override bool IsValid(global::System.ComponentModel.ITypeDescriptorContext context, object value)
		{
			return value != null && (value is string || value is global::System.Uri);
		}
	}
}
