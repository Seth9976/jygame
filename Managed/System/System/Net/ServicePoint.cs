using System;
using System.Collections;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace System.Net
{
	/// <summary>Provides connection management for HTTP connections.</summary>
	// Token: 0x020003FE RID: 1022
	public class ServicePoint
	{
		// Token: 0x060022B3 RID: 8883 RVA: 0x00063C18 File Offset: 0x00061E18
		internal ServicePoint(global::System.Uri uri, int connectionLimit, int maxIdleTime)
		{
			this.uri = uri;
			this.connectionLimit = connectionLimit;
			this.maxIdleTime = maxIdleTime;
			this.currentConnections = 0;
			this.idleSince = DateTime.Now;
		}

		/// <summary>Gets the Uniform Resource Identifier (URI) of the server that this <see cref="T:System.Net.ServicePoint" /> object connects to.</summary>
		/// <returns>An instance of the <see cref="T:System.Uri" /> class that contains the URI of the Internet server that this <see cref="T:System.Net.ServicePoint" /> object connects to.</returns>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Net.ServicePoint" /> is in host mode.</exception>
		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x00018898 File Offset: 0x00016A98
		public global::System.Uri Address
		{
			get
			{
				return this.uri;
			}
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00005023 File Offset: 0x00003223
		private static Exception GetMustImplement()
		{
			return new NotImplementedException();
		}

		/// <summary>Specifies the delegate to associate a local <see cref="T:System.Net.IPEndPoint" /> with a <see cref="T:System.Net.ServicePoint" />.</summary>
		/// <returns>A delegate that forces a <see cref="T:System.Net.ServicePoint" /> to use a particular local Internet Protocol (IP) address and port number. The default value is null.</returns>
		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x000188A0 File Offset: 0x00016AA0
		// (set) Token: 0x060022B7 RID: 8887 RVA: 0x000188A8 File Offset: 0x00016AA8
		public BindIPEndPoint BindIPEndPointDelegate
		{
			get
			{
				return this.endPointCallback;
			}
			set
			{
				this.endPointCallback = value;
			}
		}

		/// <summary>Gets the certificate received for this <see cref="T:System.Net.ServicePoint" /> object.</summary>
		/// <returns>An instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class that contains the security certificate received for this <see cref="T:System.Net.ServicePoint" /> object.</returns>
		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x000188B1 File Offset: 0x00016AB1
		public X509Certificate Certificate
		{
			get
			{
				return this.certificate;
			}
		}

		/// <summary>Gets the last client certificate sent to the server.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object that contains the public values of the last client certificate sent to the server.</returns>
		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x000188B9 File Offset: 0x00016AB9
		public X509Certificate ClientCertificate
		{
			get
			{
				return this.clientCertificate;
			}
		}

		/// <summary>Gets or sets the number of milliseconds after which an active <see cref="T:System.Net.ServicePoint" /> connection is closed.</summary>
		/// <returns>A <see cref="T:System.Int32" /> that specifies the number of milliseconds that an active <see cref="T:System.Net.ServicePoint" /> connection remains open. The default is -1, which allows an active <see cref="T:System.Net.ServicePoint" /> connection to stay connected indefinitely. Set this property to 0 to force <see cref="T:System.Net.ServicePoint" /> connections to close after servicing a request.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is a negative number less than -1.</exception>
		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x000188C1 File Offset: 0x00016AC1
		// (set) Token: 0x060022BB RID: 8891 RVA: 0x000188C1 File Offset: 0x00016AC1
		[global::System.MonoTODO]
		public int ConnectionLeaseTimeout
		{
			get
			{
				throw ServicePoint.GetMustImplement();
			}
			set
			{
				throw ServicePoint.GetMustImplement();
			}
		}

		/// <summary>Gets or sets the maximum number of connections allowed on this <see cref="T:System.Net.ServicePoint" /> object.</summary>
		/// <returns>The maximum number of connections allowed on this <see cref="T:System.Net.ServicePoint" /> object.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The connection limit is equal to or less than 0. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Net.DnsPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x000188C8 File Offset: 0x00016AC8
		// (set) Token: 0x060022BD RID: 8893 RVA: 0x000188D0 File Offset: 0x00016AD0
		public int ConnectionLimit
		{
			get
			{
				return this.connectionLimit;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException();
				}
				this.connectionLimit = value;
			}
		}

		/// <summary>Gets the connection name. </summary>
		/// <returns>A <see cref="T:System.String" /> that represents the connection name. </returns>
		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x000188E6 File Offset: 0x00016AE6
		public string ConnectionName
		{
			get
			{
				return this.uri.Scheme;
			}
		}

		/// <summary>Gets the number of open connections associated with this <see cref="T:System.Net.ServicePoint" /> object.</summary>
		/// <returns>The number of open connections associated with this <see cref="T:System.Net.ServicePoint" /> object.</returns>
		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x000188F3 File Offset: 0x00016AF3
		public int CurrentConnections
		{
			get
			{
				return this.currentConnections;
			}
		}

		/// <summary>Gets the date and time that the <see cref="T:System.Net.ServicePoint" /> object was last connected to a host.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> object that contains the date and time at which the <see cref="T:System.Net.ServicePoint" /> object was last connected.</returns>
		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x000188FB File Offset: 0x00016AFB
		// (set) Token: 0x060022C1 RID: 8897 RVA: 0x00063C70 File Offset: 0x00061E70
		public DateTime IdleSince
		{
			get
			{
				return this.idleSince;
			}
			internal set
			{
				object obj = this.locker;
				lock (obj)
				{
					this.idleSince = value;
				}
			}
		}

		/// <summary>Gets or sets the amount of time a connection associated with the <see cref="T:System.Net.ServicePoint" /> object can remain idle before the connection is closed.</summary>
		/// <returns>The length of time, in milliseconds, that a connection associated with the <see cref="T:System.Net.ServicePoint" /> object can remain idle before it is closed and reused for another connection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <see cref="P:System.Net.ServicePoint.MaxIdleTime" /> is set to less than <see cref="F:System.Threading.Timeout.Infinite" /> or greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x00018903 File Offset: 0x00016B03
		// (set) Token: 0x060022C3 RID: 8899 RVA: 0x0001890B File Offset: 0x00016B0B
		public int MaxIdleTime
		{
			get
			{
				return this.maxIdleTime;
			}
			set
			{
				if (value < -1 || value > 2147483647)
				{
					throw new ArgumentOutOfRangeException();
				}
				this.maxIdleTime = value;
			}
		}

		/// <summary>Gets the version of the HTTP protocol that the <see cref="T:System.Net.ServicePoint" /> object uses.</summary>
		/// <returns>A <see cref="T:System.Version" /> object that contains the HTTP protocol version that the <see cref="T:System.Net.ServicePoint" /> object uses.</returns>
		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x0001892C File Offset: 0x00016B2C
		public virtual Version ProtocolVersion
		{
			get
			{
				return this.protocolVersion;
			}
		}

		/// <summary>Gets or sets the size of the receiving buffer for the socket used by this <see cref="T:System.Net.ServicePoint" />.</summary>
		/// <returns>A <see cref="T:System.Int32" /> that contains the size, in bytes, of the receive buffer. The default is 8192.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x000188C1 File Offset: 0x00016AC1
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x000188C1 File Offset: 0x00016AC1
		[global::System.MonoTODO]
		public int ReceiveBufferSize
		{
			get
			{
				throw ServicePoint.GetMustImplement();
			}
			set
			{
				throw ServicePoint.GetMustImplement();
			}
		}

		/// <summary>Indicates whether the <see cref="T:System.Net.ServicePoint" /> object supports pipelined connections.</summary>
		/// <returns>true if the <see cref="T:System.Net.ServicePoint" /> object supports pipelined connections; otherwise, false.</returns>
		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x00018934 File Offset: 0x00016B34
		public bool SupportsPipelining
		{
			get
			{
				return HttpVersion.Version11.Equals(this.protocolVersion);
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that determines whether 100-Continue behavior is used.</summary>
		/// <returns>true to expect 100-Continue responses for POST requests; otherwise, false. The default value is true.</returns>
		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x00018946 File Offset: 0x00016B46
		// (set) Token: 0x060022C9 RID: 8905 RVA: 0x0001894E File Offset: 0x00016B4E
		public bool Expect100Continue
		{
			get
			{
				return this.SendContinue;
			}
			set
			{
				this.SendContinue = value;
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that determines whether the Nagle algorithm is used on connections managed by this <see cref="T:System.Net.ServicePoint" /> object.</summary>
		/// <returns>true to use the Nagle algorithm; otherwise, false. The default value is true.</returns>
		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060022CA RID: 8906 RVA: 0x00018957 File Offset: 0x00016B57
		// (set) Token: 0x060022CB RID: 8907 RVA: 0x0001895F File Offset: 0x00016B5F
		public bool UseNagleAlgorithm
		{
			get
			{
				return this.useNagle;
			}
			set
			{
				this.useNagle = value;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x00018968 File Offset: 0x00016B68
		// (set) Token: 0x060022CD RID: 8909 RVA: 0x0001899C File Offset: 0x00016B9C
		internal bool SendContinue
		{
			get
			{
				return this.sendContinue && (this.protocolVersion == null || this.protocolVersion == HttpVersion.Version11);
			}
			set
			{
				this.sendContinue = value;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x000189A5 File Offset: 0x00016BA5
		// (set) Token: 0x060022CF RID: 8911 RVA: 0x000189AD File Offset: 0x00016BAD
		internal bool UsesProxy
		{
			get
			{
				return this.usesProxy;
			}
			set
			{
				this.usesProxy = value;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x000189B6 File Offset: 0x00016BB6
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x000189BE File Offset: 0x00016BBE
		internal bool UseConnect
		{
			get
			{
				return this.useConnect;
			}
			set
			{
				this.useConnect = value;
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x00063CB0 File Offset: 0x00061EB0
		internal bool AvailableForRecycling
		{
			get
			{
				return this.CurrentConnections == 0 && this.maxIdleTime != -1 && DateTime.Now >= this.IdleSince.AddMilliseconds((double)this.maxIdleTime);
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x000189C7 File Offset: 0x00016BC7
		internal Hashtable Groups
		{
			get
			{
				if (this.groups == null)
				{
					this.groups = new Hashtable();
				}
				return this.groups;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x00063CF8 File Offset: 0x00061EF8
		internal IPHostEntry HostEntry
		{
			get
			{
				object obj = this.hostE;
				lock (obj)
				{
					if (this.host != null)
					{
						return this.host;
					}
					string text = this.uri.Host;
					if (this.uri.HostNameType == global::System.UriHostNameType.IPv6 || this.uri.HostNameType == global::System.UriHostNameType.IPv4)
					{
						if (this.uri.HostNameType == global::System.UriHostNameType.IPv6)
						{
							text = text.Substring(1, text.Length - 2);
						}
						this.host = new IPHostEntry();
						this.host.AddressList = new IPAddress[] { IPAddress.Parse(text) };
						return this.host;
					}
					try
					{
						this.host = Dns.GetHostByName(text);
					}
					catch
					{
						return null;
					}
				}
				return this.host;
			}
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x000189E5 File Offset: 0x00016BE5
		internal void SetVersion(Version version)
		{
			this.protocolVersion = version;
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x00063DF8 File Offset: 0x00061FF8
		private WebConnectionGroup GetConnectionGroup(string name)
		{
			if (name == null)
			{
				name = string.Empty;
			}
			WebConnectionGroup webConnectionGroup = this.Groups[name] as WebConnectionGroup;
			if (webConnectionGroup != null)
			{
				return webConnectionGroup;
			}
			webConnectionGroup = new WebConnectionGroup(this, name);
			this.Groups[name] = webConnectionGroup;
			return webConnectionGroup;
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x00063E44 File Offset: 0x00062044
		internal EventHandler SendRequest(HttpWebRequest request, string groupName)
		{
			object obj = this.locker;
			WebConnection connection;
			lock (obj)
			{
				WebConnectionGroup connectionGroup = this.GetConnectionGroup(groupName);
				connection = connectionGroup.GetConnection(request);
			}
			return connection.SendRequest(request);
		}

		/// <summary>Removes the specified connection group from this <see cref="T:System.Net.ServicePoint" /> object.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that indicates whether the connection group was closed.</returns>
		/// <param name="connectionGroupName">The name of the connection group that contains the connections to close and remove from this service point. </param>
		// Token: 0x060022D8 RID: 8920 RVA: 0x00063E94 File Offset: 0x00062094
		public bool CloseConnectionGroup(string connectionGroupName)
		{
			object obj = this.locker;
			lock (obj)
			{
				WebConnectionGroup connectionGroup = this.GetConnectionGroup(connectionGroupName);
				if (connectionGroup != null)
				{
					connectionGroup.Close();
					return true;
				}
			}
			return false;
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00063EE8 File Offset: 0x000620E8
		internal void IncrementConnection()
		{
			object obj = this.locker;
			lock (obj)
			{
				this.currentConnections++;
				this.idleSince = DateTime.Now.AddMilliseconds(1000000.0);
			}
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x00063F48 File Offset: 0x00062148
		internal void DecrementConnection()
		{
			object obj = this.locker;
			lock (obj)
			{
				this.currentConnections--;
				if (this.currentConnections == 0)
				{
					this.idleSince = DateTime.Now;
				}
			}
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x000189EE File Offset: 0x00016BEE
		internal void SetCertificates(X509Certificate client, X509Certificate server)
		{
			this.certificate = server;
			this.clientCertificate = client;
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x00063FA4 File Offset: 0x000621A4
		internal bool CallEndPointDelegate(global::System.Net.Sockets.Socket sock, IPEndPoint remote)
		{
			if (this.endPointCallback == null)
			{
				return true;
			}
			int num = 0;
			checked
			{
				for (;;)
				{
					IPEndPoint ipendPoint = null;
					try
					{
						ipendPoint = this.endPointCallback(this, remote, num);
					}
					catch
					{
						return false;
					}
					if (ipendPoint == null)
					{
						break;
					}
					try
					{
						sock.Bind(ipendPoint);
					}
					catch (global::System.Net.Sockets.SocketException)
					{
						num++;
						continue;
					}
					return true;
				}
				return true;
			}
		}

		// Token: 0x0400152D RID: 5421
		private global::System.Uri uri;

		// Token: 0x0400152E RID: 5422
		private int connectionLimit;

		// Token: 0x0400152F RID: 5423
		private int maxIdleTime;

		// Token: 0x04001530 RID: 5424
		private int currentConnections;

		// Token: 0x04001531 RID: 5425
		private DateTime idleSince;

		// Token: 0x04001532 RID: 5426
		private Version protocolVersion;

		// Token: 0x04001533 RID: 5427
		private X509Certificate certificate;

		// Token: 0x04001534 RID: 5428
		private X509Certificate clientCertificate;

		// Token: 0x04001535 RID: 5429
		private IPHostEntry host;

		// Token: 0x04001536 RID: 5430
		private bool usesProxy;

		// Token: 0x04001537 RID: 5431
		private Hashtable groups;

		// Token: 0x04001538 RID: 5432
		private bool sendContinue = true;

		// Token: 0x04001539 RID: 5433
		private bool useConnect;

		// Token: 0x0400153A RID: 5434
		private object locker = new object();

		// Token: 0x0400153B RID: 5435
		private object hostE = new object();

		// Token: 0x0400153C RID: 5436
		private bool useNagle;

		// Token: 0x0400153D RID: 5437
		private BindIPEndPoint endPointCallback;
	}
}
