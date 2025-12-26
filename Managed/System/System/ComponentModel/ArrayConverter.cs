using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert <see cref="T:System.Array" /> objects to and from various other representations.</summary>
	// Token: 0x020000C9 RID: 201
	public class ArrayConverter : CollectionConverter
	{
		/// <summary>Converts the given value object to the specified destination type.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">The culture into which <paramref name="value" /> will be converted.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the value to. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="destinationType" /> is null. </exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x060008A7 RID: 2215 RVA: 0x0002E7F8 File Offset: 0x0002C9F8
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(string) && value is Array)
			{
				return value.GetType().Name + " Array";
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Gets a collection of properties for the type of array specified by the value parameter.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties that are exposed for an array, or null if there are no properties.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="value">An <see cref="T:System.Object" /> that specifies the type of array to get the properties for. </param>
		/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> that will be used as a filter. </param>
		// Token: 0x060008A8 RID: 2216 RVA: 0x0002E854 File Offset: 0x0002CA54
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			if (value == null)
			{
				throw new NullReferenceException();
			}
			PropertyDescriptorCollection propertyDescriptorCollection = new PropertyDescriptorCollection(null);
			if (value is Array)
			{
				Array array = (Array)value;
				for (int i = 0; i < array.Length; i++)
				{
					propertyDescriptorCollection.Add(new ArrayConverter.ArrayPropertyDescriptor(i, array.GetType()));
				}
			}
			return propertyDescriptorCollection;
		}

		/// <summary>Gets a value indicating whether this object supports properties.</summary>
		/// <returns>true because <see cref="M:System.ComponentModel.ArrayConverter.GetProperties(System.ComponentModel.ITypeDescriptorContext,System.Object,System.Attribute[])" /> should be called to find the properties of this object. This method never returns false.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		// Token: 0x060008A9 RID: 2217 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x020000CA RID: 202
		internal class ArrayPropertyDescriptor : PropertyDescriptor
		{
			// Token: 0x060008AA RID: 2218 RVA: 0x00008363 File Offset: 0x00006563
			public ArrayPropertyDescriptor(int index, Type array_type)
				: base(string.Format("[{0}]", index), null)
			{
				this.index = index;
				this.array_type = array_type;
			}

			// Token: 0x170001E5 RID: 485
			// (get) Token: 0x060008AB RID: 2219 RVA: 0x0000838A File Offset: 0x0000658A
			public override Type ComponentType
			{
				get
				{
					return this.array_type;
				}
			}

			// Token: 0x170001E6 RID: 486
			// (get) Token: 0x060008AC RID: 2220 RVA: 0x00008392 File Offset: 0x00006592
			public override Type PropertyType
			{
				get
				{
					return this.array_type.GetElementType();
				}
			}

			// Token: 0x170001E7 RID: 487
			// (get) Token: 0x060008AD RID: 2221 RVA: 0x00002AA1 File Offset: 0x00000CA1
			public override bool IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x060008AE RID: 2222 RVA: 0x0000839F File Offset: 0x0000659F
			public override object GetValue(object component)
			{
				if (component == null)
				{
					return null;
				}
				return ((Array)component).GetValue(this.index);
			}

			// Token: 0x060008AF RID: 2223 RVA: 0x000083BA File Offset: 0x000065BA
			public override void SetValue(object component, object value)
			{
				if (component == null)
				{
					return;
				}
				((Array)component).SetValue(value, this.index);
			}

			// Token: 0x060008B0 RID: 2224 RVA: 0x000029F5 File Offset: 0x00000BF5
			public override void ResetValue(object component)
			{
			}

			// Token: 0x060008B1 RID: 2225 RVA: 0x00002AA1 File Offset: 0x00000CA1
			public override bool CanResetValue(object component)
			{
				return false;
			}

			// Token: 0x060008B2 RID: 2226 RVA: 0x00002AA1 File Offset: 0x00000CA1
			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}

			// Token: 0x0400024A RID: 586
			private int index;

			// Token: 0x0400024B RID: 587
			private Type array_type;
		}
	}
}
