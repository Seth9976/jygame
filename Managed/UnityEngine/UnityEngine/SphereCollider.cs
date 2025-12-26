using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A sphere-shaped primitive collider.</para>
	/// </summary>
	// Token: 0x02000111 RID: 273
	public sealed class SphereCollider : Collider
	{
		/// <summary>
		///   <para>The center of the sphere in the object's local space.</para>
		/// </summary>
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x00018DB4 File Offset: 0x00016FB4
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x000073B5 File Offset: 0x000055B5
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

		// Token: 0x0600107A RID: 4218
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x0600107B RID: 4219
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		/// <summary>
		///   <para>The radius of the sphere measured in the object's local space.</para>
		/// </summary>
		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x0600107C RID: 4220
		// (set) Token: 0x0600107D RID: 4221
		public extern float radius
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
