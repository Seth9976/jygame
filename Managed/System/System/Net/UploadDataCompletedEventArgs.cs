using System;
using System.ComponentModel;

namespace System.Net
{
	/// <summary>Provides data for the <see cref="E:System.Net.WebClient.UploadDataCompleted" /> event.</summary>
	// Token: 0x020004DE RID: 1246
	public class UploadDataCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x06002C41 RID: 11329 RVA: 0x0001EA0A File Offset: 0x0001CC0A
		internal UploadDataCompletedEventArgs(byte[] result, Exception error, bool cancelled, object userState)
			: base(error, cancelled, userState)
		{
			this.result = result;
		}

		/// <summary>Gets the server reply to a data upload operation started by calling an <see cref="Overload:System.Net.WebClient.UploadDataAsync" /> method.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the server reply.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06002C42 RID: 11330 RVA: 0x0001EA1D File Offset: 0x0001CC1D
		public byte[] Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x04001BB5 RID: 7093
		private byte[] result;
	}
}
