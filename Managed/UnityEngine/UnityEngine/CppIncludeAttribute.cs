using System;

namespace UnityEngine
{
	// Token: 0x02000253 RID: 595
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
	internal class CppIncludeAttribute : Attribute
	{
		// Token: 0x0600207D RID: 8317 RVA: 0x0000286A File Offset: 0x00000A6A
		public CppIncludeAttribute(string header)
		{
		}
	}
}
