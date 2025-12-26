using System;

namespace System.Net.Mime
{
	/// <summary>Specifies the Content-Transfer-Encoding header information for an e-mail message attachment.</summary>
	// Token: 0x0200036C RID: 876
	public enum TransferEncoding
	{
		/// <summary>Encodes data that consists of printable characters in the US-ASCII character set. See RFC 2406 Section 6.7.</summary>
		// Token: 0x040012E1 RID: 4833
		QuotedPrintable,
		/// <summary>Encodes stream-based data. See RFC 2406 Section 6.8.</summary>
		// Token: 0x040012E2 RID: 4834
		Base64,
		/// <summary>Used for data that is not encoded. The data is in 7-bit US-ASCII characters with a total line length of no longer than 1000 characters. See RFC2406 Section 2.7.</summary>
		// Token: 0x040012E3 RID: 4835
		SevenBit,
		/// <summary>Indicates that the transfer encoding is unknown.</summary>
		// Token: 0x040012E4 RID: 4836
		Unknown = -1
	}
}
