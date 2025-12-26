using System;

namespace System.ComponentModel
{
	/// <summary>Indicates whether the component associated with this attribute has been inherited from a base class. This class cannot be inherited.</summary>
	// Token: 0x02000164 RID: 356
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
	public sealed class InheritanceAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.InheritanceAttribute" /> class.</summary>
		// Token: 0x06000CB6 RID: 3254 RVA: 0x0000AB04 File Offset: 0x00008D04
		public InheritanceAttribute()
		{
			this.level = InheritanceLevel.NotInherited;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.InheritanceAttribute" /> class with the specified inheritance level.</summary>
		/// <param name="inheritanceLevel">An <see cref="T:System.ComponentModel.InheritanceLevel" /> that indicates the level of inheritance to set this attribute to. </param>
		// Token: 0x06000CB7 RID: 3255 RVA: 0x0000AB13 File Offset: 0x00008D13
		public InheritanceAttribute(InheritanceLevel inheritanceLevel)
		{
			this.level = inheritanceLevel;
		}

		/// <summary>Gets or sets the current inheritance level stored in this attribute.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.InheritanceLevel" /> stored in this attribute.</returns>
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x0000AB4F File Offset: 0x00008D4F
		public InheritanceLevel InheritanceLevel
		{
			get
			{
				return this.level;
			}
		}

		/// <summary>Override to test for equality.</summary>
		/// <returns>true if the object is the same; otherwise, false.</returns>
		/// <param name="value">The object to test. </param>
		// Token: 0x06000CBA RID: 3258 RVA: 0x0000AB57 File Offset: 0x00008D57
		public override bool Equals(object obj)
		{
			return obj is InheritanceAttribute && (obj == this || ((InheritanceAttribute)obj).InheritanceLevel == this.level);
		}

		/// <summary>Returns the hashcode for this object.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.InheritanceAttribute" />.</returns>
		// Token: 0x06000CBB RID: 3259 RVA: 0x0000AB82 File Offset: 0x00008D82
		public override int GetHashCode()
		{
			return this.level.GetHashCode();
		}

		/// <summary>Gets a value indicating whether the current value of the attribute is the default value for the attribute.</summary>
		/// <returns>true if the current value of the attribute is the default; otherwise, false.</returns>
		// Token: 0x06000CBC RID: 3260 RVA: 0x0000AB94 File Offset: 0x00008D94
		public override bool IsDefaultAttribute()
		{
			return this.level == InheritanceAttribute.Default.InheritanceLevel;
		}

		/// <summary>Converts this attribute to a string.</summary>
		/// <returns>A string that represents this <see cref="T:System.ComponentModel.InheritanceAttribute" />.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06000CBD RID: 3261 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		public override string ToString()
		{
			return this.level.ToString();
		}

		// Token: 0x04000389 RID: 905
		private InheritanceLevel level;

		/// <summary>Specifies that the default value for <see cref="T:System.ComponentModel.InheritanceAttribute" /> is <see cref="F:System.ComponentModel.InheritanceAttribute.NotInherited" />. This field is read-only.</summary>
		// Token: 0x0400038A RID: 906
		public static readonly InheritanceAttribute Default = new InheritanceAttribute();

		/// <summary>Specifies that the component is inherited. This field is read-only.</summary>
		// Token: 0x0400038B RID: 907
		public static readonly InheritanceAttribute Inherited = new InheritanceAttribute(InheritanceLevel.Inherited);

		/// <summary>Specifies that the component is inherited and is read-only. This field is read-only.</summary>
		// Token: 0x0400038C RID: 908
		public static readonly InheritanceAttribute InheritedReadOnly = new InheritanceAttribute(InheritanceLevel.InheritedReadOnly);

		/// <summary>Specifies that the component is not inherited. This field is read-only.</summary>
		// Token: 0x0400038D RID: 909
		public static readonly InheritanceAttribute NotInherited = new InheritanceAttribute(InheritanceLevel.NotInherited);
	}
}
