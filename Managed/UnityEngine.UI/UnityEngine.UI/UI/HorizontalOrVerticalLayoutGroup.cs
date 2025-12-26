using System;

namespace UnityEngine.UI
{
	// Token: 0x02000090 RID: 144
	public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x000168C4 File Offset: 0x00014AC4
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x000168CC File Offset: 0x00014ACC
		public float spacing
		{
			get
			{
				return this.m_Spacing;
			}
			set
			{
				base.SetProperty<float>(ref this.m_Spacing, value);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x000168DC File Offset: 0x00014ADC
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x000168E4 File Offset: 0x00014AE4
		public bool childForceExpandWidth
		{
			get
			{
				return this.m_ChildForceExpandWidth;
			}
			set
			{
				base.SetProperty<bool>(ref this.m_ChildForceExpandWidth, value);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x000168F4 File Offset: 0x00014AF4
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x000168FC File Offset: 0x00014AFC
		public bool childForceExpandHeight
		{
			get
			{
				return this.m_ChildForceExpandHeight;
			}
			set
			{
				base.SetProperty<bool>(ref this.m_ChildForceExpandHeight, value);
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001690C File Offset: 0x00014B0C
		protected void CalcAlongAxis(int axis, bool isVertical)
		{
			float num = (float)((axis != 0) ? base.padding.vertical : base.padding.horizontal);
			float num2 = num;
			float num3 = num;
			float num4 = 0f;
			bool flag = isVertical ^ (axis == 1);
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				RectTransform rectTransform = base.rectChildren[i];
				float minSize = LayoutUtility.GetMinSize(rectTransform, axis);
				float preferredSize = LayoutUtility.GetPreferredSize(rectTransform, axis);
				float num5 = LayoutUtility.GetFlexibleSize(rectTransform, axis);
				if ((axis != 0) ? this.childForceExpandHeight : this.childForceExpandWidth)
				{
					num5 = Mathf.Max(num5, 1f);
				}
				if (flag)
				{
					num2 = Mathf.Max(minSize + num, num2);
					num3 = Mathf.Max(preferredSize + num, num3);
					num4 = Mathf.Max(num5, num4);
				}
				else
				{
					num2 += minSize + this.spacing;
					num3 += preferredSize + this.spacing;
					num4 += num5;
				}
			}
			if (!flag && base.rectChildren.Count > 0)
			{
				num2 -= this.spacing;
				num3 -= this.spacing;
			}
			num3 = Mathf.Max(num2, num3);
			base.SetLayoutInputForAxis(num2, num3, num4, axis);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00016A4C File Offset: 0x00014C4C
		protected void SetChildrenAlongAxis(int axis, bool isVertical)
		{
			float num = base.rectTransform.rect.size[axis];
			bool flag = isVertical ^ (axis == 1);
			if (flag)
			{
				float num2 = num - (float)((axis != 0) ? base.padding.vertical : base.padding.horizontal);
				for (int i = 0; i < base.rectChildren.Count; i++)
				{
					RectTransform rectTransform = base.rectChildren[i];
					float minSize = LayoutUtility.GetMinSize(rectTransform, axis);
					float preferredSize = LayoutUtility.GetPreferredSize(rectTransform, axis);
					float num3 = LayoutUtility.GetFlexibleSize(rectTransform, axis);
					if ((axis != 0) ? this.childForceExpandHeight : this.childForceExpandWidth)
					{
						num3 = Mathf.Max(num3, 1f);
					}
					float num4 = Mathf.Clamp(num2, minSize, (num3 <= 0f) ? preferredSize : num);
					float startOffset = base.GetStartOffset(axis, num4);
					base.SetChildAlongAxis(rectTransform, axis, startOffset, num4);
				}
			}
			else
			{
				float num5 = (float)((axis != 0) ? base.padding.top : base.padding.left);
				if (base.GetTotalFlexibleSize(axis) == 0f && base.GetTotalPreferredSize(axis) < num)
				{
					num5 = base.GetStartOffset(axis, base.GetTotalPreferredSize(axis) - (float)((axis != 0) ? base.padding.vertical : base.padding.horizontal));
				}
				float num6 = 0f;
				if (base.GetTotalMinSize(axis) != base.GetTotalPreferredSize(axis))
				{
					num6 = Mathf.Clamp01((num - base.GetTotalMinSize(axis)) / (base.GetTotalPreferredSize(axis) - base.GetTotalMinSize(axis)));
				}
				float num7 = 0f;
				if (num > base.GetTotalPreferredSize(axis) && base.GetTotalFlexibleSize(axis) > 0f)
				{
					num7 = (num - base.GetTotalPreferredSize(axis)) / base.GetTotalFlexibleSize(axis);
				}
				for (int j = 0; j < base.rectChildren.Count; j++)
				{
					RectTransform rectTransform2 = base.rectChildren[j];
					float minSize2 = LayoutUtility.GetMinSize(rectTransform2, axis);
					float preferredSize2 = LayoutUtility.GetPreferredSize(rectTransform2, axis);
					float num8 = LayoutUtility.GetFlexibleSize(rectTransform2, axis);
					if ((axis != 0) ? this.childForceExpandHeight : this.childForceExpandWidth)
					{
						num8 = Mathf.Max(num8, 1f);
					}
					float num9 = Mathf.Lerp(minSize2, preferredSize2, num6);
					num9 += num8 * num7;
					base.SetChildAlongAxis(rectTransform2, axis, num5, num9);
					num5 += num9 + this.spacing;
				}
			}
		}

		// Token: 0x0400027B RID: 635
		[SerializeField]
		protected float m_Spacing;

		// Token: 0x0400027C RID: 636
		[SerializeField]
		protected bool m_ChildForceExpandWidth = true;

		// Token: 0x0400027D RID: 637
		[SerializeField]
		protected bool m_ChildForceExpandHeight = true;
	}
}
