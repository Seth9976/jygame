using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Allows applications to receive notification when the Internet Protocol (IP) address of a network interface, also called a network card or adapter, changes.</summary>
	// Token: 0x020003BA RID: 954
	public sealed class NetworkChange
	{
		// Token: 0x060020ED RID: 8429 RVA: 0x000021C3 File Offset: 0x000003C3
		private NetworkChange()
		{
		}

		/// <summary>Occurs when the IP address of a network interface changes.</summary>
		// Token: 0x1400004F RID: 79
		// (add) Token: 0x060020EE RID: 8430 RVA: 0x00017978 File Offset: 0x00015B78
		// (remove) Token: 0x060020EF RID: 8431 RVA: 0x0001798F File Offset: 0x00015B8F
		public static event NetworkAddressChangedEventHandler NetworkAddressChanged;

		/// <summary>Occurs when the availability of the network changes.</summary>
		// Token: 0x14000050 RID: 80
		// (add) Token: 0x060020F0 RID: 8432 RVA: 0x000179A6 File Offset: 0x00015BA6
		// (remove) Token: 0x060020F1 RID: 8433 RVA: 0x000179BD File Offset: 0x00015BBD
		public static event NetworkAvailabilityChangedEventHandler NetworkAvailabilityChanged;
	}
}
