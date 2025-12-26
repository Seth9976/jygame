using System;
using System.Collections;

namespace System.Security.Cryptography
{
	/// <summary>Represents a collection of <see cref="T:System.Security.Cryptography.Oid" /> objects. This class cannot be inherited.</summary>
	// Token: 0x02000450 RID: 1104
	public sealed class OidCollection : ICollection, IEnumerable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.OidCollection" /> class.</summary>
		// Token: 0x06002728 RID: 10024 RVA: 0x0001B53C File Offset: 0x0001973C
		public OidCollection()
		{
			this._list = new ArrayList();
		}

		/// <summary>Copies the <see cref="T:System.Security.Cryptography.OidCollection" /> object into an array.</summary>
		/// <param name="array">The array to copy the <see cref="T:System.Security.Cryptography.OidCollection" /> object to.</param>
		/// <param name="index">The location where the copy operation starts.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> cannot be a multidimensional array.-or-The length of <paramref name="array" /> is an invalid offset length.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="index" /> is out range.</exception>
		// Token: 0x06002729 RID: 10025 RVA: 0x0001B54F File Offset: 0x0001974F
		void ICollection.CopyTo(Array array, int index)
		{
			this._list.CopyTo(array, index);
		}

		/// <summary>Returns an <see cref="T:System.Security.Cryptography.OidEnumerator" /> object that can be used to navigate the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.OidEnumerator" /> object that can be used to navigate the collection.</returns>
		// Token: 0x0600272A RID: 10026 RVA: 0x0001B55E File Offset: 0x0001975E
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new OidEnumerator(this);
		}

		/// <summary>Gets the number of <see cref="T:System.Security.Cryptography.Oid" /> objects in a collection. </summary>
		/// <returns>The number of <see cref="T:System.Security.Cryptography.Oid" /> objects in a collection.</returns>
		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x0001B566 File Offset: 0x00019766
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Gets a value that indicates whether access to the <see cref="T:System.Security.Cryptography.OidCollection" /> object is thread safe.</summary>
		/// <returns>false in all cases.</returns>
		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x0600272C RID: 10028 RVA: 0x0001B573 File Offset: 0x00019773
		public bool IsSynchronized
		{
			get
			{
				return this._list.IsSynchronized;
			}
		}

		/// <summary>Gets an <see cref="T:System.Security.Cryptography.Oid" /> object from the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
		/// <param name="index">The location of the <see cref="T:System.Security.Cryptography.Oid" /> object in the collection.</param>
		// Token: 0x17000AF0 RID: 2800
		public Oid this[int index]
		{
			get
			{
				return (Oid)this._list[index];
			}
		}

		/// <summary>Gets the first <see cref="T:System.Security.Cryptography.Oid" /> object that contains a value of the <see cref="P:System.Security.Cryptography.Oid.Value" /> property or a value of the <see cref="P:System.Security.Cryptography.Oid.FriendlyName" /> property that matches the specified string value from the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
		/// <param name="oid">A string that represents a <see cref="P:System.Security.Cryptography.Oid.Value" /> property or a <see cref="P:System.Security.Cryptography.Oid.FriendlyName" /> property.</param>
		// Token: 0x17000AF1 RID: 2801
		public Oid this[string oid]
		{
			get
			{
				foreach (object obj in this._list)
				{
					Oid oid2 = (Oid)obj;
					if (oid2.Value == oid)
					{
						return oid2;
					}
				}
				return null;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</returns>
		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x0600272F RID: 10031 RVA: 0x0001B593 File Offset: 0x00019793
		public object SyncRoot
		{
			get
			{
				return this._list.SyncRoot;
			}
		}

		/// <summary>Adds an <see cref="T:System.Security.Cryptography.Oid" /> object to the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>The index of the added <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
		/// <param name="oid">The <see cref="T:System.Security.Cryptography.Oid" /> object to add to the collection.</param>
		// Token: 0x06002730 RID: 10032 RVA: 0x0001B5A0 File Offset: 0x000197A0
		public int Add(Oid oid)
		{
			return (!this._readOnly) ? this._list.Add(oid) : 0;
		}

		/// <summary>Copies the <see cref="T:System.Security.Cryptography.OidCollection" /> object into an array.</summary>
		/// <param name="array">The array to copy the <see cref="T:System.Security.Cryptography.OidCollection" /> object into.</param>
		/// <param name="index">The location where the copy operation starts.</param>
		// Token: 0x06002731 RID: 10033 RVA: 0x0001B54F File Offset: 0x0001974F
		public void CopyTo(Oid[] array, int index)
		{
			this._list.CopyTo(array, index);
		}

		/// <summary>Returns an <see cref="T:System.Security.Cryptography.OidEnumerator" /> object that can be used to navigate the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.OidEnumerator" /> object.</returns>
		// Token: 0x06002732 RID: 10034 RVA: 0x0001B55E File Offset: 0x0001975E
		public OidEnumerator GetEnumerator()
		{
			return new OidEnumerator(this);
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002733 RID: 10035 RVA: 0x0001B5BF File Offset: 0x000197BF
		// (set) Token: 0x06002734 RID: 10036 RVA: 0x0001B5C7 File Offset: 0x000197C7
		internal bool ReadOnly
		{
			get
			{
				return this._readOnly;
			}
			set
			{
				this._readOnly = value;
			}
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x00073D2C File Offset: 0x00071F2C
		internal OidCollection ReadOnlyCopy()
		{
			OidCollection oidCollection = new OidCollection();
			foreach (object obj in this._list)
			{
				Oid oid = (Oid)obj;
				oidCollection.Add(oid);
			}
			oidCollection._readOnly = true;
			return oidCollection;
		}

		// Token: 0x040017E8 RID: 6120
		private ArrayList _list;

		// Token: 0x040017E9 RID: 6121
		private bool _readOnly;
	}
}
