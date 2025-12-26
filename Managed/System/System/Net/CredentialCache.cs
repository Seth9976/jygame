using System;
using System.Collections;

namespace System.Net
{
	/// <summary>Provides storage for multiple credentials.</summary>
	// Token: 0x02000301 RID: 769
	public class CredentialCache : IEnumerable, ICredentials, ICredentialsByHost
	{
		/// <summary>Creates a new instance of the <see cref="T:System.Net.CredentialCache" /> class.</summary>
		// Token: 0x06001A2A RID: 6698 RVA: 0x00013574 File Offset: 0x00011774
		public CredentialCache()
		{
			this.cache = new Hashtable();
			this.cacheForHost = new Hashtable();
		}

		/// <summary>Gets the system credentials of the application.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> that represents the system credentials of the application.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="USERNAME" />
		/// </PermissionSet>
		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x000135AD File Offset: 0x000117AD
		[global::System.MonoTODO("Need EnvironmentPermission implementation first")]
		public static ICredentials DefaultCredentials
		{
			get
			{
				return CredentialCache.empty;
			}
		}

		/// <summary>Gets the network credentials of the current security context.</summary>
		/// <returns>An <see cref="T:System.Net.NetworkCredential" /> that represents the network credentials of the current user or application.</returns>
		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x000135AD File Offset: 0x000117AD
		public static NetworkCredential DefaultNetworkCredentials
		{
			get
			{
				return CredentialCache.empty;
			}
		}

		/// <summary>Returns the <see cref="T:System.Net.NetworkCredential" /> instance associated with the specified Uniform Resource Identifier (URI) and authentication type.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkCredential" /> or, if there is no matching credential in the cache, null.</returns>
		/// <param name="uriPrefix">A <see cref="T:System.Uri" /> that specifies the URI prefix of the resources that the credential grants access to. </param>
		/// <param name="authType">The authentication scheme used by the resource named in <paramref name="uriPrefix" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="uriPrefix" /> or <paramref name="authType" /> is null. </exception>
		// Token: 0x06001A2E RID: 6702 RVA: 0x0004E358 File Offset: 0x0004C558
		public NetworkCredential GetCredential(global::System.Uri uriPrefix, string authType)
		{
			int num = -1;
			NetworkCredential networkCredential = null;
			if (uriPrefix == null || authType == null)
			{
				return null;
			}
			string text = uriPrefix.AbsolutePath;
			text = text.Substring(0, text.LastIndexOf('/'));
			IDictionaryEnumerator enumerator = this.cache.GetEnumerator();
			while (enumerator.MoveNext())
			{
				CredentialCache.CredentialCacheKey credentialCacheKey = enumerator.Key as CredentialCache.CredentialCacheKey;
				if (credentialCacheKey.Length > num)
				{
					if (string.Compare(credentialCacheKey.AuthType, authType, true) == 0)
					{
						global::System.Uri uriPrefix2 = credentialCacheKey.UriPrefix;
						if (!(uriPrefix2.Scheme != uriPrefix.Scheme))
						{
							if (uriPrefix2.Port == uriPrefix.Port)
							{
								if (!(uriPrefix2.Host != uriPrefix.Host))
								{
									if (text.StartsWith(credentialCacheKey.AbsPath))
									{
										num = credentialCacheKey.Length;
										networkCredential = (NetworkCredential)enumerator.Value;
									}
								}
							}
						}
					}
				}
			}
			return networkCredential;
		}

		/// <summary>Returns an enumerator that can iterate through the <see cref="T:System.Net.CredentialCache" /> instance.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Net.CredentialCache" />.</returns>
		// Token: 0x06001A2F RID: 6703 RVA: 0x000135B4 File Offset: 0x000117B4
		public IEnumerator GetEnumerator()
		{
			return this.cache.Values.GetEnumerator();
		}

		/// <summary>Adds a <see cref="T:System.Net.NetworkCredential" /> instance to the credential cache for use with protocols other than SMTP and associates it with a Uniform Resource Identifier (URI) prefix and authentication protocol. </summary>
		/// <param name="uriPrefix">A <see cref="T:System.Uri" /> that specifies the URI prefix of the resources that the credential grants access to. </param>
		/// <param name="authType">The authentication scheme used by the resource named in <paramref name="uriPrefix" />. </param>
		/// <param name="cred">The <see cref="T:System.Net.NetworkCredential" /> to add to the credential cache. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="uriPrefix" /> is null. -or- <paramref name="authType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">The same credentials are added more than once. </exception>
		// Token: 0x06001A30 RID: 6704 RVA: 0x000135C6 File Offset: 0x000117C6
		public void Add(global::System.Uri uriPrefix, string authType, NetworkCredential cred)
		{
			if (uriPrefix == null)
			{
				throw new ArgumentNullException("uriPrefix");
			}
			if (authType == null)
			{
				throw new ArgumentNullException("authType");
			}
			this.cache.Add(new CredentialCache.CredentialCacheKey(uriPrefix, authType), cred);
		}

		/// <summary>Deletes a <see cref="T:System.Net.NetworkCredential" /> instance from the cache if it is associated with the specified Uniform Resource Identifier (URI) prefix and authentication protocol.</summary>
		/// <param name="uriPrefix">A <see cref="T:System.Uri" /> that specifies the URI prefix of the resources that the credential is used for. </param>
		/// <param name="authType">The authentication scheme used by the host named in <paramref name="uriPrefix" />. </param>
		// Token: 0x06001A31 RID: 6705 RVA: 0x00013603 File Offset: 0x00011803
		public void Remove(global::System.Uri uriPrefix, string authType)
		{
			if (uriPrefix == null)
			{
				throw new ArgumentNullException("uriPrefix");
			}
			if (authType == null)
			{
				throw new ArgumentNullException("authType");
			}
			this.cache.Remove(new CredentialCache.CredentialCacheKey(uriPrefix, authType));
		}

		/// <summary>Returns the <see cref="T:System.Net.NetworkCredential" /> instance associated with the specified host, port, and authentication protocol.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkCredential" /> or, if there is no matching credential in the cache, null.</returns>
		/// <param name="host">A <see cref="T:System.String" /> that identifies the host computer.</param>
		/// <param name="port">A <see cref="T:System.Int32" /> that specifies the port to connect to on <paramref name="host" />.</param>
		/// <param name="authenticationType">A <see cref="T:System.String" /> that identifies the authentication scheme used when connecting to <paramref name="host" />. See Remarks.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="host" /> is null. -or- <paramref name="authType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="authType" /> not an accepted value. See Remarks. -or-<paramref name="host" /> is equal to the empty string ("").</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="port" /> is less than zero.</exception>
		// Token: 0x06001A32 RID: 6706 RVA: 0x0004E46C File Offset: 0x0004C66C
		public NetworkCredential GetCredential(string host, int port, string authenticationType)
		{
			NetworkCredential networkCredential = null;
			if (host == null || port < 0 || authenticationType == null)
			{
				return null;
			}
			IDictionaryEnumerator enumerator = this.cacheForHost.GetEnumerator();
			while (enumerator.MoveNext())
			{
				CredentialCache.CredentialCacheForHostKey credentialCacheForHostKey = enumerator.Key as CredentialCache.CredentialCacheForHostKey;
				if (string.Compare(credentialCacheForHostKey.AuthType, authenticationType, true) == 0)
				{
					if (!(credentialCacheForHostKey.Host != host))
					{
						if (credentialCacheForHostKey.Port == port)
						{
							networkCredential = (NetworkCredential)enumerator.Value;
						}
					}
				}
			}
			return networkCredential;
		}

		/// <summary>Adds a <see cref="T:System.Net.NetworkCredential" /> instance for use with SMTP to the credential cache and associates it with a host computer, port, and authentication protocol. Credentials added using this method are valid for SMTP only. This method does not work for HTTP or FTP requests.</summary>
		/// <param name="host">A <see cref="T:System.String" /> that identifies the host computer.</param>
		/// <param name="port">A <see cref="T:System.Int32" /> that specifies the port to connect to on <paramref name="host" />.</param>
		/// <param name="authenticationType">A <see cref="T:System.String" /> that identifies the authentication scheme used when connecting to <paramref name="host" /> using <paramref name="cred" />. See Remarks.</param>
		/// <param name="credential">The <see cref="T:System.Net.NetworkCredential" /> to add to the credential cache. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="host" /> is null. -or-<paramref name="authType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="authType" /> not an accepted value. See Remarks. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="port" /> is less than zero.</exception>
		// Token: 0x06001A33 RID: 6707 RVA: 0x0004E504 File Offset: 0x0004C704
		public void Add(string host, int port, string authenticationType, NetworkCredential credential)
		{
			if (host == null)
			{
				throw new ArgumentNullException("host");
			}
			if (port < 0)
			{
				throw new ArgumentOutOfRangeException("port");
			}
			if (authenticationType == null)
			{
				throw new ArgumentOutOfRangeException("authenticationType");
			}
			this.cacheForHost.Add(new CredentialCache.CredentialCacheForHostKey(host, port, authenticationType), credential);
		}

		/// <summary>Deletes a <see cref="T:System.Net.NetworkCredential" /> instance from the cache if it is associated with the specified host, port, and authentication protocol.</summary>
		/// <param name="host">A <see cref="T:System.String" /> that identifies the host computer.</param>
		/// <param name="port">A <see cref="T:System.Int32" /> that specifies the port to connect to on <paramref name="host" />.</param>
		/// <param name="authenticationType">A <see cref="T:System.String" /> that identifies the authentication scheme used when connecting to <paramref name="host" />. See Remarks.</param>
		// Token: 0x06001A34 RID: 6708 RVA: 0x0001363F File Offset: 0x0001183F
		public void Remove(string host, int port, string authenticationType)
		{
			if (host == null)
			{
				return;
			}
			if (authenticationType == null)
			{
				return;
			}
			this.cacheForHost.Remove(new CredentialCache.CredentialCacheForHostKey(host, port, authenticationType));
		}

		// Token: 0x04001042 RID: 4162
		private static NetworkCredential empty = new NetworkCredential(string.Empty, string.Empty, string.Empty);

		// Token: 0x04001043 RID: 4163
		private Hashtable cache;

		// Token: 0x04001044 RID: 4164
		private Hashtable cacheForHost;

		// Token: 0x02000302 RID: 770
		private class CredentialCacheKey
		{
			// Token: 0x06001A35 RID: 6709 RVA: 0x0004E55C File Offset: 0x0004C75C
			internal CredentialCacheKey(global::System.Uri uriPrefix, string authType)
			{
				this.uriPrefix = uriPrefix;
				this.authType = authType;
				this.absPath = uriPrefix.AbsolutePath;
				this.absPath = this.absPath.Substring(0, this.absPath.LastIndexOf('/'));
				this.len = uriPrefix.AbsoluteUri.Length;
				this.hash = uriPrefix.GetHashCode() + authType.GetHashCode();
			}

			// Token: 0x1700064C RID: 1612
			// (get) Token: 0x06001A36 RID: 6710 RVA: 0x00013662 File Offset: 0x00011862
			public int Length
			{
				get
				{
					return this.len;
				}
			}

			// Token: 0x1700064D RID: 1613
			// (get) Token: 0x06001A37 RID: 6711 RVA: 0x0001366A File Offset: 0x0001186A
			public string AbsPath
			{
				get
				{
					return this.absPath;
				}
			}

			// Token: 0x1700064E RID: 1614
			// (get) Token: 0x06001A38 RID: 6712 RVA: 0x00013672 File Offset: 0x00011872
			public global::System.Uri UriPrefix
			{
				get
				{
					return this.uriPrefix;
				}
			}

			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x06001A39 RID: 6713 RVA: 0x0001367A File Offset: 0x0001187A
			public string AuthType
			{
				get
				{
					return this.authType;
				}
			}

			// Token: 0x06001A3A RID: 6714 RVA: 0x00013682 File Offset: 0x00011882
			public override int GetHashCode()
			{
				return this.hash;
			}

			// Token: 0x06001A3B RID: 6715 RVA: 0x0004E5CC File Offset: 0x0004C7CC
			public override bool Equals(object obj)
			{
				CredentialCache.CredentialCacheKey credentialCacheKey = obj as CredentialCache.CredentialCacheKey;
				return credentialCacheKey != null && this.hash == credentialCacheKey.hash;
			}

			// Token: 0x06001A3C RID: 6716 RVA: 0x0001368A File Offset: 0x0001188A
			public override string ToString()
			{
				return string.Concat(new object[] { this.absPath, " : ", this.authType, " : len=", this.len });
			}

			// Token: 0x04001045 RID: 4165
			private global::System.Uri uriPrefix;

			// Token: 0x04001046 RID: 4166
			private string authType;

			// Token: 0x04001047 RID: 4167
			private string absPath;

			// Token: 0x04001048 RID: 4168
			private int len;

			// Token: 0x04001049 RID: 4169
			private int hash;
		}

		// Token: 0x02000303 RID: 771
		private class CredentialCacheForHostKey
		{
			// Token: 0x06001A3D RID: 6717 RVA: 0x000136C7 File Offset: 0x000118C7
			internal CredentialCacheForHostKey(string host, int port, string authType)
			{
				this.host = host;
				this.port = port;
				this.authType = authType;
				this.hash = host.GetHashCode() + port.GetHashCode() + authType.GetHashCode();
			}

			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x06001A3E RID: 6718 RVA: 0x000136FF File Offset: 0x000118FF
			public string Host
			{
				get
				{
					return this.host;
				}
			}

			// Token: 0x17000651 RID: 1617
			// (get) Token: 0x06001A3F RID: 6719 RVA: 0x00013707 File Offset: 0x00011907
			public int Port
			{
				get
				{
					return this.port;
				}
			}

			// Token: 0x17000652 RID: 1618
			// (get) Token: 0x06001A40 RID: 6720 RVA: 0x0001370F File Offset: 0x0001190F
			public string AuthType
			{
				get
				{
					return this.authType;
				}
			}

			// Token: 0x06001A41 RID: 6721 RVA: 0x00013717 File Offset: 0x00011917
			public override int GetHashCode()
			{
				return this.hash;
			}

			// Token: 0x06001A42 RID: 6722 RVA: 0x0004E5F8 File Offset: 0x0004C7F8
			public override bool Equals(object obj)
			{
				CredentialCache.CredentialCacheForHostKey credentialCacheForHostKey = obj as CredentialCache.CredentialCacheForHostKey;
				return credentialCacheForHostKey != null && this.hash == credentialCacheForHostKey.hash;
			}

			// Token: 0x06001A43 RID: 6723 RVA: 0x0001371F File Offset: 0x0001191F
			public override string ToString()
			{
				return this.host + " : " + this.authType;
			}

			// Token: 0x0400104A RID: 4170
			private string host;

			// Token: 0x0400104B RID: 4171
			private int port;

			// Token: 0x0400104C RID: 4172
			private string authType;

			// Token: 0x0400104D RID: 4173
			private int hash;
		}
	}
}
