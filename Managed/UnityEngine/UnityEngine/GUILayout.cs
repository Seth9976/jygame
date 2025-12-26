using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The GUILayout class is the interface for Unity gui with automatic layout.</para>
	/// </summary>
	// Token: 0x020001CF RID: 463
	public class GUILayout
	{
		/// <summary>
		///   <para>Make an auto-layout label.</para>
		/// </summary>
		/// <param name="text">Text to display on the label.</param>
		/// <param name="image">Texture to display on the label.</param>
		/// <param name="content">Text, image and tooltip for this label.</param>
		/// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B15 RID: 6933 RVA: 0x00009F2F File Offset: 0x0000812F
		public static void Label(Texture image, params GUILayoutOption[] options)
		{
			GUILayout.DoLabel(GUIContent.Temp(image), GUI.skin.label, options);
		}

		/// <summary>
		///   <para>Make an auto-layout label.</para>
		/// </summary>
		/// <param name="text">Text to display on the label.</param>
		/// <param name="image">Texture to display on the label.</param>
		/// <param name="content">Text, image and tooltip for this label.</param>
		/// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B16 RID: 6934 RVA: 0x00009F47 File Offset: 0x00008147
		public static void Label(string text, params GUILayoutOption[] options)
		{
			GUILayout.DoLabel(GUIContent.Temp(text), GUI.skin.label, options);
		}

		/// <summary>
		///   <para>Make an auto-layout label.</para>
		/// </summary>
		/// <param name="text">Text to display on the label.</param>
		/// <param name="image">Texture to display on the label.</param>
		/// <param name="content">Text, image and tooltip for this label.</param>
		/// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B17 RID: 6935 RVA: 0x00009F5F File Offset: 0x0000815F
		public static void Label(GUIContent content, params GUILayoutOption[] options)
		{
			GUILayout.DoLabel(content, GUI.skin.label, options);
		}

		/// <summary>
		///   <para>Make an auto-layout label.</para>
		/// </summary>
		/// <param name="text">Text to display on the label.</param>
		/// <param name="image">Texture to display on the label.</param>
		/// <param name="content">Text, image and tooltip for this label.</param>
		/// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B18 RID: 6936 RVA: 0x00009F72 File Offset: 0x00008172
		public static void Label(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.DoLabel(GUIContent.Temp(image), style, options);
		}

		/// <summary>
		///   <para>Make an auto-layout label.</para>
		/// </summary>
		/// <param name="text">Text to display on the label.</param>
		/// <param name="image">Texture to display on the label.</param>
		/// <param name="content">Text, image and tooltip for this label.</param>
		/// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B19 RID: 6937 RVA: 0x00009F81 File Offset: 0x00008181
		public static void Label(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.DoLabel(GUIContent.Temp(text), style, options);
		}

		/// <summary>
		///   <para>Make an auto-layout label.</para>
		/// </summary>
		/// <param name="text">Text to display on the label.</param>
		/// <param name="image">Texture to display on the label.</param>
		/// <param name="content">Text, image and tooltip for this label.</param>
		/// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B1A RID: 6938 RVA: 0x00009F90 File Offset: 0x00008190
		public static void Label(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.DoLabel(content, style, options);
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x00009F9A File Offset: 0x0000819A
		private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			GUI.Label(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		/// <summary>
		///   <para>Make an auto-layout box.</para>
		/// </summary>
		/// <param name="text">Text to display on the box.</param>
		/// <param name="image">Texture to display on the box.</param>
		/// <param name="content">Text, image and tooltip for this box.</param>
		/// <param name="style">The style to use. If left out, the box style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B1C RID: 6940 RVA: 0x00009FAB File Offset: 0x000081AB
		public static void Box(Texture image, params GUILayoutOption[] options)
		{
			GUILayout.DoBox(GUIContent.Temp(image), GUI.skin.box, options);
		}

		/// <summary>
		///   <para>Make an auto-layout box.</para>
		/// </summary>
		/// <param name="text">Text to display on the box.</param>
		/// <param name="image">Texture to display on the box.</param>
		/// <param name="content">Text, image and tooltip for this box.</param>
		/// <param name="style">The style to use. If left out, the box style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B1D RID: 6941 RVA: 0x00009FC3 File Offset: 0x000081C3
		public static void Box(string text, params GUILayoutOption[] options)
		{
			GUILayout.DoBox(GUIContent.Temp(text), GUI.skin.box, options);
		}

		/// <summary>
		///   <para>Make an auto-layout box.</para>
		/// </summary>
		/// <param name="text">Text to display on the box.</param>
		/// <param name="image">Texture to display on the box.</param>
		/// <param name="content">Text, image and tooltip for this box.</param>
		/// <param name="style">The style to use. If left out, the box style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B1E RID: 6942 RVA: 0x00009FDB File Offset: 0x000081DB
		public static void Box(GUIContent content, params GUILayoutOption[] options)
		{
			GUILayout.DoBox(content, GUI.skin.box, options);
		}

		/// <summary>
		///   <para>Make an auto-layout box.</para>
		/// </summary>
		/// <param name="text">Text to display on the box.</param>
		/// <param name="image">Texture to display on the box.</param>
		/// <param name="content">Text, image and tooltip for this box.</param>
		/// <param name="style">The style to use. If left out, the box style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B1F RID: 6943 RVA: 0x00009FEE File Offset: 0x000081EE
		public static void Box(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.DoBox(GUIContent.Temp(image), style, options);
		}

		/// <summary>
		///   <para>Make an auto-layout box.</para>
		/// </summary>
		/// <param name="text">Text to display on the box.</param>
		/// <param name="image">Texture to display on the box.</param>
		/// <param name="content">Text, image and tooltip for this box.</param>
		/// <param name="style">The style to use. If left out, the box style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B20 RID: 6944 RVA: 0x00009FFD File Offset: 0x000081FD
		public static void Box(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.DoBox(GUIContent.Temp(text), style, options);
		}

		/// <summary>
		///   <para>Make an auto-layout box.</para>
		/// </summary>
		/// <param name="text">Text to display on the box.</param>
		/// <param name="image">Texture to display on the box.</param>
		/// <param name="content">Text, image and tooltip for this box.</param>
		/// <param name="style">The style to use. If left out, the box style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B21 RID: 6945 RVA: 0x0000A00C File Offset: 0x0000820C
		public static void Box(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.DoBox(content, style, options);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0000A016 File Offset: 0x00008216
		private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			GUI.Box(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		/// <summary>
		///   <para>Make a single press button. The user clicks them and something happens immediately.</para>
		/// </summary>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>true when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001B23 RID: 6947 RVA: 0x0000A027 File Offset: 0x00008227
		public static bool Button(Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.DoButton(GUIContent.Temp(image), GUI.skin.button, options);
		}

		/// <summary>
		///   <para>Make a single press button. The user clicks them and something happens immediately.</para>
		/// </summary>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>true when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001B24 RID: 6948 RVA: 0x0000A03F File Offset: 0x0000823F
		public static bool Button(string text, params GUILayoutOption[] options)
		{
			return GUILayout.DoButton(GUIContent.Temp(text), GUI.skin.button, options);
		}

		/// <summary>
		///   <para>Make a single press button. The user clicks them and something happens immediately.</para>
		/// </summary>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>true when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001B25 RID: 6949 RVA: 0x0000A057 File Offset: 0x00008257
		public static bool Button(GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.DoButton(content, GUI.skin.button, options);
		}

		/// <summary>
		///   <para>Make a single press button. The user clicks them and something happens immediately.</para>
		/// </summary>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>true when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001B26 RID: 6950 RVA: 0x0000A06A File Offset: 0x0000826A
		public static bool Button(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoButton(GUIContent.Temp(image), style, options);
		}

		/// <summary>
		///   <para>Make a single press button. The user clicks them and something happens immediately.</para>
		/// </summary>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>true when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001B27 RID: 6951 RVA: 0x0000A079 File Offset: 0x00008279
		public static bool Button(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoButton(GUIContent.Temp(text), style, options);
		}

		/// <summary>
		///   <para>Make a single press button. The user clicks them and something happens immediately.</para>
		/// </summary>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>true when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001B28 RID: 6952 RVA: 0x0000A088 File Offset: 0x00008288
		public static bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoButton(content, style, options);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0000A092 File Offset: 0x00008292
		private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return GUI.Button(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		/// <summary>
		///   <para>Make a repeating button. The button returns true as long as the user holds down the mouse.</para>
		/// </summary>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>true when the holds down the mouse.</para>
		/// </returns>
		// Token: 0x06001B2A RID: 6954 RVA: 0x0000A0A3 File Offset: 0x000082A3
		public static bool RepeatButton(Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(image), GUI.skin.button, options);
		}

		/// <summary>
		///   <para>Make a repeating button. The button returns true as long as the user holds down the mouse.</para>
		/// </summary>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>true when the holds down the mouse.</para>
		/// </returns>
		// Token: 0x06001B2B RID: 6955 RVA: 0x0000A0BB File Offset: 0x000082BB
		public static bool RepeatButton(string text, params GUILayoutOption[] options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(text), GUI.skin.button, options);
		}

		/// <summary>
		///   <para>Make a repeating button. The button returns true as long as the user holds down the mouse.</para>
		/// </summary>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>true when the holds down the mouse.</para>
		/// </returns>
		// Token: 0x06001B2C RID: 6956 RVA: 0x0000A0D3 File Offset: 0x000082D3
		public static bool RepeatButton(GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.DoRepeatButton(content, GUI.skin.button, options);
		}

		/// <summary>
		///   <para>Make a repeating button. The button returns true as long as the user holds down the mouse.</para>
		/// </summary>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>true when the holds down the mouse.</para>
		/// </returns>
		// Token: 0x06001B2D RID: 6957 RVA: 0x0000A0E6 File Offset: 0x000082E6
		public static bool RepeatButton(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(image), style, options);
		}

		/// <summary>
		///   <para>Make a repeating button. The button returns true as long as the user holds down the mouse.</para>
		/// </summary>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>true when the holds down the mouse.</para>
		/// </returns>
		// Token: 0x06001B2E RID: 6958 RVA: 0x0000A0F5 File Offset: 0x000082F5
		public static bool RepeatButton(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(text), style, options);
		}

		/// <summary>
		///   <para>Make a repeating button. The button returns true as long as the user holds down the mouse.</para>
		/// </summary>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>true when the holds down the mouse.</para>
		/// </returns>
		// Token: 0x06001B2F RID: 6959 RVA: 0x0000A104 File Offset: 0x00008304
		public static bool RepeatButton(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoRepeatButton(content, style, options);
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0000A10E File Offset: 0x0000830E
		private static bool DoRepeatButton(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return GUI.RepeatButton(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		/// <summary>
		///   <para>Make a single-line text field where the user can edit a string.</para>
		/// </summary>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textArea style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001B31 RID: 6961 RVA: 0x0000A11F File Offset: 0x0000831F
		public static string TextField(string text, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, -1, false, GUI.skin.textField, options);
		}

		/// <summary>
		///   <para>Make a single-line text field where the user can edit a string.</para>
		/// </summary>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textArea style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001B32 RID: 6962 RVA: 0x0000A134 File Offset: 0x00008334
		public static string TextField(string text, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, maxLength, false, GUI.skin.textField, options);
		}

		/// <summary>
		///   <para>Make a single-line text field where the user can edit a string.</para>
		/// </summary>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textArea style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001B33 RID: 6963 RVA: 0x0000A149 File Offset: 0x00008349
		public static string TextField(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, -1, false, style, options);
		}

		/// <summary>
		///   <para>Make a single-line text field where the user can edit a string.</para>
		/// </summary>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textArea style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001B34 RID: 6964 RVA: 0x0000A155 File Offset: 0x00008355
		public static string TextField(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, maxLength, true, style, options);
		}

		/// <summary>
		///   <para>Make a text field where the user can enter a password.</para>
		/// </summary>
		/// <param name="password">Password to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maskChar">Character to mask the password with.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <param name="options"></param>
		/// <returns>
		///   <para>The edited password.</para>
		/// </returns>
		// Token: 0x06001B35 RID: 6965 RVA: 0x0000A161 File Offset: 0x00008361
		public static string PasswordField(string password, char maskChar, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, -1, GUI.skin.textField, options);
		}

		/// <summary>
		///   <para>Make a text field where the user can enter a password.</para>
		/// </summary>
		/// <param name="password">Password to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maskChar">Character to mask the password with.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <param name="options"></param>
		/// <returns>
		///   <para>The edited password.</para>
		/// </returns>
		// Token: 0x06001B36 RID: 6966 RVA: 0x0000A176 File Offset: 0x00008376
		public static string PasswordField(string password, char maskChar, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, maxLength, GUI.skin.textField, options);
		}

		/// <summary>
		///   <para>Make a text field where the user can enter a password.</para>
		/// </summary>
		/// <param name="password">Password to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maskChar">Character to mask the password with.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <param name="options"></param>
		/// <returns>
		///   <para>The edited password.</para>
		/// </returns>
		// Token: 0x06001B37 RID: 6967 RVA: 0x0000A18B File Offset: 0x0000838B
		public static string PasswordField(string password, char maskChar, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, -1, style, options);
		}

		/// <summary>
		///   <para>Make a text field where the user can enter a password.</para>
		/// </summary>
		/// <param name="password">Password to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maskChar">Character to mask the password with.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <param name="options"></param>
		/// <returns>
		///   <para>The edited password.</para>
		/// </returns>
		// Token: 0x06001B38 RID: 6968 RVA: 0x0001F778 File Offset: 0x0001D978
		public static string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			GUIContent guicontent = GUIContent.Temp(GUI.PasswordFieldGetStrToShow(password, maskChar));
			return GUI.PasswordField(GUILayoutUtility.GetRect(guicontent, GUI.skin.textField, options), password, maskChar, maxLength, style);
		}

		/// <summary>
		///   <para>Make a multi-line text field where the user can edit a string.</para>
		/// </summary>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&amp;amp;lt;br&amp;amp;gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001B39 RID: 6969 RVA: 0x0000A197 File Offset: 0x00008397
		public static string TextArea(string text, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, -1, true, GUI.skin.textArea, options);
		}

		/// <summary>
		///   <para>Make a multi-line text field where the user can edit a string.</para>
		/// </summary>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&amp;amp;lt;br&amp;amp;gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001B3A RID: 6970 RVA: 0x0000A1AC File Offset: 0x000083AC
		public static string TextArea(string text, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, maxLength, true, GUI.skin.textArea, options);
		}

		/// <summary>
		///   <para>Make a multi-line text field where the user can edit a string.</para>
		/// </summary>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&amp;amp;lt;br&amp;amp;gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001B3B RID: 6971 RVA: 0x0000A1C1 File Offset: 0x000083C1
		public static string TextArea(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, -1, true, style, options);
		}

		/// <summary>
		///   <para>Make a multi-line text field where the user can edit a string.</para>
		/// </summary>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&amp;amp;lt;br&amp;amp;gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001B3C RID: 6972 RVA: 0x0000A155 File Offset: 0x00008355
		public static string TextArea(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoTextField(text, maxLength, true, style, options);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0001F7B0 File Offset: 0x0001D9B0
		private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options)
		{
			int controlID = GUIUtility.GetControlID(FocusType.Keyboard);
			GUIContent guicontent = GUIContent.Temp(text);
			if (GUIUtility.keyboardControl != controlID)
			{
				guicontent = GUIContent.Temp(text);
			}
			else
			{
				guicontent = GUIContent.Temp(text + Input.compositionString);
			}
			Rect rect = GUILayoutUtility.GetRect(guicontent, style, options);
			if (GUIUtility.keyboardControl == controlID)
			{
				guicontent = GUIContent.Temp(text);
			}
			GUI.DoTextField(rect, controlID, guicontent, multiline, maxLength, style);
			return guicontent.text;
		}

		/// <summary>
		///   <para>Make an on/off toggle button.</para>
		/// </summary>
		/// <param name="value">Is the button on or off?</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The new value of the button.</para>
		/// </returns>
		// Token: 0x06001B3E RID: 6974 RVA: 0x0000A1CD File Offset: 0x000083CD
		public static bool Toggle(bool value, Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(image), GUI.skin.toggle, options);
		}

		/// <summary>
		///   <para>Make an on/off toggle button.</para>
		/// </summary>
		/// <param name="value">Is the button on or off?</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The new value of the button.</para>
		/// </returns>
		// Token: 0x06001B3F RID: 6975 RVA: 0x0000A1E6 File Offset: 0x000083E6
		public static bool Toggle(bool value, string text, params GUILayoutOption[] options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(text), GUI.skin.toggle, options);
		}

		/// <summary>
		///   <para>Make an on/off toggle button.</para>
		/// </summary>
		/// <param name="value">Is the button on or off?</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The new value of the button.</para>
		/// </returns>
		// Token: 0x06001B40 RID: 6976 RVA: 0x0000A1FF File Offset: 0x000083FF
		public static bool Toggle(bool value, GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.DoToggle(value, content, GUI.skin.toggle, options);
		}

		/// <summary>
		///   <para>Make an on/off toggle button.</para>
		/// </summary>
		/// <param name="value">Is the button on or off?</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The new value of the button.</para>
		/// </returns>
		// Token: 0x06001B41 RID: 6977 RVA: 0x0000A213 File Offset: 0x00008413
		public static bool Toggle(bool value, Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(image), style, options);
		}

		/// <summary>
		///   <para>Make an on/off toggle button.</para>
		/// </summary>
		/// <param name="value">Is the button on or off?</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The new value of the button.</para>
		/// </returns>
		// Token: 0x06001B42 RID: 6978 RVA: 0x0000A223 File Offset: 0x00008423
		public static bool Toggle(bool value, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(text), style, options);
		}

		/// <summary>
		///   <para>Make an on/off toggle button.</para>
		/// </summary>
		/// <param name="value">Is the button on or off?</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The new value of the button.</para>
		/// </returns>
		// Token: 0x06001B43 RID: 6979 RVA: 0x0000A233 File Offset: 0x00008433
		public static bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoToggle(value, content, style, options);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0000A23E File Offset: 0x0000843E
		private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return GUI.Toggle(GUILayoutUtility.GetRect(content, style, options), value, content, style);
		}

		/// <summary>
		///   <para>Make a toolbar.</para>
		/// </summary>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the buttons.</param>
		/// <param name="images">An array of textures on the buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001B45 RID: 6981 RVA: 0x0000A250 File Offset: 0x00008450
		public static int Toolbar(int selected, string[] texts, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(texts), GUI.skin.button, options);
		}

		/// <summary>
		///   <para>Make a toolbar.</para>
		/// </summary>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the buttons.</param>
		/// <param name="images">An array of textures on the buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001B46 RID: 6982 RVA: 0x0000A269 File Offset: 0x00008469
		public static int Toolbar(int selected, Texture[] images, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(images), GUI.skin.button, options);
		}

		/// <summary>
		///   <para>Make a toolbar.</para>
		/// </summary>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the buttons.</param>
		/// <param name="images">An array of textures on the buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001B47 RID: 6983 RVA: 0x0000A282 File Offset: 0x00008482
		public static int Toolbar(int selected, GUIContent[] content, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, content, GUI.skin.button, options);
		}

		/// <summary>
		///   <para>Make a toolbar.</para>
		/// </summary>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the buttons.</param>
		/// <param name="images">An array of textures on the buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001B48 RID: 6984 RVA: 0x0000A296 File Offset: 0x00008496
		public static int Toolbar(int selected, string[] texts, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(texts), style, options);
		}

		/// <summary>
		///   <para>Make a toolbar.</para>
		/// </summary>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the buttons.</param>
		/// <param name="images">An array of textures on the buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001B49 RID: 6985 RVA: 0x0000A2A6 File Offset: 0x000084A6
		public static int Toolbar(int selected, Texture[] images, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(images), style, options);
		}

		/// <summary>
		///   <para>Make a toolbar.</para>
		/// </summary>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the buttons.</param>
		/// <param name="images">An array of textures on the buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001B4A RID: 6986 RVA: 0x0001F820 File Offset: 0x0001DA20
		public static int Toolbar(int selected, GUIContent[] contents, GUIStyle style, params GUILayoutOption[] options)
		{
			GUIStyle guistyle;
			GUIStyle guistyle2;
			GUIStyle guistyle3;
			GUI.FindStyles(ref style, out guistyle, out guistyle2, out guistyle3, "left", "mid", "right");
			Vector2 vector = default(Vector2);
			int num = contents.Length;
			GUIStyle guistyle4 = ((num <= 1) ? style : guistyle);
			GUIStyle guistyle5 = ((num <= 1) ? style : guistyle2);
			GUIStyle guistyle6 = ((num <= 1) ? style : guistyle3);
			int num2 = guistyle4.margin.left;
			for (int i = 0; i < contents.Length; i++)
			{
				if (i == num - 2)
				{
					guistyle4 = guistyle5;
					guistyle5 = guistyle6;
				}
				if (i == num - 1)
				{
					guistyle4 = guistyle6;
				}
				Vector2 vector2 = guistyle4.CalcSize(contents[i]);
				if (vector2.x > vector.x)
				{
					vector.x = vector2.x;
				}
				if (vector2.y > vector.y)
				{
					vector.y = vector2.y;
				}
				if (i == num - 1)
				{
					num2 += guistyle4.margin.right;
				}
				else
				{
					num2 += Mathf.Max(guistyle4.margin.right, guistyle5.margin.left);
				}
			}
			vector.x = vector.x * (float)contents.Length + (float)num2;
			return GUI.Toolbar(GUILayoutUtility.GetRect(vector.x, vector.y, style, options), selected, contents, style);
		}

		/// <summary>
		///   <para>Make a Selection Grid.</para>
		/// </summary>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the buttons.</param>
		/// <param name="images">An array of textures on the buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the button.</param>
		/// <param name="xCount">How many elements to fit in the horizontal direction. The elements will be scaled to fit unless the style defines a fixedWidth to use. The height of the control will be determined from the number of elements.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001B4B RID: 6987 RVA: 0x0000A2B6 File Offset: 0x000084B6
		public static int SelectionGrid(int selected, string[] texts, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(texts), xCount, GUI.skin.button, options);
		}

		/// <summary>
		///   <para>Make a Selection Grid.</para>
		/// </summary>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the buttons.</param>
		/// <param name="images">An array of textures on the buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the button.</param>
		/// <param name="xCount">How many elements to fit in the horizontal direction. The elements will be scaled to fit unless the style defines a fixedWidth to use. The height of the control will be determined from the number of elements.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001B4C RID: 6988 RVA: 0x0000A2D0 File Offset: 0x000084D0
		public static int SelectionGrid(int selected, Texture[] images, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(images), xCount, GUI.skin.button, options);
		}

		/// <summary>
		///   <para>Make a Selection Grid.</para>
		/// </summary>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the buttons.</param>
		/// <param name="images">An array of textures on the buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the button.</param>
		/// <param name="xCount">How many elements to fit in the horizontal direction. The elements will be scaled to fit unless the style defines a fixedWidth to use. The height of the control will be determined from the number of elements.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001B4D RID: 6989 RVA: 0x0000A2EA File Offset: 0x000084EA
		public static int SelectionGrid(int selected, GUIContent[] content, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, content, xCount, GUI.skin.button, options);
		}

		/// <summary>
		///   <para>Make a Selection Grid.</para>
		/// </summary>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the buttons.</param>
		/// <param name="images">An array of textures on the buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the button.</param>
		/// <param name="xCount">How many elements to fit in the horizontal direction. The elements will be scaled to fit unless the style defines a fixedWidth to use. The height of the control will be determined from the number of elements.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001B4E RID: 6990 RVA: 0x0000A2FF File Offset: 0x000084FF
		public static int SelectionGrid(int selected, string[] texts, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(texts), xCount, style, options);
		}

		/// <summary>
		///   <para>Make a Selection Grid.</para>
		/// </summary>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the buttons.</param>
		/// <param name="images">An array of textures on the buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the button.</param>
		/// <param name="xCount">How many elements to fit in the horizontal direction. The elements will be scaled to fit unless the style defines a fixedWidth to use. The height of the control will be determined from the number of elements.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001B4F RID: 6991 RVA: 0x0000A311 File Offset: 0x00008511
		public static int SelectionGrid(int selected, Texture[] images, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(images), xCount, style, options);
		}

		/// <summary>
		///   <para>Make a Selection Grid.</para>
		/// </summary>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the buttons.</param>
		/// <param name="images">An array of textures on the buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the button.</param>
		/// <param name="xCount">How many elements to fit in the horizontal direction. The elements will be scaled to fit unless the style defines a fixedWidth to use. The height of the control will be determined from the number of elements.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001B50 RID: 6992 RVA: 0x0000A323 File Offset: 0x00008523
		public static int SelectionGrid(int selected, GUIContent[] contents, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUI.SelectionGrid(GUIGridSizer.GetRect(contents, xCount, style, options), selected, contents, xCount, style);
		}

		/// <summary>
		///   <para>A horizontal slider the user can drag to change a value between a min and a max.</para>
		/// </summary>
		/// <param name="value">The value the slider shows. This determines the position of the draggable thumb.</param>
		/// <param name="leftValue">The value at the left end of the slider.</param>
		/// <param name="rightValue">The value at the right end of the slider.</param>
		/// <param name="slider">The GUIStyle to use for displaying the dragging area. If left out, the horizontalSlider style from the current GUISkin is used.</param>
		/// <param name="thumb">The GUIStyle to use for displaying draggable thumb. If left out, the horizontalSliderThumb style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.</param>
		/// <returns>
		///   <para>The value that has been set by the user.</para>
		/// </returns>
		// Token: 0x06001B51 RID: 6993 RVA: 0x0000A338 File Offset: 0x00008538
		public static float HorizontalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.DoHorizontalSlider(value, leftValue, rightValue, GUI.skin.horizontalSlider, GUI.skin.horizontalSliderThumb, options);
		}

		/// <summary>
		///   <para>A horizontal slider the user can drag to change a value between a min and a max.</para>
		/// </summary>
		/// <param name="value">The value the slider shows. This determines the position of the draggable thumb.</param>
		/// <param name="leftValue">The value at the left end of the slider.</param>
		/// <param name="rightValue">The value at the right end of the slider.</param>
		/// <param name="slider">The GUIStyle to use for displaying the dragging area. If left out, the horizontalSlider style from the current GUISkin is used.</param>
		/// <param name="thumb">The GUIStyle to use for displaying draggable thumb. If left out, the horizontalSliderThumb style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.</param>
		/// <returns>
		///   <para>The value that has been set by the user.</para>
		/// </returns>
		// Token: 0x06001B52 RID: 6994 RVA: 0x0000A357 File Offset: 0x00008557
		public static float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.DoHorizontalSlider(value, leftValue, rightValue, slider, thumb, options);
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0000A366 File Offset: 0x00008566
		private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options)
		{
			return GUI.HorizontalSlider(GUILayoutUtility.GetRect(GUIContent.Temp("mmmm"), slider, options), value, leftValue, rightValue, slider, thumb);
		}

		/// <summary>
		///   <para>A vertical slider the user can drag to change a value between a min and a max.</para>
		/// </summary>
		/// <param name="value">The value the slider shows. This determines the position of the draggable thumb.</param>
		/// <param name="topValue">The value at the top end of the slider.</param>
		/// <param name="bottomValue">The value at the bottom end of the slider.</param>
		/// <param name="slider">The GUIStyle to use for displaying the dragging area. If left out, the horizontalSlider style from the current GUISkin is used.</param>
		/// <param name="thumb">The GUIStyle to use for displaying draggable thumb. If left out, the horizontalSliderThumb style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.</param>
		/// <param name="leftValue"></param>
		/// <param name="rightValue"></param>
		/// <returns>
		///   <para>The value that has been set by the user.</para>
		/// </returns>
		// Token: 0x06001B54 RID: 6996 RVA: 0x0000A385 File Offset: 0x00008585
		public static float VerticalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.DoVerticalSlider(value, leftValue, rightValue, GUI.skin.verticalSlider, GUI.skin.verticalSliderThumb, options);
		}

		/// <summary>
		///   <para>A vertical slider the user can drag to change a value between a min and a max.</para>
		/// </summary>
		/// <param name="value">The value the slider shows. This determines the position of the draggable thumb.</param>
		/// <param name="topValue">The value at the top end of the slider.</param>
		/// <param name="bottomValue">The value at the bottom end of the slider.</param>
		/// <param name="slider">The GUIStyle to use for displaying the dragging area. If left out, the horizontalSlider style from the current GUISkin is used.</param>
		/// <param name="thumb">The GUIStyle to use for displaying draggable thumb. If left out, the horizontalSliderThumb style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.</param>
		/// <param name="leftValue"></param>
		/// <param name="rightValue"></param>
		/// <returns>
		///   <para>The value that has been set by the user.</para>
		/// </returns>
		// Token: 0x06001B55 RID: 6997 RVA: 0x0000A3A4 File Offset: 0x000085A4
		public static float VerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.DoVerticalSlider(value, leftValue, rightValue, slider, thumb, options);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0000A3B3 File Offset: 0x000085B3
		private static float DoVerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUI.VerticalSlider(GUILayoutUtility.GetRect(GUIContent.Temp("\n\n\n\n\n"), slider, options), value, leftValue, rightValue, slider, thumb);
		}

		/// <summary>
		///   <para>Make a horizontal scrollbar.</para>
		/// </summary>
		/// <param name="value">The position between min and max.</param>
		/// <param name="size">How much can we see?</param>
		/// <param name="leftValue">The value at the left end of the scrollbar.</param>
		/// <param name="rightValue">The value at the right end of the scrollbar.</param>
		/// <param name="style">The style to use for the scrollbar background. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.</param>
		/// <returns>
		///   <para>The modified value. This can be changed by the user by dragging the scrollbar, or clicking the arrows at the end.</para>
		/// </returns>
		// Token: 0x06001B57 RID: 6999 RVA: 0x0000A3D2 File Offset: 0x000085D2
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, GUI.skin.horizontalScrollbar, options);
		}

		/// <summary>
		///   <para>Make a horizontal scrollbar.</para>
		/// </summary>
		/// <param name="value">The position between min and max.</param>
		/// <param name="size">How much can we see?</param>
		/// <param name="leftValue">The value at the left end of the scrollbar.</param>
		/// <param name="rightValue">The value at the right end of the scrollbar.</param>
		/// <param name="style">The style to use for the scrollbar background. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.</param>
		/// <returns>
		///   <para>The modified value. This can be changed by the user by dragging the scrollbar, or clicking the arrows at the end.</para>
		/// </returns>
		// Token: 0x06001B58 RID: 7000 RVA: 0x0000A3E9 File Offset: 0x000085E9
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUI.HorizontalScrollbar(GUILayoutUtility.GetRect(GUIContent.Temp("mmmm"), style, options), value, size, leftValue, rightValue, style);
		}

		/// <summary>
		///   <para>Make a vertical scrollbar.</para>
		/// </summary>
		/// <param name="value">The position between min and max.</param>
		/// <param name="size">How much can we see?</param>
		/// <param name="topValue">The value at the top end of the scrollbar.</param>
		/// <param name="bottomValue">The value at the bottom end of the scrollbar.</param>
		/// <param name="style">The style to use for the scrollbar background. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.</param>
		/// <returns>
		///   <para>The modified value. This can be changed by the user by dragging the scrollbar, or clicking the arrows at the end.</para>
		/// </returns>
		// Token: 0x06001B59 RID: 7001 RVA: 0x0000A409 File Offset: 0x00008609
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, GUI.skin.verticalScrollbar, options);
		}

		/// <summary>
		///   <para>Make a vertical scrollbar.</para>
		/// </summary>
		/// <param name="value">The position between min and max.</param>
		/// <param name="size">How much can we see?</param>
		/// <param name="topValue">The value at the top end of the scrollbar.</param>
		/// <param name="bottomValue">The value at the bottom end of the scrollbar.</param>
		/// <param name="style">The style to use for the scrollbar background. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.</param>
		/// <returns>
		///   <para>The modified value. This can be changed by the user by dragging the scrollbar, or clicking the arrows at the end.</para>
		/// </returns>
		// Token: 0x06001B5A RID: 7002 RVA: 0x0000A420 File Offset: 0x00008620
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUI.VerticalScrollbar(GUILayoutUtility.GetRect(GUIContent.Temp("\n\n\n\n"), style, options), value, size, topValue, bottomValue, style);
		}

		/// <summary>
		///   <para>Insert a space in the current layout group.</para>
		/// </summary>
		/// <param name="pixels"></param>
		// Token: 0x06001B5B RID: 7003 RVA: 0x0001F998 File Offset: 0x0001DB98
		public static void Space(float pixels)
		{
			GUIUtility.CheckOnGUI();
			if (GUILayoutUtility.current.topLevel.isVertical)
			{
				GUILayoutUtility.GetRect(0f, pixels, GUILayoutUtility.spaceStyle, new GUILayoutOption[] { GUILayout.Height(pixels) });
			}
			else
			{
				GUILayoutUtility.GetRect(pixels, 0f, GUILayoutUtility.spaceStyle, new GUILayoutOption[] { GUILayout.Width(pixels) });
			}
		}

		/// <summary>
		///   <para>Insert a flexible space element.</para>
		/// </summary>
		// Token: 0x06001B5C RID: 7004 RVA: 0x0001FA04 File Offset: 0x0001DC04
		public static void FlexibleSpace()
		{
			GUIUtility.CheckOnGUI();
			GUILayoutOption guilayoutOption;
			if (GUILayoutUtility.current.topLevel.isVertical)
			{
				guilayoutOption = GUILayout.ExpandHeight(true);
			}
			else
			{
				guilayoutOption = GUILayout.ExpandWidth(true);
			}
			guilayoutOption.value = 10000;
			GUILayoutUtility.GetRect(0f, 0f, GUILayoutUtility.spaceStyle, new GUILayoutOption[] { guilayoutOption });
		}

		/// <summary>
		///   <para>Begin a Horizontal control group.</para>
		/// </summary>
		/// <param name="text">Text to display on group.</param>
		/// <param name="image">Texture to display on group.</param>
		/// <param name="content">Text, image, and tooltip for this group.</param>
		/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B5D RID: 7005 RVA: 0x0000A440 File Offset: 0x00008640
		public static void BeginHorizontal(params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(GUIContent.none, GUIStyle.none, options);
		}

		/// <summary>
		///   <para>Begin a Horizontal control group.</para>
		/// </summary>
		/// <param name="text">Text to display on group.</param>
		/// <param name="image">Texture to display on group.</param>
		/// <param name="content">Text, image, and tooltip for this group.</param>
		/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B5E RID: 7006 RVA: 0x0000A452 File Offset: 0x00008652
		public static void BeginHorizontal(GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(GUIContent.none, style, options);
		}

		/// <summary>
		///   <para>Begin a Horizontal control group.</para>
		/// </summary>
		/// <param name="text">Text to display on group.</param>
		/// <param name="image">Texture to display on group.</param>
		/// <param name="content">Text, image, and tooltip for this group.</param>
		/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B5F RID: 7007 RVA: 0x0000A460 File Offset: 0x00008660
		public static void BeginHorizontal(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(GUIContent.Temp(text), style, options);
		}

		/// <summary>
		///   <para>Begin a Horizontal control group.</para>
		/// </summary>
		/// <param name="text">Text to display on group.</param>
		/// <param name="image">Texture to display on group.</param>
		/// <param name="content">Text, image, and tooltip for this group.</param>
		/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B60 RID: 7008 RVA: 0x0000A46F File Offset: 0x0000866F
		public static void BeginHorizontal(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(GUIContent.Temp(image), style, options);
		}

		/// <summary>
		///   <para>Begin a Horizontal control group.</para>
		/// </summary>
		/// <param name="text">Text to display on group.</param>
		/// <param name="image">Texture to display on group.</param>
		/// <param name="content">Text, image, and tooltip for this group.</param>
		/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B61 RID: 7009 RVA: 0x0001FA6C File Offset: 0x0001DC6C
		public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayoutGroup guilayoutGroup = GUILayoutUtility.BeginLayoutGroup(style, options, typeof(GUILayoutGroup));
			guilayoutGroup.isVertical = false;
			if (style != GUIStyle.none || content != GUIContent.none)
			{
				GUI.Box(guilayoutGroup.rect, content, style);
			}
		}

		/// <summary>
		///   <para>Close a group started with BeginHorizontal.</para>
		/// </summary>
		// Token: 0x06001B62 RID: 7010 RVA: 0x0000A47E File Offset: 0x0000867E
		public static void EndHorizontal()
		{
			GUILayoutUtility.EndGroup("GUILayout.EndHorizontal");
			GUILayoutUtility.EndLayoutGroup();
		}

		/// <summary>
		///   <para>Begin a vertical control group.</para>
		/// </summary>
		/// <param name="text">Text to display on group.</param>
		/// <param name="image">Texture to display on group.</param>
		/// <param name="content">Text, image, and tooltip for this group.</param>
		/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B63 RID: 7011 RVA: 0x0000A48F File Offset: 0x0000868F
		public static void BeginVertical(params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(GUIContent.none, GUIStyle.none, options);
		}

		/// <summary>
		///   <para>Begin a vertical control group.</para>
		/// </summary>
		/// <param name="text">Text to display on group.</param>
		/// <param name="image">Texture to display on group.</param>
		/// <param name="content">Text, image, and tooltip for this group.</param>
		/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B64 RID: 7012 RVA: 0x0000A4A1 File Offset: 0x000086A1
		public static void BeginVertical(GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(GUIContent.none, style, options);
		}

		/// <summary>
		///   <para>Begin a vertical control group.</para>
		/// </summary>
		/// <param name="text">Text to display on group.</param>
		/// <param name="image">Texture to display on group.</param>
		/// <param name="content">Text, image, and tooltip for this group.</param>
		/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B65 RID: 7013 RVA: 0x0000A4AF File Offset: 0x000086AF
		public static void BeginVertical(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(GUIContent.Temp(text), style, options);
		}

		/// <summary>
		///   <para>Begin a vertical control group.</para>
		/// </summary>
		/// <param name="text">Text to display on group.</param>
		/// <param name="image">Texture to display on group.</param>
		/// <param name="content">Text, image, and tooltip for this group.</param>
		/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B66 RID: 7014 RVA: 0x0000A4BE File Offset: 0x000086BE
		public static void BeginVertical(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(GUIContent.Temp(image), style, options);
		}

		/// <summary>
		///   <para>Begin a vertical control group.</para>
		/// </summary>
		/// <param name="text">Text to display on group.</param>
		/// <param name="image">Texture to display on group.</param>
		/// <param name="content">Text, image, and tooltip for this group.</param>
		/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		// Token: 0x06001B67 RID: 7015 RVA: 0x0001FAB8 File Offset: 0x0001DCB8
		public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayoutGroup guilayoutGroup = GUILayoutUtility.BeginLayoutGroup(style, options, typeof(GUILayoutGroup));
			guilayoutGroup.isVertical = true;
			if (style != GUIStyle.none)
			{
				GUI.Box(guilayoutGroup.rect, content, style);
			}
		}

		/// <summary>
		///   <para>Close a group started with BeginVertical.</para>
		/// </summary>
		// Token: 0x06001B68 RID: 7016 RVA: 0x0000A4CD File Offset: 0x000086CD
		public static void EndVertical()
		{
			GUILayoutUtility.EndGroup("GUILayout.EndVertical");
			GUILayoutUtility.EndLayoutGroup();
		}

		/// <summary>
		///   <para>Begin a GUILayout block of GUI controls in a fixed screen area.</para>
		/// </summary>
		/// <param name="text">Optional text to display in the area.</param>
		/// <param name="image">Optional texture to display in the area.</param>
		/// <param name="content">Optional text, image and tooltip top display for this area.</param>
		/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
		/// <param name="screenRect"></param>
		// Token: 0x06001B69 RID: 7017 RVA: 0x0000A4DE File Offset: 0x000086DE
		public static void BeginArea(Rect screenRect)
		{
			GUILayout.BeginArea(screenRect, GUIContent.none, GUIStyle.none);
		}

		/// <summary>
		///   <para>Begin a GUILayout block of GUI controls in a fixed screen area.</para>
		/// </summary>
		/// <param name="text">Optional text to display in the area.</param>
		/// <param name="image">Optional texture to display in the area.</param>
		/// <param name="content">Optional text, image and tooltip top display for this area.</param>
		/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
		/// <param name="screenRect"></param>
		// Token: 0x06001B6A RID: 7018 RVA: 0x0000A4F0 File Offset: 0x000086F0
		public static void BeginArea(Rect screenRect, string text)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(text), GUIStyle.none);
		}

		/// <summary>
		///   <para>Begin a GUILayout block of GUI controls in a fixed screen area.</para>
		/// </summary>
		/// <param name="text">Optional text to display in the area.</param>
		/// <param name="image">Optional texture to display in the area.</param>
		/// <param name="content">Optional text, image and tooltip top display for this area.</param>
		/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
		/// <param name="screenRect"></param>
		// Token: 0x06001B6B RID: 7019 RVA: 0x0000A503 File Offset: 0x00008703
		public static void BeginArea(Rect screenRect, Texture image)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(image), GUIStyle.none);
		}

		/// <summary>
		///   <para>Begin a GUILayout block of GUI controls in a fixed screen area.</para>
		/// </summary>
		/// <param name="text">Optional text to display in the area.</param>
		/// <param name="image">Optional texture to display in the area.</param>
		/// <param name="content">Optional text, image and tooltip top display for this area.</param>
		/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
		/// <param name="screenRect"></param>
		// Token: 0x06001B6C RID: 7020 RVA: 0x0000A4DE File Offset: 0x000086DE
		public static void BeginArea(Rect screenRect, GUIContent content)
		{
			GUILayout.BeginArea(screenRect, GUIContent.none, GUIStyle.none);
		}

		/// <summary>
		///   <para>Begin a GUILayout block of GUI controls in a fixed screen area.</para>
		/// </summary>
		/// <param name="text">Optional text to display in the area.</param>
		/// <param name="image">Optional texture to display in the area.</param>
		/// <param name="content">Optional text, image and tooltip top display for this area.</param>
		/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
		/// <param name="screenRect"></param>
		// Token: 0x06001B6D RID: 7021 RVA: 0x0000A516 File Offset: 0x00008716
		public static void BeginArea(Rect screenRect, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.none, style);
		}

		/// <summary>
		///   <para>Begin a GUILayout block of GUI controls in a fixed screen area.</para>
		/// </summary>
		/// <param name="text">Optional text to display in the area.</param>
		/// <param name="image">Optional texture to display in the area.</param>
		/// <param name="content">Optional text, image and tooltip top display for this area.</param>
		/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
		/// <param name="screenRect"></param>
		// Token: 0x06001B6E RID: 7022 RVA: 0x0000A524 File Offset: 0x00008724
		public static void BeginArea(Rect screenRect, string text, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(text), style);
		}

		/// <summary>
		///   <para>Begin a GUILayout block of GUI controls in a fixed screen area.</para>
		/// </summary>
		/// <param name="text">Optional text to display in the area.</param>
		/// <param name="image">Optional texture to display in the area.</param>
		/// <param name="content">Optional text, image and tooltip top display for this area.</param>
		/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
		/// <param name="screenRect"></param>
		// Token: 0x06001B6F RID: 7023 RVA: 0x0000A533 File Offset: 0x00008733
		public static void BeginArea(Rect screenRect, Texture image, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(image), style);
		}

		/// <summary>
		///   <para>Begin a GUILayout block of GUI controls in a fixed screen area.</para>
		/// </summary>
		/// <param name="text">Optional text to display in the area.</param>
		/// <param name="image">Optional texture to display in the area.</param>
		/// <param name="content">Optional text, image and tooltip top display for this area.</param>
		/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
		/// <param name="screenRect"></param>
		// Token: 0x06001B70 RID: 7024 RVA: 0x0001FAF8 File Offset: 0x0001DCF8
		public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			GUILayoutGroup guilayoutGroup = GUILayoutUtility.BeginLayoutArea(style, typeof(GUILayoutGroup));
			if (Event.current.type == EventType.Layout)
			{
				guilayoutGroup.resetCoords = true;
				guilayoutGroup.minWidth = (guilayoutGroup.maxWidth = screenRect.width);
				guilayoutGroup.minHeight = (guilayoutGroup.maxHeight = screenRect.height);
				guilayoutGroup.rect = Rect.MinMaxRect(screenRect.xMin, screenRect.yMin, guilayoutGroup.rect.xMax, guilayoutGroup.rect.yMax);
			}
			GUI.BeginGroup(guilayoutGroup.rect, content, style);
		}

		/// <summary>
		///   <para>Close a GUILayout block started with BeginArea.</para>
		/// </summary>
		// Token: 0x06001B71 RID: 7025 RVA: 0x0001FB9C File Offset: 0x0001DD9C
		public static void EndArea()
		{
			GUIUtility.CheckOnGUI();
			if (Event.current.type == EventType.Used)
			{
				return;
			}
			GUILayoutUtility.current.layoutGroups.Pop();
			GUILayoutUtility.current.topLevel = (GUILayoutGroup)GUILayoutUtility.current.layoutGroups.Peek();
			GUI.EndGroup();
		}

		/// <summary>
		///   <para>Begin an automatically laid out scrollview.</para>
		/// </summary>
		/// <param name="scrollPosition">The position to use display.</param>
		/// <param name="alwayShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when the content inside the ScrollView is wider than the scrollview itself.</param>
		/// <param name="alwayShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when content inside the ScrollView is taller than the scrollview itself.</param>
		/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
		/// <param name="options"></param>
		/// <param name="alwaysShowHorizontal"></param>
		/// <param name="alwaysShowVertical"></param>
		/// <param name="style"></param>
		/// <param name="background"></param>
		/// <returns>
		///   <para>The modified scrollPosition. Feed this back into the variable you pass in, as shown in the example.</para>
		/// </returns>
		// Token: 0x06001B72 RID: 7026 RVA: 0x0000A542 File Offset: 0x00008742
		public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, false, false, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView, options);
		}

		/// <summary>
		///   <para>Begin an automatically laid out scrollview.</para>
		/// </summary>
		/// <param name="scrollPosition">The position to use display.</param>
		/// <param name="alwayShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when the content inside the ScrollView is wider than the scrollview itself.</param>
		/// <param name="alwayShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when content inside the ScrollView is taller than the scrollview itself.</param>
		/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
		/// <param name="options"></param>
		/// <param name="alwaysShowHorizontal"></param>
		/// <param name="alwaysShowVertical"></param>
		/// <param name="style"></param>
		/// <param name="background"></param>
		/// <returns>
		///   <para>The modified scrollPosition. Feed this back into the variable you pass in, as shown in the example.</para>
		/// </returns>
		// Token: 0x06001B73 RID: 7027 RVA: 0x0000A56B File Offset: 0x0000876B
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView, options);
		}

		/// <summary>
		///   <para>Begin an automatically laid out scrollview.</para>
		/// </summary>
		/// <param name="scrollPosition">The position to use display.</param>
		/// <param name="alwayShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when the content inside the ScrollView is wider than the scrollview itself.</param>
		/// <param name="alwayShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when content inside the ScrollView is taller than the scrollview itself.</param>
		/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
		/// <param name="options"></param>
		/// <param name="alwaysShowHorizontal"></param>
		/// <param name="alwaysShowVertical"></param>
		/// <param name="style"></param>
		/// <param name="background"></param>
		/// <returns>
		///   <para>The modified scrollPosition. Feed this back into the variable you pass in, as shown in the example.</para>
		/// </returns>
		// Token: 0x06001B74 RID: 7028 RVA: 0x0000A594 File Offset: 0x00008794
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, false, false, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView, options);
		}

		/// <summary>
		///   <para>Begin an automatically laid out scrollview.</para>
		/// </summary>
		/// <param name="scrollPosition">The position to use display.</param>
		/// <param name="alwayShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when the content inside the ScrollView is wider than the scrollview itself.</param>
		/// <param name="alwayShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when content inside the ScrollView is taller than the scrollview itself.</param>
		/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
		/// <param name="options"></param>
		/// <param name="alwaysShowHorizontal"></param>
		/// <param name="alwaysShowVertical"></param>
		/// <param name="style"></param>
		/// <param name="background"></param>
		/// <returns>
		///   <para>The modified scrollPosition. Feed this back into the variable you pass in, as shown in the example.</para>
		/// </returns>
		// Token: 0x06001B75 RID: 7029 RVA: 0x0001FBF4 File Offset: 0x0001DDF4
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style)
		{
			GUILayoutOption[] array = null;
			return GUILayout.BeginScrollView(scrollPosition, style, array);
		}

		/// <summary>
		///   <para>Begin an automatically laid out scrollview.</para>
		/// </summary>
		/// <param name="scrollPosition">The position to use display.</param>
		/// <param name="alwayShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when the content inside the ScrollView is wider than the scrollview itself.</param>
		/// <param name="alwayShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when content inside the ScrollView is taller than the scrollview itself.</param>
		/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
		/// <param name="options"></param>
		/// <param name="alwaysShowHorizontal"></param>
		/// <param name="alwaysShowVertical"></param>
		/// <param name="style"></param>
		/// <param name="background"></param>
		/// <returns>
		///   <para>The modified scrollPosition. Feed this back into the variable you pass in, as shown in the example.</para>
		/// </returns>
		// Token: 0x06001B76 RID: 7030 RVA: 0x0001FC0C File Offset: 0x0001DE0C
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
		{
			string name = style.name;
			GUIStyle guistyle = GUI.skin.FindStyle(name + "VerticalScrollbar");
			if (guistyle == null)
			{
				guistyle = GUI.skin.verticalScrollbar;
			}
			GUIStyle guistyle2 = GUI.skin.FindStyle(name + "HorizontalScrollbar");
			if (guistyle2 == null)
			{
				guistyle2 = GUI.skin.horizontalScrollbar;
			}
			return GUILayout.BeginScrollView(scrollPosition, false, false, guistyle2, guistyle, style, options);
		}

		/// <summary>
		///   <para>Begin an automatically laid out scrollview.</para>
		/// </summary>
		/// <param name="scrollPosition">The position to use display.</param>
		/// <param name="alwayShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when the content inside the ScrollView is wider than the scrollview itself.</param>
		/// <param name="alwayShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when content inside the ScrollView is taller than the scrollview itself.</param>
		/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
		/// <param name="options"></param>
		/// <param name="alwaysShowHorizontal"></param>
		/// <param name="alwaysShowVertical"></param>
		/// <param name="style"></param>
		/// <param name="background"></param>
		/// <returns>
		///   <para>The modified scrollPosition. Feed this back into the variable you pass in, as shown in the example.</para>
		/// </returns>
		// Token: 0x06001B77 RID: 7031 RVA: 0x0000A5AB File Offset: 0x000087AB
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView, options);
		}

		/// <summary>
		///   <para>Begin an automatically laid out scrollview.</para>
		/// </summary>
		/// <param name="scrollPosition">The position to use display.</param>
		/// <param name="alwayShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when the content inside the ScrollView is wider than the scrollview itself.</param>
		/// <param name="alwayShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when content inside the ScrollView is taller than the scrollview itself.</param>
		/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
		/// <param name="options"></param>
		/// <param name="alwaysShowHorizontal"></param>
		/// <param name="alwaysShowVertical"></param>
		/// <param name="style"></param>
		/// <param name="background"></param>
		/// <returns>
		///   <para>The modified scrollPosition. Feed this back into the variable you pass in, as shown in the example.</para>
		/// </returns>
		// Token: 0x06001B78 RID: 7032 RVA: 0x0001FC7C File Offset: 0x0001DE7C
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
		{
			GUIUtility.CheckOnGUI();
			GUIScrollGroup guiscrollGroup = (GUIScrollGroup)GUILayoutUtility.BeginLayoutGroup(background, null, typeof(GUIScrollGroup));
			EventType type = Event.current.type;
			if (type == EventType.Layout)
			{
				guiscrollGroup.resetCoords = true;
				guiscrollGroup.isVertical = true;
				guiscrollGroup.stretchWidth = 1;
				guiscrollGroup.stretchHeight = 1;
				guiscrollGroup.verticalScrollbar = verticalScrollbar;
				guiscrollGroup.horizontalScrollbar = horizontalScrollbar;
				guiscrollGroup.needsVerticalScrollbar = alwaysShowVertical;
				guiscrollGroup.needsHorizontalScrollbar = alwaysShowHorizontal;
				guiscrollGroup.ApplyOptions(options);
			}
			return GUI.BeginScrollView(guiscrollGroup.rect, scrollPosition, new Rect(0f, 0f, guiscrollGroup.clientWidth, guiscrollGroup.clientHeight), alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background);
		}

		/// <summary>
		///   <para>End a scroll view begun with a call to BeginScrollView.</para>
		/// </summary>
		// Token: 0x06001B79 RID: 7033 RVA: 0x0000A5C4 File Offset: 0x000087C4
		public static void EndScrollView()
		{
			GUILayout.EndScrollView(true);
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x0000A5CC File Offset: 0x000087CC
		internal static void EndScrollView(bool handleScrollWheel)
		{
			GUILayoutUtility.EndGroup("GUILayout.EndScrollView");
			GUILayoutUtility.EndLayoutGroup();
			GUI.EndScrollView(handleScrollWheel);
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0000A5E3 File Offset: 0x000087E3
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(text), GUI.skin.window, options);
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0000A5FF File Offset: 0x000087FF
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(image), GUI.skin.window, options);
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0000A61B File Offset: 0x0000881B
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.DoWindow(id, screenRect, func, content, GUI.skin.window, options);
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0000A632 File Offset: 0x00008832
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(text), style, options);
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0000A646 File Offset: 0x00008846
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(image), style, options);
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0000A65A File Offset: 0x0000885A
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.DoWindow(id, screenRect, func, content, style, options);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0001FD38 File Offset: 0x0001DF38
		private static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			GUIUtility.CheckOnGUI();
			GUILayout.LayoutedWindow layoutedWindow = new GUILayout.LayoutedWindow(func, screenRect, content, options, style);
			return GUI.Window(id, screenRect, new GUI.WindowFunction(layoutedWindow.DoWindow), content, style);
		}

		/// <summary>
		///   <para>Option passed to a control to give it an absolute width.</para>
		/// </summary>
		/// <param name="width"></param>
		// Token: 0x06001B82 RID: 7042 RVA: 0x0000A669 File Offset: 0x00008869
		public static GUILayoutOption Width(float width)
		{
			return new GUILayoutOption(GUILayoutOption.Type.fixedWidth, width);
		}

		/// <summary>
		///   <para>Option passed to a control to specify a minimum width.
		/// </para>
		/// </summary>
		/// <param name="minWidth"></param>
		// Token: 0x06001B83 RID: 7043 RVA: 0x0000A677 File Offset: 0x00008877
		public static GUILayoutOption MinWidth(float minWidth)
		{
			return new GUILayoutOption(GUILayoutOption.Type.minWidth, minWidth);
		}

		/// <summary>
		///   <para>Option passed to a control to specify a maximum width.</para>
		/// </summary>
		/// <param name="maxWidth"></param>
		// Token: 0x06001B84 RID: 7044 RVA: 0x0000A685 File Offset: 0x00008885
		public static GUILayoutOption MaxWidth(float maxWidth)
		{
			return new GUILayoutOption(GUILayoutOption.Type.maxWidth, maxWidth);
		}

		/// <summary>
		///   <para>Option passed to a control to give it an absolute height.</para>
		/// </summary>
		/// <param name="height"></param>
		// Token: 0x06001B85 RID: 7045 RVA: 0x0000A693 File Offset: 0x00008893
		public static GUILayoutOption Height(float height)
		{
			return new GUILayoutOption(GUILayoutOption.Type.fixedHeight, height);
		}

		/// <summary>
		///   <para>Option passed to a control to specify a minimum height.</para>
		/// </summary>
		/// <param name="minHeight"></param>
		// Token: 0x06001B86 RID: 7046 RVA: 0x0000A6A1 File Offset: 0x000088A1
		public static GUILayoutOption MinHeight(float minHeight)
		{
			return new GUILayoutOption(GUILayoutOption.Type.minHeight, minHeight);
		}

		/// <summary>
		///   <para>Option passed to a control to specify a maximum height.</para>
		/// </summary>
		/// <param name="maxHeight"></param>
		// Token: 0x06001B87 RID: 7047 RVA: 0x0000A6AF File Offset: 0x000088AF
		public static GUILayoutOption MaxHeight(float maxHeight)
		{
			return new GUILayoutOption(GUILayoutOption.Type.maxHeight, maxHeight);
		}

		/// <summary>
		///   <para>Option passed to a control to allow or disallow horizontal expansion.</para>
		/// </summary>
		/// <param name="expand"></param>
		// Token: 0x06001B88 RID: 7048 RVA: 0x0000A6BD File Offset: 0x000088BD
		public static GUILayoutOption ExpandWidth(bool expand)
		{
			return new GUILayoutOption(GUILayoutOption.Type.stretchWidth, (!expand) ? 0 : 1);
		}

		/// <summary>
		///   <para>Option passed to a control to allow or disallow vertical expansion.</para>
		/// </summary>
		/// <param name="expand"></param>
		// Token: 0x06001B89 RID: 7049 RVA: 0x0000A6D7 File Offset: 0x000088D7
		public static GUILayoutOption ExpandHeight(bool expand)
		{
			return new GUILayoutOption(GUILayoutOption.Type.stretchHeight, (!expand) ? 0 : 1);
		}

		// Token: 0x020001D0 RID: 464
		private sealed class LayoutedWindow
		{
			// Token: 0x06001B8A RID: 7050 RVA: 0x0000A6F1 File Offset: 0x000088F1
			internal LayoutedWindow(GUI.WindowFunction f, Rect screenRect, GUIContent content, GUILayoutOption[] options, GUIStyle style)
			{
				this.m_Func = f;
				this.m_ScreenRect = screenRect;
				this.m_Options = options;
				this.m_Style = style;
			}

			// Token: 0x06001B8B RID: 7051 RVA: 0x0001FD70 File Offset: 0x0001DF70
			public void DoWindow(int windowID)
			{
				GUILayoutGroup topLevel = GUILayoutUtility.current.topLevel;
				EventType type = Event.current.type;
				if (type != EventType.Layout)
				{
					topLevel.ResetCursor();
				}
				else
				{
					topLevel.resetCoords = true;
					topLevel.rect = this.m_ScreenRect;
					if (this.m_Options != null)
					{
						topLevel.ApplyOptions(this.m_Options);
					}
					topLevel.isWindow = true;
					topLevel.windowID = windowID;
					topLevel.style = this.m_Style;
				}
				this.m_Func(windowID);
			}

			// Token: 0x04000704 RID: 1796
			private readonly GUI.WindowFunction m_Func;

			// Token: 0x04000705 RID: 1797
			private readonly Rect m_ScreenRect;

			// Token: 0x04000706 RID: 1798
			private readonly GUILayoutOption[] m_Options;

			// Token: 0x04000707 RID: 1799
			private readonly GUIStyle m_Style;
		}

		/// <summary>
		///   <para>Disposable helper class for managing BeginHorizontal / EndHorizontal.</para>
		/// </summary>
		// Token: 0x020001D1 RID: 465
		public class HorizontalScope : GUI.Scope
		{
			/// <summary>
			///   <para>Create a new HorizontalScope and begin the corresponding horizontal group.</para>
			/// </summary>
			/// <param name="text">Text to display on group.</param>
			/// <param name="image">Texture to display on group.</param>
			/// <param name="content">Text, image, and tooltip for this group.</param>
			/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
			/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
			/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
			/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
			// Token: 0x06001B8C RID: 7052 RVA: 0x0000A717 File Offset: 0x00008917
			public HorizontalScope(params GUILayoutOption[] options)
			{
				GUILayout.BeginHorizontal(options);
			}

			/// <summary>
			///   <para>Create a new HorizontalScope and begin the corresponding horizontal group.</para>
			/// </summary>
			/// <param name="text">Text to display on group.</param>
			/// <param name="image">Texture to display on group.</param>
			/// <param name="content">Text, image, and tooltip for this group.</param>
			/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
			/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
			/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
			/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
			// Token: 0x06001B8D RID: 7053 RVA: 0x0000A725 File Offset: 0x00008925
			public HorizontalScope(GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginHorizontal(style, options);
			}

			/// <summary>
			///   <para>Create a new HorizontalScope and begin the corresponding horizontal group.</para>
			/// </summary>
			/// <param name="text">Text to display on group.</param>
			/// <param name="image">Texture to display on group.</param>
			/// <param name="content">Text, image, and tooltip for this group.</param>
			/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
			/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
			/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
			/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
			// Token: 0x06001B8E RID: 7054 RVA: 0x0000A734 File Offset: 0x00008934
			public HorizontalScope(string text, GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginHorizontal(text, style, options);
			}

			/// <summary>
			///   <para>Create a new HorizontalScope and begin the corresponding horizontal group.</para>
			/// </summary>
			/// <param name="text">Text to display on group.</param>
			/// <param name="image">Texture to display on group.</param>
			/// <param name="content">Text, image, and tooltip for this group.</param>
			/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
			/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
			/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
			/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
			// Token: 0x06001B8F RID: 7055 RVA: 0x0000A744 File Offset: 0x00008944
			public HorizontalScope(Texture image, GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginHorizontal(image, style, options);
			}

			/// <summary>
			///   <para>Create a new HorizontalScope and begin the corresponding horizontal group.</para>
			/// </summary>
			/// <param name="text">Text to display on group.</param>
			/// <param name="image">Texture to display on group.</param>
			/// <param name="content">Text, image, and tooltip for this group.</param>
			/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
			/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
			/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
			/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
			// Token: 0x06001B90 RID: 7056 RVA: 0x0000A754 File Offset: 0x00008954
			public HorizontalScope(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginHorizontal(content, style, options);
			}

			// Token: 0x06001B91 RID: 7057 RVA: 0x0000A764 File Offset: 0x00008964
			protected override void CloseScope()
			{
				GUILayout.EndHorizontal();
			}
		}

		/// <summary>
		///   <para>Disposable helper class for managing BeginVertical / EndVertical.</para>
		/// </summary>
		// Token: 0x020001D2 RID: 466
		public class VerticalScope : GUI.Scope
		{
			/// <summary>
			///   <para>Create a new VerticalScope and begin the corresponding vertical group.</para>
			/// </summary>
			/// <param name="text">Text to display on group.</param>
			/// <param name="image">Texture to display on group.</param>
			/// <param name="content">Text, image, and tooltip for this group.</param>
			/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
			/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
			/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
			/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
			// Token: 0x06001B92 RID: 7058 RVA: 0x0000A76B File Offset: 0x0000896B
			public VerticalScope(params GUILayoutOption[] options)
			{
				GUILayout.BeginVertical(options);
			}

			/// <summary>
			///   <para>Create a new VerticalScope and begin the corresponding vertical group.</para>
			/// </summary>
			/// <param name="text">Text to display on group.</param>
			/// <param name="image">Texture to display on group.</param>
			/// <param name="content">Text, image, and tooltip for this group.</param>
			/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
			/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
			/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
			/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
			// Token: 0x06001B93 RID: 7059 RVA: 0x0000A779 File Offset: 0x00008979
			public VerticalScope(GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginVertical(style, options);
			}

			/// <summary>
			///   <para>Create a new VerticalScope and begin the corresponding vertical group.</para>
			/// </summary>
			/// <param name="text">Text to display on group.</param>
			/// <param name="image">Texture to display on group.</param>
			/// <param name="content">Text, image, and tooltip for this group.</param>
			/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
			/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
			/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
			/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
			// Token: 0x06001B94 RID: 7060 RVA: 0x0000A788 File Offset: 0x00008988
			public VerticalScope(string text, GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginVertical(text, style, options);
			}

			/// <summary>
			///   <para>Create a new VerticalScope and begin the corresponding vertical group.</para>
			/// </summary>
			/// <param name="text">Text to display on group.</param>
			/// <param name="image">Texture to display on group.</param>
			/// <param name="content">Text, image, and tooltip for this group.</param>
			/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
			/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
			/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
			/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
			// Token: 0x06001B95 RID: 7061 RVA: 0x0000A798 File Offset: 0x00008998
			public VerticalScope(Texture image, GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginVertical(image, style, options);
			}

			/// <summary>
			///   <para>Create a new VerticalScope and begin the corresponding vertical group.</para>
			/// </summary>
			/// <param name="text">Text to display on group.</param>
			/// <param name="image">Texture to display on group.</param>
			/// <param name="content">Text, image, and tooltip for this group.</param>
			/// <param name="style">The style to use for background image and padding values. If left out, the background is transparent.</param>
			/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
			/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
			/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
			// Token: 0x06001B96 RID: 7062 RVA: 0x0000A7A8 File Offset: 0x000089A8
			public VerticalScope(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
			{
				GUILayout.BeginVertical(content, style, options);
			}

			// Token: 0x06001B97 RID: 7063 RVA: 0x0000A7B8 File Offset: 0x000089B8
			protected override void CloseScope()
			{
				GUILayout.EndVertical();
			}
		}

		/// <summary>
		///   <para>Disposable helper class for managing BeginArea / EndArea.</para>
		/// </summary>
		// Token: 0x020001D3 RID: 467
		public class AreaScope : GUI.Scope
		{
			/// <summary>
			///   <para>Create a new AreaScope and begin the corresponding Area.</para>
			/// </summary>
			/// <param name="text">Optional text to display in the area.</param>
			/// <param name="image">Optional texture to display in the area.</param>
			/// <param name="content">Optional text, image and tooltip top display for this area.</param>
			/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
			/// <param name="screenRect"></param>
			// Token: 0x06001B98 RID: 7064 RVA: 0x0000A7BF File Offset: 0x000089BF
			public AreaScope(Rect screenRect)
			{
				GUILayout.BeginArea(screenRect);
			}

			/// <summary>
			///   <para>Create a new AreaScope and begin the corresponding Area.</para>
			/// </summary>
			/// <param name="text">Optional text to display in the area.</param>
			/// <param name="image">Optional texture to display in the area.</param>
			/// <param name="content">Optional text, image and tooltip top display for this area.</param>
			/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
			/// <param name="screenRect"></param>
			// Token: 0x06001B99 RID: 7065 RVA: 0x0000A7CD File Offset: 0x000089CD
			public AreaScope(Rect screenRect, string text)
			{
				GUILayout.BeginArea(screenRect, text);
			}

			/// <summary>
			///   <para>Create a new AreaScope and begin the corresponding Area.</para>
			/// </summary>
			/// <param name="text">Optional text to display in the area.</param>
			/// <param name="image">Optional texture to display in the area.</param>
			/// <param name="content">Optional text, image and tooltip top display for this area.</param>
			/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
			/// <param name="screenRect"></param>
			// Token: 0x06001B9A RID: 7066 RVA: 0x0000A7DC File Offset: 0x000089DC
			public AreaScope(Rect screenRect, Texture image)
			{
				GUILayout.BeginArea(screenRect, image);
			}

			/// <summary>
			///   <para>Create a new AreaScope and begin the corresponding Area.</para>
			/// </summary>
			/// <param name="text">Optional text to display in the area.</param>
			/// <param name="image">Optional texture to display in the area.</param>
			/// <param name="content">Optional text, image and tooltip top display for this area.</param>
			/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
			/// <param name="screenRect"></param>
			// Token: 0x06001B9B RID: 7067 RVA: 0x0000A7EB File Offset: 0x000089EB
			public AreaScope(Rect screenRect, GUIContent content)
			{
				GUILayout.BeginArea(screenRect, content);
			}

			/// <summary>
			///   <para>Create a new AreaScope and begin the corresponding Area.</para>
			/// </summary>
			/// <param name="text">Optional text to display in the area.</param>
			/// <param name="image">Optional texture to display in the area.</param>
			/// <param name="content">Optional text, image and tooltip top display for this area.</param>
			/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
			/// <param name="screenRect"></param>
			// Token: 0x06001B9C RID: 7068 RVA: 0x0000A7FA File Offset: 0x000089FA
			public AreaScope(Rect screenRect, string text, GUIStyle style)
			{
				GUILayout.BeginArea(screenRect, text, style);
			}

			/// <summary>
			///   <para>Create a new AreaScope and begin the corresponding Area.</para>
			/// </summary>
			/// <param name="text">Optional text to display in the area.</param>
			/// <param name="image">Optional texture to display in the area.</param>
			/// <param name="content">Optional text, image and tooltip top display for this area.</param>
			/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
			/// <param name="screenRect"></param>
			// Token: 0x06001B9D RID: 7069 RVA: 0x0000A80A File Offset: 0x00008A0A
			public AreaScope(Rect screenRect, Texture image, GUIStyle style)
			{
				GUILayout.BeginArea(screenRect, image, style);
			}

			/// <summary>
			///   <para>Create a new AreaScope and begin the corresponding Area.</para>
			/// </summary>
			/// <param name="text">Optional text to display in the area.</param>
			/// <param name="image">Optional texture to display in the area.</param>
			/// <param name="content">Optional text, image and tooltip top display for this area.</param>
			/// <param name="style">The style to use. If left out, the empty GUIStyle (GUIStyle.none) is used, giving a transparent background.</param>
			/// <param name="screenRect"></param>
			// Token: 0x06001B9E RID: 7070 RVA: 0x0000A81A File Offset: 0x00008A1A
			public AreaScope(Rect screenRect, GUIContent content, GUIStyle style)
			{
				GUILayout.BeginArea(screenRect, content, style);
			}

			// Token: 0x06001B9F RID: 7071 RVA: 0x0000A82A File Offset: 0x00008A2A
			protected override void CloseScope()
			{
				GUILayout.EndArea();
			}
		}

		/// <summary>
		///   <para>Disposable helper class for managing BeginScrollView / EndScrollView.</para>
		/// </summary>
		// Token: 0x020001D4 RID: 468
		public class ScrollViewScope : GUI.Scope
		{
			/// <summary>
			///   <para>Create a new ScrollViewScope and begin the corresponding ScrollView.</para>
			/// </summary>
			/// <param name="scrollPosition">The position to use display.</param>
			/// <param name="alwaysShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when the content inside the ScrollView is wider than the scrollview itself.</param>
			/// <param name="alwaysShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when content inside the ScrollView is taller than the scrollview itself.</param>
			/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
			/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
			/// <param name="options"></param>
			/// <param name="style"></param>
			/// <param name="background"></param>
			// Token: 0x06001BA0 RID: 7072 RVA: 0x0000A831 File Offset: 0x00008A31
			public ScrollViewScope(Vector2 scrollPosition, params GUILayoutOption[] options)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUILayout.BeginScrollView(scrollPosition, options);
			}

			/// <summary>
			///   <para>Create a new ScrollViewScope and begin the corresponding ScrollView.</para>
			/// </summary>
			/// <param name="scrollPosition">The position to use display.</param>
			/// <param name="alwaysShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when the content inside the ScrollView is wider than the scrollview itself.</param>
			/// <param name="alwaysShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when content inside the ScrollView is taller than the scrollview itself.</param>
			/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
			/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
			/// <param name="options"></param>
			/// <param name="style"></param>
			/// <param name="background"></param>
			// Token: 0x06001BA1 RID: 7073 RVA: 0x0000A84D File Offset: 0x00008A4D
			public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, options);
			}

			/// <summary>
			///   <para>Create a new ScrollViewScope and begin the corresponding ScrollView.</para>
			/// </summary>
			/// <param name="scrollPosition">The position to use display.</param>
			/// <param name="alwaysShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when the content inside the ScrollView is wider than the scrollview itself.</param>
			/// <param name="alwaysShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when content inside the ScrollView is taller than the scrollview itself.</param>
			/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
			/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
			/// <param name="options"></param>
			/// <param name="style"></param>
			/// <param name="background"></param>
			// Token: 0x06001BA2 RID: 7074 RVA: 0x0000A86C File Offset: 0x00008A6C
			public ScrollViewScope(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, options);
			}

			/// <summary>
			///   <para>Create a new ScrollViewScope and begin the corresponding ScrollView.</para>
			/// </summary>
			/// <param name="scrollPosition">The position to use display.</param>
			/// <param name="alwaysShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when the content inside the ScrollView is wider than the scrollview itself.</param>
			/// <param name="alwaysShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when content inside the ScrollView is taller than the scrollview itself.</param>
			/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
			/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
			/// <param name="options"></param>
			/// <param name="style"></param>
			/// <param name="background"></param>
			// Token: 0x06001BA3 RID: 7075 RVA: 0x0000A88B File Offset: 0x00008A8B
			public ScrollViewScope(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUILayout.BeginScrollView(scrollPosition, style, options);
			}

			/// <summary>
			///   <para>Create a new ScrollViewScope and begin the corresponding ScrollView.</para>
			/// </summary>
			/// <param name="scrollPosition">The position to use display.</param>
			/// <param name="alwaysShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when the content inside the ScrollView is wider than the scrollview itself.</param>
			/// <param name="alwaysShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when content inside the ScrollView is taller than the scrollview itself.</param>
			/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
			/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
			/// <param name="options"></param>
			/// <param name="style"></param>
			/// <param name="background"></param>
			// Token: 0x06001BA4 RID: 7076 RVA: 0x0000A8A8 File Offset: 0x00008AA8
			public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, options);
			}

			/// <summary>
			///   <para>Create a new ScrollViewScope and begin the corresponding ScrollView.</para>
			/// </summary>
			/// <param name="scrollPosition">The position to use display.</param>
			/// <param name="alwaysShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when the content inside the ScrollView is wider than the scrollview itself.</param>
			/// <param name="alwaysShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when content inside the ScrollView is taller than the scrollview itself.</param>
			/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
			/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
			/// <param name="options"></param>
			/// <param name="style"></param>
			/// <param name="background"></param>
			// Token: 0x06001BA5 RID: 7077 RVA: 0x0000A8CB File Offset: 0x00008ACB
			public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
			}

			/// <summary>
			///   <para>The modified scrollPosition. Feed this back into the variable you pass in, as shown in the example.</para>
			/// </summary>
			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x0000A8F0 File Offset: 0x00008AF0
			// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x0000A8F8 File Offset: 0x00008AF8
			public Vector2 scrollPosition { get; private set; }

			/// <summary>
			///   <para>Whether this ScrollView should handle scroll wheel events. (default: true).</para>
			/// </summary>
			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x0000A901 File Offset: 0x00008B01
			// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x0000A909 File Offset: 0x00008B09
			public bool handleScrollWheel { get; set; }

			// Token: 0x06001BAA RID: 7082 RVA: 0x0000A912 File Offset: 0x00008B12
			protected override void CloseScope()
			{
				GUILayout.EndScrollView(this.handleScrollWheel);
			}
		}
	}
}
