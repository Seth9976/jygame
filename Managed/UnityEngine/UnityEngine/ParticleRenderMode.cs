using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The rendering mode for legacy particles.</para>
	/// </summary>
	// Token: 0x020000ED RID: 237
	public enum ParticleRenderMode
	{
		/// <summary>
		///   <para>Render the particles as billboards facing the player. (Default)</para>
		/// </summary>
		// Token: 0x040002A8 RID: 680
		Billboard,
		/// <summary>
		///   <para>Stretch particles in the direction of motion.</para>
		/// </summary>
		// Token: 0x040002A9 RID: 681
		Stretch = 3,
		/// <summary>
		///   <para>Sort the particles back-to-front and render as billboards.</para>
		/// </summary>
		// Token: 0x040002AA RID: 682
		SortedBillboard = 2,
		/// <summary>
		///   <para>Render the particles as billboards always facing up along the y-Axis.</para>
		/// </summary>
		// Token: 0x040002AB RID: 683
		HorizontalBillboard = 4,
		/// <summary>
		///   <para>Render the particles as billboards always facing the player, but not pitching along the x-Axis.</para>
		/// </summary>
		// Token: 0x040002AC RID: 684
		VerticalBillboard
	}
}
