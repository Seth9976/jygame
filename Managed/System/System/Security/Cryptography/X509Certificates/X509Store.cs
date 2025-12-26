using System;
using System.Collections.Generic;
using System.Security.Permissions;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Represents an X.509 store, which is a physical store where certificates are persisted and managed. This class cannot be inherited.</summary>
	// Token: 0x02000473 RID: 1139
	public sealed class X509Store
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" /> class using the personal certificates of the current user store.</summary>
		// Token: 0x06002855 RID: 10325 RVA: 0x0001C1A3 File Offset: 0x0001A3A3
		public X509Store()
			: this("MY", StoreLocation.CurrentUser)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" /> class using the specified store name.</summary>
		/// <param name="storeName">A string value representing the store name. See <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" />  for more information. </param>
		// Token: 0x06002856 RID: 10326 RVA: 0x0001C1B1 File Offset: 0x0001A3B1
		public X509Store(string storeName)
			: this(storeName, StoreLocation.CurrentUser)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" /> class using the specified <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" /> value.</summary>
		/// <param name="storeName">One of the <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" /> values. </param>
		// Token: 0x06002857 RID: 10327 RVA: 0x0001C1BB File Offset: 0x0001A3BB
		public X509Store(StoreName storeName)
			: this(storeName, StoreLocation.CurrentUser)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" /> class using the specified <see cref="T:System.Security.Cryptography.X509Certificates.StoreLocation" /> value.</summary>
		/// <param name="storeLocation">One of the <see cref="T:System.Security.Cryptography.X509Certificates.StoreLocation" /> values. </param>
		// Token: 0x06002858 RID: 10328 RVA: 0x0001C1C5 File Offset: 0x0001A3C5
		public X509Store(StoreLocation storeLocation)
			: this("MY", storeLocation)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" /> class using the specified <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" /> and <see cref="T:System.Security.Cryptography.X509Certificates.StoreLocation" /> values.</summary>
		/// <param name="storeName">One of the <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" /> values. </param>
		/// <param name="storeLocation">One of the <see cref="T:System.Security.Cryptography.X509Certificates.StoreLocation" /> values. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="storeLocation" /> is not a valid location or <paramref name="storeName" /> is not a valid name. </exception>
		// Token: 0x06002859 RID: 10329 RVA: 0x00078ADC File Offset: 0x00076CDC
		public X509Store(StoreName storeName, StoreLocation storeLocation)
		{
			if (storeName < StoreName.AddressBook || storeName > StoreName.TrustedPublisher)
			{
				throw new ArgumentException("storeName");
			}
			if (storeLocation < StoreLocation.CurrentUser || storeLocation > StoreLocation.LocalMachine)
			{
				throw new ArgumentException("storeLocation");
			}
			if (storeName != StoreName.CertificateAuthority)
			{
				this._name = storeName.ToString();
			}
			else
			{
				this._name = "CA";
			}
			this._location = storeLocation;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" /> class using an Intptr handle to an HCERTSTORE store.</summary>
		/// <param name="storeHandle">An <see cref="T:System.IntPtr" /> handle to an HCERTSTORE store.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="storeHandle" /> parameter is null.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The <paramref name="storeHandle" /> parameter points to an invalid context.</exception>
		// Token: 0x0600285A RID: 10330 RVA: 0x0001C1D3 File Offset: 0x0001A3D3
		[global::System.MonoTODO("Mono's stores are fully managed. All handles are invalid.")]
		[PermissionSet(SecurityAction.LinkDemand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\">\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\nversion=\"1\"\nFlags=\"UnmanagedCode\"/>\n</PermissionSet>\n")]
		public X509Store(IntPtr storeHandle)
		{
			if (storeHandle == IntPtr.Zero)
			{
				throw new ArgumentNullException("storeHandle");
			}
			throw new CryptographicException("Invalid handle.");
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" /> class using a string representing a value from the <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" /> enumeration and a value from the <see cref="T:System.Security.Cryptography.X509Certificates.StoreLocation" /> enumeration.</summary>
		/// <param name="storeName">A string representing a value from the <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" /> enumeration. </param>
		/// <param name="storeLocation">One of the <see cref="T:System.Security.Cryptography.X509Certificates.StoreLocation" /> values. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="storeLocation" /> contains invalid values. </exception>
		// Token: 0x0600285B RID: 10331 RVA: 0x0001C200 File Offset: 0x0001A400
		public X509Store(string storeName, StoreLocation storeLocation)
		{
			if (storeLocation < StoreLocation.CurrentUser || storeLocation > StoreLocation.LocalMachine)
			{
				throw new ArgumentException("storeLocation");
			}
			this._name = storeName;
			this._location = storeLocation;
		}

		/// <summary>Returns a collection of certificates located in an X.509 certificate store.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</returns>
		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x0600285C RID: 10332 RVA: 0x0001C22F File Offset: 0x0001A42F
		public X509Certificate2Collection Certificates
		{
			get
			{
				if (this.list == null)
				{
					this.list = new X509Certificate2Collection();
				}
				else if (this.store == null)
				{
					this.list.Clear();
				}
				return this.list;
			}
		}

		/// <summary>Gets the location of the X.509 certificate store.</summary>
		/// <returns>One of the <see cref="T:System.Security.Cryptography.X509Certificates.StoreLocation" /> values.</returns>
		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x0001C268 File Offset: 0x0001A468
		public StoreLocation Location
		{
			get
			{
				return this._location;
			}
		}

		/// <summary>Gets the name of the X.509 certificate store.</summary>
		/// <returns>One of the <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" /> values.</returns>
		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x0001C270 File Offset: 0x0001A470
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x0001C278 File Offset: 0x0001A478
		private X509Stores Factory
		{
			get
			{
				if (this._location == StoreLocation.CurrentUser)
				{
					return X509StoreManager.CurrentUser;
				}
				return X509StoreManager.LocalMachine;
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06002860 RID: 10336 RVA: 0x0001C291 File Offset: 0x0001A491
		private bool IsOpen
		{
			get
			{
				return this.store != null;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x0001C29F File Offset: 0x0001A49F
		private bool IsReadOnly
		{
			get
			{
				return Environment.UnityWebSecurityEnabled || (this._flags & OpenFlags.ReadWrite) == OpenFlags.ReadOnly;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002862 RID: 10338 RVA: 0x0001C2B8 File Offset: 0x0001A4B8
		internal X509Store Store
		{
			get
			{
				return this.store;
			}
		}

		/// <summary>Gets an <see cref="T:System.IntPtr" /> handle to an HCERTSTORE store.  </summary>
		/// <returns>An <see cref="T:System.IntPtr" /> handle to an HCERTSTORE store.</returns>
		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x0001BC78 File Offset: 0x00019E78
		[global::System.MonoTODO("Mono's stores are fully managed. Always returns IntPtr.Zero.")]
		public IntPtr StoreHandle
		{
			get
			{
				return IntPtr.Zero;
			}
		}

		/// <summary>Adds a certificate to an X.509 certificate store.</summary>
		/// <param name="certificate">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="certificate" /> is null. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate could not be added to the store.</exception>
		// Token: 0x06002864 RID: 10340 RVA: 0x00078B5C File Offset: 0x00076D5C
		public void Add(X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			if (!this.IsOpen)
			{
				throw new CryptographicException(global::Locale.GetText("Store isn't opened."));
			}
			if (this.IsReadOnly)
			{
				throw new CryptographicException(global::Locale.GetText("Store is read-only."));
			}
			if (!this.Exists(certificate))
			{
				try
				{
					this.store.Import(new X509Certificate(certificate.RawData));
				}
				finally
				{
					this.Certificates.Add(certificate);
				}
			}
		}

		/// <summary>Adds a collection of certificates to an X.509 certificate store.</summary>
		/// <param name="certificates">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="certificates" /> is null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x06002865 RID: 10341 RVA: 0x00078BF8 File Offset: 0x00076DF8
		[global::System.MonoTODO("Method isn't transactional (like documented)")]
		public void AddRange(X509Certificate2Collection certificates)
		{
			if (certificates == null)
			{
				throw new ArgumentNullException("certificates");
			}
			if (certificates.Count == 0)
			{
				return;
			}
			if (!this.IsOpen)
			{
				throw new CryptographicException(global::Locale.GetText("Store isn't opened."));
			}
			if (this.IsReadOnly)
			{
				throw new CryptographicException(global::Locale.GetText("Store is read-only."));
			}
			foreach (X509Certificate2 x509Certificate in certificates)
			{
				if (!this.Exists(x509Certificate))
				{
					try
					{
						this.store.Import(new X509Certificate(x509Certificate.RawData));
					}
					finally
					{
						this.Certificates.Add(x509Certificate);
					}
				}
			}
		}

		/// <summary>Closes an X.509 certificate store.</summary>
		// Token: 0x06002866 RID: 10342 RVA: 0x0001C2C0 File Offset: 0x0001A4C0
		public void Close()
		{
			this.store = null;
			if (this.list != null)
			{
				this.list.Clear();
			}
		}

		/// <summary>Opens an X.509 certificate store or creates a new store, depending on <see cref="T:System.Security.Cryptography.X509Certificates.OpenFlags" /> flag settings.</summary>
		/// <param name="flags">One the <see cref="T:System.Security.Cryptography.X509Certificates.OpenFlags" /> values. </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The store is unreadable. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">The store contains invalid values.</exception>
		// Token: 0x06002867 RID: 10343 RVA: 0x00078CBC File Offset: 0x00076EBC
		public void Open(OpenFlags flags)
		{
			if (string.IsNullOrEmpty(this._name))
			{
				throw new CryptographicException(global::Locale.GetText("Invalid store name (null or empty)."));
			}
			string name = this._name;
			string text;
			if (name != null)
			{
				if (X509Store.<>f__switch$map1B == null)
				{
					X509Store.<>f__switch$map1B = new Dictionary<string, int>(1) { { "Root", 0 } };
				}
				int num;
				if (X509Store.<>f__switch$map1B.TryGetValue(name, out num))
				{
					if (num == 0)
					{
						text = "Trust";
						goto IL_008B;
					}
				}
			}
			text = this._name;
			IL_008B:
			bool flag = (flags & OpenFlags.OpenExistingOnly) != OpenFlags.OpenExistingOnly;
			this.store = this.Factory.Open(text, flag);
			if (this.store == null)
			{
				throw new CryptographicException(global::Locale.GetText("Store {0} doesn't exists.", new object[] { this._name }));
			}
			this._flags = flags;
			foreach (X509Certificate x509Certificate in this.store.Certificates)
			{
				this.Certificates.Add(new X509Certificate2(x509Certificate.RawData));
			}
		}

		/// <summary>Removes a certificate from an X.509 certificate store.</summary>
		/// <param name="certificate">The certificate to remove.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="certificate" /> is null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x06002868 RID: 10344 RVA: 0x00078E0C File Offset: 0x0007700C
		public void Remove(X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			if (!this.IsOpen)
			{
				throw new CryptographicException(global::Locale.GetText("Store isn't opened."));
			}
			if (!this.Exists(certificate))
			{
				return;
			}
			if (this.IsReadOnly)
			{
				throw new CryptographicException(global::Locale.GetText("Store is read-only."));
			}
			try
			{
				this.store.Remove(new X509Certificate(certificate.RawData));
			}
			finally
			{
				this.Certificates.Remove(certificate);
			}
		}

		/// <summary>Removes a range of certificates from an X.509 certificate store.</summary>
		/// <param name="certificates">A range of certificates to remove.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="certificates" /> is null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x06002869 RID: 10345 RVA: 0x00078EA8 File Offset: 0x000770A8
		[global::System.MonoTODO("Method isn't transactional (like documented)")]
		public void RemoveRange(X509Certificate2Collection certificates)
		{
			if (certificates == null)
			{
				throw new ArgumentNullException("certificates");
			}
			if (certificates.Count == 0)
			{
				return;
			}
			if (!this.IsOpen)
			{
				throw new CryptographicException(global::Locale.GetText("Store isn't opened."));
			}
			bool flag = false;
			foreach (X509Certificate2 x509Certificate in certificates)
			{
				if (this.Exists(x509Certificate))
				{
					flag = true;
				}
			}
			if (!flag)
			{
				return;
			}
			if (this.IsReadOnly)
			{
				throw new CryptographicException(global::Locale.GetText("Store is read-only."));
			}
			try
			{
				foreach (X509Certificate2 x509Certificate2 in certificates)
				{
					this.store.Remove(new X509Certificate(x509Certificate2.RawData));
				}
			}
			finally
			{
				this.Certificates.RemoveRange(certificates);
			}
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x00078F98 File Offset: 0x00077198
		private bool Exists(X509Certificate2 certificate)
		{
			if (this.store == null || this.list == null || certificate == null)
			{
				return false;
			}
			foreach (X509Certificate2 x509Certificate in this.list)
			{
				if (certificate.Equals(x509Certificate))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x040018BE RID: 6334
		private string _name;

		// Token: 0x040018BF RID: 6335
		private StoreLocation _location;

		// Token: 0x040018C0 RID: 6336
		private X509Certificate2Collection list;

		// Token: 0x040018C1 RID: 6337
		private OpenFlags _flags;

		// Token: 0x040018C2 RID: 6338
		private X509Store store;
	}
}
