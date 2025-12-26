using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Applies forces within an area.</para>
	/// </summary>
	// Token: 0x0200013C RID: 316
	public sealed class AreaEffector2D : Effector2D
	{
		/// <summary>
		///   <para>The angle of the force to be applied.</para>
		/// </summary>
		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600130D RID: 4877
		// (set) Token: 0x0600130E RID: 4878
		public extern float forceAngle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should the forceAngle use global space?</para>
		/// </summary>
		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x0600130F RID: 4879
		// (set) Token: 0x06001310 RID: 4880
		public extern bool useGlobalAngle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The magnitude of the force to be applied.</para>
		/// </summary>
		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001311 RID: 4881
		// (set) Token: 0x06001312 RID: 4882
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
		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001313 RID: 4883
		// (set) Token: 0x06001314 RID: 4884
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
		///   <para>The linear drag to apply to rigid-bodies.</para>
		/// </summary>
		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001315 RID: 4885
		// (set) Token: 0x06001316 RID: 4886
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
		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001317 RID: 4887
		// (set) Token: 0x06001318 RID: 4888
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
		///   <para>The target for where the effector applies any force.</para>
		/// </summary>
		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001319 RID: 4889
		// (set) Token: 0x0600131A RID: 4890
		public extern EffectorSelection2D forceTarget
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
