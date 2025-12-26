using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x020002D6 RID: 726
	[Serializable]
	public class UnassignedReferenceException : SystemException
	{
		// Token: 0x060021F2 RID: 8690 RVA: 0x0000DA21 File Offset: 0x0000BC21
		public UnassignedReferenceException()
			: base("A Unity Runtime error occurred!")
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x0000DA39 File Offset: 0x0000BC39
		public UnassignedReferenceException(string message)
			: base(message)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0000DA4D File Offset: 0x0000BC4D
		public UnassignedReferenceException(string message, Exception innerException)
			: base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x0000DA62 File Offset: 0x0000BC62
		protected UnassignedReferenceException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x04000B02 RID: 2818
		private const int Result = -2147467261;

		// Token: 0x04000B03 RID: 2819
		private string unityStackTrace;
	}
}
