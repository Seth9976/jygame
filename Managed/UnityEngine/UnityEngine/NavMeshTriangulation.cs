using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Contains data describing a triangulation of a navmesh.</para>
	/// </summary>
	// Token: 0x02000143 RID: 323
	public struct NavMeshTriangulation
	{
		/// <summary>
		///   <para>NavMeshLayer values for the navmesh triangulation.</para>
		/// </summary>
		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x00007B51 File Offset: 0x00005D51
		[Obsolete("Use areas instead.")]
		public int[] layers
		{
			get
			{
				return this.areas;
			}
		}

		/// <summary>
		///   <para>Vertices for the navmesh triangulation.</para>
		/// </summary>
		// Token: 0x04000379 RID: 889
		public Vector3[] vertices;

		/// <summary>
		///   <para>Triangle indices for the navmesh triangulation.</para>
		/// </summary>
		// Token: 0x0400037A RID: 890
		public int[] indices;

		/// <summary>
		///   <para>NavMesh area indices for the navmesh triangulation.</para>
		/// </summary>
		// Token: 0x0400037B RID: 891
		public int[] areas;
	}
}
