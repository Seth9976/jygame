using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The Audio Reverb Filter takes an Audio Clip and distortionates it in a.</para>
	/// </summary>
	// Token: 0x02000164 RID: 356
	public sealed class AudioReverbFilter : Behaviour
	{
		/// <summary>
		///   <para>Set/Get reverb preset properties.</para>
		/// </summary>
		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060014EC RID: 5356
		// (set) Token: 0x060014ED RID: 5357
		public extern AudioReverbPreset reverbPreset
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Mix level of dry signal in output in mB. Ranges from -10000.0 to 0.0. Default is 0.</para>
		/// </summary>
		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060014EE RID: 5358
		// (set) Token: 0x060014EF RID: 5359
		public extern float dryLevel
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Room effect level at low frequencies in mB. Ranges from -10000.0 to 0.0. Default is 0.0.</para>
		/// </summary>
		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060014F0 RID: 5360
		// (set) Token: 0x060014F1 RID: 5361
		public extern float room
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Room effect high-frequency level re. low frequency level in mB. Ranges from -10000.0 to 0.0. Default is 0.0.</para>
		/// </summary>
		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060014F2 RID: 5362
		// (set) Token: 0x060014F3 RID: 5363
		public extern float roomHF
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Rolloff factor for room effect. Ranges from 0.0 to 10.0. Default is 10.0.</para>
		/// </summary>
		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060014F4 RID: 5364
		// (set) Token: 0x060014F5 RID: 5365
		public extern float roomRolloff
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Reverberation decay time at low-frequencies in seconds. Ranges from 0.1 to 20.0. Default is 1.0.</para>
		/// </summary>
		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060014F6 RID: 5366
		// (set) Token: 0x060014F7 RID: 5367
		public extern float decayTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Decay HF Ratio : High-frequency to low-frequency decay time ratio. Ranges from 0.1 to 2.0. Default is 0.5.</para>
		/// </summary>
		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060014F8 RID: 5368
		// (set) Token: 0x060014F9 RID: 5369
		public extern float decayHFRatio
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Early reflections level relative to room effect in mB. Ranges from -10000.0 to 1000.0. Default is -10000.0.</para>
		/// </summary>
		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060014FA RID: 5370
		// (set) Token: 0x060014FB RID: 5371
		public extern float reflectionsLevel
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Late reverberation level relative to room effect in mB. Ranges from -10000.0 to 2000.0. Default is 0.0.</para>
		/// </summary>
		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060014FC RID: 5372
		// (set) Token: 0x060014FD RID: 5373
		public extern float reflectionsDelay
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Late reverberation level relative to room effect in mB. Ranges from -10000.0 to 2000.0. Default is 0.0.</para>
		/// </summary>
		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060014FE RID: 5374
		// (set) Token: 0x060014FF RID: 5375
		public extern float reverbLevel
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Late reverberation delay time relative to first reflection in seconds. Ranges from 0.0 to 0.1. Default is 0.04.</para>
		/// </summary>
		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001500 RID: 5376
		// (set) Token: 0x06001501 RID: 5377
		public extern float reverbDelay
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Reverberation diffusion (echo density) in percent. Ranges from 0.0 to 100.0. Default is 100.0.</para>
		/// </summary>
		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001502 RID: 5378
		// (set) Token: 0x06001503 RID: 5379
		public extern float diffusion
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Reverberation density (modal density) in percent. Ranges from 0.0 to 100.0. Default is 100.0.</para>
		/// </summary>
		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001504 RID: 5380
		// (set) Token: 0x06001505 RID: 5381
		public extern float density
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Reference high frequency in Hz. Ranges from 20.0 to 20000.0. Default is 5000.0.</para>
		/// </summary>
		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001506 RID: 5382
		// (set) Token: 0x06001507 RID: 5383
		public extern float hfReference
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Room effect low-frequency level in mB. Ranges from -10000.0 to 0.0. Default is 0.0.</para>
		/// </summary>
		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001508 RID: 5384
		// (set) Token: 0x06001509 RID: 5385
		public extern float roomLF
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Reference low-frequency in Hz. Ranges from 20.0 to 1000.0. Default is 250.0.</para>
		/// </summary>
		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600150A RID: 5386
		// (set) Token: 0x0600150B RID: 5387
		public extern float lfReference
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
