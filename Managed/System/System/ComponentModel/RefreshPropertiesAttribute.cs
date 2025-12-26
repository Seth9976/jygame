using System;

namespace System.ComponentModel
{
	/// <summary>Indicates that the property grid should refresh when the associated property value changes. This class cannot be inherited.</summary>
	// Token: 0x020001A6 RID: 422
	[AttributeUsage(AttributeTargets.All)]
	public sealed class RefreshPropertiesAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.RefreshPropertiesAttribute" /> class.</summary>
		/// <param name="refresh">A <see cref="T:System.ComponentModel.RefreshProperties" /> value indicating the nature of the refresh.</param>
		// Token: 0x06000ED4 RID: 3796 RVA: 0x0000C438 File Offset: 0x0000A638
		public RefreshPropertiesAttribute(RefreshProperties refresh)
		{
			this.refresh = refresh;
		}

		/// <summary>Gets the refresh properties for the member.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.RefreshProperties" /> that indicates the current refresh properties for the member.</returns>
		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0000C46A File Offset: 0x0000A66A
		public RefreshProperties RefreshProperties
		{
			get
			{
				return this.refresh;
			}
		}

		/// <summary>Overrides the object's <see cref="Overload:System.Object.Equals" /> method.</summary>
		/// <returns>true if the specified object is the same; otherwise, false.</returns>
		/// <param name="value">The object to test for equality. </param>
		// Token: 0x06000ED7 RID: 3799 RVA: 0x0000C472 File Offset: 0x0000A672
		public override bool Equals(object obj)
		{
			return obj is RefreshPropertiesAttribute && (obj == this || ((RefreshPropertiesAttribute)obj).RefreshProperties == this.refresh);
		}

		/// <summary>Returns the hash code for this object.</summary>
		/// <returns>The hash code for the object that the attribute belongs to.</returns>
		// Token: 0x06000ED8 RID: 3800 RVA: 0x0000C49D File Offset: 0x0000A69D
		public override int GetHashCode()
		{
			return this.refresh.GetHashCode();
		}

		/// <summary>Gets a value indicating whether the current value of the attribute is the default value for the attribute.</summary>
		/// <returns>true if the current value of the attribute is the default; otherwise, false.</returns>
		// Token: 0x06000ED9 RID: 3801 RVA: 0x0000C4AF File Offset: 0x0000A6AF
		public override bool IsDefaultAttribute()
		{
			return this == RefreshPropertiesAttribute.Default;
		}

		// Token: 0x04000438 RID: 1080
		private RefreshProperties refresh;

		/// <summary>Indicates that all properties are queried again and refreshed if the property value is changed. This field is read-only.</summary>
		// Token: 0x04000439 RID: 1081
		public static readonly RefreshPropertiesAttribute All = new RefreshPropertiesAttribute(RefreshProperties.All);

		/// <summary>Indicates that no other properties are refreshed if the property value is changed. This field is read-only.</summary>
		// Token: 0x0400043A RID: 1082
		public static readonly RefreshPropertiesAttribute Default = new RefreshPropertiesAttribute(RefreshProperties.None);

		/// <summary>Indicates that all properties are repainted if the property value is changed. This field is read-only.</summary>
		// Token: 0x0400043B RID: 1083
		public static readonly RefreshPropertiesAttribute Repaint = new RefreshPropertiesAttribute(RefreshProperties.Repaint);
	}
}
