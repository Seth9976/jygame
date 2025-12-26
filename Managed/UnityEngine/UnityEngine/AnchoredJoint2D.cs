using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Parent class for all joints that have anchor points.</para>
	/// </summary>
	// Token: 0x02000130 RID: 304
	public class AnchoredJoint2D : Joint2D
	{
		/// <summary>
		///   <para>The joint's anchor point on the object that has the joint component.</para>
		/// </summary>
		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x0001A0B4 File Offset: 0x000182B4
		// (set) Token: 0x0600129B RID: 4763 RVA: 0x0000798A File Offset: 0x00005B8A
		public Vector2 anchor
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_anchor(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_anchor(ref value);
			}
		}

		// Token: 0x0600129C RID: 4764
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_anchor(out Vector2 value);

		// Token: 0x0600129D RID: 4765
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_anchor(ref Vector2 value);

		/// <summary>
		///   <para>The joint's anchor point on the second object (ie, the one which doesn't have the joint component).</para>
		/// </summary>
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x0001A0CC File Offset: 0x000182CC
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x00007994 File Offset: 0x00005B94
		public Vector2 connectedAnchor
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_connectedAnchor(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_connectedAnchor(ref value);
			}
		}

		// Token: 0x060012A0 RID: 4768
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_connectedAnchor(out Vector2 value);

		// Token: 0x060012A1 RID: 4769
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_connectedAnchor(ref Vector2 value);
	}
}
