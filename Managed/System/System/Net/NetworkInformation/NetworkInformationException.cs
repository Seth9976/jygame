using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Net.NetworkInformation
{
	/// <summary>The exception that is thrown when an error occurs while retrieving network information.</summary>
	// Token: 0x020003BC RID: 956
	[Serializable]
	public class NetworkInformationException : global::System.ComponentModel.Win32Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.NetworkInformationException" /> class.</summary>
		// Token: 0x060020F2 RID: 8434 RVA: 0x0001448B File Offset: 0x0001268B
		public NetworkInformationException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.NetworkInformationException" /> class with the specified error code.</summary>
		/// <param name="errorCode">A Win32 error code. </param>
		// Token: 0x060020F3 RID: 8435 RVA: 0x00014493 File Offset: 0x00012693
		public NetworkInformationException(int errorCode)
			: base(errorCode)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.NetworkInformationException" /> class with serialized data.</summary>
		/// <param name="serializationInfo">A SerializationInfo object that contains the serialized exception data. </param>
		/// <param name="streamingContext">A StreamingContext that contains contextual information about the serialized exception. </param>
		// Token: 0x060020F4 RID: 8436 RVA: 0x000179D4 File Offset: 0x00015BD4
		protected NetworkInformationException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			this.error_code = info.GetInt32("ErrorCode");
		}

		/// <summary>Gets the Win32 error code for this exception.</summary>
		/// <returns>An <see cref="T:System.Int32" /> value that contains the Win32 error code.</returns>
		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x000179EF File Offset: 0x00015BEF
		public override int ErrorCode
		{
			get
			{
				return this.error_code;
			}
		}

		// Token: 0x040013F0 RID: 5104
		private int error_code;
	}
}
