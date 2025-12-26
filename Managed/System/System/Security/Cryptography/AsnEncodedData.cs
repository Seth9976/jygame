using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Mono.Security;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Represents Abstract Syntax Notation One (ASN.1)-encoded data.</summary>
	// Token: 0x0200044E RID: 1102
	public class AsnEncodedData
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class.</summary>
		// Token: 0x06002710 RID: 10000 RVA: 0x000021C3 File Offset: 0x000003C3
		protected AsnEncodedData()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class using a byte array.</summary>
		/// <param name="oid">A string that represents <see cref="T:System.Security.Cryptography.Oid" /> information.</param>
		/// <param name="rawData">A byte array that contains Abstract Syntax Notation One (ASN.1)-encoded data.</param>
		// Token: 0x06002711 RID: 10001 RVA: 0x0001B437 File Offset: 0x00019637
		public AsnEncodedData(string oid, byte[] rawData)
		{
			this._oid = new Oid(oid);
			this.RawData = rawData;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class using an <see cref="T:System.Security.Cryptography.Oid" /> object and a byte array.</summary>
		/// <param name="oid">An <see cref="T:System.Security.Cryptography.Oid" /> object.</param>
		/// <param name="rawData">A byte array that contains Abstract Syntax Notation One (ASN.1)-encoded data.</param>
		// Token: 0x06002712 RID: 10002 RVA: 0x0001B452 File Offset: 0x00019652
		public AsnEncodedData(Oid oid, byte[] rawData)
		{
			this.Oid = oid;
			this.RawData = rawData;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class using an instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class.</summary>
		/// <param name="asnEncodedData">An instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asnEncodedData" /> is null.</exception>
		// Token: 0x06002713 RID: 10003 RVA: 0x00073600 File Offset: 0x00071800
		public AsnEncodedData(AsnEncodedData asnEncodedData)
		{
			if (asnEncodedData == null)
			{
				throw new ArgumentNullException("asnEncodedData");
			}
			if (asnEncodedData._oid != null)
			{
				this.Oid = new Oid(asnEncodedData._oid);
			}
			this.RawData = asnEncodedData._raw;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class using a byte array.</summary>
		/// <param name="rawData">A byte array that contains Abstract Syntax Notation One (ASN.1)-encoded data.</param>
		// Token: 0x06002714 RID: 10004 RVA: 0x0001B468 File Offset: 0x00019668
		public AsnEncodedData(byte[] rawData)
		{
			this.RawData = rawData;
		}

		/// <summary>Gets or sets the <see cref="T:System.Security.Cryptography.Oid" /> value for an <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x0001B477 File Offset: 0x00019677
		// (set) Token: 0x06002716 RID: 10006 RVA: 0x0001B47F File Offset: 0x0001967F
		public Oid Oid
		{
			get
			{
				return this._oid;
			}
			set
			{
				if (value == null)
				{
					this._oid = null;
				}
				else
				{
					this._oid = new Oid(value);
				}
			}
		}

		/// <summary>Gets or sets the Abstract Syntax Notation One (ASN.1)-encoded data represented in a byte array.</summary>
		/// <returns>A byte array that represents the Abstract Syntax Notation One (ASN.1)-encoded data.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value is null.</exception>
		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x0001B49F File Offset: 0x0001969F
		// (set) Token: 0x06002718 RID: 10008 RVA: 0x0001B4A7 File Offset: 0x000196A7
		public byte[] RawData
		{
			get
			{
				return this._raw;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("RawData");
				}
				this._raw = (byte[])value.Clone();
			}
		}

		/// <summary>Copies information from an <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object.</summary>
		/// <param name="asnEncodedData">The <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object to base the new object on.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asnEncodedData " />is null.</exception>
		// Token: 0x06002719 RID: 10009 RVA: 0x0007364C File Offset: 0x0007184C
		public virtual void CopyFrom(AsnEncodedData asnEncodedData)
		{
			if (asnEncodedData == null)
			{
				throw new ArgumentNullException("asnEncodedData");
			}
			if (asnEncodedData._oid == null)
			{
				this.Oid = null;
			}
			else
			{
				this.Oid = new Oid(asnEncodedData._oid);
			}
			this.RawData = asnEncodedData._raw;
		}

		/// <summary>Returns a formatted version of the Abstract Syntax Notation One (ASN.1)-encoded data as a string.</summary>
		/// <returns>A formatted string that represents the Abstract Syntax Notation One (ASN.1)-encoded data.</returns>
		/// <param name="multiLine">true if the return string should contain carriage returns; otherwise, false.</param>
		// Token: 0x0600271A RID: 10010 RVA: 0x0001B4CB File Offset: 0x000196CB
		public virtual string Format(bool multiLine)
		{
			if (this._raw == null)
			{
				return string.Empty;
			}
			if (this._oid == null)
			{
				return this.Default(multiLine);
			}
			return this.ToString(multiLine);
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x000736A0 File Offset: 0x000718A0
		internal virtual string ToString(bool multiLine)
		{
			string value = this._oid.Value;
			switch (value)
			{
			case "2.5.29.19":
				return this.BasicConstraintsExtension(multiLine);
			case "2.5.29.37":
				return this.EnhancedKeyUsageExtension(multiLine);
			case "2.5.29.15":
				return this.KeyUsageExtension(multiLine);
			case "2.5.29.14":
				return this.SubjectKeyIdentifierExtension(multiLine);
			case "2.5.29.17":
				return this.SubjectAltName(multiLine);
			case "2.16.840.1.113730.1.1":
				return this.NetscapeCertType(multiLine);
			}
			return this.Default(multiLine);
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x0007378C File Offset: 0x0007198C
		internal string Default(bool multiLine)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < this._raw.Length; i++)
			{
				stringBuilder.Append(this._raw[i].ToString("x2"));
				if (i != this._raw.Length - 1)
				{
					stringBuilder.Append(" ");
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x000737F8 File Offset: 0x000719F8
		internal string BasicConstraintsExtension(bool multiLine)
		{
			string text;
			try
			{
				global::System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension x509BasicConstraintsExtension = new global::System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension(this, false);
				text = x509BasicConstraintsExtension.ToString(multiLine);
			}
			catch
			{
				text = string.Empty;
			}
			return text;
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00073844 File Offset: 0x00071A44
		internal string EnhancedKeyUsageExtension(bool multiLine)
		{
			string text;
			try
			{
				global::System.Security.Cryptography.X509Certificates.X509EnhancedKeyUsageExtension x509EnhancedKeyUsageExtension = new global::System.Security.Cryptography.X509Certificates.X509EnhancedKeyUsageExtension(this, false);
				text = x509EnhancedKeyUsageExtension.ToString(multiLine);
			}
			catch
			{
				text = string.Empty;
			}
			return text;
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00073890 File Offset: 0x00071A90
		internal string KeyUsageExtension(bool multiLine)
		{
			string text;
			try
			{
				global::System.Security.Cryptography.X509Certificates.X509KeyUsageExtension x509KeyUsageExtension = new global::System.Security.Cryptography.X509Certificates.X509KeyUsageExtension(this, false);
				text = x509KeyUsageExtension.ToString(multiLine);
			}
			catch
			{
				text = string.Empty;
			}
			return text;
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x000738DC File Offset: 0x00071ADC
		internal string SubjectKeyIdentifierExtension(bool multiLine)
		{
			string text;
			try
			{
				global::System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension x509SubjectKeyIdentifierExtension = new global::System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension(this, false);
				text = x509SubjectKeyIdentifierExtension.ToString(multiLine);
			}
			catch
			{
				text = string.Empty;
			}
			return text;
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x00073928 File Offset: 0x00071B28
		internal string SubjectAltName(bool multiLine)
		{
			if (this._raw.Length < 5)
			{
				return "Information Not Available";
			}
			string text3;
			try
			{
				ASN1 asn = new ASN1(this._raw);
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < asn.Count; i++)
				{
					ASN1 asn2 = asn[i];
					byte tag = asn2.Tag;
					string text;
					string text2;
					if (tag != 129)
					{
						if (tag != 130)
						{
							text = string.Format("Unknown ({0})=", asn2.Tag);
							text2 = CryptoConvert.ToHex(asn2.Value);
						}
						else
						{
							text = "DNS Name=";
							text2 = Encoding.ASCII.GetString(asn2.Value);
						}
					}
					else
					{
						text = "RFC822 Name=";
						text2 = Encoding.ASCII.GetString(asn2.Value);
					}
					stringBuilder.Append(text);
					stringBuilder.Append(text2);
					if (multiLine)
					{
						stringBuilder.Append(Environment.NewLine);
					}
					else if (i < asn.Count - 1)
					{
						stringBuilder.Append(", ");
					}
				}
				text3 = stringBuilder.ToString();
			}
			catch
			{
				text3 = string.Empty;
			}
			return text3;
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00073A90 File Offset: 0x00071C90
		internal string NetscapeCertType(bool multiLine)
		{
			if (this._raw.Length < 4 || this._raw[0] != 3 || this._raw[1] != 2)
			{
				return "Information Not Available";
			}
			int num = this._raw[3] >> (int)this._raw[2] << (int)this._raw[2];
			StringBuilder stringBuilder = new StringBuilder();
			if ((num & 128) == 128)
			{
				stringBuilder.Append("SSL Client Authentication");
			}
			if ((num & 64) == 64)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("SSL Server Authentication");
			}
			if ((num & 32) == 32)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("SMIME");
			}
			if ((num & 16) == 16)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("Signature");
			}
			if ((num & 8) == 8)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("Unknown cert type");
			}
			if ((num & 4) == 4)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("SSL CA");
			}
			if ((num & 2) == 2)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("SMIME CA");
			}
			if ((num & 1) == 1)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("Signature CA");
			}
			stringBuilder.AppendFormat(" ({0})", num.ToString("x2"));
			return stringBuilder.ToString();
		}

		// Token: 0x040017E3 RID: 6115
		internal Oid _oid;

		// Token: 0x040017E4 RID: 6116
		internal byte[] _raw;
	}
}
