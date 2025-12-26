using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Cache;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace System.Net
{
	/// <summary>Implements a File Transfer Protocol (FTP) client.</summary>
	// Token: 0x02000321 RID: 801
	public sealed class FtpWebRequest : WebRequest
	{
		// Token: 0x06001B3C RID: 6972 RVA: 0x00051794 File Offset: 0x0004F994
		internal FtpWebRequest(global::System.Uri uri)
		{
			this.requestUri = uri;
			this.proxy = GlobalProxySelection.Select;
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00005023 File Offset: 0x00003223
		private static Exception GetMustImplement()
		{
			return new NotImplementedException();
		}

		/// <summary>Gets the certificates used for establishing an encrypted connection to the FTP server.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> object that contains the client certificates.</returns>
		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x00013CC1 File Offset: 0x00011EC1
		// (set) Token: 0x06001B40 RID: 6976 RVA: 0x00013CC1 File Offset: 0x00011EC1
		[global::System.MonoTODO]
		public global::System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates
		{
			get
			{
				throw FtpWebRequest.GetMustImplement();
			}
			set
			{
				throw FtpWebRequest.GetMustImplement();
			}
		}

		/// <summary>Gets or sets the name of the connection group that contains the service point used to send the current request.</summary>
		/// <returns>A <see cref="T:System.String" /> value that contains a connection group name.</returns>
		/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress. </exception>
		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x00013CC1 File Offset: 0x00011EC1
		// (set) Token: 0x06001B42 RID: 6978 RVA: 0x00013CC1 File Offset: 0x00011EC1
		[global::System.MonoTODO]
		public override string ConnectionGroupName
		{
			get
			{
				throw FtpWebRequest.GetMustImplement();
			}
			set
			{
				throw FtpWebRequest.GetMustImplement();
			}
		}

		/// <summary>Always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Always throws a <see cref="T:System.NotSupportedException" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Content type information is not supported for FTP.</exception>
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001B43 RID: 6979 RVA: 0x00006A38 File Offset: 0x00004C38
		// (set) Token: 0x06001B44 RID: 6980 RVA: 0x00006A38 File Offset: 0x00004C38
		public override string ContentType
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>Gets or sets a value that is ignored by the <see cref="T:System.Net.FtpWebRequest" /> class.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that should be ignored.</returns>
		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override long ContentLength
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a byte offset into the file being downloaded by this request.</summary>
		/// <returns>An <see cref="T:System.Int64" /> instance that specifies the file offset, in bytes. The default value is zero.</returns>
		/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for this property is less than zero. </exception>
		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x00013CC8 File Offset: 0x00011EC8
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x00013CD0 File Offset: 0x00011ED0
		public long ContentOffset
		{
			get
			{
				return this.offset;
			}
			set
			{
				this.CheckRequestStarted();
				if (value < 0L)
				{
					throw new ArgumentOutOfRangeException();
				}
				this.offset = value;
			}
		}

		/// <summary>Gets or sets the credentials used to communicate with the FTP server.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> instance; otherwise, null if the property has not been set.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value specified for a set operation is null.</exception>
		/// <exception cref="T:System.ArgumentException">An <see cref="T:System.Net.ICredentials" /> of a type other than <see cref="T:System.Net.NetworkCredential" /> was specified for a set operation.</exception>
		/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x00013CED File Offset: 0x00011EED
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x00013CF5 File Offset: 0x00011EF5
		public override ICredentials Credentials
		{
			get
			{
				return this.credentials;
			}
			set
			{
				this.CheckRequestStarted();
				if (value == null)
				{
					throw new ArgumentNullException();
				}
				if (!(value is NetworkCredential))
				{
					throw new ArgumentException();
				}
				this.credentials = value as NetworkCredential;
			}
		}

		/// <summary>Defines the default cache policy for all FTP requests.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.RequestCachePolicy" /> that defines the cache policy for FTP requests.</returns>
		/// <exception cref="T:System.ArgumentNullException">The caller tried to set this property to null.</exception>
		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00013CC1 File Offset: 0x00011EC1
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x00013CC1 File Offset: 0x00011EC1
		[global::System.MonoTODO]
		public new static global::System.Net.Cache.RequestCachePolicy DefaultCachePolicy
		{
			get
			{
				throw FtpWebRequest.GetMustImplement();
			}
			set
			{
				throw FtpWebRequest.GetMustImplement();
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> that specifies that an SSL connection should be used.</summary>
		/// <returns>true if control and data transmissions are encrypted; otherwise, false. The default value is false.</returns>
		/// <exception cref="T:System.InvalidOperationException">The connection to the FTP server has already been established.</exception>
		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x00013D26 File Offset: 0x00011F26
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x00013D2E File Offset: 0x00011F2E
		public bool EnableSsl
		{
			get
			{
				return this.enableSsl;
			}
			set
			{
				this.CheckRequestStarted();
				this.enableSsl = value;
			}
		}

		/// <summary>Gets an empty <see cref="T:System.Net.WebHeaderCollection" /> object.</summary>
		/// <returns>An empty <see cref="T:System.Net.WebHeaderCollection" /> object.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x00013CC1 File Offset: 0x00011EC1
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x00013CC1 File Offset: 0x00011EC1
		[global::System.MonoTODO]
		public override WebHeaderCollection Headers
		{
			get
			{
				throw FtpWebRequest.GetMustImplement();
			}
			set
			{
				throw FtpWebRequest.GetMustImplement();
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that specifies whether the control connection to the FTP server is closed after the request completes.</summary>
		/// <returns>true if the connection to the server should not be destroyed; otherwise, false. The default value is true.</returns>
		/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress. </exception>
		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x00013D3D File Offset: 0x00011F3D
		// (set) Token: 0x06001B52 RID: 6994 RVA: 0x00013D45 File Offset: 0x00011F45
		[global::System.MonoTODO("We don't support KeepAlive = true")]
		public bool KeepAlive
		{
			get
			{
				return this.keepAlive;
			}
			set
			{
				this.CheckRequestStarted();
			}
		}

		/// <summary>Gets or sets the command to send to the FTP server.</summary>
		/// <returns>A <see cref="T:System.String" /> value that contains the FTP command to send to the server. The default value is <see cref="F:System.Net.WebRequestMethods.Ftp.DownloadFile" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress. </exception>
		/// <exception cref="T:System.ArgumentException">The method is invalid.- or -The method is not supported.- or -Multiple methods were specified.</exception>
		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00013D4D File Offset: 0x00011F4D
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x000518A0 File Offset: 0x0004FAA0
		public override string Method
		{
			get
			{
				return this.method;
			}
			set
			{
				this.CheckRequestStarted();
				if (value == null)
				{
					throw new ArgumentNullException("Method string cannot be null");
				}
				if (value.Length == 0 || Array.BinarySearch<string>(FtpWebRequest.supportedCommands, value) < 0)
				{
					throw new ArgumentException("Method not supported", "value");
				}
				this.method = value;
			}
		}

		/// <summary>Always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Always throws a <see cref="T:System.NotSupportedException" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Preauthentication is not supported for FTP.</exception>
		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x00006A38 File Offset: 0x00004C38
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x00006A38 File Offset: 0x00004C38
		public override bool PreAuthenticate
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>Gets or sets the proxy used to communicate with the FTP server.</summary>
		/// <returns>An <see cref="T:System.Net.IWebProxy" /> instance responsible for communicating with the FTP server.</returns>
		/// <exception cref="T:System.ArgumentNullException">This property cannot be set to null.</exception>
		/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x00013D55 File Offset: 0x00011F55
		// (set) Token: 0x06001B58 RID: 7000 RVA: 0x00013D5D File Offset: 0x00011F5D
		public override IWebProxy Proxy
		{
			get
			{
				return this.proxy;
			}
			set
			{
				this.CheckRequestStarted();
				if (value == null)
				{
					throw new ArgumentNullException();
				}
				this.proxy = value;
			}
		}

		/// <summary>Gets or sets a time-out when reading from or writing to a stream.</summary>
		/// <returns>The number of milliseconds before the reading or writing times out. The default value is 300,000 milliseconds (5 minutes).</returns>
		/// <exception cref="T:System.InvalidOperationException">The request has already been sent. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than or equal to zero and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />. </exception>
		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x00013D78 File Offset: 0x00011F78
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x00013D80 File Offset: 0x00011F80
		public int ReadWriteTimeout
		{
			get
			{
				return this.rwTimeout;
			}
			set
			{
				this.CheckRequestStarted();
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException();
				}
				this.rwTimeout = value;
			}
		}

		/// <summary>Gets or sets the new name of a file being renamed.</summary>
		/// <returns>The new name of the file being renamed.</returns>
		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00013D9C File Offset: 0x00011F9C
		// (set) Token: 0x06001B5C RID: 7004 RVA: 0x00013DA4 File Offset: 0x00011FA4
		public string RenameTo
		{
			get
			{
				return this.renameTo;
			}
			set
			{
				this.CheckRequestStarted();
				if (value == null || value.Length == 0)
				{
					throw new ArgumentException("RenameTo value can't be null or empty", "RenameTo");
				}
				this.renameTo = value;
			}
		}

		/// <summary>Gets the URI requested by this instance.</summary>
		/// <returns>A <see cref="T:System.Uri" /> instance that identifies a resource that is accessed using the File Transfer Protocol.</returns>
		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x00013DD4 File Offset: 0x00011FD4
		public override global::System.Uri RequestUri
		{
			get
			{
				return this.requestUri;
			}
		}

		/// <summary>Gets the <see cref="T:System.Net.ServicePoint" /> object used to connect to the FTP server.</summary>
		/// <returns>A <see cref="T:System.Net.ServicePoint" /> object that can be used to customize connection behavior.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x00013DDC File Offset: 0x00011FDC
		public ServicePoint ServicePoint
		{
			get
			{
				return this.GetServicePoint();
			}
		}

		/// <summary>Gets or sets the behavior of a client application's data transfer process.</summary>
		/// <returns>false if the client application's data transfer process listens for a connection on the data port; otherwise, true if the client should initiate a connection on the data port. The default value is true.</returns>
		/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress. </exception>
		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x00013DE4 File Offset: 0x00011FE4
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x00013DEC File Offset: 0x00011FEC
		public bool UsePassive
		{
			get
			{
				return this.usePassive;
			}
			set
			{
				this.CheckRequestStarted();
				this.usePassive = value;
			}
		}

		/// <summary>Always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Always throws a <see cref="T:System.NotSupportedException" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Default credentials are not supported for FTP.</exception>
		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x00013CC1 File Offset: 0x00011EC1
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x00013CC1 File Offset: 0x00011EC1
		[global::System.MonoTODO]
		public override bool UseDefaultCredentials
		{
			get
			{
				throw FtpWebRequest.GetMustImplement();
			}
			set
			{
				throw FtpWebRequest.GetMustImplement();
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that specifies the data type for file transfers.</summary>
		/// <returns>true to indicate to the server that the data to be transferred is binary; false to indicate that the data is text. The default value is true.</returns>
		/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress.</exception>
		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x00013DFB File Offset: 0x00011FFB
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x00013E03 File Offset: 0x00012003
		public bool UseBinary
		{
			get
			{
				return this.binary;
			}
			set
			{
				this.CheckRequestStarted();
				this.binary = value;
			}
		}

		/// <summary>Gets or sets the number of milliseconds to wait for a request.</summary>
		/// <returns>An <see cref="T:System.Int32" /> value that contains the number of milliseconds to wait before a request times out. The default value is <see cref="F:System.Threading.Timeout.Infinite" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified is less than zero and is not <see cref="F:System.Threading.Timeout.Infinite" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress. </exception>
		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x00013E12 File Offset: 0x00012012
		// (set) Token: 0x06001B66 RID: 7014 RVA: 0x00013E1A File Offset: 0x0001201A
		public override int Timeout
		{
			get
			{
				return this.timeout;
			}
			set
			{
				this.CheckRequestStarted();
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException();
				}
				this.timeout = value;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x00013E36 File Offset: 0x00012036
		private string DataType
		{
			get
			{
				return (!this.binary) ? "A" : "I";
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x000518F8 File Offset: 0x0004FAF8
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x0005193C File Offset: 0x0004FB3C
		private FtpWebRequest.RequestState State
		{
			get
			{
				object obj = this.locker;
				FtpWebRequest.RequestState requestState;
				lock (obj)
				{
					requestState = this.requestState;
				}
				return requestState;
			}
			set
			{
				object obj = this.locker;
				lock (obj)
				{
					this.CheckIfAborted();
					this.CheckFinalState();
					this.requestState = value;
				}
			}
		}

		/// <summary>Terminates an asynchronous FTP operation.</summary>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001B6A RID: 7018 RVA: 0x00051988 File Offset: 0x0004FB88
		public override void Abort()
		{
			object obj = this.locker;
			lock (obj)
			{
				if (this.State == FtpWebRequest.RequestState.TransferInProgress)
				{
					this.SendCommand(false, "ABOR", new string[0]);
				}
				if (!this.InFinalState())
				{
					this.State = FtpWebRequest.RequestState.Aborted;
					this.ftpResponse = new FtpWebResponse(this, this.requestUri, this.method, FtpStatusCode.FileActionAborted, "Aborted by request");
				}
			}
		}

		/// <summary>Begins sending a request and receiving a response from an FTP server asynchronously.</summary>
		/// <returns>An <see cref="T:System.IAsyncResult" /> instance that indicates the status of the operation.</returns>
		/// <param name="callback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the operation is complete. </param>
		/// <param name="state">A user-defined object that contains information about the operation. This object is passed to the <paramref name="callback" /> delegate when the operation completes. </param>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="M:System.Net.FtpWebRequest.GetResponse" /> or <see cref="M:System.Net.FtpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> has already been called for this instance. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.DnsPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001B6B RID: 7019 RVA: 0x00051A14 File Offset: 0x0004FC14
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			if (this.asyncResult != null && !this.asyncResult.IsCompleted)
			{
				throw new InvalidOperationException("Cannot re-call BeginGetRequestStream/BeginGetResponse while a previous call is still in progress");
			}
			this.CheckIfAborted();
			this.asyncResult = new FtpAsyncResult(callback, state);
			object obj = this.locker;
			lock (obj)
			{
				if (this.InFinalState())
				{
					this.asyncResult.SetCompleted(true, this.ftpResponse);
				}
				else
				{
					if (this.State == FtpWebRequest.RequestState.Before)
					{
						this.State = FtpWebRequest.RequestState.Scheduled;
					}
					Thread thread = new Thread(new ThreadStart(this.ProcessRequest));
					thread.Start();
				}
			}
			return this.asyncResult;
		}

		/// <summary>Ends a pending asynchronous operation started with <see cref="M:System.Net.FtpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.</summary>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> reference that contains an <see cref="T:System.Net.FtpWebResponse" /> instance. This object contains the FTP server's response to the request.</returns>
		/// <param name="asyncResult">The <see cref="T:System.IAsyncResult" /> that was returned when the operation started. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="asyncResult" /> was not obtained by calling <see cref="M:System.Net.FtpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">This method was already called for the operation identified by <paramref name="asyncResult" />. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001B6C RID: 7020 RVA: 0x00051AD8 File Offset: 0x0004FCD8
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("AsyncResult cannot be null!");
			}
			if (!(asyncResult is FtpAsyncResult) || asyncResult != this.asyncResult)
			{
				throw new ArgumentException("AsyncResult is from another request!");
			}
			FtpAsyncResult ftpAsyncResult = (FtpAsyncResult)asyncResult;
			if (!ftpAsyncResult.WaitUntilComplete(this.timeout, false))
			{
				this.Abort();
				throw new WebException("Transfer timed out.", WebExceptionStatus.Timeout);
			}
			this.CheckIfAborted();
			asyncResult = null;
			if (ftpAsyncResult.GotException)
			{
				throw ftpAsyncResult.Exception;
			}
			return ftpAsyncResult.Response;
		}

		/// <summary>Returns the FTP server response.</summary>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> reference that contains an <see cref="T:System.Net.FtpWebResponse" /> instance. This object contains the FTP server's response to the request.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="M:System.Net.FtpWebRequest.GetResponse" /> or <see cref="M:System.Net.FtpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> has already been called for this instance.- or -An HTTP proxy is enabled, and you attempted to use an FTP command other than <see cref="F:System.Net.WebRequestMethods.Ftp.DownloadFile" />, <see cref="F:System.Net.WebRequestMethods.Ftp.ListDirectory" />, or <see cref="F:System.Net.WebRequestMethods.Ftp.ListDirectoryDetails" />.</exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="P:System.Net.FtpWebRequest.EnableSsl" /> is set to true, but the server does not support this feature.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.DnsPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001B6D RID: 7021 RVA: 0x00051B68 File Offset: 0x0004FD68
		public override WebResponse GetResponse()
		{
			IAsyncResult asyncResult = this.BeginGetResponse(null, null);
			return this.EndGetResponse(asyncResult);
		}

		/// <summary>Begins asynchronously opening a request's content stream for writing.</summary>
		/// <returns>An <see cref="T:System.IAsyncResult" /> instance that indicates the status of the operation.</returns>
		/// <param name="callback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the operation is complete. </param>
		/// <param name="state">A user-defined object that contains information about the operation. This object is passed to the <paramref name="callback" /> delegate when the operation completes. </param>
		/// <exception cref="T:System.InvalidOperationException">A previous call to this method or <see cref="M:System.Net.FtpWebRequest.GetRequestStream" /> has not yet completed. </exception>
		/// <exception cref="T:System.Net.WebException">A connection to the FTP server could not be established. </exception>
		/// <exception cref="T:System.Net.ProtocolViolationException">The <see cref="P:System.Net.FtpWebRequest.Method" /> property is not set to <see cref="F:System.Net.WebRequestMethods.Ftp.UploadFile" />. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.DnsPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001B6E RID: 7022 RVA: 0x00051B88 File Offset: 0x0004FD88
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			if (this.method != "STOR" && this.method != "STOU" && this.method != "APPE")
			{
				throw new ProtocolViolationException();
			}
			object obj = this.locker;
			lock (obj)
			{
				this.CheckIfAborted();
				if (this.State != FtpWebRequest.RequestState.Before)
				{
					throw new InvalidOperationException("Cannot re-call BeginGetRequestStream/BeginGetResponse while a previous call is still in progress");
				}
				this.State = FtpWebRequest.RequestState.Scheduled;
			}
			this.asyncResult = new FtpAsyncResult(callback, state);
			Thread thread = new Thread(new ThreadStart(this.ProcessRequest));
			thread.Start();
			return this.asyncResult;
		}

		/// <summary>Ends a pending asynchronous operation started with <see cref="M:System.Net.FtpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />.</summary>
		/// <returns>A writable <see cref="T:System.IO.Stream" /> instance associated with this instance.</returns>
		/// <param name="asyncResult">The <see cref="T:System.IAsyncResult" /> object that was returned when the operation started. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="asyncResult" /> was not obtained by calling <see cref="M:System.Net.FtpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">This method was already called for the operation identified by <paramref name="asyncResult" />. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001B6F RID: 7023 RVA: 0x00051C54 File Offset: 0x0004FE54
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (!(asyncResult is FtpAsyncResult))
			{
				throw new ArgumentException("asyncResult");
			}
			if (this.State == FtpWebRequest.RequestState.Aborted)
			{
				throw new WebException("Request aborted", WebExceptionStatus.RequestCanceled);
			}
			if (asyncResult != this.asyncResult)
			{
				throw new ArgumentException("AsyncResult is from another request!");
			}
			FtpAsyncResult ftpAsyncResult = (FtpAsyncResult)asyncResult;
			if (!ftpAsyncResult.WaitUntilComplete(this.timeout, false))
			{
				this.Abort();
				throw new WebException("Request timed out");
			}
			if (ftpAsyncResult.GotException)
			{
				throw ftpAsyncResult.Exception;
			}
			return ftpAsyncResult.Stream;
		}

		/// <summary>Retrieves the stream used to upload data to an FTP server.</summary>
		/// <returns>A writable <see cref="T:System.IO.Stream" /> instance used to store data to be sent to the server by the current request.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="M:System.Net.FtpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" /> has been called and has not completed. - or -An HTTP proxy is enabled, and you attempted to use an FTP command other than <see cref="F:System.Net.WebRequestMethods.Ftp.DownloadFile" />, <see cref="F:System.Net.WebRequestMethods.Ftp.ListDirectory" />, or <see cref="F:System.Net.WebRequestMethods.Ftp.ListDirectoryDetails" />.</exception>
		/// <exception cref="T:System.Net.WebException">A connection to the FTP server could not be established. </exception>
		/// <exception cref="T:System.Net.ProtocolViolationException">The <see cref="P:System.Net.FtpWebRequest.Method" /> property is not set to <see cref="F:System.Net.WebRequestMethods.Ftp.UploadFile" /> or <see cref="F:System.Net.WebRequestMethods.Ftp.AppendFile" />. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.DnsPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001B70 RID: 7024 RVA: 0x00051CFC File Offset: 0x0004FEFC
		public override Stream GetRequestStream()
		{
			IAsyncResult asyncResult = this.BeginGetRequestStream(null, null);
			return this.EndGetRequestStream(asyncResult);
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00013E52 File Offset: 0x00012052
		private ServicePoint GetServicePoint()
		{
			if (this.servicePoint == null)
			{
				this.servicePoint = ServicePointManager.FindServicePoint(this.requestUri, this.proxy);
			}
			return this.servicePoint;
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00051D1C File Offset: 0x0004FF1C
		private void ResolveHost()
		{
			this.CheckIfAborted();
			this.hostEntry = this.GetServicePoint().HostEntry;
			if (this.hostEntry == null)
			{
				this.ftpResponse.UpdateStatus(new FtpStatus(FtpStatusCode.ActionAbortedLocalProcessingError, "Cannot resolve server name"));
				throw new WebException("The remote server name could not be resolved: " + this.requestUri, null, WebExceptionStatus.NameResolutionFailure, this.ftpResponse);
			}
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x00051D84 File Offset: 0x0004FF84
		private void ProcessRequest()
		{
			if (this.State == FtpWebRequest.RequestState.Scheduled)
			{
				this.ftpResponse = new FtpWebResponse(this, this.requestUri, this.method, this.keepAlive);
				try
				{
					this.ProcessMethod();
					this.asyncResult.SetCompleted(false, this.ftpResponse);
				}
				catch (Exception ex)
				{
					this.State = FtpWebRequest.RequestState.Error;
					this.SetCompleteWithError(ex);
				}
			}
			else
			{
				if (this.InProgress())
				{
					FtpStatus responseStatus = this.GetResponseStatus();
					this.ftpResponse.UpdateStatus(responseStatus);
					if (this.ftpResponse.IsFinal())
					{
						this.State = FtpWebRequest.RequestState.Finished;
					}
				}
				this.asyncResult.SetCompleted(false, this.ftpResponse);
			}
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00051E48 File Offset: 0x00050048
		private void SetType()
		{
			if (this.binary)
			{
				FtpStatus ftpStatus = this.SendCommand("TYPE", new string[] { this.DataType });
				if (ftpStatus.StatusCode < FtpStatusCode.CommandOK || ftpStatus.StatusCode >= (FtpStatusCode)300)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
			}
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00051EA4 File Offset: 0x000500A4
		private string GetRemoteFolderPath(global::System.Uri uri)
		{
			string text = global::System.Uri.UnescapeDataString(uri.LocalPath);
			string text2;
			if (this.initial_path == null || this.initial_path == "/")
			{
				text2 = text;
			}
			else
			{
				if (text[0] == '/')
				{
					text = text.Substring(1);
				}
				global::System.Uri uri2 = new global::System.Uri("ftp://dummy-host" + this.initial_path);
				text2 = new global::System.Uri(uri2, text).LocalPath;
			}
			int num = text2.LastIndexOf('/');
			if (num == -1)
			{
				return null;
			}
			return text2.Substring(0, num + 1);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00051F3C File Offset: 0x0005013C
		private void CWDAndSetFileName(global::System.Uri uri)
		{
			string remoteFolderPath = this.GetRemoteFolderPath(uri);
			if (remoteFolderPath != null)
			{
				FtpStatus ftpStatus = this.SendCommand("CWD", new string[] { remoteFolderPath });
				if (ftpStatus.StatusCode < FtpStatusCode.CommandOK || ftpStatus.StatusCode >= (FtpStatusCode)300)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
				int num = uri.LocalPath.LastIndexOf('/');
				if (num >= 0)
				{
					this.file_name = global::System.Uri.UnescapeDataString(uri.LocalPath.Substring(num + 1));
				}
			}
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00051FC4 File Offset: 0x000501C4
		private void ProcessMethod()
		{
			this.State = FtpWebRequest.RequestState.Connecting;
			this.ResolveHost();
			this.OpenControlConnection();
			this.CWDAndSetFileName(this.requestUri);
			this.SetType();
			string text = this.method;
			if (text != null)
			{
				if (FtpWebRequest.<>f__switch$mapA == null)
				{
					FtpWebRequest.<>f__switch$mapA = new Dictionary<string, int>(12)
					{
						{ "RETR", 0 },
						{ "NLST", 0 },
						{ "LIST", 0 },
						{ "APPE", 1 },
						{ "STOR", 1 },
						{ "STOU", 1 },
						{ "SIZE", 2 },
						{ "MDTM", 2 },
						{ "PWD", 2 },
						{ "MKD", 2 },
						{ "RENAME", 2 },
						{ "DELE", 2 }
					};
				}
				int num;
				if (FtpWebRequest.<>f__switch$mapA.TryGetValue(text, out num))
				{
					switch (num)
					{
					case 0:
						this.DownloadData();
						break;
					case 1:
						this.UploadData();
						break;
					case 2:
						this.ProcessSimpleMethod();
						break;
					default:
						goto IL_0124;
					}
					this.CheckIfAborted();
					return;
				}
			}
			IL_0124:
			throw new Exception(string.Format("Support for command {0} not implemented yet", this.method));
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00013E7C File Offset: 0x0001207C
		private void CloseControlConnection()
		{
			if (this.controlStream != null)
			{
				this.SendCommand("QUIT", new string[0]);
				this.controlStream.Close();
				this.controlStream = null;
			}
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00013EAD File Offset: 0x000120AD
		internal void CloseDataConnection()
		{
			if (this.origDataStream != null)
			{
				this.origDataStream.Close();
				this.origDataStream = null;
			}
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x00013ECC File Offset: 0x000120CC
		private void CloseConnection()
		{
			this.CloseControlConnection();
			this.CloseDataConnection();
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x00052114 File Offset: 0x00050314
		private void ProcessSimpleMethod()
		{
			this.State = FtpWebRequest.RequestState.TransferInProgress;
			if (this.method == "PWD")
			{
				this.method = "PWD";
			}
			if (this.method == "RENAME")
			{
				this.method = "RNFR";
			}
			FtpStatus ftpStatus = this.SendCommand(this.method, new string[] { this.file_name });
			this.ftpResponse.Stream = Stream.Null;
			string statusDescription = ftpStatus.StatusDescription;
			string text = this.method;
			switch (text)
			{
			case "SIZE":
			{
				if (ftpStatus.StatusCode != FtpStatusCode.FileStatus)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
				int num2 = 4;
				int num3 = 0;
				while (num2 < statusDescription.Length && char.IsDigit(statusDescription[num2]))
				{
					num2++;
					num3++;
				}
				if (num3 == 0)
				{
					throw new WebException("Bad format for server response in " + this.method);
				}
				long num4;
				if (!long.TryParse(statusDescription.Substring(4, num3), out num4))
				{
					throw new WebException("Bad format for server response in " + this.method);
				}
				this.ftpResponse.contentLength = num4;
				break;
			}
			case "MDTM":
				if (ftpStatus.StatusCode != FtpStatusCode.FileStatus)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
				this.ftpResponse.LastModified = DateTime.ParseExact(statusDescription.Substring(4), "yyyyMMddHHmmss", null);
				break;
			case "MKD":
				if (ftpStatus.StatusCode != FtpStatusCode.PathnameCreated)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
				break;
			case "CWD":
				this.method = "PWD";
				if (ftpStatus.StatusCode != FtpStatusCode.FileActionOK)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
				ftpStatus = this.SendCommand(this.method, new string[0]);
				if (ftpStatus.StatusCode != FtpStatusCode.PathnameCreated)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
				break;
			case "RNFR":
				this.method = "RENAME";
				if (ftpStatus.StatusCode != FtpStatusCode.FileCommandPending)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
				ftpStatus = this.SendCommand("RNTO", new string[] { (this.renameTo == null) ? string.Empty : this.renameTo });
				if (ftpStatus.StatusCode != FtpStatusCode.FileActionOK)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
				break;
			case "DELE":
				if (ftpStatus.StatusCode != FtpStatusCode.FileActionOK)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
				break;
			}
			this.State = FtpWebRequest.RequestState.Finished;
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x00013EDA File Offset: 0x000120DA
		private void UploadData()
		{
			this.State = FtpWebRequest.RequestState.OpeningData;
			this.OpenDataConnection();
			this.State = FtpWebRequest.RequestState.TransferInProgress;
			this.requestStream = new FtpDataStream(this, this.dataStream, false);
			this.asyncResult.Stream = this.requestStream;
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x00013F14 File Offset: 0x00012114
		private void DownloadData()
		{
			this.State = FtpWebRequest.RequestState.OpeningData;
			this.OpenDataConnection();
			this.State = FtpWebRequest.RequestState.TransferInProgress;
			this.ftpResponse.Stream = new FtpDataStream(this, this.dataStream, true);
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x00013F42 File Offset: 0x00012142
		private void CheckRequestStarted()
		{
			if (this.State != FtpWebRequest.RequestState.Before)
			{
				throw new InvalidOperationException("There is a request currently in progress");
			}
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00052424 File Offset: 0x00050624
		private void OpenControlConnection()
		{
			Exception ex = null;
			global::System.Net.Sockets.Socket socket = null;
			foreach (IPAddress ipaddress in this.hostEntry.AddressList)
			{
				socket = new global::System.Net.Sockets.Socket(ipaddress.AddressFamily, global::System.Net.Sockets.SocketType.Stream, global::System.Net.Sockets.ProtocolType.Tcp);
				IPEndPoint ipendPoint = new IPEndPoint(ipaddress, this.requestUri.Port);
				if (!this.ServicePoint.CallEndPointDelegate(socket, ipendPoint))
				{
					socket.Close();
					socket = null;
				}
				else
				{
					try
					{
						socket.Connect(ipendPoint);
						this.localEndPoint = (IPEndPoint)socket.LocalEndPoint;
						break;
					}
					catch (global::System.Net.Sockets.SocketException ex2)
					{
						ex = ex2;
						socket.Close();
						socket = null;
					}
				}
			}
			if (socket == null)
			{
				throw new WebException("Unable to connect to remote server", ex, WebExceptionStatus.UnknownError, this.ftpResponse);
			}
			this.controlStream = new global::System.Net.Sockets.NetworkStream(socket);
			this.controlReader = new StreamReader(this.controlStream, Encoding.ASCII);
			this.State = FtpWebRequest.RequestState.Authenticating;
			this.Authenticate();
			FtpStatus ftpStatus = this.SendCommand("OPTS", new string[] { "utf8", "on" });
			ftpStatus = this.SendCommand("PWD", new string[0]);
			this.initial_path = FtpWebRequest.GetInitialPath(ftpStatus);
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00052570 File Offset: 0x00050770
		private static string GetInitialPath(FtpStatus status)
		{
			int statusCode = (int)status.StatusCode;
			if (statusCode < 200 || statusCode > 300 || status.StatusDescription.Length <= 4)
			{
				throw new WebException("Error getting current directory: " + status.StatusDescription, null, WebExceptionStatus.UnknownError, null);
			}
			string text = status.StatusDescription.Substring(4);
			if (text[0] == '"')
			{
				int num = text.IndexOf('"', 1);
				if (num == -1)
				{
					throw new WebException("Error getting current directory: PWD -> " + status.StatusDescription, null, WebExceptionStatus.UnknownError, null);
				}
				text = text.Substring(1, num - 1);
			}
			if (!text.EndsWith("/"))
			{
				text += "/";
			}
			return text;
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x00052634 File Offset: 0x00050834
		private global::System.Net.Sockets.Socket SetupPassiveConnection(string statusDescription)
		{
			if (statusDescription.Length < 4)
			{
				throw new WebException("Cannot open passive data connection");
			}
			int num = 3;
			while (num < statusDescription.Length && !char.IsDigit(statusDescription[num]))
			{
				num++;
			}
			if (num >= statusDescription.Length)
			{
				throw new WebException("Cannot open passive data connection");
			}
			string[] array = statusDescription.Substring(num).Split(new char[] { ',' }, 6);
			if (array.Length != 6)
			{
				throw new WebException("Cannot open passive data connection");
			}
			int num2 = array[5].Length - 1;
			while (num2 >= 0 && !char.IsDigit(array[5][num2]))
			{
				num2--;
			}
			if (num2 < 0)
			{
				throw new WebException("Cannot open passive data connection");
			}
			array[5] = array[5].Substring(0, num2 + 1);
			IPAddress ipaddress;
			try
			{
				ipaddress = IPAddress.Parse(string.Join(".", array, 0, 4));
			}
			catch (FormatException)
			{
				throw new WebException("Cannot open passive data connection");
			}
			int num3;
			int num4;
			if (!int.TryParse(array[4], out num3) || !int.TryParse(array[5], out num4))
			{
				throw new WebException("Cannot open passive data connection");
			}
			int num5 = (num3 << 8) + num4;
			if (num5 < 0 || num5 > 65535)
			{
				throw new WebException("Cannot open passive data connection");
			}
			IPEndPoint ipendPoint = new IPEndPoint(ipaddress, num5);
			global::System.Net.Sockets.Socket socket = new global::System.Net.Sockets.Socket(ipendPoint.AddressFamily, global::System.Net.Sockets.SocketType.Stream, global::System.Net.Sockets.ProtocolType.Tcp);
			try
			{
				socket.Connect(ipendPoint);
			}
			catch (global::System.Net.Sockets.SocketException)
			{
				socket.Close();
				throw new WebException("Cannot open passive data connection");
			}
			return socket;
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x000527F0 File Offset: 0x000509F0
		private Exception CreateExceptionFromResponse(FtpStatus status)
		{
			FtpWebResponse ftpWebResponse = new FtpWebResponse(this, this.requestUri, this.method, status);
			return new WebException("Server returned an error: " + status.StatusDescription, null, WebExceptionStatus.ProtocolError, ftpWebResponse);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0005282C File Offset: 0x00050A2C
		internal void SetTransferCompleted()
		{
			if (this.InFinalState())
			{
				return;
			}
			this.State = FtpWebRequest.RequestState.Finished;
			FtpStatus responseStatus = this.GetResponseStatus();
			this.ftpResponse.UpdateStatus(responseStatus);
			if (!this.keepAlive)
			{
				this.CloseConnection();
			}
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00013F5A File Offset: 0x0001215A
		internal void OperationCompleted()
		{
			if (!this.keepAlive)
			{
				this.CloseConnection();
			}
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00013F6D File Offset: 0x0001216D
		private void SetCompleteWithError(Exception exc)
		{
			if (this.asyncResult != null)
			{
				this.asyncResult.SetCompleted(false, exc);
			}
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00052870 File Offset: 0x00050A70
		private global::System.Net.Sockets.Socket InitDataConnection()
		{
			if (this.usePassive)
			{
				FtpStatus ftpStatus = this.SendCommand("PASV", new string[0]);
				if (ftpStatus.StatusCode != FtpStatusCode.EnteringPassive)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
				return this.SetupPassiveConnection(ftpStatus.StatusDescription);
			}
			else
			{
				global::System.Net.Sockets.Socket socket = new global::System.Net.Sockets.Socket(global::System.Net.Sockets.AddressFamily.InterNetwork, global::System.Net.Sockets.SocketType.Stream, global::System.Net.Sockets.ProtocolType.Tcp);
				try
				{
					socket.Bind(new IPEndPoint(this.localEndPoint.Address, 0));
					socket.Listen(1);
				}
				catch (global::System.Net.Sockets.SocketException ex)
				{
					socket.Close();
					throw new WebException("Couldn't open listening socket on client", ex);
				}
				IPEndPoint ipendPoint = (IPEndPoint)socket.LocalEndPoint;
				string text = ipendPoint.Address.ToString().Replace('.', ',');
				int num = ipendPoint.Port >> 8;
				int num2 = ipendPoint.Port % 256;
				string text2 = string.Concat(new object[] { text, ",", num, ",", num2 });
				FtpStatus ftpStatus = this.SendCommand("PORT", new string[] { text2 });
				if (ftpStatus.StatusCode != FtpStatusCode.CommandOK)
				{
					socket.Close();
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
				return socket;
			}
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x000529BC File Offset: 0x00050BBC
		private void OpenDataConnection()
		{
			global::System.Net.Sockets.Socket socket = this.InitDataConnection();
			FtpStatus ftpStatus;
			if (this.offset > 0L)
			{
				ftpStatus = this.SendCommand("REST", new string[] { this.offset.ToString() });
				if (ftpStatus.StatusCode != FtpStatusCode.FileCommandPending)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
			}
			if (this.method != "NLST" && this.method != "LIST" && this.method != "STOU")
			{
				ftpStatus = this.SendCommand(this.method, new string[] { this.file_name });
			}
			else
			{
				ftpStatus = this.SendCommand(this.method, new string[0]);
			}
			if (ftpStatus.StatusCode != FtpStatusCode.OpeningData && ftpStatus.StatusCode != FtpStatusCode.DataAlreadyOpen)
			{
				throw this.CreateExceptionFromResponse(ftpStatus);
			}
			if (this.usePassive)
			{
				this.origDataStream = new global::System.Net.Sockets.NetworkStream(socket, true);
				this.dataStream = this.origDataStream;
				if (this.EnableSsl)
				{
					this.ChangeToSSLSocket(ref this.dataStream);
				}
			}
			else
			{
				global::System.Net.Sockets.Socket socket2 = null;
				try
				{
					socket2 = socket.Accept();
				}
				catch (global::System.Net.Sockets.SocketException)
				{
					socket.Close();
					if (socket2 != null)
					{
						socket2.Close();
					}
					throw new ProtocolViolationException("Server commited a protocol violation.");
				}
				socket.Close();
				this.origDataStream = new global::System.Net.Sockets.NetworkStream(socket, true);
				this.dataStream = this.origDataStream;
				if (this.EnableSsl)
				{
					this.ChangeToSSLSocket(ref this.dataStream);
				}
			}
			this.ftpResponse.UpdateStatus(ftpStatus);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00052B74 File Offset: 0x00050D74
		private void Authenticate()
		{
			string text = null;
			string text2 = null;
			string text3 = null;
			if (this.credentials != null)
			{
				text = this.credentials.UserName;
				text2 = this.credentials.Password;
				text3 = this.credentials.Domain;
			}
			if (text == null)
			{
				text = "anonymous";
			}
			if (text2 == null)
			{
				text2 = "@anonymous";
			}
			if (!string.IsNullOrEmpty(text3))
			{
				text = text3 + '\\' + text;
			}
			FtpStatus ftpStatus = this.GetResponseStatus();
			this.ftpResponse.BannerMessage = ftpStatus.StatusDescription;
			if (this.EnableSsl)
			{
				this.InitiateSecureConnection(ref this.controlStream);
				this.controlReader = new StreamReader(this.controlStream, Encoding.ASCII);
				ftpStatus = this.SendCommand("PBSZ", new string[] { "0" });
				int num = (int)ftpStatus.StatusCode;
				if (num < 200 || num >= 300)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
				ftpStatus = this.SendCommand("PROT", new string[] { "P" });
				num = (int)ftpStatus.StatusCode;
				if (num < 200 || num >= 300)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
				ftpStatus = new FtpStatus(FtpStatusCode.SendUserCommand, string.Empty);
			}
			if (ftpStatus.StatusCode != FtpStatusCode.SendUserCommand)
			{
				throw this.CreateExceptionFromResponse(ftpStatus);
			}
			ftpStatus = this.SendCommand("USER", new string[] { text });
			FtpStatusCode statusCode = ftpStatus.StatusCode;
			if (statusCode != FtpStatusCode.LoggedInProceed)
			{
				if (statusCode != FtpStatusCode.SendPasswordCommand)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
				ftpStatus = this.SendCommand("PASS", new string[] { text2 });
				if (ftpStatus.StatusCode != FtpStatusCode.LoggedInProceed)
				{
					throw this.CreateExceptionFromResponse(ftpStatus);
				}
			}
			this.ftpResponse.WelcomeMessage = ftpStatus.StatusDescription;
			this.ftpResponse.UpdateStatus(ftpStatus);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00013F87 File Offset: 0x00012187
		private FtpStatus SendCommand(string command, params string[] parameters)
		{
			return this.SendCommand(true, command, parameters);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00052D74 File Offset: 0x00050F74
		private FtpStatus SendCommand(bool waitResponse, string command, params string[] parameters)
		{
			string text = command;
			if (parameters.Length > 0)
			{
				text = text + " " + string.Join(" ", parameters);
			}
			text += "\r\n";
			byte[] bytes = Encoding.ASCII.GetBytes(text);
			try
			{
				this.controlStream.Write(bytes, 0, bytes.Length);
			}
			catch (IOException)
			{
				return new FtpStatus(FtpStatusCode.ServiceNotAvailable, "Write failed");
			}
			if (!waitResponse)
			{
				return null;
			}
			FtpStatus responseStatus = this.GetResponseStatus();
			if (this.ftpResponse != null)
			{
				this.ftpResponse.UpdateStatus(responseStatus);
			}
			return responseStatus;
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00013F92 File Offset: 0x00012192
		internal static FtpStatus ServiceNotAvailable()
		{
			return new FtpStatus(FtpStatusCode.ServiceNotAvailable, global::Locale.GetText("Invalid response from server"));
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00052E24 File Offset: 0x00051024
		internal FtpStatus GetResponseStatus()
		{
			string text = null;
			try
			{
				text = this.controlReader.ReadLine();
			}
			catch (IOException)
			{
			}
			if (text == null || text.Length < 3)
			{
				return FtpWebRequest.ServiceNotAvailable();
			}
			int num;
			if (!int.TryParse(text.Substring(0, 3), out num))
			{
				return FtpWebRequest.ServiceNotAvailable();
			}
			if (text.Length > 3 && text[3] == '-')
			{
				string text2 = null;
				string text3 = num.ToString() + ' ';
				for (;;)
				{
					text2 = null;
					try
					{
						text2 = this.controlReader.ReadLine();
					}
					catch (IOException)
					{
					}
					if (text2 == null)
					{
						break;
					}
					text = text + Environment.NewLine + text2;
					if (text2.StartsWith(text3, StringComparison.Ordinal))
					{
						goto Block_8;
					}
				}
				return FtpWebRequest.ServiceNotAvailable();
				Block_8:;
			}
			return new FtpStatus((FtpStatusCode)num, text);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00052F20 File Offset: 0x00051120
		private void InitiateSecureConnection(ref Stream stream)
		{
			FtpStatus ftpStatus = this.SendCommand("AUTH", new string[] { "TLS" });
			if (ftpStatus.StatusCode != FtpStatusCode.ServerWantsSecureSession)
			{
				throw this.CreateExceptionFromResponse(ftpStatus);
			}
			this.ChangeToSSLSocket(ref stream);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00052F68 File Offset: 0x00051168
		internal bool ChangeToSSLSocket(ref Stream stream)
		{
			global::System.Net.Security.SslStream sslStream = new global::System.Net.Security.SslStream(stream, true, this.callback, null);
			sslStream.AuthenticateAsClient(this.requestUri.Host, null, global::System.Security.Authentication.SslProtocols.Default, false);
			stream = sslStream;
			return true;
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x00013FA8 File Offset: 0x000121A8
		private bool InFinalState()
		{
			return this.State == FtpWebRequest.RequestState.Aborted || this.State == FtpWebRequest.RequestState.Error || this.State == FtpWebRequest.RequestState.Finished;
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x00013FCE File Offset: 0x000121CE
		private bool InProgress()
		{
			return this.State != FtpWebRequest.RequestState.Before && !this.InFinalState();
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x00013FE7 File Offset: 0x000121E7
		internal void CheckIfAborted()
		{
			if (this.State == FtpWebRequest.RequestState.Aborted)
			{
				throw new WebException("Request aborted", WebExceptionStatus.RequestCanceled);
			}
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x00014001 File Offset: 0x00012201
		private void CheckFinalState()
		{
			if (this.InFinalState())
			{
				throw new InvalidOperationException("Cannot change final state");
			}
		}

		// Token: 0x040010B9 RID: 4281
		private const string ChangeDir = "CWD";

		// Token: 0x040010BA RID: 4282
		private const string UserCommand = "USER";

		// Token: 0x040010BB RID: 4283
		private const string PasswordCommand = "PASS";

		// Token: 0x040010BC RID: 4284
		private const string TypeCommand = "TYPE";

		// Token: 0x040010BD RID: 4285
		private const string PassiveCommand = "PASV";

		// Token: 0x040010BE RID: 4286
		private const string PortCommand = "PORT";

		// Token: 0x040010BF RID: 4287
		private const string AbortCommand = "ABOR";

		// Token: 0x040010C0 RID: 4288
		private const string AuthCommand = "AUTH";

		// Token: 0x040010C1 RID: 4289
		private const string RestCommand = "REST";

		// Token: 0x040010C2 RID: 4290
		private const string RenameFromCommand = "RNFR";

		// Token: 0x040010C3 RID: 4291
		private const string RenameToCommand = "RNTO";

		// Token: 0x040010C4 RID: 4292
		private const string QuitCommand = "QUIT";

		// Token: 0x040010C5 RID: 4293
		private const string EOL = "\r\n";

		// Token: 0x040010C6 RID: 4294
		private global::System.Uri requestUri;

		// Token: 0x040010C7 RID: 4295
		private string file_name;

		// Token: 0x040010C8 RID: 4296
		private ServicePoint servicePoint;

		// Token: 0x040010C9 RID: 4297
		private Stream origDataStream;

		// Token: 0x040010CA RID: 4298
		private Stream dataStream;

		// Token: 0x040010CB RID: 4299
		private Stream controlStream;

		// Token: 0x040010CC RID: 4300
		private StreamReader controlReader;

		// Token: 0x040010CD RID: 4301
		private NetworkCredential credentials;

		// Token: 0x040010CE RID: 4302
		private IPHostEntry hostEntry;

		// Token: 0x040010CF RID: 4303
		private IPEndPoint localEndPoint;

		// Token: 0x040010D0 RID: 4304
		private IWebProxy proxy;

		// Token: 0x040010D1 RID: 4305
		private int timeout = 100000;

		// Token: 0x040010D2 RID: 4306
		private int rwTimeout = 300000;

		// Token: 0x040010D3 RID: 4307
		private long offset;

		// Token: 0x040010D4 RID: 4308
		private bool binary = true;

		// Token: 0x040010D5 RID: 4309
		private bool enableSsl;

		// Token: 0x040010D6 RID: 4310
		private bool usePassive = true;

		// Token: 0x040010D7 RID: 4311
		private bool keepAlive;

		// Token: 0x040010D8 RID: 4312
		private string method = "RETR";

		// Token: 0x040010D9 RID: 4313
		private string renameTo;

		// Token: 0x040010DA RID: 4314
		private object locker = new object();

		// Token: 0x040010DB RID: 4315
		private FtpWebRequest.RequestState requestState;

		// Token: 0x040010DC RID: 4316
		private FtpAsyncResult asyncResult;

		// Token: 0x040010DD RID: 4317
		private FtpWebResponse ftpResponse;

		// Token: 0x040010DE RID: 4318
		private Stream requestStream;

		// Token: 0x040010DF RID: 4319
		private string initial_path;

		// Token: 0x040010E0 RID: 4320
		private static readonly string[] supportedCommands = new string[]
		{
			"APPE", "DELE", "LIST", "MDTM", "MKD", "NLST", "PWD", "RENAME", "RETR", "RMD",
			"SIZE", "STOR", "STOU"
		};

		// Token: 0x040010E1 RID: 4321
		private global::System.Net.Security.RemoteCertificateValidationCallback callback = delegate(object sender, X509Certificate certificate, global::System.Security.Cryptography.X509Certificates.X509Chain chain, global::System.Net.Security.SslPolicyErrors sslPolicyErrors)
		{
			if (ServicePointManager.ServerCertificateValidationCallback != null)
			{
				return ServicePointManager.ServerCertificateValidationCallback(sender, certificate, chain, sslPolicyErrors);
			}
			if (sslPolicyErrors != global::System.Net.Security.SslPolicyErrors.None)
			{
				throw new InvalidOperationException("SSL authentication error: " + sslPolicyErrors);
			}
			return true;
		};

		// Token: 0x02000322 RID: 802
		private enum RequestState
		{
			// Token: 0x040010E6 RID: 4326
			Before,
			// Token: 0x040010E7 RID: 4327
			Scheduled,
			// Token: 0x040010E8 RID: 4328
			Connecting,
			// Token: 0x040010E9 RID: 4329
			Authenticating,
			// Token: 0x040010EA RID: 4330
			OpeningData,
			// Token: 0x040010EB RID: 4331
			TransferInProgress,
			// Token: 0x040010EC RID: 4332
			Finished,
			// Token: 0x040010ED RID: 4333
			Aborted,
			// Token: 0x040010EE RID: 4334
			Error
		}
	}
}
