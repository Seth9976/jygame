using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Represents the chain policy to be applied when building an X509 certificate chain. This class cannot be inherited.</summary>
	// Token: 0x02000465 RID: 1125
	public sealed class X509ChainPolicy
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" /> class. </summary>
		// Token: 0x06002816 RID: 10262 RVA: 0x0001BEBA File Offset: 0x0001A0BA
		public X509ChainPolicy()
		{
			this.Reset();
		}

		/// <summary>Gets a collection of object identifiers (OIDs) specifying which application policies or enhanced key usages (EKUs) the certificate supports.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.OidCollection" />  object.</returns>
		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x0001BEC8 File Offset: 0x0001A0C8
		public OidCollection ApplicationPolicy
		{
			get
			{
				return this.apps;
			}
		}

		/// <summary>Gets a collection of object identifiers (OIDs) specifying which certificate policies the certificate supports.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.OidCollection" /> object.</returns>
		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x0001BED0 File Offset: 0x0001A0D0
		public OidCollection CertificatePolicy
		{
			get
			{
				return this.cert;
			}
		}

		/// <summary>Represents an additional collection of certificates that can be searched by the chaining engine when validating a certificate chain.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</returns>
		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x0001BED8 File Offset: 0x0001A0D8
		public X509Certificate2Collection ExtraStore
		{
			get
			{
				return this.store;
			}
		}

		/// <summary>Gets or sets values for X509 revocation flags.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationFlag" /> object.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationFlag" /> value supplied is not a valid flag. </exception>
		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x0600281A RID: 10266 RVA: 0x0001BEE0 File Offset: 0x0001A0E0
		// (set) Token: 0x0600281B RID: 10267 RVA: 0x0001BEE8 File Offset: 0x0001A0E8
		public X509RevocationFlag RevocationFlag
		{
			get
			{
				return this.rflag;
			}
			set
			{
				if (value < X509RevocationFlag.EndCertificateOnly || value > X509RevocationFlag.ExcludeRoot)
				{
					throw new ArgumentException("RevocationFlag");
				}
				this.rflag = value;
			}
		}

		/// <summary>Gets or sets values for X509 certificate revocation mode.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationMode" /> object.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationMode" /> value supplied is not a valid flag. </exception>
		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x0600281C RID: 10268 RVA: 0x0001BF0A File Offset: 0x0001A10A
		// (set) Token: 0x0600281D RID: 10269 RVA: 0x0001BF12 File Offset: 0x0001A112
		public X509RevocationMode RevocationMode
		{
			get
			{
				return this.mode;
			}
			set
			{
				if (value < X509RevocationMode.NoCheck || value > X509RevocationMode.Offline)
				{
					throw new ArgumentException("RevocationMode");
				}
				this.mode = value;
			}
		}

		/// <summary>Gets the time span that elapsed during online revocation verification or downloading the certificate revocation list (CRL).</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> object.</returns>
		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x0600281E RID: 10270 RVA: 0x0001BF34 File Offset: 0x0001A134
		// (set) Token: 0x0600281F RID: 10271 RVA: 0x0001BF3C File Offset: 0x0001A13C
		public TimeSpan UrlRetrievalTimeout
		{
			get
			{
				return this.timeout;
			}
			set
			{
				this.timeout = value;
			}
		}

		/// <summary>Gets verification flags for the certificate.</summary>
		/// <returns>A value from the <see cref="T:System.Security.Cryptography.X509Certificates.X509VerificationFlags" /> enumeration.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Security.Cryptography.X509Certificates.X509VerificationFlags" /> value supplied is not a valid flag. <see cref="F:System.Security.Cryptography.X509Certificates.X509VerificationFlags.NoFlag" /> is the default value. </exception>
		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002820 RID: 10272 RVA: 0x0001BF45 File Offset: 0x0001A145
		// (set) Token: 0x06002821 RID: 10273 RVA: 0x0001BF4D File Offset: 0x0001A14D
		public X509VerificationFlags VerificationFlags
		{
			get
			{
				return this.vflags;
			}
			set
			{
				if ((value | X509VerificationFlags.AllFlags) != X509VerificationFlags.AllFlags)
				{
					throw new ArgumentException("VerificationFlags");
				}
				this.vflags = value;
			}
		}

		/// <summary>The time that the certificate was verified expressed in local time.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> object.</returns>
		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002822 RID: 10274 RVA: 0x0001BF72 File Offset: 0x0001A172
		// (set) Token: 0x06002823 RID: 10275 RVA: 0x0001BF7A File Offset: 0x0001A17A
		public DateTime VerificationTime
		{
			get
			{
				return this.vtime;
			}
			set
			{
				this.vtime = value;
			}
		}

		/// <summary>Resets the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" /> members to their default values.</summary>
		// Token: 0x06002824 RID: 10276 RVA: 0x00077CE0 File Offset: 0x00075EE0
		public void Reset()
		{
			this.apps = new OidCollection();
			this.cert = new OidCollection();
			this.store = new X509Certificate2Collection();
			this.rflag = X509RevocationFlag.ExcludeRoot;
			this.mode = X509RevocationMode.Online;
			this.timeout = TimeSpan.Zero;
			this.vflags = X509VerificationFlags.NoFlag;
			this.vtime = DateTime.Now;
		}

		// Token: 0x04001860 RID: 6240
		private OidCollection apps;

		// Token: 0x04001861 RID: 6241
		private OidCollection cert;

		// Token: 0x04001862 RID: 6242
		private X509Certificate2Collection store;

		// Token: 0x04001863 RID: 6243
		private X509RevocationFlag rflag;

		// Token: 0x04001864 RID: 6244
		private X509RevocationMode mode;

		// Token: 0x04001865 RID: 6245
		private TimeSpan timeout;

		// Token: 0x04001866 RID: 6246
		private X509VerificationFlags vflags;

		// Token: 0x04001867 RID: 6247
		private DateTime vtime;
	}
}
