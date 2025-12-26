using System;
using System.Collections;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace System.Net
{
	/// <summary>Contains HTTP proxy settings for the <see cref="T:System.Net.WebRequest" /> class.</summary>
	// Token: 0x0200043A RID: 1082
	[Serializable]
	public class WebProxy : ISerializable, IWebProxy
	{
		/// <summary>Initializes an empty instance of the <see cref="T:System.Net.WebProxy" /> class.</summary>
		// Token: 0x0600267F RID: 9855 RVA: 0x0001B035 File Offset: 0x00019235
		public WebProxy()
			: this(null, false, null, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebProxy" /> class with the specified URI.</summary>
		/// <param name="Address">The URI of the proxy server. </param>
		/// <exception cref="T:System.UriFormatException">
		///   <paramref name="Address" /> is an invalid URI. </exception>
		// Token: 0x06002680 RID: 9856 RVA: 0x0001B041 File Offset: 0x00019241
		public WebProxy(string address)
			: this(WebProxy.ToUri(address), false, null, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebProxy" /> class from the specified <see cref="T:System.Uri" /> instance.</summary>
		/// <param name="Address">A <see cref="T:System.Uri" /> instance that contains the address of the proxy server. </param>
		// Token: 0x06002681 RID: 9857 RVA: 0x0001B052 File Offset: 0x00019252
		public WebProxy(global::System.Uri address)
			: this(address, false, null, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebProxy" /> class with the specified URI and bypass setting.</summary>
		/// <param name="Address">The URI of the proxy server. </param>
		/// <param name="BypassOnLocal">true to bypass the proxy for local addresses; otherwise, false. </param>
		/// <exception cref="T:System.UriFormatException">
		///   <paramref name="Address" /> is an invalid URI. </exception>
		// Token: 0x06002682 RID: 9858 RVA: 0x0001B05E File Offset: 0x0001925E
		public WebProxy(string address, bool bypassOnLocal)
			: this(WebProxy.ToUri(address), bypassOnLocal, null, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebProxy" /> class with the specified host and port number.</summary>
		/// <param name="Host">The name of the proxy host. </param>
		/// <param name="Port">The port number on <paramref name="Host" /> to use. </param>
		/// <exception cref="T:System.UriFormatException">The URI formed by combining <paramref name="Host" /> and <paramref name="Port" /> is not a valid URI. </exception>
		// Token: 0x06002683 RID: 9859 RVA: 0x0001B06F File Offset: 0x0001926F
		public WebProxy(string host, int port)
			: this(new global::System.Uri(string.Concat(new object[] { "http://", host, ":", port })))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebProxy" /> class with the <see cref="T:System.Uri" /> instance and bypass setting.</summary>
		/// <param name="Address">A <see cref="T:System.Uri" /> instance that contains the address of the proxy server. </param>
		/// <param name="BypassOnLocal">true to bypass the proxy for local addresses; otherwise, false. </param>
		// Token: 0x06002684 RID: 9860 RVA: 0x0001B0A4 File Offset: 0x000192A4
		public WebProxy(global::System.Uri address, bool bypassOnLocal)
			: this(address, bypassOnLocal, null, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebProxy" /> class with the specified URI, bypass setting, and list of URIs to bypass.</summary>
		/// <param name="Address">The URI of the proxy server. </param>
		/// <param name="BypassOnLocal">true to bypass the proxy for local addresses; otherwise, false. </param>
		/// <param name="BypassList">An array of regular expression strings that contain the URIs of the servers to bypass. </param>
		/// <exception cref="T:System.UriFormatException">
		///   <paramref name="Address" /> is an invalid URI. </exception>
		// Token: 0x06002685 RID: 9861 RVA: 0x0001B0B0 File Offset: 0x000192B0
		public WebProxy(string address, bool bypassOnLocal, string[] bypassList)
			: this(WebProxy.ToUri(address), bypassOnLocal, bypassList, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebProxy" /> class with the specified <see cref="T:System.Uri" /> instance, bypass setting, and list of URIs to bypass.</summary>
		/// <param name="Address">A <see cref="T:System.Uri" /> instance that contains the address of the proxy server. </param>
		/// <param name="BypassOnLocal">true to bypass the proxy for local addresses; otherwise, false. </param>
		/// <param name="BypassList">An array of regular expression strings that contains the URIs of the servers to bypass. </param>
		// Token: 0x06002686 RID: 9862 RVA: 0x0001B0C1 File Offset: 0x000192C1
		public WebProxy(global::System.Uri address, bool bypassOnLocal, string[] bypassList)
			: this(address, bypassOnLocal, bypassList, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebProxy" /> class with the specified URI, bypass setting, list of URIs to bypass, and credentials.</summary>
		/// <param name="Address">The URI of the proxy server. </param>
		/// <param name="BypassOnLocal">true to bypass the proxy for local addresses; otherwise, false. </param>
		/// <param name="BypassList">An array of regular expression strings that contains the URIs of the servers to bypass. </param>
		/// <param name="Credentials">An <see cref="T:System.Net.ICredentials" /> instance to submit to the proxy server for authentication. </param>
		/// <exception cref="T:System.UriFormatException">
		///   <paramref name="Address" /> is an invalid URI. </exception>
		// Token: 0x06002687 RID: 9863 RVA: 0x0001B0CD File Offset: 0x000192CD
		public WebProxy(string address, bool bypassOnLocal, string[] bypassList, ICredentials credentials)
			: this(WebProxy.ToUri(address), bypassOnLocal, bypassList, credentials)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebProxy" /> class with the specified <see cref="T:System.Uri" /> instance, bypass setting, list of URIs to bypass, and credentials.</summary>
		/// <param name="Address">A <see cref="T:System.Uri" /> instance that contains the address of the proxy server. </param>
		/// <param name="BypassOnLocal">true to bypass the proxy for local addresses; otherwise, false. </param>
		/// <param name="BypassList">An array of regular expression strings that contains the URIs of the servers to bypass. </param>
		/// <param name="Credentials">An <see cref="T:System.Net.ICredentials" /> instance to submit to the proxy server for authentication. </param>
		// Token: 0x06002688 RID: 9864 RVA: 0x0001B0DF File Offset: 0x000192DF
		public WebProxy(global::System.Uri address, bool bypassOnLocal, string[] bypassList, ICredentials credentials)
		{
			this.address = address;
			this.bypassOnLocal = bypassOnLocal;
			if (bypassList != null)
			{
				this.bypassList = new ArrayList(bypassList);
			}
			this.credentials = credentials;
			this.CheckBypassList();
		}

		/// <summary>Initializes an instance of the <see cref="T:System.Net.WebProxy" /> class using previously serialized content.</summary>
		/// <param name="serializationInfo">The serialization data. </param>
		/// <param name="streamingContext">The context for the serialized data. </param>
		// Token: 0x06002689 RID: 9865 RVA: 0x00072EB8 File Offset: 0x000710B8
		protected WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.address = (global::System.Uri)serializationInfo.GetValue("_ProxyAddress", typeof(global::System.Uri));
			this.bypassOnLocal = serializationInfo.GetBoolean("_BypassOnLocal");
			this.bypassList = (ArrayList)serializationInfo.GetValue("_BypassList", typeof(ArrayList));
			this.useDefaultCredentials = serializationInfo.GetBoolean("_UseDefaultCredentials");
			this.credentials = null;
			this.CheckBypassList();
		}

		/// <summary>Creates the serialization data and context that are used by the system to serialize a <see cref="T:System.Net.WebProxy" /> object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure that indicates the destination for this serialization. </param>
		// Token: 0x0600268A RID: 9866 RVA: 0x0001B115 File Offset: 0x00019315
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Gets or sets the address of the proxy server.</summary>
		/// <returns>A <see cref="T:System.Uri" /> instance that contains the address of the proxy server.</returns>
		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x0600268B RID: 9867 RVA: 0x0001B11F File Offset: 0x0001931F
		// (set) Token: 0x0600268C RID: 9868 RVA: 0x0001B127 File Offset: 0x00019327
		public global::System.Uri Address
		{
			get
			{
				return this.address;
			}
			set
			{
				this.address = value;
			}
		}

		/// <summary>Gets a list of addresses that do not use the proxy server.</summary>
		/// <returns>An <see cref="T:System.Collections.ArrayList" /> that contains a list of <see cref="P:System.Net.WebProxy.BypassList" /> arrays that represents URIs that do not use the proxy server when accessed.</returns>
		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x0600268D RID: 9869 RVA: 0x0001B130 File Offset: 0x00019330
		public ArrayList BypassArrayList
		{
			get
			{
				if (this.bypassList == null)
				{
					this.bypassList = new ArrayList();
				}
				return this.bypassList;
			}
		}

		/// <summary>Gets or sets an array of addresses that do not use the proxy server.</summary>
		/// <returns>An array that contains a list of regular expressions that describe URIs that do not use the proxy server when accessed.</returns>
		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x0600268E RID: 9870 RVA: 0x0001B14E File Offset: 0x0001934E
		// (set) Token: 0x0600268F RID: 9871 RVA: 0x0001B16A File Offset: 0x0001936A
		public string[] BypassList
		{
			get
			{
				return (string[])this.BypassArrayList.ToArray(typeof(string));
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException();
				}
				this.bypassList = new ArrayList(value);
				this.CheckBypassList();
			}
		}

		/// <summary>Gets or sets a value that indicates whether to bypass the proxy server for local addresses.</summary>
		/// <returns>true to bypass the proxy server for local addresses; otherwise, false. The default value is false.</returns>
		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06002690 RID: 9872 RVA: 0x0001B18A File Offset: 0x0001938A
		// (set) Token: 0x06002691 RID: 9873 RVA: 0x0001B192 File Offset: 0x00019392
		public bool BypassProxyOnLocal
		{
			get
			{
				return this.bypassOnLocal;
			}
			set
			{
				this.bypassOnLocal = value;
			}
		}

		/// <summary>Gets or sets the credentials to submit to the proxy server for authentication.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> instance that contains the credentials to submit to the proxy server for authentication.</returns>
		/// <exception cref="T:System.InvalidOperationException">You attempted to set this property when the <see cref="P:System.Net.WebProxy.UseDefaultCredentials" />  property was set to true. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06002692 RID: 9874 RVA: 0x0001B19B File Offset: 0x0001939B
		// (set) Token: 0x06002693 RID: 9875 RVA: 0x0001B1A3 File Offset: 0x000193A3
		public ICredentials Credentials
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

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that controls whether the <see cref="P:System.Net.CredentialCache.DefaultCredentials" /> are sent with requests.</summary>
		/// <returns>true if the default credentials are used; otherwise, false. The default value is false.</returns>
		/// <exception cref="T:System.InvalidOperationException">You attempted to set this property when the <see cref="P:System.Net.WebProxy.Credentials" /> property contains credentials other than the default credentials. For more information, see the Remarks section.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="USERNAME" />
		/// </PermissionSet>
		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x0001B1AC File Offset: 0x000193AC
		// (set) Token: 0x06002695 RID: 9877 RVA: 0x0001B1B4 File Offset: 0x000193B4
		[global::System.MonoTODO("Does not affect Credentials, since CredentialCache.DefaultCredentials is not implemented.")]
		public bool UseDefaultCredentials
		{
			get
			{
				return this.useDefaultCredentials;
			}
			set
			{
				this.useDefaultCredentials = value;
			}
		}

		/// <summary>Reads the Internet Explorer nondynamic proxy settings.</summary>
		/// <returns>A <see cref="T:System.Net.WebProxy" /> instance that contains the nondynamic proxy settings from Internet Explorer 5.5 and later.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06002696 RID: 9878 RVA: 0x00072F3C File Offset: 0x0007113C
		[Obsolete("This method has been deprecated", false)]
		[global::System.MonoTODO("Can we get this info under windows from the system?")]
		public static WebProxy GetDefaultProxy()
		{
			IWebProxy select = GlobalProxySelection.Select;
			if (select is WebProxy)
			{
				return (WebProxy)select;
			}
			return new WebProxy();
		}

		/// <summary>Returns the proxied URI for a request.</summary>
		/// <returns>The <see cref="T:System.Uri" /> instance of the Internet resource, if the resource is on the bypass list; otherwise, the <see cref="T:System.Uri" /> instance of the proxy.</returns>
		/// <param name="destination">The <see cref="T:System.Uri" /> instance of the requested Internet resource. </param>
		// Token: 0x06002697 RID: 9879 RVA: 0x0001B1BD File Offset: 0x000193BD
		public global::System.Uri GetProxy(global::System.Uri destination)
		{
			if (this.IsBypassed(destination))
			{
				return destination;
			}
			return this.address;
		}

		/// <summary>Indicates whether to use the proxy server for the specified host.</summary>
		/// <returns>true if the proxy server should not be used for <paramref name="host" />; otherwise, false.</returns>
		/// <param name="host">The <see cref="T:System.Uri" /> instance of the host to check for proxy use. </param>
		// Token: 0x06002698 RID: 9880 RVA: 0x00072F68 File Offset: 0x00071168
		public bool IsBypassed(global::System.Uri host)
		{
			if (host == null)
			{
				throw new ArgumentNullException("host");
			}
			if (host.IsLoopback && this.bypassOnLocal)
			{
				return true;
			}
			if (this.address == null)
			{
				return true;
			}
			string host2 = host.Host;
			if (this.bypassOnLocal && host2.IndexOf('.') == -1)
			{
				return true;
			}
			if (!this.bypassOnLocal)
			{
				if (string.Compare(host2, "localhost", true, CultureInfo.InvariantCulture) == 0)
				{
					return true;
				}
				if (string.Compare(host2, "loopback", true, CultureInfo.InvariantCulture) == 0)
				{
					return true;
				}
				IPAddress ipaddress = null;
				if (IPAddress.TryParse(host2, out ipaddress) && IPAddress.IsLoopback(ipaddress))
				{
					return true;
				}
			}
			if (this.bypassList == null || this.bypassList.Count == 0)
			{
				return false;
			}
			bool flag;
			try
			{
				string text = host.Scheme + "://" + host.Authority;
				int i;
				for (i = 0; i < this.bypassList.Count; i++)
				{
					global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex((string)this.bypassList[i], global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Singleline);
					if (regex.IsMatch(text))
					{
						break;
					}
				}
				if (i == this.bypassList.Count)
				{
					flag = false;
				}
				else
				{
					while (i < this.bypassList.Count)
					{
						new global::System.Text.RegularExpressions.Regex((string)this.bypassList[i]);
						i++;
					}
					flag = true;
				}
			}
			catch (ArgumentException)
			{
				flag = false;
			}
			return flag;
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data that is needed to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
		// Token: 0x06002699 RID: 9881 RVA: 0x00073124 File Offset: 0x00071324
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			serializationInfo.AddValue("_BypassOnLocal", this.bypassOnLocal);
			serializationInfo.AddValue("_ProxyAddress", this.address);
			serializationInfo.AddValue("_BypassList", this.bypassList);
			serializationInfo.AddValue("_UseDefaultCredentials", this.UseDefaultCredentials);
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x00073178 File Offset: 0x00071378
		private void CheckBypassList()
		{
			if (this.bypassList == null)
			{
				return;
			}
			for (int i = 0; i < this.bypassList.Count; i++)
			{
				new global::System.Text.RegularExpressions.Regex((string)this.bypassList[i]);
			}
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x0001B1D3 File Offset: 0x000193D3
		private static global::System.Uri ToUri(string address)
		{
			if (address == null)
			{
				return null;
			}
			if (address.IndexOf("://") == -1)
			{
				address = "http://" + address;
			}
			return new global::System.Uri(address);
		}

		// Token: 0x04001799 RID: 6041
		private global::System.Uri address;

		// Token: 0x0400179A RID: 6042
		private bool bypassOnLocal;

		// Token: 0x0400179B RID: 6043
		private ArrayList bypassList;

		// Token: 0x0400179C RID: 6044
		private ICredentials credentials;

		// Token: 0x0400179D RID: 6045
		private bool useDefaultCredentials;
	}
}
