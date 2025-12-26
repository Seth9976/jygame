using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Provides data for the <see cref="E:System.Net.NetworkInformation.NetworkChange.NetworkAvailabilityChanged" /> event.</summary>
	// Token: 0x020003B9 RID: 953
	public class NetworkAvailabilityEventArgs : EventArgs
	{
		// Token: 0x060020EB RID: 8427 RVA: 0x00017961 File Offset: 0x00015B61
		internal NetworkAvailabilityEventArgs(bool available)
		{
			this.available = available;
		}

		/// <summary>Gets the current status of the network connection.</summary>
		/// <returns>true if the network is available; otherwise, false.</returns>
		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x060020EC RID: 8428 RVA: 0x00017970 File Offset: 0x00015B70
		public bool IsAvailable
		{
			get
			{
				return this.available;
			}
		}

		// Token: 0x040013E9 RID: 5097
		private bool available;
	}
}
