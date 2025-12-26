using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Prevent name mangling of constructors, methods, fields and properties.</para>
	/// </summary>
	// Token: 0x020000B7 RID: 183
	[Obsolete("NotRenamedAttribute was used for the Flash buildtarget, which is not supported anymore starting Unity 5.0", true)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
	[NotConverted]
	public sealed class NotRenamedAttribute : Attribute
	{
	}
}
