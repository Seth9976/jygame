using System;
using System.Collections;
using System.Globalization;
using System.Text;

namespace System.Net
{
	/// <summary>Provides a set of properties and methods that are used to manage cookies. This class cannot be inherited.</summary>
	// Token: 0x020002FF RID: 767
	[Serializable]
	public sealed class Cookie
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Cookie" /> class.</summary>
		// Token: 0x060019F8 RID: 6648 RVA: 0x0004DDC8 File Offset: 0x0004BFC8
		public Cookie()
		{
			this.expires = DateTime.MinValue;
			this.timestamp = DateTime.Now;
			this.domain = string.Empty;
			this.name = string.Empty;
			this.val = string.Empty;
			this.comment = string.Empty;
			this.port = string.Empty;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Cookie" /> class with a specified <see cref="P:System.Net.Cookie.Name" /> and <see cref="P:System.Net.Cookie.Value" />.</summary>
		/// <param name="name">The name of a <see cref="T:System.Net.Cookie" />. The following characters must not be used inside <paramref name="name" />: equal sign, semicolon, comma, newline (\n), return (\r), tab (\t), and space character. The dollar sign character ("$") cannot be the first character. </param>
		/// <param name="value">The value of a <see cref="T:System.Net.Cookie" />. The following characters must not be used inside <paramref name="value" />: semicolon, comma. </param>
		/// <exception cref="T:System.Net.CookieException">The <paramref name="name" /> parameter is null. -or- The <paramref name="name" /> parameter is of zero length. -or- The <paramref name="name" /> parameter contains an invalid character.-or- The <paramref name="value" /> parameter is null .-or - The <paramref name="value" /> parameter contains a string not enclosed in quotes that contains an invalid character. </exception>
		// Token: 0x060019F9 RID: 6649 RVA: 0x000132B6 File Offset: 0x000114B6
		public Cookie(string name, string value)
			: this()
		{
			this.Name = name;
			this.Value = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Cookie" /> class with a specified <see cref="P:System.Net.Cookie.Name" />, <see cref="P:System.Net.Cookie.Value" />, and <see cref="P:System.Net.Cookie.Path" />.</summary>
		/// <param name="name">The name of a <see cref="T:System.Net.Cookie" />. The following characters must not be used inside <paramref name="name" />: equal sign, semicolon, comma, newline (\n), return (\r), tab (\t), and space character. The dollar sign character ("$") cannot be the first character. </param>
		/// <param name="value">The value of a <see cref="T:System.Net.Cookie" />. The following characters must not be used inside <paramref name="value" />: semicolon, comma. </param>
		/// <param name="path">The subset of URIs on the origin server to which this <see cref="T:System.Net.Cookie" /> applies. The default value is "/". </param>
		/// <exception cref="T:System.Net.CookieException">The <paramref name="name" /> parameter is null. -or- The <paramref name="name" /> parameter is of zero length. -or- The <paramref name="name" /> parameter contains an invalid character.-or- The <paramref name="value" /> parameter is null .-or - The <paramref name="value" /> parameter contains a string not enclosed in quotes that contains an invalid character.</exception>
		// Token: 0x060019FA RID: 6650 RVA: 0x000132CC File Offset: 0x000114CC
		public Cookie(string name, string value, string path)
			: this(name, value)
		{
			this.Path = path;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Cookie" /> class with a specified <see cref="P:System.Net.Cookie.Name" />, <see cref="P:System.Net.Cookie.Value" />, <see cref="P:System.Net.Cookie.Path" />, and <see cref="P:System.Net.Cookie.Domain" />.</summary>
		/// <param name="name">The name of a <see cref="T:System.Net.Cookie" />. The following characters must not be used inside <paramref name="name" />: equal sign, semicolon, comma, newline (\n), return (\r), tab (\t), and space character. The dollar sign character ("$") cannot be the first character. </param>
		/// <param name="value">The value of a <see cref="T:System.Net.Cookie" /> object. The following characters must not be used inside <paramref name="value" />: semicolon, comma. </param>
		/// <param name="path">The subset of URIs on the origin server to which this <see cref="T:System.Net.Cookie" /> applies. The default value is "/". </param>
		/// <param name="domain">The optional internet domain for which this <see cref="T:System.Net.Cookie" /> is valid. The default value is the host this <see cref="T:System.Net.Cookie" /> has been received from. </param>
		/// <exception cref="T:System.Net.CookieException">The <paramref name="name" /> parameter is null. -or- The <paramref name="name" /> parameter is of zero length. -or- The <paramref name="name" /> parameter contains an invalid character.-or- The <paramref name="value" /> parameter is null .-or - The <paramref name="value" /> parameter contains a string not enclosed in quotes that contains an invalid character.</exception>
		// Token: 0x060019FB RID: 6651 RVA: 0x000132DD File Offset: 0x000114DD
		public Cookie(string name, string value, string path, string domain)
			: this(name, value, path)
		{
			this.Domain = domain;
		}

		/// <summary>Gets or sets a comment that the server can add to a <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>An optional comment to document intended usage for this <see cref="T:System.Net.Cookie" />.</returns>
		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x00013327 File Offset: 0x00011527
		// (set) Token: 0x060019FE RID: 6654 RVA: 0x0001332F File Offset: 0x0001152F
		public string Comment
		{
			get
			{
				return this.comment;
			}
			set
			{
				this.comment = ((value != null) ? value : string.Empty);
			}
		}

		/// <summary>Gets or sets a URI comment that the server can provide with a <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>An optional comment that represents the intended usage of the URI reference for this <see cref="T:System.Net.Cookie" />. The value must conform to URI format.</returns>
		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x00013348 File Offset: 0x00011548
		// (set) Token: 0x06001A00 RID: 6656 RVA: 0x00013350 File Offset: 0x00011550
		public global::System.Uri CommentUri
		{
			get
			{
				return this.commentUri;
			}
			set
			{
				this.commentUri = value;
			}
		}

		/// <summary>Gets or sets the discard flag set by the server.</summary>
		/// <returns>true if the client is to discard the <see cref="T:System.Net.Cookie" /> at the end of the current session; otherwise, false. The default is false.</returns>
		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x00013359 File Offset: 0x00011559
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x00013361 File Offset: 0x00011561
		public bool Discard
		{
			get
			{
				return this.discard;
			}
			set
			{
				this.discard = value;
			}
		}

		/// <summary>Gets or sets the URI for which the <see cref="T:System.Net.Cookie" /> is valid.</summary>
		/// <returns>The URI for which the <see cref="T:System.Net.Cookie" /> is valid.</returns>
		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x0001336A File Offset: 0x0001156A
		// (set) Token: 0x06001A04 RID: 6660 RVA: 0x00013372 File Offset: 0x00011572
		public string Domain
		{
			get
			{
				return this.domain;
			}
			set
			{
				if (Cookie.IsNullOrEmpty(value))
				{
					this.domain = string.Empty;
					this.ExactDomain = true;
				}
				else
				{
					this.domain = value;
					this.ExactDomain = value[0] != '.';
				}
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x000133B1 File Offset: 0x000115B1
		// (set) Token: 0x06001A06 RID: 6662 RVA: 0x000133B9 File Offset: 0x000115B9
		internal bool ExactDomain
		{
			get
			{
				return this.exact_domain;
			}
			set
			{
				this.exact_domain = value;
			}
		}

		/// <summary>Gets or sets the current state of the <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>true if the <see cref="T:System.Net.Cookie" /> has expired; otherwise, false. The default is false.</returns>
		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x000133C2 File Offset: 0x000115C2
		// (set) Token: 0x06001A08 RID: 6664 RVA: 0x000133EC File Offset: 0x000115EC
		public bool Expired
		{
			get
			{
				return this.expires <= DateTime.Now && this.expires != DateTime.MinValue;
			}
			set
			{
				if (value)
				{
					this.expires = DateTime.Now;
				}
			}
		}

		/// <summary>Gets or sets the expiration date and time for the <see cref="T:System.Net.Cookie" /> as a <see cref="T:System.DateTime" />.</summary>
		/// <returns>The expiration date and time for the <see cref="T:System.Net.Cookie" /> as a <see cref="T:System.DateTime" /> instance.</returns>
		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x000133FF File Offset: 0x000115FF
		// (set) Token: 0x06001A0A RID: 6666 RVA: 0x00013407 File Offset: 0x00011607
		public DateTime Expires
		{
			get
			{
				return this.expires;
			}
			set
			{
				this.expires = value;
			}
		}

		/// <summary>Determines whether a page script or other active content can access this cookie.</summary>
		/// <returns>Boolean value that determines whether a page script or other active content can access this cookie.</returns>
		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x00013410 File Offset: 0x00011610
		// (set) Token: 0x06001A0C RID: 6668 RVA: 0x00013418 File Offset: 0x00011618
		public bool HttpOnly
		{
			get
			{
				return this.httpOnly;
			}
			set
			{
				this.httpOnly = value;
			}
		}

		/// <summary>Gets or sets the name for the <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>The name for the <see cref="T:System.Net.Cookie" />.</returns>
		/// <exception cref="T:System.Net.CookieException">The value specified for a set operation is null or the empty string- or -The value specified for a set operation contained an illegal character. The following characters must not be used inside the <see cref="P:System.Net.Cookie.Name" /> property: equal sign, semicolon, comma, newline (\n), return (\r), tab (\t), and space character. The dollar sign character ("$") cannot be the first character.</exception>
		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x00013421 File Offset: 0x00011621
		// (set) Token: 0x06001A0E RID: 6670 RVA: 0x0004DE28 File Offset: 0x0004C028
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (Cookie.IsNullOrEmpty(value))
				{
					throw new CookieException("Name cannot be empty");
				}
				if (value[0] == '$' || value.IndexOfAny(Cookie.reservedCharsName) != -1)
				{
					this.name = string.Empty;
					throw new CookieException("Name contains invalid characters");
				}
				this.name = value;
			}
		}

		/// <summary>Gets or sets the URIs to which the <see cref="T:System.Net.Cookie" /> applies.</summary>
		/// <returns>The URIs to which the <see cref="T:System.Net.Cookie" /> applies.</returns>
		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x00013429 File Offset: 0x00011629
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x00013446 File Offset: 0x00011646
		public string Path
		{
			get
			{
				return (this.path != null) ? this.path : string.Empty;
			}
			set
			{
				this.path = ((value != null) ? value : string.Empty);
			}
		}

		/// <summary>Gets or sets a list of TCP ports that the <see cref="T:System.Net.Cookie" /> applies to.</summary>
		/// <returns>The list of TCP ports that the <see cref="T:System.Net.Cookie" /> applies to.</returns>
		/// <exception cref="T:System.Net.CookieException">The value specified for a set operation could not be parsed or is not enclosed in double quotes. </exception>
		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x0001345F File Offset: 0x0001165F
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x0004DE88 File Offset: 0x0004C088
		public string Port
		{
			get
			{
				return this.port;
			}
			set
			{
				if (Cookie.IsNullOrEmpty(value))
				{
					this.port = string.Empty;
					return;
				}
				if (value[0] != '"' || value[value.Length - 1] != '"')
				{
					throw new CookieException("The 'Port'='" + value + "' part of the cookie is invalid. Port must be enclosed by double quotes.");
				}
				this.port = value;
				string[] array = this.port.Split(Cookie.portSeparators);
				this.ports = new int[array.Length];
				for (int i = 0; i < this.ports.Length; i++)
				{
					this.ports[i] = int.MinValue;
					if (array[i].Length != 0)
					{
						try
						{
							this.ports[i] = int.Parse(array[i]);
						}
						catch (Exception ex)
						{
							throw new CookieException("The 'Port'='" + value + "' part of the cookie is invalid. Invalid value: " + array[i], ex);
						}
					}
				}
				this.Version = 1;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00013467 File Offset: 0x00011667
		internal int[] Ports
		{
			get
			{
				return this.ports;
			}
		}

		/// <summary>Gets or sets the security level of a <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>true if the client is only to return the cookie in subsequent requests if those requests use Secure Hypertext Transfer Protocol (HTTPS); otherwise, false. The default is false.</returns>
		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x0001346F File Offset: 0x0001166F
		// (set) Token: 0x06001A15 RID: 6677 RVA: 0x00013477 File Offset: 0x00011677
		public bool Secure
		{
			get
			{
				return this.secure;
			}
			set
			{
				this.secure = value;
			}
		}

		/// <summary>Gets the time when the cookie was issued as a <see cref="T:System.DateTime" />.</summary>
		/// <returns>The time when the cookie was issued as a <see cref="T:System.DateTime" />.</returns>
		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x00013480 File Offset: 0x00011680
		public DateTime TimeStamp
		{
			get
			{
				return this.timestamp;
			}
		}

		/// <summary>Gets or sets the <see cref="P:System.Net.Cookie.Value" /> for the <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>The <see cref="P:System.Net.Cookie.Value" /> for the <see cref="T:System.Net.Cookie" />.</returns>
		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x00013488 File Offset: 0x00011688
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x00013490 File Offset: 0x00011690
		public string Value
		{
			get
			{
				return this.val;
			}
			set
			{
				if (value == null)
				{
					this.val = string.Empty;
					return;
				}
				this.val = value;
			}
		}

		/// <summary>Gets or sets the version of HTTP state maintenance to which the cookie conforms.</summary>
		/// <returns>The version of HTTP state maintenance to which the cookie conforms.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a version is not allowed. </exception>
		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x000134AB File Offset: 0x000116AB
		// (set) Token: 0x06001A1A RID: 6682 RVA: 0x000134B3 File Offset: 0x000116B3
		public int Version
		{
			get
			{
				return this.version;
			}
			set
			{
				if (value < 0 || value > 10)
				{
					this.version = 0;
				}
				else
				{
					this.version = value;
				}
			}
		}

		/// <summary>Overrides the <see cref="M:System.Object.Equals(System.Object)" /> method.</summary>
		/// <returns>Returns true if the <see cref="T:System.Net.Cookie" /> is equal to <paramref name="comparand" />. Two <see cref="T:System.Net.Cookie" /> instances are equal if their <see cref="P:System.Net.Cookie.Name" />, <see cref="P:System.Net.Cookie.Value" />, <see cref="P:System.Net.Cookie.Path" />, <see cref="P:System.Net.Cookie.Domain" />, and <see cref="P:System.Net.Cookie.Version" /> properties are equal. <see cref="P:System.Net.Cookie.Name" /> and <see cref="P:System.Net.Cookie.Domain" /> string comparisons are case-insensitive.</returns>
		/// <param name="comparand">A reference to a <see cref="T:System.Net.Cookie" />. </param>
		// Token: 0x06001A1B RID: 6683 RVA: 0x0004DF90 File Offset: 0x0004C190
		public override bool Equals(object obj)
		{
			Cookie cookie = obj as Cookie;
			return cookie != null && string.Compare(this.name, cookie.name, true, CultureInfo.InvariantCulture) == 0 && string.Compare(this.val, cookie.val, false, CultureInfo.InvariantCulture) == 0 && string.Compare(this.Path, cookie.Path, false, CultureInfo.InvariantCulture) == 0 && string.Compare(this.domain, cookie.domain, true, CultureInfo.InvariantCulture) == 0 && this.version == cookie.version;
		}

		/// <summary>Overrides the <see cref="M:System.Object.GetHashCode" /> method.</summary>
		/// <returns>The 32-bit signed integer hash code for this instance.</returns>
		// Token: 0x06001A1C RID: 6684 RVA: 0x0004E02C File Offset: 0x0004C22C
		public override int GetHashCode()
		{
			return Cookie.hash(CaseInsensitiveHashCodeProvider.DefaultInvariant.GetHashCode(this.name), this.val.GetHashCode(), this.Path.GetHashCode(), CaseInsensitiveHashCodeProvider.DefaultInvariant.GetHashCode(this.domain), this.version);
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x000134D7 File Offset: 0x000116D7
		private static int hash(int i, int j, int k, int l, int m)
		{
			return i ^ ((j << 13) | (j >> 19)) ^ ((k << 26) | (k >> 6)) ^ ((l << 7) | (l >> 25)) ^ ((m << 20) | (m >> 12));
		}

		/// <summary>Overrides the <see cref="M:System.Object.ToString" /> method.</summary>
		/// <returns>Returns a string representation of this <see cref="T:System.Net.Cookie" /> object that is suitable for including in a HTTP Cookie: request header.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x06001A1E RID: 6686 RVA: 0x00013502 File Offset: 0x00011702
		public override string ToString()
		{
			return this.ToString(null);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0004E07C File Offset: 0x0004C27C
		internal string ToString(global::System.Uri uri)
		{
			if (this.name.Length == 0)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder(64);
			if (this.version > 0)
			{
				stringBuilder.Append("$Version=").Append(this.version).Append("; ");
			}
			stringBuilder.Append(this.name).Append("=").Append(this.val);
			if (this.version == 0)
			{
				return stringBuilder.ToString();
			}
			if (!Cookie.IsNullOrEmpty(this.path))
			{
				stringBuilder.Append("; $Path=").Append(this.path);
			}
			else if (uri != null)
			{
				stringBuilder.Append("; $Path=/").Append(this.path);
			}
			bool flag = uri == null || uri.Host != this.domain;
			if (flag && !Cookie.IsNullOrEmpty(this.domain))
			{
				stringBuilder.Append("; $Domain=").Append(this.domain);
			}
			if (this.port != null && this.port.Length != 0)
			{
				stringBuilder.Append("; $Port=").Append(this.port);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x0004E1E0 File Offset: 0x0004C3E0
		internal string ToClientString()
		{
			if (this.name.Length == 0)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder(64);
			if (this.version > 0)
			{
				stringBuilder.Append("Version=").Append(this.version).Append(";");
			}
			stringBuilder.Append(this.name).Append("=").Append(this.val);
			if (this.path != null && this.path.Length != 0)
			{
				stringBuilder.Append(";Path=").Append(this.QuotedString(this.path));
			}
			if (this.domain != null && this.domain.Length != 0)
			{
				stringBuilder.Append(";Domain=").Append(this.QuotedString(this.domain));
			}
			if (this.port != null && this.port.Length != 0)
			{
				stringBuilder.Append(";Port=").Append(this.port);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x0001350B File Offset: 0x0001170B
		private string QuotedString(string value)
		{
			if (this.version == 0 || this.IsToken(value))
			{
				return value;
			}
			return "\"" + value.Replace("\"", "\\\"") + "\"";
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x0004E304 File Offset: 0x0004C504
		private bool IsToken(string value)
		{
			int length = value.Length;
			for (int i = 0; i < length; i++)
			{
				char c = value[i];
				if (c < ' ' || c >= '\u007f' || Cookie.tspecials.IndexOf(c) != -1)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000132A2 File Offset: 0x000114A2
		private static bool IsNullOrEmpty(string s)
		{
			return s == null || s.Length == 0;
		}

		// Token: 0x04001030 RID: 4144
		private string comment;

		// Token: 0x04001031 RID: 4145
		private global::System.Uri commentUri;

		// Token: 0x04001032 RID: 4146
		private bool discard;

		// Token: 0x04001033 RID: 4147
		private string domain;

		// Token: 0x04001034 RID: 4148
		private DateTime expires;

		// Token: 0x04001035 RID: 4149
		private bool httpOnly;

		// Token: 0x04001036 RID: 4150
		private string name;

		// Token: 0x04001037 RID: 4151
		private string path;

		// Token: 0x04001038 RID: 4152
		private string port;

		// Token: 0x04001039 RID: 4153
		private int[] ports;

		// Token: 0x0400103A RID: 4154
		private bool secure;

		// Token: 0x0400103B RID: 4155
		private DateTime timestamp;

		// Token: 0x0400103C RID: 4156
		private string val;

		// Token: 0x0400103D RID: 4157
		private int version;

		// Token: 0x0400103E RID: 4158
		private static char[] reservedCharsName = new char[] { ' ', '=', ';', ',', '\n', '\r', '\t' };

		// Token: 0x0400103F RID: 4159
		private static char[] portSeparators = new char[] { '"', ',' };

		// Token: 0x04001040 RID: 4160
		private static string tspecials = "()<>@,;:\\\"/[]?={} \t";

		// Token: 0x04001041 RID: 4161
		private bool exact_domain;
	}
}
