using System;

namespace System.Security.Cryptography
{
	/// <summary>Represents a cryptographic object identifier. This class cannot be inherited.</summary>
	// Token: 0x02000451 RID: 1105
	public sealed class Oid
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Oid" /> class.</summary>
		// Token: 0x06002736 RID: 10038 RVA: 0x000021C3 File Offset: 0x000003C3
		public Oid()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Oid" /> class using a string value of an <see cref="T:System.Security.Cryptography.Oid" /> object.</summary>
		/// <param name="oid">An object identifier.</param>
		// Token: 0x06002737 RID: 10039 RVA: 0x0001B5D0 File Offset: 0x000197D0
		public Oid(string oid)
		{
			if (oid == null)
			{
				throw new ArgumentNullException("oid");
			}
			this._value = oid;
			this._name = this.GetName(oid);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Oid" /> class using the specified value and friendly name.</summary>
		/// <param name="value">The dotted number of the identifier.</param>
		/// <param name="friendlyName">The friendly name of the identifier.</param>
		// Token: 0x06002738 RID: 10040 RVA: 0x0001B5FD File Offset: 0x000197FD
		public Oid(string value, string friendlyName)
		{
			this._value = value;
			this._name = friendlyName;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Oid" /> class using the specified <see cref="T:System.Security.Cryptography.Oid" /> object.</summary>
		/// <param name="oid">The object identifier information to use to create the new object identifier.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="oid " />is null.</exception>
		// Token: 0x06002739 RID: 10041 RVA: 0x0001B613 File Offset: 0x00019813
		public Oid(Oid oid)
		{
			if (oid == null)
			{
				throw new ArgumentNullException("oid");
			}
			this._value = oid.Value;
			this._name = oid.FriendlyName;
		}

		/// <summary>Gets or sets the friendly name of the identifier.</summary>
		/// <returns>The friendly name of the identifier.</returns>
		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x0001B644 File Offset: 0x00019844
		// (set) Token: 0x0600273B RID: 10043 RVA: 0x0001B64C File Offset: 0x0001984C
		public string FriendlyName
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
				this._value = this.GetValue(this._name);
			}
		}

		/// <summary>Gets or sets the dotted number of the identifier.</summary>
		/// <returns>The dotted number of the identifier.</returns>
		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x0600273C RID: 10044 RVA: 0x0001B667 File Offset: 0x00019867
		// (set) Token: 0x0600273D RID: 10045 RVA: 0x0001B66F File Offset: 0x0001986F
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
				this._name = this.GetName(this._value);
			}
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x00073DA0 File Offset: 0x00071FA0
		private string GetName(string oid)
		{
			switch (oid)
			{
			case "1.2.840.113549.1.1.1":
				return "RSA";
			case "1.2.840.113549.1.7.1":
				return "PKCS 7 Data";
			case "1.2.840.113549.1.9.3":
				return "Content Type";
			case "1.2.840.113549.1.9.4":
				return "Message Digest";
			case "1.2.840.113549.1.9.5":
				return "Signing Time";
			case "1.2.840.113549.3.7":
				return "3des";
			case "2.5.29.19":
				return "Basic Constraints";
			case "2.5.29.15":
				return "Key Usage";
			case "2.5.29.37":
				return "Enhanced Key Usage";
			case "2.5.29.14":
				return "Subject Key Identifier";
			case "2.5.29.17":
				return "Subject Alternative Name";
			case "2.16.840.1.113730.1.1":
				return "Netscape Cert Type";
			case "1.2.840.113549.2.5":
				return "md5";
			case "1.3.14.3.2.26":
				return "sha1";
			}
			return this._name;
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x00073F2C File Offset: 0x0007212C
		private string GetValue(string name)
		{
			switch (name)
			{
			case "RSA":
				return "1.2.840.113549.1.1.1";
			case "PKCS 7 Data":
				return "1.2.840.113549.1.7.1";
			case "Content Type":
				return "1.2.840.113549.1.9.3";
			case "Message Digest":
				return "1.2.840.113549.1.9.4";
			case "Signing Time":
				return "1.2.840.113549.1.9.5";
			case "3des":
				return "1.2.840.113549.3.7";
			case "Basic Constraints":
				return "2.5.29.19";
			case "Key Usage":
				return "2.5.29.15";
			case "Enhanced Key Usage":
				return "2.5.29.37";
			case "Subject Key Identifier":
				return "2.5.29.14";
			case "Subject Alternative Name":
				return "2.5.29.17";
			case "Netscape Cert Type":
				return "2.16.840.1.113730.1.1";
			case "md5":
				return "1.2.840.113549.2.5";
			case "sha1":
				return "1.3.14.3.2.26";
			}
			return this._value;
		}

		// Token: 0x040017EA RID: 6122
		internal const string oidRSA = "1.2.840.113549.1.1.1";

		// Token: 0x040017EB RID: 6123
		internal const string nameRSA = "RSA";

		// Token: 0x040017EC RID: 6124
		internal const string oidPkcs7Data = "1.2.840.113549.1.7.1";

		// Token: 0x040017ED RID: 6125
		internal const string namePkcs7Data = "PKCS 7 Data";

		// Token: 0x040017EE RID: 6126
		internal const string oidPkcs9ContentType = "1.2.840.113549.1.9.3";

		// Token: 0x040017EF RID: 6127
		internal const string namePkcs9ContentType = "Content Type";

		// Token: 0x040017F0 RID: 6128
		internal const string oidPkcs9MessageDigest = "1.2.840.113549.1.9.4";

		// Token: 0x040017F1 RID: 6129
		internal const string namePkcs9MessageDigest = "Message Digest";

		// Token: 0x040017F2 RID: 6130
		internal const string oidPkcs9SigningTime = "1.2.840.113549.1.9.5";

		// Token: 0x040017F3 RID: 6131
		internal const string namePkcs9SigningTime = "Signing Time";

		// Token: 0x040017F4 RID: 6132
		internal const string oidMd5 = "1.2.840.113549.2.5";

		// Token: 0x040017F5 RID: 6133
		internal const string nameMd5 = "md5";

		// Token: 0x040017F6 RID: 6134
		internal const string oid3Des = "1.2.840.113549.3.7";

		// Token: 0x040017F7 RID: 6135
		internal const string name3Des = "3des";

		// Token: 0x040017F8 RID: 6136
		internal const string oidSha1 = "1.3.14.3.2.26";

		// Token: 0x040017F9 RID: 6137
		internal const string nameSha1 = "sha1";

		// Token: 0x040017FA RID: 6138
		internal const string oidSubjectAltName = "2.5.29.17";

		// Token: 0x040017FB RID: 6139
		internal const string nameSubjectAltName = "Subject Alternative Name";

		// Token: 0x040017FC RID: 6140
		internal const string oidNetscapeCertType = "2.16.840.1.113730.1.1";

		// Token: 0x040017FD RID: 6141
		internal const string nameNetscapeCertType = "Netscape Cert Type";

		// Token: 0x040017FE RID: 6142
		private string _value;

		// Token: 0x040017FF RID: 6143
		private string _name;
	}
}
