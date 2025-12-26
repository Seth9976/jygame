using System;

namespace UnityEngine
{
	// Token: 0x020001DC RID: 476
	internal sealed class GUIWordWrapSizer : GUILayoutEntry
	{
		// Token: 0x06001BFC RID: 7164 RVA: 0x00022AF0 File Offset: 0x00020CF0
		public GUIWordWrapSizer(GUIStyle style, GUIContent content, GUILayoutOption[] options)
			: base(0f, 0f, 0f, 0f, style)
		{
			this.m_Content = new GUIContent(content);
			this.ApplyOptions(options);
			this.m_ForcedMinHeight = this.minHeight;
			this.m_ForcedMaxHeight = this.maxHeight;
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00022B44 File Offset: 0x00020D44
		public override void CalcWidth()
		{
			if (this.minWidth == 0f || this.maxWidth == 0f)
			{
				float num;
				float num2;
				base.style.CalcMinMaxWidth(this.m_Content, out num, out num2);
				if (this.minWidth == 0f)
				{
					this.minWidth = num;
				}
				if (this.maxWidth == 0f)
				{
					this.maxWidth = num2;
				}
			}
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00022BB4 File Offset: 0x00020DB4
		public override void CalcHeight()
		{
			if (this.m_ForcedMinHeight == 0f || this.m_ForcedMaxHeight == 0f)
			{
				float num = base.style.CalcHeight(this.m_Content, this.rect.width);
				if (this.m_ForcedMinHeight == 0f)
				{
					this.minHeight = num;
				}
				else
				{
					this.minHeight = this.m_ForcedMinHeight;
				}
				if (this.m_ForcedMaxHeight == 0f)
				{
					this.maxHeight = num;
				}
				else
				{
					this.maxHeight = this.m_ForcedMaxHeight;
				}
			}
		}

		// Token: 0x04000740 RID: 1856
		private readonly GUIContent m_Content;

		// Token: 0x04000741 RID: 1857
		private readonly float m_ForcedMinHeight;

		// Token: 0x04000742 RID: 1858
		private readonly float m_ForcedMaxHeight;
	}
}
