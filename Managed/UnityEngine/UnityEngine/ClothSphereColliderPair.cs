using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>A pair of SphereColliders used to define shapes for Cloth objects to collide against.</para>
	/// </summary>
	// Token: 0x02000118 RID: 280
	public struct ClothSphereColliderPair
	{
		/// <summary>
		///   <para>Creates a ClothSphereColliderPair. If only one SphereCollider is given, the ClothSphereColliderPair will define a simple sphere. If two SphereColliders are given, the ClothSphereColliderPair defines a conic capsule shape, composed of the two spheres and the cone connecting the two.</para>
		/// </summary>
		/// <param name="a">The first SphereCollider of a ClothSphereColliderPair.</param>
		/// <param name="b">The second SphereCollider of a ClothSphereColliderPair.</param>
		// Token: 0x060010F9 RID: 4345 RVA: 0x000074FE File Offset: 0x000056FE
		public ClothSphereColliderPair(SphereCollider a)
		{
			this.m_First = null;
			this.m_Second = null;
			this.first = a;
			this.second = null;
		}

		/// <summary>
		///   <para>Creates a ClothSphereColliderPair. If only one SphereCollider is given, the ClothSphereColliderPair will define a simple sphere. If two SphereColliders are given, the ClothSphereColliderPair defines a conic capsule shape, composed of the two spheres and the cone connecting the two.</para>
		/// </summary>
		/// <param name="a">The first SphereCollider of a ClothSphereColliderPair.</param>
		/// <param name="b">The second SphereCollider of a ClothSphereColliderPair.</param>
		// Token: 0x060010FA RID: 4346 RVA: 0x0000751C File Offset: 0x0000571C
		public ClothSphereColliderPair(SphereCollider a, SphereCollider b)
		{
			this.m_First = null;
			this.m_Second = null;
			this.first = a;
			this.second = b;
		}

		/// <summary>
		///   <para>The first SphereCollider of a ClothSphereColliderPair.</para>
		/// </summary>
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x0000753A File Offset: 0x0000573A
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x00007542 File Offset: 0x00005742
		public SphereCollider first
		{
			get
			{
				return this.m_First;
			}
			set
			{
				this.m_First = value;
			}
		}

		/// <summary>
		///   <para>The second SphereCollider of a ClothSphereColliderPair.</para>
		/// </summary>
		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0000754B File Offset: 0x0000574B
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x00007553 File Offset: 0x00005753
		public SphereCollider second
		{
			get
			{
				return this.m_Second;
			}
			set
			{
				this.m_Second = value;
			}
		}

		// Token: 0x0400032A RID: 810
		private SphereCollider m_First;

		// Token: 0x0400032B RID: 811
		private SphereCollider m_Second;
	}
}
