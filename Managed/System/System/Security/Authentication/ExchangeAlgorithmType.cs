using System;

namespace System.Security.Authentication
{
	/// <summary>Specifies the algorithm used to create keys shared by the client and server.</summary>
	// Token: 0x02000448 RID: 1096
	public enum ExchangeAlgorithmType
	{
		/// <summary>No key exchange algorithm is used.</summary>
		// Token: 0x040017CD RID: 6093
		None,
		/// <summary>The Diffie Hellman ephemeral key exchange algorithm.</summary>
		// Token: 0x040017CE RID: 6094
		DiffieHellman = 43522,
		/// <summary>The RSA public-key exchange algorithm.</summary>
		// Token: 0x040017CF RID: 6095
		RsaKeyX = 41984,
		/// <summary>The RSA public-key signature algorithm.</summary>
		// Token: 0x040017D0 RID: 6096
		RsaSign = 9216
	}
}
