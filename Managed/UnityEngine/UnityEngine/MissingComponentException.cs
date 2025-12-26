using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x020002D5 RID: 725
	[Serializable]
	public class MissingComponentException : SystemException
	{
		// Token: 0x060021EE RID: 8686 RVA: 0x0000DA21 File Offset: 0x0000BC21
		public MissingComponentException()
			: base("A Unity Runtime error occurred!")
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0000DA39 File Offset: 0x0000BC39
		public MissingComponentException(string message)
			: base(message)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x0000DA4D File Offset: 0x0000BC4D
		public MissingComponentException(string message, Exception innerException)
			: base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x0000DA62 File Offset: 0x0000BC62
		protected MissingComponentException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x04000B00 RID: 2816
		private const int Result = -2147467261;

		// Token: 0x04000B01 RID: 2817
		private string unityStackTrace;
	}
}
