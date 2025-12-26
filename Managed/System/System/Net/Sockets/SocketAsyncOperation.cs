using System;

namespace System.Net.Sockets
{
	/// <summary>The type of asynchronous socket operation most recently performed with this context object.</summary>
	// Token: 0x0200041A RID: 1050
	public enum SocketAsyncOperation
	{
		/// <summary>None of the socket operations.</summary>
		// Token: 0x0400164B RID: 5707
		None,
		/// <summary>A socket Accept operation. </summary>
		// Token: 0x0400164C RID: 5708
		Accept,
		/// <summary>A socket Connect operation.</summary>
		// Token: 0x0400164D RID: 5709
		Connect,
		/// <summary>A socket Disconnect operation.</summary>
		// Token: 0x0400164E RID: 5710
		Disconnect,
		/// <summary>A socket Receive operation.</summary>
		// Token: 0x0400164F RID: 5711
		Receive,
		/// <summary>A socket ReceiveFrom operation.</summary>
		// Token: 0x04001650 RID: 5712
		ReceiveFrom,
		/// <summary>A socket ReceiveMessageFrom operation.</summary>
		// Token: 0x04001651 RID: 5713
		ReceiveMessageFrom,
		/// <summary>A socket Send operation.</summary>
		// Token: 0x04001652 RID: 5714
		Send,
		/// <summary>A socket SendPackets operation.</summary>
		// Token: 0x04001653 RID: 5715
		SendPackets,
		/// <summary>A socket SendTo operation.</summary>
		// Token: 0x04001654 RID: 5716
		SendTo
	}
}
