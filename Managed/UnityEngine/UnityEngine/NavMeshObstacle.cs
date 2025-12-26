using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>An obstacle for NavMeshAgents to avoid.</para>
	/// </summary>
	// Token: 0x02000146 RID: 326
	public sealed class NavMeshObstacle : Behaviour
	{
		/// <summary>
		///   <para>Height of the obstacle's cylinder shape.</para>
		/// </summary>
		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060013C9 RID: 5065
		// (set) Token: 0x060013CA RID: 5066
		public extern float height
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Radius of the obstacle's capsule shape.</para>
		/// </summary>
		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060013CB RID: 5067
		// (set) Token: 0x060013CC RID: 5068
		public extern float radius
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Velocity at which the obstacle moves around the NavMesh.</para>
		/// </summary>
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x0001A2B4 File Offset: 0x000184B4
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x00007BB9 File Offset: 0x00005DB9
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_velocity(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_velocity(ref value);
			}
		}

		// Token: 0x060013CF RID: 5071
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_velocity(out Vector3 value);

		// Token: 0x060013D0 RID: 5072
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_velocity(ref Vector3 value);

		/// <summary>
		///   <para>Should this obstacle make a cut-out in the navmesh.</para>
		/// </summary>
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060013D1 RID: 5073
		// (set) Token: 0x060013D2 RID: 5074
		public extern bool carving
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should this obstacle be carved when it is constantly moving?</para>
		/// </summary>
		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060013D3 RID: 5075
		// (set) Token: 0x060013D4 RID: 5076
		public extern bool carveOnlyStationary
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Threshold distance for updating a moving carved hole (when carving is enabled).</para>
		/// </summary>
		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060013D5 RID: 5077
		// (set) Token: 0x060013D6 RID: 5078
		public extern float carvingMoveThreshold
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Time to wait until obstacle is treated as stationary (when carving and carveOnlyStationary are enabled).</para>
		/// </summary>
		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060013D7 RID: 5079
		// (set) Token: 0x060013D8 RID: 5080
		public extern float carvingTimeToStationary
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Shape of the obstacle.</para>
		/// </summary>
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060013D9 RID: 5081
		// (set) Token: 0x060013DA RID: 5082
		public extern NavMeshObstacleShape shape
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The center of the obstacle, measured in the object's local space.</para>
		/// </summary>
		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x0001A2CC File Offset: 0x000184CC
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x00007BC3 File Offset: 0x00005DC3
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_center(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_center(ref value);
			}
		}

		// Token: 0x060013DD RID: 5085
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x060013DE RID: 5086
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		/// <summary>
		///   <para>The size of the obstacle, measured in the object's local space.</para>
		/// </summary>
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x0001A2E4 File Offset: 0x000184E4
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x00007BCD File Offset: 0x00005DCD
		public Vector3 size
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_size(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_size(ref value);
			}
		}

		// Token: 0x060013E1 RID: 5089
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_size(out Vector3 value);

		// Token: 0x060013E2 RID: 5090
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_size(ref Vector3 value);

		// Token: 0x060013E3 RID: 5091
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void FitExtents();
	}
}
