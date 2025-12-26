using System;
using System.Collections;

namespace System.Diagnostics
{
	/// <summary>Provides a strongly typed collection of <see cref="T:System.Diagnostics.ProcessThread" /> objects.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000251 RID: 593
	public class ProcessThreadCollection : ReadOnlyCollectionBase
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ProcessThreadCollection" /> class, with no associated <see cref="T:System.Diagnostics.ProcessThread" /> instances.</summary>
		// Token: 0x060014CB RID: 5323 RVA: 0x0000FF32 File Offset: 0x0000E132
		protected ProcessThreadCollection()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ProcessThreadCollection" /> class, using the specified array of <see cref="T:System.Diagnostics.ProcessThread" /> instances.</summary>
		/// <param name="processThreads">An array of <see cref="T:System.Diagnostics.ProcessThread" /> instances with which to initialize this <see cref="T:System.Diagnostics.ProcessThreadCollection" /> instance. </param>
		// Token: 0x060014CC RID: 5324 RVA: 0x00008E22 File Offset: 0x00007022
		public ProcessThreadCollection(ProcessThread[] processThreads)
		{
			base.InnerList.AddRange(processThreads);
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00010133 File Offset: 0x0000E333
		internal static ProcessThreadCollection GetEmpty()
		{
			return new ProcessThreadCollection();
		}

		/// <summary>Gets an index for iterating over the set of process threads.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.ProcessThread" /> that indexes the threads in the collection.</returns>
		/// <param name="index">The zero-based index value of the thread in the collection. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004EF RID: 1263
		public ProcessThread this[int index]
		{
			get
			{
				return (ProcessThread)base.InnerList[index];
			}
		}

		/// <summary>Appends a process thread to the collection.</summary>
		/// <returns>The zero-based index of the thread in the collection.</returns>
		/// <param name="thread">The thread to add to the collection. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060014CF RID: 5327 RVA: 0x0001014D File Offset: 0x0000E34D
		public int Add(ProcessThread thread)
		{
			return base.InnerList.Add(thread);
		}

		/// <summary>Determines whether the specified process thread exists in the collection.</summary>
		/// <returns>true if the thread exists in the collection; otherwise, false.</returns>
		/// <param name="thread">A <see cref="T:System.Diagnostics.ProcessThread" /> instance that indicates the thread to find in this collection. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060014D0 RID: 5328 RVA: 0x0000FF4D File Offset: 0x0000E14D
		public bool Contains(ProcessThread thread)
		{
			return base.InnerList.Contains(thread);
		}

		/// <summary>Copies an array of <see cref="T:System.Diagnostics.ProcessThread" /> instances to the collection, at the specified index.</summary>
		/// <param name="array">An array of <see cref="T:System.Diagnostics.ProcessThread" /> instances to add to the collection. </param>
		/// <param name="index">The location at which to add the new instances. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060014D1 RID: 5329 RVA: 0x00008E49 File Offset: 0x00007049
		public void CopyTo(ProcessThread[] array, int index)
		{
			base.InnerList.CopyTo(array, index);
		}

		/// <summary>Provides the location of a specified thread within the collection.</summary>
		/// <returns>The zero-based index that defines the location of the thread within the <see cref="T:System.Diagnostics.ProcessThreadCollection" />.</returns>
		/// <param name="thread">The <see cref="T:System.Diagnostics.ProcessThread" /> whose index is retrieved. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060014D2 RID: 5330 RVA: 0x0000FF5B File Offset: 0x0000E15B
		public int IndexOf(ProcessThread thread)
		{
			return base.InnerList.IndexOf(thread);
		}

		/// <summary>Inserts a process thread at the specified location in the collection.</summary>
		/// <param name="index">The zero-based index indicating the location at which to insert the thread. </param>
		/// <param name="thread">The thread to insert into the collection. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060014D3 RID: 5331 RVA: 0x0001015B File Offset: 0x0000E35B
		public void Insert(int index, ProcessThread thread)
		{
			base.InnerList.Insert(index, thread);
		}

		/// <summary>Deletes a process thread from the collection.</summary>
		/// <param name="thread">The thread to remove from the collection. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060014D4 RID: 5332 RVA: 0x0001016A File Offset: 0x0000E36A
		public void Remove(ProcessThread thread)
		{
			base.InnerList.Remove(thread);
		}
	}
}
