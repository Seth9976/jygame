using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.Experimental.Networking
{
	/// <summary>
	///   <para>A general-purpose UploadHandler subclass, using a native-code memory buffer.</para>
	/// </summary>
	// Token: 0x020001F6 RID: 502
	[StructLayout(LayoutKind.Sequential)]
	public sealed class UploadHandlerRaw : UploadHandler
	{
		/// <summary>
		///   <para>General constructor. Contents of the input argument are copied into a native buffer.</para>
		/// </summary>
		/// <param name="data">Raw data to transmit to the remote server.</param>
		// Token: 0x06001D9B RID: 7579 RVA: 0x0000B830 File Offset: 0x00009A30
		public UploadHandlerRaw(byte[] data)
		{
			base.InternalCreateRaw(data);
		}

		// Token: 0x06001D9C RID: 7580
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern string InternalGetContentType();

		// Token: 0x06001D9D RID: 7581
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalSetContentType(string newContentType);

		// Token: 0x06001D9E RID: 7582
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern byte[] InternalGetData();

		// Token: 0x06001D9F RID: 7583
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern float InternalGetProgress();

		// Token: 0x06001DA0 RID: 7584 RVA: 0x0000B83F File Offset: 0x00009A3F
		internal override string GetContentType()
		{
			return this.InternalGetContentType();
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x0000B847 File Offset: 0x00009A47
		internal override void SetContentType(string newContentType)
		{
			this.InternalSetContentType(newContentType);
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x0000B850 File Offset: 0x00009A50
		internal override byte[] GetData()
		{
			return this.InternalGetData();
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x0000B858 File Offset: 0x00009A58
		internal override float GetProgress()
		{
			return this.InternalGetProgress();
		}
	}
}
