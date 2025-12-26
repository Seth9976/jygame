using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A box-shaped primitive collider.</para>
	/// </summary>
	// Token: 0x02000110 RID: 272
	public sealed class BoxCollider : Collider
	{
		/// <summary>
		///   <para>The center of the box, measured in the object's local space.</para>
		/// </summary>
		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x00018D84 File Offset: 0x00016F84
		// (set) Token: 0x0600106E RID: 4206 RVA: 0x0000737C File Offset: 0x0000557C
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

		// Token: 0x0600106F RID: 4207
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x06001070 RID: 4208
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		/// <summary>
		///   <para>The size of the box, measured in the object's local space.</para>
		/// </summary>
		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x00018D9C File Offset: 0x00016F9C
		// (set) Token: 0x06001072 RID: 4210 RVA: 0x00007386 File Offset: 0x00005586
		public Vector3 size
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_size(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_size(ref value);
			}
		}

		// Token: 0x06001073 RID: 4211
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_size(out Vector3 value);

		// Token: 0x06001074 RID: 4212
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_size(ref Vector3 value);

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x00007390 File Offset: 0x00005590
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x000073A2 File Offset: 0x000055A2
		[Obsolete("use BoxCollider.size instead.")]
		public Vector3 extents
		{
			get
			{
				return this.size * 0.5f;
			}
			set
			{
				this.size = value * 2f;
			}
		}
	}
}
