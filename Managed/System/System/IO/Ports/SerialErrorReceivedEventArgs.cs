using System;

namespace System.IO.Ports
{
	/// <summary>Prepares data for the <see cref="E:System.IO.Ports.SerialPort.ErrorReceived" /> event.</summary>
	// Token: 0x020002A7 RID: 679
	public class SerialErrorReceivedEventArgs : EventArgs
	{
		// Token: 0x0600173F RID: 5951 RVA: 0x000115D3 File Offset: 0x0000F7D3
		internal SerialErrorReceivedEventArgs(SerialError eventType)
		{
			this.eventType = eventType;
		}

		/// <summary>Gets or sets the event type.</summary>
		/// <returns>One of the <see cref="T:System.IO.Ports.SerialError" /> values.</returns>
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x000115E2 File Offset: 0x0000F7E2
		public SerialError EventType
		{
			get
			{
				return this.eventType;
			}
		}

		// Token: 0x04000EB4 RID: 3764
		private SerialError eventType;
	}
}
