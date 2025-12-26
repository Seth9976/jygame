using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	/// <summary>Represents the set of captures made by a single capturing group.</summary>
	// Token: 0x02000489 RID: 1161
	[Serializable]
	public class CaptureCollection : ICollection, IEnumerable
	{
		// Token: 0x060028E3 RID: 10467 RVA: 0x0001C76E File Offset: 0x0001A96E
		internal CaptureCollection(int n)
		{
			this.list = new Capture[n];
		}

		/// <summary>Gets the number of substrings captured by the group.</summary>
		/// <returns>The number of items in the <see cref="T:System.Text.RegularExpressions.CaptureCollection" />.</returns>
		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060028E4 RID: 10468 RVA: 0x0001C782 File Offset: 0x0001A982
		public int Count
		{
			get
			{
				return this.list.Length;
			}
		}

		/// <summary>Gets a value that indicates whether the collection is read only.</summary>
		/// <returns>true in all cases.</returns>
		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x000025B7 File Offset: 0x000007B7
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets a value indicating whether access to the collection is synchronized (thread-safe).</summary>
		/// <returns>false in all cases.</returns>
		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060028E6 RID: 10470 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an individual member of the collection.</summary>
		/// <returns>The captured substring at position <paramref name="i" /> in the collection.</returns>
		/// <param name="i">Index into the capture collection. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="i" /> is less than 0 or greater than <see cref="P:System.Text.RegularExpressions.CaptureCollection.Count" />. </exception>
		// Token: 0x17000B5A RID: 2906
		public Capture this[int i]
		{
			get
			{
				if (i < 0 || i >= this.Count)
				{
					throw new ArgumentOutOfRangeException("Index is out of range");
				}
				return this.list[i];
			}
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x0001C7B4 File Offset: 0x0001A9B4
		internal void SetValue(Capture cap, int i)
		{
			this.list[i] = cap;
		}

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>An object that can be used to synchronize access to the collection.</returns>
		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x0001C7BF File Offset: 0x0001A9BF
		public object SyncRoot
		{
			get
			{
				return this.list;
			}
		}

		/// <summary>Copies all the elements of the collection to the given array beginning at the given index.</summary>
		/// <param name="array">The array the collection is to be copied into. </param>
		/// <param name="arrayIndex">The position in the destination array where copying is to begin. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array " />is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="arrayIndex" /> is outside the bounds of <paramref name="array" />. -or-<paramref name="arrayIndex" /> plus <see cref="P:System.Text.RegularExpressions.CaptureCollection.Count" /> is outside the bounds of <paramref name="array" />. </exception>
		// Token: 0x060028EA RID: 10474 RVA: 0x0001C7C7 File Offset: 0x0001A9C7
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		/// <summary>Provides an enumerator that iterates through the collection.</summary>
		/// <returns>An object that contains all <see cref="T:System.Text.RegularExpressions.Capture" /> objects within the <see cref="T:System.Text.RegularExpressions.CaptureCollection" />.</returns>
		// Token: 0x060028EB RID: 10475 RVA: 0x0001C7D6 File Offset: 0x0001A9D6
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x0400192A RID: 6442
		private Capture[] list;
	}
}
