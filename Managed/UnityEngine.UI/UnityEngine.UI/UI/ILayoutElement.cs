using System;

namespace UnityEngine.UI
{
	// Token: 0x02000091 RID: 145
	public interface ILayoutElement
	{
		// Token: 0x060004FE RID: 1278
		void CalculateLayoutInputHorizontal();

		// Token: 0x060004FF RID: 1279
		void CalculateLayoutInputVertical();

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000500 RID: 1280
		float minWidth { get; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000501 RID: 1281
		float preferredWidth { get; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000502 RID: 1282
		float flexibleWidth { get; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000503 RID: 1283
		float minHeight { get; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000504 RID: 1284
		float preferredHeight { get; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000505 RID: 1285
		float flexibleHeight { get; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000506 RID: 1286
		int layoutPriority { get; }
	}
}
