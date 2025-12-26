using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Simple access to web pages.</para>
	/// </summary>
	// Token: 0x0200009C RID: 156
	public sealed class WWW : IDisposable
	{
		/// <summary>
		///   <para>Creates a WWW request with the given URL.</para>
		/// </summary>
		/// <param name="url">The url to download. Must be '%' escaped.</param>
		/// <returns>
		///   <para>A new WWW object. When it has been downloaded, the results can be fetched from the returned object.</para>
		/// </returns>
		// Token: 0x060008C5 RID: 2245 RVA: 0x00005585 File Offset: 0x00003785
		public WWW(string url)
		{
			this.InitWWW(url, null, null);
		}

		/// <summary>
		///   <para>Creates a WWW request with the given URL.</para>
		/// </summary>
		/// <param name="url">The url to download. Must be '%' escaped.</param>
		/// <param name="form">A WWWForm instance containing the form data to post.</param>
		/// <returns>
		///   <para>A new WWW object. When it has been downloaded, the results can be fetched from the returned object.</para>
		/// </returns>
		// Token: 0x060008C6 RID: 2246 RVA: 0x00015710 File Offset: 0x00013910
		public WWW(string url, WWWForm form)
		{
			string[] array = WWW.FlattenedHeadersFrom(form.headers);
			this.InitWWW(url, form.data, array);
		}

		/// <summary>
		///   <para>Creates a WWW request with the given URL.</para>
		/// </summary>
		/// <param name="url">The url to download. Must be '%' escaped.</param>
		/// <param name="postData">A byte array of data to be posted to the url.</param>
		/// <returns>
		///   <para>A new WWW object. When it has been downloaded, the results can be fetched from the returned object.</para>
		/// </returns>
		// Token: 0x060008C7 RID: 2247 RVA: 0x00005596 File Offset: 0x00003796
		public WWW(string url, byte[] postData)
		{
			this.InitWWW(url, postData, null);
		}

		/// <summary>
		///   <para>Creates a WWW request with the given URL.</para>
		/// </summary>
		/// <param name="url">The url to download. Must be '%' escaped.</param>
		/// <param name="postData">A byte array of data to be posted to the url.</param>
		/// <param name="headers">A hash table of custom headers to send with the request.</param>
		/// <returns>
		///   <para>A new WWW object. When it has been downloaded, the results can be fetched from the returned object.</para>
		/// </returns>
		// Token: 0x060008C8 RID: 2248 RVA: 0x000055A7 File Offset: 0x000037A7
		[Obsolete("This overload is deprecated. Use UnityEngine.WWW.WWW(string, byte[], System.Collections.Generic.Dictionary<string, string>) instead.", true)]
		public WWW(string url, byte[] postData, Hashtable headers)
		{
			Debug.LogError("This overload is deprecated. Use UnityEngine.WWW.WWW(string, byte[], System.Collections.Generic.Dictionary<string, string>) instead");
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00015740 File Offset: 0x00013940
		public WWW(string url, byte[] postData, Dictionary<string, string> headers)
		{
			string[] array = WWW.FlattenedHeadersFrom(headers);
			this.InitWWW(url, postData, array);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x000055B9 File Offset: 0x000037B9
		internal WWW(string url, Hash128 hash, uint crc)
		{
			WWW.INTERNAL_CALL_WWW(this, url, ref hash, crc);
		}

		/// <summary>
		///   <para>Disposes of an existing WWW object.</para>
		/// </summary>
		// Token: 0x060008CB RID: 2251 RVA: 0x000055CB File Offset: 0x000037CB
		public void Dispose()
		{
			this.DestroyWWW(true);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00015764 File Offset: 0x00013964
		~WWW()
		{
			this.DestroyWWW(false);
		}

		// Token: 0x060008CD RID: 2253
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void DestroyWWW(bool cancel);

		// Token: 0x060008CE RID: 2254
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitWWW(string url, byte[] postData, string[] iHeaders);

		// Token: 0x060008CF RID: 2255
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern bool enforceWebSecurityRestrictions();

		/// <summary>
		///   <para>Escapes characters in a string to ensure they are URL-friendly.</para>
		/// </summary>
		/// <param name="s">A string with characters to be escaped.</param>
		/// <param name="e">The text encoding to use.</param>
		// Token: 0x060008D0 RID: 2256 RVA: 0x00015794 File Offset: 0x00013994
		[ExcludeFromDocs]
		public static string EscapeURL(string s)
		{
			Encoding utf = Encoding.UTF8;
			return WWW.EscapeURL(s, utf);
		}

		/// <summary>
		///   <para>Escapes characters in a string to ensure they are URL-friendly.</para>
		/// </summary>
		/// <param name="s">A string with characters to be escaped.</param>
		/// <param name="e">The text encoding to use.</param>
		// Token: 0x060008D1 RID: 2257 RVA: 0x000055D4 File Offset: 0x000037D4
		public static string EscapeURL(string s, [DefaultValue("System.Text.Encoding.UTF8")] Encoding e)
		{
			if (s == null)
			{
				return null;
			}
			if (s == string.Empty)
			{
				return string.Empty;
			}
			if (e == null)
			{
				return null;
			}
			return WWWTranscoder.URLEncode(s, e);
		}

		/// <summary>
		///   <para>Converts URL-friendly escape sequences back to normal text.</para>
		/// </summary>
		/// <param name="s">A string containing escaped characters.</param>
		/// <param name="e">The text encoding to use.</param>
		// Token: 0x060008D2 RID: 2258 RVA: 0x000157B0 File Offset: 0x000139B0
		[ExcludeFromDocs]
		public static string UnEscapeURL(string s)
		{
			Encoding utf = Encoding.UTF8;
			return WWW.UnEscapeURL(s, utf);
		}

		/// <summary>
		///   <para>Converts URL-friendly escape sequences back to normal text.</para>
		/// </summary>
		/// <param name="s">A string containing escaped characters.</param>
		/// <param name="e">The text encoding to use.</param>
		// Token: 0x060008D3 RID: 2259 RVA: 0x00005603 File Offset: 0x00003803
		public static string UnEscapeURL(string s, [DefaultValue("System.Text.Encoding.UTF8")] Encoding e)
		{
			if (s == null)
			{
				return null;
			}
			if (s.IndexOf('%') == -1 && s.IndexOf('+') == -1)
			{
				return s;
			}
			return WWWTranscoder.URLDecode(s, e);
		}

		/// <summary>
		///   <para>Dictionary of headers returned by the request.</para>
		/// </summary>
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00005632 File Offset: 0x00003832
		public Dictionary<string, string> responseHeaders
		{
			get
			{
				if (!this.isDone)
				{
					throw new UnityException("WWW is not finished downloading yet");
				}
				return WWW.ParseHTTPHeaderString(this.responseHeadersString);
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060008D5 RID: 2261
		private extern string responseHeadersString
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns the contents of the fetched web page as a string (Read Only).</para>
		/// </summary>
		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x000157CC File Offset: 0x000139CC
		public string text
		{
			get
			{
				if (!this.isDone)
				{
					throw new UnityException("WWW is not ready downloading yet");
				}
				byte[] bytes = this.bytes;
				return this.GetTextEncoder().GetString(bytes, 0, bytes.Length);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00005655 File Offset: 0x00003855
		internal static Encoding DefaultEncoding
		{
			get
			{
				return Encoding.ASCII;
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00015808 File Offset: 0x00013A08
		private Encoding GetTextEncoder()
		{
			string text = null;
			if (this.responseHeaders.TryGetValue("CONTENT-TYPE", out text))
			{
				int num = text.IndexOf("charset", StringComparison.OrdinalIgnoreCase);
				if (num > -1)
				{
					int num2 = text.IndexOf('=', num);
					if (num2 > -1)
					{
						string text2 = text.Substring(num2 + 1).Trim().Trim(new char[] { '\'', '"' })
							.Trim();
						int num3 = text2.IndexOf(';');
						if (num3 > -1)
						{
							text2 = text2.Substring(0, num3);
						}
						try
						{
							return Encoding.GetEncoding(text2);
						}
						catch (Exception)
						{
							Debug.Log("Unsupported encoding: '" + text2 + "'");
						}
					}
				}
			}
			return Encoding.UTF8;
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x0000565C File Offset: 0x0000385C
		[Obsolete("Please use WWW.text instead")]
		public string data
		{
			get
			{
				return this.text;
			}
		}

		/// <summary>
		///   <para>Returns the contents of the fetched web page as a byte array (Read Only).</para>
		/// </summary>
		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060008DA RID: 2266
		public extern byte[] bytes
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060008DB RID: 2267
		public extern int size
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns an error message if there was an error during the download (Read Only).</para>
		/// </summary>
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060008DC RID: 2268
		public extern string error
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x060008DD RID: 2269
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Texture2D GetTexture(bool markNonReadable);

		/// <summary>
		///   <para>Returns a Texture2D generated from the downloaded data (Read Only).</para>
		/// </summary>
		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00005664 File Offset: 0x00003864
		public Texture2D texture
		{
			get
			{
				return this.GetTexture(false);
			}
		}

		/// <summary>
		///   <para>Returns a non-readable Texture2D generated from the downloaded data (Read Only).</para>
		/// </summary>
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x0000566D File Offset: 0x0000386D
		public Texture2D textureNonReadable
		{
			get
			{
				return this.GetTexture(true);
			}
		}

		/// <summary>
		///   <para>Returns a AudioClip generated from the downloaded data (Read Only).</para>
		/// </summary>
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00005676 File Offset: 0x00003876
		public AudioClip audioClip
		{
			get
			{
				return this.GetAudioClip(true);
			}
		}

		/// <summary>
		///   <para>Returns an AudioClip generated from the downloaded data (Read Only).</para>
		/// </summary>
		/// <param name="threeD">Use this to specify whether the clip should be a 2D or 3D clip
		/// the .audioClip property defaults to 3D.</param>
		/// <param name="stream">Sets whether the clip should be completely downloaded before it's ready to play (false) or the stream can be played even if only part of the clip is downloaded (true).
		/// The latter will disable seeking on the clip (with .time and/or .timeSamples).</param>
		/// <param name="audioType">The AudioType of the content your downloading. If this is not set Unity will try to determine the type from URL.</param>
		/// <returns>
		///   <para>The returned AudioClip.</para>
		/// </returns>
		// Token: 0x060008E1 RID: 2273 RVA: 0x0000567F File Offset: 0x0000387F
		public AudioClip GetAudioClip(bool threeD)
		{
			return this.GetAudioClip(threeD, false);
		}

		/// <summary>
		///   <para>Returns an AudioClip generated from the downloaded data (Read Only).</para>
		/// </summary>
		/// <param name="threeD">Use this to specify whether the clip should be a 2D or 3D clip
		/// the .audioClip property defaults to 3D.</param>
		/// <param name="stream">Sets whether the clip should be completely downloaded before it's ready to play (false) or the stream can be played even if only part of the clip is downloaded (true).
		/// The latter will disable seeking on the clip (with .time and/or .timeSamples).</param>
		/// <param name="audioType">The AudioType of the content your downloading. If this is not set Unity will try to determine the type from URL.</param>
		/// <returns>
		///   <para>The returned AudioClip.</para>
		/// </returns>
		// Token: 0x060008E2 RID: 2274 RVA: 0x00005689 File Offset: 0x00003889
		public AudioClip GetAudioClip(bool threeD, bool stream)
		{
			return this.GetAudioClip(threeD, stream, AudioType.UNKNOWN);
		}

		/// <summary>
		///   <para>Returns an AudioClip generated from the downloaded data (Read Only).</para>
		/// </summary>
		/// <param name="threeD">Use this to specify whether the clip should be a 2D or 3D clip
		/// the .audioClip property defaults to 3D.</param>
		/// <param name="stream">Sets whether the clip should be completely downloaded before it's ready to play (false) or the stream can be played even if only part of the clip is downloaded (true).
		/// The latter will disable seeking on the clip (with .time and/or .timeSamples).</param>
		/// <param name="audioType">The AudioType of the content your downloading. If this is not set Unity will try to determine the type from URL.</param>
		/// <returns>
		///   <para>The returned AudioClip.</para>
		/// </returns>
		// Token: 0x060008E3 RID: 2275 RVA: 0x00005694 File Offset: 0x00003894
		public AudioClip GetAudioClip(bool threeD, bool stream, AudioType audioType)
		{
			return this.GetAudioClipInternal(threeD, stream, false, audioType);
		}

		/// <summary>
		///   <para>Returns an AudioClip generated from the downloaded data that is compressed in memory (Read Only).</para>
		/// </summary>
		/// <param name="threeD">Use this to specify whether the clip should be a 2D or 3D clip.</param>
		/// <param name="audioType">The AudioType of the content your downloading. If this is not set Unity will try to determine the type from URL.</param>
		/// <returns>
		///   <para>The returned AudioClip.</para>
		/// </returns>
		// Token: 0x060008E4 RID: 2276 RVA: 0x000056A0 File Offset: 0x000038A0
		public AudioClip GetAudioClipCompressed()
		{
			return this.GetAudioClipCompressed(true);
		}

		/// <summary>
		///   <para>Returns an AudioClip generated from the downloaded data that is compressed in memory (Read Only).</para>
		/// </summary>
		/// <param name="threeD">Use this to specify whether the clip should be a 2D or 3D clip.</param>
		/// <param name="audioType">The AudioType of the content your downloading. If this is not set Unity will try to determine the type from URL.</param>
		/// <returns>
		///   <para>The returned AudioClip.</para>
		/// </returns>
		// Token: 0x060008E5 RID: 2277 RVA: 0x000056A9 File Offset: 0x000038A9
		public AudioClip GetAudioClipCompressed(bool threeD)
		{
			return this.GetAudioClipCompressed(threeD, AudioType.UNKNOWN);
		}

		/// <summary>
		///   <para>Returns an AudioClip generated from the downloaded data that is compressed in memory (Read Only).</para>
		/// </summary>
		/// <param name="threeD">Use this to specify whether the clip should be a 2D or 3D clip.</param>
		/// <param name="audioType">The AudioType of the content your downloading. If this is not set Unity will try to determine the type from URL.</param>
		/// <returns>
		///   <para>The returned AudioClip.</para>
		/// </returns>
		// Token: 0x060008E6 RID: 2278 RVA: 0x000056B3 File Offset: 0x000038B3
		public AudioClip GetAudioClipCompressed(bool threeD, AudioType audioType)
		{
			return this.GetAudioClipInternal(threeD, false, true, audioType);
		}

		// Token: 0x060008E7 RID: 2279
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AudioClip GetAudioClipInternal(bool threeD, bool stream, bool compressed, AudioType audioType);

		/// <summary>
		///   <para>Returns a MovieTexture generated from the downloaded data (Read Only).</para>
		/// </summary>
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060008E8 RID: 2280
		public extern MovieTexture movie
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Replaces the contents of an existing Texture2D with an image from the downloaded data.</para>
		/// </summary>
		/// <param name="tex">An existing texture object to be overwritten with the image data.</param>
		// Token: 0x060008E9 RID: 2281
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void LoadImageIntoTexture(Texture2D tex);

		/// <summary>
		///   <para>Is the download already finished? (Read Only)</para>
		/// </summary>
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060008EA RID: 2282
		public extern bool isDone
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x060008EB RID: 2283
		[Obsolete("All blocking WWW functions have been deprecated, please use one of the asynchronous functions instead.", true)]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetURL(string url);

		// Token: 0x060008EC RID: 2284 RVA: 0x000056BF File Offset: 0x000038BF
		[Obsolete("All blocking WWW functions have been deprecated, please use one of the asynchronous functions instead.", true)]
		public static Texture2D GetTextureFromURL(string url)
		{
			return new WWW(url).texture;
		}

		/// <summary>
		///   <para>How far has the download progressed (Read Only).</para>
		/// </summary>
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060008ED RID: 2285
		public extern float progress
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>How far has the upload progressed (Read Only).</para>
		/// </summary>
		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060008EE RID: 2286
		public extern float uploadProgress
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The number of bytes downloaded by this WWW query (read only).</para>
		/// </summary>
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060008EF RID: 2287
		public extern int bytesDownloaded
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Load an Ogg Vorbis file into the audio clip.</para>
		/// </summary>
		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00002096 File Offset: 0x00000296
		[Obsolete("Property WWW.oggVorbis has been deprecated. Use WWW.audioClip instead (UnityUpgradable).", true)]
		public AudioClip oggVorbis
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		///   <para>Loads the new web player data file.</para>
		/// </summary>
		// Token: 0x060008F1 RID: 2289 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("LoadUnityWeb is no longer supported. Please use javascript to reload the web player on a different url instead", true)]
		public void LoadUnityWeb()
		{
		}

		/// <summary>
		///   <para>The URL of this WWW request (Read Only).</para>
		/// </summary>
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060008F2 RID: 2290
		public extern string url
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Streams an AssetBundle that can contain any kind of asset from the project folder.</para>
		/// </summary>
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060008F3 RID: 2291
		public extern AssetBundle assetBundle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Priority of AssetBundle decompression thread.</para>
		/// </summary>
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060008F4 RID: 2292
		// (set) Token: 0x060008F5 RID: 2293
		public extern ThreadPriority threadPriority
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x060008F6 RID: 2294
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_WWW(WWW self, string url, ref Hash128 hash, uint crc);

		/// <summary>
		///   <para>Loads an AssetBundle with the specified version number from the cache. If the AssetBundle is not currently cached, it will automatically be downloaded and stored in the cache for future retrieval from local storage.</para>
		/// </summary>
		/// <param name="url">The URL to download the AssetBundle from, if it is not present in the cache. Must be '%' escaped.</param>
		/// <param name="version">Version of the AssetBundle. The file will only be loaded from the disk cache if it has previously been downloaded with the same version parameter. By incrementing the version number requested by your application, you can force Caching to download a new copy of the AssetBundle from url.</param>
		/// <param name="crc">An optional CRC-32 Checksum of the uncompressed contents. If this is non-zero, then the content will be compared against the checksum before loading it, and give an error if it does not match. You can use this to avoid data corruption from bad downloads or users tampering with the cached files on disk. If the CRC does not match, Unity will try to redownload the data, and if the CRC on the server does not match it will fail with an error. Look at the error string returned to see the correct CRC value to use for an AssetBundle.</param>
		/// <returns>
		///   <para>A WWW instance, which can be used to access the data once the load/download operation is completed.</para>
		/// </returns>
		// Token: 0x060008F7 RID: 2295 RVA: 0x000158E0 File Offset: 0x00013AE0
		[ExcludeFromDocs]
		public static WWW LoadFromCacheOrDownload(string url, int version)
		{
			uint num = 0U;
			return WWW.LoadFromCacheOrDownload(url, version, num);
		}

		/// <summary>
		///   <para>Loads an AssetBundle with the specified version number from the cache. If the AssetBundle is not currently cached, it will automatically be downloaded and stored in the cache for future retrieval from local storage.</para>
		/// </summary>
		/// <param name="url">The URL to download the AssetBundle from, if it is not present in the cache. Must be '%' escaped.</param>
		/// <param name="version">Version of the AssetBundle. The file will only be loaded from the disk cache if it has previously been downloaded with the same version parameter. By incrementing the version number requested by your application, you can force Caching to download a new copy of the AssetBundle from url.</param>
		/// <param name="crc">An optional CRC-32 Checksum of the uncompressed contents. If this is non-zero, then the content will be compared against the checksum before loading it, and give an error if it does not match. You can use this to avoid data corruption from bad downloads or users tampering with the cached files on disk. If the CRC does not match, Unity will try to redownload the data, and if the CRC on the server does not match it will fail with an error. Look at the error string returned to see the correct CRC value to use for an AssetBundle.</param>
		/// <returns>
		///   <para>A WWW instance, which can be used to access the data once the load/download operation is completed.</para>
		/// </returns>
		// Token: 0x060008F8 RID: 2296 RVA: 0x000158F8 File Offset: 0x00013AF8
		public static WWW LoadFromCacheOrDownload(string url, int version, [DefaultValue("0")] uint crc)
		{
			Hash128 hash = new Hash128(0U, 0U, 0U, (uint)version);
			return WWW.LoadFromCacheOrDownload(url, hash, crc);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00015918 File Offset: 0x00013B18
		[ExcludeFromDocs]
		public static WWW LoadFromCacheOrDownload(string url, Hash128 hash)
		{
			uint num = 0U;
			return WWW.LoadFromCacheOrDownload(url, hash, num);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x000056CC File Offset: 0x000038CC
		public static WWW LoadFromCacheOrDownload(string url, Hash128 hash, [DefaultValue("0")] uint crc)
		{
			return new WWW(url, hash, crc);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00015930 File Offset: 0x00013B30
		private static string[] FlattenedHeadersFrom(Dictionary<string, string> headers)
		{
			if (headers == null)
			{
				return null;
			}
			string[] array = new string[headers.Count * 2];
			int num = 0;
			foreach (KeyValuePair<string, string> keyValuePair in headers)
			{
				array[num++] = keyValuePair.Key.ToString();
				array[num++] = keyValuePair.Value.ToString();
			}
			return array;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x000159C0 File Offset: 0x00013BC0
		internal static Dictionary<string, string> ParseHTTPHeaderString(string input)
		{
			if (input == null)
			{
				throw new ArgumentException("input was null to ParseHTTPHeaderString");
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			StringReader stringReader = new StringReader(input);
			int num = 0;
			for (;;)
			{
				string text = stringReader.ReadLine();
				if (text == null)
				{
					break;
				}
				if (num++ == 0 && text.StartsWith("HTTP"))
				{
					dictionary["STATUS"] = text;
				}
				else
				{
					int num2 = text.IndexOf(": ");
					if (num2 != -1)
					{
						string text2 = text.Substring(0, num2).ToUpper();
						string text3 = text.Substring(num2 + 2);
						dictionary[text2] = text3;
					}
				}
			}
			return dictionary;
		}

		// Token: 0x040001E9 RID: 489
		internal IntPtr m_Ptr;
	}
}
