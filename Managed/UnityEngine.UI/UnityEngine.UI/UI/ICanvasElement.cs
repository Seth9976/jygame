using System;

namespace UnityEngine.UI
{
	// Token: 0x0200003A RID: 58
	public interface ICanvasElement
	{
		// Token: 0x06000169 RID: 361
		void Rebuild(CanvasUpdate executing);

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600016A RID: 362
		Transform transform { get; }

		// Token: 0x0600016B RID: 363
		void LayoutComplete();

		// Token: 0x0600016C RID: 364
		void GraphicUpdateComplete();

		// Token: 0x0600016D RID: 365
		bool IsDestroyed();
	}
}
