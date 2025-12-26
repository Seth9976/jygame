using System;

namespace System.Net.Sockets
{
	/// <summary>Encapsulates the information that is necessary to duplicate a <see cref="T:System.Net.Sockets.Socket" />.</summary>
	// Token: 0x0200041E RID: 1054
	[Serializable]
	public struct SocketInformation
	{
		/// <summary>Gets or sets the options for a <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>A <see cref="T:System.Net.Sockets.SocketInformationOptions" /> instance.</returns>
		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x060024A6 RID: 9382 RVA: 0x00019778 File Offset: 0x00017978
		// (set) Token: 0x060024A7 RID: 9383 RVA: 0x00019780 File Offset: 0x00017980
		public SocketInformationOptions Options
		{
			get
			{
				return this.options;
			}
			set
			{
				this.options = value;
			}
		}

		/// <summary>Gets or sets the protocol information for a <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>An array of type <see cref="T:System.Byte" />.</returns>
		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x00019789 File Offset: 0x00017989
		// (set) Token: 0x060024A9 RID: 9385 RVA: 0x00019791 File Offset: 0x00017991
		public byte[] ProtocolInformation
		{
			get
			{
				return this.protocol_info;
			}
			set
			{
				this.protocol_info = value;
			}
		}

		// Token: 0x04001690 RID: 5776
		private SocketInformationOptions options;

		// Token: 0x04001691 RID: 5777
		private byte[] protocol_info;
	}
}
