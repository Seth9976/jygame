using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	// Token: 0x02000046 RID: 70
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(CanvasRenderer))]
	[RequireComponent(typeof(RectTransform))]
	public abstract class Graphic : UIBehaviour, ICanvasElement
	{
		// Token: 0x060001FB RID: 507 RVA: 0x00008490 File Offset: 0x00006690
		protected Graphic()
		{
			if (this.m_ColorTweenRunner == null)
			{
				this.m_ColorTweenRunner = new TweenRunner<ColorTween>();
			}
			this.m_ColorTweenRunner.Init(this);
			this.useLegacyMeshGeneration = true;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000084F8 File Offset: 0x000066F8
		public static Material defaultGraphicMaterial
		{
			get
			{
				if (Graphic.s_DefaultUI == null)
				{
					Graphic.s_DefaultUI = Canvas.GetDefaultCanvasMaterial();
				}
				return Graphic.s_DefaultUI;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000851C File Offset: 0x0000671C
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00008524 File Offset: 0x00006724
		public Color color
		{
			get
			{
				return this.m_Color;
			}
			set
			{
				if (SetPropertyUtility.SetColor(ref this.m_Color, value))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00008540 File Offset: 0x00006740
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00008548 File Offset: 0x00006748
		public bool raycastTarget
		{
			get
			{
				return this.m_RaycastTarget;
			}
			set
			{
				this.m_RaycastTarget = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00008554 File Offset: 0x00006754
		// (set) Token: 0x06000203 RID: 515 RVA: 0x0000855C File Offset: 0x0000675C
		protected bool useLegacyMeshGeneration { get; set; }

		// Token: 0x06000204 RID: 516 RVA: 0x00008568 File Offset: 0x00006768
		public virtual void SetAllDirty()
		{
			this.SetLayoutDirty();
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000857C File Offset: 0x0000677C
		public virtual void SetLayoutDirty()
		{
			if (!this.IsActive())
			{
				return;
			}
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			if (this.m_OnDirtyLayoutCallback != null)
			{
				this.m_OnDirtyLayoutCallback();
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000085AC File Offset: 0x000067AC
		public virtual void SetVerticesDirty()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.m_VertsDirty = true;
			CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);
			if (this.m_OnDirtyVertsCallback != null)
			{
				this.m_OnDirtyVertsCallback();
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000085E0 File Offset: 0x000067E0
		public virtual void SetMaterialDirty()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.m_MaterialDirty = true;
			CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);
			if (this.m_OnDirtyMaterialCallback != null)
			{
				this.m_OnDirtyMaterialCallback();
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00008614 File Offset: 0x00006814
		protected override void OnRectTransformDimensionsChange()
		{
			if (base.gameObject.activeInHierarchy)
			{
				if (CanvasUpdateRegistry.IsRebuildingLayout())
				{
					this.SetVerticesDirty();
				}
				else
				{
					this.SetVerticesDirty();
					this.SetLayoutDirty();
				}
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00008654 File Offset: 0x00006854
		protected override void OnBeforeTransformParentChanged()
		{
			GraphicRegistry.UnregisterGraphicForCanvas(this.canvas, this);
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00008670 File Offset: 0x00006870
		protected override void OnTransformParentChanged()
		{
			base.OnTransformParentChanged();
			if (!this.IsActive())
			{
				return;
			}
			this.CacheCanvas();
			GraphicRegistry.RegisterGraphicForCanvas(this.canvas, this);
			this.SetAllDirty();
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600020B RID: 523 RVA: 0x000086A8 File Offset: 0x000068A8
		public int depth
		{
			get
			{
				return this.canvasRenderer.absoluteDepth;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000086B8 File Offset: 0x000068B8
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600020D RID: 525 RVA: 0x000086E4 File Offset: 0x000068E4
		public Canvas canvas
		{
			get
			{
				if (this.m_Canvas == null)
				{
					this.CacheCanvas();
				}
				return this.m_Canvas;
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00008704 File Offset: 0x00006904
		private void CacheCanvas()
		{
			List<Canvas> list = ListPool<Canvas>.Get();
			base.gameObject.GetComponentsInParent<Canvas>(false, list);
			if (list.Count > 0)
			{
				this.m_Canvas = list[0];
			}
			ListPool<Canvas>.Release(list);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00008744 File Offset: 0x00006944
		public CanvasRenderer canvasRenderer
		{
			get
			{
				if (this.m_CanvasRender == null)
				{
					this.m_CanvasRender = base.GetComponent<CanvasRenderer>();
				}
				return this.m_CanvasRender;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0000876C File Offset: 0x0000696C
		public virtual Material defaultMaterial
		{
			get
			{
				return Graphic.defaultGraphicMaterial;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00008774 File Offset: 0x00006974
		// (set) Token: 0x06000212 RID: 530 RVA: 0x000087A4 File Offset: 0x000069A4
		public virtual Material material
		{
			get
			{
				return (!(this.m_Material != null)) ? this.defaultMaterial : this.m_Material;
			}
			set
			{
				if (this.m_Material == value)
				{
					return;
				}
				this.m_Material = value;
				this.SetMaterialDirty();
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000213 RID: 531 RVA: 0x000087C8 File Offset: 0x000069C8
		public virtual Material materialForRendering
		{
			get
			{
				List<Component> list = ListPool<Component>.Get();
				base.GetComponents(typeof(IMaterialModifier), list);
				Material material = this.material;
				for (int i = 0; i < list.Count; i++)
				{
					material = (list[i] as IMaterialModifier).GetModifiedMaterial(material);
				}
				ListPool<Component>.Release(list);
				return material;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00008824 File Offset: 0x00006A24
		public virtual Texture mainTexture
		{
			get
			{
				return Graphic.s_WhiteTexture;
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000882C File Offset: 0x00006A2C
		protected override void OnEnable()
		{
			base.OnEnable();
			this.CacheCanvas();
			GraphicRegistry.RegisterGraphicForCanvas(this.canvas, this);
			if (Graphic.s_WhiteTexture == null)
			{
				Graphic.s_WhiteTexture = Texture2D.whiteTexture;
			}
			this.SetAllDirty();
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00008874 File Offset: 0x00006A74
		protected override void OnDisable()
		{
			GraphicRegistry.UnregisterGraphicForCanvas(this.canvas, this);
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			if (this.canvasRenderer != null)
			{
				this.canvasRenderer.Clear();
			}
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000088C0 File Offset: 0x00006AC0
		protected override void OnCanvasHierarchyChanged()
		{
			Canvas canvas = this.m_Canvas;
			this.CacheCanvas();
			if (canvas != this.m_Canvas)
			{
				GraphicRegistry.UnregisterGraphicForCanvas(canvas, this);
				GraphicRegistry.RegisterGraphicForCanvas(this.canvas, this);
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00008900 File Offset: 0x00006B00
		public virtual void Rebuild(CanvasUpdate update)
		{
			if (this.canvasRenderer.cull)
			{
				return;
			}
			if (update == CanvasUpdate.PreRender)
			{
				if (this.m_VertsDirty)
				{
					this.UpdateGeometry();
					this.m_VertsDirty = false;
				}
				if (this.m_MaterialDirty)
				{
					this.UpdateMaterial();
					this.m_MaterialDirty = false;
				}
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00008964 File Offset: 0x00006B64
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00008968 File Offset: 0x00006B68
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000896C File Offset: 0x00006B6C
		protected virtual void UpdateMaterial()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.canvasRenderer.materialCount = 1;
			this.canvasRenderer.SetMaterial(this.materialForRendering, 0);
			this.canvasRenderer.SetTexture(this.mainTexture);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000089B4 File Offset: 0x00006BB4
		protected virtual void UpdateGeometry()
		{
			if (this.useLegacyMeshGeneration)
			{
				this.DoLegacyMeshGeneration();
			}
			else
			{
				this.DoMeshGeneration();
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000089D4 File Offset: 0x00006BD4
		private void DoMeshGeneration()
		{
			if (this.rectTransform != null && this.rectTransform.rect.width >= 0f && this.rectTransform.rect.height >= 0f)
			{
				this.OnPopulateMesh(Graphic.s_VertexHelper);
			}
			else
			{
				Graphic.s_VertexHelper.Clear();
			}
			List<Component> list = ListPool<Component>.Get();
			base.GetComponents(typeof(IMeshModifier), list);
			for (int i = 0; i < list.Count; i++)
			{
				((IMeshModifier)list[i]).ModifyMesh(Graphic.s_VertexHelper);
			}
			ListPool<Component>.Release(list);
			Graphic.s_VertexHelper.FillMesh(Graphic.workerMesh);
			this.canvasRenderer.SetMesh(Graphic.workerMesh);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00008AB0 File Offset: 0x00006CB0
		private void DoLegacyMeshGeneration()
		{
			if (this.rectTransform != null && this.rectTransform.rect.width >= 0f && this.rectTransform.rect.height >= 0f)
			{
				this.OnPopulateMesh(Graphic.workerMesh);
			}
			else
			{
				Graphic.workerMesh.Clear();
			}
			List<Component> list = ListPool<Component>.Get();
			base.GetComponents(typeof(IMeshModifier), list);
			for (int i = 0; i < list.Count; i++)
			{
				((IMeshModifier)list[i]).ModifyMesh(Graphic.workerMesh);
			}
			ListPool<Component>.Release(list);
			this.canvasRenderer.SetMesh(Graphic.workerMesh);
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00008B7C File Offset: 0x00006D7C
		protected static Mesh workerMesh
		{
			get
			{
				if (Graphic.s_Mesh == null)
				{
					Graphic.s_Mesh = new Mesh();
					Graphic.s_Mesh.name = "Shared UI Mesh";
					Graphic.s_Mesh.hideFlags = HideFlags.HideAndDontSave;
				}
				return Graphic.s_Mesh;
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00008BC4 File Offset: 0x00006DC4
		[Obsolete("Use OnPopulateMesh instead.", true)]
		protected virtual void OnFillVBO(List<UIVertex> vbo)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00008BC8 File Offset: 0x00006DC8
		[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", false)]
		protected virtual void OnPopulateMesh(Mesh m)
		{
			this.OnPopulateMesh(Graphic.s_VertexHelper);
			Graphic.s_VertexHelper.FillMesh(m);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00008BE0 File Offset: 0x00006DE0
		protected virtual void OnPopulateMesh(VertexHelper vh)
		{
			Rect pixelAdjustedRect = this.GetPixelAdjustedRect();
			Vector4 vector = new Vector4(pixelAdjustedRect.x, pixelAdjustedRect.y, pixelAdjustedRect.x + pixelAdjustedRect.width, pixelAdjustedRect.y + pixelAdjustedRect.height);
			Color32 color = this.color;
			vh.Clear();
			vh.AddVert(new Vector3(vector.x, vector.y), color, new Vector2(0f, 0f));
			vh.AddVert(new Vector3(vector.x, vector.w), color, new Vector2(0f, 1f));
			vh.AddVert(new Vector3(vector.z, vector.w), color, new Vector2(1f, 1f));
			vh.AddVert(new Vector3(vector.z, vector.y), color, new Vector2(1f, 0f));
			vh.AddTriangle(0, 1, 2);
			vh.AddTriangle(2, 3, 0);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00008CF0 File Offset: 0x00006EF0
		protected override void OnDidApplyAnimationProperties()
		{
			this.SetAllDirty();
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00008CF8 File Offset: 0x00006EF8
		public virtual void SetNativeSize()
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00008CFC File Offset: 0x00006EFC
		public virtual bool Raycast(Vector2 sp, Camera eventCamera)
		{
			if (!base.isActiveAndEnabled)
			{
				return false;
			}
			Transform transform = base.transform;
			List<Component> list = ListPool<Component>.Get();
			bool flag = false;
			while (transform != null)
			{
				transform.GetComponents<Component>(list);
				for (int i = 0; i < list.Count; i++)
				{
					ICanvasRaycastFilter canvasRaycastFilter = list[i] as ICanvasRaycastFilter;
					if (canvasRaycastFilter != null)
					{
						bool flag2 = true;
						CanvasGroup canvasGroup = list[i] as CanvasGroup;
						if (canvasGroup != null)
						{
							if (!flag && canvasGroup.ignoreParentGroups)
							{
								flag = true;
								flag2 = canvasRaycastFilter.IsRaycastLocationValid(sp, eventCamera);
							}
							else if (!flag)
							{
								flag2 = canvasRaycastFilter.IsRaycastLocationValid(sp, eventCamera);
							}
						}
						else
						{
							flag2 = canvasRaycastFilter.IsRaycastLocationValid(sp, eventCamera);
						}
						if (!flag2)
						{
							ListPool<Component>.Release(list);
							return false;
						}
					}
				}
				transform = transform.parent;
			}
			ListPool<Component>.Release(list);
			return true;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00008DF0 File Offset: 0x00006FF0
		public Vector2 PixelAdjustPoint(Vector2 point)
		{
			if (!this.canvas || !this.canvas.pixelPerfect)
			{
				return point;
			}
			return RectTransformUtility.PixelAdjustPoint(point, base.transform, this.canvas);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00008E34 File Offset: 0x00007034
		public Rect GetPixelAdjustedRect()
		{
			if (!this.canvas || !this.canvas.pixelPerfect)
			{
				return this.rectTransform.rect;
			}
			return RectTransformUtility.PixelAdjustRect(this.rectTransform, this.canvas);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00008E80 File Offset: 0x00007080
		public void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
			this.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, true);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00008E90 File Offset: 0x00007090
		private void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
		{
			if (this.canvasRenderer == null || (!useRGB && !useAlpha))
			{
				return;
			}
			if (this.canvasRenderer.GetColor().Equals(targetColor))
			{
				return;
			}
			ColorTween.ColorTweenMode colorTweenMode = ((!useRGB || !useAlpha) ? ((!useRGB) ? ColorTween.ColorTweenMode.Alpha : ColorTween.ColorTweenMode.RGB) : ColorTween.ColorTweenMode.All);
			ColorTween colorTween = new ColorTween
			{
				duration = duration,
				startColor = this.canvasRenderer.GetColor(),
				targetColor = targetColor
			};
			colorTween.AddOnChangedCallback(new UnityAction<Color>(this.canvasRenderer.SetColor));
			colorTween.ignoreTimeScale = ignoreTimeScale;
			colorTween.tweenMode = colorTweenMode;
			this.m_ColorTweenRunner.StartTween(colorTween);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00008F64 File Offset: 0x00007164
		private static Color CreateColorFromAlpha(float alpha)
		{
			Color black = Color.black;
			black.a = alpha;
			return black;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00008F80 File Offset: 0x00007180
		public void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
			this.CrossFadeColor(Graphic.CreateColorFromAlpha(alpha), duration, ignoreTimeScale, true, false);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00008F94 File Offset: 0x00007194
		public void RegisterDirtyLayoutCallback(UnityAction action)
		{
			this.m_OnDirtyLayoutCallback = (UnityAction)Delegate.Combine(this.m_OnDirtyLayoutCallback, action);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00008FB0 File Offset: 0x000071B0
		public void UnregisterDirtyLayoutCallback(UnityAction action)
		{
			this.m_OnDirtyLayoutCallback = (UnityAction)Delegate.Remove(this.m_OnDirtyLayoutCallback, action);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00008FCC File Offset: 0x000071CC
		public void RegisterDirtyVerticesCallback(UnityAction action)
		{
			this.m_OnDirtyVertsCallback = (UnityAction)Delegate.Combine(this.m_OnDirtyVertsCallback, action);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00008FE8 File Offset: 0x000071E8
		public void UnregisterDirtyVerticesCallback(UnityAction action)
		{
			this.m_OnDirtyVertsCallback = (UnityAction)Delegate.Remove(this.m_OnDirtyVertsCallback, action);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00009004 File Offset: 0x00007204
		public void RegisterDirtyMaterialCallback(UnityAction action)
		{
			this.m_OnDirtyMaterialCallback = (UnityAction)Delegate.Combine(this.m_OnDirtyMaterialCallback, action);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00009020 File Offset: 0x00007220
		public void UnregisterDirtyMaterialCallback(UnityAction action)
		{
			this.m_OnDirtyMaterialCallback = (UnityAction)Delegate.Remove(this.m_OnDirtyMaterialCallback, action);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000903C File Offset: 0x0000723C
		virtual bool UnityEngine.UI.ICanvasElement.IsDestroyed()
		{
			return base.IsDestroyed();
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00009044 File Offset: 0x00007244
		virtual Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x040000ED RID: 237
		protected static Material s_DefaultUI = null;

		// Token: 0x040000EE RID: 238
		protected static Texture2D s_WhiteTexture = null;

		// Token: 0x040000EF RID: 239
		[FormerlySerializedAs("m_Mat")]
		[SerializeField]
		protected Material m_Material;

		// Token: 0x040000F0 RID: 240
		[SerializeField]
		private Color m_Color = Color.white;

		// Token: 0x040000F1 RID: 241
		[SerializeField]
		private bool m_RaycastTarget = true;

		// Token: 0x040000F2 RID: 242
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x040000F3 RID: 243
		[NonSerialized]
		private CanvasRenderer m_CanvasRender;

		// Token: 0x040000F4 RID: 244
		[NonSerialized]
		private Canvas m_Canvas;

		// Token: 0x040000F5 RID: 245
		[NonSerialized]
		private bool m_VertsDirty;

		// Token: 0x040000F6 RID: 246
		[NonSerialized]
		private bool m_MaterialDirty;

		// Token: 0x040000F7 RID: 247
		[NonSerialized]
		protected UnityAction m_OnDirtyLayoutCallback;

		// Token: 0x040000F8 RID: 248
		[NonSerialized]
		protected UnityAction m_OnDirtyVertsCallback;

		// Token: 0x040000F9 RID: 249
		[NonSerialized]
		protected UnityAction m_OnDirtyMaterialCallback;

		// Token: 0x040000FA RID: 250
		[NonSerialized]
		protected static Mesh s_Mesh;

		// Token: 0x040000FB RID: 251
		[NonSerialized]
		private static readonly VertexHelper s_VertexHelper = new VertexHelper();

		// Token: 0x040000FC RID: 252
		[NonSerialized]
		private readonly TweenRunner<ColorTween> m_ColorTweenRunner;
	}
}
