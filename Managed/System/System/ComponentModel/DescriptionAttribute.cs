using System;

namespace System.ComponentModel
{
	/// <summary>Specifies a description for a property or event.</summary>
	// Token: 0x020000F7 RID: 247
	[AttributeUsage(AttributeTargets.All)]
	public class DescriptionAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DescriptionAttribute" /> class with no parameters.</summary>
		// Token: 0x06000A16 RID: 2582 RVA: 0x00009666 File Offset: 0x00007866
		public DescriptionAttribute()
		{
			this.desc = string.Empty;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DescriptionAttribute" /> class with a description.</summary>
		/// <param name="description">The description text. </param>
		// Token: 0x06000A17 RID: 2583 RVA: 0x00009679 File Offset: 0x00007879
		public DescriptionAttribute(string name)
		{
			this.desc = name;
		}

		/// <summary>Gets the description stored in this attribute.</summary>
		/// <returns>The description stored in this attribute.</returns>
		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00009694 File Offset: 0x00007894
		public virtual string Description
		{
			get
			{
				return this.DescriptionValue;
			}
		}

		/// <summary>Gets or sets the string stored as the description.</summary>
		/// <returns>The string stored as the description. The default value is an empty string ("").</returns>
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0000969C File Offset: 0x0000789C
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x000096A4 File Offset: 0x000078A4
		protected string DescriptionValue
		{
			get
			{
				return this.desc;
			}
			set
			{
				this.desc = value;
			}
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DescriptionAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		// Token: 0x06000A1C RID: 2588 RVA: 0x000096AD File Offset: 0x000078AD
		public override bool Equals(object obj)
		{
			return obj is DescriptionAttribute && (obj == this || ((DescriptionAttribute)obj).Description == this.desc);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000096DB File Offset: 0x000078DB
		public override int GetHashCode()
		{
			return this.desc.GetHashCode();
		}

		/// <summary>Returns a value indicating whether this is the default <see cref="T:System.ComponentModel.DescriptionAttribute" /> instance.</summary>
		/// <returns>true, if this is the default <see cref="T:System.ComponentModel.DescriptionAttribute" /> instance; otherwise, false.</returns>
		// Token: 0x06000A1E RID: 2590 RVA: 0x000096E8 File Offset: 0x000078E8
		public override bool IsDefaultAttribute()
		{
			return this == DescriptionAttribute.Default;
		}

		// Token: 0x040002B8 RID: 696
		private string desc;

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.DescriptionAttribute" />, which is an empty string (""). This static field is read-only.</summary>
		// Token: 0x040002B9 RID: 697
		public static readonly DescriptionAttribute Default = new DescriptionAttribute();
	}
}
