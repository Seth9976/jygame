using System;

namespace System
{
	// Token: 0x02000006 RID: 6
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	internal class MonoDocumentationNoteAttribute : global::System.MonoTODOAttribute
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000021F6 File Offset: 0x000003F6
		public MonoDocumentationNoteAttribute(string comment)
			: base(comment)
		{
		}
	}
}
