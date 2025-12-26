using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Net.Cache;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace System.Net
{
	/// <summary>Provides common methods for sending data to and receiving data from a resource identified by a URI.</summary>
	// Token: 0x0200042C RID: 1068
	[ComVisible(true)]
	public class WebClient : global::System.ComponentModel.Component
	{
		// Token: 0x06002535 RID: 9525 RVA: 0x0006C470 File Offset: 0x0006A670
		static WebClient()
		{
			int num = 0;
			int i = 48;
			while (i <= 57)
			{
				WebClient.hexBytes[num] = (byte)i;
				i++;
				num++;
			}
			int j = 97;
			while (j <= 102)
			{
				WebClient.hexBytes[num] = (byte)j;
				j++;
				num++;
			}
		}

		/// <summary>Occurs when an asynchronous data download operation completes.</summary>
		// Token: 0x14000053 RID: 83
		// (add) Token: 0x06002536 RID: 9526 RVA: 0x0001A1CD File Offset: 0x000183CD
		// (remove) Token: 0x06002537 RID: 9527 RVA: 0x0001A1E6 File Offset: 0x000183E6
		public event DownloadDataCompletedEventHandler DownloadDataCompleted;

		/// <summary>Occurs when an asynchronous file download operation completes.</summary>
		// Token: 0x14000054 RID: 84
		// (add) Token: 0x06002538 RID: 9528 RVA: 0x0001A1FF File Offset: 0x000183FF
		// (remove) Token: 0x06002539 RID: 9529 RVA: 0x0001A218 File Offset: 0x00018418
		public event global::System.ComponentModel.AsyncCompletedEventHandler DownloadFileCompleted;

		/// <summary>Occurs when an asynchronous download operation successfully transfers some or all of the data.</summary>
		// Token: 0x14000055 RID: 85
		// (add) Token: 0x0600253A RID: 9530 RVA: 0x0001A231 File Offset: 0x00018431
		// (remove) Token: 0x0600253B RID: 9531 RVA: 0x0001A24A File Offset: 0x0001844A
		public event DownloadProgressChangedEventHandler DownloadProgressChanged;

		/// <summary>Occurs when an asynchronous resource-download operation completes.</summary>
		// Token: 0x14000056 RID: 86
		// (add) Token: 0x0600253C RID: 9532 RVA: 0x0001A263 File Offset: 0x00018463
		// (remove) Token: 0x0600253D RID: 9533 RVA: 0x0001A27C File Offset: 0x0001847C
		public event DownloadStringCompletedEventHandler DownloadStringCompleted;

		/// <summary>Occurs when an asynchronous operation to open a stream containing a resource completes.</summary>
		// Token: 0x14000057 RID: 87
		// (add) Token: 0x0600253E RID: 9534 RVA: 0x0001A295 File Offset: 0x00018495
		// (remove) Token: 0x0600253F RID: 9535 RVA: 0x0001A2AE File Offset: 0x000184AE
		public event OpenReadCompletedEventHandler OpenReadCompleted;

		/// <summary>Occurs when an asynchronous operation to open a stream to write data to a resource completes.</summary>
		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06002540 RID: 9536 RVA: 0x0001A2C7 File Offset: 0x000184C7
		// (remove) Token: 0x06002541 RID: 9537 RVA: 0x0001A2E0 File Offset: 0x000184E0
		public event OpenWriteCompletedEventHandler OpenWriteCompleted;

		/// <summary>Occurs when an asynchronous data-upload operation completes.</summary>
		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06002542 RID: 9538 RVA: 0x0001A2F9 File Offset: 0x000184F9
		// (remove) Token: 0x06002543 RID: 9539 RVA: 0x0001A312 File Offset: 0x00018512
		public event UploadDataCompletedEventHandler UploadDataCompleted;

		/// <summary>Occurs when an asynchronous file-upload operation completes.</summary>
		// Token: 0x1400005A RID: 90
		// (add) Token: 0x06002544 RID: 9540 RVA: 0x0001A32B File Offset: 0x0001852B
		// (remove) Token: 0x06002545 RID: 9541 RVA: 0x0001A344 File Offset: 0x00018544
		public event UploadFileCompletedEventHandler UploadFileCompleted;

		/// <summary>Occurs when an asynchronous upload operation successfully transfers some or all of the data.</summary>
		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06002546 RID: 9542 RVA: 0x0001A35D File Offset: 0x0001855D
		// (remove) Token: 0x06002547 RID: 9543 RVA: 0x0001A376 File Offset: 0x00018576
		public event UploadProgressChangedEventHandler UploadProgressChanged;

		/// <summary>Occurs when an asynchronous string-upload operation completes.</summary>
		// Token: 0x1400005C RID: 92
		// (add) Token: 0x06002548 RID: 9544 RVA: 0x0001A38F File Offset: 0x0001858F
		// (remove) Token: 0x06002549 RID: 9545 RVA: 0x0001A3A8 File Offset: 0x000185A8
		public event UploadStringCompletedEventHandler UploadStringCompleted;

		/// <summary>Occurs when an asynchronous upload of a name/value collection completes.</summary>
		// Token: 0x1400005D RID: 93
		// (add) Token: 0x0600254A RID: 9546 RVA: 0x0001A3C1 File Offset: 0x000185C1
		// (remove) Token: 0x0600254B RID: 9547 RVA: 0x0001A3DA File Offset: 0x000185DA
		public event UploadValuesCompletedEventHandler UploadValuesCompleted;

		/// <summary>Gets or sets the base URI for requests made by a <see cref="T:System.Net.WebClient" />.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the base URI for requests made by a <see cref="T:System.Net.WebClient" /> or <see cref="F:System.String.Empty" /> if no base address has been specified.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Net.WebClient.BaseAddress" /> is set to an invalid URI. The inner exception may contain information that will help you locate the error.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x0600254C RID: 9548 RVA: 0x0001A3F3 File Offset: 0x000185F3
		// (set) Token: 0x0600254D RID: 9549 RVA: 0x0001A42E File Offset: 0x0001862E
		public string BaseAddress
		{
			get
			{
				if (this.baseString == null && this.baseAddress == null)
				{
					return string.Empty;
				}
				this.baseString = this.baseAddress.ToString();
				return this.baseString;
			}
			set
			{
				if (value == null || value.Length == 0)
				{
					this.baseAddress = null;
				}
				else
				{
					this.baseAddress = new global::System.Uri(value);
				}
			}
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00005023 File Offset: 0x00003223
		private static Exception GetMustImplement()
		{
			return new NotImplementedException();
		}

		/// <summary>Gets or sets the application's cache policy for any resources obtained by this WebClient instance using <see cref="T:System.Net.WebRequest" /> objects.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.RequestCachePolicy" /> object that represents the application's caching requirements.</returns>
		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x0600254F RID: 9551 RVA: 0x0001A459 File Offset: 0x00018659
		// (set) Token: 0x06002550 RID: 9552 RVA: 0x0001A459 File Offset: 0x00018659
		[global::System.MonoTODO]
		public global::System.Net.Cache.RequestCachePolicy CachePolicy
		{
			get
			{
				throw WebClient.GetMustImplement();
			}
			set
			{
				throw WebClient.GetMustImplement();
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that controls whether the <see cref="P:System.Net.CredentialCache.DefaultCredentials" /> are sent with requests.</summary>
		/// <returns>true if the default credentials are used; otherwise false. The default value is false.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="USERNAME" />
		/// </PermissionSet>
		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x0001A459 File Offset: 0x00018659
		// (set) Token: 0x06002552 RID: 9554 RVA: 0x0001A459 File Offset: 0x00018659
		[global::System.MonoTODO]
		public bool UseDefaultCredentials
		{
			get
			{
				throw WebClient.GetMustImplement();
			}
			set
			{
				throw WebClient.GetMustImplement();
			}
		}

		/// <summary>Gets or sets the network credentials that are sent to the host and used to authenticate the request.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> containing the authentication credentials for the request. The default is null.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x0001A460 File Offset: 0x00018660
		// (set) Token: 0x06002554 RID: 9556 RVA: 0x0001A468 File Offset: 0x00018668
		public ICredentials Credentials
		{
			get
			{
				return this.credentials;
			}
			set
			{
				this.credentials = value;
			}
		}

		/// <summary>Gets or sets a collection of header name/value pairs associated with the request.</summary>
		/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> containing header name/value pairs associated with this request.</returns>
		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002555 RID: 9557 RVA: 0x0001A471 File Offset: 0x00018671
		// (set) Token: 0x06002556 RID: 9558 RVA: 0x0001A48F File Offset: 0x0001868F
		public WebHeaderCollection Headers
		{
			get
			{
				if (this.headers == null)
				{
					this.headers = new WebHeaderCollection();
				}
				return this.headers;
			}
			set
			{
				this.headers = value;
			}
		}

		/// <summary>Gets or sets a collection of query name/value pairs associated with the request.</summary>
		/// <returns>A <see cref="T:System.Collections.Specialized.NameValueCollection" /> that contains query name/value pairs associated with the request. If no pairs are associated with the request, the value is an empty <see cref="T:System.Collections.Specialized.NameValueCollection" />.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002557 RID: 9559 RVA: 0x0001A498 File Offset: 0x00018698
		// (set) Token: 0x06002558 RID: 9560 RVA: 0x0001A4B6 File Offset: 0x000186B6
		public global::System.Collections.Specialized.NameValueCollection QueryString
		{
			get
			{
				if (this.queryString == null)
				{
					this.queryString = new global::System.Collections.Specialized.NameValueCollection();
				}
				return this.queryString;
			}
			set
			{
				this.queryString = value;
			}
		}

		/// <summary>Gets a collection of header name/value pairs associated with the response.</summary>
		/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> containing header name/value pairs associated with the response, or null if no response has been received.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x0001A4BF File Offset: 0x000186BF
		public WebHeaderCollection ResponseHeaders
		{
			get
			{
				return this.responseHeaders;
			}
		}

		/// <summary>Gets and sets the <see cref="T:System.Text.Encoding" /> used to upload and download strings.</summary>
		/// <returns>A <see cref="T:System.Text.Encoding" /> that is used to encode strings. The default value of this property is the encoding returned by <see cref="P:System.Text.Encoding.Default" />.</returns>
		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x0001A4C7 File Offset: 0x000186C7
		// (set) Token: 0x0600255B RID: 9563 RVA: 0x0001A4CF File Offset: 0x000186CF
		public Encoding Encoding
		{
			get
			{
				return this.encoding;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Encoding");
				}
				this.encoding = value;
			}
		}

		/// <summary>Gets or sets the proxy used by this <see cref="T:System.Net.WebClient" /> object.</summary>
		/// <returns>An <see cref="T:System.Net.IWebProxy" /> instance used to send requests.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <see cref="P:System.Net.WebClient.Proxy" /> is set to null. </exception>
		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x0001A4E9 File Offset: 0x000186E9
		// (set) Token: 0x0600255D RID: 9565 RVA: 0x0001A4F1 File Offset: 0x000186F1
		public IWebProxy Proxy
		{
			get
			{
				return this.proxy;
			}
			set
			{
				this.proxy = value;
			}
		}

		/// <summary>Gets whether a Web request is in progress.</summary>
		/// <returns>true if the Web request is still in progress; otherwise false.</returns>
		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x0001A4FA File Offset: 0x000186FA
		public bool IsBusy
		{
			get
			{
				return this.is_busy;
			}
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x0001A502 File Offset: 0x00018702
		private void CheckBusy()
		{
			if (this.IsBusy)
			{
				throw new NotSupportedException("WebClient does not support conccurent I/O operations.");
			}
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x0006C4D8 File Offset: 0x0006A6D8
		private void SetBusy()
		{
			lock (this)
			{
				this.CheckBusy();
				this.is_busy = true;
			}
		}

		/// <summary>Downloads the resource with the specified URI as a <see cref="T:System.Byte" /> array.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the downloaded resource.</returns>
		/// <param name="address">The URI from which to download data. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while downloading data. </exception>
		/// <exception cref="T:System.NotSupportedException">The method has been called simultaneously on multiple threads.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002561 RID: 9569 RVA: 0x0001A51A File Offset: 0x0001871A
		public byte[] DownloadData(string address)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return this.DownloadData(this.CreateUri(address));
		}

		/// <summary>Downloads the resource with the specified URI as a <see cref="T:System.Byte" /> array.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the downloaded resource.</returns>
		/// <param name="address">The URI represented by the <see cref="T:System.Uri" />  object, from which to download data.</param>
		// Token: 0x06002562 RID: 9570 RVA: 0x0006C518 File Offset: 0x0006A718
		public byte[] DownloadData(global::System.Uri address)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			byte[] array;
			try
			{
				this.SetBusy();
				this.async = false;
				array = this.DownloadDataCore(address, null);
			}
			finally
			{
				this.is_busy = false;
			}
			return array;
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x0006C578 File Offset: 0x0006A778
		private byte[] DownloadDataCore(global::System.Uri address, object userToken)
		{
			WebRequest webRequest = null;
			byte[] array;
			try
			{
				webRequest = this.SetupRequest(address);
				WebResponse webResponse = this.GetWebResponse(webRequest);
				Stream responseStream = webResponse.GetResponseStream();
				array = this.ReadAll(responseStream, (int)webResponse.ContentLength, userToken);
			}
			catch (ThreadInterruptedException)
			{
				if (webRequest != null)
				{
					webRequest.Abort();
				}
				throw;
			}
			catch (WebException ex)
			{
				throw;
			}
			catch (Exception ex2)
			{
				throw new WebException("An error occurred performing a WebClient request.", ex2);
			}
			return array;
		}

		/// <summary>Downloads the resource with the specified URI to a local file.</summary>
		/// <param name="address">The URI from which to download data. </param>
		/// <param name="fileName">The name of the local file that is to receive the data. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- <paramref name="filename" /> is null or <see cref="F:System.String.Empty" />.-or-The file does not exist.-or- An error occurred while downloading data. </exception>
		/// <exception cref="T:System.NotSupportedException">The method has been called simultaneously on multiple threads.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002564 RID: 9572 RVA: 0x0001A53A File Offset: 0x0001873A
		public void DownloadFile(string address, string fileName)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			this.DownloadFile(this.CreateUri(address), fileName);
		}

		/// <summary>Downloads the resource with the specified URI to a local file.</summary>
		/// <param name="address">The URI specified as a <see cref="T:System.String" />, from which to download data. </param>
		/// <param name="fileName">The name of the local file that is to receive the data. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- <paramref name="filename" /> is null or <see cref="F:System.String.Empty" />.-or- The file does not exist. -or- An error occurred while downloading data. </exception>
		/// <exception cref="T:System.NotSupportedException">The method has been called simultaneously on multiple threads.</exception>
		// Token: 0x06002565 RID: 9573 RVA: 0x0006C614 File Offset: 0x0006A814
		public void DownloadFile(global::System.Uri address, string fileName)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (fileName == null)
			{
				throw new ArgumentNullException("fileName");
			}
			try
			{
				this.SetBusy();
				this.async = false;
				this.DownloadFileCore(address, fileName, null);
			}
			catch (WebException ex)
			{
				throw;
			}
			catch (Exception ex2)
			{
				throw new WebException("An error occurred performing a WebClient request.", ex2);
			}
			finally
			{
				this.is_busy = false;
			}
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x0006C6B0 File Offset: 0x0006A8B0
		private void DownloadFileCore(global::System.Uri address, string fileName, object userToken)
		{
			WebRequest webRequest = null;
			using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
			{
				try
				{
					webRequest = this.SetupRequest(address);
					WebResponse webResponse = this.GetWebResponse(webRequest);
					Stream responseStream = webResponse.GetResponseStream();
					int num = (int)webResponse.ContentLength;
					int num2 = ((num > -1 && num <= 32768) ? num : 32768);
					byte[] array = new byte[num2];
					long num3 = 0L;
					int num4;
					while ((num4 = responseStream.Read(array, 0, num2)) != 0)
					{
						if (this.async)
						{
							num3 += (long)num4;
							this.OnDownloadProgressChanged(new DownloadProgressChangedEventArgs(num3, webResponse.ContentLength, userToken));
						}
						fileStream.Write(array, 0, num4);
					}
				}
				catch (ThreadInterruptedException)
				{
					if (webRequest != null)
					{
						webRequest.Abort();
					}
					throw;
				}
			}
		}

		/// <summary>Opens a readable stream for the data downloaded from a resource with the URI specified as a <see cref="T:System.String" />.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> used to read data from a resource.</returns>
		/// <param name="address">The URI specified as a <see cref="T:System.String" /> from which to download data. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, <paramref name="address" /> is invalid.-or- An error occurred while downloading data. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002567 RID: 9575 RVA: 0x0001A55B File Offset: 0x0001875B
		public Stream OpenRead(string address)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return this.OpenRead(this.CreateUri(address));
		}

		/// <summary>Opens a readable stream for the data downloaded from a resource with the URI specified as a <see cref="T:System.Uri" /></summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> used to read data from a resource.</returns>
		/// <param name="address">The URI specified as a <see cref="T:System.Uri" /> from which to download data. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, <paramref name="address" /> is invalid.-or- An error occurred while downloading data. </exception>
		// Token: 0x06002568 RID: 9576 RVA: 0x0006C7AC File Offset: 0x0006A9AC
		public Stream OpenRead(global::System.Uri address)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			Stream responseStream;
			try
			{
				this.SetBusy();
				this.async = false;
				WebRequest webRequest = this.SetupRequest(address);
				WebResponse webResponse = this.GetWebResponse(webRequest);
				responseStream = webResponse.GetResponseStream();
			}
			catch (WebException ex)
			{
				throw;
			}
			catch (Exception ex2)
			{
				throw new WebException("An error occurred performing a WebClient request.", ex2);
			}
			finally
			{
				this.is_busy = false;
			}
			return responseStream;
		}

		/// <summary>Opens a stream for writing data to the specified resource.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> used to write data to the resource.</returns>
		/// <param name="address">The URI of the resource to receive the data. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- An error occurred while opening the stream. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002569 RID: 9577 RVA: 0x0001A57B File Offset: 0x0001877B
		public Stream OpenWrite(string address)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return this.OpenWrite(this.CreateUri(address));
		}

		/// <summary>Opens a stream for writing data to the specified resource, using the specified method.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> used to write data to the resource.</returns>
		/// <param name="address">The URI of the resource to receive the data. </param>
		/// <param name="method">The method used to send the data to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- An error occurred while opening the stream. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x0600256A RID: 9578 RVA: 0x0001A59B File Offset: 0x0001879B
		public Stream OpenWrite(string address, string method)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return this.OpenWrite(this.CreateUri(address), method);
		}

		/// <summary>Opens a stream for writing data to the specified resource.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> used to write data to the resource.</returns>
		/// <param name="address">The URI of the resource to receive the data.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- An error occurred while opening the stream. </exception>
		// Token: 0x0600256B RID: 9579 RVA: 0x0001A5BC File Offset: 0x000187BC
		public Stream OpenWrite(global::System.Uri address)
		{
			return this.OpenWrite(address, null);
		}

		/// <summary>Opens a stream for writing data to the specified resource, by using the specified method.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> used to write data to the resource.</returns>
		/// <param name="address">The URI of the resource to receive the data.</param>
		/// <param name="method">The method used to send the data to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- An error occurred while opening the stream. </exception>
		// Token: 0x0600256C RID: 9580 RVA: 0x0006C850 File Offset: 0x0006AA50
		public Stream OpenWrite(global::System.Uri address, string method)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			Stream requestStream;
			try
			{
				this.SetBusy();
				this.async = false;
				WebRequest webRequest = this.SetupRequest(address, method, true);
				requestStream = webRequest.GetRequestStream();
			}
			catch (WebException ex)
			{
				throw;
			}
			catch (Exception ex2)
			{
				throw new WebException("An error occurred performing a WebClient request.", ex2);
			}
			finally
			{
				this.is_busy = false;
			}
			return requestStream;
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x0006C8E8 File Offset: 0x0006AAE8
		private string DetermineMethod(global::System.Uri address, string method, bool is_upload)
		{
			if (method != null)
			{
				return method;
			}
			if (address.Scheme == global::System.Uri.UriSchemeFtp)
			{
				return (!is_upload) ? "RETR" : "STOR";
			}
			return (!is_upload) ? "GET" : "POST";
		}

		/// <summary>Uploads a data buffer to a resource identified by a URI.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the body of the response from the resource.</returns>
		/// <param name="address">The URI of the resource to receive the data. </param>
		/// <param name="data">The data buffer to send to the resource. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- <paramref name="data" /> is null. -or-An error occurred while sending the data.-or- There was no response from the server hosting the resource. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x0600256E RID: 9582 RVA: 0x0001A5C6 File Offset: 0x000187C6
		public byte[] UploadData(string address, byte[] data)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return this.UploadData(this.CreateUri(address), data);
		}

		/// <summary>Uploads a data buffer to the specified resource, using the specified method.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the body of the response from the resource.</returns>
		/// <param name="address">The URI of the resource to receive the data. </param>
		/// <param name="method">The HTTP method used to send the data to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="data">The data buffer to send to the resource. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- <paramref name="data" /> is null.-or- An error occurred while uploading the data.-or- There was no response from the server hosting the resource. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x0600256F RID: 9583 RVA: 0x0001A5E7 File Offset: 0x000187E7
		public byte[] UploadData(string address, string method, byte[] data)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return this.UploadData(this.CreateUri(address), method, data);
		}

		/// <summary>Uploads a data buffer to a resource identified by a URI.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the body of the response from the resource.</returns>
		/// <param name="address">The URI of the resource to receive the data. </param>
		/// <param name="data">The data buffer to send to the resource. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- <paramref name="data" /> is null. -or-An error occurred while sending the data.-or- There was no response from the server hosting the resource. </exception>
		// Token: 0x06002570 RID: 9584 RVA: 0x0001A609 File Offset: 0x00018809
		public byte[] UploadData(global::System.Uri address, byte[] data)
		{
			return this.UploadData(address, null, data);
		}

		/// <summary>Uploads a data buffer to the specified resource, using the specified method.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the body of the response from the resource.</returns>
		/// <param name="address">The URI of the resource to receive the data. </param>
		/// <param name="method">The HTTP method used to send the data to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="data">The data buffer to send to the resource.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- <paramref name="data" /> is null.-or- An error occurred while uploading the data.-or- There was no response from the server hosting the resource. </exception>
		// Token: 0x06002571 RID: 9585 RVA: 0x0006C940 File Offset: 0x0006AB40
		public byte[] UploadData(global::System.Uri address, string method, byte[] data)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			byte[] array;
			try
			{
				this.SetBusy();
				this.async = false;
				array = this.UploadDataCore(address, method, data, null);
			}
			catch (WebException)
			{
				throw;
			}
			catch (Exception ex)
			{
				throw new WebException("An error occurred performing a WebClient request.", ex);
			}
			finally
			{
				this.is_busy = false;
			}
			return array;
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x0006C9E4 File Offset: 0x0006ABE4
		private byte[] UploadDataCore(global::System.Uri address, string method, byte[] data, object userToken)
		{
			WebRequest webRequest = this.SetupRequest(address, method, true);
			byte[] array;
			try
			{
				int num = data.Length;
				webRequest.ContentLength = (long)num;
				using (Stream requestStream = webRequest.GetRequestStream())
				{
					requestStream.Write(data, 0, num);
				}
				WebResponse webResponse = this.GetWebResponse(webRequest);
				Stream responseStream = webResponse.GetResponseStream();
				array = this.ReadAll(responseStream, (int)webResponse.ContentLength, userToken);
			}
			catch (ThreadInterruptedException)
			{
				if (webRequest != null)
				{
					webRequest.Abort();
				}
				throw;
			}
			return array;
		}

		/// <summary>Uploads the specified local file to a resource with the specified URI.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the body of the response from the resource.</returns>
		/// <param name="address">The URI of the resource to receive the file. For example, ftp://localhost/samplefile.txt.</param>
		/// <param name="fileName">The file to send to the resource. For example, "samplefile.txt".</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- <paramref name="fileName" /> is null, is <see cref="F:System.String.Empty" />, contains invalid characters, or does not exist.-or- An error occurred while uploading the file.-or- There was no response from the server hosting the resource.-or- The Content-type header begins with multipart. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002573 RID: 9587 RVA: 0x0001A614 File Offset: 0x00018814
		public byte[] UploadFile(string address, string fileName)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return this.UploadFile(this.CreateUri(address), fileName);
		}

		/// <summary>Uploads the specified local file to a resource with the specified URI.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the body of the response from the resource.</returns>
		/// <param name="address">The URI of the resource to receive the file. For example, ftp://localhost/samplefile.txt.</param>
		/// <param name="fileName">The file to send to the resource. For example, "samplefile.txt".</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- <paramref name="fileName" /> is null, is <see cref="F:System.String.Empty" />, contains invalid characters, or does not exist.-or- An error occurred while uploading the file.-or- There was no response from the server hosting the resource.-or- The Content-type header begins with multipart. </exception>
		// Token: 0x06002574 RID: 9588 RVA: 0x0001A635 File Offset: 0x00018835
		public byte[] UploadFile(global::System.Uri address, string fileName)
		{
			return this.UploadFile(address, null, fileName);
		}

		/// <summary>Uploads the specified local file to the specified resource, using the specified method.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the body of the response from the resource.</returns>
		/// <param name="address">The URI of the resource to receive the file.</param>
		/// <param name="method">The HTTP method used to send the file to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="fileName">The file to send to the resource. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- <paramref name="fileName" /> is null, is <see cref="F:System.String.Empty" />, contains invalid characters, or does not exist.-or- An error occurred while uploading the file.-or- There was no response from the server hosting the resource.-or- The Content-type header begins with multipart. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002575 RID: 9589 RVA: 0x0001A640 File Offset: 0x00018840
		public byte[] UploadFile(string address, string method, string fileName)
		{
			return this.UploadFile(this.CreateUri(address), method, fileName);
		}

		/// <summary>Uploads the specified local file to the specified resource, using the specified method.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the body of the response from the resource.</returns>
		/// <param name="address">The URI of the resource to receive the file.</param>
		/// <param name="method">The HTTP method used to send the file to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="fileName">The file to send to the resource. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- <paramref name="fileName" /> is null, is <see cref="F:System.String.Empty" />, contains invalid characters, or does not exist.-or- An error occurred while uploading the file.-or- There was no response from the server hosting the resource.-or- The Content-type header begins with multipart. </exception>
		// Token: 0x06002576 RID: 9590 RVA: 0x0006CA88 File Offset: 0x0006AC88
		public byte[] UploadFile(global::System.Uri address, string method, string fileName)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (fileName == null)
			{
				throw new ArgumentNullException("fileName");
			}
			byte[] array;
			try
			{
				this.SetBusy();
				this.async = false;
				array = this.UploadFileCore(address, method, fileName, null);
			}
			catch (WebException ex)
			{
				throw;
			}
			catch (Exception ex2)
			{
				throw new WebException("An error occurred performing a WebClient request.", ex2);
			}
			finally
			{
				this.is_busy = false;
			}
			return array;
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x0006CB2C File Offset: 0x0006AD2C
		private byte[] UploadFileCore(global::System.Uri address, string method, string fileName, object userToken)
		{
			string text = this.Headers["Content-Type"];
			if (text != null)
			{
				string text2 = text.ToLower();
				if (text2.StartsWith("multipart/"))
				{
					throw new WebException("Content-Type cannot be set to a multipart type for this request.");
				}
			}
			else
			{
				text = "application/octet-stream";
			}
			string text3 = "------------" + DateTime.Now.Ticks.ToString("x");
			this.Headers["Content-Type"] = string.Format("multipart/form-data; boundary={0}", text3);
			Stream stream = null;
			Stream stream2 = null;
			byte[] array = null;
			fileName = Path.GetFullPath(fileName);
			WebRequest webRequest = null;
			try
			{
				stream2 = File.OpenRead(fileName);
				webRequest = this.SetupRequest(address, method, true);
				stream = webRequest.GetRequestStream();
				byte[] bytes = Encoding.ASCII.GetBytes("--" + text3 + "\r\n");
				stream.Write(bytes, 0, bytes.Length);
				string text4 = string.Format("Content-Disposition: form-data; name=\"file\"; filename=\"{0}\"\r\nContent-Type: {1}\r\n\r\n", Path.GetFileName(fileName), text);
				byte[] bytes2 = Encoding.UTF8.GetBytes(text4);
				stream.Write(bytes2, 0, bytes2.Length);
				byte[] array2 = new byte[4096];
				int num;
				while ((num = stream2.Read(array2, 0, 4096)) != 0)
				{
					stream.Write(array2, 0, num);
				}
				stream.WriteByte(13);
				stream.WriteByte(10);
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
				stream = null;
				WebResponse webResponse = this.GetWebResponse(webRequest);
				Stream responseStream = webResponse.GetResponseStream();
				array = this.ReadAll(responseStream, (int)webResponse.ContentLength, userToken);
			}
			catch (ThreadInterruptedException)
			{
				if (webRequest != null)
				{
					webRequest.Abort();
				}
				throw;
			}
			finally
			{
				if (stream2 != null)
				{
					stream2.Close();
				}
				if (stream != null)
				{
					stream.Close();
				}
			}
			return array;
		}

		/// <summary>Uploads the specified name/value collection to the resource identified by the specified URI.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the body of the response from the resource.</returns>
		/// <param name="address">The URI of the resource to receive the collection. </param>
		/// <param name="data">The <see cref="T:System.Collections.Specialized.NameValueCollection" /> to send to the resource. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- <paramref name="data" /> is null.-or- There was no response from the server hosting the resource.-or- An error occurred while opening the stream.-or- The Content-type header is not null or "application/x-www-form-urlencoded". </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002578 RID: 9592 RVA: 0x0001A651 File Offset: 0x00018851
		public byte[] UploadValues(string address, global::System.Collections.Specialized.NameValueCollection data)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return this.UploadValues(this.CreateUri(address), data);
		}

		/// <summary>Uploads the specified name/value collection to the resource identified by the specified URI, using the specified method.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the body of the response from the resource.</returns>
		/// <param name="address">The URI of the resource to receive the collection. </param>
		/// <param name="method">The HTTP method used to send the file to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="data">The <see cref="T:System.Collections.Specialized.NameValueCollection" /> to send to the resource. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- <paramref name="data" /> is null.-or- An error occurred while opening the stream.-or- There was no response from the server hosting the resource.-or- The Content-type header value is not null and is not application/x-www-form-urlencoded. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002579 RID: 9593 RVA: 0x0001A672 File Offset: 0x00018872
		public byte[] UploadValues(string address, string method, global::System.Collections.Specialized.NameValueCollection data)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return this.UploadValues(this.CreateUri(address), method, data);
		}

		/// <summary>Uploads the specified name/value collection to the resource identified by the specified URI.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the body of the response from the resource.</returns>
		/// <param name="address">The URI of the resource to receive the collection. </param>
		/// <param name="data">The <see cref="T:System.Collections.Specialized.NameValueCollection" /> to send to the resource. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- <paramref name="data" /> is null.-or- There was no response from the server hosting the resource.-or- An error occurred while opening the stream.-or- The Content-type header is not null or "application/x-www-form-urlencoded". </exception>
		// Token: 0x0600257A RID: 9594 RVA: 0x0001A694 File Offset: 0x00018894
		public byte[] UploadValues(global::System.Uri address, global::System.Collections.Specialized.NameValueCollection data)
		{
			return this.UploadValues(address, null, data);
		}

		/// <summary>Uploads the specified name/value collection to the resource identified by the specified URI, using the specified method.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the body of the response from the resource.</returns>
		/// <param name="address">The URI of the resource to receive the collection. </param>
		/// <param name="method">The HTTP method used to send the file to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="data">The <see cref="T:System.Collections.Specialized.NameValueCollection" /> to send to the resource. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" />, and <paramref name="address" /> is invalid.-or- <paramref name="data" /> is null.-or- An error occurred while opening the stream.-or- There was no response from the server hosting the resource.-or- The Content-type header value is not null and is not application/x-www-form-urlencoded. </exception>
		// Token: 0x0600257B RID: 9595 RVA: 0x0006CD30 File Offset: 0x0006AF30
		public byte[] UploadValues(global::System.Uri address, string method, global::System.Collections.Specialized.NameValueCollection data)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			byte[] array;
			try
			{
				this.SetBusy();
				this.async = false;
				array = this.UploadValuesCore(address, method, data, null);
			}
			catch (WebException ex)
			{
				throw;
			}
			catch (Exception ex2)
			{
				throw new WebException("An error occurred performing a WebClient request.", ex2);
			}
			finally
			{
				this.is_busy = false;
			}
			return array;
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x0006CDD4 File Offset: 0x0006AFD4
		private byte[] UploadValuesCore(global::System.Uri uri, string method, global::System.Collections.Specialized.NameValueCollection data, object userToken)
		{
			string text = this.Headers["Content-Type"];
			if (text != null && string.Compare(text, WebClient.urlEncodedCType, true) != 0)
			{
				throw new WebException("Content-Type header cannot be changed from its default value for this request.");
			}
			this.Headers["Content-Type"] = WebClient.urlEncodedCType;
			WebRequest webRequest = this.SetupRequest(uri, method, true);
			byte[] array2;
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				foreach (object obj in data)
				{
					string text2 = (string)obj;
					byte[] array = Encoding.UTF8.GetBytes(text2);
					WebClient.UrlEncodeAndWrite(memoryStream, array);
					memoryStream.WriteByte(61);
					array = Encoding.UTF8.GetBytes(data[text2]);
					WebClient.UrlEncodeAndWrite(memoryStream, array);
					memoryStream.WriteByte(38);
				}
				int num = (int)memoryStream.Length;
				if (num > 0)
				{
					memoryStream.SetLength((long)(--num));
				}
				byte[] buffer = memoryStream.GetBuffer();
				webRequest.ContentLength = (long)num;
				using (Stream requestStream = webRequest.GetRequestStream())
				{
					requestStream.Write(buffer, 0, num);
				}
				memoryStream.Close();
				WebResponse webResponse = this.GetWebResponse(webRequest);
				Stream responseStream = webResponse.GetResponseStream();
				array2 = this.ReadAll(responseStream, (int)webResponse.ContentLength, userToken);
			}
			catch (ThreadInterruptedException)
			{
				webRequest.Abort();
				throw;
			}
			return array2;
		}

		/// <summary>Downloads the requested resource as a <see cref="T:System.String" />. The resource to download is specified as a <see cref="T:System.String" /> containing the URI.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the requested resource.</returns>
		/// <param name="address">A <see cref="T:System.String" /> containing the URI to download.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while downloading the resource. </exception>
		/// <exception cref="T:System.NotSupportedException">The method has been called simultaneously on multiple threads.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x0600257D RID: 9597 RVA: 0x0001A69F File Offset: 0x0001889F
		public string DownloadString(string address)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return this.encoding.GetString(this.DownloadData(this.CreateUri(address)));
		}

		/// <summary>Downloads the requested resource as a <see cref="T:System.String" />. The resource to download is specified as a <see cref="T:System.Uri" />.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the requested resource.</returns>
		/// <param name="address">A <see cref="T:System.Uri" /> object containing the URI to download.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while downloading the resource. </exception>
		/// <exception cref="T:System.NotSupportedException">The method has been called simultaneously on multiple threads.</exception>
		// Token: 0x0600257E RID: 9598 RVA: 0x0001A6CA File Offset: 0x000188CA
		public string DownloadString(global::System.Uri address)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return this.encoding.GetString(this.DownloadData(this.CreateUri(address)));
		}

		/// <summary>Uploads the specified string to the specified resource, using the POST method.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the response sent by the server.</returns>
		/// <param name="address">The URI of the resource to receive the string. For Http resources, this URI must identify a resource that can accept a request sent with the POST method, such as a script or ASP page. </param>
		/// <param name="data">The string to be uploaded.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> is null.</exception>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- There was no response from the server hosting the resource.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x0600257F RID: 9599 RVA: 0x0006CFA4 File Offset: 0x0006B1A4
		public string UploadString(string address, string data)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			byte[] array = this.UploadData(address, this.encoding.GetBytes(data));
			return this.encoding.GetString(array);
		}

		/// <summary>Uploads the specified string to the specified resource, using the specified method.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the response sent by the server.</returns>
		/// <param name="address">The URI of the resource to receive the file. This URI must identify a resource that can accept a request sent with the <paramref name="method" /> method. </param>
		/// <param name="method">The HTTP method used to send the string to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="data">The string to be uploaded.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- There was no response from the server hosting the resource.-or-<paramref name="method" /> cannot be used to send content.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002580 RID: 9600 RVA: 0x0006CFF4 File Offset: 0x0006B1F4
		public string UploadString(string address, string method, string data)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			byte[] array = this.UploadData(address, method, this.encoding.GetBytes(data));
			return this.encoding.GetString(array);
		}

		/// <summary>Uploads the specified string to the specified resource, using the POST method.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the response sent by the server.</returns>
		/// <param name="address">The URI of the resource to receive the string. For Http resources, this URI must identify a resource that can accept a request sent with the POST method, such as a script or ASP page. </param>
		/// <param name="data">The string to be uploaded.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> is null.</exception>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- There was no response from the server hosting the resource.</exception>
		// Token: 0x06002581 RID: 9601 RVA: 0x0006D044 File Offset: 0x0006B244
		public string UploadString(global::System.Uri address, string data)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			byte[] array = this.UploadData(address, this.encoding.GetBytes(data));
			return this.encoding.GetString(array);
		}

		/// <summary>Uploads the specified string to the specified resource, using the specified method.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the response sent by the server.</returns>
		/// <param name="address">The URI of the resource to receive the file. This URI must identify a resource that can accept a request sent with the <paramref name="method" /> method. </param>
		/// <param name="method">The HTTP method used to send the string to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="data">The string to be uploaded.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- There was no response from the server hosting the resource.-or-<paramref name="method" /> cannot be used to send content.</exception>
		// Token: 0x06002582 RID: 9602 RVA: 0x0006D09C File Offset: 0x0006B29C
		public string UploadString(global::System.Uri address, string method, string data)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			byte[] array = this.UploadData(address, method, this.encoding.GetBytes(data));
			return this.encoding.GetString(array);
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x0001A6FB File Offset: 0x000188FB
		private global::System.Uri CreateUri(string address)
		{
			return this.MakeUri(address);
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x0006D0F4 File Offset: 0x0006B2F4
		private global::System.Uri CreateUri(global::System.Uri address)
		{
			string query = address.Query;
			if (string.IsNullOrEmpty(query))
			{
				query = this.GetQueryString(true);
			}
			if (this.baseAddress == null && query == null)
			{
				return address;
			}
			if (this.baseAddress == null)
			{
				return new global::System.Uri(address.ToString() + query, query != null);
			}
			if (query == null)
			{
				return new global::System.Uri(this.baseAddress, address.ToString());
			}
			return new global::System.Uri(this.baseAddress, address.ToString() + query, query != null);
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x0006D194 File Offset: 0x0006B394
		private string GetQueryString(bool add_qmark)
		{
			if (this.queryString == null || this.queryString.Count == 0)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder();
			if (add_qmark)
			{
				stringBuilder.Append('?');
			}
			foreach (object obj in this.queryString)
			{
				string text = (string)obj;
				stringBuilder.AppendFormat("{0}={1}&", text, this.UrlEncode(this.queryString[text]));
			}
			if (stringBuilder.Length != 0)
			{
				stringBuilder.Length--;
			}
			if (stringBuilder.Length == 0)
			{
				return null;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x0006D270 File Offset: 0x0006B470
		private global::System.Uri MakeUri(string path)
		{
			string text = this.GetQueryString(true);
			if (this.baseAddress == null && text == null)
			{
				try
				{
					return new global::System.Uri(path);
				}
				catch (ArgumentNullException)
				{
					if (Environment.UnityWebSecurityEnabled)
					{
						throw;
					}
					path = Path.GetFullPath(path);
					return new global::System.Uri("file://" + path);
				}
				catch (global::System.UriFormatException)
				{
					if (Environment.UnityWebSecurityEnabled)
					{
						throw;
					}
					path = Path.GetFullPath(path);
					return new global::System.Uri("file://" + path);
				}
			}
			if (this.baseAddress == null)
			{
				return new global::System.Uri(path + text, text != null);
			}
			if (text == null)
			{
				return new global::System.Uri(this.baseAddress, path);
			}
			return new global::System.Uri(this.baseAddress, path + text, text != null);
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x0006D37C File Offset: 0x0006B57C
		private WebRequest SetupRequest(global::System.Uri uri)
		{
			WebRequest webRequest = this.GetWebRequest(uri);
			if (this.Proxy != null)
			{
				webRequest.Proxy = this.Proxy;
			}
			webRequest.Credentials = this.credentials;
			if (this.headers != null && this.headers.Count != 0 && webRequest is HttpWebRequest)
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)webRequest;
				string text = this.headers["Expect"];
				string text2 = this.headers["Content-Type"];
				string text3 = this.headers["Accept"];
				string text4 = this.headers["Connection"];
				string text5 = this.headers["User-Agent"];
				string text6 = this.headers["Referer"];
				this.headers.RemoveInternal("Expect");
				this.headers.RemoveInternal("Content-Type");
				this.headers.RemoveInternal("Accept");
				this.headers.RemoveInternal("Connection");
				this.headers.RemoveInternal("Referer");
				this.headers.RemoveInternal("User-Agent");
				webRequest.Headers = this.headers;
				if (text != null && text.Length > 0)
				{
					httpWebRequest.Expect = text;
				}
				if (text3 != null && text3.Length > 0)
				{
					httpWebRequest.Accept = text3;
				}
				if (text2 != null && text2.Length > 0)
				{
					httpWebRequest.ContentType = text2;
				}
				if (text4 != null && text4.Length > 0)
				{
					httpWebRequest.Connection = text4;
				}
				if (text5 != null && text5.Length > 0)
				{
					httpWebRequest.UserAgent = text5;
				}
				if (text6 != null && text6.Length > 0)
				{
					httpWebRequest.Referer = text6;
				}
			}
			this.responseHeaders = null;
			return webRequest;
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x0006D564 File Offset: 0x0006B764
		private WebRequest SetupRequest(global::System.Uri uri, string method, bool is_upload)
		{
			WebRequest webRequest = this.SetupRequest(uri);
			webRequest.Method = this.DetermineMethod(uri, method, is_upload);
			return webRequest;
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x0006D58C File Offset: 0x0006B78C
		private byte[] ReadAll(Stream stream, int length, object userToken)
		{
			MemoryStream memoryStream = null;
			bool flag = length == -1;
			int num = ((!flag) ? length : 8192);
			if (flag)
			{
				memoryStream = new MemoryStream();
			}
			int num2 = 0;
			byte[] array = new byte[num];
			int num3;
			while ((num3 = stream.Read(array, num2, num)) != 0)
			{
				if (flag)
				{
					memoryStream.Write(array, 0, num3);
				}
				else
				{
					num2 += num3;
					num -= num3;
				}
				if (this.async)
				{
					this.OnDownloadProgressChanged(new DownloadProgressChangedEventArgs((long)num3, (long)length, userToken));
				}
			}
			if (flag)
			{
				return memoryStream.ToArray();
			}
			return array;
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x0006D62C File Offset: 0x0006B82C
		private string UrlEncode(string str)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int length = str.Length;
			for (int i = 0; i < length; i++)
			{
				char c = str[i];
				if (c == ' ')
				{
					stringBuilder.Append('+');
				}
				else if ((c < '0' && c != '-' && c != '.') || (c < 'A' && c > '9') || (c > 'Z' && c < 'a' && c != '_') || c > 'z')
				{
					stringBuilder.Append('%');
					int num = (int)(c >> 4);
					stringBuilder.Append((char)WebClient.hexBytes[num]);
					num = (int)(c & '\u000f');
					stringBuilder.Append((char)WebClient.hexBytes[num]);
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x0006D708 File Offset: 0x0006B908
		private static void UrlEncodeAndWrite(Stream stream, byte[] bytes)
		{
			if (bytes == null)
			{
				return;
			}
			int num = bytes.Length;
			if (num == 0)
			{
				return;
			}
			for (int i = 0; i < num; i++)
			{
				char c = (char)bytes[i];
				if (c == ' ')
				{
					stream.WriteByte(43);
				}
				else if ((c < '0' && c != '-' && c != '.') || (c < 'A' && c > '9') || (c > 'Z' && c < 'a' && c != '_') || c > 'z')
				{
					stream.WriteByte(37);
					int num2 = (int)(c >> 4);
					stream.WriteByte(WebClient.hexBytes[num2]);
					num2 = (int)(c & '\u000f');
					stream.WriteByte(WebClient.hexBytes[num2]);
				}
				else
				{
					stream.WriteByte((byte)c);
				}
			}
		}

		/// <summary>Cancels a pending asynchronous operation.</summary>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x0600258C RID: 9612 RVA: 0x0006D7D4 File Offset: 0x0006B9D4
		public void CancelAsync()
		{
			lock (this)
			{
				if (this.async_thread != null)
				{
					Thread thread = this.async_thread;
					this.CompleteAsync();
					thread.Interrupt();
				}
			}
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x0006D828 File Offset: 0x0006BA28
		private void CompleteAsync()
		{
			lock (this)
			{
				this.is_busy = false;
				this.async_thread = null;
			}
		}

		/// <summary>Downloads the specified resource as a <see cref="T:System.Byte" /> array. This method does not block the calling thread.</summary>
		/// <param name="address">A <see cref="T:System.Uri" /> containing the URI to download.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while downloading the resource. </exception>
		// Token: 0x0600258E RID: 9614 RVA: 0x0001A704 File Offset: 0x00018904
		public void DownloadDataAsync(global::System.Uri address)
		{
			this.DownloadDataAsync(address, null);
		}

		/// <summary>Downloads the specified resource as a <see cref="T:System.Byte" /> array. This method does not block the calling thread.</summary>
		/// <param name="address">A <see cref="T:System.Uri" /> containing the URI to download.</param>
		/// <param name="userToken">A user-defined object that is passed to the method invoked when the asynchronous operation completes.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while downloading the resource. </exception>
		// Token: 0x0600258F RID: 9615 RVA: 0x0006D868 File Offset: 0x0006BA68
		public void DownloadDataAsync(global::System.Uri address, object userToken)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			lock (this)
			{
				this.SetBusy();
				this.async = true;
				this.async_thread = new Thread(delegate(object state)
				{
					object[] array2 = (object[])state;
					try
					{
						byte[] array3 = this.DownloadDataCore((global::System.Uri)array2[0], array2[1]);
						this.OnDownloadDataCompleted(new DownloadDataCompletedEventArgs(array3, null, false, array2[1]));
					}
					catch (ThreadInterruptedException)
					{
						this.OnDownloadDataCompleted(new DownloadDataCompletedEventArgs(null, null, true, array2[1]));
						throw;
					}
					catch (Exception ex)
					{
						this.OnDownloadDataCompleted(new DownloadDataCompletedEventArgs(null, ex, false, array2[1]));
					}
				});
				object[] array = new object[] { address, userToken };
				this.async_thread.Start(array);
			}
		}

		/// <summary>Downloads, to a local file, the resource with the specified URI. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to download. </param>
		/// <param name="fileName">The name of the file to be placed on the local computer. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while downloading the resource. </exception>
		/// <exception cref="T:System.InvalidOperationException">The local file specified by <paramref name="fileName" /> is in use by another thread.</exception>
		// Token: 0x06002590 RID: 9616 RVA: 0x0001A70E File Offset: 0x0001890E
		public void DownloadFileAsync(global::System.Uri address, string fileName)
		{
			this.DownloadFileAsync(address, fileName, null);
		}

		/// <summary>Downloads, to a local file, the resource with the specified URI. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to download. </param>
		/// <param name="fileName">The name of the file to be placed on the local computer. </param>
		/// <param name="userToken">A user-defined object that is passed to the method invoked when the asynchronous operation completes.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while downloading the resource. </exception>
		/// <exception cref="T:System.InvalidOperationException">The local file specified by <paramref name="fileName" /> is in use by another thread.</exception>
		// Token: 0x06002591 RID: 9617 RVA: 0x0006D8F0 File Offset: 0x0006BAF0
		public void DownloadFileAsync(global::System.Uri address, string fileName, object userToken)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (fileName == null)
			{
				throw new ArgumentNullException("fileName");
			}
			lock (this)
			{
				this.SetBusy();
				this.async = true;
				this.async_thread = new Thread(delegate(object state)
				{
					object[] array2 = (object[])state;
					try
					{
						this.DownloadFileCore((global::System.Uri)array2[0], (string)array2[1], array2[2]);
						this.OnDownloadFileCompleted(new global::System.ComponentModel.AsyncCompletedEventArgs(null, false, array2[2]));
					}
					catch (ThreadInterruptedException)
					{
						this.OnDownloadFileCompleted(new global::System.ComponentModel.AsyncCompletedEventArgs(null, true, array2[2]));
					}
					catch (Exception ex)
					{
						this.OnDownloadFileCompleted(new global::System.ComponentModel.AsyncCompletedEventArgs(ex, false, array2[2]));
					}
				});
				object[] array = new object[] { address, fileName, userToken };
				this.async_thread.Start(array);
			}
		}

		/// <summary>Downloads the resource specified as a <see cref="T:System.Uri" />. This method does not block the calling thread.</summary>
		/// <param name="address">A <see cref="T:System.Uri" /> containing the URI to download.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while downloading the resource. </exception>
		// Token: 0x06002592 RID: 9618 RVA: 0x0001A719 File Offset: 0x00018919
		public void DownloadStringAsync(global::System.Uri address)
		{
			this.DownloadStringAsync(address, null);
		}

		/// <summary>Downloads the specified string to the specified resource. This method does not block the calling thread.</summary>
		/// <param name="address">A <see cref="T:System.Uri" /> containing the URI to download.</param>
		/// <param name="userToken">A user-defined object that is passed to the method invoked when the asynchronous operation completes.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while downloading the resource. </exception>
		// Token: 0x06002593 RID: 9619 RVA: 0x0006D98C File Offset: 0x0006BB8C
		public void DownloadStringAsync(global::System.Uri address, object userToken)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			lock (this)
			{
				this.SetBusy();
				this.async = true;
				this.async_thread = new Thread(delegate(object state)
				{
					object[] array2 = (object[])state;
					try
					{
						string @string = this.encoding.GetString(this.DownloadDataCore((global::System.Uri)array2[0], array2[1]));
						this.OnDownloadStringCompleted(new DownloadStringCompletedEventArgs(@string, null, false, array2[1]));
					}
					catch (ThreadInterruptedException)
					{
						this.OnDownloadStringCompleted(new DownloadStringCompletedEventArgs(null, null, true, array2[1]));
					}
					catch (Exception ex)
					{
						this.OnDownloadStringCompleted(new DownloadStringCompletedEventArgs(null, ex, false, array2[1]));
					}
				});
				object[] array = new object[] { address, userToken };
				this.async_thread.Start(array);
			}
		}

		/// <summary>Opens a readable stream containing the specified resource. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to retrieve.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and address is invalid.-or- An error occurred while downloading the resource. -or- An error occurred while opening the stream.</exception>
		// Token: 0x06002594 RID: 9620 RVA: 0x0001A723 File Offset: 0x00018923
		public void OpenReadAsync(global::System.Uri address)
		{
			this.OpenReadAsync(address, null);
		}

		/// <summary>Opens a readable stream containing the specified resource. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to retrieve.</param>
		/// <param name="userToken">A user-defined object that is passed to the method invoked when the asynchronous operation completes.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and address is invalid.-or- An error occurred while downloading the resource. -or- An error occurred while opening the stream.</exception>
		// Token: 0x06002595 RID: 9621 RVA: 0x0006DA14 File Offset: 0x0006BC14
		public void OpenReadAsync(global::System.Uri address, object userToken)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			lock (this)
			{
				this.SetBusy();
				this.async = true;
				this.async_thread = new Thread(delegate(object state)
				{
					object[] array2 = (object[])state;
					WebRequest webRequest = null;
					try
					{
						webRequest = this.SetupRequest((global::System.Uri)array2[0]);
						WebResponse webResponse = this.GetWebResponse(webRequest);
						Stream responseStream = webResponse.GetResponseStream();
						this.OnOpenReadCompleted(new OpenReadCompletedEventArgs(responseStream, null, false, array2[1]));
					}
					catch (ThreadInterruptedException)
					{
						if (webRequest != null)
						{
							webRequest.Abort();
						}
						this.OnOpenReadCompleted(new OpenReadCompletedEventArgs(null, null, true, array2[1]));
					}
					catch (Exception ex)
					{
						this.OnOpenReadCompleted(new OpenReadCompletedEventArgs(null, ex, false, array2[1]));
					}
				});
				object[] array = new object[] { address, userToken };
				this.async_thread.Start(array);
			}
		}

		/// <summary>Opens a stream for writing data to the specified resource. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to receive the data. </param>
		// Token: 0x06002596 RID: 9622 RVA: 0x0001A72D File Offset: 0x0001892D
		public void OpenWriteAsync(global::System.Uri address)
		{
			this.OpenWriteAsync(address, null);
		}

		/// <summary>Opens a stream for writing data to the specified resource. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to receive the data. </param>
		/// <param name="method">The method used to send the data to the resource. If null, the default is POST for http and STOR for ftp.</param>
		// Token: 0x06002597 RID: 9623 RVA: 0x0001A737 File Offset: 0x00018937
		public void OpenWriteAsync(global::System.Uri address, string method)
		{
			this.OpenWriteAsync(address, method, null);
		}

		/// <summary>Opens a stream for writing data to the specified resource, using the specified method. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to receive the data.</param>
		/// <param name="method">The method used to send the data to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="userToken">A user-defined object that is passed to the method invoked when the asynchronous operation completes</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while opening the stream. </exception>
		// Token: 0x06002598 RID: 9624 RVA: 0x0006DA9C File Offset: 0x0006BC9C
		public void OpenWriteAsync(global::System.Uri address, string method, object userToken)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			lock (this)
			{
				this.SetBusy();
				this.async = true;
				this.async_thread = new Thread(delegate(object state)
				{
					object[] array2 = (object[])state;
					WebRequest webRequest = null;
					try
					{
						webRequest = this.SetupRequest((global::System.Uri)array2[0], (string)array2[1], true);
						Stream requestStream = webRequest.GetRequestStream();
						this.OnOpenWriteCompleted(new OpenWriteCompletedEventArgs(requestStream, null, false, array2[2]));
					}
					catch (ThreadInterruptedException)
					{
						if (webRequest != null)
						{
							webRequest.Abort();
						}
						this.OnOpenWriteCompleted(new OpenWriteCompletedEventArgs(null, null, true, array2[2]));
					}
					catch (Exception ex)
					{
						this.OnOpenWriteCompleted(new OpenWriteCompletedEventArgs(null, ex, false, array2[2]));
					}
				});
				object[] array = new object[] { address, method, userToken };
				this.async_thread.Start(array);
			}
		}

		/// <summary>Uploads a data buffer to a resource identified by a URI, using the POST method. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to receive the data. </param>
		/// <param name="data">The data buffer to send to the resource. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while opening the stream.-or- There was no response from the server hosting the resource. </exception>
		// Token: 0x06002599 RID: 9625 RVA: 0x0001A742 File Offset: 0x00018942
		public void UploadDataAsync(global::System.Uri address, byte[] data)
		{
			this.UploadDataAsync(address, null, data);
		}

		/// <summary>Uploads a data buffer to a resource identified by a URI, using the specified method. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to receive the data.</param>
		/// <param name="method">The HTTP method used to send the file to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="data">The data buffer to send to the resource.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while opening the stream.-or- There was no response from the server hosting the resource. </exception>
		// Token: 0x0600259A RID: 9626 RVA: 0x0001A74D File Offset: 0x0001894D
		public void UploadDataAsync(global::System.Uri address, string method, byte[] data)
		{
			this.UploadDataAsync(address, method, data, null);
		}

		/// <summary>Uploads a data buffer to a resource identified by a URI, using the specified method and identifying token.</summary>
		/// <param name="address">The URI of the resource to receive the data.</param>
		/// <param name="method">The HTTP method used to send the file to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="data">The data buffer to send to the resource.</param>
		/// <param name="userToken">A user-defined object that is passed to the method invoked when the asynchronous operation completes.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- An error occurred while opening the stream.-or- There was no response from the server hosting the resource. </exception>
		// Token: 0x0600259B RID: 9627 RVA: 0x0006DB28 File Offset: 0x0006BD28
		public void UploadDataAsync(global::System.Uri address, string method, byte[] data, object userToken)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			lock (this)
			{
				this.SetBusy();
				this.async = true;
				this.async_thread = new Thread(delegate(object state)
				{
					object[] array2 = (object[])state;
					try
					{
						byte[] array3 = this.UploadDataCore((global::System.Uri)array2[0], (string)array2[1], (byte[])array2[2], array2[3]);
						this.OnUploadDataCompleted(new UploadDataCompletedEventArgs(array3, null, false, array2[3]));
					}
					catch (ThreadInterruptedException)
					{
						this.OnUploadDataCompleted(new UploadDataCompletedEventArgs(null, null, true, array2[3]));
					}
					catch (Exception ex)
					{
						this.OnUploadDataCompleted(new UploadDataCompletedEventArgs(null, ex, false, array2[3]));
					}
				});
				object[] array = new object[] { address, method, data, userToken };
				this.async_thread.Start(array);
			}
		}

		/// <summary>Uploads the specified local file to the specified resource, using the POST method. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to receive the file. For HTTP resources, this URI must identify a resource that can accept a request sent with the POST method, such as a script or ASP page. </param>
		/// <param name="fileName">The file to send to the resource. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- <paramref name="fileName" /> is null, is <see cref="F:System.String.Empty" />, contains invalid character, or the specified path to the file does not exist.-or- An error occurred while opening the stream.-or- There was no response from the server hosting the resource.-or- The Content-type header begins with multipart. </exception>
		// Token: 0x0600259C RID: 9628 RVA: 0x0001A759 File Offset: 0x00018959
		public void UploadFileAsync(global::System.Uri address, string fileName)
		{
			this.UploadFileAsync(address, null, fileName);
		}

		/// <summary>Uploads the specified local file to the specified resource, using the POST method. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to receive the file. For HTTP resources, this URI must identify a resource that can accept a request sent with the POST method, such as a script or ASP page. </param>
		/// <param name="method">The HTTP method used to send the data to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="fileName">The file to send to the resource. </param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- <paramref name="fileName" /> is null, is <see cref="F:System.String.Empty" />, contains invalid character, or the specified path to the file does not exist.-or- An error occurred while opening the stream.-or- There was no response from the server hosting the resource.-or- The Content-type header begins with multipart. </exception>
		// Token: 0x0600259D RID: 9629 RVA: 0x0001A764 File Offset: 0x00018964
		public void UploadFileAsync(global::System.Uri address, string method, string fileName)
		{
			this.UploadFileAsync(address, method, fileName, null);
		}

		/// <summary>Uploads the specified local file to the specified resource, using the POST method. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to receive the file. For HTTP resources, this URI must identify a resource that can accept a request sent with the POST method, such as a script or ASP page.</param>
		/// <param name="method">The HTTP method used to send the data to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="fileName">The file to send to the resource.</param>
		/// <param name="userToken">A user-defined object that is passed to the method invoked when the asynchronous operation completes.</param>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- <paramref name="fileName" /> is null, is <see cref="F:System.String.Empty" />, contains invalid character, or the specified path to the file does not exist.-or- An error occurred while opening the stream.-or- There was no response from the server hosting the resource.-or- The Content-type header begins with multipart. </exception>
		// Token: 0x0600259E RID: 9630 RVA: 0x0006DBCC File Offset: 0x0006BDCC
		public void UploadFileAsync(global::System.Uri address, string method, string fileName, object userToken)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (fileName == null)
			{
				throw new ArgumentNullException("fileName");
			}
			lock (this)
			{
				this.SetBusy();
				this.async = true;
				this.async_thread = new Thread(delegate(object state)
				{
					object[] array2 = (object[])state;
					try
					{
						byte[] array3 = this.UploadFileCore((global::System.Uri)array2[0], (string)array2[1], (string)array2[2], array2[3]);
						this.OnUploadFileCompleted(new UploadFileCompletedEventArgs(array3, null, false, array2[3]));
					}
					catch (ThreadInterruptedException)
					{
						this.OnUploadFileCompleted(new UploadFileCompletedEventArgs(null, null, true, array2[3]));
					}
					catch (Exception ex)
					{
						this.OnUploadFileCompleted(new UploadFileCompletedEventArgs(null, ex, false, array2[3]));
					}
				});
				object[] array = new object[] { address, method, fileName, userToken };
				this.async_thread.Start(array);
			}
		}

		/// <summary>Uploads the specified string to the specified resource. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to receive the file. For HTTP resources, this URI must identify a resource that can accept a request sent with the POST method, such as a script or ASP page. </param>
		/// <param name="data">The string to be uploaded.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> is null.</exception>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- There was no response from the server hosting the resource.</exception>
		// Token: 0x0600259F RID: 9631 RVA: 0x0001A770 File Offset: 0x00018970
		public void UploadStringAsync(global::System.Uri address, string data)
		{
			this.UploadStringAsync(address, null, data);
		}

		/// <summary>Uploads the specified string to the specified resource. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to receive the file. For HTTP resources, this URI must identify a resource that can accept a request sent with the POST method, such as a script or ASP page.</param>
		/// <param name="method">The HTTP method used to send the file to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="data">The string to be uploaded.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> is null.</exception>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- There was no response from the server hosting the resource.</exception>
		// Token: 0x060025A0 RID: 9632 RVA: 0x0001A77B File Offset: 0x0001897B
		public void UploadStringAsync(global::System.Uri address, string method, string data)
		{
			this.UploadStringAsync(address, method, data, null);
		}

		/// <summary>Uploads the specified string to the specified resource. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to receive the file. For HTTP resources, this URI must identify a resource that can accept a request sent with the POST method, such as a script or ASP page.</param>
		/// <param name="method">The HTTP method used to send the file to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="data">The string to be uploaded.</param>
		/// <param name="userToken">A user-defined object that is passed to the method invoked when the asynchronous operation completes.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> is null.</exception>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- There was no response from the server hosting the resource.</exception>
		// Token: 0x060025A1 RID: 9633 RVA: 0x0006DC70 File Offset: 0x0006BE70
		public void UploadStringAsync(global::System.Uri address, string method, string data, object userToken)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			lock (this)
			{
				this.CheckBusy();
				this.async = true;
				this.async_thread = new Thread(delegate(object state)
				{
					object[] array2 = (object[])state;
					try
					{
						string text = this.UploadString((global::System.Uri)array2[0], (string)array2[1], (string)array2[2]);
						this.OnUploadStringCompleted(new UploadStringCompletedEventArgs(text, null, false, array2[3]));
					}
					catch (ThreadInterruptedException)
					{
						this.OnUploadStringCompleted(new UploadStringCompletedEventArgs(null, null, true, array2[3]));
					}
					catch (Exception ex)
					{
						this.OnUploadStringCompleted(new UploadStringCompletedEventArgs(null, ex, false, array2[3]));
					}
				});
				object[] array = new object[] { address, method, data, userToken };
				this.async_thread.Start(array);
			}
		}

		/// <summary>Uploads the data in the specified name/value collection to the resource identified by the specified URI. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to receive the collection. This URI must identify a resource that can accept a request sent with the default method. See remarks.</param>
		/// <param name="data">The <see cref="T:System.Collections.Specialized.NameValueCollection" /> to send to the resource.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> is null.</exception>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- There was no response from the server hosting the resource.</exception>
		// Token: 0x060025A2 RID: 9634 RVA: 0x0001A787 File Offset: 0x00018987
		public void UploadValuesAsync(global::System.Uri address, global::System.Collections.Specialized.NameValueCollection values)
		{
			this.UploadValuesAsync(address, null, values);
		}

		/// <summary>Uploads the data in the specified name/value collection to the resource identified by the specified URI, using the specified method. This method does not block the calling thread.</summary>
		/// <param name="address">The URI of the resource to receive the collection. This URI must identify a resource that can accept a request sent with the <paramref name="method" /> method.</param>
		/// <param name="method">The method used to send the string to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="data">The <see cref="T:System.Collections.Specialized.NameValueCollection" /> to send to the resource.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> is null. -or- <paramref name="address" /> is null.</exception>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- There was no response from the server hosting the resource.-or-<paramref name="method" /> cannot be used to send content.</exception>
		// Token: 0x060025A3 RID: 9635 RVA: 0x0001A792 File Offset: 0x00018992
		public void UploadValuesAsync(global::System.Uri address, string method, global::System.Collections.Specialized.NameValueCollection values)
		{
			this.UploadValuesAsync(address, method, values, null);
		}

		/// <summary>Uploads the data in the specified name/value collection to the resource identified by the specified URI, using the specified method. This method does not block the calling thread, and allows the caller to pass an object to the method that is invoked when the operation completes.</summary>
		/// <param name="address">The URI of the resource to receive the collection. This URI must identify a resource that can accept a request sent with the <paramref name="method" /> method.</param>
		/// <param name="method">The HTTP method used to send the string to the resource. If null, the default is POST for http and STOR for ftp.</param>
		/// <param name="data">The <see cref="T:System.Collections.Specialized.NameValueCollection" /> to send to the resource.</param>
		/// <param name="userToken">A user-defined object that is passed to the method invoked when the asynchronous operation completes.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> is null. -or- <paramref name="address" /> is null.</exception>
		/// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress" /> and <paramref name="address" /> is invalid.-or- There was no response from the server hosting the resource.-or-<paramref name="method" /> cannot be used to send content.</exception>
		// Token: 0x060025A4 RID: 9636 RVA: 0x0006DD14 File Offset: 0x0006BF14
		public void UploadValuesAsync(global::System.Uri address, string method, global::System.Collections.Specialized.NameValueCollection values, object userToken)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			lock (this)
			{
				this.CheckBusy();
				this.async = true;
				this.async_thread = new Thread(delegate(object state)
				{
					object[] array2 = (object[])state;
					try
					{
						byte[] array3 = this.UploadValuesCore((global::System.Uri)array2[0], (string)array2[1], (global::System.Collections.Specialized.NameValueCollection)array2[2], array2[3]);
						this.OnUploadValuesCompleted(new UploadValuesCompletedEventArgs(array3, null, false, array2[3]));
					}
					catch (ThreadInterruptedException)
					{
						this.OnUploadValuesCompleted(new UploadValuesCompletedEventArgs(null, null, true, array2[3]));
					}
					catch (Exception ex)
					{
						this.OnUploadValuesCompleted(new UploadValuesCompletedEventArgs(null, ex, false, array2[3]));
					}
				});
				object[] array = new object[] { address, method, values, userToken };
				this.async_thread.Start(array);
			}
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.DownloadDataCompleted" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Net.DownloadDataCompletedEventArgs" /> object that contains event data.</param>
		// Token: 0x060025A5 RID: 9637 RVA: 0x0001A79E File Offset: 0x0001899E
		protected virtual void OnDownloadDataCompleted(DownloadDataCompletedEventArgs args)
		{
			this.CompleteAsync();
			if (this.DownloadDataCompleted != null)
			{
				this.DownloadDataCompleted(this, args);
			}
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.DownloadFileCompleted" /> event.</summary>
		/// <param name="e">An <see cref="T:System.ComponentModel.AsyncCompletedEventArgs" /> object containing event data.</param>
		// Token: 0x060025A6 RID: 9638 RVA: 0x0001A7BE File Offset: 0x000189BE
		protected virtual void OnDownloadFileCompleted(global::System.ComponentModel.AsyncCompletedEventArgs args)
		{
			this.CompleteAsync();
			if (this.DownloadFileCompleted != null)
			{
				this.DownloadFileCompleted(this, args);
			}
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.DownloadProgressChanged" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Net.DownloadProgressChangedEventArgs" /> object containing event data.</param>
		// Token: 0x060025A7 RID: 9639 RVA: 0x0001A7DE File Offset: 0x000189DE
		protected virtual void OnDownloadProgressChanged(DownloadProgressChangedEventArgs e)
		{
			if (this.DownloadProgressChanged != null)
			{
				this.DownloadProgressChanged(this, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.DownloadStringCompleted" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Net.DownloadStringCompletedEventArgs" /> object containing event data.</param>
		// Token: 0x060025A8 RID: 9640 RVA: 0x0001A7F8 File Offset: 0x000189F8
		protected virtual void OnDownloadStringCompleted(DownloadStringCompletedEventArgs args)
		{
			this.CompleteAsync();
			if (this.DownloadStringCompleted != null)
			{
				this.DownloadStringCompleted(this, args);
			}
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.OpenReadCompleted" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Net.OpenReadCompletedEventArgs" />  object containing event data.</param>
		// Token: 0x060025A9 RID: 9641 RVA: 0x0001A818 File Offset: 0x00018A18
		protected virtual void OnOpenReadCompleted(OpenReadCompletedEventArgs args)
		{
			this.CompleteAsync();
			if (this.OpenReadCompleted != null)
			{
				this.OpenReadCompleted(this, args);
			}
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.OpenWriteCompleted" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Net.OpenWriteCompletedEventArgs" /> object containing event data.</param>
		// Token: 0x060025AA RID: 9642 RVA: 0x0001A838 File Offset: 0x00018A38
		protected virtual void OnOpenWriteCompleted(OpenWriteCompletedEventArgs args)
		{
			this.CompleteAsync();
			if (this.OpenWriteCompleted != null)
			{
				this.OpenWriteCompleted(this, args);
			}
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.UploadDataCompleted" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Net.UploadDataCompletedEventArgs" />  object containing event data.</param>
		// Token: 0x060025AB RID: 9643 RVA: 0x0001A858 File Offset: 0x00018A58
		protected virtual void OnUploadDataCompleted(UploadDataCompletedEventArgs args)
		{
			this.CompleteAsync();
			if (this.UploadDataCompleted != null)
			{
				this.UploadDataCompleted(this, args);
			}
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.UploadFileCompleted" /> event.</summary>
		/// <param name="e">An <see cref="T:System.Net.UploadFileCompletedEventArgs" /> object containing event data.</param>
		// Token: 0x060025AC RID: 9644 RVA: 0x0001A878 File Offset: 0x00018A78
		protected virtual void OnUploadFileCompleted(UploadFileCompletedEventArgs args)
		{
			this.CompleteAsync();
			if (this.UploadFileCompleted != null)
			{
				this.UploadFileCompleted(this, args);
			}
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.UploadProgressChanged" /> event.</summary>
		/// <param name="e">An <see cref="T:System.Net.UploadProgressChangedEventArgs" /> object containing event data.</param>
		// Token: 0x060025AD RID: 9645 RVA: 0x0001A898 File Offset: 0x00018A98
		protected virtual void OnUploadProgressChanged(UploadProgressChangedEventArgs e)
		{
			if (this.UploadProgressChanged != null)
			{
				this.UploadProgressChanged(this, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.UploadStringCompleted" /> event.</summary>
		/// <param name="e">An <see cref="T:System.Net.UploadStringCompletedEventArgs" />  object containing event data.</param>
		// Token: 0x060025AE RID: 9646 RVA: 0x0001A8B2 File Offset: 0x00018AB2
		protected virtual void OnUploadStringCompleted(UploadStringCompletedEventArgs args)
		{
			this.CompleteAsync();
			if (this.UploadStringCompleted != null)
			{
				this.UploadStringCompleted(this, args);
			}
		}

		/// <summary>Raises the <see cref="E:System.Net.WebClient.UploadValuesCompleted" /> event.</summary>
		/// <param name="e">A <see cref="T:System.Net.UploadValuesCompletedEventArgs" />  object containing event data.</param>
		// Token: 0x060025AF RID: 9647 RVA: 0x0001A8D2 File Offset: 0x00018AD2
		protected virtual void OnUploadValuesCompleted(UploadValuesCompletedEventArgs args)
		{
			this.CompleteAsync();
			if (this.UploadValuesCompleted != null)
			{
				this.UploadValuesCompleted(this, args);
			}
		}

		/// <summary>Returns the <see cref="T:System.Net.WebResponse" /> for the specified <see cref="T:System.Net.WebRequest" /> using the specified <see cref="T:System.IAsyncResult" />.</summary>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> containing the response for the specified <see cref="T:System.Net.WebRequest" />.</returns>
		/// <param name="request">A <see cref="T:System.Net.WebRequest" /> that is used to obtain the response.</param>
		/// <param name="result">An <see cref="T:System.IAsyncResult" /> object obtained from a previous call to <see cref="M:System.Net.WebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> .</param>
		// Token: 0x060025B0 RID: 9648 RVA: 0x0006DDB8 File Offset: 0x0006BFB8
		protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
		{
			WebResponse webResponse = request.EndGetResponse(result);
			this.responseHeaders = webResponse.Headers;
			return webResponse;
		}

		/// <summary>Returns a <see cref="T:System.Net.WebRequest" /> object for the specified resource.</summary>
		/// <returns>A new <see cref="T:System.Net.WebRequest" /> object for the specified resource.</returns>
		/// <param name="address">A <see cref="T:System.Uri" /> that identifies the resource to request.</param>
		// Token: 0x060025B1 RID: 9649 RVA: 0x0001A8F2 File Offset: 0x00018AF2
		protected virtual WebRequest GetWebRequest(global::System.Uri address)
		{
			return WebRequest.Create(address);
		}

		/// <summary>Returns the <see cref="T:System.Net.WebResponse" /> for the specified <see cref="T:System.Net.WebRequest" />.</summary>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> containing the response for the specified <see cref="T:System.Net.WebRequest" />.</returns>
		/// <param name="request">A <see cref="T:System.Net.WebRequest" /> that is used to obtain the response. </param>
		// Token: 0x060025B2 RID: 9650 RVA: 0x0006DDDC File Offset: 0x0006BFDC
		protected virtual WebResponse GetWebResponse(WebRequest request)
		{
			WebResponse response = request.GetResponse();
			this.responseHeaders = response.Headers;
			return response;
		}

		// Token: 0x0400170C RID: 5900
		private static readonly string urlEncodedCType = "application/x-www-form-urlencoded";

		// Token: 0x0400170D RID: 5901
		private static byte[] hexBytes = new byte[16];

		// Token: 0x0400170E RID: 5902
		private ICredentials credentials;

		// Token: 0x0400170F RID: 5903
		private WebHeaderCollection headers;

		// Token: 0x04001710 RID: 5904
		private WebHeaderCollection responseHeaders;

		// Token: 0x04001711 RID: 5905
		private global::System.Uri baseAddress;

		// Token: 0x04001712 RID: 5906
		private string baseString;

		// Token: 0x04001713 RID: 5907
		private global::System.Collections.Specialized.NameValueCollection queryString;

		// Token: 0x04001714 RID: 5908
		private bool is_busy;

		// Token: 0x04001715 RID: 5909
		private bool async;

		// Token: 0x04001716 RID: 5910
		private Thread async_thread;

		// Token: 0x04001717 RID: 5911
		private Encoding encoding = Encoding.Default;

		// Token: 0x04001718 RID: 5912
		private IWebProxy proxy;
	}
}
