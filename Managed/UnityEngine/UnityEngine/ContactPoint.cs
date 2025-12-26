using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes a contact point where the collision occurs.</para>
	/// </summary>
	// Token: 0x02000103 RID: 259
	public struct ContactPoint
	{
		/// <summary>
		///   <para>The point of contact.</para>
		/// </summary>
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x0000706C File Offset: 0x0000526C
		public Vector3 point
		{
			get
			{
				return this.m_Point;
			}
		}

		/// <summary>
		///   <para>Normal of the contact point.</para>
		/// </summary>
		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x00007074 File Offset: 0x00005274
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		/// <summary>
		///   <para>The first collider in contact at the point.</para>
		/// </summary>
		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x0000707C File Offset: 0x0000527C
		public Collider thisCollider
		{
			get
			{
				return ContactPoint.ColliderFromInstanceId(this.m_ThisColliderInstanceID);
			}
		}

		/// <summary>
		///   <para>The other collider in contact at the point.</para>
		/// </summary>
		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x00007089 File Offset: 0x00005289
		public Collider otherCollider
		{
			get
			{
				return ContactPoint.ColliderFromInstanceId(this.m_OtherColliderInstanceID);
			}
		}

		// Token: 0x06000F0E RID: 3854
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider ColliderFromInstanceId(int instanceID);

		// Token: 0x04000312 RID: 786
		internal Vector3 m_Point;

		// Token: 0x04000313 RID: 787
		internal Vector3 m_Normal;

		// Token: 0x04000314 RID: 788
		internal int m_ThisColliderInstanceID;

		// Token: 0x04000315 RID: 789
		internal int m_OtherColliderInstanceID;
	}
}
