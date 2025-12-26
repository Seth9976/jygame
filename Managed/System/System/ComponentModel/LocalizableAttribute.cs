using System;

namespace System.ComponentModel
{
	/// <summary>Specifies whether a property should be localized. This class cannot be inherited.</summary>
	// Token: 0x02000187 RID: 391
	[AttributeUsage(AttributeTargets.All)]
	public sealed class LocalizableAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.LocalizableAttribute" /> class.</summary>
		/// <param name="isLocalizable">true if a property should be localized; otherwise, false. </param>
		// Token: 0x06000D52 RID: 3410 RVA: 0x0000B134 File Offset: 0x00009334
		public LocalizableAttribute(bool localizable)
		{
			this.localizable = localizable;
		}

		/// <summary>Gets a value indicating whether a property should be localized.</summary>
		/// <returns>true if a property should be localized; otherwise, false.</returns>
		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x0000B166 File Offset: 0x00009366
		public bool IsLocalizable
		{
			get
			{
				return this.localizable;
			}
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.LocalizableAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		// Token: 0x06000D55 RID: 3413 RVA: 0x0000B16E File Offset: 0x0000936E
		public override bool Equals(object obj)
		{
			return obj is LocalizableAttribute && (obj == this || ((LocalizableAttribute)obj).IsLocalizable == this.localizable);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.LocalizableAttribute" />.</returns>
		// Token: 0x06000D56 RID: 3414 RVA: 0x0000B199 File Offset: 0x00009399
		public override int GetHashCode()
		{
			return this.localizable.GetHashCode();
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>true if the attribute is the default value for this attribute class; otherwise, false.</returns>
		// Token: 0x06000D57 RID: 3415 RVA: 0x0000B1A6 File Offset: 0x000093A6
		public override bool IsDefaultAttribute()
		{
			return this.localizable == LocalizableAttribute.Default.IsLocalizable;
		}

		// Token: 0x040003B5 RID: 949
		private bool localizable;

		/// <summary>Specifies the default value, which is <see cref="F:System.ComponentModel.LocalizableAttribute.No" />. This static field is read-only.</summary>
		// Token: 0x040003B6 RID: 950
		public static readonly LocalizableAttribute Default = new LocalizableAttribute(false);

		/// <summary>Specifies that a property should not be localized. This static field is read-only.</summary>
		// Token: 0x040003B7 RID: 951
		public static readonly LocalizableAttribute No = new LocalizableAttribute(false);

		/// <summary>Specifies that a property should be localized. This static field is read-only.</summary>
		// Token: 0x040003B8 RID: 952
		public static readonly LocalizableAttribute Yes = new LocalizableAttribute(true);
	}
}
