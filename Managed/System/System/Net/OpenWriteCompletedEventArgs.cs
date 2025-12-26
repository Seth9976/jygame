using System;
using System.ComponentModel;
using System.IO;

namespace System.Net
{
	/// <summary>Provides data for the <see cref="E:System.Net.WebClient.OpenWriteCompleted" /> event.</summary>
	// Token: 0x020004E5 RID: 1253
	public class OpenWriteCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x06002C50 RID: 11344 RVA: 0x0001EAE9 File Offset: 0x0001CCE9
		internal OpenWriteCompletedEventArgs(Stream result, Exception error, bool cancelled, object userState)
			: base(error, cancelled, userState)
		{
			this.result = result;
		}

		/// <summary>Gets a writable stream that is used to send data to a server.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> where you can write data to be uploaded.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x0001EAFC File Offset: 0x0001CCFC
		public Stream Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x04001BBD RID: 7101
		private Stream result;
	}
}
