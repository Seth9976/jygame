using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Contains information about a tree placed in the Terrain game object.</para>
	/// </summary>
	// Token: 0x020001A6 RID: 422
	public struct TreeInstance
	{
		/// <summary>
		///   <para>Position of the tree.</para>
		/// </summary>
		// Token: 0x0400051D RID: 1309
		public Vector3 position;

		/// <summary>
		///   <para>Width scale of this instance (compared to the prototype's size).</para>
		/// </summary>
		// Token: 0x0400051E RID: 1310
		public float widthScale;

		/// <summary>
		///   <para>Height scale of this instance (compared to the prototype's size).</para>
		/// </summary>
		// Token: 0x0400051F RID: 1311
		public float heightScale;

		/// <summary>
		///   <para>Rotation of the tree on X-Z plane (in radians).</para>
		/// </summary>
		// Token: 0x04000520 RID: 1312
		public float rotation;

		/// <summary>
		///   <para>Color of this instance.</para>
		/// </summary>
		// Token: 0x04000521 RID: 1313
		public Color32 color;

		/// <summary>
		///   <para>Lightmap color calculated for this instance.</para>
		/// </summary>
		// Token: 0x04000522 RID: 1314
		public Color32 lightmapColor;

		/// <summary>
		///   <para>Index of this instance in the TerrainData.treePrototypes array.</para>
		/// </summary>
		// Token: 0x04000523 RID: 1315
		public int prototypeIndex;

		// Token: 0x04000524 RID: 1316
		internal float temporaryDistance;
	}
}
