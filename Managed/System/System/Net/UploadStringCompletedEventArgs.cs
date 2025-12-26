using System;
using System.ComponentModel;

namespace System.Net
{
	/// <summary>Provides data for the <see cref="E:System.Net.WebClient.UploadStringCompleted" /> event.</summary>
	// Token: 0x020004E4 RID: 1252
	public class UploadStringCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x06002C4E RID: 11342 RVA: 0x0001EACE File Offset: 0x0001CCCE
		internal UploadStringCompletedEventArgs(string result, Exception error, bool cancelled, object userState)
			: base(error, cancelled, userState)
		{
			this.result = result;
		}

		/// <summary>Gets the server reply to a string upload operation that is started by calling an <see cref="Overload:System.Net.WebClient.UploadStringAsync" /> method.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array that contains the server reply.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x0001EAE1 File Offset: 0x0001CCE1
		public string Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x04001BBC RID: 7100
		private string result;
	}
}
