using System;

namespace System.ComponentModel
{
	/// <summary>Specifies what type to use as a converter for the object this attribute is bound to. This class cannot be inherited.</summary>
	// Token: 0x020001B3 RID: 435
	[AttributeUsage(AttributeTargets.All)]
	public sealed class TypeConverterAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeConverterAttribute" /> class with the default type converter, which is an empty string ("").</summary>
		// Token: 0x06000F0E RID: 3854 RVA: 0x0000C7B5 File Offset: 0x0000A9B5
		public TypeConverterAttribute()
		{
			this.converter_type = string.Empty;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeConverterAttribute" /> class, using the specified type name as the data converter for the object this attribute is bound to.</summary>
		/// <param name="typeName">The fully qualified name of the class to use for data conversion for the object this attribute is bound to. </param>
		// Token: 0x06000F0F RID: 3855 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		public TypeConverterAttribute(string typeName)
		{
			this.converter_type = typeName;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeConverterAttribute" /> class, using the specified type as the data converter for the object this attribute is bound to.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of the converter class to use for data conversion for the object this attribute is bound to. </param>
		// Token: 0x06000F10 RID: 3856 RVA: 0x0000C7D7 File Offset: 0x0000A9D7
		public TypeConverterAttribute(Type type)
		{
			this.converter_type = type.AssemblyQualifiedName;
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.TypeConverterAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		// Token: 0x06000F12 RID: 3858 RVA: 0x0000C7F7 File Offset: 0x0000A9F7
		public override bool Equals(object obj)
		{
			return obj is TypeConverterAttribute && ((TypeConverterAttribute)obj).ConverterTypeName == this.converter_type;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.TypeConverterAttribute" />.</returns>
		// Token: 0x06000F13 RID: 3859 RVA: 0x0000C81C File Offset: 0x0000AA1C
		public override int GetHashCode()
		{
			return this.converter_type.GetHashCode();
		}

		/// <summary>Gets the fully qualified type name of the <see cref="T:System.Type" /> to use as a converter for the object this attribute is bound to.</summary>
		/// <returns>The fully qualified type name of the <see cref="T:System.Type" /> to use as a converter for the object this attribute is bound to, or an empty string ("") if none exists. The default value is an empty string ("").</returns>
		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x0000C829 File Offset: 0x0000AA29
		public string ConverterTypeName
		{
			get
			{
				return this.converter_type;
			}
		}

		/// <summary>Specifies the type to use as a converter for the object this attribute is bound to. This static field is read-only.</summary>
		// Token: 0x04000454 RID: 1108
		public static readonly TypeConverterAttribute Default = new TypeConverterAttribute();

		// Token: 0x04000455 RID: 1109
		private string converter_type;
	}
}
