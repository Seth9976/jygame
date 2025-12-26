using System;
using System.Collections;

namespace System.ComponentModel.Design
{
	/// <summary>Represents a collection of designers.</summary>
	// Token: 0x020000FF RID: 255
	public class DesignerCollection : ICollection, IEnumerable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.DesignerCollection" /> class that contains the specified designers.</summary>
		/// <param name="designers">An array of <see cref="T:System.ComponentModel.Design.IDesignerHost" /> objects to store. </param>
		// Token: 0x06000A3C RID: 2620 RVA: 0x00009875 File Offset: 0x00007A75
		public DesignerCollection(IDesignerHost[] designers)
		{
			this.designers = new ArrayList(designers);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.DesignerCollection" /> class that contains the specified set of designers.</summary>
		/// <param name="designers">A list that contains the collection of designers to add. </param>
		// Token: 0x06000A3D RID: 2621 RVA: 0x00009875 File Offset: 0x00007A75
		public DesignerCollection(IList designers)
		{
			this.designers = new ArrayList(designers);
		}

		/// <summary>Gets the number of elements contained in the collection.</summary>
		/// <returns>The number of elements contained in the collection.</returns>
		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00009889 File Offset: 0x00007A89
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}

		/// <summary>Gets a new enumerator for this collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that enumerates the collection.</returns>
		// Token: 0x06000A3F RID: 2623 RVA: 0x00009891 File Offset: 0x00007A91
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).</summary>
		/// <returns>true if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, false.</returns>
		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00009899 File Offset: 0x00007A99
		bool ICollection.IsSynchronized
		{
			get
			{
				return this.designers.IsSynchronized;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>An object that can be used to synchronize access to the collection.</returns>
		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x000098A6 File Offset: 0x00007AA6
		object ICollection.SyncRoot
		{
			get
			{
				return this.designers.SyncRoot;
			}
		}

		/// <summary>Copies the elements of the collection to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from collection. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		// Token: 0x06000A42 RID: 2626 RVA: 0x000098B3 File Offset: 0x00007AB3
		void ICollection.CopyTo(Array array, int index)
		{
			this.designers.CopyTo(array, index);
		}

		/// <summary>Gets the number of designers in the collection.</summary>
		/// <returns>The number of designers in the collection.</returns>
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x000098C2 File Offset: 0x00007AC2
		public int Count
		{
			get
			{
				return this.designers.Count;
			}
		}

		/// <summary>Gets the designer at the specified index.</summary>
		/// <returns>The designer at the specified index.</returns>
		/// <param name="index">The index of the designer to return. </param>
		// Token: 0x17000256 RID: 598
		public virtual IDesignerHost this[int index]
		{
			get
			{
				return (IDesignerHost)this.designers[index];
			}
		}

		/// <summary>Gets a new enumerator for this collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that enumerates the collection.</returns>
		// Token: 0x06000A45 RID: 2629 RVA: 0x000098E2 File Offset: 0x00007AE2
		public IEnumerator GetEnumerator()
		{
			return this.designers.GetEnumerator();
		}

		// Token: 0x040002C9 RID: 713
		private ArrayList designers;
	}
}
