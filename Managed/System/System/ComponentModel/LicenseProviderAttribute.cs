using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the <see cref="T:System.ComponentModel.LicenseProvider" /> to use with a class. This class cannot be inherited.</summary>
	// Token: 0x0200017C RID: 380
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class LicenseProviderAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.LicenseProviderAttribute" /> class without a license provider.</summary>
		// Token: 0x06000D19 RID: 3353 RVA: 0x0000AE18 File Offset: 0x00009018
		public LicenseProviderAttribute()
		{
			this.Provider = null;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.LicenseProviderAttribute" /> class with the specified type.</summary>
		/// <param name="typeName">The fully qualified name of the license provider class. </param>
		// Token: 0x06000D1A RID: 3354 RVA: 0x0000AE27 File Offset: 0x00009027
		public LicenseProviderAttribute(string typeName)
		{
			this.Provider = Type.GetType(typeName, false);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.LicenseProviderAttribute" /> class with the specified type of license provider.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of the license provider class. </param>
		// Token: 0x06000D1B RID: 3355 RVA: 0x0000AE3C File Offset: 0x0000903C
		public LicenseProviderAttribute(Type type)
		{
			this.Provider = type;
		}

		/// <summary>Gets the license provider that must be used with the associated class.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type of the license provider. The default value is null.</returns>
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x0000AE57 File Offset: 0x00009057
		public Type LicenseProvider
		{
			get
			{
				return this.Provider;
			}
		}

		/// <summary>Indicates a unique ID for this attribute type.</summary>
		/// <returns>A unique ID for this attribute type.</returns>
		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0000AE5F File Offset: 0x0000905F
		public override object TypeId
		{
			get
			{
				return base.ToString() + ((this.Provider == null) ? null : this.Provider.ToString());
			}
		}

		/// <summary>Indicates whether this instance and a specified object are equal.</summary>
		/// <returns>true if <paramref name="value" /> is equal to this instance; otherwise, false.</returns>
		/// <param name="value">Another object to compare to. </param>
		// Token: 0x06000D1F RID: 3359 RVA: 0x0000AE88 File Offset: 0x00009088
		public override bool Equals(object obj)
		{
			return obj is LicenseProviderAttribute && (obj == this || ((LicenseProviderAttribute)obj).LicenseProvider.Equals(this.Provider));
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.LicenseProviderAttribute" />.</returns>
		// Token: 0x06000D20 RID: 3360 RVA: 0x0000AEB6 File Offset: 0x000090B6
		public override int GetHashCode()
		{
			return this.Provider.GetHashCode();
		}

		// Token: 0x04000398 RID: 920
		private Type Provider;

		/// <summary>Specifies the default value, which is no provider. This static field is read-only.</summary>
		// Token: 0x04000399 RID: 921
		public static readonly LicenseProviderAttribute Default = new LicenseProviderAttribute();
	}
}
