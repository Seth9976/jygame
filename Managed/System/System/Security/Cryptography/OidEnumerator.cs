using System;
using System.Collections;

namespace System.Security.Cryptography
{
	/// <summary>Provides the ability to navigate through an <see cref="T:System.Security.Cryptography.OidCollection" /> object. This class cannot be inherited.</summary>
	// Token: 0x02000452 RID: 1106
	public sealed class OidEnumerator : IEnumerator
	{
		// Token: 0x06002740 RID: 10048 RVA: 0x0001B68A File Offset: 0x0001988A
		internal OidEnumerator(OidCollection collection)
		{
			this._collection = collection;
			this._position = -1;
		}

		/// <summary>Gets the current <see cref="T:System.Security.Cryptography.Oid" /> object in an <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>The current <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06002741 RID: 10049 RVA: 0x0001B6A0 File Offset: 0x000198A0
		object IEnumerator.Current
		{
			get
			{
				if (this._position < 0)
				{
					throw new ArgumentOutOfRangeException();
				}
				return this._collection[this._position];
			}
		}

		/// <summary>Gets the current <see cref="T:System.Security.Cryptography.Oid" /> object in an <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>The current <see cref="T:System.Security.Cryptography.Oid" /> object in the collection.</returns>
		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x0001B6A0 File Offset: 0x000198A0
		public Oid Current
		{
			get
			{
				if (this._position < 0)
				{
					throw new ArgumentOutOfRangeException();
				}
				return this._collection[this._position];
			}
		}

		/// <summary>Advances to the next <see cref="T:System.Security.Cryptography.Oid" /> object in an <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>true, if the enumerator was successfully advanced to the next element; false, if the enumerator has passed the end of the collection.</returns>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created.</exception>
		// Token: 0x06002743 RID: 10051 RVA: 0x000740B8 File Offset: 0x000722B8
		public bool MoveNext()
		{
			if (++this._position < this._collection.Count)
			{
				return true;
			}
			this._position = this._collection.Count - 1;
			return false;
		}

		/// <summary>Sets an enumerator to its initial position.</summary>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created.</exception>
		// Token: 0x06002744 RID: 10052 RVA: 0x0001B6C5 File Offset: 0x000198C5
		public void Reset()
		{
			this._position = -1;
		}

		// Token: 0x04001802 RID: 6146
		private OidCollection _collection;

		// Token: 0x04001803 RID: 6147
		private int _position;
	}
}
