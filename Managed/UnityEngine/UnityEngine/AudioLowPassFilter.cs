using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The Audio Low Pass Filter filter passes low frequencies of an.</para>
	/// </summary>
	// Token: 0x0200015F RID: 351
	public sealed class AudioLowPassFilter : Behaviour
	{
		/// <summary>
		///   <para>Lowpass cutoff frequency in hz. 10.0 to 22000.0. Default = 5000.0.</para>
		/// </summary>
		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060014C3 RID: 5315
		// (set) Token: 0x060014C4 RID: 5316
		public extern float cutoffFrequency
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns or sets the current custom frequency cutoff curve.</para>
		/// </summary>
		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060014C5 RID: 5317
		// (set) Token: 0x060014C6 RID: 5318
		public extern AnimationCurve customCutoffCurve
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Determines how much the filter's self-resonance is dampened.</para>
		/// </summary>
		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060014C7 RID: 5319
		// (set) Token: 0x060014C8 RID: 5320
		public extern float lowpassResonanceQ
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
