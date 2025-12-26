using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Provides information about network interfaces that support Internet Protocol version 6 (IPv6).</summary>
	// Token: 0x020003A4 RID: 932
	public abstract class IPv6InterfaceProperties
	{
		/// <summary>Gets the index of the network interface associated with the Internet Protocol version 6 (IPv6) address.</summary>
		/// <returns>An <see cref="T:System.Int32" /> value that contains the index of the IPv6 interface.</returns>
		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060020C5 RID: 8389
		public abstract int Index { get; }

		/// <summary>Gets the maximum transmission unit (MTU) for this network interface.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the MTU.</returns>
		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x060020C6 RID: 8390
		public abstract int Mtu { get; }
	}
}
