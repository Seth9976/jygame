using System;

namespace System.Net.Sockets
{
	/// <summary>Specifies socket send and receive behaviors.</summary>
	// Token: 0x0200041D RID: 1053
	[Flags]
	public enum SocketFlags
	{
		/// <summary>Use no flags for this call.</summary>
		// Token: 0x04001686 RID: 5766
		None = 0,
		/// <summary>Process out-of-band data.</summary>
		// Token: 0x04001687 RID: 5767
		OutOfBand = 1,
		/// <summary>Peek at the incoming message.</summary>
		// Token: 0x04001688 RID: 5768
		Peek = 2,
		/// <summary>Send without using routing tables.</summary>
		// Token: 0x04001689 RID: 5769
		DontRoute = 4,
		/// <summary>Provides a standard value for the number of WSABUF structures that are used to send and receive data.</summary>
		// Token: 0x0400168A RID: 5770
		MaxIOVectorLength = 16,
		/// <summary>The message was too large to fit into the specified buffer and was truncated.</summary>
		// Token: 0x0400168B RID: 5771
		Truncated = 256,
		/// <summary>Indicates that the control data did not fit into an internal 64-KB buffer and was truncated.</summary>
		// Token: 0x0400168C RID: 5772
		ControlDataTruncated = 512,
		/// <summary>Indicates a broadcast packet.</summary>
		// Token: 0x0400168D RID: 5773
		Broadcast = 1024,
		/// <summary>Indicates a multicast packet.</summary>
		// Token: 0x0400168E RID: 5774
		Multicast = 2048,
		/// <summary>Partial send or receive for message.</summary>
		// Token: 0x0400168F RID: 5775
		Partial = 32768
	}
}
