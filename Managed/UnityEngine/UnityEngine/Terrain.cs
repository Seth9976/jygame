using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine
{
	/// <summary>
	///   <para>The Terrain component renders the terrain.</para>
	/// </summary>
	// Token: 0x020001AA RID: 426
	public sealed class Terrain : Behaviour
	{
		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001887 RID: 6279
		// (set) Token: 0x06001888 RID: 6280
		public extern TerrainRenderFlags editorRenderFlags
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The Terrain Data that stores heightmaps, terrain textures, detail meshes and trees.</para>
		/// </summary>
		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001889 RID: 6281
		// (set) Token: 0x0600188A RID: 6282
		public extern TerrainData terrainData
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The maximum distance at which trees are rendered.</para>
		/// </summary>
		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600188B RID: 6283
		// (set) Token: 0x0600188C RID: 6284
		public extern float treeDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Distance from the camera where trees will be rendered as billboards only.</para>
		/// </summary>
		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600188D RID: 6285
		// (set) Token: 0x0600188E RID: 6286
		public extern float treeBillboardDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Total distance delta that trees will use to transition from billboard orientation to mesh orientation.</para>
		/// </summary>
		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x0600188F RID: 6287
		// (set) Token: 0x06001890 RID: 6288
		public extern float treeCrossFadeLength
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Maximum number of trees rendered at full LOD.</para>
		/// </summary>
		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001891 RID: 6289
		// (set) Token: 0x06001892 RID: 6290
		public extern int treeMaximumFullLODCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Detail objects will be displayed up to this distance.</para>
		/// </summary>
		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001893 RID: 6291
		// (set) Token: 0x06001894 RID: 6292
		public extern float detailObjectDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Density of detail objects.</para>
		/// </summary>
		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001895 RID: 6293
		// (set) Token: 0x06001896 RID: 6294
		public extern float detailObjectDensity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Collect Detail patches from memory.</para>
		/// </summary>
		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001897 RID: 6295
		// (set) Token: 0x06001898 RID: 6296
		public extern bool collectDetailPatches
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>An approximation of how many pixels the terrain will pop in the worst case when switching lod.</para>
		/// </summary>
		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001899 RID: 6297
		// (set) Token: 0x0600189A RID: 6298
		public extern float heightmapPixelError
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Lets you essentially lower the heightmap resolution used for rendering.</para>
		/// </summary>
		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600189B RID: 6299
		// (set) Token: 0x0600189C RID: 6300
		public extern int heightmapMaximumLOD
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Heightmap patches beyond basemap distance will use a precomputed low res basemap.</para>
		/// </summary>
		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600189D RID: 6301
		// (set) Token: 0x0600189E RID: 6302
		public extern float basemapDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x00008B47 File Offset: 0x00006D47
		// (set) Token: 0x060018A0 RID: 6304 RVA: 0x00008B4F File Offset: 0x00006D4F
		[Obsolete("use basemapDistance", true)]
		public float splatmapDistance
		{
			get
			{
				return this.basemapDistance;
			}
			set
			{
				this.basemapDistance = value;
			}
		}

		/// <summary>
		///   <para>The index of the baked lightmap applied to this terrain.</para>
		/// </summary>
		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060018A1 RID: 6305
		// (set) Token: 0x060018A2 RID: 6306
		public extern int lightmapIndex
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The index of the realtime lightmap applied to this terrain.</para>
		/// </summary>
		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060018A3 RID: 6307
		// (set) Token: 0x060018A4 RID: 6308
		public extern int realtimeLightmapIndex
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The UV scale &amp; offset used for a baked lightmap.</para>
		/// </summary>
		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x0001B77C File Offset: 0x0001997C
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x00008B58 File Offset: 0x00006D58
		public Vector4 lightmapScaleOffset
		{
			get
			{
				Vector4 vector;
				this.INTERNAL_get_lightmapScaleOffset(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_lightmapScaleOffset(ref value);
			}
		}

		// Token: 0x060018A7 RID: 6311
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_lightmapScaleOffset(out Vector4 value);

		// Token: 0x060018A8 RID: 6312
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_lightmapScaleOffset(ref Vector4 value);

		/// <summary>
		///   <para>The UV scale &amp; offset used for a realtime lightmap.</para>
		/// </summary>
		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x0001B794 File Offset: 0x00019994
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x00008B62 File Offset: 0x00006D62
		public Vector4 realtimeLightmapScaleOffset
		{
			get
			{
				Vector4 vector;
				this.INTERNAL_get_realtimeLightmapScaleOffset(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_realtimeLightmapScaleOffset(ref value);
			}
		}

		// Token: 0x060018AB RID: 6315
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_realtimeLightmapScaleOffset(out Vector4 value);

		// Token: 0x060018AC RID: 6316
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_realtimeLightmapScaleOffset(ref Vector4 value);

		/// <summary>
		///   <para>Should terrain cast shadows?.</para>
		/// </summary>
		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060018AD RID: 6317
		// (set) Token: 0x060018AE RID: 6318
		public extern bool castShadows
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How reflection probes are used for terrain. See Rendering.ReflectionProbeUsage.</para>
		/// </summary>
		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060018AF RID: 6319
		// (set) Token: 0x060018B0 RID: 6320
		public extern ReflectionProbeUsage reflectionProbeUsage
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x060018B1 RID: 6321
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetClosestReflectionProbesInternal(object result);

		// Token: 0x060018B2 RID: 6322 RVA: 0x00008B6C File Offset: 0x00006D6C
		public void GetClosestReflectionProbes(List<ReflectionProbeBlendInfo> result)
		{
			this.GetClosestReflectionProbesInternal(result);
		}

		/// <summary>
		///   <para>The type of the material used to render the terrain. Could be one of the built-in types or custom. See Terrain.MaterialType.</para>
		/// </summary>
		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060018B3 RID: 6323
		// (set) Token: 0x060018B4 RID: 6324
		public extern Terrain.MaterialType materialType
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The custom material used to render the terrain.</para>
		/// </summary>
		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060018B5 RID: 6325
		// (set) Token: 0x060018B6 RID: 6326
		public extern Material materialTemplate
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The specular color of the terrain.</para>
		/// </summary>
		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x0001B7AC File Offset: 0x000199AC
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x00008B75 File Offset: 0x00006D75
		public Color legacySpecular
		{
			get
			{
				Color color;
				this.INTERNAL_get_legacySpecular(out color);
				return color;
			}
			set
			{
				this.INTERNAL_set_legacySpecular(ref value);
			}
		}

		// Token: 0x060018B9 RID: 6329
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_legacySpecular(out Color value);

		// Token: 0x060018BA RID: 6330
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_legacySpecular(ref Color value);

		/// <summary>
		///   <para>The shininess value of the terrain.</para>
		/// </summary>
		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060018BB RID: 6331
		// (set) Token: 0x060018BC RID: 6332
		public extern float legacyShininess
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Specify if terrain heightmap should be drawn.</para>
		/// </summary>
		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060018BD RID: 6333
		// (set) Token: 0x060018BE RID: 6334
		public extern bool drawHeightmap
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Specify if terrain trees and details should be drawn.</para>
		/// </summary>
		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060018BF RID: 6335
		// (set) Token: 0x060018C0 RID: 6336
		public extern bool drawTreesAndFoliage
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Samples the height at the given position defined in world space, relative to the terrain space.</para>
		/// </summary>
		/// <param name="worldPosition"></param>
		// Token: 0x060018C1 RID: 6337 RVA: 0x00008B7F File Offset: 0x00006D7F
		public float SampleHeight(Vector3 worldPosition)
		{
			return Terrain.INTERNAL_CALL_SampleHeight(this, ref worldPosition);
		}

		// Token: 0x060018C2 RID: 6338
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_SampleHeight(Terrain self, ref Vector3 worldPosition);

		/// <summary>
		///   <para>Update the terrain's LOD and vegetation information after making changes with TerrainData.SetHeightsDelayLOD.</para>
		/// </summary>
		// Token: 0x060018C3 RID: 6339
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ApplyDelayedHeightmapModification();

		/// <summary>
		///   <para>Adds a tree instance to the terrain.</para>
		/// </summary>
		/// <param name="instance"></param>
		// Token: 0x060018C4 RID: 6340 RVA: 0x00008B89 File Offset: 0x00006D89
		public void AddTreeInstance(TreeInstance instance)
		{
			Terrain.INTERNAL_CALL_AddTreeInstance(this, ref instance);
		}

		// Token: 0x060018C5 RID: 6341
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddTreeInstance(Terrain self, ref TreeInstance instance);

		/// <summary>
		///   <para>Lets you setup the connection between neighboring Terrains.</para>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="top"></param>
		/// <param name="right"></param>
		/// <param name="bottom"></param>
		// Token: 0x060018C6 RID: 6342
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom);

		/// <summary>
		///   <para>Get the position of the terrain.</para>
		/// </summary>
		// Token: 0x060018C7 RID: 6343
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Vector3 GetPosition();

		/// <summary>
		///   <para>Flushes any change done in the terrain so it takes effect.</para>
		/// </summary>
		// Token: 0x060018C8 RID: 6344
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Flush();

		// Token: 0x060018C9 RID: 6345 RVA: 0x00008B93 File Offset: 0x00006D93
		internal void RemoveTrees(Vector2 position, float radius, int prototypeIndex)
		{
			Terrain.INTERNAL_CALL_RemoveTrees(this, ref position, radius, prototypeIndex);
		}

		// Token: 0x060018CA RID: 6346
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_RemoveTrees(Terrain self, ref Vector2 position, float radius, int prototypeIndex);

		/// <summary>
		///   <para>The active terrain. This is a convenience function to get to the main terrain in the scene.</para>
		/// </summary>
		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060018CB RID: 6347
		public static extern Terrain activeTerrain
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The active terrains in the scene.</para>
		/// </summary>
		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060018CC RID: 6348
		public static extern Terrain[] activeTerrains
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Creates a Terrain including collider from TerrainData.</para>
		/// </summary>
		/// <param name="assignTerrain"></param>
		// Token: 0x060018CD RID: 6349
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern GameObject CreateTerrainGameObject(TerrainData assignTerrain);

		/// <summary>
		///   <para>The type of the material used to render a terrain object. Could be one of the built-in types or custom.</para>
		/// </summary>
		// Token: 0x020001AB RID: 427
		public enum MaterialType
		{
			/// <summary>
			///   <para>A built-in material that uses the standard physically-based lighting model. Inputs supported: smoothness, metallic / specular, normal.</para>
			/// </summary>
			// Token: 0x04000533 RID: 1331
			BuiltInStandard,
			/// <summary>
			///   <para>A built-in material that uses the legacy Lambert (diffuse) lighting model and has optional normal map support.</para>
			/// </summary>
			// Token: 0x04000534 RID: 1332
			BuiltInLegacyDiffuse,
			/// <summary>
			///   <para>A built-in material that uses the legacy BlinnPhong (specular) lighting model and has optional normal map support.</para>
			/// </summary>
			// Token: 0x04000535 RID: 1333
			BuiltInLegacySpecular,
			/// <summary>
			///   <para>Use a custom material given by Terrain.materialTemplate.</para>
			/// </summary>
			// Token: 0x04000536 RID: 1334
			Custom
		}
	}
}
