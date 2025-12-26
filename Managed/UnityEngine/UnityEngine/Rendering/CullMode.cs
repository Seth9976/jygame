using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Backface culling mode.</para>
	/// </summary>
	// Token: 0x02000283 RID: 643
	public enum CullMode
	{
		/// <summary>
		///   <para>Disable culling.</para>
		/// </summary>
		// Token: 0x040009F5 RID: 2549
		Off,
		/// <summary>
		///   <para>Cull front-facing geometry.</para>
		/// </summary>
		// Token: 0x040009F6 RID: 2550
		Front,
		/// <summary>
		///   <para>Cull back-facing geometry.</para>
		/// </summary>
		// Token: 0x040009F7 RID: 2551
		Back
	}
}
