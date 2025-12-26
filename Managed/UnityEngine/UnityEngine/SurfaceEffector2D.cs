using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Applies tangent forces along the surfaces of colliders.</para>
	/// </summary>
	// Token: 0x0200013F RID: 319
	public sealed class SurfaceEffector2D : Effector2D
	{
		/// <summary>
		///   <para>The speed to be maintained along the surface.</para>
		/// </summary>
		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600133A RID: 4922
		// (set) Token: 0x0600133B RID: 4923
		public extern float speed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The speed variation (from zero to the variation) added to base speed to be applied.</para>
		/// </summary>
		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600133C RID: 4924
		// (set) Token: 0x0600133D RID: 4925
		public extern float speedVariation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The scale of the impulse force applied while attempting to reach the surface speed.</para>
		/// </summary>
		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600133E RID: 4926
		// (set) Token: 0x0600133F RID: 4927
		public extern float forceScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should the impulse force but applied to the contact point?</para>
		/// </summary>
		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001340 RID: 4928
		// (set) Token: 0x06001341 RID: 4929
		public extern bool useContactForce
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should friction be used for any contact with the surface?</para>
		/// </summary>
		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001342 RID: 4930
		// (set) Token: 0x06001343 RID: 4931
		public extern bool useFriction
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should bounce be used for any contact with the surface?</para>
		/// </summary>
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001344 RID: 4932
		// (set) Token: 0x06001345 RID: 4933
		public extern bool useBounce
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
