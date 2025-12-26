using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000083 RID: 131
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
	[ExecuteInEditMode]
	public class AspectRatioFitter : UIBehaviour, ILayoutController, ILayoutSelfController
	{
		// Token: 0x060004A3 RID: 1187 RVA: 0x00015830 File Offset: 0x00013A30
		protected AspectRatioFitter()
		{
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00015844 File Offset: 0x00013A44
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x0001584C File Offset: 0x00013A4C
		public AspectRatioFitter.AspectMode aspectMode
		{
			get
			{
				return this.m_AspectMode;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<AspectRatioFitter.AspectMode>(ref this.m_AspectMode, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00015868 File Offset: 0x00013A68
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00015870 File Offset: 0x00013A70
		public float aspectRatio
		{
			get
			{
				return this.m_AspectRatio;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_AspectRatio, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0001588C File Offset: 0x00013A8C
		private RectTransform rectTransform
		{
			get
			{
				if (this.m_Rect == null)
				{
					this.m_Rect = base.GetComponent<RectTransform>();
				}
				return this.m_Rect;
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000158B4 File Offset: 0x00013AB4
		protected override void OnEnable()
		{
			base.OnEnable();
			this.SetDirty();
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000158C4 File Offset: 0x00013AC4
		protected override void OnDisable()
		{
			this.m_Tracker.Clear();
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000158E4 File Offset: 0x00013AE4
		protected override void OnRectTransformDimensionsChange()
		{
			this.UpdateRect();
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000158EC File Offset: 0x00013AEC
		private void UpdateRect()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.m_Tracker.Clear();
			switch (this.m_AspectMode)
			{
			case AspectRatioFitter.AspectMode.WidthControlsHeight:
				this.m_Tracker.Add(this, this.rectTransform, DrivenTransformProperties.SizeDeltaY);
				this.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.rectTransform.rect.width / this.m_AspectRatio);
				break;
			case AspectRatioFitter.AspectMode.HeightControlsWidth:
				this.m_Tracker.Add(this, this.rectTransform, DrivenTransformProperties.SizeDeltaX);
				this.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.rectTransform.rect.height * this.m_AspectRatio);
				break;
			case AspectRatioFitter.AspectMode.FitInParent:
			case AspectRatioFitter.AspectMode.EnvelopeParent:
			{
				this.m_Tracker.Add(this, this.rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchorMinX | DrivenTransformProperties.AnchorMinY | DrivenTransformProperties.AnchorMaxX | DrivenTransformProperties.AnchorMaxY | DrivenTransformProperties.SizeDeltaX | DrivenTransformProperties.SizeDeltaY);
				this.rectTransform.anchorMin = Vector2.zero;
				this.rectTransform.anchorMax = Vector2.one;
				this.rectTransform.anchoredPosition = Vector2.zero;
				Vector2 zero = Vector2.zero;
				Vector2 parentSize = this.GetParentSize();
				if ((parentSize.y * this.aspectRatio < parentSize.x) ^ (this.m_AspectMode == AspectRatioFitter.AspectMode.FitInParent))
				{
					zero.y = this.GetSizeDeltaToProduceSize(parentSize.x / this.aspectRatio, 1);
				}
				else
				{
					zero.x = this.GetSizeDeltaToProduceSize(parentSize.y * this.aspectRatio, 0);
				}
				this.rectTransform.sizeDelta = zero;
				break;
			}
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00015A84 File Offset: 0x00013C84
		private float GetSizeDeltaToProduceSize(float size, int axis)
		{
			return size - this.GetParentSize()[axis] * (this.rectTransform.anchorMax[axis] - this.rectTransform.anchorMin[axis]);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00015ACC File Offset: 0x00013CCC
		private Vector2 GetParentSize()
		{
			RectTransform rectTransform = this.rectTransform.parent as RectTransform;
			if (!rectTransform)
			{
				return Vector2.zero;
			}
			return rectTransform.rect.size;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00015B0C File Offset: 0x00013D0C
		public virtual void SetLayoutHorizontal()
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00015B10 File Offset: 0x00013D10
		public virtual void SetLayoutVertical()
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00015B14 File Offset: 0x00013D14
		protected void SetDirty()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.UpdateRect();
		}

		// Token: 0x0400023B RID: 571
		[SerializeField]
		private AspectRatioFitter.AspectMode m_AspectMode;

		// Token: 0x0400023C RID: 572
		[SerializeField]
		private float m_AspectRatio = 1f;

		// Token: 0x0400023D RID: 573
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x0400023E RID: 574
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x02000084 RID: 132
		public enum AspectMode
		{
			// Token: 0x04000240 RID: 576
			None,
			// Token: 0x04000241 RID: 577
			WidthControlsHeight,
			// Token: 0x04000242 RID: 578
			HeightControlsWidth,
			// Token: 0x04000243 RID: 579
			FitInParent,
			// Token: 0x04000244 RID: 580
			EnvelopeParent
		}
	}
}
