using System;

namespace System
{
	/// <summary>Defines the parts of a URI for the <see cref="M:System.Uri.GetLeftPart(System.UriPartial)" /> method.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020004D8 RID: 1240
	public enum UriPartial
	{
		/// <summary>The scheme segment of the URI.</summary>
		// Token: 0x04001BA5 RID: 7077
		Scheme,
		/// <summary>The scheme and authority segments of the URI.</summary>
		// Token: 0x04001BA6 RID: 7078
		Authority,
		/// <summary>The scheme, authority, and path segments of the URI.</summary>
		// Token: 0x04001BA7 RID: 7079
		Path,
		/// <summary>The scheme, authority, path, and query segments of the URI.</summary>
		// Token: 0x04001BA8 RID: 7080
		Query
	}
}
