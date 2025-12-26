using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Attribute for setting up RPC functions.</para>
	/// </summary>
	// Token: 0x02000072 RID: 114
	[Obsolete("NetworkView RPC functions are deprecated. Refer to the new Multiplayer Networking system.")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class RPC : Attribute
	{
	}
}
