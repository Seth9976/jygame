using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Specifies permission to access information about network interfaces and traffic statistics.</summary>
	// Token: 0x020003BB RID: 955
	[Flags]
	public enum NetworkInformationAccess
	{
		/// <summary>No access to network information.</summary>
		// Token: 0x040013ED RID: 5101
		None = 0,
		/// <summary>Read access to network information.</summary>
		// Token: 0x040013EE RID: 5102
		Read = 1,
		/// <summary>Ping access to network information.</summary>
		// Token: 0x040013EF RID: 5103
		Ping = 4
	}
}
