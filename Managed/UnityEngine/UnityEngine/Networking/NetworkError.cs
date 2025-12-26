using System;

namespace UnityEngine.Networking
{
	/// <summary>
	///   <para>Possible transport layer erors.</para>
	/// </summary>
	// Token: 0x0200021E RID: 542
	public enum NetworkError
	{
		/// <summary>
		///   <para>Everything good so far.</para>
		/// </summary>
		// Token: 0x04000869 RID: 2153
		Ok,
		/// <summary>
		///   <para>Host doesn't exist.</para>
		/// </summary>
		// Token: 0x0400086A RID: 2154
		WrongHost,
		/// <summary>
		///   <para>Connection doesn't exist.</para>
		/// </summary>
		// Token: 0x0400086B RID: 2155
		WrongConnection,
		/// <summary>
		///   <para>Channel doesn't exist.</para>
		/// </summary>
		// Token: 0x0400086C RID: 2156
		WrongChannel,
		/// <summary>
		///   <para>No internal resources ro acomplish request.</para>
		/// </summary>
		// Token: 0x0400086D RID: 2157
		NoResources,
		/// <summary>
		///   <para>Obsolete.</para>
		/// </summary>
		// Token: 0x0400086E RID: 2158
		BadMessage,
		/// <summary>
		///   <para>Timeout happened.</para>
		/// </summary>
		// Token: 0x0400086F RID: 2159
		Timeout,
		/// <summary>
		///   <para>Sending message too long to fit internal buffers, or user doesn't present buffer with length enouf to contain receiving message.</para>
		/// </summary>
		// Token: 0x04000870 RID: 2160
		MessageToLong,
		/// <summary>
		///   <para>Operation is not supported.</para>
		/// </summary>
		// Token: 0x04000871 RID: 2161
		WrongOperation,
		/// <summary>
		///   <para>Different version of protocol on ends of connection.</para>
		/// </summary>
		// Token: 0x04000872 RID: 2162
		VersionMismatch,
		/// <summary>
		///   <para>Two ends of connection have different agreement about channels, channels qos and network parameters.</para>
		/// </summary>
		// Token: 0x04000873 RID: 2163
		CRCMismatch,
		/// <summary>
		///   <para>The address supplied to connect to was invalid or could not be resolved.</para>
		/// </summary>
		// Token: 0x04000874 RID: 2164
		DNSFailure
	}
}
