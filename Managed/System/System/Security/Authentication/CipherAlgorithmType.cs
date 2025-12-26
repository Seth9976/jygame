using System;

namespace System.Security.Authentication
{
	/// <summary>Defines the possible cipher algorithms for the <see cref="T:System.Net.Security.SslStream" /> class.</summary>
	// Token: 0x02000447 RID: 1095
	public enum CipherAlgorithmType
	{
		/// <summary>No encryption algorithm is used.</summary>
		// Token: 0x040017C3 RID: 6083
		None,
		/// <summary>The Advanced Encryption Standard (AES) algorithm.</summary>
		// Token: 0x040017C4 RID: 6084
		Aes = 26129,
		/// <summary>The Advanced Encryption Standard (AES) algorithm with a 128 bit key.</summary>
		// Token: 0x040017C5 RID: 6085
		Aes128 = 26126,
		/// <summary>The Advanced Encryption Standard (AES) algorithm with a 192 bit key.</summary>
		// Token: 0x040017C6 RID: 6086
		Aes192,
		/// <summary>The Advanced Encryption Standard (AES) algorithm with a 256 bit key.</summary>
		// Token: 0x040017C7 RID: 6087
		Aes256,
		/// <summary>The Data Encryption Standard (DES) algorithm.</summary>
		// Token: 0x040017C8 RID: 6088
		Des = 26113,
		/// <summary>Rivest's Code 2 (RC2) algorithm.</summary>
		// Token: 0x040017C9 RID: 6089
		Rc2,
		/// <summary>Rivest's Code 4 (RC4) algorithm.</summary>
		// Token: 0x040017CA RID: 6090
		Rc4 = 26625,
		/// <summary>The Triple Data Encryption Standard (3DES) algorithm.</summary>
		// Token: 0x040017CB RID: 6091
		TripleDes = 26115
	}
}
