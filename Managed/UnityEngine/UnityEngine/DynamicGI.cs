using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Allows to control the dynamic Global Illumination.</para>
	/// </summary>
	// Token: 0x020000DB RID: 219
	public sealed class DynamicGI
	{
		/// <summary>
		///   <para>Allows for scaling the contribution coming from realtime &amp; static  lightmaps.</para>
		/// </summary>
		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000D36 RID: 3382
		// (set) Token: 0x06000D37 RID: 3383
		public static extern float indirectScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Threshold for limiting updates of realtime GI.</para>
		/// </summary>
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000D38 RID: 3384
		// (set) Token: 0x06000D39 RID: 3385
		public static extern float updateThreshold
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00006930 File Offset: 0x00004B30
		public static void SetEmissive(Renderer renderer, Color color)
		{
			DynamicGI.INTERNAL_CALL_SetEmissive(renderer, ref color);
		}

		// Token: 0x06000D3B RID: 3387
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetEmissive(Renderer renderer, ref Color color);

		/// <summary>
		///   <para>Schedules an update of the albedo and emissive textures of a system that contains the renderer or the terrain.</para>
		/// </summary>
		/// <param name="renderer">The Renderer to use when searching for a system to update.</param>
		/// <param name="terrain">The Terrain to use when searching for systems to update.</param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		// Token: 0x06000D3C RID: 3388 RVA: 0x0000693A File Offset: 0x00004B3A
		public static void UpdateMaterials(Renderer renderer)
		{
			DynamicGI.UpdateMaterialsForRenderer(renderer);
		}

		// Token: 0x06000D3D RID: 3389
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void UpdateMaterialsForRenderer(Renderer renderer);

		/// <summary>
		///   <para>Schedules an update of the albedo and emissive textures of a system that contains the renderer or the terrain.</para>
		/// </summary>
		/// <param name="renderer">The Renderer to use when searching for a system to update.</param>
		/// <param name="terrain">The Terrain to use when searching for systems to update.</param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		// Token: 0x06000D3E RID: 3390 RVA: 0x00017A84 File Offset: 0x00015C84
		public static void UpdateMaterials(Terrain terrain)
		{
			if (terrain == null)
			{
				throw new ArgumentNullException("terrain");
			}
			if (terrain.terrainData == null)
			{
				throw new ArgumentException("Invalid terrainData.");
			}
			DynamicGI.UpdateMaterialsForTerrain(terrain, new Rect(0f, 0f, 1f, 1f));
		}

		/// <summary>
		///   <para>Schedules an update of the albedo and emissive textures of a system that contains the renderer or the terrain.</para>
		/// </summary>
		/// <param name="renderer">The Renderer to use when searching for a system to update.</param>
		/// <param name="terrain">The Terrain to use when searching for systems to update.</param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		// Token: 0x06000D3F RID: 3391 RVA: 0x00017AE4 File Offset: 0x00015CE4
		public static void UpdateMaterials(Terrain terrain, int x, int y, int width, int height)
		{
			if (terrain == null)
			{
				throw new ArgumentNullException("terrain");
			}
			if (terrain.terrainData == null)
			{
				throw new ArgumentException("Invalid terrainData.");
			}
			float num = (float)terrain.terrainData.alphamapWidth;
			float num2 = (float)terrain.terrainData.alphamapHeight;
			DynamicGI.UpdateMaterialsForTerrain(terrain, new Rect((float)x / num, (float)y / num2, (float)width / num, (float)height / num2));
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00006942 File Offset: 0x00004B42
		internal static void UpdateMaterialsForTerrain(Terrain terrain, Rect uvBounds)
		{
			DynamicGI.INTERNAL_CALL_UpdateMaterialsForTerrain(terrain, ref uvBounds);
		}

		// Token: 0x06000D41 RID: 3393
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_UpdateMaterialsForTerrain(Terrain terrain, ref Rect uvBounds);

		/// <summary>
		///   <para>Schedules an update of the environment texture.</para>
		/// </summary>
		// Token: 0x06000D42 RID: 3394
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdateEnvironment();

		/// <summary>
		///   <para>When enabled, new dynamic Global Illumination output is shown in each frame.</para>
		/// </summary>
		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000D43 RID: 3395
		// (set) Token: 0x06000D44 RID: 3396
		public static extern bool synchronousMode
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
