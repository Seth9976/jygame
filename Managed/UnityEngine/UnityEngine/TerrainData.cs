using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The TerrainData class stores heightmaps, detail mesh positions, tree instances, and terrain texture alpha maps.</para>
	/// </summary>
	// Token: 0x020001A7 RID: 423
	public sealed class TerrainData : Object
	{
		// Token: 0x06001833 RID: 6195 RVA: 0x00008AF0 File Offset: 0x00006CF0
		public TerrainData()
		{
			this.Internal_Create(this);
		}

		// Token: 0x06001834 RID: 6196
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void Internal_Create([Writable] TerrainData terrainData);

		// Token: 0x06001835 RID: 6197
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern bool HasUser(GameObject user);

		// Token: 0x06001836 RID: 6198
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void AddUser(GameObject user);

		// Token: 0x06001837 RID: 6199
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void RemoveUser(GameObject user);

		/// <summary>
		///   <para>Width of the terrain in samples (Read Only).</para>
		/// </summary>
		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001838 RID: 6200
		public extern int heightmapWidth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Height of the terrain in samples (Read Only).</para>
		/// </summary>
		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001839 RID: 6201
		public extern int heightmapHeight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Resolution of the heightmap.</para>
		/// </summary>
		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x0600183A RID: 6202
		// (set) Token: 0x0600183B RID: 6203
		public extern int heightmapResolution
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The size of each heightmap sample.</para>
		/// </summary>
		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x0001B4E0 File Offset: 0x000196E0
		public Vector3 heightmapScale
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_heightmapScale(out vector);
				return vector;
			}
		}

		// Token: 0x0600183D RID: 6205
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_heightmapScale(out Vector3 value);

		/// <summary>
		///   <para>The total size in world units of the terrain.</para>
		/// </summary>
		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x0001B4F8 File Offset: 0x000196F8
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x00008AFF File Offset: 0x00006CFF
		public Vector3 size
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_size(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_size(ref value);
			}
		}

		// Token: 0x06001840 RID: 6208
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_size(out Vector3 value);

		// Token: 0x06001841 RID: 6209
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_size(ref Vector3 value);

		/// <summary>
		///   <para>The thickness of the terrain used for collision detection.</para>
		/// </summary>
		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001842 RID: 6210
		// (set) Token: 0x06001843 RID: 6211
		public extern float thickness
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Gets the height at a certain point x,y.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		// Token: 0x06001844 RID: 6212
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetHeight(int x, int y);

		/// <summary>
		///   <para>Gets an interpolated height at a point x,y.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		// Token: 0x06001845 RID: 6213
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetInterpolatedHeight(float x, float y);

		/// <summary>
		///   <para>Get an array of heightmap samples.</para>
		/// </summary>
		/// <param name="xBase">First x index of heightmap samples to retrieve.</param>
		/// <param name="yBase">First y index of heightmap samples to retrieve.</param>
		/// <param name="width">Number of samples to retrieve along the heightmap's x axis.</param>
		/// <param name="height">Number of samples to retrieve along the heightmap's y axis.</param>
		// Token: 0x06001846 RID: 6214
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float[,] GetHeights(int xBase, int yBase, int width, int height);

		/// <summary>
		///   <para>Set an array of heightmap samples.</para>
		/// </summary>
		/// <param name="xBase">First x index of heightmap samples to set.</param>
		/// <param name="yBase">First y index of heightmap samples to set.</param>
		/// <param name="heights">Array of heightmap samples to set (values range from 0 to 1, array indexed as [y,x]).</param>
		// Token: 0x06001847 RID: 6215 RVA: 0x0001B510 File Offset: 0x00019710
		public void SetHeights(int xBase, int yBase, float[,] heights)
		{
			if (heights == null)
			{
				throw new NullReferenceException();
			}
			if (xBase + heights.GetLength(1) > this.heightmapWidth || xBase + heights.GetLength(1) < 0 || yBase + heights.GetLength(0) < 0 || xBase < 0 || yBase < 0 || yBase + heights.GetLength(0) > this.heightmapHeight)
			{
				throw new ArgumentException(UnityString.Format("X or Y base out of bounds. Setting up to {0}x{1} while map size is {2}x{3}", new object[]
				{
					xBase + heights.GetLength(1),
					yBase + heights.GetLength(0),
					this.heightmapWidth,
					this.heightmapHeight
				}));
			}
			this.Internal_SetHeights(xBase, yBase, heights.GetLength(1), heights.GetLength(0), heights);
		}

		// Token: 0x06001848 RID: 6216
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights);

		// Token: 0x06001849 RID: 6217
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetHeightsDelayLOD(int xBase, int yBase, int width, int height, float[,] heights);

		/// <summary>
		///   <para>Set an array of heightmap samples.</para>
		/// </summary>
		/// <param name="xBase">First x index of heightmap samples to set.</param>
		/// <param name="yBase">First y index of heightmap samples to set.</param>
		/// <param name="heights">Array of heightmap samples to set (values range from 0 to 1, array indexed as [y,x]).</param>
		// Token: 0x0600184A RID: 6218 RVA: 0x0001B5E8 File Offset: 0x000197E8
		public void SetHeightsDelayLOD(int xBase, int yBase, float[,] heights)
		{
			if (heights == null)
			{
				throw new ArgumentNullException("heights");
			}
			int length = heights.GetLength(0);
			int length2 = heights.GetLength(1);
			if (xBase < 0 || xBase + length2 < 0 || xBase + length2 > this.heightmapWidth)
			{
				throw new ArgumentException(UnityString.Format("X out of bounds - trying to set {0}-{1} but the terrain ranges from 0-{2}", new object[]
				{
					xBase,
					xBase + length2,
					this.heightmapWidth
				}));
			}
			if (yBase < 0 || yBase + length < 0 || yBase + length > this.heightmapHeight)
			{
				throw new ArgumentException(UnityString.Format("Y out of bounds - trying to set {0}-{1} but the terrain ranges from 0-{2}", new object[]
				{
					yBase,
					yBase + length,
					this.heightmapHeight
				}));
			}
			this.Internal_SetHeightsDelayLOD(xBase, yBase, length2, length, heights);
		}

		/// <summary>
		///   <para>Gets the gradient of the terrain at point &amp;amp;amp;amp;lt;x,y&amp;amp;amp;amp;gt;.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		// Token: 0x0600184B RID: 6219
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetSteepness(float x, float y);

		/// <summary>
		///   <para>Get an interpolated normal at a given location.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		// Token: 0x0600184C RID: 6220
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Vector3 GetInterpolatedNormal(float x, float y);

		// Token: 0x0600184D RID: 6221
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern int GetAdjustedSize(int size);

		/// <summary>
		///   <para>Strength of the waving grass in the terrain.</para>
		/// </summary>
		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600184E RID: 6222
		// (set) Token: 0x0600184F RID: 6223
		public extern float wavingGrassStrength
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Amount of waving grass in the terrain.</para>
		/// </summary>
		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001850 RID: 6224
		// (set) Token: 0x06001851 RID: 6225
		public extern float wavingGrassAmount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Speed of the waving grass.</para>
		/// </summary>
		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001852 RID: 6226
		// (set) Token: 0x06001853 RID: 6227
		public extern float wavingGrassSpeed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Color of the waving grass that the terrain has.</para>
		/// </summary>
		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x0001B6D0 File Offset: 0x000198D0
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x00008B09 File Offset: 0x00006D09
		public Color wavingGrassTint
		{
			get
			{
				Color color;
				this.INTERNAL_get_wavingGrassTint(out color);
				return color;
			}
			set
			{
				this.INTERNAL_set_wavingGrassTint(ref value);
			}
		}

		// Token: 0x06001856 RID: 6230
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_wavingGrassTint(out Color value);

		// Token: 0x06001857 RID: 6231
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_wavingGrassTint(ref Color value);

		/// <summary>
		///   <para>Detail width of the TerrainData.</para>
		/// </summary>
		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001858 RID: 6232
		public extern int detailWidth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Detail height of the TerrainData.</para>
		/// </summary>
		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001859 RID: 6233
		public extern int detailHeight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Set the resolution of the detail map.</para>
		/// </summary>
		/// <param name="detailResolution">Specifies the number of pixels in the detail resolution map. A larger detailResolution, leads to more accurate detail object painting.</param>
		/// <param name="resolutionPerPatch">Specifies the size in pixels of each individually rendered detail patch. A larger number reduces draw calls, but might increase triangle count since detail patches are culled on a per batch basis. A recommended value is 16. If you use a very large detail object distance and your grass is very sparse, it makes sense to increase the value.</param>
		// Token: 0x0600185A RID: 6234
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetDetailResolution(int detailResolution, int resolutionPerPatch);

		/// <summary>
		///   <para>Detail Resolution of the TerrainData.</para>
		/// </summary>
		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600185B RID: 6235
		public extern int detailResolution
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600185C RID: 6236
		internal extern int detailResolutionPerPatch
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x0600185D RID: 6237
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void ResetDirtyDetails();

		/// <summary>
		///   <para>Reloads all the values of the available prototypes (ie, detail mesh assets) in the TerrainData Object.</para>
		/// </summary>
		// Token: 0x0600185E RID: 6238
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RefreshPrototypes();

		/// <summary>
		///   <para>Contains the detail texture/meshes that the terrain has.</para>
		/// </summary>
		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600185F RID: 6239
		// (set) Token: 0x06001860 RID: 6240
		public extern DetailPrototype[] detailPrototypes
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns an array of all supported detail layer indices in the area.</para>
		/// </summary>
		/// <param name="xBase"></param>
		/// <param name="yBase"></param>
		/// <param name="totalWidth"></param>
		/// <param name="totalHeight"></param>
		// Token: 0x06001861 RID: 6241
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int[] GetSupportedLayers(int xBase, int yBase, int totalWidth, int totalHeight);

		/// <summary>
		///   <para>Returns a 2D array of the detail object density in the specific location.</para>
		/// </summary>
		/// <param name="xBase"></param>
		/// <param name="yBase"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="layer"></param>
		// Token: 0x06001862 RID: 6242
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer);

		/// <summary>
		///   <para>Sets the detail layer density map.</para>
		/// </summary>
		/// <param name="xBase"></param>
		/// <param name="yBase"></param>
		/// <param name="layer"></param>
		/// <param name="details"></param>
		// Token: 0x06001863 RID: 6243 RVA: 0x00008B13 File Offset: 0x00006D13
		public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details)
		{
			this.Internal_SetDetailLayer(xBase, yBase, details.GetLength(1), details.GetLength(0), layer, details);
		}

		// Token: 0x06001864 RID: 6244
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data);

		/// <summary>
		///   <para>Contains the current trees placed in the terrain.</para>
		/// </summary>
		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001865 RID: 6245
		// (set) Token: 0x06001866 RID: 6246
		public extern TreeInstance[] treeInstances
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Get the tree instance at the specified index. It is used as a faster version of treeInstances[index] as this function doesn't create the entire tree instances array.</para>
		/// </summary>
		/// <param name="index">The index of the tree instance.</param>
		// Token: 0x06001867 RID: 6247
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern TreeInstance GetTreeInstance(int index);

		/// <summary>
		///   <para>Set the tree instance with new parameters at the specified index. However, TreeInstance.prototypeIndex and TreeInstance.position can not be changed otherwise an ArgumentException will be thrown.</para>
		/// </summary>
		/// <param name="index">The index of the tree instance.</param>
		/// <param name="instance">The new TreeInstance value.</param>
		// Token: 0x06001868 RID: 6248 RVA: 0x00008B30 File Offset: 0x00006D30
		public void SetTreeInstance(int index, TreeInstance instance)
		{
			TerrainData.INTERNAL_CALL_SetTreeInstance(this, index, ref instance);
		}

		// Token: 0x06001869 RID: 6249
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTreeInstance(TerrainData self, int index, ref TreeInstance instance);

		/// <summary>
		///   <para>Returns the number of tree instances.</para>
		/// </summary>
		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600186A RID: 6250
		public extern int treeInstanceCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The list of tree prototypes this are the ones available in the inspector.</para>
		/// </summary>
		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600186B RID: 6251
		// (set) Token: 0x0600186C RID: 6252
		public extern TreePrototype[] treePrototypes
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x0600186D RID: 6253
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void RemoveTreePrototype(int index);

		// Token: 0x0600186E RID: 6254
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void RecalculateTreePositions();

		// Token: 0x0600186F RID: 6255
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void RemoveDetailPrototype(int index);

		// Token: 0x06001870 RID: 6256
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern bool NeedUpgradeScaledTreePrototypes();

		// Token: 0x06001871 RID: 6257
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void UpgradeScaledTreePrototype();

		/// <summary>
		///   <para>Number of alpha map layers.</para>
		/// </summary>
		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001872 RID: 6258
		public extern int alphamapLayers
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns the alpha map at a position x, y given a width and height.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		// Token: 0x06001873 RID: 6259
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float[,,] GetAlphamaps(int x, int y, int width, int height);

		/// <summary>
		///   <para>Resolution of the alpha map.</para>
		/// </summary>
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001874 RID: 6260
		// (set) Token: 0x06001875 RID: 6261
		public extern int alphamapResolution
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Width of the alpha map.</para>
		/// </summary>
		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001876 RID: 6262
		public extern int alphamapWidth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Height of the alpha map.</para>
		/// </summary>
		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001877 RID: 6263
		public extern int alphamapHeight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Resolution of the base map used for rendering far patches on the terrain.</para>
		/// </summary>
		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001878 RID: 6264
		// (set) Token: 0x06001879 RID: 6265
		public extern int baseMapResolution
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Assign all splat values in the given map area.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="map"></param>
		// Token: 0x0600187A RID: 6266 RVA: 0x0001B6E8 File Offset: 0x000198E8
		public void SetAlphamaps(int x, int y, float[,,] map)
		{
			if (map.GetLength(2) != this.alphamapLayers)
			{
				throw new Exception(UnityString.Format("Float array size wrong (layers should be {0})", new object[] { this.alphamapLayers }));
			}
			this.Internal_SetAlphamaps(x, y, map.GetLength(1), map.GetLength(0), map);
		}

		// Token: 0x0600187B RID: 6267
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map);

		// Token: 0x0600187C RID: 6268
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void RecalculateBasemapIfDirty();

		// Token: 0x0600187D RID: 6269
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetBasemapDirty(bool dirty);

		// Token: 0x0600187E RID: 6270
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Texture2D GetAlphamapTexture(int index);

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x0600187F RID: 6271
		private extern int alphamapTextureCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Alpha map textures used by the Terrain. Used by Terrain Inspector for undo.</para>
		/// </summary>
		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x0001B744 File Offset: 0x00019944
		public Texture2D[] alphamapTextures
		{
			get
			{
				Texture2D[] array = new Texture2D[this.alphamapTextureCount];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = this.GetAlphamapTexture(i);
				}
				return array;
			}
		}

		/// <summary>
		///   <para>Splat texture used by the terrain.</para>
		/// </summary>
		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001881 RID: 6273
		// (set) Token: 0x06001882 RID: 6274
		public extern SplatPrototype[] splatPrototypes
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001883 RID: 6275
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void AddTree(out TreeInstance tree);

		// Token: 0x06001884 RID: 6276 RVA: 0x00008B3B File Offset: 0x00006D3B
		internal int RemoveTrees(Vector2 position, float radius, int prototypeIndex)
		{
			return TerrainData.INTERNAL_CALL_RemoveTrees(this, ref position, radius, prototypeIndex);
		}

		// Token: 0x06001885 RID: 6277
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_RemoveTrees(TerrainData self, ref Vector2 position, float radius, int prototypeIndex);
	}
}
