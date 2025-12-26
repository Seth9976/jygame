using System;

namespace System.Collections.Specialized
{
	/// <summary>Supports a simple iteration over a <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
	// Token: 0x020000C6 RID: 198
	public class StringEnumerator
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x00008203 File Offset: 0x00006403
		internal StringEnumerator(StringCollection coll)
		{
			this.enumerable = ((IEnumerable)coll).GetEnumerator();
		}

		/// <summary>Gets the current element in the collection.</summary>
		/// <returns>The current element in the collection.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00008217 File Offset: 0x00006417
		public string Current
		{
			get
			{
				return (string)this.enumerable.Current;
			}
		}

		/// <summary>Advances the enumerator to the next element of the collection.</summary>
		/// <returns>true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.</returns>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
		// Token: 0x06000892 RID: 2194 RVA: 0x00008229 File Offset: 0x00006429
		public bool MoveNext()
		{
			return this.enumerable.MoveNext();
		}

		/// <summary>Sets the enumerator to its initial position, which is before the first element in the collection.</summary>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
		// Token: 0x06000893 RID: 2195 RVA: 0x00008236 File Offset: 0x00006436
		public void Reset()
		{
			this.enumerable.Reset();
		}

		// Token: 0x04000247 RID: 583
		private IEnumerator enumerable;
	}
}
