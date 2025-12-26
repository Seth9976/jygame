using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.IO.Ports
{
	// Token: 0x020002AF RID: 687
	internal class WinSerialStream : Stream, IDisposable, ISerialStream
	{
		// Token: 0x060017C0 RID: 6080 RVA: 0x00049294 File Offset: 0x00047494
		public WinSerialStream(string port_name, int baud_rate, int data_bits, Parity parity, StopBits sb, bool dtr_enable, bool rts_enable, Handshake hs, int read_timeout, int write_timeout, int read_buffer_size, int write_buffer_size)
		{
			this.handle = WinSerialStream.CreateFile(port_name, 3221225472U, 0U, 0U, 3U, 1073741824U, 0U);
			if (this.handle == -1)
			{
				this.ReportIOError(port_name);
			}
			this.SetAttributes(baud_rate, parity, data_bits, sb, hs);
			if (!WinSerialStream.PurgeComm(this.handle, 12U) || !WinSerialStream.SetupComm(this.handle, read_buffer_size, write_buffer_size))
			{
				this.ReportIOError(null);
			}
			this.read_timeout = read_timeout;
			this.write_timeout = write_timeout;
			this.timeouts = new Timeouts(read_timeout, write_timeout);
			if (!WinSerialStream.SetCommTimeouts(this.handle, this.timeouts))
			{
				this.ReportIOError(null);
			}
			this.SetSignal(SerialSignal.Dtr, dtr_enable);
			if (hs != Handshake.RequestToSend && hs != Handshake.RequestToSendXOnXOff)
			{
				this.SetSignal(SerialSignal.Rts, rts_enable);
			}
			NativeOverlapped nativeOverlapped = default(NativeOverlapped);
			this.write_event = new ManualResetEvent(false);
			nativeOverlapped.EventHandle = this.write_event.Handle;
			this.write_overlapped = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(NativeOverlapped)));
			Marshal.StructureToPtr(nativeOverlapped, this.write_overlapped, true);
			NativeOverlapped nativeOverlapped2 = default(NativeOverlapped);
			this.read_event = new ManualResetEvent(false);
			nativeOverlapped2.EventHandle = this.read_event.Handle;
			this.read_overlapped = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(NativeOverlapped)));
			Marshal.StructureToPtr(nativeOverlapped2, this.read_overlapped, true);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00011B8D File Offset: 0x0000FD8D
		void IDisposable.Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060017C2 RID: 6082
		[DllImport("kernel32", SetLastError = true)]
		private static extern int CreateFile(string port_name, uint desired_access, uint share_mode, uint security_attrs, uint creation, uint flags, uint template);

		// Token: 0x060017C3 RID: 6083
		[DllImport("kernel32", SetLastError = true)]
		private static extern bool SetupComm(int handle, int read_buffer_size, int write_buffer_size);

		// Token: 0x060017C4 RID: 6084
		[DllImport("kernel32", SetLastError = true)]
		private static extern bool PurgeComm(int handle, uint flags);

		// Token: 0x060017C5 RID: 6085
		[DllImport("kernel32", SetLastError = true)]
		private static extern bool SetCommTimeouts(int handle, Timeouts timeouts);

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool CanTimeout
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x00011B9C File Offset: 0x0000FD9C
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x00049414 File Offset: 0x00047614
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
				this.timeouts.SetValues(value, this.write_timeout);
				if (!WinSerialStream.SetCommTimeouts(this.handle, this.timeouts))
				{
					this.ReportIOError(null);
				}
				this.read_timeout = value;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x00011BA4 File Offset: 0x0000FDA4
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x00049470 File Offset: 0x00047670
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
				this.timeouts.SetValues(this.read_timeout, value);
				if (!WinSerialStream.SetCommTimeouts(this.handle, this.timeouts))
				{
					this.ReportIOError(null);
				}
				this.write_timeout = value;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x00006A38 File Offset: 0x00004C38
		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x00006A38 File Offset: 0x00004C38
		// (set) Token: 0x060017D0 RID: 6096 RVA: 0x00006A38 File Offset: 0x00004C38
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

		// Token: 0x060017D1 RID: 6097
		[DllImport("kernel32", SetLastError = true)]
		private static extern bool CloseHandle(int handle);

		// Token: 0x060017D2 RID: 6098 RVA: 0x00011BAC File Offset: 0x0000FDAC
		protected override void Dispose(bool disposing)
		{
			if (this.disposed)
			{
				return;
			}
			this.disposed = true;
			WinSerialStream.CloseHandle(this.handle);
			Marshal.FreeHGlobal(this.write_overlapped);
			Marshal.FreeHGlobal(this.read_overlapped);
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00011AE6 File Offset: 0x0000FCE6
		public override void Close()
		{
			((IDisposable)this).Dispose();
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x000494CC File Offset: 0x000476CC
		~WinSerialStream()
		{
			this.Dispose(false);
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00011BE3 File Offset: 0x0000FDE3
		public override void Flush()
		{
			this.CheckDisposed();
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00006A38 File Offset: 0x00004C38
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00006A38 File Offset: 0x00004C38
		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060017D8 RID: 6104
		[DllImport("kernel32", SetLastError = true)]
		private unsafe static extern bool ReadFile(int handle, byte* buffer, int bytes_to_read, out int bytes_read, IntPtr overlapped);

		// Token: 0x060017D9 RID: 6105
		[DllImport("kernel32", SetLastError = true)]
		private static extern bool GetOverlappedResult(int handle, IntPtr overlapped, ref int bytes_transfered, bool wait);

		// Token: 0x060017DA RID: 6106 RVA: 0x000494FC File Offset: 0x000476FC
		public unsafe override int Read([In] [Out] byte[] buffer, int offset, int count)
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
			fixed (byte* ptr = (ref buffer != null && buffer.Length != 0 ? ref buffer[0] : ref *null))
			{
				if (WinSerialStream.ReadFile(this.handle, ptr + offset, count, out num, this.read_overlapped))
				{
					return num;
				}
				if ((long)Marshal.GetLastWin32Error() != 997L)
				{
					this.ReportIOError(null);
				}
				if (!WinSerialStream.GetOverlappedResult(this.handle, this.read_overlapped, ref num, true))
				{
					this.ReportIOError(null);
				}
			}
			if (num == 0)
			{
				throw new TimeoutException();
			}
			return num;
		}

		// Token: 0x060017DB RID: 6107
		[DllImport("kernel32", SetLastError = true)]
		private unsafe static extern bool WriteFile(int handle, byte* buffer, int bytes_to_write, out int bytes_written, IntPtr overlapped);

		// Token: 0x060017DC RID: 6108 RVA: 0x000495D8 File Offset: 0x000477D8
		public unsafe override void Write(byte[] buffer, int offset, int count)
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
			int num = 0;
			fixed (byte* ptr = (ref buffer != null && buffer.Length != 0 ? ref buffer[0] : ref *null))
			{
				if (WinSerialStream.WriteFile(this.handle, ptr + offset, count, out num, this.write_overlapped))
				{
					return;
				}
				if ((long)Marshal.GetLastWin32Error() != 997L)
				{
					this.ReportIOError(null);
				}
				if (!WinSerialStream.GetOverlappedResult(this.handle, this.write_overlapped, ref num, true))
				{
					this.ReportIOError(null);
				}
			}
			if (num < count)
			{
				throw new TimeoutException();
			}
		}

		// Token: 0x060017DD RID: 6109
		[DllImport("kernel32", SetLastError = true)]
		private static extern bool GetCommState(int handle, [Out] DCB dcb);

		// Token: 0x060017DE RID: 6110
		[DllImport("kernel32", SetLastError = true)]
		private static extern bool SetCommState(int handle, DCB dcb);

		// Token: 0x060017DF RID: 6111 RVA: 0x000496B0 File Offset: 0x000478B0
		public void SetAttributes(int baud_rate, Parity parity, int data_bits, StopBits bits, Handshake hs)
		{
			DCB dcb = new DCB();
			if (!WinSerialStream.GetCommState(this.handle, dcb))
			{
				this.ReportIOError(null);
			}
			dcb.SetValues(baud_rate, parity, data_bits, bits, hs);
			if (!WinSerialStream.SetCommState(this.handle, dcb))
			{
				this.ReportIOError(null);
			}
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00049700 File Offset: 0x00047900
		private void ReportIOError(string optional_arg)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			int num = lastWin32Error;
			string text;
			if (num != 2 && num != 3)
			{
				if (num != 87)
				{
					text = new global::System.ComponentModel.Win32Exception().Message;
				}
				else
				{
					text = "Parameter is incorrect.";
				}
			}
			else
			{
				text = "The port `" + optional_arg + "' does not exist.";
			}
			throw new IOException(text);
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00011BEB File Offset: 0x0000FDEB
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00011C09 File Offset: 0x0000FE09
		public void DiscardInBuffer()
		{
			if (!WinSerialStream.PurgeComm(this.handle, 4U))
			{
				this.ReportIOError(null);
			}
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00011C09 File Offset: 0x0000FE09
		public void DiscardOutBuffer()
		{
			if (!WinSerialStream.PurgeComm(this.handle, 4U))
			{
				this.ReportIOError(null);
			}
		}

		// Token: 0x060017E4 RID: 6116
		[DllImport("kernel32", SetLastError = true)]
		private static extern bool ClearCommError(int handle, out uint errors, out CommStat stat);

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060017E5 RID: 6117 RVA: 0x00049768 File Offset: 0x00047968
		public int BytesToRead
		{
			get
			{
				uint num;
				CommStat commStat;
				if (!WinSerialStream.ClearCommError(this.handle, out num, out commStat))
				{
					this.ReportIOError(null);
				}
				return (int)commStat.BytesIn;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00049798 File Offset: 0x00047998
		public int BytesToWrite
		{
			get
			{
				uint num;
				CommStat commStat;
				if (!WinSerialStream.ClearCommError(this.handle, out num, out commStat))
				{
					this.ReportIOError(null);
				}
				return (int)commStat.BytesOut;
			}
		}

		// Token: 0x060017E7 RID: 6119
		[DllImport("kernel32", SetLastError = true)]
		private static extern bool GetCommModemStatus(int handle, out uint flags);

		// Token: 0x060017E8 RID: 6120 RVA: 0x000497C8 File Offset: 0x000479C8
		public SerialSignal GetSignals()
		{
			uint num;
			if (!WinSerialStream.GetCommModemStatus(this.handle, out num))
			{
				this.ReportIOError(null);
			}
			SerialSignal serialSignal = SerialSignal.None;
			if ((num & 128U) != 0U)
			{
				serialSignal |= SerialSignal.Cd;
			}
			if ((num & 16U) != 0U)
			{
				serialSignal |= SerialSignal.Cts;
			}
			if ((num & 32U) != 0U)
			{
				serialSignal |= SerialSignal.Dsr;
			}
			return serialSignal;
		}

		// Token: 0x060017E9 RID: 6121
		[DllImport("kernel32", SetLastError = true)]
		private static extern bool EscapeCommFunction(int handle, uint flags);

		// Token: 0x060017EA RID: 6122 RVA: 0x0004981C File Offset: 0x00047A1C
		public void SetSignal(SerialSignal signal, bool value)
		{
			if (signal != SerialSignal.Rts && signal != SerialSignal.Dtr)
			{
				throw new Exception("Wrong internal value");
			}
			uint num;
			if (signal == SerialSignal.Rts)
			{
				if (value)
				{
					num = 3U;
				}
				else
				{
					num = 4U;
				}
			}
			else if (value)
			{
				num = 5U;
			}
			else
			{
				num = 6U;
			}
			if (!WinSerialStream.EscapeCommFunction(this.handle, num))
			{
				this.ReportIOError(null);
			}
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00011C23 File Offset: 0x0000FE23
		public void SetBreakState(bool value)
		{
			if (!WinSerialStream.EscapeCommFunction(this.handle, (!value) ? 9U : 8U))
			{
				this.ReportIOError(null);
			}
		}

		// Token: 0x04000EE8 RID: 3816
		private const uint GenericRead = 2147483648U;

		// Token: 0x04000EE9 RID: 3817
		private const uint GenericWrite = 1073741824U;

		// Token: 0x04000EEA RID: 3818
		private const uint OpenExisting = 3U;

		// Token: 0x04000EEB RID: 3819
		private const uint FileFlagOverlapped = 1073741824U;

		// Token: 0x04000EEC RID: 3820
		private const uint PurgeRxClear = 4U;

		// Token: 0x04000EED RID: 3821
		private const uint PurgeTxClear = 8U;

		// Token: 0x04000EEE RID: 3822
		private const uint WinInfiniteTimeout = 4294967295U;

		// Token: 0x04000EEF RID: 3823
		private const uint FileIOPending = 997U;

		// Token: 0x04000EF0 RID: 3824
		private const uint SetRts = 3U;

		// Token: 0x04000EF1 RID: 3825
		private const uint ClearRts = 4U;

		// Token: 0x04000EF2 RID: 3826
		private const uint SetDtr = 5U;

		// Token: 0x04000EF3 RID: 3827
		private const uint ClearDtr = 6U;

		// Token: 0x04000EF4 RID: 3828
		private const uint SetBreak = 8U;

		// Token: 0x04000EF5 RID: 3829
		private const uint ClearBreak = 9U;

		// Token: 0x04000EF6 RID: 3830
		private const uint CtsOn = 16U;

		// Token: 0x04000EF7 RID: 3831
		private const uint DsrOn = 32U;

		// Token: 0x04000EF8 RID: 3832
		private const uint RsldOn = 128U;

		// Token: 0x04000EF9 RID: 3833
		private const uint EvRxChar = 1U;

		// Token: 0x04000EFA RID: 3834
		private const uint EvCts = 8U;

		// Token: 0x04000EFB RID: 3835
		private const uint EvDsr = 16U;

		// Token: 0x04000EFC RID: 3836
		private const uint EvRlsd = 32U;

		// Token: 0x04000EFD RID: 3837
		private const uint EvBreak = 64U;

		// Token: 0x04000EFE RID: 3838
		private const uint EvErr = 128U;

		// Token: 0x04000EFF RID: 3839
		private const uint EvRing = 256U;

		// Token: 0x04000F00 RID: 3840
		private int handle;

		// Token: 0x04000F01 RID: 3841
		private int read_timeout;

		// Token: 0x04000F02 RID: 3842
		private int write_timeout;

		// Token: 0x04000F03 RID: 3843
		private bool disposed;

		// Token: 0x04000F04 RID: 3844
		private IntPtr write_overlapped;

		// Token: 0x04000F05 RID: 3845
		private IntPtr read_overlapped;

		// Token: 0x04000F06 RID: 3846
		private ManualResetEvent read_event;

		// Token: 0x04000F07 RID: 3847
		private ManualResetEvent write_event;

		// Token: 0x04000F08 RID: 3848
		private Timeouts timeouts;
	}
}
