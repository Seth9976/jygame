using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Ambient lighting mode.</para>
	/// </summary>
	// Token: 0x02000286 RID: 646
	public enum AmbientMode
	{
		/// <summary>
		///   <para>Skybox-based or custom ambient lighting.</para>
		/// </summary>
		// Token: 0x04000A08 RID: 2568
		Skybox,
		/// <summary>
		///   <para>Trilight ambient lighting.</para>
		/// </summary>
		// Token: 0x04000A09 RID: 2569
		Trilight,
		/// <summary>
		///   <para>Flat ambient lighting.</para>
		/// </summary>
		// Token: 0x04000A0A RID: 2570
		Flat = 3,
		/// <summary>
		///   <para>Ambient lighting is defined by a custom cubemap.</para>
		/// </summary>
		// Token: 0x04000A0B RID: 2571
		Custom
	}
}
