using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Information about a particle collision.</para>
	/// </summary>
	// Token: 0x020000E4 RID: 228
	public struct ParticleCollisionEvent
	{
		/// <summary>
		///   <para>Intersection point of the collision in world coordinates.</para>
		/// </summary>
		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x00006A52 File Offset: 0x00004C52
		public Vector3 intersection
		{
			get
			{
				return this.m_Intersection;
			}
		}

		/// <summary>
		///   <para>Geometry normal at the intersection point of the collision.</para>
		/// </summary>
		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00006A5A File Offset: 0x00004C5A
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		/// <summary>
		///   <para>Incident velocity at the intersection point of the collision.</para>
		/// </summary>
		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x00006A62 File Offset: 0x00004C62
		public Vector3 velocity
		{
			get
			{
				return this.m_Velocity;
			}
		}

		/// <summary>
		///   <para>The Collider for the GameObject struck by the particles.</para>
		/// </summary>
		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00006A6A File Offset: 0x00004C6A
		public Collider collider
		{
			get
			{
				return ParticleCollisionEvent.InstanceIDToCollider(this.m_ColliderInstanceID);
			}
		}

		// Token: 0x06000DBB RID: 3515
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider InstanceIDToCollider(int instanceID);

		// Token: 0x04000294 RID: 660
		private Vector3 m_Intersection;

		// Token: 0x04000295 RID: 661
		private Vector3 m_Normal;

		// Token: 0x04000296 RID: 662
		private Vector3 m_Velocity;

		// Token: 0x04000297 RID: 663
		private int m_ColliderInstanceID;
	}
}
