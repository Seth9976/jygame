using System;
using System.ComponentModel;

namespace System.Net
{
	/// <summary>Provides data for the <see cref="E:System.Net.WebClient.UploadProgressChanged" /> event of a <see cref="T:System.Net.WebClient" />.</summary>
	// Token: 0x020004E6 RID: 1254
	public class UploadProgressChangedEventArgs : global::System.ComponentModel.ProgressChangedEventArgs
	{
		// Token: 0x06002C52 RID: 11346 RVA: 0x0001EB04 File Offset: 0x0001CD04
		internal UploadProgressChangedEventArgs(long bytesReceived, long totalBytesToReceive, long bytesSent, long totalBytesToSend, int progressPercentage, object userState)
			: base(progressPercentage, userState)
		{
			this.received = bytesReceived;
			this.total_recv = totalBytesToReceive;
			this.sent = bytesSent;
			this.total_send = totalBytesToSend;
		}

		/// <summary>Gets the number of bytes received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that indicates the number of bytes received.</returns>
		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002C53 RID: 11347 RVA: 0x0001EB2D File Offset: 0x0001CD2D
		public long BytesReceived
		{
			get
			{
				return this.received;
			}
		}

		/// <summary>Gets the total number of bytes in a <see cref="T:System.Net.WebClient" /> data upload operation.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that indicates the number of bytes that will be received.</returns>
		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x0001EB35 File Offset: 0x0001CD35
		public long TotalBytesToReceive
		{
			get
			{
				return this.total_recv;
			}
		}

		/// <summary>Gets the number of bytes sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that indicates the number of bytes sent.</returns>
		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002C55 RID: 11349 RVA: 0x0001EB3D File Offset: 0x0001CD3D
		public long BytesSent
		{
			get
			{
				return this.sent;
			}
		}

		/// <summary>Gets the total number of bytes to send.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that indicates the number of bytes that will be sent.</returns>
		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x0001EB45 File Offset: 0x0001CD45
		public long TotalBytesToSend
		{
			get
			{
				return this.total_send;
			}
		}

		// Token: 0x04001BBE RID: 7102
		private long received;

		// Token: 0x04001BBF RID: 7103
		private long sent;

		// Token: 0x04001BC0 RID: 7104
		private long total_recv;

		// Token: 0x04001BC1 RID: 7105
		private long total_send;
	}
}
