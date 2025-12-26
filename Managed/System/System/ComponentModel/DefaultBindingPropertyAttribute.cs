using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the default binding property for a component. This class cannot be inherited.</summary>
	// Token: 0x020000F2 RID: 242
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultBindingPropertyAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultBindingPropertyAttribute" /> class using no parameters. </summary>
		// Token: 0x060009EA RID: 2538 RVA: 0x000021D7 File Offset: 0x000003D7
		public DefaultBindingPropertyAttribute()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultBindingPropertyAttribute" /> class using the specified property name.</summary>
		/// <param name="name">The name of the default binding property.</param>
		// Token: 0x060009EB RID: 2539 RVA: 0x00009452 File Offset: 0x00007652
		public DefaultBindingPropertyAttribute(string name)
		{
			this.name = name;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.ComponentModel.DefaultBindingPropertyAttribute" /> instance. </summary>
		/// <returns>true if the object is equal to the current instance; otherwise, false, indicating they are not equal.</returns>
		/// <param name="obj">The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.ComponentModel.DefaultBindingPropertyAttribute" /> instance</param>
		// Token: 0x060009ED RID: 2541 RVA: 0x000301D0 File Offset: 0x0002E3D0
		public override bool Equals(object obj)
		{
			DefaultBindingPropertyAttribute defaultBindingPropertyAttribute = obj as DefaultBindingPropertyAttribute;
			return obj != null && this.name == defaultBindingPropertyAttribute.Name;
		}

		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060009EE RID: 2542 RVA: 0x0000946D File Offset: 0x0000766D
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Gets the name of the default binding property for the component to which the <see cref="T:System.ComponentModel.DefaultBindingPropertyAttribute" /> is bound.</summary>
		/// <returns>The name of the default binding property for the component to which the <see cref="T:System.ComponentModel.DefaultBindingPropertyAttribute" /> is bound.</returns>
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00009475 File Offset: 0x00007675
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Represents the default value for the <see cref="T:System.ComponentModel.DefaultBindingPropertyAttribute" /> class.</summary>
		// Token: 0x040002AD RID: 685
		public static readonly DefaultBindingPropertyAttribute Default = new DefaultBindingPropertyAttribute();

		// Token: 0x040002AE RID: 686
		private string name;
	}
}
