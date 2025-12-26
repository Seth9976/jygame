using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Information returned about an object detected by a raycast in 2D physics.</para>
	/// </summary>
	// Token: 0x0200011B RID: 283
	public struct RaycastHit2D
	{
		/// <summary>
		///   <para>The centroid of the primitive used to perform the cast.</para>
		/// </summary>
		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x000076EC File Offset: 0x000058EC
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x000076F4 File Offset: 0x000058F4
		public Vector2 centroid
		{
			get
			{
				return this.m_Centroid;
			}
			set
			{
				this.m_Centroid = value;
			}
		}

		/// <summary>
		///   <para>The point in world space where the ray hit the collider's surface.</para>
		/// </summary>
		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x000076FD File Offset: 0x000058FD
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x00007705 File Offset: 0x00005905
		public Vector2 point
		{
			get
			{
				return this.m_Point;
			}
			set
			{
				this.m_Point = value;
			}
		}

		/// <summary>
		///   <para>The normal vector of the surface hit by the ray.</para>
		/// </summary>
		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x0000770E File Offset: 0x0000590E
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x00007716 File Offset: 0x00005916
		public Vector2 normal
		{
			get
			{
				return this.m_Normal;
			}
			set
			{
				this.m_Normal = value;
			}
		}

		/// <summary>
		///   <para>The distance from the ray origin to the impact point.</para>
		/// </summary>
		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x0000771F File Offset: 0x0000591F
		// (set) Token: 0x060011EA RID: 4586 RVA: 0x00007727 File Offset: 0x00005927
		public float distance
		{
			get
			{
				return this.m_Distance;
			}
			set
			{
				this.m_Distance = value;
			}
		}

		/// <summary>
		///   <para>Fraction of the distance along the ray that the hit occurred.</para>
		/// </summary>
		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x00007730 File Offset: 0x00005930
		// (set) Token: 0x060011EC RID: 4588 RVA: 0x00007738 File Offset: 0x00005938
		public float fraction
		{
			get
			{
				return this.m_Fraction;
			}
			set
			{
				this.m_Fraction = value;
			}
		}

		/// <summary>
		///   <para>The collider hit by the ray.</para>
		/// </summary>
		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00007741 File Offset: 0x00005941
		public Collider2D collider
		{
			get
			{
				return this.m_Collider;
			}
		}

		/// <summary>
		///   <para>The Rigidbody2D attached to the object that was hit.</para>
		/// </summary>
		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x00007749 File Offset: 0x00005949
		public Rigidbody2D rigidbody
		{
			get
			{
				return (!(this.collider != null)) ? null : this.collider.attachedRigidbody;
			}
		}

		/// <summary>
		///   <para>The Transform of the object that was hit.</para>
		/// </summary>
		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x00019E10 File Offset: 0x00018010
		public Transform transform
		{
			get
			{
				Rigidbody2D rigidbody = this.rigidbody;
				if (rigidbody != null)
				{
					return rigidbody.transform;
				}
				if (this.collider != null)
				{
					return this.collider.transform;
				}
				return null;
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00019E58 File Offset: 0x00018058
		public int CompareTo(RaycastHit2D other)
		{
			if (this.collider == null)
			{
				return 1;
			}
			if (other.collider == null)
			{
				return -1;
			}
			return this.fraction.CompareTo(other.fraction);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0000776D File Offset: 0x0000596D
		public static implicit operator bool(RaycastHit2D hit)
		{
			return hit.collider != null;
		}

		// Token: 0x04000330 RID: 816
		private Vector2 m_Centroid;

		// Token: 0x04000331 RID: 817
		private Vector2 m_Point;

		// Token: 0x04000332 RID: 818
		private Vector2 m_Normal;

		// Token: 0x04000333 RID: 819
		private float m_Distance;

		// Token: 0x04000334 RID: 820
		private float m_Fraction;

		// Token: 0x04000335 RID: 821
		private Collider2D m_Collider;
	}
}
