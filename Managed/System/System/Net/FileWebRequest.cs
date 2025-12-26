using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Net
{
	/// <summary>Provides a file system implementation of the <see cref="T:System.Net.WebRequest" /> class.</summary>
	// Token: 0x02000316 RID: 790
	[Serializable]
	public class FileWebRequest : WebRequest, ISerializable
	{
		// Token: 0x06001ACD RID: 6861 RVA: 0x0001398F File Offset: 0x00011B8F
		internal FileWebRequest(global::System.Uri uri)
		{
			this.uri = uri;
			this.webHeaders = new WebHeaderCollection();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.FileWebRequest" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information that is required to serialize the new <see cref="T:System.Net.FileWebRequest" /> object. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source of the serialized stream that is associated with the new <see cref="T:System.Net.FileWebRequest" /> object. </param>
		// Token: 0x06001ACE RID: 6862 RVA: 0x00050AB4 File Offset: 0x0004ECB4
		[Obsolete("Serialization is obsoleted for this type", false)]
		protected FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.webHeaders = (WebHeaderCollection)serializationInfo.GetValue("headers", typeof(WebHeaderCollection));
			this.proxy = (IWebProxy)serializationInfo.GetValue("proxy", typeof(IWebProxy));
			this.uri = (global::System.Uri)serializationInfo.GetValue("uri", typeof(global::System.Uri));
			this.connectionGroup = serializationInfo.GetString("connectionGroupName");
			this.method = serializationInfo.GetString("method");
			this.contentLength = serializationInfo.GetInt64("contentLength");
			this.timeout = serializationInfo.GetInt32("timeout");
			this.fileAccess = (FileAccess)((int)serializationInfo.GetValue("fileAccess", typeof(FileAccess)));
			this.preAuthenticate = serializationInfo.GetBoolean("preauthenticate");
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the required data to serialize the <see cref="T:System.Net.FileWebRequest" />.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized data for the <see cref="T:System.Net.FileWebRequest" />. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the destination of the serialized stream that is associated with the new <see cref="T:System.Net.FileWebRequest" />. </param>
		// Token: 0x06001ACF RID: 6863 RVA: 0x000139C6 File Offset: 0x00011BC6
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Gets or sets the name of the connection group for the request. This property is reserved for future use.</summary>
		/// <returns>The name of the connection group for the request.</returns>
		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x000139D0 File Offset: 0x00011BD0
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x000139D8 File Offset: 0x00011BD8
		public override string ConnectionGroupName
		{
			get
			{
				return this.connectionGroup;
			}
			set
			{
				this.connectionGroup = value;
			}
		}

		/// <summary>Gets or sets the content length of the data being sent.</summary>
		/// <returns>The number of bytes of request data being sent.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Net.FileWebRequest.ContentLength" /> is less than 0. </exception>
		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x000139E1 File Offset: 0x00011BE1
		// (set) Token: 0x06001AD3 RID: 6867 RVA: 0x000139E9 File Offset: 0x00011BE9
		public override long ContentLength
		{
			get
			{
				return this.contentLength;
			}
			set
			{
				if (value < 0L)
				{
					throw new ArgumentException("The Content-Length value must be greater than or equal to zero.", "value");
				}
				this.contentLength = value;
			}
		}

		/// <summary>Gets or sets the content type of the data being sent. This property is reserved for future use.</summary>
		/// <returns>The content type of the data being sent.</returns>
		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x00013A0A File Offset: 0x00011C0A
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x00013A1C File Offset: 0x00011C1C
		public override string ContentType
		{
			get
			{
				return this.webHeaders["Content-Type"];
			}
			set
			{
				this.webHeaders["Content-Type"] = value;
			}
		}

		/// <summary>Gets or sets the credentials that are associated with this request. This property is reserved for future use.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> that contains the authentication credentials that are associated with this request. The default is null.</returns>
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x00013A2F File Offset: 0x00011C2F
		// (set) Token: 0x06001AD7 RID: 6871 RVA: 0x00013A37 File Offset: 0x00011C37
		public override ICredentials Credentials
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

		/// <summary>Gets a collection of the name/value pairs that are associated with the request. This property is reserved for future use.</summary>
		/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> that contains header name/value pairs associated with this request.</returns>
		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x00013A40 File Offset: 0x00011C40
		public override WebHeaderCollection Headers
		{
			get
			{
				return this.webHeaders;
			}
		}

		/// <summary>Gets or sets the protocol method used for the request. This property is reserved for future use.</summary>
		/// <returns>The protocol method to use in this request.</returns>
		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x00013A48 File Offset: 0x00011C48
		// (set) Token: 0x06001ADA RID: 6874 RVA: 0x00013A50 File Offset: 0x00011C50
		public override string Method
		{
			get
			{
				return this.method;
			}
			set
			{
				if (value == null || value.Length == 0)
				{
					throw new ArgumentException("Cannot set null or blank methods on request.", "value");
				}
				this.method = value;
			}
		}

		/// <summary>Gets or sets a value that indicates whether to preauthenticate a request. This property is reserved for future use.</summary>
		/// <returns>true to preauthenticate; otherwise, false.</returns>
		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x00013A7A File Offset: 0x00011C7A
		// (set) Token: 0x06001ADC RID: 6876 RVA: 0x00013A82 File Offset: 0x00011C82
		public override bool PreAuthenticate
		{
			get
			{
				return this.preAuthenticate;
			}
			set
			{
				this.preAuthenticate = value;
			}
		}

		/// <summary>Gets or sets the network proxy to use for this request. This property is reserved for future use.</summary>
		/// <returns>An <see cref="T:System.Net.IWebProxy" /> that indicates the network proxy to use for this request.</returns>
		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x00013A8B File Offset: 0x00011C8B
		// (set) Token: 0x06001ADE RID: 6878 RVA: 0x00013A93 File Offset: 0x00011C93
		public override IWebProxy Proxy
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

		/// <summary>Gets the Uniform Resource Identifier (URI) of the request.</summary>
		/// <returns>A <see cref="T:System.Uri" /> that contains the URI of the request.</returns>
		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x00013A9C File Offset: 0x00011C9C
		public override global::System.Uri RequestUri
		{
			get
			{
				return this.uri;
			}
		}

		/// <summary>Gets or sets the length of time until the request times out.</summary>
		/// <returns>The time, in milliseconds, until the request times out, or the value <see cref="F:System.Threading.Timeout.Infinite" /> to indicate that the request does not time out.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified is less than or equal to zero and is not <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x00013AA4 File Offset: 0x00011CA4
		// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x00013AAC File Offset: 0x00011CAC
		public override int Timeout
		{
			get
			{
				return this.timeout;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("Timeout can be only set to 'System.Threading.Timeout.Infinite' or a value >= 0.");
				}
				this.timeout = value;
			}
		}

		/// <summary>Always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Always throws a <see cref="T:System.NotSupportedException" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Default credentials are not supported for file Uniform Resource Identifiers (URIs).</exception>
		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x00006A38 File Offset: 0x00004C38
		// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x00006A38 File Offset: 0x00004C38
		public override bool UseDefaultCredentials
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

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00005023 File Offset: 0x00003223
		private static Exception GetMustImplement()
		{
			return new NotImplementedException();
		}

		/// <summary>Cancels a request to an Internet resource.</summary>
		// Token: 0x06001AE5 RID: 6885 RVA: 0x00013AC7 File Offset: 0x00011CC7
		[global::System.MonoTODO]
		public override void Abort()
		{
			throw FileWebRequest.GetMustImplement();
		}

		/// <summary>Begins an asynchronous request for a <see cref="T:System.IO.Stream" /> object to use to write data.</summary>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate. </param>
		/// <param name="state">An object that contains state information for this request. </param>
		/// <exception cref="T:System.Net.ProtocolViolationException">The <see cref="P:System.Net.FileWebRequest.Method" /> property is GET and the application writes to the stream. </exception>
		/// <exception cref="T:System.InvalidOperationException">The stream is being used by a previous call to <see cref="M:System.Net.FileWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />. </exception>
		/// <exception cref="T:System.ApplicationException">No write stream is available. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001AE6 RID: 6886 RVA: 0x00050BBC File Offset: 0x0004EDBC
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			if (string.Compare("GET", this.method, true) == 0 || string.Compare("HEAD", this.method, true) == 0 || string.Compare("CONNECT", this.method, true) == 0)
			{
				throw new ProtocolViolationException("Cannot send a content-body with this verb-type.");
			}
			lock (this)
			{
				if (this.asyncResponding || this.webResponse != null)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
				if (this.requesting)
				{
					throw new InvalidOperationException("Cannot re-call start of asynchronous method while a previous call is still in progress.");
				}
				this.requesting = true;
			}
			FileWebRequest.GetRequestStreamCallback getRequestStreamCallback = new FileWebRequest.GetRequestStreamCallback(this.GetRequestStreamInternal);
			return getRequestStreamCallback.BeginInvoke(callback, state);
		}

		/// <summary>Ends an asynchronous request for a <see cref="T:System.IO.Stream" /> instance that the application uses to write data.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> object that the application uses to write data.</returns>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that references the pending request for a stream. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> is null. </exception>
		// Token: 0x06001AE7 RID: 6887 RVA: 0x00050C90 File Offset: 0x0004EE90
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (!asyncResult.IsCompleted)
			{
				asyncResult.AsyncWaitHandle.WaitOne();
			}
			AsyncResult asyncResult2 = (AsyncResult)asyncResult;
			FileWebRequest.GetRequestStreamCallback getRequestStreamCallback = (FileWebRequest.GetRequestStreamCallback)asyncResult2.AsyncDelegate;
			return getRequestStreamCallback.EndInvoke(asyncResult);
		}

		/// <summary>Returns a <see cref="T:System.IO.Stream" /> object for writing data to the file system resource.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> for writing data to the file system resource.</returns>
		/// <exception cref="T:System.Net.WebException">The request times out. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001AE8 RID: 6888 RVA: 0x00050CE0 File Offset: 0x0004EEE0
		public override Stream GetRequestStream()
		{
			IAsyncResult asyncResult = this.BeginGetRequestStream(null, null);
			if (!asyncResult.AsyncWaitHandle.WaitOne(this.timeout, false))
			{
				throw new WebException("The request timed out", WebExceptionStatus.Timeout);
			}
			return this.EndGetRequestStream(asyncResult);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00013ACE File Offset: 0x00011CCE
		internal Stream GetRequestStreamInternal()
		{
			this.requestStream = new FileWebRequest.FileWebStream(this, FileMode.Create, FileAccess.Write, FileShare.Read);
			return this.requestStream;
		}

		/// <summary>Begins an asynchronous request for a file system resource.</summary>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate. </param>
		/// <param name="state">An object that contains state information for this request. </param>
		/// <exception cref="T:System.InvalidOperationException">The stream is already in use by a previous call to <see cref="M:System.Net.FileWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001AEA RID: 6890 RVA: 0x00050D24 File Offset: 0x0004EF24
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			lock (this)
			{
				if (this.asyncResponding)
				{
					throw new InvalidOperationException("Cannot re-call start of asynchronous method while a previous call is still in progress.");
				}
				this.asyncResponding = true;
			}
			FileWebRequest.GetResponseCallback getResponseCallback = new FileWebRequest.GetResponseCallback(this.GetResponseInternal);
			return getResponseCallback.BeginInvoke(callback, state);
		}

		/// <summary>Ends an asynchronous request for a file system resource.</summary>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains the response from the file system resource.</returns>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that references the pending request for a response. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> is null. </exception>
		// Token: 0x06001AEB RID: 6891 RVA: 0x00050D88 File Offset: 0x0004EF88
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (!asyncResult.IsCompleted)
			{
				asyncResult.AsyncWaitHandle.WaitOne();
			}
			AsyncResult asyncResult2 = (AsyncResult)asyncResult;
			FileWebRequest.GetResponseCallback getResponseCallback = (FileWebRequest.GetResponseCallback)asyncResult2.AsyncDelegate;
			WebResponse webResponse = getResponseCallback.EndInvoke(asyncResult);
			this.asyncResponding = false;
			return webResponse;
		}

		/// <summary>Returns a response to a file system request.</summary>
		/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains the response from the file system resource.</returns>
		/// <exception cref="T:System.Net.WebException">The request timed out. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001AEC RID: 6892 RVA: 0x00050DE0 File Offset: 0x0004EFE0
		public override WebResponse GetResponse()
		{
			IAsyncResult asyncResult = this.BeginGetResponse(null, null);
			if (!asyncResult.AsyncWaitHandle.WaitOne(this.timeout, false))
			{
				throw new WebException("The request timed out", WebExceptionStatus.Timeout);
			}
			return this.EndGetResponse(asyncResult);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00050E24 File Offset: 0x0004F024
		private WebResponse GetResponseInternal()
		{
			if (this.webResponse != null)
			{
				return this.webResponse;
			}
			lock (this)
			{
				if (this.requesting)
				{
					this.requestEndEvent = new AutoResetEvent(false);
				}
			}
			if (this.requestEndEvent != null)
			{
				this.requestEndEvent.WaitOne();
			}
			FileStream fileStream = null;
			try
			{
				fileStream = new FileWebRequest.FileWebStream(this, FileMode.Open, FileAccess.Read, FileShare.Read);
			}
			catch (Exception ex)
			{
				throw new WebException(ex.Message, ex);
			}
			this.webResponse = new FileWebResponse(this.uri, fileStream);
			return this.webResponse;
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" />  that specifies the destination for this serialization. </param>
		// Token: 0x06001AEE RID: 6894 RVA: 0x00050EE0 File Offset: 0x0004F0E0
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			serializationInfo.AddValue("headers", this.webHeaders, typeof(WebHeaderCollection));
			serializationInfo.AddValue("proxy", this.proxy, typeof(IWebProxy));
			serializationInfo.AddValue("uri", this.uri, typeof(global::System.Uri));
			serializationInfo.AddValue("connectionGroupName", this.connectionGroup);
			serializationInfo.AddValue("method", this.method);
			serializationInfo.AddValue("contentLength", this.contentLength);
			serializationInfo.AddValue("timeout", this.timeout);
			serializationInfo.AddValue("fileAccess", this.fileAccess);
			serializationInfo.AddValue("preauthenticate", false);
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00050FA8 File Offset: 0x0004F1A8
		internal void Close()
		{
			lock (this)
			{
				this.requesting = false;
				if (this.requestEndEvent != null)
				{
					this.requestEndEvent.Set();
				}
			}
		}

		// Token: 0x04001070 RID: 4208
		private global::System.Uri uri;

		// Token: 0x04001071 RID: 4209
		private WebHeaderCollection webHeaders;

		// Token: 0x04001072 RID: 4210
		private ICredentials credentials;

		// Token: 0x04001073 RID: 4211
		private string connectionGroup;

		// Token: 0x04001074 RID: 4212
		private long contentLength;

		// Token: 0x04001075 RID: 4213
		private FileAccess fileAccess = FileAccess.Read;

		// Token: 0x04001076 RID: 4214
		private string method = "GET";

		// Token: 0x04001077 RID: 4215
		private IWebProxy proxy;

		// Token: 0x04001078 RID: 4216
		private bool preAuthenticate;

		// Token: 0x04001079 RID: 4217
		private int timeout = 100000;

		// Token: 0x0400107A RID: 4218
		private Stream requestStream;

		// Token: 0x0400107B RID: 4219
		private FileWebResponse webResponse;

		// Token: 0x0400107C RID: 4220
		private AutoResetEvent requestEndEvent;

		// Token: 0x0400107D RID: 4221
		private bool requesting;

		// Token: 0x0400107E RID: 4222
		private bool asyncResponding;

		// Token: 0x02000317 RID: 791
		internal class FileWebStream : FileStream
		{
			// Token: 0x06001AF0 RID: 6896 RVA: 0x00013AE5 File Offset: 0x00011CE5
			internal FileWebStream(FileWebRequest webRequest, FileMode mode, FileAccess access, FileShare share)
				: base(webRequest.RequestUri.LocalPath, mode, access, share)
			{
				this.webRequest = webRequest;
			}

			// Token: 0x06001AF1 RID: 6897 RVA: 0x00050FF8 File Offset: 0x0004F1F8
			public override void Close()
			{
				base.Close();
				FileWebRequest fileWebRequest = this.webRequest;
				this.webRequest = null;
				if (fileWebRequest != null)
				{
					fileWebRequest.Close();
				}
			}

			// Token: 0x0400107F RID: 4223
			private FileWebRequest webRequest;
		}

		// Token: 0x02000318 RID: 792
		// (Invoke) Token: 0x06001AF3 RID: 6899
		private delegate Stream GetRequestStreamCallback();

		// Token: 0x02000319 RID: 793
		// (Invoke) Token: 0x06001AF7 RID: 6903
		private delegate WebResponse GetResponseCallback();
	}
}
