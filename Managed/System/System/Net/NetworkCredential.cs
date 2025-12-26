using System;

namespace System.Net
{
	/// <summary>Provides credentials for password-based authentication schemes such as basic, digest, NTLM, and Kerberos authentication.</summary>
	// Token: 0x02000370 RID: 880
	public class NetworkCredential : ICredentials, ICredentialsByHost
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkCredential" /> class.</summary>
		// Token: 0x06001EA4 RID: 7844 RVA: 0x000021C3 File Offset: 0x000003C3
		public NetworkCredential()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkCredential" /> class with the specified user name and password.</summary>
		/// <param name="userName">The user name associated with the credentials. </param>
		/// <param name="password">The password for the user name associated with the credentials. </param>
		// Token: 0x06001EA5 RID: 7845 RVA: 0x00016494 File Offset: 0x00014694
		public NetworkCredential(string userName, string password)
		{
			this.userName = userName;
			this.password = password;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkCredential" /> class with the specified user name, password, and domain.</summary>
		/// <param name="userName">The user name associated with the credentials. </param>
		/// <param name="password">The password for the user name associated with the credentials. </param>
		/// <param name="domain">The domain associated with these credentials. </param>
		// Token: 0x06001EA6 RID: 7846 RVA: 0x000164AA File Offset: 0x000146AA
		public NetworkCredential(string userName, string password, string domain)
		{
			this.userName = userName;
			this.password = password;
			this.domain = domain;
		}

		/// <summary>Gets or sets the domain or computer name that verifies the credentials.</summary>
		/// <returns>The name of the domain associated with the credentials.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001EA7 RID: 7847 RVA: 0x000164C7 File Offset: 0x000146C7
		// (set) Token: 0x06001EA8 RID: 7848 RVA: 0x000164E4 File Offset: 0x000146E4
		public string Domain
		{
			get
			{
				return (this.domain != null) ? this.domain : string.Empty;
			}
			set
			{
				this.domain = value;
			}
		}

		/// <summary>Gets or sets the user name associated with the credentials.</summary>
		/// <returns>The user name associated with the credentials.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x000164ED File Offset: 0x000146ED
		// (set) Token: 0x06001EAA RID: 7850 RVA: 0x0001650A File Offset: 0x0001470A
		public string UserName
		{
			get
			{
				return (this.userName != null) ? this.userName : string.Empty;
			}
			set
			{
				this.userName = value;
			}
		}

		/// <summary>Gets or sets the password for the user name associated with the credentials.</summary>
		/// <returns>The password associated with the credentials. If this <see cref="T:System.Net.NetworkCredential" /> instance was constructed with a null password, then the <see cref="P:System.Net.NetworkCredential.Password" /> property will return an empty string.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x00016513 File Offset: 0x00014713
		// (set) Token: 0x06001EAC RID: 7852 RVA: 0x00016530 File Offset: 0x00014730
		public string Password
		{
			get
			{
				return (this.password != null) ? this.password : string.Empty;
			}
			set
			{
				this.password = value;
			}
		}

		/// <summary>Returns an instance of the <see cref="T:System.Net.NetworkCredential" /> class for the specified Uniform Resource Identifier (URI) and authentication type.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkCredential" /> object.</returns>
		/// <param name="uri">The URI that the client provides authentication for. </param>
		/// <param name="authType">The type of authentication requested, as defined in the <see cref="P:System.Net.IAuthenticationModule.AuthenticationType" /> property. </param>
		// Token: 0x06001EAD RID: 7853 RVA: 0x000021CB File Offset: 0x000003CB
		public NetworkCredential GetCredential(global::System.Uri uri, string authType)
		{
			return this;
		}

		/// <summary>Returns an instance of the <see cref="T:System.Net.NetworkCredential" /> class for the specified host, port, and authentication type.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkCredential" /> for the specified host, port, and authentication protocol, or null if there are no credentials available for the specified host, port, and authentication protocol.</returns>
		/// <param name="host">The host computer that authenticates the client.</param>
		/// <param name="port">The port on the <paramref name="host" /> that the client communicates with.</param>
		/// <param name="authenticationType">The type of authentication requested, as defined in the <see cref="P:System.Net.IAuthenticationModule.AuthenticationType" /> property. </param>
		// Token: 0x06001EAE RID: 7854 RVA: 0x000021CB File Offset: 0x000003CB
		public NetworkCredential GetCredential(string host, int port, string authenticationType)
		{
			return this;
		}

		// Token: 0x040012EE RID: 4846
		private string userName;

		// Token: 0x040012EF RID: 4847
		private string password;

		// Token: 0x040012F0 RID: 4848
		private string domain;
	}
}
