using System;

namespace System.IO.Ports
{
	/// <summary>Provides data for the <see cref="E:System.IO.Ports.SerialPort.PinChanged" /> event.</summary>
	// Token: 0x020002A9 RID: 681
	public class SerialPinChangedEventArgs : EventArgs
	{
		// Token: 0x06001741 RID: 5953 RVA: 0x000115EA File Offset: 0x0000F7EA
		internal SerialPinChangedEventArgs(SerialPinChange eventType)
		{
			this.eventType = eventType;
		}

		/// <summary>Gets or sets the event type.</summary>
		/// <returns>One of the <see cref="T:System.IO.Ports.SerialPinChange" /> values.</returns>
		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x000115F9 File Offset: 0x0000F7F9
		public SerialPinChange EventType
		{
			get
			{
				return this.eventType;
			}
		}

		// Token: 0x04000EBB RID: 3771
		private SerialPinChange eventType;
	}
}
