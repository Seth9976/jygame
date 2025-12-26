using System;
using System.Runtime.InteropServices;

namespace System.IO.Ports
{
	// Token: 0x020002AB RID: 683
	internal class SerialPortStream : Stream, IDisposable, ISerialStream
	{
		// Token: 0x06001793 RID: 6035 RVA: 0x00049034 File Offset: 0x00047234
		public SerialPortStream(string portName, int baudRate, int dataBits, Parity parity, StopBits stopBits, bool dtrEnable, bool rtsEnable, Handshake handshake, int readTimeout, int writeTimeout, int readBufferSize, int writeBufferSize)
		{
			this.fd = SerialPortStream.open_serial(portName);
			if (this.fd == -1)
			{
				SerialPortStream.ThrowIOException();
			}
			if (!SerialPortStream.set_attributes(this.fd, baudRate, parity, dataBits, stopBits, handshake))
			{
				SerialPortStream.ThrowIOException();
			}
			this.read_timeout = readTimeout;
			this.write_timeout = writeTimeout;
			this.SetSignal(SerialSignal.Dtr, dtrEnable);
			if (handshake != Handshake.RequestToSend && handshake != Handshake.RequestToSendXOnXOff)
			{
				this.SetSignal(SerialSignal.Rts, rtsEnable);
			}
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00011A59 File Offset: 0x0000FC59
		void IDisposable.Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001795 RID: 6037
		[DllImport("MonoPosixHelper", SetLastError = true)]
		private static extern int open_serial(string portName);

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool CanTimeout
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x00011A68 File Offset: 0x0000FC68
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x00011A70 File Offset: 0x0000FC70
		public override int ReadTimeout
		{
			get
			{
				return this.read_timeout;
			}
			set
			{
				if (value < 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.read_timeout = value;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x00011A92 File Offset: 0x0000FC92
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x00011A9A File Offset: 0x0000FC9A
		public override int WriteTimeout
		{
			get
			{
				return this.write_timeout;
			}
			set
			{
				if (value < 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.write_timeout = value;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00006A38 File Offset: 0x00004C38
		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x00006A38 File Offset: 0x00004C38
		// (set) Token: 0x060017A0 RID: 6048 RVA: 0x00006A38 File Offset: 0x00004C38
		public override long Position
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void Flush()
		{
		}

		// Token: 0x060017A2 RID: 6050
		[DllImport("MonoPosixHelper", SetLastError = true)]
		private static extern int read_serial(int fd, byte[] buffer, int offset, int count);

		// Token: 0x060017A3 RID: 6051
		[DllImport("MonoPosixHelper", SetLastError = true)]
		private static extern bool poll_serial(int fd, out int error, int timeout);

		// Token: 0x060017A4 RID: 6052 RVA: 0x000490B4 File Offset: 0x000472B4
		public override int Read([In] [Out] byte[] buffer, int offset, int count)
		{
			this.CheckDisposed();
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException("offset or count less than zero.");
			}
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("offset+count", "The size of the buffer is less than offset + count.");
			}
			int num;
			bool flag = SerialPortStream.poll_serial(this.fd, out num, this.read_timeout);
			if (num == -1)
			{
				SerialPortStream.ThrowIOException();
			}
			if (!flag)
			{
				throw new TimeoutException();
			}
			return SerialPortStream.read_serial(this.fd, buffer, offset, count);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00006A38 File Offset: 0x00004C38
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00006A38 File Offset: 0x00004C38
		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060017A7 RID: 6055
		[DllImport("MonoPosixHelper", SetLastError = true)]
		private static extern int write_serial(int fd, byte[] buffer, int offset, int count, int timeout);

		// Token: 0x060017A8 RID: 6056 RVA: 0x00049148 File Offset: 0x00047348
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.CheckDisposed();
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("offset+count", "The size of the buffer is less than offset + count.");
			}
			if (SerialPortStream.write_serial(this.fd, buffer, offset, count, this.write_timeout) < 0)
			{
				throw new TimeoutException("The operation has timed-out");
			}
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00011ABC File Offset: 0x0000FCBC
		protected override void Dispose(bool disposing)
		{
			if (this.disposed)
			{
				return;
			}
			this.disposed = true;
			if (SerialPortStream.close_serial(this.fd) != 0)
			{
				SerialPortStream.ThrowIOException();
			}
		}

		// Token: 0x060017AA RID: 6058
		[DllImport("MonoPosixHelper", SetLastError = true)]
		private static extern int close_serial(int fd);

		// Token: 0x060017AB RID: 6059 RVA: 0x00011AE6 File Offset: 0x0000FCE6
		public override void Close()
		{
			((IDisposable)this).Dispose();
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x000491C0 File Offset: 0x000473C0
		~SerialPortStream()
		{
			this.Dispose(false);
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x00011AEE File Offset: 0x0000FCEE
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		// Token: 0x060017AE RID: 6062
		[DllImport("MonoPosixHelper", SetLastError = true)]
		private static extern bool set_attributes(int fd, int baudRate, Parity parity, int dataBits, StopBits stopBits, Handshake handshake);

		// Token: 0x060017AF RID: 6063 RVA: 0x00011B0C File Offset: 0x0000FD0C
		public void SetAttributes(int baud_rate, Parity parity, int data_bits, StopBits sb, Handshake hs)
		{
			if (!SerialPortStream.set_attributes(this.fd, baud_rate, parity, data_bits, sb, hs))
			{
				SerialPortStream.ThrowIOException();
			}
		}

		// Token: 0x060017B0 RID: 6064
		[DllImport("MonoPosixHelper", SetLastError = true)]
		private static extern int get_bytes_in_buffer(int fd, int input);

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x00011B2A File Offset: 0x0000FD2A
		public int BytesToRead
		{
			get
			{
				return SerialPortStream.get_bytes_in_buffer(this.fd, 1);
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x00011B38 File Offset: 0x0000FD38
		public int BytesToWrite
		{
			get
			{
				return SerialPortStream.get_bytes_in_buffer(this.fd, 0);
			}
		}

		// Token: 0x060017B3 RID: 6067
		[DllImport("MonoPosixHelper", SetLastError = true)]
		private static extern void discard_buffer(int fd, bool inputBuffer);

		// Token: 0x060017B4 RID: 6068 RVA: 0x00011B46 File Offset: 0x0000FD46
		public void DiscardInBuffer()
		{
			SerialPortStream.discard_buffer(this.fd, true);
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x00011B54 File Offset: 0x0000FD54
		public void DiscardOutBuffer()
		{
			SerialPortStream.discard_buffer(this.fd, false);
		}

		// Token: 0x060017B6 RID: 6070
		[DllImport("MonoPosixHelper", SetLastError = true)]
		private static extern SerialSignal get_signals(int fd, out int error);

		// Token: 0x060017B7 RID: 6071 RVA: 0x000491F0 File Offset: 0x000473F0
		public SerialSignal GetSignals()
		{
			int num;
			SerialSignal serialSignal = SerialPortStream.get_signals(this.fd, out num);
			if (num == -1)
			{
				SerialPortStream.ThrowIOException();
			}
			return serialSignal;
		}

		// Token: 0x060017B8 RID: 6072
		[DllImport("MonoPosixHelper", SetLastError = true)]
		private static extern int set_signal(int fd, SerialSignal signal, bool value);

		// Token: 0x060017B9 RID: 6073 RVA: 0x00049218 File Offset: 0x00047418
		public void SetSignal(SerialSignal signal, bool value)
		{
			if (signal < SerialSignal.Cd || signal > SerialSignal.Rts || signal == SerialSignal.Cd || signal == SerialSignal.Cts || signal == SerialSignal.Dsr)
			{
				throw new Exception("Invalid internal value");
			}
			if (SerialPortStream.set_signal(this.fd, signal, value) == -1)
			{
				SerialPortStream.ThrowIOException();
			}
		}

		// Token: 0x060017BA RID: 6074
		[DllImport("MonoPosixHelper", SetLastError = true)]
		private static extern int breakprop(int fd);

		// Token: 0x060017BB RID: 6075 RVA: 0x00011B62 File Offset: 0x0000FD62
		public void SetBreakState(bool value)
		{
			if (value)
			{
				SerialPortStream.breakprop(this.fd);
			}
		}

		// Token: 0x060017BC RID: 6076
		[DllImport("libc")]
		private static extern IntPtr strerror(int errnum);

		// Token: 0x060017BD RID: 6077 RVA: 0x0004926C File Offset: 0x0004746C
		private static void ThrowIOException()
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			string text = Marshal.PtrToStringAnsi(SerialPortStream.strerror(lastWin32Error));
			throw new IOException(text);
		}

		// Token: 0x04000ED7 RID: 3799
		private int fd;

		// Token: 0x04000ED8 RID: 3800
		private int read_timeout;

		// Token: 0x04000ED9 RID: 3801
		private int write_timeout;

		// Token: 0x04000EDA RID: 3802
		private bool disposed;
	}
}
