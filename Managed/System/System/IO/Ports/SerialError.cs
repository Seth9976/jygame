using System;

namespace System.IO.Ports
{
	/// <summary>Specifies errors that occur on the <see cref="T:System.IO.Ports.SerialPort" /> object</summary>
	// Token: 0x020002A6 RID: 678
	public enum SerialError
	{
		/// <summary>An input buffer overflow has occurred. There is either no room in the input buffer, or a character was received after the end-of-file (EOF) character.</summary>
		// Token: 0x04000EAF RID: 3759
		RXOver = 1,
		/// <summary>A character-buffer overrun has occurred. The next character is lost.</summary>
		// Token: 0x04000EB0 RID: 3760
		Overrun,
		/// <summary>The hardware detected a parity error.</summary>
		// Token: 0x04000EB1 RID: 3761
		RXParity = 4,
		/// <summary>The hardware detected a framing error.</summary>
		// Token: 0x04000EB2 RID: 3762
		Frame = 8,
		/// <summary>The application tried to transmit a character, but the output buffer was full.</summary>
		// Token: 0x04000EB3 RID: 3763
		TXFull = 256
	}
}
