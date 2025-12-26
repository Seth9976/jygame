using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Topology of Mesh faces.</para>
	/// </summary>
	// Token: 0x02000270 RID: 624
	public enum MeshTopology
	{
		/// <summary>
		///   <para>Mesh is made from triangles.</para>
		/// </summary>
		// Token: 0x04000934 RID: 2356
		Triangles,
		/// <summary>
		///   <para>Mesh is made from quads.</para>
		/// </summary>
		// Token: 0x04000935 RID: 2357
		Quads = 2,
		/// <summary>
		///   <para>Mesh is made from lines.</para>
		/// </summary>
		// Token: 0x04000936 RID: 2358
		Lines,
		/// <summary>
		///   <para>Mesh is a line strip.</para>
		/// </summary>
		// Token: 0x04000937 RID: 2359
		LineStrip,
		/// <summary>
		///   <para>Mesh is made from points.</para>
		/// </summary>
		// Token: 0x04000938 RID: 2360
		Points
	}
}
