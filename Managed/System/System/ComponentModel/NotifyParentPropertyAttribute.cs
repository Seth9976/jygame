using System;

namespace System.ComponentModel
{
	/// <summary>Indicates that the parent property is notified when the value of the property that this attribute is applied to is modified. This class cannot be inherited.</summary>
	// Token: 0x02000195 RID: 405
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class NotifyParentPropertyAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.NotifyParentPropertyAttribute" /> class, using the specified value to determine whether the parent property is notified of changes to the value of the property.</summary>
		/// <param name="notifyParent">true if the parent should be notified of changes; otherwise, false. </param>
		// Token: 0x06000E13 RID: 3603 RVA: 0x0000BADB File Offset: 0x00009CDB
		public NotifyParentPropertyAttribute(bool notifyParent)
		{
			this.notifyParent = notifyParent;
		}

		/// <summary>Gets or sets a value indicating whether the parent property should be notified of changes to the value of the property.</summary>
		/// <returns>true if the parent property should be notified of changes; otherwise, false.</returns>
		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x0000BB0D File Offset: 0x00009D0D
		public bool NotifyParent
		{
			get
			{
				return this.notifyParent;
			}
		}

		/// <summary>Gets a value indicating whether the specified object is the same as the current object.</summary>
		/// <returns>true if the object is the same as this object; otherwise, false.</returns>
		/// <param name="obj">The object to test for equality. </param>
		// Token: 0x06000E16 RID: 3606 RVA: 0x0000BB15 File Offset: 0x00009D15
		public override bool Equals(object obj)
		{
			return obj is NotifyParentPropertyAttribute && (obj == this || ((NotifyParentPropertyAttribute)obj).NotifyParent == this.notifyParent);
		}

		/// <summary>Gets the hash code for this object.</summary>
		/// <returns>The hash code for the object the attribute belongs to.</returns>
		// Token: 0x06000E17 RID: 3607 RVA: 0x0000BB40 File Offset: 0x00009D40
		public override int GetHashCode()
		{
			return this.notifyParent.GetHashCode();
		}

		/// <summary>Gets a value indicating whether the current value of the attribute is the default value for the attribute.</summary>
		/// <returns>true if the current value of the attribute is the default value of the attribute; otherwise, false.</returns>
		// Token: 0x06000E18 RID: 3608 RVA: 0x0000BB4D File Offset: 0x00009D4D
		public override bool IsDefaultAttribute()
		{
			return this.notifyParent == NotifyParentPropertyAttribute.Default.NotifyParent;
		}

		// Token: 0x04000405 RID: 1029
		private bool notifyParent;

		/// <summary>Indicates the default attribute state, that the property should not notify the parent property of changes to its value. This field is read-only.</summary>
		// Token: 0x04000406 RID: 1030
		public static readonly NotifyParentPropertyAttribute Default = new NotifyParentPropertyAttribute(false);

		/// <summary>Indicates that the parent property is not be notified of changes to the value of the property. This field is read-only.</summary>
		// Token: 0x04000407 RID: 1031
		public static readonly NotifyParentPropertyAttribute No = new NotifyParentPropertyAttribute(false);

		/// <summary>Indicates that the parent property is notified of changes to the value of the property. This field is read-only.</summary>
		// Token: 0x04000408 RID: 1032
		public static readonly NotifyParentPropertyAttribute Yes = new NotifyParentPropertyAttribute(true);
	}
}
