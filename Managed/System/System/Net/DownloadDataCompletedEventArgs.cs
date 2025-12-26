using System;
using System.ComponentModel;

namespace System.Net
{
	/// <summary>Provides data for the <see cref="E:System.Net.WebClient.DownloadDataCompleted" /> event.</summary>
	// Token: 0x020004E2 RID: 1250
	public class DownloadDataCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x06002C49 RID: 11337 RVA: 0x0001EA76 File Offset: 0x0001CC76
		internal DownloadDataCompletedEventArgs(byte[] result, Exception error, bool cancelled, object userState)
			: base(error, cancelled, userState)
		{
			this.result = result;
		}

		/// <summary>Gets the data that is downloaded by a <see cref="Overload:System.Net.WebClient.DownloadDataAsync" /> method.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array that contains the downloaded data.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x0001EA89 File Offset: 0x0001CC89
		public byte[] Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x04001BB9 RID: 7097
		private byte[] result;
	}
}
