using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Specifies how much of the X.509 certificate chain should be included in the X.509 data.</summary>
	// Token: 0x0200046D RID: 1133
	public enum X509IncludeOption
	{
		/// <summary>No X.509 chain information is included.</summary>
		// Token: 0x0400189B RID: 6299
		None,
		/// <summary>The entire X.509 chain is included except for the root certificate.</summary>
		// Token: 0x0400189C RID: 6300
		ExcludeRoot,
		/// <summary>Only the end certificate is included in the X.509 chain information.</summary>
		// Token: 0x0400189D RID: 6301
		EndCertOnly,
		/// <summary>The entire X.509 chain is included.</summary>
		// Token: 0x0400189E RID: 6302
		WholeChain
	}
}
