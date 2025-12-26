using System;
using System.ComponentModel;

namespace System.Net
{
	/// <summary>Provides data for the <see cref="E:System.Net.WebClient.UploadFileCompleted" /> event.</summary>
	// Token: 0x020004DF RID: 1247
	public class UploadFileCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x06002C43 RID: 11331 RVA: 0x0001EA25 File Offset: 0x0001CC25
		internal UploadFileCompletedEventArgs(byte[] result, Exception error, bool cancelled, object userState)
			: base(error, cancelled, userState)
		{
			this.result = result;
		}

		/// <summary>Gets the server reply to a data upload operation that is started by calling an <see cref="Overload:System.Net.WebClient.UploadFileAsync" /> method.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array that contains the server reply.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x0001EA38 File Offset: 0x0001CC38
		public byte[] Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x04001BB6 RID: 7094
		private byte[] result;
	}
}
