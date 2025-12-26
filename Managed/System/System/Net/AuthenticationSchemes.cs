using System;

namespace System.Net
{
	/// <summary>Specifies protocols for authentication.</summary>
	// Token: 0x020002C7 RID: 711
	[Flags]
	public enum AuthenticationSchemes
	{
		/// <summary>No authentication is allowed. A client requesting an <see cref="T:System.Net.HttpListener" /> object with this flag set will always receive a 403 Forbidden status. Use this flag when a resource should never be served to a client.</summary>
		// Token: 0x04000F85 RID: 3973
		None = 0,
		/// <summary>Specifies digest authentication.</summary>
		// Token: 0x04000F86 RID: 3974
		Digest = 1,
		/// <summary>Negotiates with the client to determine the authentication scheme. If both client and server support Kerberos, it is used; otherwise, NTLM is used.</summary>
		// Token: 0x04000F87 RID: 3975
		Negotiate = 2,
		/// <summary>Specifies NTLM authentication.</summary>
		// Token: 0x04000F88 RID: 3976
		Ntlm = 4,
		/// <summary>Specifies Windows authentication.</summary>
		// Token: 0x04000F89 RID: 3977
		IntegratedWindowsAuthentication = 6,
		/// <summary>Specifies basic authentication. </summary>
		// Token: 0x04000F8A RID: 3978
		Basic = 8,
		/// <summary>Specifies anonymous authentication.</summary>
		// Token: 0x04000F8B RID: 3979
		Anonymous = 32768
	}
}
