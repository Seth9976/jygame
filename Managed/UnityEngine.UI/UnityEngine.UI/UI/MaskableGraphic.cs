using System;
using UnityEngine.Events;
using UnityEngine.Rendering;

namespace UnityEngine.UI
{
	// Token: 0x0200005E RID: 94
	public abstract class MaskableGraphic : Graphic, IMaskable, IClippable, IMaterialModifier
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0000F3E4 File Offset: 0x0000D5E4
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0000F3EC File Offset: 0x0000D5EC
		public MaskableGraphic.CullStateChangedEvent onCullStateChanged
		{
			get
			{
				return this.m_OnCullStateChanged;
			}
			set
			{
				this.m_OnCullStateChanged = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000F3F8 File Offset: 0x0000D5F8
		// (set) Token: 0x0600030E RID: 782 RVA: 0x0000F400 File Offset: 0x0000D600
		public bool maskable
		{
			get
			{
				return this.m_Maskable;
			}
			set
			{
				if (value == this.m_Maskable)
				{
					return;
				}
				this.m_Maskable = value;
				this.m_ShouldRecalculateStencil = true;
				this.SetMaterialDirty();
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000F424 File Offset: 0x0000D624
		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			Material material = baseMaterial;
			if (this.m_ShouldRecalculateStencil)
			{
				Transform transform = MaskUtilities.FindRootSortOverrideCanvas(base.transform);
				this.m_StencilValue = ((!this.maskable) ? 0 : MaskUtilities.GetStencilDepth(base.transform, transform));
				this.m_ShouldRecalculateStencil = false;
			}
			if (this.m_StencilValue > 0 && base.GetComponent<Mask>() == null)
			{
				Material material2 = StencilMaterial.Add(material, (1 << this.m_StencilValue) - 1, StencilOp.Keep, CompareFunction.Equal, ColorWriteMask.All, (1 << this.m_StencilValue) - 1, 0);
				StencilMaterial.Remove(this.m_MaskMaterial);
				this.m_MaskMaterial = material2;
				material = this.m_MaskMaterial;
			}
			return material;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000F4D4 File Offset: 0x0000D6D4
		public virtual void Cull(Rect clipRect, bool validRect)
		{
			if (!base.canvasRenderer.hasMoved)
			{
				return;
			}
			bool flag = !validRect || !clipRect.Overlaps(this.canvasRect);
			bool flag2 = base.canvasRenderer.cull != flag;
			base.canvasRenderer.cull = flag;
			if (flag2)
			{
				this.m_OnCullStateChanged.Invoke(flag);
				this.SetVerticesDirty();
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000F544 File Offset: 0x0000D744
		public virtual void SetClipRect(Rect clipRect, bool validRect)
		{
			if (validRect)
			{
				base.canvasRenderer.EnableRectClipping(clipRect);
			}
			else
			{
				base.canvasRenderer.DisableRectClipping();
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000F574 File Offset: 0x0000D774
		protected override void OnEnable()
		{
			base.OnEnable();
			this.m_ShouldRecalculateStencil = true;
			this.UpdateClipParent();
			this.SetMaterialDirty();
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000F590 File Offset: 0x0000D790
		protected override void OnDisable()
		{
			base.OnDisable();
			this.m_ShouldRecalculateStencil = true;
			this.SetMaterialDirty();
			this.UpdateClipParent();
			StencilMaterial.Remove(this.m_MaskMaterial);
			this.m_MaskMaterial = null;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000F5C8 File Offset: 0x0000D7C8
		protected override void OnTransformParentChanged()
		{
			base.OnTransformParentChanged();
			this.m_ShouldRecalculateStencil = true;
			this.UpdateClipParent();
			this.SetMaterialDirty();
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000F5E4 File Offset: 0x0000D7E4
		[Obsolete("Not used anymore.", true)]
		public virtual void ParentMaskStateChanged()
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
		protected override void OnCanvasHierarchyChanged()
		{
			base.OnCanvasHierarchyChanged();
			this.m_ShouldRecalculateStencil = true;
			this.UpdateClipParent();
			this.SetMaterialDirty();
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0000F604 File Offset: 0x0000D804
		private Rect canvasRect
		{
			get
			{
				base.rectTransform.GetWorldCorners(this.m_Corners);
				if (base.canvas)
				{
					for (int i = 0; i < 4; i++)
					{
						this.m_Corners[i] = base.canvas.transform.InverseTransformPoint(this.m_Corners[i]);
					}
				}
				return new Rect(this.m_Corners[0].x, this.m_Corners[0].y, this.m_Corners[2].x - this.m_Corners[0].x, this.m_Corners[2].y - this.m_Corners[0].y);
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000F6E4 File Offset: 0x0000D8E4
		private void UpdateClipParent()
		{
			RectMask2D rectMask2D = ((!this.maskable || !this.IsActive()) ? null : MaskUtilities.GetRectMaskForClippable(this));
			if (rectMask2D != this.m_ParentMask && this.m_ParentMask != null)
			{
				this.m_ParentMask.RemoveClippable(this);
			}
			if (rectMask2D != null)
			{
				rectMask2D.AddClippable(this);
			}
			this.m_ParentMask = rectMask2D;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000F75C File Offset: 0x0000D95C
		public virtual void RecalculateClipping()
		{
			this.UpdateClipParent();
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000F764 File Offset: 0x0000D964
		public virtual void RecalculateMasking()
		{
			this.m_ShouldRecalculateStencil = true;
			this.SetMaterialDirty();
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000F774 File Offset: 0x0000D974
		virtual RectTransform UnityEngine.UI.IClippable.get_rectTransform()
		{
			return base.rectTransform;
		}

		// Token: 0x0400018A RID: 394
		[NonSerialized]
		protected bool m_ShouldRecalculateStencil = true;

		// Token: 0x0400018B RID: 395
		[NonSerialized]
		protected Material m_MaskMaterial;

		// Token: 0x0400018C RID: 396
		[NonSerialized]
		private RectMask2D m_ParentMask;

		// Token: 0x0400018D RID: 397
		[NonSerialized]
		private bool m_Maskable = true;

		// Token: 0x0400018E RID: 398
		[Obsolete("Not used anymore.", true)]
		[NonSerialized]
		protected bool m_IncludeForMasking;

		// Token: 0x0400018F RID: 399
		[SerializeField]
		private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged = new MaskableGraphic.CullStateChangedEvent();

		// Token: 0x04000190 RID: 400
		[Obsolete("Not used anymore", true)]
		[NonSerialized]
		protected bool m_ShouldRecalculate = true;

		// Token: 0x04000191 RID: 401
		[NonSerialized]
		protected int m_StencilValue;

		// Token: 0x04000192 RID: 402
		private readonly Vector3[] m_Corners = new Vector3[4];

		// Token: 0x0200005F RID: 95
		[Serializable]
		public class CullStateChangedEvent : UnityEvent<bool>
		{
		}
	}
}
