using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Representation of a plane in 3D space.</para>
	/// </summary>
	// Token: 0x02000061 RID: 97
	public struct Plane
	{
		/// <summary>
		///   <para>Creates a plane.</para>
		/// </summary>
		/// <param name="inNormal"></param>
		/// <param name="inPoint"></param>
		// Token: 0x06000609 RID: 1545 RVA: 0x000046D6 File Offset: 0x000028D6
		public Plane(Vector3 inNormal, Vector3 inPoint)
		{
			this.m_Normal = Vector3.Normalize(inNormal);
			this.m_Distance = -Vector3.Dot(inNormal, inPoint);
		}

		/// <summary>
		///   <para>Creates a plane.</para>
		/// </summary>
		/// <param name="inNormal"></param>
		/// <param name="d"></param>
		// Token: 0x0600060A RID: 1546 RVA: 0x000046F2 File Offset: 0x000028F2
		public Plane(Vector3 inNormal, float d)
		{
			this.m_Normal = Vector3.Normalize(inNormal);
			this.m_Distance = d;
		}

		/// <summary>
		///   <para>Creates a plane.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		// Token: 0x0600060B RID: 1547 RVA: 0x00004707 File Offset: 0x00002907
		public Plane(Vector3 a, Vector3 b, Vector3 c)
		{
			this.m_Normal = Vector3.Normalize(Vector3.Cross(b - a, c - a));
			this.m_Distance = -Vector3.Dot(this.m_Normal, a);
		}

		/// <summary>
		///   <para>Normal vector of the plane.</para>
		/// </summary>
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x0000473A File Offset: 0x0000293A
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00004742 File Offset: 0x00002942
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
		///   <para>Distance from the origin to the plane.</para>
		/// </summary>
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0000474B File Offset: 0x0000294B
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x00004753 File Offset: 0x00002953
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
		///   <para>Sets a plane using a point that lies within it along with a normal to orient it.</para>
		/// </summary>
		/// <param name="inNormal">The plane's normal vector.</param>
		/// <param name="inPoint">A point that lies on the plane.</param>
		// Token: 0x06000610 RID: 1552 RVA: 0x0000475C File Offset: 0x0000295C
		public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint)
		{
			this.normal = Vector3.Normalize(inNormal);
			this.distance = -Vector3.Dot(inNormal, inPoint);
		}

		/// <summary>
		///   <para>Sets a plane using three points that lie within it.  The points go around clockwise as you look down on the top surface of the plane.</para>
		/// </summary>
		/// <param name="a">First point in clockwise order.</param>
		/// <param name="b">Second point in clockwise order.</param>
		/// <param name="c">Third point in clockwise order.</param>
		// Token: 0x06000611 RID: 1553 RVA: 0x00004778 File Offset: 0x00002978
		public void Set3Points(Vector3 a, Vector3 b, Vector3 c)
		{
			this.normal = Vector3.Normalize(Vector3.Cross(b - a, c - a));
			this.distance = -Vector3.Dot(this.normal, a);
		}

		/// <summary>
		///   <para>Returns a signed distance from plane to point.</para>
		/// </summary>
		/// <param name="inPt"></param>
		// Token: 0x06000612 RID: 1554 RVA: 0x000047AB File Offset: 0x000029AB
		public float GetDistanceToPoint(Vector3 inPt)
		{
			return Vector3.Dot(this.normal, inPt) + this.distance;
		}

		/// <summary>
		///   <para>Is a point on the positive side of the plane?</para>
		/// </summary>
		/// <param name="inPt"></param>
		// Token: 0x06000613 RID: 1555 RVA: 0x000047C0 File Offset: 0x000029C0
		public bool GetSide(Vector3 inPt)
		{
			return Vector3.Dot(this.normal, inPt) + this.distance > 0f;
		}

		/// <summary>
		///   <para>Are two points on the same side of the plane?</para>
		/// </summary>
		/// <param name="inPt0"></param>
		/// <param name="inPt1"></param>
		// Token: 0x06000614 RID: 1556 RVA: 0x00013544 File Offset: 0x00011744
		public bool SameSide(Vector3 inPt0, Vector3 inPt1)
		{
			float distanceToPoint = this.GetDistanceToPoint(inPt0);
			float distanceToPoint2 = this.GetDistanceToPoint(inPt1);
			return (distanceToPoint > 0f && distanceToPoint2 > 0f) || (distanceToPoint <= 0f && distanceToPoint2 <= 0f);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00013594 File Offset: 0x00011794
		public bool Raycast(Ray ray, out float enter)
		{
			float num = Vector3.Dot(ray.direction, this.normal);
			float num2 = -Vector3.Dot(ray.origin, this.normal) - this.distance;
			if (Mathf.Approximately(num, 0f))
			{
				enter = 0f;
				return false;
			}
			enter = num2 / num;
			return enter > 0f;
		}

		// Token: 0x040000FF RID: 255
		private Vector3 m_Normal;

		// Token: 0x04000100 RID: 256
		private float m_Distance;
	}
}
