using System;

namespace UnityEngine
{
	// Token: 0x020002D2 RID: 722
	internal struct SliderHandler
	{
		// Token: 0x060021C6 RID: 8646 RVA: 0x000298D8 File Offset: 0x00027AD8
		public SliderHandler(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id)
		{
			this.position = position;
			this.currentValue = currentValue;
			this.size = size;
			this.start = start;
			this.end = end;
			this.slider = slider;
			this.thumb = thumb;
			this.horiz = horiz;
			this.id = id;
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x0002992C File Offset: 0x00027B2C
		public float Handle()
		{
			if (this.slider == null || this.thumb == null)
			{
				return this.currentValue;
			}
			switch (this.CurrentEventType())
			{
			case EventType.MouseDown:
				return this.OnMouseDown();
			case EventType.MouseUp:
				return this.OnMouseUp();
			case EventType.MouseDrag:
				return this.OnMouseDrag();
			case EventType.Repaint:
				return this.OnRepaint();
			}
			return this.currentValue;
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x000299AC File Offset: 0x00027BAC
		private float OnMouseDown()
		{
			if (!this.position.Contains(this.CurrentEvent().mousePosition) || this.IsEmptySlider())
			{
				return this.currentValue;
			}
			GUI.scrollTroughSide = 0;
			GUIUtility.hotControl = this.id;
			this.CurrentEvent().Use();
			if (this.ThumbSelectionRect().Contains(this.CurrentEvent().mousePosition))
			{
				this.StartDraggingWithValue(this.ClampedCurrentValue());
				return this.currentValue;
			}
			GUI.changed = true;
			if (this.SupportsPageMovements())
			{
				this.SliderState().isDragging = false;
				GUI.nextScrollStepTime = SystemClock.now.AddMilliseconds(250.0);
				GUI.scrollTroughSide = this.CurrentScrollTroughSide();
				return this.PageMovementValue();
			}
			float num = this.ValueForCurrentMousePosition();
			this.StartDraggingWithValue(num);
			return this.Clamp(num);
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00029A98 File Offset: 0x00027C98
		private float OnMouseDrag()
		{
			if (GUIUtility.hotControl != this.id)
			{
				return this.currentValue;
			}
			SliderState sliderState = this.SliderState();
			if (!sliderState.isDragging)
			{
				return this.currentValue;
			}
			GUI.changed = true;
			this.CurrentEvent().Use();
			float num = this.MousePosition() - sliderState.dragStartPos;
			float num2 = sliderState.dragStartValue + num / this.ValuesPerPixel();
			return this.Clamp(num2);
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x0000D917 File Offset: 0x0000BB17
		private float OnMouseUp()
		{
			if (GUIUtility.hotControl == this.id)
			{
				this.CurrentEvent().Use();
				GUIUtility.hotControl = 0;
			}
			return this.currentValue;
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00029B0C File Offset: 0x00027D0C
		private float OnRepaint()
		{
			this.slider.Draw(this.position, GUIContent.none, this.id);
			if (!this.IsEmptySlider())
			{
				this.thumb.Draw(this.ThumbRect(), GUIContent.none, this.id);
			}
			if (GUIUtility.hotControl != this.id || !this.position.Contains(this.CurrentEvent().mousePosition) || this.IsEmptySlider())
			{
				return this.currentValue;
			}
			if (this.ThumbRect().Contains(this.CurrentEvent().mousePosition))
			{
				if (GUI.scrollTroughSide != 0)
				{
					GUIUtility.hotControl = 0;
				}
				return this.currentValue;
			}
			GUI.InternalRepaintEditorWindow();
			if (SystemClock.now < GUI.nextScrollStepTime)
			{
				return this.currentValue;
			}
			if (this.CurrentScrollTroughSide() != GUI.scrollTroughSide)
			{
				return this.currentValue;
			}
			GUI.nextScrollStepTime = SystemClock.now.AddMilliseconds(30.0);
			if (this.SupportsPageMovements())
			{
				this.SliderState().isDragging = false;
				GUI.changed = true;
				return this.PageMovementValue();
			}
			return this.ClampedCurrentValue();
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x0000D940 File Offset: 0x0000BB40
		private EventType CurrentEventType()
		{
			return this.CurrentEvent().GetTypeForControl(this.id);
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00029C50 File Offset: 0x00027E50
		private int CurrentScrollTroughSide()
		{
			float num = ((!this.horiz) ? this.CurrentEvent().mousePosition.y : this.CurrentEvent().mousePosition.x);
			float num2 = ((!this.horiz) ? this.ThumbRect().y : this.ThumbRect().x);
			return (num <= num2) ? (-1) : 1;
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x0000D953 File Offset: 0x0000BB53
		private bool IsEmptySlider()
		{
			return this.start == this.end;
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x0000D963 File Offset: 0x0000BB63
		private bool SupportsPageMovements()
		{
			return this.size != 0f && GUI.usePageScrollbars;
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x00029CD4 File Offset: 0x00027ED4
		private float PageMovementValue()
		{
			float num = this.currentValue;
			int num2 = ((this.start <= this.end) ? 1 : (-1));
			if (this.MousePosition() > this.PageUpMovementBound())
			{
				num += this.size * (float)num2 * 0.9f;
			}
			else
			{
				num -= this.size * (float)num2 * 0.9f;
			}
			return this.Clamp(num);
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x00029D44 File Offset: 0x00027F44
		private float PageUpMovementBound()
		{
			if (this.horiz)
			{
				return this.ThumbRect().xMax - this.position.x;
			}
			return this.ThumbRect().yMax - this.position.y;
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x0000D97D File Offset: 0x0000BB7D
		private Event CurrentEvent()
		{
			return Event.current;
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x00029D98 File Offset: 0x00027F98
		private float ValueForCurrentMousePosition()
		{
			if (this.horiz)
			{
				return (this.MousePosition() - this.ThumbRect().width * 0.5f) / this.ValuesPerPixel() + this.start - this.size * 0.5f;
			}
			return (this.MousePosition() - this.ThumbRect().height * 0.5f) / this.ValuesPerPixel() + this.start - this.size * 0.5f;
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x0000D984 File Offset: 0x0000BB84
		private float Clamp(float value)
		{
			return Mathf.Clamp(value, this.MinValue(), this.MaxValue());
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x00029E20 File Offset: 0x00028020
		private Rect ThumbSelectionRect()
		{
			return this.ThumbRect();
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x00029E38 File Offset: 0x00028038
		private void StartDraggingWithValue(float dragStartValue)
		{
			SliderState sliderState = this.SliderState();
			sliderState.dragStartPos = this.MousePosition();
			sliderState.dragStartValue = dragStartValue;
			sliderState.isDragging = true;
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0000D998 File Offset: 0x0000BB98
		private SliderState SliderState()
		{
			return (SliderState)GUIUtility.GetStateObject(typeof(SliderState), this.id);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x0000D9B4 File Offset: 0x0000BBB4
		private Rect ThumbRect()
		{
			return (!this.horiz) ? this.VerticalThumbRect() : this.HorizontalThumbRect();
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x00029E68 File Offset: 0x00028068
		private Rect VerticalThumbRect()
		{
			float num = this.ValuesPerPixel();
			if (this.start < this.end)
			{
				return new Rect(this.position.x + (float)this.slider.padding.left, (this.ClampedCurrentValue() - this.start) * num + this.position.y + (float)this.slider.padding.top, this.position.width - (float)this.slider.padding.horizontal, this.size * num + this.ThumbSize());
			}
			return new Rect(this.position.x + (float)this.slider.padding.left, (this.ClampedCurrentValue() + this.size - this.start) * num + this.position.y + (float)this.slider.padding.top, this.position.width - (float)this.slider.padding.horizontal, this.size * -num + this.ThumbSize());
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x00029FA4 File Offset: 0x000281A4
		private Rect HorizontalThumbRect()
		{
			float num = this.ValuesPerPixel();
			if (this.start < this.end)
			{
				return new Rect((this.ClampedCurrentValue() - this.start) * num + this.position.x + (float)this.slider.padding.left, this.position.y + (float)this.slider.padding.top, this.size * num + this.ThumbSize(), this.position.height - (float)this.slider.padding.vertical);
			}
			return new Rect((this.ClampedCurrentValue() + this.size - this.start) * num + this.position.x + (float)this.slider.padding.left, this.position.y, this.size * -num + this.ThumbSize(), this.position.height);
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x0000D9D2 File Offset: 0x0000BBD2
		private float ClampedCurrentValue()
		{
			return this.Clamp(this.currentValue);
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x0002A0BC File Offset: 0x000282BC
		private float MousePosition()
		{
			if (this.horiz)
			{
				return this.CurrentEvent().mousePosition.x - this.position.x;
			}
			return this.CurrentEvent().mousePosition.y - this.position.y;
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x0002A11C File Offset: 0x0002831C
		private float ValuesPerPixel()
		{
			if (this.horiz)
			{
				return (this.position.width - (float)this.slider.padding.horizontal - this.ThumbSize()) / (this.end - this.start);
			}
			return (this.position.height - (float)this.slider.padding.vertical - this.ThumbSize()) / (this.end - this.start);
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x0002A1A0 File Offset: 0x000283A0
		private float ThumbSize()
		{
			if (this.horiz)
			{
				return (this.thumb.fixedWidth == 0f) ? ((float)this.thumb.padding.horizontal) : this.thumb.fixedWidth;
			}
			return (this.thumb.fixedHeight == 0f) ? ((float)this.thumb.padding.vertical) : this.thumb.fixedHeight;
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		private float MaxValue()
		{
			return Mathf.Max(this.start, this.end) - this.size;
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x0000D9FA File Offset: 0x0000BBFA
		private float MinValue()
		{
			return Mathf.Min(this.start, this.end);
		}

		// Token: 0x04000AF4 RID: 2804
		private readonly Rect position;

		// Token: 0x04000AF5 RID: 2805
		private readonly float currentValue;

		// Token: 0x04000AF6 RID: 2806
		private readonly float size;

		// Token: 0x04000AF7 RID: 2807
		private readonly float start;

		// Token: 0x04000AF8 RID: 2808
		private readonly float end;

		// Token: 0x04000AF9 RID: 2809
		private readonly GUIStyle slider;

		// Token: 0x04000AFA RID: 2810
		private readonly GUIStyle thumb;

		// Token: 0x04000AFB RID: 2811
		private readonly bool horiz;

		// Token: 0x04000AFC RID: 2812
		private readonly int id;
	}
}
