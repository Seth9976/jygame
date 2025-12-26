using System;
using System.IO;

namespace System.Net.Security
{
	/// <summary>Provides methods for passing credentials across a stream and requesting or performing authentication for client-server applications.</summary>
	// Token: 0x020003F5 RID: 1013
	public abstract class AuthenticatedStream : Stream
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Security.AuthenticatedStream" /> class. </summary>
		/// <param name="innerStream">A <see cref="T:System.IO.Stream" /> object used by the <see cref="T:System.Net.Security.AuthenticatedStream" />  for sending and receiving data.</param>
		/// <param name="leaveInnerStreamOpen">A <see cref="T:System.Boolean" /> that indicates whether closing this <see cref="T:System.Net.Security.AuthenticatedStream" />  object also closes <paramref name="innerStream" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="innerStream" /> is null.-or-<paramref name="innerStream" /> is equal to <see cref="F:System.IO.Stream.Null" />.</exception>
		// Token: 0x06002244 RID: 8772 RVA: 0x00018480 File Offset: 0x00016680
		protected AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen)
		{
			this.innerStream = innerStream;
			this.leaveStreamOpen = leaveInnerStreamOpen;
		}

		/// <summary>Gets the stream used by this <see cref="T:System.Net.Security.AuthenticatedStream" /> for sending and receiving data.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> object.</returns>
		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x00018496 File Offset: 0x00016696
		protected Stream InnerStream
		{
			get
			{
				return this.innerStream;
			}
		}

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether authentication was successful.</summary>
		/// <returns>true if successful authentication occurred; otherwise, false. </returns>
		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06002246 RID: 8774
		public abstract bool IsAuthenticated { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether data sent using this <see cref="T:System.Net.Security.AuthenticatedStream" /> is encrypted.</summary>
		/// <returns>true if data is encrypted before being transmitted over the network and decrypted when it reaches the remote endpoint; otherwise, false.</returns>
		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06002247 RID: 8775
		public abstract bool IsEncrypted { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether both server and client have been authenticated.</summary>
		/// <returns>true if the client and server have been authenticated; otherwise, false.</returns>
		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06002248 RID: 8776
		public abstract bool IsMutuallyAuthenticated { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the local side of the connection was authenticated as the server.</summary>
		/// <returns>true if the local endpoint was authenticated as the server side of a client-server authenticated connection; false if the local endpoint was authenticated as the client.</returns>
		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06002249 RID: 8777
		public abstract bool IsServer { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the data sent using this stream is signed.</summary>
		/// <returns>true if the data is signed before being transmitted; otherwise, false.</returns>
		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x0600224A RID: 8778
		public abstract bool IsSigned { get; }

		/// <summary>Gets whether the stream used by this <see cref="T:System.Net.Security.AuthenticatedStream" /> for sending and receiving data has been left open.</summary>
		/// <returns>true if the inner stream has been left open; otherwise, false.</returns>
		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x0001849E File Offset: 0x0001669E
		public bool LeaveInnerStreamOpen
		{
			get
			{
				return this.leaveStreamOpen;
			}
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Security.AuthenticatedStream" /> and optionally releases the managed resources. </summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		// Token: 0x0600224C RID: 8780 RVA: 0x000184A6 File Offset: 0x000166A6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.innerStream != null)
			{
				if (!this.leaveStreamOpen)
				{
					this.innerStream.Close();
				}
				this.innerStream = null;
			}
		}

		// Token: 0x04001512 RID: 5394
		private Stream innerStream;

		// Token: 0x04001513 RID: 5395
		private bool leaveStreamOpen;
	}
}
