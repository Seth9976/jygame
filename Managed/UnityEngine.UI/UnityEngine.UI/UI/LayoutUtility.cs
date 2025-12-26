using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000099 RID: 153
	public static class LayoutUtility
	{
		// Token: 0x0600055D RID: 1373 RVA: 0x00017828 File Offset: 0x00015A28
		public static float GetMinSize(RectTransform rect, int axis)
		{
			if (axis == 0)
			{
				return LayoutUtility.GetMinWidth(rect);
			}
			return LayoutUtility.GetMinHeight(rect);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00017840 File Offset: 0x00015A40
		public static float GetPreferredSize(RectTransform rect, int axis)
		{
			if (axis == 0)
			{
				return LayoutUtility.GetPreferredWidth(rect);
			}
			return LayoutUtility.GetPreferredHeight(rect);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00017858 File Offset: 0x00015A58
		public static float GetFlexibleSize(RectTransform rect, int axis)
		{
			if (axis == 0)
			{
				return LayoutUtility.GetFlexibleWidth(rect);
			}
			return LayoutUtility.GetFlexibleHeight(rect);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00017870 File Offset: 0x00015A70
		public static float GetMinWidth(RectTransform rect)
		{
			return LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.minWidth, 0f);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000178A8 File Offset: 0x00015AA8
		public static float GetPreferredWidth(RectTransform rect)
		{
			return Mathf.Max(LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.minWidth, 0f), LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.preferredWidth, 0f));
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0001790C File Offset: 0x00015B0C
		public static float GetFlexibleWidth(RectTransform rect)
		{
			return LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.flexibleWidth, 0f);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00017944 File Offset: 0x00015B44
		public static float GetMinHeight(RectTransform rect)
		{
			return LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.minHeight, 0f);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0001797C File Offset: 0x00015B7C
		public static float GetPreferredHeight(RectTransform rect)
		{
			return Mathf.Max(LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.minHeight, 0f), LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.preferredHeight, 0f));
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000179E0 File Offset: 0x00015BE0
		public static float GetFlexibleHeight(RectTransform rect)
		{
			return LayoutUtility.GetLayoutProperty(rect, (ILayoutElement e) => e.flexibleHeight, 0f);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00017A18 File Offset: 0x00015C18
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue)
		{
			ILayoutElement layoutElement;
			return LayoutUtility.GetLayoutProperty(rect, property, defaultValue, out layoutElement);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00017A30 File Offset: 0x00015C30
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source)
		{
			source = null;
			if (rect == null)
			{
				return 0f;
			}
			float num = defaultValue;
			int num2 = int.MinValue;
			List<Component> list = ListPool<Component>.Get();
			rect.GetComponents(typeof(ILayoutElement), list);
			for (int i = 0; i < list.Count; i++)
			{
				ILayoutElement layoutElement = list[i] as ILayoutElement;
				if (!(layoutElement is Behaviour) || ((Behaviour)layoutElement).isActiveAndEnabled)
				{
					int layoutPriority = layoutElement.layoutPriority;
					if (layoutPriority >= num2)
					{
						float num3 = property(layoutElement);
						if (num3 >= 0f)
						{
							if (layoutPriority > num2)
							{
								num = num3;
								num2 = layoutPriority;
								source = layoutElement;
							}
							else if (num3 > num)
							{
								num = num3;
								source = layoutElement;
							}
						}
					}
				}
			}
			ListPool<Component>.Release(list);
			return num;
		}
	}
}
