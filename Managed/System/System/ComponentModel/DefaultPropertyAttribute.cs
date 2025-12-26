using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the default property for a component.</summary>
	// Token: 0x020000F4 RID: 244
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultPropertyAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultPropertyAttribute" /> class.</summary>
		/// <param name="name">The name of the default property for the component this attribute is bound to. </param>
		// Token: 0x060009F5 RID: 2549 RVA: 0x000094C6 File Offset: 0x000076C6
		public DefaultPropertyAttribute(string name)
		{
			this.property_name = name;
		}

		/// <summary>Gets the name of the default property for the component this attribute is bound to.</summary>
		/// <returns>The name of the default property for the component this attribute is bound to. The default value is null.</returns>
		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x000094E2 File Offset: 0x000076E2
		public string Name
		{
			get
			{
				return this.property_name;
			}
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DefaultPropertyAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		// Token: 0x060009F8 RID: 2552 RVA: 0x000094EA File Offset: 0x000076EA
		public override bool Equals(object o)
		{
			return o is DefaultPropertyAttribute && ((DefaultPropertyAttribute)o).Name == this.property_name;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060009F9 RID: 2553 RVA: 0x0000946D File Offset: 0x0000766D
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x040002B1 RID: 689
		private string property_name;

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.DefaultPropertyAttribute" />, which is null. This static field is read-only.</summary>
		// Token: 0x040002B2 RID: 690
		public static readonly DefaultPropertyAttribute Default = new DefaultPropertyAttribute(null);
	}
}
