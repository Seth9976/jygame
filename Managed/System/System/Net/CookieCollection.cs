using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace System.Net
{
	/// <summary>Provides a collection container for instances of the <see cref="T:System.Net.Cookie" /> class.</summary>
	// Token: 0x020002FC RID: 764
	[Serializable]
	public class CookieCollection : ICollection, IEnumerable
	{
		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x00013160 File Offset: 0x00011360
		internal IList<Cookie> List
		{
			get
			{
				return this.list;
			}
		}

		/// <summary>Gets the number of cookies contained in a <see cref="T:System.Net.CookieCollection" />.</summary>
		/// <returns>The number of cookies contained in a <see cref="T:System.Net.CookieCollection" />.</returns>
		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00013168 File Offset: 0x00011368
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		/// <summary>Gets a value that indicates whether access to a <see cref="T:System.Net.CookieCollection" /> is thread safe.</summary>
		/// <returns>true if access to the <see cref="T:System.Net.CookieCollection" /> is thread safe; otherwise, false. The default is false.</returns>
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that you can use to synchronize access to the <see cref="T:System.Net.CookieCollection" />.</summary>
		/// <returns>An object that you can use to synchronize access to the <see cref="T:System.Net.CookieCollection" />.</returns>
		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x000021CB File Offset: 0x000003CB
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Copies the elements of a <see cref="T:System.Net.CookieCollection" /> to an instance of the <see cref="T:System.Array" /> class, starting at a particular index.</summary>
		/// <param name="array">The target <see cref="T:System.Array" /> to which the <see cref="T:System.Net.CookieCollection" /> will be copied. </param>
		/// <param name="index">The zero-based index in the target <see cref="T:System.Array" /> where copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is multidimensional.-or- The number of elements in this <see cref="T:System.Net.CookieCollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The elements in this <see cref="T:System.Net.CookieCollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x060019D3 RID: 6611 RVA: 0x00013175 File Offset: 0x00011375
		public void CopyTo(Array array, int index)
		{
			((ICollection)this.list).CopyTo(array, index);
		}

		/// <summary>Copies the elements of this <see cref="T:System.Net.CookieCollection" /> to a <see cref="T:System.Net.Cookie" /> array starting at the specified index of the target array.</summary>
		/// <param name="array">The target <see cref="T:System.Net.Cookie" /> array to which the <see cref="T:System.Net.CookieCollection" /> will be copied.</param>
		/// <param name="index">The zero-based index in the target <see cref="T:System.Array" /> where copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is multidimensional.-or- The number of elements in this <see cref="T:System.Net.CookieCollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The elements in this <see cref="T:System.Net.CookieCollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x060019D4 RID: 6612 RVA: 0x00013184 File Offset: 0x00011384
		public void CopyTo(Cookie[] array, int index)
		{
			this.list.CopyTo(array, index);
		}

		/// <summary>Gets an enumerator that can iterate through a <see cref="T:System.Net.CookieCollection" />.</summary>
		/// <returns>An instance of an implementation of an <see cref="T:System.Collections.IEnumerator" /> interface that can iterate through a <see cref="T:System.Net.CookieCollection" />.</returns>
		// Token: 0x060019D5 RID: 6613 RVA: 0x00013193 File Offset: 0x00011393
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		/// <summary>Gets a value that indicates whether a <see cref="T:System.Net.CookieCollection" /> is read-only.</summary>
		/// <returns>true if this is a read-only <see cref="T:System.Net.CookieCollection" />; otherwise, false. The default is true.</returns>
		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x000025B7 File Offset: 0x000007B7
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Adds a <see cref="T:System.Net.Cookie" /> to a <see cref="T:System.Net.CookieCollection" />.</summary>
		/// <param name="cookie">The <see cref="T:System.Net.Cookie" /> to be added to a <see cref="T:System.Net.CookieCollection" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="cookie" /> is null. </exception>
		// Token: 0x060019D7 RID: 6615 RVA: 0x0004CE34 File Offset: 0x0004B034
		public void Add(Cookie cookie)
		{
			if (cookie == null)
			{
				throw new ArgumentNullException("cookie");
			}
			int num = this.SearchCookie(cookie);
			if (num == -1)
			{
				this.list.Add(cookie);
			}
			else
			{
				this.list[num] = cookie;
			}
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x000131A5 File Offset: 0x000113A5
		internal void Sort()
		{
			if (this.list.Count > 0)
			{
				this.list.Sort(CookieCollection.Comparer);
			}
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x0004CE80 File Offset: 0x0004B080
		private int SearchCookie(Cookie cookie)
		{
			string name = cookie.Name;
			string domain = cookie.Domain;
			string path = cookie.Path;
			for (int i = this.list.Count - 1; i >= 0; i--)
			{
				Cookie cookie2 = this.list[i];
				if (cookie2.Version == cookie.Version)
				{
					if (string.Compare(domain, cookie2.Domain, true, CultureInfo.InvariantCulture) == 0)
					{
						if (string.Compare(name, cookie2.Name, true, CultureInfo.InvariantCulture) == 0)
						{
							if (string.Compare(path, cookie2.Path, true, CultureInfo.InvariantCulture) == 0)
							{
								return i;
							}
						}
					}
				}
			}
			return -1;
		}

		/// <summary>Adds the contents of a <see cref="T:System.Net.CookieCollection" /> to the current instance.</summary>
		/// <param name="cookies">The <see cref="T:System.Net.CookieCollection" /> to be added. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="cookies" /> is null. </exception>
		// Token: 0x060019DA RID: 6618 RVA: 0x0004CF40 File Offset: 0x0004B140
		public void Add(CookieCollection cookies)
		{
			if (cookies == null)
			{
				throw new ArgumentNullException("cookies");
			}
			foreach (object obj in cookies)
			{
				Cookie cookie = (Cookie)obj;
				this.Add(cookie);
			}
		}

		/// <summary>Gets the <see cref="T:System.Net.Cookie" /> with a specific index from a <see cref="T:System.Net.CookieCollection" />.</summary>
		/// <returns>A <see cref="T:System.Net.Cookie" /> with a specific index from a <see cref="T:System.Net.CookieCollection" />.</returns>
		/// <param name="index">The zero-based index of the <see cref="T:System.Net.Cookie" /> to be found. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than 0 or <paramref name="index" /> is greater than or equal to <see cref="P:System.Net.CookieCollection.Count" />. </exception>
		// Token: 0x17000634 RID: 1588
		public Cookie this[int index]
		{
			get
			{
				if (index < 0 || index >= this.list.Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return this.list[index];
			}
		}

		/// <summary>Gets the <see cref="T:System.Net.Cookie" /> with a specific name from a <see cref="T:System.Net.CookieCollection" />.</summary>
		/// <returns>The <see cref="T:System.Net.Cookie" /> with a specific name from a <see cref="T:System.Net.CookieCollection" />.</returns>
		/// <param name="name">The name of the <see cref="T:System.Net.Cookie" /> to be found. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null. </exception>
		// Token: 0x17000635 RID: 1589
		public Cookie this[string name]
		{
			get
			{
				foreach (Cookie cookie in this.list)
				{
					if (string.Compare(cookie.Name, name, true, CultureInfo.InvariantCulture) == 0)
					{
						return cookie;
					}
				}
				return null;
			}
		}

		// Token: 0x04001026 RID: 4134
		private List<Cookie> list = new List<Cookie>();

		// Token: 0x04001027 RID: 4135
		private static CookieCollection.CookieCollectionComparer Comparer = new CookieCollection.CookieCollectionComparer();

		// Token: 0x020002FD RID: 765
		private sealed class CookieCollectionComparer : IComparer<Cookie>
		{
			// Token: 0x060019DE RID: 6622 RVA: 0x0004D024 File Offset: 0x0004B224
			public int Compare(Cookie x, Cookie y)
			{
				if (x == null || y == null)
				{
					return 0;
				}
				int num = x.Name.Length + x.Value.Length;
				int num2 = y.Name.Length + y.Value.Length;
				return num - num2;
			}
		}
	}
}
