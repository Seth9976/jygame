using System;

namespace UnityEngine
{
	// Token: 0x02000258 RID: 600
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	internal class CppPropertyAttribute : Attribute
	{
		// Token: 0x06002083 RID: 8323 RVA: 0x0000286A File Offset: 0x00000A6A
		public CppPropertyAttribute(string getter, string setter)
		{
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x0000286A File Offset: 0x00000A6A
		public CppPropertyAttribute(string getter)
		{
		}
	}
}
