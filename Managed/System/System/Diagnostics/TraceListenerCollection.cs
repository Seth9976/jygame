using System;
using System.Collections;

namespace System.Diagnostics
{
	/// <summary>Provides a thread-safe list of <see cref="T:System.Diagnostics.TraceListener" /> objects.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000266 RID: 614
	public class TraceListenerCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x0600157F RID: 5503 RVA: 0x00010839 File Offset: 0x0000EA39
		internal TraceListenerCollection()
			: this(true)
		{
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00010842 File Offset: 0x0000EA42
		internal TraceListenerCollection(bool addDefault)
		{
			if (addDefault)
			{
				this.Add(new DefaultTraceListener());
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Diagnostics.TraceListener" /> at the specified index in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <returns>The <see cref="T:System.Diagnostics.TraceListener" /> at the specified index.</returns>
		/// <param name="index">The zero-based index of the <paramref name="value" /> to get.</param>
		// Token: 0x17000521 RID: 1313
		object IList.this[int index]
		{
			get
			{
				return this.listeners[index];
			}
			set
			{
				TraceListener traceListener = (TraceListener)value;
				this.InitializeListener(traceListener);
				this[index] = traceListener;
			}
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Diagnostics.TraceListenerCollection" /> is synchronized (thread safe).</summary>
		/// <returns>Always true.</returns>
		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x0001087B File Offset: 0x0000EA7B
		bool ICollection.IsSynchronized
		{
			get
			{
				return this.listeners.IsSynchronized;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <returns>The current <see cref="T:System.Diagnostics.TraceListenerCollection" /> object.</returns>
		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x00010888 File Offset: 0x0000EA88
		object ICollection.SyncRoot
		{
			get
			{
				return this.listeners.SyncRoot;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Diagnostics.TraceListenerCollection" /> has a fixed size.</summary>
		/// <returns>Always false.</returns>
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x00010895 File Offset: 0x0000EA95
		bool IList.IsFixedSize
		{
			get
			{
				return this.listeners.IsFixedSize;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Diagnostics.TraceListenerCollection" /> is read-only</summary>
		/// <returns>Always false.</returns>
		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x000108A2 File Offset: 0x0000EAA2
		bool IList.IsReadOnly
		{
			get
			{
				return this.listeners.IsReadOnly;
			}
		}

		/// <summary>Copies a section of the current <see cref="T:System.Diagnostics.TraceListenerCollection" /> to the specified array of <see cref="T:System.Diagnostics.TraceListener" /> objects. </summary>
		/// <param name="array">The one-dimensional array of <see cref="T:System.Diagnostics.TraceListener" /> objects that is the destination of the elements copied from the <see cref="T:System.Diagnostics.TraceListenerCollection" />. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		// Token: 0x06001587 RID: 5511 RVA: 0x000108AF File Offset: 0x0000EAAF
		void ICollection.CopyTo(Array array, int index)
		{
			this.listeners.CopyTo(array, index);
		}

		/// <summary>Adds a trace listener to the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <returns>The position into which the new trace listener was inserted.</returns>
		/// <param name="value">The object to add to the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is null. -or-<paramref name="value" /> is not a <see cref="T:System.Diagnostics.TraceListener" />.</exception>
		// Token: 0x06001588 RID: 5512 RVA: 0x000108BE File Offset: 0x0000EABE
		int IList.Add(object value)
		{
			if (value is TraceListener)
			{
				return this.Add((TraceListener)value);
			}
			throw new NotSupportedException(global::Locale.GetText("You can only add TraceListener objects to the collection"));
		}

		/// <summary>Determines whether the <see cref="T:System.Diagnostics.TraceListenerCollection" /> contains a specific object.</summary>
		/// <returns>true if the <see cref="T:System.Object" /> is found in the <see cref="T:System.Diagnostics.TraceListenerCollection" />; otherwise, false.</returns>
		/// <param name="value">The object to locate in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		// Token: 0x06001589 RID: 5513 RVA: 0x000108E7 File Offset: 0x0000EAE7
		bool IList.Contains(object value)
		{
			return value is TraceListener && this.listeners.Contains(value);
		}

		/// <summary>Determines the index of a specific object in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <returns>The index of <paramref name="value" /> if found in the <see cref="T:System.Diagnostics.TraceListenerCollection" />; otherwise, -1.</returns>
		/// <param name="value">The object to locate in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		// Token: 0x0600158A RID: 5514 RVA: 0x00010902 File Offset: 0x0000EB02
		int IList.IndexOf(object value)
		{
			if (value is TraceListener)
			{
				return this.listeners.IndexOf(value);
			}
			return -1;
		}

		/// <summary>Inserts a <see cref="T:System.Diagnostics.TraceListener" /> object at the specified position in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The <see cref="T:System.Diagnostics.TraceListener" /> object to insert into the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is not a <see cref="T:System.Diagnostics.TraceListener" /> object.</exception>
		// Token: 0x0600158B RID: 5515 RVA: 0x0001091D File Offset: 0x0000EB1D
		void IList.Insert(int index, object value)
		{
			if (value is TraceListener)
			{
				this.Insert(index, (TraceListener)value);
				return;
			}
			throw new NotSupportedException(global::Locale.GetText("You can only insert TraceListener objects into the collection"));
		}

		/// <summary>Removes an object from the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <param name="value">The object to remove from the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		// Token: 0x0600158C RID: 5516 RVA: 0x00010947 File Offset: 0x0000EB47
		void IList.Remove(object value)
		{
			if (value is TraceListener)
			{
				this.listeners.Remove(value);
			}
		}

		/// <summary>Gets the number of listeners in the list.</summary>
		/// <returns>The number of listeners in the list.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x00010960 File Offset: 0x0000EB60
		public int Count
		{
			get
			{
				return this.listeners.Count;
			}
		}

		/// <summary>Gets the first <see cref="T:System.Diagnostics.TraceListener" /> in the list with the specified name.</summary>
		/// <returns>The first <see cref="T:System.Diagnostics.TraceListener" /> in the list with the given <see cref="P:System.Diagnostics.TraceListener.Name" />. This item returns null if no <see cref="T:System.Diagnostics.TraceListener" /> with the given name can be found.</returns>
		/// <param name="name">The name of the <see cref="T:System.Diagnostics.TraceListener" /> to get from the list. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000527 RID: 1319
		public TraceListener this[string name]
		{
			get
			{
				object syncRoot = this.listeners.SyncRoot;
				lock (syncRoot)
				{
					foreach (object obj in this.listeners)
					{
						TraceListener traceListener = (TraceListener)obj;
						if (traceListener.Name == name)
						{
							return traceListener;
						}
					}
				}
				return null;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Diagnostics.TraceListener" /> at the specified index.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.TraceListener" /> with the specified index.</returns>
		/// <param name="i">The zero-based index of the <see cref="T:System.Diagnostics.TraceListener" /> to get from the list. </param>
		/// <exception cref="T:System.ArgumentNullException">The value is null.</exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000528 RID: 1320
		public TraceListener this[int index]
		{
			get
			{
				return (TraceListener)this.listeners[index];
			}
			set
			{
				this.InitializeListener(value);
				this.listeners[index] = value;
			}
		}

		/// <summary>Adds a <see cref="T:System.Diagnostics.TraceListener" /> to the list.</summary>
		/// <returns>The position at which the new listener was inserted.</returns>
		/// <param name="listener">A <see cref="T:System.Diagnostics.TraceListener" /> to add to the list. </param>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06001591 RID: 5521 RVA: 0x00010996 File Offset: 0x0000EB96
		public int Add(TraceListener listener)
		{
			this.InitializeListener(listener);
			return this.listeners.Add(listener);
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x000109AB File Offset: 0x0000EBAB
		internal void Add(TraceListener listener, TraceImplSettings settings)
		{
			listener.IndentLevel = settings.IndentLevel;
			listener.IndentSize = settings.IndentSize;
			this.listeners.Add(listener);
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x000109D2 File Offset: 0x0000EBD2
		private void InitializeListener(TraceListener listener)
		{
			listener.IndentLevel = TraceImpl.IndentLevel;
			listener.IndentSize = TraceImpl.IndentSize;
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00042C30 File Offset: 0x00040E30
		private void InitializeRange(IList listeners)
		{
			int count = listeners.Count;
			for (int num = 0; num != count; num++)
			{
				this.InitializeListener((TraceListener)listeners[num]);
			}
		}

		/// <summary>Adds an array of <see cref="T:System.Diagnostics.TraceListener" /> objects to the list.</summary>
		/// <param name="value">An array of <see cref="T:System.Diagnostics.TraceListener" /> objects to add to the list. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06001595 RID: 5525 RVA: 0x000109EA File Offset: 0x0000EBEA
		public void AddRange(TraceListener[] value)
		{
			this.InitializeRange(value);
			this.listeners.AddRange(value);
		}

		/// <summary>Adds the contents of another <see cref="T:System.Diagnostics.TraceListenerCollection" /> to the list.</summary>
		/// <param name="value">Another <see cref="T:System.Diagnostics.TraceListenerCollection" /> whose contents are added to the list. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06001596 RID: 5526 RVA: 0x000109FF File Offset: 0x0000EBFF
		public void AddRange(TraceListenerCollection value)
		{
			this.InitializeRange(value);
			this.listeners.AddRange(value.listeners);
		}

		/// <summary>Clears all the listeners from the list.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x06001597 RID: 5527 RVA: 0x00010A19 File Offset: 0x0000EC19
		public void Clear()
		{
			this.listeners.Clear();
		}

		/// <summary>Checks whether the list contains the specified listener.</summary>
		/// <returns>true if the listener is in the list; otherwise, false.</returns>
		/// <param name="listener">A <see cref="T:System.Diagnostics.TraceListener" /> to find in the list. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x06001598 RID: 5528 RVA: 0x00010A26 File Offset: 0x0000EC26
		public bool Contains(TraceListener listener)
		{
			return this.listeners.Contains(listener);
		}

		/// <summary>Copies a section of the current <see cref="T:System.Diagnostics.TraceListenerCollection" /> list to the specified array at the specified index.</summary>
		/// <param name="listeners">An array of type <see cref="T:System.Array" /> to copy the elements into. </param>
		/// <param name="index">The starting index number in the current list to copy from. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x06001599 RID: 5529 RVA: 0x00010A34 File Offset: 0x0000EC34
		public void CopyTo(TraceListener[] listeners, int index)
		{
			listeners.CopyTo(listeners, index);
		}

		/// <summary>Gets an enumerator for this list.</summary>
		/// <returns>An enumerator of type <see cref="T:System.Collections.IEnumerator" />.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x0600159A RID: 5530 RVA: 0x00010A3E File Offset: 0x0000EC3E
		public IEnumerator GetEnumerator()
		{
			return this.listeners.GetEnumerator();
		}

		/// <summary>Gets the index of the specified listener.</summary>
		/// <returns>The index of the listener, if it can be found in the list; otherwise, -1.</returns>
		/// <param name="listener">A <see cref="T:System.Diagnostics.TraceListener" /> to find in the list. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x0600159B RID: 5531 RVA: 0x00010A4B File Offset: 0x0000EC4B
		public int IndexOf(TraceListener listener)
		{
			return this.listeners.IndexOf(listener);
		}

		/// <summary>Inserts the listener at the specified index.</summary>
		/// <param name="index">The position in the list to insert the new <see cref="T:System.Diagnostics.TraceListener" />. </param>
		/// <param name="listener">A <see cref="T:System.Diagnostics.TraceListener" /> to insert in the list. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> is not a valid index in the list. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="listener" /> is null.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x0600159C RID: 5532 RVA: 0x00010A59 File Offset: 0x0000EC59
		public void Insert(int index, TraceListener listener)
		{
			this.InitializeListener(listener);
			this.listeners.Insert(index, listener);
		}

		/// <summary>Removes from the collection the first <see cref="T:System.Diagnostics.TraceListener" /> with the specified name.</summary>
		/// <param name="name">The name of the <see cref="T:System.Diagnostics.TraceListener" /> to remove from the list. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x0600159D RID: 5533 RVA: 0x00042C68 File Offset: 0x00040E68
		public void Remove(string name)
		{
			TraceListener traceListener = null;
			object syncRoot = this.listeners.SyncRoot;
			lock (syncRoot)
			{
				foreach (object obj in this.listeners)
				{
					TraceListener traceListener2 = (TraceListener)obj;
					if (traceListener2.Name == name)
					{
						traceListener = traceListener2;
						break;
					}
				}
				if (traceListener == null)
				{
					throw new ArgumentException(global::Locale.GetText("TraceListener " + name + " was not in the collection"));
				}
				this.listeners.Remove(traceListener);
			}
		}

		/// <summary>Removes from the collection the specified <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <param name="listener">A <see cref="T:System.Diagnostics.TraceListener" /> to remove from the list. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x0600159E RID: 5534 RVA: 0x00010A6F File Offset: 0x0000EC6F
		public void Remove(TraceListener listener)
		{
			this.listeners.Remove(listener);
		}

		/// <summary>Removes from the collection the <see cref="T:System.Diagnostics.TraceListener" /> at the specified index.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.Diagnostics.TraceListener" /> to remove from the list. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> is not a valid index in the list. </exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x0600159F RID: 5535 RVA: 0x00010A7D File Offset: 0x0000EC7D
		public void RemoveAt(int index)
		{
			this.listeners.RemoveAt(index);
		}

		// Token: 0x040006B3 RID: 1715
		private ArrayList listeners = ArrayList.Synchronized(new ArrayList(1));
	}
}
