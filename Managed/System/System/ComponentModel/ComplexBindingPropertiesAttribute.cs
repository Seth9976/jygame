using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the data source and data member properties for a component that supports complex data binding. This class cannot be inherited.</summary>
	// Token: 0x020000E0 RID: 224
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class ComplexBindingPropertiesAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" /> class using the specified data source and data member. </summary>
		/// <param name="dataSource">The name of the property to be used as the data source.</param>
		/// <param name="dataMember">The name of the property to be used as the source for data.</param>
		// Token: 0x06000974 RID: 2420 RVA: 0x00008DE1 File Offset: 0x00006FE1
		public ComplexBindingPropertiesAttribute(string dataSource, string dataMember)
		{
			this.data_source = dataSource;
			this.data_member = dataMember;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" /> class using the specified data source. </summary>
		/// <param name="dataSource">The name of the property to be used as the data source.</param>
		// Token: 0x06000975 RID: 2421 RVA: 0x00008DF7 File Offset: 0x00006FF7
		public ComplexBindingPropertiesAttribute(string dataSource)
		{
			this.data_source = dataSource;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" /> class using no parameters. </summary>
		// Token: 0x06000976 RID: 2422 RVA: 0x000021D7 File Offset: 0x000003D7
		public ComplexBindingPropertiesAttribute()
		{
		}

		/// <summary>Gets the name of the data member property for the component to which the <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" /> is bound.</summary>
		/// <returns>The name of the data member property for the component to which <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" /> is bound</returns>
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x00008E12 File Offset: 0x00007012
		public string DataMember
		{
			get
			{
				return this.data_member;
			}
		}

		/// <summary>Gets the name of the data source property for the component to which the <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" /> is bound.</summary>
		/// <returns>The name of the data source property for the component to which <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" /> is bound.</returns>
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x00008E1A File Offset: 0x0000701A
		public string DataSource
		{
			get
			{
				return this.data_source;
			}
		}

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" /> instance. </summary>
		/// <returns>true if the object is equal to the current instance; otherwise, false, indicating they are not equal.</returns>
		/// <param name="obj">The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" /> instance </param>
		// Token: 0x0600097A RID: 2426 RVA: 0x0002F708 File Offset: 0x0002D908
		public override bool Equals(object obj)
		{
			ComplexBindingPropertiesAttribute complexBindingPropertiesAttribute = obj as ComplexBindingPropertiesAttribute;
			return complexBindingPropertiesAttribute != null && complexBindingPropertiesAttribute.DataMember == this.data_member && complexBindingPropertiesAttribute.DataSource == this.data_source;
		}

		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x0600097B RID: 2427 RVA: 0x0002F750 File Offset: 0x0002D950
		public override int GetHashCode()
		{
			int hashCode = (this.data_source + this.data_member).GetHashCode();
			if (hashCode == 0)
			{
				return base.GetHashCode();
			}
			return hashCode;
		}

		// Token: 0x04000291 RID: 657
		private string data_source;

		// Token: 0x04000292 RID: 658
		private string data_member;

		/// <summary>Represents the default value for the <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" /> class.</summary>
		// Token: 0x04000293 RID: 659
		public static readonly ComplexBindingPropertiesAttribute Default = new ComplexBindingPropertiesAttribute();
	}
}
