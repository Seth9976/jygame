using System;

namespace System.IO.Ports
{
	/// <summary>Provides data for the <see cref="E:System.IO.Ports.SerialPort.DataReceived" /> event.</summary>
	// Token: 0x020002AC RID: 684
	public class SerialDataReceivedEventArgs : EventArgs
	{
		// Token: 0x060017BE RID: 6078 RVA: 0x00011B76 File Offset: 0x0000FD76
		internal SerialDataReceivedEventArgs(SerialData eventType)
		{
			this.eventType = eventType;
		}

		/// <summary>Gets or sets the event type.</summary>
		/// <returns>One of the <see cref="T:System.IO.Ports.SerialData" /> values.</returns>
		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x00011B85 File Offset: 0x0000FD85
		public SerialData EventType
		{
			get
			{
				return this.eventType;
			}
		}

		// Token: 0x04000EDB RID: 3803
		private SerialData eventType;
	}
}
