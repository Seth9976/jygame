using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000072 RID: 114
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Slider", 33)]
	public class Slider : Selectable, IEventSystemHandler, IInitializePotentialDragHandler, IDragHandler, ICanvasElement
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x000134B4 File Offset: 0x000116B4
		protected Slider()
		{
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x000134E0 File Offset: 0x000116E0
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x000134E8 File Offset: 0x000116E8
		public RectTransform fillRect
		{
			get
			{
				return this.m_FillRect;
			}
			set
			{
				if (SetPropertyUtility.SetClass<RectTransform>(ref this.m_FillRect, value))
				{
					this.UpdateCachedReferences();
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x00013508 File Offset: 0x00011708
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x00013510 File Offset: 0x00011710
		public RectTransform handleRect
		{
			get
			{
				return this.m_HandleRect;
			}
			set
			{
				if (SetPropertyUtility.SetClass<RectTransform>(ref this.m_HandleRect, value))
				{
					this.UpdateCachedReferences();
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00013530 File Offset: 0x00011730
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x00013538 File Offset: 0x00011738
		public Slider.Direction direction
		{
			get
			{
				return this.m_Direction;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<Slider.Direction>(ref this.m_Direction, value))
				{
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x00013554 File Offset: 0x00011754
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x0001355C File Offset: 0x0001175C
		public float minValue
		{
			get
			{
				return this.m_MinValue;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_MinValue, value))
				{
					this.Set(this.m_Value);
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00013584 File Offset: 0x00011784
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x0001358C File Offset: 0x0001178C
		public float maxValue
		{
			get
			{
				return this.m_MaxValue;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_MaxValue, value))
				{
					this.Set(this.m_Value);
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x000135B4 File Offset: 0x000117B4
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x000135BC File Offset: 0x000117BC
		public bool wholeNumbers
		{
			get
			{
				return this.m_WholeNumbers;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<bool>(ref this.m_WholeNumbers, value))
				{
					this.Set(this.m_Value);
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x000135E4 File Offset: 0x000117E4
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00013604 File Offset: 0x00011804
		public virtual float value
		{
			get
			{
				if (this.wholeNumbers)
				{
					return Mathf.Round(this.m_Value);
				}
				return this.m_Value;
			}
			set
			{
				this.Set(value);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00013610 File Offset: 0x00011810
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00013650 File Offset: 0x00011850
		public float normalizedValue
		{
			get
			{
				if (Mathf.Approximately(this.minValue, this.maxValue))
				{
					return 0f;
				}
				return Mathf.InverseLerp(this.minValue, this.maxValue, this.value);
			}
			set
			{
				this.value = Mathf.Lerp(this.minValue, this.maxValue, value);
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00013678 File Offset: 0x00011878
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00013680 File Offset: 0x00011880
		public Slider.SliderEvent onValueChanged
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

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0001368C File Offset: 0x0001188C
		private float stepSize
		{
			get
			{
				return (!this.wholeNumbers) ? ((this.maxValue - this.minValue) * 0.1f) : 1f;
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000136C4 File Offset: 0x000118C4
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000136C8 File Offset: 0x000118C8
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000136CC File Offset: 0x000118CC
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000136D0 File Offset: 0x000118D0
		protected override void OnEnable()
		{
			base.OnEnable();
			this.UpdateCachedReferences();
			this.Set(this.m_Value, false);
			this.UpdateVisuals();
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000136F4 File Offset: 0x000118F4
		protected override void OnDisable()
		{
			this.m_Tracker.Clear();
			base.OnDisable();
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00013708 File Offset: 0x00011908
		protected override void OnDidApplyAnimationProperties()
		{
			this.m_Value = this.ClampValue(this.m_Value);
			float num = this.normalizedValue;
			if (this.m_FillContainerRect != null)
			{
				if (this.m_FillImage != null && this.m_FillImage.type == Image.Type.Filled)
				{
					num = this.m_FillImage.fillAmount;
				}
				else
				{
					num = ((!this.reverseValue) ? this.m_FillRect.anchorMax[(int)this.axis] : (1f - this.m_FillRect.anchorMin[(int)this.axis]));
				}
			}
			else if (this.m_HandleContainerRect != null)
			{
				num = ((!this.reverseValue) ? this.m_HandleRect.anchorMin[(int)this.axis] : (1f - this.m_HandleRect.anchorMin[(int)this.axis]));
			}
			this.UpdateVisuals();
			if (num != this.normalizedValue)
			{
				this.onValueChanged.Invoke(this.m_Value);
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00013840 File Offset: 0x00011A40
		private void UpdateCachedReferences()
		{
			if (this.m_FillRect)
			{
				this.m_FillTransform = this.m_FillRect.transform;
				this.m_FillImage = this.m_FillRect.GetComponent<Image>();
				if (this.m_FillTransform.parent != null)
				{
					this.m_FillContainerRect = this.m_FillTransform.parent.GetComponent<RectTransform>();
				}
			}
			else
			{
				this.m_FillContainerRect = null;
				this.m_FillImage = null;
			}
			if (this.m_HandleRect)
			{
				this.m_HandleTransform = this.m_HandleRect.transform;
				if (this.m_HandleTransform.parent != null)
				{
					this.m_HandleContainerRect = this.m_HandleTransform.parent.GetComponent<RectTransform>();
				}
			}
			else
			{
				this.m_HandleContainerRect = null;
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00013918 File Offset: 0x00011B18
		private float ClampValue(float input)
		{
			float num = Mathf.Clamp(input, this.minValue, this.maxValue);
			if (this.wholeNumbers)
			{
				num = Mathf.Round(num);
			}
			return num;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0001394C File Offset: 0x00011B4C
		private void Set(float input)
		{
			this.Set(input, true);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00013958 File Offset: 0x00011B58
		protected virtual void Set(float input, bool sendCallback)
		{
			float num = this.ClampValue(input);
			if (this.m_Value == num)
			{
				return;
			}
			this.m_Value = num;
			this.UpdateVisuals();
			if (sendCallback)
			{
				this.m_OnValueChanged.Invoke(num);
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0001399C File Offset: 0x00011B9C
		protected override void OnRectTransformDimensionsChange()
		{
			base.OnRectTransformDimensionsChange();
			if (!this.IsActive())
			{
				return;
			}
			this.UpdateVisuals();
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x000139B8 File Offset: 0x00011BB8
		private Slider.Axis axis
		{
			get
			{
				return (this.m_Direction != Slider.Direction.LeftToRight && this.m_Direction != Slider.Direction.RightToLeft) ? Slider.Axis.Vertical : Slider.Axis.Horizontal;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x000139D8 File Offset: 0x00011BD8
		private bool reverseValue
		{
			get
			{
				return this.m_Direction == Slider.Direction.RightToLeft || this.m_Direction == Slider.Direction.TopToBottom;
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000139F4 File Offset: 0x00011BF4
		private void UpdateVisuals()
		{
			this.m_Tracker.Clear();
			if (this.m_FillContainerRect != null)
			{
				this.m_Tracker.Add(this, this.m_FillRect, DrivenTransformProperties.Anchors);
				Vector2 zero = Vector2.zero;
				Vector2 one = Vector2.one;
				if (this.m_FillImage != null && this.m_FillImage.type == Image.Type.Filled)
				{
					this.m_FillImage.fillAmount = this.normalizedValue;
				}
				else if (this.reverseValue)
				{
					zero[(int)this.axis] = 1f - this.normalizedValue;
				}
				else
				{
					one[(int)this.axis] = this.normalizedValue;
				}
				this.m_FillRect.anchorMin = zero;
				this.m_FillRect.anchorMax = one;
			}
			if (this.m_HandleContainerRect != null)
			{
				this.m_Tracker.Add(this, this.m_HandleRect, DrivenTransformProperties.Anchors);
				Vector2 zero2 = Vector2.zero;
				Vector2 one2 = Vector2.one;
				int axis = (int)this.axis;
				float num = ((!this.reverseValue) ? this.normalizedValue : (1f - this.normalizedValue));
				one2[(int)this.axis] = num;
				zero2[axis] = num;
				this.m_HandleRect.anchorMin = zero2;
				this.m_HandleRect.anchorMax = one2;
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00013B5C File Offset: 0x00011D5C
		private void UpdateDrag(PointerEventData eventData, Camera cam)
		{
			RectTransform rectTransform = this.m_HandleContainerRect ?? this.m_FillContainerRect;
			if (rectTransform != null && rectTransform.rect.size[(int)this.axis] > 0f)
			{
				Vector2 vector;
				if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, eventData.position, cam, out vector))
				{
					return;
				}
				vector -= rectTransform.rect.position;
				float num = Mathf.Clamp01((vector - this.m_Offset)[(int)this.axis] / rectTransform.rect.size[(int)this.axis]);
				this.normalizedValue = ((!this.reverseValue) ? num : (1f - num));
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00013C3C File Offset: 0x00011E3C
		private bool MayDrag(PointerEventData eventData)
		{
			return this.IsActive() && this.IsInteractable() && eventData.button == PointerEventData.InputButton.Left;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00013C6C File Offset: 0x00011E6C
		public override void OnPointerDown(PointerEventData eventData)
		{
			if (!this.MayDrag(eventData))
			{
				return;
			}
			base.OnPointerDown(eventData);
			this.m_Offset = Vector2.zero;
			if (this.m_HandleContainerRect != null && RectTransformUtility.RectangleContainsScreenPoint(this.m_HandleRect, eventData.position, eventData.enterEventCamera))
			{
				Vector2 vector;
				if (RectTransformUtility.ScreenPointToLocalPointInRectangle(this.m_HandleRect, eventData.position, eventData.pressEventCamera, out vector))
				{
					this.m_Offset = vector;
				}
			}
			else
			{
				this.UpdateDrag(eventData, eventData.pressEventCamera);
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00013CFC File Offset: 0x00011EFC
		public virtual void OnDrag(PointerEventData eventData)
		{
			if (!this.MayDrag(eventData))
			{
				return;
			}
			this.UpdateDrag(eventData, eventData.pressEventCamera);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00013D18 File Offset: 0x00011F18
		public override void OnMove(AxisEventData eventData)
		{
			if (!this.IsActive() || !this.IsInteractable())
			{
				base.OnMove(eventData);
				return;
			}
			switch (eventData.moveDir)
			{
			case MoveDirection.Left:
				if (this.axis == Slider.Axis.Horizontal && this.FindSelectableOnLeft() == null)
				{
					this.Set((!this.reverseValue) ? (this.value - this.stepSize) : (this.value + this.stepSize));
				}
				else
				{
					base.OnMove(eventData);
				}
				break;
			case MoveDirection.Up:
				if (this.axis == Slider.Axis.Vertical && this.FindSelectableOnUp() == null)
				{
					this.Set((!this.reverseValue) ? (this.value + this.stepSize) : (this.value - this.stepSize));
				}
				else
				{
					base.OnMove(eventData);
				}
				break;
			case MoveDirection.Right:
				if (this.axis == Slider.Axis.Horizontal && this.FindSelectableOnRight() == null)
				{
					this.Set((!this.reverseValue) ? (this.value + this.stepSize) : (this.value - this.stepSize));
				}
				else
				{
					base.OnMove(eventData);
				}
				break;
			case MoveDirection.Down:
				if (this.axis == Slider.Axis.Vertical && this.FindSelectableOnDown() == null)
				{
					this.Set((!this.reverseValue) ? (this.value - this.stepSize) : (this.value + this.stepSize));
				}
				else
				{
					base.OnMove(eventData);
				}
				break;
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00013EDC File Offset: 0x000120DC
		public override Selectable FindSelectableOnLeft()
		{
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Slider.Axis.Horizontal)
			{
				return null;
			}
			return base.FindSelectableOnLeft();
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00013F10 File Offset: 0x00012110
		public override Selectable FindSelectableOnRight()
		{
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Slider.Axis.Horizontal)
			{
				return null;
			}
			return base.FindSelectableOnRight();
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00013F44 File Offset: 0x00012144
		public override Selectable FindSelectableOnUp()
		{
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Slider.Axis.Vertical)
			{
				return null;
			}
			return base.FindSelectableOnUp();
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00013F7C File Offset: 0x0001217C
		public override Selectable FindSelectableOnDown()
		{
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Slider.Axis.Vertical)
			{
				return null;
			}
			return base.FindSelectableOnDown();
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00013FB4 File Offset: 0x000121B4
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			eventData.useDragThreshold = false;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00013FC0 File Offset: 0x000121C0
		public void SetDirection(Slider.Direction direction, bool includeRectLayouts)
		{
			Slider.Axis axis = this.axis;
			bool reverseValue = this.reverseValue;
			this.direction = direction;
			if (!includeRectLayouts)
			{
				return;
			}
			if (this.axis != axis)
			{
				RectTransformUtility.FlipLayoutAxes(base.transform as RectTransform, true, true);
			}
			if (this.reverseValue != reverseValue)
			{
				RectTransformUtility.FlipLayoutOnAxis(base.transform as RectTransform, (int)this.axis, true, true);
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0001402C File Offset: 0x0001222C
		virtual bool UnityEngine.UI.ICanvasElement.IsDestroyed()
		{
			return base.IsDestroyed();
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00014034 File Offset: 0x00012234
		virtual Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x040001FF RID: 511
		[SerializeField]
		private RectTransform m_FillRect;

		// Token: 0x04000200 RID: 512
		[SerializeField]
		private RectTransform m_HandleRect;

		// Token: 0x04000201 RID: 513
		[SerializeField]
		[Space]
		private Slider.Direction m_Direction;

		// Token: 0x04000202 RID: 514
		[SerializeField]
		private float m_MinValue;

		// Token: 0x04000203 RID: 515
		[SerializeField]
		private float m_MaxValue = 1f;

		// Token: 0x04000204 RID: 516
		[SerializeField]
		private bool m_WholeNumbers;

		// Token: 0x04000205 RID: 517
		[SerializeField]
		protected float m_Value;

		// Token: 0x04000206 RID: 518
		[Space]
		[SerializeField]
		private Slider.SliderEvent m_OnValueChanged = new Slider.SliderEvent();

		// Token: 0x04000207 RID: 519
		private Image m_FillImage;

		// Token: 0x04000208 RID: 520
		private Transform m_FillTransform;

		// Token: 0x04000209 RID: 521
		private RectTransform m_FillContainerRect;

		// Token: 0x0400020A RID: 522
		private Transform m_HandleTransform;

		// Token: 0x0400020B RID: 523
		private RectTransform m_HandleContainerRect;

		// Token: 0x0400020C RID: 524
		private Vector2 m_Offset = Vector2.zero;

		// Token: 0x0400020D RID: 525
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x02000073 RID: 115
		public enum Direction
		{
			// Token: 0x0400020F RID: 527
			LeftToRight,
			// Token: 0x04000210 RID: 528
			RightToLeft,
			// Token: 0x04000211 RID: 529
			BottomToTop,
			// Token: 0x04000212 RID: 530
			TopToBottom
		}

		// Token: 0x02000074 RID: 116
		[Serializable]
		public class SliderEvent : UnityEvent<float>
		{
		}

		// Token: 0x02000075 RID: 117
		private enum Axis
		{
			// Token: 0x04000214 RID: 532
			Horizontal,
			// Token: 0x04000215 RID: 533
			Vertical
		}
	}
}
