using System;

namespace UnityEngine
{
	// Token: 0x020001DA RID: 474
	internal sealed class GUIAspectSizer : GUILayoutEntry
	{
		// Token: 0x06001BF7 RID: 7159 RVA: 0x0000AB81 File Offset: 0x00008D81
		public GUIAspectSizer(float aspect, GUILayoutOption[] options)
			: base(0f, 0f, 0f, 0f, GUIStyle.none)
		{
			this.aspect = aspect;
			this.ApplyOptions(options);
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00022640 File Offset: 0x00020840
		public override void CalcHeight()
		{
			this.minHeight = (this.maxHeight = this.rect.width / this.aspect);
		}

		// Token: 0x04000739 RID: 1849
		private float aspect;
	}
}
