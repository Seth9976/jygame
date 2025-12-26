using System;
using System.ComponentModel;

namespace UnityEngine.Networking.Types
{
	/// <summary>
	///   <para>The AppID identifies the application on the Unity Cloud or UNET servers.</para>
	/// </summary>
	// Token: 0x02000211 RID: 529
	[DefaultValue(AppID.Invalid)]
	public enum AppID : ulong
	{
		/// <summary>
		///   <para>Invalid AppID.</para>
		/// </summary>
		// Token: 0x04000838 RID: 2104
		Invalid = 18446744073709551615UL
	}
}
