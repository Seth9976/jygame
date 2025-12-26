using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	/// <summary>Represents the set of successful matches found by iteratively applying a regular expression pattern to the input string.</summary>
	// Token: 0x020004A2 RID: 1186
	[Serializable]
	public class MatchCollection : ICollection, IEnumerable
	{
		// Token: 0x060029CF RID: 10703 RVA: 0x0001D201 File Offset: 0x0001B401
		internal MatchCollection(Match start)
		{
			this.current = start;
			this.list = new ArrayList();
		}

		/// <summary>Gets the number of matches.</summary>
		/// <returns>The number of matches.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060029D0 RID: 10704 RVA: 0x0001D21B File Offset: 0x0001B41B
		public int Count
		{
			get
			{
				return this.FullList.Count;
			}
		}

		/// <summary>Gets a value that indicates whether the collection is read only.</summary>
		/// <returns>This value of this property is always true.</returns>
		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060029D1 RID: 10705 RVA: 0x000025B7 File Offset: 0x000007B7
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets a value indicating whether access to the collection is synchronized (thread-safe).</summary>
		/// <returns>The value of this property is always false.</returns>
		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060029D2 RID: 10706 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an individual member of the collection.</summary>
		/// <returns>The captured substring at position <paramref name="i" /> in the collection.</returns>
		/// <param name="i">Index into the Match collection. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="i" /> is less than 0 or greater than or equal to <see cref="P:System.Text.RegularExpressions.MatchCollection.Count" />. </exception>
		// Token: 0x17000B8A RID: 2954
		public virtual Match this[int i]
		{
			get
			{
				if (i < 0 || !this.TryToGet(i))
				{
					throw new ArgumentOutOfRangeException("i");
				}
				return (i >= this.list.Count) ? this.current : ((Match)this.list[i]);
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>An object that can be used to synchronize access to the collection. This property always returns the object itself.</returns>
		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060029D4 RID: 10708 RVA: 0x0001D228 File Offset: 0x0001B428
		public object SyncRoot
		{
			get
			{
				return this.list;
			}
		}

		/// <summary>Copies all the elements of the collection to the given array starting at the given index.</summary>
		/// <param name="array">The array the collection is to be copied into. </param>
		/// <param name="arrayIndex">The position in the array where copying is to begin. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is a multi-dimensional array.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="arrayIndex" /> is outside the bounds of <paramref name="array" />.-or-<paramref name="arrayIndex" /> plus <see cref="P:System.Text.RegularExpressions.GroupCollection.Count" /> is outside the bounds of <paramref name="array" />.</exception>
		// Token: 0x060029D5 RID: 10709 RVA: 0x0001D230 File Offset: 0x0001B430
		public void CopyTo(Array array, int index)
		{
			this.FullList.CopyTo(array, index);
		}

		/// <summary>Provides an enumerator in the same order as <see cref="P:System.Text.RegularExpressions.MatchCollection.Item(System.Int32)" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that contains all Match objects within the MatchCollection.</returns>
		// Token: 0x060029D6 RID: 10710 RVA: 0x00082068 File Offset: 0x00080268
		public IEnumerator GetEnumerator()
		{
			IEnumerator enumerator2;
			if (this.current.Success)
			{
				IEnumerator enumerator = new MatchCollection.Enumerator(this);
				enumerator2 = enumerator;
			}
			else
			{
				enumerator2 = this.list.GetEnumerator();
			}
			return enumerator2;
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x000820A0 File Offset: 0x000802A0
		private bool TryToGet(int i)
		{
			while (i > this.list.Count && this.current.Success)
			{
				this.list.Add(this.current);
				this.current = this.current.NextMatch();
			}
			return i < this.list.Count || this.current.Success;
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060029D8 RID: 10712 RVA: 0x0001D23F File Offset: 0x0001B43F
		private ICollection FullList
		{
			get
			{
				if (this.TryToGet(2147483647))
				{
					throw new SystemException("too many matches");
				}
				return this.list;
			}
		}

		// Token: 0x04001A16 RID: 6678
		private Match current;

		// Token: 0x04001A17 RID: 6679
		private ArrayList list;

		// Token: 0x020004A3 RID: 1187
		private class Enumerator : IEnumerator
		{
			// Token: 0x060029D9 RID: 10713 RVA: 0x0001D262 File Offset: 0x0001B462
			internal Enumerator(MatchCollection coll)
			{
				this.coll = coll;
				this.index = -1;
			}

			// Token: 0x060029DA RID: 10714 RVA: 0x0001D278 File Offset: 0x0001B478
			void IEnumerator.Reset()
			{
				this.index = -1;
			}

			// Token: 0x17000B8D RID: 2957
			// (get) Token: 0x060029DB RID: 10715 RVA: 0x00082118 File Offset: 0x00080318
			object IEnumerator.Current
			{
				get
				{
					if (this.index < 0)
					{
						throw new InvalidOperationException("'Current' called before 'MoveNext()'");
					}
					if (this.index > this.coll.list.Count)
					{
						throw new SystemException("MatchCollection in invalid state");
					}
					if (this.index == this.coll.list.Count && !this.coll.current.Success)
					{
						throw new InvalidOperationException("'Current' called after 'MoveNext()' returned false");
					}
					return (this.index >= this.coll.list.Count) ? this.coll.current : this.coll.list[this.index];
				}
			}

			// Token: 0x060029DC RID: 10716 RVA: 0x000821E0 File Offset: 0x000803E0
			bool IEnumerator.MoveNext()
			{
				if (this.index > this.coll.list.Count)
				{
					throw new SystemException("MatchCollection in invalid state");
				}
				return (this.index != this.coll.list.Count || this.coll.current.Success) && this.coll.TryToGet(++this.index);
			}

			// Token: 0x04001A18 RID: 6680
			private int index;

			// Token: 0x04001A19 RID: 6681
			private MatchCollection coll;
		}
	}
}
