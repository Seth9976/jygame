using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Rolloff modes that a 3D sound can have in an audio source.</para>
	/// </summary>
	// Token: 0x0200015A RID: 346
	public enum AudioRolloffMode
	{
		/// <summary>
		///   <para>Use this mode when you want a real-world rolloff.</para>
		/// </summary>
		// Token: 0x040003CE RID: 974
		Logarithmic,
		/// <summary>
		///   <para>Use this mode when you want to lower the volume of your sound over the distance.</para>
		/// </summary>
		// Token: 0x040003CF RID: 975
		Linear,
		/// <summary>
		///   <para>Use this when you want to use a custom rolloff.</para>
		/// </summary>
		// Token: 0x040003D0 RID: 976
		Custom
	}
}
