using System;

namespace System.ComponentModel
{
	/// <summary>Specifies that the designer for a class belongs to a certain category.</summary>
	// Token: 0x0200010B RID: 267
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DesignerCategoryAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerCategoryAttribute" /> class with an empty string ("").</summary>
		// Token: 0x06000AA9 RID: 2729 RVA: 0x00009C9B File Offset: 0x00007E9B
		public DesignerCategoryAttribute()
		{
			this.category = string.Empty;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerCategoryAttribute" /> class with the given category name.</summary>
		/// <param name="category">The name of the category. </param>
		// Token: 0x06000AAA RID: 2730 RVA: 0x00009CAE File Offset: 0x00007EAE
		public DesignerCategoryAttribute(string category)
		{
			this.category = category;
		}

		/// <summary>Gets a unique identifier for this attribute.</summary>
		/// <returns>An <see cref="T:System.Object" /> that is a unique identifier for the attribute.</returns>
		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x00009CFB File Offset: 0x00007EFB
		public override object TypeId
		{
			get
			{
				return base.GetType();
			}
		}

		/// <summary>Gets the name of the category.</summary>
		/// <returns>The name of the category.</returns>
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x00009D03 File Offset: 0x00007F03
		public string Category
		{
			get
			{
				return this.category;
			}
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DesignOnlyAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		// Token: 0x06000AAE RID: 2734 RVA: 0x00009D0B File Offset: 0x00007F0B
		public override bool Equals(object obj)
		{
			return obj is DesignerCategoryAttribute && (obj == this || ((DesignerCategoryAttribute)obj).Category == this.category);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000AAF RID: 2735 RVA: 0x00009D39 File Offset: 0x00007F39
		public override int GetHashCode()
		{
			return this.category.GetHashCode();
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>true if the attribute is the default value for this attribute class; otherwise, false.</returns>
		// Token: 0x06000AB0 RID: 2736 RVA: 0x00009D46 File Offset: 0x00007F46
		public override bool IsDefaultAttribute()
		{
			return this.category == DesignerCategoryAttribute.Default.Category;
		}

		// Token: 0x040002DD RID: 733
		private string category;

		/// <summary>Specifies that a component marked with this category use a component designer. This field is read-only.</summary>
		// Token: 0x040002DE RID: 734
		public static readonly DesignerCategoryAttribute Component = new DesignerCategoryAttribute("Component");

		/// <summary>Specifies that a component marked with this category use a form designer. This static field is read-only.</summary>
		// Token: 0x040002DF RID: 735
		public static readonly DesignerCategoryAttribute Form = new DesignerCategoryAttribute("Form");

		/// <summary>Specifies that a component marked with this category use a generic designer. This static field is read-only.</summary>
		// Token: 0x040002E0 RID: 736
		public static readonly DesignerCategoryAttribute Generic = new DesignerCategoryAttribute("Designer");

		/// <summary>Specifies that a component marked with this category cannot use a visual designer. This static field is read-only.</summary>
		// Token: 0x040002E1 RID: 737
		public static readonly DesignerCategoryAttribute Default = new DesignerCategoryAttribute(string.Empty);
	}
}
