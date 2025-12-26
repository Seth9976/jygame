using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Represents an axis aligned bounding box.</para>
	/// </summary>
	// Token: 0x0200005D RID: 93
	public struct Bounds
	{
		/// <summary>
		///   <para>Creates new Bounds with a given center and total size. Bound extents will be half the given size.</para>
		/// </summary>
		/// <param name="center"></param>
		/// <param name="size"></param>
		// Token: 0x060005AB RID: 1451 RVA: 0x00004080 File Offset: 0x00002280
		public Bounds(Vector3 center, Vector3 size)
		{
			this.m_Center = center;
			this.m_Extents = size * 0.5f;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00012DC8 File Offset: 0x00010FC8
		public override int GetHashCode()
		{
			return this.center.GetHashCode() ^ (this.extents.GetHashCode() << 2);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00012DF4 File Offset: 0x00010FF4
		public override bool Equals(object other)
		{
			if (!(other is Bounds))
			{
				return false;
			}
			Bounds bounds = (Bounds)other;
			return this.center.Equals(bounds.center) && this.extents.Equals(bounds.extents);
		}

		/// <summary>
		///   <para>The center of the bounding box.</para>
		/// </summary>
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0000409A File Offset: 0x0000229A
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x000040A2 File Offset: 0x000022A2
		public Vector3 center
		{
			get
			{
				return this.m_Center;
			}
			set
			{
				this.m_Center = value;
			}
		}

		/// <summary>
		///   <para>The total size of the box. This is always twice as large as the extents.</para>
		/// </summary>
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x000040AB File Offset: 0x000022AB
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x000040BD File Offset: 0x000022BD
		public Vector3 size
		{
			get
			{
				return this.m_Extents * 2f;
			}
			set
			{
				this.m_Extents = value * 0.5f;
			}
		}

		/// <summary>
		///   <para>The extents of the box. This is always half of the size.</para>
		/// </summary>
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x000040D0 File Offset: 0x000022D0
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x000040D8 File Offset: 0x000022D8
		public Vector3 extents
		{
			get
			{
				return this.m_Extents;
			}
			set
			{
				this.m_Extents = value;
			}
		}

		/// <summary>
		///   <para>The minimal point of the box. This is always equal to center-extents.</para>
		/// </summary>
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x000040E1 File Offset: 0x000022E1
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x000040F4 File Offset: 0x000022F4
		public Vector3 min
		{
			get
			{
				return this.center - this.extents;
			}
			set
			{
				this.SetMinMax(value, this.max);
			}
		}

		/// <summary>
		///   <para>The maximal point of the box. This is always equal to center+extents.</para>
		/// </summary>
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00004103 File Offset: 0x00002303
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x00004116 File Offset: 0x00002316
		public Vector3 max
		{
			get
			{
				return this.center + this.extents;
			}
			set
			{
				this.SetMinMax(this.min, value);
			}
		}

		/// <summary>
		///   <para>Sets the bounds to the min and max value of the box.</para>
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		// Token: 0x060005B8 RID: 1464 RVA: 0x00004125 File Offset: 0x00002325
		public void SetMinMax(Vector3 min, Vector3 max)
		{
			this.extents = (max - min) * 0.5f;
			this.center = min + this.extents;
		}

		/// <summary>
		///   <para>Grows the Bounds to include the point.</para>
		/// </summary>
		/// <param name="point"></param>
		// Token: 0x060005B9 RID: 1465 RVA: 0x00004150 File Offset: 0x00002350
		public void Encapsulate(Vector3 point)
		{
			this.SetMinMax(Vector3.Min(this.min, point), Vector3.Max(this.max, point));
		}

		/// <summary>
		///   <para>Grow the bounds to encapsulate the bounds.</para>
		/// </summary>
		/// <param name="bounds"></param>
		// Token: 0x060005BA RID: 1466 RVA: 0x00004170 File Offset: 0x00002370
		public void Encapsulate(Bounds bounds)
		{
			this.Encapsulate(bounds.center - bounds.extents);
			this.Encapsulate(bounds.center + bounds.extents);
		}

		/// <summary>
		///   <para>Expand the bounds by increasing its size by amount along each side.</para>
		/// </summary>
		/// <param name="amount"></param>
		// Token: 0x060005BB RID: 1467 RVA: 0x000041A4 File Offset: 0x000023A4
		public void Expand(float amount)
		{
			amount *= 0.5f;
			this.extents += new Vector3(amount, amount, amount);
		}

		/// <summary>
		///   <para>Expand the bounds by increasing its size by amount along each side.</para>
		/// </summary>
		/// <param name="amount"></param>
		// Token: 0x060005BC RID: 1468 RVA: 0x000041C8 File Offset: 0x000023C8
		public void Expand(Vector3 amount)
		{
			this.extents += amount * 0.5f;
		}

		/// <summary>
		///   <para>Does another bounding box intersect with this bounding box?</para>
		/// </summary>
		/// <param name="bounds"></param>
		// Token: 0x060005BD RID: 1469 RVA: 0x00012E54 File Offset: 0x00011054
		public bool Intersects(Bounds bounds)
		{
			return this.min.x <= bounds.max.x && this.max.x >= bounds.min.x && this.min.y <= bounds.max.y && this.max.y >= bounds.min.y && this.min.z <= bounds.max.z && this.max.z >= bounds.min.z;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000041E6 File Offset: 0x000023E6
		private static bool Internal_Contains(Bounds m, Vector3 point)
		{
			return Bounds.INTERNAL_CALL_Internal_Contains(ref m, ref point);
		}

		// Token: 0x060005BF RID: 1471
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_Contains(ref Bounds m, ref Vector3 point);

		/// <summary>
		///   <para>Is point contained in the bounding box?</para>
		/// </summary>
		/// <param name="point"></param>
		// Token: 0x060005C0 RID: 1472 RVA: 0x000041F1 File Offset: 0x000023F1
		public bool Contains(Vector3 point)
		{
			return Bounds.Internal_Contains(this, point);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000041FF File Offset: 0x000023FF
		private static float Internal_SqrDistance(Bounds m, Vector3 point)
		{
			return Bounds.INTERNAL_CALL_Internal_SqrDistance(ref m, ref point);
		}

		// Token: 0x060005C2 RID: 1474
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_Internal_SqrDistance(ref Bounds m, ref Vector3 point);

		/// <summary>
		///   <para>The smallest squared distance between the point and this bounding box.</para>
		/// </summary>
		/// <param name="point"></param>
		// Token: 0x060005C3 RID: 1475 RVA: 0x0000420A File Offset: 0x0000240A
		public float SqrDistance(Vector3 point)
		{
			return Bounds.Internal_SqrDistance(this, point);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00004218 File Offset: 0x00002418
		private static bool Internal_IntersectRay(ref Ray ray, ref Bounds bounds, out float distance)
		{
			return Bounds.INTERNAL_CALL_Internal_IntersectRay(ref ray, ref bounds, out distance);
		}

		// Token: 0x060005C5 RID: 1477
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_IntersectRay(ref Ray ray, ref Bounds bounds, out float distance);

		/// <summary>
		///   <para>Does ray intersect this bounding box?</para>
		/// </summary>
		/// <param name="ray"></param>
		// Token: 0x060005C6 RID: 1478 RVA: 0x00012F38 File Offset: 0x00011138
		public bool IntersectRay(Ray ray)
		{
			float num;
			return Bounds.Internal_IntersectRay(ref ray, ref this, out num);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00004222 File Offset: 0x00002422
		public bool IntersectRay(Ray ray, out float distance)
		{
			return Bounds.Internal_IntersectRay(ref ray, ref this, out distance);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0000422D File Offset: 0x0000242D
		private static Vector3 Internal_GetClosestPoint(ref Bounds bounds, ref Vector3 point)
		{
			return Bounds.INTERNAL_CALL_Internal_GetClosestPoint(ref bounds, ref point);
		}

		// Token: 0x060005C9 RID: 1481
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_Internal_GetClosestPoint(ref Bounds bounds, ref Vector3 point);

		/// <summary>
		///   <para>The closest point on the bounding box.</para>
		/// </summary>
		/// <param name="point">Arbitrary point.</param>
		/// <returns>
		///   <para>The point on the bounding box or inside the bounding box.</para>
		/// </returns>
		// Token: 0x060005CA RID: 1482 RVA: 0x00004236 File Offset: 0x00002436
		public Vector3 ClosestPoint(Vector3 point)
		{
			return Bounds.Internal_GetClosestPoint(ref this, ref point);
		}

		/// <summary>
		///   <para>Returns a nicely formatted string for the bounds.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x060005CB RID: 1483 RVA: 0x00004240 File Offset: 0x00002440
		public override string ToString()
		{
			return UnityString.Format("Center: {0}, Extents: {1}", new object[] { this.m_Center, this.m_Extents });
		}

		/// <summary>
		///   <para>Returns a nicely formatted string for the bounds.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x060005CC RID: 1484 RVA: 0x0000426E File Offset: 0x0000246E
		public string ToString(string format)
		{
			return UnityString.Format("Center: {0}, Extents: {1}", new object[]
			{
				this.m_Center.ToString(format),
				this.m_Extents.ToString(format)
			});
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0000429E File Offset: 0x0000249E
		public static bool operator ==(Bounds lhs, Bounds rhs)
		{
			return lhs.center == rhs.center && lhs.extents == rhs.extents;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x000042CE File Offset: 0x000024CE
		public static bool operator !=(Bounds lhs, Bounds rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x040000F4 RID: 244
		private Vector3 m_Center;

		// Token: 0x040000F5 RID: 245
		private Vector3 m_Extents;
	}
}
