using System;
using System.IO;
using System.Runtime.Serialization;

namespace System.Net
{
	/// <summary>Provides a file system implementation of the <see cref="T:System.Net.WebResponse" /> class.</summary>
	// Token: 0x0200031A RID: 794
	[Serializable]
	public class FileWebResponse : WebResponse, IDisposable, ISerializable
	{
		// Token: 0x06001AFA RID: 6906 RVA: 0x00051028 File Offset: 0x0004F228
		internal FileWebResponse(global::System.Uri responseUri, FileStream fileStream)
		{
			try
			{
				this.responseUri = responseUri;
				this.fileStream = fileStream;
				this.contentLength = fileStream.Length;
				this.webHeaders = new WebHeaderCollection();
				this.webHeaders.Add("Content-Length", Convert.ToString(this.contentLength));
				this.webHeaders.Add("Content-Type", "application/octet-stream");
			}
			catch (Exception ex)
			{
				throw new WebException(ex.Message, ex);
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.FileWebResponse" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance that contains the information required to serialize the new <see cref="T:System.Net.FileWebResponse" /> instance. </param>
		/// <param name="streamingContext">An instance of the <see cref="T:System.Runtime.Serialization.StreamingContext" /> class that contains the source of the serialized stream associated with the new <see cref="T:System.Net.FileWebResponse" /> instance. </param>
		// Token: 0x06001AFB RID: 6907 RVA: 0x000510B8 File Offset: 0x0004F2B8
		[Obsolete("Serialization is obsoleted for this type", false)]
		protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.responseUri = (global::System.Uri)serializationInfo.GetValue("responseUri", typeof(global::System.Uri));
			this.contentLength = serializationInfo.GetInt64("contentLength");
			this.webHeaders = (WebHeaderCollection)serializationInfo.GetValue("webHeaders", typeof(WebHeaderCollection));
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance with the data needed to serialize the <see cref="T:System.Net.FileWebResponse" />.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> , which will hold the serialized data for the <see cref="T:System.Net.FileWebResponse" />. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> containing the destination of the serialized stream associated with the new <see cref="T:System.Net.FileWebResponse" />. </param>
		// Token: 0x06001AFC RID: 6908 RVA: 0x00013B03 File Offset: 0x00011D03
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Net.FileWebResponse" />.</summary>
		// Token: 0x06001AFD RID: 6909 RVA: 0x00013B0D File Offset: 0x00011D0D
		void IDisposable.Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Gets the length of the content in the file system resource.</summary>
		/// <returns>The number of bytes returned from the file system resource.</returns>
		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001AFE RID: 6910 RVA: 0x00013B1C File Offset: 0x00011D1C
		public override long ContentLength
		{
			get
			{
				this.CheckDisposed();
				return this.contentLength;
			}
		}

		/// <summary>Gets the content type of the file system resource.</summary>
		/// <returns>The value "binary/octet-stream".</returns>
		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x00013B2A File Offset: 0x00011D2A
		public override string ContentType
		{
			get
			{
				this.CheckDisposed();
				return "application/octet-stream";
			}
		}

		/// <summary>Gets a collection of header name/value pairs associated with the response.</summary>
		/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> that contains the header name/value pairs associated with the response.</returns>
		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x00013B37 File Offset: 0x00011D37
		public override WebHeaderCollection Headers
		{
			get
			{
				this.CheckDisposed();
				return this.webHeaders;
			}
		}

		/// <summary>Gets the URI of the file system resource that provided the response.</summary>
		/// <returns>A <see cref="T:System.Uri" /> that contains the URI of the file system resource that provided the response.</returns>
		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x00013B45 File Offset: 0x00011D45
		public override global::System.Uri ResponseUri
		{
			get
			{
				this.CheckDisposed();
				return this.responseUri;
			}
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
		// Token: 0x06001B02 RID: 6914 RVA: 0x00051120 File Offset: 0x0004F320
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			serializationInfo.AddValue("responseUri", this.responseUri, typeof(global::System.Uri));
			serializationInfo.AddValue("contentLength", this.contentLength);
			serializationInfo.AddValue("webHeaders", this.webHeaders, typeof(WebHeaderCollection));
		}

		/// <summary>Returns the data stream from the file system resource.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> for reading data from the file system resource.</returns>
		// Token: 0x06001B03 RID: 6915 RVA: 0x00013B53 File Offset: 0x00011D53
		public override Stream GetResponseStream()
		{
			this.CheckDisposed();
			return this.fileStream;
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00051178 File Offset: 0x0004F378
		~FileWebResponse()
		{
			this.Dispose(false);
		}

		/// <summary>Closes the response stream.</summary>
		// Token: 0x06001B05 RID: 6917 RVA: 0x00011AE6 File Offset: 0x0000FCE6
		public override void Close()
		{
			((IDisposable)this).Dispose();
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.FileWebResponse" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		// Token: 0x06001B06 RID: 6918 RVA: 0x000511A8 File Offset: 0x0004F3A8
		private void Dispose(bool disposing)
		{
			if (this.disposed)
			{
				return;
			}
			this.disposed = true;
			if (disposing)
			{
				this.responseUri = null;
				this.webHeaders = null;
			}
			FileStream fileStream = this.fileStream;
			this.fileStream = null;
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00013B61 File Offset: 0x00011D61
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		// Token: 0x04001080 RID: 4224
		private global::System.Uri responseUri;

		// Token: 0x04001081 RID: 4225
		private FileStream fileStream;

		// Token: 0x04001082 RID: 4226
		private long contentLength;

		// Token: 0x04001083 RID: 4227
		private WebHeaderCollection webHeaders;

		// Token: 0x04001084 RID: 4228
		private bool disposed;
	}
}
