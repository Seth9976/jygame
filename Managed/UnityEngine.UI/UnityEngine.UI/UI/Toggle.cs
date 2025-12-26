using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200007A RID: 122
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Toggle", 31)]
	public class Toggle : Selectable, IEventSystemHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement
	{
		// Token: 0x06000473 RID: 1139 RVA: 0x00014FE8 File Offset: 0x000131E8
		protected Toggle()
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00015004 File Offset: 0x00013204
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x0001500C File Offset: 0x0001320C
		public ToggleGroup group
		{
			get
			{
				return this.m_Group;
			}
			set
			{
				this.m_Group = value;
				this.SetToggleGroup(this.m_Group, true);
				this.PlayEffect(true);
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001502C File Offset: 0x0001322C
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00015030 File Offset: 0x00013230
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00015034 File Offset: 0x00013234
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00015038 File Offset: 0x00013238
		protected override void OnEnable()
		{
			base.OnEnable();
			this.SetToggleGroup(this.m_Group, false);
			this.PlayEffect(true);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00015054 File Offset: 0x00013254
		protected override void OnDisable()
		{
			this.SetToggleGroup(null, false);
			base.OnDisable();
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00015064 File Offset: 0x00013264
		protected override void OnDidApplyAnimationProperties()
		{
			if (this.graphic != null)
			{
				bool flag = !Mathf.Approximately(this.graphic.canvasRenderer.GetColor().a, 0f);
				if (this.m_IsOn != flag)
				{
					this.m_IsOn = flag;
					this.Set(!flag);
				}
			}
			base.OnDidApplyAnimationProperties();
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x000150CC File Offset: 0x000132CC
		private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue)
		{
			ToggleGroup group = this.m_Group;
			if (this.m_Group != null)
			{
				this.m_Group.UnregisterToggle(this);
			}
			if (setMemberValue)
			{
				this.m_Group = newGroup;
			}
			if (this.m_Group != null && this.IsActive())
			{
				this.m_Group.RegisterToggle(this);
			}
			if (newGroup != null && newGroup != group && this.isOn && this.IsActive())
			{
				this.m_Group.NotifyToggleOn(this);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0001516C File Offset: 0x0001336C
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00015174 File Offset: 0x00013374
		public bool isOn
		{
			get
			{
				return this.m_IsOn;
			}
			set
			{
				this.Set(value);
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00015180 File Offset: 0x00013380
		private void Set(bool value)
		{
			this.Set(value, true);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001518C File Offset: 0x0001338C
		private void Set(bool value, bool sendCallback)
		{
			if (this.m_IsOn == value)
			{
				return;
			}
			this.m_IsOn = value;
			if (this.m_Group != null && this.IsActive() && (this.m_IsOn || (!this.m_Group.AnyTogglesOn() && !this.m_Group.allowSwitchOff)))
			{
				this.m_IsOn = true;
				this.m_Group.NotifyToggleOn(this);
			}
			this.PlayEffect(this.toggleTransition == Toggle.ToggleTransition.None);
			if (sendCallback)
			{
				this.onValueChanged.Invoke(this.m_IsOn);
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00015230 File Offset: 0x00013430
		private void PlayEffect(bool instant)
		{
			if (this.graphic == null)
			{
				return;
			}
			this.graphic.CrossFadeAlpha((!this.m_IsOn) ? 0f : 1f, (!instant) ? 0.1f : 0f, true);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0001528C File Offset: 0x0001348C
		protected override void Start()
		{
			this.PlayEffect(true);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00015298 File Offset: 0x00013498
		private void InternalToggle()
		{
			if (!this.IsActive() || !this.IsInteractable())
			{
				return;
			}
			this.isOn = !this.isOn;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000152CC File Offset: 0x000134CC
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.InternalToggle();
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000152E0 File Offset: 0x000134E0
		public virtual void OnSubmit(BaseEventData eventData)
		{
			this.InternalToggle();
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x000152E8 File Offset: 0x000134E8
		virtual bool UnityEngine.UI.ICanvasElement.IsDestroyed()
		{
			return base.IsDestroyed();
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000152F0 File Offset: 0x000134F0
		virtual Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x0400022B RID: 555
		public Toggle.ToggleTransition toggleTransition = Toggle.ToggleTransition.Fade;

		// Token: 0x0400022C RID: 556
		public Graphic graphic;

		// Token: 0x0400022D RID: 557
		[SerializeField]
		private ToggleGroup m_Group;

		// Token: 0x0400022E RID: 558
		public Toggle.ToggleEvent onValueChanged = new Toggle.ToggleEvent();

		// Token: 0x0400022F RID: 559
		[Tooltip("Is the toggle currently on or off?")]
		[SerializeField]
		[FormerlySerializedAs("m_IsActive")]
		private bool m_IsOn;

		// Token: 0x0200007B RID: 123
		public enum ToggleTransition
		{
			// Token: 0x04000231 RID: 561
			None,
			// Token: 0x04000232 RID: 562
			Fade
		}

		// Token: 0x0200007C RID: 124
		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
		}
	}
}
