using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The global Substance engine processor usage (as used for the ProceduralMaterial.substanceProcessorUsage property).</para>
	/// </summary>
	// Token: 0x0200008C RID: 140
	public enum ProceduralProcessorUsage
	{
		/// <summary>
		///   <para>Exact control of processor usage is not available.</para>
		/// </summary>
		// Token: 0x0400019F RID: 415
		Unsupported,
		/// <summary>
		///   <para>A single physical processor core is used for ProceduralMaterial generation.</para>
		/// </summary>
		// Token: 0x040001A0 RID: 416
		One,
		/// <summary>
		///   <para>Half of all physical processor cores are used for ProceduralMaterial generation.</para>
		/// </summary>
		// Token: 0x040001A1 RID: 417
		Half,
		/// <summary>
		///   <para>All physical processor cores are used for ProceduralMaterial generation.</para>
		/// </summary>
		// Token: 0x040001A2 RID: 418
		All
	}
}
