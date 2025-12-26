using System;
using System.Collections.Generic;
using System.Threading;

namespace System.Net.Sockets
{
	/// <summary>Represents an asynchronous socket operation.</summary>
	// Token: 0x02000419 RID: 1049
	public class SocketAsyncEventArgs : EventArgs, IDisposable
	{
		/// <summary>Creates an empty <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> instance.</summary>
		/// <exception cref="T:System.NotSupportedException">The platform is not supported. </exception>
		// Token: 0x0600246B RID: 9323 RVA: 0x0006AE1C File Offset: 0x0006901C
		public SocketAsyncEventArgs()
		{
			this.AcceptSocket = null;
			this.Buffer = null;
			this.BufferList = null;
			this.BytesTransferred = 0;
			this.Count = 0;
			this.DisconnectReuseSocket = false;
			this.LastOperation = SocketAsyncOperation.None;
			this.Offset = 0;
			this.RemoteEndPoint = null;
			this.SendPacketsElements = null;
			this.SendPacketsFlags = TransmitFileOptions.UseDefaultWorkerThread;
			this.SendPacketsSendSize = -1;
			this.SocketError = SocketError.Success;
			this.SocketFlags = SocketFlags.None;
			this.UserToken = null;
		}

		/// <summary>The event used to complete an asynchronous operation.</summary>
		// Token: 0x14000052 RID: 82
		// (add) Token: 0x0600246C RID: 9324 RVA: 0x000195E1 File Offset: 0x000177E1
		// (remove) Token: 0x0600246D RID: 9325 RVA: 0x000195FA File Offset: 0x000177FA
		public event EventHandler<SocketAsyncEventArgs> Completed;

		/// <summary>Gets or sets the socket to use or the socket created for accepting a connection with an asynchronous socket method.</summary>
		/// <returns>The <see cref="T:System.Net.Sockets.Socket" /> to use or the socket created for accepting a connection with an asynchronous socket method.</returns>
		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x00019613 File Offset: 0x00017813
		// (set) Token: 0x0600246F RID: 9327 RVA: 0x0001961B File Offset: 0x0001781B
		public Socket AcceptSocket { get; set; }

		/// <summary>Gets the data buffer to use with an asynchronous socket method.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array that represents the data buffer to use with an asynchronous socket method.</returns>
		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x00019624 File Offset: 0x00017824
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x0001962C File Offset: 0x0001782C
		public byte[] Buffer { get; private set; }

		/// <summary>Gets or sets an array of data buffers to use with an asynchronous socket method.</summary>
		/// <returns>An <see cref="T:System.Collections.IList" /> that represents an array of data buffers to use with an asynchronous socket method.</returns>
		/// <exception cref="T:System.ArgumentException">There are ambiguous buffers specified on a set operation. This exception occurs if a value other than null is passed and the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property is also not null.</exception>
		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x00019635 File Offset: 0x00017835
		// (set) Token: 0x06002473 RID: 9331 RVA: 0x0001963D File Offset: 0x0001783D
		[global::System.MonoTODO("not supported in all cases")]
		public IList<ArraySegment<byte>> BufferList
		{
			get
			{
				return this._bufferList;
			}
			set
			{
				if (this.Buffer != null && value != null)
				{
					throw new ArgumentException("Buffer and BufferList properties cannot both be non-null.");
				}
				this._bufferList = value;
			}
		}

		/// <summary>Gets the number of bytes transferred in the socket operation.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the number of bytes transferred in the socket operation.</returns>
		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x00019662 File Offset: 0x00017862
		// (set) Token: 0x06002475 RID: 9333 RVA: 0x0001966A File Offset: 0x0001786A
		public int BytesTransferred { get; private set; }

		/// <summary>Gets the maximum amount of data, in bytes, to send or receive in an asynchronous operation.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the maximum amount of data, in bytes, to send or receive.</returns>
		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x00019673 File Offset: 0x00017873
		// (set) Token: 0x06002477 RID: 9335 RVA: 0x0001967B File Offset: 0x0001787B
		public int Count { get; private set; }

		/// <summary>Gets or sets a value that specifies if socket can be reused after a disconnect operation.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> that specifies if socket can be reused after a disconnect operation.</returns>
		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06002478 RID: 9336 RVA: 0x00019684 File Offset: 0x00017884
		// (set) Token: 0x06002479 RID: 9337 RVA: 0x0001968C File Offset: 0x0001788C
		public bool DisconnectReuseSocket { get; set; }

		/// <summary>Gets the type of socket operation most recently performed with this context object.</summary>
		/// <returns>A <see cref="T:System.Net.Sockets.SocketAsyncOperation" /> instance that indicates the type of socket operation most recently performed with this context object.</returns>
		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x0600247A RID: 9338 RVA: 0x00019695 File Offset: 0x00017895
		// (set) Token: 0x0600247B RID: 9339 RVA: 0x0001969D File Offset: 0x0001789D
		public SocketAsyncOperation LastOperation { get; private set; }

		/// <summary>Gets the offset, in bytes, into the data buffer referenced by the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the offset, in bytes, into the data buffer referenced by the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property.</returns>
		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x0600247C RID: 9340 RVA: 0x000196A6 File Offset: 0x000178A6
		// (set) Token: 0x0600247D RID: 9341 RVA: 0x000196AE File Offset: 0x000178AE
		public int Offset { get; private set; }

		/// <summary>Gets or sets the remote IP endpoint for an asynchronous operation.</summary>
		/// <returns>An <see cref="T:System.Net.EndPoint" /> that represents the remote IP endpoint for an asynchronous operation.</returns>
		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x000196B7 File Offset: 0x000178B7
		// (set) Token: 0x0600247F RID: 9343 RVA: 0x000196BF File Offset: 0x000178BF
		public EndPoint RemoteEndPoint { get; set; }

		/// <summary>Gets the IP address and interface of a received packet.</summary>
		/// <returns>An <see cref="T:System.Net.Sockets.IPPacketInformation" /> instance that contains the IP address and interface of a received packet.</returns>
		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002480 RID: 9344 RVA: 0x000196C8 File Offset: 0x000178C8
		// (set) Token: 0x06002481 RID: 9345 RVA: 0x000196D0 File Offset: 0x000178D0
		public IPPacketInformation ReceiveMessageFromPacketInfo { get; private set; }

		/// <summary>Gets or sets an array of buffers to be sent for an asynchronous operation used by the <see cref="M:System.Net.Sockets.Socket.SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs)" /> method.</summary>
		/// <returns>An array of <see cref="T:System.Net.Sockets.SendPacketsElement" /> objects that represent an array of buffers to be sent.</returns>
		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x000196D9 File Offset: 0x000178D9
		// (set) Token: 0x06002483 RID: 9347 RVA: 0x000196E1 File Offset: 0x000178E1
		public SendPacketsElement[] SendPacketsElements { get; set; }

		/// <summary>Gets or sets a bitwise combination of <see cref="T:System.Net.Sockets.TransmitFileOptions" /> values for an asynchronous operation used by the <see cref="M:System.Net.Sockets.Socket.SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs)" /> method.</summary>
		/// <returns>A <see cref="T:System.Net.Sockets.TransmitFileOptions" /> that contains a bitwise combination of values that are used with an asynchronous operation.</returns>
		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x000196EA File Offset: 0x000178EA
		// (set) Token: 0x06002485 RID: 9349 RVA: 0x000196F2 File Offset: 0x000178F2
		public TransmitFileOptions SendPacketsFlags { get; set; }

		/// <summary>Gets or sets the size, in bytes, of the data block used in the send operation.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the size, in bytes, of the data block used in the send operation.</returns>
		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x000196FB File Offset: 0x000178FB
		// (set) Token: 0x06002487 RID: 9351 RVA: 0x00019703 File Offset: 0x00017903
		[global::System.MonoTODO("unused property")]
		public int SendPacketsSendSize { get; set; }

		/// <summary>Gets or sets the result of the asynchronous socket operation.</summary>
		/// <returns>A <see cref="T:System.Net.Sockets.SocketError" /> that represents the result of the asynchronous socket operation.</returns>
		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x0001970C File Offset: 0x0001790C
		// (set) Token: 0x06002489 RID: 9353 RVA: 0x00019714 File Offset: 0x00017914
		public SocketError SocketError { get; set; }

		/// <summary>Gets the results of an asynchronous socket operation or sets the behavior of an asynchronous operation.</summary>
		/// <returns>A <see cref="T:System.Net.Sockets.SocketFlags" /> that represents the results of an asynchronous socket operation.</returns>
		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x0001971D File Offset: 0x0001791D
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x00019725 File Offset: 0x00017925
		public SocketFlags SocketFlags { get; set; }

		/// <summary>Gets or sets a user or application object associated with this asynchronous socket operation.</summary>
		/// <returns>An object that represents the user or application object associated with this asynchronous socket operation.</returns>
		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x0001972E File Offset: 0x0001792E
		// (set) Token: 0x0600248D RID: 9357 RVA: 0x00019736 File Offset: 0x00017936
		public object UserToken { get; set; }

		/// <summary>Frees resources used by the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> class.</summary>
		// Token: 0x0600248E RID: 9358 RVA: 0x0006AE98 File Offset: 0x00069098
		~SocketAsyncEventArgs()
		{
			this.Dispose(false);
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x0006AEC8 File Offset: 0x000690C8
		private void Dispose(bool disposing)
		{
			Socket acceptSocket = this.AcceptSocket;
			if (acceptSocket != null)
			{
				acceptSocket.Close();
			}
			if (disposing)
			{
				GC.SuppressFinalize(this);
			}
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> instance and optionally disposes of the managed resources.</summary>
		// Token: 0x06002490 RID: 9360 RVA: 0x0001973F File Offset: 0x0001793F
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Represents a method that is called when an asynchronous operation completes.</summary>
		/// <param name="e">The event that is signaled.</param>
		// Token: 0x06002491 RID: 9361 RVA: 0x0006AEF4 File Offset: 0x000690F4
		protected virtual void OnCompleted(SocketAsyncEventArgs e)
		{
			if (e == null)
			{
				return;
			}
			EventHandler<SocketAsyncEventArgs> completed = e.Completed;
			if (completed != null)
			{
				completed(e.curSocket, e);
			}
		}

		/// <summary>Sets the data buffer to use with an asynchronous socket method.</summary>
		/// <param name="offset">The offset, in bytes, in the data buffer where the operation starts.</param>
		/// <param name="count">The maximum amount of data, in bytes, to send or receive in the buffer.</param>
		/// <exception cref="T:System.ArgumentException">There are ambiguous buffers specified. This exception occurs if the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property is also not null and the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> property is also not null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">An argument was out of range. This exception occurs if the <paramref name="offset" /> parameter is less than zero or greater than the length of the array in the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property. This exception also occurs if the <paramref name="count" /> parameter is less than zero or greater than the length of the array in the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property minus the <paramref name="offset" /> parameter.</exception>
		// Token: 0x06002492 RID: 9362 RVA: 0x00019748 File Offset: 0x00017948
		public void SetBuffer(int offset, int count)
		{
			this.SetBufferInternal(this.Buffer, offset, count);
		}

		/// <summary>Sets the data buffer to use with an asynchronous socket method.</summary>
		/// <param name="buffer">The data buffer to use with an asynchronous socket method.</param>
		/// <param name="offset">The offset, in bytes, in the data buffer where the operation starts.</param>
		/// <param name="count">The maximum amount of data, in bytes, to send or receive in the buffer.</param>
		/// <exception cref="T:System.ArgumentException">There are ambiguous buffers specified. This exception occurs if the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property is also not null and the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> property is also not null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">An argument was out of range. This exception occurs if the <paramref name="offset" /> parameter is less than zero or greater than the length of the array in the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property. This exception also occurs if the <paramref name="count" /> parameter is less than zero or greater than the length of the array in the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property minus the <paramref name="offset" /> parameter.</exception>
		// Token: 0x06002493 RID: 9363 RVA: 0x00019758 File Offset: 0x00017958
		public void SetBuffer(byte[] buffer, int offset, int count)
		{
			this.SetBufferInternal(buffer, offset, count);
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x0006AF24 File Offset: 0x00069124
		private void SetBufferInternal(byte[] buffer, int offset, int count)
		{
			if (buffer != null)
			{
				if (this.BufferList != null)
				{
					throw new ArgumentException("Buffer and BufferList properties cannot both be non-null.");
				}
				int num = buffer.Length;
				if (offset < 0 || (offset != 0 && offset >= num))
				{
					throw new ArgumentOutOfRangeException("offset");
				}
				if (count < 0 || count > num - offset)
				{
					throw new ArgumentOutOfRangeException("count");
				}
				this.Count = count;
				this.Offset = offset;
			}
			this.Buffer = buffer;
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x0006AFA0 File Offset: 0x000691A0
		private void ReceiveCallback()
		{
			this.SocketError = SocketError.Success;
			this.LastOperation = SocketAsyncOperation.Receive;
			SocketError socketError = SocketError.Success;
			if (!this.curSocket.Connected)
			{
				this.SocketError = SocketError.NotConnected;
				return;
			}
			try
			{
				this.BytesTransferred = this.curSocket.Receive_nochecks(this.Buffer, this.Offset, this.Count, this.SocketFlags, out socketError);
			}
			finally
			{
				this.SocketError = socketError;
				this.OnCompleted(this);
			}
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x0006B028 File Offset: 0x00069228
		private void ConnectCallback()
		{
			this.LastOperation = SocketAsyncOperation.Connect;
			SocketError socketError = SocketError.AccessDenied;
			try
			{
				socketError = this.TryConnect(this.RemoteEndPoint);
			}
			finally
			{
				this.SocketError = socketError;
				this.OnCompleted(this);
			}
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x0006B074 File Offset: 0x00069274
		private SocketError TryConnect(EndPoint endpoint)
		{
			this.curSocket.Connected = false;
			SocketError socketError = SocketError.Success;
			try
			{
				if (!this.curSocket.Blocking)
				{
					int num;
					this.curSocket.Poll(-1, SelectMode.SelectWrite, out num);
					socketError = (SocketError)num;
					if (num != 0)
					{
						return socketError;
					}
					this.curSocket.Connected = true;
				}
				else
				{
					this.curSocket.seed_endpoint = endpoint;
					this.curSocket.Connect(endpoint);
					this.curSocket.Connected = true;
				}
			}
			catch (SocketException ex)
			{
				socketError = ex.SocketErrorCode;
			}
			return socketError;
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x0006B120 File Offset: 0x00069320
		private void SendCallback()
		{
			this.SocketError = SocketError.Success;
			this.LastOperation = SocketAsyncOperation.Send;
			SocketError socketError = SocketError.Success;
			if (!this.curSocket.Connected)
			{
				this.SocketError = SocketError.NotConnected;
				return;
			}
			try
			{
				if (this.Buffer != null)
				{
					this.BytesTransferred = this.curSocket.Send_nochecks(this.Buffer, this.Offset, this.Count, SocketFlags.None, out socketError);
				}
				else if (this.BufferList != null)
				{
					this.BytesTransferred = 0;
					foreach (ArraySegment<byte> arraySegment in this.BufferList)
					{
						this.BytesTransferred += this.curSocket.Send_nochecks(arraySegment.Array, arraySegment.Offset, arraySegment.Count, SocketFlags.None, out socketError);
						if (socketError != SocketError.Success)
						{
							break;
						}
					}
				}
			}
			finally
			{
				this.SocketError = socketError;
				this.OnCompleted(this);
			}
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x0006B240 File Offset: 0x00069440
		private void AcceptCallback()
		{
			this.SocketError = SocketError.Success;
			this.LastOperation = SocketAsyncOperation.Accept;
			try
			{
				this.curSocket.Accept(this.AcceptSocket);
			}
			catch (SocketException ex)
			{
				this.SocketError = ex.SocketErrorCode;
				throw;
			}
			finally
			{
				this.OnCompleted(this);
			}
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x0006B2AC File Offset: 0x000694AC
		private void DisconnectCallback()
		{
			this.SocketError = SocketError.Success;
			this.LastOperation = SocketAsyncOperation.Disconnect;
			try
			{
				this.curSocket.Disconnect(this.DisconnectReuseSocket);
			}
			catch (SocketException ex)
			{
				this.SocketError = ex.SocketErrorCode;
				throw;
			}
			finally
			{
				this.OnCompleted(this);
			}
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x0006B318 File Offset: 0x00069518
		private void ReceiveFromCallback()
		{
			this.SocketError = SocketError.Success;
			this.LastOperation = SocketAsyncOperation.ReceiveFrom;
			try
			{
				EndPoint remoteEndPoint = this.RemoteEndPoint;
				if (this.Buffer != null)
				{
					this.BytesTransferred = this.curSocket.ReceiveFrom_nochecks(this.Buffer, this.Offset, this.Count, this.SocketFlags, ref remoteEndPoint);
				}
				else if (this.BufferList != null)
				{
					throw new NotImplementedException();
				}
			}
			catch (SocketException ex)
			{
				this.SocketError = ex.SocketErrorCode;
				throw;
			}
			finally
			{
				this.OnCompleted(this);
			}
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x0006B3C4 File Offset: 0x000695C4
		private void SendToCallback()
		{
			this.SocketError = SocketError.Success;
			this.LastOperation = SocketAsyncOperation.SendTo;
			int i = 0;
			try
			{
				int count = this.Count;
				while (i < count)
				{
					i += this.curSocket.SendTo_nochecks(this.Buffer, this.Offset, count, this.SocketFlags, this.RemoteEndPoint);
				}
				this.BytesTransferred = i;
			}
			catch (SocketException ex)
			{
				this.SocketError = ex.SocketErrorCode;
				throw;
			}
			finally
			{
				this.OnCompleted(this);
			}
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x0006B460 File Offset: 0x00069660
		internal void DoOperation(SocketAsyncOperation operation, Socket socket)
		{
			this.curSocket = socket;
			ThreadStart threadStart;
			switch (operation)
			{
			case SocketAsyncOperation.Accept:
				threadStart = new ThreadStart(this.AcceptCallback);
				goto IL_00BE;
			case SocketAsyncOperation.Connect:
				threadStart = new ThreadStart(this.ConnectCallback);
				goto IL_00BE;
			case SocketAsyncOperation.Disconnect:
				threadStart = new ThreadStart(this.DisconnectCallback);
				goto IL_00BE;
			case SocketAsyncOperation.Receive:
				threadStart = new ThreadStart(this.ReceiveCallback);
				goto IL_00BE;
			case SocketAsyncOperation.ReceiveFrom:
				threadStart = new ThreadStart(this.ReceiveFromCallback);
				goto IL_00BE;
			case SocketAsyncOperation.Send:
				threadStart = new ThreadStart(this.SendCallback);
				goto IL_00BE;
			case SocketAsyncOperation.SendTo:
				threadStart = new ThreadStart(this.SendToCallback);
				goto IL_00BE;
			}
			throw new NotSupportedException();
			IL_00BE:
			new Thread(threadStart)
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x04001638 RID: 5688
		private IList<ArraySegment<byte>> _bufferList;

		// Token: 0x04001639 RID: 5689
		private Socket curSocket;
	}
}
