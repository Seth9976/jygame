using System;

namespace System.ComponentModel
{
	/// <summary>Specifies whether a property can only be set at design time.</summary>
	// Token: 0x0200012A RID: 298
	[AttributeUsage(AttributeTargets.All)]
	public sealed class DesignOnlyAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignOnlyAttribute" /> class.</summary>
		/// <param name="isDesignOnly">true if a property can be set only at design time; false if the property can be set at design time and at run time. </param>
		// Token: 0x06000B5B RID: 2907 RVA: 0x00009F90 File Offset: 0x00008190
		public DesignOnlyAttribute(bool design_only)
		{
			this.design_only = design_only;
		}

		/// <summary>Gets a value indicating whether a property can be set only at design time.</summary>
		/// <returns>true if a property can be set only at design time; otherwise, false.</returns>
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00009FC2 File Offset: 0x000081C2
		public bool IsDesignOnly
		{
			get
			{
				return this.design_only;
			}
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DesignOnlyAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		// Token: 0x06000B5E RID: 2910 RVA: 0x00009FCA File Offset: 0x000081CA
		public override bool Equals(object obj)
		{
			return obj is DesignOnlyAttribute && (obj == this || ((DesignOnlyAttribute)obj).IsDesignOnly == this.design_only);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00009FF5 File Offset: 0x000081F5
		public override int GetHashCode()
		{
			return this.design_only.GetHashCode();
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>true if the attribute is the default value for this attribute class; otherwise, false.</returns>
		// Token: 0x06000B60 RID: 2912 RVA: 0x0000A002 File Offset: 0x00008202
		public override bool IsDefaultAttribute()
		{
			return this.design_only == DesignOnlyAttribute.Default.IsDesignOnly;
		}

		// Token: 0x040002FE RID: 766
		private bool design_only;

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.DesignOnlyAttribute" />, which is <see cref="F:System.ComponentModel.DesignOnlyAttribute.No" />. This static field is read-only.</summary>
		// Token: 0x040002FF RID: 767
		public static readonly DesignOnlyAttribute Default = new DesignOnlyAttribute(false);

		/// <summary>Specifies that a property can be set at design time or at run time. This static field is read-only.</summary>
		// Token: 0x04000300 RID: 768
		public static readonly DesignOnlyAttribute No = new DesignOnlyAttribute(false);

		/// <summary>Specifies that a property can be set only at design time. This static field is read-only.</summary>
		// Token: 0x04000301 RID: 769
		public static readonly DesignOnlyAttribute Yes = new DesignOnlyAttribute(true);
	}
}
