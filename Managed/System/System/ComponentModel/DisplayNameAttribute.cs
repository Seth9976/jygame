using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the display name for a property, event, or public void method which takes no arguments. </summary>
	// Token: 0x02000144 RID: 324
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
	public class DisplayNameAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DisplayNameAttribute" /> class.</summary>
		// Token: 0x06000BE9 RID: 3049 RVA: 0x0000A556 File Offset: 0x00008756
		public DisplayNameAttribute()
		{
			this.attributeDisplayName = string.Empty;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DisplayNameAttribute" /> class using the display name.</summary>
		/// <param name="displayName">The display name.</param>
		// Token: 0x06000BEA RID: 3050 RVA: 0x0000A569 File Offset: 0x00008769
		public DisplayNameAttribute(string displayName)
		{
			this.attributeDisplayName = displayName;
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>true if the attribute is the default value for this attribute class; otherwise, false.</returns>
		// Token: 0x06000BEC RID: 3052 RVA: 0x0000A584 File Offset: 0x00008784
		public override bool IsDefaultAttribute()
		{
			return this.attributeDisplayName != null && this.attributeDisplayName.Length == 0;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.DisplayNameAttribute" />.</returns>
		// Token: 0x06000BED RID: 3053 RVA: 0x0000A5A1 File Offset: 0x000087A1
		public override int GetHashCode()
		{
			return this.attributeDisplayName.GetHashCode();
		}

		/// <summary>Determines whether two <see cref="T:System.ComponentModel.DisplayNameAttribute" /> instances are equal.</summary>
		/// <returns>true if the value of the given object is equal to that of the current object; otherwise, false.</returns>
		/// <param name="obj">The <see cref="T:System.ComponentModel.DisplayNameAttribute" /> to test the value equality of.</param>
		// Token: 0x06000BEE RID: 3054 RVA: 0x00031554 File Offset: 0x0002F754
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DisplayNameAttribute displayNameAttribute = obj as DisplayNameAttribute;
			return displayNameAttribute != null && displayNameAttribute.DisplayName == this.attributeDisplayName;
		}

		/// <summary>Gets the display name for a property, event, or public void method that takes no arguments stored in this attribute.</summary>
		/// <returns>The display name.</returns>
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x0000A5AE File Offset: 0x000087AE
		public virtual string DisplayName
		{
			get
			{
				return this.attributeDisplayName;
			}
		}

		/// <summary>Gets or sets the display name.</summary>
		/// <returns>The display name.</returns>
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0000A5AE File Offset: 0x000087AE
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x0000A5B6 File Offset: 0x000087B6
		protected string DisplayNameValue
		{
			get
			{
				return this.attributeDisplayName;
			}
			set
			{
				this.attributeDisplayName = value;
			}
		}

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.DisplayNameAttribute" />. This field is read-only.</summary>
		// Token: 0x0400036C RID: 876
		public static readonly DisplayNameAttribute Default = new DisplayNameAttribute();

		// Token: 0x0400036D RID: 877
		private string attributeDisplayName;
	}
}
