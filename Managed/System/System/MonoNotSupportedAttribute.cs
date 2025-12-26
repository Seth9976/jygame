using System;

namespace System
{
	// Token: 0x0200000A RID: 10
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	internal class MonoNotSupportedAttribute : global::System.MonoTODOAttribute
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000021F6 File Offset: 0x000003F6
		public MonoNotSupportedAttribute(string comment)
			: base(comment)
		{
		}
	}
}
