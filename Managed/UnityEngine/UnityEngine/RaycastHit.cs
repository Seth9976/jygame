using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Structure used to get information back from a raycast.</para>
	/// </summary>
	// Token: 0x02000115 RID: 277
	public struct RaycastHit
	{
		// Token: 0x060010B7 RID: 4279 RVA: 0x000073F1 File Offset: 0x000055F1
		private static void CalculateRaycastTexCoord(out Vector2 output, Collider col, Vector2 uv, Vector3 point, int face, int index)
		{
			RaycastHit.INTERNAL_CALL_CalculateRaycastTexCoord(out output, col, ref uv, ref point, face, index);
		}

		// Token: 0x060010B8 RID: 4280
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CalculateRaycastTexCoord(out Vector2 output, Collider col, ref Vector2 uv, ref Vector3 point, int face, int index);

		/// <summary>
		///   <para>The impact point in world space where the ray hit the collider.</para>
		/// </summary>
		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x00007402 File Offset: 0x00005602
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x0000740A File Offset: 0x0000560A
		public Vector3 point
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
		///   <para>The normal of the surface the ray hit.</para>
		/// </summary>
		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x00007413 File Offset: 0x00005613
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x0000741B File Offset: 0x0000561B
		public Vector3 normal
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
		///   <para>The barycentric coordinate of the triangle we hit.</para>
		/// </summary>
		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x00007424 File Offset: 0x00005624
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x0000745E File Offset: 0x0000565E
		public Vector3 barycentricCoordinate
		{
			get
			{
				return new Vector3(1f - (this.m_UV.y + this.m_UV.x), this.m_UV.x, this.m_UV.y);
			}
			set
			{
				this.m_UV = value;
			}
		}

		/// <summary>
		///   <para>The distance from the ray's origin to the impact point.</para>
		/// </summary>
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x0000746C File Offset: 0x0000566C
		// (set) Token: 0x060010C0 RID: 4288 RVA: 0x00007474 File Offset: 0x00005674
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
		///   <para>The index of the triangle that was hit.</para>
		/// </summary>
		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x0000747D File Offset: 0x0000567D
		public int triangleIndex
		{
			get
			{
				return this.m_FaceID;
			}
		}

		/// <summary>
		///   <para>The uv texture coordinate at the impact point.</para>
		/// </summary>
		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x00018E44 File Offset: 0x00017044
		public Vector2 textureCoord
		{
			get
			{
				Vector2 vector;
				RaycastHit.CalculateRaycastTexCoord(out vector, this.collider, this.m_UV, this.m_Point, this.m_FaceID, 0);
				return vector;
			}
		}

		/// <summary>
		///   <para>The secondary uv texture coordinate at the impact point.</para>
		/// </summary>
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x00018E74 File Offset: 0x00017074
		public Vector2 textureCoord2
		{
			get
			{
				Vector2 vector;
				RaycastHit.CalculateRaycastTexCoord(out vector, this.collider, this.m_UV, this.m_Point, this.m_FaceID, 1);
				return vector;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x00018E74 File Offset: 0x00017074
		[Obsolete("Use textureCoord2 instead")]
		public Vector2 textureCoord1
		{
			get
			{
				Vector2 vector;
				RaycastHit.CalculateRaycastTexCoord(out vector, this.collider, this.m_UV, this.m_Point, this.m_FaceID, 1);
				return vector;
			}
		}

		/// <summary>
		///   <para>The uv lightmap coordinate at the impact point.</para>
		/// </summary>
		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00018EA4 File Offset: 0x000170A4
		public Vector2 lightmapCoord
		{
			get
			{
				Vector2 vector;
				RaycastHit.CalculateRaycastTexCoord(out vector, this.collider, this.m_UV, this.m_Point, this.m_FaceID, 1);
				if (this.collider.GetComponent<Renderer>() != null)
				{
					Vector4 lightmapScaleOffset = this.collider.GetComponent<Renderer>().lightmapScaleOffset;
					vector.x = vector.x * lightmapScaleOffset.x + lightmapScaleOffset.z;
					vector.y = vector.y * lightmapScaleOffset.y + lightmapScaleOffset.w;
				}
				return vector;
			}
		}

		/// <summary>
		///   <para>The Collider that was hit.</para>
		/// </summary>
		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x00007485 File Offset: 0x00005685
		public Collider collider
		{
			get
			{
				return this.m_Collider;
			}
		}

		/// <summary>
		///   <para>The Rigidbody of the collider that was hit. If the collider is not attached to a rigidbody then it is null.</para>
		/// </summary>
		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x0000748D File Offset: 0x0000568D
		public Rigidbody rigidbody
		{
			get
			{
				return (!(this.collider != null)) ? null : this.collider.attachedRigidbody;
			}
		}

		/// <summary>
		///   <para>The Transform of the rigidbody or collider that was hit.</para>
		/// </summary>
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x00018F38 File Offset: 0x00017138
		public Transform transform
		{
			get
			{
				Rigidbody rigidbody = this.rigidbody;
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

		// Token: 0x04000324 RID: 804
		private Vector3 m_Point;

		// Token: 0x04000325 RID: 805
		private Vector3 m_Normal;

		// Token: 0x04000326 RID: 806
		private int m_FaceID;

		// Token: 0x04000327 RID: 807
		private float m_Distance;

		// Token: 0x04000328 RID: 808
		private Vector2 m_UV;

		// Token: 0x04000329 RID: 809
		private Collider m_Collider;
	}
}
