using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Possible status messages returned by Network.Connect and in MonoBehaviour.OnFailedToConnect|OnFailedToConnect in case the error was not immediate.</para>
	/// </summary>
	// Token: 0x02000066 RID: 102
	public enum NetworkConnectionError
	{
		/// <summary>
		///   <para>No error occurred.</para>
		/// </summary>
		// Token: 0x0400011D RID: 285
		NoError,
		/// <summary>
		///   <para>We presented an RSA public key which does not match what the system we connected to is using.</para>
		/// </summary>
		// Token: 0x0400011E RID: 286
		RSAPublicKeyMismatch = 21,
		/// <summary>
		///   <para>The server is using a password and has refused our connection because we did not set the correct password.</para>
		/// </summary>
		// Token: 0x0400011F RID: 287
		InvalidPassword = 23,
		/// <summary>
		///   <para>Connection attempt failed, possibly because of internal connectivity problems.</para>
		/// </summary>
		// Token: 0x04000120 RID: 288
		ConnectionFailed = 15,
		/// <summary>
		///   <para>The server is at full capacity, failed to connect.</para>
		/// </summary>
		// Token: 0x04000121 RID: 289
		TooManyConnectedPlayers = 18,
		/// <summary>
		///   <para>We are banned from the system we attempted to connect to (likely temporarily).</para>
		/// </summary>
		// Token: 0x04000122 RID: 290
		ConnectionBanned = 22,
		/// <summary>
		///   <para>We are already connected to this particular server (can happen after fast disconnect/reconnect).</para>
		/// </summary>
		// Token: 0x04000123 RID: 291
		AlreadyConnectedToServer = 16,
		/// <summary>
		///   <para>Cannot connect to two servers at once. Close the connection before connecting again.</para>
		/// </summary>
		// Token: 0x04000124 RID: 292
		AlreadyConnectedToAnotherServer = -1,
		/// <summary>
		///   <para>Internal error while attempting to initialize network interface. Socket possibly already in use.</para>
		/// </summary>
		// Token: 0x04000125 RID: 293
		CreateSocketOrThreadFailure = -2,
		/// <summary>
		///   <para>Incorrect parameters given to Connect function.</para>
		/// </summary>
		// Token: 0x04000126 RID: 294
		IncorrectParameters = -3,
		/// <summary>
		///   <para>No host target given in Connect.</para>
		/// </summary>
		// Token: 0x04000127 RID: 295
		EmptyConnectTarget = -4,
		/// <summary>
		///   <para>Client could not connect internally to same network NAT enabled server.</para>
		/// </summary>
		// Token: 0x04000128 RID: 296
		InternalDirectConnectFailed = -5,
		/// <summary>
		///   <para>The NAT target we are trying to connect to is not connected to the facilitator server.</para>
		/// </summary>
		// Token: 0x04000129 RID: 297
		NATTargetNotConnected = 69,
		/// <summary>
		///   <para>Connection lost while attempting to connect to NAT target.</para>
		/// </summary>
		// Token: 0x0400012A RID: 298
		NATTargetConnectionLost = 71,
		/// <summary>
		///   <para>NAT punchthrough attempt has failed. The cause could be a too restrictive NAT implementation on either endpoints.</para>
		/// </summary>
		// Token: 0x0400012B RID: 299
		NATPunchthroughFailed = 73
	}
}
