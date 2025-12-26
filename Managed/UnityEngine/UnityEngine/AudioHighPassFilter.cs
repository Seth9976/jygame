using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The Audio High Pass Filter passes high frequencies of an AudioSource and.</para>
	/// </summary>
	// Token: 0x02000160 RID: 352
	public sealed class AudioHighPassFilter : Behaviour
	{
		/// <summary>
		///   <para>Highpass cutoff frequency in hz. 10.0 to 22000.0. Default = 5000.0.</para>
		/// </summary>
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060014CA RID: 5322
		// (set) Token: 0x060014CB RID: 5323
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
		///   <para>Determines how much the filter's self-resonance isdampened.</para>
		/// </summary>
		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060014CC RID: 5324
		// (set) Token: 0x060014CD RID: 5325
		public extern float highpassResonanceQ
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
