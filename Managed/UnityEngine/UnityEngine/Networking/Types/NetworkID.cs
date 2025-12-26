using System;
using System.ComponentModel;

namespace UnityEngine.Networking.Types
{
	/// <summary>
	///   <para>Network ID, used for match making.</para>
	/// </summary>
	// Token: 0x02000213 RID: 531
	[DefaultValue(NetworkID.Invalid)]
	public enum NetworkID : ulong
	{
		/// <summary>
		///   <para>Invalid NetworkID.</para>
		/// </summary>
		// Token: 0x0400083C RID: 2108
		Invalid = 18446744073709551615UL
	}
}
