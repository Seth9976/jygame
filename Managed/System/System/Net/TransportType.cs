using System;

namespace System.Net
{
	/// <summary>Defines transport types for the <see cref="T:System.Net.SocketPermission" /> and <see cref="T:System.Net.Sockets.Socket" /> classes.</summary>
	// Token: 0x0200042A RID: 1066
	public enum TransportType
	{
		/// <summary>UDP transport.</summary>
		// Token: 0x040016F6 RID: 5878
		Udp = 1,
		/// <summary>The transport type is connectionless, such as UDP. Specifying this value has the same effect as specifying <see cref="F:System.Net.TransportType.Udp" />.</summary>
		// Token: 0x040016F7 RID: 5879
		Connectionless = 1,
		/// <summary>TCP transport.</summary>
		// Token: 0x040016F8 RID: 5880
		Tcp,
		/// <summary>The transport is connection oriented, such as TCP. Specifying this value has the same effect as specifying <see cref="F:System.Net.TransportType.Tcp" />.</summary>
		// Token: 0x040016F9 RID: 5881
		ConnectionOriented = 2,
		/// <summary>All transport types.</summary>
		// Token: 0x040016FA RID: 5882
		All
	}
}
