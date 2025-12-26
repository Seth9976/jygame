using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x020002D7 RID: 727
	[Serializable]
	public class MissingReferenceException : SystemException
	{
		// Token: 0x060021F6 RID: 8694 RVA: 0x0000DA21 File Offset: 0x0000BC21
		public MissingReferenceException()
			: base("A Unity Runtime error occurred!")
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x0000DA39 File Offset: 0x0000BC39
		public MissingReferenceException(string message)
			: base(message)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x0000DA4D File Offset: 0x0000BC4D
		public MissingReferenceException(string message, Exception innerException)
			: base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x0000DA62 File Offset: 0x0000BC62
		protected MissingReferenceException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x04000B04 RID: 2820
		private const int Result = -2147467261;

		// Token: 0x04000B05 RID: 2821
		private string unityStackTrace;
	}
}
