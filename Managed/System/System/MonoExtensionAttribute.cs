using System;

namespace System
{
	// Token: 0x02000007 RID: 7
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	internal class MonoExtensionAttribute : global::System.MonoTODOAttribute
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000021F6 File Offset: 0x000003F6
		public MonoExtensionAttribute(string comment)
			: base(comment)
		{
		}
	}
}
