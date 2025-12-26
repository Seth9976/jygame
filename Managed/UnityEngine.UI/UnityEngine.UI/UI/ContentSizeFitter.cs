using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000089 RID: 137
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("Layout/Content Size Fitter", 141)]
	public class ContentSizeFitter : UIBehaviour, ILayoutController, ILayoutSelfController
	{
		// Token: 0x060004D1 RID: 1233 RVA: 0x00015F94 File Offset: 0x00014194
		protected ContentSizeFitter()
		{
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00015F9C File Offset: 0x0001419C
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00015FA4 File Offset: 0x000141A4
		public ContentSizeFitter.FitMode horizontalFit
		{
			get
			{
				return this.m_HorizontalFit;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<ContentSizeFitter.FitMode>(ref this.m_HorizontalFit, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00015FC0 File Offset: 0x000141C0
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00015FC8 File Offset: 0x000141C8
		public ContentSizeFitter.FitMode verticalFit
		{
			get
			{
				return this.m_VerticalFit;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<ContentSizeFitter.FitMode>(ref this.m_VerticalFit, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00015FE4 File Offset: 0x000141E4
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

		// Token: 0x060004D7 RID: 1239 RVA: 0x0001600C File Offset: 0x0001420C
		protected override void OnEnable()
		{
			base.OnEnable();
			this.SetDirty();
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0001601C File Offset: 0x0001421C
		protected override void OnDisable()
		{
			this.m_Tracker.Clear();
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0001603C File Offset: 0x0001423C
		protected override void OnRectTransformDimensionsChange()
		{
			this.SetDirty();
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00016044 File Offset: 0x00014244
		private void HandleSelfFittingAlongAxis(int axis)
		{
			ContentSizeFitter.FitMode fitMode = ((axis != 0) ? this.verticalFit : this.horizontalFit);
			if (fitMode == ContentSizeFitter.FitMode.Unconstrained)
			{
				return;
			}
			this.m_Tracker.Add(this, this.rectTransform, (axis != 0) ? DrivenTransformProperties.SizeDeltaY : DrivenTransformProperties.SizeDeltaX);
			if (fitMode == ContentSizeFitter.FitMode.MinSize)
			{
				this.rectTransform.SetSizeWithCurrentAnchors((RectTransform.Axis)axis, LayoutUtility.GetMinSize(this.m_Rect, axis));
			}
			else
			{
				this.rectTransform.SetSizeWithCurrentAnchors((RectTransform.Axis)axis, LayoutUtility.GetPreferredSize(this.m_Rect, axis));
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000160D4 File Offset: 0x000142D4
		public virtual void SetLayoutHorizontal()
		{
			this.m_Tracker.Clear();
			this.HandleSelfFittingAlongAxis(0);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000160E8 File Offset: 0x000142E8
		public virtual void SetLayoutVertical()
		{
			this.HandleSelfFittingAlongAxis(1);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x000160F4 File Offset: 0x000142F4
		protected void SetDirty()
		{
			if (!this.IsActive())
			{
				return;
			}
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
		}

		// Token: 0x04000261 RID: 609
		[SerializeField]
		protected ContentSizeFitter.FitMode m_HorizontalFit;

		// Token: 0x04000262 RID: 610
		[SerializeField]
		protected ContentSizeFitter.FitMode m_VerticalFit;

		// Token: 0x04000263 RID: 611
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x04000264 RID: 612
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x0200008A RID: 138
		public enum FitMode
		{
			// Token: 0x04000266 RID: 614
			Unconstrained,
			// Token: 0x04000267 RID: 615
			MinSize,
			// Token: 0x04000268 RID: 616
			PreferredSize
		}
	}
}
