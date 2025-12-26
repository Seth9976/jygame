using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Specifies characteristics of the X.500 distinguished name.</summary>
	// Token: 0x0200045A RID: 1114
	[Flags]
	public enum X500DistinguishedNameFlags
	{
		/// <summary>The distinguished name has no special characteristics.</summary>
		// Token: 0x0400182C RID: 6188
		None = 0,
		/// <summary>The distinguished name is reversed.</summary>
		// Token: 0x0400182D RID: 6189
		Reversed = 1,
		/// <summary>The distinguished name uses semicolons.</summary>
		// Token: 0x0400182E RID: 6190
		UseSemicolons = 16,
		/// <summary>The distinguished name does not use the plus sign.</summary>
		// Token: 0x0400182F RID: 6191
		DoNotUsePlusSign = 32,
		/// <summary>The distinguished name does not use quotation marks.</summary>
		// Token: 0x04001830 RID: 6192
		DoNotUseQuotes = 64,
		/// <summary>The distinguished name uses commas.</summary>
		// Token: 0x04001831 RID: 6193
		UseCommas = 128,
		/// <summary>The distinguished name uses the new line character.</summary>
		// Token: 0x04001832 RID: 6194
		UseNewLines = 256,
		/// <summary>The distinguished name uses UTF8 encoding.</summary>
		// Token: 0x04001833 RID: 6195
		UseUTF8Encoding = 4096,
		/// <summary>The distinguished name uses T61 encoding.</summary>
		// Token: 0x04001834 RID: 6196
		UseT61Encoding = 8192,
		/// <summary>The distinguished name uses UTF8 encoding.</summary>
		// Token: 0x04001835 RID: 6197
		ForceUTF8Encoding = 16384
	}
}
