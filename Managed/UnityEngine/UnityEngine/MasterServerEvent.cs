using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes status messages from the master server as returned in MonoBehaviour.OnMasterServerEvent|OnMasterServerEvent.</para>
	/// </summary>
	// Token: 0x02000068 RID: 104
	public enum MasterServerEvent
	{
		/// <summary>
		///   <para>Registration failed because an empty game name was given.</para>
		/// </summary>
		// Token: 0x04000130 RID: 304
		RegistrationFailedGameName,
		/// <summary>
		///   <para>Registration failed because an empty game type was given.</para>
		/// </summary>
		// Token: 0x04000131 RID: 305
		RegistrationFailedGameType,
		/// <summary>
		///   <para>Registration failed because no server is running.</para>
		/// </summary>
		// Token: 0x04000132 RID: 306
		RegistrationFailedNoServer,
		/// <summary>
		///   <para>Registration to master server succeeded, received confirmation.</para>
		/// </summary>
		// Token: 0x04000133 RID: 307
		RegistrationSucceeded,
		/// <summary>
		///   <para>Received a host list from the master server.</para>
		/// </summary>
		// Token: 0x04000134 RID: 308
		HostListReceived
	}
}
