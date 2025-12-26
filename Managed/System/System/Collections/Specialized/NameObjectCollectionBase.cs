using System;
using System.Runtime.Serialization;

namespace System.Collections.Specialized
{
	/// <summary>Provides the abstract base class for a collection of associated <see cref="T:System.String" /> keys and <see cref="T:System.Object" /> values that can be accessed either with the key or with the index.</summary>
	// Token: 0x020000BA RID: 186
	[Serializable]
	public abstract class NameObjectCollectionBase : ICollection, IEnumerable, IDeserializationCallback, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> class that is empty.</summary>
		// Token: 0x060007D7 RID: 2007 RVA: 0x00007888 File Offset: 0x00005A88
		protected NameObjectCollectionBase()
		{
			this.m_readonly = false;
			this.m_hashprovider = CaseInsensitiveHashCodeProvider.DefaultInvariant;
			this.m_comparer = CaseInsensitiveComparer.DefaultInvariant;
			this.m_defCapacity = 0;
			this.Init();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> class that is empty, has the specified initial capacity, and uses the default hash code provider and the default comparer.</summary>
		/// <param name="capacity">The approximate number of entries that the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance can initially contain.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="capacity" /> is less than zero. </exception>
		// Token: 0x060007D8 RID: 2008 RVA: 0x000078BA File Offset: 0x00005ABA
		protected NameObjectCollectionBase(int capacity)
		{
			this.m_readonly = false;
			this.m_hashprovider = CaseInsensitiveHashCodeProvider.DefaultInvariant;
			this.m_comparer = CaseInsensitiveComparer.DefaultInvariant;
			this.m_defCapacity = capacity;
			this.Init();
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000078EC File Offset: 0x00005AEC
		internal NameObjectCollectionBase(IEqualityComparer equalityComparer, IComparer comparer, IHashCodeProvider hcp)
		{
			this.equality_comparer = equalityComparer;
			this.m_comparer = comparer;
			this.m_hashprovider = hcp;
			this.m_readonly = false;
			this.m_defCapacity = 0;
			this.Init();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> class that is empty, has the default initial capacity, and uses the specified <see cref="T:System.Collections.IEqualityComparer" /> object.</summary>
		/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object to use to determine whether two keys are equal and to generate hash codes for the keys in the collection.</param>
		// Token: 0x060007DA RID: 2010 RVA: 0x0002D688 File Offset: 0x0002B888
		protected NameObjectCollectionBase(IEqualityComparer equalityComparer)
		{
			IEqualityComparer equalityComparer2;
			if (equalityComparer == null)
			{
				IEqualityComparer invariantCultureIgnoreCase = StringComparer.InvariantCultureIgnoreCase;
				equalityComparer2 = invariantCultureIgnoreCase;
			}
			else
			{
				equalityComparer2 = equalityComparer;
			}
			this..ctor(equalityComparer2, null, null);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> class that is empty, has the default initial capacity, and uses the specified hash code provider and the specified comparer.</summary>
		/// <param name="hashProvider">The <see cref="T:System.Collections.IHashCodeProvider" /> that will supply the hash codes for all keys in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> to use to determine whether two keys are equal.</param>
		// Token: 0x060007DB RID: 2011 RVA: 0x0000791D File Offset: 0x00005B1D
		[Obsolete("Use NameObjectCollectionBase(IEqualityComparer)")]
		protected NameObjectCollectionBase(IHashCodeProvider hashProvider, IComparer comparer)
		{
			this.m_comparer = comparer;
			this.m_hashprovider = hashProvider;
			this.m_readonly = false;
			this.m_defCapacity = 0;
			this.Init();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> class that is serializable and uses the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the new <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source and destination of the serialized stream associated with the new <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</param>
		// Token: 0x060007DC RID: 2012 RVA: 0x00007947 File Offset: 0x00005B47
		protected NameObjectCollectionBase(SerializationInfo info, StreamingContext context)
		{
			this.infoCopy = info;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> class that is empty, has the specified initial capacity, and uses the specified <see cref="T:System.Collections.IEqualityComparer" /> object.</summary>
		/// <param name="capacity">The approximate number of entries that the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> object can initially contain.</param>
		/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object to use to determine whether two keys are equal and to generate hash codes for the keys in the collection.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="capacity" /> is less than zero.</exception>
		// Token: 0x060007DD RID: 2013 RVA: 0x0002D6B0 File Offset: 0x0002B8B0
		protected NameObjectCollectionBase(int capacity, IEqualityComparer equalityComparer)
		{
			this.m_readonly = false;
			IEqualityComparer equalityComparer2;
			if (equalityComparer == null)
			{
				IEqualityComparer invariantCultureIgnoreCase = StringComparer.InvariantCultureIgnoreCase;
				equalityComparer2 = invariantCultureIgnoreCase;
			}
			else
			{
				equalityComparer2 = equalityComparer;
			}
			this.equality_comparer = equalityComparer2;
			this.m_defCapacity = capacity;
			this.Init();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> class that is empty, has the specified initial capacity and uses the specified hash code provider and the specified comparer.</summary>
		/// <param name="capacity">The approximate number of entries that the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance can initially contain.</param>
		/// <param name="hashProvider">The <see cref="T:System.Collections.IHashCodeProvider" /> that will supply the hash codes for all keys in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> to use to determine whether two keys are equal.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="capacity" /> is less than zero.</exception>
		// Token: 0x060007DE RID: 2014 RVA: 0x00007956 File Offset: 0x00005B56
		[Obsolete("Use NameObjectCollectionBase(int,IEqualityComparer)")]
		protected NameObjectCollectionBase(int capacity, IHashCodeProvider hashProvider, IComparer comparer)
		{
			this.m_readonly = false;
			this.m_hashprovider = hashProvider;
			this.m_comparer = comparer;
			this.m_defCapacity = capacity;
			this.Init();
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> object is synchronized (thread safe).</summary>
		/// <returns>true if access to the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> object is synchronized (thread safe); otherwise, false. The default is false.</returns>
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00002AA1 File Offset: 0x00000CA1
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> object.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> object.</returns>
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x000021CB File Offset: 0x000003CB
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Copies the entire <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is multidimensional.-or-The number of elements in the source <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
		// Token: 0x060007E1 RID: 2017 RVA: 0x00007980 File Offset: 0x00005B80
		void ICollection.CopyTo(Array array, int index)
		{
			((ICollection)this.Keys).CopyTo(array, index);
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x0000798F File Offset: 0x00005B8F
		internal IEqualityComparer EqualityComparer
		{
			get
			{
				return this.equality_comparer;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00007997 File Offset: 0x00005B97
		internal IComparer Comparer
		{
			get
			{
				return this.m_comparer;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0000799F File Offset: 0x00005B9F
		internal IHashCodeProvider HashCodeProvider
		{
			get
			{
				return this.m_hashprovider;
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0002D6F0 File Offset: 0x0002B8F0
		private void Init()
		{
			if (this.equality_comparer != null)
			{
				this.m_ItemsContainer = new Hashtable(this.m_defCapacity, this.equality_comparer);
			}
			else
			{
				this.m_ItemsContainer = new Hashtable(this.m_defCapacity, this.m_hashprovider, this.m_comparer);
			}
			this.m_ItemsArray = new ArrayList();
			this.m_NullKeyItem = null;
		}

		/// <summary>Gets a <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" /> instance that contains all the keys in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <returns>A <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" /> instance that contains all the keys in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</returns>
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x000079A7 File Offset: 0x00005BA7
		public virtual NameObjectCollectionBase.KeysCollection Keys
		{
			get
			{
				if (this.keyscoll == null)
				{
					this.keyscoll = new NameObjectCollectionBase.KeysCollection(this);
				}
				return this.keyscoll;
			}
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</returns>
		// Token: 0x060007E7 RID: 2023 RVA: 0x000079C6 File Offset: 0x00005BC6
		public virtual IEnumerator GetEnumerator()
		{
			return new NameObjectCollectionBase._KeysEnumerator(this);
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data needed to serialize the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null.</exception>
		// Token: 0x060007E8 RID: 2024 RVA: 0x0002D754 File Offset: 0x0002B954
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			int count = this.Count;
			string[] array = new string[count];
			object[] array2 = new object[count];
			int num = 0;
			foreach (object obj in this.m_ItemsArray)
			{
				NameObjectCollectionBase._Item item = (NameObjectCollectionBase._Item)obj;
				array[num] = item.key;
				array2[num] = item.value;
				num++;
			}
			if (this.equality_comparer != null)
			{
				info.AddValue("KeyComparer", this.equality_comparer, typeof(IEqualityComparer));
				info.AddValue("Version", 4, typeof(int));
			}
			else
			{
				info.AddValue("HashProvider", this.m_hashprovider, typeof(IHashCodeProvider));
				info.AddValue("Comparer", this.m_comparer, typeof(IComparer));
				info.AddValue("Version", 2, typeof(int));
			}
			info.AddValue("ReadOnly", this.m_readonly);
			info.AddValue("Count", count);
			info.AddValue("Keys", array, typeof(string[]));
			info.AddValue("Values", array2, typeof(object[]));
		}

		/// <summary>Gets the number of key/value pairs contained in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</returns>
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x000079CE File Offset: 0x00005BCE
		public virtual int Count
		{
			get
			{
				return this.m_ItemsArray.Count;
			}
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event.</param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance is invalid.</exception>
		// Token: 0x060007EA RID: 2026 RVA: 0x0002D8D8 File Offset: 0x0002BAD8
		public virtual void OnDeserialization(object sender)
		{
			SerializationInfo serializationInfo = this.infoCopy;
			if (serializationInfo == null)
			{
				return;
			}
			this.infoCopy = null;
			this.m_hashprovider = (IHashCodeProvider)serializationInfo.GetValue("HashProvider", typeof(IHashCodeProvider));
			if (this.m_hashprovider == null)
			{
				this.equality_comparer = (IEqualityComparer)serializationInfo.GetValue("KeyComparer", typeof(IEqualityComparer));
			}
			else
			{
				this.m_comparer = (IComparer)serializationInfo.GetValue("Comparer", typeof(IComparer));
				if (this.m_comparer == null)
				{
					throw new SerializationException("The comparer is null");
				}
			}
			this.m_readonly = serializationInfo.GetBoolean("ReadOnly");
			string[] array = (string[])serializationInfo.GetValue("Keys", typeof(string[]));
			if (array == null)
			{
				throw new SerializationException("keys is null");
			}
			object[] array2 = (object[])serializationInfo.GetValue("Values", typeof(object[]));
			if (array2 == null)
			{
				throw new SerializationException("values is null");
			}
			this.Init();
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				this.BaseAdd(array[i], array2[i]);
			}
		}

		/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance is read-only.</summary>
		/// <returns>true if the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance is read-only; otherwise, false.</returns>
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x000079DB File Offset: 0x00005BDB
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x000079E3 File Offset: 0x00005BE3
		protected bool IsReadOnly
		{
			get
			{
				return this.m_readonly;
			}
			set
			{
				this.m_readonly = value;
			}
		}

		/// <summary>Adds an entry with the specified key and value into the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <param name="name">The <see cref="T:System.String" /> key of the entry to add. The key can be null.</param>
		/// <param name="value">The <see cref="T:System.Object" /> value of the entry to add. The value can be null.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only. </exception>
		// Token: 0x060007ED RID: 2029 RVA: 0x0002DA18 File Offset: 0x0002BC18
		protected void BaseAdd(string name, object value)
		{
			if (this.IsReadOnly)
			{
				throw new NotSupportedException("Collection is read-only");
			}
			NameObjectCollectionBase._Item item = new NameObjectCollectionBase._Item(name, value);
			if (name == null)
			{
				if (this.m_NullKeyItem == null)
				{
					this.m_NullKeyItem = item;
				}
			}
			else if (this.m_ItemsContainer[name] == null)
			{
				this.m_ItemsContainer.Add(name, item);
			}
			this.m_ItemsArray.Add(item);
		}

		/// <summary>Removes all entries from the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x060007EE RID: 2030 RVA: 0x000079EC File Offset: 0x00005BEC
		protected void BaseClear()
		{
			if (this.IsReadOnly)
			{
				throw new NotSupportedException("Collection is read-only");
			}
			this.Init();
		}

		/// <summary>Gets the value of the entry at the specified index of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the value of the entry at the specified index.</returns>
		/// <param name="index">The zero-based index of the value to get.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is outside the valid range of indexes for the collection. </exception>
		// Token: 0x060007EF RID: 2031 RVA: 0x00007A0A File Offset: 0x00005C0A
		protected object BaseGet(int index)
		{
			return ((NameObjectCollectionBase._Item)this.m_ItemsArray[index]).value;
		}

		/// <summary>Gets the value of the first entry with the specified key from the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the value of the first entry with the specified key, if found; otherwise, null.</returns>
		/// <param name="name">The <see cref="T:System.String" /> key of the entry to get. The key can be null.</param>
		// Token: 0x060007F0 RID: 2032 RVA: 0x0002DA8C File Offset: 0x0002BC8C
		protected object BaseGet(string name)
		{
			NameObjectCollectionBase._Item item = this.FindFirstMatchedItem(name);
			if (item == null)
			{
				return null;
			}
			return item.value;
		}

		/// <summary>Returns a <see cref="T:System.String" /> array that contains all the keys in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <returns>A <see cref="T:System.String" /> array that contains all the keys in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</returns>
		// Token: 0x060007F1 RID: 2033 RVA: 0x0002DAB0 File Offset: 0x0002BCB0
		protected string[] BaseGetAllKeys()
		{
			int count = this.m_ItemsArray.Count;
			string[] array = new string[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = this.BaseGetKey(i);
			}
			return array;
		}

		/// <summary>Returns an <see cref="T:System.Object" /> array that contains all the values in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <returns>An <see cref="T:System.Object" /> array that contains all the values in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</returns>
		// Token: 0x060007F2 RID: 2034 RVA: 0x0002DAF0 File Offset: 0x0002BCF0
		protected object[] BaseGetAllValues()
		{
			int count = this.m_ItemsArray.Count;
			object[] array = new object[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = this.BaseGet(i);
			}
			return array;
		}

		/// <summary>Returns an array of the specified type that contains all the values in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <returns>An array of the specified type that contains all the values in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</returns>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of array to return.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> is not a valid <see cref="T:System.Type" />. </exception>
		// Token: 0x060007F3 RID: 2035 RVA: 0x0002DB30 File Offset: 0x0002BD30
		protected object[] BaseGetAllValues(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("'type' argument can't be null");
			}
			int count = this.m_ItemsArray.Count;
			object[] array = (object[])Array.CreateInstance(type, count);
			for (int i = 0; i < count; i++)
			{
				array[i] = this.BaseGet(i);
			}
			return array;
		}

		/// <summary>Gets the key of the entry at the specified index of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <returns>A <see cref="T:System.String" /> that represents the key of the entry at the specified index.</returns>
		/// <param name="index">The zero-based index of the key to get.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is outside the valid range of indexes for the collection. </exception>
		// Token: 0x060007F4 RID: 2036 RVA: 0x00007A22 File Offset: 0x00005C22
		protected string BaseGetKey(int index)
		{
			return ((NameObjectCollectionBase._Item)this.m_ItemsArray[index]).key;
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance contains entries whose keys are not null.</summary>
		/// <returns>true if the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance contains entries whose keys are not null; otherwise, false.</returns>
		// Token: 0x060007F5 RID: 2037 RVA: 0x00007A3A File Offset: 0x00005C3A
		protected bool BaseHasKeys()
		{
			return this.m_ItemsContainer.Count > 0;
		}

		/// <summary>Removes the entries with the specified key from the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <param name="name">The <see cref="T:System.String" /> key of the entries to remove. The key can be null.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only. </exception>
		// Token: 0x060007F6 RID: 2038 RVA: 0x0002DB84 File Offset: 0x0002BD84
		protected void BaseRemove(string name)
		{
			if (this.IsReadOnly)
			{
				throw new NotSupportedException("Collection is read-only");
			}
			if (name != null)
			{
				this.m_ItemsContainer.Remove(name);
			}
			else
			{
				this.m_NullKeyItem = null;
			}
			int num = this.m_ItemsArray.Count;
			int i = 0;
			while (i < num)
			{
				string text = this.BaseGetKey(i);
				if (this.Equals(text, name))
				{
					this.m_ItemsArray.RemoveAt(i);
					num--;
				}
				else
				{
					i++;
				}
			}
		}

		/// <summary>Removes the entry at the specified index of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <param name="index">The zero-based index of the entry to remove.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is outside the valid range of indexes for the collection.</exception>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x060007F7 RID: 2039 RVA: 0x0002DC10 File Offset: 0x0002BE10
		protected void BaseRemoveAt(int index)
		{
			if (this.IsReadOnly)
			{
				throw new NotSupportedException("Collection is read-only");
			}
			string text = this.BaseGetKey(index);
			if (text != null)
			{
				this.m_ItemsContainer.Remove(text);
			}
			else
			{
				this.m_NullKeyItem = null;
			}
			this.m_ItemsArray.RemoveAt(index);
		}

		/// <summary>Sets the value of the entry at the specified index of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <param name="index">The zero-based index of the entry to set.</param>
		/// <param name="value">The <see cref="T:System.Object" /> that represents the new value of the entry to set. The value can be null.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is outside the valid range of indexes for the collection.</exception>
		// Token: 0x060007F8 RID: 2040 RVA: 0x0002DC68 File Offset: 0x0002BE68
		protected void BaseSet(int index, object value)
		{
			if (this.IsReadOnly)
			{
				throw new NotSupportedException("Collection is read-only");
			}
			NameObjectCollectionBase._Item item = (NameObjectCollectionBase._Item)this.m_ItemsArray[index];
			item.value = value;
		}

		/// <summary>Sets the value of the first entry with the specified key in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance, if found; otherwise, adds an entry with the specified key and value into the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <param name="name">The <see cref="T:System.String" /> key of the entry to set. The key can be null.</param>
		/// <param name="value">The <see cref="T:System.Object" /> that represents the new value of the entry to set. The value can be null.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only. </exception>
		// Token: 0x060007F9 RID: 2041 RVA: 0x0002DCA4 File Offset: 0x0002BEA4
		protected void BaseSet(string name, object value)
		{
			if (this.IsReadOnly)
			{
				throw new NotSupportedException("Collection is read-only");
			}
			NameObjectCollectionBase._Item item = this.FindFirstMatchedItem(name);
			if (item != null)
			{
				item.value = value;
			}
			else
			{
				this.BaseAdd(name, value);
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00007A4A File Offset: 0x00005C4A
		[global::System.MonoTODO]
		private NameObjectCollectionBase._Item FindFirstMatchedItem(string name)
		{
			if (name != null)
			{
				return (NameObjectCollectionBase._Item)this.m_ItemsContainer[name];
			}
			return this.m_NullKeyItem;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00007A6A File Offset: 0x00005C6A
		internal bool Equals(string s1, string s2)
		{
			if (this.m_comparer != null)
			{
				return this.m_comparer.Compare(s1, s2) == 0;
			}
			return this.equality_comparer.Equals(s1, s2);
		}

		// Token: 0x04000228 RID: 552
		private Hashtable m_ItemsContainer;

		// Token: 0x04000229 RID: 553
		private NameObjectCollectionBase._Item m_NullKeyItem;

		// Token: 0x0400022A RID: 554
		private ArrayList m_ItemsArray;

		// Token: 0x0400022B RID: 555
		private IHashCodeProvider m_hashprovider;

		// Token: 0x0400022C RID: 556
		private IComparer m_comparer;

		// Token: 0x0400022D RID: 557
		private int m_defCapacity;

		// Token: 0x0400022E RID: 558
		private bool m_readonly;

		// Token: 0x0400022F RID: 559
		private SerializationInfo infoCopy;

		// Token: 0x04000230 RID: 560
		private NameObjectCollectionBase.KeysCollection keyscoll;

		// Token: 0x04000231 RID: 561
		private IEqualityComparer equality_comparer;

		// Token: 0x020000BB RID: 187
		internal class _Item
		{
			// Token: 0x060007FC RID: 2044 RVA: 0x00007A95 File Offset: 0x00005C95
			public _Item(string key, object value)
			{
				this.key = key;
				this.value = value;
			}

			// Token: 0x04000232 RID: 562
			public string key;

			// Token: 0x04000233 RID: 563
			public object value;
		}

		// Token: 0x020000BC RID: 188
		[Serializable]
		internal class _KeysEnumerator : IEnumerator
		{
			// Token: 0x060007FD RID: 2045 RVA: 0x00007AAB File Offset: 0x00005CAB
			internal _KeysEnumerator(NameObjectCollectionBase collection)
			{
				this.m_collection = collection;
				this.Reset();
			}

			// Token: 0x170001B5 RID: 437
			// (get) Token: 0x060007FE RID: 2046 RVA: 0x00007AC0 File Offset: 0x00005CC0
			public object Current
			{
				get
				{
					if (this.m_position < this.m_collection.Count || this.m_position < 0)
					{
						return this.m_collection.BaseGetKey(this.m_position);
					}
					throw new InvalidOperationException();
				}
			}

			// Token: 0x060007FF RID: 2047 RVA: 0x0002DCEC File Offset: 0x0002BEEC
			public bool MoveNext()
			{
				return ++this.m_position < this.m_collection.Count;
			}

			// Token: 0x06000800 RID: 2048 RVA: 0x00007AFB File Offset: 0x00005CFB
			public void Reset()
			{
				this.m_position = -1;
			}

			// Token: 0x04000234 RID: 564
			private NameObjectCollectionBase m_collection;

			// Token: 0x04000235 RID: 565
			private int m_position;
		}

		/// <summary>Represents a collection of the <see cref="T:System.String" /> keys of a collection. </summary>
		// Token: 0x020000BD RID: 189
		[Serializable]
		public class KeysCollection : ICollection, IEnumerable
		{
			// Token: 0x06000801 RID: 2049 RVA: 0x00007B04 File Offset: 0x00005D04
			internal KeysCollection(NameObjectCollectionBase collection)
			{
				this.m_collection = collection;
			}

			/// <summary>Copies the entire <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
			/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
			/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
			/// <exception cref="T:System.ArgumentNullException">
			///   <paramref name="array" /> is null. </exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">
			///   <paramref name="index" /> is less than zero. </exception>
			/// <exception cref="T:System.ArgumentException">
			///   <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
			/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
			// Token: 0x06000802 RID: 2050 RVA: 0x0002DD18 File Offset: 0x0002BF18
			void ICollection.CopyTo(Array array, int arrayIndex)
			{
				ArrayList itemsArray = this.m_collection.m_ItemsArray;
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (arrayIndex < 0)
				{
					throw new ArgumentOutOfRangeException("arrayIndex");
				}
				if (array.Length > 0 && arrayIndex >= array.Length)
				{
					throw new ArgumentException("arrayIndex is equal to or greater than array.Length");
				}
				if (arrayIndex + itemsArray.Count > array.Length)
				{
					throw new ArgumentException("Not enough room from arrayIndex to end of array for this KeysCollection");
				}
				if (array != null && array.Rank > 1)
				{
					throw new ArgumentException("array is multidimensional");
				}
				object[] array2 = (object[])array;
				int i = 0;
				while (i < itemsArray.Count)
				{
					array2[arrayIndex] = ((NameObjectCollectionBase._Item)itemsArray[i]).key;
					i++;
					arrayIndex++;
				}
			}

			/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" /> is synchronized (thread safe).</summary>
			/// <returns>true if access to the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" /> is synchronized (thread safe); otherwise, false. The default is false.</returns>
			// Token: 0x170001B6 RID: 438
			// (get) Token: 0x06000803 RID: 2051 RVA: 0x00002AA1 File Offset: 0x00000CA1
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" />.</summary>
			/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" />.</returns>
			// Token: 0x170001B7 RID: 439
			// (get) Token: 0x06000804 RID: 2052 RVA: 0x00007B13 File Offset: 0x00005D13
			object ICollection.SyncRoot
			{
				get
				{
					return this.m_collection;
				}
			}

			/// <summary>Gets the key at the specified index of the collection.</summary>
			/// <returns>A <see cref="T:System.String" /> that contains the key at the specified index of the collection.</returns>
			/// <param name="index">The zero-based index of the key to get from the collection. </param>
			/// <exception cref="T:System.ArgumentOutOfRangeException">
			///   <paramref name="index" /> is outside the valid range of indexes for the collection. </exception>
			// Token: 0x06000805 RID: 2053 RVA: 0x00007B1B File Offset: 0x00005D1B
			public virtual string Get(int index)
			{
				return this.m_collection.BaseGetKey(index);
			}

			/// <summary>Gets the number of keys in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" />.</summary>
			/// <returns>The number of keys in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" />.</returns>
			// Token: 0x170001B8 RID: 440
			// (get) Token: 0x06000806 RID: 2054 RVA: 0x00007B29 File Offset: 0x00005D29
			public int Count
			{
				get
				{
					return this.m_collection.Count;
				}
			}

			/// <summary>Gets the entry at the specified index of the collection.</summary>
			/// <returns>The <see cref="T:System.String" /> key of the entry at the specified index of the collection.</returns>
			/// <param name="index">The zero-based index of the entry to locate in the collection. </param>
			/// <exception cref="T:System.ArgumentOutOfRangeException">
			///   <paramref name="index" /> is outside the valid range of indexes for the collection. </exception>
			// Token: 0x170001B9 RID: 441
			public string this[int index]
			{
				get
				{
					return this.Get(index);
				}
			}

			/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" />.</summary>
			/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" />.</returns>
			// Token: 0x06000808 RID: 2056 RVA: 0x00007B3F File Offset: 0x00005D3F
			public IEnumerator GetEnumerator()
			{
				return new NameObjectCollectionBase._KeysEnumerator(this.m_collection);
			}

			// Token: 0x04000236 RID: 566
			private NameObjectCollectionBase m_collection;
		}
	}
}
