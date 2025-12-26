using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>BillboardAsset describes how a billboard is rendered.</para>
	/// </summary>
	// Token: 0x020000D2 RID: 210
	public sealed class BillboardAsset : Object
	{
		/// <summary>
		///   <para>Width of the billboard.</para>
		/// </summary>
		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000CC5 RID: 3269
		// (set) Token: 0x06000CC6 RID: 3270
		public extern float width
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Height of the billboard.</para>
		/// </summary>
		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000CC7 RID: 3271
		// (set) Token: 0x06000CC8 RID: 3272
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
		///   <para>Height of the billboard that is below ground.</para>
		/// </summary>
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000CC9 RID: 3273
		// (set) Token: 0x06000CCA RID: 3274
		public extern float bottom
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Number of pre-baked images that can be switched when the billboard is viewed from different angles.</para>
		/// </summary>
		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000CCB RID: 3275
		public extern int imageCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Number of vertices in the billboard mesh. The mesh is not necessarily a quad. It can be a more complex shape which fits the actual image more precisely.</para>
		/// </summary>
		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000CCC RID: 3276
		public extern int vertexCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Number of indices in the billboard mesh. The mesh is not necessarily a quad. It can be a more complex shape which fits the actual image more precisely.</para>
		/// </summary>
		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000CCD RID: 3277
		public extern int indexCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The material used for rendering.</para>
		/// </summary>
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000CCE RID: 3278
		// (set) Token: 0x06000CCF RID: 3279
		public extern Material material
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000CD0 RID: 3280
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void MakeRenderMesh(Mesh mesh, float widthScale, float heightScale, float rotation);

		// Token: 0x06000CD1 RID: 3281
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void MakeMaterialProperties(MaterialPropertyBlock properties, Camera camera);

		// Token: 0x06000CD2 RID: 3282
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void MakePreviewMesh(Mesh mesh);
	}
}
