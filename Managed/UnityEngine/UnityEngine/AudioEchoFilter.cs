using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The Audio Echo Filter repeats a sound after a given Delay, attenuating.</para>
	/// </summary>
	// Token: 0x02000162 RID: 354
	public sealed class AudioEchoFilter : Behaviour
	{
		/// <summary>
		///   <para>Echo delay in ms. 10 to 5000. Default = 500.</para>
		/// </summary>
		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060014D2 RID: 5330
		// (set) Token: 0x060014D3 RID: 5331
		public extern float delay
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Echo decay per delay. 0 to 1. 1.0 = No decay, 0.0 = total decay (i.e. simple 1 line delay). Default = 0.5.</para>
		/// </summary>
		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060014D4 RID: 5332
		// (set) Token: 0x060014D5 RID: 5333
		public extern float decayRatio
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Volume of original signal to pass to output. 0.0 to 1.0. Default = 1.0.</para>
		/// </summary>
		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060014D6 RID: 5334
		// (set) Token: 0x060014D7 RID: 5335
		public extern float dryMix
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Volume of echo signal to pass to output. 0.0 to 1.0. Default = 1.0.</para>
		/// </summary>
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060014D8 RID: 5336
		// (set) Token: 0x060014D9 RID: 5337
		public extern float wetMix
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
