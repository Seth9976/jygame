using System;
using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Represents a collection of <see cref="T:System.ComponentModel.ListSortDescription" /> objects.</summary>
	// Token: 0x02000184 RID: 388
	public class ListSortDescriptionCollection : IList, ICollection, IEnumerable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ListSortDescriptionCollection" /> class. </summary>
		// Token: 0x06000D39 RID: 3385 RVA: 0x0000B002 File Offset: 0x00009202
		public ListSortDescriptionCollection()
		{
			this.list = new ArrayList();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ListSortDescriptionCollection" /> class with the specified array of <see cref="T:System.ComponentModel.ListSortDescription" /> objects.</summary>
		/// <param name="sorts">The array of <see cref="T:System.ComponentModel.ListSortDescription" /> objects to be contained in the collection.</param>
		// Token: 0x06000D3A RID: 3386 RVA: 0x00032530 File Offset: 0x00030730
		public ListSortDescriptionCollection(ListSortDescription[] sorts)
		{
			this.list = new ArrayList();
			foreach (ListSortDescription listSortDescription in sorts)
			{
				this.list.Add(listSortDescription);
			}
		}

		/// <summary>Gets the specified <see cref="T:System.ComponentModel.ListSortDescription" />.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.ListSortDescription" /> with the specified index.</returns>
		/// <param name="index">The zero-based index of the <see cref="T:System.ComponentModel.ListSortDescription" />  to get in the collection </param>
		// Token: 0x17000301 RID: 769
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				throw new InvalidOperationException("ListSortDescriptorCollection is read only.");
			}
		}

		/// <summary>Gets a value indicating whether the collection has a fixed size.</summary>
		/// <returns>true in all cases.</returns>
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x0000B02A File Offset: 0x0000922A
		bool IList.IsFixedSize
		{
			get
			{
				return this.list.IsFixedSize;
			}
		}

		/// <summary>Gets a value indicating whether access to the collection is thread safe.</summary>
		/// <returns>true in all cases.</returns>
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x0000B037 File Offset: 0x00009237
		bool ICollection.IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		/// <summary>Gets the current instance that can be used to synchronize access to the collection.</summary>
		/// <returns>The current instance of the <see cref="T:System.ComponentModel.ListSortDescriptionCollection" />.</returns>
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0000B044 File Offset: 0x00009244
		object ICollection.SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		/// <summary>Gets a value indicating whether the collection is read-only.</summary>
		/// <returns>true in all cases.</returns>
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0000B051 File Offset: 0x00009251
		bool IList.IsReadOnly
		{
			get
			{
				return this.list.IsReadOnly;
			}
		}

		/// <summary>Gets a <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		// Token: 0x06000D41 RID: 3393 RVA: 0x0000B05E File Offset: 0x0000925E
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		/// <summary>Adds an item to the collection.</summary>
		/// <returns>The position into which the new element was inserted.</returns>
		/// <param name="value">The item to add to the collection.</param>
		/// <exception cref="T:System.InvalidOperationException">In all cases.</exception>
		// Token: 0x06000D42 RID: 3394 RVA: 0x0000B06B File Offset: 0x0000926B
		int IList.Add(object value)
		{
			return this.list.Add(value);
		}

		/// <summary>Removes all items from the collection.</summary>
		/// <exception cref="T:System.InvalidOperationException">In all cases.</exception>
		// Token: 0x06000D43 RID: 3395 RVA: 0x0000B079 File Offset: 0x00009279
		void IList.Clear()
		{
			this.list.Clear();
		}

		/// <summary>Inserts an item into the collection at a specified index.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.ComponentModel.ListSortDescription" />  to get or set in the collection</param>
		/// <param name="value">The item to insert into the collection.</param>
		/// <exception cref="T:System.InvalidOperationException">In all cases.</exception>
		// Token: 0x06000D44 RID: 3396 RVA: 0x0000B086 File Offset: 0x00009286
		void IList.Insert(int index, object value)
		{
			this.list.Insert(index, value);
		}

		/// <summary>Removes the first occurrence of an item from the collection.</summary>
		/// <param name="value">The item to remove from the collection.</param>
		/// <exception cref="T:System.InvalidOperationException">In all cases.</exception>
		// Token: 0x06000D45 RID: 3397 RVA: 0x0000B095 File Offset: 0x00009295
		void IList.Remove(object value)
		{
			this.list.Remove(value);
		}

		/// <summary>Removes an item from the collection at a specified index.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.ComponentModel.ListSortDescription" />  to remove from the collection</param>
		/// <exception cref="T:System.InvalidOperationException">In all cases.</exception>
		// Token: 0x06000D46 RID: 3398 RVA: 0x0000B0A3 File Offset: 0x000092A3
		void IList.RemoveAt(int index)
		{
			this.list.RemoveAt(index);
		}

		/// <summary>Gets the number of items in the collection.</summary>
		/// <returns>The number of items in the collection.</returns>
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0000B0B1 File Offset: 0x000092B1
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		/// <summary>Gets or sets the specified <see cref="T:System.ComponentModel.ListSortDescription" />.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.ListSortDescription" /> with the specified index.</returns>
		/// <param name="index">The zero-based index of the <see cref="T:System.ComponentModel.ListSortDescription" />  to get or set in the collection. </param>
		/// <exception cref="T:System.InvalidOperationException">An item is set in the <see cref="T:System.ComponentModel.ListSortDescriptionCollection" />, which is read-only.</exception>
		// Token: 0x17000307 RID: 775
		public ListSortDescription this[int index]
		{
			get
			{
				return this.list[index] as ListSortDescription;
			}
			set
			{
				throw new InvalidOperationException("ListSortDescriptorCollection is read only.");
			}
		}

		/// <summary>Determines if the <see cref="T:System.ComponentModel.ListSortDescriptionCollection" /> contains a specific value.</summary>
		/// <returns>true if the <see cref="T:System.Object" /> is found in the collection; otherwise, false. </returns>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the collection.</param>
		// Token: 0x06000D4A RID: 3402 RVA: 0x0000B0D1 File Offset: 0x000092D1
		public bool Contains(object value)
		{
			return this.list.Contains(value);
		}

		/// <summary>Copies the contents of the collection to the specified array, starting at the specified destination array index.</summary>
		/// <param name="array">The destination array for the items copied from the collection.</param>
		/// <param name="index">The index of the destination array at which copying begins.</param>
		// Token: 0x06000D4B RID: 3403 RVA: 0x0000B0DF File Offset: 0x000092DF
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		/// <summary>Returns the index of the specified item in the collection.</summary>
		/// <returns>The index of <paramref name="value" /> if found in the list; otherwise, -1.</returns>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the collection.</param>
		// Token: 0x06000D4C RID: 3404 RVA: 0x0000B0EE File Offset: 0x000092EE
		public int IndexOf(object value)
		{
			return this.list.IndexOf(value);
		}

		// Token: 0x040003AF RID: 943
		private ArrayList list;
	}
}
