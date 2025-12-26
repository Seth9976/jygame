using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Instructs the build pipeline not to try and validate a type or member for the flash platform. (obsolete in Unity 5.0 and above)</para>
	/// </summary>
	// Token: 0x020000B6 RID: 182
	[NotConverted]
	[Obsolete("NotFlashValidatedAttribute was used for the Flash buildtarget, which is not supported anymore starting Unity 5.0", true)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
	public sealed class NotFlashValidatedAttribute : Attribute
	{
	}
}
