using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Class for ProceduralMaterial handling.</para>
	/// </summary>
	// Token: 0x02000092 RID: 146
	public sealed class ProceduralMaterial : Material
	{
		// Token: 0x06000863 RID: 2147 RVA: 0x000054C0 File Offset: 0x000036C0
		internal ProceduralMaterial()
			: base(null)
		{
		}

		/// <summary>
		///   <para>Get an array of descriptions of all the ProceduralProperties this ProceduralMaterial has.</para>
		/// </summary>
		// Token: 0x06000864 RID: 2148
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern ProceduralPropertyDescription[] GetProceduralPropertyDescriptions();

		/// <summary>
		///   <para>Checks if the ProceduralMaterial has a ProceduralProperty of a given name.</para>
		/// </summary>
		/// <param name="inputName"></param>
		// Token: 0x06000865 RID: 2149
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool HasProceduralProperty(string inputName);

		/// <summary>
		///   <para>Get a named Procedural boolean property.</para>
		/// </summary>
		/// <param name="inputName"></param>
		// Token: 0x06000866 RID: 2150
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool GetProceduralBoolean(string inputName);

		/// <summary>
		///   <para>Checks if a given ProceduralProperty is visible according to the values of this ProceduralMaterial's other ProceduralProperties and to the ProceduralProperty's visibleIf expression.</para>
		/// </summary>
		/// <param name="inputName">The name of the ProceduralProperty whose visibility is evaluated.</param>
		// Token: 0x06000867 RID: 2151
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsProceduralPropertyVisible(string inputName);

		/// <summary>
		///   <para>Set a named Procedural boolean property.</para>
		/// </summary>
		/// <param name="inputName"></param>
		/// <param name="value"></param>
		// Token: 0x06000868 RID: 2152
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetProceduralBoolean(string inputName, bool value);

		/// <summary>
		///   <para>Get a named Procedural float property.</para>
		/// </summary>
		/// <param name="inputName"></param>
		// Token: 0x06000869 RID: 2153
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetProceduralFloat(string inputName);

		/// <summary>
		///   <para>Set a named Procedural float property.</para>
		/// </summary>
		/// <param name="inputName"></param>
		/// <param name="value"></param>
		// Token: 0x0600086A RID: 2154
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetProceduralFloat(string inputName, float value);

		/// <summary>
		///   <para>Get a named Procedural vector property.</para>
		/// </summary>
		/// <param name="inputName"></param>
		// Token: 0x0600086B RID: 2155
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Vector4 GetProceduralVector(string inputName);

		/// <summary>
		///   <para>Set a named Procedural vector property.</para>
		/// </summary>
		/// <param name="inputName"></param>
		/// <param name="value"></param>
		// Token: 0x0600086C RID: 2156 RVA: 0x000054C9 File Offset: 0x000036C9
		public void SetProceduralVector(string inputName, Vector4 value)
		{
			ProceduralMaterial.INTERNAL_CALL_SetProceduralVector(this, inputName, ref value);
		}

		// Token: 0x0600086D RID: 2157
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetProceduralVector(ProceduralMaterial self, string inputName, ref Vector4 value);

		/// <summary>
		///   <para>Get a named Procedural color property.</para>
		/// </summary>
		/// <param name="inputName"></param>
		// Token: 0x0600086E RID: 2158
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color GetProceduralColor(string inputName);

		/// <summary>
		///   <para>Set a named Procedural color property.</para>
		/// </summary>
		/// <param name="inputName"></param>
		/// <param name="value"></param>
		// Token: 0x0600086F RID: 2159 RVA: 0x000054D4 File Offset: 0x000036D4
		public void SetProceduralColor(string inputName, Color value)
		{
			ProceduralMaterial.INTERNAL_CALL_SetProceduralColor(this, inputName, ref value);
		}

		// Token: 0x06000870 RID: 2160
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetProceduralColor(ProceduralMaterial self, string inputName, ref Color value);

		/// <summary>
		///   <para>Get a named Procedural enum property.</para>
		/// </summary>
		/// <param name="inputName"></param>
		// Token: 0x06000871 RID: 2161
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetProceduralEnum(string inputName);

		/// <summary>
		///   <para>Set a named Procedural enum property.</para>
		/// </summary>
		/// <param name="inputName"></param>
		/// <param name="value"></param>
		// Token: 0x06000872 RID: 2162
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetProceduralEnum(string inputName, int value);

		/// <summary>
		///   <para>Get a named Procedural texture property.</para>
		/// </summary>
		/// <param name="inputName"></param>
		// Token: 0x06000873 RID: 2163
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Texture2D GetProceduralTexture(string inputName);

		/// <summary>
		///   <para>Set a named Procedural texture property.</para>
		/// </summary>
		/// <param name="inputName"></param>
		/// <param name="value"></param>
		// Token: 0x06000874 RID: 2164
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetProceduralTexture(string inputName, Texture2D value);

		/// <summary>
		///   <para>Checks if a named ProceduralProperty is cached for efficient runtime tweaking.</para>
		/// </summary>
		/// <param name="inputName"></param>
		// Token: 0x06000875 RID: 2165
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsProceduralPropertyCached(string inputName);

		/// <summary>
		///   <para>Specifies if a named ProceduralProperty should be cached for efficient runtime tweaking.</para>
		/// </summary>
		/// <param name="inputName"></param>
		/// <param name="value"></param>
		// Token: 0x06000876 RID: 2166
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CacheProceduralProperty(string inputName, bool value);

		/// <summary>
		///   <para>Clear the Procedural cache.</para>
		/// </summary>
		// Token: 0x06000877 RID: 2167
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ClearCache();

		/// <summary>
		///   <para>Set or get the Procedural cache budget.</para>
		/// </summary>
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000878 RID: 2168
		// (set) Token: 0x06000879 RID: 2169
		public extern ProceduralCacheSize cacheSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set or get the update rate in millisecond of the animated substance.</para>
		/// </summary>
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600087A RID: 2170
		// (set) Token: 0x0600087B RID: 2171
		public extern int animationUpdateRate
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Triggers an asynchronous rebuild of this ProceduralMaterial's dirty textures.</para>
		/// </summary>
		// Token: 0x0600087C RID: 2172
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RebuildTextures();

		/// <summary>
		///   <para>Triggers an immediate (synchronous) rebuild of this ProceduralMaterial's dirty textures.</para>
		/// </summary>
		// Token: 0x0600087D RID: 2173
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RebuildTexturesImmediately();

		/// <summary>
		///   <para>Check if the ProceduralTextures from this ProceduralMaterial are currently being rebuilt.</para>
		/// </summary>
		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600087E RID: 2174
		public extern bool isProcessing
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Discard all the queued ProceduralMaterial rendering operations that have not started yet.</para>
		/// </summary>
		// Token: 0x0600087F RID: 2175
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopRebuilds();

		/// <summary>
		///   <para>Indicates whether cached data is available for this ProceduralMaterial's textures (only relevant for Cache and DoNothingAndCache loading behaviors).</para>
		/// </summary>
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000880 RID: 2176
		public extern bool isCachedDataAvailable
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Should the ProceduralMaterial be generated at load time?</para>
		/// </summary>
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000881 RID: 2177
		// (set) Token: 0x06000882 RID: 2178
		public extern bool isLoadTimeGenerated
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Get ProceduralMaterial loading behavior.</para>
		/// </summary>
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000883 RID: 2179
		public extern ProceduralLoadingBehavior loadingBehavior
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Check if ProceduralMaterials are supported on the current platform.</para>
		/// </summary>
		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000884 RID: 2180
		public static extern bool isSupported
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Used to specify the Substance engine CPU usage.</para>
		/// </summary>
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000885 RID: 2181
		// (set) Token: 0x06000886 RID: 2182
		public static extern ProceduralProcessorUsage substanceProcessorUsage
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set or get an XML string of "input/value" pairs (setting the preset rebuilds the textures).</para>
		/// </summary>
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000887 RID: 2183
		// (set) Token: 0x06000888 RID: 2184
		public extern string preset
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Get generated textures.</para>
		/// </summary>
		// Token: 0x06000889 RID: 2185
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Texture[] GetGeneratedTextures();

		/// <summary>
		///   <para>This allows to get a reference to a ProceduralTexture generated by a ProceduralMaterial using its name.</para>
		/// </summary>
		/// <param name="textureName">The name of the ProceduralTexture to get.</param>
		// Token: 0x0600088A RID: 2186
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern ProceduralTexture GetGeneratedTexture(string textureName);

		/// <summary>
		///   <para>Set or get the "Readable" flag for a ProceduralMaterial.</para>
		/// </summary>
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600088B RID: 2187
		// (set) Token: 0x0600088C RID: 2188
		public extern bool isReadable
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
