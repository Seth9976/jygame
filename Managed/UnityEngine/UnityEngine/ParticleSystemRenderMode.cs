using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The rendering mode for particle systems (Shuriken).</para>
	/// </summary>
	// Token: 0x020000DF RID: 223
	public enum ParticleSystemRenderMode
	{
		/// <summary>
		///   <para>Render particles as billboards facing the player. (Default)</para>
		/// </summary>
		// Token: 0x0400027F RID: 639
		Billboard,
		/// <summary>
		///   <para>Stretch particles in the direction of motion.</para>
		/// </summary>
		// Token: 0x04000280 RID: 640
		Stretch,
		/// <summary>
		///   <para>Render particles as billboards always facing up along the y-Axis.</para>
		/// </summary>
		// Token: 0x04000281 RID: 641
		HorizontalBillboard,
		/// <summary>
		///   <para>Render particles as billboards always facing the player, but not pitching along the x-Axis.</para>
		/// </summary>
		// Token: 0x04000282 RID: 642
		VerticalBillboard,
		/// <summary>
		///   <para>Render particles as meshes.</para>
		/// </summary>
		// Token: 0x04000283 RID: 643
		Mesh
	}
}
