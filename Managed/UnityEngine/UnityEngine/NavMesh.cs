using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Singleton class to access the baked NavMesh.</para>
	/// </summary>
	// Token: 0x02000144 RID: 324
	public sealed class NavMesh
	{
		// Token: 0x060013AC RID: 5036 RVA: 0x00007B59 File Offset: 0x00005D59
		public static bool Raycast(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int areaMask)
		{
			return NavMesh.INTERNAL_CALL_Raycast(ref sourcePosition, ref targetPosition, out hit, areaMask);
		}

		// Token: 0x060013AD RID: 5037
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Raycast(ref Vector3 sourcePosition, ref Vector3 targetPosition, out NavMeshHit hit, int areaMask);

		/// <summary>
		///   <para>Calculate a path between two points and store the resulting path.</para>
		/// </summary>
		/// <param name="sourcePosition">The initial position of the path requested.</param>
		/// <param name="targetPosition">The final position of the path requested.</param>
		/// <param name="areaMask">A bitfield mask specifying which NavMesh areas can be passed when calculating a path.</param>
		/// <param name="path">The resulting path.</param>
		/// <returns>
		///   <para>True if a either a complete or partial path is found and false otherwise.</para>
		/// </returns>
		// Token: 0x060013AE RID: 5038 RVA: 0x00007B66 File Offset: 0x00005D66
		public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path)
		{
			path.ClearCorners();
			return NavMesh.CalculatePathInternal(sourcePosition, targetPosition, areaMask, path);
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00007B77 File Offset: 0x00005D77
		internal static bool CalculatePathInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path)
		{
			return NavMesh.INTERNAL_CALL_CalculatePathInternal(ref sourcePosition, ref targetPosition, areaMask, path);
		}

		// Token: 0x060013B0 RID: 5040
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_CalculatePathInternal(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path);

		// Token: 0x060013B1 RID: 5041 RVA: 0x00007B84 File Offset: 0x00005D84
		public static bool FindClosestEdge(Vector3 sourcePosition, out NavMeshHit hit, int areaMask)
		{
			return NavMesh.INTERNAL_CALL_FindClosestEdge(ref sourcePosition, out hit, areaMask);
		}

		// Token: 0x060013B2 RID: 5042
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_FindClosestEdge(ref Vector3 sourcePosition, out NavMeshHit hit, int areaMask);

		// Token: 0x060013B3 RID: 5043 RVA: 0x00007B8F File Offset: 0x00005D8F
		public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask)
		{
			return NavMesh.INTERNAL_CALL_SamplePosition(ref sourcePosition, out hit, maxDistance, areaMask);
		}

		// Token: 0x060013B4 RID: 5044
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_SamplePosition(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask);

		/// <summary>
		///   <para>Sets the cost for traversing over geometry of the layer type on all agents.</para>
		/// </summary>
		/// <param name="layer"></param>
		/// <param name="cost"></param>
		// Token: 0x060013B5 RID: 5045
		[WrapperlessIcall]
		[Obsolete("Use SetAreaCost instead.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetLayerCost(int layer, float cost);

		/// <summary>
		///   <para>Gets the cost for traversing over geometry of the layer type on all agents.</para>
		/// </summary>
		/// <param name="layer"></param>
		// Token: 0x060013B6 RID: 5046
		[Obsolete("Use GetAreaCost instead.")]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetLayerCost(int layer);

		/// <summary>
		///   <para>Returns the layer index for a named layer.</para>
		/// </summary>
		/// <param name="layerName"></param>
		// Token: 0x060013B7 RID: 5047
		[WrapperlessIcall]
		[Obsolete("Use GetAreaFromName instead.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNavMeshLayerFromName(string layerName);

		/// <summary>
		///   <para>Sets the cost for finding path over geometry of the area type on all agents.</para>
		/// </summary>
		/// <param name="areaIndex">Index of the area to set.</param>
		/// <param name="cost">New cost.</param>
		// Token: 0x060013B8 RID: 5048
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetAreaCost(int areaIndex, float cost);

		/// <summary>
		///   <para>Gets the cost for path finding over geometry of the area type.</para>
		/// </summary>
		/// <param name="areaIndex">Index of the area to get.</param>
		// Token: 0x060013B9 RID: 5049
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetAreaCost(int areaIndex);

		/// <summary>
		///   <para>Returns the area index for a named NavMesh area type.</para>
		/// </summary>
		/// <param name="areaName">Name of the area to look up.</param>
		/// <returns>
		///   <para>Index if the specified are, or -1 if no area found.</para>
		/// </returns>
		// Token: 0x060013BA RID: 5050
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetAreaFromName(string areaName);

		/// <summary>
		///   <para>Calculates triangulation of the current navmesh.</para>
		/// </summary>
		// Token: 0x060013BB RID: 5051 RVA: 0x0001A298 File Offset: 0x00018498
		public static NavMeshTriangulation CalculateTriangulation()
		{
			return (NavMeshTriangulation)NavMesh.TriangulateInternal();
		}

		// Token: 0x060013BC RID: 5052
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern object TriangulateInternal();

		// Token: 0x060013BD RID: 5053
		[WrapperlessIcall]
		[Obsolete("use NavMesh.CalculateTriangulation() instead.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Triangulate(out Vector3[] vertices, out int[] indices);

		// Token: 0x060013BE RID: 5054
		[WrapperlessIcall]
		[Obsolete("AddOffMeshLinks has no effect and is deprecated.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AddOffMeshLinks();

		// Token: 0x060013BF RID: 5055
		[Obsolete("RestoreNavMesh has no effect and is deprecated.")]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RestoreNavMesh();

		/// <summary>
		///   <para>Describes how far in the future the agents predict collisions for avoidance.</para>
		/// </summary>
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x00007B9B File Offset: 0x00005D9B
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x00007BA2 File Offset: 0x00005DA2
		public static float avoidancePredictionTime
		{
			get
			{
				return NavMesh.GetAvoidancePredictionTime();
			}
			set
			{
				NavMesh.SetAvoidancePredictionTime(value);
			}
		}

		// Token: 0x060013C2 RID: 5058
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetAvoidancePredictionTime(float t);

		// Token: 0x060013C3 RID: 5059
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float GetAvoidancePredictionTime();

		/// <summary>
		///   <para>The maximum amount of nodes processed each frame in the asynchronous pathfinding process.</para>
		/// </summary>
		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x00007BAA File Offset: 0x00005DAA
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x00007BB1 File Offset: 0x00005DB1
		public static int pathfindingIterationsPerFrame
		{
			get
			{
				return NavMesh.GetPathfindingIterationsPerFrame();
			}
			set
			{
				NavMesh.SetPathfindingIterationsPerFrame(value);
			}
		}

		// Token: 0x060013C6 RID: 5062
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetPathfindingIterationsPerFrame(int iter);

		// Token: 0x060013C7 RID: 5063
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetPathfindingIterationsPerFrame();

		/// <summary>
		///   <para>Area mask constant that includes all NavMesh areas.</para>
		/// </summary>
		// Token: 0x0400037C RID: 892
		public const int AllAreas = -1;
	}
}
