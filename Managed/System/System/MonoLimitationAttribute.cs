using System;

namespace System
{
	// Token: 0x02000009 RID: 9
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	internal class MonoLimitationAttribute : global::System.MonoTODOAttribute
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000021F6 File Offset: 0x000003F6
		public MonoLimitationAttribute(string comment)
			: base(comment)
		{
		}
	}
}
