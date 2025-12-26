using System;
using System.Runtime.CompilerServices;
using UnityEngineInternal;

namespace UnityEngine
{
	/// <summary>
	///   <para>AssetBundles let you stream additional assets via the WWW class and instantiate them at runtime. AssetBundles are created via BuildPipeline.BuildAssetBundle.</para>
	/// </summary>
	// Token: 0x02000004 RID: 4
	public sealed class AssetBundle : Object
	{
		/// <summary>
		///   <para>Asynchronously create an AssetBundle from a memory region.</para>
		/// </summary>
		/// <param name="binary"></param>
		// Token: 0x06000008 RID: 8
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AssetBundleCreateRequest CreateFromMemory(byte[] binary);

		/// <summary>
		///   <para>Synchronously create an AssetBundle from a memory region.</para>
		/// </summary>
		/// <param name="binary">Array of bytes with the AssetBundle data.</param>
		// Token: 0x06000009 RID: 9
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AssetBundle CreateFromMemoryImmediate(byte[] binary);

		/// <summary>
		///   <para>Loads an asset bundle from a disk.</para>
		/// </summary>
		/// <param name="path">Path of the file on disk
		///
		/// See Also: WWW.assetBundle, WWW.LoadFromCacheOrDownload.</param>
		// Token: 0x0600000A RID: 10
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AssetBundle CreateFromFile(string path);

		/// <summary>
		///   <para>Main asset that was supplied when building the asset bundle (Read Only).</para>
		/// </summary>
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11
		public extern Object mainAsset
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Check if an AssetBundle contains a specific object.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x0600000C RID: 12
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool Contains(string name);

		// Token: 0x0600000D RID: 13 RVA: 0x00002096 File Offset: 0x00000296
		[Obsolete("Method Load has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAsset instead and check the documentation for details.", true)]
		public Object Load(string name)
		{
			return null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002099 File Offset: 0x00000299
		[Obsolete("Method Load has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAsset instead and check the documentation for details.", true)]
		public T Load<T>(string name) where T : Object
		{
			return (T)((object)null);
		}

		// Token: 0x0600000F RID: 15
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		[Obsolete("Method Load has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAsset instead and check the documentation for details.", true)]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Object Load(string name, Type type);

		// Token: 0x06000010 RID: 16
		[WrapperlessIcall]
		[Obsolete("Method LoadAsync has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAssetAsync instead and check the documentation for details.", true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AssetBundleRequest LoadAsync(string name, Type type);

		// Token: 0x06000011 RID: 17
		[WrapperlessIcall]
		[Obsolete("Method LoadAll has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAllAssets instead and check the documentation for details.", true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Object[] LoadAll(Type type);

		// Token: 0x06000012 RID: 18 RVA: 0x00002096 File Offset: 0x00000296
		[Obsolete("Method LoadAll has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAllAssets instead and check the documentation for details.", true)]
		public Object[] LoadAll()
		{
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002096 File Offset: 0x00000296
		[Obsolete("Method LoadAll has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAllAssets instead and check the documentation for details.", true)]
		public T[] LoadAll<T>() where T : Object
		{
			return null;
		}

		/// <summary>
		///   <para>Loads asset with name of type T from the bundle.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x06000014 RID: 20 RVA: 0x000020A1 File Offset: 0x000002A1
		public Object LoadAsset(string name)
		{
			return this.LoadAsset(name, typeof(Object));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020B4 File Offset: 0x000002B4
		public T LoadAsset<T>(string name) where T : Object
		{
			return (T)((object)this.LoadAsset(name, typeof(T)));
		}

		/// <summary>
		///   <para>Loads asset with name of a given type from the bundle.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="type"></param>
		// Token: 0x06000016 RID: 22 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		public Object LoadAsset(string name, Type type)
		{
			if (name == null)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			if (type == null)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAsset_Internal(name, type);
		}

		// Token: 0x06000017 RID: 23
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Object LoadAsset_Internal(string name, Type type);

		/// <summary>
		///   <para>Asynchronously loads asset with name of a given T from the bundle.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x06000018 RID: 24 RVA: 0x000020CC File Offset: 0x000002CC
		public AssetBundleRequest LoadAssetAsync(string name)
		{
			return this.LoadAssetAsync(name, typeof(Object));
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020DF File Offset: 0x000002DF
		public AssetBundleRequest LoadAssetAsync<T>(string name)
		{
			return this.LoadAssetAsync(name, typeof(T));
		}

		/// <summary>
		///   <para>Asynchronously loads asset with name of a given type from the bundle.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="type"></param>
		// Token: 0x0600001A RID: 26 RVA: 0x0000EC48 File Offset: 0x0000CE48
		public AssetBundleRequest LoadAssetAsync(string name, Type type)
		{
			if (name == null)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			if (type == null)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetAsync_Internal(name, type);
		}

		// Token: 0x0600001B RID: 27
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AssetBundleRequest LoadAssetAsync_Internal(string name, Type type);

		/// <summary>
		///   <para>Loads asset and sub assets with name from the bundle.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x0600001C RID: 28 RVA: 0x000020F2 File Offset: 0x000002F2
		public Object[] LoadAssetWithSubAssets(string name)
		{
			return this.LoadAssetWithSubAssets(name, typeof(Object));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002105 File Offset: 0x00000305
		public T[] LoadAssetWithSubAssets<T>(string name) where T : Object
		{
			return Resources.ConvertObjects<T>(this.LoadAssetWithSubAssets(name, typeof(T)));
		}

		/// <summary>
		///   <para>Loads asset and sub assets with name of a given type from the bundle.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="type"></param>
		// Token: 0x0600001E RID: 30 RVA: 0x0000EC98 File Offset: 0x0000CE98
		public Object[] LoadAssetWithSubAssets(string name, Type type)
		{
			if (name == null)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			if (type == null)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssets_Internal(name, type);
		}

		// Token: 0x0600001F RID: 31
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Object[] LoadAssetWithSubAssets_Internal(string name, Type type);

		/// <summary>
		///   <para>Loads asset with sub assets with name from the bundle asynchronously.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x06000020 RID: 32 RVA: 0x0000211D File Offset: 0x0000031D
		public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name)
		{
			return this.LoadAssetWithSubAssetsAsync(name, typeof(Object));
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002130 File Offset: 0x00000330
		public AssetBundleRequest LoadAssetWithSubAssetsAsync<T>(string name)
		{
			return this.LoadAssetWithSubAssetsAsync(name, typeof(T));
		}

		/// <summary>
		///   <para>Loads asset with sub assets with name of a given type from the bundle asynchronously.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="type"></param>
		// Token: 0x06000022 RID: 34 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type)
		{
			if (name == null)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			if (type == null)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssetsAsync_Internal(name, type);
		}

		// Token: 0x06000023 RID: 35
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type);

		/// <summary>
		///   <para>Loads all assets contained in the asset bundle that inherit from type T.</para>
		/// </summary>
		// Token: 0x06000024 RID: 36 RVA: 0x00002143 File Offset: 0x00000343
		public Object[] LoadAllAssets()
		{
			return this.LoadAllAssets(typeof(Object));
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002155 File Offset: 0x00000355
		public T[] LoadAllAssets<T>() where T : Object
		{
			return Resources.ConvertObjects<T>(this.LoadAllAssets(typeof(T)));
		}

		/// <summary>
		///   <para>Loads all assets contained in the asset bundle that inherit from type.</para>
		/// </summary>
		/// <param name="type"></param>
		// Token: 0x06000026 RID: 38 RVA: 0x0000216C File Offset: 0x0000036C
		public Object[] LoadAllAssets(Type type)
		{
			if (type == null)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssets_Internal(string.Empty, type);
		}

		/// <summary>
		///   <para>Loads all assets contained in the asset bundle asynchronously.</para>
		/// </summary>
		// Token: 0x06000027 RID: 39 RVA: 0x0000218B File Offset: 0x0000038B
		public AssetBundleRequest LoadAllAssetsAsync()
		{
			return this.LoadAllAssetsAsync(typeof(Object));
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000219D File Offset: 0x0000039D
		public AssetBundleRequest LoadAllAssetsAsync<T>()
		{
			return this.LoadAllAssetsAsync(typeof(T));
		}

		/// <summary>
		///   <para>Loads all assets contained in the asset bundle that inherit from type asynchronously.</para>
		/// </summary>
		/// <param name="type"></param>
		// Token: 0x06000029 RID: 41 RVA: 0x000021AF File Offset: 0x000003AF
		public AssetBundleRequest LoadAllAssetsAsync(Type type)
		{
			if (type == null)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssetsAsync_Internal(string.Empty, type);
		}

		/// <summary>
		///   <para>Unloads all assets in the bundle.</para>
		/// </summary>
		/// <param name="unloadAllLoadedObjects"></param>
		// Token: 0x0600002A RID: 42
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Unload(bool unloadAllLoadedObjects);

		// Token: 0x0600002B RID: 43 RVA: 0x000021CE File Offset: 0x000003CE
		[Obsolete("This method is deprecated. Use GetAllAssetNames() instead.")]
		public string[] AllAssetNames()
		{
			return this.GetAllAssetNames();
		}

		/// <summary>
		///   <para>Return all asset names in the AssetBundle.</para>
		/// </summary>
		// Token: 0x0600002C RID: 44
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string[] GetAllAssetNames();

		/// <summary>
		///   <para>Return all the scene asset paths (paths to *.unity assets) in the AssetBundle.</para>
		/// </summary>
		// Token: 0x0600002D RID: 45
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string[] GetAllScenePaths();
	}
}
