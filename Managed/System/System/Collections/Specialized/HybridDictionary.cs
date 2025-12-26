using System;

namespace System.Collections.Specialized
{
	/// <summary>Implements IDictionary by using a <see cref="T:System.Collections.Specialized.ListDictionary" /> while the collection is small, and then switching to a <see cref="T:System.Collections.Hashtable" /> when the collection gets large.</summary>
	// Token: 0x020000B3 RID: 179
	[Serializable]
	public class HybridDictionary : ICollection, IEnumerable, IDictionary
	{
		/// <summary>Creates an empty case-sensitive <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		// Token: 0x06000793 RID: 1939 RVA: 0x000075AA File Offset: 0x000057AA
		public HybridDictionary()
			: this(0, false)
		{
		}

		/// <summary>Creates an empty <see cref="T:System.Collections.Specialized.HybridDictionary" /> with the specified case sensitivity.</summary>
		/// <param name="caseInsensitive">A Boolean that denotes whether the <see cref="T:System.Collections.Specialized.HybridDictionary" /> is case-insensitive. </param>
		// Token: 0x06000794 RID: 1940 RVA: 0x000075B4 File Offset: 0x000057B4
		public HybridDictionary(bool caseInsensitive)
			: this(0, caseInsensitive)
		{
		}

		/// <summary>Creates a case-sensitive <see cref="T:System.Collections.Specialized.HybridDictionary" /> with the specified initial size.</summary>
		/// <param name="initialSize">The approximate number of entries that the <see cref="T:System.Collections.Specialized.HybridDictionary" /> can initially contain. </param>
		// Token: 0x06000795 RID: 1941 RVA: 0x000075BE File Offset: 0x000057BE
		public HybridDictionary(int initialSize)
			: this(initialSize, false)
		{
		}

		/// <summary>Creates a <see cref="T:System.Collections.Specialized.HybridDictionary" /> with the specified initial size and case sensitivity.</summary>
		/// <param name="initialSize">The approximate number of entries that the <see cref="T:System.Collections.Specialized.HybridDictionary" /> can initially contain. </param>
		/// <param name="caseInsensitive">A Boolean that denotes whether the <see cref="T:System.Collections.Specialized.HybridDictionary" /> is case-insensitive. </param>
		// Token: 0x06000796 RID: 1942 RVA: 0x0002D0E8 File Offset: 0x0002B2E8
		public HybridDictionary(int initialSize, bool caseInsensitive)
		{
			this.caseInsensitive = caseInsensitive;
			IComparer comparer = ((!caseInsensitive) ? null : CaseInsensitiveComparer.DefaultInvariant);
			IHashCodeProvider hashCodeProvider = ((!caseInsensitive) ? null : CaseInsensitiveHashCodeProvider.DefaultInvariant);
			if (initialSize <= 10)
			{
				this.list = new ListDictionary(comparer);
			}
			else
			{
				this.hashtable = new Hashtable(initialSize, hashCodeProvider, comparer);
			}
		}

		/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> that iterates through the <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.Specialized.HybridDictionary" />.</returns>
		// Token: 0x06000797 RID: 1943 RVA: 0x000075C8 File Offset: 0x000057C8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0002D150 File Offset: 0x0002B350
		private IDictionary inner
		{
			get
			{
				IDictionary dictionary2;
				if (this.list == null)
				{
					IDictionary dictionary = this.hashtable;
					dictionary2 = dictionary;
				}
				else
				{
					dictionary2 = this.list;
				}
				return dictionary2;
			}
		}

		/// <summary>Gets the number of key/value pairs contained in the <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Specialized.HybridDictionary" />.Retrieving the value of this property is an O(1) operation.</returns>
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x000075D0 File Offset: 0x000057D0
		public int Count
		{
			get
			{
				return this.inner.Count;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.HybridDictionary" /> has a fixed size.</summary>
		/// <returns>This property always returns false.</returns>
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.HybridDictionary" /> is read-only.</summary>
		/// <returns>This property always returns false.</returns>
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.HybridDictionary" /> is synchronized (thread safe).</summary>
		/// <returns>This property always returns false.</returns>
		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public bool IsSynchronized
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
		// Token: 0x17000197 RID: 407
		public object this[object key]
		{
			get
			{
				return this.inner[key];
			}
			set
			{
				this.inner[key] = value;
				if (this.list != null && this.Count > 10)
				{
					this.Switch();
				}
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the keys in the <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the keys in the <see cref="T:System.Collections.Specialized.HybridDictionary" />.</returns>
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00007618 File Offset: 0x00005818
		public ICollection Keys
		{
			get
			{
				return this.inner.Keys;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.HybridDictionary" />.</returns>
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x000021CB File Offset: 0x000003CB
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.Specialized.HybridDictionary" />.</returns>
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00007625 File Offset: 0x00005825
		public ICollection Values
		{
			get
			{
				return this.inner.Values;
			}
		}

		/// <summary>Adds an entry with the specified key and value into the <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <param name="key">The key of the entry to add. </param>
		/// <param name="value">The value of the entry to add. The value can be null. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">An entry with the same key already exists in the <see cref="T:System.Collections.Specialized.HybridDictionary" />. </exception>
		// Token: 0x060007A2 RID: 1954 RVA: 0x00007632 File Offset: 0x00005832
		public void Add(object key, object value)
		{
			this.inner.Add(key, value);
			if (this.list != null && this.Count > 10)
			{
				this.Switch();
			}
		}

		/// <summary>Removes all entries from the <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		// Token: 0x060007A3 RID: 1955 RVA: 0x0000765F File Offset: 0x0000585F
		public void Clear()
		{
			this.inner.Clear();
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.Specialized.HybridDictionary" /> contains a specific key.</summary>
		/// <returns>true if the <see cref="T:System.Collections.Specialized.HybridDictionary" /> contains an entry with the specified key; otherwise, false.</returns>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.Specialized.HybridDictionary" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> is null. </exception>
		// Token: 0x060007A4 RID: 1956 RVA: 0x0000766C File Offset: 0x0000586C
		public bool Contains(object key)
		{
			return this.inner.Contains(key);
		}

		/// <summary>Copies the <see cref="T:System.Collections.Specialized.HybridDictionary" /> entries to a one-dimensional <see cref="T:System.Array" /> instance at the specified index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the <see cref="T:System.Collections.DictionaryEntry" /> objects copied from <see cref="T:System.Collections.Specialized.HybridDictionary" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.Specialized.HybridDictionary" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Specialized.HybridDictionary" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x060007A5 RID: 1957 RVA: 0x0000767A File Offset: 0x0000587A
		public void CopyTo(Array array, int index)
		{
			this.inner.CopyTo(array, index);
		}

		/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> that iterates through the <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> for the <see cref="T:System.Collections.Specialized.HybridDictionary" />.</returns>
		// Token: 0x060007A6 RID: 1958 RVA: 0x00007689 File Offset: 0x00005889
		public IDictionaryEnumerator GetEnumerator()
		{
			return this.inner.GetEnumerator();
		}

		/// <summary>Removes the entry with the specified key from the <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <param name="key">The key of the entry to remove. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> is null. </exception>
		// Token: 0x060007A7 RID: 1959 RVA: 0x00007696 File Offset: 0x00005896
		public void Remove(object key)
		{
			this.inner.Remove(key);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0002D17C File Offset: 0x0002B37C
		private void Switch()
		{
			IComparer comparer = ((!this.caseInsensitive) ? null : CaseInsensitiveComparer.DefaultInvariant);
			IHashCodeProvider hashCodeProvider = ((!this.caseInsensitive) ? null : CaseInsensitiveHashCodeProvider.DefaultInvariant);
			this.hashtable = new Hashtable(this.list, hashCodeProvider, comparer);
			this.list.Clear();
			this.list = null;
		}

		// Token: 0x04000215 RID: 533
		private const int switchAfter = 10;

		// Token: 0x04000216 RID: 534
		private bool caseInsensitive;

		// Token: 0x04000217 RID: 535
		private Hashtable hashtable;

		// Token: 0x04000218 RID: 536
		private ListDictionary list;
	}
}
