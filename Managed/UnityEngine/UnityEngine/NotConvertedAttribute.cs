using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Instructs the build pipeline not to convert a type or member to the target platform.</para>
	/// </summary>
	// Token: 0x020000B5 RID: 181
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class NotConvertedAttribute : Attribute
	{
	}
}
