using System;

namespace System
{
	// Token: 0x02000008 RID: 8
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	internal class MonoInternalNoteAttribute : global::System.MonoTODOAttribute
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000021F6 File Offset: 0x000003F6
		public MonoInternalNoteAttribute(string comment)
			: base(comment)
		{
		}
	}
}
