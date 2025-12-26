using System;
using System.Runtime.Serialization;

namespace System.Collections.Specialized
{
	/// <summary>Represents a collection of key/value pairs that are accessible by the key or index.</summary>
	// Token: 0x020000BF RID: 191
	[Serializable]
	public class OrderedDictionary : ICollection, IEnumerable, IDictionary, IDeserializationCallback, ISerializable, IOrderedDictionary
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> class.</summary>
		// Token: 0x06000826 RID: 2086 RVA: 0x00007C34 File Offset: 0x00005E34
		public OrderedDictionary()
		{
			this.list = new ArrayList();
			this.hash = new Hashtable();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> class using the specified initial capacity.</summary>
		/// <param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection can contain.</param>
		// Token: 0x06000827 RID: 2087 RVA: 0x00007C52 File Offset: 0x00005E52
		public OrderedDictionary(int capacity)
		{
			this.initialCapacity = ((capacity >= 0) ? capacity : 0);
			this.list = new ArrayList(this.initialCapacity);
			this.hash = new Hashtable(this.initialCapacity);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> class using the specified comparer.</summary>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> to use to determine whether two keys are equal.-or- null to use the default comparer, which is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />.</param>
		// Token: 0x06000828 RID: 2088 RVA: 0x00007C90 File Offset: 0x00005E90
		public OrderedDictionary(IEqualityComparer equalityComparer)
		{
			this.list = new ArrayList();
			this.hash = new Hashtable(equalityComparer);
			this.comparer = equalityComparer;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> class using the specified initial capacity and comparer.</summary>
		/// <param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection can contain.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> to use to determine whether two keys are equal.-or- null to use the default comparer, which is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />.</param>
		// Token: 0x06000829 RID: 2089 RVA: 0x0002E274 File Offset: 0x0002C474
		public OrderedDictionary(int capacity, IEqualityComparer equalityComparer)
		{
			this.initialCapacity = ((capacity >= 0) ? capacity : 0);
			this.list = new ArrayList(this.initialCapacity);
			this.hash = new Hashtable(this.initialCapacity, equalityComparer);
			this.comparer = equalityComparer;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> class that is serializable using the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> objects.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</param>
		// Token: 0x0600082A RID: 2090 RVA: 0x00007CB6 File Offset: 0x00005EB6
		protected OrderedDictionary(SerializationInfo info, StreamingContext context)
		{
			this.serializationInfo = info;
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and is called back by the deserialization event when deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event.</param>
		// Token: 0x0600082B RID: 2091 RVA: 0x0002E2C8 File Offset: 0x0002C4C8
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			if (this.serializationInfo == null)
			{
				return;
			}
			this.comparer = (IEqualityComparer)this.serializationInfo.GetValue("KeyComparer", typeof(IEqualityComparer));
			this.readOnly = this.serializationInfo.GetBoolean("ReadOnly");
			this.initialCapacity = this.serializationInfo.GetInt32("InitialCapacity");
			if (this.list == null)
			{
				this.list = new ArrayList();
			}
			else
			{
				this.list.Clear();
			}
			this.hash = new Hashtable(this.comparer);
			object[] array = (object[])this.serializationInfo.GetValue("ArrayList", typeof(object[]));
			foreach (DictionaryEntry dictionaryEntry in array)
			{
				this.hash.Add(dictionaryEntry.Key, dictionaryEntry.Value);
				this.list.Add(dictionaryEntry);
			}
		}

		/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> object that iterates through the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> object for the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</returns>
		// Token: 0x0600082C RID: 2092 RVA: 0x00007CC5 File Offset: 0x00005EC5
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> object is synchronized (thread-safe).</summary>
		/// <returns>This method always returns false.</returns>
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00007CD2 File Offset: 0x00005ED2
		bool ICollection.IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> object.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> object.</returns>
		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00007CDF File Offset: 0x00005EDF
		object ICollection.SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> has a fixed size.</summary>
		/// <returns>true if the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> has a fixed size; otherwise, false. The default is false.</returns>
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00002AA1 File Offset: 0x00000CA1
		bool IDictionary.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and is called back by the deserialization event when deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event.</param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is invalid.</exception>
		// Token: 0x06000830 RID: 2096 RVA: 0x00007CEC File Offset: 0x00005EEC
		protected virtual void OnDeserialization(object sender)
		{
			((IDeserializationCallback)this).OnDeserialization(sender);
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data needed to serialize the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null.</exception>
		// Token: 0x06000831 RID: 2097 RVA: 0x0002E3D4 File Offset: 0x0002C5D4
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("KeyComparer", this.comparer, typeof(IEqualityComparer));
			info.AddValue("ReadOnly", this.readOnly);
			info.AddValue("InitialCapacity", this.initialCapacity);
			object[] array = new object[this.hash.Count];
			this.hash.CopyTo(array, 0);
			info.AddValue("ArrayList", array);
		}

		/// <summary>Gets the number of key/values pairs contained in the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</returns>
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00007CF5 File Offset: 0x00005EF5
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		/// <summary>Copies the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> elements to a one-dimensional <see cref="T:System.Array" /> object at the specified index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> object that is the destination of the <see cref="T:System.Collections.DictionaryEntry" /> objects copied from <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		// Token: 0x06000833 RID: 2099 RVA: 0x00007D02 File Offset: 0x00005F02
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is read-only.</summary>
		/// <returns>true if the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is read-only; otherwise, false. The default is false.</returns>
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00007D11 File Offset: 0x00005F11
		public bool IsReadOnly
		{
			get
			{
				return this.readOnly;
			}
		}

		/// <summary>Gets or sets the value with the specified key.</summary>
		/// <returns>The value associated with the specified key. If the specified key is not found, attempting to get it returns null, and attempting to set it creates a new element using the specified key.</returns>
		/// <param name="key">The key of the value to get or set.</param>
		/// <exception cref="T:System.NotSupportedException">The property is being set and the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is read-only.</exception>
		// Token: 0x170001C2 RID: 450
		public object this[object key]
		{
			get
			{
				return this.hash[key];
			}
			set
			{
				this.WriteCheck();
				if (this.hash.Contains(key))
				{
					int num = this.FindListEntry(key);
					this.list[num] = new DictionaryEntry(key, value);
				}
				else
				{
					this.list.Add(new DictionaryEntry(key, value));
				}
				this.hash[key] = value;
			}
		}

		/// <summary>Gets or sets the value at the specified index.</summary>
		/// <returns>The value of the item at the specified index. </returns>
		/// <param name="index">The zero-based index of the value to get or set.</param>
		/// <exception cref="T:System.NotSupportedException">The property is being set and the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is read-only.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero.-or-<paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.Specialized.OrderedDictionary.Count" />.</exception>
		// Token: 0x170001C3 RID: 451
		public object this[int index]
		{
			get
			{
				return ((DictionaryEntry)this.list[index]).Value;
			}
			set
			{
				this.WriteCheck();
				DictionaryEntry dictionaryEntry = (DictionaryEntry)this.list[index];
				dictionaryEntry.Value = value;
				this.list[index] = dictionaryEntry;
				this.hash[dictionaryEntry.Key] = value;
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> object containing the keys in the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> object containing the keys in the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</returns>
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00007D27 File Offset: 0x00005F27
		public ICollection Keys
		{
			get
			{
				return new OrderedDictionary.OrderedCollection(this.list, true);
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> object containing the values in the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> object containing the values in the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</returns>
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x00007D35 File Offset: 0x00005F35
		public ICollection Values
		{
			get
			{
				return new OrderedDictionary.OrderedCollection(this.list, false);
			}
		}

		/// <summary>Adds an entry with the specified key and value into the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection with the lowest available index.</summary>
		/// <param name="key">The key of the entry to add.</param>
		/// <param name="value">The value of the entry to add. This value can be null.</param>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is read-only.</exception>
		// Token: 0x0600083B RID: 2107 RVA: 0x00007D43 File Offset: 0x00005F43
		public void Add(object key, object value)
		{
			this.WriteCheck();
			this.hash.Add(key, value);
			this.list.Add(new DictionaryEntry(key, value));
		}

		/// <summary>Removes all elements from the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is read-only.</exception>
		// Token: 0x0600083C RID: 2108 RVA: 0x00007D70 File Offset: 0x00005F70
		public void Clear()
		{
			this.WriteCheck();
			this.hash.Clear();
			this.list.Clear();
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection contains a specific key.</summary>
		/// <returns>true if the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection contains an element with the specified key; otherwise, false.</returns>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</param>
		// Token: 0x0600083D RID: 2109 RVA: 0x00007D8E File Offset: 0x00005F8E
		public bool Contains(object key)
		{
			return this.hash.Contains(key);
		}

		/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> object that iterates through the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> object for the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</returns>
		// Token: 0x0600083E RID: 2110 RVA: 0x00007D9C File Offset: 0x00005F9C
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return new OrderedDictionary.OrderedEntryCollectionEnumerator(this.list.GetEnumerator());
		}

		/// <summary>Removes the entry with the specified key from the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <param name="key">The key of the entry to remove.</param>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is read-only.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> is null.</exception>
		// Token: 0x0600083F RID: 2111 RVA: 0x0002E548 File Offset: 0x0002C748
		public void Remove(object key)
		{
			this.WriteCheck();
			if (this.hash.Contains(key))
			{
				this.hash.Remove(key);
				int num = this.FindListEntry(key);
				this.list.RemoveAt(num);
			}
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0002E58C File Offset: 0x0002C78C
		private int FindListEntry(object key)
		{
			for (int i = 0; i < this.list.Count; i++)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)this.list[i];
				if ((this.comparer == null) ? dictionaryEntry.Key.Equals(key) : this.comparer.Equals(dictionaryEntry.Key, key))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00007DAE File Offset: 0x00005FAE
		private void WriteCheck()
		{
			if (this.readOnly)
			{
				throw new NotSupportedException("Collection is read only");
			}
		}

		/// <summary>Returns a read-only copy of the current <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <returns>A read-only copy of the current <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</returns>
		// Token: 0x06000842 RID: 2114 RVA: 0x0002E600 File Offset: 0x0002C800
		public OrderedDictionary AsReadOnly()
		{
			return new OrderedDictionary
			{
				list = this.list,
				hash = this.hash,
				comparer = this.comparer,
				readOnly = true
			};
		}

		/// <summary>Inserts a new entry into the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection with the specified key and value at the specified index.</summary>
		/// <param name="index">The zero-based index at which the element should be inserted.</param>
		/// <param name="key">The key of the entry to add.</param>
		/// <param name="value">The value of the entry to add. The value can be null.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is out of range.</exception>
		/// <exception cref="T:System.NotSupportedException">This collection is read-only.</exception>
		// Token: 0x06000843 RID: 2115 RVA: 0x00007DC6 File Offset: 0x00005FC6
		public void Insert(int index, object key, object value)
		{
			this.WriteCheck();
			this.hash.Add(key, value);
			this.list.Insert(index, new DictionaryEntry(key, value));
		}

		/// <summary>Removes the entry at the specified index from the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <param name="index">The zero-based index of the entry to remove.</param>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is read-only.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero.- or -<paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.Specialized.OrderedDictionary.Count" />.</exception>
		// Token: 0x06000844 RID: 2116 RVA: 0x0002E640 File Offset: 0x0002C840
		public void RemoveAt(int index)
		{
			this.WriteCheck();
			DictionaryEntry dictionaryEntry = (DictionaryEntry)this.list[index];
			this.list.RemoveAt(index);
			this.hash.Remove(dictionaryEntry.Key);
		}

		// Token: 0x04000239 RID: 569
		private ArrayList list;

		// Token: 0x0400023A RID: 570
		private Hashtable hash;

		// Token: 0x0400023B RID: 571
		private bool readOnly;

		// Token: 0x0400023C RID: 572
		private int initialCapacity;

		// Token: 0x0400023D RID: 573
		private SerializationInfo serializationInfo;

		// Token: 0x0400023E RID: 574
		private IEqualityComparer comparer;

		// Token: 0x020000C0 RID: 192
		private class OrderedEntryCollectionEnumerator : IEnumerator, IDictionaryEnumerator
		{
			// Token: 0x06000845 RID: 2117 RVA: 0x00007DF3 File Offset: 0x00005FF3
			public OrderedEntryCollectionEnumerator(IEnumerator listEnumerator)
			{
				this.listEnumerator = listEnumerator;
			}

			// Token: 0x06000846 RID: 2118 RVA: 0x00007E02 File Offset: 0x00006002
			public bool MoveNext()
			{
				return this.listEnumerator.MoveNext();
			}

			// Token: 0x06000847 RID: 2119 RVA: 0x00007E0F File Offset: 0x0000600F
			public void Reset()
			{
				this.listEnumerator.Reset();
			}

			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x06000848 RID: 2120 RVA: 0x00007E1C File Offset: 0x0000601C
			public object Current
			{
				get
				{
					return this.listEnumerator.Current;
				}
			}

			// Token: 0x170001C7 RID: 455
			// (get) Token: 0x06000849 RID: 2121 RVA: 0x00007E29 File Offset: 0x00006029
			public DictionaryEntry Entry
			{
				get
				{
					return (DictionaryEntry)this.listEnumerator.Current;
				}
			}

			// Token: 0x170001C8 RID: 456
			// (get) Token: 0x0600084A RID: 2122 RVA: 0x0002E684 File Offset: 0x0002C884
			public object Key
			{
				get
				{
					return this.Entry.Key;
				}
			}

			// Token: 0x170001C9 RID: 457
			// (get) Token: 0x0600084B RID: 2123 RVA: 0x0002E6A0 File Offset: 0x0002C8A0
			public object Value
			{
				get
				{
					return this.Entry.Value;
				}
			}

			// Token: 0x0400023F RID: 575
			private IEnumerator listEnumerator;
		}

		// Token: 0x020000C1 RID: 193
		private class OrderedCollection : ICollection, IEnumerable
		{
			// Token: 0x0600084C RID: 2124 RVA: 0x00007E3B File Offset: 0x0000603B
			public OrderedCollection(ArrayList list, bool isKeyList)
			{
				this.list = list;
				this.isKeyList = isKeyList;
			}

			// Token: 0x170001CA RID: 458
			// (get) Token: 0x0600084D RID: 2125 RVA: 0x00007E51 File Offset: 0x00006051
			public int Count
			{
				get
				{
					return this.list.Count;
				}
			}

			// Token: 0x170001CB RID: 459
			// (get) Token: 0x0600084E RID: 2126 RVA: 0x00002AA1 File Offset: 0x00000CA1
			public bool IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170001CC RID: 460
			// (get) Token: 0x0600084F RID: 2127 RVA: 0x00007E5E File Offset: 0x0000605E
			public object SyncRoot
			{
				get
				{
					return this.list.SyncRoot;
				}
			}

			// Token: 0x06000850 RID: 2128 RVA: 0x0002E6BC File Offset: 0x0002C8BC
			public void CopyTo(Array array, int index)
			{
				for (int i = 0; i < this.list.Count; i++)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)this.list[i];
					if (this.isKeyList)
					{
						array.SetValue(dictionaryEntry.Key, index + i);
					}
					else
					{
						array.SetValue(dictionaryEntry.Value, index + i);
					}
				}
			}

			// Token: 0x06000851 RID: 2129 RVA: 0x00007E6B File Offset: 0x0000606B
			public IEnumerator GetEnumerator()
			{
				return new OrderedDictionary.OrderedCollection.OrderedCollectionEnumerator(this.list.GetEnumerator(), this.isKeyList);
			}

			// Token: 0x04000240 RID: 576
			private ArrayList list;

			// Token: 0x04000241 RID: 577
			private bool isKeyList;

			// Token: 0x020000C2 RID: 194
			private class OrderedCollectionEnumerator : IEnumerator
			{
				// Token: 0x06000852 RID: 2130 RVA: 0x00007E83 File Offset: 0x00006083
				public OrderedCollectionEnumerator(IEnumerator listEnumerator, bool isKeyList)
				{
					this.listEnumerator = listEnumerator;
					this.isKeyList = isKeyList;
				}

				// Token: 0x170001CD RID: 461
				// (get) Token: 0x06000853 RID: 2131 RVA: 0x0002E728 File Offset: 0x0002C928
				public object Current
				{
					get
					{
						DictionaryEntry dictionaryEntry = (DictionaryEntry)this.listEnumerator.Current;
						return (!this.isKeyList) ? dictionaryEntry.Value : dictionaryEntry.Key;
					}
				}

				// Token: 0x06000854 RID: 2132 RVA: 0x00007E99 File Offset: 0x00006099
				public bool MoveNext()
				{
					return this.listEnumerator.MoveNext();
				}

				// Token: 0x06000855 RID: 2133 RVA: 0x00007EA6 File Offset: 0x000060A6
				public void Reset()
				{
					this.listEnumerator.Reset();
				}

				// Token: 0x04000242 RID: 578
				private bool isKeyList;

				// Token: 0x04000243 RID: 579
				private IEnumerator listEnumerator;
			}
		}
	}
}
