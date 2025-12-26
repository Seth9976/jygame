using System;

namespace System
{
	/// <summary>Controls how URI information is escaped.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x020004D2 RID: 1234
	public enum UriFormat
	{
		/// <summary>Escaping is performed according to the rules in RFC 2396.</summary>
		// Token: 0x04001B8D RID: 7053
		UriEscaped = 1,
		/// <summary>No escaping is performed.</summary>
		// Token: 0x04001B8E RID: 7054
		Unescaped,
		/// <summary>Characters that have a reserved meaning in the requested URI components remain escaped. All others are not escaped. See Remarks.</summary>
		// Token: 0x04001B8F RID: 7055
		SafeUnescaped
	}
}
