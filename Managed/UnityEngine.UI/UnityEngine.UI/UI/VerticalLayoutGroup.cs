using System;

namespace UnityEngine.UI
{
	// Token: 0x0200009A RID: 154
	[AddComponentMenu("Layout/Vertical Layout Group", 151)]
	public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
	{
		// Token: 0x06000570 RID: 1392 RVA: 0x00017B58 File Offset: 0x00015D58
		protected VerticalLayoutGroup()
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00017B60 File Offset: 0x00015D60
		public override void CalculateLayoutInputHorizontal()
		{
			base.CalculateLayoutInputHorizontal();
			base.CalcAlongAxis(0, true);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00017B70 File Offset: 0x00015D70
		public override void CalculateLayoutInputVertical()
		{
			base.CalcAlongAxis(1, true);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00017B7C File Offset: 0x00015D7C
		public override void SetLayoutHorizontal()
		{
			base.SetChildrenAlongAxis(0, true);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00017B88 File Offset: 0x00015D88
		public override void SetLayoutVertical()
		{
			base.SetChildrenAlongAxis(1, true);
		}
	}
}
