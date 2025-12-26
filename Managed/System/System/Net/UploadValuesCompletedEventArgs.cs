using System;
using System.ComponentModel;

namespace System.Net
{
	/// <summary>Provides data for the <see cref="E:System.Net.WebClient.UploadValuesCompleted" /> event.</summary>
	// Token: 0x020004E7 RID: 1255
	public class UploadValuesCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x06002C57 RID: 11351 RVA: 0x0001EB4D File Offset: 0x0001CD4D
		internal UploadValuesCompletedEventArgs(byte[] result, Exception error, bool cancelled, object userState)
			: base(error, cancelled, userState)
		{
			this.result = result;
		}

		/// <summary>Gets the server reply to a data upload operation started by calling an <see cref="Overload:System.Net.WebClient.UploadValuesAsync" /> method.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the server reply.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002C58 RID: 11352 RVA: 0x0001EB60 File Offset: 0x0001CD60
		public byte[] Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x04001BC2 RID: 7106
		private byte[] result;
	}
}
