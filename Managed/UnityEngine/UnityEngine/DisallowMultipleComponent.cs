using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Prevents MonoBehaviour of same type (or subtype) to be added more than once to a GameObject.</para>
	/// </summary>
	// Token: 0x02000247 RID: 583
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public sealed class DisallowMultipleComponent : Attribute
	{
	}
}
