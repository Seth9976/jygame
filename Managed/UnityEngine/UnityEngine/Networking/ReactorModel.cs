using System;

namespace UnityEngine.Networking
{
	/// <summary>
	///   <para>Define how unet will handle network io operation.</para>
	/// </summary>
	// Token: 0x0200021F RID: 543
	public enum ReactorModel
	{
		/// <summary>
		///   <para>Network thread will sleep up to threadawake timeout, or up to receive event on socket will happened. Awaked thread will try to read up to maxpoolsize packets from socket and will try update connections ready to send (with fixing awaketimeout rate).</para>
		/// </summary>
		// Token: 0x04000876 RID: 2166
		SelectReactor,
		/// <summary>
		///   <para>Network thread will sleep up to threadawake timeout, after that it will try receive up to maxpoolsize amount of messages and then will try perform send operation for connection whihc ready to send.</para>
		/// </summary>
		// Token: 0x04000877 RID: 2167
		FixRateReactor
	}
}
