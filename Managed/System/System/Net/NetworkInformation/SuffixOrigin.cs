using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Specifies how an IP address host suffix was located.</summary>
	// Token: 0x020003D2 RID: 978
	public enum SuffixOrigin
	{
		/// <summary>The suffix was located using an unspecified source.</summary>
		// Token: 0x0400145A RID: 5210
		Other,
		/// <summary>The suffix was manually configured.</summary>
		// Token: 0x0400145B RID: 5211
		Manual,
		/// <summary>The suffix is a well-known suffix. Well-known suffixes are specified in standard-track Request for Comments (RFC) documents and assigned by the Internet Assigned Numbers Authority (Iana) or an address registry. Such suffixes are reserved for special purposes.</summary>
		// Token: 0x0400145C RID: 5212
		WellKnown,
		/// <summary>The suffix was supplied by a Dynamic Host Configuration Protocol (DHCP) server.</summary>
		// Token: 0x0400145D RID: 5213
		OriginDhcp,
		/// <summary>The suffix is a link-local suffix.</summary>
		// Token: 0x0400145E RID: 5214
		LinkLayerAddress,
		/// <summary>The suffix was randomly assigned.</summary>
		// Token: 0x0400145F RID: 5215
		Random
	}
}
