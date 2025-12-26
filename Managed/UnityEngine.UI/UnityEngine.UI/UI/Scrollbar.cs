using System;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000066 RID: 102
	[AddComponentMenu("UI/Scrollbar", 34)]
	[RequireComponent(typeof(RectTransform))]
	public class Scrollbar : Selectable, IEventSystemHandler, IBeginDragHandler, IInitializePotentialDragHandler, IDragHandler, ICanvasElement
	{
		// Token: 0x06000344 RID: 836 RVA: 0x000101A8 File Offset: 0x0000E3A8
		protected Scrollbar()
		{
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000345 RID: 837 RVA: 0x000101D4 File Offset: 0x0000E3D4
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000101DC File Offset: 0x0000E3DC
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

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000347 RID: 839 RVA: 0x000101FC File Offset: 0x0000E3FC
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00010204 File Offset: 0x0000E404
		public Scrollbar.Direction direction
		{
			get
			{
				return this.m_Direction;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<Scrollbar.Direction>(ref this.m_Direction, value))
				{
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00010220 File Offset: 0x0000E420
		// (set) Token: 0x0600034A RID: 842 RVA: 0x0001025C File Offset: 0x0000E45C
		public float value
		{
			get
			{
				float num = this.m_Value;
				if (this.m_NumberOfSteps > 1)
				{
					num = Mathf.Round(num * (float)(this.m_NumberOfSteps - 1)) / (float)(this.m_NumberOfSteps - 1);
				}
				return num;
			}
			set
			{
				this.Set(value);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00010268 File Offset: 0x0000E468
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00010270 File Offset: 0x0000E470
		public float size
		{
			get
			{
				return this.m_Size;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_Size, Mathf.Clamp01(value)))
				{
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00010290 File Offset: 0x0000E490
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00010298 File Offset: 0x0000E498
		public int numberOfSteps
		{
			get
			{
				return this.m_NumberOfSteps;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<int>(ref this.m_NumberOfSteps, value))
				{
					this.Set(this.m_Value);
					this.UpdateVisuals();
				}
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600034F RID: 847 RVA: 0x000102C0 File Offset: 0x0000E4C0
		// (set) Token: 0x06000350 RID: 848 RVA: 0x000102C8 File Offset: 0x0000E4C8
		public Scrollbar.ScrollEvent onValueChanged
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

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000351 RID: 849 RVA: 0x000102D4 File Offset: 0x0000E4D4
		private float stepSize
		{
			get
			{
				return (this.m_NumberOfSteps <= 1) ? 0.1f : (1f / (float)(this.m_NumberOfSteps - 1));
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000102FC File Offset: 0x0000E4FC
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00010300 File Offset: 0x0000E500
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00010304 File Offset: 0x0000E504
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00010308 File Offset: 0x0000E508
		protected override void OnEnable()
		{
			base.OnEnable();
			this.UpdateCachedReferences();
			this.Set(this.m_Value, false);
			this.UpdateVisuals();
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0001032C File Offset: 0x0000E52C
		protected override void OnDisable()
		{
			this.m_Tracker.Clear();
			base.OnDisable();
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00010340 File Offset: 0x0000E540
		private void UpdateCachedReferences()
		{
			if (this.m_HandleRect && this.m_HandleRect.parent != null)
			{
				this.m_ContainerRect = this.m_HandleRect.parent.GetComponent<RectTransform>();
			}
			else
			{
				this.m_ContainerRect = null;
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00010398 File Offset: 0x0000E598
		private void Set(float input)
		{
			this.Set(input, true);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000103A4 File Offset: 0x0000E5A4
		private void Set(float input, bool sendCallback)
		{
			float value = this.m_Value;
			this.m_Value = Mathf.Clamp01(input);
			if (value == this.value)
			{
				return;
			}
			this.UpdateVisuals();
			if (sendCallback)
			{
				this.m_OnValueChanged.Invoke(this.value);
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000103F0 File Offset: 0x0000E5F0
		protected override void OnRectTransformDimensionsChange()
		{
			base.OnRectTransformDimensionsChange();
			if (!this.IsActive())
			{
				return;
			}
			this.UpdateVisuals();
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0001040C File Offset: 0x0000E60C
		private Scrollbar.Axis axis
		{
			get
			{
				return (this.m_Direction != Scrollbar.Direction.LeftToRight && this.m_Direction != Scrollbar.Direction.RightToLeft) ? Scrollbar.Axis.Vertical : Scrollbar.Axis.Horizontal;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0001042C File Offset: 0x0000E62C
		private bool reverseValue
		{
			get
			{
				return this.m_Direction == Scrollbar.Direction.RightToLeft || this.m_Direction == Scrollbar.Direction.TopToBottom;
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00010448 File Offset: 0x0000E648
		private void UpdateVisuals()
		{
			this.m_Tracker.Clear();
			if (this.m_ContainerRect != null)
			{
				this.m_Tracker.Add(this, this.m_HandleRect, DrivenTransformProperties.Anchors);
				Vector2 zero = Vector2.zero;
				Vector2 one = Vector2.one;
				float num = this.value * (1f - this.size);
				if (this.reverseValue)
				{
					zero[(int)this.axis] = 1f - num - this.size;
					one[(int)this.axis] = 1f - num;
				}
				else
				{
					zero[(int)this.axis] = num;
					one[(int)this.axis] = num + this.size;
				}
				this.m_HandleRect.anchorMin = zero;
				this.m_HandleRect.anchorMax = one;
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00010524 File Offset: 0x0000E724
		private void UpdateDrag(PointerEventData eventData)
		{
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			if (this.m_ContainerRect == null)
			{
				return;
			}
			Vector2 vector;
			if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(this.m_ContainerRect, eventData.position, eventData.pressEventCamera, out vector))
			{
				return;
			}
			Vector2 vector2 = vector - this.m_Offset - this.m_ContainerRect.rect.position;
			Vector2 vector3 = vector2 - (this.m_HandleRect.rect.size - this.m_HandleRect.sizeDelta) * 0.5f;
			float num = ((this.axis != Scrollbar.Axis.Horizontal) ? this.m_ContainerRect.rect.height : this.m_ContainerRect.rect.width);
			float num2 = num * (1f - this.size);
			if (num2 <= 0f)
			{
				return;
			}
			switch (this.m_Direction)
			{
			case Scrollbar.Direction.LeftToRight:
				this.Set(vector3.x / num2);
				break;
			case Scrollbar.Direction.RightToLeft:
				this.Set(1f - vector3.x / num2);
				break;
			case Scrollbar.Direction.BottomToTop:
				this.Set(vector3.y / num2);
				break;
			case Scrollbar.Direction.TopToBottom:
				this.Set(1f - vector3.y / num2);
				break;
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000106A4 File Offset: 0x0000E8A4
		private bool MayDrag(PointerEventData eventData)
		{
			return this.IsActive() && this.IsInteractable() && eventData.button == PointerEventData.InputButton.Left;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000106D4 File Offset: 0x0000E8D4
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			this.isPointerDownAndNotDragging = false;
			if (!this.MayDrag(eventData))
			{
				return;
			}
			if (this.m_ContainerRect == null)
			{
				return;
			}
			this.m_Offset = Vector2.zero;
			Vector2 vector;
			if (RectTransformUtility.RectangleContainsScreenPoint(this.m_HandleRect, eventData.position, eventData.enterEventCamera) && RectTransformUtility.ScreenPointToLocalPointInRectangle(this.m_HandleRect, eventData.position, eventData.pressEventCamera, out vector))
			{
				this.m_Offset = vector - this.m_HandleRect.rect.center;
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0001076C File Offset: 0x0000E96C
		public virtual void OnDrag(PointerEventData eventData)
		{
			if (!this.MayDrag(eventData))
			{
				return;
			}
			if (this.m_ContainerRect != null)
			{
				this.UpdateDrag(eventData);
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00010794 File Offset: 0x0000E994
		public override void OnPointerDown(PointerEventData eventData)
		{
			if (!this.MayDrag(eventData))
			{
				return;
			}
			base.OnPointerDown(eventData);
			this.isPointerDownAndNotDragging = true;
			this.m_PointerDownRepeat = base.StartCoroutine(this.ClickRepeat(eventData));
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000107D0 File Offset: 0x0000E9D0
		protected IEnumerator ClickRepeat(PointerEventData eventData)
		{
			while (this.isPointerDownAndNotDragging)
			{
				Vector2 localMousePos;
				if (!RectTransformUtility.RectangleContainsScreenPoint(this.m_HandleRect, eventData.position, eventData.enterEventCamera) && RectTransformUtility.ScreenPointToLocalPointInRectangle(this.m_HandleRect, eventData.position, eventData.pressEventCamera, out localMousePos))
				{
					float axisCoordinate = ((this.axis != Scrollbar.Axis.Horizontal) ? localMousePos.y : localMousePos.x);
					if (axisCoordinate < 0f)
					{
						this.value -= this.size;
					}
					else
					{
						this.value += this.size;
					}
				}
				yield return new WaitForEndOfFrame();
			}
			base.StopCoroutine(this.m_PointerDownRepeat);
			yield break;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000107FC File Offset: 0x0000E9FC
		public override void OnPointerUp(PointerEventData eventData)
		{
			base.OnPointerUp(eventData);
			this.isPointerDownAndNotDragging = false;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0001080C File Offset: 0x0000EA0C
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
				if (this.axis == Scrollbar.Axis.Horizontal && this.FindSelectableOnLeft() == null)
				{
					this.Set((!this.reverseValue) ? (this.value - this.stepSize) : (this.value + this.stepSize));
				}
				else
				{
					base.OnMove(eventData);
				}
				break;
			case MoveDirection.Up:
				if (this.axis == Scrollbar.Axis.Vertical && this.FindSelectableOnUp() == null)
				{
					this.Set((!this.reverseValue) ? (this.value + this.stepSize) : (this.value - this.stepSize));
				}
				else
				{
					base.OnMove(eventData);
				}
				break;
			case MoveDirection.Right:
				if (this.axis == Scrollbar.Axis.Horizontal && this.FindSelectableOnRight() == null)
				{
					this.Set((!this.reverseValue) ? (this.value + this.stepSize) : (this.value - this.stepSize));
				}
				else
				{
					base.OnMove(eventData);
				}
				break;
			case MoveDirection.Down:
				if (this.axis == Scrollbar.Axis.Vertical && this.FindSelectableOnDown() == null)
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

		// Token: 0x06000366 RID: 870 RVA: 0x000109D0 File Offset: 0x0000EBD0
		public override Selectable FindSelectableOnLeft()
		{
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Scrollbar.Axis.Horizontal)
			{
				return null;
			}
			return base.FindSelectableOnLeft();
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00010A04 File Offset: 0x0000EC04
		public override Selectable FindSelectableOnRight()
		{
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Scrollbar.Axis.Horizontal)
			{
				return null;
			}
			return base.FindSelectableOnRight();
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00010A38 File Offset: 0x0000EC38
		public override Selectable FindSelectableOnUp()
		{
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Scrollbar.Axis.Vertical)
			{
				return null;
			}
			return base.FindSelectableOnUp();
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00010A70 File Offset: 0x0000EC70
		public override Selectable FindSelectableOnDown()
		{
			if (base.navigation.mode == Navigation.Mode.Automatic && this.axis == Scrollbar.Axis.Vertical)
			{
				return null;
			}
			return base.FindSelectableOnDown();
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00010AA8 File Offset: 0x0000ECA8
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			eventData.useDragThreshold = false;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00010AB4 File Offset: 0x0000ECB4
		public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts)
		{
			Scrollbar.Axis axis = this.axis;
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

		// Token: 0x0600036C RID: 876 RVA: 0x00010B20 File Offset: 0x0000ED20
		virtual bool UnityEngine.UI.ICanvasElement.IsDestroyed()
		{
			return base.IsDestroyed();
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00010B28 File Offset: 0x0000ED28
		virtual Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x040001A7 RID: 423
		[SerializeField]
		private RectTransform m_HandleRect;

		// Token: 0x040001A8 RID: 424
		[SerializeField]
		private Scrollbar.Direction m_Direction;

		// Token: 0x040001A9 RID: 425
		[SerializeField]
		[Range(0f, 1f)]
		private float m_Value;

		// Token: 0x040001AA RID: 426
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Size = 0.2f;

		// Token: 0x040001AB RID: 427
		[SerializeField]
		[Range(0f, 11f)]
		private int m_NumberOfSteps;

		// Token: 0x040001AC RID: 428
		[SerializeField]
		[Space(6f)]
		private Scrollbar.ScrollEvent m_OnValueChanged = new Scrollbar.ScrollEvent();

		// Token: 0x040001AD RID: 429
		private RectTransform m_ContainerRect;

		// Token: 0x040001AE RID: 430
		private Vector2 m_Offset = Vector2.zero;

		// Token: 0x040001AF RID: 431
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x040001B0 RID: 432
		private Coroutine m_PointerDownRepeat;

		// Token: 0x040001B1 RID: 433
		private bool isPointerDownAndNotDragging;

		// Token: 0x02000067 RID: 103
		public enum Direction
		{
			// Token: 0x040001B3 RID: 435
			LeftToRight,
			// Token: 0x040001B4 RID: 436
			RightToLeft,
			// Token: 0x040001B5 RID: 437
			BottomToTop,
			// Token: 0x040001B6 RID: 438
			TopToBottom
		}

		// Token: 0x02000068 RID: 104
		[Serializable]
		public class ScrollEvent : UnityEvent<float>
		{
		}

		// Token: 0x02000069 RID: 105
		private enum Axis
		{
			// Token: 0x040001B8 RID: 440
			Horizontal,
			// Token: 0x040001B9 RID: 441
			Vertical
		}
	}
}
