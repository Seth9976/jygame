using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Struct used to describe meshes to be combined using Mesh.CombineMeshes.</para>
	/// </summary>
	// Token: 0x0200001E RID: 30
	public struct CombineInstance
	{
		/// <summary>
		///   <para>Mesh to combine.</para>
		/// </summary>
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000022D4 File Offset: 0x000004D4
		// (set) Token: 0x06000113 RID: 275 RVA: 0x000022E2 File Offset: 0x000004E2
		public Mesh mesh
		{
			get
			{
				return this.InternalGetMesh(this.m_MeshInstanceID);
			}
			set
			{
				this.m_MeshInstanceID = ((!(value != null)) ? 0 : value.GetInstanceID());
			}
		}

		/// <summary>
		///   <para>Submesh index of the mesh.</para>
		/// </summary>
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00002302 File Offset: 0x00000502
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000230A File Offset: 0x0000050A
		public int subMeshIndex
		{
			get
			{
				return this.m_SubMeshIndex;
			}
			set
			{
				this.m_SubMeshIndex = value;
			}
		}

		/// <summary>
		///   <para>Matrix to transform the mesh with before combining.</para>
		/// </summary>
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00002313 File Offset: 0x00000513
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0000231B File Offset: 0x0000051B
		public Matrix4x4 transform
		{
			get
			{
				return this.m_Transform;
			}
			set
			{
				this.m_Transform = value;
			}
		}

		// Token: 0x06000118 RID: 280
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Mesh InternalGetMesh(int instanceID);

		// Token: 0x0400007A RID: 122
		private int m_MeshInstanceID;

		// Token: 0x0400007B RID: 123
		private int m_SubMeshIndex;

		// Token: 0x0400007C RID: 124
		private Matrix4x4 m_Transform;
	}
}
