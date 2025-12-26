using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>OcclusionArea is an area in which occlusion culling is performed.</para>
	/// </summary>
	// Token: 0x02000019 RID: 25
	public sealed class OcclusionArea : Component
	{
		/// <summary>
		///   <para>Center of the occlusion area relative to the transform.</para>
		/// </summary>
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000EFAC File Offset: 0x0000D1AC
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002281 File Offset: 0x00000481
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

		// Token: 0x06000094 RID: 148
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x06000095 RID: 149
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		/// <summary>
		///   <para>Size that the occlusion area will have.</para>
		/// </summary>
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000EFC4 File Offset: 0x0000D1C4
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000228B File Offset: 0x0000048B
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

		// Token: 0x06000098 RID: 152
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_size(out Vector3 value);

		// Token: 0x06000099 RID: 153
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_size(ref Vector3 value);
	}
}
