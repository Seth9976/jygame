using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A capsule-shaped primitive collider.</para>
	/// </summary>
	// Token: 0x02000113 RID: 275
	public sealed class CapsuleCollider : Collider
	{
		/// <summary>
		///   <para>The center of the capsule, measured in the object's local space.</para>
		/// </summary>
		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x00018DCC File Offset: 0x00016FCC
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x000073BF File Offset: 0x000055BF
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_center(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_center(ref value);
			}
		}

		// Token: 0x06001088 RID: 4232
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x06001089 RID: 4233
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		/// <summary>
		///   <para>The radius of the sphere, measured in the object's local space.</para>
		/// </summary>
		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x0600108A RID: 4234
		// (set) Token: 0x0600108B RID: 4235
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
		///   <para>The height of the capsule meased in the object's local space.</para>
		/// </summary>
		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x0600108C RID: 4236
		// (set) Token: 0x0600108D RID: 4237
		public extern float height
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The direction of the capsule.</para>
		/// </summary>
		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x0600108E RID: 4238
		// (set) Token: 0x0600108F RID: 4239
		public extern int direction
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
