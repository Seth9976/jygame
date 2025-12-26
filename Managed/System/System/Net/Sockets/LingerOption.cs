using System;

namespace System.Net.Sockets
{
	/// <summary>Specifies whether a <see cref="T:System.Net.Sockets.Socket" /> will remain connected after a call to the <see cref="M:System.Net.Sockets.Socket.Close" /> or <see cref="M:System.Net.Sockets.TcpClient.Close" /> methods and the length of time it will remain connected, if data remains to be sent.</summary>
	// Token: 0x02000409 RID: 1033
	public class LingerOption
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.LingerOption" /> class.</summary>
		/// <param name="enable">true to remain connected after the <see cref="M:System.Net.Sockets.Socket.Close" /> method is called; otherwise, false. </param>
		/// <param name="seconds">The number of seconds to remain connected after the <see cref="M:System.Net.Sockets.Socket.Close" /> method is called. </param>
		// Token: 0x0600233C RID: 9020 RVA: 0x00018E12 File Offset: 0x00017012
		public LingerOption(bool enable, int secs)
		{
			this.enabled = enable;
			this.seconds = secs;
		}

		/// <summary>Gets or sets a value that indicates whether to linger after the <see cref="T:System.Net.Sockets.Socket" /> is closed.</summary>
		/// <returns>true if the <see cref="T:System.Net.Sockets.Socket" /> should linger after <see cref="M:System.Net.Sockets.Socket.Close" /> is called; otherwise, false.</returns>
		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x00018E28 File Offset: 0x00017028
		// (set) Token: 0x0600233E RID: 9022 RVA: 0x00018E30 File Offset: 0x00017030
		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				this.enabled = value;
			}
		}

		/// <summary>Gets or sets the amount of time to remain connected after calling the <see cref="M:System.Net.Sockets.Socket.Close" /> method if data remains to be sent.</summary>
		/// <returns>The amount of time, in seconds, to remain connected after calling <see cref="M:System.Net.Sockets.Socket.Close" />.</returns>
		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x00018E39 File Offset: 0x00017039
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x00018E41 File Offset: 0x00017041
		public int LingerTime
		{
			get
			{
				return this.seconds;
			}
			set
			{
				this.seconds = value;
			}
		}

		// Token: 0x040015A2 RID: 5538
		private bool enabled;

		// Token: 0x040015A3 RID: 5539
		private int seconds;
	}
}
