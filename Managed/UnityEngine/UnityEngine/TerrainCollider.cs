using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A heightmap based collider.</para>
	/// </summary>
	// Token: 0x020001C1 RID: 449
	public sealed class TerrainCollider : Collider
	{
		/// <summary>
		///   <para>The terrain that stores the heightmap.</para>
		/// </summary>
		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060019DF RID: 6623
		// (set) Token: 0x060019E0 RID: 6624
		public extern TerrainData terrainData
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
