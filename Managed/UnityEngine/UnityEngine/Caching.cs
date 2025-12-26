using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The Caching class lets you manage cached AssetBundles, downloaded using WWW.LoadFromCacheOrDownload.</para>
	/// </summary>
	// Token: 0x020000A0 RID: 160
	public sealed class Caching
	{
		/// <summary>
		///   <para>(This is a WebPlayer-only function).</para>
		/// </summary>
		/// <param name="string">Signature The authentification signature provided by Unity.</param>
		/// <param name="int">Size The number of bytes allocated to this cache.</param>
		/// <param name="name"></param>
		/// <param name="domain"></param>
		/// <param name="size"></param>
		/// <param name="signature"></param>
		/// <param name="expiration"></param>
		// Token: 0x0600091D RID: 2333 RVA: 0x00005748 File Offset: 0x00003948
		public static bool Authorize(string name, string domain, long size, string signature)
		{
			return Caching.Authorize(name, domain, size, -1, signature);
		}

		/// <summary>
		///   <para>(This is a WebPlayer-only function).</para>
		/// </summary>
		/// <param name="string">Signature The authentification signature provided by Unity.</param>
		/// <param name="int">Size The number of bytes allocated to this cache.</param>
		/// <param name="name"></param>
		/// <param name="domain"></param>
		/// <param name="size"></param>
		/// <param name="signature"></param>
		/// <param name="expiration"></param>
		// Token: 0x0600091E RID: 2334
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Authorize(string name, string domain, long size, int expiration, string signature);

		/// <summary>
		///   <para>TODO.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="domain"></param>
		/// <param name="size"></param>
		/// <param name="signature"></param>
		/// <param name="expiration"></param>
		// Token: 0x0600091F RID: 2335 RVA: 0x00005754 File Offset: 0x00003954
		[Obsolete("Size is now specified as a long")]
		public static bool Authorize(string name, string domain, int size, int expiration, string signature)
		{
			return Caching.Authorize(name, domain, (long)size, expiration, signature);
		}

		/// <summary>
		///   <para>TODO.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="domain"></param>
		/// <param name="size"></param>
		/// <param name="signature"></param>
		/// <param name="expiration"></param>
		// Token: 0x06000920 RID: 2336 RVA: 0x00005762 File Offset: 0x00003962
		[Obsolete("Size is now specified as a long")]
		public static bool Authorize(string name, string domain, int size, string signature)
		{
			return Caching.Authorize(name, domain, (long)size, signature);
		}

		/// <summary>
		///   <para>Delete all AssetBundle and Procedural Material content that has been cached by the current application.</para>
		/// </summary>
		/// <returns>
		///   <para>True when cache cleaning succeeded, false if cache was in use.</para>
		/// </returns>
		// Token: 0x06000921 RID: 2337
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CleanCache();

		// Token: 0x06000922 RID: 2338
		[Obsolete("this API is not for public use.")]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CleanNamedCache(string name);

		// Token: 0x06000923 RID: 2339
		[Obsolete("This function is obsolete and has no effect.")]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool DeleteFromCache(string url);

		// Token: 0x06000924 RID: 2340
		[Obsolete("This function is obsolete and will always return -1. Use IsVersionCached instead.")]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetVersionFromCache(string url);

		/// <summary>
		///   <para>Checks if an AssetBundle is cached.</para>
		/// </summary>
		/// <param name="string">Url The filename of the AssetBundle. Domain and path information are stripped from this string automatically.</param>
		/// <param name="int">Version The version number of the AssetBundle to check for. Negative values are not allowed.</param>
		/// <param name="url"></param>
		/// <param name="version"></param>
		/// <returns>
		///   <para>True if an AssetBundle matching the url and version parameters has previously been loaded using WWW.LoadFromCacheOrDownload() and is currently stored in the cache. Returns false if the AssetBundle is not in cache, either because it has been flushed from the cache or was never loaded using the Caching API.</para>
		/// </returns>
		// Token: 0x06000925 RID: 2341 RVA: 0x000165AC File Offset: 0x000147AC
		public static bool IsVersionCached(string url, int version)
		{
			Hash128 hash = new Hash128(0U, 0U, 0U, (uint)version);
			return Caching.IsVersionCached(url, hash);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0000576E File Offset: 0x0000396E
		public static bool IsVersionCached(string url, Hash128 hash)
		{
			return Caching.INTERNAL_CALL_IsVersionCached(url, ref hash);
		}

		// Token: 0x06000927 RID: 2343
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsVersionCached(string url, ref Hash128 hash);

		/// <summary>
		///   <para>Bumps the timestamp of a cached file to be the current time.</para>
		/// </summary>
		/// <param name="url"></param>
		/// <param name="version"></param>
		// Token: 0x06000928 RID: 2344 RVA: 0x000165CC File Offset: 0x000147CC
		public static bool MarkAsUsed(string url, int version)
		{
			Hash128 hash = new Hash128(0U, 0U, 0U, (uint)version);
			return Caching.MarkAsUsed(url, hash);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00005778 File Offset: 0x00003978
		public static bool MarkAsUsed(string url, Hash128 hash)
		{
			return Caching.INTERNAL_CALL_MarkAsUsed(url, ref hash);
		}

		// Token: 0x0600092A RID: 2346
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_MarkAsUsed(string url, ref Hash128 hash);

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600092B RID: 2347
		[Obsolete("this API is not for public use.")]
		public static extern CacheIndex[] index
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The number of currently unused bytes in the cache.</para>
		/// </summary>
		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600092C RID: 2348
		public static extern long spaceFree
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The total number of bytes that can potentially be allocated for caching.</para>
		/// </summary>
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600092D RID: 2349
		// (set) Token: 0x0600092E RID: 2350
		public static extern long maximumAvailableDiskSpace
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Used disk space in bytes.</para>
		/// </summary>
		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600092F RID: 2351
		public static extern long spaceOccupied
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000930 RID: 2352
		[Obsolete("Please use Caching.spaceFree instead")]
		public static extern int spaceAvailable
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000931 RID: 2353
		[Obsolete("Please use Caching.spaceOccupied instead")]
		public static extern int spaceUsed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The number of seconds that an AssetBundle may remain unused in the cache before it is automatically deleted.</para>
		/// </summary>
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000932 RID: 2354
		// (set) Token: 0x06000933 RID: 2355
		public static extern int expirationDelay
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is Caching enabled?</para>
		/// </summary>
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000934 RID: 2356
		// (set) Token: 0x06000935 RID: 2357
		public static extern bool enabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is caching ready?</para>
		/// </summary>
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000936 RID: 2358
		public static extern bool ready
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
