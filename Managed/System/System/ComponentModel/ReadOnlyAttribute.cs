using System;

namespace System.ComponentModel
{
	/// <summary>Specifies whether the property this attribute is bound to is read-only or read/write. This class cannot be inherited</summary>
	// Token: 0x020001A0 RID: 416
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ReadOnlyAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ReadOnlyAttribute" /> class.</summary>
		/// <param name="isReadOnly">true to show that the property this attribute is bound to is read-only; false to show that the property is read/write. </param>
		// Token: 0x06000EA2 RID: 3746 RVA: 0x0000C1FB File Offset: 0x0000A3FB
		public ReadOnlyAttribute(bool read_only)
		{
			this.read_only = read_only;
		}

		/// <summary>Gets a value indicating whether the property this attribute is bound to is read-only.</summary>
		/// <returns>true if the property this attribute is bound to is read-only; false if the property is read/write.</returns>
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0000C22D File Offset: 0x0000A42D
		public bool IsReadOnly
		{
			get
			{
				return this.read_only;
			}
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.ReadOnlyAttribute" />.</returns>
		// Token: 0x06000EA5 RID: 3749 RVA: 0x0000C235 File Offset: 0x0000A435
		public override int GetHashCode()
		{
			return this.read_only.GetHashCode();
		}

		/// <summary>Indicates whether this instance and a specified object are equal.</summary>
		/// <returns>true if <paramref name="value" /> is equal to this instance; otherwise, false.</returns>
		/// <param name="value">Another object to compare to. </param>
		// Token: 0x06000EA6 RID: 3750 RVA: 0x000357B4 File Offset: 0x000339B4
		public override bool Equals(object o)
		{
			return o is ReadOnlyAttribute && ((ReadOnlyAttribute)o).IsReadOnly.Equals(this.read_only);
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>true if the attribute is the default value for this attribute class; otherwise, false.</returns>
		// Token: 0x06000EA7 RID: 3751 RVA: 0x0000C242 File Offset: 0x0000A442
		public override bool IsDefaultAttribute()
		{
			return this.Equals(ReadOnlyAttribute.Default);
		}

		// Token: 0x04000422 RID: 1058
		private bool read_only;

		/// <summary>Specifies that the property this attribute is bound to is read/write and can be modified. This static field is read-only.</summary>
		// Token: 0x04000423 RID: 1059
		public static readonly ReadOnlyAttribute No = new ReadOnlyAttribute(false);

		/// <summary>Specifies that the property this attribute is bound to is read-only and cannot be modified in the server explorer. This static field is read-only.</summary>
		// Token: 0x04000424 RID: 1060
		public static readonly ReadOnlyAttribute Yes = new ReadOnlyAttribute(true);

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.ReadOnlyAttribute" />, which is <see cref="F:System.ComponentModel.ReadOnlyAttribute.No" /> (that is, the property this attribute is bound to is read/write). This static field is read-only.</summary>
		// Token: 0x04000425 RID: 1061
		public static readonly ReadOnlyAttribute Default = new ReadOnlyAttribute(false);
	}
}
