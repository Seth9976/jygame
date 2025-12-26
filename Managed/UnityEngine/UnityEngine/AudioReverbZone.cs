using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Reverb Zones are used when you want to create location based ambient effects in the scene.</para>
	/// </summary>
	// Token: 0x0200015E RID: 350
	public sealed class AudioReverbZone : Behaviour
	{
		/// <summary>
		///   <para>The distance from the centerpoint that the reverb will have full effect at. Default = 10.0.</para>
		/// </summary>
		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060014A0 RID: 5280
		// (set) Token: 0x060014A1 RID: 5281
		public extern float minDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The distance from the centerpoint that the reverb will not have any effect. Default = 15.0.</para>
		/// </summary>
		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060014A2 RID: 5282
		// (set) Token: 0x060014A3 RID: 5283
		public extern float maxDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set/Get reverb preset properties.</para>
		/// </summary>
		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060014A4 RID: 5284
		// (set) Token: 0x060014A5 RID: 5285
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
		///   <para>Room effect level (at mid frequencies).</para>
		/// </summary>
		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060014A6 RID: 5286
		// (set) Token: 0x060014A7 RID: 5287
		public extern int room
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Relative room effect level at high frequencies.</para>
		/// </summary>
		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060014A8 RID: 5288
		// (set) Token: 0x060014A9 RID: 5289
		public extern int roomHF
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Relative room effect level at low frequencies.</para>
		/// </summary>
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060014AA RID: 5290
		// (set) Token: 0x060014AB RID: 5291
		public extern int roomLF
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Reverberation decay time at mid frequencies.</para>
		/// </summary>
		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060014AC RID: 5292
		// (set) Token: 0x060014AD RID: 5293
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
		///   <para>High-frequency to mid-frequency decay time ratio.</para>
		/// </summary>
		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060014AE RID: 5294
		// (set) Token: 0x060014AF RID: 5295
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
		///   <para>Early reflections level relative to room effect.</para>
		/// </summary>
		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060014B0 RID: 5296
		// (set) Token: 0x060014B1 RID: 5297
		public extern int reflections
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Initial reflection delay time.</para>
		/// </summary>
		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060014B2 RID: 5298
		// (set) Token: 0x060014B3 RID: 5299
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
		///   <para>Late reverberation level relative to room effect.</para>
		/// </summary>
		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060014B4 RID: 5300
		// (set) Token: 0x060014B5 RID: 5301
		public extern int reverb
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Late reverberation delay time relative to initial reflection.</para>
		/// </summary>
		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060014B6 RID: 5302
		// (set) Token: 0x060014B7 RID: 5303
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
		///   <para>Reference high frequency (hz).</para>
		/// </summary>
		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060014B8 RID: 5304
		// (set) Token: 0x060014B9 RID: 5305
		public extern float HFReference
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Reference low frequency (hz).</para>
		/// </summary>
		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060014BA RID: 5306
		// (set) Token: 0x060014BB RID: 5307
		public extern float LFReference
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Like rolloffscale in global settings, but for reverb room size effect.</para>
		/// </summary>
		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060014BC RID: 5308
		// (set) Token: 0x060014BD RID: 5309
		public extern float roomRolloffFactor
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Value that controls the echo density in the late reverberation decay.</para>
		/// </summary>
		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060014BE RID: 5310
		// (set) Token: 0x060014BF RID: 5311
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
		///   <para>Value that controls the modal density in the late reverberation decay.</para>
		/// </summary>
		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060014C0 RID: 5312
		// (set) Token: 0x060014C1 RID: 5313
		public extern float density
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
