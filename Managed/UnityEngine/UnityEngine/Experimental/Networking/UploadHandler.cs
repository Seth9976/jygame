using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.Experimental.Networking
{
	/// <summary>
	///   <para>Helper object for UnityWebRequests. Manages the buffering and transmission of body data during HTTP requests.</para>
	/// </summary>
	// Token: 0x020001F5 RID: 501
	[StructLayout(LayoutKind.Sequential)]
	public class UploadHandler : IDisposable
	{
		// Token: 0x06001D8E RID: 7566 RVA: 0x000021D6 File Offset: 0x000003D6
		internal UploadHandler()
		{
		}

		// Token: 0x06001D8F RID: 7567
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreateRaw(byte[] data);

		// Token: 0x06001D90 RID: 7568
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalDestroy();

		// Token: 0x06001D91 RID: 7569 RVA: 0x00024740 File Offset: 0x00022940
		~UploadHandler()
		{
			this.InternalDestroy();
		}

		/// <summary>
		///   <para>Signals that this [UploadHandler] is no longer being used, and should clean up any resources it is using.</para>
		/// </summary>
		// Token: 0x06001D92 RID: 7570 RVA: 0x0000B7F3 File Offset: 0x000099F3
		public void Dispose()
		{
			this.InternalDestroy();
			GC.SuppressFinalize(this);
		}

		/// <summary>
		///   <para>The raw data which will be transmitted to the remote server as body data. (Read Only)</para>
		/// </summary>
		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x0000B801 File Offset: 0x00009A01
		public byte[] data
		{
			get
			{
				return this.GetData();
			}
		}

		/// <summary>
		///   <para>Determines the default Content-Type header which will be transmitted with the outbound HTTP request.</para>
		/// </summary>
		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x0000B809 File Offset: 0x00009A09
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x0000B811 File Offset: 0x00009A11
		public string contentType
		{
			get
			{
				return this.GetContentType();
			}
			set
			{
				this.SetContentType(value);
			}
		}

		/// <summary>
		///   <para>Returns the proportion of data uploaded to the remote server compared to the total amount of data to upload. (Read Only)</para>
		/// </summary>
		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x0000B81A File Offset: 0x00009A1A
		public float progress
		{
			get
			{
				return this.GetProgress();
			}
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00002096 File Offset: 0x00000296
		internal virtual byte[] GetData()
		{
			return null;
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x0000B822 File Offset: 0x00009A22
		internal virtual string GetContentType()
		{
			return "text/plain";
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00002753 File Offset: 0x00000953
		internal virtual void SetContentType(string newContentType)
		{
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x0000B829 File Offset: 0x00009A29
		internal virtual float GetProgress()
		{
			return 0.5f;
		}

		// Token: 0x040007E9 RID: 2025
		[NonSerialized]
		internal IntPtr m_Ptr;
	}
}
