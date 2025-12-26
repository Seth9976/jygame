using System;

namespace System.Net.Sockets
{
	/// <summary>Specifies the type of protocol that an instance of the <see cref="T:System.Net.Sockets.Socket" /> class can use.</summary>
	// Token: 0x0200040C RID: 1036
	public enum ProtocolFamily
	{
		/// <summary>Unknown protocol.</summary>
		// Token: 0x040015AE RID: 5550
		Unknown = -1,
		/// <summary>Unspecified protocol.</summary>
		// Token: 0x040015AF RID: 5551
		Unspecified,
		/// <summary>Unix local to host protocol.</summary>
		// Token: 0x040015B0 RID: 5552
		Unix,
		/// <summary>IP version 4 protocol.</summary>
		// Token: 0x040015B1 RID: 5553
		InterNetwork,
		/// <summary>ARPANET IMP protocol.</summary>
		// Token: 0x040015B2 RID: 5554
		ImpLink,
		/// <summary>PUP protocol.</summary>
		// Token: 0x040015B3 RID: 5555
		Pup,
		/// <summary>MIT CHAOS protocol.</summary>
		// Token: 0x040015B4 RID: 5556
		Chaos,
		/// <summary>IPX or SPX protocol.</summary>
		// Token: 0x040015B5 RID: 5557
		Ipx,
		/// <summary>ISO protocol.</summary>
		// Token: 0x040015B6 RID: 5558
		Iso,
		/// <summary>European Computer Manufacturers Association (ECMA) protocol.</summary>
		// Token: 0x040015B7 RID: 5559
		Ecma,
		/// <summary>DataKit protocol.</summary>
		// Token: 0x040015B8 RID: 5560
		DataKit,
		/// <summary>CCITT protocol, such as X.25.</summary>
		// Token: 0x040015B9 RID: 5561
		Ccitt,
		/// <summary>IBM SNA protocol.</summary>
		// Token: 0x040015BA RID: 5562
		Sna,
		/// <summary>DECNet protocol.</summary>
		// Token: 0x040015BB RID: 5563
		DecNet,
		/// <summary>Direct data link protocol.</summary>
		// Token: 0x040015BC RID: 5564
		DataLink,
		/// <summary>LAT protocol.</summary>
		// Token: 0x040015BD RID: 5565
		Lat,
		/// <summary>NSC HyperChannel protocol.</summary>
		// Token: 0x040015BE RID: 5566
		HyperChannel,
		/// <summary>AppleTalk protocol.</summary>
		// Token: 0x040015BF RID: 5567
		AppleTalk,
		/// <summary>NetBIOS protocol.</summary>
		// Token: 0x040015C0 RID: 5568
		NetBios,
		/// <summary>VoiceView protocol.</summary>
		// Token: 0x040015C1 RID: 5569
		VoiceView,
		/// <summary>FireFox protocol.</summary>
		// Token: 0x040015C2 RID: 5570
		FireFox,
		/// <summary>Banyan protocol.</summary>
		// Token: 0x040015C3 RID: 5571
		Banyan = 21,
		/// <summary>Native ATM services protocol.</summary>
		// Token: 0x040015C4 RID: 5572
		Atm,
		/// <summary>IP version 6 protocol.</summary>
		// Token: 0x040015C5 RID: 5573
		InterNetworkV6,
		/// <summary>Microsoft Cluster products protocol.</summary>
		// Token: 0x040015C6 RID: 5574
		Cluster,
		/// <summary>IEEE 1284.4 workgroup protocol.</summary>
		// Token: 0x040015C7 RID: 5575
		Ieee12844,
		/// <summary>IrDA protocol.</summary>
		// Token: 0x040015C8 RID: 5576
		Irda,
		/// <summary>Network Designers OSI gateway enabled protocol.</summary>
		// Token: 0x040015C9 RID: 5577
		NetworkDesigners = 28,
		/// <summary>MAX protocol.</summary>
		// Token: 0x040015CA RID: 5578
		Max,
		/// <summary>Xerox NS protocol.</summary>
		// Token: 0x040015CB RID: 5579
		NS = 6,
		/// <summary>OSI protocol.</summary>
		// Token: 0x040015CC RID: 5580
		Osi
	}
}
