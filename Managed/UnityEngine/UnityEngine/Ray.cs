using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Representation of rays.</para>
	/// </summary>
	// Token: 0x0200005F RID: 95
	public struct Ray
	{
		/// <summary>
		///   <para>Creates a ray starting at origin along direction.</para>
		/// </summary>
		/// <param name="origin"></param>
		/// <param name="direction"></param>
		// Token: 0x060005F9 RID: 1529 RVA: 0x0000456C File Offset: 0x0000276C
		public Ray(Vector3 origin, Vector3 direction)
		{
			this.m_Origin = origin;
			this.m_Direction = direction.normalized;
		}

		/// <summary>
		///   <para>The origin point of the ray.</para>
		/// </summary>
		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00004582 File Offset: 0x00002782
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x0000458A File Offset: 0x0000278A
		public Vector3 origin
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
		///   <para>The direction of the ray.</para>
		/// </summary>
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x00004593 File Offset: 0x00002793
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x0000459B File Offset: 0x0000279B
		public Vector3 direction
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
		///   <para>Returns a point at distance units along the ray.</para>
		/// </summary>
		/// <param name="distance"></param>
		// Token: 0x060005FE RID: 1534 RVA: 0x000045AA File Offset: 0x000027AA
		public Vector3 GetPoint(float distance)
		{
			return this.m_Origin + this.m_Direction * distance;
		}

		/// <summary>
		///   <para>Returns a nicely formatted string for this ray.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x060005FF RID: 1535 RVA: 0x000045C3 File Offset: 0x000027C3
		public override string ToString()
		{
			return UnityString.Format("Origin: {0}, Dir: {1}", new object[] { this.m_Origin, this.m_Direction });
		}

		/// <summary>
		///   <para>Returns a nicely formatted string for this ray.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x06000600 RID: 1536 RVA: 0x000045F1 File Offset: 0x000027F1
		public string ToString(string format)
		{
			return UnityString.Format("Origin: {0}, Dir: {1}", new object[]
			{
				this.m_Origin.ToString(format),
				this.m_Direction.ToString(format)
			});
		}

		// Token: 0x040000FB RID: 251
		private Vector3 m_Origin;

		// Token: 0x040000FC RID: 252
		private Vector3 m_Direction;
	}
}
