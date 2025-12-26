using System;

namespace System.ComponentModel
{
	/// <summary>Specifies that a list can be used as a data source. A visual designer should use this attribute to determine whether to display a particular list in a data-binding picker. This class cannot be inherited.</summary>
	// Token: 0x02000181 RID: 385
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class ListBindableAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ListBindableAttribute" /> class using a value to indicate whether the list is bindable.</summary>
		/// <param name="listBindable">true if the list is bindable; otherwise, false. </param>
		// Token: 0x06000D2A RID: 3370 RVA: 0x0000AF0B File Offset: 0x0000910B
		public ListBindableAttribute(bool listBindable)
		{
			this.bindable = listBindable;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ListBindableAttribute" /> class using <see cref="T:System.ComponentModel.BindableSupport" /> to indicate whether the list is bindable.</summary>
		/// <param name="flags">A <see cref="T:System.ComponentModel.BindableSupport" /> that indicates whether the list is bindable. </param>
		// Token: 0x06000D2B RID: 3371 RVA: 0x0000AF1A File Offset: 0x0000911A
		public ListBindableAttribute(BindableSupport flags)
		{
			if (flags == BindableSupport.No)
			{
				this.bindable = false;
			}
			else
			{
				this.bindable = true;
			}
		}

		/// <summary>Returns whether the object passed is equal to this <see cref="T:System.ComponentModel.ListBindableAttribute" />.</summary>
		/// <returns>true if the object passed is equal to this <see cref="T:System.ComponentModel.ListBindableAttribute" />; otherwise, false.</returns>
		/// <param name="obj">The object to test equality with. </param>
		// Token: 0x06000D2D RID: 3373 RVA: 0x000324FC File Offset: 0x000306FC
		public override bool Equals(object obj)
		{
			return obj is ListBindableAttribute && ((ListBindableAttribute)obj).ListBindable.Equals(this.bindable);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.ListBindableAttribute" />.</returns>
		// Token: 0x06000D2E RID: 3374 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override int GetHashCode()
		{
			return this.bindable.GetHashCode();
		}

		/// <summary>Returns whether <see cref="P:System.ComponentModel.ListBindableAttribute.ListBindable" /> is set to the default value.</summary>
		/// <returns>true if <see cref="P:System.ComponentModel.ListBindableAttribute.ListBindable" /> is set to the default value; otherwise, false.</returns>
		// Token: 0x06000D2F RID: 3375 RVA: 0x0000AF6B File Offset: 0x0000916B
		public override bool IsDefaultAttribute()
		{
			return this.Equals(ListBindableAttribute.Default);
		}

		/// <summary>Gets whether the list is bindable.</summary>
		/// <returns>true if the list is bindable; otherwise, false.</returns>
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0000AF78 File Offset: 0x00009178
		public bool ListBindable
		{
			get
			{
				return this.bindable;
			}
		}

		/// <summary>Represents the default value for <see cref="T:System.ComponentModel.ListBindableAttribute" />.</summary>
		// Token: 0x0400039E RID: 926
		public static readonly ListBindableAttribute Default = new ListBindableAttribute(true);

		/// <summary>Specifies that the list is not bindable. This static field is read-only.</summary>
		// Token: 0x0400039F RID: 927
		public static readonly ListBindableAttribute No = new ListBindableAttribute(false);

		/// <summary>Specifies that the list is bindable. This static field is read-only.</summary>
		// Token: 0x040003A0 RID: 928
		public static readonly ListBindableAttribute Yes = new ListBindableAttribute(true);

		// Token: 0x040003A1 RID: 929
		private bool bindable;
	}
}
