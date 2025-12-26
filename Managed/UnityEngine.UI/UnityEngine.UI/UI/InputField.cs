using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000055 RID: 85
	[AddComponentMenu("UI/Input Field", 31)]
	public class InputField : Selectable, IEventSystemHandler, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IUpdateSelectedHandler, ISubmitHandler, ICanvasElement
	{
		// Token: 0x0600027D RID: 637 RVA: 0x0000BD14 File Offset: 0x00009F14
		protected InputField()
		{
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000BDAC File Offset: 0x00009FAC
		protected Mesh mesh
		{
			get
			{
				if (this.m_Mesh == null)
				{
					this.m_Mesh = new Mesh();
				}
				return this.m_Mesh;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000BDDC File Offset: 0x00009FDC
		protected TextGenerator cachedInputTextGenerator
		{
			get
			{
				if (this.m_InputTextCache == null)
				{
					this.m_InputTextCache = new TextGenerator();
				}
				return this.m_InputTextCache;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000BE0C File Offset: 0x0000A00C
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0000BDFC File Offset: 0x00009FFC
		public bool shouldHideMobileInput
		{
			get
			{
				RuntimePlatform platform = Application.platform;
				switch (platform)
				{
				case RuntimePlatform.IPhonePlayer:
				case RuntimePlatform.Android:
					break;
				default:
					if (platform != RuntimePlatform.BlackBerryPlayer && platform != RuntimePlatform.TizenPlayer)
					{
						return true;
					}
					break;
				}
				return this.m_HideMobileInput;
			}
			set
			{
				SetPropertyUtility.SetStruct<bool>(ref this.m_HideMobileInput, value);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0000BE54 File Offset: 0x0000A054
		// (set) Token: 0x06000284 RID: 644 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
		public string text
		{
			get
			{
				if (this.m_Keyboard != null && this.m_Keyboard.active && !this.InPlaceEditing() && EventSystem.current.currentSelectedGameObject == base.gameObject)
				{
					return this.m_Keyboard.text;
				}
				return this.m_Text;
			}
			set
			{
				if (this.text == value)
				{
					return;
				}
				this.m_Text = value;
				if (this.m_Keyboard != null)
				{
					this.m_Keyboard.text = this.m_Text;
				}
				if (this.m_CaretPosition > this.m_Text.Length)
				{
					this.m_CaretPosition = (this.m_CaretSelectPosition = this.m_Text.Length);
				}
				this.SendOnValueChangedAndUpdateLabel();
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000BF2C File Offset: 0x0000A12C
		public bool isFocused
		{
			get
			{
				return this.m_AllowInput;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000BF34 File Offset: 0x0000A134
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0000BF3C File Offset: 0x0000A13C
		public float caretBlinkRate
		{
			get
			{
				return this.m_CaretBlinkRate;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_CaretBlinkRate, value) && this.m_AllowInput)
				{
					this.SetCaretActive();
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000BF6C File Offset: 0x0000A16C
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0000BF74 File Offset: 0x0000A174
		public Text textComponent
		{
			get
			{
				return this.m_TextComponent;
			}
			set
			{
				SetPropertyUtility.SetClass<Text>(ref this.m_TextComponent, value);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000BF84 File Offset: 0x0000A184
		// (set) Token: 0x0600028B RID: 651 RVA: 0x0000BF8C File Offset: 0x0000A18C
		public Graphic placeholder
		{
			get
			{
				return this.m_Placeholder;
			}
			set
			{
				SetPropertyUtility.SetClass<Graphic>(ref this.m_Placeholder, value);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000BF9C File Offset: 0x0000A19C
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
		public Color selectionColor
		{
			get
			{
				return this.m_SelectionColor;
			}
			set
			{
				SetPropertyUtility.SetColor(ref this.m_SelectionColor, value);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0000BFBC File Offset: 0x0000A1BC
		public InputField.SubmitEvent onEndEdit
		{
			get
			{
				return this.m_EndEdit;
			}
			set
			{
				SetPropertyUtility.SetClass<InputField.SubmitEvent>(ref this.m_EndEdit, value);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0000BFD4 File Offset: 0x0000A1D4
		public InputField.OnChangeEvent onValueChange
		{
			get
			{
				return this.m_OnValueChange;
			}
			set
			{
				SetPropertyUtility.SetClass<InputField.OnChangeEvent>(ref this.m_OnValueChange, value);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0000BFEC File Offset: 0x0000A1EC
		public InputField.OnValidateInput onValidateInput
		{
			get
			{
				return this.m_OnValidateInput;
			}
			set
			{
				SetPropertyUtility.SetClass<InputField.OnValidateInput>(ref this.m_OnValidateInput, value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000BFFC File Offset: 0x0000A1FC
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0000C004 File Offset: 0x0000A204
		public int characterLimit
		{
			get
			{
				return this.m_CharacterLimit;
			}
			set
			{
				SetPropertyUtility.SetStruct<int>(ref this.m_CharacterLimit, value);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000C014 File Offset: 0x0000A214
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000C01C File Offset: 0x0000A21C
		public InputField.ContentType contentType
		{
			get
			{
				return this.m_ContentType;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<InputField.ContentType>(ref this.m_ContentType, value))
				{
					this.EnforceContentType();
				}
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000C038 File Offset: 0x0000A238
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0000C040 File Offset: 0x0000A240
		public InputField.LineType lineType
		{
			get
			{
				return this.m_LineType;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<InputField.LineType>(ref this.m_LineType, value))
				{
					this.SetToCustomIfContentTypeIsNot(new InputField.ContentType[]
					{
						InputField.ContentType.Standard,
						InputField.ContentType.Autocorrected
					});
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000C064 File Offset: 0x0000A264
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0000C06C File Offset: 0x0000A26C
		public InputField.InputType inputType
		{
			get
			{
				return this.m_InputType;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<InputField.InputType>(ref this.m_InputType, value))
				{
					this.SetToCustom();
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000C088 File Offset: 0x0000A288
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0000C090 File Offset: 0x0000A290
		public TouchScreenKeyboardType keyboardType
		{
			get
			{
				return this.m_KeyboardType;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<TouchScreenKeyboardType>(ref this.m_KeyboardType, value))
				{
					this.SetToCustom();
				}
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000C0AC File Offset: 0x0000A2AC
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		public InputField.CharacterValidation characterValidation
		{
			get
			{
				return this.m_CharacterValidation;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<InputField.CharacterValidation>(ref this.m_CharacterValidation, value))
				{
					this.SetToCustom();
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		public bool multiLine
		{
			get
			{
				return this.m_LineType == InputField.LineType.MultiLineNewline || this.lineType == InputField.LineType.MultiLineSubmit;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000C0EC File Offset: 0x0000A2EC
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x0000C0F4 File Offset: 0x0000A2F4
		public char asteriskChar
		{
			get
			{
				return this.m_AsteriskChar;
			}
			set
			{
				SetPropertyUtility.SetStruct<char>(ref this.m_AsteriskChar, value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000C104 File Offset: 0x0000A304
		public bool wasCanceled
		{
			get
			{
				return this.m_WasCanceled;
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000C10C File Offset: 0x0000A30C
		protected void ClampPos(ref int pos)
		{
			if (pos < 0)
			{
				pos = 0;
			}
			else if (pos > this.text.Length)
			{
				pos = this.text.Length;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000C148 File Offset: 0x0000A348
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x0000C15C File Offset: 0x0000A35C
		protected int caretPositionInternal
		{
			get
			{
				return this.m_CaretPosition + Input.compositionString.Length;
			}
			set
			{
				this.m_CaretPosition = value;
				this.ClampPos(ref this.m_CaretPosition);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000C174 File Offset: 0x0000A374
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000C188 File Offset: 0x0000A388
		protected int caretSelectPositionInternal
		{
			get
			{
				return this.m_CaretSelectPosition + Input.compositionString.Length;
			}
			set
			{
				this.m_CaretSelectPosition = value;
				this.ClampPos(ref this.m_CaretSelectPosition);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
		private bool hasSelection
		{
			get
			{
				return this.caretPositionInternal != this.caretSelectPositionInternal;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
		// (set) Token: 0x060002AB RID: 683 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		public int caretPosition
		{
			get
			{
				return this.m_CaretSelectPosition + Input.compositionString.Length;
			}
			set
			{
				this.selectionAnchorPosition = value;
				this.selectionFocusPosition = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000C1D8 File Offset: 0x0000A3D8
		// (set) Token: 0x060002AD RID: 685 RVA: 0x0000C1EC File Offset: 0x0000A3EC
		public int selectionAnchorPosition
		{
			get
			{
				return this.m_CaretPosition + Input.compositionString.Length;
			}
			set
			{
				if (Input.compositionString.Length != 0)
				{
					return;
				}
				this.m_CaretPosition = value;
				this.ClampPos(ref this.m_CaretPosition);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000C214 File Offset: 0x0000A414
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0000C228 File Offset: 0x0000A428
		public int selectionFocusPosition
		{
			get
			{
				return this.m_CaretSelectPosition + Input.compositionString.Length;
			}
			set
			{
				if (Input.compositionString.Length != 0)
				{
					return;
				}
				this.m_CaretSelectPosition = value;
				this.ClampPos(ref this.m_CaretSelectPosition);
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000C250 File Offset: 0x0000A450
		protected override void OnEnable()
		{
			base.OnEnable();
			if (this.m_Text == null)
			{
				this.m_Text = string.Empty;
			}
			this.m_DrawStart = 0;
			this.m_DrawEnd = this.m_Text.Length;
			if (this.m_TextComponent != null)
			{
				this.m_TextComponent.RegisterDirtyVerticesCallback(new UnityAction(this.MarkGeometryAsDirty));
				this.m_TextComponent.RegisterDirtyVerticesCallback(new UnityAction(this.UpdateLabel));
				this.UpdateLabel();
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
		protected override void OnDisable()
		{
			this.m_BlinkCoroutine = null;
			this.DeactivateInputField();
			if (this.m_TextComponent != null)
			{
				this.m_TextComponent.UnregisterDirtyVerticesCallback(new UnityAction(this.MarkGeometryAsDirty));
				this.m_TextComponent.UnregisterDirtyVerticesCallback(new UnityAction(this.UpdateLabel));
			}
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			if (this.m_CachedInputRenderer)
			{
				this.m_CachedInputRenderer.SetMesh(null);
			}
			if (this.m_Mesh)
			{
				Object.DestroyImmediate(this.m_Mesh);
			}
			this.m_Mesh = null;
			base.OnDisable();
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000C37C File Offset: 0x0000A57C
		private IEnumerator CaretBlink()
		{
			this.m_CaretVisible = true;
			yield return null;
			while (this.isFocused && this.m_CaretBlinkRate > 0f)
			{
				float blinkPeriod = 1f / this.m_CaretBlinkRate;
				bool blinkState = (Time.unscaledTime - this.m_BlinkStartTime) % blinkPeriod < blinkPeriod / 2f;
				if (this.m_CaretVisible != blinkState)
				{
					this.m_CaretVisible = blinkState;
					this.UpdateGeometry();
				}
				yield return null;
			}
			this.m_BlinkCoroutine = null;
			yield break;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000C398 File Offset: 0x0000A598
		private void SetCaretVisible()
		{
			if (!this.m_AllowInput)
			{
				return;
			}
			this.m_CaretVisible = true;
			this.m_BlinkStartTime = Time.unscaledTime;
			this.SetCaretActive();
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		private void SetCaretActive()
		{
			if (!this.m_AllowInput)
			{
				return;
			}
			if (this.m_CaretBlinkRate > 0f)
			{
				if (this.m_BlinkCoroutine == null)
				{
					this.m_BlinkCoroutine = base.StartCoroutine(this.CaretBlink());
				}
			}
			else
			{
				this.m_CaretVisible = true;
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000C420 File Offset: 0x0000A620
		protected void OnFocus()
		{
			this.SelectAll();
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000C428 File Offset: 0x0000A628
		protected void SelectAll()
		{
			this.caretPositionInternal = this.text.Length;
			this.caretSelectPositionInternal = 0;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000C450 File Offset: 0x0000A650
		public void MoveTextEnd(bool shift)
		{
			int length = this.text.Length;
			if (shift)
			{
				this.caretSelectPositionInternal = length;
			}
			else
			{
				this.caretPositionInternal = length;
				this.caretSelectPositionInternal = this.caretPositionInternal;
			}
			this.UpdateLabel();
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000C494 File Offset: 0x0000A694
		public void MoveTextStart(bool shift)
		{
			int num = 0;
			if (shift)
			{
				this.caretSelectPositionInternal = num;
			}
			else
			{
				this.caretPositionInternal = num;
				this.caretSelectPositionInternal = this.caretPositionInternal;
			}
			this.UpdateLabel();
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0000C4D8 File Offset: 0x0000A6D8
		private static string clipboard
		{
			get
			{
				return GUIUtility.systemCopyBuffer;
			}
			set
			{
				GUIUtility.systemCopyBuffer = value;
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		private bool InPlaceEditing()
		{
			return !TouchScreenKeyboard.isSupported;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000C4EC File Offset: 0x0000A6EC
		protected virtual void LateUpdate()
		{
			if (this.m_ShouldActivateNextUpdate)
			{
				if (!this.isFocused)
				{
					this.ActivateInputFieldInternal();
					this.m_ShouldActivateNextUpdate = false;
					return;
				}
				this.m_ShouldActivateNextUpdate = false;
			}
			if (this.InPlaceEditing() || !this.isFocused)
			{
				return;
			}
			this.AssignPositioningIfNeeded();
			if (this.m_Keyboard == null || !this.m_Keyboard.active)
			{
				if (this.m_Keyboard != null && this.m_Keyboard.wasCanceled)
				{
					this.m_WasCanceled = true;
				}
				this.OnDeselect(null);
				return;
			}
			string text = this.m_Keyboard.text;
			if (this.m_Text != text)
			{
				this.m_Text = string.Empty;
				foreach (char c in text)
				{
					if (c == '\r' || c == '\u0003')
					{
						c = '\n';
					}
					if (this.onValidateInput != null)
					{
						c = this.onValidateInput(this.m_Text, this.m_Text.Length, c);
					}
					else if (this.characterValidation != InputField.CharacterValidation.None)
					{
						c = this.Validate(this.m_Text, this.m_Text.Length, c);
					}
					if (this.lineType == InputField.LineType.MultiLineSubmit && c == '\n')
					{
						this.m_Keyboard.text = this.m_Text;
						this.OnDeselect(null);
						return;
					}
					if (c != '\0')
					{
						this.m_Text += c;
					}
				}
				if (this.characterLimit > 0 && this.m_Text.Length > this.characterLimit)
				{
					this.m_Text = this.m_Text.Substring(0, this.characterLimit);
				}
				int length = this.m_Text.Length;
				this.caretSelectPositionInternal = length;
				this.caretPositionInternal = length;
				if (this.m_Text != text)
				{
					this.m_Keyboard.text = this.m_Text;
				}
				this.SendOnValueChangedAndUpdateLabel();
			}
			if (this.m_Keyboard.done)
			{
				if (this.m_Keyboard.wasCanceled)
				{
					this.m_WasCanceled = true;
				}
				this.OnDeselect(null);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000C728 File Offset: 0x0000A928
		public Vector2 ScreenToLocal(Vector2 screen)
		{
			Canvas canvas = this.m_TextComponent.canvas;
			if (canvas == null)
			{
				return screen;
			}
			Vector3 vector = Vector3.zero;
			if (canvas.renderMode == RenderMode.ScreenSpaceOverlay)
			{
				vector = this.m_TextComponent.transform.InverseTransformPoint(screen);
			}
			else if (canvas.worldCamera != null)
			{
				Ray ray = canvas.worldCamera.ScreenPointToRay(screen);
				Plane plane = new Plane(this.m_TextComponent.transform.forward, this.m_TextComponent.transform.position);
				float num;
				plane.Raycast(ray, out num);
				vector = this.m_TextComponent.transform.InverseTransformPoint(ray.GetPoint(num));
			}
			return new Vector2(vector.x, vector.y);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000C800 File Offset: 0x0000AA00
		private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator)
		{
			if (!this.multiLine)
			{
				return 0;
			}
			float num = this.m_TextComponent.rectTransform.rect.yMax;
			if (pos.y > num)
			{
				return -1;
			}
			for (int i = 0; i < generator.lineCount; i++)
			{
				float num2 = (float)generator.lines[i].height / this.m_TextComponent.pixelsPerUnit;
				if (pos.y <= num && pos.y > num - num2)
				{
					return i;
				}
				num -= num2;
			}
			return generator.lineCount;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000C8A4 File Offset: 0x0000AAA4
		protected int GetCharacterIndexFromPosition(Vector2 pos)
		{
			TextGenerator cachedTextGenerator = this.m_TextComponent.cachedTextGenerator;
			if (cachedTextGenerator.lineCount == 0)
			{
				return 0;
			}
			int unclampedCharacterLineFromPosition = this.GetUnclampedCharacterLineFromPosition(pos, cachedTextGenerator);
			if (unclampedCharacterLineFromPosition < 0)
			{
				return 0;
			}
			if (unclampedCharacterLineFromPosition >= cachedTextGenerator.lineCount)
			{
				return cachedTextGenerator.characterCountVisible;
			}
			int startCharIdx = cachedTextGenerator.lines[unclampedCharacterLineFromPosition].startCharIdx;
			int lineEndPosition = InputField.GetLineEndPosition(cachedTextGenerator, unclampedCharacterLineFromPosition);
			for (int i = startCharIdx; i < lineEndPosition; i++)
			{
				if (i >= cachedTextGenerator.characterCountVisible)
				{
					break;
				}
				UICharInfo uicharInfo = cachedTextGenerator.characters[i];
				Vector2 vector = uicharInfo.cursorPos / this.m_TextComponent.pixelsPerUnit;
				float num = pos.x - vector.x;
				float num2 = vector.x + uicharInfo.charWidth / this.m_TextComponent.pixelsPerUnit - pos.x;
				if (num < num2)
				{
					return i;
				}
			}
			return lineEndPosition;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000C9A0 File Offset: 0x0000ABA0
		private bool MayDrag(PointerEventData eventData)
		{
			return this.IsActive() && this.IsInteractable() && eventData.button == PointerEventData.InputButton.Left && this.m_TextComponent != null && this.m_Keyboard == null;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000C9EC File Offset: 0x0000ABEC
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			if (!this.MayDrag(eventData))
			{
				return;
			}
			this.m_UpdateDrag = true;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000CA04 File Offset: 0x0000AC04
		public virtual void OnDrag(PointerEventData eventData)
		{
			if (!this.MayDrag(eventData))
			{
				return;
			}
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.textComponent.rectTransform, eventData.position, eventData.pressEventCamera, out vector);
			this.caretSelectPositionInternal = this.GetCharacterIndexFromPosition(vector) + this.m_DrawStart;
			this.MarkGeometryAsDirty();
			this.m_DragPositionOutOfBounds = !RectTransformUtility.RectangleContainsScreenPoint(this.textComponent.rectTransform, eventData.position, eventData.pressEventCamera);
			if (this.m_DragPositionOutOfBounds && this.m_DragCoroutine == null)
			{
				this.m_DragCoroutine = base.StartCoroutine(this.MouseDragOutsideRect(eventData));
			}
			eventData.Use();
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000CAAC File Offset: 0x0000ACAC
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			while (this.m_UpdateDrag && this.m_DragPositionOutOfBounds)
			{
				Vector2 localMousePos;
				RectTransformUtility.ScreenPointToLocalPointInRectangle(this.textComponent.rectTransform, eventData.position, eventData.pressEventCamera, out localMousePos);
				Rect rect = this.textComponent.rectTransform.rect;
				if (this.multiLine)
				{
					if (localMousePos.y > rect.yMax)
					{
						this.MoveUp(true, true);
					}
					else if (localMousePos.y < rect.yMin)
					{
						this.MoveDown(true, true);
					}
				}
				else if (localMousePos.x < rect.xMin)
				{
					this.MoveLeft(true, false);
				}
				else if (localMousePos.x > rect.xMax)
				{
					this.MoveRight(true, false);
				}
				this.UpdateLabel();
				float delay = ((!this.multiLine) ? 0.05f : 0.1f);
				yield return new WaitForSeconds(delay);
			}
			this.m_DragCoroutine = null;
			yield break;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			if (!this.MayDrag(eventData))
			{
				return;
			}
			this.m_UpdateDrag = false;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000CAF0 File Offset: 0x0000ACF0
		public override void OnPointerDown(PointerEventData eventData)
		{
			if (!this.MayDrag(eventData))
			{
				return;
			}
			EventSystem.current.SetSelectedGameObject(base.gameObject, eventData);
			bool allowInput = this.m_AllowInput;
			base.OnPointerDown(eventData);
			if (!this.InPlaceEditing() && (this.m_Keyboard == null || !this.m_Keyboard.active))
			{
				this.OnSelect(eventData);
				return;
			}
			if (allowInput)
			{
				Vector2 vector = this.ScreenToLocal(eventData.position);
				int num = this.GetCharacterIndexFromPosition(vector) + this.m_DrawStart;
				this.caretPositionInternal = num;
				this.caretSelectPositionInternal = num;
			}
			this.UpdateLabel();
			eventData.Use();
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000CB94 File Offset: 0x0000AD94
		protected InputField.EditState KeyPressed(Event evt)
		{
			EventModifiers modifiers = evt.modifiers;
			RuntimePlatform platform = Application.platform;
			bool flag = platform == RuntimePlatform.OSXEditor || platform == RuntimePlatform.OSXPlayer || platform == RuntimePlatform.OSXWebPlayer;
			bool flag2 = ((!flag) ? ((modifiers & EventModifiers.Control) != EventModifiers.None) : ((modifiers & EventModifiers.Command) != EventModifiers.None));
			bool flag3 = (modifiers & EventModifiers.Shift) != EventModifiers.None;
			bool flag4 = (modifiers & EventModifiers.Alt) != EventModifiers.None;
			bool flag5 = flag2 && !flag4 && !flag3;
			KeyCode keyCode = evt.keyCode;
			switch (keyCode)
			{
			case KeyCode.KeypadEnter:
				break;
			default:
				switch (keyCode)
				{
				case KeyCode.A:
					if (flag5)
					{
						this.SelectAll();
						return InputField.EditState.Continue;
					}
					goto IL_0205;
				default:
					switch (keyCode)
					{
					case KeyCode.V:
						if (flag5)
						{
							this.Append(InputField.clipboard);
							return InputField.EditState.Continue;
						}
						goto IL_0205;
					default:
						if (keyCode == KeyCode.Backspace)
						{
							this.Backspace();
							return InputField.EditState.Continue;
						}
						if (keyCode != KeyCode.Return)
						{
							if (keyCode == KeyCode.Escape)
							{
								this.m_WasCanceled = true;
								return InputField.EditState.Finish;
							}
							if (keyCode != KeyCode.Delete)
							{
								goto IL_0205;
							}
							this.ForwardSpace();
							return InputField.EditState.Continue;
						}
						break;
					case KeyCode.X:
						if (flag5)
						{
							if (this.inputType != InputField.InputType.Password)
							{
								InputField.clipboard = this.GetSelectedString();
							}
							else
							{
								InputField.clipboard = string.Empty;
							}
							this.Delete();
							this.SendOnValueChangedAndUpdateLabel();
							return InputField.EditState.Continue;
						}
						goto IL_0205;
					}
					break;
				case KeyCode.C:
					if (flag5)
					{
						if (this.inputType != InputField.InputType.Password)
						{
							InputField.clipboard = this.GetSelectedString();
						}
						else
						{
							InputField.clipboard = string.Empty;
						}
						return InputField.EditState.Continue;
					}
					goto IL_0205;
				}
				break;
			case KeyCode.UpArrow:
				this.MoveUp(flag3);
				return InputField.EditState.Continue;
			case KeyCode.DownArrow:
				this.MoveDown(flag3);
				return InputField.EditState.Continue;
			case KeyCode.RightArrow:
				this.MoveRight(flag3, flag2);
				return InputField.EditState.Continue;
			case KeyCode.LeftArrow:
				this.MoveLeft(flag3, flag2);
				return InputField.EditState.Continue;
			case KeyCode.Home:
				this.MoveTextStart(flag3);
				return InputField.EditState.Continue;
			case KeyCode.End:
				this.MoveTextEnd(flag3);
				return InputField.EditState.Continue;
			}
			if (this.lineType != InputField.LineType.MultiLineNewline)
			{
				return InputField.EditState.Finish;
			}
			IL_0205:
			char c = evt.character;
			if (!this.multiLine && (c == '\t' || c == '\r' || c == '\n'))
			{
				return InputField.EditState.Continue;
			}
			if (c == '\r' || c == '\u0003')
			{
				c = '\n';
			}
			if (this.IsValidChar(c))
			{
				this.Append(c);
			}
			if (c == '\0' && Input.compositionString.Length > 0)
			{
				this.UpdateLabel();
			}
			return InputField.EditState.Continue;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000CE20 File Offset: 0x0000B020
		private bool IsValidChar(char c)
		{
			return c != '\u007f' && (c == '\t' || c == '\n' || this.m_TextComponent.font.HasCharacter(c));
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000CE50 File Offset: 0x0000B050
		public void ProcessEvent(Event e)
		{
			this.KeyPressed(e);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000CE5C File Offset: 0x0000B05C
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
			if (!this.isFocused)
			{
				return;
			}
			bool flag = false;
			while (Event.PopEvent(this.m_ProcessingEvent))
			{
				if (this.m_ProcessingEvent.rawType == EventType.KeyDown)
				{
					flag = true;
					InputField.EditState editState = this.KeyPressed(this.m_ProcessingEvent);
					if (editState == InputField.EditState.Finish)
					{
						this.DeactivateInputField();
						break;
					}
				}
				EventType type = this.m_ProcessingEvent.type;
				if (type == EventType.ValidateCommand || type == EventType.ExecuteCommand)
				{
					string commandName = this.m_ProcessingEvent.commandName;
					if (commandName != null)
					{
						if (InputField.<>f__switch$map0 == null)
						{
							InputField.<>f__switch$map0 = new Dictionary<string, int>(1) { { "SelectAll", 0 } };
						}
						int num;
						if (InputField.<>f__switch$map0.TryGetValue(commandName, out num))
						{
							if (num == 0)
							{
								this.SelectAll();
								flag = true;
							}
						}
					}
				}
			}
			if (flag)
			{
				this.UpdateLabel();
			}
			eventData.Use();
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000CF5C File Offset: 0x0000B15C
		private string GetSelectedString()
		{
			if (!this.hasSelection)
			{
				return string.Empty;
			}
			int num = this.caretPositionInternal;
			int num2 = this.caretSelectPositionInternal;
			if (num > num2)
			{
				int num3 = num;
				num = num2;
				num2 = num3;
			}
			return this.text.Substring(num, num2 - num);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000CFA4 File Offset: 0x0000B1A4
		private int FindtNextWordBegin()
		{
			if (this.caretSelectPositionInternal + 1 >= this.text.Length)
			{
				return this.text.Length;
			}
			int num = this.text.IndexOfAny(InputField.kSeparators, this.caretSelectPositionInternal + 1);
			if (num == -1)
			{
				num = this.text.Length;
			}
			else
			{
				num++;
			}
			return num;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000D00C File Offset: 0x0000B20C
		private void MoveRight(bool shift, bool ctrl)
		{
			if (this.hasSelection && !shift)
			{
				int num = Mathf.Max(this.caretPositionInternal, this.caretSelectPositionInternal);
				this.caretSelectPositionInternal = num;
				this.caretPositionInternal = num;
				return;
			}
			int num2;
			if (ctrl)
			{
				num2 = this.FindtNextWordBegin();
			}
			else
			{
				num2 = this.caretSelectPositionInternal + 1;
			}
			if (shift)
			{
				this.caretSelectPositionInternal = num2;
			}
			else
			{
				int num = num2;
				this.caretPositionInternal = num;
				this.caretSelectPositionInternal = num;
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000D088 File Offset: 0x0000B288
		private int FindtPrevWordBegin()
		{
			if (this.caretSelectPositionInternal - 2 < 0)
			{
				return 0;
			}
			int num = this.text.LastIndexOfAny(InputField.kSeparators, this.caretSelectPositionInternal - 2);
			if (num == -1)
			{
				num = 0;
			}
			else
			{
				num++;
			}
			return num;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000D0D4 File Offset: 0x0000B2D4
		private void MoveLeft(bool shift, bool ctrl)
		{
			if (this.hasSelection && !shift)
			{
				int num = Mathf.Min(this.caretPositionInternal, this.caretSelectPositionInternal);
				this.caretSelectPositionInternal = num;
				this.caretPositionInternal = num;
				return;
			}
			int num2;
			if (ctrl)
			{
				num2 = this.FindtPrevWordBegin();
			}
			else
			{
				num2 = this.caretSelectPositionInternal - 1;
			}
			if (shift)
			{
				this.caretSelectPositionInternal = num2;
			}
			else
			{
				int num = num2;
				this.caretPositionInternal = num;
				this.caretSelectPositionInternal = num;
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000D150 File Offset: 0x0000B350
		private int DetermineCharacterLine(int charPos, TextGenerator generator)
		{
			if (!this.multiLine)
			{
				return 0;
			}
			for (int i = 0; i < generator.lineCount - 1; i++)
			{
				if (generator.lines[i + 1].startCharIdx > charPos)
				{
					return i;
				}
			}
			return generator.lineCount - 1;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000D1AC File Offset: 0x0000B3AC
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			if (originalPos >= this.cachedInputTextGenerator.characterCountVisible)
			{
				return 0;
			}
			UICharInfo uicharInfo = this.cachedInputTextGenerator.characters[originalPos];
			int num = this.DetermineCharacterLine(originalPos, this.cachedInputTextGenerator);
			if (num - 1 < 0)
			{
				return (!goToFirstChar) ? originalPos : 0;
			}
			int num2 = this.cachedInputTextGenerator.lines[num].startCharIdx - 1;
			for (int i = this.cachedInputTextGenerator.lines[num - 1].startCharIdx; i < num2; i++)
			{
				if (this.cachedInputTextGenerator.characters[i].cursorPos.x >= uicharInfo.cursorPos.x)
				{
					return i;
				}
			}
			return num2;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000D280 File Offset: 0x0000B480
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			if (originalPos >= this.cachedInputTextGenerator.characterCountVisible)
			{
				return this.text.Length;
			}
			UICharInfo uicharInfo = this.cachedInputTextGenerator.characters[originalPos];
			int num = this.DetermineCharacterLine(originalPos, this.cachedInputTextGenerator);
			if (num + 1 >= this.cachedInputTextGenerator.lineCount)
			{
				return (!goToLastChar) ? originalPos : this.text.Length;
			}
			int lineEndPosition = InputField.GetLineEndPosition(this.cachedInputTextGenerator, num + 1);
			for (int i = this.cachedInputTextGenerator.lines[num + 1].startCharIdx; i < lineEndPosition; i++)
			{
				if (this.cachedInputTextGenerator.characters[i].cursorPos.x >= uicharInfo.cursorPos.x)
				{
					return i;
				}
			}
			return lineEndPosition;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000D364 File Offset: 0x0000B564
		private void MoveDown(bool shift)
		{
			this.MoveDown(shift, true);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000D370 File Offset: 0x0000B570
		private void MoveDown(bool shift, bool goToLastChar)
		{
			if (this.hasSelection && !shift)
			{
				int num = Mathf.Max(this.caretPositionInternal, this.caretSelectPositionInternal);
				this.caretSelectPositionInternal = num;
				this.caretPositionInternal = num;
			}
			int num2 = ((!this.multiLine) ? this.text.Length : this.LineDownCharacterPosition(this.caretSelectPositionInternal, goToLastChar));
			if (shift)
			{
				this.caretSelectPositionInternal = num2;
			}
			else
			{
				int num = num2;
				this.caretSelectPositionInternal = num;
				this.caretPositionInternal = num;
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000D3FC File Offset: 0x0000B5FC
		private void MoveUp(bool shift)
		{
			this.MoveUp(shift, true);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000D408 File Offset: 0x0000B608
		private void MoveUp(bool shift, bool goToFirstChar)
		{
			if (this.hasSelection && !shift)
			{
				int num = Mathf.Min(this.caretPositionInternal, this.caretSelectPositionInternal);
				this.caretSelectPositionInternal = num;
				this.caretPositionInternal = num;
			}
			int num2 = ((!this.multiLine) ? 0 : this.LineUpCharacterPosition(this.caretSelectPositionInternal, goToFirstChar));
			if (shift)
			{
				this.caretSelectPositionInternal = num2;
			}
			else
			{
				int num = num2;
				this.caretPositionInternal = num;
				this.caretSelectPositionInternal = num;
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000D488 File Offset: 0x0000B688
		private void Delete()
		{
			if (this.caretPositionInternal == this.caretSelectPositionInternal)
			{
				return;
			}
			if (this.caretPositionInternal < this.caretSelectPositionInternal)
			{
				this.m_Text = this.text.Substring(0, this.caretPositionInternal) + this.text.Substring(this.caretSelectPositionInternal, this.text.Length - this.caretSelectPositionInternal);
				this.caretSelectPositionInternal = this.caretPositionInternal;
			}
			else
			{
				this.m_Text = this.text.Substring(0, this.caretSelectPositionInternal) + this.text.Substring(this.caretPositionInternal, this.text.Length - this.caretPositionInternal);
				this.caretPositionInternal = this.caretSelectPositionInternal;
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000D558 File Offset: 0x0000B758
		private void ForwardSpace()
		{
			if (this.hasSelection)
			{
				this.Delete();
				this.SendOnValueChangedAndUpdateLabel();
			}
			else if (this.caretPositionInternal < this.text.Length)
			{
				this.m_Text = this.text.Remove(this.caretPositionInternal, 1);
				this.SendOnValueChangedAndUpdateLabel();
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000D5B8 File Offset: 0x0000B7B8
		private void Backspace()
		{
			if (this.hasSelection)
			{
				this.Delete();
				this.SendOnValueChangedAndUpdateLabel();
			}
			else if (this.caretPositionInternal > 0)
			{
				this.m_Text = this.text.Remove(this.caretPositionInternal - 1, 1);
				int num = this.caretPositionInternal - 1;
				this.caretPositionInternal = num;
				this.caretSelectPositionInternal = num;
				this.SendOnValueChangedAndUpdateLabel();
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000D624 File Offset: 0x0000B824
		private void Insert(char c)
		{
			string text = c.ToString();
			this.Delete();
			if (this.characterLimit > 0 && this.text.Length >= this.characterLimit)
			{
				return;
			}
			this.m_Text = this.text.Insert(this.m_CaretPosition, text);
			this.caretSelectPositionInternal = (this.caretPositionInternal += text.Length);
			this.SendOnValueChanged();
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000D69C File Offset: 0x0000B89C
		private void SendOnValueChangedAndUpdateLabel()
		{
			this.SendOnValueChanged();
			this.UpdateLabel();
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000D6AC File Offset: 0x0000B8AC
		private void SendOnValueChanged()
		{
			if (this.onValueChange != null)
			{
				this.onValueChange.Invoke(this.text);
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000D6D8 File Offset: 0x0000B8D8
		protected void SendOnSubmit()
		{
			if (this.onEndEdit != null)
			{
				this.onEndEdit.Invoke(this.m_Text);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		protected virtual void Append(string input)
		{
			if (!this.InPlaceEditing())
			{
				return;
			}
			int i = 0;
			int length = input.Length;
			while (i < length)
			{
				char c = input[i];
				if (c >= ' ')
				{
					this.Append(c);
				}
				i++;
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000D744 File Offset: 0x0000B944
		protected virtual void Append(char input)
		{
			if (!this.InPlaceEditing())
			{
				return;
			}
			if (this.onValidateInput != null)
			{
				input = this.onValidateInput(this.text, this.caretPositionInternal, input);
			}
			else if (this.characterValidation != InputField.CharacterValidation.None)
			{
				input = this.Validate(this.text, this.caretPositionInternal, input);
			}
			if (input == '\0')
			{
				return;
			}
			this.Insert(input);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		protected void UpdateLabel()
		{
			if (this.m_TextComponent != null && this.m_TextComponent.font != null && !this.m_PreventFontCallback)
			{
				this.m_PreventFontCallback = true;
				string text;
				if (Input.compositionString.Length > 0)
				{
					text = this.text.Substring(0, this.m_CaretPosition) + Input.compositionString + this.text.Substring(this.m_CaretPosition);
				}
				else
				{
					text = this.text;
				}
				string text2;
				if (this.inputType == InputField.InputType.Password)
				{
					text2 = new string(this.asteriskChar, text.Length);
				}
				else
				{
					text2 = text;
				}
				bool flag = string.IsNullOrEmpty(text);
				if (this.m_Placeholder != null)
				{
					this.m_Placeholder.enabled = flag;
				}
				if (!this.m_AllowInput)
				{
					this.m_DrawStart = 0;
					this.m_DrawEnd = this.m_Text.Length;
				}
				if (!flag)
				{
					Vector2 size = this.m_TextComponent.rectTransform.rect.size;
					TextGenerationSettings generationSettings = this.m_TextComponent.GetGenerationSettings(size);
					generationSettings.generateOutOfBounds = true;
					this.cachedInputTextGenerator.Populate(text2, generationSettings);
					this.SetDrawRangeToContainCaretPosition(this.caretSelectPositionInternal);
					text2 = text2.Substring(this.m_DrawStart, Mathf.Min(this.m_DrawEnd, text2.Length) - this.m_DrawStart);
					this.SetCaretVisible();
				}
				this.m_TextComponent.text = text2;
				this.MarkGeometryAsDirty();
				this.m_PreventFontCallback = false;
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000D94C File Offset: 0x0000BB4C
		private bool IsSelectionVisible()
		{
			return this.m_DrawStart <= this.caretPositionInternal && this.m_DrawStart <= this.caretSelectPositionInternal && this.m_DrawEnd >= this.caretPositionInternal && this.m_DrawEnd >= this.caretSelectPositionInternal;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000D9A4 File Offset: 0x0000BBA4
		private static int GetLineStartPosition(TextGenerator gen, int line)
		{
			line = Mathf.Clamp(line, 0, gen.lines.Count - 1);
			return gen.lines[line].startCharIdx;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000D9DC File Offset: 0x0000BBDC
		private static int GetLineEndPosition(TextGenerator gen, int line)
		{
			line = Mathf.Max(line, 0);
			if (line + 1 < gen.lines.Count)
			{
				return gen.lines[line + 1].startCharIdx;
			}
			return gen.characterCountVisible;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000DA24 File Offset: 0x0000BC24
		private void SetDrawRangeToContainCaretPosition(int caretPos)
		{
			Vector2 size = this.cachedInputTextGenerator.rectExtents.size;
			if (this.multiLine)
			{
				IList<UILineInfo> lines = this.cachedInputTextGenerator.lines;
				int num = this.DetermineCharacterLine(caretPos, this.cachedInputTextGenerator);
				int num2 = (int)size.y;
				if (this.m_DrawEnd <= caretPos)
				{
					this.m_DrawEnd = InputField.GetLineEndPosition(this.cachedInputTextGenerator, num);
					int num3 = num;
					while (num3 >= 0 && num3 < lines.Count)
					{
						num2 -= lines[num3].height;
						if (num2 < 0)
						{
							break;
						}
						this.m_DrawStart = InputField.GetLineStartPosition(this.cachedInputTextGenerator, num3);
						num3--;
					}
				}
				else
				{
					if (this.m_DrawStart > caretPos)
					{
						this.m_DrawStart = InputField.GetLineStartPosition(this.cachedInputTextGenerator, num);
					}
					int num4 = this.DetermineCharacterLine(this.m_DrawStart, this.cachedInputTextGenerator);
					int num5 = num4;
					this.m_DrawEnd = InputField.GetLineEndPosition(this.cachedInputTextGenerator, num5);
					num2 -= lines[num5].height;
					for (;;)
					{
						if (num5 < lines.Count - 1)
						{
							num5++;
							if (num2 < lines[num5].height)
							{
								break;
							}
							this.m_DrawEnd = InputField.GetLineEndPosition(this.cachedInputTextGenerator, num5);
							num2 -= lines[num5].height;
						}
						else
						{
							if (num4 <= 0)
							{
								break;
							}
							num4--;
							if (num2 < lines[num4].height)
							{
								break;
							}
							this.m_DrawStart = InputField.GetLineStartPosition(this.cachedInputTextGenerator, num4);
							num2 -= lines[num4].height;
						}
					}
				}
			}
			else
			{
				IList<UICharInfo> characters = this.cachedInputTextGenerator.characters;
				if (this.m_DrawEnd > this.cachedInputTextGenerator.characterCountVisible)
				{
					this.m_DrawEnd = this.cachedInputTextGenerator.characterCountVisible;
				}
				float num6 = 0f;
				if (caretPos > this.m_DrawEnd || (caretPos == this.m_DrawEnd && this.m_DrawStart > 0))
				{
					this.m_DrawEnd = caretPos;
					this.m_DrawStart = this.m_DrawEnd - 1;
					while (this.m_DrawStart >= 0)
					{
						if (num6 + characters[this.m_DrawStart].charWidth > size.x)
						{
							break;
						}
						num6 += characters[this.m_DrawStart].charWidth;
						this.m_DrawStart--;
					}
					this.m_DrawStart++;
				}
				else
				{
					if (caretPos < this.m_DrawStart)
					{
						this.m_DrawStart = caretPos;
					}
					this.m_DrawEnd = this.m_DrawStart;
				}
				while (this.m_DrawEnd < this.cachedInputTextGenerator.characterCountVisible)
				{
					num6 += characters[this.m_DrawEnd].charWidth;
					if (num6 > size.x)
					{
						break;
					}
					this.m_DrawEnd++;
				}
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000DD70 File Offset: 0x0000BF70
		private void MarkGeometryAsDirty()
		{
			CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000DD78 File Offset: 0x0000BF78
		public virtual void Rebuild(CanvasUpdate update)
		{
			if (update == CanvasUpdate.LatePreRender)
			{
				this.UpdateGeometry();
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000DDA4 File Offset: 0x0000BFA4
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000DDA8 File Offset: 0x0000BFA8
		private void UpdateGeometry()
		{
			if (!this.shouldHideMobileInput)
			{
				return;
			}
			if (this.m_CachedInputRenderer == null && this.m_TextComponent != null)
			{
				GameObject gameObject = new GameObject(base.transform.name + " Input Caret");
				gameObject.hideFlags = HideFlags.DontSave;
				gameObject.transform.SetParent(this.m_TextComponent.transform.parent);
				gameObject.transform.SetAsFirstSibling();
				gameObject.layer = base.gameObject.layer;
				this.caretRectTrans = gameObject.AddComponent<RectTransform>();
				this.m_CachedInputRenderer = gameObject.AddComponent<CanvasRenderer>();
				this.m_CachedInputRenderer.SetMaterial(Graphic.defaultGraphicMaterial, Texture2D.whiteTexture);
				gameObject.AddComponent<LayoutElement>().ignoreLayout = true;
				this.AssignPositioningIfNeeded();
			}
			if (this.m_CachedInputRenderer == null)
			{
				return;
			}
			this.OnFillVBO(this.mesh);
			this.m_CachedInputRenderer.SetMesh(this.mesh);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000DEAC File Offset: 0x0000C0AC
		private void AssignPositioningIfNeeded()
		{
			if (this.m_TextComponent != null && this.caretRectTrans != null && (this.caretRectTrans.localPosition != this.m_TextComponent.rectTransform.localPosition || this.caretRectTrans.localRotation != this.m_TextComponent.rectTransform.localRotation || this.caretRectTrans.localScale != this.m_TextComponent.rectTransform.localScale || this.caretRectTrans.anchorMin != this.m_TextComponent.rectTransform.anchorMin || this.caretRectTrans.anchorMax != this.m_TextComponent.rectTransform.anchorMax || this.caretRectTrans.anchoredPosition != this.m_TextComponent.rectTransform.anchoredPosition || this.caretRectTrans.sizeDelta != this.m_TextComponent.rectTransform.sizeDelta || this.caretRectTrans.pivot != this.m_TextComponent.rectTransform.pivot))
			{
				this.caretRectTrans.localPosition = this.m_TextComponent.rectTransform.localPosition;
				this.caretRectTrans.localRotation = this.m_TextComponent.rectTransform.localRotation;
				this.caretRectTrans.localScale = this.m_TextComponent.rectTransform.localScale;
				this.caretRectTrans.anchorMin = this.m_TextComponent.rectTransform.anchorMin;
				this.caretRectTrans.anchorMax = this.m_TextComponent.rectTransform.anchorMax;
				this.caretRectTrans.anchoredPosition = this.m_TextComponent.rectTransform.anchoredPosition;
				this.caretRectTrans.sizeDelta = this.m_TextComponent.rectTransform.sizeDelta;
				this.caretRectTrans.pivot = this.m_TextComponent.rectTransform.pivot;
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000E0DC File Offset: 0x0000C2DC
		private void OnFillVBO(Mesh vbo)
		{
			using (VertexHelper vertexHelper = new VertexHelper())
			{
				if (!this.isFocused)
				{
					vertexHelper.FillMesh(vbo);
				}
				else
				{
					Rect rect = this.m_TextComponent.rectTransform.rect;
					Vector2 size = rect.size;
					Vector2 textAnchorPivot = Text.GetTextAnchorPivot(this.m_TextComponent.alignment);
					Vector2 zero = Vector2.zero;
					zero.x = Mathf.Lerp(rect.xMin, rect.xMax, textAnchorPivot.x);
					zero.y = Mathf.Lerp(rect.yMin, rect.yMax, textAnchorPivot.y);
					Vector2 vector = this.m_TextComponent.PixelAdjustPoint(zero);
					Vector2 vector2 = vector - zero + Vector2.Scale(size, textAnchorPivot);
					vector2.x -= Mathf.Floor(0.5f + vector2.x);
					vector2.y -= Mathf.Floor(0.5f + vector2.y);
					if (!this.hasSelection)
					{
						this.GenerateCursor(vertexHelper, vector2);
					}
					else
					{
						this.GenerateHightlight(vertexHelper, vector2);
					}
					vertexHelper.FillMesh(vbo);
				}
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000E238 File Offset: 0x0000C438
		private void GenerateCursor(VertexHelper vbo, Vector2 roundingOffset)
		{
			if (!this.m_CaretVisible)
			{
				return;
			}
			if (this.m_CursorVerts == null)
			{
				this.CreateCursorVerts();
			}
			float num = 1f;
			float num2 = (float)this.m_TextComponent.fontSize;
			int num3 = Mathf.Max(0, this.caretPositionInternal - this.m_DrawStart);
			TextGenerator cachedTextGenerator = this.m_TextComponent.cachedTextGenerator;
			if (cachedTextGenerator == null)
			{
				return;
			}
			if (this.m_TextComponent.resizeTextForBestFit)
			{
				num2 = (float)cachedTextGenerator.fontSizeUsedForBestFit / this.m_TextComponent.pixelsPerUnit;
			}
			Vector2 zero = Vector2.zero;
			if (cachedTextGenerator.characterCountVisible + 1 > num3 || num3 == 0)
			{
				UICharInfo uicharInfo = cachedTextGenerator.characters[num3];
				zero.x = uicharInfo.cursorPos.x;
				zero.y = uicharInfo.cursorPos.y;
			}
			zero.x /= this.m_TextComponent.pixelsPerUnit;
			if (zero.x > this.m_TextComponent.rectTransform.rect.xMax)
			{
				zero.x = this.m_TextComponent.rectTransform.rect.xMax;
			}
			int num4 = this.DetermineCharacterLine(num3, cachedTextGenerator);
			float num5 = this.SumLineHeights(num4, cachedTextGenerator);
			zero.y = this.m_TextComponent.rectTransform.rect.yMax - num5 / this.m_TextComponent.pixelsPerUnit;
			this.m_CursorVerts[0].position = new Vector3(zero.x, zero.y - num2, 0f);
			this.m_CursorVerts[1].position = new Vector3(zero.x + num, zero.y - num2, 0f);
			this.m_CursorVerts[2].position = new Vector3(zero.x + num, zero.y, 0f);
			this.m_CursorVerts[3].position = new Vector3(zero.x, zero.y, 0f);
			if (roundingOffset != Vector2.zero)
			{
				for (int i = 0; i < this.m_CursorVerts.Length; i++)
				{
					UIVertex uivertex = this.m_CursorVerts[i];
					uivertex.position.x = uivertex.position.x + roundingOffset.x;
					uivertex.position.y = uivertex.position.y + roundingOffset.y;
				}
			}
			vbo.AddUIVertexQuad(this.m_CursorVerts);
			zero.y = (float)Screen.height - zero.y;
			Input.compositionCursorPos = zero;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000E4FC File Offset: 0x0000C6FC
		private void CreateCursorVerts()
		{
			this.m_CursorVerts = new UIVertex[4];
			for (int i = 0; i < this.m_CursorVerts.Length; i++)
			{
				this.m_CursorVerts[i] = UIVertex.simpleVert;
				this.m_CursorVerts[i].color = this.m_TextComponent.color;
				this.m_CursorVerts[i].uv0 = Vector2.zero;
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000E57C File Offset: 0x0000C77C
		private float SumLineHeights(int endLine, TextGenerator generator)
		{
			float num = 0f;
			for (int i = 0; i < endLine; i++)
			{
				num += (float)generator.lines[i].height;
			}
			return num;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000E5BC File Offset: 0x0000C7BC
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
		{
			int num = Mathf.Max(0, this.caretPositionInternal - this.m_DrawStart);
			int num2 = Mathf.Max(0, this.caretSelectPositionInternal - this.m_DrawStart);
			if (num > num2)
			{
				int num3 = num;
				num = num2;
				num2 = num3;
			}
			num2--;
			TextGenerator cachedTextGenerator = this.m_TextComponent.cachedTextGenerator;
			int num4 = this.DetermineCharacterLine(num, cachedTextGenerator);
			float num5 = (float)this.m_TextComponent.fontSize;
			if (this.m_TextComponent.resizeTextForBestFit)
			{
				num5 = (float)cachedTextGenerator.fontSizeUsedForBestFit / this.m_TextComponent.pixelsPerUnit;
			}
			if (this.cachedInputTextGenerator != null && this.cachedInputTextGenerator.lines.Count > 0)
			{
				num5 = (float)this.cachedInputTextGenerator.lines[0].height;
			}
			if (this.m_TextComponent.resizeTextForBestFit && this.cachedInputTextGenerator != null)
			{
				num5 = (float)this.cachedInputTextGenerator.fontSizeUsedForBestFit;
			}
			int num6 = InputField.GetLineEndPosition(cachedTextGenerator, num4);
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.uv0 = Vector2.zero;
			simpleVert.color = this.selectionColor;
			int num7 = num;
			while (num7 <= num2 && num7 < cachedTextGenerator.characterCountVisible)
			{
				if (num7 + 1 == num6 || num7 == num2)
				{
					UICharInfo uicharInfo = cachedTextGenerator.characters[num];
					UICharInfo uicharInfo2 = cachedTextGenerator.characters[num7];
					float num8 = this.SumLineHeights(num4, cachedTextGenerator);
					Vector2 vector = new Vector2(uicharInfo.cursorPos.x / this.m_TextComponent.pixelsPerUnit, this.m_TextComponent.rectTransform.rect.yMax - num8 / this.m_TextComponent.pixelsPerUnit);
					Vector2 vector2 = new Vector2((uicharInfo2.cursorPos.x + uicharInfo2.charWidth) / this.m_TextComponent.pixelsPerUnit, vector.y - num5 / this.m_TextComponent.pixelsPerUnit);
					if (vector2.x > this.m_TextComponent.rectTransform.rect.xMax || vector2.x < this.m_TextComponent.rectTransform.rect.xMin)
					{
						vector2.x = this.m_TextComponent.rectTransform.rect.xMax;
					}
					int currentVertCount = vbo.currentVertCount;
					simpleVert.position = new Vector3(vector.x, vector2.y, 0f) + roundingOffset;
					vbo.AddVert(simpleVert);
					simpleVert.position = new Vector3(vector2.x, vector2.y, 0f) + roundingOffset;
					vbo.AddVert(simpleVert);
					simpleVert.position = new Vector3(vector2.x, vector.y, 0f) + roundingOffset;
					vbo.AddVert(simpleVert);
					simpleVert.position = new Vector3(vector.x, vector.y, 0f) + roundingOffset;
					vbo.AddVert(simpleVert);
					vbo.AddTriangle(currentVertCount, currentVertCount + 1, currentVertCount + 2);
					vbo.AddTriangle(currentVertCount + 2, currentVertCount + 3, currentVertCount);
					num = num7 + 1;
					num4++;
					num6 = InputField.GetLineEndPosition(cachedTextGenerator, num4);
				}
				num7++;
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000E934 File Offset: 0x0000CB34
		protected char Validate(string text, int pos, char ch)
		{
			if (this.characterValidation == InputField.CharacterValidation.None || !base.enabled)
			{
				return ch;
			}
			if (this.characterValidation == InputField.CharacterValidation.Integer || this.characterValidation == InputField.CharacterValidation.Decimal)
			{
				if (pos != 0 || text.Length <= 0 || text[0] != '-')
				{
					if (ch >= '0' && ch <= '9')
					{
						return ch;
					}
					if (ch == '-' && pos == 0)
					{
						return ch;
					}
					if (ch == '.' && this.characterValidation == InputField.CharacterValidation.Decimal && !text.Contains("."))
					{
						return ch;
					}
				}
			}
			else if (this.characterValidation == InputField.CharacterValidation.Alphanumeric)
			{
				if (ch >= 'A' && ch <= 'Z')
				{
					return ch;
				}
				if (ch >= 'a' && ch <= 'z')
				{
					return ch;
				}
				if (ch >= '0' && ch <= '9')
				{
					return ch;
				}
			}
			else if (this.characterValidation == InputField.CharacterValidation.Name)
			{
				char c = ((text.Length <= 0) ? ' ' : text[Mathf.Clamp(pos, 0, text.Length - 1)]);
				char c2 = ((text.Length <= 0) ? '\n' : text[Mathf.Clamp(pos + 1, 0, text.Length - 1)]);
				if (char.IsLetter(ch))
				{
					if (char.IsLower(ch) && c == ' ')
					{
						return char.ToUpper(ch);
					}
					if (char.IsUpper(ch) && c != ' ' && c != '\'')
					{
						return char.ToLower(ch);
					}
					return ch;
				}
				else if (ch == '\'')
				{
					if (c != ' ' && c != '\'' && c2 != '\'' && !text.Contains("'"))
					{
						return ch;
					}
				}
				else if (ch == ' ' && c != ' ' && c != '\'' && c2 != ' ' && c2 != '\'')
				{
					return ch;
				}
			}
			else if (this.characterValidation == InputField.CharacterValidation.EmailAddress)
			{
				if (ch >= 'A' && ch <= 'Z')
				{
					return ch;
				}
				if (ch >= 'a' && ch <= 'z')
				{
					return ch;
				}
				if (ch >= '0' && ch <= '9')
				{
					return ch;
				}
				if (ch == '@' && text.IndexOf('@') == -1)
				{
					return ch;
				}
				if ("!#$%&'*+-/=?^_`{|}~".IndexOf(ch) != -1)
				{
					return ch;
				}
				if (ch == '.')
				{
					char c3 = ((text.Length <= 0) ? ' ' : text[Mathf.Clamp(pos, 0, text.Length - 1)]);
					char c4 = ((text.Length <= 0) ? '\n' : text[Mathf.Clamp(pos + 1, 0, text.Length - 1)]);
					if (c3 != '.' && c4 != '.')
					{
						return ch;
					}
				}
			}
			return '\0';
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000EC1C File Offset: 0x0000CE1C
		public void ActivateInputField()
		{
			if (this.m_TextComponent == null || this.m_TextComponent.font == null || !this.IsActive() || !this.IsInteractable())
			{
				return;
			}
			if (this.isFocused && this.m_Keyboard != null && !this.m_Keyboard.active)
			{
				this.m_Keyboard.active = true;
				this.m_Keyboard.text = this.m_Text;
			}
			this.m_ShouldActivateNextUpdate = true;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000ECB4 File Offset: 0x0000CEB4
		private void ActivateInputFieldInternal()
		{
			if (EventSystem.current.currentSelectedGameObject != base.gameObject)
			{
				EventSystem.current.SetSelectedGameObject(base.gameObject);
			}
			if (TouchScreenKeyboard.isSupported)
			{
				if (Input.touchSupported)
				{
					TouchScreenKeyboard.hideInput = this.shouldHideMobileInput;
				}
				this.m_Keyboard = ((this.inputType != InputField.InputType.Password) ? TouchScreenKeyboard.Open(this.m_Text, this.keyboardType, this.inputType == InputField.InputType.AutoCorrect, this.multiLine) : TouchScreenKeyboard.Open(this.m_Text, this.keyboardType, false, this.multiLine, true));
			}
			else
			{
				Input.imeCompositionMode = IMECompositionMode.On;
				this.OnFocus();
			}
			this.m_AllowInput = true;
			this.m_OriginalText = this.text;
			this.m_WasCanceled = false;
			this.SetCaretVisible();
			this.UpdateLabel();
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000ED94 File Offset: 0x0000CF94
		public override void OnSelect(BaseEventData eventData)
		{
			base.OnSelect(eventData);
			this.ActivateInputField();
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.ActivateInputField();
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000EDB8 File Offset: 0x0000CFB8
		public void DeactivateInputField()
		{
			if (!this.m_AllowInput)
			{
				return;
			}
			this.m_HasDoneFocusTransition = false;
			this.m_AllowInput = false;
			if (this.m_TextComponent != null && this.IsInteractable())
			{
				if (this.m_WasCanceled)
				{
					this.text = this.m_OriginalText;
				}
				if (this.m_Keyboard != null)
				{
					this.m_Keyboard.active = false;
					this.m_Keyboard = null;
				}
				this.m_CaretPosition = (this.m_CaretSelectPosition = 0);
				this.SendOnSubmit();
				Input.imeCompositionMode = IMECompositionMode.Auto;
			}
			this.MarkGeometryAsDirty();
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000EE54 File Offset: 0x0000D054
		public override void OnDeselect(BaseEventData eventData)
		{
			this.DeactivateInputField();
			base.OnDeselect(eventData);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000EE64 File Offset: 0x0000D064
		public virtual void OnSubmit(BaseEventData eventData)
		{
			if (!this.IsActive() || !this.IsInteractable())
			{
				return;
			}
			if (!this.isFocused)
			{
				this.m_ShouldActivateNextUpdate = true;
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000EE90 File Offset: 0x0000D090
		private void EnforceContentType()
		{
			switch (this.contentType)
			{
			case InputField.ContentType.Standard:
				this.m_InputType = InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.Default;
				this.m_CharacterValidation = InputField.CharacterValidation.None;
				return;
			case InputField.ContentType.Autocorrected:
				this.m_InputType = InputField.InputType.AutoCorrect;
				this.m_KeyboardType = TouchScreenKeyboardType.Default;
				this.m_CharacterValidation = InputField.CharacterValidation.None;
				return;
			case InputField.ContentType.IntegerNumber:
				this.m_LineType = InputField.LineType.SingleLine;
				this.m_InputType = InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.NumberPad;
				this.m_CharacterValidation = InputField.CharacterValidation.Integer;
				return;
			case InputField.ContentType.DecimalNumber:
				this.m_LineType = InputField.LineType.SingleLine;
				this.m_InputType = InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.NumbersAndPunctuation;
				this.m_CharacterValidation = InputField.CharacterValidation.Decimal;
				return;
			case InputField.ContentType.Alphanumeric:
				this.m_LineType = InputField.LineType.SingleLine;
				this.m_InputType = InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.ASCIICapable;
				this.m_CharacterValidation = InputField.CharacterValidation.Alphanumeric;
				return;
			case InputField.ContentType.Name:
				this.m_LineType = InputField.LineType.SingleLine;
				this.m_InputType = InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.Default;
				this.m_CharacterValidation = InputField.CharacterValidation.Name;
				return;
			case InputField.ContentType.EmailAddress:
				this.m_LineType = InputField.LineType.SingleLine;
				this.m_InputType = InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.EmailAddress;
				this.m_CharacterValidation = InputField.CharacterValidation.EmailAddress;
				return;
			case InputField.ContentType.Password:
				this.m_LineType = InputField.LineType.SingleLine;
				this.m_InputType = InputField.InputType.Password;
				this.m_KeyboardType = TouchScreenKeyboardType.Default;
				this.m_CharacterValidation = InputField.CharacterValidation.None;
				return;
			case InputField.ContentType.Pin:
				this.m_LineType = InputField.LineType.SingleLine;
				this.m_InputType = InputField.InputType.Password;
				this.m_KeyboardType = TouchScreenKeyboardType.NumberPad;
				this.m_CharacterValidation = InputField.CharacterValidation.Integer;
				return;
			default:
				return;
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000EFCC File Offset: 0x0000D1CC
		private void SetToCustomIfContentTypeIsNot(params InputField.ContentType[] allowedContentTypes)
		{
			if (this.contentType == InputField.ContentType.Custom)
			{
				return;
			}
			for (int i = 0; i < allowedContentTypes.Length; i++)
			{
				if (this.contentType == allowedContentTypes[i])
				{
					return;
				}
			}
			this.contentType = InputField.ContentType.Custom;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000F014 File Offset: 0x0000D214
		private void SetToCustom()
		{
			if (this.contentType == InputField.ContentType.Custom)
			{
				return;
			}
			this.contentType = InputField.ContentType.Custom;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000F02C File Offset: 0x0000D22C
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			if (this.m_HasDoneFocusTransition)
			{
				state = Selectable.SelectionState.Highlighted;
			}
			else if (state == Selectable.SelectionState.Pressed)
			{
				this.m_HasDoneFocusTransition = true;
			}
			base.DoStateTransition(state, instant);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000F058 File Offset: 0x0000D258
		virtual bool UnityEngine.UI.ICanvasElement.IsDestroyed()
		{
			return base.IsDestroyed();
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000F060 File Offset: 0x0000D260
		virtual Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x0400013C RID: 316
		private const float kHScrollSpeed = 0.05f;

		// Token: 0x0400013D RID: 317
		private const float kVScrollSpeed = 0.1f;

		// Token: 0x0400013E RID: 318
		private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";

		// Token: 0x0400013F RID: 319
		protected TouchScreenKeyboard m_Keyboard;

		// Token: 0x04000140 RID: 320
		private static readonly char[] kSeparators = new char[] { ' ', '.', ',' };

		// Token: 0x04000141 RID: 321
		[FormerlySerializedAs("text")]
		[SerializeField]
		protected Text m_TextComponent;

		// Token: 0x04000142 RID: 322
		[SerializeField]
		protected Graphic m_Placeholder;

		// Token: 0x04000143 RID: 323
		[SerializeField]
		private InputField.ContentType m_ContentType;

		// Token: 0x04000144 RID: 324
		[SerializeField]
		[FormerlySerializedAs("inputType")]
		private InputField.InputType m_InputType;

		// Token: 0x04000145 RID: 325
		[FormerlySerializedAs("asteriskChar")]
		[SerializeField]
		private char m_AsteriskChar = '*';

		// Token: 0x04000146 RID: 326
		[FormerlySerializedAs("keyboardType")]
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType;

		// Token: 0x04000147 RID: 327
		[SerializeField]
		private InputField.LineType m_LineType;

		// Token: 0x04000148 RID: 328
		[SerializeField]
		[FormerlySerializedAs("hideMobileInput")]
		private bool m_HideMobileInput;

		// Token: 0x04000149 RID: 329
		[FormerlySerializedAs("validation")]
		[SerializeField]
		private InputField.CharacterValidation m_CharacterValidation;

		// Token: 0x0400014A RID: 330
		[SerializeField]
		[FormerlySerializedAs("characterLimit")]
		private int m_CharacterLimit;

		// Token: 0x0400014B RID: 331
		[FormerlySerializedAs("m_OnSubmit")]
		[SerializeField]
		[FormerlySerializedAs("onSubmit")]
		private InputField.SubmitEvent m_EndEdit = new InputField.SubmitEvent();

		// Token: 0x0400014C RID: 332
		[FormerlySerializedAs("onValueChange")]
		[SerializeField]
		private InputField.OnChangeEvent m_OnValueChange = new InputField.OnChangeEvent();

		// Token: 0x0400014D RID: 333
		[SerializeField]
		[FormerlySerializedAs("onValidateInput")]
		private InputField.OnValidateInput m_OnValidateInput;

		// Token: 0x0400014E RID: 334
		[SerializeField]
		[FormerlySerializedAs("selectionColor")]
		private Color m_SelectionColor = new Color(0.65882355f, 0.80784315f, 1f, 0.7529412f);

		// Token: 0x0400014F RID: 335
		[FormerlySerializedAs("mValue")]
		[SerializeField]
		protected string m_Text = string.Empty;

		// Token: 0x04000150 RID: 336
		[Range(0f, 4f)]
		[SerializeField]
		private float m_CaretBlinkRate = 0.85f;

		// Token: 0x04000151 RID: 337
		protected int m_CaretPosition;

		// Token: 0x04000152 RID: 338
		protected int m_CaretSelectPosition;

		// Token: 0x04000153 RID: 339
		private RectTransform caretRectTrans;

		// Token: 0x04000154 RID: 340
		protected UIVertex[] m_CursorVerts;

		// Token: 0x04000155 RID: 341
		private TextGenerator m_InputTextCache;

		// Token: 0x04000156 RID: 342
		private CanvasRenderer m_CachedInputRenderer;

		// Token: 0x04000157 RID: 343
		private bool m_PreventFontCallback;

		// Token: 0x04000158 RID: 344
		[NonSerialized]
		protected Mesh m_Mesh;

		// Token: 0x04000159 RID: 345
		private bool m_AllowInput;

		// Token: 0x0400015A RID: 346
		private bool m_ShouldActivateNextUpdate;

		// Token: 0x0400015B RID: 347
		private bool m_UpdateDrag;

		// Token: 0x0400015C RID: 348
		private bool m_DragPositionOutOfBounds;

		// Token: 0x0400015D RID: 349
		protected bool m_CaretVisible;

		// Token: 0x0400015E RID: 350
		private Coroutine m_BlinkCoroutine;

		// Token: 0x0400015F RID: 351
		private float m_BlinkStartTime;

		// Token: 0x04000160 RID: 352
		protected int m_DrawStart;

		// Token: 0x04000161 RID: 353
		protected int m_DrawEnd;

		// Token: 0x04000162 RID: 354
		private Coroutine m_DragCoroutine;

		// Token: 0x04000163 RID: 355
		private string m_OriginalText = string.Empty;

		// Token: 0x04000164 RID: 356
		private bool m_WasCanceled;

		// Token: 0x04000165 RID: 357
		private bool m_HasDoneFocusTransition;

		// Token: 0x04000166 RID: 358
		private Event m_ProcessingEvent = new Event();

		// Token: 0x02000056 RID: 86
		public enum ContentType
		{
			// Token: 0x04000169 RID: 361
			Standard,
			// Token: 0x0400016A RID: 362
			Autocorrected,
			// Token: 0x0400016B RID: 363
			IntegerNumber,
			// Token: 0x0400016C RID: 364
			DecimalNumber,
			// Token: 0x0400016D RID: 365
			Alphanumeric,
			// Token: 0x0400016E RID: 366
			Name,
			// Token: 0x0400016F RID: 367
			EmailAddress,
			// Token: 0x04000170 RID: 368
			Password,
			// Token: 0x04000171 RID: 369
			Pin,
			// Token: 0x04000172 RID: 370
			Custom
		}

		// Token: 0x02000057 RID: 87
		public enum InputType
		{
			// Token: 0x04000174 RID: 372
			Standard,
			// Token: 0x04000175 RID: 373
			AutoCorrect,
			// Token: 0x04000176 RID: 374
			Password
		}

		// Token: 0x02000058 RID: 88
		public enum CharacterValidation
		{
			// Token: 0x04000178 RID: 376
			None,
			// Token: 0x04000179 RID: 377
			Integer,
			// Token: 0x0400017A RID: 378
			Decimal,
			// Token: 0x0400017B RID: 379
			Alphanumeric,
			// Token: 0x0400017C RID: 380
			Name,
			// Token: 0x0400017D RID: 381
			EmailAddress
		}

		// Token: 0x02000059 RID: 89
		public enum LineType
		{
			// Token: 0x0400017F RID: 383
			SingleLine,
			// Token: 0x04000180 RID: 384
			MultiLineSubmit,
			// Token: 0x04000181 RID: 385
			MultiLineNewline
		}

		// Token: 0x0200005A RID: 90
		[Serializable]
		public class SubmitEvent : UnityEvent<string>
		{
		}

		// Token: 0x0200005B RID: 91
		[Serializable]
		public class OnChangeEvent : UnityEvent<string>
		{
		}

		// Token: 0x0200005C RID: 92
		protected enum EditState
		{
			// Token: 0x04000183 RID: 387
			Continue,
			// Token: 0x04000184 RID: 388
			Finish
		}

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x060005C3 RID: 1475
		public delegate char OnValidateInput(string text, int charIndex, char addedChar);
	}
}
