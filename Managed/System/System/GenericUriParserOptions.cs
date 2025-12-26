using System;

namespace System
{
	/// <summary>Specifies options for a <see cref="T:System.UriParser" />.</summary>
	// Token: 0x02000276 RID: 630
	[Flags]
	public enum GenericUriParserOptions
	{
		/// <summary>The parser:</summary>
		// Token: 0x040006EC RID: 1772
		Default = 0,
		/// <summary>The parser allows a registry-based authority.</summary>
		// Token: 0x040006ED RID: 1773
		GenericAuthority = 1,
		/// <summary>The parser allows a URI with no authority.</summary>
		// Token: 0x040006EE RID: 1774
		AllowEmptyAuthority = 2,
		/// <summary>The scheme does not define a user information part.</summary>
		// Token: 0x040006EF RID: 1775
		NoUserInfo = 4,
		/// <summary>The scheme does not define a port.</summary>
		// Token: 0x040006F0 RID: 1776
		NoPort = 8,
		/// <summary>The scheme does not define a query part.</summary>
		// Token: 0x040006F1 RID: 1777
		NoQuery = 16,
		/// <summary>The scheme does not define a fragment part.</summary>
		// Token: 0x040006F2 RID: 1778
		NoFragment = 32,
		/// <summary>The parser does not convert back slashes into forward slashes.</summary>
		// Token: 0x040006F3 RID: 1779
		DontConvertPathBackslashes = 64,
		/// <summary>The parser does not canonicalize the URI.</summary>
		// Token: 0x040006F4 RID: 1780
		DontCompressPath = 128,
		/// <summary>The parser does not unescape path dots, forward slashes, or back slashes.</summary>
		// Token: 0x040006F5 RID: 1781
		DontUnescapePathDotsAndSlashes = 256,
		/// <summary>The parser supports Internationalized Domain Name (IDN) parsing (IDN) of host names. Whether IDN is used is dictated by configuration values. See the Remarks for more information.</summary>
		// Token: 0x040006F6 RID: 1782
		Idn = 512,
		/// <summary>The parser supports the parsing rules specified in RFC 3987 for International Resource Identifiers (IRI). Whether IRI is used is dictated by configuration values. See the Remarks for more information.</summary>
		// Token: 0x040006F7 RID: 1783
		IriParsing = 1024
	}
}
