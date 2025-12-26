using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The Audio Distortion Filter distorts the sound from an AudioSource or.</para>
	/// </summary>
	// Token: 0x02000161 RID: 353
	public sealed class AudioDistortionFilter : Behaviour
	{
		/// <summary>
		///   <para>Distortion value. 0.0 to 1.0. Default = 0.5.</para>
		/// </summary>
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060014CF RID: 5327
		// (set) Token: 0x060014D0 RID: 5328
		public extern float distortionLevel
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}
	}
}
