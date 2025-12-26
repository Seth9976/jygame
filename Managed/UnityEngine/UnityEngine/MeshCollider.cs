using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A mesh collider allows you to do between meshes and primitives.</para>
	/// </summary>
	// Token: 0x02000112 RID: 274
	public sealed class MeshCollider : Collider
	{
		/// <summary>
		///   <para>The mesh object used for collision detection.</para>
		/// </summary>
		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x0600107F RID: 4223
		// (set) Token: 0x06001080 RID: 4224
		public extern Mesh sharedMesh
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Use a convex collider from the mesh.</para>
		/// </summary>
		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001081 RID: 4225
		// (set) Token: 0x06001082 RID: 4226
		public extern bool convex
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Uses interpolated normals for sphere collisions instead of flat polygonal normals.</para>
		/// </summary>
		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x000021E1 File Offset: 0x000003E1
		// (set) Token: 0x06001084 RID: 4228 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("Configuring smooth sphere collisions is no longer needed. PhysX3 has a better behaviour in place.")]
		public bool smoothSphereCollisions
		{
			get
			{
				return true;
			}
			set
			{
			}
		}
	}
}
