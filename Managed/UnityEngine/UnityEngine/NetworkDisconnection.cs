using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The reason a disconnect event occured, like in MonoBehaviour.OnDisconnectedFromServer|OnDisconnectedFromServer.</para>
	/// </summary>
	// Token: 0x02000067 RID: 103
	public enum NetworkDisconnection
	{
		/// <summary>
		///   <para>The connection to the system has been lost, no reliable packets could be delivered.</para>
		/// </summary>
		// Token: 0x0400012D RID: 301
		LostConnection = 20,
		/// <summary>
		///   <para>The connection to the system has been closed.</para>
		/// </summary>
		// Token: 0x0400012E RID: 302
		Disconnected = 19
	}
}
