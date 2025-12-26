using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Styling information for GUI elements.</para>
	/// </summary>
	// Token: 0x020001E7 RID: 487
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class GUIStyle
	{
		/// <summary>
		///   <para>Constructor for empty GUIStyle.</para>
		/// </summary>
		// Token: 0x06001C68 RID: 7272 RVA: 0x0000AFB1 File Offset: 0x000091B1
		public GUIStyle()
		{
			this.Init();
		}

		/// <summary>
		///   <para>Constructs GUIStyle identical to given other GUIStyle.</para>
		/// </summary>
		/// <param name="other"></param>
		// Token: 0x06001C69 RID: 7273 RVA: 0x0000AFBF File Offset: 0x000091BF
		public GUIStyle(GUIStyle other)
		{
			this.InitCopy(other);
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x00023388 File Offset: 0x00021588
		~GUIStyle()
		{
			this.Cleanup();
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x000233B8 File Offset: 0x000215B8
		internal void InternalOnAfterDeserialize()
		{
			this.m_FontInternal = this.GetFontInternal();
			this.m_Normal = new GUIStyleState(this, this.GetStyleStatePtr(0));
			this.m_Hover = new GUIStyleState(this, this.GetStyleStatePtr(1));
			this.m_Active = new GUIStyleState(this, this.GetStyleStatePtr(2));
			this.m_Focused = new GUIStyleState(this, this.GetStyleStatePtr(3));
			this.m_OnNormal = new GUIStyleState(this, this.GetStyleStatePtr(4));
			this.m_OnHover = new GUIStyleState(this, this.GetStyleStatePtr(5));
			this.m_OnActive = new GUIStyleState(this, this.GetStyleStatePtr(6));
			this.m_OnFocused = new GUIStyleState(this, this.GetStyleStatePtr(7));
		}

		/// <summary>
		///   <para>Rendering settings for when the component is displayed normally.</para>
		/// </summary>
		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x0000AFD6 File Offset: 0x000091D6
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x0000AFFC File Offset: 0x000091FC
		public GUIStyleState normal
		{
			get
			{
				if (this.m_Normal == null)
				{
					this.m_Normal = new GUIStyleState(this, this.GetStyleStatePtr(0));
				}
				return this.m_Normal;
			}
			set
			{
				this.AssignStyleState(0, value.m_Ptr);
			}
		}

		/// <summary>
		///   <para>Rendering settings for when the mouse is hovering over the control.</para>
		/// </summary>
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x0000B00B File Offset: 0x0000920B
		// (set) Token: 0x06001C70 RID: 7280 RVA: 0x0000B031 File Offset: 0x00009231
		public GUIStyleState hover
		{
			get
			{
				if (this.m_Hover == null)
				{
					this.m_Hover = new GUIStyleState(this, this.GetStyleStatePtr(1));
				}
				return this.m_Hover;
			}
			set
			{
				this.AssignStyleState(1, value.m_Ptr);
			}
		}

		/// <summary>
		///   <para>Rendering settings for when the control is pressed down.</para>
		/// </summary>
		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x0000B040 File Offset: 0x00009240
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x0000B066 File Offset: 0x00009266
		public GUIStyleState active
		{
			get
			{
				if (this.m_Active == null)
				{
					this.m_Active = new GUIStyleState(this, this.GetStyleStatePtr(2));
				}
				return this.m_Active;
			}
			set
			{
				this.AssignStyleState(2, value.m_Ptr);
			}
		}

		/// <summary>
		///   <para>Rendering settings for when the control is turned on.</para>
		/// </summary>
		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x0000B075 File Offset: 0x00009275
		// (set) Token: 0x06001C74 RID: 7284 RVA: 0x0000B09B File Offset: 0x0000929B
		public GUIStyleState onNormal
		{
			get
			{
				if (this.m_OnNormal == null)
				{
					this.m_OnNormal = new GUIStyleState(this, this.GetStyleStatePtr(4));
				}
				return this.m_OnNormal;
			}
			set
			{
				this.AssignStyleState(4, value.m_Ptr);
			}
		}

		/// <summary>
		///   <para>Rendering settings for when the control is turned on and the mouse is hovering it.</para>
		/// </summary>
		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x0000B0AA File Offset: 0x000092AA
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x0000B0D0 File Offset: 0x000092D0
		public GUIStyleState onHover
		{
			get
			{
				if (this.m_OnHover == null)
				{
					this.m_OnHover = new GUIStyleState(this, this.GetStyleStatePtr(5));
				}
				return this.m_OnHover;
			}
			set
			{
				this.AssignStyleState(5, value.m_Ptr);
			}
		}

		/// <summary>
		///   <para>Rendering settings for when the element is turned on and pressed down.</para>
		/// </summary>
		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x0000B0DF File Offset: 0x000092DF
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x0000B105 File Offset: 0x00009305
		public GUIStyleState onActive
		{
			get
			{
				if (this.m_OnActive == null)
				{
					this.m_OnActive = new GUIStyleState(this, this.GetStyleStatePtr(6));
				}
				return this.m_OnActive;
			}
			set
			{
				this.AssignStyleState(6, value.m_Ptr);
			}
		}

		/// <summary>
		///   <para>Rendering settings for when the element has keyboard focus.</para>
		/// </summary>
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x0000B114 File Offset: 0x00009314
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x0000B13A File Offset: 0x0000933A
		public GUIStyleState focused
		{
			get
			{
				if (this.m_Focused == null)
				{
					this.m_Focused = new GUIStyleState(this, this.GetStyleStatePtr(3));
				}
				return this.m_Focused;
			}
			set
			{
				this.AssignStyleState(3, value.m_Ptr);
			}
		}

		/// <summary>
		///   <para>Rendering settings for when the element has keyboard and is turned on.</para>
		/// </summary>
		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x0000B149 File Offset: 0x00009349
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x0000B16F File Offset: 0x0000936F
		public GUIStyleState onFocused
		{
			get
			{
				if (this.m_OnFocused == null)
				{
					this.m_OnFocused = new GUIStyleState(this, this.GetStyleStatePtr(7));
				}
				return this.m_OnFocused;
			}
			set
			{
				this.AssignStyleState(7, value.m_Ptr);
			}
		}

		/// <summary>
		///   <para>The borders of all background images.</para>
		/// </summary>
		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x0000B17E File Offset: 0x0000937E
		// (set) Token: 0x06001C7E RID: 7294 RVA: 0x0000B1A4 File Offset: 0x000093A4
		public RectOffset border
		{
			get
			{
				if (this.m_Border == null)
				{
					this.m_Border = new RectOffset(this, this.GetRectOffsetPtr(0));
				}
				return this.m_Border;
			}
			set
			{
				this.AssignRectOffset(0, value.m_Ptr);
			}
		}

		/// <summary>
		///   <para>The margins between elements rendered in this style and any other GUI elements.</para>
		/// </summary>
		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x0000B1B3 File Offset: 0x000093B3
		// (set) Token: 0x06001C80 RID: 7296 RVA: 0x0000B1D9 File Offset: 0x000093D9
		public RectOffset margin
		{
			get
			{
				if (this.m_Margin == null)
				{
					this.m_Margin = new RectOffset(this, this.GetRectOffsetPtr(1));
				}
				return this.m_Margin;
			}
			set
			{
				this.AssignRectOffset(1, value.m_Ptr);
			}
		}

		/// <summary>
		///   <para>Space from the edge of GUIStyle to the start of the contents.</para>
		/// </summary>
		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x0000B1E8 File Offset: 0x000093E8
		// (set) Token: 0x06001C82 RID: 7298 RVA: 0x0000B20E File Offset: 0x0000940E
		public RectOffset padding
		{
			get
			{
				if (this.m_Padding == null)
				{
					this.m_Padding = new RectOffset(this, this.GetRectOffsetPtr(2));
				}
				return this.m_Padding;
			}
			set
			{
				this.AssignRectOffset(2, value.m_Ptr);
			}
		}

		/// <summary>
		///   <para>Extra space to be added to the background image.</para>
		/// </summary>
		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x0000B21D File Offset: 0x0000941D
		// (set) Token: 0x06001C84 RID: 7300 RVA: 0x0000B243 File Offset: 0x00009443
		public RectOffset overflow
		{
			get
			{
				if (this.m_Overflow == null)
				{
					this.m_Overflow = new RectOffset(this, this.GetRectOffsetPtr(3));
				}
				return this.m_Overflow;
			}
			set
			{
				this.AssignRectOffset(3, value.m_Ptr);
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x0000B252 File Offset: 0x00009452
		// (set) Token: 0x06001C86 RID: 7302 RVA: 0x0000B25A File Offset: 0x0000945A
		[Obsolete("warning Don't use clipOffset - put things inside BeginGroup instead. This functionality will be removed in a later version.")]
		public Vector2 clipOffset
		{
			get
			{
				return this.Internal_clipOffset;
			}
			set
			{
				this.Internal_clipOffset = value;
			}
		}

		/// <summary>
		///   <para>The font to use for rendering. If null, the default font for the current GUISkin is used instead.</para>
		/// </summary>
		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x0000B263 File Offset: 0x00009463
		// (set) Token: 0x06001C88 RID: 7304 RVA: 0x0000B26B File Offset: 0x0000946B
		public Font font
		{
			get
			{
				return this.GetFontInternal();
			}
			set
			{
				this.SetFontInternal(value);
				this.m_FontInternal = value;
			}
		}

		/// <summary>
		///   <para>The height of one line of text with this style, measured in pixels. (Read Only)</para>
		/// </summary>
		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x0000B27B File Offset: 0x0000947B
		public float lineHeight
		{
			get
			{
				return Mathf.Round(GUIStyle.Internal_GetLineHeight(this.m_Ptr));
			}
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0002346C File Offset: 0x0002166C
		private static void Internal_Draw(IntPtr target, Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			Internal_DrawArguments internal_DrawArguments = default(Internal_DrawArguments);
			internal_DrawArguments.target = target;
			internal_DrawArguments.position = position;
			internal_DrawArguments.isHover = ((!isHover) ? 0 : 1);
			internal_DrawArguments.isActive = ((!isActive) ? 0 : 1);
			internal_DrawArguments.on = ((!on) ? 0 : 1);
			internal_DrawArguments.hasKeyboardFocus = ((!hasKeyboardFocus) ? 0 : 1);
			GUIStyle.Internal_Draw(content, ref internal_DrawArguments);
		}

		/// <summary>
		///   <para>Draw this GUIStyle on to the screen, internal version.</para>
		/// </summary>
		/// <param name="position"></param>
		/// <param name="isHover"></param>
		/// <param name="isActive"></param>
		/// <param name="on"></param>
		/// <param name="hasKeyboardFocus"></param>
		// Token: 0x06001C8B RID: 7307 RVA: 0x0000B28D File Offset: 0x0000948D
		public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			GUIStyle.Internal_Draw(this.m_Ptr, position, GUIContent.none, isHover, isActive, on, hasKeyboardFocus);
		}

		/// <summary>
		///   <para>Draw the GUIStyle with a text string inside.</para>
		/// </summary>
		/// <param name="position"></param>
		/// <param name="text"></param>
		/// <param name="isHover"></param>
		/// <param name="isActive"></param>
		/// <param name="on"></param>
		/// <param name="hasKeyboardFocus"></param>
		// Token: 0x06001C8C RID: 7308 RVA: 0x0000B2A6 File Offset: 0x000094A6
		public void Draw(Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			GUIStyle.Internal_Draw(this.m_Ptr, position, GUIContent.Temp(text), isHover, isActive, on, hasKeyboardFocus);
		}

		/// <summary>
		///   <para>Draw the GUIStyle with an image inside. If the image is too large to fit within the content area of the style it is scaled down.</para>
		/// </summary>
		/// <param name="position"></param>
		/// <param name="image"></param>
		/// <param name="isHover"></param>
		/// <param name="isActive"></param>
		/// <param name="on"></param>
		/// <param name="hasKeyboardFocus"></param>
		// Token: 0x06001C8D RID: 7309 RVA: 0x0000B2C1 File Offset: 0x000094C1
		public void Draw(Rect position, Texture image, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			GUIStyle.Internal_Draw(this.m_Ptr, position, GUIContent.Temp(image), isHover, isActive, on, hasKeyboardFocus);
		}

		/// <summary>
		///   <para>Draw the GUIStyle with text and an image inside. If the image is too large to fit within the content area of the style it is scaled down.</para>
		/// </summary>
		/// <param name="position"></param>
		/// <param name="content"></param>
		/// <param name="controlID"></param>
		/// <param name="on"></param>
		/// <param name="isHover"></param>
		/// <param name="isActive"></param>
		/// <param name="hasKeyboardFocus"></param>
		// Token: 0x06001C8E RID: 7310 RVA: 0x0000B2DC File Offset: 0x000094DC
		public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			GUIStyle.Internal_Draw(this.m_Ptr, position, content, isHover, isActive, on, hasKeyboardFocus);
		}

		/// <summary>
		///   <para>Draw the GUIStyle with text and an image inside. If the image is too large to fit within the content area of the style it is scaled down.</para>
		/// </summary>
		/// <param name="position"></param>
		/// <param name="content"></param>
		/// <param name="controlID"></param>
		/// <param name="on"></param>
		/// <param name="isHover"></param>
		/// <param name="isActive"></param>
		/// <param name="hasKeyboardFocus"></param>
		// Token: 0x06001C8F RID: 7311 RVA: 0x0000B2F2 File Offset: 0x000094F2
		public void Draw(Rect position, GUIContent content, int controlID)
		{
			this.Draw(position, content, controlID, false);
		}

		/// <summary>
		///   <para>Draw the GUIStyle with text and an image inside. If the image is too large to fit within the content area of the style it is scaled down.</para>
		/// </summary>
		/// <param name="position"></param>
		/// <param name="content"></param>
		/// <param name="controlID"></param>
		/// <param name="on"></param>
		/// <param name="isHover"></param>
		/// <param name="isActive"></param>
		/// <param name="hasKeyboardFocus"></param>
		// Token: 0x06001C90 RID: 7312 RVA: 0x0000B2FE File Offset: 0x000094FE
		public void Draw(Rect position, GUIContent content, int controlID, bool on)
		{
			if (content != null)
			{
				GUIStyle.Internal_Draw2(this.m_Ptr, position, content, controlID, on);
			}
			else
			{
				Debug.LogError("Style.Draw may not be called with GUIContent that is null.");
			}
		}

		/// <summary>
		///   <para>Draw this GUIStyle with selected content.</para>
		/// </summary>
		/// <param name="position"></param>
		/// <param name="content"></param>
		/// <param name="controlID"></param>
		/// <param name="Character"></param>
		// Token: 0x06001C91 RID: 7313 RVA: 0x000234EC File Offset: 0x000216EC
		public void DrawCursor(Rect position, GUIContent content, int controlID, int Character)
		{
			Event current = Event.current;
			if (current.type == EventType.Repaint)
			{
				Color cursorColor = new Color(0f, 0f, 0f, 0f);
				float cursorFlashSpeed = GUI.skin.settings.cursorFlashSpeed;
				float num = (Time.realtimeSinceStartup - GUIStyle.Internal_GetCursorFlashOffset()) % cursorFlashSpeed / cursorFlashSpeed;
				if (cursorFlashSpeed == 0f || num < 0.5f)
				{
					cursorColor = GUI.skin.settings.cursorColor;
				}
				GUIStyle.Internal_DrawCursor(this.m_Ptr, position, content, Character, cursorColor);
			}
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0002357C File Offset: 0x0002177C
		internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition)
		{
			Event current = Event.current;
			Color cursorColor = new Color(0f, 0f, 0f, 0f);
			float cursorFlashSpeed = GUI.skin.settings.cursorFlashSpeed;
			float num = (Time.realtimeSinceStartup - GUIStyle.Internal_GetCursorFlashOffset()) % cursorFlashSpeed / cursorFlashSpeed;
			if (cursorFlashSpeed == 0f || num < 0.5f)
			{
				cursorColor = GUI.skin.settings.cursorColor;
			}
			Internal_DrawWithTextSelectionArguments internal_DrawWithTextSelectionArguments = default(Internal_DrawWithTextSelectionArguments);
			internal_DrawWithTextSelectionArguments.target = this.m_Ptr;
			internal_DrawWithTextSelectionArguments.position = position;
			internal_DrawWithTextSelectionArguments.firstPos = firstSelectedCharacter;
			internal_DrawWithTextSelectionArguments.lastPos = lastSelectedCharacter;
			internal_DrawWithTextSelectionArguments.cursorColor = cursorColor;
			internal_DrawWithTextSelectionArguments.selectionColor = GUI.skin.settings.selectionColor;
			internal_DrawWithTextSelectionArguments.isHover = ((!position.Contains(current.mousePosition)) ? 0 : 1);
			internal_DrawWithTextSelectionArguments.isActive = ((controlID != GUIUtility.hotControl) ? 0 : 1);
			internal_DrawWithTextSelectionArguments.on = 0;
			internal_DrawWithTextSelectionArguments.hasKeyboardFocus = ((controlID != GUIUtility.keyboardControl || !GUIStyle.showKeyboardFocus) ? 0 : 1);
			internal_DrawWithTextSelectionArguments.drawSelectionAsComposition = ((!drawSelectionAsComposition) ? 0 : 1);
			GUIStyle.Internal_DrawWithTextSelection(content, ref internal_DrawWithTextSelectionArguments);
		}

		/// <summary>
		///   <para>Draw this GUIStyle with selected content.</para>
		/// </summary>
		/// <param name="position"></param>
		/// <param name="content"></param>
		/// <param name="controlID"></param>
		/// <param name="firstSelectedCharacter"></param>
		/// <param name="lastSelectedCharacter"></param>
		// Token: 0x06001C93 RID: 7315 RVA: 0x0000B325 File Offset: 0x00009525
		public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter)
		{
			this.DrawWithTextSelection(position, content, controlID, firstSelectedCharacter, lastSelectedCharacter, false);
		}

		/// <summary>
		///   <para>Shortcut for an empty GUIStyle.</para>
		/// </summary>
		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x0000B335 File Offset: 0x00009535
		public static GUIStyle none
		{
			get
			{
				if (GUIStyle.s_None == null)
				{
					GUIStyle.s_None = new GUIStyle();
				}
				return GUIStyle.s_None;
			}
		}

		/// <summary>
		///   <para>Get the pixel position of a given string index.</para>
		/// </summary>
		/// <param name="position"></param>
		/// <param name="content"></param>
		/// <param name="cursorStringIndex"></param>
		// Token: 0x06001C95 RID: 7317 RVA: 0x000236C0 File Offset: 0x000218C0
		public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
		{
			Vector2 vector;
			GUIStyle.Internal_GetCursorPixelPosition(this.m_Ptr, position, content, cursorStringIndex, out vector);
			return vector;
		}

		/// <summary>
		///   <para>Get the cursor position (indexing into contents.text) when the user clicked at cursorPixelPosition.</para>
		/// </summary>
		/// <param name="position"></param>
		/// <param name="content"></param>
		/// <param name="cursorPixelPosition"></param>
		// Token: 0x06001C96 RID: 7318 RVA: 0x0000B350 File Offset: 0x00009550
		public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			return GUIStyle.Internal_GetCursorStringIndex(this.m_Ptr, position, content, cursorPixelPosition);
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0000B360 File Offset: 0x00009560
		internal int GetNumCharactersThatFitWithinWidth(string text, float width)
		{
			return GUIStyle.Internal_GetNumCharactersThatFitWithinWidth(this.m_Ptr, text, width);
		}

		/// <summary>
		///   <para>Calculate the size of a some content if it is rendered with this style.</para>
		/// </summary>
		/// <param name="content"></param>
		// Token: 0x06001C98 RID: 7320 RVA: 0x000236E0 File Offset: 0x000218E0
		public Vector2 CalcSize(GUIContent content)
		{
			Vector2 vector;
			GUIStyle.Internal_CalcSize(this.m_Ptr, content, out vector);
			return vector;
		}

		/// <summary>
		///   <para>Calculate the size of an element formatted with this style, and a given space to content.</para>
		/// </summary>
		/// <param name="contentSize"></param>
		// Token: 0x06001C99 RID: 7321 RVA: 0x000236FC File Offset: 0x000218FC
		public Vector2 CalcScreenSize(Vector2 contentSize)
		{
			return new Vector2((this.fixedWidth == 0f) ? Mathf.Ceil(contentSize.x + (float)this.padding.left + (float)this.padding.right) : this.fixedWidth, (this.fixedHeight == 0f) ? Mathf.Ceil(contentSize.y + (float)this.padding.top + (float)this.padding.bottom) : this.fixedHeight);
		}

		/// <summary>
		///   <para>How tall this element will be when rendered with content and a specific width.</para>
		/// </summary>
		/// <param name="content"></param>
		/// <param name="width"></param>
		// Token: 0x06001C9A RID: 7322 RVA: 0x0000B36F File Offset: 0x0000956F
		public float CalcHeight(GUIContent content, float width)
		{
			return GUIStyle.Internal_CalcHeight(this.m_Ptr, content, width);
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x0000B37E File Offset: 0x0000957E
		public bool isHeightDependantOnWidth
		{
			get
			{
				return this.fixedHeight == 0f && this.wordWrap && this.imagePosition != ImagePosition.ImageOnly;
			}
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0000B3AD File Offset: 0x000095AD
		public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
		{
			GUIStyle.Internal_CalcMinMaxWidth(this.m_Ptr, content, out minWidth, out maxWidth);
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0000B3BD File Offset: 0x000095BD
		public override string ToString()
		{
			return UnityString.Format("GUIStyle '{0}'", new object[] { this.name });
		}

		// Token: 0x06001C9E RID: 7326
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init();

		// Token: 0x06001C9F RID: 7327
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InitCopy(GUIStyle other);

		// Token: 0x06001CA0 RID: 7328
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Cleanup();

		/// <summary>
		///   <para>The name of this GUIStyle. Used for getting them based on name.</para>
		/// </summary>
		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001CA1 RID: 7329
		// (set) Token: 0x06001CA2 RID: 7330
		public extern string name
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001CA3 RID: 7331
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern IntPtr GetStyleStatePtr(int idx);

		// Token: 0x06001CA4 RID: 7332
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void AssignStyleState(int idx, IntPtr srcStyleState);

		// Token: 0x06001CA5 RID: 7333
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern IntPtr GetRectOffsetPtr(int idx);

		// Token: 0x06001CA6 RID: 7334
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void AssignRectOffset(int idx, IntPtr srcRectOffset);

		/// <summary>
		///   <para>How image and text of the GUIContent is combined.</para>
		/// </summary>
		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001CA7 RID: 7335
		// (set) Token: 0x06001CA8 RID: 7336
		public extern ImagePosition imagePosition
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Text alignment.</para>
		/// </summary>
		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001CA9 RID: 7337
		// (set) Token: 0x06001CAA RID: 7338
		public extern TextAnchor alignment
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should the text be wordwrapped?</para>
		/// </summary>
		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001CAB RID: 7339
		// (set) Token: 0x06001CAC RID: 7340
		public extern bool wordWrap
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>What to do when the contents to be rendered is too large to fit within the area given.</para>
		/// </summary>
		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001CAD RID: 7341
		// (set) Token: 0x06001CAE RID: 7342
		public extern TextClipping clipping
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Pixel offset to apply to the content of this GUIstyle.</para>
		/// </summary>
		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x00023790 File Offset: 0x00021990
		// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x0000B3D8 File Offset: 0x000095D8
		public Vector2 contentOffset
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_contentOffset(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_contentOffset(ref value);
			}
		}

		// Token: 0x06001CB1 RID: 7345
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_contentOffset(out Vector2 value);

		// Token: 0x06001CB2 RID: 7346
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_contentOffset(ref Vector2 value);

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x000237A8 File Offset: 0x000219A8
		// (set) Token: 0x06001CB4 RID: 7348 RVA: 0x0000B3E2 File Offset: 0x000095E2
		internal Vector2 Internal_clipOffset
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_Internal_clipOffset(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_Internal_clipOffset(ref value);
			}
		}

		// Token: 0x06001CB5 RID: 7349
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_Internal_clipOffset(out Vector2 value);

		// Token: 0x06001CB6 RID: 7350
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_Internal_clipOffset(ref Vector2 value);

		/// <summary>
		///   <para>If non-0, any GUI elements rendered with this style will have the width specified here.</para>
		/// </summary>
		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001CB7 RID: 7351
		// (set) Token: 0x06001CB8 RID: 7352
		public extern float fixedWidth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>If non-0, any GUI elements rendered with this style will have the height specified here.</para>
		/// </summary>
		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001CB9 RID: 7353
		// (set) Token: 0x06001CBA RID: 7354
		public extern float fixedHeight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Can GUI elements of this style be stretched horizontally for better layouting?</para>
		/// </summary>
		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001CBB RID: 7355
		// (set) Token: 0x06001CBC RID: 7356
		public extern bool stretchWidth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Can GUI elements of this style be stretched vertically for better layout?</para>
		/// </summary>
		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001CBD RID: 7357
		// (set) Token: 0x06001CBE RID: 7358
		public extern bool stretchHeight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001CBF RID: 7359
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetLineHeight(IntPtr target);

		// Token: 0x06001CC0 RID: 7360
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetFontInternal(Font value);

		// Token: 0x06001CC1 RID: 7361
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Font GetFontInternal();

		/// <summary>
		///   <para>The font size to use (for dynamic fonts).</para>
		/// </summary>
		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001CC2 RID: 7362
		// (set) Token: 0x06001CC3 RID: 7363
		public extern int fontSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The font style to use (for dynamic fonts).</para>
		/// </summary>
		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001CC4 RID: 7364
		// (set) Token: 0x06001CC5 RID: 7365
		public extern FontStyle fontStyle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Enable HTML-style tags for Text Formatting Markup.</para>
		/// </summary>
		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001CC6 RID: 7366
		// (set) Token: 0x06001CC7 RID: 7367
		public extern bool richText
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001CC8 RID: 7368
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Draw(GUIContent content, ref Internal_DrawArguments arguments);

		// Token: 0x06001CC9 RID: 7369 RVA: 0x0000B3EC File Offset: 0x000095EC
		private static void Internal_Draw2(IntPtr style, Rect position, GUIContent content, int controlID, bool on)
		{
			GUIStyle.INTERNAL_CALL_Internal_Draw2(style, ref position, content, controlID, on);
		}

		// Token: 0x06001CCA RID: 7370
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_Draw2(IntPtr style, ref Rect position, GUIContent content, int controlID, bool on);

		// Token: 0x06001CCB RID: 7371 RVA: 0x0000B3FA File Offset: 0x000095FA
		private static void Internal_DrawPrefixLabel(IntPtr style, Rect position, GUIContent content, int controlID, bool on)
		{
			GUIStyle.INTERNAL_CALL_Internal_DrawPrefixLabel(style, ref position, content, controlID, on);
		}

		// Token: 0x06001CCC RID: 7372
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_DrawPrefixLabel(IntPtr style, ref Rect position, GUIContent content, int controlID, bool on);

		// Token: 0x06001CCD RID: 7373
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetCursorFlashOffset();

		// Token: 0x06001CCE RID: 7374 RVA: 0x0000B408 File Offset: 0x00009608
		private static void Internal_DrawCursor(IntPtr target, Rect position, GUIContent content, int pos, Color cursorColor)
		{
			GUIStyle.INTERNAL_CALL_Internal_DrawCursor(target, ref position, content, pos, ref cursorColor);
		}

		// Token: 0x06001CCF RID: 7375
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_DrawCursor(IntPtr target, ref Rect position, GUIContent content, int pos, ref Color cursorColor);

		// Token: 0x06001CD0 RID: 7376
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_DrawWithTextSelection(GUIContent content, ref Internal_DrawWithTextSelectionArguments arguments);

		// Token: 0x06001CD1 RID: 7377
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetDefaultFont(Font font);

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0000B416 File Offset: 0x00009616
		internal static void Internal_GetCursorPixelPosition(IntPtr target, Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret)
		{
			GUIStyle.INTERNAL_CALL_Internal_GetCursorPixelPosition(target, ref position, content, cursorStringIndex, out ret);
		}

		// Token: 0x06001CD3 RID: 7379
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_GetCursorPixelPosition(IntPtr target, ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret);

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0000B424 File Offset: 0x00009624
		internal static int Internal_GetCursorStringIndex(IntPtr target, Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			return GUIStyle.INTERNAL_CALL_Internal_GetCursorStringIndex(target, ref position, content, ref cursorPixelPosition);
		}

		// Token: 0x06001CD5 RID: 7381
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_GetCursorStringIndex(IntPtr target, ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition);

		// Token: 0x06001CD6 RID: 7382
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Internal_GetNumCharactersThatFitWithinWidth(IntPtr target, string text, float width);

		// Token: 0x06001CD7 RID: 7383
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_CalcSize(IntPtr target, GUIContent content, out Vector2 ret);

		// Token: 0x06001CD8 RID: 7384
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_CalcHeight(IntPtr target, GUIContent content, float width);

		// Token: 0x06001CD9 RID: 7385
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CalcMinMaxWidth(IntPtr target, GUIContent content, out float minWidth, out float maxWidth);

		// Token: 0x06001CDA RID: 7386 RVA: 0x0000B431 File Offset: 0x00009631
		public static implicit operator GUIStyle(string str)
		{
			if (GUISkin.current == null)
			{
				Debug.LogError("Unable to use a named GUIStyle without a current skin. Most likely you need to move your GUIStyle initialization code to OnGUI");
				return GUISkin.error;
			}
			return GUISkin.current.GetStyle(str);
		}

		// Token: 0x04000787 RID: 1927
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x04000788 RID: 1928
		[NonSerialized]
		private GUIStyleState m_Normal;

		// Token: 0x04000789 RID: 1929
		[NonSerialized]
		private GUIStyleState m_Hover;

		// Token: 0x0400078A RID: 1930
		[NonSerialized]
		private GUIStyleState m_Active;

		// Token: 0x0400078B RID: 1931
		[NonSerialized]
		private GUIStyleState m_Focused;

		// Token: 0x0400078C RID: 1932
		[NonSerialized]
		private GUIStyleState m_OnNormal;

		// Token: 0x0400078D RID: 1933
		[NonSerialized]
		private GUIStyleState m_OnHover;

		// Token: 0x0400078E RID: 1934
		[NonSerialized]
		private GUIStyleState m_OnActive;

		// Token: 0x0400078F RID: 1935
		[NonSerialized]
		private GUIStyleState m_OnFocused;

		// Token: 0x04000790 RID: 1936
		[NonSerialized]
		private RectOffset m_Border;

		// Token: 0x04000791 RID: 1937
		[NonSerialized]
		private RectOffset m_Padding;

		// Token: 0x04000792 RID: 1938
		[NonSerialized]
		private RectOffset m_Margin;

		// Token: 0x04000793 RID: 1939
		[NonSerialized]
		private RectOffset m_Overflow;

		// Token: 0x04000794 RID: 1940
		[NonSerialized]
		private Font m_FontInternal;

		// Token: 0x04000795 RID: 1941
		internal static bool showKeyboardFocus = true;

		// Token: 0x04000796 RID: 1942
		private static GUIStyle s_None;
	}
}
