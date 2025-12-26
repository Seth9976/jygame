using System;
using System.ComponentModel;
using System.IO;

namespace System.Net
{
	/// <summary>Provides data for the <see cref="E:System.Net.WebClient.OpenReadCompleted" /> event.</summary>
	// Token: 0x020004E0 RID: 1248
	public class OpenReadCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x06002C45 RID: 11333 RVA: 0x0001EA40 File Offset: 0x0001CC40
		internal OpenReadCompletedEventArgs(Stream result, Exception error, bool cancelled, object userState)
			: base(error, cancelled, userState)
		{
			this.result = result;
		}

		/// <summary>Gets a readable stream that contains data downloaded by a <see cref="Overload:System.Net.WebClient.DownloadDataAsync" /> method.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> that contains the downloaded data.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06002C46 RID: 11334 RVA: 0x0001EA53 File Offset: 0x0001CC53
		public Stream Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x04001BB7 RID: 7095
		private Stream result;
	}
}
