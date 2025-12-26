using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000097 RID: 151
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutController, ILayoutGroup
	{
		// Token: 0x06000522 RID: 1314 RVA: 0x00016EA0 File Offset: 0x000150A0
		protected LayoutGroup()
		{
			if (this.m_Padding == null)
			{
				this.m_Padding = new RectOffset();
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00016F00 File Offset: 0x00015100
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00016F08 File Offset: 0x00015108
		public RectOffset padding
		{
			get
			{
				return this.m_Padding;
			}
			set
			{
				this.SetProperty<RectOffset>(ref this.m_Padding, value);
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00016F18 File Offset: 0x00015118
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00016F20 File Offset: 0x00015120
		public TextAnchor childAlignment
		{
			get
			{
				return this.m_ChildAlignment;
			}
			set
			{
				this.SetProperty<TextAnchor>(ref this.m_ChildAlignment, value);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00016F30 File Offset: 0x00015130
		protected RectTransform rectTransform
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

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00016F58 File Offset: 0x00015158
		protected List<RectTransform> rectChildren
		{
			get
			{
				return this.m_RectChildren;
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00016F60 File Offset: 0x00015160
		public virtual void CalculateLayoutInputHorizontal()
		{
			this.m_RectChildren.Clear();
			List<Component> list = ListPool<Component>.Get();
			for (int i = 0; i < this.rectTransform.childCount; i++)
			{
				RectTransform rectTransform = this.rectTransform.GetChild(i) as RectTransform;
				if (!(rectTransform == null) && rectTransform.gameObject.activeInHierarchy)
				{
					rectTransform.GetComponents(typeof(ILayoutIgnorer), list);
					if (list.Count == 0)
					{
						this.m_RectChildren.Add(rectTransform);
					}
					else
					{
						for (int j = 0; j < list.Count; j++)
						{
							ILayoutIgnorer layoutIgnorer = (ILayoutIgnorer)list[j];
							if (!layoutIgnorer.ignoreLayout)
							{
								this.m_RectChildren.Add(rectTransform);
								break;
							}
						}
					}
				}
			}
			ListPool<Component>.Release(list);
			this.m_Tracker.Clear();
		}

		// Token: 0x0600052A RID: 1322
		public abstract void CalculateLayoutInputVertical();

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00017050 File Offset: 0x00015250
		public virtual float minWidth
		{
			get
			{
				return this.GetTotalMinSize(0);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0001705C File Offset: 0x0001525C
		public virtual float preferredWidth
		{
			get
			{
				return this.GetTotalPreferredSize(0);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00017068 File Offset: 0x00015268
		public virtual float flexibleWidth
		{
			get
			{
				return this.GetTotalFlexibleSize(0);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00017074 File Offset: 0x00015274
		public virtual float minHeight
		{
			get
			{
				return this.GetTotalMinSize(1);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00017080 File Offset: 0x00015280
		public virtual float preferredHeight
		{
			get
			{
				return this.GetTotalPreferredSize(1);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0001708C File Offset: 0x0001528C
		public virtual float flexibleHeight
		{
			get
			{
				return this.GetTotalFlexibleSize(1);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00017098 File Offset: 0x00015298
		public virtual int layoutPriority
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000532 RID: 1330
		public abstract void SetLayoutHorizontal();

		// Token: 0x06000533 RID: 1331
		public abstract void SetLayoutVertical();

		// Token: 0x06000534 RID: 1332 RVA: 0x0001709C File Offset: 0x0001529C
		protected override void OnEnable()
		{
			base.OnEnable();
			this.SetDirty();
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000170AC File Offset: 0x000152AC
		protected override void OnDisable()
		{
			this.m_Tracker.Clear();
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000170CC File Offset: 0x000152CC
		protected override void OnDidApplyAnimationProperties()
		{
			this.SetDirty();
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000170D4 File Offset: 0x000152D4
		protected float GetTotalMinSize(int axis)
		{
			return this.m_TotalMinSize[axis];
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000170E4 File Offset: 0x000152E4
		protected float GetTotalPreferredSize(int axis)
		{
			return this.m_TotalPreferredSize[axis];
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x000170F4 File Offset: 0x000152F4
		protected float GetTotalFlexibleSize(int axis)
		{
			return this.m_TotalFlexibleSize[axis];
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00017104 File Offset: 0x00015304
		protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding)
		{
			float num = requiredSpaceWithoutPadding + (float)((axis != 0) ? this.padding.vertical : this.padding.horizontal);
			float num2 = this.rectTransform.rect.size[axis];
			float num3 = num2 - num;
			float num4;
			if (axis == 0)
			{
				num4 = (float)(this.childAlignment % TextAnchor.MiddleLeft) * 0.5f;
			}
			else
			{
				num4 = (float)(this.childAlignment / TextAnchor.MiddleLeft) * 0.5f;
			}
			return (float)((axis != 0) ? this.padding.top : this.padding.left) + num3 * num4;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000171B0 File Offset: 0x000153B0
		protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis)
		{
			this.m_TotalMinSize[axis] = totalMin;
			this.m_TotalPreferredSize[axis] = totalPreferred;
			this.m_TotalFlexibleSize[axis] = totalFlexible;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000171E8 File Offset: 0x000153E8
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size)
		{
			if (rect == null)
			{
				return;
			}
			this.m_Tracker.Add(this, rect, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchorMinX | DrivenTransformProperties.AnchorMinY | DrivenTransformProperties.AnchorMaxX | DrivenTransformProperties.AnchorMaxY | DrivenTransformProperties.SizeDeltaX | DrivenTransformProperties.SizeDeltaY);
			rect.SetInsetAndSizeFromParentEdge((axis != 0) ? RectTransform.Edge.Top : RectTransform.Edge.Left, pos, size);
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0001722C File Offset: 0x0001542C
		private bool isRootLayoutGroup
		{
			get
			{
				Transform parent = base.transform.parent;
				return parent == null || base.transform.parent.GetComponent(typeof(ILayoutGroup)) == null;
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00017274 File Offset: 0x00015474
		protected override void OnRectTransformDimensionsChange()
		{
			base.OnRectTransformDimensionsChange();
			if (this.isRootLayoutGroup)
			{
				this.SetDirty();
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00017290 File Offset: 0x00015490
		protected virtual void OnTransformChildrenChanged()
		{
			this.SetDirty();
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00017298 File Offset: 0x00015498
		protected void SetProperty<T>(ref T currentValue, T newValue)
		{
			if ((currentValue == null && newValue == null) || (currentValue != null && currentValue.Equals(newValue)))
			{
				return;
			}
			currentValue = newValue;
			this.SetDirty();
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000172F8 File Offset: 0x000154F8
		protected void SetDirty()
		{
			if (!this.IsActive())
			{
				return;
			}
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
		}

		// Token: 0x04000285 RID: 645
		[SerializeField]
		protected RectOffset m_Padding = new RectOffset();

		// Token: 0x04000286 RID: 646
		[FormerlySerializedAs("m_Alignment")]
		[SerializeField]
		protected TextAnchor m_ChildAlignment;

		// Token: 0x04000287 RID: 647
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x04000288 RID: 648
		protected DrivenRectTransformTracker m_Tracker;

		// Token: 0x04000289 RID: 649
		private Vector2 m_TotalMinSize = Vector2.zero;

		// Token: 0x0400028A RID: 650
		private Vector2 m_TotalPreferredSize = Vector2.zero;

		// Token: 0x0400028B RID: 651
		private Vector2 m_TotalFlexibleSize = Vector2.zero;

		// Token: 0x0400028C RID: 652
		[NonSerialized]
		private List<RectTransform> m_RectChildren = new List<RectTransform>();
	}
}
