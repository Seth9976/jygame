using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	/// <summary>Represents a collection of <see cref="T:System.ComponentModel.EventDescriptor" /> objects.</summary>
	// Token: 0x0200014C RID: 332
	[ComVisible(true)]
	public class EventDescriptorCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x06000C19 RID: 3097 RVA: 0x0000A7A5 File Offset: 0x000089A5
		private EventDescriptorCollection()
		{
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0000A7B8 File Offset: 0x000089B8
		internal EventDescriptorCollection(ArrayList list)
		{
			this.eventList = list;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EventDescriptorCollection" /> class with the given array of <see cref="T:System.ComponentModel.EventDescriptor" /> objects.</summary>
		/// <param name="events">An array of type <see cref="T:System.ComponentModel.EventDescriptor" /> that provides the events for this collection. </param>
		// Token: 0x06000C1B RID: 3099 RVA: 0x0000A7D2 File Offset: 0x000089D2
		public EventDescriptorCollection(EventDescriptor[] events)
			: this(events, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EventDescriptorCollection" /> class with the given array of <see cref="T:System.ComponentModel.EventDescriptor" /> objects. The collection is optionally read-only.</summary>
		/// <param name="events">An array of type <see cref="T:System.ComponentModel.EventDescriptor" /> that provides the events for this collection. </param>
		/// <param name="readOnly">true to specify a read-only collection; otherwise, false.</param>
		// Token: 0x06000C1C RID: 3100 RVA: 0x00031AB0 File Offset: 0x0002FCB0
		public EventDescriptorCollection(EventDescriptor[] events, bool readOnly)
		{
			this.isReadOnly = readOnly;
			if (events == null)
			{
				return;
			}
			for (int i = 0; i < events.Length; i++)
			{
				this.Add(events[i]);
			}
		}

		/// <summary>Removes all the items from the collection.</summary>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06000C1E RID: 3102 RVA: 0x0000A7EA File Offset: 0x000089EA
		void IList.Clear()
		{
			this.Clear();
		}

		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		// Token: 0x06000C1F RID: 3103 RVA: 0x0000A7F2 File Offset: 0x000089F2
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Removes the item at the specified index.</summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06000C20 RID: 3104 RVA: 0x0000A7FA File Offset: 0x000089FA
		void IList.RemoveAt(int index)
		{
			this.RemoveAt(index);
		}

		/// <summary>Gets the number of elements contained in the collection.</summary>
		/// <returns>The number of elements contained in the collection.</returns>
		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x0000A803 File Offset: 0x00008A03
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}

		/// <summary>Adds an item to the collection.</summary>
		/// <returns>The position into which the new element was inserted.</returns>
		/// <param name="value">The <see cref="T:System.Object" /> to add to the collection.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06000C22 RID: 3106 RVA: 0x0000A80B File Offset: 0x00008A0B
		int IList.Add(object value)
		{
			return this.Add((EventDescriptor)value);
		}

		/// <summary>Determines whether the collection contains a specific value.</summary>
		/// <returns>true if the <see cref="T:System.Object" /> is found in the collection; otherwise, false.</returns>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the collection.</param>
		// Token: 0x06000C23 RID: 3107 RVA: 0x0000A819 File Offset: 0x00008A19
		bool IList.Contains(object value)
		{
			return this.Contains((EventDescriptor)value);
		}

		/// <summary>Determines the index of a specific item in the collection.</summary>
		/// <returns>The index of <paramref name="value" /> if found in the list; otherwise, -1.</returns>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the collection.</param>
		// Token: 0x06000C24 RID: 3108 RVA: 0x0000A827 File Offset: 0x00008A27
		int IList.IndexOf(object value)
		{
			return this.IndexOf((EventDescriptor)value);
		}

		/// <summary>Inserts an item to the collection at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to insert into the collection.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06000C25 RID: 3109 RVA: 0x0000A835 File Offset: 0x00008A35
		void IList.Insert(int index, object value)
		{
			this.Insert(index, (EventDescriptor)value);
		}

		/// <summary>Removes the first occurrence of a specific object from the collection.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to remove from the collection.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06000C26 RID: 3110 RVA: 0x0000A844 File Offset: 0x00008A44
		void IList.Remove(object value)
		{
			this.Remove((EventDescriptor)value);
		}

		/// <summary>Gets a value indicating whether the collection has a fixed size.</summary>
		/// <returns>true if the collection has a fixed size; otherwise, false.</returns>
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x0000A852 File Offset: 0x00008A52
		bool IList.IsFixedSize
		{
			get
			{
				return this.isReadOnly;
			}
		}

		/// <summary>Gets a value indicating whether the collection is read-only.</summary>
		/// <returns>true if the collection is read-only; otherwise, false.</returns>
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x0000A852 File Offset: 0x00008A52
		bool IList.IsReadOnly
		{
			get
			{
				return this.isReadOnly;
			}
		}

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <returns>The element at the specified index.</returns>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="index" /> is less than 0. -or-<paramref name="index" /> is equal to or greater than <see cref="P:System.ComponentModel.EventDescriptorCollection.Count" />.</exception>
		// Token: 0x170002BE RID: 702
		object IList.this[int index]
		{
			get
			{
				return this.eventList[index];
			}
			set
			{
				if (this.isReadOnly)
				{
					throw new NotSupportedException("The collection is read-only");
				}
				this.eventList[index] = value;
			}
		}

		/// <summary>Copies the elements of the collection to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from collection. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		// Token: 0x06000C2B RID: 3115 RVA: 0x0000A88D File Offset: 0x00008A8D
		void ICollection.CopyTo(Array array, int index)
		{
			this.eventList.CopyTo(array, index);
		}

		/// <summary>Gets a value indicating whether access to the collection is synchronized.</summary>
		/// <returns>true if access to the collection is synchronized; otherwise, false.</returns>
		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x00002AA1 File Offset: 0x00000CA1
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>An object that can be used to synchronize access to the collection.</returns>
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00002A97 File Offset: 0x00000C97
		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		/// <summary>Adds an <see cref="T:System.ComponentModel.EventDescriptor" /> to the end of the collection.</summary>
		/// <returns>The position of the <see cref="T:System.ComponentModel.EventDescriptor" /> within the collection.</returns>
		/// <param name="value">An <see cref="T:System.ComponentModel.EventDescriptor" /> to add to the collection. </param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06000C2E RID: 3118 RVA: 0x0000A89C File Offset: 0x00008A9C
		public int Add(EventDescriptor value)
		{
			if (this.isReadOnly)
			{
				throw new NotSupportedException("The collection is read-only");
			}
			return this.eventList.Add(value);
		}

		/// <summary>Removes all objects from the collection.</summary>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06000C2F RID: 3119 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		public void Clear()
		{
			if (this.isReadOnly)
			{
				throw new NotSupportedException("The collection is read-only");
			}
			this.eventList.Clear();
		}

		/// <summary>Returns whether the collection contains the given <see cref="T:System.ComponentModel.EventDescriptor" />.</summary>
		/// <returns>true if the collection contains the <paramref name="value" /> parameter given; otherwise, false.</returns>
		/// <param name="value">The <see cref="T:System.ComponentModel.EventDescriptor" /> to find within the collection. </param>
		// Token: 0x06000C30 RID: 3120 RVA: 0x0000A8E3 File Offset: 0x00008AE3
		public bool Contains(EventDescriptor value)
		{
			return this.eventList.Contains(value);
		}

		/// <summary>Gets the description of the event with the specified name in the collection.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.EventDescriptor" /> with the specified name, or null if the event does not exist.</returns>
		/// <param name="name">The name of the event to get from the collection. </param>
		/// <param name="ignoreCase">true if you want to ignore the case of the event; otherwise, false. </param>
		// Token: 0x06000C31 RID: 3121 RVA: 0x00031AFC File Offset: 0x0002FCFC
		public virtual EventDescriptor Find(string name, bool ignoreCase)
		{
			foreach (object obj in this.eventList)
			{
				EventDescriptor eventDescriptor = (EventDescriptor)obj;
				if (ignoreCase)
				{
					if (string.Compare(name, eventDescriptor.Name, StringComparison.OrdinalIgnoreCase) == 0)
					{
						return eventDescriptor;
					}
				}
				else if (string.Compare(name, eventDescriptor.Name, StringComparison.Ordinal) == 0)
				{
					return eventDescriptor;
				}
			}
			return null;
		}

		/// <summary>Gets an enumerator for this <see cref="T:System.ComponentModel.EventDescriptorCollection" />.</summary>
		/// <returns>An enumerator that implements <see cref="T:System.Collections.IEnumerator" />.</returns>
		// Token: 0x06000C32 RID: 3122 RVA: 0x0000A8F1 File Offset: 0x00008AF1
		public IEnumerator GetEnumerator()
		{
			return this.eventList.GetEnumerator();
		}

		/// <summary>Returns the index of the given <see cref="T:System.ComponentModel.EventDescriptor" />.</summary>
		/// <returns>The index of the given <see cref="T:System.ComponentModel.EventDescriptor" /> within the collection.</returns>
		/// <param name="value">The <see cref="T:System.ComponentModel.EventDescriptor" /> to find within the collection. </param>
		// Token: 0x06000C33 RID: 3123 RVA: 0x0000A8FE File Offset: 0x00008AFE
		public int IndexOf(EventDescriptor value)
		{
			return this.eventList.IndexOf(value);
		}

		/// <summary>Inserts an <see cref="T:System.ComponentModel.EventDescriptor" /> to the collection at a specified index.</summary>
		/// <param name="index">The index within the collection in which to insert the <paramref name="value" /> parameter. </param>
		/// <param name="value">An <see cref="T:System.ComponentModel.EventDescriptor" /> to insert into the collection. </param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06000C34 RID: 3124 RVA: 0x0000A90C File Offset: 0x00008B0C
		public void Insert(int index, EventDescriptor value)
		{
			if (this.isReadOnly)
			{
				throw new NotSupportedException("The collection is read-only");
			}
			this.eventList.Insert(index, value);
		}

		/// <summary>Removes the specified <see cref="T:System.ComponentModel.EventDescriptor" /> from the collection.</summary>
		/// <param name="value">The <see cref="T:System.ComponentModel.EventDescriptor" /> to remove from the collection. </param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06000C35 RID: 3125 RVA: 0x0000A931 File Offset: 0x00008B31
		public void Remove(EventDescriptor value)
		{
			if (this.isReadOnly)
			{
				throw new NotSupportedException("The collection is read-only");
			}
			this.eventList.Remove(value);
		}

		/// <summary>Removes the <see cref="T:System.ComponentModel.EventDescriptor" /> at the specified index from the collection.</summary>
		/// <param name="index">The index of the <see cref="T:System.ComponentModel.EventDescriptor" /> to remove. </param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		// Token: 0x06000C36 RID: 3126 RVA: 0x0000A955 File Offset: 0x00008B55
		public void RemoveAt(int index)
		{
			if (this.isReadOnly)
			{
				throw new NotSupportedException("The collection is read-only");
			}
			this.eventList.RemoveAt(index);
		}

		/// <summary>Sorts the members of this <see cref="T:System.ComponentModel.EventDescriptorCollection" />, using the default sort for this collection, which is usually alphabetical.</summary>
		/// <returns>The new <see cref="T:System.ComponentModel.EventDescriptorCollection" />.</returns>
		// Token: 0x06000C37 RID: 3127 RVA: 0x00031B98 File Offset: 0x0002FD98
		public virtual EventDescriptorCollection Sort()
		{
			EventDescriptorCollection eventDescriptorCollection = this.CloneCollection();
			eventDescriptorCollection.InternalSort(null);
			return eventDescriptorCollection;
		}

		/// <summary>Sorts the members of this <see cref="T:System.ComponentModel.EventDescriptorCollection" />, using the specified <see cref="T:System.Collections.IComparer" />.</summary>
		/// <returns>The new <see cref="T:System.ComponentModel.EventDescriptorCollection" />.</returns>
		/// <param name="comparer">An <see cref="T:System.Collections.IComparer" /> to use to sort the <see cref="T:System.ComponentModel.EventDescriptor" /> objects in this collection. </param>
		// Token: 0x06000C38 RID: 3128 RVA: 0x00031BB4 File Offset: 0x0002FDB4
		public virtual EventDescriptorCollection Sort(IComparer comparer)
		{
			EventDescriptorCollection eventDescriptorCollection = this.CloneCollection();
			eventDescriptorCollection.InternalSort(comparer);
			return eventDescriptorCollection;
		}

		/// <summary>Sorts the members of this <see cref="T:System.ComponentModel.EventDescriptorCollection" />, given a specified sort order.</summary>
		/// <returns>The new <see cref="T:System.ComponentModel.EventDescriptorCollection" />.</returns>
		/// <param name="names">An array of strings describing the order in which to sort the <see cref="T:System.ComponentModel.EventDescriptor" /> objects in the collection. </param>
		// Token: 0x06000C39 RID: 3129 RVA: 0x00031BD0 File Offset: 0x0002FDD0
		public virtual EventDescriptorCollection Sort(string[] order)
		{
			EventDescriptorCollection eventDescriptorCollection = this.CloneCollection();
			eventDescriptorCollection.InternalSort(order);
			return eventDescriptorCollection;
		}

		/// <summary>Sorts the members of this <see cref="T:System.ComponentModel.EventDescriptorCollection" />, given a specified sort order and an <see cref="T:System.Collections.IComparer" />.</summary>
		/// <returns>The new <see cref="T:System.ComponentModel.EventDescriptorCollection" />.</returns>
		/// <param name="names">An array of strings describing the order in which to sort the <see cref="T:System.ComponentModel.EventDescriptor" /> objects in the collection. </param>
		/// <param name="comparer">An <see cref="T:System.Collections.IComparer" /> to use to sort the <see cref="T:System.ComponentModel.EventDescriptor" /> objects in this collection. </param>
		// Token: 0x06000C3A RID: 3130 RVA: 0x00031BEC File Offset: 0x0002FDEC
		public virtual EventDescriptorCollection Sort(string[] order, IComparer comparer)
		{
			EventDescriptorCollection eventDescriptorCollection = this.CloneCollection();
			if (order != null)
			{
				ArrayList arrayList = eventDescriptorCollection.ExtractItems(order);
				eventDescriptorCollection.InternalSort(comparer);
				arrayList.AddRange(eventDescriptorCollection.eventList);
				eventDescriptorCollection.eventList = arrayList;
			}
			else
			{
				eventDescriptorCollection.InternalSort(comparer);
			}
			return eventDescriptorCollection;
		}

		/// <summary>Sorts the members of this <see cref="T:System.ComponentModel.EventDescriptorCollection" />, using the specified <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="sorter">A comparer to use to sort the <see cref="T:System.ComponentModel.EventDescriptor" /> objects in this collection. </param>
		// Token: 0x06000C3B RID: 3131 RVA: 0x0000A979 File Offset: 0x00008B79
		protected void InternalSort(IComparer comparer)
		{
			if (comparer == null)
			{
				comparer = MemberDescriptor.DefaultComparer;
			}
			this.eventList.Sort(comparer);
		}

		/// <summary>Sorts the members of this <see cref="T:System.ComponentModel.EventDescriptorCollection" />. The specified order is applied first, followed by the default sort for this collection, which is usually alphabetical.</summary>
		/// <param name="names">An array of strings describing the order in which to sort the <see cref="T:System.ComponentModel.EventDescriptor" /> objects in this collection. </param>
		// Token: 0x06000C3C RID: 3132 RVA: 0x00031C38 File Offset: 0x0002FE38
		protected void InternalSort(string[] order)
		{
			if (order != null)
			{
				ArrayList arrayList = this.ExtractItems(order);
				this.InternalSort(null);
				arrayList.AddRange(this.eventList);
				this.eventList = arrayList;
			}
			else
			{
				this.InternalSort(null);
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00031C7C File Offset: 0x0002FE7C
		private ArrayList ExtractItems(string[] names)
		{
			ArrayList arrayList = new ArrayList(this.eventList.Count);
			object[] array = new object[names.Length];
			for (int i = 0; i < this.eventList.Count; i++)
			{
				EventDescriptor eventDescriptor = (EventDescriptor)this.eventList[i];
				int num = Array.IndexOf<string>(names, eventDescriptor.Name);
				if (num != -1)
				{
					array[num] = eventDescriptor;
					this.eventList.RemoveAt(i);
					i--;
				}
			}
			foreach (object obj in array)
			{
				if (obj != null)
				{
					arrayList.Add(obj);
				}
			}
			return arrayList;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00031D30 File Offset: 0x0002FF30
		private EventDescriptorCollection CloneCollection()
		{
			return new EventDescriptorCollection
			{
				eventList = (ArrayList)this.eventList.Clone()
			};
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00031D5C File Offset: 0x0002FF5C
		internal EventDescriptorCollection Filter(Attribute[] attributes)
		{
			EventDescriptorCollection eventDescriptorCollection = new EventDescriptorCollection();
			foreach (object obj in this.eventList)
			{
				EventDescriptor eventDescriptor = (EventDescriptor)obj;
				if (eventDescriptor.Attributes.Contains(attributes))
				{
					eventDescriptorCollection.eventList.Add(eventDescriptor);
				}
			}
			return eventDescriptorCollection;
		}

		/// <summary>Gets the number of event descriptors in the collection.</summary>
		/// <returns>The number of event descriptors in the collection.</returns>
		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x0000A994 File Offset: 0x00008B94
		public int Count
		{
			get
			{
				return this.eventList.Count;
			}
		}

		/// <summary>Gets or sets the event with the specified name.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.EventDescriptor" /> with the specified name, or null if the event does not exist.</returns>
		/// <param name="name">The name of the <see cref="T:System.ComponentModel.EventDescriptor" /> to get or set. </param>
		// Token: 0x170002C2 RID: 706
		public virtual EventDescriptor this[string name]
		{
			get
			{
				return this.Find(name, false);
			}
		}

		/// <summary>Gets or sets the event with the specified index number.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.EventDescriptor" /> with the specified index number.</returns>
		/// <param name="index">The zero-based index number of the <see cref="T:System.ComponentModel.EventDescriptor" /> to get or set. </param>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="index" /> is not a valid index for <see cref="P:System.ComponentModel.EventDescriptorCollection.Item(System.Int32)" />. </exception>
		// Token: 0x170002C3 RID: 707
		public virtual EventDescriptor this[int index]
		{
			get
			{
				return (EventDescriptor)this.eventList[index];
			}
		}

		// Token: 0x04000379 RID: 889
		private ArrayList eventList = new ArrayList();

		// Token: 0x0400037A RID: 890
		private bool isReadOnly;

		/// <summary>Specifies an empty collection to use, rather than creating a new one with no items. This static field is read-only.</summary>
		// Token: 0x0400037B RID: 891
		public static readonly EventDescriptorCollection Empty = new EventDescriptorCollection(null, true);
	}
}
