using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Net
{
	/// <summary>The exception that is thrown when an error occurs processing an HTTP request.</summary>
	// Token: 0x0200032D RID: 813
	[Serializable]
	public class HttpListenerException : global::System.ComponentModel.Win32Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.HttpListenerException" /> class. </summary>
		// Token: 0x06001BF9 RID: 7161 RVA: 0x0001448B File Offset: 0x0001268B
		public HttpListenerException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.HttpListenerException" /> class using the specified error code.</summary>
		/// <param name="errorCode">A <see cref="T:System.Int32" /> value that identifies the error that occurred.</param>
		// Token: 0x06001BFA RID: 7162 RVA: 0x00014493 File Offset: 0x00012693
		public HttpListenerException(int errorCode)
			: base(errorCode)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.HttpListenerException" /> class using the specified error code and message.</summary>
		/// <param name="errorCode">A <see cref="T:System.Int32" /> value that identifies the error that occurred.</param>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error that occurred.</param>
		// Token: 0x06001BFB RID: 7163 RVA: 0x0001449C File Offset: 0x0001269C
		public HttpListenerException(int errorCode, string message)
			: base(errorCode, message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.HttpListenerException" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to deserialize the new <see cref="T:System.Net.HttpListenerException" /> object. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object. </param>
		// Token: 0x06001BFC RID: 7164 RVA: 0x000144A6 File Offset: 0x000126A6
		protected HttpListenerException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Gets a value that identifies the error that occurred.</summary>
		/// <returns>A <see cref="T:System.Int32" /> value.</returns>
		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x000144B0 File Offset: 0x000126B0
		public override int ErrorCode
		{
			get
			{
				return base.ErrorCode;
			}
		}
	}
}
