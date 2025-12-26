using System;
using System.Runtime.InteropServices;

namespace System.IO.Ports
{
	// Token: 0x020002B1 RID: 689
	[StructLayout(LayoutKind.Sequential)]
	internal class Timeouts
	{
		// Token: 0x060017EE RID: 6126 RVA: 0x00011C4A File Offset: 0x0000FE4A
		public Timeouts(int read_timeout, int write_timeout)
		{
			this.SetValues(read_timeout, write_timeout);
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00011C5A File Offset: 0x0000FE5A
		public void SetValues(int read_timeout, int write_timeout)
		{
			this.ReadIntervalTimeout = uint.MaxValue;
			this.ReadTotalTimeoutMultiplier = uint.MaxValue;
			this.ReadTotalTimeoutConstant = (uint)((read_timeout != -1) ? read_timeout : (-2));
			this.WriteTotalTimeoutMultiplier = 0U;
			this.WriteTotalTimeoutConstant = (uint)((write_timeout != -1) ? write_timeout : (-1));
		}

		// Token: 0x04000F1C RID: 3868
		public const uint MaxDWord = 4294967295U;

		// Token: 0x04000F1D RID: 3869
		public uint ReadIntervalTimeout;

		// Token: 0x04000F1E RID: 3870
		public uint ReadTotalTimeoutMultiplier;

		// Token: 0x04000F1F RID: 3871
		public uint ReadTotalTimeoutConstant;

		// Token: 0x04000F20 RID: 3872
		public uint WriteTotalTimeoutMultiplier;

		// Token: 0x04000F21 RID: 3873
		public uint WriteTotalTimeoutConstant;
	}
}
