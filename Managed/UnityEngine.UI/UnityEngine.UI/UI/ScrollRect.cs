using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200006A RID: 106
	[RequireComponent(typeof(RectTransform))]
	[SelectionBase]
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Scroll Rect", 37)]
	[ExecuteInEditMode]
	public class ScrollRect : UIBehaviour, IEventSystemHandler, IBeginDragHandler, IInitializePotentialDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutController, ILayoutGroup
	{
		// Token: 0x0600036F RID: 879 RVA: 0x00010B38 File Offset: 0x0000ED38
		protected ScrollRect()
		{
			this.flexibleWidth = -1f;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00010BCC File Offset: 0x0000EDCC
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00010BD4 File Offset: 0x0000EDD4
		public RectTransform content
		{
			get
			{
				return this.m_Content;
			}
			set
			{
				this.m_Content = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00010BE0 File Offset: 0x0000EDE0
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00010BE8 File Offset: 0x0000EDE8
		public bool horizontal
		{
			get
			{
				return this.m_Horizontal;
			}
			set
			{
				this.m_Horizontal = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00010BF4 File Offset: 0x0000EDF4
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00010BFC File Offset: 0x0000EDFC
		public bool vertical
		{
			get
			{
				return this.m_Vertical;
			}
			set
			{
				this.m_Vertical = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00010C08 File Offset: 0x0000EE08
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00010C10 File Offset: 0x0000EE10
		public ScrollRect.MovementType movementType
		{
			get
			{
				return this.m_MovementType;
			}
			set
			{
				this.m_MovementType = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00010C1C File Offset: 0x0000EE1C
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00010C24 File Offset: 0x0000EE24
		public float elasticity
		{
			get
			{
				return this.m_Elasticity;
			}
			set
			{
				this.m_Elasticity = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00010C30 File Offset: 0x0000EE30
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00010C38 File Offset: 0x0000EE38
		public bool inertia
		{
			get
			{
				return this.m_Inertia;
			}
			set
			{
				this.m_Inertia = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00010C44 File Offset: 0x0000EE44
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00010C4C File Offset: 0x0000EE4C
		public float decelerationRate
		{
			get
			{
				return this.m_DecelerationRate;
			}
			set
			{
				this.m_DecelerationRate = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00010C58 File Offset: 0x0000EE58
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00010C60 File Offset: 0x0000EE60
		public float scrollSensitivity
		{
			get
			{
				return this.m_ScrollSensitivity;
			}
			set
			{
				this.m_ScrollSensitivity = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00010C6C File Offset: 0x0000EE6C
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00010C74 File Offset: 0x0000EE74
		public RectTransform viewport
		{
			get
			{
				return this.m_Viewport;
			}
			set
			{
				this.m_Viewport = value;
				this.SetDirtyCaching();
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00010C84 File Offset: 0x0000EE84
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00010C8C File Offset: 0x0000EE8C
		public Scrollbar horizontalScrollbar
		{
			get
			{
				return this.m_HorizontalScrollbar;
			}
			set
			{
				if (this.m_HorizontalScrollbar)
				{
					this.m_HorizontalScrollbar.onValueChanged.RemoveListener(new UnityAction<float>(this.SetHorizontalNormalizedPosition));
				}
				this.m_HorizontalScrollbar = value;
				if (this.m_HorizontalScrollbar)
				{
					this.m_HorizontalScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.SetHorizontalNormalizedPosition));
				}
				this.SetDirtyCaching();
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00010D00 File Offset: 0x0000EF00
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00010D08 File Offset: 0x0000EF08
		public Scrollbar verticalScrollbar
		{
			get
			{
				return this.m_VerticalScrollbar;
			}
			set
			{
				if (this.m_VerticalScrollbar)
				{
					this.m_VerticalScrollbar.onValueChanged.RemoveListener(new UnityAction<float>(this.SetVerticalNormalizedPosition));
				}
				this.m_VerticalScrollbar = value;
				if (this.m_VerticalScrollbar)
				{
					this.m_VerticalScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.SetVerticalNormalizedPosition));
				}
				this.SetDirtyCaching();
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00010D7C File Offset: 0x0000EF7C
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00010D84 File Offset: 0x0000EF84
		public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility
		{
			get
			{
				return this.m_HorizontalScrollbarVisibility;
			}
			set
			{
				this.m_HorizontalScrollbarVisibility = value;
				this.SetDirtyCaching();
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00010D94 File Offset: 0x0000EF94
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00010D9C File Offset: 0x0000EF9C
		public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility
		{
			get
			{
				return this.m_VerticalScrollbarVisibility;
			}
			set
			{
				this.m_VerticalScrollbarVisibility = value;
				this.SetDirtyCaching();
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00010DAC File Offset: 0x0000EFAC
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00010DB4 File Offset: 0x0000EFB4
		public float horizontalScrollbarSpacing
		{
			get
			{
				return this.m_HorizontalScrollbarSpacing;
			}
			set
			{
				this.m_HorizontalScrollbarSpacing = value;
				this.SetDirty();
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00010DCC File Offset: 0x0000EFCC
		public float verticalScrollbarSpacing
		{
			get
			{
				return this.m_VerticalScrollbarSpacing;
			}
			set
			{
				this.m_VerticalScrollbarSpacing = value;
				this.SetDirty();
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00010DDC File Offset: 0x0000EFDC
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00010DE4 File Offset: 0x0000EFE4
		public ScrollRect.ScrollRectEvent onValueChanged
		{
			get
			{
				return this.m_OnValueChanged;
			}
			set
			{
				this.m_OnValueChanged = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		protected RectTransform viewRect
		{
			get
			{
				if (this.m_ViewRect == null)
				{
					this.m_ViewRect = this.m_Viewport;
				}
				if (this.m_ViewRect == null)
				{
					this.m_ViewRect = (RectTransform)base.transform;
				}
				return this.m_ViewRect;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00010E44 File Offset: 0x0000F044
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00010E4C File Offset: 0x0000F04C
		public Vector2 velocity
		{
			get
			{
				return this.m_Velocity;
			}
			set
			{
				this.m_Velocity = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00010E58 File Offset: 0x0000F058
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

		// Token: 0x06000394 RID: 916 RVA: 0x00010E80 File Offset: 0x0000F080
		public virtual void Rebuild(CanvasUpdate executing)
		{
			if (executing == CanvasUpdate.Prelayout)
			{
				this.UpdateCachedData();
			}
			if (executing == CanvasUpdate.PostLayout)
			{
				this.UpdateBounds();
				this.UpdateScrollbars(Vector2.zero);
				this.UpdatePrevData();
				this.m_HasRebuiltLayout = true;
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00010EC4 File Offset: 0x0000F0C4
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00010EC8 File Offset: 0x0000F0C8
		private void UpdateCachedData()
		{
			Transform transform = base.transform;
			this.m_HorizontalScrollbarRect = ((!(this.m_HorizontalScrollbar == null)) ? (this.m_HorizontalScrollbar.transform as RectTransform) : null);
			this.m_VerticalScrollbarRect = ((!(this.m_VerticalScrollbar == null)) ? (this.m_VerticalScrollbar.transform as RectTransform) : null);
			bool flag = this.viewRect.parent == transform;
			bool flag2 = !this.m_HorizontalScrollbarRect || this.m_HorizontalScrollbarRect.parent == transform;
			bool flag3 = !this.m_VerticalScrollbarRect || this.m_VerticalScrollbarRect.parent == transform;
			bool flag4 = flag && flag2 && flag3;
			this.m_HSliderExpand = flag4 && this.m_HorizontalScrollbarRect && this.horizontalScrollbarVisibility == ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
			this.m_VSliderExpand = flag4 && this.m_VerticalScrollbarRect && this.verticalScrollbarVisibility == ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
			this.m_HSliderHeight = ((!(this.m_HorizontalScrollbarRect == null)) ? this.m_HorizontalScrollbarRect.rect.height : 0f);
			this.m_VSliderWidth = ((!(this.m_VerticalScrollbarRect == null)) ? this.m_VerticalScrollbarRect.rect.width : 0f);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00011060 File Offset: 0x0000F260
		protected override void OnEnable()
		{
			base.OnEnable();
			if (this.m_HorizontalScrollbar)
			{
				this.m_HorizontalScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.SetHorizontalNormalizedPosition));
			}
			if (this.m_VerticalScrollbar)
			{
				this.m_VerticalScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.SetVerticalNormalizedPosition));
			}
			CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(this);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000110D4 File Offset: 0x0000F2D4
		protected override void OnDisable()
		{
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			if (this.m_HorizontalScrollbar)
			{
				this.m_HorizontalScrollbar.onValueChanged.RemoveListener(new UnityAction<float>(this.SetHorizontalNormalizedPosition));
			}
			if (this.m_VerticalScrollbar)
			{
				this.m_VerticalScrollbar.onValueChanged.RemoveListener(new UnityAction<float>(this.SetVerticalNormalizedPosition));
			}
			this.m_HasRebuiltLayout = false;
			this.m_Tracker.Clear();
			this.m_Velocity = Vector2.zero;
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00011170 File Offset: 0x0000F370
		public override bool IsActive()
		{
			return base.IsActive() && this.m_Content != null;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0001118C File Offset: 0x0000F38C
		private void EnsureLayoutHasRebuilt()
		{
			if (!this.m_HasRebuiltLayout && !CanvasUpdateRegistry.IsRebuildingLayout())
			{
				Canvas.ForceUpdateCanvases();
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000111A8 File Offset: 0x0000F3A8
		public virtual void StopMovement()
		{
			this.m_Velocity = Vector2.zero;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000111B8 File Offset: 0x0000F3B8
		public virtual void OnScroll(PointerEventData data)
		{
			if (!this.IsActive())
			{
				return;
			}
			this.EnsureLayoutHasRebuilt();
			this.UpdateBounds();
			Vector2 scrollDelta = data.scrollDelta;
			scrollDelta.y *= -1f;
			if (this.vertical && !this.horizontal)
			{
				if (Mathf.Abs(scrollDelta.x) > Mathf.Abs(scrollDelta.y))
				{
					scrollDelta.y = scrollDelta.x;
				}
				scrollDelta.x = 0f;
			}
			if (this.horizontal && !this.vertical)
			{
				if (Mathf.Abs(scrollDelta.y) > Mathf.Abs(scrollDelta.x))
				{
					scrollDelta.x = scrollDelta.y;
				}
				scrollDelta.y = 0f;
			}
			Vector2 vector = this.m_Content.anchoredPosition;
			vector += scrollDelta * this.m_ScrollSensitivity;
			if (this.m_MovementType == ScrollRect.MovementType.Clamped)
			{
				vector += this.CalculateOffset(vector - this.m_Content.anchoredPosition);
			}
			this.SetContentAnchoredPosition(vector);
			this.UpdateBounds();
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000112E8 File Offset: 0x0000F4E8
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.m_Velocity = Vector2.zero;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00011304 File Offset: 0x0000F504
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			if (!this.IsActive())
			{
				return;
			}
			this.UpdateBounds();
			this.m_PointerStartLocalCursor = Vector2.zero;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.viewRect, eventData.position, eventData.pressEventCamera, out this.m_PointerStartLocalCursor);
			this.m_ContentStartPosition = this.m_Content.anchoredPosition;
			this.m_Dragging = true;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00011370 File Offset: 0x0000F570
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.m_Dragging = false;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00011388 File Offset: 0x0000F588
		public virtual void OnDrag(PointerEventData eventData)
		{
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			if (!this.IsActive())
			{
				return;
			}
			Vector2 vector;
			if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(this.viewRect, eventData.position, eventData.pressEventCamera, out vector))
			{
				return;
			}
			this.UpdateBounds();
			Vector2 vector2 = vector - this.m_PointerStartLocalCursor;
			Vector2 vector3 = this.m_ContentStartPosition + vector2;
			Vector2 vector4 = this.CalculateOffset(vector3 - this.m_Content.anchoredPosition);
			vector3 += vector4;
			if (this.m_MovementType == ScrollRect.MovementType.Elastic)
			{
				if (vector4.x != 0f)
				{
					vector3.x -= ScrollRect.RubberDelta(vector4.x, this.m_ViewBounds.size.x);
				}
				if (vector4.y != 0f)
				{
					vector3.y -= ScrollRect.RubberDelta(vector4.y, this.m_ViewBounds.size.y);
				}
			}
			this.SetContentAnchoredPosition(vector3);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000114A0 File Offset: 0x0000F6A0
		protected virtual void SetContentAnchoredPosition(Vector2 position)
		{
			if (!this.m_Horizontal)
			{
				position.x = this.m_Content.anchoredPosition.x;
			}
			if (!this.m_Vertical)
			{
				position.y = this.m_Content.anchoredPosition.y;
			}
			if (position != this.m_Content.anchoredPosition)
			{
				this.m_Content.anchoredPosition = position;
				this.UpdateBounds();
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00011520 File Offset: 0x0000F720
		protected virtual void LateUpdate()
		{
			if (!this.m_Content)
			{
				return;
			}
			this.EnsureLayoutHasRebuilt();
			this.UpdateScrollbarVisibility();
			this.UpdateBounds();
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			Vector2 vector = this.CalculateOffset(Vector2.zero);
			if (!this.m_Dragging && (vector != Vector2.zero || this.m_Velocity != Vector2.zero))
			{
				Vector2 vector2 = this.m_Content.anchoredPosition;
				for (int i = 0; i < 2; i++)
				{
					if (this.m_MovementType == ScrollRect.MovementType.Elastic && vector[i] != 0f)
					{
						float num = this.m_Velocity[i];
						vector2[i] = Mathf.SmoothDamp(this.m_Content.anchoredPosition[i], this.m_Content.anchoredPosition[i] + vector[i], ref num, this.m_Elasticity, float.PositiveInfinity, unscaledDeltaTime);
						this.m_Velocity[i] = num;
					}
					else if (this.m_Inertia)
					{
						ref Vector2 ptr = ref this.m_Velocity;
						int num3;
						int num2 = (num3 = i);
						float num4 = ptr[num3];
						this.m_Velocity[num2] = num4 * Mathf.Pow(this.m_DecelerationRate, unscaledDeltaTime);
						if (Mathf.Abs(this.m_Velocity[i]) < 1f)
						{
							this.m_Velocity[i] = 0f;
						}
						ref Vector2 ptr2 = ref vector2;
						int num5 = (num3 = i);
						num4 = ptr2[num3];
						vector2[num5] = num4 + this.m_Velocity[i] * unscaledDeltaTime;
					}
					else
					{
						this.m_Velocity[i] = 0f;
					}
				}
				if (this.m_Velocity != Vector2.zero)
				{
					if (this.m_MovementType == ScrollRect.MovementType.Clamped)
					{
						vector = this.CalculateOffset(vector2 - this.m_Content.anchoredPosition);
						vector2 += vector;
					}
					this.SetContentAnchoredPosition(vector2);
				}
			}
			if (this.m_Dragging && this.m_Inertia)
			{
				Vector3 vector3 = (this.m_Content.anchoredPosition - this.m_PrevPosition) / unscaledDeltaTime;
				this.m_Velocity = Vector3.Lerp(this.m_Velocity, vector3, unscaledDeltaTime * 10f);
			}
			if (this.m_ViewBounds != this.m_PrevViewBounds || this.m_ContentBounds != this.m_PrevContentBounds || this.m_Content.anchoredPosition != this.m_PrevPosition)
			{
				this.UpdateScrollbars(vector);
				this.m_OnValueChanged.Invoke(this.normalizedPosition);
				this.UpdatePrevData();
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000117EC File Offset: 0x0000F9EC
		private void UpdatePrevData()
		{
			if (this.m_Content == null)
			{
				this.m_PrevPosition = Vector2.zero;
			}
			else
			{
				this.m_PrevPosition = this.m_Content.anchoredPosition;
			}
			this.m_PrevViewBounds = this.m_ViewBounds;
			this.m_PrevContentBounds = this.m_ContentBounds;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00011844 File Offset: 0x0000FA44
		private void UpdateScrollbars(Vector2 offset)
		{
			if (this.m_HorizontalScrollbar)
			{
				if (this.m_ContentBounds.size.x > 0f)
				{
					this.m_HorizontalScrollbar.size = Mathf.Clamp01((this.m_ViewBounds.size.x - Mathf.Abs(offset.x)) / this.m_ContentBounds.size.x);
				}
				else
				{
					this.m_HorizontalScrollbar.size = 1f;
				}
				this.m_HorizontalScrollbar.value = this.horizontalNormalizedPosition;
			}
			if (this.m_VerticalScrollbar)
			{
				if (this.m_ContentBounds.size.y > 0f)
				{
					this.m_VerticalScrollbar.size = Mathf.Clamp01((this.m_ViewBounds.size.y - Mathf.Abs(offset.y)) / this.m_ContentBounds.size.y);
				}
				else
				{
					this.m_VerticalScrollbar.size = 1f;
				}
				this.m_VerticalScrollbar.value = this.verticalNormalizedPosition;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00011984 File Offset: 0x0000FB84
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00011998 File Offset: 0x0000FB98
		public Vector2 normalizedPosition
		{
			get
			{
				return new Vector2(this.horizontalNormalizedPosition, this.verticalNormalizedPosition);
			}
			set
			{
				this.SetNormalizedPosition(value.x, 0);
				this.SetNormalizedPosition(value.y, 1);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x000119B8 File Offset: 0x0000FBB8
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00011A80 File Offset: 0x0000FC80
		public float horizontalNormalizedPosition
		{
			get
			{
				this.UpdateBounds();
				if (this.m_ContentBounds.size.x <= this.m_ViewBounds.size.x)
				{
					return (float)((this.m_ViewBounds.min.x <= this.m_ContentBounds.min.x) ? 0 : 1);
				}
				return (this.m_ViewBounds.min.x - this.m_ContentBounds.min.x) / (this.m_ContentBounds.size.x - this.m_ViewBounds.size.x);
			}
			set
			{
				this.SetNormalizedPosition(value, 0);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00011A8C File Offset: 0x0000FC8C
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00011B54 File Offset: 0x0000FD54
		public float verticalNormalizedPosition
		{
			get
			{
				this.UpdateBounds();
				if (this.m_ContentBounds.size.y <= this.m_ViewBounds.size.y)
				{
					return (float)((this.m_ViewBounds.min.y <= this.m_ContentBounds.min.y) ? 0 : 1);
				}
				return (this.m_ViewBounds.min.y - this.m_ContentBounds.min.y) / (this.m_ContentBounds.size.y - this.m_ViewBounds.size.y);
			}
			set
			{
				this.SetNormalizedPosition(value, 1);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00011B60 File Offset: 0x0000FD60
		private void SetHorizontalNormalizedPosition(float value)
		{
			this.SetNormalizedPosition(value, 0);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00011B6C File Offset: 0x0000FD6C
		private void SetVerticalNormalizedPosition(float value)
		{
			this.SetNormalizedPosition(value, 1);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00011B78 File Offset: 0x0000FD78
		private void SetNormalizedPosition(float value, int axis)
		{
			this.EnsureLayoutHasRebuilt();
			this.UpdateBounds();
			float num = this.m_ContentBounds.size[axis] - this.m_ViewBounds.size[axis];
			float num2 = this.m_ViewBounds.min[axis] - value * num;
			float num3 = this.m_Content.localPosition[axis] + num2 - this.m_ContentBounds.min[axis];
			Vector3 localPosition = this.m_Content.localPosition;
			if (Mathf.Abs(localPosition[axis] - num3) > 0.01f)
			{
				localPosition[axis] = num3;
				this.m_Content.localPosition = localPosition;
				this.m_Velocity[axis] = 0f;
				this.UpdateBounds();
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00011C58 File Offset: 0x0000FE58
		private static float RubberDelta(float overStretching, float viewSize)
		{
			return (1f - 1f / (Mathf.Abs(overStretching) * 0.55f / viewSize + 1f)) * viewSize * Mathf.Sign(overStretching);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00011C84 File Offset: 0x0000FE84
		protected override void OnRectTransformDimensionsChange()
		{
			this.SetDirty();
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00011C8C File Offset: 0x0000FE8C
		private bool hScrollingNeeded
		{
			get
			{
				return !Application.isPlaying || this.m_ContentBounds.size.x > this.m_ViewBounds.size.x + 0.01f;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00011CD4 File Offset: 0x0000FED4
		private bool vScrollingNeeded
		{
			get
			{
				return !Application.isPlaying || this.m_ContentBounds.size.y > this.m_ViewBounds.size.y + 0.01f;
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00011D1C File Offset: 0x0000FF1C
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00011D20 File Offset: 0x0000FF20
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00011D24 File Offset: 0x0000FF24
		public virtual float minWidth
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00011D2C File Offset: 0x0000FF2C
		public virtual float preferredWidth
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00011D34 File Offset: 0x0000FF34
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00011D3C File Offset: 0x0000FF3C
		public virtual float flexibleWidth { get; private set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00011D48 File Offset: 0x0000FF48
		public virtual float minHeight
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00011D50 File Offset: 0x0000FF50
		public virtual float preferredHeight
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00011D58 File Offset: 0x0000FF58
		public virtual float flexibleHeight
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00011D60 File Offset: 0x0000FF60
		public virtual int layoutPriority
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00011D64 File Offset: 0x0000FF64
		public virtual void SetLayoutHorizontal()
		{
			this.m_Tracker.Clear();
			if (this.m_HSliderExpand || this.m_VSliderExpand)
			{
				this.m_Tracker.Add(this, this.viewRect, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchorMinX | DrivenTransformProperties.AnchorMinY | DrivenTransformProperties.AnchorMaxX | DrivenTransformProperties.AnchorMaxY | DrivenTransformProperties.SizeDeltaX | DrivenTransformProperties.SizeDeltaY);
				this.viewRect.anchorMin = Vector2.zero;
				this.viewRect.anchorMax = Vector2.one;
				this.viewRect.sizeDelta = Vector2.zero;
				this.viewRect.anchoredPosition = Vector2.zero;
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.content);
				this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
				this.m_ContentBounds = this.GetBounds();
			}
			if (this.m_VSliderExpand && this.vScrollingNeeded)
			{
				this.viewRect.sizeDelta = new Vector2(-(this.m_VSliderWidth + this.m_VerticalScrollbarSpacing), this.viewRect.sizeDelta.y);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.content);
				this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
				this.m_ContentBounds = this.GetBounds();
			}
			if (this.m_HSliderExpand && this.hScrollingNeeded)
			{
				this.viewRect.sizeDelta = new Vector2(this.viewRect.sizeDelta.x, -(this.m_HSliderHeight + this.m_HorizontalScrollbarSpacing));
				this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
				this.m_ContentBounds = this.GetBounds();
			}
			if (this.m_VSliderExpand && this.vScrollingNeeded && this.viewRect.sizeDelta.x == 0f && this.viewRect.sizeDelta.y < 0f)
			{
				this.viewRect.sizeDelta = new Vector2(-(this.m_VSliderWidth + this.m_VerticalScrollbarSpacing), this.viewRect.sizeDelta.y);
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00011FEC File Offset: 0x000101EC
		public virtual void SetLayoutVertical()
		{
			this.UpdateScrollbarLayout();
			this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
			this.m_ContentBounds = this.GetBounds();
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00012048 File Offset: 0x00010248
		private void UpdateScrollbarVisibility()
		{
			if (this.m_VerticalScrollbar && this.m_VerticalScrollbarVisibility != ScrollRect.ScrollbarVisibility.Permanent && this.m_VerticalScrollbar.gameObject.activeSelf != this.vScrollingNeeded)
			{
				this.m_VerticalScrollbar.gameObject.SetActive(this.vScrollingNeeded);
			}
			if (this.m_HorizontalScrollbar && this.m_HorizontalScrollbarVisibility != ScrollRect.ScrollbarVisibility.Permanent && this.m_HorizontalScrollbar.gameObject.activeSelf != this.hScrollingNeeded)
			{
				this.m_HorizontalScrollbar.gameObject.SetActive(this.hScrollingNeeded);
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000120F0 File Offset: 0x000102F0
		private void UpdateScrollbarLayout()
		{
			if (this.m_VSliderExpand && this.m_HorizontalScrollbar)
			{
				this.m_Tracker.Add(this, this.m_HorizontalScrollbarRect, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchorMinX | DrivenTransformProperties.AnchorMaxX | DrivenTransformProperties.SizeDeltaX);
				this.m_HorizontalScrollbarRect.anchorMin = new Vector2(0f, this.m_HorizontalScrollbarRect.anchorMin.y);
				this.m_HorizontalScrollbarRect.anchorMax = new Vector2(1f, this.m_HorizontalScrollbarRect.anchorMax.y);
				this.m_HorizontalScrollbarRect.anchoredPosition = new Vector2(0f, this.m_HorizontalScrollbarRect.anchoredPosition.y);
				if (this.vScrollingNeeded)
				{
					this.m_HorizontalScrollbarRect.sizeDelta = new Vector2(-(this.m_VSliderWidth + this.m_VerticalScrollbarSpacing), this.m_HorizontalScrollbarRect.sizeDelta.y);
				}
				else
				{
					this.m_HorizontalScrollbarRect.sizeDelta = new Vector2(0f, this.m_HorizontalScrollbarRect.sizeDelta.y);
				}
			}
			if (this.m_HSliderExpand && this.m_VerticalScrollbar)
			{
				this.m_Tracker.Add(this, this.m_VerticalScrollbarRect, DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchorMinY | DrivenTransformProperties.AnchorMaxY | DrivenTransformProperties.SizeDeltaY);
				this.m_VerticalScrollbarRect.anchorMin = new Vector2(this.m_VerticalScrollbarRect.anchorMin.x, 0f);
				this.m_VerticalScrollbarRect.anchorMax = new Vector2(this.m_VerticalScrollbarRect.anchorMax.x, 1f);
				this.m_VerticalScrollbarRect.anchoredPosition = new Vector2(this.m_VerticalScrollbarRect.anchoredPosition.x, 0f);
				if (this.hScrollingNeeded)
				{
					this.m_VerticalScrollbarRect.sizeDelta = new Vector2(this.m_VerticalScrollbarRect.sizeDelta.x, -(this.m_HSliderHeight + this.m_HorizontalScrollbarSpacing));
				}
				else
				{
					this.m_VerticalScrollbarRect.sizeDelta = new Vector2(this.m_VerticalScrollbarRect.sizeDelta.x, 0f);
				}
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0001232C File Offset: 0x0001052C
		private void UpdateBounds()
		{
			this.m_ViewBounds = new Bounds(this.viewRect.rect.center, this.viewRect.rect.size);
			this.m_ContentBounds = this.GetBounds();
			if (this.m_Content == null)
			{
				return;
			}
			Vector3 size = this.m_ContentBounds.size;
			Vector3 center = this.m_ContentBounds.center;
			Vector3 vector = this.m_ViewBounds.size - size;
			if (vector.x > 0f)
			{
				center.x -= vector.x * (this.m_Content.pivot.x - 0.5f);
				size.x = this.m_ViewBounds.size.x;
			}
			if (vector.y > 0f)
			{
				center.y -= vector.y * (this.m_Content.pivot.y - 0.5f);
				size.y = this.m_ViewBounds.size.y;
			}
			this.m_ContentBounds.size = size;
			this.m_ContentBounds.center = center;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00012490 File Offset: 0x00010690
		private Bounds GetBounds()
		{
			if (this.m_Content == null)
			{
				return default(Bounds);
			}
			Vector3 vector = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
			Vector3 vector2 = new Vector3(float.MinValue, float.MinValue, float.MinValue);
			Matrix4x4 worldToLocalMatrix = this.viewRect.worldToLocalMatrix;
			this.m_Content.GetWorldCorners(this.m_Corners);
			for (int i = 0; i < 4; i++)
			{
				Vector3 vector3 = worldToLocalMatrix.MultiplyPoint3x4(this.m_Corners[i]);
				vector = Vector3.Min(vector3, vector);
				vector2 = Vector3.Max(vector3, vector2);
			}
			Bounds bounds = new Bounds(vector, Vector3.zero);
			bounds.Encapsulate(vector2);
			return bounds;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00012558 File Offset: 0x00010758
		private Vector2 CalculateOffset(Vector2 delta)
		{
			Vector2 zero = Vector2.zero;
			if (this.m_MovementType == ScrollRect.MovementType.Unrestricted)
			{
				return zero;
			}
			Vector2 vector = this.m_ContentBounds.min;
			Vector2 vector2 = this.m_ContentBounds.max;
			if (this.m_Horizontal)
			{
				vector.x += delta.x;
				vector2.x += delta.x;
				if (vector.x > this.m_ViewBounds.min.x)
				{
					zero.x = this.m_ViewBounds.min.x - vector.x;
				}
				else if (vector2.x < this.m_ViewBounds.max.x)
				{
					zero.x = this.m_ViewBounds.max.x - vector2.x;
				}
			}
			if (this.m_Vertical)
			{
				vector.y += delta.y;
				vector2.y += delta.y;
				if (vector2.y < this.m_ViewBounds.max.y)
				{
					zero.y = this.m_ViewBounds.max.y - vector2.y;
				}
				else if (vector.y > this.m_ViewBounds.min.y)
				{
					zero.y = this.m_ViewBounds.min.y - vector.y;
				}
			}
			return zero;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0001271C File Offset: 0x0001091C
		protected void SetDirty()
		{
			if (!this.IsActive())
			{
				return;
			}
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00012738 File Offset: 0x00010938
		protected void SetDirtyCaching()
		{
			if (!this.IsActive())
			{
				return;
			}
			CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(this);
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00012758 File Offset: 0x00010958
		virtual bool UnityEngine.UI.ICanvasElement.IsDestroyed()
		{
			return base.IsDestroyed();
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00012760 File Offset: 0x00010960
		virtual Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x040001BA RID: 442
		[SerializeField]
		private RectTransform m_Content;

		// Token: 0x040001BB RID: 443
		[SerializeField]
		private bool m_Horizontal = true;

		// Token: 0x040001BC RID: 444
		[SerializeField]
		private bool m_Vertical = true;

		// Token: 0x040001BD RID: 445
		[SerializeField]
		private ScrollRect.MovementType m_MovementType = ScrollRect.MovementType.Elastic;

		// Token: 0x040001BE RID: 446
		[SerializeField]
		private float m_Elasticity = 0.1f;

		// Token: 0x040001BF RID: 447
		[SerializeField]
		private bool m_Inertia = true;

		// Token: 0x040001C0 RID: 448
		[SerializeField]
		private float m_DecelerationRate = 0.135f;

		// Token: 0x040001C1 RID: 449
		[SerializeField]
		private float m_ScrollSensitivity = 1f;

		// Token: 0x040001C2 RID: 450
		[SerializeField]
		private RectTransform m_Viewport;

		// Token: 0x040001C3 RID: 451
		[SerializeField]
		private Scrollbar m_HorizontalScrollbar;

		// Token: 0x040001C4 RID: 452
		[SerializeField]
		private Scrollbar m_VerticalScrollbar;

		// Token: 0x040001C5 RID: 453
		[SerializeField]
		private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility;

		// Token: 0x040001C6 RID: 454
		[SerializeField]
		private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility;

		// Token: 0x040001C7 RID: 455
		[SerializeField]
		private float m_HorizontalScrollbarSpacing;

		// Token: 0x040001C8 RID: 456
		[SerializeField]
		private float m_VerticalScrollbarSpacing;

		// Token: 0x040001C9 RID: 457
		[SerializeField]
		private ScrollRect.ScrollRectEvent m_OnValueChanged = new ScrollRect.ScrollRectEvent();

		// Token: 0x040001CA RID: 458
		private Vector2 m_PointerStartLocalCursor = Vector2.zero;

		// Token: 0x040001CB RID: 459
		private Vector2 m_ContentStartPosition = Vector2.zero;

		// Token: 0x040001CC RID: 460
		private RectTransform m_ViewRect;

		// Token: 0x040001CD RID: 461
		private Bounds m_ContentBounds;

		// Token: 0x040001CE RID: 462
		private Bounds m_ViewBounds;

		// Token: 0x040001CF RID: 463
		private Vector2 m_Velocity;

		// Token: 0x040001D0 RID: 464
		private bool m_Dragging;

		// Token: 0x040001D1 RID: 465
		private Vector2 m_PrevPosition = Vector2.zero;

		// Token: 0x040001D2 RID: 466
		private Bounds m_PrevContentBounds;

		// Token: 0x040001D3 RID: 467
		private Bounds m_PrevViewBounds;

		// Token: 0x040001D4 RID: 468
		[NonSerialized]
		private bool m_HasRebuiltLayout;

		// Token: 0x040001D5 RID: 469
		private bool m_HSliderExpand;

		// Token: 0x040001D6 RID: 470
		private bool m_VSliderExpand;

		// Token: 0x040001D7 RID: 471
		private float m_HSliderHeight;

		// Token: 0x040001D8 RID: 472
		private float m_VSliderWidth;

		// Token: 0x040001D9 RID: 473
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x040001DA RID: 474
		private RectTransform m_HorizontalScrollbarRect;

		// Token: 0x040001DB RID: 475
		private RectTransform m_VerticalScrollbarRect;

		// Token: 0x040001DC RID: 476
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x040001DD RID: 477
		private readonly Vector3[] m_Corners = new Vector3[4];

		// Token: 0x0200006B RID: 107
		public enum MovementType
		{
			// Token: 0x040001E0 RID: 480
			Unrestricted,
			// Token: 0x040001E1 RID: 481
			Elastic,
			// Token: 0x040001E2 RID: 482
			Clamped
		}

		// Token: 0x0200006C RID: 108
		public enum ScrollbarVisibility
		{
			// Token: 0x040001E4 RID: 484
			Permanent,
			// Token: 0x040001E5 RID: 485
			AutoHide,
			// Token: 0x040001E6 RID: 486
			AutoHideAndExpandViewport
		}

		// Token: 0x0200006D RID: 109
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
		}
	}
}
