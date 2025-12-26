using System;

namespace System.ComponentModel
{
	/// <summary>Specifies that an object has no subproperties capable of being edited. This class cannot be inherited.</summary>
	// Token: 0x02000161 RID: 353
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ImmutableObjectAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ImmutableObjectAttribute" /> class.</summary>
		/// <param name="immutable">true if the object is immutable; otherwise, false. </param>
		// Token: 0x06000CAE RID: 3246 RVA: 0x0000AA7E File Offset: 0x00008C7E
		public ImmutableObjectAttribute(bool immutable)
		{
			this.immutable = immutable;
		}

		/// <summary>Gets whether the object is immutable.</summary>
		/// <returns>true if the object is immutable; otherwise, false.</returns>
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x0000AAB0 File Offset: 0x00008CB0
		public bool Immutable
		{
			get
			{
				return this.immutable;
			}
		}

		/// <returns>true if <paramref name="obj" /> equals the type and value of this instance; otherwise, false.</returns>
		/// <param name="obj">An <see cref="T:System.Object" /> to compare with this instance or null. </param>
		// Token: 0x06000CB1 RID: 3249 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		public override bool Equals(object obj)
		{
			return obj is ImmutableObjectAttribute && (obj == this || ((ImmutableObjectAttribute)obj).Immutable == this.immutable);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.ImmutableObjectAttribute" />.</returns>
		// Token: 0x06000CB2 RID: 3250 RVA: 0x0000AAE3 File Offset: 0x00008CE3
		public override int GetHashCode()
		{
			return this.immutable.GetHashCode();
		}

		/// <summary>Indicates whether the value of this instance is the default value.</summary>
		/// <returns>true if this instance is the default attribute for the class; otherwise, false.</returns>
		// Token: 0x06000CB3 RID: 3251 RVA: 0x0000AAF0 File Offset: 0x00008CF0
		public override bool IsDefaultAttribute()
		{
			return this.immutable == ImmutableObjectAttribute.Default.Immutable;
		}

		// Token: 0x04000385 RID: 901
		private bool immutable;

		/// <summary>Represents the default value for <see cref="T:System.ComponentModel.ImmutableObjectAttribute" />.</summary>
		// Token: 0x04000386 RID: 902
		public static readonly ImmutableObjectAttribute Default = new ImmutableObjectAttribute(false);

		/// <summary>Specifies that an object has at least one editable subproperty. This static field is read-only.</summary>
		// Token: 0x04000387 RID: 903
		public static readonly ImmutableObjectAttribute No = new ImmutableObjectAttribute(false);

		/// <summary>Specifies that an object has no subproperties that can be edited. This static field is read-only.</summary>
		// Token: 0x04000388 RID: 904
		public static readonly ImmutableObjectAttribute Yes = new ImmutableObjectAttribute(true);
	}
}
