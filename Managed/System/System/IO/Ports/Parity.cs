using System;

namespace System.IO.Ports
{
	/// <summary>Specifies the parity bit for a <see cref="T:System.IO.Ports.SerialPort" /> object.</summary>
	// Token: 0x020002A4 RID: 676
	public enum Parity
	{
		/// <summary>No parity check occurs.</summary>
		// Token: 0x04000EA6 RID: 3750
		None,
		/// <summary>Sets the parity bit so that the count of bits set is an odd number.</summary>
		// Token: 0x04000EA7 RID: 3751
		Odd,
		/// <summary>Sets the parity bit so that the count of bits set is an even number.</summary>
		// Token: 0x04000EA8 RID: 3752
		Even,
		/// <summary>Leaves the parity bit set to 1.</summary>
		// Token: 0x04000EA9 RID: 3753
		Mark,
		/// <summary>Leaves the parity bit set to 0.</summary>
		// Token: 0x04000EAA RID: 3754
		Space
	}
}
