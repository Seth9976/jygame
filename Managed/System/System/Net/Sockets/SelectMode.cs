using System;

namespace System.Net.Sockets
{
	/// <summary>Defines the polling modes for the <see cref="M:System.Net.Sockets.Socket.Poll(System.Int32,System.Net.Sockets.SelectMode)" /> method.</summary>
	// Token: 0x0200040E RID: 1038
	public enum SelectMode
	{
		/// <summary>Read status mode.</summary>
		// Token: 0x040015E8 RID: 5608
		SelectRead,
		/// <summary>Write status mode.</summary>
		// Token: 0x040015E9 RID: 5609
		SelectWrite,
		/// <summary>Error status mode.</summary>
		// Token: 0x040015EA RID: 5610
		SelectError
	}
}
