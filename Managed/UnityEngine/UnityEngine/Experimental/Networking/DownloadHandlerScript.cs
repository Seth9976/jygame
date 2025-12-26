using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.Experimental.Networking
{
	/// <summary>
	///   <para>An abstract base class for user-created scripting-driven DownloadHandler implementations.</para>
	/// </summary>
	// Token: 0x020001F9 RID: 505
	[StructLayout(LayoutKind.Sequential)]
	public class DownloadHandlerScript : DownloadHandler
	{
		/// <summary>
		///   <para>Create a DownloadHandlerScript which allocates new buffers when passing data to callbacks.</para>
		/// </summary>
		// Token: 0x06001DBE RID: 7614 RVA: 0x0000B8B5 File Offset: 0x00009AB5
		public DownloadHandlerScript()
		{
			base.InternalCreateScript();
		}

		/// <summary>
		///   <para>Create a DownloadHandlerScript which reuses a preallocated buffer to pass data to callbacks.</para>
		/// </summary>
		/// <param name="preallocatedBuffer">A byte buffer into which data will be copied, for use by DownloadHandler.ReceiveData.</param>
		// Token: 0x06001DBF RID: 7615 RVA: 0x0000B8C3 File Offset: 0x00009AC3
		public DownloadHandlerScript(byte[] preallocatedBuffer)
		{
			if (preallocatedBuffer == null || preallocatedBuffer.Length < 1)
			{
				throw new ArgumentException("Cannot create a preallocated-buffer DownloadHandlerScript backed by a null or zero-length array");
			}
			base.InternalCreateScript();
			this.InternalSetPreallocatedBuffer(preallocatedBuffer);
		}

		// Token: 0x06001DC0 RID: 7616
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalSetPreallocatedBuffer(byte[] buffer);
	}
}
