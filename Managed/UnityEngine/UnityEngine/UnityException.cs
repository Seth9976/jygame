using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x020002D4 RID: 724
	[Serializable]
	public class UnityException : SystemException
	{
		// Token: 0x060021EA RID: 8682 RVA: 0x0000DA21 File Offset: 0x0000BC21
		public UnityException()
			: base("A Unity Runtime error occurred!")
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x0000DA39 File Offset: 0x0000BC39
		public UnityException(string message)
			: base(message)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x0000DA4D File Offset: 0x0000BC4D
		public UnityException(string message, Exception innerException)
			: base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x0000DA62 File Offset: 0x0000BC62
		protected UnityException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x04000AFE RID: 2814
		private const int Result = -2147467261;

		// Token: 0x04000AFF RID: 2815
		private string unityStackTrace;
	}
}
