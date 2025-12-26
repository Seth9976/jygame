using System;
using System.Configuration;
using System.IO;
using System.Net.Cache;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace System.Net
{
	/// <summary>Provides an HTTP-specific implementation of the <see cref="T:System.Net.WebRequest" /> class.</summary>
	// Token: 0x02000338 RID: 824
	[Serializable]
	public class HttpWebRequest : WebRequest, ISerializable
	{
		// Token: 0x06001C65 RID: 7269 RVA: 0x0005587C File Offset: 0x00053A7C
		internal HttpWebRequest(global::System.Uri uri)
		{
			this.requestUri = uri;
			this.actualUri = uri;
			this.proxy = GlobalProxySelection.Select;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.HttpWebRequest" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the new <see cref="T:System.Net.HttpWebRequest" /> object. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source and destination of the serialized stream associated with the new <see cref="T:System.Net.HttpWebRequest" /> object. </param>
		// Token: 0x06001C66 RID: 7270 RVA: 0x00055930 File Offset: 0x00053B30
		[Obsolete("Serialization is obsoleted for this type", false)]
		protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.requestUri = (global::System.Uri)serializationInfo.GetValue("requestUri", typeof(global::System.Uri));
			this.actualUri = (global::System.Uri)serializationInfo.GetValue("actualUri", typeof(global::System.Uri));
			this.allowAutoRedirect = serializationInfo.GetBoolean("allowAutoRedirect");
			this.allowBuffering = serializationInfo.GetBoolean("allowBuffering");
			this.certificates = (global::System.Security.Cryptography.X509Certificates.X509CertificateCollection)serializationInfo.GetValue("certificates", typeof(global::System.Security.Cryptography.X509Certificates.X509CertificateCollection));
			this.connectionGroup = serializationInfo.GetString("connectionGroup");
			this.contentLength = serializationInfo.GetInt64("contentLength");
			this.webHeaders = (WebHeaderCollection)serializationInfo.GetValue("webHeaders", typeof(WebHeaderCollection));
			this.keepAlive = serializationInfo.GetBoolean("keepAlive");
			this.maxAutoRedirect = serializationInfo.GetInt32("maxAutoRedirect");
			this.mediaType = serializationInfo.GetString("mediaType");
			this.method = serializationInfo.GetString("method");
			this.initialMethod = serializationInfo.GetString("initialMethod");
			this.pipelined = serializationInfo.GetBoolean("pipelined");
			this.version = (Version)serializationInfo.GetValue("version", typeof(Version));
			this.proxy = (IWebProxy)serializationInfo.GetValue("proxy", typeof(IWebProxy));
			this.sendChunked = serializationInfo.GetBoolean("sendChunked");
			this.timeout = serializationInfo.GetInt32("timeout");
			this.redirects = serializationInfo.GetInt32("redirects");
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00055B68 File Offset: 0x00053D68
		static HttpWebRequest()
		{
			NetConfig netConfig = global::System.Configuration.ConfigurationSettings.GetConfig("system.net/settings") as NetConfig;
			if (netConfig != null)
			{
				int num = netConfig.MaxResponseHeadersLength;
				if (num != -1)
				{
					num *= 64;
				}
				HttpWebRequest.defaultMaxResponseHeadersLength = num;
			}
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
		// Token: 0x06001C68 RID: 7272 RVA: 0x000149D2 File Offset: 0x00012BD2
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x000149DC File Offset: 0x00012BDC
		internal bool UsesNtlmAuthentication
		{
			get
			{
				return this.is_ntlm_auth;
			}
		}

		/// <summary>Gets or sets the value of the Accept HTTP header.</summary>
		/// <returns>The value of the Accept HTTP header. The default value is null.</returns>
		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x000149E4 File Offset: 0x00012BE4
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x000149F6 File Offset: 0x00012BF6
		public string Accept
		{
			get
			{
				return this.webHeaders["Accept"];
			}
			set
			{
				this.CheckRequestStarted();
				this.webHeaders.RemoveAndAdd("Accept", value);
			}
		}

		/// <summary>Gets the Uniform Resource Identifier (URI) of the Internet resource that actually responds to the request.</summary>
		/// <returns>A <see cref="T:System.Uri" /> that identifies the Internet resource that actually responds to the request. The default is the URI used by the <see cref="M:System.Net.WebRequest.Create(System.String)" /> method to initialize the request.</returns>
		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x00014A0F File Offset: 0x00012C0F
		public global::System.Uri Address
		{
			get
			{
				return this.actualUri;
			}
		}

		/// <summary>Gets or sets a value that indicates whether the request should follow redirection responses.</summary>
		/// <returns>true if the request should automatically follow redirection responses from the Internet resource; otherwise, false. The default value is true.</returns>
		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x00014A17 File Offset: 0x00012C17
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x00014A1F File Offset: 0x00012C1F
		public bool AllowAutoRedirect
		{
			get
			{
				return this.allowAutoRedirect;
			}
			set
			{
				this.allowAutoRedirect = value;
			}
		}

		/// <summary>Gets or sets a value that indicates whether to buffer the data sent to the Internet resource.</summary>
		/// <returns>true to enable buffering of the data sent to the Internet resource; false to disable buffering. The default is true.</returns>
		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x00014A28 File Offset: 0x00012C28
		// (set) Token: 0x06001C70 RID: 7280 RVA: 0x00014A30 File Offset: 0x00012C30
		public bool AllowWriteStreamBuffering
		{
			get
			{
				return this.allowBuffering;
			}
			set
			{
				this.allowBuffering = value;
			}
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x00005023 File Offset: 0x00003223
		private static Exception GetMustImplement()
		{
			return new NotImplementedException();
		}

		/// <summary>Gets or sets the type of decompression that is used.</summary>
		/// <returns>A T:System.Net.DecompressionMethods object that indicates the type of decompression that is used. </returns>
		/// <exception cref="T:System.InvalidOperationException">The object's current state does not allow this property to be set.</exception>
		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x00014A39 File Offset: 0x00012C39
		// (set) Token: 0x06001C73 RID: 7283 RVA: 0x00014A41 File Offset: 0x00012C41
		public DecompressionMethods AutomaticDecompression
		{
			get
			{
				return this.auto_decomp;
			}
			set
			{
				this.CheckRequestStarted();
				this.auto_decomp = value;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x00055BB0 File Offset: 0x00053DB0
		internal bool InternalAllowBuffering
		{
			get
			{
				return this.allowBuffering && (this.method != "HEAD" && this.method != "GET" && this.method != "MKCOL" && this.method != "CONNECT" && this.method != "DELETE") && this.method != "TRACE";
			}
		}

		/// <summary>Gets or sets the collection of security certificates that are associated with this request.</summary>
		/// <returns>The <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> that contains the security certificates associated with this request.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value specified for a set operation is null. </exception>
		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x00014A50 File Offset: 0x00012C50
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x00014A6E File Offset: 0x00012C6E
		public global::System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates
		{
			get
			{
				if (this.certificates == null)
				{
					this.certificates = new global::System.Security.Cryptography.X509Certificates.X509CertificateCollection();
				}
				return this.certificates;
			}
			[global::System.MonoTODO]
			set
			{
				throw HttpWebRequest.GetMustImplement();
			}
		}

		/// <summary>Gets or sets the value of the Connection HTTP header.</summary>
		/// <returns>The value of the Connection HTTP header. The default value is null.</returns>
		/// <exception cref="T:System.ArgumentException">The value of <see cref="P:System.Net.HttpWebRequest.Connection" /> is set to Keep-alive or Close. </exception>
		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x00014A75 File Offset: 0x00012C75
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x00055C48 File Offset: 0x00053E48
		public string Connection
		{
			get
			{
				return this.webHeaders["Connection"];
			}
			set
			{
				this.CheckRequestStarted();
				string text = value;
				if (text != null)
				{
					text = text.Trim().ToLower();
				}
				if (text == null || text.Length == 0)
				{
					this.webHeaders.RemoveInternal("Connection");
					return;
				}
				if (text == "keep-alive" || text == "close")
				{
					throw new ArgumentException("Keep-Alive and Close may not be set with this property");
				}
				if (this.keepAlive && text.IndexOf("keep-alive") == -1)
				{
					value += ", Keep-Alive";
				}
				this.webHeaders.RemoveAndAdd("Connection", value);
			}
		}

		/// <summary>Gets or sets the name of the connection group for the request.</summary>
		/// <returns>The name of the connection group for this request. The default value is null.</returns>
		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x00014A87 File Offset: 0x00012C87
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x00014A8F File Offset: 0x00012C8F
		public override string ConnectionGroupName
		{
			get
			{
				return this.connectionGroup;
			}
			set
			{
				this.connectionGroup = value;
			}
		}

		/// <summary>Gets or sets the Content-length HTTP header.</summary>
		/// <returns>The number of bytes of data to send to the Internet resource. The default is -1, which indicates the property has not been set and that there is no request data to send.</returns>
		/// <exception cref="T:System.InvalidOperationException">The request has been started by calling the <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" />, or <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> method. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The new <see cref="P:System.Net.HttpWebRequest.ContentLength" /> value is less than 0. </exception>
		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x00014A98 File Offset: 0x00012C98
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x00014AA0 File Offset: 0x00012CA0
		public override long ContentLength
		{
			get
			{
				return this.contentLength;
			}
			set
			{
				this.CheckRequestStarted();
				if (value < 0L)
				{
					throw new ArgumentOutOfRangeException("value", "Content-Length must be >= 0");
				}
				this.contentLength = value;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (set) Token: 0x06001C7D RID: 7293 RVA: 0x00014AC7 File Offset: 0x00012CC7
		internal long InternalContentLength
		{
			set
			{
				this.contentLength = value;
			}
		}

		/// <summary>Gets or sets the value of the Content-type HTTP header.</summary>
		/// <returns>The value of the Content-type HTTP header. The default value is null.</returns>
		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x00014AD0 File Offset: 0x00012CD0
		// (set) Token: 0x06001C7F RID: 7295 RVA: 0x00014AE2 File Offset: 0x00012CE2
		public override string ContentType
		{
			get
			{
				return this.webHeaders["Content-Type"];
			}
			set
			{
				if (value == null || value.Trim().Length == 0)
				{
					this.webHeaders.RemoveInternal("Content-Type");
					return;
				}
				this.webHeaders.RemoveAndAdd("Content-Type", value);
			}
		}

		/// <summary>Gets or sets the delegate method called when an HTTP 100-continue response is received from the Internet resource.</summary>
		/// <returns>A delegate that implements the callback method that executes when an HTTP Continue response is returned from the Internet resource. The default value is null.</returns>
		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x00014B1C File Offset: 0x00012D1C
		// (set) Token: 0x06001C81 RID: 7297 RVA: 0x00014B24 File Offset: 0x00012D24
		public HttpContinueDelegate ContinueDelegate
		{
			get
			{
				return this.continueDelegate;
			}
			set
			{
				this.continueDelegate = value;
			}
		}

		/// <summary>Gets or sets the cookies associated with the request.</summary>
		/// <returns>A <see cref="T:System.Net.CookieContainer" /> that contains the cookies associated with this request.</returns>
		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x00014B2D File Offset: 0x00012D2D
		// (set) Token: 0x06001C83 RID: 7299 RVA: 0x00014B35 File Offset: 0x00012D35
		public CookieContainer CookieContainer
		{
			get
			{
				return this.cookieContainer;
			}
			set
			{
				this.cookieContainer = value;
			}
		}

		/// <summary>Gets or sets authentication information for the request.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> that contains the authentication credentials associated with the request. The default is null.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x00014B3E File Offset: 0x00012D3E
		// (set) Token: 0x06001C85 RID: 7301 RVA: 0x00014B46 File Offset: 0x00012D46
		public override ICredentials Credentials
		{
			get
			{
				return this.credentials;
			}
			set
			{
				this.credentials = value;
			}
		}

		/// <summary>Gets or sets the default cache policy for this request.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.HttpRequestCachePolicy" /> that specifies the cache policy in effect for this request when no other policy is applicable.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x00014A6E File Offset: 0x00012C6E
		// (set) Token: 0x06001C87 RID: 7303 RVA: 0x00014A6E File Offset: 0x00012C6E
		[global::System.MonoTODO]
		public new static global::System.Net.Cache.RequestCachePolicy DefaultCachePolicy
		{
			get
			{
				throw HttpWebRequest.GetMustImplement();
			}
			set
			{
				throw HttpWebRequest.GetMustImplement();
			}
		}

		/// <summary>Gets or sets the default maximum length of an HTTP error response.</summary>
		/// <returns>An integer that represents the default maximum length of an HTTP error response.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value is less than 0 and is not equal to -1. </exception>
		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x00014A6E File Offset: 0x00012C6E
		// (set) Token: 0x06001C89 RID: 7305 RVA: 0x00014A6E File Offset: 0x00012C6E
		[global::System.MonoTODO]
		public static int DefaultMaximumErrorResponseLength
		{
			get
			{
				throw HttpWebRequest.GetMustImplement();
			}
			set
			{
				throw HttpWebRequest.GetMustImplement();
			}
		}

		/// <summary>Gets or sets the value of the Expect HTTP header.</summary>
		/// <returns>The contents of the Expect HTTP header. The default value is null.Note:The value for this property is stored in <see cref="T:System.Net.WebHeaderCollection" />. If WebHeaderCollection is set, the property value is lost.</returns>
		/// <exception cref="T:System.ArgumentException">Expect is set to a string that contains "100-continue" as a substring. </exception>
		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x00014B4F File Offset: 0x00012D4F
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x00055CF8 File Offset: 0x00053EF8
		public string Expect
		{
			get
			{
				return this.webHeaders["Expect"];
			}
			set
			{
				this.CheckRequestStarted();
				string text = value;
				if (text != null)
				{
					text = text.Trim().ToLower();
				}
				if (text == null || text.Length == 0)
				{
					this.webHeaders.RemoveInternal("Expect");
					return;
				}
				if (text == "100-continue")
				{
					throw new ArgumentException("100-Continue cannot be set with this property.", "value");
				}
				this.webHeaders.RemoveAndAdd("Expect", value);
			}
		}

		/// <summary>Gets a value that indicates whether a response has been received from an Internet resource.</summary>
		/// <returns>true if a response has been received; otherwise, false.</returns>
		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x00014B61 File Offset: 0x00012D61
		public bool HaveResponse
		{
			get
			{
				return this.haveResponse;
			}
		}

		/// <summary>Specifies a collection of the name/value pairs that make up the HTTP headers.</summary>
		/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> that contains the name/value pairs that make up the headers for the HTTP request.</returns>
		/// <exception cref="T:System.InvalidOperationException">The request has been started by calling the <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" />, or <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> method. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x00014B69 File Offset: 0x00012D69
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x00055D74 File Offset: 0x00053F74
		public override WebHeaderCollection Headers
		{
			get
			{
				return this.webHeaders;
			}
			set
			{
				this.CheckRequestStarted();
				WebHeaderCollection webHeaderCollection = new WebHeaderCollection(true);
				int count = value.Count;
				for (int i = 0; i < count; i++)
				{
					webHeaderCollection.Add(value.GetKey(i), value.Get(i));
				}
				this.webHeaders = webHeaderCollection;
			}
		}

		/// <summary>Gets or sets the value of the If-Modified-Since HTTP header.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> that contains the contents of the If-Modified-Since HTTP header. The default value is the current date and time.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00055DC4 File Offset: 0x00053FC4
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x00055E24 File Offset: 0x00054024
		public DateTime IfModifiedSince
		{
			get
			{
				string text = this.webHeaders["If-Modified-Since"];
				if (text == null)
				{
					return DateTime.Now;
				}
				DateTime dateTime;
				try
				{
					dateTime = MonoHttpDate.Parse(text);
				}
				catch (Exception)
				{
					dateTime = DateTime.Now;
				}
				return dateTime;
			}
			set
			{
				this.CheckRequestStarted();
				this.webHeaders.SetInternal("If-Modified-Since", value.ToUniversalTime().ToString("r", null));
			}
		}

		/// <summary>Gets or sets a value that indicates whether to make a persistent connection to the Internet resource.</summary>
		/// <returns>true if the request to the Internet resource should contain a Connection HTTP header with the value Keep-alive; otherwise, false. The default is true.</returns>
		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x00014B71 File Offset: 0x00012D71
		// (set) Token: 0x06001C92 RID: 7314 RVA: 0x00014B79 File Offset: 0x00012D79
		public bool KeepAlive
		{
			get
			{
				return this.keepAlive;
			}
			set
			{
				this.keepAlive = value;
			}
		}

		/// <summary>Gets or sets the maximum number of redirects that the request follows.</summary>
		/// <returns>The maximum number of redirection responses that the request follows. The default value is 50.</returns>
		/// <exception cref="T:System.ArgumentException">The value is set to 0 or less. </exception>
		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x00014B82 File Offset: 0x00012D82
		// (set) Token: 0x06001C94 RID: 7316 RVA: 0x00014B8A File Offset: 0x00012D8A
		public int MaximumAutomaticRedirections
		{
			get
			{
				return this.maxAutoRedirect;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Must be > 0", "value");
				}
				this.maxAutoRedirect = value;
			}
		}

		/// <summary>Gets or sets the maximum allowed length of the response headers.</summary>
		/// <returns>The length, in kilobytes (1024 bytes), of the response headers.</returns>
		/// <exception cref="T:System.InvalidOperationException">The property is set after the request has already been submitted. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value is less than 0 and is not equal to -1. </exception>
		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x00014BAA File Offset: 0x00012DAA
		// (set) Token: 0x06001C96 RID: 7318 RVA: 0x00014BB2 File Offset: 0x00012DB2
		[global::System.MonoTODO("Use this")]
		public int MaximumResponseHeadersLength
		{
			get
			{
				return this.maxResponseHeadersLength;
			}
			set
			{
				this.maxResponseHeadersLength = value;
			}
		}

		/// <summary>Gets or sets the default for the <see cref="P:System.Net.HttpWebRequest.MaximumResponseHeadersLength" /> property.</summary>
		/// <returns>The length, in kilobytes (1024 bytes), of the default maximum for response headers received. The default configuration file sets this value to 64 kilobytes.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value is not equal to -1 and is less than zero. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x00014BBB File Offset: 0x00012DBB
		// (set) Token: 0x06001C98 RID: 7320 RVA: 0x00014BC2 File Offset: 0x00012DC2
		[global::System.MonoTODO("Use this")]
		public static int DefaultMaximumResponseHeadersLength
		{
			get
			{
				return HttpWebRequest.defaultMaxResponseHeadersLength;
			}
			set
			{
				HttpWebRequest.defaultMaxResponseHeadersLength = value;
			}
		}

		/// <summary>Gets or sets a time-out in milliseconds when writing to or reading from a stream.</summary>
		/// <returns>The number of milliseconds before the writing or reading times out. The default value is 300,000 milliseconds (5 minutes).</returns>
		/// <exception cref="T:System.InvalidOperationException">The request has already been sent. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than or equal to zero and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /></exception>
		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x00014BCA File Offset: 0x00012DCA
		// (set) Token: 0x06001C9A RID: 7322 RVA: 0x00014BD2 File Offset: 0x00012DD2
		public int ReadWriteTimeout
		{
			get
			{
				return this.readWriteTimeout;
			}
			set
			{
				if (this.requestSent)
				{
					throw new InvalidOperationException("The request has already been sent.");
				}
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value", "Must be >= -1");
				}
				this.readWriteTimeout = value;
			}
		}

		/// <summary>Gets or sets the media type of the request.</summary>
		/// <returns>The media type of the request. The default value is null.</returns>
		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x00014C08 File Offset: 0x00012E08
		// (set) Token: 0x06001C9C RID: 7324 RVA: 0x00014C10 File Offset: 0x00012E10
		public string MediaType
		{
			get
			{
				return this.mediaType;
			}
			set
			{
				this.mediaType = value;
			}
		}

		/// <summary>Gets or sets the method for the request.</summary>
		/// <returns>The request method to use to contact the Internet resource. The default value is GET.</returns>
		/// <exception cref="T:System.ArgumentException">No method is supplied.-or- The method string contains invalid characters. </exception>
		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x00014C19 File Offset: 0x00012E19
		// (set) Token: 0x06001C9E RID: 7326 RVA: 0x00014C21 File Offset: 0x00012E21
		public override string Method
		{
			get
			{
				return this.method;
			}
			set
			{
				if (value == null || value.Trim() == string.Empty)
				{
					throw new ArgumentException("not a valid method");
				}
				this.method = value;
			}
		}

		/// <summary>Gets or sets a value that indicates whether to pipeline the request to the Internet resource.</summary>
		/// <returns>true if the request should be pipelined; otherwise, false. The default is true.</returns>
		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x00014C50 File Offset: 0x00012E50
		// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x00014C58 File Offset: 0x00012E58
		public bool Pipelined
		{
			get
			{
				return this.pipelined;
			}
			set
			{
				this.pipelined = value;
			}
		}

		/// <summary>Gets or sets a value that indicates whether to send an Authorization header with the request.</summary>
		/// <returns>true to send an HTTP Authorization header with requests after authentication has taken place; otherwise, false. The default is false.</returns>
		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x00014C61 File Offset: 0x00012E61
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x00014C69 File Offset: 0x00012E69
		public override bool PreAuthenticate
		{
			get
			{
				return this.preAuthenticate;
			}
			set
			{
				this.preAuthenticate = value;
			}
		}

		/// <summary>Gets or sets the version of HTTP to use for the request.</summary>
		/// <returns>The HTTP version to use for the request. The default is <see cref="F:System.Net.HttpVersion.Version11" />.</returns>
		/// <exception cref="T:System.ArgumentException">The HTTP version is set to a value other than 1.0 or 1.1. </exception>
		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x00014C72 File Offset: 0x00012E72
		// (set) Token: 0x06001CA4 RID: 7332 RVA: 0x00014C7A File Offset: 0x00012E7A
		public Version ProtocolVersion
		{
			get
			{
				return this.version;
			}
			set
			{
				if (value != HttpVersion.Version10 && value != HttpVersion.Version11)
				{
					throw new ArgumentException("value");
				}
				this.version = value;
			}
		}

		/// <summary>Gets or sets proxy information for the request.</summary>
		/// <returns>The <see cref="T:System.Net.IWebProxy" /> object to use to proxy the request. The default value is set by calling the <see cref="P:System.Net.GlobalProxySelection.Select" /> property.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <see cref="P:System.Net.HttpWebRequest.Proxy" /> is set to null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The request has been started by calling <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" />, or <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have permission for the requested operation. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x00014CAE File Offset: 0x00012EAE
		// (set) Token: 0x06001CA6 RID: 7334 RVA: 0x00014CB6 File Offset: 0x00012EB6
		public override IWebProxy Proxy
		{
			get
			{
				return this.proxy;
			}
			set
			{
				this.CheckRequestStarted();
				this.proxy = value;
				this.servicePoint = null;
			}
		}

		/// <summary>Gets or sets the value of the Referer HTTP header.</summary>
		/// <returns>The value of the Referer HTTP header. The default value is null.</returns>
		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x00014CCC File Offset: 0x00012ECC
		// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x00014CDE File Offset: 0x00012EDE
		public string Referer
		{
			get
			{
				return this.webHeaders["Referer"];
			}
			set
			{
				this.CheckRequestStarted();
				if (value == null || value.Trim().Length == 0)
				{
					this.webHeaders.RemoveInternal("Referer");
					return;
				}
				this.webHeaders.SetInternal("Referer", value);
			}
		}

		/// <summary>Gets the original Uniform Resource Identifier (URI) of the request.</summary>
		/// <returns>A <see cref="T:System.Uri" /> that contains the URI of the Internet resource passed to the <see cref="M:System.Net.WebRequest.Create(System.String)" /> method.</returns>
		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x00014D1E File Offset: 0x00012F1E
		public override global::System.Uri RequestUri
		{
			get
			{
				return this.requestUri;
			}
		}

		/// <summary>Gets or sets a value that indicates whether to send data in segments to the Internet resource.</summary>
		/// <returns>true to send data to the Internet resource in segments; otherwise, false. The default value is false.</returns>
		/// <exception cref="T:System.InvalidOperationException">The request has been started by calling the <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" />, or <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> method. </exception>
		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x00014D26 File Offset: 0x00012F26
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x00014D2E File Offset: 0x00012F2E
		public bool SendChunked
		{
			get
			{
				return this.sendChunked;
			}
			set
			{
				this.CheckRequestStarted();
				this.sendChunked = value;
			}
		}

		/// <summary>Gets the service point to use for the request.</summary>
		/// <returns>A <see cref="T:System.Net.ServicePoint" /> that represents the network connection to the Internet resource.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00014D3D File Offset: 0x00012F3D
		public ServicePoint ServicePoint
		{
			get
			{
				return this.GetServicePoint();
			}
		}

		/// <summary>Gets or sets the time-out value in milliseconds for the <see cref="M:System.Net.HttpWebRequest.GetResponse" /> and <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> methods.</summary>
		/// <returns>The number of milliseconds to wait before the request times out. The default value is 100,000 milliseconds (100 seconds).</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified is less than zero and is not <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x00014D45 File Offset: 0x00012F45
		// (set) Token: 0x06001CAE RID: 7342 RVA: 0x00014D4D File Offset: 0x00012F4D
		public override int Timeout
		{
			get
			{
				return this.timeout;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.timeout = value;
			}
		}

		/// <summary>Gets or sets the value of the Transfer-encoding HTTP header.</summary>
		/// <returns>The value of the Transfer-encoding HTTP header. The default value is null.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set when <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is false. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set to the value "Chunked". </exception>
		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x00014D68 File Offset: 0x00012F68
		// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x00055E5C File Offset: 0x0005405C
		public string TransferEncoding
		{
			get
			{
				return this.webHeaders["Transfer-Encoding"];
			}
			set
			{
				this.CheckRequestStarted();
				string text = value;
				if (text != null)
				{
					text = text.Trim().ToLower();
				}
				if (text == null || text.Length == 0)
				{
					this.webHeaders.RemoveInternal("Transfer-Encoding");
					return;
				}
				if (text == "chunked")
				{
					throw new ArgumentException("Chunked encoding must be set with the SendChunked property");
				}
				if (!this.sendChunked)
				{
					throw new ArgumentException("SendChunked must be True", "value");
				}
				this.webHeaders.RemoveAndAdd("Transfer-Encoding", value);
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that controls whether default credentials are sent with requests.</summary>
		/// <returns>true if the default credentials are used; otherwise false. The default value is false.</returns>
		/// <exception cref="T:System.InvalidOperationException">You attempted to set this property after the request was sent.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="USERNAME" />
		/// </PermissionSet>
		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x00014D7A File Offset: 0x00012F7A
		// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x00055EEC File Offset: 0x000540EC
		public override bool UseDefaultCredentials
		{
			get
			{
				return CredentialCache.DefaultCredentials == this.Credentials;
			}
			set
			{
				ICredentials credentials;
				if (value)
				{
					ICredentials defaultCredentials = CredentialCache.DefaultCredentials;
					credentials = defaultCredentials;
				}
				else
				{
					credentials = null;
				}
				this.Credentials = credentials;
			}
		}

		/// <summary>Gets or sets the value of the User-agent HTTP header.</summary>
		/// <returns>The value of the User-agent HTTP header. The default value is null.Note:The value for this property is stored in <see cref="T:System.Net.WebHeaderCollection" />. If WebHeaderCollection is set, the property value is lost.</returns>
		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x00014D89 File Offset: 0x00012F89
		// (set) Token: 0x06001CB4 RID: 7348 RVA: 0x00014D9B File Offset: 0x00012F9B
		public string UserAgent
		{
			get
			{
				return this.webHeaders["User-Agent"];
			}
			set
			{
				this.webHeaders.SetInternal("User-Agent", value);
			}
		}

		/// <summary>Gets or sets a value that indicates whether to allow high-speed NTLM-authenticated connection sharing.</summary>
		/// <returns>true to keep the authenticated connection open; otherwise, false.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x00014DAE File Offset: 0x00012FAE
		// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x00014DB6 File Offset: 0x00012FB6
		public bool UnsafeAuthenticatedConnectionSharing
		{
			get
			{
				return this.unsafe_auth_blah;
			}
			set
			{
				this.unsafe_auth_blah = value;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001CB7 RID: 7351 RVA: 0x00014DBF File Offset: 0x00012FBF
		internal bool GotRequestStream
		{
			get
			{
				return this.gotRequestStream;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x00014DC7 File Offset: 0x00012FC7
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x00014DCF File Offset: 0x00012FCF
		internal bool ExpectContinue
		{
			get
			{
				return this.expectContinue;
			}
			set
			{
				this.expectContinue = value;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x00014A0F File Offset: 0x00012C0F
		internal global::System.Uri AuthUri
		{
			get
			{
				return this.actualUri;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x00014DD8 File Offset: 0x00012FD8
		internal bool ProxyQuery
		{
			get
			{
				return this.servicePoint.UsesProxy && !this.servicePoint.UseConnect;
			}
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x00055F14 File Offset: 0x00054114
		internal ServicePoint GetServicePoint()
		{
			object obj = this.locker;
			lock (obj)
			{
				if (this.hostChanged || this.servicePoint == null)
				{
					this.servicePoint = ServicePointManager.FindServicePoint(this.actualUri, this.proxy);
					this.hostChanged = false;
				}
			}
			return this.servicePoint;
		}

		/// <summary>Adds a byte range header to a request for a specific range from the beginning or end of the requested data.</summary>
		/// <param name="range">The starting or ending point of the range. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rangeSpecifier" /> is invalid. </exception>
		/// <exception cref="T:System.InvalidOperationException">The range header could not be added. </exception>
		// Token: 0x06001CBD RID: 7357 RVA: 0x00014DFB File Offset: 0x00012FFB
		public void AddRange(int range)
		{
			this.AddRange("bytes", range);
		}

		/// <summary>Adds a byte range header to the request for a specified range.</summary>
		/// <param name="from">The position at which to start sending data. </param>
		/// <param name="to">The position at which to stop sending data. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rangeSpecifier" /> is invalid. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="from" /> is greater than <paramref name="to" />-or- <paramref name="from" /> or <paramref name="to" /> is less than 0. </exception>
		/// <exception cref="T:System.InvalidOperationException">The range header could not be added. </exception>
		// Token: 0x06001CBE RID: 7358 RVA: 0x00014E09 File Offset: 0x00013009
		public void AddRange(int from, int to)
		{
			this.AddRange("bytes", from, to);
		}

		/// <summary>Adds a Range header to a request for a specific range from the beginning or end of the requested data.</summary>
		/// <param name="rangeSpecifier">The description of the range. </param>
		/// <param name="range">The starting or ending point of the range. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="rangeSpecifier" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rangeSpecifier" /> is invalid. </exception>
		/// <exception cref="T:System.InvalidOperationException">The range header could not be added. </exception>
		// Token: 0x06001CBF RID: 7359 RVA: 0x00055F84 File Offset: 0x00054184
		public void AddRange(string rangeSpecifier, int range)
		{
			if (rangeSpecifier == null)
			{
				throw new ArgumentNullException("rangeSpecifier");
			}
			string text = this.webHeaders["Range"];
			if (text == null || text.Length == 0)
			{
				text = rangeSpecifier + "=";
			}
			else
			{
				if (!text.ToLower().StartsWith(rangeSpecifier.ToLower() + "="))
				{
					throw new InvalidOperationException("rangeSpecifier");
				}
				text += ",";
			}
			this.webHeaders.RemoveAndAdd("Range", text + range + "-");
		}

		/// <summary>Adds a range header to a request for a specified range.</summary>
		/// <param name="rangeSpecifier">The description of the range. </param>
		/// <param name="from">The position at which to start sending data. </param>
		/// <param name="to">The position at which to stop sending data. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="rangeSpecifier" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="from" /> is greater than <paramref name="to" />-or- <paramref name="from" /> or <paramref name="to" /> is less than 0. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rangeSpecifier" /> is invalid. </exception>
		/// <exception cref="T:System.InvalidOperationException">The range header could not be added. </exception>
		// Token: 0x06001CC0 RID: 7360 RVA: 0x00056034 File Offset: 0x00054234
		public void AddRange(string rangeSpecifier, int from, int to)
		{
			if (rangeSpecifier == null)
			{
				throw new ArgumentNullException("rangeSpecifier");
			}
			if (from < 0 || to < 0 || from > to)
			{
				throw new ArgumentOutOfRangeException();
			}
			string text = this.webHeaders["Range"];
			if (text == null || text.Length == 0)
			{
				text = rangeSpecifier + "=";
			}
			else
			{
				if (!text.ToLower().StartsWith(rangeSpecifier.ToLower() + "="))
				{
					throw new InvalidOperationException("rangeSpecifier");
				}
				text += ",";
			}
			this.webHeaders.RemoveAndAdd("Range", string.Concat(new object[] { text, from, "-", to }));
		}

		/// <summary>Begins an asynchronous request for a <see cref="T:System.IO.Stream" /> object to use to write data.</summary>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate. </param>
		/// <param name="state">The state object for this request. </param>
		/// <exception cref="T:System.Net.ProtocolViolationException">The <see cref="P:System.Net.HttpWebRequest.Method" /> property is GET or HEAD.-or- <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> is true, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> is false, <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is -1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is false, and <see cref="P:System.Net.HttpWebRequest.Method" /> is POST or PUT. </exception>
		/// <exception cref="T:System.InvalidOperationException">The stream is being used by a previous call to <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />-or- <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set to a value and <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is false.-or- The thread pool is running out of threads. </exception>
		/// <exception cref="T:System.NotSupportedException">The request cache validator indicated that the response for this request can be served from the cache; however, requests that write data must not use the cache. This exception can occur if you are using a custom cache validator that is incorrectly implemented. </exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called. </exception>
		/// <exception cref="T:System.ObjectDisposedException">In a .NET Compact Framework application, a request stream with zero content length was not obtained and closed correctly. For more information about handling zero content length requests, see Network Programming in the .NET Compact Framework.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.DnsPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001CC1 RID: 7361 RVA: 0x00056118 File Offset: 0x00054318
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			if (this.Aborted)
			{
				throw new WebException("The request was canceled.", WebExceptionStatus.RequestCanceled);
			}
			bool flag = !(this.method == "GET") && !(this.method == "CONNECT") && !(this.method == "HEAD") && !(this.method == "TRACE") && !(this.method == "DELETE");
			if (this.method == null || !flag)
			{
				throw new ProtocolViolationException("Cannot send data when method is: " + this.method);
			}
			if (this.contentLength == -1L && !this.sendChunked && !this.allowBuffering && this.KeepAlive)
			{
				throw new ProtocolViolationException("Content-Length not set");
			}
			string transferEncoding = this.TransferEncoding;
			if (!this.sendChunked && transferEncoding != null && transferEncoding.Trim() != string.Empty)
			{
				throw new ProtocolViolationException("SendChunked should be true.");
			}
			object obj = this.locker;
			IAsyncResult asyncResult;
			lock (obj)
			{
				if (this.asyncWrite != null)
				{
					throw new InvalidOperationException("Cannot re-call start of asynchronous method while a previous call is still in progress.");
				}
				this.asyncWrite = new WebAsyncResult(this, callback, state);
				this.initialMethod = this.method;
				if (this.haveRequest && this.writeStream != null)
				{
					this.asyncWrite.SetCompleted(true, this.writeStream);
					this.asyncWrite.DoCallback();
					asyncResult = this.asyncWrite;
				}
				else
				{
					this.gotRequestStream = true;
					WebAsyncResult webAsyncResult = this.asyncWrite;
					if (!this.requestSent)
					{
						this.requestSent = true;
						this.redirects = 0;
						this.servicePoint = this.GetServicePoint();
						this.abortHandler = this.servicePoint.SendRequest(this, this.connectionGroup);
					}
					asyncResult = webAsyncResult;
				}
			}
			return asyncResult;
		}

		/// <summary>Ends an asynchronous request for a <see cref="T:System.IO.Stream" /> object to use to write data.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> to use to write request data.</returns>
		/// <param name="asyncResult">The pending request for a stream. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> is null. </exception>
		/// <exception cref="T:System.IO.IOException">The request did not complete, and no stream is available. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="asyncResult" /> was not returned by the current instance from a call to <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">This method was called previously using <paramref name="asyncResult" />. </exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called.-or- An error occurred while processing the request. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06001CC2 RID: 7362 RVA: 0x00056330 File Offset: 0x00054530
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			WebAsyncResult webAsyncResult = asyncResult as WebAsyncResult;
			if (webAsyncResult == null)
			{
				throw new ArgumentException("Invalid IAsyncResult");
			}
			this.asyncWrite = webAsyncResult;
			webAsyncResult.WaitUntilComplete();
			Exception exception = webAsyncResult.Exception;
			if (exception != null)
			{
				throw exception;
			}
			return webAsyncResult.WriteStream;
		}

		/// <summary>Gets a <see cref="T:System.IO.Stream" /> object to use to write request data.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> to use to write request data.</returns>
		/// <exception cref="T:System.Net.ProtocolViolationException">The <see cref="P:System.Net.HttpWebRequest.Method" /> property is GET or HEAD.-or- <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> is true, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> is false, <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is -1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is false, and <see cref="P:System.Net.HttpWebRequest.Method" /> is POST or PUT. </exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> method is called more than once.-or- <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set to a value and <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is false. </exception>
		/// <exception cref="T:System.NotSupportedException">The request cache validator indicated that the response for this request can be served from the cache; however, requests that write data must not use the cache. This exception can occur if you are using a custom cache validator that is incorrectly implemented. </exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called.-or- The time-out period for the request expired.-or- An error occurred while processing the request. </exception>
		/// <exception cref="T:System.ObjectDisposedException">In a .NET Compact Framework application, a request stream with zero content length was not obtained and closed correctly. For more information about handling zero content length requests, see Network Programming in the .NET Compact Framework.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.DnsPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001CC3 RID: 7363 RVA: 0x00056388 File Offset: 0x00054588
		public override Stream GetRequestStream()
		{
			IAsyncResult asyncResult = this.asyncWrite;
			if (asyncResult == null)
			{
				asyncResult = this.BeginGetRequestStream(null, null);
				this.asyncWrite = (WebAsyncResult)asyncResult;
			}
			if (!asyncResult.IsCompleted && !asyncResult.AsyncWaitHandle.WaitOne(this.timeout, false))
			{
				this.Abort();
				throw new WebException("The request timed out", WebExceptionStatus.Timeout);
			}
			return this.EndGetRequestStream(asyncResult);
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x000563F4 File Offset: 0x000545F4
		private void CheckIfForceWrite()
		{
			if (this.writeStream == null || this.writeStream.RequestWritten || this.contentLength < 0L || !this.InternalAllowBuffering)
			{
				return;
			}
			if ((long)this.writeStream.WriteBufferLength == this.contentLength)
			{
				this.writeStream.WriteRequest();
			}
		}

		/// <summary>Begins an asynchronous request to an Internet resource.</summary>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request for a response.</returns>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate </param>
		/// <param name="state">The state object for this request. </param>
		/// <exception cref="T:System.InvalidOperationException">The stream is already in use by a previous call to <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />-or- <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set to a value and <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is false.-or- The thread pool is running out of threads. </exception>
		/// <exception cref="T:System.Net.ProtocolViolationException">
		///   <see cref="P:System.Net.HttpWebRequest.Method" /> is GET or HEAD, and either <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is greater than zero or <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is true.-or- <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> is true, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> is false, and either <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is -1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is false and <see cref="P:System.Net.HttpWebRequest.Method" /> is POST or PUT. </exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.DnsPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001CC5 RID: 7365 RVA: 0x00056458 File Offset: 0x00054658
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			if (this.Aborted)
			{
				throw new WebException("The request was canceled.", WebExceptionStatus.RequestCanceled);
			}
			if (this.method == null)
			{
				throw new ProtocolViolationException("Method is null.");
			}
			string transferEncoding = this.TransferEncoding;
			if (!this.sendChunked && transferEncoding != null && transferEncoding.Trim() != string.Empty)
			{
				throw new ProtocolViolationException("SendChunked should be true.");
			}
			Monitor.Enter(this.locker);
			this.getResponseCalled = true;
			if (this.asyncRead != null && !this.haveResponse)
			{
				Monitor.Exit(this.locker);
				throw new InvalidOperationException("Cannot re-call start of asynchronous method while a previous call is still in progress.");
			}
			this.CheckIfForceWrite();
			this.asyncRead = new WebAsyncResult(this, callback, state);
			WebAsyncResult webAsyncResult = this.asyncRead;
			this.initialMethod = this.method;
			if (this.haveResponse)
			{
				Exception ex = this.saved_exc;
				if (this.webResponse != null)
				{
					Monitor.Exit(this.locker);
					if (ex == null)
					{
						webAsyncResult.SetCompleted(true, this.webResponse);
					}
					else
					{
						webAsyncResult.SetCompleted(true, ex);
					}
					webAsyncResult.DoCallback();
					return webAsyncResult;
				}
				if (ex != null)
				{
					Monitor.Exit(this.locker);
					webAsyncResult.SetCompleted(true, ex);
					webAsyncResult.DoCallback();
					return webAsyncResult;
				}
			}
			if (!this.requestSent)
			{
				this.requestSent = true;
				this.redirects = 0;
				this.servicePoint = this.GetServicePoint();
				this.abortHandler = this.servicePoint.SendRequest(this, this.connectionGroup);
			}
			Monitor.Exit(this.locker);
			return webAsyncResult;
		}

		/// <summary>Ends an asynchronous request to an Internet resource.</summary>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains the response from the Internet resource.</returns>
		/// <param name="asyncResult">The pending request for a response. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> is null. </exception>
		/// <exception cref="T:System.InvalidOperationException">This method was called previously using <paramref name="asyncResult." />-or- The <see cref="P:System.Net.HttpWebRequest.ContentLength" /> property is greater than 0 but the data has not been written to the request stream. </exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called.-or- An error occurred while processing the request. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="asyncResult" /> was not returned by the current instance from a call to <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06001CC6 RID: 7366 RVA: 0x000565EC File Offset: 0x000547EC
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			WebAsyncResult webAsyncResult = asyncResult as WebAsyncResult;
			if (webAsyncResult == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			if (!webAsyncResult.WaitUntilComplete(this.timeout, false))
			{
				this.Abort();
				throw new WebException("The request timed out", WebExceptionStatus.Timeout);
			}
			if (webAsyncResult.GotException)
			{
				throw webAsyncResult.Exception;
			}
			return webAsyncResult.Response;
		}

		/// <summary>Returns a response from an Internet resource.</summary>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains the response from the Internet resource.</returns>
		/// <exception cref="T:System.InvalidOperationException">The stream is already in use by a previous call to <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.-or- <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set to a value and <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is false. </exception>
		/// <exception cref="T:System.Net.ProtocolViolationException">
		///   <see cref="P:System.Net.HttpWebRequest.Method" /> is GET or HEAD, and either <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is greater or equal to zero or <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is true.-or- <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> is true, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> is false, <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is -1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is false, and <see cref="P:System.Net.HttpWebRequest.Method" /> is POST or PUT. </exception>
		/// <exception cref="T:System.NotSupportedException">The request cache validator indicated that the response for this request can be served from the cache; however, this request includes data to be sent to the server. Requests that send data must not use the cache. This exception can occur if you are using a custom cache validator that is incorrectly implemented. </exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called.-or- The time-out period for the request expired.-or- An error occurred while processing the request. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.DnsPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001CC7 RID: 7367 RVA: 0x00056664 File Offset: 0x00054864
		public override WebResponse GetResponse()
		{
			WebAsyncResult webAsyncResult = (WebAsyncResult)this.BeginGetResponse(null, null);
			return this.EndGetResponse(webAsyncResult);
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x00014E18 File Offset: 0x00013018
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x00014E20 File Offset: 0x00013020
		internal bool FinishedReading
		{
			get
			{
				return this.finished_reading;
			}
			set
			{
				this.finished_reading = value;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00014E29 File Offset: 0x00013029
		internal bool Aborted
		{
			get
			{
				return Interlocked.CompareExchange(ref this.aborted, 0, 0) == 1;
			}
		}

		/// <summary>Cancels a request to an Internet resource.</summary>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06001CCB RID: 7371 RVA: 0x00056688 File Offset: 0x00054888
		public override void Abort()
		{
			if (Interlocked.CompareExchange(ref this.aborted, 1, 0) == 1)
			{
				return;
			}
			if (this.haveResponse && this.finished_reading)
			{
				return;
			}
			this.haveResponse = true;
			if (this.abortHandler != null)
			{
				try
				{
					this.abortHandler(this, EventArgs.Empty);
				}
				catch (Exception)
				{
				}
				this.abortHandler = null;
			}
			if (this.asyncWrite != null)
			{
				WebAsyncResult webAsyncResult = this.asyncWrite;
				if (!webAsyncResult.IsCompleted)
				{
					try
					{
						WebException ex = new WebException("Aborted.", WebExceptionStatus.RequestCanceled);
						webAsyncResult.SetCompleted(false, ex);
						webAsyncResult.DoCallback();
					}
					catch
					{
					}
				}
				this.asyncWrite = null;
			}
			if (this.asyncRead != null)
			{
				WebAsyncResult webAsyncResult2 = this.asyncRead;
				if (!webAsyncResult2.IsCompleted)
				{
					try
					{
						WebException ex2 = new WebException("Aborted.", WebExceptionStatus.RequestCanceled);
						webAsyncResult2.SetCompleted(false, ex2);
						webAsyncResult2.DoCallback();
					}
					catch
					{
					}
				}
				this.asyncRead = null;
			}
			if (this.writeStream != null)
			{
				try
				{
					this.writeStream.Close();
					this.writeStream = null;
				}
				catch
				{
				}
			}
			if (this.webResponse != null)
			{
				try
				{
					this.webResponse.Close();
					this.webResponse = null;
				}
				catch
				{
				}
			}
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data required to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
		// Token: 0x06001CCC RID: 7372 RVA: 0x00056818 File Offset: 0x00054A18
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			serializationInfo.AddValue("requestUri", this.requestUri, typeof(global::System.Uri));
			serializationInfo.AddValue("actualUri", this.actualUri, typeof(global::System.Uri));
			serializationInfo.AddValue("allowAutoRedirect", this.allowAutoRedirect);
			serializationInfo.AddValue("allowBuffering", this.allowBuffering);
			serializationInfo.AddValue("certificates", this.certificates, typeof(global::System.Security.Cryptography.X509Certificates.X509CertificateCollection));
			serializationInfo.AddValue("connectionGroup", this.connectionGroup);
			serializationInfo.AddValue("contentLength", this.contentLength);
			serializationInfo.AddValue("webHeaders", this.webHeaders, typeof(WebHeaderCollection));
			serializationInfo.AddValue("keepAlive", this.keepAlive);
			serializationInfo.AddValue("maxAutoRedirect", this.maxAutoRedirect);
			serializationInfo.AddValue("mediaType", this.mediaType);
			serializationInfo.AddValue("method", this.method);
			serializationInfo.AddValue("initialMethod", this.initialMethod);
			serializationInfo.AddValue("pipelined", this.pipelined);
			serializationInfo.AddValue("version", this.version, typeof(Version));
			serializationInfo.AddValue("proxy", this.proxy, typeof(IWebProxy));
			serializationInfo.AddValue("sendChunked", this.sendChunked);
			serializationInfo.AddValue("timeout", this.timeout);
			serializationInfo.AddValue("redirects", this.redirects);
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00014E3B File Offset: 0x0001303B
		private void CheckRequestStarted()
		{
			if (this.requestSent)
			{
				throw new InvalidOperationException("request started");
			}
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x00014E53 File Offset: 0x00013053
		internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers)
		{
			if (this.continueDelegate != null)
			{
				this.continueDelegate(statusCode, headers);
			}
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000569A8 File Offset: 0x00054BA8
		private bool Redirect(WebAsyncResult result, HttpStatusCode code)
		{
			this.redirects++;
			Exception ex = null;
			string text = null;
			switch (code)
			{
			case HttpStatusCode.MultipleChoices:
				ex = new WebException("Ambiguous redirect.");
				goto IL_00E4;
			case HttpStatusCode.MovedPermanently:
			case HttpStatusCode.Found:
			case HttpStatusCode.TemporaryRedirect:
				this.contentLength = -1L;
				this.bodyBufferLength = 0;
				this.bodyBuffer = null;
				this.method = "GET";
				text = this.webResponse.Headers["Location"];
				goto IL_00E4;
			case HttpStatusCode.SeeOther:
				this.method = "GET";
				text = this.webResponse.Headers["Location"];
				goto IL_00E4;
			case HttpStatusCode.NotModified:
				return false;
			case HttpStatusCode.UseProxy:
				ex = new NotImplementedException("Proxy support not available.");
				goto IL_00E4;
			}
			ex = new ProtocolViolationException("Invalid status code: " + (int)code);
			IL_00E4:
			if (ex != null)
			{
				throw ex;
			}
			if (text == null)
			{
				throw new WebException("No Location header found for " + (int)code, WebExceptionStatus.ProtocolError);
			}
			global::System.Uri uri = this.actualUri;
			try
			{
				this.actualUri = new global::System.Uri(this.actualUri, text);
			}
			catch (Exception)
			{
				throw new WebException(string.Format("Invalid URL ({0}) for {1}", text, (int)code), WebExceptionStatus.ProtocolError);
			}
			this.hostChanged = this.actualUri.Scheme != uri.Scheme || this.actualUri.Host != uri.Host || this.actualUri.Port != uri.Port;
			return true;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00056B60 File Offset: 0x00054D60
		private string GetHeaders()
		{
			bool flag = false;
			if (this.sendChunked)
			{
				flag = true;
				this.webHeaders.RemoveAndAdd("Transfer-Encoding", "chunked");
				this.webHeaders.RemoveInternal("Content-Length");
			}
			else if (this.contentLength != -1L)
			{
				if (this.contentLength > 0L)
				{
					flag = true;
				}
				this.webHeaders.SetInternal("Content-Length", this.contentLength.ToString());
				this.webHeaders.RemoveInternal("Transfer-Encoding");
			}
			if (this.actualVersion == HttpVersion.Version11 && flag && this.servicePoint.SendContinue)
			{
				this.webHeaders.RemoveAndAdd("Expect", "100-continue");
				this.expectContinue = true;
			}
			else
			{
				this.webHeaders.RemoveInternal("Expect");
				this.expectContinue = false;
			}
			bool proxyQuery = this.ProxyQuery;
			string text = ((!proxyQuery) ? "Connection" : "Proxy-Connection");
			this.webHeaders.RemoveInternal(proxyQuery ? "Connection" : "Proxy-Connection");
			Version protocolVersion = this.servicePoint.ProtocolVersion;
			bool flag2 = protocolVersion == null || protocolVersion == HttpVersion.Version10;
			if (this.keepAlive && (this.version == HttpVersion.Version10 || flag2))
			{
				this.webHeaders.RemoveAndAdd(text, "keep-alive");
			}
			else if (!this.keepAlive && this.version == HttpVersion.Version11)
			{
				this.webHeaders.RemoveAndAdd(text, "close");
			}
			this.webHeaders.SetInternal("Host", this.actualUri.Authority);
			if (this.cookieContainer != null)
			{
				string cookieHeader = this.cookieContainer.GetCookieHeader(this.actualUri);
				if (cookieHeader != string.Empty)
				{
					this.webHeaders.SetInternal("Cookie", cookieHeader);
				}
			}
			string text2 = null;
			if ((this.auto_decomp & DecompressionMethods.GZip) != DecompressionMethods.None)
			{
				text2 = "gzip";
			}
			if ((this.auto_decomp & DecompressionMethods.Deflate) != DecompressionMethods.None)
			{
				text2 = ((text2 == null) ? "deflate" : "gzip, deflate");
			}
			if (text2 != null)
			{
				this.webHeaders.RemoveAndAdd("Accept-Encoding", text2);
			}
			if (!this.usedPreAuth && this.preAuthenticate)
			{
				this.DoPreAuthenticate();
			}
			return this.webHeaders.ToString();
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00056DFC File Offset: 0x00054FFC
		private void DoPreAuthenticate()
		{
			bool flag = this.proxy != null && !this.proxy.IsBypassed(this.actualUri);
			ICredentials credentials2;
			if (!flag || this.credentials != null)
			{
				ICredentials credentials = this.credentials;
				credentials2 = credentials;
			}
			else
			{
				credentials2 = this.proxy.Credentials;
			}
			ICredentials credentials3 = credentials2;
			Authorization authorization = AuthenticationManager.PreAuthenticate(this, credentials3);
			if (authorization == null)
			{
				return;
			}
			this.webHeaders.RemoveInternal("Proxy-Authorization");
			this.webHeaders.RemoveInternal("Authorization");
			string text = ((!flag || this.credentials != null) ? "Authorization" : "Proxy-Authorization");
			this.webHeaders[text] = authorization.Message;
			this.usedPreAuth = true;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00056EC4 File Offset: 0x000550C4
		internal void SetWriteStreamError(WebExceptionStatus status, Exception exc)
		{
			if (this.Aborted)
			{
				return;
			}
			WebAsyncResult webAsyncResult = this.asyncWrite;
			if (webAsyncResult == null)
			{
				webAsyncResult = this.asyncRead;
			}
			if (webAsyncResult != null)
			{
				WebException ex;
				if (exc == null)
				{
					string text = "Error: " + status;
					ex = new WebException(text, status);
				}
				else
				{
					string text = string.Format("Error: {0} ({1})", status, exc.Message);
					ex = new WebException(text, exc, status);
				}
				webAsyncResult.SetCompleted(false, ex);
				webAsyncResult.DoCallback();
			}
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00056F4C File Offset: 0x0005514C
		internal void SendRequestHeaders(bool propagate_error)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string text;
			if (!this.ProxyQuery)
			{
				text = this.actualUri.PathAndQuery;
			}
			else if (this.actualUri.IsDefaultPort)
			{
				text = string.Format("{0}://{1}{2}", this.actualUri.Scheme, this.actualUri.Host, this.actualUri.PathAndQuery);
			}
			else
			{
				text = string.Format("{0}://{1}:{2}{3}", new object[]
				{
					this.actualUri.Scheme,
					this.actualUri.Host,
					this.actualUri.Port,
					this.actualUri.PathAndQuery
				});
			}
			if (this.servicePoint.ProtocolVersion != null && this.servicePoint.ProtocolVersion < this.version)
			{
				this.actualVersion = this.servicePoint.ProtocolVersion;
			}
			else
			{
				this.actualVersion = this.version;
			}
			stringBuilder.AppendFormat("{0} {1} HTTP/{2}.{3}\r\n", new object[]
			{
				this.method,
				text,
				this.actualVersion.Major,
				this.actualVersion.Minor
			});
			stringBuilder.Append(this.GetHeaders());
			string text2 = stringBuilder.ToString();
			byte[] bytes = Encoding.UTF8.GetBytes(text2);
			try
			{
				this.writeStream.SetHeaders(bytes);
			}
			catch (WebException ex)
			{
				this.SetWriteStreamError(ex.Status, ex);
				if (propagate_error)
				{
					throw;
				}
			}
			catch (Exception ex2)
			{
				this.SetWriteStreamError(WebExceptionStatus.SendFailure, ex2);
				if (propagate_error)
				{
					throw;
				}
			}
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00057128 File Offset: 0x00055328
		internal void SetWriteStream(WebConnectionStream stream)
		{
			if (this.Aborted)
			{
				return;
			}
			this.writeStream = stream;
			if (this.bodyBuffer != null)
			{
				this.webHeaders.RemoveInternal("Transfer-Encoding");
				this.contentLength = (long)this.bodyBufferLength;
				this.writeStream.SendChunked = false;
			}
			this.SendRequestHeaders(false);
			this.haveRequest = true;
			if (this.bodyBuffer != null)
			{
				this.writeStream.Write(this.bodyBuffer, 0, this.bodyBufferLength);
				this.bodyBuffer = null;
				this.writeStream.Close();
			}
			else if (this.method != "HEAD" && this.method != "GET" && this.method != "MKCOL" && this.method != "CONNECT" && this.method != "DELETE" && this.method != "TRACE" && this.getResponseCalled && !this.writeStream.RequestWritten)
			{
				this.writeStream.WriteRequest();
			}
			if (this.asyncWrite != null)
			{
				this.asyncWrite.SetCompleted(false, stream);
				this.asyncWrite.DoCallback();
				this.asyncWrite = null;
			}
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00057294 File Offset: 0x00055494
		internal void SetResponseError(WebExceptionStatus status, Exception e, string where)
		{
			if (this.Aborted)
			{
				return;
			}
			object obj = this.locker;
			lock (obj)
			{
				string text = string.Format("Error getting response stream ({0}): {1}", where, status);
				WebAsyncResult webAsyncResult = this.asyncRead;
				if (webAsyncResult == null)
				{
					webAsyncResult = this.asyncWrite;
				}
				WebException ex;
				if (e is WebException)
				{
					ex = (WebException)e;
				}
				else
				{
					ex = new WebException(text, e, status, null);
				}
				if (webAsyncResult != null)
				{
					if (!webAsyncResult.IsCompleted)
					{
						webAsyncResult.SetCompleted(false, ex);
						webAsyncResult.DoCallback();
					}
					else if (webAsyncResult == this.asyncWrite)
					{
						this.saved_exc = ex;
					}
					this.haveResponse = true;
					this.asyncRead = null;
					this.asyncWrite = null;
				}
				else
				{
					this.haveResponse = true;
					this.saved_exc = ex;
				}
			}
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0005737C File Offset: 0x0005557C
		private void CheckSendError(WebConnectionData data)
		{
			int statusCode = data.StatusCode;
			if (statusCode < 400 || statusCode == 401 || statusCode == 407)
			{
				return;
			}
			if (this.writeStream != null && this.asyncRead == null && !this.writeStream.CompleteRequestWritten)
			{
				this.saved_exc = new WebException(data.StatusDescription, null, WebExceptionStatus.ProtocolError, this.webResponse);
				this.webResponse.ReadAll();
			}
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x000573FC File Offset: 0x000555FC
		private void HandleNtlmAuth(WebAsyncResult r)
		{
			WebConnectionStream webConnectionStream = this.webResponse.GetResponseStream() as WebConnectionStream;
			if (webConnectionStream != null)
			{
				WebConnection connection = webConnectionStream.Connection;
				connection.PriorityRequest = this;
				ICredentials credentials2;
				if (this.proxy == null || this.proxy.IsBypassed(this.actualUri))
				{
					ICredentials credentials = this.credentials;
					credentials2 = credentials;
				}
				else
				{
					credentials2 = this.proxy.Credentials;
				}
				ICredentials credentials3 = credentials2;
				if (credentials3 != null)
				{
					connection.NtlmCredential = credentials3.GetCredential(this.requestUri, "NTLM");
					connection.UnsafeAuthenticatedConnectionSharing = this.unsafe_auth_blah;
				}
			}
			r.Reset();
			this.haveResponse = false;
			this.webResponse.ReadAll();
			this.webResponse = null;
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x000574BC File Offset: 0x000556BC
		internal void SetResponseData(WebConnectionData data)
		{
			object obj = this.locker;
			lock (obj)
			{
				if (this.Aborted)
				{
					if (data.stream != null)
					{
						data.stream.Close();
					}
				}
				else
				{
					WebException ex = null;
					try
					{
						this.webResponse = new HttpWebResponse(this.actualUri, this.method, data, this.cookieContainer);
					}
					catch (Exception ex2)
					{
						ex = new WebException(ex2.Message, ex2, WebExceptionStatus.ProtocolError, null);
						if (data.stream != null)
						{
							data.stream.Close();
						}
					}
					if (ex == null && (this.method == "POST" || this.method == "PUT"))
					{
						object obj2 = this.locker;
						lock (obj2)
						{
							this.CheckSendError(data);
							if (this.saved_exc != null)
							{
								ex = (WebException)this.saved_exc;
							}
						}
					}
					WebAsyncResult webAsyncResult = this.asyncRead;
					bool flag = false;
					if (webAsyncResult == null && this.webResponse != null)
					{
						flag = true;
						webAsyncResult = new WebAsyncResult(null, null);
						webAsyncResult.SetCompleted(false, this.webResponse);
					}
					if (webAsyncResult != null)
					{
						if (ex != null)
						{
							webAsyncResult.SetCompleted(false, ex);
							webAsyncResult.DoCallback();
						}
						else
						{
							try
							{
								if (!this.CheckFinalStatus(webAsyncResult))
								{
									if (this.is_ntlm_auth && this.authCompleted && this.webResponse != null && this.webResponse.StatusCode < HttpStatusCode.BadRequest)
									{
										WebConnectionStream webConnectionStream = this.webResponse.GetResponseStream() as WebConnectionStream;
										if (webConnectionStream != null)
										{
											WebConnection connection = webConnectionStream.Connection;
											connection.NtlmAuthenticated = true;
										}
									}
									if (this.writeStream != null)
									{
										this.writeStream.KillBuffer();
									}
									this.haveResponse = true;
									webAsyncResult.SetCompleted(false, this.webResponse);
									webAsyncResult.DoCallback();
								}
								else
								{
									if (this.webResponse != null)
									{
										if (this.is_ntlm_auth)
										{
											this.HandleNtlmAuth(webAsyncResult);
											return;
										}
										this.webResponse.Close();
									}
									this.finished_reading = false;
									this.haveResponse = false;
									this.webResponse = null;
									webAsyncResult.Reset();
									this.servicePoint = this.GetServicePoint();
									this.abortHandler = this.servicePoint.SendRequest(this, this.connectionGroup);
								}
							}
							catch (WebException ex3)
							{
								if (flag)
								{
									this.saved_exc = ex3;
									this.haveResponse = true;
								}
								webAsyncResult.SetCompleted(false, ex3);
								webAsyncResult.DoCallback();
							}
							catch (Exception ex4)
							{
								ex = new WebException(ex4.Message, ex4, WebExceptionStatus.ProtocolError, null);
								if (flag)
								{
									this.saved_exc = ex;
									this.haveResponse = true;
								}
								webAsyncResult.SetCompleted(false, ex);
								webAsyncResult.DoCallback();
							}
						}
					}
				}
			}
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x00057824 File Offset: 0x00055A24
		private bool CheckAuthorization(WebResponse response, HttpStatusCode code)
		{
			this.authCompleted = false;
			if (code == HttpStatusCode.Unauthorized && this.credentials == null)
			{
				return false;
			}
			bool flag = code == HttpStatusCode.ProxyAuthenticationRequired;
			if (flag && (this.proxy == null || this.proxy.Credentials == null))
			{
				return false;
			}
			string[] values = response.Headers.GetValues((!flag) ? "WWW-Authenticate" : "Proxy-Authenticate");
			if (values == null || values.Length == 0)
			{
				return false;
			}
			ICredentials credentials2;
			if (!flag)
			{
				ICredentials credentials = this.credentials;
				credentials2 = credentials;
			}
			else
			{
				credentials2 = this.proxy.Credentials;
			}
			ICredentials credentials3 = credentials2;
			Authorization authorization = null;
			foreach (string text in values)
			{
				authorization = AuthenticationManager.Authenticate(text, this, credentials3);
				if (authorization != null)
				{
					break;
				}
			}
			if (authorization == null)
			{
				return false;
			}
			this.webHeaders[(!flag) ? "Authorization" : "Proxy-Authorization"] = authorization.Message;
			this.authCompleted = authorization.Complete;
			this.is_ntlm_auth = authorization.Module.AuthenticationType == "NTLM";
			return true;
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00057960 File Offset: 0x00055B60
		private bool CheckFinalStatus(WebAsyncResult result)
		{
			if (result.GotException)
			{
				throw result.Exception;
			}
			Exception ex = result.Exception;
			this.bodyBuffer = null;
			HttpWebResponse response = result.Response;
			WebExceptionStatus webExceptionStatus = WebExceptionStatus.ProtocolError;
			HttpStatusCode httpStatusCode = (HttpStatusCode)0;
			if (ex == null && this.webResponse != null)
			{
				httpStatusCode = this.webResponse.StatusCode;
				if (!this.authCompleted && ((httpStatusCode == HttpStatusCode.Unauthorized && this.credentials != null) || (this.ProxyQuery && httpStatusCode == HttpStatusCode.ProxyAuthenticationRequired)) && !this.usedPreAuth && this.CheckAuthorization(this.webResponse, httpStatusCode))
				{
					if (this.InternalAllowBuffering)
					{
						this.bodyBuffer = this.writeStream.WriteBuffer;
						this.bodyBufferLength = this.writeStream.WriteBufferLength;
						return true;
					}
					if (this.method != "PUT" && this.method != "POST")
					{
						return true;
					}
					this.writeStream.InternalClose();
					this.writeStream = null;
					this.webResponse.Close();
					this.webResponse = null;
					throw new WebException("This request requires buffering of data for authentication or redirection to be sucessful.");
				}
				else if (httpStatusCode >= HttpStatusCode.BadRequest)
				{
					string text = string.Format("The remote server returned an error: ({0}) {1}.", (int)httpStatusCode, this.webResponse.StatusDescription);
					ex = new WebException(text, null, webExceptionStatus, this.webResponse);
					this.webResponse.ReadAll();
				}
				else if (httpStatusCode == HttpStatusCode.NotModified && this.allowAutoRedirect)
				{
					string text2 = string.Format("The remote server returned an error: ({0}) {1}.", (int)httpStatusCode, this.webResponse.StatusDescription);
					ex = new WebException(text2, null, webExceptionStatus, this.webResponse);
				}
				else if (httpStatusCode >= HttpStatusCode.MultipleChoices && this.allowAutoRedirect && this.redirects >= this.maxAutoRedirect)
				{
					ex = new WebException("Max. redirections exceeded.", null, webExceptionStatus, this.webResponse);
					this.webResponse.ReadAll();
				}
			}
			if (ex == null)
			{
				bool flag = false;
				int num = (int)httpStatusCode;
				if (this.allowAutoRedirect && num >= 300)
				{
					if (this.InternalAllowBuffering && this.writeStream.WriteBufferLength > 0)
					{
						this.bodyBuffer = this.writeStream.WriteBuffer;
						this.bodyBufferLength = this.writeStream.WriteBufferLength;
					}
					flag = this.Redirect(result, httpStatusCode);
				}
				if (response != null && num >= 300 && num != 304)
				{
					response.ReadAll();
				}
				return flag;
			}
			if (this.writeStream != null)
			{
				this.writeStream.InternalClose();
				this.writeStream = null;
			}
			this.webResponse = null;
			throw ex;
		}

		// Token: 0x040011D7 RID: 4567
		private global::System.Uri requestUri;

		// Token: 0x040011D8 RID: 4568
		private global::System.Uri actualUri;

		// Token: 0x040011D9 RID: 4569
		private bool hostChanged;

		// Token: 0x040011DA RID: 4570
		private bool allowAutoRedirect = true;

		// Token: 0x040011DB RID: 4571
		private bool allowBuffering = true;

		// Token: 0x040011DC RID: 4572
		private global::System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates;

		// Token: 0x040011DD RID: 4573
		private string connectionGroup;

		// Token: 0x040011DE RID: 4574
		private long contentLength = -1L;

		// Token: 0x040011DF RID: 4575
		private HttpContinueDelegate continueDelegate;

		// Token: 0x040011E0 RID: 4576
		private CookieContainer cookieContainer;

		// Token: 0x040011E1 RID: 4577
		private ICredentials credentials;

		// Token: 0x040011E2 RID: 4578
		private bool haveResponse;

		// Token: 0x040011E3 RID: 4579
		private bool haveRequest;

		// Token: 0x040011E4 RID: 4580
		private bool requestSent;

		// Token: 0x040011E5 RID: 4581
		private WebHeaderCollection webHeaders = new WebHeaderCollection(true);

		// Token: 0x040011E6 RID: 4582
		private bool keepAlive = true;

		// Token: 0x040011E7 RID: 4583
		private int maxAutoRedirect = 50;

		// Token: 0x040011E8 RID: 4584
		private string mediaType = string.Empty;

		// Token: 0x040011E9 RID: 4585
		private string method = "GET";

		// Token: 0x040011EA RID: 4586
		private string initialMethod = "GET";

		// Token: 0x040011EB RID: 4587
		private bool pipelined = true;

		// Token: 0x040011EC RID: 4588
		private bool preAuthenticate;

		// Token: 0x040011ED RID: 4589
		private bool usedPreAuth;

		// Token: 0x040011EE RID: 4590
		private Version version = HttpVersion.Version11;

		// Token: 0x040011EF RID: 4591
		private Version actualVersion;

		// Token: 0x040011F0 RID: 4592
		private IWebProxy proxy;

		// Token: 0x040011F1 RID: 4593
		private bool sendChunked;

		// Token: 0x040011F2 RID: 4594
		private ServicePoint servicePoint;

		// Token: 0x040011F3 RID: 4595
		private int timeout = 100000;

		// Token: 0x040011F4 RID: 4596
		private WebConnectionStream writeStream;

		// Token: 0x040011F5 RID: 4597
		private HttpWebResponse webResponse;

		// Token: 0x040011F6 RID: 4598
		private WebAsyncResult asyncWrite;

		// Token: 0x040011F7 RID: 4599
		private WebAsyncResult asyncRead;

		// Token: 0x040011F8 RID: 4600
		private EventHandler abortHandler;

		// Token: 0x040011F9 RID: 4601
		private int aborted;

		// Token: 0x040011FA RID: 4602
		private bool gotRequestStream;

		// Token: 0x040011FB RID: 4603
		private int redirects;

		// Token: 0x040011FC RID: 4604
		private bool expectContinue;

		// Token: 0x040011FD RID: 4605
		private bool authCompleted;

		// Token: 0x040011FE RID: 4606
		private byte[] bodyBuffer;

		// Token: 0x040011FF RID: 4607
		private int bodyBufferLength;

		// Token: 0x04001200 RID: 4608
		private bool getResponseCalled;

		// Token: 0x04001201 RID: 4609
		private Exception saved_exc;

		// Token: 0x04001202 RID: 4610
		private object locker = new object();

		// Token: 0x04001203 RID: 4611
		private bool is_ntlm_auth;

		// Token: 0x04001204 RID: 4612
		private bool finished_reading;

		// Token: 0x04001205 RID: 4613
		internal WebConnection WebConnection;

		// Token: 0x04001206 RID: 4614
		private DecompressionMethods auto_decomp;

		// Token: 0x04001207 RID: 4615
		private int maxResponseHeadersLength;

		// Token: 0x04001208 RID: 4616
		private static int defaultMaxResponseHeadersLength = 65536;

		// Token: 0x04001209 RID: 4617
		private int readWriteTimeout = 300000;

		// Token: 0x0400120A RID: 4618
		private bool unsafe_auth_blah;
	}
}
