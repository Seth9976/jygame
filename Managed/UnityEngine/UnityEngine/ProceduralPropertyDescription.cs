using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes a ProceduralProperty.</para>
	/// </summary>
	// Token: 0x02000091 RID: 145
	[StructLayout(LayoutKind.Sequential)]
	public sealed class ProceduralPropertyDescription
	{
		/// <summary>
		///   <para>The name of the ProceduralProperty. Used to get and set the values.</para>
		/// </summary>
		// Token: 0x040001C7 RID: 455
		public string name;

		/// <summary>
		///   <para>The label of the ProceduralProperty. Can contain space and be overall more user-friendly than the 'name' member.</para>
		/// </summary>
		// Token: 0x040001C8 RID: 456
		public string label;

		/// <summary>
		///   <para>The name of the GUI group. Used to display ProceduralProperties in groups.</para>
		/// </summary>
		// Token: 0x040001C9 RID: 457
		public string group;

		/// <summary>
		///   <para>The ProceduralPropertyType describes what type of property this is.</para>
		/// </summary>
		// Token: 0x040001CA RID: 458
		public ProceduralPropertyType type;

		/// <summary>
		///   <para>If true, the Float or Vector property is constrained to values within a specified range.</para>
		/// </summary>
		// Token: 0x040001CB RID: 459
		public bool hasRange;

		/// <summary>
		///   <para>If hasRange is true, minimum specifies the minimum allowed value for this Float or Vector property.</para>
		/// </summary>
		// Token: 0x040001CC RID: 460
		public float minimum;

		/// <summary>
		///   <para>If hasRange is true, maximum specifies the maximum allowed value for this Float or Vector property.</para>
		/// </summary>
		// Token: 0x040001CD RID: 461
		public float maximum;

		/// <summary>
		///   <para>Specifies the step size of this Float or Vector property. Zero is no step.</para>
		/// </summary>
		// Token: 0x040001CE RID: 462
		public float step;

		/// <summary>
		///   <para>The available options for a ProceduralProperty of type Enum.</para>
		/// </summary>
		// Token: 0x040001CF RID: 463
		public string[] enumOptions;

		/// <summary>
		///   <para>The names of the individual components of a Vector234 ProceduralProperty.</para>
		/// </summary>
		// Token: 0x040001D0 RID: 464
		public string[] componentLabels;
	}
}
