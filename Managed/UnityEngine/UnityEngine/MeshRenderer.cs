using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Renders meshes inserted by the MeshFilter or TextMesh.</para>
	/// </summary>
	// Token: 0x02000037 RID: 55
	public sealed class MeshRenderer : Renderer
	{
		/// <summary>
		///   <para>Vertex attributes in this mesh will override or add attributes of the primary mesh in the MeshRenderer.</para>
		/// </summary>
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002DE RID: 734
		// (set) Token: 0x060002DF RID: 735
		public extern Mesh additionalVertexStreams
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}
	}
}
