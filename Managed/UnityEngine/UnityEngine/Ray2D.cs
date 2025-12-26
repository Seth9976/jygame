using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>A ray in 2D space.</para>
	/// </summary>
	// Token: 0x02000060 RID: 96
	public struct Ray2D
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x00004621 File Offset: 0x00002821
		public Ray2D(Vector2 origin, Vector2 direction)
		{
			this.m_Origin = origin;
			this.m_Direction = direction.normalized;
		}

		/// <summary>
		///   <para>The starting point of the ray in world space.</para>
		/// </summary>
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00004637 File Offset: 0x00002837
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x0000463F File Offset: 0x0000283F
		public Vector2 origin
		{
			get
			{
				return this.m_Origin;
			}
			set
			{
				this.m_Origin = value;
			}
		}

		/// <summary>
		///   <para>The direction of the ray in world space.</para>
		/// </summary>
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x00004648 File Offset: 0x00002848
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x00004650 File Offset: 0x00002850
		public Vector2 direction
		{
			get
			{
				return this.m_Direction;
			}
			set
			{
				this.m_Direction = value.normalized;
			}
		}

		/// <summary>
		///   <para>Get a point that lies a given distance along a ray.</para>
		/// </summary>
		/// <param name="distance">Distance of the desired point along the path of the ray.</param>
		// Token: 0x06000606 RID: 1542 RVA: 0x0000465F File Offset: 0x0000285F
		public Vector2 GetPoint(float distance)
		{
			return this.m_Origin + this.m_Direction * distance;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00004678 File Offset: 0x00002878
		public override string ToString()
		{
			return UnityString.Format("Origin: {0}, Dir: {1}", new object[] { this.m_Origin, this.m_Direction });
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000046A6 File Offset: 0x000028A6
		public string ToString(string format)
		{
			return UnityString.Format("Origin: {0}, Dir: {1}", new object[]
			{
				this.m_Origin.ToString(format),
				this.m_Direction.ToString(format)
			});
		}

		// Token: 0x040000FD RID: 253
		private Vector2 m_Origin;

		// Token: 0x040000FE RID: 254
		private Vector2 m_Direction;
	}
}
