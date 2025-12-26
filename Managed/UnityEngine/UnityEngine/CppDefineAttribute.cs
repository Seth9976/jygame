using System;

namespace UnityEngine
{
	// Token: 0x02000254 RID: 596
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
	internal class CppDefineAttribute : Attribute
	{
		// Token: 0x0600207E RID: 8318 RVA: 0x0000286A File Offset: 0x00000A6A
		public CppDefineAttribute(string symbol, string value)
		{
		}
	}
}
