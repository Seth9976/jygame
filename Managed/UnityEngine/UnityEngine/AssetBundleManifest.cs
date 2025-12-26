using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Manifest for all the assetBundle in the build.</para>
	/// </summary>
	// Token: 0x02000005 RID: 5
	public sealed class AssetBundleManifest : Object
	{
		/// <summary>
		///   <para>Get all the AssetBundles in the manifest.</para>
		/// </summary>
		/// <returns>
		///   <para>An array of asset bundle names.</para>
		/// </returns>
		// Token: 0x0600002F RID: 47
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string[] GetAllAssetBundles();

		/// <summary>
		///   <para>Get all the AssetBundles with variant in the manifest.</para>
		/// </summary>
		/// <returns>
		///   <para>An array of asset bundle names.</para>
		/// </returns>
		// Token: 0x06000030 RID: 48
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string[] GetAllAssetBundlesWithVariant();

		/// <summary>
		///   <para>Get the hash for the given AssetBundle.</para>
		/// </summary>
		/// <param name="assetBundleName">Name of the asset bundle.</param>
		/// <returns>
		///   <para>The 128-bit hash for the asset bundle.</para>
		/// </returns>
		// Token: 0x06000031 RID: 49
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Hash128 GetAssetBundleHash(string assetBundleName);

		/// <summary>
		///   <para>Get the direct dependent AssetBundles for the given AssetBundle.</para>
		/// </summary>
		/// <param name="assetBundleName">Name of the asset bundle.</param>
		/// <returns>
		///   <para>Array of asset bundle names this asset bundle depends on.</para>
		/// </returns>
		// Token: 0x06000032 RID: 50
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string[] GetDirectDependencies(string assetBundleName);

		/// <summary>
		///   <para>Get all the dependent AssetBundles for the given AssetBundle.</para>
		/// </summary>
		/// <param name="assetBundleName">Name of the asset bundle.</param>
		// Token: 0x06000033 RID: 51
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string[] GetAllDependencies(string assetBundleName);
	}
}
