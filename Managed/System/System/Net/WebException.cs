using System;
using System.Runtime.Serialization;

namespace System.Net
{
	/// <summary>The exception that is thrown when an error occurs while accessing the network through a pluggable protocol.</summary>
	// Token: 0x02000433 RID: 1075
	[Serializable]
	public class WebException : InvalidOperationException, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class.</summary>
		// Token: 0x06002623 RID: 9763 RVA: 0x0001AB92 File Offset: 0x00018D92
		public WebException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class with the specified error message.</summary>
		/// <param name="message">The text of the error message. </param>
		// Token: 0x06002624 RID: 9764 RVA: 0x0001ABA2 File Offset: 0x00018DA2
		public WebException(string message)
			: base(message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class from the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> instances.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that contains the information required to serialize the new <see cref="T:System.Net.WebException" />. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the source of the serialized stream that is associated with the new <see cref="T:System.Net.WebException" />. </param>
		// Token: 0x06002625 RID: 9765 RVA: 0x0001ABB3 File Offset: 0x00018DB3
		protected WebException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class with the specified error message and nested exception.</summary>
		/// <param name="message">The text of the error message. </param>
		/// <param name="innerException">A nested exception. </param>
		// Token: 0x06002626 RID: 9766 RVA: 0x0001ABC5 File Offset: 0x00018DC5
		public WebException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class with the specified error message and status.</summary>
		/// <param name="message">The text of the error message. </param>
		/// <param name="status">One of the <see cref="T:System.Net.WebExceptionStatus" /> values. </param>
		// Token: 0x06002627 RID: 9767 RVA: 0x0001ABD7 File Offset: 0x00018DD7
		public WebException(string message, WebExceptionStatus status)
			: base(message)
		{
			this.status = status;
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x0001ABEF File Offset: 0x00018DEF
		internal WebException(string message, Exception innerException, WebExceptionStatus status)
			: base(message, innerException)
		{
			this.status = status;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class with the specified error message, nested exception, status, and response.</summary>
		/// <param name="message">The text of the error message. </param>
		/// <param name="innerException">A nested exception. </param>
		/// <param name="status">One of the <see cref="T:System.Net.WebExceptionStatus" /> values. </param>
		/// <param name="response">A <see cref="T:System.Net.WebResponse" /> instance that contains the response from the remote host. </param>
		// Token: 0x06002629 RID: 9769 RVA: 0x0001AC08 File Offset: 0x00018E08
		public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response)
			: base(message, innerException)
		{
			this.status = status;
			this.response = response;
		}

		/// <summary>Serializes this instance into the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</summary>
		/// <param name="serializationInfo">The object into which this <see cref="T:System.Net.WebException" /> will be serialized. </param>
		/// <param name="streamingContext">The destination of the serialization. </param>
		// Token: 0x0600262A RID: 9770 RVA: 0x0001356A File Offset: 0x0001176A
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}

		/// <summary>Gets the response that the remote host returned.</summary>
		/// <returns>If a response is available from the Internet resource, a <see cref="T:System.Net.WebResponse" /> instance that contains the error response from an Internet resource; otherwise, null.</returns>
		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x0600262B RID: 9771 RVA: 0x0001AC29 File Offset: 0x00018E29
		public WebResponse Response
		{
			get
			{
				return this.response;
			}
		}

		/// <summary>Gets the status of the response.</summary>
		/// <returns>One of the <see cref="T:System.Net.WebExceptionStatus" /> values.</returns>
		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x0001AC31 File Offset: 0x00018E31
		public WebExceptionStatus Status
		{
			get
			{
				return this.status;
			}
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance with the data needed to serialize the <see cref="T:System.Net.WebException" />.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to be used. </param>
		/// <param name="streamingContext">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> to be used. </param>
		// Token: 0x0600262D RID: 9773 RVA: 0x0001356A File Offset: 0x0001176A
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}

		// Token: 0x04001771 RID: 6001
		private WebResponse response;

		// Token: 0x04001772 RID: 6002
		private WebExceptionStatus status = WebExceptionStatus.UnknownError;
	}
}
