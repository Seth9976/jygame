using System;

namespace System.Configuration
{
	// Token: 0x020001D7 RID: 471
	internal class SectionData
	{
		// Token: 0x06001058 RID: 4184 RVA: 0x0000D580 File Offset: 0x0000B780
		public SectionData(string sectionName, string typeName, bool allowLocation, AllowDefinition allowDefinition, bool requirePermission)
		{
			this.SectionName = sectionName;
			this.TypeName = typeName;
			this.AllowLocation = allowLocation;
			this.AllowDefinition = allowDefinition;
			this.RequirePermission = requirePermission;
		}

		// Token: 0x0400049A RID: 1178
		public readonly string SectionName;

		// Token: 0x0400049B RID: 1179
		public readonly string TypeName;

		// Token: 0x0400049C RID: 1180
		public readonly bool AllowLocation;

		// Token: 0x0400049D RID: 1181
		public readonly AllowDefinition AllowDefinition;

		// Token: 0x0400049E RID: 1182
		public string FileName;

		// Token: 0x0400049F RID: 1183
		public readonly bool RequirePermission;
	}
}
