using System;

namespace System.Net
{
	/// <summary>Contains an authentication message for an Internet server.</summary>
	// Token: 0x020002C8 RID: 712
	public class Authorization
	{
		/// <summary>Creates a new instance of the <see cref="T:System.Net.Authorization" /> class with the specified authorization message.</summary>
		/// <param name="token">The encrypted authorization message expected by the server. </param>
		// Token: 0x06001873 RID: 6259 RVA: 0x000121E0 File Offset: 0x000103E0
		public Authorization(string token)
			: this(token, true)
		{
		}

		/// <summary>Creates a new instance of the <see cref="T:System.Net.Authorization" /> class with the specified authorization message and completion status.</summary>
		/// <param name="token">The encrypted authorization message expected by the server. </param>
		/// <param name="finished">The completion status of the authorization attempt. true if the authorization attempt is complete; otherwise, false. </param>
		// Token: 0x06001874 RID: 6260 RVA: 0x000121EA File Offset: 0x000103EA
		public Authorization(string token, bool complete)
			: this(token, complete, null)
		{
		}

		/// <summary>Creates a new instance of the <see cref="T:System.Net.Authorization" /> class with the specified authorization message, completion status, and connection group identifier.</summary>
		/// <param name="token">The encrypted authorization message expected by the server. </param>
		/// <param name="finished">The completion status of the authorization attempt. true if the authorization attempt is complete; otherwise, false. </param>
		/// <param name="connectionGroupId">A unique identifier that can be used to create private client-server connections that are bound only to this authentication scheme. </param>
		// Token: 0x06001875 RID: 6261 RVA: 0x000121F5 File Offset: 0x000103F5
		public Authorization(string token, bool complete, string connectionGroupId)
		{
			this.token = token;
			this.complete = complete;
			this.connectionGroupId = connectionGroupId;
		}

		/// <summary>Gets the message returned to the server in response to an authentication challenge.</summary>
		/// <returns>The message that will be returned to the server in response to an authentication challenge.</returns>
		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x00012212 File Offset: 0x00010412
		public string Message
		{
			get
			{
				return this.token;
			}
		}

		/// <summary>Gets the completion status of the authorization.</summary>
		/// <returns>true if the authentication process is complete; otherwise, false.</returns>
		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x0001221A File Offset: 0x0001041A
		public bool Complete
		{
			get
			{
				return this.complete;
			}
		}

		/// <summary>Gets a unique identifier for user-specific connections.</summary>
		/// <returns>A unique string that associates a connection with an authenticating entity.</returns>
		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x00012222 File Offset: 0x00010422
		public string ConnectionGroupId
		{
			get
			{
				return this.connectionGroupId;
			}
		}

		/// <summary>Gets or sets the prefix for Uniform Resource Identifiers (URIs) that can be authenticated with the <see cref="P:System.Net.Authorization.Message" /> property.</summary>
		/// <returns>An array of strings that contains URI prefixes.</returns>
		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x0001222A File Offset: 0x0001042A
		// (set) Token: 0x0600187A RID: 6266 RVA: 0x00012232 File Offset: 0x00010432
		public string[] ProtectionRealm
		{
			get
			{
				return this.protectionRealm;
			}
			set
			{
				this.protectionRealm = value;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x0001223B File Offset: 0x0001043B
		// (set) Token: 0x0600187C RID: 6268 RVA: 0x00012243 File Offset: 0x00010443
		internal IAuthenticationModule Module
		{
			get
			{
				return this.module;
			}
			set
			{
				this.module = value;
			}
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00005023 File Offset: 0x00003223
		private static Exception GetMustImplement()
		{
			return new NotImplementedException();
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that indicates whether mutual authentication occurred.</summary>
		/// <returns>true if both client and server were authenticated; otherwise, false.</returns>
		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x0001224C File Offset: 0x0001044C
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x0001224C File Offset: 0x0001044C
		[global::System.MonoTODO]
		public bool MutuallyAuthenticated
		{
			get
			{
				throw Authorization.GetMustImplement();
			}
			set
			{
				throw Authorization.GetMustImplement();
			}
		}

		// Token: 0x04000F8C RID: 3980
		private string token;

		// Token: 0x04000F8D RID: 3981
		private bool complete;

		// Token: 0x04000F8E RID: 3982
		private string connectionGroupId;

		// Token: 0x04000F8F RID: 3983
		private string[] protectionRealm;

		// Token: 0x04000F90 RID: 3984
		private IAuthenticationModule module;
	}
}
