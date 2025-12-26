using System;

namespace System.IO.Ports
{
	/// <summary>Specifies the type of change that occurred on the <see cref="T:System.IO.Ports.SerialPort" /> object.</summary>
	// Token: 0x020002A8 RID: 680
	public enum SerialPinChange
	{
		/// <summary>The Clear to Send (CTS) signal changed state. This signal is used to indicate whether data can be sent over the serial port.</summary>
		// Token: 0x04000EB6 RID: 3766
		CtsChanged = 8,
		/// <summary>The Data Set Ready (DSR) signal changed state. This signal is used to indicate whether the device on the serial port is ready to operate.</summary>
		// Token: 0x04000EB7 RID: 3767
		DsrChanged = 16,
		/// <summary>The Carrier Detect (CD) signal changed state. This signal is used to indicate whether a modem is connected to a working phone line and a data carrier signal is detected.</summary>
		// Token: 0x04000EB8 RID: 3768
		CDChanged = 32,
		/// <summary>A break was detected on input.</summary>
		// Token: 0x04000EB9 RID: 3769
		Break = 64,
		/// <summary>A ring indicator was detected.</summary>
		// Token: 0x04000EBA RID: 3770
		Ring = 256
	}
}
