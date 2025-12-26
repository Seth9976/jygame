using System;
using System.IO;

namespace System.Net
{
	/// <summary>Encapsulates a File Transfer Protocol (FTP) server's response to a request.</summary>
	// Token: 0x02000324 RID: 804
	public class FtpWebResponse : WebResponse
	{
		// Token: 0x06001B97 RID: 7063 RVA: 0x00052FA4 File Offset: 0x000511A4
		internal FtpWebResponse(FtpWebRequest request, global::System.Uri uri, string method, bool keepAlive)
		{
			this.request = request;
			this.uri = uri;
			this.method = method;
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00053000 File Offset: 0x00051200
		internal FtpWebResponse(FtpWebRequest request, global::System.Uri uri, string method, FtpStatusCode statusCode, string statusDescription)
		{
			this.request = request;
			this.uri = uri;
			this.method = method;
			this.statusCode = statusCode;
			this.statusDescription = statusDescription;
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x00014077 File Offset: 0x00012277
		internal FtpWebResponse(FtpWebRequest request, global::System.Uri uri, string method, FtpStatus status)
			: this(request, uri, method, status.StatusCode, status.StatusDescription)
		{
		}

		/// <summary>Gets the length of the data received from the FTP server.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that contains the number of bytes of data received from the FTP server. </returns>
		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x00014090 File Offset: 0x00012290
		public override long ContentLength
		{
			get
			{
				return this.contentLength;
			}
		}

		/// <summary>Gets an empty <see cref="T:System.Net.WebHeaderCollection" /> object.</summary>
		/// <returns>An empty <see cref="T:System.Net.WebHeaderCollection" /> object.</returns>
		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x00014098 File Offset: 0x00012298
		public override WebHeaderCollection Headers
		{
			get
			{
				return new WebHeaderCollection();
			}
		}

		/// <summary>Gets the URI that sent the response to the request.</summary>
		/// <returns>A <see cref="T:System.Uri" /> instance that identifies the resource associated with this response.</returns>
		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x0001409F File Offset: 0x0001229F
		public override global::System.Uri ResponseUri
		{
			get
			{
				return this.uri;
			}
		}

		/// <summary>Gets the date and time that a file on an FTP server was last modified.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> that contains the last modified date and time for a file.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x000140A7 File Offset: 0x000122A7
		// (set) Token: 0x06001B9E RID: 7070 RVA: 0x000140AF File Offset: 0x000122AF
		public DateTime LastModified
		{
			get
			{
				return this.lastModified;
			}
			internal set
			{
				this.lastModified = value;
			}
		}

		/// <summary>Gets the message sent by the FTP server when a connection is established prior to logon.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the banner message sent by the server; otherwise, <see cref="F:System.String.Empty" /> if no message is sent.</returns>
		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x000140B8 File Offset: 0x000122B8
		// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x000140C0 File Offset: 0x000122C0
		public string BannerMessage
		{
			get
			{
				return this.bannerMessage;
			}
			internal set
			{
				this.bannerMessage = value;
			}
		}

		/// <summary>Gets the message sent by the FTP server when authentication is complete.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the welcome message sent by the server; otherwise, <see cref="F:System.String.Empty" /> if no message is sent.</returns>
		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x000140C9 File Offset: 0x000122C9
		// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x000140D1 File Offset: 0x000122D1
		public string WelcomeMessage
		{
			get
			{
				return this.welcomeMessage;
			}
			internal set
			{
				this.welcomeMessage = value;
			}
		}

		/// <summary>Gets the message sent by the server when the FTP session is ending.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the exit message sent by the server; otherwise, <see cref="F:System.String.Empty" /> if no message is sent.</returns>
		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x000140DA File Offset: 0x000122DA
		// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x000140E2 File Offset: 0x000122E2
		public string ExitMessage
		{
			get
			{
				return this.exitMessage;
			}
			internal set
			{
				this.exitMessage = value;
			}
		}

		/// <summary>Gets the most recent status code sent from the FTP server.</summary>
		/// <returns>An <see cref="T:System.Net.FtpStatusCode" /> value that indicates the most recent status code returned with this response.</returns>
		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x000140EB File Offset: 0x000122EB
		// (set) Token: 0x06001BA6 RID: 7078 RVA: 0x000140F3 File Offset: 0x000122F3
		public FtpStatusCode StatusCode
		{
			get
			{
				return this.statusCode;
			}
			private set
			{
				this.statusCode = value;
			}
		}

		/// <summary>Gets text that describes a status code sent from the FTP server.</summary>
		/// <returns>A <see cref="T:System.String" /> instance that contains the status code and message returned with this response.</returns>
		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x000140FC File Offset: 0x000122FC
		// (set) Token: 0x06001BA8 RID: 7080 RVA: 0x00014104 File Offset: 0x00012304
		public string StatusDescription
		{
			get
			{
				return this.statusDescription;
			}
			private set
			{
				this.statusDescription = value;
			}
		}

		/// <summary>Frees the resources held by the response.</summary>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06001BA9 RID: 7081 RVA: 0x0005306C File Offset: 0x0005126C
		public override void Close()
		{
			if (this.disposed)
			{
				return;
			}
			this.disposed = true;
			if (this.stream != null)
			{
				this.stream.Close();
				if (this.stream == Stream.Null)
				{
					this.request.OperationCompleted();
				}
			}
			this.stream = null;
		}

		/// <summary>Retrieves the stream that contains response data sent from an FTP server.</summary>
		/// <returns>A readable <see cref="T:System.IO.Stream" /> instance that contains data returned with the response; otherwise, <see cref="F:System.IO.Stream.Null" /> if no response data was returned by the server.</returns>
		/// <exception cref="T:System.InvalidOperationException">The response did not return a data stream. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06001BAA RID: 7082 RVA: 0x000530C4 File Offset: 0x000512C4
		public override Stream GetResponseStream()
		{
			if (this.stream == null)
			{
				return Stream.Null;
			}
			if (this.method != "RETR" && this.method != "NLST")
			{
				this.CheckDisposed();
			}
			return this.stream;
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00014116 File Offset: 0x00012316
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x0001410D File Offset: 0x0001230D
		internal Stream Stream
		{
			get
			{
				return this.stream;
			}
			set
			{
				this.stream = value;
			}
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0001411E File Offset: 0x0001231E
		internal void UpdateStatus(FtpStatus status)
		{
			this.statusCode = status.StatusCode;
			this.statusDescription = status.StatusDescription;
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00014138 File Offset: 0x00012338
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00014156 File Offset: 0x00012356
		internal bool IsFinal()
		{
			return this.statusCode >= FtpStatusCode.CommandOK;
		}

		// Token: 0x040010F1 RID: 4337
		private Stream stream;

		// Token: 0x040010F2 RID: 4338
		private global::System.Uri uri;

		// Token: 0x040010F3 RID: 4339
		private FtpStatusCode statusCode;

		// Token: 0x040010F4 RID: 4340
		private DateTime lastModified = DateTime.MinValue;

		// Token: 0x040010F5 RID: 4341
		private string bannerMessage = string.Empty;

		// Token: 0x040010F6 RID: 4342
		private string welcomeMessage = string.Empty;

		// Token: 0x040010F7 RID: 4343
		private string exitMessage = string.Empty;

		// Token: 0x040010F8 RID: 4344
		private string statusDescription;

		// Token: 0x040010F9 RID: 4345
		private string method;

		// Token: 0x040010FA RID: 4346
		private bool disposed;

		// Token: 0x040010FB RID: 4347
		private FtpWebRequest request;

		// Token: 0x040010FC RID: 4348
		internal long contentLength = -1L;
	}
}
