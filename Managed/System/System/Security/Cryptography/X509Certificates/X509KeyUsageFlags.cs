using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Defines how the certificate key can be used. If this value is not defined, the key can be used for any purpose.</summary>
	// Token: 0x0200046F RID: 1135
	[Flags]
	public enum X509KeyUsageFlags
	{
		/// <summary>No key usage parameters.</summary>
		// Token: 0x040018A5 RID: 6309
		None = 0,
		/// <summary>The key can be used for encryption only.</summary>
		// Token: 0x040018A6 RID: 6310
		EncipherOnly = 1,
		/// <summary>The key can be used to sign a certificate revocation list (CRL).</summary>
		// Token: 0x040018A7 RID: 6311
		CrlSign = 2,
		/// <summary>The key can be used to sign certificates.</summary>
		// Token: 0x040018A8 RID: 6312
		KeyCertSign = 4,
		/// <summary>The key can be used to determine key agreement, such as a key created using the Diffie-Hellman key agreement algorithm.</summary>
		// Token: 0x040018A9 RID: 6313
		KeyAgreement = 8,
		/// <summary>The key can be used for data encryption.</summary>
		// Token: 0x040018AA RID: 6314
		DataEncipherment = 16,
		/// <summary>The key can be used for key encryption.</summary>
		// Token: 0x040018AB RID: 6315
		KeyEncipherment = 32,
		/// <summary>The key can be used for authentication.</summary>
		// Token: 0x040018AC RID: 6316
		NonRepudiation = 64,
		/// <summary>The key can be used as a digital signature.</summary>
		// Token: 0x040018AD RID: 6317
		DigitalSignature = 128,
		/// <summary>The key can be used for decryption only.</summary>
		// Token: 0x040018AE RID: 6318
		DecipherOnly = 32768
	}
}
