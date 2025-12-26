using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Net.Sockets
{
	/// <summary>The exception that is thrown when a socket error occurs.</summary>
	// Token: 0x0200041C RID: 1052
	[Serializable]
	public class SocketException : global::System.ComponentModel.Win32Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.SocketException" /> class with the last operating system error code.</summary>
		// Token: 0x0600249E RID: 9374 RVA: 0x00019763 File Offset: 0x00017963
		public SocketException()
			: base(SocketException.WSAGetLastError_internal())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.SocketException" /> class with the specified error code.</summary>
		/// <param name="errorCode">The error code that indicates the error that occurred. </param>
		// Token: 0x0600249F RID: 9375 RVA: 0x00014493 File Offset: 0x00012693
		public SocketException(int error)
			: base(error)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.SocketException" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance that contains the information that is required to serialize the new <see cref="T:System.Net.Sockets.SocketException" /> instance. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the source of the serialized stream that is associated with the new <see cref="T:System.Net.Sockets.SocketException" /> instance. </param>
		// Token: 0x060024A0 RID: 9376 RVA: 0x000144A6 File Offset: 0x000126A6
		protected SocketException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0001449C File Offset: 0x0001269C
		internal SocketException(int error, string message)
			: base(error, message)
		{
		}

		// Token: 0x060024A2 RID: 9378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int WSAGetLastError_internal();

		/// <summary>Gets the error code that is associated with this exception.</summary>
		/// <returns>An integer error code that is associated with this exception.</returns>
		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x00019770 File Offset: 0x00017970
		public override int ErrorCode
		{
			get
			{
				return base.NativeErrorCode;
			}
		}

		/// <summary>Gets the error code that is associated with this exception.</summary>
		/// <returns>An integer error code that is associated with this exception.</returns>
		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060024A4 RID: 9380 RVA: 0x00019770 File Offset: 0x00017970
		public SocketError SocketErrorCode
		{
			get
			{
				return (SocketError)base.NativeErrorCode;
			}
		}

		/// <summary>Gets the error message that is associated with this exception.</summary>
		/// <returns>A string that contains the error message. </returns>
		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x0000D4B1 File Offset: 0x0000B6B1
		public override string Message
		{
			get
			{
				return base.Message;
			}
		}
	}
}
