using System;
using System.ComponentModel;

namespace System.Net
{
	/// <summary>Provides data for the <see cref="E:System.Net.WebClient.DownloadStringCompleted" /> event.</summary>
	// Token: 0x020004E1 RID: 1249
	public class DownloadStringCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x06002C47 RID: 11335 RVA: 0x0001EA5B File Offset: 0x0001CC5B
		internal DownloadStringCompletedEventArgs(string result, Exception error, bool cancelled, object userState)
			: base(error, cancelled, userState)
		{
			this.result = result;
		}

		/// <summary>Gets the data that is downloaded by a <see cref="Overload:System.Net.WebClient.DownloadStringAsync" /> method.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the downloaded data.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x0001EA6E File Offset: 0x0001CC6E
		public string Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x04001BB8 RID: 7096
		private string result;
	}
}
