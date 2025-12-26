using System;
using System.ComponentModel;

namespace System.Net
{
	/// <summary>Provides data for the <see cref="E:System.Net.WebClient.DownloadProgressChanged" /> event of a <see cref="T:System.Net.WebClient" />.</summary>
	// Token: 0x020004E3 RID: 1251
	public class DownloadProgressChangedEventArgs : global::System.ComponentModel.ProgressChangedEventArgs
	{
		// Token: 0x06002C4B RID: 11339 RVA: 0x0001EA91 File Offset: 0x0001CC91
		internal DownloadProgressChangedEventArgs(long bytesReceived, long totalBytesToReceive, object userState)
			: base((totalBytesToReceive == -1L) ? 0 : ((int)(bytesReceived * 100L / totalBytesToReceive)), userState)
		{
			this.received = bytesReceived;
			this.total = totalBytesToReceive;
		}

		/// <summary>Gets the number of bytes received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that indicates the number of bytes received.</returns>
		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06002C4C RID: 11340 RVA: 0x0001EABE File Offset: 0x0001CCBE
		public long BytesReceived
		{
			get
			{
				return this.received;
			}
		}

		/// <summary>Gets the total number of bytes in a <see cref="T:System.Net.WebClient" /> data download operation.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that indicates the number of bytes that will be received.</returns>
		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x0001EAC6 File Offset: 0x0001CCC6
		public long TotalBytesToReceive
		{
			get
			{
				return this.total;
			}
		}

		// Token: 0x04001BBA RID: 7098
		private long received;

		// Token: 0x04001BBB RID: 7099
		private long total;
	}
}
