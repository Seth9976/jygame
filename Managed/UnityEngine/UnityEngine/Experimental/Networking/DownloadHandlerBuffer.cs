using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.Experimental.Networking
{
	/// <summary>
	///   <para>A general-purpose DownloadHandler implementation which stores received data in a native byte buffer.</para>
	/// </summary>
	// Token: 0x020001F8 RID: 504
	[StructLayout(LayoutKind.Sequential)]
	public sealed class DownloadHandlerBuffer : DownloadHandler
	{
		/// <summary>
		///   <para>Default constructor.</para>
		/// </summary>
		// Token: 0x06001DB8 RID: 7608 RVA: 0x0000B88A File Offset: 0x00009A8A
		public DownloadHandlerBuffer()
		{
			base.InternalCreateString();
		}

		/// <summary>
		///   <para>Returns a copy of the contents of the native-memory data buffer as a byte array.</para>
		/// </summary>
		/// <returns>
		///   <para>A copy of the data which has been downloaded.</para>
		/// </returns>
		// Token: 0x06001DB9 RID: 7609 RVA: 0x0000B898 File Offset: 0x00009A98
		protected override byte[] GetData()
		{
			return this.InternalGetData();
		}

		/// <summary>
		///   <para>Returns a copy of the native-memory buffer interpreted as a UTF8 string.</para>
		/// </summary>
		/// <returns>
		///   <para>A string representing the data in the native-memory buffer.</para>
		/// </returns>
		// Token: 0x06001DBA RID: 7610 RVA: 0x0000B8A0 File Offset: 0x00009AA0
		protected override string GetText()
		{
			return this.InternalGetText();
		}

		// Token: 0x06001DBB RID: 7611
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern byte[] InternalGetData();

		// Token: 0x06001DBC RID: 7612
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern string InternalGetText();

		/// <summary>
		///   <para>Returns a copy of the native-memory buffer interpreted as a UTF8 string.</para>
		/// </summary>
		/// <param name="www">A finished UnityWebRequest object with DownloadHandlerBuffer attached.</param>
		/// <returns>
		///   <para>The same as [DownloadHandlerBuffer.text]</para>
		/// </returns>
		// Token: 0x06001DBD RID: 7613 RVA: 0x0000B8A8 File Offset: 0x00009AA8
		public static string GetContent(UnityWebRequest www)
		{
			return DownloadHandler.GetCheckedDownloader<DownloadHandlerBuffer>(www).text;
		}
	}
}
