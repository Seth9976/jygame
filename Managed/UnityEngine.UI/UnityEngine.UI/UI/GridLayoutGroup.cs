using System;

namespace UnityEngine.UI
{
	// Token: 0x0200008B RID: 139
	[AddComponentMenu("Layout/Grid Layout Group", 152)]
	public class GridLayoutGroup : LayoutGroup
	{
		// Token: 0x060004DE RID: 1246 RVA: 0x00016110 File Offset: 0x00014310
		protected GridLayoutGroup()
		{
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00016140 File Offset: 0x00014340
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00016148 File Offset: 0x00014348
		public GridLayoutGroup.Corner startCorner
		{
			get
			{
				return this.m_StartCorner;
			}
			set
			{
				base.SetProperty<GridLayoutGroup.Corner>(ref this.m_StartCorner, value);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00016158 File Offset: 0x00014358
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00016160 File Offset: 0x00014360
		public GridLayoutGroup.Axis startAxis
		{
			get
			{
				return this.m_StartAxis;
			}
			set
			{
				base.SetProperty<GridLayoutGroup.Axis>(ref this.m_StartAxis, value);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00016170 File Offset: 0x00014370
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00016178 File Offset: 0x00014378
		public Vector2 cellSize
		{
			get
			{
				return this.m_CellSize;
			}
			set
			{
				base.SetProperty<Vector2>(ref this.m_CellSize, value);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00016188 File Offset: 0x00014388
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00016190 File Offset: 0x00014390
		public Vector2 spacing
		{
			get
			{
				return this.m_Spacing;
			}
			set
			{
				base.SetProperty<Vector2>(ref this.m_Spacing, value);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x000161A0 File Offset: 0x000143A0
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x000161A8 File Offset: 0x000143A8
		public GridLayoutGroup.Constraint constraint
		{
			get
			{
				return this.m_Constraint;
			}
			set
			{
				base.SetProperty<GridLayoutGroup.Constraint>(ref this.m_Constraint, value);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x000161B8 File Offset: 0x000143B8
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x000161C0 File Offset: 0x000143C0
		public int constraintCount
		{
			get
			{
				return this.m_ConstraintCount;
			}
			set
			{
				base.SetProperty<int>(ref this.m_ConstraintCount, Mathf.Max(1, value));
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x000161D8 File Offset: 0x000143D8
		public override void CalculateLayoutInputHorizontal()
		{
			base.CalculateLayoutInputHorizontal();
			int num2;
			int num;
			if (this.m_Constraint == GridLayoutGroup.Constraint.FixedColumnCount)
			{
				num = (num2 = this.m_ConstraintCount);
			}
			else if (this.m_Constraint == GridLayoutGroup.Constraint.FixedRowCount)
			{
				num = (num2 = Mathf.CeilToInt((float)base.rectChildren.Count / (float)this.m_ConstraintCount - 0.001f));
			}
			else
			{
				num2 = 1;
				num = Mathf.CeilToInt(Mathf.Sqrt((float)base.rectChildren.Count));
			}
			base.SetLayoutInputForAxis((float)base.padding.horizontal + (this.cellSize.x + this.spacing.x) * (float)num2 - this.spacing.x, (float)base.padding.horizontal + (this.cellSize.x + this.spacing.x) * (float)num - this.spacing.x, -1f, 0);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000162E0 File Offset: 0x000144E0
		public override void CalculateLayoutInputVertical()
		{
			int num;
			if (this.m_Constraint == GridLayoutGroup.Constraint.FixedColumnCount)
			{
				num = Mathf.CeilToInt((float)base.rectChildren.Count / (float)this.m_ConstraintCount - 0.001f);
			}
			else if (this.m_Constraint == GridLayoutGroup.Constraint.FixedRowCount)
			{
				num = this.m_ConstraintCount;
			}
			else
			{
				float x = base.rectTransform.rect.size.x;
				int num2 = Mathf.Max(1, Mathf.FloorToInt((x - (float)base.padding.horizontal + this.spacing.x + 0.001f) / (this.cellSize.x + this.spacing.x)));
				num = Mathf.CeilToInt((float)base.rectChildren.Count / (float)num2);
			}
			float num3 = (float)base.padding.vertical + (this.cellSize.y + this.spacing.y) * (float)num - this.spacing.y;
			base.SetLayoutInputForAxis(num3, num3, -1f, 1);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0001640C File Offset: 0x0001460C
		public override void SetLayoutHorizontal()
		{
			this.SetCellsAlongAxis(0);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00016418 File Offset: 0x00014618
		public override void SetLayoutVertical()
		{
			this.SetCellsAlongAxis(1);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00016424 File Offset: 0x00014624
		private void SetCellsAlongAxis(int axis)
		{
			if (axis == 0)
			{
				for (int i = 0; i < base.rectChildren.Count; i++)
				{
					RectTransform rectTransform = base.rectChildren[i];
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchorMinX | DrivenTransformProperties.AnchorMinY | DrivenTransformProperties.AnchorMaxX | DrivenTransformProperties.AnchorMaxY | DrivenTransformProperties.SizeDeltaX | DrivenTransformProperties.SizeDeltaY);
					rectTransform.anchorMin = Vector2.up;
					rectTransform.anchorMax = Vector2.up;
					rectTransform.sizeDelta = this.cellSize;
				}
				return;
			}
			float x = base.rectTransform.rect.size.x;
			float y = base.rectTransform.rect.size.y;
			int num;
			int num2;
			if (this.m_Constraint == GridLayoutGroup.Constraint.FixedColumnCount)
			{
				num = this.m_ConstraintCount;
				num2 = Mathf.CeilToInt((float)base.rectChildren.Count / (float)num - 0.001f);
			}
			else if (this.m_Constraint == GridLayoutGroup.Constraint.FixedRowCount)
			{
				num2 = this.m_ConstraintCount;
				num = Mathf.CeilToInt((float)base.rectChildren.Count / (float)num2 - 0.001f);
			}
			else
			{
				if (this.cellSize.x + this.spacing.x <= 0f)
				{
					num = int.MaxValue;
				}
				else
				{
					num = Mathf.Max(1, Mathf.FloorToInt((x - (float)base.padding.horizontal + this.spacing.x + 0.001f) / (this.cellSize.x + this.spacing.x)));
				}
				if (this.cellSize.y + this.spacing.y <= 0f)
				{
					num2 = int.MaxValue;
				}
				else
				{
					num2 = Mathf.Max(1, Mathf.FloorToInt((y - (float)base.padding.vertical + this.spacing.y + 0.001f) / (this.cellSize.y + this.spacing.y)));
				}
			}
			int num3 = (int)(this.startCorner % GridLayoutGroup.Corner.LowerLeft);
			int num4 = (int)(this.startCorner / GridLayoutGroup.Corner.LowerLeft);
			int num5;
			int num6;
			int num7;
			if (this.startAxis == GridLayoutGroup.Axis.Horizontal)
			{
				num5 = num;
				num6 = Mathf.Clamp(num, 1, base.rectChildren.Count);
				num7 = Mathf.Clamp(num2, 1, Mathf.CeilToInt((float)base.rectChildren.Count / (float)num5));
			}
			else
			{
				num5 = num2;
				num7 = Mathf.Clamp(num2, 1, base.rectChildren.Count);
				num6 = Mathf.Clamp(num, 1, Mathf.CeilToInt((float)base.rectChildren.Count / (float)num5));
			}
			Vector2 vector = new Vector2((float)num6 * this.cellSize.x + (float)(num6 - 1) * this.spacing.x, (float)num7 * this.cellSize.y + (float)(num7 - 1) * this.spacing.y);
			Vector2 vector2 = new Vector2(base.GetStartOffset(0, vector.x), base.GetStartOffset(1, vector.y));
			for (int j = 0; j < base.rectChildren.Count; j++)
			{
				int num8;
				int num9;
				if (this.startAxis == GridLayoutGroup.Axis.Horizontal)
				{
					num8 = j % num5;
					num9 = j / num5;
				}
				else
				{
					num8 = j / num5;
					num9 = j % num5;
				}
				if (num3 == 1)
				{
					num8 = num6 - 1 - num8;
				}
				if (num4 == 1)
				{
					num9 = num7 - 1 - num9;
				}
				base.SetChildAlongAxis(base.rectChildren[j], 0, vector2.x + (this.cellSize[0] + this.spacing[0]) * (float)num8, this.cellSize[0]);
				base.SetChildAlongAxis(base.rectChildren[j], 1, vector2.y + (this.cellSize[1] + this.spacing[1]) * (float)num9, this.cellSize[1]);
			}
		}

		// Token: 0x04000269 RID: 617
		[SerializeField]
		protected GridLayoutGroup.Corner m_StartCorner;

		// Token: 0x0400026A RID: 618
		[SerializeField]
		protected GridLayoutGroup.Axis m_StartAxis;

		// Token: 0x0400026B RID: 619
		[SerializeField]
		protected Vector2 m_CellSize = new Vector2(100f, 100f);

		// Token: 0x0400026C RID: 620
		[SerializeField]
		protected Vector2 m_Spacing = Vector2.zero;

		// Token: 0x0400026D RID: 621
		[SerializeField]
		protected GridLayoutGroup.Constraint m_Constraint;

		// Token: 0x0400026E RID: 622
		[SerializeField]
		protected int m_ConstraintCount = 2;

		// Token: 0x0200008C RID: 140
		public enum Corner
		{
			// Token: 0x04000270 RID: 624
			UpperLeft,
			// Token: 0x04000271 RID: 625
			UpperRight,
			// Token: 0x04000272 RID: 626
			LowerLeft,
			// Token: 0x04000273 RID: 627
			LowerRight
		}

		// Token: 0x0200008D RID: 141
		public enum Axis
		{
			// Token: 0x04000275 RID: 629
			Horizontal,
			// Token: 0x04000276 RID: 630
			Vertical
		}

		// Token: 0x0200008E RID: 142
		public enum Constraint
		{
			// Token: 0x04000278 RID: 632
			Flexible,
			// Token: 0x04000279 RID: 633
			FixedColumnCount,
			// Token: 0x0400027A RID: 634
			FixedRowCount
		}
	}
}
