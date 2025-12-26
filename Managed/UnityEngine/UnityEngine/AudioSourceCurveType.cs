using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>This defines the curve type of the different custom curves that can be queried and set within the AudioSource.</para>
	/// </summary>
	// Token: 0x0200015B RID: 347
	public enum AudioSourceCurveType
	{
		/// <summary>
		///   <para>Custom Volume Rolloff.</para>
		/// </summary>
		// Token: 0x040003D2 RID: 978
		CustomRolloff,
		/// <summary>
		///   <para>The Spatial Blend.</para>
		/// </summary>
		// Token: 0x040003D3 RID: 979
		SpatialBlend,
		/// <summary>
		///   <para>Reverb Zone Mix.</para>
		/// </summary>
		// Token: 0x040003D4 RID: 980
		ReverbZoneMix,
		/// <summary>
		///   <para>The 3D Spread.</para>
		/// </summary>
		// Token: 0x040003D5 RID: 981
		Spread
	}
}
