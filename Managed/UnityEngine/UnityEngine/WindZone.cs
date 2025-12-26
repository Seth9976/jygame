using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Wind Zones add realism to the trees you create by making them wave their branches and leaves as if blown by the wind.</para>
	/// </summary>
	// Token: 0x020000D9 RID: 217
	public sealed class WindZone : Component
	{
		/// <summary>
		///   <para>Defines the type of wind zone to be used (Spherical or Directional).</para>
		/// </summary>
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000D0F RID: 3343
		// (set) Token: 0x06000D10 RID: 3344
		public extern WindZoneMode mode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Radius of the Spherical Wind Zone (only active if the WindZoneMode is set to Spherical).</para>
		/// </summary>
		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000D11 RID: 3345
		// (set) Token: 0x06000D12 RID: 3346
		public extern float radius
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The primary wind force.</para>
		/// </summary>
		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000D13 RID: 3347
		// (set) Token: 0x06000D14 RID: 3348
		public extern float windMain
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The turbulence wind force.</para>
		/// </summary>
		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000D15 RID: 3349
		// (set) Token: 0x06000D16 RID: 3350
		public extern float windTurbulence
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Defines ow much the wind changes over time.</para>
		/// </summary>
		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000D17 RID: 3351
		// (set) Token: 0x06000D18 RID: 3352
		public extern float windPulseMagnitude
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Defines the frequency of the wind changes.</para>
		/// </summary>
		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000D19 RID: 3353
		// (set) Token: 0x06000D1A RID: 3354
		public extern float windPulseFrequency
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
