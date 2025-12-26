using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Net.Cache;
using System.Net.Configuration;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Security.Principal;

namespace System.Net
{
	/// <summary>Makes a request to a Uniform Resource Identifier (URI). This is an abstract class.</summary>
	// Token: 0x0200043B RID: 1083
	[Serializable]
	public abstract class WebRequest : MarshalByRefObject, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebRequest" /> class.</summary>
		// Token: 0x0600269C RID: 9884 RVA: 0x0001B201 File Offset: 0x00019401
		protected WebRequest()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebRequest" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that contains the information required to serialize the new <see cref="T:System.Net.WebRequest" /> instance. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that indicates the source of the serialized stream associated with the new <see cref="T:System.Net.WebRequest" /> instance. </param>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the constructor, when the constructor is not overridden in a descendant class. </exception>
		// Token: 0x0600269D RID: 9885 RVA: 0x0001B201 File Offset: 0x00019401
		protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x000731C4 File Offset: 0x000713C4
		static WebRequest()
		{
			object section = ConfigurationManager.GetSection("system.net/webRequestModules");
			global::System.Net.Configuration.WebRequestModulesSection webRequestModulesSection = section as global::System.Net.Configuration.WebRequestModulesSection;
			if (webRequestModulesSection != null)
			{
				foreach (object obj in webRequestModulesSection.WebRequestModules)
				{
					global::System.Net.Configuration.WebRequestModuleElement webRequestModuleElement = (global::System.Net.Configuration.WebRequestModuleElement)obj;
					WebRequest.AddPrefix(webRequestModuleElement.Prefix, webRequestModuleElement.Type);
				}
				return;
			}
			global::System.Configuration.ConfigurationSettings.GetConfig("system.net/webRequestModules");
		}

		/// <summary>When overridden in a descendant class, populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance with the data needed to serialize the <see cref="T:System.Net.WebRequest" />.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" />, which holds the serialized data for the <see cref="T:System.Net.WebRequest" />. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the destination of the serialized stream associated with the new <see cref="T:System.Net.WebRequest" />. </param>
		/// <exception cref="T:System.NotImplementedException">An attempt is made to serialize the object, when the interface is not overridden in a descendant class. </exception>
		// Token: 0x0600269F RID: 9887 RVA: 0x00006A38 File Offset: 0x00004C38
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x0007326C File Offset: 0x0007146C
		private static void AddDynamicPrefix(string protocol, string implementor)
		{
			Type type = typeof(WebRequest).Assembly.GetType("System.Net." + implementor);
			if (type == null)
			{
				return;
			}
			WebRequest.AddPrefix(protocol, type);
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x0001B210 File Offset: 0x00019410
		private static Exception GetMustImplement()
		{
			return new NotImplementedException("This method must be implemented in derived classes");
		}

		/// <summary>Gets or sets values indicating the level of authentication and impersonation used for this request.</summary>
		/// <returns>A bitwise combination of the <see cref="T:System.Net.Security.AuthenticationLevel" /> values. The default value is <see cref="F:System.Net.Security.AuthenticationLevel.MutualAuthRequested" />.In mutual authentication, both the client and server present credentials to establish their identity. The <see cref="F:System.Net.Security.AuthenticationLevel.MutualAuthRequired" /> and <see cref="F:System.Net.Security.AuthenticationLevel.MutualAuthRequested" /> values are relevant for Kerberos authentication. Kerberos authentication can be supported directly, or can be used if the Negotiate security protocol is used to select the actual security protocol. For more information about authentication protocols, see Internet Authentication.To determine whether mutual authentication occurred, check the <see cref="P:System.Net.WebResponse.IsMutuallyAuthenticated" /> property. If you specify the <see cref="F:System.Net.Security.AuthenticationLevel.MutualAuthRequired" /> authentication flag value and mutual authentication does not occur, your application will receive an <see cref="T:System.IO.IOException" /> with a <see cref="T:System.Net.ProtocolViolationException" /> inner exception indicating that mutual authentication failed.</returns>
		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x060026A2 RID: 9890 RVA: 0x0001B21C File Offset: 0x0001941C
		// (set) Token: 0x060026A3 RID: 9891 RVA: 0x0001B224 File Offset: 0x00019424
		public global::System.Net.Security.AuthenticationLevel AuthenticationLevel
		{
			get
			{
				return this.authentication_level;
			}
			set
			{
				this.authentication_level = value;
			}
		}

		/// <summary>Gets or sets the cache policy for this request.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.RequestCachePolicy" /> object that defines a cache policy.</returns>
		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x0001B22D File Offset: 0x0001942D
		// (set) Token: 0x060026A5 RID: 9893 RVA: 0x000029F5 File Offset: 0x00000BF5
		public virtual global::System.Net.Cache.RequestCachePolicy CachePolicy
		{
			get
			{
				throw WebRequest.GetMustImplement();
			}
			set
			{
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets the name of the connection group for the request.</summary>
		/// <returns>The name of the connection group for the request.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x060026A6 RID: 9894 RVA: 0x0001B22D File Offset: 0x0001942D
		// (set) Token: 0x060026A7 RID: 9895 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual string ConnectionGroupName
		{
			get
			{
				throw WebRequest.GetMustImplement();
			}
			set
			{
				throw WebRequest.GetMustImplement();
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets the content length of the request data being sent.</summary>
		/// <returns>The number of bytes of request data being sent.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x060026A8 RID: 9896 RVA: 0x0001B22D File Offset: 0x0001942D
		// (set) Token: 0x060026A9 RID: 9897 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual long ContentLength
		{
			get
			{
				throw WebRequest.GetMustImplement();
			}
			set
			{
				throw WebRequest.GetMustImplement();
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets the content type of the request data being sent.</summary>
		/// <returns>The content type of the request data.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x060026AA RID: 9898 RVA: 0x0001B22D File Offset: 0x0001942D
		// (set) Token: 0x060026AB RID: 9899 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual string ContentType
		{
			get
			{
				throw WebRequest.GetMustImplement();
			}
			set
			{
				throw WebRequest.GetMustImplement();
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets the network credentials used for authenticating the request with the Internet resource.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> containing the authentication credentials associated with the request. The default is null.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x0001B22D File Offset: 0x0001942D
		// (set) Token: 0x060026AD RID: 9901 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual ICredentials Credentials
		{
			get
			{
				throw WebRequest.GetMustImplement();
			}
			set
			{
				throw WebRequest.GetMustImplement();
			}
		}

		/// <summary>Gets or sets the default cache policy for this request.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.HttpRequestCachePolicy" /> that specifies the cache policy in effect for this request when no other policy is applicable.</returns>
		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x0001B22D File Offset: 0x0001942D
		// (set) Token: 0x060026AF RID: 9903 RVA: 0x0001B22D File Offset: 0x0001942D
		public static global::System.Net.Cache.RequestCachePolicy DefaultCachePolicy
		{
			get
			{
				throw WebRequest.GetMustImplement();
			}
			set
			{
				throw WebRequest.GetMustImplement();
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets the collection of header name/value pairs associated with the request.</summary>
		/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> containing the header name/value pairs associated with this request.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x060026B0 RID: 9904 RVA: 0x0001B22D File Offset: 0x0001942D
		// (set) Token: 0x060026B1 RID: 9905 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual WebHeaderCollection Headers
		{
			get
			{
				throw WebRequest.GetMustImplement();
			}
			set
			{
				throw WebRequest.GetMustImplement();
			}
		}

		/// <summary>Gets or sets the impersonation level for the current request.</summary>
		/// <returns>A <see cref="T:System.Security.Principal.TokenImpersonationLevel" /> value.</returns>
		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x060026B2 RID: 9906 RVA: 0x0001B22D File Offset: 0x0001942D
		// (set) Token: 0x060026B3 RID: 9907 RVA: 0x0001B22D File Offset: 0x0001942D
		public TokenImpersonationLevel ImpersonationLevel
		{
			get
			{
				throw WebRequest.GetMustImplement();
			}
			set
			{
				throw WebRequest.GetMustImplement();
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets the protocol method to use in this request.</summary>
		/// <returns>The protocol method to use in this request.</returns>
		/// <exception cref="T:System.NotImplementedException">If the property is not overridden in a descendant class, any attempt is made to get or set the property. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x060026B4 RID: 9908 RVA: 0x0001B22D File Offset: 0x0001942D
		// (set) Token: 0x060026B5 RID: 9909 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual string Method
		{
			get
			{
				throw WebRequest.GetMustImplement();
			}
			set
			{
				throw WebRequest.GetMustImplement();
			}
		}

		/// <summary>When overridden in a descendant class, indicates whether to pre-authenticate the request.</summary>
		/// <returns>true to pre-authenticate; otherwise, false.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x060026B6 RID: 9910 RVA: 0x0001B22D File Offset: 0x0001942D
		// (set) Token: 0x060026B7 RID: 9911 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual bool PreAuthenticate
		{
			get
			{
				throw WebRequest.GetMustImplement();
			}
			set
			{
				throw WebRequest.GetMustImplement();
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets the network proxy to use to access this Internet resource.</summary>
		/// <returns>The <see cref="T:System.Net.IWebProxy" /> to use to access the Internet resource.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x060026B8 RID: 9912 RVA: 0x0001B22D File Offset: 0x0001942D
		// (set) Token: 0x060026B9 RID: 9913 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual IWebProxy Proxy
		{
			get
			{
				throw WebRequest.GetMustImplement();
			}
			set
			{
				throw WebRequest.GetMustImplement();
			}
		}

		/// <summary>When overridden in a descendant class, gets the URI of the Internet resource associated with the request.</summary>
		/// <returns>A <see cref="T:System.Uri" /> representing the resource associated with the request </returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x060026BA RID: 9914 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual global::System.Uri RequestUri
		{
			get
			{
				throw WebRequest.GetMustImplement();
			}
		}

		/// <summary>Gets or sets the length of time, in milliseconds, before the request times out.</summary>
		/// <returns>The length of time, in milliseconds, until the request times out, or the value <see cref="F:System.Threading.Timeout.Infinite" /> to indicate that the request does not time out. The default value is defined by the descendant class.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x0001B22D File Offset: 0x0001942D
		// (set) Token: 0x060026BC RID: 9916 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual int Timeout
		{
			get
			{
				throw WebRequest.GetMustImplement();
			}
			set
			{
				throw WebRequest.GetMustImplement();
			}
		}

		/// <summary>When overridden in a descendant class, gets or sets a <see cref="T:System.Boolean" /> value that controls whether <see cref="P:System.Net.CredentialCache.DefaultCredentials" /> are sent with requests.</summary>
		/// <returns>true if the default credentials are used; otherwise false. The default value is false.</returns>
		/// <exception cref="T:System.InvalidOperationException">You attempted to set this property after the request was sent.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x0001B22D File Offset: 0x0001942D
		// (set) Token: 0x060026BE RID: 9918 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual bool UseDefaultCredentials
		{
			get
			{
				throw WebRequest.GetMustImplement();
			}
			set
			{
				throw WebRequest.GetMustImplement();
			}
		}

		/// <summary>Gets or sets the global HTTP proxy.</summary>
		/// <returns>An <see cref="T:System.Net.IWebProxy" /> used by every call to instances of <see cref="T:System.Net.WebRequest" />.</returns>
		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x000732A8 File Offset: 0x000714A8
		// (set) Token: 0x060026C0 RID: 9920 RVA: 0x0001B234 File Offset: 0x00019434
		public static IWebProxy DefaultWebProxy
		{
			get
			{
				if (!WebRequest.isDefaultWebProxySet)
				{
					object obj = WebRequest.lockobj;
					lock (obj)
					{
						if (WebRequest.defaultWebProxy == null)
						{
							WebRequest.defaultWebProxy = WebRequest.GetDefaultWebProxy();
						}
					}
				}
				return WebRequest.defaultWebProxy;
			}
			set
			{
				WebRequest.defaultWebProxy = value;
				WebRequest.isDefaultWebProxySet = true;
			}
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x00073300 File Offset: 0x00071500
		[global::System.MonoTODO("Needs to respect Module, Proxy.AutoDetect, and Proxy.ScriptLocation config settings")]
		private static IWebProxy GetDefaultWebProxy()
		{
			global::System.Net.Configuration.DefaultProxySection defaultProxySection = ConfigurationManager.GetSection("system.net/defaultProxy") as global::System.Net.Configuration.DefaultProxySection;
			if (defaultProxySection == null)
			{
				return WebRequest.GetSystemWebProxy();
			}
			global::System.Net.Configuration.ProxyElement proxy = defaultProxySection.Proxy;
			WebProxy webProxy;
			if (proxy.UseSystemDefault != global::System.Net.Configuration.ProxyElement.UseSystemDefaultValues.False && proxy.ProxyAddress == null)
			{
				webProxy = (WebProxy)WebRequest.GetSystemWebProxy();
			}
			else
			{
				webProxy = new WebProxy();
			}
			if (proxy.ProxyAddress != null)
			{
				webProxy.Address = proxy.ProxyAddress;
			}
			if (proxy.BypassOnLocal != global::System.Net.Configuration.ProxyElement.BypassOnLocalValues.Unspecified)
			{
				webProxy.BypassProxyOnLocal = proxy.BypassOnLocal == global::System.Net.Configuration.ProxyElement.BypassOnLocalValues.True;
			}
			return webProxy;
		}

		/// <summary>Aborts the Request </summary>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060026C2 RID: 9922 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual void Abort()
		{
			throw WebRequest.GetMustImplement();
		}

		/// <summary>When overridden in a descendant class, provides an asynchronous version of the <see cref="M:System.Net.WebRequest.GetRequestStream" /> method.</summary>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate. </param>
		/// <param name="state">An object containing state information for this asynchronous request. </param>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		// Token: 0x060026C3 RID: 9923 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			throw WebRequest.GetMustImplement();
		}

		/// <summary>When overridden in a descendant class, begins an asynchronous request for an Internet resource.</summary>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate. </param>
		/// <param name="state">An object containing state information for this asynchronous request. </param>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		// Token: 0x060026C4 RID: 9924 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			throw WebRequest.GetMustImplement();
		}

		/// <summary>Initializes a new <see cref="T:System.Net.WebRequest" /> instance for the specified URI scheme.</summary>
		/// <returns>A <see cref="T:System.Net.WebRequest" /> descendant for the specific URI scheme.</returns>
		/// <param name="requestUriString">The URI that identifies the Internet resource. </param>
		/// <exception cref="T:System.NotSupportedException">The request scheme specified in <paramref name="requestUriString" /> has not been registered. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="requestUriString" /> is null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have permission to connect to the requested URI or a URI that the request is redirected to. </exception>
		/// <exception cref="T:System.UriFormatException">The URI specified in <paramref name="requestUriString" /> is not a valid URI. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060026C5 RID: 9925 RVA: 0x0001B242 File Offset: 0x00019442
		public static WebRequest Create(string requestUriString)
		{
			if (requestUriString == null)
			{
				throw new ArgumentNullException("requestUriString");
			}
			return WebRequest.Create(new global::System.Uri(requestUriString));
		}

		/// <summary>Initializes a new <see cref="T:System.Net.WebRequest" /> instance for the specified URI scheme.</summary>
		/// <returns>A <see cref="T:System.Net.WebRequest" /> descendant for the specified URI scheme.</returns>
		/// <param name="requestUri">A <see cref="T:System.Uri" /> containing the URI of the requested resource. </param>
		/// <exception cref="T:System.NotSupportedException">The request scheme specified in <paramref name="requestUri" /> is not registered. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="requestUri" /> is null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have permission to connect to the requested URI or a URI that the request is redirected to. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060026C6 RID: 9926 RVA: 0x0001B260 File Offset: 0x00019460
		public static WebRequest Create(global::System.Uri requestUri)
		{
			if (requestUri == null)
			{
				throw new ArgumentNullException("requestUri");
			}
			return WebRequest.GetCreator(requestUri.AbsoluteUri).Create(requestUri);
		}

		/// <summary>Initializes a new <see cref="T:System.Net.WebRequest" /> instance for the specified URI scheme.</summary>
		/// <returns>A <see cref="T:System.Net.WebRequest" /> descendant for the specified URI scheme.</returns>
		/// <param name="requestUri">A <see cref="T:System.Uri" /> containing the URI of the requested resource. </param>
		/// <exception cref="T:System.NotSupportedException">The request scheme specified in <paramref name="requestUri" /> is not registered. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="requestUri" /> is null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have permission to connect to the requested URI or a URI that the request is redirected to. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060026C7 RID: 9927 RVA: 0x0001B28A File Offset: 0x0001948A
		public static WebRequest CreateDefault(global::System.Uri requestUri)
		{
			if (requestUri == null)
			{
				throw new ArgumentNullException("requestUri");
			}
			return WebRequest.GetCreator(requestUri.Scheme).Create(requestUri);
		}

		/// <summary>When overridden in a descendant class, returns a <see cref="T:System.IO.Stream" /> for writing data to the Internet resource.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> to write data to.</returns>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that references a pending request for a stream. </param>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		// Token: 0x060026C8 RID: 9928 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			throw WebRequest.GetMustImplement();
		}

		/// <summary>When overridden in a descendant class, returns a <see cref="T:System.Net.WebResponse" />.</summary>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains a response to the Internet request.</returns>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that references a pending request for a response. </param>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		// Token: 0x060026C9 RID: 9929 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			throw WebRequest.GetMustImplement();
		}

		/// <summary>When overridden in a descendant class, returns a <see cref="T:System.IO.Stream" /> for writing data to the Internet resource.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> for writing data to the Internet resource.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060026CA RID: 9930 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual Stream GetRequestStream()
		{
			throw WebRequest.GetMustImplement();
		}

		/// <summary>When overridden in a descendant class, returns a response to an Internet request.</summary>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> containing the response to the Internet request.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method, when the method is not overridden in a descendant class. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060026CB RID: 9931 RVA: 0x0001B22D File Offset: 0x0001942D
		public virtual WebResponse GetResponse()
		{
			throw WebRequest.GetMustImplement();
		}

		/// <summary>Returns a proxy configured with the Internet Explorer settings of the currently impersonated user.</summary>
		/// <returns>An <see cref="T:System.Net.IWebProxy" /> used by every call to instances of <see cref="T:System.Net.WebRequest" />.</returns>
		// Token: 0x060026CC RID: 9932 RVA: 0x000733A0 File Offset: 0x000715A0
		[global::System.MonoTODO("Look in other places for proxy config info")]
		public static IWebProxy GetSystemWebProxy()
		{
			string text = Environment.GetEnvironmentVariable("http_proxy");
			if (text == null)
			{
				text = Environment.GetEnvironmentVariable("HTTP_PROXY");
			}
			if (text != null)
			{
				try
				{
					if (!text.StartsWith("http://"))
					{
						text = "http://" + text;
					}
					global::System.Uri uri = new global::System.Uri(text);
					IPAddress ipaddress;
					if (IPAddress.TryParse(uri.Host, out ipaddress))
					{
						if (IPAddress.Any.Equals(ipaddress))
						{
							uri = new global::System.UriBuilder(uri)
							{
								Host = "127.0.0.1"
							}.Uri;
						}
						else if (IPAddress.IPv6Any.Equals(ipaddress))
						{
							uri = new global::System.UriBuilder(uri)
							{
								Host = "[::1]"
							}.Uri;
						}
					}
					return new WebProxy(uri);
				}
				catch (global::System.UriFormatException)
				{
				}
			}
			return new WebProxy();
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
		// Token: 0x060026CD RID: 9933 RVA: 0x0001B22D File Offset: 0x0001942D
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw WebRequest.GetMustImplement();
		}

		/// <summary>Registers a <see cref="T:System.Net.WebRequest" /> descendant for the specified URI.</summary>
		/// <returns>true if registration is successful; otherwise, false.</returns>
		/// <param name="prefix">The complete URI or URI prefix that the <see cref="T:System.Net.WebRequest" /> descendant services. </param>
		/// <param name="creator">The create method that the <see cref="T:System.Net.WebRequest" /> calls to create the <see cref="T:System.Net.WebRequest" /> descendant. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="prefix" /> is null-or- <paramref name="creator" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x060026CE RID: 9934 RVA: 0x00073490 File Offset: 0x00071690
		public static bool RegisterPrefix(string prefix, IWebRequestCreate creator)
		{
			if (prefix == null)
			{
				throw new ArgumentNullException("prefix");
			}
			if (creator == null)
			{
				throw new ArgumentNullException("creator");
			}
			object syncRoot = WebRequest.prefixes.SyncRoot;
			lock (syncRoot)
			{
				string text = prefix.ToLower(CultureInfo.InvariantCulture);
				if (WebRequest.prefixes.Contains(text))
				{
					return false;
				}
				WebRequest.prefixes.Add(text, creator);
			}
			return true;
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x00073520 File Offset: 0x00071720
		private static IWebRequestCreate GetCreator(string prefix)
		{
			int num = -1;
			IWebRequestCreate webRequestCreate = null;
			prefix = prefix.ToLower(CultureInfo.InvariantCulture);
			IDictionaryEnumerator enumerator = WebRequest.prefixes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string text = enumerator.Key as string;
				if (text.Length > num)
				{
					if (prefix.StartsWith(text))
					{
						num = text.Length;
						webRequestCreate = (IWebRequestCreate)enumerator.Value;
					}
				}
			}
			if (webRequestCreate == null)
			{
				throw new NotSupportedException(prefix);
			}
			return webRequestCreate;
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x0001B2B4 File Offset: 0x000194B4
		internal static void ClearPrefixes()
		{
			WebRequest.prefixes.Clear();
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x0001B2C0 File Offset: 0x000194C0
		internal static void RemovePrefix(string prefix)
		{
			WebRequest.prefixes.Remove(prefix);
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x000735A8 File Offset: 0x000717A8
		internal static void AddPrefix(string prefix, string typeName)
		{
			Type type = Type.GetType(typeName);
			if (type == null)
			{
				throw new global::System.Configuration.ConfigurationException(string.Format("Type {0} not found", typeName));
			}
			WebRequest.AddPrefix(prefix, type);
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x000735DC File Offset: 0x000717DC
		internal static void AddPrefix(string prefix, Type type)
		{
			object obj = Activator.CreateInstance(type, true);
			WebRequest.prefixes[prefix] = obj;
		}

		// Token: 0x0400179E RID: 6046
		private static global::System.Collections.Specialized.HybridDictionary prefixes = new global::System.Collections.Specialized.HybridDictionary();

		// Token: 0x0400179F RID: 6047
		private static bool isDefaultWebProxySet;

		// Token: 0x040017A0 RID: 6048
		private static IWebProxy defaultWebProxy;

		// Token: 0x040017A1 RID: 6049
		private global::System.Net.Security.AuthenticationLevel authentication_level = global::System.Net.Security.AuthenticationLevel.MutualAuthRequested;

		// Token: 0x040017A2 RID: 6050
		private static readonly object lockobj = new object();
	}
}
