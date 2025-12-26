using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Applies "platform" behaviour such as one-way collisions etc.</para>
	/// </summary>
	// Token: 0x0200013E RID: 318
	public sealed class PlatformEffector2D : Effector2D
	{
		/// <summary>
		///   <para>Should the one-way collision behaviour be used?</para>
		/// </summary>
		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600132D RID: 4909
		// (set) Token: 0x0600132E RID: 4910
		public extern bool useOneWay
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Ensures that all contacts controlled by the one-way behaviour act the same.</para>
		/// </summary>
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x0600132F RID: 4911
		// (set) Token: 0x06001330 RID: 4912
		public extern bool useOneWayGrouping
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should friction be used on the platform sides?</para>
		/// </summary>
		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001331 RID: 4913
		// (set) Token: 0x06001332 RID: 4914
		public extern bool useSideFriction
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should bounce be used on the platform sides?</para>
		/// </summary>
		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001333 RID: 4915
		// (set) Token: 0x06001334 RID: 4916
		public extern bool useSideBounce
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The angle of an arc that defines the surface of the platform centered of the local 'up' of the effector.</para>
		/// </summary>
		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001335 RID: 4917
		// (set) Token: 0x06001336 RID: 4918
		public extern float surfaceArc
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The angle of an arc that defines the sides of the platform centered on the local 'left' and 'right' of the effector. Any collision normals within this arc are considered for the 'side' behaviours.</para>
		/// </summary>
		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001337 RID: 4919
		// (set) Token: 0x06001338 RID: 4920
		public extern float sideArc
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
