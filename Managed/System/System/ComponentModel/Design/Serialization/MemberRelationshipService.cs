using System;
using System.Collections;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Provides the base class for relating one member to another.</summary>
	// Token: 0x02000139 RID: 313
	public abstract class MemberRelationshipService
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationshipService" /> class. </summary>
		// Token: 0x06000BAE RID: 2990 RVA: 0x0000A22B File Offset: 0x0000842B
		protected MemberRelationshipService()
		{
			this._relations = new Hashtable();
		}

		/// <summary>Gets a value indicating whether the given relationship is supported.</summary>
		/// <returns>true if a relationship between the given two objects is supported; otherwise, false.</returns>
		/// <param name="source">The source relationship.</param>
		/// <param name="relationship">The relationship to set into the source.</param>
		// Token: 0x06000BAF RID: 2991
		public abstract bool SupportsRelationship(MemberRelationship source, MemberRelationship relationship);

		/// <summary>Gets a relationship to the given source relationship.</summary>
		/// <returns>A relationship to <paramref name="source" />, or <see cref="F:System.ComponentModel.Design.Serialization.MemberRelationship.Empty" /> if no relationship exists.</returns>
		/// <param name="source">The source relationship.</param>
		// Token: 0x06000BB0 RID: 2992 RVA: 0x00030E30 File Offset: 0x0002F030
		protected virtual MemberRelationship GetRelationship(MemberRelationship source)
		{
			if (source.IsEmpty)
			{
				throw new ArgumentNullException("source");
			}
			MemberRelationshipService.MemberRelationshipWeakEntry memberRelationshipWeakEntry = this._relations[new MemberRelationshipService.MemberRelationshipWeakEntry(source)] as MemberRelationshipService.MemberRelationshipWeakEntry;
			if (memberRelationshipWeakEntry != null)
			{
				return new MemberRelationship(memberRelationshipWeakEntry.Owner, memberRelationshipWeakEntry.Member);
			}
			return MemberRelationship.Empty;
		}

		/// <summary>Creates a relationship between the source object and target relationship.</summary>
		/// <param name="source">The source relationship.</param>
		/// <param name="relationship">The relationship to set into the source.</param>
		/// <exception cref="T:System.ArgumentException">The relationship is not supported by the service.</exception>
		// Token: 0x06000BB1 RID: 2993 RVA: 0x00030E90 File Offset: 0x0002F090
		protected virtual void SetRelationship(MemberRelationship source, MemberRelationship relationship)
		{
			if (source.IsEmpty)
			{
				throw new ArgumentNullException("source");
			}
			if (!relationship.IsEmpty && !this.SupportsRelationship(source, relationship))
			{
				throw new ArgumentException("Relationship not supported.");
			}
			this._relations[new MemberRelationshipService.MemberRelationshipWeakEntry(source)] = new MemberRelationshipService.MemberRelationshipWeakEntry(relationship);
		}

		/// <summary>Establishes a relationship between a source and target object.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> structure encapsulating the relationship between a source and target object, or null if there is no relationship.</returns>
		/// <param name="sourceOwner">The owner of a source relationship.</param>
		/// <param name="sourceMember">The member of a source relationship.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="sourceOwner" /> or <paramref name="sourceMember" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="sourceOwner" /> or <paramref name="sourceMember" /> is empty, or the relationship is not supported by the service.</exception>
		// Token: 0x1700029F RID: 671
		public MemberRelationship this[object owner, MemberDescriptor member]
		{
			get
			{
				return this.GetRelationship(new MemberRelationship(owner, member));
			}
			set
			{
				this.SetRelationship(new MemberRelationship(owner, member), value);
			}
		}

		/// <summary>Establishes a relationship between a source and target object.</summary>
		/// <returns>The current relationship associated with <paramref name="source" />, or <see cref="F:System.ComponentModel.Design.Serialization.MemberRelationship.Empty" /> if there is no relationship.</returns>
		/// <param name="source">The source relationship. This is the left-hand side of a relationship assignment.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="source" /> is empty, or the relationship is not supported by the service.</exception>
		// Token: 0x170002A0 RID: 672
		public MemberRelationship this[MemberRelationship source]
		{
			get
			{
				return this.GetRelationship(source);
			}
			set
			{
				this.SetRelationship(source, value);
			}
		}

		// Token: 0x04000319 RID: 793
		private Hashtable _relations;

		// Token: 0x0200013A RID: 314
		private class MemberRelationshipWeakEntry
		{
			// Token: 0x06000BB6 RID: 2998 RVA: 0x0000A270 File Offset: 0x00008470
			public MemberRelationshipWeakEntry(MemberRelationship relation)
			{
				this._ownerWeakRef = new WeakReference(relation.Owner);
				this._member = relation.Member;
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0000A297 File Offset: 0x00008497
			public object Owner
			{
				get
				{
					if (this._ownerWeakRef.IsAlive)
					{
						return this._ownerWeakRef.Target;
					}
					return null;
				}
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x0000A2B6 File Offset: 0x000084B6
			public MemberDescriptor Member
			{
				get
				{
					return this._member;
				}
			}

			// Token: 0x06000BB9 RID: 3001 RVA: 0x0000A2BE File Offset: 0x000084BE
			public override int GetHashCode()
			{
				if (this.Owner != null && this._member != null)
				{
					return this._member.GetHashCode() ^ this._ownerWeakRef.Target.GetHashCode();
				}
				return base.GetHashCode();
			}

			// Token: 0x06000BBA RID: 3002 RVA: 0x0000A2F9 File Offset: 0x000084F9
			public override bool Equals(object o)
			{
				return o is MemberRelationshipService.MemberRelationshipWeakEntry && (MemberRelationshipService.MemberRelationshipWeakEntry)o == this;
			}

			// Token: 0x06000BBB RID: 3003 RVA: 0x0000A314 File Offset: 0x00008514
			public static bool operator ==(MemberRelationshipService.MemberRelationshipWeakEntry left, MemberRelationshipService.MemberRelationshipWeakEntry right)
			{
				return left.Owner == right.Owner && left.Member == right.Member;
			}

			// Token: 0x06000BBC RID: 3004 RVA: 0x0000A33B File Offset: 0x0000853B
			public static bool operator !=(MemberRelationshipService.MemberRelationshipWeakEntry left, MemberRelationshipService.MemberRelationshipWeakEntry right)
			{
				return !(left == right);
			}

			// Token: 0x0400031A RID: 794
			private WeakReference _ownerWeakRef;

			// Token: 0x0400031B RID: 795
			private MemberDescriptor _member;
		}
	}
}
