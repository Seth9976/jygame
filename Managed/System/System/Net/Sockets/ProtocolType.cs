using System;

namespace System.Net.Sockets
{
	/// <summary>Specifies the protocols that the <see cref="T:System.Net.Sockets.Socket" /> class supports.</summary>
	// Token: 0x0200040D RID: 1037
	public enum ProtocolType
	{
		/// <summary>Internet Protocol.</summary>
		// Token: 0x040015CE RID: 5582
		IP,
		/// <summary>Internet Control Message Protocol.</summary>
		// Token: 0x040015CF RID: 5583
		Icmp,
		/// <summary>Internet Group Management Protocol.</summary>
		// Token: 0x040015D0 RID: 5584
		Igmp,
		/// <summary>Gateway To Gateway Protocol.</summary>
		// Token: 0x040015D1 RID: 5585
		Ggp,
		/// <summary>Transmission Control Protocol.</summary>
		// Token: 0x040015D2 RID: 5586
		Tcp = 6,
		/// <summary>PARC Universal Packet Protocol.</summary>
		// Token: 0x040015D3 RID: 5587
		Pup = 12,
		/// <summary>User Datagram Protocol.</summary>
		// Token: 0x040015D4 RID: 5588
		Udp = 17,
		/// <summary>Internet Datagram Protocol.</summary>
		// Token: 0x040015D5 RID: 5589
		Idp = 22,
		/// <summary>Internet Protocol version 6 (IPv6). </summary>
		// Token: 0x040015D6 RID: 5590
		IPv6 = 41,
		/// <summary>Net Disk Protocol (unofficial).</summary>
		// Token: 0x040015D7 RID: 5591
		ND = 77,
		/// <summary>Raw IP packet protocol.</summary>
		// Token: 0x040015D8 RID: 5592
		Raw = 255,
		/// <summary>Unspecified protocol.</summary>
		// Token: 0x040015D9 RID: 5593
		Unspecified = 0,
		/// <summary>Internet Packet Exchange Protocol.</summary>
		// Token: 0x040015DA RID: 5594
		Ipx = 1000,
		/// <summary>Sequenced Packet Exchange protocol.</summary>
		// Token: 0x040015DB RID: 5595
		Spx = 1256,
		/// <summary>Sequenced Packet Exchange version 2 protocol.</summary>
		// Token: 0x040015DC RID: 5596
		SpxII,
		/// <summary>Unknown protocol.</summary>
		// Token: 0x040015DD RID: 5597
		Unknown = -1,
		/// <summary>Internet Protocol version 4.</summary>
		// Token: 0x040015DE RID: 5598
		IPv4 = 4,
		/// <summary>IPv6 Routing header.</summary>
		// Token: 0x040015DF RID: 5599
		IPv6RoutingHeader = 43,
		/// <summary>IPv6 Fragment header.</summary>
		// Token: 0x040015E0 RID: 5600
		IPv6FragmentHeader,
		/// <summary>IPv6 Encapsulating Security Payload header.</summary>
		// Token: 0x040015E1 RID: 5601
		IPSecEncapsulatingSecurityPayload = 50,
		/// <summary>IPv6 Authentication header. For details, see RFC 2292 section 2.2.1, available at http://www.ietf.org.</summary>
		// Token: 0x040015E2 RID: 5602
		IPSecAuthenticationHeader,
		/// <summary>Internet Control Message Protocol for IPv6.</summary>
		// Token: 0x040015E3 RID: 5603
		IcmpV6 = 58,
		/// <summary>IPv6 No next header.</summary>
		// Token: 0x040015E4 RID: 5604
		IPv6NoNextHeader,
		/// <summary>IPv6 Destination Options header.</summary>
		// Token: 0x040015E5 RID: 5605
		IPv6DestinationOptions,
		/// <summary>IPv6 Hop by Hop Options header.</summary>
		// Token: 0x040015E6 RID: 5606
		IPv6HopByHopOptions = 0
	}
}
