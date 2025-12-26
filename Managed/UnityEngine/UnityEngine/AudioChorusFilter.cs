using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The Audio Chorus Filter takes an Audio Clip and processes it creating a chorus effect.</para>
	/// </summary>
	// Token: 0x02000163 RID: 355
	public sealed class AudioChorusFilter : Behaviour
	{
		/// <summary>
		///   <para>Volume of original signal to pass to output. 0.0 to 1.0. Default = 0.5.</para>
		/// </summary>
		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060014DB RID: 5339
		// (set) Token: 0x060014DC RID: 5340
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
		///   <para>Volume of 1st chorus tap. 0.0 to 1.0. Default = 0.5.</para>
		/// </summary>
		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060014DD RID: 5341
		// (set) Token: 0x060014DE RID: 5342
		public extern float wetMix1
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Volume of 2nd chorus tap. This tap is 90 degrees out of phase of the first tap. 0.0 to 1.0. Default = 0.5.</para>
		/// </summary>
		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060014DF RID: 5343
		// (set) Token: 0x060014E0 RID: 5344
		public extern float wetMix2
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Volume of 3rd chorus tap. This tap is 90 degrees out of phase of the second tap. 0.0 to 1.0. Default = 0.5.</para>
		/// </summary>
		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060014E1 RID: 5345
		// (set) Token: 0x060014E2 RID: 5346
		public extern float wetMix3
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Chorus delay in ms. 0.1 to 100.0. Default = 40.0 ms.</para>
		/// </summary>
		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060014E3 RID: 5347
		// (set) Token: 0x060014E4 RID: 5348
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
		///   <para>Chorus modulation rate in hz. 0.0 to 20.0. Default = 0.8 hz.</para>
		/// </summary>
		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060014E5 RID: 5349
		// (set) Token: 0x060014E6 RID: 5350
		public extern float rate
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Chorus modulation depth. 0.0 to 1.0. Default = 0.03.</para>
		/// </summary>
		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060014E7 RID: 5351
		// (set) Token: 0x060014E8 RID: 5352
		public extern float depth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Chorus feedback. Controls how much of the wet signal gets fed back into the chorus buffer. 0.0 to 1.0. Default = 0.0.</para>
		/// </summary>
		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060014E9 RID: 5353
		// (set) Token: 0x060014EA RID: 5354
		[Obsolete("feedback is deprecated, this property does nothing.")]
		public extern float feedback
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
