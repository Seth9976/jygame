using System;

namespace UnityEngine
{
	// Token: 0x02000257 RID: 599
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	internal class CppPropertyBodyAttribute : Attribute
	{
		// Token: 0x06002081 RID: 8321 RVA: 0x0000286A File Offset: 0x00000A6A
		public CppPropertyBodyAttribute(string getterBody, string setterBody)
		{
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x0000286A File Offset: 0x00000A6A
		public CppPropertyBodyAttribute(string getterBody)
		{
		}
	}
}
