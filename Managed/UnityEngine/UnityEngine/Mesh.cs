using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>A class that allows creating or modifying meshes from scripts.</para>
	/// </summary>
	// Token: 0x0200001F RID: 31
	public sealed class Mesh : Object
	{
		/// <summary>
		///   <para>Creates an empty mesh.</para>
		/// </summary>
		// Token: 0x06000119 RID: 281 RVA: 0x00002324 File Offset: 0x00000524
		public Mesh()
		{
			Mesh.Internal_Create(this);
		}

		// Token: 0x0600011A RID: 282
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] Mesh mono);

		/// <summary>
		///   <para>Clears all vertex data and all triangle indices.</para>
		/// </summary>
		/// <param name="keepVertexLayout"></param>
		// Token: 0x0600011B RID: 283
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Clear([DefaultValue("true")] bool keepVertexLayout);

		// Token: 0x0600011C RID: 284 RVA: 0x0000F0CC File Offset: 0x0000D2CC
		[ExcludeFromDocs]
		public void Clear()
		{
			bool flag = true;
			this.Clear(flag);
		}

		/// <summary>
		///   <para>Returns state of the Read/Write Enabled checkbox when model was imported.</para>
		/// </summary>
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600011D RID: 285
		public extern bool isReadable
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600011E RID: 286
		internal extern bool canAccess
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns a copy of the vertex positions or assigns a new vertex positions array.</para>
		/// </summary>
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600011F RID: 287
		// (set) Token: 0x06000120 RID: 288
		public extern Vector3[] vertices
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002332 File Offset: 0x00000532
		public void SetVertices(List<Vector3> inVertices)
		{
			this.SetVerticesInternal(inVertices);
		}

		// Token: 0x06000122 RID: 290
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetVerticesInternal(object vertices);

		/// <summary>
		///   <para>The normals of the mesh.</para>
		/// </summary>
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000123 RID: 291
		// (set) Token: 0x06000124 RID: 292
		public extern Vector3[] normals
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000233B File Offset: 0x0000053B
		public void SetNormals(List<Vector3> inNormals)
		{
			this.SetNormalsInternal(inNormals);
		}

		// Token: 0x06000126 RID: 294
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetNormalsInternal(object normals);

		/// <summary>
		///   <para>The tangents of the mesh.</para>
		/// </summary>
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000127 RID: 295
		// (set) Token: 0x06000128 RID: 296
		public extern Vector4[] tangents
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002344 File Offset: 0x00000544
		public void SetTangents(List<Vector4> inTangents)
		{
			this.SetTangentsInternal(inTangents);
		}

		// Token: 0x0600012A RID: 298
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetTangentsInternal(object tangents);

		/// <summary>
		///   <para>The base texture coordinates of the mesh.</para>
		/// </summary>
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600012B RID: 299
		// (set) Token: 0x0600012C RID: 300
		public extern Vector2[] uv
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The second texture coordinate set of the mesh, if present.</para>
		/// </summary>
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600012D RID: 301
		// (set) Token: 0x0600012E RID: 302
		public extern Vector2[] uv2
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The third texture coordinate set of the mesh, if present.</para>
		/// </summary>
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600012F RID: 303
		// (set) Token: 0x06000130 RID: 304
		public extern Vector2[] uv3
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The fourth texture coordinate set of the mesh, if present.</para>
		/// </summary>
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000131 RID: 305
		// (set) Token: 0x06000132 RID: 306
		public extern Vector2[] uv4
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000234D File Offset: 0x0000054D
		public void SetUVs(int channel, List<Vector2> uvs)
		{
			this.SetUVInternal(uvs, channel, 2);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002358 File Offset: 0x00000558
		public void SetUVs(int channel, List<Vector3> uvs)
		{
			this.SetUVInternal(uvs, channel, 3);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002363 File Offset: 0x00000563
		public void SetUVs(int channel, List<Vector4> uvs)
		{
			this.SetUVInternal(uvs, channel, 4);
		}

		// Token: 0x06000136 RID: 310
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetUVInternal(object uvs, int channel, int dim);

		/// <summary>
		///   <para>The bounding volume of the mesh.</para>
		/// </summary>
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000F0E4 File Offset: 0x0000D2E4
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0000236E File Offset: 0x0000056E
		public Bounds bounds
		{
			get
			{
				Bounds bounds;
				this.INTERNAL_get_bounds(out bounds);
				return bounds;
			}
			set
			{
				this.INTERNAL_set_bounds(ref value);
			}
		}

		// Token: 0x06000139 RID: 313
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bounds(out Bounds value);

		// Token: 0x0600013A RID: 314
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_bounds(ref Bounds value);

		/// <summary>
		///   <para>Vertex colors of the mesh.</para>
		/// </summary>
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600013B RID: 315
		// (set) Token: 0x0600013C RID: 316
		public extern Color[] colors
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002378 File Offset: 0x00000578
		public void SetColors(List<Color> inColors)
		{
			this.SetColorsInternal(inColors);
		}

		// Token: 0x0600013E RID: 318
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetColorsInternal(object colors);

		/// <summary>
		///   <para>Vertex colors of the mesh.</para>
		/// </summary>
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600013F RID: 319
		// (set) Token: 0x06000140 RID: 320
		public extern Color32[] colors32
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002381 File Offset: 0x00000581
		public void SetColors(List<Color32> inColors)
		{
			this.SetColors32Internal(inColors);
		}

		// Token: 0x06000142 RID: 322
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetColors32Internal(object colors);

		/// <summary>
		///   <para>Recalculate the bounding volume of the mesh from the vertices.</para>
		/// </summary>
		// Token: 0x06000143 RID: 323
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RecalculateBounds();

		/// <summary>
		///   <para>Recalculates the normals of the mesh from the triangles and vertices.</para>
		/// </summary>
		// Token: 0x06000144 RID: 324
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RecalculateNormals();

		/// <summary>
		///   <para>Optimizes the mesh for display.</para>
		/// </summary>
		// Token: 0x06000145 RID: 325
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Optimize();

		/// <summary>
		///   <para>An array containing all triangles in the mesh.</para>
		/// </summary>
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000146 RID: 326
		// (set) Token: 0x06000147 RID: 327
		public extern int[] triangles
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns the triangle list for the submesh.</para>
		/// </summary>
		/// <param name="submesh"></param>
		// Token: 0x06000148 RID: 328
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int[] GetTriangles(int submesh);

		/// <summary>
		///   <para>Sets the triangle list for the submesh.</para>
		/// </summary>
		/// <param name="inTriangles"></param>
		/// <param name="submesh"></param>
		/// <param name="triangles"></param>
		// Token: 0x06000149 RID: 329
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetTriangles(int[] triangles, int submesh);

		// Token: 0x0600014A RID: 330 RVA: 0x0000238A File Offset: 0x0000058A
		public void SetTriangles(List<int> inTriangles, int submesh)
		{
			this.SetTrianglesInternal(inTriangles, submesh);
		}

		// Token: 0x0600014B RID: 331
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetTrianglesInternal(object triangles, int submesh);

		/// <summary>
		///   <para>Returns the index buffer for the submesh.</para>
		/// </summary>
		/// <param name="submesh"></param>
		// Token: 0x0600014C RID: 332
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int[] GetIndices(int submesh);

		/// <summary>
		///   <para>Sets the index buffer for the submesh.</para>
		/// </summary>
		/// <param name="indices"></param>
		/// <param name="topology"></param>
		/// <param name="submesh"></param>
		// Token: 0x0600014D RID: 333
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetIndices(int[] indices, MeshTopology topology, int submesh);

		/// <summary>
		///   <para>Gets the topology of a submesh.</para>
		/// </summary>
		/// <param name="submesh"></param>
		// Token: 0x0600014E RID: 334
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MeshTopology GetTopology(int submesh);

		/// <summary>
		///   <para>Returns the number of vertices in the mesh (Read Only).</para>
		/// </summary>
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600014F RID: 335
		public extern int vertexCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The number of submeshes. Every material has a separate triangle list.</para>
		/// </summary>
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000150 RID: 336
		// (set) Token: 0x06000151 RID: 337
		public extern int subMeshCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Combines several meshes into this mesh.</para>
		/// </summary>
		/// <param name="combine">Descriptions of the meshes to combine.</param>
		/// <param name="mergeSubMeshes">Should all meshes be combined into a single submesh?</param>
		/// <param name="useMatrices">Should the transforms supplied in the CombineInstance array be used or ignored?</param>
		// Token: 0x06000152 RID: 338
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CombineMeshes(CombineInstance[] combine, [DefaultValue("true")] bool mergeSubMeshes, [DefaultValue("true")] bool useMatrices);

		// Token: 0x06000153 RID: 339 RVA: 0x0000F0FC File Offset: 0x0000D2FC
		[ExcludeFromDocs]
		public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes)
		{
			bool flag = true;
			this.CombineMeshes(combine, mergeSubMeshes, flag);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000F114 File Offset: 0x0000D314
		[ExcludeFromDocs]
		public void CombineMeshes(CombineInstance[] combine)
		{
			bool flag = true;
			bool flag2 = true;
			this.CombineMeshes(combine, flag2, flag);
		}

		/// <summary>
		///   <para>The bone weights of each vertex.</para>
		/// </summary>
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000155 RID: 341
		// (set) Token: 0x06000156 RID: 342
		public extern BoneWeight[] boneWeights
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The bind poses. The bind pose at each index refers to the bone with the same index.</para>
		/// </summary>
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000157 RID: 343
		// (set) Token: 0x06000158 RID: 344
		public extern Matrix4x4[] bindposes
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Optimize mesh for frequent updates.</para>
		/// </summary>
		// Token: 0x06000159 RID: 345
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void MarkDynamic();

		/// <summary>
		///   <para>Upload previously done mesh modifications to the graphics API.</para>
		/// </summary>
		/// <param name="markNoLogerReadable">Frees up system memory copy of mesh data when set to true.</param>
		// Token: 0x0600015A RID: 346
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UploadMeshData(bool markNoLogerReadable);

		/// <summary>
		///   <para>Returns BlendShape count on this mesh.</para>
		/// </summary>
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600015B RID: 347
		public extern int blendShapeCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns name of BlendShape by given index.</para>
		/// </summary>
		/// <param name="index"></param>
		// Token: 0x0600015C RID: 348
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string GetBlendShapeName(int index);

		// Token: 0x0600015D RID: 349
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetBlendShapeIndex(string blendShapeName);
	}
}
