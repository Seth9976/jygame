using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Applies forces to attract/repulse against a point.</para>
	/// </summary>
	// Token: 0x0200013D RID: 317
	public sealed class PointEffector2D : Effector2D
	{
		/// <summary>
		///   <para>The magnitude of the force to be applied.</para>
		/// </summary>
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600131C RID: 4892
		// (set) Token: 0x0600131D RID: 4893
		public extern float forceMagnitude
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The variation of the magnitude of the force to be applied.</para>
		/// </summary>
		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600131E RID: 4894
		// (set) Token: 0x0600131F RID: 4895
		public extern float forceVariation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The scale applied to the calculated distance between source and target.</para>
		/// </summary>
		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001320 RID: 4896
		// (set) Token: 0x06001321 RID: 4897
		public extern float distanceScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The linear drag to apply to rigid-bodies.</para>
		/// </summary>
		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001322 RID: 4898
		// (set) Token: 0x06001323 RID: 4899
		public extern float drag
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The angular drag to apply to rigid-bodies.</para>
		/// </summary>
		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001324 RID: 4900
		// (set) Token: 0x06001325 RID: 4901
		public extern float angularDrag
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The source which is used to calculate the centroid point of the effector.  The distance from the target is defined from this point.</para>
		/// </summary>
		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001326 RID: 4902
		// (set) Token: 0x06001327 RID: 4903
		public extern EffectorSelection2D forceSource
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The target for where the effector applies any force.</para>
		/// </summary>
		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001328 RID: 4904
		// (set) Token: 0x06001329 RID: 4905
		public extern EffectorSelection2D forceTarget
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The mode used to apply the effector force.</para>
		/// </summary>
		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600132A RID: 4906
		// (set) Token: 0x0600132B RID: 4907
		public extern EffectorForceMode2D forceMode
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
