using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Provides information about network interfaces that support Internet Protocol version 4 (IPv4).</summary>
	// Token: 0x0200039A RID: 922
	public abstract class IPv4InterfaceProperties
	{
		/// <summary>Gets the index of the network interface associated with the Internet Protocol version 4 (IPv4) address.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the index of the IPv4 interface.</returns>
		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06002072 RID: 8306
		public abstract int Index { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether this interface has an automatic private IP addressing (APIPA) address.</summary>
		/// <returns>true if the interface uses an APIPA address; otherwise, false.</returns>
		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002073 RID: 8307
		public abstract bool IsAutomaticPrivateAddressingActive { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether this interface has automatic private IP addressing (APIPA) enabled.</summary>
		/// <returns>true if the interface uses APIPA; otherwise, false.</returns>
		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002074 RID: 8308
		public abstract bool IsAutomaticPrivateAddressingEnabled { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the interface is configured to use a Dynamic Host Configuration Protocol (DHCP) server to obtain an IP address.</summary>
		/// <returns>true if the interface is configured to obtain an IP address from a DHCP server; otherwise, false.</returns>
		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06002075 RID: 8309
		public abstract bool IsDhcpEnabled { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether this interface can forward (route) packets.</summary>
		/// <returns>true if this interface routes packets; otherwise false.</returns>
		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06002076 RID: 8310
		public abstract bool IsForwardingEnabled { get; }

		/// <summary>Gets the maximum transmission unit (MTU) for this network interface.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the MTU.</returns>
		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06002077 RID: 8311
		public abstract int Mtu { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether an interface uses Windows Internet Name Service (WINS).</summary>
		/// <returns>true if the interface uses WINS; otherwise, false.</returns>
		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002078 RID: 8312
		public abstract bool UsesWins { get; }
	}
}
