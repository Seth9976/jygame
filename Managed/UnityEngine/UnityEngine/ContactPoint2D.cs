using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Details about a specific point of contact involved in a 2D physics collision.</para>
	/// </summary>
	// Token: 0x02000128 RID: 296
	public struct ContactPoint2D
	{
		/// <summary>
		///   <para>The point of contact between the two colliders in world space.</para>
		/// </summary>
		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x00007845 File Offset: 0x00005A45
		public Vector2 point
		{
			get
			{
				return this.m_Point;
			}
		}

		/// <summary>
		///   <para>Surface normal at the contact point.</para>
		/// </summary>
		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x0000784D File Offset: 0x00005A4D
		public Vector2 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		/// <summary>
		///   <para>The collider attached to the object receiving the collision message.</para>
		/// </summary>
		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00007855 File Offset: 0x00005A55
		public Collider2D collider
		{
			get
			{
				return this.m_Collider;
			}
		}

		/// <summary>
		///   <para>The incoming collider involved in the collision at this contact point.</para>
		/// </summary>
		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x0000785D File Offset: 0x00005A5D
		public Collider2D otherCollider
		{
			get
			{
				return this.m_OtherCollider;
			}
		}

		// Token: 0x04000350 RID: 848
		internal Vector2 m_Point;

		// Token: 0x04000351 RID: 849
		internal Vector2 m_Normal;

		// Token: 0x04000352 RID: 850
		internal Collider2D m_Collider;

		// Token: 0x04000353 RID: 851
		internal Collider2D m_OtherCollider;
	}
}
