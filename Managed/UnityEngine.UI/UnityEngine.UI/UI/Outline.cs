using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x020000A4 RID: 164
	[AddComponentMenu("UI/Effects/Outline", 15)]
	public class Outline : Shadow
	{
		// Token: 0x060005B0 RID: 1456 RVA: 0x00018734 File Offset: 0x00016934
		protected Outline()
		{
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0001873C File Offset: 0x0001693C
		public override void ModifyMesh(VertexHelper vh)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = ListPool<UIVertex>.Get();
			vh.GetUIVertexStream(list);
			int num = list.Count * 5;
			if (list.Capacity < num)
			{
				list.Capacity = num;
			}
			int num2 = 0;
			int num3 = list.Count;
			base.ApplyShadowZeroAlloc(list, base.effectColor, num2, list.Count, base.effectDistance.x, base.effectDistance.y);
			num2 = num3;
			num3 = list.Count;
			base.ApplyShadowZeroAlloc(list, base.effectColor, num2, list.Count, base.effectDistance.x, -base.effectDistance.y);
			num2 = num3;
			num3 = list.Count;
			base.ApplyShadowZeroAlloc(list, base.effectColor, num2, list.Count, -base.effectDistance.x, base.effectDistance.y);
			num2 = num3;
			num3 = list.Count;
			base.ApplyShadowZeroAlloc(list, base.effectColor, num2, list.Count, -base.effectDistance.x, -base.effectDistance.y);
			vh.Clear();
			vh.AddUIVertexTriangleStream(list);
			ListPool<UIVertex>.Release(list);
		}
	}
}
