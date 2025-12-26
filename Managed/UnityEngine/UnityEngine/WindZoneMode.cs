using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Modes a Wind Zone can have, either Spherical or Directional.</para>
	/// </summary>
	// Token: 0x020000D8 RID: 216
	public enum WindZoneMode
	{
		/// <summary>
		///   <para>Wind zone only has an effect inside the radius, and has a falloff from the center towards the edge.</para>
		/// </summary>
		// Token: 0x04000269 RID: 617
		Directional,
		/// <summary>
		///   <para>Wind zone affects the entire scene in one direction.</para>
		/// </summary>
		// Token: 0x0400026A RID: 618
		Spherical
	}
}
