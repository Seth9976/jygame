using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A base class for all 2D effectors.</para>
	/// </summary>
	// Token: 0x0200013B RID: 315
	public class Effector2D : Behaviour
	{
		/// <summary>
		///   <para>Should the collider-mask be used or the global collision matrix?</para>
		/// </summary>
		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001305 RID: 4869
		// (set) Token: 0x06001306 RID: 4870
		public extern bool useColliderMask
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The mask used to select specific layers allowed to interact with the effector.</para>
		/// </summary>
		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001307 RID: 4871
		// (set) Token: 0x06001308 RID: 4872
		public extern int colliderMask
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001309 RID: 4873
		internal extern bool requiresCollider
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600130A RID: 4874
		internal extern bool designedForTrigger
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600130B RID: 4875
		internal extern bool designedForNonTrigger
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
