using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Provides a generic collection that supports data binding.</summary>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	// Token: 0x020000D6 RID: 214
	[Serializable]
	public class BindingList<T> : Collection<T>, IList, ICollection, IEnumerable, IBindingList, ICancelAddNew, IRaiseItemChangedEvents
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.BindingList`1" /> class with the specified list.</summary>
		/// <param name="list">An <see cref="T:System.Collections.Generic.IList`1" /> of items to be contained in the <see cref="T:System.ComponentModel.BindingList`1" />.</param>
		// Token: 0x0600090A RID: 2314 RVA: 0x00008899 File Offset: 0x00006A99
		public BindingList(IList<T> list)
			: base(list)
		{
			this.CheckType();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.BindingList`1" /> class using default values.</summary>
		// Token: 0x0600090B RID: 2315 RVA: 0x000088BD File Offset: 0x00006ABD
		public BindingList()
		{
			this.CheckType();
		}

		/// <summary>Occurs before an item is added to the list.</summary>
		// Token: 0x1400001A RID: 26
		// (add) Token: 0x0600090C RID: 2316 RVA: 0x000088E0 File Offset: 0x00006AE0
		// (remove) Token: 0x0600090D RID: 2317 RVA: 0x000088F9 File Offset: 0x00006AF9
		public event AddingNewEventHandler AddingNew;

		/// <summary>Occurs when the list or an item in the list changes.</summary>
		// Token: 0x1400001B RID: 27
		// (add) Token: 0x0600090E RID: 2318 RVA: 0x00008912 File Offset: 0x00006B12
		// (remove) Token: 0x0600090F RID: 2319 RVA: 0x0000892B File Offset: 0x00006B2B
		public event ListChangedEventHandler ListChanged;

		/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor)" />.</summary>
		/// <param name="prop">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to add as a search criteria. </param>
		// Token: 0x06000910 RID: 2320 RVA: 0x000029F5 File Offset: 0x00000BF5
		void IBindingList.AddIndex(PropertyDescriptor index)
		{
		}

		/// <summary>Adds a new item to the list. For more information, see <see cref="M:System.ComponentModel.IBindingList.AddNew" />.</summary>
		/// <returns>The item added to the list.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x06000911 RID: 2321 RVA: 0x00008944 File Offset: 0x00006B44
		object IBindingList.AddNew()
		{
			return this.AddNew();
		}

		/// <summary>Sorts the list based on a <see cref="T:System.ComponentModel.PropertyDescriptor" /> and a <see cref="T:System.ComponentModel.ListSortDirection" />. For a complete description of this member, see <see cref="M:System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor,System.ComponentModel.ListSortDirection)" /></summary>
		/// <param name="prop">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to sort by.</param>
		/// <param name="direction">One of the <see cref="T:System.ComponentModel.ListSortDirection" /> values.</param>
		// Token: 0x06000912 RID: 2322 RVA: 0x00008951 File Offset: 0x00006B51
		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			this.ApplySortCore(property, direction);
		}

		/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor,System.Object)" />.</summary>
		/// <returns>The index of the row that has the given <see cref="T:System.ComponentModel.PropertyDescriptor" /> .</returns>
		/// <param name="prop">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to search on.</param>
		/// <param name="key">The value of the <paramref name="property" /> parameter to search for.</param>
		// Token: 0x06000913 RID: 2323 RVA: 0x0000895B File Offset: 0x00006B5B
		int IBindingList.Find(PropertyDescriptor property, object key)
		{
			return this.FindCore(property, key);
		}

		/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor)" />.</summary>
		/// <param name="prop">A <see cref="T:System.ComponentModel.PropertyDescriptor" /> to remove from the indexes used for searching.</param>
		// Token: 0x06000914 RID: 2324 RVA: 0x000029F5 File Offset: 0x00000BF5
		void IBindingList.RemoveIndex(PropertyDescriptor property)
		{
		}

		/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.RemoveSort" /></summary>
		// Token: 0x06000915 RID: 2325 RVA: 0x00008965 File Offset: 0x00006B65
		void IBindingList.RemoveSort()
		{
			this.RemoveSortCore();
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.IsSorted" />.</summary>
		/// <returns>true if <see cref="M:System.ComponentModel.IBindingListView.ApplySort(System.ComponentModel.ListSortDescriptionCollection)" /> has been called and <see cref="M:System.ComponentModel.IBindingList.RemoveSort" /> has not been called; otherwise, false.</returns>
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x0000896D File Offset: 0x00006B6D
		bool IBindingList.IsSorted
		{
			get
			{
				return this.IsSortedCore;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SortDirection" />.</summary>
		/// <returns>One of the <see cref="T:System.ComponentModel.ListSortDirection" /> values.</returns>
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00008975 File Offset: 0x00006B75
		ListSortDirection IBindingList.SortDirection
		{
			get
			{
				return this.SortDirectionCore;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SortProperty" />.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.PropertyDescriptor" /> that is being used for sorting.</returns>
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x0000897D File Offset: 0x00006B7D
		PropertyDescriptor IBindingList.SortProperty
		{
			get
			{
				return this.SortPropertyCore;
			}
		}

		/// <summary>Gets a value indicating whether items in the list can be edited.</summary>
		/// <returns>true if list items can be edited; otherwise, false. The default is true.</returns>
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x00008985 File Offset: 0x00006B85
		bool IBindingList.AllowEdit
		{
			get
			{
				return this.AllowEdit;
			}
		}

		/// <summary>Gets a value indicating whether new items can be added to the list using the <see cref="M:System.ComponentModel.BindingList`1.AddNew" /> method.</summary>
		/// <returns>true if you can add items to the list with the <see cref="M:System.ComponentModel.BindingList`1.AddNew" /> method; otherwise, false. The default depends on the underlying type contained in the list.</returns>
		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x0000898D File Offset: 0x00006B8D
		bool IBindingList.AllowNew
		{
			get
			{
				return this.AllowNew;
			}
		}

		/// <summary>Gets a value indicating whether items can be removed from the list.</summary>
		/// <returns>true if you can remove items from the list with the <see cref="M:System.ComponentModel.BindingList`1.RemoveItem(System.Int32)" /> method; otherwise, false. The default is true.</returns>
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00008995 File Offset: 0x00006B95
		bool IBindingList.AllowRemove
		{
			get
			{
				return this.AllowRemove;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsChangeNotification" />.</summary>
		/// <returns>true if a <see cref="E:System.ComponentModel.IBindingList.ListChanged" /> event is raised when the list changes or when an item changes; otherwise, false.</returns>
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x0000899D File Offset: 0x00006B9D
		bool IBindingList.SupportsChangeNotification
		{
			get
			{
				return this.SupportsChangeNotificationCore;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsSearching" />.</summary>
		/// <returns>true if the list supports searching using the <see cref="M:System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor,System.Object)" /> method; otherwise, false.</returns>
		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x000089A5 File Offset: 0x00006BA5
		bool IBindingList.SupportsSearching
		{
			get
			{
				return this.SupportsSearchingCore;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsSorting" />.</summary>
		/// <returns>true if the list supports sorting; otherwise, false.</returns>
		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x000089AD File Offset: 0x00006BAD
		bool IBindingList.SupportsSorting
		{
			get
			{
				return this.SupportsSortingCore;
			}
		}

		/// <summary>Gets a value indicating whether item property value changes raise <see cref="E:System.ComponentModel.BindingList`1.ListChanged" /> events of type <see cref="F:System.ComponentModel.ListChangedType.ItemChanged" />. This member cannot be overridden in a derived class.</summary>
		/// <returns>true if the list type implements <see cref="T:System.ComponentModel.INotifyPropertyChanged" />, otherwise, false. The default is false.</returns>
		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x000089B5 File Offset: 0x00006BB5
		bool IRaiseItemChangedEvents.RaisesItemChangedEvents
		{
			get
			{
				return this.type_raises_item_changed_events;
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0002EE98 File Offset: 0x0002D098
		private void CheckType()
		{
			ConstructorInfo constructor = typeof(T).GetConstructor(Type.EmptyTypes);
			this.type_has_default_ctor = constructor != null;
			this.type_raises_item_changed_events = typeof(INotifyPropertyChanged).IsAssignableFrom(typeof(T));
		}

		/// <summary>Gets or sets a value indicating whether items in the list can be edited.</summary>
		/// <returns>true if list items can be edited; otherwise, false. The default is true.</returns>
		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x000089BD File Offset: 0x00006BBD
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x000089C5 File Offset: 0x00006BC5
		public bool AllowEdit
		{
			get
			{
				return this.allow_edit;
			}
			set
			{
				if (this.allow_edit != value)
				{
					this.allow_edit = value;
					if (this.raise_list_changed_events)
					{
						this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
					}
				}
			}
		}

		/// <summary>Gets or sets a value indicating whether you can add items to the list using the <see cref="M:System.ComponentModel.BindingList`1.AddNew" /> method.</summary>
		/// <returns>true if you can add items to the list with the <see cref="M:System.ComponentModel.BindingList`1.AddNew" /> method; otherwise, false. The default depends on the underlying type contained in the list.</returns>
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x000089F2 File Offset: 0x00006BF2
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x00008A21 File Offset: 0x00006C21
		public bool AllowNew
		{
			get
			{
				if (this.allow_new_set)
				{
					return this.allow_new;
				}
				return this.type_has_default_ctor || this.AddingNew != null;
			}
			set
			{
				if (this.AllowNew != value)
				{
					this.allow_new_set = true;
					this.allow_new = value;
					if (this.raise_list_changed_events)
					{
						this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
					}
				}
			}
		}

		/// <summary>Gets or sets a value indicating whether you can remove items from the collection. </summary>
		/// <returns>true if you can remove items from the list with the <see cref="M:System.ComponentModel.BindingList`1.RemoveItem(System.Int32)" /> method otherwise, false. The default is true.</returns>
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x00008A55 File Offset: 0x00006C55
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x00008A5D File Offset: 0x00006C5D
		public bool AllowRemove
		{
			get
			{
				return this.allow_remove;
			}
			set
			{
				if (this.allow_remove != value)
				{
					this.allow_remove = value;
					if (this.raise_list_changed_events)
					{
						this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
					}
				}
			}
		}

		/// <summary>Gets a value indicating whether the list is sorted. </summary>
		/// <returns>true if the list is sorted; otherwise, false. The default is false.</returns>
		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00002AA1 File Offset: 0x00000CA1
		protected virtual bool IsSortedCore
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets or sets a value indicating whether adding or removing items within the list raises <see cref="E:System.ComponentModel.BindingList`1.ListChanged" /> events.</summary>
		/// <returns>true if adding or removing items raises <see cref="E:System.ComponentModel.BindingList`1.ListChanged" /> events; otherwise, false. The default is true.</returns>
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00008A8A File Offset: 0x00006C8A
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x00008A92 File Offset: 0x00006C92
		public bool RaiseListChangedEvents
		{
			get
			{
				return this.raise_list_changed_events;
			}
			set
			{
				this.raise_list_changed_events = value;
			}
		}

		/// <summary>Gets the direction the list is sorted.</summary>
		/// <returns>One of the <see cref="T:System.ComponentModel.ListSortDirection" /> values. The default is <see cref="F:System.ComponentModel.ListSortDirection.Ascending" />. </returns>
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00002AA1 File Offset: 0x00000CA1
		protected virtual ListSortDirection SortDirectionCore
		{
			get
			{
				return ListSortDirection.Ascending;
			}
		}

		/// <summary>Gets the property descriptor that is used for sorting the list if sorting is implemented in a derived class; otherwise, returns null. </summary>
		/// <returns>The <see cref="T:System.ComponentModel.PropertyDescriptor" /> used for sorting the list.</returns>
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00002A97 File Offset: 0x00000C97
		protected virtual PropertyDescriptor SortPropertyCore
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets a value indicating whether <see cref="E:System.ComponentModel.BindingList`1.ListChanged" /> events are enabled.</summary>
		/// <returns>true if <see cref="E:System.ComponentModel.BindingList`1.ListChanged" /> events are supported; otherwise, false. The default is true.</returns>
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x000025B7 File Offset: 0x000007B7
		protected virtual bool SupportsChangeNotificationCore
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets a value indicating whether the list supports searching.</summary>
		/// <returns>true if the list supports searching; otherwise, false. The default is false.</returns>
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00002AA1 File Offset: 0x00000CA1
		protected virtual bool SupportsSearchingCore
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the list supports sorting.</summary>
		/// <returns>true if the list supports sorting; otherwise, false. The default is false.</returns>
		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00002AA1 File Offset: 0x00000CA1
		protected virtual bool SupportsSortingCore
		{
			get
			{
				return false;
			}
		}

		/// <summary>Adds a new item to the collection.</summary>
		/// <returns>The item added to the list.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Windows.Forms.BindingSource.AllowNew" /> property is set to false. -or-A public default constructor could not be found for the current item type.</exception>
		// Token: 0x0600092F RID: 2351 RVA: 0x00008A9B File Offset: 0x00006C9B
		public T AddNew()
		{
			return (T)((object)this.AddNewCore());
		}

		/// <summary>Adds a new item to the end of the collection.</summary>
		/// <returns>The item that was added to the collection.</returns>
		/// <exception cref="T:System.InvalidCastException">The new item is not the same type as the objects contained in the <see cref="T:System.ComponentModel.BindingList`1" />.</exception>
		// Token: 0x06000930 RID: 2352 RVA: 0x0002EEE8 File Offset: 0x0002D0E8
		protected virtual object AddNewCore()
		{
			if (!this.AllowNew)
			{
				throw new InvalidOperationException();
			}
			AddingNewEventArgs addingNewEventArgs = new AddingNewEventArgs();
			this.OnAddingNew(addingNewEventArgs);
			T t = (T)((object)addingNewEventArgs.NewObject);
			if (t == null)
			{
				if (!this.type_has_default_ctor)
				{
					throw new InvalidOperationException();
				}
				t = (T)((object)Activator.CreateInstance(typeof(T)));
			}
			this.Add(t);
			this.pending_add_index = this.IndexOf(t);
			this.add_pending = true;
			return t;
		}

		/// <summary>Sorts the items if overridden in a derived class; otherwise, throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="prop">A <see cref="T:System.ComponentModel.PropertyDescriptor" /> that specifies the property to sort on.</param>
		/// <param name="direction">One of the <see cref="T:System.ComponentModel.ListSortDirection" />  values.</param>
		/// <exception cref="T:System.NotSupportedException">Method is not overridden in a derived class. </exception>
		// Token: 0x06000931 RID: 2353 RVA: 0x00006A38 File Offset: 0x00004C38
		protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
		{
			throw new NotSupportedException();
		}

		/// <summary>Discards a pending new item.</summary>
		/// <param name="itemIndex">The index of the of the new item to be added </param>
		// Token: 0x06000932 RID: 2354 RVA: 0x0002EF74 File Offset: 0x0002D174
		public virtual void CancelNew(int itemIndex)
		{
			if (!this.add_pending)
			{
				return;
			}
			if (itemIndex != this.pending_add_index)
			{
				return;
			}
			this.add_pending = false;
			base.RemoveItem(itemIndex);
			if (this.raise_list_changed_events)
			{
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, itemIndex));
			}
		}

		/// <summary>Removes all elements from the collection.</summary>
		// Token: 0x06000933 RID: 2355 RVA: 0x00008AA8 File Offset: 0x00006CA8
		protected override void ClearItems()
		{
			this.EndNew(this.pending_add_index);
			base.ClearItems();
			this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
		}

		/// <summary>Commits a pending new item to the collection.</summary>
		/// <param name="itemIndex">The index of the new item to be added.</param>
		// Token: 0x06000934 RID: 2356 RVA: 0x00008AC9 File Offset: 0x00006CC9
		public virtual void EndNew(int itemIndex)
		{
			if (!this.add_pending)
			{
				return;
			}
			if (itemIndex != this.pending_add_index)
			{
				return;
			}
			this.add_pending = false;
		}

		/// <summary>Searches for the index of the item that has the specified property descriptor with the specified value, if searching is implemented in a derived class; otherwise, a <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>The zero-based index of the item that matches the property descriptor and contains the specified value.</returns>
		/// <param name="prop">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to search for.</param>
		/// <param name="key">The value of <paramref name="property" /> to match.</param>
		/// <exception cref="T:System.NotSupportedException">
		///   <see cref="M:System.ComponentModel.BindingList`1.FindCore(System.ComponentModel.PropertyDescriptor,System.Object)" /> is not overridden in a derived class.</exception>
		// Token: 0x06000935 RID: 2357 RVA: 0x00006A38 File Offset: 0x00004C38
		protected virtual int FindCore(PropertyDescriptor prop, object key)
		{
			throw new NotSupportedException();
		}

		/// <summary>Inserts the specified item in the list at the specified index.</summary>
		/// <param name="index">The zero-based index where the item is to be inserted.</param>
		/// <param name="item">The item to insert in the list.</param>
		// Token: 0x06000936 RID: 2358 RVA: 0x00008AEB File Offset: 0x00006CEB
		protected override void InsertItem(int index, T item)
		{
			this.EndNew(this.pending_add_index);
			base.InsertItem(index, item);
			if (this.raise_list_changed_events)
			{
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index));
			}
		}

		/// <summary>Raises the <see cref="E:System.ComponentModel.BindingList`1.AddingNew" /> event.</summary>
		/// <param name="e">An <see cref="T:System.ComponentModel.AddingNewEventArgs" /> that contains the event data. </param>
		// Token: 0x06000937 RID: 2359 RVA: 0x00008B19 File Offset: 0x00006D19
		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
			if (this.AddingNew != null)
			{
				this.AddingNew(this, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.ComponentModel.BindingList`1.ListChanged" /> event.</summary>
		/// <param name="e">A <see cref="T:System.ComponentModel.ListChangedEventArgs" /> that contains the event data. </param>
		// Token: 0x06000938 RID: 2360 RVA: 0x00008B33 File Offset: 0x00006D33
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
			if (this.ListChanged != null)
			{
				this.ListChanged(this, e);
			}
		}

		/// <summary>Removes the item at the specified index.</summary>
		/// <param name="index">The zero-based index of the item to remove. </param>
		/// <exception cref="T:System.NotSupportedException">You are removing a newly added item and <see cref="P:System.ComponentModel.IBindingList.AllowRemove" /> is set to false. </exception>
		// Token: 0x06000939 RID: 2361 RVA: 0x00008B4D File Offset: 0x00006D4D
		protected override void RemoveItem(int index)
		{
			if (!this.AllowRemove)
			{
				throw new NotSupportedException();
			}
			this.EndNew(this.pending_add_index);
			base.RemoveItem(index);
			if (this.raise_list_changed_events)
			{
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
			}
		}

		/// <summary>Removes any sort applied with <see cref="M:System.ComponentModel.BindingList`1.ApplySortCore(System.ComponentModel.PropertyDescriptor,System.ComponentModel.ListSortDirection)" /> if sorting is implemented in a derived class; otherwise, raises <see cref="T:System.NotSupportedException" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Method is not overridden in a derived class. </exception>
		// Token: 0x0600093A RID: 2362 RVA: 0x00006A38 File Offset: 0x00004C38
		protected virtual void RemoveSortCore()
		{
			throw new NotSupportedException();
		}

		/// <summary>Raises a <see cref="E:System.ComponentModel.BindingList`1.ListChanged" /> event of type <see cref="F:System.ComponentModel.ListChangedType.Reset" />.</summary>
		// Token: 0x0600093B RID: 2363 RVA: 0x00008B8B File Offset: 0x00006D8B
		public void ResetBindings()
		{
			this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
		}

		/// <summary>Raises a <see cref="E:System.ComponentModel.BindingList`1.ListChanged" /> event of type <see cref="F:System.ComponentModel.ListChangedType.ItemChanged" /> for the item at the specified position.</summary>
		/// <param name="position">A zero-based index of the item to be reset.</param>
		// Token: 0x0600093C RID: 2364 RVA: 0x00008B9A File Offset: 0x00006D9A
		public void ResetItem(int position)
		{
			this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, position));
		}

		/// <summary>Replaces the item at the specified index with the specified item.</summary>
		/// <param name="index">The zero-based index of the item to replace.</param>
		/// <param name="item">The new value for the item at the specified index. The value can be null for reference types.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero.-or-<paramref name="index" /> is greater than <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x0600093D RID: 2365 RVA: 0x00008BA9 File Offset: 0x00006DA9
		protected override void SetItem(int index, T item)
		{
			base.SetItem(index, item);
			this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, index));
		}

		// Token: 0x0400026A RID: 618
		private bool allow_edit = true;

		// Token: 0x0400026B RID: 619
		private bool allow_remove = true;

		// Token: 0x0400026C RID: 620
		private bool allow_new;

		// Token: 0x0400026D RID: 621
		private bool allow_new_set;

		// Token: 0x0400026E RID: 622
		private bool raise_list_changed_events = true;

		// Token: 0x0400026F RID: 623
		private bool type_has_default_ctor;

		// Token: 0x04000270 RID: 624
		private bool type_raises_item_changed_events;

		// Token: 0x04000271 RID: 625
		private bool add_pending;

		// Token: 0x04000272 RID: 626
		private int pending_add_index;
	}
}
