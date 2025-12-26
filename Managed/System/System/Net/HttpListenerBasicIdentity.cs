using System;
using System.Security.Principal;

namespace System.Net
{
	/// <summary>Holds the user name and password from a basic authentication request.</summary>
	// Token: 0x0200032A RID: 810
	public class HttpListenerBasicIdentity : GenericIdentity
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.HttpListenerBasicIdentity" /> class using the specified user name and password.</summary>
		/// <param name="username">The user name.</param>
		/// <param name="password">The password.</param>
		// Token: 0x06001BCE RID: 7118 RVA: 0x00014228 File Offset: 0x00012428
		public HttpListenerBasicIdentity(string username, string password)
			: base(username, "Basic")
		{
			this.password = password;
		}

		/// <summary>Indicates the password from a basic authentication attempt.</summary>
		/// <returns>A <see cref="T:System.String" /> that holds the password.</returns>
		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x0001423D File Offset: 0x0001243D
		public virtual string Password
		{
			get
			{
				return this.password;
			}
		}

		// Token: 0x04001118 RID: 4376
		private string password;
	}
}
