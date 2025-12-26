using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.Experimental.Networking
{
	/// <summary>
	///   <para>A DownloadHandler subclass specialized for downloading AssetBundles.</para>
	/// </summary>
	// Token: 0x020001FB RID: 507
	[StructLayout(LayoutKind.Sequential)]
	public sealed class DownloadHandlerAssetBundle : DownloadHandler
	{
		/// <summary>
		///   <para>Standard constructor for non-cached asset bundles.</para>
		/// </summary>
		/// <param name="url">The nominal (pre-redirect) URL at which the asset bundle is located.</param>
		/// <param name="crc">A checksum to compare to the downloaded data for integrity checking, or zero to skip integrity checking.</param>
		// Token: 0x06001DC8 RID: 7624 RVA: 0x0000B92D File Offset: 0x00009B2D
		public DownloadHandlerAssetBundle(string url, uint crc)
		{
			base.InternalCreateWebStream(url, crc);
		}

		/// <summary>
		///   <para>Simple versioned constructor. Caches downloaded asset bundles.</para>
		/// </summary>
		/// <param name="url">The nominal (pre-redirect) URL at which the asset bundle is located.</param>
		/// <param name="crc">A checksum to compare to the downloaded data for integrity checking, or zero to skip integrity checking.</param>
		/// <param name="version">Current version number of the asset bundle at url. Increment to redownload.</param>
		// Token: 0x06001DC9 RID: 7625 RVA: 0x00024830 File Offset: 0x00022A30
		public DownloadHandlerAssetBundle(string url, uint version, uint crc)
		{
			Hash128 hash = new Hash128(0U, 0U, 0U, version);
			base.InternalCreateWebStream(url, hash, crc);
		}

		/// <summary>
		///   <para>Versioned constructor. Caches downloaded asset bundles.</para>
		/// </summary>
		/// <param name="url">The nominal (pre-redirect) URL at which the asset bundle is located.</param>
		/// <param name="crc">A checksum to compare to the downloaded data for integrity checking, or zero to skip integrity checking.</param>
		/// <param name="hash">A hash object defining the version of the asset bundle.</param>
		// Token: 0x06001DCA RID: 7626 RVA: 0x0000B93D File Offset: 0x00009B3D
		public DownloadHandlerAssetBundle(string url, Hash128 hash, uint crc)
		{
			base.InternalCreateWebStream(url, hash, crc);
		}

		/// <summary>
		///   <para>Not implemented. Throws &lt;a href="http:msdn.microsoft.comen-uslibrarysystem.notsupportedexception"&gt;NotSupportedException&lt;a&gt;.</para>
		/// </summary>
		/// <returns>
		///   <para>Not implemented.</para>
		/// </returns>
		// Token: 0x06001DCB RID: 7627 RVA: 0x0000B94E File Offset: 0x00009B4E
		protected override byte[] GetData()
		{
			throw new NotSupportedException("Raw data access is not supported for asset bundles");
		}

		/// <summary>
		///   <para>Not implemented. Throws &lt;a href="http:msdn.microsoft.comen-uslibrarysystem.notsupportedexception"&gt;NotSupportedException&lt;a&gt;.</para>
		/// </summary>
		/// <returns>
		///   <para>Not implemented.</para>
		/// </returns>
		// Token: 0x06001DCC RID: 7628 RVA: 0x0000B95A File Offset: 0x00009B5A
		protected override string GetText()
		{
			throw new NotSupportedException("String access is not supported for asset bundles");
		}

		/// <summary>
		///   <para>Returns the downloaded AssetBundle, or null. (Read Only)</para>
		/// </summary>
		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001DCD RID: 7629
		public extern AssetBundle assetBundle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns the downloaded AssetBundle, or null. (Read Only)</para>
		/// </summary>
		/// <param name="www">A finished UnityWebRequest object with DownloadHandlerAssetBundle attached.</param>
		/// <returns>
		///   <para>The same as [DownloadHandlerAssetBundle.assetBundle]</para>
		/// </returns>
		// Token: 0x06001DCE RID: 7630 RVA: 0x0000B966 File Offset: 0x00009B66
		public static AssetBundle GetContent(UnityWebRequest www)
		{
			return DownloadHandler.GetCheckedDownloader<DownloadHandlerAssetBundle>(www).assetBundle;
		}
	}
}
