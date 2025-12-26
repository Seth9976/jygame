using System;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Represents a single relationship between an object and a member.</summary>
	// Token: 0x02000138 RID: 312
	public struct MemberRelationship
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> class. </summary>
		/// <param name="owner">The object that owns <paramref name="member" />.</param>
		/// <param name="member">The member which is to be related to <paramref name="owner" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="owner" /> or <paramref name="member" /> is null.</exception>
		// Token: 0x06000BA5 RID: 2981 RVA: 0x0000A169 File Offset: 0x00008369
		public MemberRelationship(object owner, MemberDescriptor member)
		{
			this._owner = owner;
			this._member = member;
		}

		/// <summary>Gets a value indicating whether this relationship is equal to the <see cref="F:System.ComponentModel.Design.Serialization.MemberRelationship.Empty" /> relationship. </summary>
		/// <returns>true if this relationship is equal to the <see cref="F:System.ComponentModel.Design.Serialization.MemberRelationship.Empty" /> relationship; otherwise, false.</returns>
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x0000A179 File Offset: 0x00008379
		public bool IsEmpty
		{
			get
			{
				return this._owner == null;
			}
		}

		/// <summary>Gets the owning object.</summary>
		/// <returns>The owning object that is passed in to the <see cref="M:System.ComponentModel.Design.Serialization.MemberRelationship.#ctor(System.Object,System.ComponentModel.MemberDescriptor)" />.</returns>
		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0000A184 File Offset: 0x00008384
		public object Owner
		{
			get
			{
				return this._owner;
			}
		}

		/// <summary>Gets the related member.</summary>
		/// <returns>The member that is passed in to the <see cref="M:System.ComponentModel.Design.Serialization.MemberRelationship.#ctor(System.Object,System.ComponentModel.MemberDescriptor)" />.</returns>
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0000A18C File Offset: 0x0000838C
		public MemberDescriptor Member
		{
			get
			{
				return this._member;
			}
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />.</returns>
		// Token: 0x06000BAA RID: 2986 RVA: 0x0000A194 File Offset: 0x00008394
		public override int GetHashCode()
		{
			if (this._owner != null && this._member != null)
			{
				return this._member.GetHashCode() ^ this._owner.GetHashCode();
			}
			return base.GetHashCode();
		}

		/// <summary>Determines whether two <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> instances are equal.</summary>
		/// <returns>true if the specified <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> is equal to the current <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />; otherwise, false.</returns>
		/// <param name="obj">The <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> to compare with the current <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />.</param>
		// Token: 0x06000BAB RID: 2987 RVA: 0x0000A1D4 File Offset: 0x000083D4
		public override bool Equals(object o)
		{
			return o is MemberRelationship && (MemberRelationship)o == this;
		}

		/// <summary>Tests whether two specified <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> structures are equivalent.</summary>
		/// <returns>This operator returns true if the two <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> structures are equal; otherwise, false.</returns>
		/// <param name="left">The <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> structure that is to the left of the equality operator.</param>
		/// <param name="right">The <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> structure that is to the right of the equality operator.</param>
		// Token: 0x06000BAC RID: 2988 RVA: 0x0000A1F4 File Offset: 0x000083F4
		public static bool operator ==(MemberRelationship left, MemberRelationship right)
		{
			return left.Owner == right.Owner && left.Member == right.Member;
		}

		/// <summary>Tests whether two specified <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> structures are different.</summary>
		/// <returns>This operator returns true if the two <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> structures are different; otherwise, false.</returns>
		/// <param name="left">The <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> structure that is to the left of the inequality operator.</param>
		/// <param name="right">The <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> structure that is to the right of the inequality operator.</param>
		// Token: 0x06000BAD RID: 2989 RVA: 0x0000A21F File Offset: 0x0000841F
		public static bool operator !=(MemberRelationship left, MemberRelationship right)
		{
			return !(left == right);
		}

		/// <summary>Represents the empty member relationship. This field is read-only.</summary>
		// Token: 0x04000316 RID: 790
		public static readonly MemberRelationship Empty = default(MemberRelationship);

		// Token: 0x04000317 RID: 791
		private object _owner;

		// Token: 0x04000318 RID: 792
		private MemberDescriptor _member;
	}
}
