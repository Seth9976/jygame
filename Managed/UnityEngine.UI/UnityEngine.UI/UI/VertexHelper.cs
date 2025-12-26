using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200009F RID: 159
	public class VertexHelper : IDisposable
	{
		// Token: 0x06000592 RID: 1426 RVA: 0x00017FC4 File Offset: 0x000161C4
		public VertexHelper()
		{
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00018024 File Offset: 0x00016224
		public VertexHelper(Mesh m)
		{
			this.m_Positions.AddRange(m.vertices);
			this.m_Colors.AddRange(m.colors32);
			this.m_Uv0S.AddRange(m.uv);
			this.m_Uv1S.AddRange(m.uv2);
			this.m_Normals.AddRange(m.normals);
			this.m_Tangents.AddRange(m.tangents);
			this.m_Indicies.AddRange(m.GetIndices(0));
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00018134 File Offset: 0x00016334
		public void Clear()
		{
			this.m_Positions.Clear();
			this.m_Colors.Clear();
			this.m_Uv0S.Clear();
			this.m_Uv1S.Clear();
			this.m_Normals.Clear();
			this.m_Tangents.Clear();
			this.m_Indicies.Clear();
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x00018190 File Offset: 0x00016390
		public int currentVertCount
		{
			get
			{
				return this.m_Positions.Count;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x000181A0 File Offset: 0x000163A0
		public int currentIndexCount
		{
			get
			{
				return this.m_Indicies.Count;
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000181B0 File Offset: 0x000163B0
		public void PopulateUIVertex(ref UIVertex vertex, int i)
		{
			vertex.position = this.m_Positions[i];
			vertex.color = this.m_Colors[i];
			vertex.uv0 = this.m_Uv0S[i];
			vertex.uv1 = this.m_Uv1S[i];
			vertex.normal = this.m_Normals[i];
			vertex.tangent = this.m_Tangents[i];
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0001822C File Offset: 0x0001642C
		public void SetUIVertex(UIVertex vertex, int i)
		{
			this.m_Positions[i] = vertex.position;
			this.m_Colors[i] = vertex.color;
			this.m_Uv0S[i] = vertex.uv0;
			this.m_Uv1S[i] = vertex.uv1;
			this.m_Normals[i] = vertex.normal;
			this.m_Tangents[i] = vertex.tangent;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000182AC File Offset: 0x000164AC
		public void FillMesh(Mesh mesh)
		{
			mesh.Clear();
			if (this.m_Positions.Count >= 65000)
			{
				throw new ArgumentException("Mesh can not have more than 65000 verticies");
			}
			mesh.SetVertices(this.m_Positions);
			mesh.SetColors(this.m_Colors);
			mesh.SetUVs(0, this.m_Uv0S);
			mesh.SetUVs(1, this.m_Uv1S);
			mesh.SetNormals(this.m_Normals);
			mesh.SetTangents(this.m_Tangents);
			mesh.SetTriangles(this.m_Indicies, 0);
			mesh.RecalculateBounds();
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0001833C File Offset: 0x0001653C
		public void Dispose()
		{
			ListPool<Vector3>.Release(this.m_Positions);
			ListPool<Color32>.Release(this.m_Colors);
			ListPool<Vector2>.Release(this.m_Uv0S);
			ListPool<Vector2>.Release(this.m_Uv1S);
			ListPool<Vector3>.Release(this.m_Normals);
			ListPool<Vector4>.Release(this.m_Tangents);
			ListPool<int>.Release(this.m_Indicies);
			this.m_Positions = null;
			this.m_Colors = null;
			this.m_Uv0S = null;
			this.m_Uv1S = null;
			this.m_Normals = null;
			this.m_Tangents = null;
			this.m_Indicies = null;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000183C8 File Offset: 0x000165C8
		public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector3 normal, Vector4 tangent)
		{
			this.m_Positions.Add(position);
			this.m_Colors.Add(color);
			this.m_Uv0S.Add(uv0);
			this.m_Uv1S.Add(uv1);
			this.m_Normals.Add(normal);
			this.m_Tangents.Add(tangent);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00018420 File Offset: 0x00016620
		public void AddVert(Vector3 position, Color32 color, Vector2 uv0)
		{
			this.AddVert(position, color, uv0, Vector2.zero, VertexHelper.s_DefaultNormal, VertexHelper.s_DefaultTangent);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00018448 File Offset: 0x00016648
		public void AddVert(UIVertex v)
		{
			this.AddVert(v.position, v.color, v.uv0, v.uv1, v.normal, v.tangent);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00018488 File Offset: 0x00016688
		public void AddTriangle(int idx0, int idx1, int idx2)
		{
			this.m_Indicies.Add(idx0);
			this.m_Indicies.Add(idx1);
			this.m_Indicies.Add(idx2);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000184BC File Offset: 0x000166BC
		public void AddUIVertexQuad(UIVertex[] verts)
		{
			int currentVertCount = this.currentVertCount;
			for (int i = 0; i < 4; i++)
			{
				this.AddVert(verts[i].position, verts[i].color, verts[i].uv0, verts[i].uv1, verts[i].normal, verts[i].tangent);
			}
			this.AddTriangle(currentVertCount, currentVertCount + 1, currentVertCount + 2);
			this.AddTriangle(currentVertCount + 2, currentVertCount + 3, currentVertCount);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0001854C File Offset: 0x0001674C
		public void AddUIVertexStream(List<UIVertex> verts, List<int> indicies)
		{
			if (verts != null)
			{
				CanvasRenderer.AddUIVertexStream(verts, this.m_Positions, this.m_Colors, this.m_Uv0S, this.m_Uv1S, this.m_Normals, this.m_Tangents);
			}
			if (indicies != null)
			{
				this.m_Indicies.AddRange(indicies);
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0001859C File Offset: 0x0001679C
		public void AddUIVertexTriangleStream(List<UIVertex> verts)
		{
			CanvasRenderer.SplitUIVertexStreams(verts, this.m_Positions, this.m_Colors, this.m_Uv0S, this.m_Uv1S, this.m_Normals, this.m_Tangents, this.m_Indicies);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000185DC File Offset: 0x000167DC
		public void GetUIVertexStream(List<UIVertex> stream)
		{
			CanvasRenderer.CreateUIVertexStream(stream, this.m_Positions, this.m_Colors, this.m_Uv0S, this.m_Uv1S, this.m_Normals, this.m_Tangents, this.m_Indicies);
		}

		// Token: 0x040002A6 RID: 678
		private List<Vector3> m_Positions = ListPool<Vector3>.Get();

		// Token: 0x040002A7 RID: 679
		private List<Color32> m_Colors = ListPool<Color32>.Get();

		// Token: 0x040002A8 RID: 680
		private List<Vector2> m_Uv0S = ListPool<Vector2>.Get();

		// Token: 0x040002A9 RID: 681
		private List<Vector2> m_Uv1S = ListPool<Vector2>.Get();

		// Token: 0x040002AA RID: 682
		private List<Vector3> m_Normals = ListPool<Vector3>.Get();

		// Token: 0x040002AB RID: 683
		private List<Vector4> m_Tangents = ListPool<Vector4>.Get();

		// Token: 0x040002AC RID: 684
		private List<int> m_Indicies = ListPool<int>.Get();

		// Token: 0x040002AD RID: 685
		private static readonly Vector4 s_DefaultTangent = new Vector4(1f, 0f, 0f, -1f);

		// Token: 0x040002AE RID: 686
		private static readonly Vector3 s_DefaultNormal = Vector3.back;
	}
}
