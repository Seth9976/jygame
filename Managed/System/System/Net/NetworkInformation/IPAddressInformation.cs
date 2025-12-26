using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Provides information about a network interface address.</summary>
	// Token: 0x02000386 RID: 902
	public abstract class IPAddressInformation
	{
		/// <summary>Gets the Internet Protocol (IP) address.</summary>
		/// <returns>An <see cref="T:System.Net.IPAddress" /> instance that contains the IP address of an interface.</returns>
		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001FA3 RID: 8099
		public abstract IPAddress Address { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the Internet Protocol (IP) address is valid to appear in a Domain Name System (DNS) server database.</summary>
		/// <returns>true if the address can appear in a DNS database; otherwise, false.</returns>
		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001FA4 RID: 8100
		public abstract bool IsDnsEligible { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the Internet Protocol (IP) address is transient (a cluster address).</summary>
		/// <returns>true if the address is transient; otherwise, false.</returns>
		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001FA5 RID: 8101
		public abstract bool IsTransient { get; }
	}
}
