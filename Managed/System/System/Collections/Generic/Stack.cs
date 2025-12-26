using System;
using System.Runtime.InteropServices;

namespace System.Collections.Generic
{
	/// <summary>Represents a variable size last-in-first-out (LIFO) collection of instances of the same arbitrary type.</summary>
	/// <typeparam name="T">Specifies the type of elements in the stack.</typeparam>
	/// <filterpriority>1</filterpriority>
	// Token: 0x020000AE RID: 174
	[ComVisible(false)]
	[Serializable]
	public class Stack<T> : IEnumerable<T>, ICollection, IEnumerable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.Stack`1" /> class that is empty and has the default initial capacity.</summary>
		// Token: 0x0600075C RID: 1884 RVA: 0x000021C3 File Offset: 0x000003C3
		public Stack()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.Stack`1" /> class that is empty and has the specified initial capacity or the default initial capacity, whichever is greater.</summary>
		/// <param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Generic.Stack`1" /> can contain.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="capacity" /> is less than zero.</exception>
		// Token: 0x0600075D RID: 1885 RVA: 0x000072A7 File Offset: 0x000054A7
		public Stack(int count)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this._array = new T[count];
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.Stack`1" /> class that contains elements copied from the specified collection and has sufficient capacity to accommodate the number of elements copied.</summary>
		/// <param name="collection">The collection to copy elements from.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="collection" /> is null.</exception>
		// Token: 0x0600075E RID: 1886 RVA: 0x0002CB78 File Offset: 0x0002AD78
		public Stack(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			ICollection<T> collection2 = collection as ICollection<T>;
			if (collection2 != null)
			{
				this._size = collection2.Count;
				this._array = new T[this._size];
				collection2.CopyTo(this._array, 0);
			}
			else
			{
				foreach (T t in collection)
				{
					this.Push(t);
				}
			}
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).</summary>
		/// <returns>true if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, false.  In the default implementation of <see cref="T:System.Collections.Generic.Stack`1" />, this property always returns false.</returns>
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00002AA1 File Offset: 0x00000CA1
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.  In the default implementation of <see cref="T:System.Collections.Generic.Stack`1" />, this property always returns the current instance.</returns>
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x000021CB File Offset: 0x000003CB
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ICollection" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="arrayIndex" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is multidimensional.-or-<paramref name="array" /> does not have zero-based indexing.-or-The number of elements in the source <see cref="T:System.Collections.ICollection" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.-or-The type of the source <see cref="T:System.Collections.ICollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
		// Token: 0x06000761 RID: 1889 RVA: 0x0002CC20 File Offset: 0x0002AE20
		void ICollection.CopyTo(Array dest, int idx)
		{
			try
			{
				if (this._array != null)
				{
					this._array.CopyTo(dest, idx);
					Array.Reverse(dest, idx, this._size);
				}
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException();
			}
		}

		/// <summary>Returns an enumerator that iterates through the collection.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.</returns>
		// Token: 0x06000762 RID: 1890 RVA: 0x000072CD File Offset: 0x000054CD
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		// Token: 0x06000763 RID: 1891 RVA: 0x000072CD File Offset: 0x000054CD
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Removes all objects from the <see cref="T:System.Collections.Generic.Stack`1" />.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06000764 RID: 1892 RVA: 0x000072DA File Offset: 0x000054DA
		public void Clear()
		{
			if (this._array != null)
			{
				Array.Clear(this._array, 0, this._array.Length);
			}
			this._size = 0;
			this._version++;
		}

		/// <summary>Determines whether an element is in the <see cref="T:System.Collections.Generic.Stack`1" />.</summary>
		/// <returns>true if <paramref name="item" /> is found in the <see cref="T:System.Collections.Generic.Stack`1" />; otherwise, false.</returns>
		/// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.Stack`1" />. The value can be null for reference types.</param>
		// Token: 0x06000765 RID: 1893 RVA: 0x00007310 File Offset: 0x00005510
		public bool Contains(T t)
		{
			return this._array != null && Array.IndexOf<T>(this._array, t, 0, this._size) != -1;
		}

		/// <summary>Copies the <see cref="T:System.Collections.Generic.Stack`1" /> to an existing one-dimensional <see cref="T:System.Array" />, starting at the specified array index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Generic.Stack`1" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="arrayIndex" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">The number of elements in the source <see cref="T:System.Collections.Generic.Stack`1" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.</exception>
		// Token: 0x06000766 RID: 1894 RVA: 0x0002CC74 File Offset: 0x0002AE74
		public void CopyTo(T[] dest, int idx)
		{
			if (dest == null)
			{
				throw new ArgumentNullException("dest");
			}
			if (idx < 0)
			{
				throw new ArgumentOutOfRangeException("idx");
			}
			if (this._array != null)
			{
				Array.Copy(this._array, 0, dest, idx, this._size);
				Array.Reverse(dest, idx, this._size);
			}
		}

		/// <summary>Returns the object at the top of the <see cref="T:System.Collections.Generic.Stack`1" /> without removing it.</summary>
		/// <returns>The object at the top of the <see cref="T:System.Collections.Generic.Stack`1" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Collections.Generic.Stack`1" /> is empty.</exception>
		// Token: 0x06000767 RID: 1895 RVA: 0x00007339 File Offset: 0x00005539
		public T Peek()
		{
			if (this._size == 0)
			{
				throw new InvalidOperationException();
			}
			return this._array[this._size - 1];
		}

		/// <summary>Removes and returns the object at the top of the <see cref="T:System.Collections.Generic.Stack`1" />.</summary>
		/// <returns>The object removed from the top of the <see cref="T:System.Collections.Generic.Stack`1" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Collections.Generic.Stack`1" /> is empty.</exception>
		// Token: 0x06000768 RID: 1896 RVA: 0x0002CCD0 File Offset: 0x0002AED0
		public T Pop()
		{
			if (this._size == 0)
			{
				throw new InvalidOperationException();
			}
			this._version++;
			T t = this._array[--this._size];
			this._array[this._size] = default(T);
			return t;
		}

		/// <summary>Inserts an object at the top of the <see cref="T:System.Collections.Generic.Stack`1" />.</summary>
		/// <param name="item">The object to push onto the <see cref="T:System.Collections.Generic.Stack`1" />. The value can be null for reference types.</param>
		// Token: 0x06000769 RID: 1897 RVA: 0x0002CD34 File Offset: 0x0002AF34
		public void Push(T t)
		{
			if (this._array == null || this._size == this._array.Length)
			{
				Array.Resize<T>(ref this._array, (this._size != 0) ? (2 * this._size) : 16);
			}
			this._version++;
			this._array[this._size++] = t;
		}

		/// <summary>Copies the <see cref="T:System.Collections.Generic.Stack`1" /> to a new array.</summary>
		/// <returns>A new array containing copies of the elements of the <see cref="T:System.Collections.Generic.Stack`1" />.</returns>
		// Token: 0x0600076A RID: 1898 RVA: 0x0002CDB0 File Offset: 0x0002AFB0
		public T[] ToArray()
		{
			T[] array = new T[this._size];
			this.CopyTo(array, 0);
			return array;
		}

		/// <summary>Sets the capacity to the actual number of elements in the <see cref="T:System.Collections.Generic.Stack`1" />, if that number is less than 90 percent of current capacity.</summary>
		// Token: 0x0600076B RID: 1899 RVA: 0x0002CDD4 File Offset: 0x0002AFD4
		public void TrimExcess()
		{
			if (this._array != null && (double)this._size < (double)this._array.Length * 0.9)
			{
				Array.Resize<T>(ref this._array, this._size);
			}
			this._version++;
		}

		/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Generic.Stack`1" />.</summary>
		/// <returns>The number of elements contained in the <see cref="T:System.Collections.Generic.Stack`1" />.</returns>
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x0000735F File Offset: 0x0000555F
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		/// <summary>Returns an enumerator for the <see cref="T:System.Collections.Generic.Stack`1" />.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.Stack`1.Enumerator" /> for the <see cref="T:System.Collections.Generic.Stack`1" />.</returns>
		// Token: 0x0600076D RID: 1901 RVA: 0x00007367 File Offset: 0x00005567
		public Stack<T>.Enumerator GetEnumerator()
		{
			return new Stack<T>.Enumerator(this);
		}

		// Token: 0x04000209 RID: 521
		private const int INITIAL_SIZE = 16;

		// Token: 0x0400020A RID: 522
		private T[] _array;

		// Token: 0x0400020B RID: 523
		private int _size;

		// Token: 0x0400020C RID: 524
		private int _version;

		/// <summary>Enumerates the elements of a <see cref="T:System.Collections.Generic.Stack`1" />.</summary>
		// Token: 0x020000AF RID: 175
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x0600076E RID: 1902 RVA: 0x0000736F File Offset: 0x0000556F
			internal Enumerator(Stack<T> t)
			{
				this.parent = t;
				this.idx = -2;
				this._version = t._version;
			}

			/// <summary>Sets the enumerator to its initial position, which is before the first element in the collection. This class cannot be inherited.</summary>
			/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
			// Token: 0x0600076F RID: 1903 RVA: 0x0000738C File Offset: 0x0000558C
			void IEnumerator.Reset()
			{
				if (this._version != this.parent._version)
				{
					throw new InvalidOperationException();
				}
				this.idx = -2;
			}

			/// <summary>Gets the element at the current position of the enumerator.</summary>
			/// <returns>The element in the collection at the current position of the enumerator.</returns>
			/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
			// Token: 0x1700018B RID: 395
			// (get) Token: 0x06000770 RID: 1904 RVA: 0x000073B2 File Offset: 0x000055B2
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			/// <summary>Releases all resources used by the <see cref="T:System.Collections.Generic.Stack`1.Enumerator" />.</summary>
			// Token: 0x06000771 RID: 1905 RVA: 0x000073BF File Offset: 0x000055BF
			public void Dispose()
			{
				this.idx = -2;
			}

			/// <summary>Advances the enumerator to the next element of the <see cref="T:System.Collections.Generic.Stack`1" />.</summary>
			/// <returns>true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.</returns>
			/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
			// Token: 0x06000772 RID: 1906 RVA: 0x0002CE2C File Offset: 0x0002B02C
			public bool MoveNext()
			{
				if (this._version != this.parent._version)
				{
					throw new InvalidOperationException();
				}
				if (this.idx == -2)
				{
					this.idx = this.parent._size;
				}
				return this.idx != -1 && --this.idx != -1;
			}

			/// <summary>Gets the element at the current position of the enumerator.</summary>
			/// <returns>The element in the <see cref="T:System.Collections.Generic.Stack`1" /> at the current position of the enumerator.</returns>
			/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
			// Token: 0x1700018C RID: 396
			// (get) Token: 0x06000773 RID: 1907 RVA: 0x000073C9 File Offset: 0x000055C9
			public T Current
			{
				get
				{
					if (this.idx < 0)
					{
						throw new InvalidOperationException();
					}
					return this.parent._array[this.idx];
				}
			}

			// Token: 0x0400020D RID: 525
			private const int NOT_STARTED = -2;

			// Token: 0x0400020E RID: 526
			private const int FINISHED = -1;

			// Token: 0x0400020F RID: 527
			private Stack<T> parent;

			// Token: 0x04000210 RID: 528
			private int idx;

			// Token: 0x04000211 RID: 529
			private int _version;
		}
	}
}
