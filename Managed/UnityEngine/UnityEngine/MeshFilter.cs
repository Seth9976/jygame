using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A class to access the Mesh of the.</para>
	/// </summary>
	// Token: 0x0200001D RID: 29
	public sealed class MeshFilter : Component
	{
		/// <summary>
		///   <para>Returns the instantiated Mesh assigned to the mesh filter.</para>
		/// </summary>
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600010E RID: 270
		// (set) Token: 0x0600010F RID: 271
		public extern Mesh mesh
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns the shared mesh of the mesh filter.</para>
		/// </summary>
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000110 RID: 272
		// (set) Token: 0x06000111 RID: 273
		public extern Mesh sharedMesh
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
