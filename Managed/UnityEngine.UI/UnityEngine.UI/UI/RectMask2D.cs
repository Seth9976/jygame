using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000065 RID: 101
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/2D Rect Mask", 13)]
	public class RectMask2D : UIBehaviour, ICanvasRaycastFilter, IClipper
	{
		// Token: 0x06000339 RID: 825 RVA: 0x0000FF14 File Offset: 0x0000E114
		protected RectMask2D()
		{
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000FF40 File Offset: 0x0000E140
		public Rect canvasRect
		{
			get
			{
				Canvas canvas = null;
				List<Canvas> list = ListPool<Canvas>.Get();
				base.gameObject.GetComponentsInParent<Canvas>(false, list);
				if (list.Count > 0)
				{
					canvas = list[0];
				}
				ListPool<Canvas>.Release(list);
				return this.m_VertexClipper.GetCanvasRect(this.rectTransform, canvas);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0000FF90 File Offset: 0x0000E190
		public RectTransform rectTransform
		{
			get
			{
				RectTransform rectTransform;
				if ((rectTransform = this.m_RectTransform) == null)
				{
					rectTransform = (this.m_RectTransform = base.GetComponent<RectTransform>());
				}
				return rectTransform;
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000FFBC File Offset: 0x0000E1BC
		protected override void OnEnable()
		{
			base.OnEnable();
			this.m_ShouldRecalculateClipRects = true;
			ClipperRegistry.Register(this);
			MaskUtilities.Notify2DMaskStateChanged(this);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		protected override void OnDisable()
		{
			base.OnDisable();
			this.m_ClipTargets.Clear();
			this.m_Clippers.Clear();
			ClipperRegistry.Unregister(this);
			MaskUtilities.Notify2DMaskStateChanged(this);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00010010 File Offset: 0x0000E210
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return !base.isActiveAndEnabled || RectTransformUtility.RectangleContainsScreenPoint(this.rectTransform, sp, eventCamera);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00010038 File Offset: 0x0000E238
		public virtual void PerformClipping()
		{
			if (this.m_ShouldRecalculateClipRects)
			{
				MaskUtilities.GetRectMasksForClip(this, this.m_Clippers);
				this.m_ShouldRecalculateClipRects = false;
			}
			bool flag = true;
			Rect rect = Clipping.FindCullAndClipWorldRect(this.m_Clippers, out flag);
			if (rect != this.m_LastClipRectCanvasSpace)
			{
				for (int i = 0; i < this.m_ClipTargets.Count; i++)
				{
					this.m_ClipTargets[i].SetClipRect(rect, flag);
				}
				this.m_LastClipRectCanvasSpace = rect;
				this.m_LastClipRectValid = flag;
			}
			for (int j = 0; j < this.m_ClipTargets.Count; j++)
			{
				this.m_ClipTargets[j].Cull(this.m_LastClipRectCanvasSpace, this.m_LastClipRectValid);
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000100FC File Offset: 0x0000E2FC
		public void AddClippable(IClippable clippable)
		{
			if (clippable == null)
			{
				return;
			}
			if (!this.m_ClipTargets.Contains(clippable))
			{
				this.m_ClipTargets.Add(clippable);
			}
			clippable.SetClipRect(this.m_LastClipRectCanvasSpace, this.m_LastClipRectValid);
			clippable.Cull(this.m_LastClipRectCanvasSpace, this.m_LastClipRectValid);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00010154 File Offset: 0x0000E354
		public void RemoveClippable(IClippable clippable)
		{
			if (clippable == null)
			{
				return;
			}
			clippable.SetClipRect(default(Rect), false);
			this.m_ClipTargets.Remove(clippable);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00010188 File Offset: 0x0000E388
		protected override void OnTransformParentChanged()
		{
			base.OnTransformParentChanged();
			this.m_ShouldRecalculateClipRects = true;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00010198 File Offset: 0x0000E398
		protected override void OnCanvasHierarchyChanged()
		{
			base.OnCanvasHierarchyChanged();
			this.m_ShouldRecalculateClipRects = true;
		}

		// Token: 0x040001A0 RID: 416
		[NonSerialized]
		private readonly RectangularVertexClipper m_VertexClipper = new RectangularVertexClipper();

		// Token: 0x040001A1 RID: 417
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x040001A2 RID: 418
		[NonSerialized]
		private List<IClippable> m_ClipTargets = new List<IClippable>();

		// Token: 0x040001A3 RID: 419
		[NonSerialized]
		private bool m_ShouldRecalculateClipRects;

		// Token: 0x040001A4 RID: 420
		[NonSerialized]
		private List<RectMask2D> m_Clippers = new List<RectMask2D>();

		// Token: 0x040001A5 RID: 421
		[NonSerialized]
		private Rect m_LastClipRectCanvasSpace;

		// Token: 0x040001A6 RID: 422
		[NonSerialized]
		private bool m_LastClipRectValid;
	}
}
