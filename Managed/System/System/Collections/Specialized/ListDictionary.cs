using System;

namespace System.Collections.Specialized
{
	/// <summary>Implements IDictionary using a singly linked list. Recommended for collections that typically contain 10 items or less.</summary>
	// Token: 0x020000B5 RID: 181
	[Serializable]
	public class ListDictionary : ICollection, IEnumerable, IDictionary
	{
		/// <summary>Creates an empty <see cref="T:System.Collections.Specialized.ListDictionary" /> using the default comparer.</summary>
		// Token: 0x060007AE RID: 1966 RVA: 0x000076A4 File Offset: 0x000058A4
		public ListDictionary()
		{
			this.count = 0;
			this.version = 0;
			this.comparer = null;
			this.head = null;
		}

		/// <summary>Creates an empty <see cref="T:System.Collections.Specialized.ListDictionary" /> using the specified comparer.</summary>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> to use to determine whether two keys are equal.-or- null to use the default comparer, which is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param>
		// Token: 0x060007AF RID: 1967 RVA: 0x000076C8 File Offset: 0x000058C8
		public ListDictionary(IComparer comparer)
			: this()
		{
			this.comparer = comparer;
		}

		/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> that iterates through the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x060007B0 RID: 1968 RVA: 0x000076D7 File Offset: 0x000058D7
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new ListDictionary.DictionaryNodeEnumerator(this);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0002D1DC File Offset: 0x0002B3DC
		private ListDictionary.DictionaryNode FindEntry(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", "Attempted lookup for a null key.");
			}
			ListDictionary.DictionaryNode dictionaryNode = this.head;
			if (this.comparer == null)
			{
				while (dictionaryNode != null)
				{
					if (key.Equals(dictionaryNode.key))
					{
						break;
					}
					dictionaryNode = dictionaryNode.next;
				}
			}
			else
			{
				while (dictionaryNode != null)
				{
					if (this.comparer.Compare(key, dictionaryNode.key) == 0)
					{
						break;
					}
					dictionaryNode = dictionaryNode.next;
				}
			}
			return dictionaryNode;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0002D270 File Offset: 0x0002B470
		private ListDictionary.DictionaryNode FindEntry(object key, out ListDictionary.DictionaryNode prev)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", "Attempted lookup for a null key.");
			}
			ListDictionary.DictionaryNode dictionaryNode = this.head;
			prev = null;
			if (this.comparer == null)
			{
				while (dictionaryNode != null)
				{
					if (key.Equals(dictionaryNode.key))
					{
						break;
					}
					prev = dictionaryNode;
					dictionaryNode = dictionaryNode.next;
				}
			}
			else
			{
				while (dictionaryNode != null)
				{
					if (this.comparer.Compare(key, dictionaryNode.key) == 0)
					{
						break;
					}
					prev = dictionaryNode;
					dictionaryNode = dictionaryNode.next;
				}
			}
			return dictionaryNode;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0002D30C File Offset: 0x0002B50C
		private void AddImpl(object key, object value, ListDictionary.DictionaryNode prev)
		{
			if (prev == null)
			{
				this.head = new ListDictionary.DictionaryNode(key, value, this.head);
			}
			else
			{
				prev.next = new ListDictionary.DictionaryNode(key, value, prev.next);
			}
			this.count++;
			this.version++;
		}

		/// <summary>Gets the number of key/value pairs contained in the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x000076DF File Offset: 0x000058DF
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.ListDictionary" /> is synchronized (thread safe).</summary>
		/// <returns>This property always returns false.</returns>
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x000021CB File Offset: 0x000003CB
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Copies the <see cref="T:System.Collections.Specialized.ListDictionary" /> entries to a one-dimensional <see cref="T:System.Array" /> instance at the specified index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the <see cref="T:System.Collections.DictionaryEntry" /> objects copied from <see cref="T:System.Collections.Specialized.ListDictionary" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.Specialized.ListDictionary" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Specialized.ListDictionary" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x060007B7 RID: 1975 RVA: 0x0002D368 File Offset: 0x0002B568
		public void CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array", "Array cannot be null.");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "index is less than 0");
			}
			if (index > array.Length)
			{
				throw new IndexOutOfRangeException("index is too large");
			}
			if (this.Count > array.Length - index)
			{
				throw new ArgumentException("Not enough room in the array");
			}
			foreach (object obj in this)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				array.SetValue(dictionaryEntry, index++);
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.ListDictionary" /> has a fixed size.</summary>
		/// <returns>This property always returns false.</returns>
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.ListDictionary" /> is read-only.</summary>
		/// <returns>This property always returns false.</returns>
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets or sets the value associated with the specified key.</summary>
		/// <returns>The value associated with the specified key. If the specified key is not found, attempting to get it returns null, and attempting to set it creates a new entry using the specified key.</returns>
		/// <param name="key">The key whose value to get or set. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> is null. </exception>
		// Token: 0x170001A1 RID: 417
		public object this[object key]
		{
			get
			{
				ListDictionary.DictionaryNode dictionaryNode = this.FindEntry(key);
				return (dictionaryNode != null) ? dictionaryNode.value : null;
			}
			set
			{
				ListDictionary.DictionaryNode dictionaryNode2;
				ListDictionary.DictionaryNode dictionaryNode = this.FindEntry(key, out dictionaryNode2);
				if (dictionaryNode != null)
				{
					dictionaryNode.value = value;
				}
				else
				{
					this.AddImpl(key, value, dictionaryNode2);
				}
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the keys in the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the keys in the <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x000076E7 File Offset: 0x000058E7
		public ICollection Keys
		{
			get
			{
				return new ListDictionary.DictionaryNodeCollection(this, true);
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x000076F0 File Offset: 0x000058F0
		public ICollection Values
		{
			get
			{
				return new ListDictionary.DictionaryNodeCollection(this, false);
			}
		}

		/// <summary>Adds an entry with the specified key and value into the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <param name="key">The key of the entry to add. </param>
		/// <param name="value">The value of the entry to add. The value can be null. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">An entry with the same key already exists in the <see cref="T:System.Collections.Specialized.ListDictionary" />. </exception>
		// Token: 0x060007BE RID: 1982 RVA: 0x0002D490 File Offset: 0x0002B690
		public void Add(object key, object value)
		{
			ListDictionary.DictionaryNode dictionaryNode2;
			ListDictionary.DictionaryNode dictionaryNode = this.FindEntry(key, out dictionaryNode2);
			if (dictionaryNode != null)
			{
				throw new ArgumentException("key", "Duplicate key in add.");
			}
			this.AddImpl(key, value, dictionaryNode2);
		}

		/// <summary>Removes all entries from the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		// Token: 0x060007BF RID: 1983 RVA: 0x000076F9 File Offset: 0x000058F9
		public void Clear()
		{
			this.head = null;
			this.count = 0;
			this.version++;
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.Specialized.ListDictionary" /> contains a specific key.</summary>
		/// <returns>true if the <see cref="T:System.Collections.Specialized.ListDictionary" /> contains an entry with the specified key; otherwise, false.</returns>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.Specialized.ListDictionary" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> is null. </exception>
		// Token: 0x060007C0 RID: 1984 RVA: 0x00007717 File Offset: 0x00005917
		public bool Contains(object key)
		{
			return this.FindEntry(key) != null;
		}

		/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> that iterates through the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> for the <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x060007C1 RID: 1985 RVA: 0x000076D7 File Offset: 0x000058D7
		public IDictionaryEnumerator GetEnumerator()
		{
			return new ListDictionary.DictionaryNodeEnumerator(this);
		}

		/// <summary>Removes the entry with the specified key from the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <param name="key">The key of the entry to remove. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> is null. </exception>
		// Token: 0x060007C2 RID: 1986 RVA: 0x0002D4C8 File Offset: 0x0002B6C8
		public void Remove(object key)
		{
			ListDictionary.DictionaryNode dictionaryNode2;
			ListDictionary.DictionaryNode dictionaryNode = this.FindEntry(key, out dictionaryNode2);
			if (dictionaryNode == null)
			{
				return;
			}
			if (dictionaryNode2 == null)
			{
				this.head = dictionaryNode.next;
			}
			else
			{
				dictionaryNode2.next = dictionaryNode.next;
			}
			dictionaryNode.value = null;
			this.count--;
			this.version++;
		}

		// Token: 0x04000219 RID: 537
		private int count;

		// Token: 0x0400021A RID: 538
		private int version;

		// Token: 0x0400021B RID: 539
		private ListDictionary.DictionaryNode head;

		// Token: 0x0400021C RID: 540
		private IComparer comparer;

		// Token: 0x020000B6 RID: 182
		[Serializable]
		private class DictionaryNode
		{
			// Token: 0x060007C3 RID: 1987 RVA: 0x00007726 File Offset: 0x00005926
			public DictionaryNode(object key, object value, ListDictionary.DictionaryNode next)
			{
				this.key = key;
				this.value = value;
				this.next = next;
			}

			// Token: 0x0400021D RID: 541
			public object key;

			// Token: 0x0400021E RID: 542
			public object value;

			// Token: 0x0400021F RID: 543
			public ListDictionary.DictionaryNode next;
		}

		// Token: 0x020000B7 RID: 183
		private class DictionaryNodeEnumerator : IEnumerator, IDictionaryEnumerator
		{
			// Token: 0x060007C4 RID: 1988 RVA: 0x00007743 File Offset: 0x00005943
			public DictionaryNodeEnumerator(ListDictionary dict)
			{
				this.dict = dict;
				this.version = dict.version;
				this.Reset();
			}

			// Token: 0x060007C5 RID: 1989 RVA: 0x00007764 File Offset: 0x00005964
			private void FailFast()
			{
				if (this.version != this.dict.version)
				{
					throw new InvalidOperationException("The ListDictionary's contents changed after this enumerator was instantiated.");
				}
			}

			// Token: 0x060007C6 RID: 1990 RVA: 0x0002D52C File Offset: 0x0002B72C
			public bool MoveNext()
			{
				this.FailFast();
				if (this.current == null && !this.isAtStart)
				{
					return false;
				}
				this.current = ((!this.isAtStart) ? this.current.next : this.dict.head);
				this.isAtStart = false;
				return this.current != null;
			}

			// Token: 0x060007C7 RID: 1991 RVA: 0x00007787 File Offset: 0x00005987
			public void Reset()
			{
				this.FailFast();
				this.isAtStart = true;
				this.current = null;
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0000779D File Offset: 0x0000599D
			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x060007C9 RID: 1993 RVA: 0x000077AA File Offset: 0x000059AA
			private ListDictionary.DictionaryNode DictionaryNode
			{
				get
				{
					this.FailFast();
					if (this.current == null)
					{
						throw new InvalidOperationException("Enumerator is positioned before the collection's first element or after the last element.");
					}
					return this.current;
				}
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x060007CA RID: 1994 RVA: 0x0002D598 File Offset: 0x0002B798
			public DictionaryEntry Entry
			{
				get
				{
					object key = this.DictionaryNode.key;
					return new DictionaryEntry(key, this.current.value);
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x060007CB RID: 1995 RVA: 0x000077CE File Offset: 0x000059CE
			public object Key
			{
				get
				{
					return this.DictionaryNode.key;
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x060007CC RID: 1996 RVA: 0x000077DB File Offset: 0x000059DB
			public object Value
			{
				get
				{
					return this.DictionaryNode.value;
				}
			}

			// Token: 0x04000220 RID: 544
			private ListDictionary dict;

			// Token: 0x04000221 RID: 545
			private bool isAtStart;

			// Token: 0x04000222 RID: 546
			private ListDictionary.DictionaryNode current;

			// Token: 0x04000223 RID: 547
			private int version;
		}

		// Token: 0x020000B8 RID: 184
		private class DictionaryNodeCollection : ICollection, IEnumerable
		{
			// Token: 0x060007CD RID: 1997 RVA: 0x000077E8 File Offset: 0x000059E8
			public DictionaryNodeCollection(ListDictionary dict, bool isKeyList)
			{
				this.dict = dict;
				this.isKeyList = isKeyList;
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x060007CE RID: 1998 RVA: 0x000077FE File Offset: 0x000059FE
			public int Count
			{
				get
				{
					return this.dict.Count;
				}
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x060007CF RID: 1999 RVA: 0x00002AA1 File Offset: 0x00000CA1
			public bool IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0000780B File Offset: 0x00005A0B
			public object SyncRoot
			{
				get
				{
					return this.dict.SyncRoot;
				}
			}

			// Token: 0x060007D1 RID: 2001 RVA: 0x0002D5C4 File Offset: 0x0002B7C4
			public void CopyTo(Array array, int index)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array", "Array cannot be null.");
				}
				if (index < 0)
				{
					throw new ArgumentOutOfRangeException("index", "index is less than 0");
				}
				if (index > array.Length)
				{
					throw new IndexOutOfRangeException("index is too large");
				}
				if (this.Count > array.Length - index)
				{
					throw new ArgumentException("Not enough room in the array");
				}
				foreach (object obj in this)
				{
					array.SetValue(obj, index++);
				}
			}

			// Token: 0x060007D2 RID: 2002 RVA: 0x00007818 File Offset: 0x00005A18
			public IEnumerator GetEnumerator()
			{
				return new ListDictionary.DictionaryNodeCollection.DictionaryNodeCollectionEnumerator(this.dict.GetEnumerator(), this.isKeyList);
			}

			// Token: 0x04000224 RID: 548
			private ListDictionary dict;

			// Token: 0x04000225 RID: 549
			private bool isKeyList;

			// Token: 0x020000B9 RID: 185
			private class DictionaryNodeCollectionEnumerator : IEnumerator
			{
				// Token: 0x060007D3 RID: 2003 RVA: 0x00007830 File Offset: 0x00005A30
				public DictionaryNodeCollectionEnumerator(IDictionaryEnumerator inner, bool isKeyList)
				{
					this.inner = inner;
					this.isKeyList = isKeyList;
				}

				// Token: 0x170001AC RID: 428
				// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00007846 File Offset: 0x00005A46
				public object Current
				{
					get
					{
						return (!this.isKeyList) ? this.inner.Value : this.inner.Key;
					}
				}

				// Token: 0x060007D5 RID: 2005 RVA: 0x0000786E File Offset: 0x00005A6E
				public bool MoveNext()
				{
					return this.inner.MoveNext();
				}

				// Token: 0x060007D6 RID: 2006 RVA: 0x0000787B File Offset: 0x00005A7B
				public void Reset()
				{
					this.inner.Reset();
				}

				// Token: 0x04000226 RID: 550
				private IDictionaryEnumerator inner;

				// Token: 0x04000227 RID: 551
				private bool isKeyList;
			}
		}
	}
}
