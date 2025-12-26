using System;

namespace System.Net.Sockets
{
	/// <summary>Specifies the addressing scheme that an instance of the <see cref="T:System.Net.Sockets.Socket" /> class can use.</summary>
	// Token: 0x02000405 RID: 1029
	public enum AddressFamily
	{
		/// <summary>Unknown address family.</summary>
		// Token: 0x0400155C RID: 5468
		Unknown = -1,
		/// <summary>Unspecified address family.</summary>
		// Token: 0x0400155D RID: 5469
		Unspecified,
		/// <summary>Unix local to host address.</summary>
		// Token: 0x0400155E RID: 5470
		Unix,
		/// <summary>Address for IP version 4.</summary>
		// Token: 0x0400155F RID: 5471
		InterNetwork,
		/// <summary>ARPANET IMP address.</summary>
		// Token: 0x04001560 RID: 5472
		ImpLink,
		/// <summary>Address for PUP protocols.</summary>
		// Token: 0x04001561 RID: 5473
		Pup,
		/// <summary>Address for MIT CHAOS protocols.</summary>
		// Token: 0x04001562 RID: 5474
		Chaos,
		/// <summary>Address for Xerox NS protocols.</summary>
		// Token: 0x04001563 RID: 5475
		NS,
		/// <summary>IPX or SPX address.</summary>
		// Token: 0x04001564 RID: 5476
		Ipx = 6,
		/// <summary>Address for ISO protocols.</summary>
		// Token: 0x04001565 RID: 5477
		Iso,
		/// <summary>Address for OSI protocols.</summary>
		// Token: 0x04001566 RID: 5478
		Osi = 7,
		/// <summary>European Computer Manufacturers Association (ECMA) address.</summary>
		// Token: 0x04001567 RID: 5479
		Ecma,
		/// <summary>Address for Datakit protocols.</summary>
		// Token: 0x04001568 RID: 5480
		DataKit,
		/// <summary>Addresses for CCITT protocols, such as X.25.</summary>
		// Token: 0x04001569 RID: 5481
		Ccitt,
		/// <summary>IBM SNA address.</summary>
		// Token: 0x0400156A RID: 5482
		Sna,
		/// <summary>DECnet address.</summary>
		// Token: 0x0400156B RID: 5483
		DecNet,
		/// <summary>Direct data-link interface address.</summary>
		// Token: 0x0400156C RID: 5484
		DataLink,
		/// <summary>LAT address.</summary>
		// Token: 0x0400156D RID: 5485
		Lat,
		/// <summary>NSC Hyperchannel address.</summary>
		// Token: 0x0400156E RID: 5486
		HyperChannel,
		/// <summary>AppleTalk address.</summary>
		// Token: 0x0400156F RID: 5487
		AppleTalk,
		/// <summary>NetBios address.</summary>
		// Token: 0x04001570 RID: 5488
		NetBios,
		/// <summary>VoiceView address.</summary>
		// Token: 0x04001571 RID: 5489
		VoiceView,
		/// <summary>FireFox address.</summary>
		// Token: 0x04001572 RID: 5490
		FireFox,
		/// <summary>Banyan address.</summary>
		// Token: 0x04001573 RID: 5491
		Banyan = 21,
		/// <summary>Native ATM services address.</summary>
		// Token: 0x04001574 RID: 5492
		Atm,
		/// <summary>Address for IP version 6.</summary>
		// Token: 0x04001575 RID: 5493
		InterNetworkV6,
		/// <summary>Address for Microsoft cluster products.</summary>
		// Token: 0x04001576 RID: 5494
		Cluster,
		/// <summary>IEEE 1284.4 workgroup address.</summary>
		// Token: 0x04001577 RID: 5495
		Ieee12844,
		/// <summary>IrDA address.</summary>
		// Token: 0x04001578 RID: 5496
		Irda,
		/// <summary>Address for Network Designers OSI gateway-enabled protocols.</summary>
		// Token: 0x04001579 RID: 5497
		NetworkDesigners = 28,
		/// <summary>MAX address.</summary>
		// Token: 0x0400157A RID: 5498
		Max
	}
}
