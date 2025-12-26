using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine
{
	/// <summary>
	///   <para>Defines how GUI looks and behaves.</para>
	/// </summary>
	// Token: 0x020001E1 RID: 481
	[ExecuteInEditMode]
	[Serializable]
	public sealed class GUISkin : ScriptableObject
	{
		// Token: 0x06001C0C RID: 7180 RVA: 0x0000AC31 File Offset: 0x00008E31
		public GUISkin()
		{
			this.m_CustomStyles = new GUIStyle[1];
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0000AC50 File Offset: 0x00008E50
		internal void OnEnable()
		{
			this.Apply();
		}

		/// <summary>
		///   <para>The default font to use for all styles.</para>
		/// </summary>
		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x0000AC58 File Offset: 0x00008E58
		// (set) Token: 0x06001C0F RID: 7183 RVA: 0x0000AC60 File Offset: 0x00008E60
		public Font font
		{
			get
			{
				return this.m_Font;
			}
			set
			{
				this.m_Font = value;
				if (GUISkin.current == this)
				{
					GUIStyle.SetDefaultFont(this.m_Font);
				}
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for GUI.Box controls.</para>
		/// </summary>
		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x0000AC8A File Offset: 0x00008E8A
		// (set) Token: 0x06001C11 RID: 7185 RVA: 0x0000AC92 File Offset: 0x00008E92
		public GUIStyle box
		{
			get
			{
				return this.m_box;
			}
			set
			{
				this.m_box = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for GUI.Label controls.</para>
		/// </summary>
		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x0000ACA1 File Offset: 0x00008EA1
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x0000ACA9 File Offset: 0x00008EA9
		public GUIStyle label
		{
			get
			{
				return this.m_label;
			}
			set
			{
				this.m_label = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for GUI.TextField controls.</para>
		/// </summary>
		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x0000ACB8 File Offset: 0x00008EB8
		// (set) Token: 0x06001C15 RID: 7189 RVA: 0x0000ACC0 File Offset: 0x00008EC0
		public GUIStyle textField
		{
			get
			{
				return this.m_textField;
			}
			set
			{
				this.m_textField = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for GUI.TextArea controls.</para>
		/// </summary>
		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x0000ACCF File Offset: 0x00008ECF
		// (set) Token: 0x06001C17 RID: 7191 RVA: 0x0000ACD7 File Offset: 0x00008ED7
		public GUIStyle textArea
		{
			get
			{
				return this.m_textArea;
			}
			set
			{
				this.m_textArea = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for GUI.Button controls.</para>
		/// </summary>
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x0000ACE6 File Offset: 0x00008EE6
		// (set) Token: 0x06001C19 RID: 7193 RVA: 0x0000ACEE File Offset: 0x00008EEE
		public GUIStyle button
		{
			get
			{
				return this.m_button;
			}
			set
			{
				this.m_button = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for GUI.Toggle controls.</para>
		/// </summary>
		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x0000ACFD File Offset: 0x00008EFD
		// (set) Token: 0x06001C1B RID: 7195 RVA: 0x0000AD05 File Offset: 0x00008F05
		public GUIStyle toggle
		{
			get
			{
				return this.m_toggle;
			}
			set
			{
				this.m_toggle = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for Window controls (SA GUI.Window).</para>
		/// </summary>
		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x0000AD14 File Offset: 0x00008F14
		// (set) Token: 0x06001C1D RID: 7197 RVA: 0x0000AD1C File Offset: 0x00008F1C
		public GUIStyle window
		{
			get
			{
				return this.m_window;
			}
			set
			{
				this.m_window = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for the background part of GUI.HorizontalSlider controls.</para>
		/// </summary>
		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x0000AD2B File Offset: 0x00008F2B
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x0000AD33 File Offset: 0x00008F33
		public GUIStyle horizontalSlider
		{
			get
			{
				return this.m_horizontalSlider;
			}
			set
			{
				this.m_horizontalSlider = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for the thumb that is dragged in GUI.HorizontalSlider controls.</para>
		/// </summary>
		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x0000AD42 File Offset: 0x00008F42
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x0000AD4A File Offset: 0x00008F4A
		public GUIStyle horizontalSliderThumb
		{
			get
			{
				return this.m_horizontalSliderThumb;
			}
			set
			{
				this.m_horizontalSliderThumb = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for the background part of GUI.VerticalSlider controls.</para>
		/// </summary>
		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x0000AD59 File Offset: 0x00008F59
		// (set) Token: 0x06001C23 RID: 7203 RVA: 0x0000AD61 File Offset: 0x00008F61
		public GUIStyle verticalSlider
		{
			get
			{
				return this.m_verticalSlider;
			}
			set
			{
				this.m_verticalSlider = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for the thumb that is dragged in GUI.VerticalSlider controls.</para>
		/// </summary>
		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x0000AD70 File Offset: 0x00008F70
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x0000AD78 File Offset: 0x00008F78
		public GUIStyle verticalSliderThumb
		{
			get
			{
				return this.m_verticalSliderThumb;
			}
			set
			{
				this.m_verticalSliderThumb = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for the background part of GUI.HorizontalScrollbar controls.</para>
		/// </summary>
		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x0000AD87 File Offset: 0x00008F87
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x0000AD8F File Offset: 0x00008F8F
		public GUIStyle horizontalScrollbar
		{
			get
			{
				return this.m_horizontalScrollbar;
			}
			set
			{
				this.m_horizontalScrollbar = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for the thumb that is dragged in GUI.HorizontalScrollbar controls.</para>
		/// </summary>
		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x0000AD9E File Offset: 0x00008F9E
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x0000ADA6 File Offset: 0x00008FA6
		public GUIStyle horizontalScrollbarThumb
		{
			get
			{
				return this.m_horizontalScrollbarThumb;
			}
			set
			{
				this.m_horizontalScrollbarThumb = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for the left button on GUI.HorizontalScrollbar controls.</para>
		/// </summary>
		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x0000ADB5 File Offset: 0x00008FB5
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x0000ADBD File Offset: 0x00008FBD
		public GUIStyle horizontalScrollbarLeftButton
		{
			get
			{
				return this.m_horizontalScrollbarLeftButton;
			}
			set
			{
				this.m_horizontalScrollbarLeftButton = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for the right button on GUI.HorizontalScrollbar controls.</para>
		/// </summary>
		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x0000ADCC File Offset: 0x00008FCC
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x0000ADD4 File Offset: 0x00008FD4
		public GUIStyle horizontalScrollbarRightButton
		{
			get
			{
				return this.m_horizontalScrollbarRightButton;
			}
			set
			{
				this.m_horizontalScrollbarRightButton = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for the background part of GUI.VerticalScrollbar controls.</para>
		/// </summary>
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x0000ADE3 File Offset: 0x00008FE3
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x0000ADEB File Offset: 0x00008FEB
		public GUIStyle verticalScrollbar
		{
			get
			{
				return this.m_verticalScrollbar;
			}
			set
			{
				this.m_verticalScrollbar = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for the thumb that is dragged in GUI.VerticalScrollbar controls.</para>
		/// </summary>
		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x0000ADFA File Offset: 0x00008FFA
		// (set) Token: 0x06001C31 RID: 7217 RVA: 0x0000AE02 File Offset: 0x00009002
		public GUIStyle verticalScrollbarThumb
		{
			get
			{
				return this.m_verticalScrollbarThumb;
			}
			set
			{
				this.m_verticalScrollbarThumb = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for the up button on GUI.VerticalScrollbar controls.</para>
		/// </summary>
		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x0000AE11 File Offset: 0x00009011
		// (set) Token: 0x06001C33 RID: 7219 RVA: 0x0000AE19 File Offset: 0x00009019
		public GUIStyle verticalScrollbarUpButton
		{
			get
			{
				return this.m_verticalScrollbarUpButton;
			}
			set
			{
				this.m_verticalScrollbarUpButton = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for the down button on GUI.VerticalScrollbar controls.</para>
		/// </summary>
		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x0000AE28 File Offset: 0x00009028
		// (set) Token: 0x06001C35 RID: 7221 RVA: 0x0000AE30 File Offset: 0x00009030
		public GUIStyle verticalScrollbarDownButton
		{
			get
			{
				return this.m_verticalScrollbarDownButton;
			}
			set
			{
				this.m_verticalScrollbarDownButton = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Style used by default for the background of ScrollView controls (see GUI.BeginScrollView).</para>
		/// </summary>
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x0000AE3F File Offset: 0x0000903F
		// (set) Token: 0x06001C37 RID: 7223 RVA: 0x0000AE47 File Offset: 0x00009047
		public GUIStyle scrollView
		{
			get
			{
				return this.m_ScrollView;
			}
			set
			{
				this.m_ScrollView = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Array of GUI styles for specific needs.</para>
		/// </summary>
		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x0000AE56 File Offset: 0x00009056
		// (set) Token: 0x06001C39 RID: 7225 RVA: 0x0000AE5E File Offset: 0x0000905E
		public GUIStyle[] customStyles
		{
			get
			{
				return this.m_CustomStyles;
			}
			set
			{
				this.m_CustomStyles = value;
				this.Apply();
			}
		}

		/// <summary>
		///   <para>Generic settings for how controls should behave with this skin.</para>
		/// </summary>
		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x0000AE6D File Offset: 0x0000906D
		public GUISettings settings
		{
			get
			{
				return this.m_Settings;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x0000AE75 File Offset: 0x00009075
		internal static GUIStyle error
		{
			get
			{
				if (GUISkin.ms_Error == null)
				{
					GUISkin.ms_Error = new GUIStyle();
				}
				return GUISkin.ms_Error;
			}
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0000AE90 File Offset: 0x00009090
		internal void Apply()
		{
			if (this.m_CustomStyles == null)
			{
				Debug.Log("custom styles is null");
			}
			this.BuildStyleCache();
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00022CA4 File Offset: 0x00020EA4
		private void BuildStyleCache()
		{
			if (this.m_box == null)
			{
				this.m_box = new GUIStyle();
			}
			if (this.m_button == null)
			{
				this.m_button = new GUIStyle();
			}
			if (this.m_toggle == null)
			{
				this.m_toggle = new GUIStyle();
			}
			if (this.m_label == null)
			{
				this.m_label = new GUIStyle();
			}
			if (this.m_window == null)
			{
				this.m_window = new GUIStyle();
			}
			if (this.m_textField == null)
			{
				this.m_textField = new GUIStyle();
			}
			if (this.m_textArea == null)
			{
				this.m_textArea = new GUIStyle();
			}
			if (this.m_horizontalSlider == null)
			{
				this.m_horizontalSlider = new GUIStyle();
			}
			if (this.m_horizontalSliderThumb == null)
			{
				this.m_horizontalSliderThumb = new GUIStyle();
			}
			if (this.m_verticalSlider == null)
			{
				this.m_verticalSlider = new GUIStyle();
			}
			if (this.m_verticalSliderThumb == null)
			{
				this.m_verticalSliderThumb = new GUIStyle();
			}
			if (this.m_horizontalScrollbar == null)
			{
				this.m_horizontalScrollbar = new GUIStyle();
			}
			if (this.m_horizontalScrollbarThumb == null)
			{
				this.m_horizontalScrollbarThumb = new GUIStyle();
			}
			if (this.m_horizontalScrollbarLeftButton == null)
			{
				this.m_horizontalScrollbarLeftButton = new GUIStyle();
			}
			if (this.m_horizontalScrollbarRightButton == null)
			{
				this.m_horizontalScrollbarRightButton = new GUIStyle();
			}
			if (this.m_verticalScrollbar == null)
			{
				this.m_verticalScrollbar = new GUIStyle();
			}
			if (this.m_verticalScrollbarThumb == null)
			{
				this.m_verticalScrollbarThumb = new GUIStyle();
			}
			if (this.m_verticalScrollbarUpButton == null)
			{
				this.m_verticalScrollbarUpButton = new GUIStyle();
			}
			if (this.m_verticalScrollbarDownButton == null)
			{
				this.m_verticalScrollbarDownButton = new GUIStyle();
			}
			if (this.m_ScrollView == null)
			{
				this.m_ScrollView = new GUIStyle();
			}
			this.m_Styles = new Dictionary<string, GUIStyle>(StringComparer.OrdinalIgnoreCase);
			this.m_Styles["box"] = this.m_box;
			this.m_box.name = "box";
			this.m_Styles["button"] = this.m_button;
			this.m_button.name = "button";
			this.m_Styles["toggle"] = this.m_toggle;
			this.m_toggle.name = "toggle";
			this.m_Styles["label"] = this.m_label;
			this.m_label.name = "label";
			this.m_Styles["window"] = this.m_window;
			this.m_window.name = "window";
			this.m_Styles["textfield"] = this.m_textField;
			this.m_textField.name = "textfield";
			this.m_Styles["textarea"] = this.m_textArea;
			this.m_textArea.name = "textarea";
			this.m_Styles["horizontalslider"] = this.m_horizontalSlider;
			this.m_horizontalSlider.name = "horizontalslider";
			this.m_Styles["horizontalsliderthumb"] = this.m_horizontalSliderThumb;
			this.m_horizontalSliderThumb.name = "horizontalsliderthumb";
			this.m_Styles["verticalslider"] = this.m_verticalSlider;
			this.m_verticalSlider.name = "verticalslider";
			this.m_Styles["verticalsliderthumb"] = this.m_verticalSliderThumb;
			this.m_verticalSliderThumb.name = "verticalsliderthumb";
			this.m_Styles["horizontalscrollbar"] = this.m_horizontalScrollbar;
			this.m_horizontalScrollbar.name = "horizontalscrollbar";
			this.m_Styles["horizontalscrollbarthumb"] = this.m_horizontalScrollbarThumb;
			this.m_horizontalScrollbarThumb.name = "horizontalscrollbarthumb";
			this.m_Styles["horizontalscrollbarleftbutton"] = this.m_horizontalScrollbarLeftButton;
			this.m_horizontalScrollbarLeftButton.name = "horizontalscrollbarleftbutton";
			this.m_Styles["horizontalscrollbarrightbutton"] = this.m_horizontalScrollbarRightButton;
			this.m_horizontalScrollbarRightButton.name = "horizontalscrollbarrightbutton";
			this.m_Styles["verticalscrollbar"] = this.m_verticalScrollbar;
			this.m_verticalScrollbar.name = "verticalscrollbar";
			this.m_Styles["verticalscrollbarthumb"] = this.m_verticalScrollbarThumb;
			this.m_verticalScrollbarThumb.name = "verticalscrollbarthumb";
			this.m_Styles["verticalscrollbarupbutton"] = this.m_verticalScrollbarUpButton;
			this.m_verticalScrollbarUpButton.name = "verticalscrollbarupbutton";
			this.m_Styles["verticalscrollbardownbutton"] = this.m_verticalScrollbarDownButton;
			this.m_verticalScrollbarDownButton.name = "verticalscrollbardownbutton";
			this.m_Styles["scrollview"] = this.m_ScrollView;
			this.m_ScrollView.name = "scrollview";
			if (this.m_CustomStyles != null)
			{
				for (int i = 0; i < this.m_CustomStyles.Length; i++)
				{
					if (this.m_CustomStyles[i] != null)
					{
						this.m_Styles[this.m_CustomStyles[i].name] = this.m_CustomStyles[i];
					}
				}
			}
			GUISkin.error.stretchHeight = true;
			GUISkin.error.normal.textColor = Color.red;
		}

		/// <summary>
		///   <para>Get a named GUIStyle.</para>
		/// </summary>
		/// <param name="styleName"></param>
		// Token: 0x06001C3E RID: 7230 RVA: 0x000231E8 File Offset: 0x000213E8
		public GUIStyle GetStyle(string styleName)
		{
			GUIStyle guistyle = this.FindStyle(styleName);
			if (guistyle != null)
			{
				return guistyle;
			}
			Debug.LogWarning(string.Concat(new object[]
			{
				"Unable to find style '",
				styleName,
				"' in skin '",
				base.name,
				"' ",
				Event.current.type
			}));
			return GUISkin.error;
		}

		/// <summary>
		///   <para>Try to search for a GUIStyle. This functions returns NULL and does not give an error.</para>
		/// </summary>
		/// <param name="styleName"></param>
		// Token: 0x06001C3F RID: 7231 RVA: 0x00023254 File Offset: 0x00021454
		public GUIStyle FindStyle(string styleName)
		{
			if (this == null)
			{
				Debug.LogError("GUISkin is NULL");
				return null;
			}
			if (this.m_Styles == null)
			{
				this.BuildStyleCache();
			}
			GUIStyle guistyle;
			if (this.m_Styles.TryGetValue(styleName, out guistyle))
			{
				return guistyle;
			}
			return null;
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x0000AEAD File Offset: 0x000090AD
		internal void MakeCurrent()
		{
			GUISkin.current = this;
			GUIStyle.SetDefaultFont(this.font);
			if (GUISkin.m_SkinChanged != null)
			{
				GUISkin.m_SkinChanged();
			}
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0000AED4 File Offset: 0x000090D4
		public IEnumerator GetEnumerator()
		{
			if (this.m_Styles == null)
			{
				this.BuildStyleCache();
			}
			return this.m_Styles.Values.GetEnumerator();
		}

		// Token: 0x0400075D RID: 1885
		[SerializeField]
		private Font m_Font;

		// Token: 0x0400075E RID: 1886
		[SerializeField]
		private GUIStyle m_box;

		// Token: 0x0400075F RID: 1887
		[SerializeField]
		private GUIStyle m_button;

		// Token: 0x04000760 RID: 1888
		[SerializeField]
		private GUIStyle m_toggle;

		// Token: 0x04000761 RID: 1889
		[SerializeField]
		private GUIStyle m_label;

		// Token: 0x04000762 RID: 1890
		[SerializeField]
		private GUIStyle m_textField;

		// Token: 0x04000763 RID: 1891
		[SerializeField]
		private GUIStyle m_textArea;

		// Token: 0x04000764 RID: 1892
		[SerializeField]
		private GUIStyle m_window;

		// Token: 0x04000765 RID: 1893
		[SerializeField]
		private GUIStyle m_horizontalSlider;

		// Token: 0x04000766 RID: 1894
		[SerializeField]
		private GUIStyle m_horizontalSliderThumb;

		// Token: 0x04000767 RID: 1895
		[SerializeField]
		private GUIStyle m_verticalSlider;

		// Token: 0x04000768 RID: 1896
		[SerializeField]
		private GUIStyle m_verticalSliderThumb;

		// Token: 0x04000769 RID: 1897
		[SerializeField]
		private GUIStyle m_horizontalScrollbar;

		// Token: 0x0400076A RID: 1898
		[SerializeField]
		private GUIStyle m_horizontalScrollbarThumb;

		// Token: 0x0400076B RID: 1899
		[SerializeField]
		private GUIStyle m_horizontalScrollbarLeftButton;

		// Token: 0x0400076C RID: 1900
		[SerializeField]
		private GUIStyle m_horizontalScrollbarRightButton;

		// Token: 0x0400076D RID: 1901
		[SerializeField]
		private GUIStyle m_verticalScrollbar;

		// Token: 0x0400076E RID: 1902
		[SerializeField]
		private GUIStyle m_verticalScrollbarThumb;

		// Token: 0x0400076F RID: 1903
		[SerializeField]
		private GUIStyle m_verticalScrollbarUpButton;

		// Token: 0x04000770 RID: 1904
		[SerializeField]
		private GUIStyle m_verticalScrollbarDownButton;

		// Token: 0x04000771 RID: 1905
		[SerializeField]
		private GUIStyle m_ScrollView;

		// Token: 0x04000772 RID: 1906
		[SerializeField]
		internal GUIStyle[] m_CustomStyles;

		// Token: 0x04000773 RID: 1907
		[SerializeField]
		private GUISettings m_Settings = new GUISettings();

		// Token: 0x04000774 RID: 1908
		internal static GUIStyle ms_Error;

		// Token: 0x04000775 RID: 1909
		private Dictionary<string, GUIStyle> m_Styles;

		// Token: 0x04000776 RID: 1910
		internal static GUISkin.SkinChangedDelegate m_SkinChanged;

		// Token: 0x04000777 RID: 1911
		internal static GUISkin current;

		// Token: 0x020001E2 RID: 482
		// (Invoke) Token: 0x06001C43 RID: 7235
		internal delegate void SkinChangedDelegate();
	}
}
