using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Specifies the Network Basic Input/Output System (NetBIOS) node type.</summary>
	// Token: 0x020003B8 RID: 952
	public enum NetBiosNodeType
	{
		/// <summary>An unknown node type.</summary>
		// Token: 0x040013E4 RID: 5092
		Unknown,
		/// <summary>A broadcast node.</summary>
		// Token: 0x040013E5 RID: 5093
		Broadcast,
		/// <summary>A peer-to-peer node.</summary>
		// Token: 0x040013E6 RID: 5094
		Peer2Peer,
		/// <summary>A mixed node.</summary>
		// Token: 0x040013E7 RID: 5095
		Mixed = 4,
		/// <summary>A hybrid node.</summary>
		// Token: 0x040013E8 RID: 5096
		Hybrid = 8
	}
}
