using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Determines how Unity will compress baked reflection cubemap.</para>
	/// </summary>
	// Token: 0x02000288 RID: 648
	public enum ReflectionCubemapCompression
	{
		/// <summary>
		///   <para>Baked Reflection cubemap will be left uncompressed.</para>
		/// </summary>
		// Token: 0x04000A10 RID: 2576
		Uncompressed,
		/// <summary>
		///   <para>Baked Reflection cubemap will be compressed.</para>
		/// </summary>
		// Token: 0x04000A11 RID: 2577
		Compressed,
		/// <summary>
		///   <para>Baked Reflection cubemap will be compressed if compression format is suitable.</para>
		/// </summary>
		// Token: 0x04000A12 RID: 2578
		Auto
	}
}
