using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the properties that support lookup-based binding. This class cannot be inherited.</summary>
	// Token: 0x02000188 RID: 392
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class LookupBindingPropertiesAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" /> class. </summary>
		/// <param name="dataSource">The name of the property to be used as the data source.</param>
		/// <param name="displayMember">The name of the property to be used for the display name.</param>
		/// <param name="valueMember">The name of the property to be used as the source for values.</param>
		/// <param name="lookupMember">The name of the property to be used for lookups.</param>
		// Token: 0x06000D58 RID: 3416 RVA: 0x0000B1BA File Offset: 0x000093BA
		public LookupBindingPropertiesAttribute(string dataSource, string displayMember, string valueMember, string lookupMember)
		{
			this.data_source = dataSource;
			this.display_member = displayMember;
			this.value_member = valueMember;
			this.lookup_member = lookupMember;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" /> class using no parameters. </summary>
		// Token: 0x06000D59 RID: 3417 RVA: 0x000021D7 File Offset: 0x000003D7
		public LookupBindingPropertiesAttribute()
		{
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" />.</returns>
		// Token: 0x06000D5B RID: 3419 RVA: 0x00032578 File Offset: 0x00030778
		public override int GetHashCode()
		{
			return ((this.data_source == null) ? 1 : this.data_source.GetHashCode()) << 24 + ((this.display_member == null) ? 1 : this.display_member.GetHashCode()) << 16 + ((this.lookup_member == null) ? 1 : this.lookup_member.GetHashCode()) << 8 + ((this.value_member == null) ? 1 : this.value_member.GetHashCode());
		}

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" /> instance. </summary>
		/// <returns>true if the object is equal to the current instance; otherwise, false, indicating they are not equal.</returns>
		/// <param name="obj">The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" /> instance </param>
		// Token: 0x06000D5C RID: 3420 RVA: 0x0003260C File Offset: 0x0003080C
		public override bool Equals(object obj)
		{
			LookupBindingPropertiesAttribute lookupBindingPropertiesAttribute = obj as LookupBindingPropertiesAttribute;
			return lookupBindingPropertiesAttribute != null && !(this.data_source != lookupBindingPropertiesAttribute.data_source) && !(this.display_member != lookupBindingPropertiesAttribute.display_member) && !(this.value_member != lookupBindingPropertiesAttribute.value_member) && !(this.lookup_member != lookupBindingPropertiesAttribute.lookup_member);
		}

		/// <summary>Gets the name of the data source property for the component to which the <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" /> is bound.</summary>
		/// <returns>The data source property for the component to which the <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" /> is bound.</returns>
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0000B1EB File Offset: 0x000093EB
		public string DataSource
		{
			get
			{
				return this.data_source;
			}
		}

		/// <summary>Gets the name of the display member property for the component to which the <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" /> is bound.</summary>
		/// <returns>The name of the display member property for the component to which the <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" /> is bound.</returns>
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x0000B1F3 File Offset: 0x000093F3
		public string DisplayMember
		{
			get
			{
				return this.display_member;
			}
		}

		/// <summary>Gets the name of the lookup member for the component to which this attribute is bound.</summary>
		/// <returns>The name of the lookup member for the component to which the <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" /> is bound.</returns>
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x0000B1FB File Offset: 0x000093FB
		public string LookupMember
		{
			get
			{
				return this.lookup_member;
			}
		}

		/// <summary>Gets the name of the value member property for the component to which the <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" /> is bound.</summary>
		/// <returns>The name of the value member property for the component to which the <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" /> is bound.</returns>
		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x0000B203 File Offset: 0x00009403
		public string ValueMember
		{
			get
			{
				return this.value_member;
			}
		}

		// Token: 0x040003B9 RID: 953
		private string data_source;

		// Token: 0x040003BA RID: 954
		private string display_member;

		// Token: 0x040003BB RID: 955
		private string value_member;

		// Token: 0x040003BC RID: 956
		private string lookup_member;

		/// <summary>Represents the default value for the <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" /> class.</summary>
		// Token: 0x040003BD RID: 957
		public static readonly LookupBindingPropertiesAttribute Default = new LookupBindingPropertiesAttribute();
	}
}
