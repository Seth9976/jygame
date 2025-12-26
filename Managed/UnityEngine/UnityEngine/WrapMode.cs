using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Determines how time is treated outside of the keyframed range of an AnimationClip or AnimationCurve.</para>
	/// </summary>
	// Token: 0x0200016F RID: 367
	public enum WrapMode
	{
		/// <summary>
		///   <para>When time reaches the end of the animation clip, the clip will automatically stop playing and time will be reset to beginning of the clip.</para>
		/// </summary>
		// Token: 0x040003FA RID: 1018
		Once = 1,
		/// <summary>
		///   <para>When time reaches the end of the animation clip, time will continue at the beginning.</para>
		/// </summary>
		// Token: 0x040003FB RID: 1019
		Loop,
		/// <summary>
		///   <para>When time reaches the end of the animation clip, time will ping pong back between beginning and end.</para>
		/// </summary>
		// Token: 0x040003FC RID: 1020
		PingPong = 4,
		/// <summary>
		///   <para>Reads the default repeat mode set higher up.</para>
		/// </summary>
		// Token: 0x040003FD RID: 1021
		Default = 0,
		/// <summary>
		///   <para>Plays back the animation. When it reaches the end, it will keep playing the last frame and never stop playing.</para>
		/// </summary>
		// Token: 0x040003FE RID: 1022
		ClampForever = 8,
		// Token: 0x040003FF RID: 1023
		Clamp = 1
	}
}
