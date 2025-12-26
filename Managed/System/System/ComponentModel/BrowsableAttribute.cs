using System;

namespace System.ComponentModel
{
	/// <summary>Specifies whether a property or event should be displayed in a Properties window.</summary>
	// Token: 0x020000D8 RID: 216
	[AttributeUsage(AttributeTargets.All)]
	public sealed class BrowsableAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.BrowsableAttribute" /> class.</summary>
		/// <param name="browsable">true if a property or event can be modified at design time; otherwise, false. The default is true. </param>
		// Token: 0x06000944 RID: 2372 RVA: 0x00008C14 File Offset: 0x00006E14
		public BrowsableAttribute(bool browsable)
		{
			this.browsable = browsable;
		}

		/// <summary>Gets a value indicating whether an object is browsable.</summary>
		/// <returns>true if the object is browsable; otherwise, false.</returns>
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00008C46 File Offset: 0x00006E46
		public bool Browsable
		{
			get
			{
				return this.browsable;
			}
		}

		/// <summary>Indicates whether this instance and a specified object are equal.</summary>
		/// <returns>true if <paramref name="obj" /> is equal to this instance; otherwise, false.</returns>
		/// <param name="obj">Another object to compare to. </param>
		// Token: 0x06000947 RID: 2375 RVA: 0x00008C4E File Offset: 0x00006E4E
		public override bool Equals(object obj)
		{
			return obj is BrowsableAttribute && (obj == this || ((BrowsableAttribute)obj).Browsable == this.browsable);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000948 RID: 2376 RVA: 0x00008C79 File Offset: 0x00006E79
		public override int GetHashCode()
		{
			return this.browsable.GetHashCode();
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>true if the attribute is the default value for this attribute class; otherwise, false.</returns>
		// Token: 0x06000949 RID: 2377 RVA: 0x00008C86 File Offset: 0x00006E86
		public override bool IsDefaultAttribute()
		{
			return this.browsable == BrowsableAttribute.Default.Browsable;
		}

		// Token: 0x04000275 RID: 629
		private bool browsable;

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.BrowsableAttribute" />, which is <see cref="F:System.ComponentModel.BrowsableAttribute.Yes" />. This static field is read-only.</summary>
		// Token: 0x04000276 RID: 630
		public static readonly BrowsableAttribute Default = new BrowsableAttribute(true);

		/// <summary>Specifies that a property or event cannot be modified at design time. This static field is read-only.</summary>
		// Token: 0x04000277 RID: 631
		public static readonly BrowsableAttribute No = new BrowsableAttribute(false);

		/// <summary>Specifies that a property or event can be modified at design time. This static field is read-only.</summary>
		// Token: 0x04000278 RID: 632
		public static readonly BrowsableAttribute Yes = new BrowsableAttribute(true);
	}
}
