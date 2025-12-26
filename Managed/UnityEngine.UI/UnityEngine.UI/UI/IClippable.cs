using System;

namespace UnityEngine.UI
{
	// Token: 0x02000081 RID: 129
	public interface IClippable
	{
		// Token: 0x0600049D RID: 1181
		void RecalculateClipping();

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600049E RID: 1182
		RectTransform rectTransform { get; }

		// Token: 0x0600049F RID: 1183
		void Cull(Rect clipRect, bool validRect);

		// Token: 0x060004A0 RID: 1184
		void SetClipRect(Rect value, bool validRect);
	}
}
