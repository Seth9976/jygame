using System;
using System.Runtime.InteropServices;

namespace System.IO.Ports
{
	// Token: 0x020002B0 RID: 688
	[StructLayout(LayoutKind.Sequential)]
	internal class DCB
	{
		// Token: 0x060017ED RID: 6125 RVA: 0x00049888 File Offset: 0x00047A88
		public void SetValues(int baud_rate, Parity parity, int byte_size, StopBits sb, Handshake hs)
		{
			switch (sb)
			{
			case StopBits.One:
				this.stop_bits = 0;
				break;
			case StopBits.Two:
				this.stop_bits = 2;
				break;
			case StopBits.OnePointFive:
				this.stop_bits = 1;
				break;
			}
			this.baud_rate = baud_rate;
			this.parity = (byte)parity;
			this.byte_size = (byte)byte_size;
			this.flags &= -8965;
			switch (hs)
			{
			case Handshake.XOnXOff:
				this.flags |= 768;
				break;
			case Handshake.RequestToSend:
				this.flags |= 8196;
				break;
			case Handshake.RequestToSendXOnXOff:
				this.flags |= 8964;
				break;
			}
		}

		// Token: 0x04000F09 RID: 3849
		private const int fOutxCtsFlow = 4;

		// Token: 0x04000F0A RID: 3850
		private const int fOutX = 256;

		// Token: 0x04000F0B RID: 3851
		private const int fInX = 512;

		// Token: 0x04000F0C RID: 3852
		private const int fRtsControl2 = 8192;

		// Token: 0x04000F0D RID: 3853
		public int dcb_length;

		// Token: 0x04000F0E RID: 3854
		public int baud_rate;

		// Token: 0x04000F0F RID: 3855
		public int flags;

		// Token: 0x04000F10 RID: 3856
		public short w_reserved;

		// Token: 0x04000F11 RID: 3857
		public short xon_lim;

		// Token: 0x04000F12 RID: 3858
		public short xoff_lim;

		// Token: 0x04000F13 RID: 3859
		public byte byte_size;

		// Token: 0x04000F14 RID: 3860
		public byte parity;

		// Token: 0x04000F15 RID: 3861
		public byte stop_bits;

		// Token: 0x04000F16 RID: 3862
		public byte xon_char;

		// Token: 0x04000F17 RID: 3863
		public byte xoff_char;

		// Token: 0x04000F18 RID: 3864
		public byte error_char;

		// Token: 0x04000F19 RID: 3865
		public byte eof_char;

		// Token: 0x04000F1A RID: 3866
		public byte evt_char;

		// Token: 0x04000F1B RID: 3867
		public short w_reserved1;
	}
}
