using System;

namespace System.ComponentModel
{
	/// <summary>Specifies that this property can be combined with properties belonging to other objects in a Properties window.</summary>
	// Token: 0x02000191 RID: 401
	[AttributeUsage(AttributeTargets.All)]
	public sealed class MergablePropertyAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.MergablePropertyAttribute" /> class.</summary>
		/// <param name="allowMerge">true if this property can be combined with properties belonging to other objects in a Properties window; otherwise, false. </param>
		// Token: 0x06000DFA RID: 3578 RVA: 0x0000B916 File Offset: 0x00009B16
		public MergablePropertyAttribute(bool allowMerge)
		{
			this.mergable = allowMerge;
		}

		/// <summary>Gets a value indicating whether this property can be combined with properties belonging to other objects in a Properties window.</summary>
		/// <returns>true if this property can be combined with properties belonging to other objects in a Properties window; otherwise, false.</returns>
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x0000B948 File Offset: 0x00009B48
		public bool AllowMerge
		{
			get
			{
				return this.mergable;
			}
		}

		/// <summary>Indicates whether this instance and a specified object are equal.</summary>
		/// <returns>true if <paramref name="obj" /> is equal to this instance; otherwise, false.</returns>
		/// <param name="obj">Another object to compare to. </param>
		// Token: 0x06000DFD RID: 3581 RVA: 0x0000B950 File Offset: 0x00009B50
		public override bool Equals(object obj)
		{
			return obj is MergablePropertyAttribute && (obj == this || ((MergablePropertyAttribute)obj).AllowMerge == this.mergable);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.MergablePropertyAttribute" />.</returns>
		// Token: 0x06000DFE RID: 3582 RVA: 0x0000B97B File Offset: 0x00009B7B
		public override int GetHashCode()
		{
			return this.mergable.GetHashCode();
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>true if the attribute is the default value for this attribute class; otherwise, false.</returns>
		// Token: 0x06000DFF RID: 3583 RVA: 0x0000B988 File Offset: 0x00009B88
		public override bool IsDefaultAttribute()
		{
			return this.mergable == MergablePropertyAttribute.Default.AllowMerge;
		}

		// Token: 0x040003FD RID: 1021
		private bool mergable;

		/// <summary>Specifies the default value, which is <see cref="F:System.ComponentModel.MergablePropertyAttribute.Yes" />, that is a property can be combined with properties belonging to other objects in a Properties window. This static field is read-only.</summary>
		// Token: 0x040003FE RID: 1022
		public static readonly MergablePropertyAttribute Default = new MergablePropertyAttribute(true);

		/// <summary>Specifies that a property cannot be combined with properties belonging to other objects in a Properties window. This static field is read-only.</summary>
		// Token: 0x040003FF RID: 1023
		public static readonly MergablePropertyAttribute No = new MergablePropertyAttribute(false);

		/// <summary>Specifies that a property can be combined with properties belonging to other objects in a Properties window. This static field is read-only.</summary>
		// Token: 0x04000400 RID: 1024
		public static readonly MergablePropertyAttribute Yes = new MergablePropertyAttribute(true);
	}
}
