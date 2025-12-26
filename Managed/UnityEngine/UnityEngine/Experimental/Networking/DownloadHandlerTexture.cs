using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.Experimental.Networking
{
	/// <summary>
	///   <para>A DownloadHandler subclass specialized for downloading images for use as Texture objects.</para>
	/// </summary>
	// Token: 0x020001FA RID: 506
	[StructLayout(LayoutKind.Sequential)]
	public sealed class DownloadHandlerTexture : DownloadHandler
	{
		/// <summary>
		///   <para>Default constructor.</para>
		/// </summary>
		// Token: 0x06001DC1 RID: 7617 RVA: 0x0000B8F2 File Offset: 0x00009AF2
		public DownloadHandlerTexture()
		{
			base.InternalCreateTexture(true);
		}

		/// <summary>
		///   <para>Constructor, allows TextureImporter.isReadable property to be set.</para>
		/// </summary>
		/// <param name="readable">Value to set for TextureImporter.isReadable.</param>
		// Token: 0x06001DC2 RID: 7618 RVA: 0x0000B901 File Offset: 0x00009B01
		public DownloadHandlerTexture(bool readable)
		{
			base.InternalCreateTexture(readable);
		}

		/// <summary>
		///   <para>Called by DownloadHandler.data. Returns a copy of the downloaded image data as raw bytes.</para>
		/// </summary>
		/// <returns>
		///   <para>A copy of the downloaded data.</para>
		/// </returns>
		// Token: 0x06001DC3 RID: 7619 RVA: 0x0000B910 File Offset: 0x00009B10
		protected override byte[] GetData()
		{
			return this.InternalGetData();
		}

		/// <summary>
		///   <para>Returns the downloaded Texture, or null. (Read Only)</para>
		/// </summary>
		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x0000B918 File Offset: 0x00009B18
		public Texture2D texture
		{
			get
			{
				return this.InternalGetTexture();
			}
		}

		// Token: 0x06001DC5 RID: 7621
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Texture2D InternalGetTexture();

		// Token: 0x06001DC6 RID: 7622
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern byte[] InternalGetData();

		/// <summary>
		///   <para>Returns the downloaded Texture, or null. (Read Only)</para>
		/// </summary>
		/// <param name="www">A finished UnityWebRequest object with DownloadHandlerTexture attached.</param>
		/// <returns>
		///   <para>The same as [DownloadHandlerTexture.texture]</para>
		/// </returns>
		// Token: 0x06001DC7 RID: 7623 RVA: 0x0000B920 File Offset: 0x00009B20
		public static Texture2D GetContent(UnityWebRequest www)
		{
			return DownloadHandler.GetCheckedDownloader<DownloadHandlerTexture>(www).texture;
		}
	}
}
