using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A component that will render to the screen after all normal rendering has completed when attached to a Canvas. Designed for GUI application.</para>
	/// </summary>
	// Token: 0x020001BF RID: 447
	public sealed class CanvasRenderer : Component
	{
		/// <summary>
		///   <para>Set the color of the renderer. Will be multiplied with the UIVertex color and the Canvas color.</para>
		/// </summary>
		/// <param name="color">Renderer multiply color.</param>
		// Token: 0x060019A5 RID: 6565 RVA: 0x00009085 File Offset: 0x00007285
		public void SetColor(Color color)
		{
			CanvasRenderer.INTERNAL_CALL_SetColor(this, ref color);
		}

		// Token: 0x060019A6 RID: 6566
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetColor(CanvasRenderer self, ref Color color);

		/// <summary>
		///   <para>Get the current color of the renderer.</para>
		/// </summary>
		// Token: 0x060019A7 RID: 6567
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color GetColor();

		/// <summary>
		///   <para>Get the current alpha of the renderer.</para>
		/// </summary>
		// Token: 0x060019A8 RID: 6568
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetAlpha();

		/// <summary>
		///   <para>Set the alpha of the renderer. Will be multiplied with the UIVertex alpha and the Canvas alpha.</para>
		/// </summary>
		/// <param name="alpha">Alpha.</param>
		// Token: 0x060019A9 RID: 6569
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetAlpha(float alpha);

		/// <summary>
		///   <para>Is the UIRenderer a mask component.</para>
		/// </summary>
		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060019AA RID: 6570
		// (set) Token: 0x060019AB RID: 6571
		[Obsolete("isMask is no longer supported. See EnableClipping for vertex clipping configuration")]
		public extern bool isMask
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x0000908F File Offset: 0x0000728F
		[Obsolete("UI System now uses meshes. Generate a mesh and use 'SetMesh' instead")]
		public void SetVertices(List<UIVertex> vertices)
		{
			this.SetVertices(vertices.ToArray(), vertices.Count);
		}

		/// <summary>
		///   <para>Set the vertices for the UIRenderer.</para>
		/// </summary>
		/// <param name="vertices">Array of vertices to set.</param>
		/// <param name="size">Number of vertices to set.</param>
		// Token: 0x060019AD RID: 6573 RVA: 0x0001BE48 File Offset: 0x0001A048
		[Obsolete("UI System now uses meshes. Generate a mesh and use 'SetMesh' instead")]
		public void SetVertices(UIVertex[] vertices, int size)
		{
			Mesh mesh = new Mesh();
			List<Vector3> list = new List<Vector3>();
			List<Color32> list2 = new List<Color32>();
			List<Vector2> list3 = new List<Vector2>();
			List<Vector2> list4 = new List<Vector2>();
			List<Vector3> list5 = new List<Vector3>();
			List<Vector4> list6 = new List<Vector4>();
			List<int> list7 = new List<int>();
			for (int i = 0; i < size; i += 4)
			{
				for (int j = 0; j < 4; j++)
				{
					list.Add(vertices[i + j].position);
					list2.Add(vertices[i + j].color);
					list3.Add(vertices[i + j].uv0);
					list4.Add(vertices[i + j].uv1);
					list5.Add(vertices[i + j].normal);
					list6.Add(vertices[i + j].tangent);
				}
				list7.Add(i);
				list7.Add(i + 1);
				list7.Add(i + 2);
				list7.Add(i + 2);
				list7.Add(i + 3);
				list7.Add(i);
			}
			mesh.SetVertices(list);
			mesh.SetColors(list2);
			mesh.SetNormals(list5);
			mesh.SetTangents(list6);
			mesh.SetUVs(0, list3);
			mesh.SetUVs(1, list4);
			mesh.SetIndices(list7.ToArray(), MeshTopology.Triangles, 0);
			this.SetMesh(mesh);
			Object.DestroyImmediate(mesh);
		}

		/// <summary>
		///   <para>Enables rect clipping on the CanvasRendered. Geometry outside of the specified rect will be clipped (not rendered).</para>
		/// </summary>
		/// <param name="rect"></param>
		// Token: 0x060019AE RID: 6574 RVA: 0x000090A3 File Offset: 0x000072A3
		public void EnableRectClipping(Rect rect)
		{
			CanvasRenderer.INTERNAL_CALL_EnableRectClipping(this, ref rect);
		}

		// Token: 0x060019AF RID: 6575
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_EnableRectClipping(CanvasRenderer self, ref Rect rect);

		/// <summary>
		///   <para>Disables rectangle clipping for this CanvasRenderer.</para>
		/// </summary>
		// Token: 0x060019B0 RID: 6576
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DisableRectClipping();

		/// <summary>
		///   <para>True if rect clipping has been enabled on this renderer.
		/// See Also: CanvasRenderer.EnableRectClipping, CanvasRenderer.DisableRectClipping.</para>
		/// </summary>
		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060019B1 RID: 6577
		public extern bool hasRectClipping
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Enable 'render stack' pop draw call.</para>
		/// </summary>
		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060019B2 RID: 6578
		// (set) Token: 0x060019B3 RID: 6579
		public extern bool hasPopInstruction
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The number of materials usable by this renderer.</para>
		/// </summary>
		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060019B4 RID: 6580
		// (set) Token: 0x060019B5 RID: 6581
		public extern int materialCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set the material for the canvas renderer. If a texture is specified then it will be used as the 'MainTex' instead of the material's 'MainTex'.
		/// See Also: CanvasRenderer.SetMaterialCount, CanvasRenderer.SetTexture.</para>
		/// </summary>
		/// <param name="material">Material for rendering.</param>
		/// <param name="texture">Material texture overide.</param>
		/// <param name="index">Material index.</param>
		// Token: 0x060019B6 RID: 6582
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetMaterial(Material material, int index);

		/// <summary>
		///   <para>Set the material for the canvas renderer. If a texture is specified then it will be used as the 'MainTex' instead of the material's 'MainTex'.
		/// See Also: CanvasRenderer.SetMaterialCount, CanvasRenderer.SetTexture.</para>
		/// </summary>
		/// <param name="material">Material for rendering.</param>
		/// <param name="texture">Material texture overide.</param>
		/// <param name="index">Material index.</param>
		// Token: 0x060019B7 RID: 6583 RVA: 0x000090AD File Offset: 0x000072AD
		public void SetMaterial(Material material, Texture texture)
		{
			this.materialCount = Math.Max(1, this.materialCount);
			this.SetMaterial(material, 0);
			this.SetTexture(texture);
		}

		/// <summary>
		///   <para>Gets the current Material assigned to the CanvasRenderer.</para>
		/// </summary>
		/// <param name="index">The material index to retrieve (0 if this parameter is omitted).</param>
		/// <returns>
		///   <para>Result.</para>
		/// </returns>
		// Token: 0x060019B8 RID: 6584 RVA: 0x000090D0 File Offset: 0x000072D0
		public Material GetMaterial()
		{
			return this.GetMaterial(0);
		}

		/// <summary>
		///   <para>Gets the current Material assigned to the CanvasRenderer.</para>
		/// </summary>
		/// <param name="index">The material index to retrieve (0 if this parameter is omitted).</param>
		/// <returns>
		///   <para>Result.</para>
		/// </returns>
		// Token: 0x060019B9 RID: 6585
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Material GetMaterial(int index);

		/// <summary>
		///   <para>The number of materials usable by this renderer. Used internally for masking.</para>
		/// </summary>
		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060019BA RID: 6586
		// (set) Token: 0x060019BB RID: 6587
		public extern int popMaterialCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set the material for the canvas renderer. Used internally for masking.</para>
		/// </summary>
		/// <param name="material"></param>
		/// <param name="index"></param>
		// Token: 0x060019BC RID: 6588
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPopMaterial(Material material, int index);

		/// <summary>
		///   <para>Gets the current Material assigned to the CanvasRenderer. Used internally for masking.</para>
		/// </summary>
		/// <param name="index"></param>
		// Token: 0x060019BD RID: 6589
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Material GetPopMaterial(int index);

		/// <summary>
		///   <para>Sets the texture used by this renderer's material.</para>
		/// </summary>
		/// <param name="texture"></param>
		// Token: 0x060019BE RID: 6590
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetTexture(Texture texture);

		/// <summary>
		///   <para>Sets the Mesh used by this renderer.</para>
		/// </summary>
		/// <param name="mesh"></param>
		// Token: 0x060019BF RID: 6591
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetMesh(Mesh mesh);

		/// <summary>
		///   <para>Remove all cached vertices.</para>
		/// </summary>
		// Token: 0x060019C0 RID: 6592
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Clear();

		// Token: 0x060019C1 RID: 6593 RVA: 0x000090D9 File Offset: 0x000072D9
		public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indicies)
		{
			CanvasRenderer.SplitUIVertexStreamsInternal(verts, positions, colors, uv0S, uv1S, normals, tangents);
			CanvasRenderer.SplitIndiciesStreamsInternal(verts, indicies);
		}

		// Token: 0x060019C2 RID: 6594
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object normals, object tangents);

		// Token: 0x060019C3 RID: 6595
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SplitIndiciesStreamsInternal(object verts, object indicies);

		// Token: 0x060019C4 RID: 6596 RVA: 0x000090F2 File Offset: 0x000072F2
		public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indicies)
		{
			CanvasRenderer.CreateUIVertexStreamInternal(verts, positions, colors, uv0S, uv1S, normals, tangents, indicies);
		}

		// Token: 0x060019C5 RID: 6597
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object normals, object tangents, object indicies);

		// Token: 0x060019C6 RID: 6598 RVA: 0x00009105 File Offset: 0x00007305
		public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents)
		{
			CanvasRenderer.SplitUIVertexStreamsInternal(verts, positions, colors, uv0S, uv1S, normals, tangents);
		}

		/// <summary>
		///   <para>Depth of the renderer realative to the parent canvas.</para>
		/// </summary>
		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060019C7 RID: 6599
		public extern int relativeDepth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Indicates whether geometry emitted by this rendered is ignored.</para>
		/// </summary>
		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060019C8 RID: 6600
		// (set) Token: 0x060019C9 RID: 6601
		public extern bool cull
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Depth of the renderer realitive to the root canvas.</para>
		/// </summary>
		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060019CA RID: 6602
		public extern int absoluteDepth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>True if any change has occured that would invalidate the positions of generated geometry.</para>
		/// </summary>
		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060019CB RID: 6603
		public extern bool hasMoved
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
