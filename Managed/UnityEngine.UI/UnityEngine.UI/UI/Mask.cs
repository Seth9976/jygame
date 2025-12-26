using System;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200005D RID: 93
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Mask", 13)]
	public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier
	{
		// Token: 0x060002FF RID: 767 RVA: 0x0000F078 File Offset: 0x0000D278
		protected Mask()
		{
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000F088 File Offset: 0x0000D288
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

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0000F0B4 File Offset: 0x0000D2B4
		// (set) Token: 0x06000302 RID: 770 RVA: 0x0000F0BC File Offset: 0x0000D2BC
		public bool showMaskGraphic
		{
			get
			{
				return this.m_ShowMaskGraphic;
			}
			set
			{
				if (this.m_ShowMaskGraphic == value)
				{
					return;
				}
				this.m_ShowMaskGraphic = value;
				if (this.graphic != null)
				{
					this.graphic.SetMaterialDirty();
				}
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000F0FC File Offset: 0x0000D2FC
		public Graphic graphic
		{
			get
			{
				Graphic graphic;
				if ((graphic = this.m_Graphic) == null)
				{
					graphic = (this.m_Graphic = base.GetComponent<Graphic>());
				}
				return graphic;
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000F128 File Offset: 0x0000D328
		[Obsolete("use Mask.enabled instead", true)]
		public virtual bool MaskEnabled()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000F130 File Offset: 0x0000D330
		[Obsolete("Not used anymore.")]
		public virtual void OnSiblingGraphicEnabledDisabled()
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000F134 File Offset: 0x0000D334
		protected override void OnEnable()
		{
			base.OnEnable();
			if (this.graphic != null)
			{
				this.graphic.canvasRenderer.hasPopInstruction = true;
				this.graphic.SetMaterialDirty();
			}
			MaskUtilities.NotifyStencilStateChanged(this);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000F17C File Offset: 0x0000D37C
		protected override void OnDisable()
		{
			base.OnDisable();
			if (this.graphic != null)
			{
				this.graphic.SetMaterialDirty();
				this.graphic.canvasRenderer.hasPopInstruction = false;
				this.graphic.canvasRenderer.popMaterialCount = 0;
			}
			StencilMaterial.Remove(this.m_MaskMaterial);
			this.m_MaskMaterial = null;
			StencilMaterial.Remove(this.m_UnmaskMaterial);
			this.m_UnmaskMaterial = null;
			MaskUtilities.NotifyStencilStateChanged(this);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return !base.isActiveAndEnabled || RectTransformUtility.RectangleContainsScreenPoint(this.rectTransform, sp, eventCamera);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000F220 File Offset: 0x0000D420
		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			if (this.graphic == null)
			{
				return baseMaterial;
			}
			Transform transform = MaskUtilities.FindRootSortOverrideCanvas(base.transform);
			int stencilDepth = MaskUtilities.GetStencilDepth(base.transform, transform);
			if (stencilDepth >= 8)
			{
				Debug.LogError("Attempting to use a stencil mask with depth > 8", base.gameObject);
				return baseMaterial;
			}
			int num = 1 << stencilDepth;
			if (num == 1)
			{
				Material material = StencilMaterial.Add(baseMaterial, 1, StencilOp.Replace, CompareFunction.Always, (!this.m_ShowMaskGraphic) ? ((ColorWriteMask)0) : ColorWriteMask.All);
				StencilMaterial.Remove(this.m_MaskMaterial);
				this.m_MaskMaterial = material;
				Material material2 = StencilMaterial.Add(baseMaterial, 1, StencilOp.Zero, CompareFunction.Always, (ColorWriteMask)0);
				StencilMaterial.Remove(this.m_UnmaskMaterial);
				this.m_UnmaskMaterial = material2;
				this.graphic.canvasRenderer.popMaterialCount = 1;
				this.graphic.canvasRenderer.SetPopMaterial(this.m_UnmaskMaterial, 0);
				return this.m_MaskMaterial;
			}
			Material material3 = StencilMaterial.Add(baseMaterial, num | (num - 1), StencilOp.Replace, CompareFunction.Equal, (!this.m_ShowMaskGraphic) ? ((ColorWriteMask)0) : ColorWriteMask.All, num - 1, num | (num - 1));
			StencilMaterial.Remove(this.m_MaskMaterial);
			this.m_MaskMaterial = material3;
			this.graphic.canvasRenderer.hasPopInstruction = true;
			Material material4 = StencilMaterial.Add(baseMaterial, num - 1, StencilOp.Replace, CompareFunction.Equal, (ColorWriteMask)0, num - 1, num | (num - 1));
			StencilMaterial.Remove(this.m_UnmaskMaterial);
			this.m_UnmaskMaterial = material4;
			this.graphic.canvasRenderer.popMaterialCount = 1;
			this.graphic.canvasRenderer.SetPopMaterial(this.m_UnmaskMaterial, 0);
			return this.m_MaskMaterial;
		}

		// Token: 0x04000185 RID: 389
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x04000186 RID: 390
		[SerializeField]
		[FormerlySerializedAs("m_ShowGraphic")]
		private bool m_ShowMaskGraphic = true;

		// Token: 0x04000187 RID: 391
		[NonSerialized]
		private Graphic m_Graphic;

		// Token: 0x04000188 RID: 392
		[NonSerialized]
		private Material m_MaskMaterial;

		// Token: 0x04000189 RID: 393
		[NonSerialized]
		private Material m_UnmaskMaterial;
	}
}
