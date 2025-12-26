using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Assembly level attribute. Any classes in an assembly with this attribute will be considered to be Editor Classes.</para>
	/// </summary>
	// Token: 0x0200025C RID: 604
	[AttributeUsage(AttributeTargets.Assembly)]
	public class AssemblyIsEditorAssembly : Attribute
	{
	}
}
