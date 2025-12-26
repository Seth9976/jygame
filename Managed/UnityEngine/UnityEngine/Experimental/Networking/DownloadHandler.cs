using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace UnityEngine.Experimental.Networking
{
	/// <summary>
	///   <para>Manage and process HTTP response body data received from a remote server.</para>
	/// </summary>
	// Token: 0x020001F7 RID: 503
	[StructLayout(LayoutKind.Sequential)]
	public class DownloadHandler : IDisposable
	{
		// Token: 0x06001DA4 RID: 7588 RVA: 0x000021D6 File Offset: 0x000003D6
		internal DownloadHandler()
		{
		}

		// Token: 0x06001DA5 RID: 7589
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreateString();

		// Token: 0x06001DA6 RID: 7590
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreateScript();

		// Token: 0x06001DA7 RID: 7591
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreateTexture(bool readable);

		// Token: 0x06001DA8 RID: 7592
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreateWebStream(string url, uint crc);

		// Token: 0x06001DA9 RID: 7593 RVA: 0x0000B860 File Offset: 0x00009A60
		internal void InternalCreateWebStream(string url, Hash128 hash, uint crc)
		{
			DownloadHandler.INTERNAL_CALL_InternalCreateWebStream(this, url, ref hash, crc);
		}

		// Token: 0x06001DAA RID: 7594
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_InternalCreateWebStream(DownloadHandler self, string url, ref Hash128 hash, uint crc);

		// Token: 0x06001DAB RID: 7595
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalDestroy();

		// Token: 0x06001DAC RID: 7596 RVA: 0x00024770 File Offset: 0x00022970
		~DownloadHandler()
		{
			this.InternalDestroy();
		}

		/// <summary>
		///   <para>Signals that this [DownloadHandler] is no longer being used, and should clean up any resources it is using.</para>
		/// </summary>
		// Token: 0x06001DAD RID: 7597 RVA: 0x0000B86C File Offset: 0x00009A6C
		public void Dispose()
		{
			this.InternalDestroy();
			GC.SuppressFinalize(this);
		}

		/// <summary>
		///   <para>Returns true if this DownloadHandler has been informed by its parent UnityWebRequest that all data has been received, and this DownloadHandler has completed any necessary post-download processing. (Read Only)</para>
		/// </summary>
		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001DAE RID: 7598
		public extern bool isDone
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns the raw bytes downloaded from the remote server, or null. (Read Only)</para>
		/// </summary>
		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x0000B87A File Offset: 0x00009A7A
		public byte[] data
		{
			get
			{
				return this.GetData();
			}
		}

		/// <summary>
		///   <para>Convenience property. Returns the bytes from data interpreted as a UTF8 string. (Read Only)</para>
		/// </summary>
		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x0000B882 File Offset: 0x00009A82
		public string text
		{
			get
			{
				return this.GetText();
			}
		}

		/// <summary>
		///   <para>Callback, invoked when the data property is accessed.</para>
		/// </summary>
		/// <returns>
		///   <para>Byte array to return as the value of the data property.</para>
		/// </returns>
		// Token: 0x06001DB1 RID: 7601 RVA: 0x00002096 File Offset: 0x00000296
		protected virtual byte[] GetData()
		{
			return null;
		}

		/// <summary>
		///   <para>Callback, invoked when the text property is accessed.</para>
		/// </summary>
		/// <returns>
		///   <para>String to return as the return value of the text property.</para>
		/// </returns>
		// Token: 0x06001DB2 RID: 7602 RVA: 0x000247A0 File Offset: 0x000229A0
		protected virtual string GetText()
		{
			byte[] data = this.GetData();
			if (data != null && data.Length > 0)
			{
				return Encoding.UTF8.GetString(data, 0, data.Length);
			}
			return string.Empty;
		}

		/// <summary>
		///   <para>Callback, invoked as data is received from the remote server.</para>
		/// </summary>
		/// <param name="data">A buffer containing unprocessed data, received from the remote server.</param>
		/// <param name="dataLength">The number of bytes in data which are new.</param>
		/// <returns>
		///   <para>True if the download should continue, false to abort.</para>
		/// </returns>
		// Token: 0x06001DB3 RID: 7603 RVA: 0x000021E1 File Offset: 0x000003E1
		protected virtual bool ReceiveData(byte[] data, int dataLength)
		{
			return true;
		}

		/// <summary>
		///   <para>Callback, invoked with a Content-Length header is received.</para>
		/// </summary>
		/// <param name="contentLength">The value of the received Content-Length header.</param>
		// Token: 0x06001DB4 RID: 7604 RVA: 0x00002753 File Offset: 0x00000953
		protected virtual void ReceiveContentLength(int contentLength)
		{
		}

		/// <summary>
		///   <para>Callback, invoked when all data has been received from the remote server.</para>
		/// </summary>
		// Token: 0x06001DB5 RID: 7605 RVA: 0x00002753 File Offset: 0x00000953
		protected virtual void CompleteContent()
		{
		}

		/// <summary>
		///   <para>Callback, invoked when UnityWebRequest.downloadProgress is accessed.</para>
		/// </summary>
		/// <returns>
		///   <para>The return value for UnityWebRequest.downloadProgress.</para>
		/// </returns>
		// Token: 0x06001DB6 RID: 7606 RVA: 0x0000B829 File Offset: 0x00009A29
		protected virtual float GetProgress()
		{
			return 0.5f;
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x000247D8 File Offset: 0x000229D8
		protected static T GetCheckedDownloader<T>(UnityWebRequest www) where T : DownloadHandler
		{
			if (www == null)
			{
				throw new NullReferenceException("Cannot get content from a null UnityWebRequest object");
			}
			if (!www.isDone)
			{
				throw new InvalidOperationException("Cannot get content from an unfinished UnityWebRequest object");
			}
			if (www.isError)
			{
				throw new InvalidOperationException(www.error);
			}
			return (T)((object)www.downloadHandler);
		}

		// Token: 0x040007EA RID: 2026
		[NonSerialized]
		internal IntPtr m_Ptr;
	}
}
