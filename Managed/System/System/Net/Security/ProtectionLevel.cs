using System;

namespace System.Net.Security
{
	/// <summary>Indicates the security services requested for an authenticated stream.</summary>
	// Token: 0x020003F8 RID: 1016
	public enum ProtectionLevel
	{
		/// <summary>Authentication only.</summary>
		// Token: 0x0400151B RID: 5403
		None,
		/// <summary>Sign data to help ensure the integrity of transmitted data.</summary>
		// Token: 0x0400151C RID: 5404
		Sign,
		/// <summary>Encrypt and sign data to help ensure the confidentiality and integrity of transmitted data.</summary>
		// Token: 0x0400151D RID: 5405
		EncryptAndSign
	}
}
