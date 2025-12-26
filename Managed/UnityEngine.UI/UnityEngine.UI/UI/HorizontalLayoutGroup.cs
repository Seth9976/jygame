using System;

namespace UnityEngine.UI
{
	// Token: 0x0200008F RID: 143
	[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
	public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
	{
		// Token: 0x060004F0 RID: 1264 RVA: 0x00016870 File Offset: 0x00014A70
		protected HorizontalLayoutGroup()
		{
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00016878 File Offset: 0x00014A78
		public override void CalculateLayoutInputHorizontal()
		{
			base.CalculateLayoutInputHorizontal();
			base.CalcAlongAxis(0, false);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00016888 File Offset: 0x00014A88
		public override void CalculateLayoutInputVertical()
		{
			base.CalcAlongAxis(1, false);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00016894 File Offset: 0x00014A94
		public override void SetLayoutHorizontal()
		{
			base.SetChildrenAlongAxis(0, false);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000168A0 File Offset: 0x00014AA0
		public override void SetLayoutVertical()
		{
			base.SetChildrenAlongAxis(1, false);
		}
	}
}
