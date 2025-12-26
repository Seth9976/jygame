using System;

namespace System.ComponentModel
{
	/// <summary>Defines identifiers for types of inheritance levels.</summary>
	// Token: 0x02000165 RID: 357
	public enum InheritanceLevel
	{
		/// <summary>The object is inherited.</summary>
		// Token: 0x0400038F RID: 911
		Inherited = 1,
		/// <summary>The object is inherited, but has read-only access.</summary>
		// Token: 0x04000390 RID: 912
		InheritedReadOnly,
		/// <summary>The object is not inherited.</summary>
		// Token: 0x04000391 RID: 913
		NotInherited
	}
}
