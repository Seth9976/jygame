using System;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000037 RID: 55
	[AddComponentMenu("UI/Button", 30)]
	public class Button : Selectable, IEventSystemHandler, IPointerClickHandler, ISubmitHandler
	{
		// Token: 0x06000161 RID: 353 RVA: 0x0000585C File Offset: 0x00003A5C
		protected Button()
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00005870 File Offset: 0x00003A70
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00005878 File Offset: 0x00003A78
		public Button.ButtonClickedEvent onClick
		{
			get
			{
				return this.m_OnClick;
			}
			set
			{
				this.m_OnClick = value;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00005884 File Offset: 0x00003A84
		private void Press()
		{
			if (!this.IsActive() || !this.IsInteractable())
			{
				return;
			}
			this.m_OnClick.Invoke();
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000058B4 File Offset: 0x00003AB4
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.Press();
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000058C8 File Offset: 0x00003AC8
		public virtual void OnSubmit(BaseEventData eventData)
		{
			this.Press();
			if (!this.IsActive() || !this.IsInteractable())
			{
				return;
			}
			this.DoStateTransition(Selectable.SelectionState.Pressed, false);
			base.StartCoroutine(this.OnFinishSubmit());
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00005908 File Offset: 0x00003B08
		private IEnumerator OnFinishSubmit()
		{
			float fadeTime = base.colors.fadeDuration;
			float elapsedTime = 0f;
			while (elapsedTime < fadeTime)
			{
				elapsedTime += Time.unscaledDeltaTime;
				yield return null;
			}
			this.DoStateTransition(base.currentSelectionState, false);
			yield break;
		}

		// Token: 0x040000A9 RID: 169
		[SerializeField]
		[FormerlySerializedAs("onClick")]
		private Button.ButtonClickedEvent m_OnClick = new Button.ButtonClickedEvent();

		// Token: 0x02000038 RID: 56
		[Serializable]
		public class ButtonClickedEvent : UnityEvent
		{
		}
	}
}
