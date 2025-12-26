using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Provides Internet Protocol (IP) statistical data.</summary>
	// Token: 0x02000390 RID: 912
	public abstract class IPGlobalStatistics
	{
		/// <summary>Gets the default time-to-live (TTL) value for Internet Protocol (IP) packets.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the TTL.</returns>
		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001FFF RID: 8191
		public abstract int DefaultTtl { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that specifies whether Internet Protocol (IP) packet forwarding is enabled.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that specifies whether packet forwarding is enabled.</returns>
		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06002000 RID: 8192
		public abstract bool ForwardingEnabled { get; }

		/// <summary>Gets the number of network interfaces.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value containing the number of network interfaces for the address family used to obtain this <see cref="T:System.Net.NetworkInformation.IPGlobalStatistics" /> instance.</returns>
		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06002001 RID: 8193
		public abstract int NumberOfInterfaces { get; }

		/// <summary>Gets the number of Internet Protocol (IP) addresses assigned to the local computer.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that indicates the number of IP addresses assigned to the address family (Internet Protocol version 4 or Internet Protocol version 6) described by this object.</returns>
		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06002002 RID: 8194
		public abstract int NumberOfIPAddresses { get; }

		/// <summary>Gets the number of routes in the Internet Protocol (IP) routing table.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of routes in the routing table.</returns>
		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06002003 RID: 8195
		public abstract int NumberOfRoutes { get; }

		/// <summary>Gets the number of outbound Internet Protocol (IP) packets.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of outgoing packets.</returns>
		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06002004 RID: 8196
		public abstract long OutputPacketRequests { get; }

		/// <summary>Gets the number of routes that have been discarded from the routing table.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of valid routes that have been discarded.</returns>
		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06002005 RID: 8197
		public abstract long OutputPacketRoutingDiscards { get; }

		/// <summary>Gets the number of transmitted Internet Protocol (IP) packets that have been discarded.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of outgoing packets that have been discarded.</returns>
		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06002006 RID: 8198
		public abstract long OutputPacketsDiscarded { get; }

		/// <summary>Gets the number of Internet Protocol (IP) packets for which the local computer could not determine a route to the destination address.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the number of packets that could not be sent because a route could not be found.</returns>
		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06002007 RID: 8199
		public abstract long OutputPacketsWithNoRoute { get; }

		/// <summary>Gets the number of Internet Protocol (IP) packets that could not be fragmented.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of packets that required fragmentation but had the "Don't Fragment" bit set.</returns>
		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06002008 RID: 8200
		public abstract long PacketFragmentFailures { get; }

		/// <summary>Gets the number of Internet Protocol (IP) packets that required reassembly.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of packet reassemblies required.</returns>
		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06002009 RID: 8201
		public abstract long PacketReassembliesRequired { get; }

		/// <summary>Gets the number of Internet Protocol (IP) packets that were not successfully reassembled.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of packets that could not be reassembled.</returns>
		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x0600200A RID: 8202
		public abstract long PacketReassemblyFailures { get; }

		/// <summary>Gets the maximum amount of time within which all fragments of an Internet Protocol (IP) packet must arrive.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the maximum number of milliseconds within which all fragments of a packet must arrive to avoid being discarded.</returns>
		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x0600200B RID: 8203
		public abstract long PacketReassemblyTimeout { get; }

		/// <summary>Gets the number of Internet Protocol (IP) packets fragmented.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of fragmented packets.</returns>
		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x0600200C RID: 8204
		public abstract long PacketsFragmented { get; }

		/// <summary>Gets the number of Internet Protocol (IP) packets reassembled.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of fragmented packets that have been successfully reassembled.</returns>
		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x0600200D RID: 8205
		public abstract long PacketsReassembled { get; }

		/// <summary>Gets the number of Internet Protocol (IP) packets received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of IP packets received.</returns>
		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x0600200E RID: 8206
		public abstract long ReceivedPackets { get; }

		/// <summary>Gets the number of Internet Protocol (IP) packets delivered.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of IP packets delivered.</returns>
		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x0600200F RID: 8207
		public abstract long ReceivedPacketsDelivered { get; }

		/// <summary>Gets the number of Internet Protocol (IP) packets that have been received and discarded.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of incoming packets that have been discarded.</returns>
		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06002010 RID: 8208
		public abstract long ReceivedPacketsDiscarded { get; }

		/// <summary>Gets the number of Internet Protocol (IP) packets forwarded.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of forwarded packets.</returns>
		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06002011 RID: 8209
		public abstract long ReceivedPacketsForwarded { get; }

		/// <summary>Gets the number of Internet Protocol (IP) packets with address errors that were received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of IP packets received with errors in the address portion of the header.</returns>
		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06002012 RID: 8210
		public abstract long ReceivedPacketsWithAddressErrors { get; }

		/// <summary>Gets the number of Internet Protocol (IP) packets with header errors that were received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of IP packets received and discarded due to errors in the header.</returns>
		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06002013 RID: 8211
		public abstract long ReceivedPacketsWithHeadersErrors { get; }

		/// <summary>Gets the number of Internet Protocol (IP) packets received on the local machine with an unknown protocol in the header.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that indicates the total number of IP packets received with an unknown protocol.</returns>
		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06002014 RID: 8212
		public abstract long ReceivedPacketsWithUnknownProtocol { get; }
	}
}
