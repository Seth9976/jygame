using System;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace System.Net
{
	/// <summary>Describes an incoming HTTP request to an <see cref="T:System.Net.HttpListener" /> object. This class cannot be inherited.</summary>
	// Token: 0x0200032F RID: 815
	public sealed class HttpListenerRequest
	{
		// Token: 0x06001C0A RID: 7178 RVA: 0x00014571 File Offset: 0x00012771
		internal HttpListenerRequest(HttpListenerContext context)
		{
			this.context = context;
			this.headers = new WebHeaderCollection();
			this.input_stream = Stream.Null;
			this.version = HttpVersion.Version10;
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00054170 File Offset: 0x00052370
		internal void SetRequestLine(string req)
		{
			string[] array = req.Split(HttpListenerRequest.separators, 3);
			if (array.Length != 3)
			{
				this.context.ErrorMessage = "Invalid request line (parts).";
				return;
			}
			this.method = array[0];
			foreach (char c in this.method)
			{
				int num = (int)c;
				if ((num < 65 || num > 90) && (num <= 32 || c >= '\u007f' || c == '(' || c == ')' || c == '<' || c == '<' || c == '>' || c == '@' || c == ',' || c == ';' || c == ':' || c == '\\' || c == '"' || c == '/' || c == '[' || c == ']' || c == '?' || c == '=' || c == '{' || c == '}'))
				{
					this.context.ErrorMessage = "(Invalid verb)";
					return;
				}
			}
			this.raw_url = array[1];
			if (array[2].Length != 8 || !array[2].StartsWith("HTTP/"))
			{
				this.context.ErrorMessage = "Invalid request line (version).";
				return;
			}
			try
			{
				this.version = new Version(array[2].Substring(5));
				if (this.version.Major < 1)
				{
					throw new Exception();
				}
			}
			catch
			{
				this.context.ErrorMessage = "Invalid request line (version).";
			}
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00054334 File Offset: 0x00052534
		private void CreateQueryString(string query)
		{
			this.query_string = new global::System.Collections.Specialized.NameValueCollection();
			if (query == null || query.Length == 0)
			{
				return;
			}
			if (query[0] == '?')
			{
				query = query.Substring(1);
			}
			string[] array = query.Split(new char[] { '&' });
			foreach (string text in array)
			{
				int num = text.IndexOf('=');
				if (num == -1)
				{
					this.query_string.Add(null, HttpUtility.UrlDecode(text));
				}
				else
				{
					string text2 = HttpUtility.UrlDecode(text.Substring(0, num));
					string text3 = HttpUtility.UrlDecode(text.Substring(num + 1));
					this.query_string.Add(text2, text3);
				}
			}
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x000543FC File Offset: 0x000525FC
		internal void FinishInitialization()
		{
			string text = this.UserHostName;
			if (this.version > HttpVersion.Version10 && (text == null || text.Length == 0))
			{
				this.context.ErrorMessage = "Invalid host name";
				return;
			}
			global::System.Uri uri;
			string pathAndQuery;
			if (global::System.Uri.MaybeUri(this.raw_url) && global::System.Uri.TryCreate(this.raw_url, global::System.UriKind.Absolute, out uri))
			{
				pathAndQuery = uri.PathAndQuery;
			}
			else
			{
				pathAndQuery = this.raw_url;
			}
			if (text == null || text.Length == 0)
			{
				text = this.UserHostAddress;
			}
			if (uri != null)
			{
				text = uri.Host;
			}
			int num = text.IndexOf(':');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			string text2 = string.Format("{0}://{1}:{2}", (!this.IsSecureConnection) ? "http" : "https", text, this.LocalEndPoint.Port);
			if (!global::System.Uri.TryCreate(text2 + pathAndQuery, global::System.UriKind.Absolute, out this.url))
			{
				this.context.ErrorMessage = "Invalid url: " + text2 + pathAndQuery;
				return;
			}
			this.CreateQueryString(this.url.Query);
			string text3 = null;
			if (this.version >= HttpVersion.Version11)
			{
				text3 = this.Headers["Transfer-Encoding"];
				if (text3 != null && text3 != "chunked")
				{
					this.context.Connection.SendError(null, 501);
					return;
				}
			}
			this.is_chunked = text3 == "chunked";
			foreach (string text4 in HttpListenerRequest.no_body_methods)
			{
				if (string.Compare(this.method, text4, StringComparison.InvariantCultureIgnoreCase) == 0)
				{
					return;
				}
			}
			if (!this.is_chunked && !this.cl_set)
			{
				this.context.Connection.SendError(null, 411);
				return;
			}
			if (this.is_chunked || this.content_length > 0L)
			{
				this.input_stream = this.context.Connection.GetRequestStream(this.is_chunked, this.content_length);
			}
			if (this.Headers["Expect"] == "100-continue")
			{
				ResponseStream responseStream = this.context.Connection.GetResponseStream();
				responseStream.InternalWrite(HttpListenerRequest._100continue, 0, HttpListenerRequest._100continue.Length);
			}
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00054690 File Offset: 0x00052890
		internal static string Unquote(string str)
		{
			int num = str.IndexOf('"');
			int num2 = str.LastIndexOf('"');
			if (num >= 0 && num2 >= 0)
			{
				str = str.Substring(num + 1, num2 - 1);
			}
			return str.Trim();
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x000546D4 File Offset: 0x000528D4
		internal void AddHeader(string header)
		{
			int num = header.IndexOf(':');
			if (num == -1 || num == 0)
			{
				this.context.ErrorMessage = "Bad Request";
				this.context.ErrorStatus = 400;
				return;
			}
			string text = header.Substring(0, num).Trim();
			string text2 = header.Substring(num + 1).Trim();
			string text3 = text.ToLower(CultureInfo.InvariantCulture);
			this.headers.SetInternal(text, text2);
			string text4 = text3;
			switch (text4)
			{
			case "accept-language":
				this.user_languages = text2.Split(new char[] { ',' });
				break;
			case "accept":
				this.accept_types = text2.Split(new char[] { ',' });
				break;
			case "content-length":
				try
				{
					this.content_length = long.Parse(text2.Trim());
					if (this.content_length < 0L)
					{
						this.context.ErrorMessage = "Invalid Content-Length.";
					}
					this.cl_set = true;
				}
				catch
				{
					this.context.ErrorMessage = "Invalid Content-Length.";
				}
				break;
			case "referer":
				try
				{
					this.referrer = new global::System.Uri(text2);
				}
				catch
				{
					this.referrer = new global::System.Uri("http://someone.is.screwing.with.the.headers.com/");
				}
				break;
			case "cookie":
			{
				if (this.cookies == null)
				{
					this.cookies = new CookieCollection();
				}
				string[] array = text2.Split(new char[] { ',', ';' });
				Cookie cookie = null;
				int num3 = 0;
				foreach (string text5 in array)
				{
					string text6 = text5.Trim();
					if (text6.Length != 0)
					{
						if (text6.StartsWith("$Version"))
						{
							num3 = int.Parse(HttpListenerRequest.Unquote(text6.Substring(text6.IndexOf("=") + 1)));
						}
						else if (text6.StartsWith("$Path"))
						{
							if (cookie != null)
							{
								cookie.Path = text6.Substring(text6.IndexOf("=") + 1).Trim();
							}
						}
						else if (text6.StartsWith("$Domain"))
						{
							if (cookie != null)
							{
								cookie.Domain = text6.Substring(text6.IndexOf("=") + 1).Trim();
							}
						}
						else if (text6.StartsWith("$Port"))
						{
							if (cookie != null)
							{
								cookie.Port = text6.Substring(text6.IndexOf("=") + 1).Trim();
							}
						}
						else
						{
							if (cookie != null)
							{
								this.cookies.Add(cookie);
							}
							cookie = new Cookie();
							int num4 = text6.IndexOf("=");
							if (num4 > 0)
							{
								cookie.Name = text6.Substring(0, num4).Trim();
								cookie.Value = text6.Substring(num4 + 1).Trim();
							}
							else
							{
								cookie.Name = text6.Trim();
								cookie.Value = string.Empty;
							}
							cookie.Version = num3;
						}
					}
				}
				if (cookie != null)
				{
					this.cookies.Add(cookie);
				}
				break;
			}
			}
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00054ABC File Offset: 0x00052CBC
		internal bool FlushInput()
		{
			if (!this.HasEntityBody)
			{
				return true;
			}
			int num = 2048;
			if (this.content_length > 0L)
			{
				num = (int)Math.Min(this.content_length, (long)num);
			}
			byte[] array = new byte[num];
			bool flag;
			for (;;)
			{
				try
				{
					if (this.InputStream.Read(array, 0, num) <= 0)
					{
						flag = true;
						break;
					}
				}
				catch
				{
					flag = false;
					break;
				}
			}
			return flag;
		}

		/// <summary>Gets the MIME types accepted by the client. </summary>
		/// <returns>A <see cref="T:System.String" /> array that contains the type names specified in the request's Accept header or null if the client request did not include an Accept header.</returns>
		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x000145A1 File Offset: 0x000127A1
		public string[] AcceptTypes
		{
			get
			{
				return this.accept_types;
			}
		}

		/// <summary>Gets an error code that identifies a problem with the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> provided by the client.</summary>
		/// <returns>An <see cref="T:System.Int32" /> value that contains a Windows error code.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Create" />
		/// </PermissionSet>
		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[global::System.MonoTODO("Always returns 0")]
		public int ClientCertificateError
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Gets the content encoding that can be used with data sent with the request</summary>
		/// <returns>An <see cref="T:System.Text.Encoding" /> object suitable for use with the data in the <see cref="P:System.Net.HttpListenerRequest.InputStream" /> property.</returns>
		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x000145A9 File Offset: 0x000127A9
		public Encoding ContentEncoding
		{
			get
			{
				if (this.content_encoding == null)
				{
					this.content_encoding = Encoding.Default;
				}
				return this.content_encoding;
			}
		}

		/// <summary>Gets the length of the body data included in the request.</summary>
		/// <returns>The value from the request's Content-Length header. This value is -1 if the content length is not known.</returns>
		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x000145C7 File Offset: 0x000127C7
		public long ContentLength64
		{
			get
			{
				return this.content_length;
			}
		}

		/// <summary>Gets the MIME type of the body data included in the request.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the text of the request's Content-Type header.</returns>
		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x000145CF File Offset: 0x000127CF
		public string ContentType
		{
			get
			{
				return this.headers["content-type"];
			}
		}

		/// <summary>Gets the cookies sent with the request.</summary>
		/// <returns>A <see cref="T:System.Net.CookieCollection" /> that contains cookies that accompany the request. This property returns an empty collection if the request does not contain cookies.</returns>
		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x000145E1 File Offset: 0x000127E1
		public CookieCollection Cookies
		{
			get
			{
				if (this.cookies == null)
				{
					this.cookies = new CookieCollection();
				}
				return this.cookies;
			}
		}

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the request has associated body data.</summary>
		/// <returns>true if the request has associated body data; otherwise, false.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x000145FF File Offset: 0x000127FF
		public bool HasEntityBody
		{
			get
			{
				return this.content_length > 0L || this.is_chunked;
			}
		}

		/// <summary>Gets the collection of header name/value pairs sent in the request.</summary>
		/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> that contains the HTTP headers included in the request.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x00014617 File Offset: 0x00012817
		public global::System.Collections.Specialized.NameValueCollection Headers
		{
			get
			{
				return this.headers;
			}
		}

		/// <summary>Gets the HTTP method specified by the client. </summary>
		/// <returns>A <see cref="T:System.String" /> that contains the method used in the request.</returns>
		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x0001461F File Offset: 0x0001281F
		public string HttpMethod
		{
			get
			{
				return this.method;
			}
		}

		/// <summary>Gets a stream that contains the body data sent by the client.</summary>
		/// <returns>A readable <see cref="T:System.IO.Stream" /> object that contains the bytes sent by the client in the body of the request. This property returns <see cref="F:System.IO.Stream.Null" /> if no data is sent with the request.</returns>
		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x00014627 File Offset: 0x00012827
		public Stream InputStream
		{
			get
			{
				return this.input_stream;
			}
		}

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the client sending this request is authenticated.</summary>
		/// <returns>true if the client was authenticated; otherwise, false.</returns>
		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[global::System.MonoTODO("Always returns false")]
		public bool IsAuthenticated
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the request is sent from the local computer.</summary>
		/// <returns>true if the request originated on the same computer as the <see cref="T:System.Net.HttpListener" /> object that provided the request; otherwise, false.</returns>
		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x0001462F File Offset: 0x0001282F
		public bool IsLocal
		{
			get
			{
				return IPAddress.IsLoopback(this.RemoteEndPoint.Address);
			}
		}

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the TCP connection used to send the request is using the Secure Sockets Layer (SSL) protocol.</summary>
		/// <returns>true if the TCP connection is using SSL; otherwise, false.</returns>
		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x00014641 File Offset: 0x00012841
		public bool IsSecureConnection
		{
			get
			{
				return this.context.Connection.IsSecure;
			}
		}

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the client requests a persistent connection.</summary>
		/// <returns>true if the connection should be kept open; otherwise, false.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public bool KeepAlive
		{
			get
			{
				return false;
			}
		}

		/// <summary>Get the server IP address and port number to which the request is directed.</summary>
		/// <returns>An <see cref="T:System.Net.IPEndPoint" /> that represents the IP address that the request is sent to.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x00014653 File Offset: 0x00012853
		public IPEndPoint LocalEndPoint
		{
			get
			{
				return this.context.Connection.LocalEndPoint;
			}
		}

		/// <summary>Gets the HTTP version used by the requesting client.</summary>
		/// <returns>A <see cref="T:System.Version" /> that identifies the client's version of HTTP.</returns>
		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x00014665 File Offset: 0x00012865
		public Version ProtocolVersion
		{
			get
			{
				return this.version;
			}
		}

		/// <summary>Gets the query string included in the request.</summary>
		/// <returns>A <see cref="T:System.Collections.Specialized.NameValueCollection" /> object that contains the query data included in the request <see cref="P:System.Net.HttpListenerRequest.Url" />.</returns>
		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x0001466D File Offset: 0x0001286D
		public global::System.Collections.Specialized.NameValueCollection QueryString
		{
			get
			{
				return this.query_string;
			}
		}

		/// <summary>Gets the URL information (without the host and port) requested by the client.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the raw URL for this request.</returns>
		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x00014675 File Offset: 0x00012875
		public string RawUrl
		{
			get
			{
				return this.raw_url;
			}
		}

		/// <summary>Gets the client IP address and port number from which the request originated.</summary>
		/// <returns>An <see cref="T:System.Net.IPEndPoint" /> that represents the IP address and port number from which the request originated.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x0001467D File Offset: 0x0001287D
		public IPEndPoint RemoteEndPoint
		{
			get
			{
				return this.context.Connection.RemoteEndPoint;
			}
		}

		/// <summary>Gets the request identifier of the incoming HTTP request.</summary>
		/// <returns>A <see cref="T:System.Guid" /> object that contains the identifier of the HTTP request.</returns>
		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0001468F File Offset: 0x0001288F
		public Guid RequestTraceIdentifier
		{
			get
			{
				return this.identifier;
			}
		}

		/// <summary>Gets the <see cref="T:System.Uri" /> object requested by the client.</summary>
		/// <returns>A <see cref="T:System.Uri" /> object that identifies the resource requested by the client.</returns>
		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00014697 File Offset: 0x00012897
		public global::System.Uri Url
		{
			get
			{
				return this.url;
			}
		}

		/// <summary>Gets the Uniform Resource Identifier (URI) of the resource that referred the client to the server.</summary>
		/// <returns>A <see cref="T:System.Uri" /> object that contains the text of the request's <see cref="F:System.Net.HttpRequestHeader.Referer" /> header, or null if the header was not included in the request.</returns>
		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0001469F File Offset: 0x0001289F
		public global::System.Uri UrlReferrer
		{
			get
			{
				return this.referrer;
			}
		}

		/// <summary>Gets the user agent presented by the client.</summary>
		/// <returns>A <see cref="T:System.String" /> object that contains the text of the request's User-Agent header.</returns>
		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x000146A7 File Offset: 0x000128A7
		public string UserAgent
		{
			get
			{
				return this.headers["user-agent"];
			}
		}

		/// <summary>Gets the server IP address and port number to which the request is directed.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the host address information.</returns>
		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x000146B9 File Offset: 0x000128B9
		public string UserHostAddress
		{
			get
			{
				return this.LocalEndPoint.ToString();
			}
		}

		/// <summary>Gets the DNS name and, if provided, the port number specified by the client.</summary>
		/// <returns>A <see cref="T:System.String" /> value that contains the text of the request's Host header.</returns>
		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x000146C6 File Offset: 0x000128C6
		public string UserHostName
		{
			get
			{
				return this.headers["host"];
			}
		}

		/// <summary>Gets the natural languages that are preferred for the response.</summary>
		/// <returns>A <see cref="T:System.String" /> array that contains the languages specified in the request's <see cref="F:System.Net.HttpRequestHeader.AcceptLanguage" /> header or null if the client request did not include an <see cref="F:System.Net.HttpRequestHeader.AcceptLanguage" /> header.</returns>
		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x000146D8 File Offset: 0x000128D8
		public string[] UserLanguages
		{
			get
			{
				return this.user_languages;
			}
		}

		/// <summary>Begins an asynchronous request for the client's X.509 v.3 certificate.</summary>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that indicates the status of the operation.</returns>
		/// <param name="requestCallback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the operation is complete.</param>
		/// <param name="state">A user-defined object that contains information about the operation. This object is passed to the callback delegate when the operation completes.</param>
		// Token: 0x06001C2C RID: 7212 RVA: 0x00002A97 File Offset: 0x00000C97
		public IAsyncResult BeginGetClientCertificate(AsyncCallback requestCallback, object state)
		{
			return null;
		}

		/// <summary>Ends an asynchronous request for the client's X.509 v.3 certificate.</summary>
		/// <returns>The <see cref="T:System.IAsyncResult" /> object that is returned when the operation started.</returns>
		/// <param name="asyncResult">The pending request for the certificate.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="asyncResult" /> was not obtained by calling <see cref="M:System.Net.HttpListenerRequest.BeginGetClientCertificate(System.AsyncCallback,System.Object)" /><paramref name="e." /></exception>
		/// <exception cref="T:System.InvalidOperationException">This method was already called for the operation identified by <paramref name="asyncResult" />. </exception>
		// Token: 0x06001C2D RID: 7213 RVA: 0x00002A97 File Offset: 0x00000C97
		public global::System.Security.Cryptography.X509Certificates.X509Certificate2 EndGetClientCertificate(IAsyncResult asyncResult)
		{
			return null;
		}

		/// <summary>Retrieves the client's X.509 v.3 certificate.</summary>
		/// <returns>A <see cref="N:System.Security.Cryptography.X509Certificates" /> object that contains the client's X.509 v.3 certificate.</returns>
		/// <exception cref="T:System.InvalidOperationException">A call to this method to retrieve the client's X.509 v.3 certificate is in progress and therefore another call to this method cannot be made.</exception>
		// Token: 0x06001C2E RID: 7214 RVA: 0x00002A97 File Offset: 0x00000C97
		public global::System.Security.Cryptography.X509Certificates.X509Certificate2 GetClientCertificate()
		{
			return null;
		}

		// Token: 0x0400112D RID: 4397
		private string[] accept_types;

		// Token: 0x0400112E RID: 4398
		private Encoding content_encoding;

		// Token: 0x0400112F RID: 4399
		private long content_length;

		// Token: 0x04001130 RID: 4400
		private bool cl_set;

		// Token: 0x04001131 RID: 4401
		private CookieCollection cookies;

		// Token: 0x04001132 RID: 4402
		private WebHeaderCollection headers;

		// Token: 0x04001133 RID: 4403
		private string method;

		// Token: 0x04001134 RID: 4404
		private Stream input_stream;

		// Token: 0x04001135 RID: 4405
		private Version version;

		// Token: 0x04001136 RID: 4406
		private global::System.Collections.Specialized.NameValueCollection query_string;

		// Token: 0x04001137 RID: 4407
		private string raw_url;

		// Token: 0x04001138 RID: 4408
		private Guid identifier;

		// Token: 0x04001139 RID: 4409
		private global::System.Uri url;

		// Token: 0x0400113A RID: 4410
		private global::System.Uri referrer;

		// Token: 0x0400113B RID: 4411
		private string[] user_languages;

		// Token: 0x0400113C RID: 4412
		private HttpListenerContext context;

		// Token: 0x0400113D RID: 4413
		private bool is_chunked;

		// Token: 0x0400113E RID: 4414
		private static byte[] _100continue = Encoding.ASCII.GetBytes("HTTP/1.1 100 Continue\r\n\r\n");

		// Token: 0x0400113F RID: 4415
		private static readonly string[] no_body_methods = new string[] { "GET", "HEAD", "DELETE" };

		// Token: 0x04001140 RID: 4416
		private static char[] separators = new char[] { ' ' };
	}
}
