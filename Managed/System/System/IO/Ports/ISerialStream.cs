using System;

namespace System.IO.Ports
{
	// Token: 0x020002A3 RID: 675
	internal interface ISerialStream : IDisposable
	{
		// Token: 0x06001730 RID: 5936
		int Read(byte[] buffer, int offset, int count);

		// Token: 0x06001731 RID: 5937
		void Write(byte[] buffer, int offset, int count);

		// Token: 0x06001732 RID: 5938
		void SetAttributes(int baud_rate, Parity parity, int data_bits, StopBits sb, Handshake hs);

		// Token: 0x06001733 RID: 5939
		void DiscardInBuffer();

		// Token: 0x06001734 RID: 5940
		void DiscardOutBuffer();

		// Token: 0x06001735 RID: 5941
		SerialSignal GetSignals();

		// Token: 0x06001736 RID: 5942
		void SetSignal(SerialSignal signal, bool value);

		// Token: 0x06001737 RID: 5943
		void SetBreakState(bool value);

		// Token: 0x06001738 RID: 5944
		void Close();

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001739 RID: 5945
		int BytesToRead { get; }

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600173A RID: 5946
		int BytesToWrite { get; }

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600173B RID: 5947
		// (set) Token: 0x0600173C RID: 5948
		int ReadTimeout { get; set; }

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600173D RID: 5949
		// (set) Token: 0x0600173E RID: 5950
		int WriteTimeout { get; set; }
	}
}
