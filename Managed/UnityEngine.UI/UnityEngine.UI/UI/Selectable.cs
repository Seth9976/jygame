using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200006E RID: 110
	[AddComponentMenu("UI/Selectable", 70)]
	[DisallowMultipleComponent]
	[SelectionBase]
	[ExecuteInEditMode]
	public class Selectable : UIBehaviour, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, ISelectHandler, IDeselectHandler, IMoveHandler
	{
		// Token: 0x060003C9 RID: 969 RVA: 0x00012770 File Offset: 0x00010970
		protected Selectable()
		{
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003CB RID: 971 RVA: 0x000127D0 File Offset: 0x000109D0
		public static List<Selectable> allSelectables
		{
			get
			{
				return Selectable.s_List;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003CC RID: 972 RVA: 0x000127D8 File Offset: 0x000109D8
		// (set) Token: 0x060003CD RID: 973 RVA: 0x000127E0 File Offset: 0x000109E0
		public Navigation navigation
		{
			get
			{
				return this.m_Navigation;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<Navigation>(ref this.m_Navigation, value))
				{
					this.OnSetProperty();
				}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003CE RID: 974 RVA: 0x000127FC File Offset: 0x000109FC
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00012804 File Offset: 0x00010A04
		public Selectable.Transition transition
		{
			get
			{
				return this.m_Transition;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<Selectable.Transition>(ref this.m_Transition, value))
				{
					this.OnSetProperty();
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00012820 File Offset: 0x00010A20
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00012828 File Offset: 0x00010A28
		public ColorBlock colors
		{
			get
			{
				return this.m_Colors;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<ColorBlock>(ref this.m_Colors, value))
				{
					this.OnSetProperty();
				}
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00012844 File Offset: 0x00010A44
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0001284C File Offset: 0x00010A4C
		public SpriteState spriteState
		{
			get
			{
				return this.m_SpriteState;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<SpriteState>(ref this.m_SpriteState, value))
				{
					this.OnSetProperty();
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00012868 File Offset: 0x00010A68
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00012870 File Offset: 0x00010A70
		public AnimationTriggers animationTriggers
		{
			get
			{
				return this.m_AnimationTriggers;
			}
			set
			{
				if (SetPropertyUtility.SetClass<AnimationTriggers>(ref this.m_AnimationTriggers, value))
				{
					this.OnSetProperty();
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0001288C File Offset: 0x00010A8C
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00012894 File Offset: 0x00010A94
		public Graphic targetGraphic
		{
			get
			{
				return this.m_TargetGraphic;
			}
			set
			{
				if (SetPropertyUtility.SetClass<Graphic>(ref this.m_TargetGraphic, value))
				{
					this.OnSetProperty();
				}
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x000128B0 File Offset: 0x00010AB0
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x000128B8 File Offset: 0x00010AB8
		public bool interactable
		{
			get
			{
				return this.m_Interactable;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<bool>(ref this.m_Interactable, value))
				{
					this.OnSetProperty();
				}
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003DA RID: 986 RVA: 0x000128D4 File Offset: 0x00010AD4
		// (set) Token: 0x060003DB RID: 987 RVA: 0x000128DC File Offset: 0x00010ADC
		private bool isPointerInside { get; set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000128E8 File Offset: 0x00010AE8
		// (set) Token: 0x060003DD RID: 989 RVA: 0x000128F0 File Offset: 0x00010AF0
		private bool isPointerDown { get; set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003DE RID: 990 RVA: 0x000128FC File Offset: 0x00010AFC
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00012904 File Offset: 0x00010B04
		private bool hasSelection { get; set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00012910 File Offset: 0x00010B10
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00012920 File Offset: 0x00010B20
		public Image image
		{
			get
			{
				return this.m_TargetGraphic as Image;
			}
			set
			{
				this.m_TargetGraphic = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0001292C File Offset: 0x00010B2C
		public Animator animator
		{
			get
			{
				return base.GetComponent<Animator>();
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00012934 File Offset: 0x00010B34
		protected override void Awake()
		{
			if (this.m_TargetGraphic == null)
			{
				this.m_TargetGraphic = base.GetComponent<Graphic>();
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00012954 File Offset: 0x00010B54
		protected override void OnCanvasGroupChanged()
		{
			bool flag = true;
			Transform transform = base.transform;
			while (transform != null)
			{
				transform.GetComponents<CanvasGroup>(this.m_CanvasGroupCache);
				bool flag2 = false;
				for (int i = 0; i < this.m_CanvasGroupCache.Count; i++)
				{
					if (!this.m_CanvasGroupCache[i].interactable)
					{
						flag = false;
						flag2 = true;
					}
					if (this.m_CanvasGroupCache[i].ignoreParentGroups)
					{
						flag2 = true;
					}
				}
				if (flag2)
				{
					break;
				}
				transform = transform.parent;
			}
			if (flag != this.m_GroupsAllowInteraction)
			{
				this.m_GroupsAllowInteraction = flag;
				this.OnSetProperty();
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00012A04 File Offset: 0x00010C04
		public virtual bool IsInteractable()
		{
			return this.m_GroupsAllowInteraction && this.m_Interactable;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00012A1C File Offset: 0x00010C1C
		protected override void OnDidApplyAnimationProperties()
		{
			this.OnSetProperty();
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00012A24 File Offset: 0x00010C24
		protected override void OnEnable()
		{
			base.OnEnable();
			Selectable.s_List.Add(this);
			Selectable.SelectionState selectionState = Selectable.SelectionState.Normal;
			if (this.hasSelection)
			{
				selectionState = Selectable.SelectionState.Highlighted;
			}
			this.m_CurrentSelectionState = selectionState;
			this.InternalEvaluateAndTransitionToSelectionState(true);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00012A60 File Offset: 0x00010C60
		private void OnSetProperty()
		{
			this.InternalEvaluateAndTransitionToSelectionState(false);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00012A6C File Offset: 0x00010C6C
		protected override void OnDisable()
		{
			Selectable.s_List.Remove(this);
			this.InstantClearState();
			base.OnDisable();
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00012A88 File Offset: 0x00010C88
		protected Selectable.SelectionState currentSelectionState
		{
			get
			{
				return this.m_CurrentSelectionState;
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00012A90 File Offset: 0x00010C90
		protected virtual void InstantClearState()
		{
			string normalTrigger = this.m_AnimationTriggers.normalTrigger;
			this.isPointerInside = false;
			this.isPointerDown = false;
			this.hasSelection = false;
			switch (this.m_Transition)
			{
			case Selectable.Transition.ColorTint:
				this.StartColorTween(Color.white, true);
				break;
			case Selectable.Transition.SpriteSwap:
				this.DoSpriteSwap(null);
				break;
			case Selectable.Transition.Animation:
				this.TriggerAnimation(normalTrigger);
				break;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00012B08 File Offset: 0x00010D08
		protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			Color color;
			Sprite sprite;
			string text;
			switch (state)
			{
			case Selectable.SelectionState.Normal:
				color = this.m_Colors.normalColor;
				sprite = null;
				text = this.m_AnimationTriggers.normalTrigger;
				break;
			case Selectable.SelectionState.Highlighted:
				color = this.m_Colors.highlightedColor;
				sprite = this.m_SpriteState.highlightedSprite;
				text = this.m_AnimationTriggers.highlightedTrigger;
				break;
			case Selectable.SelectionState.Pressed:
				color = this.m_Colors.pressedColor;
				sprite = this.m_SpriteState.pressedSprite;
				text = this.m_AnimationTriggers.pressedTrigger;
				break;
			case Selectable.SelectionState.Disabled:
				color = this.m_Colors.disabledColor;
				sprite = this.m_SpriteState.disabledSprite;
				text = this.m_AnimationTriggers.disabledTrigger;
				break;
			default:
				color = Color.black;
				sprite = null;
				text = string.Empty;
				break;
			}
			if (base.gameObject.activeInHierarchy)
			{
				switch (this.m_Transition)
				{
				case Selectable.Transition.ColorTint:
					this.StartColorTween(color * this.m_Colors.colorMultiplier, instant);
					break;
				case Selectable.Transition.SpriteSwap:
					this.DoSpriteSwap(sprite);
					break;
				case Selectable.Transition.Animation:
					this.TriggerAnimation(text);
					break;
				}
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00012C48 File Offset: 0x00010E48
		public Selectable FindSelectable(Vector3 dir)
		{
			dir = dir.normalized;
			Vector3 vector = Quaternion.Inverse(base.transform.rotation) * dir;
			Vector3 vector2 = base.transform.TransformPoint(Selectable.GetPointOnRectEdge(base.transform as RectTransform, vector));
			float num = float.NegativeInfinity;
			Selectable selectable = null;
			for (int i = 0; i < Selectable.s_List.Count; i++)
			{
				Selectable selectable2 = Selectable.s_List[i];
				if (!(selectable2 == this) && !(selectable2 == null))
				{
					if (selectable2.IsInteractable() && selectable2.navigation.mode != Navigation.Mode.None)
					{
						RectTransform rectTransform = selectable2.transform as RectTransform;
						Vector3 vector3 = ((!(rectTransform != null)) ? Vector3.zero : rectTransform.rect.center);
						Vector3 vector4 = selectable2.transform.TransformPoint(vector3) - vector2;
						float num2 = Vector3.Dot(dir, vector4);
						if (num2 > 0f)
						{
							float num3 = num2 / vector4.sqrMagnitude;
							if (num3 > num)
							{
								num = num3;
								selectable = selectable2;
							}
						}
					}
				}
			}
			return selectable;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00012D9C File Offset: 0x00010F9C
		private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
		{
			if (rect == null)
			{
				return Vector3.zero;
			}
			if (dir != Vector2.zero)
			{
				dir /= Mathf.Max(Mathf.Abs(dir.x), Mathf.Abs(dir.y));
			}
			dir = rect.rect.center + Vector2.Scale(rect.rect.size, dir * 0.5f);
			return dir;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00012E2C File Offset: 0x0001102C
		private void Navigate(AxisEventData eventData, Selectable sel)
		{
			if (sel != null && sel.IsActive())
			{
				eventData.selectedObject = sel.gameObject;
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00012E54 File Offset: 0x00011054
		public virtual Selectable FindSelectableOnLeft()
		{
			if (this.m_Navigation.mode == Navigation.Mode.Explicit)
			{
				return this.m_Navigation.selectOnLeft;
			}
			if ((this.m_Navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None)
			{
				return this.FindSelectable(base.transform.rotation * Vector3.left);
			}
			return null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00012EB0 File Offset: 0x000110B0
		public virtual Selectable FindSelectableOnRight()
		{
			if (this.m_Navigation.mode == Navigation.Mode.Explicit)
			{
				return this.m_Navigation.selectOnRight;
			}
			if ((this.m_Navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None)
			{
				return this.FindSelectable(base.transform.rotation * Vector3.right);
			}
			return null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00012F0C File Offset: 0x0001110C
		public virtual Selectable FindSelectableOnUp()
		{
			if (this.m_Navigation.mode == Navigation.Mode.Explicit)
			{
				return this.m_Navigation.selectOnUp;
			}
			if ((this.m_Navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None)
			{
				return this.FindSelectable(base.transform.rotation * Vector3.up);
			}
			return null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00012F68 File Offset: 0x00011168
		public virtual Selectable FindSelectableOnDown()
		{
			if (this.m_Navigation.mode == Navigation.Mode.Explicit)
			{
				return this.m_Navigation.selectOnDown;
			}
			if ((this.m_Navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None)
			{
				return this.FindSelectable(base.transform.rotation * Vector3.down);
			}
			return null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00012FC4 File Offset: 0x000111C4
		public virtual void OnMove(AxisEventData eventData)
		{
			switch (eventData.moveDir)
			{
			case MoveDirection.Left:
				this.Navigate(eventData, this.FindSelectableOnLeft());
				break;
			case MoveDirection.Up:
				this.Navigate(eventData, this.FindSelectableOnUp());
				break;
			case MoveDirection.Right:
				this.Navigate(eventData, this.FindSelectableOnRight());
				break;
			case MoveDirection.Down:
				this.Navigate(eventData, this.FindSelectableOnDown());
				break;
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0001303C File Offset: 0x0001123C
		private void StartColorTween(Color targetColor, bool instant)
		{
			if (this.m_TargetGraphic == null)
			{
				return;
			}
			this.m_TargetGraphic.CrossFadeColor(targetColor, (!instant) ? this.m_Colors.fadeDuration : 0f, true, true);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00013084 File Offset: 0x00011284
		private void DoSpriteSwap(Sprite newSprite)
		{
			if (this.image == null)
			{
				return;
			}
			this.image.overrideSprite = newSprite;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000130A4 File Offset: 0x000112A4
		private void TriggerAnimation(string triggername)
		{
			if (this.animator == null || !this.animator.isActiveAndEnabled || this.animator.runtimeAnimatorController == null || string.IsNullOrEmpty(triggername))
			{
				return;
			}
			this.animator.ResetTrigger(this.m_AnimationTriggers.normalTrigger);
			this.animator.ResetTrigger(this.m_AnimationTriggers.pressedTrigger);
			this.animator.ResetTrigger(this.m_AnimationTriggers.highlightedTrigger);
			this.animator.ResetTrigger(this.m_AnimationTriggers.disabledTrigger);
			this.animator.SetTrigger(triggername);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00013158 File Offset: 0x00011358
		protected bool IsHighlighted(BaseEventData eventData)
		{
			if (!this.IsActive())
			{
				return false;
			}
			if (this.IsPressed())
			{
				return false;
			}
			bool flag = this.hasSelection;
			if (eventData is PointerEventData)
			{
				PointerEventData pointerEventData = eventData as PointerEventData;
				flag |= (this.isPointerDown && !this.isPointerInside && pointerEventData.pointerPress == base.gameObject) || (!this.isPointerDown && this.isPointerInside && pointerEventData.pointerPress == base.gameObject) || (!this.isPointerDown && this.isPointerInside && pointerEventData.pointerPress == null);
			}
			else
			{
				flag |= this.isPointerInside;
			}
			return flag;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0001322C File Offset: 0x0001142C
		[Obsolete("Is Pressed no longer requires eventData", false)]
		protected bool IsPressed(BaseEventData eventData)
		{
			return this.IsPressed();
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00013234 File Offset: 0x00011434
		protected bool IsPressed()
		{
			return this.IsActive() && this.isPointerInside && this.isPointerDown;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00013264 File Offset: 0x00011464
		protected void UpdateSelectionState(BaseEventData eventData)
		{
			if (this.IsPressed())
			{
				this.m_CurrentSelectionState = Selectable.SelectionState.Pressed;
				return;
			}
			if (this.IsHighlighted(eventData))
			{
				this.m_CurrentSelectionState = Selectable.SelectionState.Highlighted;
				return;
			}
			this.m_CurrentSelectionState = Selectable.SelectionState.Normal;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000132A0 File Offset: 0x000114A0
		private void EvaluateAndTransitionToSelectionState(BaseEventData eventData)
		{
			if (!this.IsActive())
			{
				return;
			}
			this.UpdateSelectionState(eventData);
			this.InternalEvaluateAndTransitionToSelectionState(false);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000132BC File Offset: 0x000114BC
		private void InternalEvaluateAndTransitionToSelectionState(bool instant)
		{
			Selectable.SelectionState selectionState = this.m_CurrentSelectionState;
			if (this.IsActive() && !this.IsInteractable())
			{
				selectionState = Selectable.SelectionState.Disabled;
			}
			this.DoStateTransition(selectionState, instant);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000132F0 File Offset: 0x000114F0
		public virtual void OnPointerDown(PointerEventData eventData)
		{
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			if (this.IsInteractable() && this.navigation.mode != Navigation.Mode.None)
			{
				EventSystem.current.SetSelectedGameObject(base.gameObject, eventData);
			}
			this.isPointerDown = true;
			this.EvaluateAndTransitionToSelectionState(eventData);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00013348 File Offset: 0x00011548
		public virtual void OnPointerUp(PointerEventData eventData)
		{
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.isPointerDown = false;
			this.EvaluateAndTransitionToSelectionState(eventData);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00013364 File Offset: 0x00011564
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
			this.isPointerInside = true;
			this.EvaluateAndTransitionToSelectionState(eventData);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00013374 File Offset: 0x00011574
		public virtual void OnPointerExit(PointerEventData eventData)
		{
			this.isPointerInside = false;
			this.EvaluateAndTransitionToSelectionState(eventData);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00013384 File Offset: 0x00011584
		public virtual void OnSelect(BaseEventData eventData)
		{
			this.hasSelection = true;
			this.EvaluateAndTransitionToSelectionState(eventData);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00013394 File Offset: 0x00011594
		public virtual void OnDeselect(BaseEventData eventData)
		{
			this.hasSelection = false;
			this.EvaluateAndTransitionToSelectionState(eventData);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000133A4 File Offset: 0x000115A4
		public virtual void Select()
		{
			if (EventSystem.current.alreadySelecting)
			{
				return;
			}
			EventSystem.current.SetSelectedGameObject(base.gameObject);
		}

		// Token: 0x040001E7 RID: 487
		private static List<Selectable> s_List = new List<Selectable>();

		// Token: 0x040001E8 RID: 488
		[SerializeField]
		[FormerlySerializedAs("navigation")]
		private Navigation m_Navigation = Navigation.defaultNavigation;

		// Token: 0x040001E9 RID: 489
		[FormerlySerializedAs("transition")]
		[SerializeField]
		private Selectable.Transition m_Transition = Selectable.Transition.ColorTint;

		// Token: 0x040001EA RID: 490
		[FormerlySerializedAs("colors")]
		[SerializeField]
		private ColorBlock m_Colors = ColorBlock.defaultColorBlock;

		// Token: 0x040001EB RID: 491
		[SerializeField]
		[FormerlySerializedAs("spriteState")]
		private SpriteState m_SpriteState;

		// Token: 0x040001EC RID: 492
		[FormerlySerializedAs("animationTriggers")]
		[SerializeField]
		private AnimationTriggers m_AnimationTriggers = new AnimationTriggers();

		// Token: 0x040001ED RID: 493
		[SerializeField]
		[Tooltip("Can the Selectable be interacted with?")]
		private bool m_Interactable = true;

		// Token: 0x040001EE RID: 494
		[SerializeField]
		[FormerlySerializedAs("m_HighlightGraphic")]
		[FormerlySerializedAs("highlightGraphic")]
		private Graphic m_TargetGraphic;

		// Token: 0x040001EF RID: 495
		private bool m_GroupsAllowInteraction = true;

		// Token: 0x040001F0 RID: 496
		private Selectable.SelectionState m_CurrentSelectionState;

		// Token: 0x040001F1 RID: 497
		private readonly List<CanvasGroup> m_CanvasGroupCache = new List<CanvasGroup>();

		// Token: 0x0200006F RID: 111
		public enum Transition
		{
			// Token: 0x040001F6 RID: 502
			None,
			// Token: 0x040001F7 RID: 503
			ColorTint,
			// Token: 0x040001F8 RID: 504
			SpriteSwap,
			// Token: 0x040001F9 RID: 505
			Animation
		}

		// Token: 0x02000070 RID: 112
		protected enum SelectionState
		{
			// Token: 0x040001FB RID: 507
			Normal,
			// Token: 0x040001FC RID: 508
			Highlighted,
			// Token: 0x040001FD RID: 509
			Pressed,
			// Token: 0x040001FE RID: 510
			Disabled
		}
	}
}
