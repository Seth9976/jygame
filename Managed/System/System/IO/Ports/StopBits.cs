using System;

namespace System.IO.Ports
{
	/// <summary>Specifies the number of stop bits used on the <see cref="T:System.IO.Ports.SerialPort" /> object.</summary>
	// Token: 0x020002AE RID: 686
	public enum StopBits
	{
		/// <summary>No stop bits are used. This value is not supported. Setting the <see cref="P:System.IO.Ports.SerialPort.StopBits" /> property to <see cref="F:System.IO.Ports.StopBits.None" /> raises an <see cref="T:System.ArgumentOutOfRangeException" />.</summary>
		// Token: 0x04000EE4 RID: 3812
		None,
		/// <summary>One stop bit is used.</summary>
		// Token: 0x04000EE5 RID: 3813
		One,
		/// <summary>Two stop bits are used.</summary>
		// Token: 0x04000EE6 RID: 3814
		Two,
		/// <summary>1.5 stop bits are used.</summary>
		// Token: 0x04000EE7 RID: 3815
		OnePointFive
	}
}
