using System;
using System.ComponentModel;

namespace UnityEngine.Networking.Types
{
	/// <summary>
	///   <para>Describes the access levels granted to this client.</para>
	/// </summary>
	// Token: 0x02000210 RID: 528
	[DefaultValue(NetworkAccessLevel.Invalid)]
	public enum NetworkAccessLevel : ulong
	{
		/// <summary>
		///   <para>Invalid access level, signifying no access level has been granted/specified.</para>
		/// </summary>
		// Token: 0x04000833 RID: 2099
		Invalid,
		/// <summary>
		///   <para>User access level. This means you can do operations which affect yourself only, like disconnect yourself from the match.</para>
		/// </summary>
		// Token: 0x04000834 RID: 2100
		User,
		/// <summary>
		///   <para>Access level Owner, generally granting access for operations key to the peer host server performing it's work.</para>
		/// </summary>
		// Token: 0x04000835 RID: 2101
		Owner,
		/// <summary>
		///   <para>Administration access level, generally describing clearence to perform game altering actions against anyone inside a particular match.</para>
		/// </summary>
		// Token: 0x04000836 RID: 2102
		Admin = 4UL
	}
}
