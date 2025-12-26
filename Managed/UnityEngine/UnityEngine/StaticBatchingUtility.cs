using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>StaticBatchingUtility can prepare your objects to take advantage of Unity's static batching.</para>
	/// </summary>
	// Token: 0x02000038 RID: 56
	public sealed class StaticBatchingUtility
	{
		/// <summary>
		///   <para>Combine will prepare all children of the staticBatchRoot for static batching.</para>
		/// </summary>
		/// <param name="staticBatchRoot"></param>
		// Token: 0x060002E1 RID: 737 RVA: 0x00002858 File Offset: 0x00000A58
		public static void Combine(GameObject staticBatchRoot)
		{
			InternalStaticBatchingUtility.CombineRoot(staticBatchRoot);
		}

		/// <summary>
		///   <para>Combine will prepare all gos for the static batching. staticBatchRoot will be treated as their parent.</para>
		/// </summary>
		/// <param name="gos"></param>
		/// <param name="staticBatchRoot"></param>
		// Token: 0x060002E2 RID: 738 RVA: 0x00002860 File Offset: 0x00000A60
		public static void Combine(GameObject[] gos, GameObject staticBatchRoot)
		{
			InternalStaticBatchingUtility.CombineGameObjects(gos, staticBatchRoot, false);
		}

		// Token: 0x060002E3 RID: 739
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Mesh InternalCombineVertices(MeshSubsetCombineUtility.MeshInstance[] meshes, string meshName);

		// Token: 0x060002E4 RID: 740
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalCombineIndices(MeshSubsetCombineUtility.SubMeshInstance[] submeshes, [Writable] Mesh combinedMesh);
	}
}
