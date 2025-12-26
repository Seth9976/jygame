using System;
using System.Text;

namespace System
{
	/// <summary>Provides a custom constructor for uniform resource identifiers (URIs) and modifies URIs for the <see cref="T:System.Uri" /> class.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020004CE RID: 1230
	public class UriBuilder
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.UriBuilder" /> class.</summary>
		// Token: 0x06002B90 RID: 11152 RVA: 0x0001E41E File Offset: 0x0001C61E
		public UriBuilder()
			: this(global::System.Uri.UriSchemeHttp, "localhost")
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.UriBuilder" /> class with the specified URI.</summary>
		/// <param name="uri">A URI string. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="uri" /> is null. </exception>
		/// <exception cref="T:System.UriFormatException">
		///   <paramref name="uri" /> is a zero length string or contains only spaces.-or- The parsing routine detected a scheme in an invalid form.-or- The parser detected more than two consecutive slashes in a URI that does not use the "file" scheme.-or- <paramref name="uri" /> is not a valid URI. </exception>
		// Token: 0x06002B91 RID: 11153 RVA: 0x0001E430 File Offset: 0x0001C630
		public UriBuilder(string uri)
			: this(new global::System.Uri(uri))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.UriBuilder" /> class with the specified <see cref="T:System.Uri" /> instance.</summary>
		/// <param name="uri">An instance of the <see cref="T:System.Uri" /> class. </param>
		/// <exception cref="T:System.NullReferenceException">
		///   <paramref name="uri" /> is null. </exception>
		// Token: 0x06002B92 RID: 11154 RVA: 0x0008C104 File Offset: 0x0008A304
		public UriBuilder(global::System.Uri uri)
		{
			this.scheme = uri.Scheme;
			this.host = uri.Host;
			this.port = uri.Port;
			this.path = uri.AbsolutePath;
			this.query = uri.Query;
			this.fragment = uri.Fragment;
			this.username = uri.UserInfo;
			int num = this.username.IndexOf(':');
			if (num != -1)
			{
				this.password = this.username.Substring(num + 1);
				this.username = this.username.Substring(0, num);
			}
			else
			{
				this.password = string.Empty;
			}
			this.modified = true;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.UriBuilder" /> class with the specified scheme and host.</summary>
		/// <param name="schemeName">An Internet access protocol. </param>
		/// <param name="hostName">A DNS-style domain name or IP address. </param>
		// Token: 0x06002B93 RID: 11155 RVA: 0x0008C1C0 File Offset: 0x0008A3C0
		public UriBuilder(string schemeName, string hostName)
		{
			this.Scheme = schemeName;
			this.Host = hostName;
			this.port = -1;
			this.Path = string.Empty;
			this.query = string.Empty;
			this.fragment = string.Empty;
			this.username = string.Empty;
			this.password = string.Empty;
			this.modified = true;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.UriBuilder" /> class with the specified scheme, host, and port.</summary>
		/// <param name="scheme">An Internet access protocol. </param>
		/// <param name="host">A DNS-style domain name or IP address. </param>
		/// <param name="portNumber">An IP port number for the service. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="portNumber" /> is less than 0 or greater than 65,535. </exception>
		// Token: 0x06002B94 RID: 11156 RVA: 0x0001E43E File Offset: 0x0001C63E
		public UriBuilder(string scheme, string host, int portNumber)
			: this(scheme, host)
		{
			this.Port = portNumber;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.UriBuilder" /> class with the specified scheme, host, port number, and path.</summary>
		/// <param name="scheme">An Internet access protocol. </param>
		/// <param name="host">A DNS-style domain name or IP address. </param>
		/// <param name="port">An IP port number for the service. </param>
		/// <param name="pathValue">The path to the Internet resource. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="port" /> is less than 0 or greater than 65,535. </exception>
		// Token: 0x06002B95 RID: 11157 RVA: 0x0001E44F File Offset: 0x0001C64F
		public UriBuilder(string scheme, string host, int port, string pathValue)
			: this(scheme, host, port)
		{
			this.Path = pathValue;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.UriBuilder" /> class with the specified scheme, host, port number, path and query string or fragment identifier.</summary>
		/// <param name="scheme">An Internet access protocol. </param>
		/// <param name="host">A DNS-style domain name or IP address. </param>
		/// <param name="port">An IP port number for the service. </param>
		/// <param name="path">The path to the Internet resource. </param>
		/// <param name="extraValue">A query string or fragment identifier. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="extraValue" /> is neither null nor <see cref="F:System.String.Empty" />, nor does a valid fragment identifier begin with a number sign (#), nor a valid query string begin with a question mark (?). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="port" /> is less than 0 or greater than 65,535. </exception>
		// Token: 0x06002B96 RID: 11158 RVA: 0x0008C228 File Offset: 0x0008A428
		public UriBuilder(string scheme, string host, int port, string pathValue, string extraValue)
			: this(scheme, host, port, pathValue)
		{
			if (extraValue == null || extraValue.Length == 0)
			{
				return;
			}
			if (extraValue[0] == '#')
			{
				this.Fragment = extraValue.Remove(0, 1);
			}
			else
			{
				if (extraValue[0] != '?')
				{
					throw new ArgumentException("extraValue");
				}
				this.Query = extraValue.Remove(0, 1);
			}
		}

		/// <summary>Gets or sets the fragment portion of the URI.</summary>
		/// <returns>The fragment portion of the URI. The fragment identifier ("#") is added to the beginning of the fragment.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06002B97 RID: 11159 RVA: 0x0001E462 File Offset: 0x0001C662
		// (set) Token: 0x06002B98 RID: 11160 RVA: 0x0008C2A8 File Offset: 0x0008A4A8
		public string Fragment
		{
			get
			{
				return this.fragment;
			}
			set
			{
				this.fragment = value;
				if (this.fragment == null)
				{
					this.fragment = string.Empty;
				}
				else if (this.fragment.Length > 0)
				{
					this.fragment = "#" + value.Replace("%23", "#");
				}
				this.modified = true;
			}
		}

		/// <summary>Gets or sets the Domain Name System (DNS) host name or IP address of a server.</summary>
		/// <returns>The DNS host name or IP address of the server.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x0001E46A File Offset: 0x0001C66A
		// (set) Token: 0x06002B9A RID: 11162 RVA: 0x0001E472 File Offset: 0x0001C672
		public string Host
		{
			get
			{
				return this.host;
			}
			set
			{
				this.host = ((value != null) ? value : string.Empty);
				this.modified = true;
			}
		}

		/// <summary>Gets or sets the password associated with the user that accesses the URI.</summary>
		/// <returns>The password of the user that accesses the URI.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x0001E492 File Offset: 0x0001C692
		// (set) Token: 0x06002B9C RID: 11164 RVA: 0x0001E49A File Offset: 0x0001C69A
		public string Password
		{
			get
			{
				return this.password;
			}
			set
			{
				this.password = ((value != null) ? value : string.Empty);
				this.modified = true;
			}
		}

		/// <summary>Gets or sets the path to the resource referenced by the URI.</summary>
		/// <returns>The path to the resource referenced by the URI.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x0001E4BA File Offset: 0x0001C6BA
		// (set) Token: 0x06002B9E RID: 11166 RVA: 0x0008C310 File Offset: 0x0008A510
		public string Path
		{
			get
			{
				return this.path;
			}
			set
			{
				if (value == null || value.Length == 0)
				{
					this.path = "/";
				}
				else
				{
					this.path = global::System.Uri.EscapeString(value.Replace('\\', '/'), false, true, true);
				}
				this.modified = true;
			}
		}

		/// <summary>Gets or sets the port number of the URI.</summary>
		/// <returns>The port number of the URI.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The port cannot be set to a value less than 0 or greater than 65,535. </exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x0001E4C2 File Offset: 0x0001C6C2
		// (set) Token: 0x06002BA0 RID: 11168 RVA: 0x0001E4CA File Offset: 0x0001C6CA
		public int Port
		{
			get
			{
				return this.port;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.port = value;
				this.modified = true;
			}
		}

		/// <summary>Gets or sets any query information included in the URI.</summary>
		/// <returns>The query information included in the URI.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x0001E4EC File Offset: 0x0001C6EC
		// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x0001E4F4 File Offset: 0x0001C6F4
		public string Query
		{
			get
			{
				return this.query;
			}
			set
			{
				if (value == null || value.Length == 0)
				{
					this.query = string.Empty;
				}
				else
				{
					this.query = "?" + value;
				}
				this.modified = true;
			}
		}

		/// <summary>Gets or sets the scheme name of the URI.</summary>
		/// <returns>The scheme of the URI.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The scheme cannot be set to an invalid scheme name. </exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x0001E52F File Offset: 0x0001C72F
		// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x0008C360 File Offset: 0x0008A560
		public string Scheme
		{
			get
			{
				return this.scheme;
			}
			set
			{
				if (value == null)
				{
					value = string.Empty;
				}
				int num = value.IndexOf(':');
				if (num != -1)
				{
					value = value.Substring(0, num);
				}
				this.scheme = value.ToLower();
				this.modified = true;
			}
		}

		/// <summary>Gets the <see cref="T:System.Uri" /> instance constructed by the specified <see cref="T:System.UriBuilder" /> instance.</summary>
		/// <returns>A <see cref="T:System.Uri" /> that contains the URI constructed by the <see cref="T:System.UriBuilder" />.</returns>
		/// <exception cref="T:System.UriFormatException">The URI constructed by the <see cref="T:System.UriBuilder" /> properties is invalid. </exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x0001E537 File Offset: 0x0001C737
		public global::System.Uri Uri
		{
			get
			{
				if (!this.modified)
				{
					return this.uri;
				}
				this.uri = new global::System.Uri(this.ToString(), true);
				this.modified = false;
				return this.uri;
			}
		}

		/// <summary>The user name associated with the user that accesses the URI.</summary>
		/// <returns>The user name of the user that accesses the URI.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x0001E56A File Offset: 0x0001C76A
		// (set) Token: 0x06002BA7 RID: 11175 RVA: 0x0001E572 File Offset: 0x0001C772
		public string UserName
		{
			get
			{
				return this.username;
			}
			set
			{
				this.username = ((value != null) ? value : string.Empty);
				this.modified = true;
			}
		}

		/// <summary>Compares an existing <see cref="T:System.Uri" /> instance with the contents of the <see cref="T:System.UriBuilder" /> for equality.</summary>
		/// <returns>true if <paramref name="rparam" /> represents the same <see cref="T:System.Uri" /> as the <see cref="T:System.Uri" /> constructed by this <see cref="T:System.UriBuilder" /> instance; otherwise, false.</returns>
		/// <param name="rparam">The object to compare with the current instance. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x06002BA8 RID: 11176 RVA: 0x0001E592 File Offset: 0x0001C792
		public override bool Equals(object rparam)
		{
			return rparam != null && this.Uri.Equals(rparam.ToString());
		}

		/// <summary>Returns the hash code for the URI.</summary>
		/// <returns>The hash code generated for the URI.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06002BA9 RID: 11177 RVA: 0x0001E5B1 File Offset: 0x0001C7B1
		public override int GetHashCode()
		{
			return this.Uri.GetHashCode();
		}

		/// <summary>Returns the display string for the specified <see cref="T:System.UriBuilder" /> instance.</summary>
		/// <returns>The string that contains the unescaped display string of the <see cref="T:System.UriBuilder" />.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002BAA RID: 11178 RVA: 0x0008C3A8 File Offset: 0x0008A5A8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.scheme);
			stringBuilder.Append("://");
			if (this.username != string.Empty)
			{
				stringBuilder.Append(this.username);
				if (this.password != string.Empty)
				{
					stringBuilder.Append(":" + this.password);
				}
				stringBuilder.Append('@');
			}
			stringBuilder.Append(this.host);
			if (this.port > 0)
			{
				stringBuilder.Append(":" + this.port);
			}
			if (this.path != string.Empty && stringBuilder[stringBuilder.Length - 1] != '/' && this.path.Length > 0 && this.path[0] != '/')
			{
				stringBuilder.Append('/');
			}
			stringBuilder.Append(this.path);
			stringBuilder.Append(this.query);
			stringBuilder.Append(this.fragment);
			return stringBuilder.ToString();
		}

		// Token: 0x04001B48 RID: 6984
		private string scheme;

		// Token: 0x04001B49 RID: 6985
		private string host;

		// Token: 0x04001B4A RID: 6986
		private int port;

		// Token: 0x04001B4B RID: 6987
		private string path;

		// Token: 0x04001B4C RID: 6988
		private string query;

		// Token: 0x04001B4D RID: 6989
		private string fragment;

		// Token: 0x04001B4E RID: 6990
		private string username;

		// Token: 0x04001B4F RID: 6991
		private string password;

		// Token: 0x04001B50 RID: 6992
		private global::System.Uri uri;

		// Token: 0x04001B51 RID: 6993
		private bool modified;
	}
}
