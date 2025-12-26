using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Collider for 2D physics representing an axis-aligned rectangle.</para>
	/// </summary>
	// Token: 0x02000125 RID: 293
	public sealed class BoxCollider2D : Collider2D
	{
		/// <summary>
		///   <para>The width and height of the rectangle.</para>
		/// </summary>
		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x0001A058 File Offset: 0x00018258
		// (set) Token: 0x06001261 RID: 4705 RVA: 0x0000782E File Offset: 0x00005A2E
		public Vector2 size
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_size(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_size(ref value);
			}
		}

		// Token: 0x06001262 RID: 4706
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_size(out Vector2 value);

		// Token: 0x06001263 RID: 4707
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_size(ref Vector2 value);
	}
}
