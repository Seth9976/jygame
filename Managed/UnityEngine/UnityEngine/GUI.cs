using System;
using System.Runtime.CompilerServices;
using UnityEngineInternal;

namespace UnityEngine
{
	/// <summary>
	///   <para>The GUI class is the interface for Unity's GUI with manual positioning.</para>
	/// </summary>
	// Token: 0x020001C7 RID: 455
	public class GUI
	{
		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x000093AC File Offset: 0x000075AC
		// (set) Token: 0x06001A24 RID: 6692 RVA: 0x000093B3 File Offset: 0x000075B3
		internal static DateTime nextScrollStepTime { get; set; } = DateTime.Now;

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x000093BB File Offset: 0x000075BB
		// (set) Token: 0x06001A26 RID: 6694 RVA: 0x000093C2 File Offset: 0x000075C2
		internal static int scrollTroughSide { get; set; }

		/// <summary>
		///   <para>The global skin to use.</para>
		/// </summary>
		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x000093D7 File Offset: 0x000075D7
		// (set) Token: 0x06001A27 RID: 6695 RVA: 0x000093CA File Offset: 0x000075CA
		public static GUISkin skin
		{
			get
			{
				GUIUtility.CheckOnGUI();
				return GUI.s_Skin;
			}
			set
			{
				GUIUtility.CheckOnGUI();
				GUI.DoSetSkin(value);
			}
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x000093E3 File Offset: 0x000075E3
		internal static void DoSetSkin(GUISkin newSkin)
		{
			if (!newSkin)
			{
				newSkin = GUIUtility.GetDefaultSkin();
			}
			GUI.s_Skin = newSkin;
			newSkin.MakeCurrent();
		}

		/// <summary>
		///   <para>The GUI transform matrix.</para>
		/// </summary>
		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x00009403 File Offset: 0x00007603
		// (set) Token: 0x06001A2B RID: 6699 RVA: 0x0000940A File Offset: 0x0000760A
		public static Matrix4x4 matrix
		{
			get
			{
				return GUIClip.GetMatrix();
			}
			set
			{
				GUIClip.SetMatrix(value);
			}
		}

		/// <summary>
		///   <para>The tooltip of the control the mouse is currently over, or which has keyboard focus. (Read Only).</para>
		/// </summary>
		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x0001D180 File Offset: 0x0001B380
		// (set) Token: 0x06001A2D RID: 6701 RVA: 0x00009412 File Offset: 0x00007612
		public static string tooltip
		{
			get
			{
				string text = GUI.Internal_GetTooltip();
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
			set
			{
				GUI.Internal_SetTooltip(value);
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x0000941A File Offset: 0x0000761A
		protected static string mouseTooltip
		{
			get
			{
				return GUI.Internal_GetMouseTooltip();
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x00009421 File Offset: 0x00007621
		// (set) Token: 0x06001A30 RID: 6704 RVA: 0x00009428 File Offset: 0x00007628
		protected static Rect tooltipRect
		{
			get
			{
				return GUI.s_ToolTipRect;
			}
			set
			{
				GUI.s_ToolTipRect = value;
			}
		}

		/// <summary>
		///   <para>Make a text or texture label on screen.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the label.</param>
		/// <param name="text">Text to display on the label.</param>
		/// <param name="image">Texture to display on the label.</param>
		/// <param name="content">Text, image and tooltip for this label.</param>
		/// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.</param>
		// Token: 0x06001A31 RID: 6705 RVA: 0x00009430 File Offset: 0x00007630
		public static void Label(Rect position, string text)
		{
			GUI.Label(position, GUIContent.Temp(text), GUI.s_Skin.label);
		}

		/// <summary>
		///   <para>Make a text or texture label on screen.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the label.</param>
		/// <param name="text">Text to display on the label.</param>
		/// <param name="image">Texture to display on the label.</param>
		/// <param name="content">Text, image and tooltip for this label.</param>
		/// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.</param>
		// Token: 0x06001A32 RID: 6706 RVA: 0x00009448 File Offset: 0x00007648
		public static void Label(Rect position, Texture image)
		{
			GUI.Label(position, GUIContent.Temp(image), GUI.s_Skin.label);
		}

		/// <summary>
		///   <para>Make a text or texture label on screen.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the label.</param>
		/// <param name="text">Text to display on the label.</param>
		/// <param name="image">Texture to display on the label.</param>
		/// <param name="content">Text, image and tooltip for this label.</param>
		/// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.</param>
		// Token: 0x06001A33 RID: 6707 RVA: 0x00009460 File Offset: 0x00007660
		public static void Label(Rect position, GUIContent content)
		{
			GUI.Label(position, content, GUI.s_Skin.label);
		}

		/// <summary>
		///   <para>Make a text or texture label on screen.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the label.</param>
		/// <param name="text">Text to display on the label.</param>
		/// <param name="image">Texture to display on the label.</param>
		/// <param name="content">Text, image and tooltip for this label.</param>
		/// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.</param>
		// Token: 0x06001A34 RID: 6708 RVA: 0x00009473 File Offset: 0x00007673
		public static void Label(Rect position, string text, GUIStyle style)
		{
			GUI.Label(position, GUIContent.Temp(text), style);
		}

		/// <summary>
		///   <para>Make a text or texture label on screen.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the label.</param>
		/// <param name="text">Text to display on the label.</param>
		/// <param name="image">Texture to display on the label.</param>
		/// <param name="content">Text, image and tooltip for this label.</param>
		/// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.</param>
		// Token: 0x06001A35 RID: 6709 RVA: 0x00009482 File Offset: 0x00007682
		public static void Label(Rect position, Texture image, GUIStyle style)
		{
			GUI.Label(position, GUIContent.Temp(image), style);
		}

		/// <summary>
		///   <para>Make a text or texture label on screen.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the label.</param>
		/// <param name="text">Text to display on the label.</param>
		/// <param name="image">Texture to display on the label.</param>
		/// <param name="content">Text, image and tooltip for this label.</param>
		/// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.</param>
		// Token: 0x06001A36 RID: 6710 RVA: 0x00009491 File Offset: 0x00007691
		public static void Label(Rect position, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			GUI.DoLabel(position, content, style.m_Ptr);
		}

		/// <summary>
		///   <para>Draw a texture within a rectangle.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to draw the texture within.</param>
		/// <param name="image">Texture to display.</param>
		/// <param name="scaleMode">How to scale the image when the aspect ratio of it doesn't fit the aspect ratio to be drawn within.</param>
		/// <param name="alphaBlend">Whether to apply alpha blending when drawing the image (enabled by default).</param>
		/// <param name="imageAspect">Aspect ratio to use for the source image. If 0 (the default), the aspect ratio from the image is used.  Pass in w/h for the desired aspect ratio.  This allows the aspect ratio of the source image to be adjusted without changing the pixel width and height.</param>
		// Token: 0x06001A37 RID: 6711 RVA: 0x000094A5 File Offset: 0x000076A5
		public static void DrawTexture(Rect position, Texture image)
		{
			GUI.DrawTexture(position, image, ScaleMode.StretchToFill);
		}

		/// <summary>
		///   <para>Draw a texture within a rectangle.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to draw the texture within.</param>
		/// <param name="image">Texture to display.</param>
		/// <param name="scaleMode">How to scale the image when the aspect ratio of it doesn't fit the aspect ratio to be drawn within.</param>
		/// <param name="alphaBlend">Whether to apply alpha blending when drawing the image (enabled by default).</param>
		/// <param name="imageAspect">Aspect ratio to use for the source image. If 0 (the default), the aspect ratio from the image is used.  Pass in w/h for the desired aspect ratio.  This allows the aspect ratio of the source image to be adjusted without changing the pixel width and height.</param>
		// Token: 0x06001A38 RID: 6712 RVA: 0x000094AF File Offset: 0x000076AF
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode)
		{
			GUI.DrawTexture(position, image, scaleMode, true);
		}

		/// <summary>
		///   <para>Draw a texture within a rectangle.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to draw the texture within.</param>
		/// <param name="image">Texture to display.</param>
		/// <param name="scaleMode">How to scale the image when the aspect ratio of it doesn't fit the aspect ratio to be drawn within.</param>
		/// <param name="alphaBlend">Whether to apply alpha blending when drawing the image (enabled by default).</param>
		/// <param name="imageAspect">Aspect ratio to use for the source image. If 0 (the default), the aspect ratio from the image is used.  Pass in w/h for the desired aspect ratio.  This allows the aspect ratio of the source image to be adjusted without changing the pixel width and height.</param>
		// Token: 0x06001A39 RID: 6713 RVA: 0x000094BA File Offset: 0x000076BA
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend)
		{
			GUI.DrawTexture(position, image, scaleMode, alphaBlend, 0f);
		}

		/// <summary>
		///   <para>Draw a texture within a rectangle.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to draw the texture within.</param>
		/// <param name="image">Texture to display.</param>
		/// <param name="scaleMode">How to scale the image when the aspect ratio of it doesn't fit the aspect ratio to be drawn within.</param>
		/// <param name="alphaBlend">Whether to apply alpha blending when drawing the image (enabled by default).</param>
		/// <param name="imageAspect">Aspect ratio to use for the source image. If 0 (the default), the aspect ratio from the image is used.  Pass in w/h for the desired aspect ratio.  This allows the aspect ratio of the source image to be adjusted without changing the pixel width and height.</param>
		// Token: 0x06001A3A RID: 6714 RVA: 0x0001D1A0 File Offset: 0x0001B3A0
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect)
		{
			GUIUtility.CheckOnGUI();
			if (Event.current.type == EventType.Repaint)
			{
				if (image == null)
				{
					Debug.LogWarning("null texture passed to GUI.DrawTexture");
					return;
				}
				if (imageAspect == 0f)
				{
					imageAspect = (float)image.width / (float)image.height;
				}
				Material material = ((!alphaBlend) ? GUI.blitMaterial : GUI.blendMaterial);
				float num = position.width / position.height;
				InternalDrawTextureArguments internalDrawTextureArguments = default(InternalDrawTextureArguments);
				internalDrawTextureArguments.texture = image;
				internalDrawTextureArguments.leftBorder = 0;
				internalDrawTextureArguments.rightBorder = 0;
				internalDrawTextureArguments.topBorder = 0;
				internalDrawTextureArguments.bottomBorder = 0;
				internalDrawTextureArguments.color = GUI.color;
				internalDrawTextureArguments.mat = material;
				switch (scaleMode)
				{
				case ScaleMode.StretchToFill:
					internalDrawTextureArguments.screenRect = position;
					internalDrawTextureArguments.sourceRect = new Rect(0f, 0f, 1f, 1f);
					Graphics.DrawTexture(ref internalDrawTextureArguments);
					break;
				case ScaleMode.ScaleAndCrop:
					if (num > imageAspect)
					{
						float num2 = imageAspect / num;
						internalDrawTextureArguments.screenRect = position;
						internalDrawTextureArguments.sourceRect = new Rect(0f, (1f - num2) * 0.5f, 1f, num2);
						Graphics.DrawTexture(ref internalDrawTextureArguments);
					}
					else
					{
						float num3 = num / imageAspect;
						internalDrawTextureArguments.screenRect = position;
						internalDrawTextureArguments.sourceRect = new Rect(0.5f - num3 * 0.5f, 0f, num3, 1f);
						Graphics.DrawTexture(ref internalDrawTextureArguments);
					}
					break;
				case ScaleMode.ScaleToFit:
					if (num > imageAspect)
					{
						float num4 = imageAspect / num;
						internalDrawTextureArguments.screenRect = new Rect(position.xMin + position.width * (1f - num4) * 0.5f, position.yMin, num4 * position.width, position.height);
						internalDrawTextureArguments.sourceRect = new Rect(0f, 0f, 1f, 1f);
						Graphics.DrawTexture(ref internalDrawTextureArguments);
					}
					else
					{
						float num5 = num / imageAspect;
						internalDrawTextureArguments.screenRect = new Rect(position.xMin, position.yMin + position.height * (1f - num5) * 0.5f, position.width, num5 * position.height);
						internalDrawTextureArguments.sourceRect = new Rect(0f, 0f, 1f, 1f);
						Graphics.DrawTexture(ref internalDrawTextureArguments);
					}
					break;
				}
			}
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0001D42C File Offset: 0x0001B62C
		internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect)
		{
			float num = position.width / position.height;
			bool flag = false;
			switch (scaleMode)
			{
			case ScaleMode.StretchToFill:
				outScreenRect = position;
				outSourceRect = new Rect(0f, 0f, 1f, 1f);
				flag = true;
				break;
			case ScaleMode.ScaleAndCrop:
				if (num > imageAspect)
				{
					float num2 = imageAspect / num;
					outScreenRect = position;
					outSourceRect = new Rect(0f, (1f - num2) * 0.5f, 1f, num2);
					flag = true;
				}
				else
				{
					float num3 = num / imageAspect;
					outScreenRect = position;
					outSourceRect = new Rect(0.5f - num3 * 0.5f, 0f, num3, 1f);
					flag = true;
				}
				break;
			case ScaleMode.ScaleToFit:
				if (num > imageAspect)
				{
					float num4 = imageAspect / num;
					outScreenRect = new Rect(position.xMin + position.width * (1f - num4) * 0.5f, position.yMin, num4 * position.width, position.height);
					outSourceRect = new Rect(0f, 0f, 1f, 1f);
					flag = true;
				}
				else
				{
					float num5 = num / imageAspect;
					outScreenRect = new Rect(position.xMin, position.yMin + position.height * (1f - num5) * 0.5f, position.width, num5 * position.height);
					outSourceRect = new Rect(0f, 0f, 1f, 1f);
					flag = true;
				}
				break;
			}
			return flag;
		}

		/// <summary>
		///   <para>Draw a texture within a rectangle with the given texture coordinates. Use this function for clipping or tiling the image within the given rectangle.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to draw the texture within.</param>
		/// <param name="image">Texture to display.</param>
		/// <param name="texCoords">How to scale the image when the aspect ratio of it doesn't fit the aspect ratio to be drawn within.</param>
		/// <param name="alphaBlend">Whether to alpha blend the image on to the display (the default). If false, the picture is drawn on to the display.</param>
		// Token: 0x06001A3C RID: 6716 RVA: 0x000094CA File Offset: 0x000076CA
		public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords)
		{
			GUI.DrawTextureWithTexCoords(position, image, texCoords, true);
		}

		/// <summary>
		///   <para>Draw a texture within a rectangle with the given texture coordinates. Use this function for clipping or tiling the image within the given rectangle.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to draw the texture within.</param>
		/// <param name="image">Texture to display.</param>
		/// <param name="texCoords">How to scale the image when the aspect ratio of it doesn't fit the aspect ratio to be drawn within.</param>
		/// <param name="alphaBlend">Whether to alpha blend the image on to the display (the default). If false, the picture is drawn on to the display.</param>
		// Token: 0x06001A3D RID: 6717 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
		public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords, bool alphaBlend)
		{
			GUIUtility.CheckOnGUI();
			if (Event.current.type == EventType.Repaint)
			{
				Material material = ((!alphaBlend) ? GUI.blitMaterial : GUI.blendMaterial);
				InternalDrawTextureArguments internalDrawTextureArguments = default(InternalDrawTextureArguments);
				internalDrawTextureArguments.texture = image;
				internalDrawTextureArguments.leftBorder = 0;
				internalDrawTextureArguments.rightBorder = 0;
				internalDrawTextureArguments.topBorder = 0;
				internalDrawTextureArguments.bottomBorder = 0;
				internalDrawTextureArguments.color = GUI.color;
				internalDrawTextureArguments.mat = material;
				internalDrawTextureArguments.screenRect = position;
				internalDrawTextureArguments.sourceRect = texCoords;
				Graphics.DrawTexture(ref internalDrawTextureArguments);
			}
		}

		/// <summary>
		///   <para>Make a graphical box.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the box.</param>
		/// <param name="text">Text to display on the box.</param>
		/// <param name="image">Texture to display on the box.</param>
		/// <param name="content">Text, image and tooltip for this box.</param>
		/// <param name="style">The style to use. If left out, the box style from the current GUISkin is used.</param>
		// Token: 0x06001A3E RID: 6718 RVA: 0x000094D5 File Offset: 0x000076D5
		public static void Box(Rect position, string text)
		{
			GUI.Box(position, GUIContent.Temp(text), GUI.s_Skin.box);
		}

		/// <summary>
		///   <para>Make a graphical box.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the box.</param>
		/// <param name="text">Text to display on the box.</param>
		/// <param name="image">Texture to display on the box.</param>
		/// <param name="content">Text, image and tooltip for this box.</param>
		/// <param name="style">The style to use. If left out, the box style from the current GUISkin is used.</param>
		// Token: 0x06001A3F RID: 6719 RVA: 0x000094ED File Offset: 0x000076ED
		public static void Box(Rect position, Texture image)
		{
			GUI.Box(position, GUIContent.Temp(image), GUI.s_Skin.box);
		}

		/// <summary>
		///   <para>Make a graphical box.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the box.</param>
		/// <param name="text">Text to display on the box.</param>
		/// <param name="image">Texture to display on the box.</param>
		/// <param name="content">Text, image and tooltip for this box.</param>
		/// <param name="style">The style to use. If left out, the box style from the current GUISkin is used.</param>
		// Token: 0x06001A40 RID: 6720 RVA: 0x00009505 File Offset: 0x00007705
		public static void Box(Rect position, GUIContent content)
		{
			GUI.Box(position, content, GUI.s_Skin.box);
		}

		/// <summary>
		///   <para>Make a graphical box.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the box.</param>
		/// <param name="text">Text to display on the box.</param>
		/// <param name="image">Texture to display on the box.</param>
		/// <param name="content">Text, image and tooltip for this box.</param>
		/// <param name="style">The style to use. If left out, the box style from the current GUISkin is used.</param>
		// Token: 0x06001A41 RID: 6721 RVA: 0x00009518 File Offset: 0x00007718
		public static void Box(Rect position, string text, GUIStyle style)
		{
			GUI.Box(position, GUIContent.Temp(text), style);
		}

		/// <summary>
		///   <para>Make a graphical box.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the box.</param>
		/// <param name="text">Text to display on the box.</param>
		/// <param name="image">Texture to display on the box.</param>
		/// <param name="content">Text, image and tooltip for this box.</param>
		/// <param name="style">The style to use. If left out, the box style from the current GUISkin is used.</param>
		// Token: 0x06001A42 RID: 6722 RVA: 0x00009527 File Offset: 0x00007727
		public static void Box(Rect position, Texture image, GUIStyle style)
		{
			GUI.Box(position, GUIContent.Temp(image), style);
		}

		/// <summary>
		///   <para>Make a graphical box.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the box.</param>
		/// <param name="text">Text to display on the box.</param>
		/// <param name="image">Texture to display on the box.</param>
		/// <param name="content">Text, image and tooltip for this box.</param>
		/// <param name="style">The style to use. If left out, the box style from the current GUISkin is used.</param>
		// Token: 0x06001A43 RID: 6723 RVA: 0x0001D660 File Offset: 0x0001B860
		public static void Box(Rect position, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			int controlID = GUIUtility.GetControlID(GUI.s_BoxHash, FocusType.Passive);
			if (Event.current.type == EventType.Repaint)
			{
				style.Draw(position, content, controlID);
			}
		}

		/// <summary>
		///   <para>Make a single press button. The user clicks them and something happens immediately.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>true when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001A44 RID: 6724 RVA: 0x00009536 File Offset: 0x00007736
		public static bool Button(Rect position, string text)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoButton(position, GUIContent.Temp(text), GUI.s_Skin.button.m_Ptr);
		}

		/// <summary>
		///   <para>Make a single press button. The user clicks them and something happens immediately.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>true when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001A45 RID: 6725 RVA: 0x00009558 File Offset: 0x00007758
		public static bool Button(Rect position, Texture image)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoButton(position, GUIContent.Temp(image), GUI.s_Skin.button.m_Ptr);
		}

		/// <summary>
		///   <para>Make a single press button. The user clicks them and something happens immediately.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>true when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001A46 RID: 6726 RVA: 0x0000957A File Offset: 0x0000777A
		public static bool Button(Rect position, GUIContent content)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoButton(position, content, GUI.s_Skin.button.m_Ptr);
		}

		/// <summary>
		///   <para>Make a single press button. The user clicks them and something happens immediately.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>true when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001A47 RID: 6727 RVA: 0x00009597 File Offset: 0x00007797
		public static bool Button(Rect position, string text, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoButton(position, GUIContent.Temp(text), style.m_Ptr);
		}

		/// <summary>
		///   <para>Make a single press button. The user clicks them and something happens immediately.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>true when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001A48 RID: 6728 RVA: 0x000095B0 File Offset: 0x000077B0
		public static bool Button(Rect position, Texture image, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoButton(position, GUIContent.Temp(image), style.m_Ptr);
		}

		/// <summary>
		///   <para>Make a single press button. The user clicks them and something happens immediately.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>true when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001A49 RID: 6729 RVA: 0x000095C9 File Offset: 0x000077C9
		public static bool Button(Rect position, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoButton(position, content, style.m_Ptr);
		}

		/// <summary>
		///   <para>Make a button that is active as long as the user holds it down.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>True when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001A4A RID: 6730 RVA: 0x000095DD File Offset: 0x000077DD
		public static bool RepeatButton(Rect position, string text)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(text), GUI.s_Skin.button, FocusType.Native);
		}

		/// <summary>
		///   <para>Make a button that is active as long as the user holds it down.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>True when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001A4B RID: 6731 RVA: 0x000095F6 File Offset: 0x000077F6
		public static bool RepeatButton(Rect position, Texture image)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(image), GUI.s_Skin.button, FocusType.Native);
		}

		/// <summary>
		///   <para>Make a button that is active as long as the user holds it down.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>True when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001A4C RID: 6732 RVA: 0x0000960F File Offset: 0x0000780F
		public static bool RepeatButton(Rect position, GUIContent content)
		{
			return GUI.DoRepeatButton(position, content, GUI.s_Skin.button, FocusType.Native);
		}

		/// <summary>
		///   <para>Make a button that is active as long as the user holds it down.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>True when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001A4D RID: 6733 RVA: 0x00009623 File Offset: 0x00007823
		public static bool RepeatButton(Rect position, string text, GUIStyle style)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(text), style, FocusType.Native);
		}

		/// <summary>
		///   <para>Make a button that is active as long as the user holds it down.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>True when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001A4E RID: 6734 RVA: 0x00009633 File Offset: 0x00007833
		public static bool RepeatButton(Rect position, Texture image, GUIStyle style)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(image), style, FocusType.Native);
		}

		/// <summary>
		///   <para>Make a button that is active as long as the user holds it down.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>True when the users clicks the button.</para>
		/// </returns>
		// Token: 0x06001A4F RID: 6735 RVA: 0x00009643 File Offset: 0x00007843
		public static bool RepeatButton(Rect position, GUIContent content, GUIStyle style)
		{
			return GUI.DoRepeatButton(position, content, style, FocusType.Native);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0001D698 File Offset: 0x0001B898
		private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType)
		{
			GUIUtility.CheckOnGUI();
			int controlID = GUIUtility.GetControlID(GUI.s_RepeatButtonHash, focusType, position);
			EventType typeForControl = Event.current.GetTypeForControl(controlID);
			if (typeForControl == EventType.MouseDown)
			{
				if (position.Contains(Event.current.mousePosition))
				{
					GUIUtility.hotControl = controlID;
					Event.current.Use();
				}
				return false;
			}
			if (typeForControl != EventType.MouseUp)
			{
				if (typeForControl != EventType.Repaint)
				{
					return false;
				}
				style.Draw(position, content, controlID);
				return controlID == GUIUtility.hotControl && position.Contains(Event.current.mousePosition);
			}
			else
			{
				if (GUIUtility.hotControl == controlID)
				{
					GUIUtility.hotControl = 0;
					Event.current.Use();
					return position.Contains(Event.current.mousePosition);
				}
				return false;
			}
		}

		/// <summary>
		///   <para>Make a single-line text field where the user can edit a string.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the text field.</param>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001A51 RID: 6737 RVA: 0x0001D760 File Offset: 0x0001B960
		public static string TextField(Rect position, string text)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, -1, GUI.skin.textField);
			return guicontent.text;
		}

		/// <summary>
		///   <para>Make a single-line text field where the user can edit a string.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the text field.</param>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001A52 RID: 6738 RVA: 0x0001D794 File Offset: 0x0001B994
		public static string TextField(Rect position, string text, int maxLength)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, GUI.skin.textField);
			return guicontent.text;
		}

		/// <summary>
		///   <para>Make a single-line text field where the user can edit a string.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the text field.</param>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001A53 RID: 6739 RVA: 0x0001D7C8 File Offset: 0x0001B9C8
		public static string TextField(Rect position, string text, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, -1, style);
			return guicontent.text;
		}

		/// <summary>
		///   <para>Make a single-line text field where the user can edit a string.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the text field.</param>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001A54 RID: 6740 RVA: 0x0001D7F4 File Offset: 0x0001B9F4
		public static string TextField(Rect position, string text, int maxLength, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, maxLength, style);
			return guicontent.text;
		}

		/// <summary>
		///   <para>Make a text field where the user can enter a password.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the text field.</param>
		/// <param name="password">Password to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maskChar">Character to mask the password with.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The edited password.</para>
		/// </returns>
		// Token: 0x06001A55 RID: 6741 RVA: 0x0000964E File Offset: 0x0000784E
		public static string PasswordField(Rect position, string password, char maskChar)
		{
			return GUI.PasswordField(position, password, maskChar, -1, GUI.skin.textField);
		}

		/// <summary>
		///   <para>Make a text field where the user can enter a password.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the text field.</param>
		/// <param name="password">Password to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maskChar">Character to mask the password with.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The edited password.</para>
		/// </returns>
		// Token: 0x06001A56 RID: 6742 RVA: 0x00009663 File Offset: 0x00007863
		public static string PasswordField(Rect position, string password, char maskChar, int maxLength)
		{
			return GUI.PasswordField(position, password, maskChar, maxLength, GUI.skin.textField);
		}

		/// <summary>
		///   <para>Make a text field where the user can enter a password.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the text field.</param>
		/// <param name="password">Password to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maskChar">Character to mask the password with.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The edited password.</para>
		/// </returns>
		// Token: 0x06001A57 RID: 6743 RVA: 0x00009678 File Offset: 0x00007878
		public static string PasswordField(Rect position, string password, char maskChar, GUIStyle style)
		{
			return GUI.PasswordField(position, password, maskChar, -1, style);
		}

		/// <summary>
		///   <para>Make a text field where the user can enter a password.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the text field.</param>
		/// <param name="password">Password to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maskChar">Character to mask the password with.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textField style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The edited password.</para>
		/// </returns>
		// Token: 0x06001A58 RID: 6744 RVA: 0x0001D820 File Offset: 0x0001BA20
		public static string PasswordField(Rect position, string password, char maskChar, int maxLength, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			string text = GUI.PasswordFieldGetStrToShow(password, maskChar);
			GUIContent guicontent = GUIContent.Temp(text);
			bool changed = GUI.changed;
			GUI.changed = false;
			if (TouchScreenKeyboard.isSupported)
			{
				GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard), guicontent, false, maxLength, style, password, maskChar);
			}
			else
			{
				GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, style);
			}
			text = ((!GUI.changed) ? password : guicontent.text);
			GUI.changed = GUI.changed || changed;
			return text;
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00009684 File Offset: 0x00007884
		internal static string PasswordFieldGetStrToShow(string password, char maskChar)
		{
			return (Event.current.type != EventType.Repaint && Event.current.type != EventType.MouseDown) ? password : string.Empty.PadRight(password.Length, maskChar);
		}

		/// <summary>
		///   <para>Make a Multi-line text area where the user can edit a string.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the text field.</param>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textArea style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001A5A RID: 6746 RVA: 0x0001D8A8 File Offset: 0x0001BAA8
		public static string TextArea(Rect position, string text)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, -1, GUI.skin.textArea);
			return guicontent.text;
		}

		/// <summary>
		///   <para>Make a Multi-line text area where the user can edit a string.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the text field.</param>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textArea style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001A5B RID: 6747 RVA: 0x0001D8DC File Offset: 0x0001BADC
		public static string TextArea(Rect position, string text, int maxLength)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, maxLength, GUI.skin.textArea);
			return guicontent.text;
		}

		/// <summary>
		///   <para>Make a Multi-line text area where the user can edit a string.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the text field.</param>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textArea style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001A5C RID: 6748 RVA: 0x0001D910 File Offset: 0x0001BB10
		public static string TextArea(Rect position, string text, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, -1, style);
			return guicontent.text;
		}

		/// <summary>
		///   <para>Make a Multi-line text area where the user can edit a string.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the text field.</param>
		/// <param name="text">Text to edit. The return value of this function should be assigned back to the string as shown in the example.</param>
		/// <param name="maxLength">The maximum length of the string. If left out, the user can type for ever and ever.</param>
		/// <param name="style">The style to use. If left out, the textArea style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The edited string.</para>
		/// </returns>
		// Token: 0x06001A5D RID: 6749 RVA: 0x0001D93C File Offset: 0x0001BB3C
		public static string TextArea(Rect position, string text, int maxLength, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, style);
			return guicontent.text;
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0001D968 File Offset: 0x0001BB68
		private static string TextArea(Rect position, GUIContent content, int maxLength, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(content.text, content.image);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, style);
			return guicontent.text;
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x000096BC File Offset: 0x000078BC
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style)
		{
			GUI.DoTextField(position, id, content, multiline, maxLength, style, null);
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x000096CC File Offset: 0x000078CC
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText)
		{
			GUI.DoTextField(position, id, content, multiline, maxLength, style, secureText, '\0');
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar)
		{
			if (maxLength >= 0 && content.text.Length > maxLength)
			{
				content.text = content.text.Substring(0, maxLength);
			}
			GUIUtility.CheckOnGUI();
			TextEditor textEditor = (TextEditor)GUIUtility.GetStateObject(typeof(TextEditor), id);
			textEditor.content.text = content.text;
			textEditor.SaveBackup();
			textEditor.position = position;
			textEditor.style = style;
			textEditor.multiline = multiline;
			textEditor.controlID = id;
			textEditor.DetectFocusChange();
			if (TouchScreenKeyboard.isSupported)
			{
				GUI.HandleTextFieldEventForTouchscreen(position, id, content, multiline, maxLength, style, secureText, maskChar, textEditor);
			}
			else
			{
				GUI.HandleTextFieldEventForDesktop(position, id, content, multiline, maxLength, style, textEditor);
			}
			textEditor.UpdateScrollOffsetIfNeeded();
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x0001DA68 File Offset: 0x0001BC68
		private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor)
		{
			Event current = Event.current;
			EventType type = current.type;
			if (type != EventType.MouseDown)
			{
				if (type == EventType.Repaint)
				{
					if (editor.keyboardOnScreen != null)
					{
						content.text = editor.keyboardOnScreen.text;
						if (maxLength >= 0 && content.text.Length > maxLength)
						{
							content.text = content.text.Substring(0, maxLength);
						}
						if (editor.keyboardOnScreen.done)
						{
							editor.keyboardOnScreen = null;
							GUI.changed = true;
						}
					}
					string text = content.text;
					if (secureText != null)
					{
						content.text = GUI.PasswordFieldGetStrToShow(text, maskChar);
					}
					style.Draw(position, content, id, false);
					content.text = text;
				}
			}
			else if (position.Contains(current.mousePosition))
			{
				GUIUtility.hotControl = id;
				if (GUI.s_HotTextField != -1 && GUI.s_HotTextField != id)
				{
					TextEditor textEditor = (TextEditor)GUIUtility.GetStateObject(typeof(TextEditor), GUI.s_HotTextField);
					textEditor.keyboardOnScreen = null;
				}
				GUI.s_HotTextField = id;
				if (GUIUtility.keyboardControl != id)
				{
					GUIUtility.keyboardControl = id;
				}
				editor.keyboardOnScreen = TouchScreenKeyboard.Open((secureText == null) ? content.text : secureText, TouchScreenKeyboardType.Default, true, multiline, secureText != null);
				current.Use();
			}
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x0001DBD0 File Offset: 0x0001BDD0
		private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor)
		{
			Event current = Event.current;
			bool flag = false;
			switch (current.type)
			{
			case EventType.MouseDown:
				if (position.Contains(current.mousePosition))
				{
					GUIUtility.hotControl = id;
					GUIUtility.keyboardControl = id;
					editor.m_HasFocus = true;
					editor.MoveCursorToPosition(Event.current.mousePosition);
					if (Event.current.clickCount == 2 && GUI.skin.settings.doubleClickSelectsWord)
					{
						editor.SelectCurrentWord();
						editor.DblClickSnap(TextEditor.DblClickSnapping.WORDS);
						editor.MouseDragSelectsWholeWords(true);
					}
					if (Event.current.clickCount == 3 && GUI.skin.settings.tripleClickSelectsLine)
					{
						editor.SelectCurrentParagraph();
						editor.MouseDragSelectsWholeWords(true);
						editor.DblClickSnap(TextEditor.DblClickSnapping.PARAGRAPHS);
					}
					current.Use();
				}
				break;
			case EventType.MouseUp:
				if (GUIUtility.hotControl == id)
				{
					editor.MouseDragSelectsWholeWords(false);
					GUIUtility.hotControl = 0;
					current.Use();
				}
				break;
			case EventType.MouseDrag:
				if (GUIUtility.hotControl == id)
				{
					if (current.shift)
					{
						editor.MoveCursorToPosition(Event.current.mousePosition);
					}
					else
					{
						editor.SelectToPosition(Event.current.mousePosition);
					}
					current.Use();
				}
				break;
			case EventType.KeyDown:
				if (GUIUtility.keyboardControl != id)
				{
					return;
				}
				if (editor.HandleKeyEvent(current))
				{
					current.Use();
					flag = true;
					content.text = editor.content.text;
				}
				else
				{
					if (current.keyCode == KeyCode.Tab || current.character == '\t')
					{
						return;
					}
					char character = current.character;
					if (character == '\n' && !multiline && !current.alt)
					{
						return;
					}
					Font font = style.font;
					if (!font)
					{
						font = GUI.skin.font;
					}
					if (font.HasCharacter(character) || character == '\n')
					{
						editor.Insert(character);
						flag = true;
					}
					else if (character == '\0')
					{
						if (Input.compositionString.Length > 0)
						{
							editor.ReplaceSelection(string.Empty);
							flag = true;
						}
						current.Use();
					}
				}
				break;
			case EventType.Repaint:
				if (GUIUtility.keyboardControl != id)
				{
					style.Draw(position, content, id, false);
				}
				else
				{
					editor.DrawCursor(content.text);
				}
				break;
			}
			if (GUIUtility.keyboardControl == id)
			{
				GUIUtility.textFieldInput = true;
			}
			if (flag)
			{
				GUI.changed = true;
				content.text = editor.content.text;
				if (maxLength >= 0 && content.text.Length > maxLength)
				{
					content.text = content.text.Substring(0, maxLength);
				}
				current.Use();
			}
		}

		/// <summary>
		///   <para>Make an on/off toggle button.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="value">Is this button on or off?</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the toggle style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The new value of the button.</para>
		/// </returns>
		// Token: 0x06001A64 RID: 6756 RVA: 0x000096DE File Offset: 0x000078DE
		public static bool Toggle(Rect position, bool value, string text)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(text), GUI.s_Skin.toggle);
		}

		/// <summary>
		///   <para>Make an on/off toggle button.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="value">Is this button on or off?</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the toggle style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The new value of the button.</para>
		/// </returns>
		// Token: 0x06001A65 RID: 6757 RVA: 0x000096F7 File Offset: 0x000078F7
		public static bool Toggle(Rect position, bool value, Texture image)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(image), GUI.s_Skin.toggle);
		}

		/// <summary>
		///   <para>Make an on/off toggle button.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="value">Is this button on or off?</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the toggle style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The new value of the button.</para>
		/// </returns>
		// Token: 0x06001A66 RID: 6758 RVA: 0x00009710 File Offset: 0x00007910
		public static bool Toggle(Rect position, bool value, GUIContent content)
		{
			return GUI.Toggle(position, value, content, GUI.s_Skin.toggle);
		}

		/// <summary>
		///   <para>Make an on/off toggle button.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="value">Is this button on or off?</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the toggle style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The new value of the button.</para>
		/// </returns>
		// Token: 0x06001A67 RID: 6759 RVA: 0x00009724 File Offset: 0x00007924
		public static bool Toggle(Rect position, bool value, string text, GUIStyle style)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(text), style);
		}

		/// <summary>
		///   <para>Make an on/off toggle button.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="value">Is this button on or off?</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the toggle style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The new value of the button.</para>
		/// </returns>
		// Token: 0x06001A68 RID: 6760 RVA: 0x00009734 File Offset: 0x00007934
		public static bool Toggle(Rect position, bool value, Texture image, GUIStyle style)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(image), style);
		}

		/// <summary>
		///   <para>Make an on/off toggle button.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the button.</param>
		/// <param name="value">Is this button on or off?</param>
		/// <param name="text">Text to display on the button.</param>
		/// <param name="image">Texture to display on the button.</param>
		/// <param name="content">Text, image and tooltip for this button.</param>
		/// <param name="style">The style to use. If left out, the toggle style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The new value of the button.</para>
		/// </returns>
		// Token: 0x06001A69 RID: 6761 RVA: 0x00009744 File Offset: 0x00007944
		public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoToggle(position, GUIUtility.GetControlID(GUI.s_ToggleHash, FocusType.Native, position), value, content, style.m_Ptr);
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00009765 File Offset: 0x00007965
		public static bool Toggle(Rect position, int id, bool value, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoToggle(position, id, value, content, style.m_Ptr);
		}

		/// <summary>
		///   <para>Make a toolbar.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the toolbar.</param>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the toolbar buttons.</param>
		/// <param name="images">An array of textures on the toolbar buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the toolbar buttons.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001A6B RID: 6763 RVA: 0x0000977C File Offset: 0x0000797C
		public static int Toolbar(Rect position, int selected, string[] texts)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(texts), GUI.s_Skin.button);
		}

		/// <summary>
		///   <para>Make a toolbar.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the toolbar.</param>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the toolbar buttons.</param>
		/// <param name="images">An array of textures on the toolbar buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the toolbar buttons.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001A6C RID: 6764 RVA: 0x00009795 File Offset: 0x00007995
		public static int Toolbar(Rect position, int selected, Texture[] images)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(images), GUI.s_Skin.button);
		}

		/// <summary>
		///   <para>Make a toolbar.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the toolbar.</param>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the toolbar buttons.</param>
		/// <param name="images">An array of textures on the toolbar buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the toolbar buttons.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001A6D RID: 6765 RVA: 0x000097AE File Offset: 0x000079AE
		public static int Toolbar(Rect position, int selected, GUIContent[] content)
		{
			return GUI.Toolbar(position, selected, content, GUI.s_Skin.button);
		}

		/// <summary>
		///   <para>Make a toolbar.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the toolbar.</param>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the toolbar buttons.</param>
		/// <param name="images">An array of textures on the toolbar buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the toolbar buttons.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001A6E RID: 6766 RVA: 0x000097C2 File Offset: 0x000079C2
		public static int Toolbar(Rect position, int selected, string[] texts, GUIStyle style)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(texts), style);
		}

		/// <summary>
		///   <para>Make a toolbar.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the toolbar.</param>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the toolbar buttons.</param>
		/// <param name="images">An array of textures on the toolbar buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the toolbar buttons.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001A6F RID: 6767 RVA: 0x000097D2 File Offset: 0x000079D2
		public static int Toolbar(Rect position, int selected, Texture[] images, GUIStyle style)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(images), style);
		}

		/// <summary>
		///   <para>Make a toolbar.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the toolbar.</param>
		/// <param name="selected">The index of the selected button.</param>
		/// <param name="texts">An array of strings to show on the toolbar buttons.</param>
		/// <param name="images">An array of textures on the toolbar buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the toolbar buttons.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001A70 RID: 6768 RVA: 0x0001DEB4 File Offset: 0x0001C0B4
		public static int Toolbar(Rect position, int selected, GUIContent[] contents, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			GUIStyle guistyle;
			GUIStyle guistyle2;
			GUIStyle guistyle3;
			GUI.FindStyles(ref style, out guistyle, out guistyle2, out guistyle3, "left", "mid", "right");
			return GUI.DoButtonGrid(position, selected, contents, contents.Length, style, guistyle, guistyle2, guistyle3);
		}

		/// <summary>
		///   <para>Make a grid of buttons.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the grid.</param>
		/// <param name="selected">The index of the selected grid button.</param>
		/// <param name="texts">An array of strings to show on the grid buttons.</param>
		/// <param name="images">An array of textures on the grid buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the grid button.</param>
		/// <param name="xCount">How many elements to fit in the horizontal direction. The controls will be scaled to fit unless the style defines a fixedWidth to use.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001A71 RID: 6769 RVA: 0x000097E2 File Offset: 0x000079E2
		public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(texts), xCount, null);
		}

		/// <summary>
		///   <para>Make a grid of buttons.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the grid.</param>
		/// <param name="selected">The index of the selected grid button.</param>
		/// <param name="texts">An array of strings to show on the grid buttons.</param>
		/// <param name="images">An array of textures on the grid buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the grid button.</param>
		/// <param name="xCount">How many elements to fit in the horizontal direction. The controls will be scaled to fit unless the style defines a fixedWidth to use.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001A72 RID: 6770 RVA: 0x000097F3 File Offset: 0x000079F3
		public static int SelectionGrid(Rect position, int selected, Texture[] images, int xCount)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(images), xCount, null);
		}

		/// <summary>
		///   <para>Make a grid of buttons.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the grid.</param>
		/// <param name="selected">The index of the selected grid button.</param>
		/// <param name="texts">An array of strings to show on the grid buttons.</param>
		/// <param name="images">An array of textures on the grid buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the grid button.</param>
		/// <param name="xCount">How many elements to fit in the horizontal direction. The controls will be scaled to fit unless the style defines a fixedWidth to use.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001A73 RID: 6771 RVA: 0x00009804 File Offset: 0x00007A04
		public static int SelectionGrid(Rect position, int selected, GUIContent[] content, int xCount)
		{
			return GUI.SelectionGrid(position, selected, content, xCount, null);
		}

		/// <summary>
		///   <para>Make a grid of buttons.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the grid.</param>
		/// <param name="selected">The index of the selected grid button.</param>
		/// <param name="texts">An array of strings to show on the grid buttons.</param>
		/// <param name="images">An array of textures on the grid buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the grid button.</param>
		/// <param name="xCount">How many elements to fit in the horizontal direction. The controls will be scaled to fit unless the style defines a fixedWidth to use.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001A74 RID: 6772 RVA: 0x00009810 File Offset: 0x00007A10
		public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount, GUIStyle style)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(texts), xCount, style);
		}

		/// <summary>
		///   <para>Make a grid of buttons.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the grid.</param>
		/// <param name="selected">The index of the selected grid button.</param>
		/// <param name="texts">An array of strings to show on the grid buttons.</param>
		/// <param name="images">An array of textures on the grid buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the grid button.</param>
		/// <param name="xCount">How many elements to fit in the horizontal direction. The controls will be scaled to fit unless the style defines a fixedWidth to use.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001A75 RID: 6773 RVA: 0x00009822 File Offset: 0x00007A22
		public static int SelectionGrid(Rect position, int selected, Texture[] images, int xCount, GUIStyle style)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(images), xCount, style);
		}

		/// <summary>
		///   <para>Make a grid of buttons.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the grid.</param>
		/// <param name="selected">The index of the selected grid button.</param>
		/// <param name="texts">An array of strings to show on the grid buttons.</param>
		/// <param name="images">An array of textures on the grid buttons.</param>
		/// <param name="contents">An array of text, image and tooltips for the grid button.</param>
		/// <param name="xCount">How many elements to fit in the horizontal direction. The controls will be scaled to fit unless the style defines a fixedWidth to use.</param>
		/// <param name="style">The style to use. If left out, the button style from the current GUISkin is used.</param>
		/// <param name="content"></param>
		/// <returns>
		///   <para>The index of the selected button.</para>
		/// </returns>
		// Token: 0x06001A76 RID: 6774 RVA: 0x00009834 File Offset: 0x00007A34
		public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style)
		{
			if (style == null)
			{
				style = GUI.s_Skin.button;
			}
			return GUI.DoButtonGrid(position, selected, contents, xCount, style, style, style, style);
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0001DEF4 File Offset: 0x0001C0F4
		internal static void FindStyles(ref GUIStyle style, out GUIStyle firstStyle, out GUIStyle midStyle, out GUIStyle lastStyle, string first, string mid, string last)
		{
			if (style == null)
			{
				style = GUI.skin.button;
			}
			string name = style.name;
			midStyle = GUI.skin.FindStyle(name + mid);
			if (midStyle == null)
			{
				midStyle = style;
			}
			firstStyle = GUI.skin.FindStyle(name + first);
			if (firstStyle == null)
			{
				firstStyle = midStyle;
			}
			lastStyle = GUI.skin.FindStyle(name + last);
			if (lastStyle == null)
			{
				lastStyle = midStyle;
			}
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0001DF7C File Offset: 0x0001C17C
		internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle)
		{
			if (xCount < 2)
			{
				return 0;
			}
			if (xCount == 2)
			{
				return Mathf.Max(firstStyle.margin.right, lastStyle.margin.left);
			}
			int num = Mathf.Max(midStyle.margin.left, midStyle.margin.right);
			return Mathf.Max(firstStyle.margin.right, midStyle.margin.left) + Mathf.Max(midStyle.margin.right, lastStyle.margin.left) + num * (xCount - 3);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0001E010 File Offset: 0x0001C210
		private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle)
		{
			GUIUtility.CheckOnGUI();
			int num = contents.Length;
			if (num == 0)
			{
				return selected;
			}
			if (xCount <= 0)
			{
				Debug.LogWarning("You are trying to create a SelectionGrid with zero or less elements to be displayed in the horizontal direction. Set xCount to a positive value.");
				return selected;
			}
			int controlID = GUIUtility.GetControlID(GUI.s_ButtonGridHash, FocusType.Native, position);
			int num2 = num / xCount;
			if (num % xCount != 0)
			{
				num2++;
			}
			float num3 = (float)GUI.CalcTotalHorizSpacing(xCount, style, firstStyle, midStyle, lastStyle);
			float num4 = (float)(Mathf.Max(style.margin.top, style.margin.bottom) * (num2 - 1));
			float num5 = (position.width - num3) / (float)xCount;
			float num6 = (position.height - num4) / (float)num2;
			if (style.fixedWidth != 0f)
			{
				num5 = style.fixedWidth;
			}
			if (style.fixedHeight != 0f)
			{
				num6 = style.fixedHeight;
			}
			switch (Event.current.GetTypeForControl(controlID))
			{
			case EventType.MouseDown:
				if (position.Contains(Event.current.mousePosition))
				{
					Rect[] array = GUI.CalcMouseRects(position, num, xCount, num5, num6, style, firstStyle, midStyle, lastStyle, false);
					if (GUI.GetButtonGridMouseSelection(array, Event.current.mousePosition, true) != -1)
					{
						GUIUtility.hotControl = controlID;
						Event.current.Use();
					}
				}
				break;
			case EventType.MouseUp:
				if (GUIUtility.hotControl == controlID)
				{
					GUIUtility.hotControl = 0;
					Event.current.Use();
					Rect[] array = GUI.CalcMouseRects(position, num, xCount, num5, num6, style, firstStyle, midStyle, lastStyle, false);
					int buttonGridMouseSelection = GUI.GetButtonGridMouseSelection(array, Event.current.mousePosition, true);
					GUI.changed = true;
					return buttonGridMouseSelection;
				}
				break;
			case EventType.MouseDrag:
				if (GUIUtility.hotControl == controlID)
				{
					Event.current.Use();
				}
				break;
			case EventType.Repaint:
			{
				GUIStyle guistyle = null;
				GUIClip.Push(position, Vector2.zero, Vector2.zero, false);
				position = new Rect(0f, 0f, position.width, position.height);
				Rect[] array = GUI.CalcMouseRects(position, num, xCount, num5, num6, style, firstStyle, midStyle, lastStyle, false);
				int buttonGridMouseSelection2 = GUI.GetButtonGridMouseSelection(array, Event.current.mousePosition, controlID == GUIUtility.hotControl);
				bool flag = position.Contains(Event.current.mousePosition);
				GUIUtility.mouseUsed = GUIUtility.mouseUsed || flag;
				for (int i = 0; i < num; i++)
				{
					GUIStyle guistyle2;
					if (i != 0)
					{
						guistyle2 = midStyle;
					}
					else
					{
						guistyle2 = firstStyle;
					}
					if (i == num - 1)
					{
						guistyle2 = lastStyle;
					}
					if (num == 1)
					{
						guistyle2 = style;
					}
					if (i != selected)
					{
						guistyle2.Draw(array[i], contents[i], i == buttonGridMouseSelection2 && (GUI.enabled || controlID == GUIUtility.hotControl) && (controlID == GUIUtility.hotControl || GUIUtility.hotControl == 0), controlID == GUIUtility.hotControl && GUI.enabled, false, false);
					}
					else
					{
						guistyle = guistyle2;
					}
				}
				if (selected < num && selected > -1)
				{
					guistyle.Draw(array[selected], contents[selected], selected == buttonGridMouseSelection2 && (GUI.enabled || controlID == GUIUtility.hotControl) && (controlID == GUIUtility.hotControl || GUIUtility.hotControl == 0), controlID == GUIUtility.hotControl, true, false);
				}
				if (buttonGridMouseSelection2 >= 0)
				{
					GUI.tooltip = contents[buttonGridMouseSelection2].tooltip;
				}
				GUIClip.Pop();
				break;
			}
			}
			return selected;
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x0001E3AC File Offset: 0x0001C5AC
		private static Rect[] CalcMouseRects(Rect position, int count, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, bool addBorders)
		{
			int num = 0;
			int num2 = 0;
			float num3 = position.xMin;
			float num4 = position.yMin;
			GUIStyle guistyle = style;
			Rect[] array = new Rect[count];
			if (count > 1)
			{
				guistyle = firstStyle;
			}
			for (int i = 0; i < count; i++)
			{
				if (!addBorders)
				{
					array[i] = new Rect(num3, num4, elemWidth, elemHeight);
				}
				else
				{
					array[i] = guistyle.margin.Add(new Rect(num3, num4, elemWidth, elemHeight));
				}
				array[i].width = Mathf.Round(array[i].xMax) - Mathf.Round(array[i].x);
				array[i].x = Mathf.Round(array[i].x);
				GUIStyle guistyle2 = midStyle;
				if (i == count - 2)
				{
					guistyle2 = lastStyle;
				}
				num3 += elemWidth + (float)Mathf.Max(guistyle.margin.right, guistyle2.margin.left);
				num2++;
				if (num2 >= xCount)
				{
					num++;
					num2 = 0;
					num4 += elemHeight + (float)Mathf.Max(style.margin.top, style.margin.bottom);
					num3 = position.xMin;
				}
			}
			return array;
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x0001E50C File Offset: 0x0001C70C
		private static int GetButtonGridMouseSelection(Rect[] buttonRects, Vector2 mousePos, bool findNearest)
		{
			for (int i = 0; i < buttonRects.Length; i++)
			{
				if (buttonRects[i].Contains(mousePos))
				{
					return i;
				}
			}
			if (!findNearest)
			{
				return -1;
			}
			float num = 10000000f;
			int num2 = -1;
			for (int j = 0; j < buttonRects.Length; j++)
			{
				Rect rect = buttonRects[j];
				Vector2 vector = new Vector2(Mathf.Clamp(mousePos.x, rect.xMin, rect.xMax), Mathf.Clamp(mousePos.y, rect.yMin, rect.yMax));
				float sqrMagnitude = (mousePos - vector).sqrMagnitude;
				if (sqrMagnitude < num)
				{
					num2 = j;
					num = sqrMagnitude;
				}
			}
			return num2;
		}

		/// <summary>
		///   <para>A horizontal slider the user can drag to change a value between a min and a max.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the slider.</param>
		/// <param name="value">The value the slider shows. This determines the position of the draggable thumb.</param>
		/// <param name="leftValue">The value at the left end of the slider.</param>
		/// <param name="rightValue">The value at the right end of the slider.</param>
		/// <param name="slider">The GUIStyle to use for displaying the dragging area. If left out, the horizontalSlider style from the current GUISkin is used.</param>
		/// <param name="thumb">The GUIStyle to use for displaying draggable thumb. If left out, the horizontalSliderThumb style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The value that has been set by the user.</para>
		/// </returns>
		// Token: 0x06001A7C RID: 6780 RVA: 0x0001E5D0 File Offset: 0x0001C7D0
		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue)
		{
			return GUI.Slider(position, value, 0f, leftValue, rightValue, GUI.skin.horizontalSlider, GUI.skin.horizontalSliderThumb, true, GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Native, position));
		}

		/// <summary>
		///   <para>A horizontal slider the user can drag to change a value between a min and a max.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the slider.</param>
		/// <param name="value">The value the slider shows. This determines the position of the draggable thumb.</param>
		/// <param name="leftValue">The value at the left end of the slider.</param>
		/// <param name="rightValue">The value at the right end of the slider.</param>
		/// <param name="slider">The GUIStyle to use for displaying the dragging area. If left out, the horizontalSlider style from the current GUISkin is used.</param>
		/// <param name="thumb">The GUIStyle to use for displaying draggable thumb. If left out, the horizontalSliderThumb style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The value that has been set by the user.</para>
		/// </returns>
		// Token: 0x06001A7D RID: 6781 RVA: 0x0001E60C File Offset: 0x0001C80C
		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb)
		{
			return GUI.Slider(position, value, 0f, leftValue, rightValue, slider, thumb, true, GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Native, position));
		}

		/// <summary>
		///   <para>A vertical slider the user can drag to change a value between a min and a max.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the slider.</param>
		/// <param name="value">The value the slider shows. This determines the position of the draggable thumb.</param>
		/// <param name="topValue">The value at the top end of the slider.</param>
		/// <param name="bottomValue">The value at the bottom end of the slider.</param>
		/// <param name="slider">The GUIStyle to use for displaying the dragging area. If left out, the horizontalSlider style from the current GUISkin is used.</param>
		/// <param name="thumb">The GUIStyle to use for displaying draggable thumb. If left out, the horizontalSliderThumb style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The value that has been set by the user.</para>
		/// </returns>
		// Token: 0x06001A7E RID: 6782 RVA: 0x0001E638 File Offset: 0x0001C838
		public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue)
		{
			return GUI.Slider(position, value, 0f, topValue, bottomValue, GUI.skin.verticalSlider, GUI.skin.verticalSliderThumb, false, GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Native, position));
		}

		/// <summary>
		///   <para>A vertical slider the user can drag to change a value between a min and a max.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the slider.</param>
		/// <param name="value">The value the slider shows. This determines the position of the draggable thumb.</param>
		/// <param name="topValue">The value at the top end of the slider.</param>
		/// <param name="bottomValue">The value at the bottom end of the slider.</param>
		/// <param name="slider">The GUIStyle to use for displaying the dragging area. If left out, the horizontalSlider style from the current GUISkin is used.</param>
		/// <param name="thumb">The GUIStyle to use for displaying draggable thumb. If left out, the horizontalSliderThumb style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The value that has been set by the user.</para>
		/// </returns>
		// Token: 0x06001A7F RID: 6783 RVA: 0x0001E674 File Offset: 0x0001C874
		public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb)
		{
			return GUI.Slider(position, value, 0f, topValue, bottomValue, slider, thumb, false, GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Native, position));
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0001E6A0 File Offset: 0x0001C8A0
		public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id)
		{
			GUIUtility.CheckOnGUI();
			SliderHandler sliderHandler = new SliderHandler(position, value, size, start, end, slider, thumb, horiz, id);
			return sliderHandler.Handle();
		}

		/// <summary>
		///   <para>Make a horizontal scrollbar. Scrollbars are what you use to scroll through a document. Most likely, you want to use scrollViews instead.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the scrollbar.</param>
		/// <param name="value">The position between min and max.</param>
		/// <param name="size">How much can we see?</param>
		/// <param name="leftValue">The value at the left end of the scrollbar.</param>
		/// <param name="rightValue">The value at the right end of the scrollbar.</param>
		/// <param name="style">The style to use for the scrollbar background. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The modified value. This can be changed by the user by dragging the scrollbar, or clicking the arrows at the end.</para>
		/// </returns>
		// Token: 0x06001A81 RID: 6785 RVA: 0x0001E6D0 File Offset: 0x0001C8D0
		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue)
		{
			return GUI.Scroller(position, value, size, leftValue, rightValue, GUI.skin.horizontalScrollbar, GUI.skin.horizontalScrollbarThumb, GUI.skin.horizontalScrollbarLeftButton, GUI.skin.horizontalScrollbarRightButton, true);
		}

		/// <summary>
		///   <para>Make a horizontal scrollbar. Scrollbars are what you use to scroll through a document. Most likely, you want to use scrollViews instead.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the scrollbar.</param>
		/// <param name="value">The position between min and max.</param>
		/// <param name="size">How much can we see?</param>
		/// <param name="leftValue">The value at the left end of the scrollbar.</param>
		/// <param name="rightValue">The value at the right end of the scrollbar.</param>
		/// <param name="style">The style to use for the scrollbar background. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The modified value. This can be changed by the user by dragging the scrollbar, or clicking the arrows at the end.</para>
		/// </returns>
		// Token: 0x06001A82 RID: 6786 RVA: 0x0001E714 File Offset: 0x0001C914
		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style)
		{
			return GUI.Scroller(position, value, size, leftValue, rightValue, style, GUI.skin.GetStyle(style.name + "thumb"), GUI.skin.GetStyle(style.name + "leftbutton"), GUI.skin.GetStyle(style.name + "rightbutton"), true);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0001E780 File Offset: 0x0001C980
		internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style)
		{
			bool flag = false;
			if (GUI.DoRepeatButton(rect, GUIContent.none, style, FocusType.Passive))
			{
				bool flag2 = GUI.s_ScrollControlId != scrollerID;
				GUI.s_ScrollControlId = scrollerID;
				if (flag2)
				{
					flag = true;
					GUI.nextScrollStepTime = DateTime.Now.AddMilliseconds(250.0);
				}
				else if (DateTime.Now >= GUI.nextScrollStepTime)
				{
					flag = true;
					GUI.nextScrollStepTime = DateTime.Now.AddMilliseconds(30.0);
				}
				if (Event.current.type == EventType.Repaint)
				{
					GUI.InternalRepaintEditorWindow();
				}
			}
			return flag;
		}

		/// <summary>
		///   <para>Make a vertical scrollbar. Scrollbars are what you use to scroll through a document. Most likely, you want to use scrollViews instead.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the scrollbar.</param>
		/// <param name="value">The position between min and max.</param>
		/// <param name="size">How much can we see?</param>
		/// <param name="topValue">The value at the top of the scrollbar.</param>
		/// <param name="bottomValue">The value at the bottom of the scrollbar.</param>
		/// <param name="style">The style to use for the scrollbar background. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The modified value. This can be changed by the user by dragging the scrollbar, or clicking the arrows at the end.</para>
		/// </returns>
		// Token: 0x06001A84 RID: 6788 RVA: 0x0001E824 File Offset: 0x0001CA24
		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue)
		{
			return GUI.Scroller(position, value, size, topValue, bottomValue, GUI.skin.verticalScrollbar, GUI.skin.verticalScrollbarThumb, GUI.skin.verticalScrollbarUpButton, GUI.skin.verticalScrollbarDownButton, false);
		}

		/// <summary>
		///   <para>Make a vertical scrollbar. Scrollbars are what you use to scroll through a document. Most likely, you want to use scrollViews instead.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the scrollbar.</param>
		/// <param name="value">The position between min and max.</param>
		/// <param name="size">How much can we see?</param>
		/// <param name="topValue">The value at the top of the scrollbar.</param>
		/// <param name="bottomValue">The value at the bottom of the scrollbar.</param>
		/// <param name="style">The style to use for the scrollbar background. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <returns>
		///   <para>The modified value. This can be changed by the user by dragging the scrollbar, or clicking the arrows at the end.</para>
		/// </returns>
		// Token: 0x06001A85 RID: 6789 RVA: 0x0001E868 File Offset: 0x0001CA68
		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style)
		{
			return GUI.Scroller(position, value, size, topValue, bottomValue, style, GUI.skin.GetStyle(style.name + "thumb"), GUI.skin.GetStyle(style.name + "upbutton"), GUI.skin.GetStyle(style.name + "downbutton"), false);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0001E8D4 File Offset: 0x0001CAD4
		private static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz)
		{
			GUIUtility.CheckOnGUI();
			int controlID = GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Passive, position);
			Rect rect;
			Rect rect2;
			Rect rect3;
			if (horiz)
			{
				rect = new Rect(position.x + leftButton.fixedWidth, position.y, position.width - leftButton.fixedWidth - rightButton.fixedWidth, position.height);
				rect2 = new Rect(position.x, position.y, leftButton.fixedWidth, position.height);
				rect3 = new Rect(position.xMax - rightButton.fixedWidth, position.y, rightButton.fixedWidth, position.height);
			}
			else
			{
				rect = new Rect(position.x, position.y + leftButton.fixedHeight, position.width, position.height - leftButton.fixedHeight - rightButton.fixedHeight);
				rect2 = new Rect(position.x, position.y, position.width, leftButton.fixedHeight);
				rect3 = new Rect(position.x, position.yMax - rightButton.fixedHeight, position.width, rightButton.fixedHeight);
			}
			value = GUI.Slider(rect, value, size, leftValue, rightValue, slider, thumb, horiz, controlID);
			bool flag = false;
			if (Event.current.type == EventType.MouseUp)
			{
				flag = true;
			}
			if (GUI.ScrollerRepeatButton(controlID, rect2, leftButton))
			{
				value -= GUI.s_ScrollStepSize * ((leftValue >= rightValue) ? (-1f) : 1f);
			}
			if (GUI.ScrollerRepeatButton(controlID, rect3, rightButton))
			{
				value += GUI.s_ScrollStepSize * ((leftValue >= rightValue) ? (-1f) : 1f);
			}
			if (flag && Event.current.type == EventType.Used)
			{
				GUI.s_ScrollControlId = 0;
			}
			if (leftValue < rightValue)
			{
				value = Mathf.Clamp(value, leftValue, rightValue - size);
			}
			else
			{
				value = Mathf.Clamp(value, rightValue, leftValue - size);
			}
			return value;
		}

		/// <summary>
		///   <para>Begin a group. Must be matched with a call to EndGroup.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the group.</param>
		/// <param name="text">Text to display on the group.</param>
		/// <param name="image">Texture to display on the group.</param>
		/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
		/// <param name="style">The style to use for the background.</param>
		// Token: 0x06001A87 RID: 6791 RVA: 0x0000985A File Offset: 0x00007A5A
		public static void BeginGroup(Rect position)
		{
			GUI.BeginGroup(position, GUIContent.none, GUIStyle.none);
		}

		/// <summary>
		///   <para>Begin a group. Must be matched with a call to EndGroup.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the group.</param>
		/// <param name="text">Text to display on the group.</param>
		/// <param name="image">Texture to display on the group.</param>
		/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
		/// <param name="style">The style to use for the background.</param>
		// Token: 0x06001A88 RID: 6792 RVA: 0x0000986C File Offset: 0x00007A6C
		public static void BeginGroup(Rect position, string text)
		{
			GUI.BeginGroup(position, GUIContent.Temp(text), GUIStyle.none);
		}

		/// <summary>
		///   <para>Begin a group. Must be matched with a call to EndGroup.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the group.</param>
		/// <param name="text">Text to display on the group.</param>
		/// <param name="image">Texture to display on the group.</param>
		/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
		/// <param name="style">The style to use for the background.</param>
		// Token: 0x06001A89 RID: 6793 RVA: 0x0000987F File Offset: 0x00007A7F
		public static void BeginGroup(Rect position, Texture image)
		{
			GUI.BeginGroup(position, GUIContent.Temp(image), GUIStyle.none);
		}

		/// <summary>
		///   <para>Begin a group. Must be matched with a call to EndGroup.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the group.</param>
		/// <param name="text">Text to display on the group.</param>
		/// <param name="image">Texture to display on the group.</param>
		/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
		/// <param name="style">The style to use for the background.</param>
		// Token: 0x06001A8A RID: 6794 RVA: 0x00009892 File Offset: 0x00007A92
		public static void BeginGroup(Rect position, GUIContent content)
		{
			GUI.BeginGroup(position, content, GUIStyle.none);
		}

		/// <summary>
		///   <para>Begin a group. Must be matched with a call to EndGroup.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the group.</param>
		/// <param name="text">Text to display on the group.</param>
		/// <param name="image">Texture to display on the group.</param>
		/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
		/// <param name="style">The style to use for the background.</param>
		// Token: 0x06001A8B RID: 6795 RVA: 0x000098A0 File Offset: 0x00007AA0
		public static void BeginGroup(Rect position, GUIStyle style)
		{
			GUI.BeginGroup(position, GUIContent.none, style);
		}

		/// <summary>
		///   <para>Begin a group. Must be matched with a call to EndGroup.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the group.</param>
		/// <param name="text">Text to display on the group.</param>
		/// <param name="image">Texture to display on the group.</param>
		/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
		/// <param name="style">The style to use for the background.</param>
		// Token: 0x06001A8C RID: 6796 RVA: 0x000098AE File Offset: 0x00007AAE
		public static void BeginGroup(Rect position, string text, GUIStyle style)
		{
			GUI.BeginGroup(position, GUIContent.Temp(text), style);
		}

		/// <summary>
		///   <para>Begin a group. Must be matched with a call to EndGroup.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the group.</param>
		/// <param name="text">Text to display on the group.</param>
		/// <param name="image">Texture to display on the group.</param>
		/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
		/// <param name="style">The style to use for the background.</param>
		// Token: 0x06001A8D RID: 6797 RVA: 0x000098BD File Offset: 0x00007ABD
		public static void BeginGroup(Rect position, Texture image, GUIStyle style)
		{
			GUI.BeginGroup(position, GUIContent.Temp(image), style);
		}

		/// <summary>
		///   <para>Begin a group. Must be matched with a call to EndGroup.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the group.</param>
		/// <param name="text">Text to display on the group.</param>
		/// <param name="image">Texture to display on the group.</param>
		/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
		/// <param name="style">The style to use for the background.</param>
		// Token: 0x06001A8E RID: 6798 RVA: 0x0001EAE0 File Offset: 0x0001CCE0
		public static void BeginGroup(Rect position, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			int controlID = GUIUtility.GetControlID(GUI.s_BeginGroupHash, FocusType.Passive);
			if (content != GUIContent.none || style != GUIStyle.none)
			{
				EventType type = Event.current.type;
				if (type != EventType.Repaint)
				{
					if (position.Contains(Event.current.mousePosition))
					{
						GUIUtility.mouseUsed = true;
					}
				}
				else
				{
					style.Draw(position, content, controlID);
				}
			}
			GUIClip.Push(position, Vector2.zero, Vector2.zero, false);
		}

		/// <summary>
		///   <para>End a group.</para>
		/// </summary>
		// Token: 0x06001A8F RID: 6799 RVA: 0x000098CC File Offset: 0x00007ACC
		public static void EndGroup()
		{
			GUIUtility.CheckOnGUI();
			GUIClip.Pop();
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x000098D8 File Offset: 0x00007AD8
		public static void BeginClip(Rect position)
		{
			GUIUtility.CheckOnGUI();
			GUIClip.Push(position, Vector2.zero, Vector2.zero, false);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000098CC File Offset: 0x00007ACC
		public static void EndClip()
		{
			GUIUtility.CheckOnGUI();
			GUIClip.Pop();
		}

		/// <summary>
		///   <para>Begin a scrolling view inside your GUI.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the ScrollView.</param>
		/// <param name="scrollPosition">The pixel distance that the view is scrolled in the X and Y directions.</param>
		/// <param name="viewRect">The rectangle used inside the scrollview.</param>
		/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
		/// <param name="alwaysShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when viewRect is wider than position.</param>
		/// <param name="alwaysShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when viewRect is taller than position.</param>
		/// <returns>
		///   <para>The modified scrollPosition. Feed this back into the variable you pass in, as shown in the example.</para>
		/// </returns>
		// Token: 0x06001A92 RID: 6802 RVA: 0x000098F0 File Offset: 0x00007AF0
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, false, false, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView);
		}

		/// <summary>
		///   <para>Begin a scrolling view inside your GUI.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the ScrollView.</param>
		/// <param name="scrollPosition">The pixel distance that the view is scrolled in the X and Y directions.</param>
		/// <param name="viewRect">The rectangle used inside the scrollview.</param>
		/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
		/// <param name="alwaysShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when viewRect is wider than position.</param>
		/// <param name="alwaysShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when viewRect is taller than position.</param>
		/// <returns>
		///   <para>The modified scrollPosition. Feed this back into the variable you pass in, as shown in the example.</para>
		/// </returns>
		// Token: 0x06001A93 RID: 6803 RVA: 0x0000991A File Offset: 0x00007B1A
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView);
		}

		/// <summary>
		///   <para>Begin a scrolling view inside your GUI.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the ScrollView.</param>
		/// <param name="scrollPosition">The pixel distance that the view is scrolled in the X and Y directions.</param>
		/// <param name="viewRect">The rectangle used inside the scrollview.</param>
		/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
		/// <param name="alwaysShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when viewRect is wider than position.</param>
		/// <param name="alwaysShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when viewRect is taller than position.</param>
		/// <returns>
		///   <para>The modified scrollPosition. Feed this back into the variable you pass in, as shown in the example.</para>
		/// </returns>
		// Token: 0x06001A94 RID: 6804 RVA: 0x00009945 File Offset: 0x00007B45
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, false, false, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView);
		}

		/// <summary>
		///   <para>Begin a scrolling view inside your GUI.</para>
		/// </summary>
		/// <param name="position">Rectangle on the screen to use for the ScrollView.</param>
		/// <param name="scrollPosition">The pixel distance that the view is scrolled in the X and Y directions.</param>
		/// <param name="viewRect">The rectangle used inside the scrollview.</param>
		/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
		/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
		/// <param name="alwaysShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when viewRect is wider than position.</param>
		/// <param name="alwaysShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when viewRect is taller than position.</param>
		/// <returns>
		///   <para>The modified scrollPosition. Feed this back into the variable you pass in, as shown in the example.</para>
		/// </returns>
		// Token: 0x06001A95 RID: 6805 RVA: 0x0000995E File Offset: 0x00007B5E
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00009979 File Offset: 0x00007B79
		protected static Vector2 DoBeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x0001EB6C File Offset: 0x0001CD6C
		internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
		{
			GUIUtility.CheckOnGUI();
			int controlID = GUIUtility.GetControlID(GUI.s_ScrollviewHash, FocusType.Passive);
			GUI.ScrollViewState scrollViewState = (GUI.ScrollViewState)GUIUtility.GetStateObject(typeof(GUI.ScrollViewState), controlID);
			if (scrollViewState.apply)
			{
				scrollPosition = scrollViewState.scrollPosition;
				scrollViewState.apply = false;
			}
			scrollViewState.position = position;
			scrollViewState.scrollPosition = scrollPosition;
			scrollViewState.visibleRect = (scrollViewState.viewRect = viewRect);
			scrollViewState.visibleRect.width = position.width;
			scrollViewState.visibleRect.height = position.height;
			GUI.s_ScrollViewStates.Push(scrollViewState);
			Rect rect = new Rect(position);
			EventType type = Event.current.type;
			if (type != EventType.Layout)
			{
				if (type != EventType.Used)
				{
					bool flag = alwaysShowVertical;
					bool flag2 = alwaysShowHorizontal;
					if (flag2 || viewRect.width > rect.width)
					{
						scrollViewState.visibleRect.height = position.height - horizontalScrollbar.fixedHeight + (float)horizontalScrollbar.margin.top;
						rect.height -= horizontalScrollbar.fixedHeight + (float)horizontalScrollbar.margin.top;
						flag2 = true;
					}
					if (flag || viewRect.height > rect.height)
					{
						scrollViewState.visibleRect.width = position.width - verticalScrollbar.fixedWidth + (float)verticalScrollbar.margin.left;
						rect.width -= verticalScrollbar.fixedWidth + (float)verticalScrollbar.margin.left;
						flag = true;
						if (!flag2 && viewRect.width > rect.width)
						{
							scrollViewState.visibleRect.height = position.height - horizontalScrollbar.fixedHeight + (float)horizontalScrollbar.margin.top;
							rect.height -= horizontalScrollbar.fixedHeight + (float)horizontalScrollbar.margin.top;
							flag2 = true;
						}
					}
					if (Event.current.type == EventType.Repaint && background != GUIStyle.none)
					{
						background.Draw(position, position.Contains(Event.current.mousePosition), false, flag2 && flag, false);
					}
					if (flag2 && horizontalScrollbar != GUIStyle.none)
					{
						scrollPosition.x = GUI.HorizontalScrollbar(new Rect(position.x, position.yMax - horizontalScrollbar.fixedHeight, rect.width, horizontalScrollbar.fixedHeight), scrollPosition.x, rect.width, 0f, viewRect.width, horizontalScrollbar);
					}
					else
					{
						GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Passive);
						GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
						GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
						if (horizontalScrollbar != GUIStyle.none)
						{
							scrollPosition.x = 0f;
						}
						else
						{
							scrollPosition.x = Mathf.Clamp(scrollPosition.x, 0f, Mathf.Max(viewRect.width - position.width, 0f));
						}
					}
					if (flag && verticalScrollbar != GUIStyle.none)
					{
						scrollPosition.y = GUI.VerticalScrollbar(new Rect(rect.xMax + (float)verticalScrollbar.margin.left, rect.y, verticalScrollbar.fixedWidth, rect.height), scrollPosition.y, rect.height, 0f, viewRect.height, verticalScrollbar);
					}
					else
					{
						GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Passive);
						GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
						GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
						if (verticalScrollbar != GUIStyle.none)
						{
							scrollPosition.y = 0f;
						}
						else
						{
							scrollPosition.y = Mathf.Clamp(scrollPosition.y, 0f, Mathf.Max(viewRect.height - position.height, 0f));
						}
					}
				}
			}
			else
			{
				GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Passive);
				GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
				GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
				GUIUtility.GetControlID(GUI.s_SliderHash, FocusType.Passive);
				GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
				GUIUtility.GetControlID(GUI.s_RepeatButtonHash, FocusType.Passive);
			}
			GUIClip.Push(rect, new Vector2(Mathf.Round(-scrollPosition.x - viewRect.x), Mathf.Round(-scrollPosition.y - viewRect.y)), Vector2.zero, false);
			return scrollPosition;
		}

		/// <summary>
		///   <para>Ends a scrollview started with a call to BeginScrollView.</para>
		/// </summary>
		/// <param name="handleScrollWheel"></param>
		// Token: 0x06001A98 RID: 6808 RVA: 0x0000998C File Offset: 0x00007B8C
		public static void EndScrollView()
		{
			GUI.EndScrollView(true);
		}

		/// <summary>
		///   <para>Ends a scrollview started with a call to BeginScrollView.</para>
		/// </summary>
		/// <param name="handleScrollWheel"></param>
		// Token: 0x06001A99 RID: 6809 RVA: 0x0001F000 File Offset: 0x0001D200
		public static void EndScrollView(bool handleScrollWheel)
		{
			GUIUtility.CheckOnGUI();
			GUI.ScrollViewState scrollViewState = (GUI.ScrollViewState)GUI.s_ScrollViewStates.Peek();
			GUIClip.Pop();
			GUI.s_ScrollViewStates.Pop();
			if (handleScrollWheel && Event.current.type == EventType.ScrollWheel && scrollViewState.position.Contains(Event.current.mousePosition))
			{
				scrollViewState.scrollPosition.x = Mathf.Clamp(scrollViewState.scrollPosition.x + Event.current.delta.x * 20f, 0f, scrollViewState.viewRect.width - scrollViewState.visibleRect.width);
				scrollViewState.scrollPosition.y = Mathf.Clamp(scrollViewState.scrollPosition.y + Event.current.delta.y * 20f, 0f, scrollViewState.viewRect.height - scrollViewState.visibleRect.height);
				scrollViewState.apply = true;
				Event.current.Use();
			}
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00009994 File Offset: 0x00007B94
		internal static GUI.ScrollViewState GetTopScrollView()
		{
			if (GUI.s_ScrollViewStates.Count != 0)
			{
				return (GUI.ScrollViewState)GUI.s_ScrollViewStates.Peek();
			}
			return null;
		}

		/// <summary>
		///   <para>Scrolls all enclosing scrollviews so they try to make position visible.</para>
		/// </summary>
		/// <param name="position"></param>
		// Token: 0x06001A9B RID: 6811 RVA: 0x0001F114 File Offset: 0x0001D314
		public static void ScrollTo(Rect position)
		{
			GUI.ScrollViewState topScrollView = GUI.GetTopScrollView();
			if (topScrollView != null)
			{
				topScrollView.ScrollTo(position);
			}
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0001F134 File Offset: 0x0001D334
		public static bool ScrollTowards(Rect position, float maxDelta)
		{
			GUI.ScrollViewState topScrollView = GUI.GetTopScrollView();
			return topScrollView != null && topScrollView.ScrollTowards(position, maxDelta);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x000099B6 File Offset: 0x00007BB6
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, string text)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(text), GUI.skin.window, GUI.skin, true);
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x000099DB File Offset: 0x00007BDB
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, Texture image)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(image), GUI.skin.window, GUI.skin, true);
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00009A00 File Offset: 0x00007C00
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, content, GUI.skin.window, GUI.skin, true);
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00009A20 File Offset: 0x00007C20
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, string text, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(text), style, GUI.skin, true);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00009A3D File Offset: 0x00007C3D
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, Texture image, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(image), style, GUI.skin, true);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00009A5A File Offset: 0x00007C5A
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, title, style, GUI.skin, true);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00009A72 File Offset: 0x00007C72
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, string text)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(text), GUI.skin.window, GUI.skin);
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00009A96 File Offset: 0x00007C96
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, Texture image)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(image), GUI.skin.window, GUI.skin);
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00009ABA File Offset: 0x00007CBA
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, content, GUI.skin.window, GUI.skin);
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00009AD9 File Offset: 0x00007CD9
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, string text, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(text), style, GUI.skin);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00009AF5 File Offset: 0x00007CF5
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, Texture image, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(image), style, GUI.skin);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00009B11 File Offset: 0x00007D11
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, content, style, GUI.skin);
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0001F158 File Offset: 0x0001D358
		internal static void CallWindowDelegate(GUI.WindowFunction func, int id, GUISkin _skin, int forceRect, float width, float height, GUIStyle style)
		{
			GUILayoutUtility.SelectIDList(id, true);
			GUISkin skin = GUI.skin;
			if (Event.current.type == EventType.Layout)
			{
				if (forceRect != 0)
				{
					GUILayoutOption[] array = new GUILayoutOption[]
					{
						GUILayout.Width(width),
						GUILayout.Height(height)
					};
					GUILayoutUtility.BeginWindow(id, style, array);
				}
				else
				{
					GUILayoutUtility.BeginWindow(id, style, null);
				}
			}
			GUI.skin = _skin;
			func(id);
			if (Event.current.type == EventType.Layout)
			{
				GUILayoutUtility.Layout();
			}
			GUI.skin = skin;
		}

		/// <summary>
		///   <para>If you want to have the entire window background to act as a drag area, use the version of DragWindow that takes no parameters and put it at the end of the window function.</para>
		/// </summary>
		// Token: 0x06001AAA RID: 6826 RVA: 0x00009B28 File Offset: 0x00007D28
		public static void DragWindow()
		{
			GUI.DragWindow(new Rect(0f, 0f, 10000f, 10000f));
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0001F1E4 File Offset: 0x0001D3E4
		internal static void BeginWindows(int skinMode, int editorWindowInstanceID)
		{
			GUILayoutGroup topLevel = GUILayoutUtility.current.topLevel;
			GenericStack layoutGroups = GUILayoutUtility.current.layoutGroups;
			GUILayoutGroup windows = GUILayoutUtility.current.windows;
			Matrix4x4 matrix = GUI.matrix;
			GUI.Internal_BeginWindows();
			GUI.matrix = matrix;
			GUILayoutUtility.current.topLevel = topLevel;
			GUILayoutUtility.current.layoutGroups = layoutGroups;
			GUILayoutUtility.current.windows = windows;
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0001F244 File Offset: 0x0001D444
		internal static void EndWindows()
		{
			GUILayoutGroup topLevel = GUILayoutUtility.current.topLevel;
			GenericStack layoutGroups = GUILayoutUtility.current.layoutGroups;
			GUILayoutGroup windows = GUILayoutUtility.current.windows;
			GUI.Internal_EndWindows();
			GUILayoutUtility.current.topLevel = topLevel;
			GUILayoutUtility.current.layoutGroups = layoutGroups;
			GUILayoutUtility.current.windows = windows;
		}

		/// <summary>
		///   <para>Global tinting color for the GUI.</para>
		/// </summary>
		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x0001F298 File Offset: 0x0001D498
		// (set) Token: 0x06001AAE RID: 6830 RVA: 0x00009B48 File Offset: 0x00007D48
		public static Color color
		{
			get
			{
				Color color;
				GUI.INTERNAL_get_color(out color);
				return color;
			}
			set
			{
				GUI.INTERNAL_set_color(ref value);
			}
		}

		// Token: 0x06001AAF RID: 6831
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_color(out Color value);

		// Token: 0x06001AB0 RID: 6832
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_color(ref Color value);

		/// <summary>
		///   <para>Global tinting color for all background elements rendered by the GUI.</para>
		/// </summary>
		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x0001F2B0 File Offset: 0x0001D4B0
		// (set) Token: 0x06001AB2 RID: 6834 RVA: 0x00009B51 File Offset: 0x00007D51
		public static Color backgroundColor
		{
			get
			{
				Color color;
				GUI.INTERNAL_get_backgroundColor(out color);
				return color;
			}
			set
			{
				GUI.INTERNAL_set_backgroundColor(ref value);
			}
		}

		// Token: 0x06001AB3 RID: 6835
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_backgroundColor(out Color value);

		// Token: 0x06001AB4 RID: 6836
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_backgroundColor(ref Color value);

		/// <summary>
		///   <para>Tinting color for all text rendered by the GUI.</para>
		/// </summary>
		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x0001F2C8 File Offset: 0x0001D4C8
		// (set) Token: 0x06001AB6 RID: 6838 RVA: 0x00009B5A File Offset: 0x00007D5A
		public static Color contentColor
		{
			get
			{
				Color color;
				GUI.INTERNAL_get_contentColor(out color);
				return color;
			}
			set
			{
				GUI.INTERNAL_set_contentColor(ref value);
			}
		}

		// Token: 0x06001AB7 RID: 6839
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_contentColor(out Color value);

		// Token: 0x06001AB8 RID: 6840
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_contentColor(ref Color value);

		/// <summary>
		///   <para>Returns true if any controls changed the value of the input data.</para>
		/// </summary>
		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001AB9 RID: 6841
		// (set) Token: 0x06001ABA RID: 6842
		public static extern bool changed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is the GUI enabled?</para>
		/// </summary>
		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001ABB RID: 6843
		// (set) Token: 0x06001ABC RID: 6844
		public static extern bool enabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001ABD RID: 6845
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_GetTooltip();

		// Token: 0x06001ABE RID: 6846
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetTooltip(string value);

		// Token: 0x06001ABF RID: 6847
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_GetMouseTooltip();

		/// <summary>
		///   <para>The sorting depth of the currently executing GUI behaviour.</para>
		/// </summary>
		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001AC0 RID: 6848
		// (set) Token: 0x06001AC1 RID: 6849
		public static extern int depth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00009B63 File Offset: 0x00007D63
		private static void DoLabel(Rect position, GUIContent content, IntPtr style)
		{
			GUI.INTERNAL_CALL_DoLabel(ref position, content, style);
		}

		// Token: 0x06001AC3 RID: 6851
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DoLabel(ref Rect position, GUIContent content, IntPtr style);

		// Token: 0x06001AC4 RID: 6852
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitializeGUIClipTexture();

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001AC5 RID: 6853
		private static extern Material blendMaterial
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001AC6 RID: 6854
		private static extern Material blitMaterial
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00009B6E File Offset: 0x00007D6E
		private static bool DoButton(Rect position, GUIContent content, IntPtr style)
		{
			return GUI.INTERNAL_CALL_DoButton(ref position, content, style);
		}

		// Token: 0x06001AC8 RID: 6856
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_DoButton(ref Rect position, GUIContent content, IntPtr style);

		/// <summary>
		///   <para>Set the name of the next control.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x06001AC9 RID: 6857
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetNextControlName(string name);

		/// <summary>
		///   <para>Get the name of named control that has focus.</para>
		/// </summary>
		// Token: 0x06001ACA RID: 6858
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetNameOfFocusedControl();

		/// <summary>
		///   <para>Move keyboard focus to a named control.</para>
		/// </summary>
		/// <param name="name">Name set using SetNextControlName.</param>
		// Token: 0x06001ACB RID: 6859
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FocusControl(string name);

		// Token: 0x06001ACC RID: 6860 RVA: 0x00009B79 File Offset: 0x00007D79
		internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, IntPtr style)
		{
			return GUI.INTERNAL_CALL_DoToggle(ref position, id, value, content, style);
		}

		// Token: 0x06001ACD RID: 6861
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_DoToggle(ref Rect position, int id, bool value, GUIContent content, IntPtr style);

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001ACE RID: 6862
		internal static extern bool usePageScrollbars
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06001ACF RID: 6863
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalRepaintEditorWindow();

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00009B87 File Offset: 0x00007D87
		private static Rect DoModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUISkin skin)
		{
			return GUI.INTERNAL_CALL_DoModalWindow(id, ref clientRect, func, content, style, skin);
		}

		// Token: 0x06001AD1 RID: 6865
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Rect INTERNAL_CALL_DoModalWindow(int id, ref Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUISkin skin);

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00009B97 File Offset: 0x00007D97
		private static Rect DoWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout)
		{
			return GUI.INTERNAL_CALL_DoWindow(id, ref clientRect, func, title, style, skin, forceRectOnLayout);
		}

		// Token: 0x06001AD3 RID: 6867
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Rect INTERNAL_CALL_DoWindow(int id, ref Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout);

		/// <summary>
		///   <para>Make a window draggable.</para>
		/// </summary>
		/// <param name="position">The part of the window that can be dragged. This is clipped to the actual window.</param>
		// Token: 0x06001AD4 RID: 6868 RVA: 0x00009BA9 File Offset: 0x00007DA9
		public static void DragWindow(Rect position)
		{
			GUI.INTERNAL_CALL_DragWindow(ref position);
		}

		// Token: 0x06001AD5 RID: 6869
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DragWindow(ref Rect position);

		/// <summary>
		///   <para>Bring a specific window to front of the floating windows.</para>
		/// </summary>
		/// <param name="windowID">The identifier used when you created the window in the Window call.</param>
		// Token: 0x06001AD6 RID: 6870
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BringWindowToFront(int windowID);

		/// <summary>
		///   <para>Bring a specific window to back of the floating windows.</para>
		/// </summary>
		/// <param name="windowID">The identifier used when you created the window in the Window call.</param>
		// Token: 0x06001AD7 RID: 6871
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BringWindowToBack(int windowID);

		/// <summary>
		///   <para>Make a window become the active window.</para>
		/// </summary>
		/// <param name="windowID">The identifier used when you created the window in the Window call.</param>
		// Token: 0x06001AD8 RID: 6872
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FocusWindow(int windowID);

		/// <summary>
		///   <para>Remove focus from all windows.</para>
		/// </summary>
		// Token: 0x06001AD9 RID: 6873
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnfocusWindow();

		// Token: 0x06001ADA RID: 6874
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_BeginWindows();

		// Token: 0x06001ADB RID: 6875
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_EndWindows();

		// Token: 0x040006E5 RID: 1765
		private static float s_ScrollStepSize = 10f;

		// Token: 0x040006E6 RID: 1766
		private static int s_ScrollControlId;

		// Token: 0x040006E7 RID: 1767
		private static int s_HotTextField = -1;

		// Token: 0x040006E8 RID: 1768
		private static readonly int s_BoxHash = "Box".GetHashCode();

		// Token: 0x040006E9 RID: 1769
		private static readonly int s_RepeatButtonHash = "repeatButton".GetHashCode();

		// Token: 0x040006EA RID: 1770
		private static readonly int s_ToggleHash = "Toggle".GetHashCode();

		// Token: 0x040006EB RID: 1771
		private static readonly int s_ButtonGridHash = "ButtonGrid".GetHashCode();

		// Token: 0x040006EC RID: 1772
		private static readonly int s_SliderHash = "Slider".GetHashCode();

		// Token: 0x040006ED RID: 1773
		private static readonly int s_BeginGroupHash = "BeginGroup".GetHashCode();

		// Token: 0x040006EE RID: 1774
		private static readonly int s_ScrollviewHash = "scrollView".GetHashCode();

		// Token: 0x040006EF RID: 1775
		private static GUISkin s_Skin;

		// Token: 0x040006F0 RID: 1776
		internal static Rect s_ToolTipRect;

		// Token: 0x040006F1 RID: 1777
		private static GenericStack s_ScrollViewStates = new GenericStack();

		// Token: 0x020001C8 RID: 456
		internal sealed class ScrollViewState
		{
			// Token: 0x06001ADD RID: 6877 RVA: 0x00009BB2 File Offset: 0x00007DB2
			internal void ScrollTo(Rect position)
			{
				this.ScrollTowards(position, float.PositiveInfinity);
			}

			// Token: 0x06001ADE RID: 6878 RVA: 0x0001F2E0 File Offset: 0x0001D4E0
			internal bool ScrollTowards(Rect position, float maxDelta)
			{
				Vector2 vector = this.ScrollNeeded(position);
				if (vector.sqrMagnitude < 0.0001f)
				{
					return false;
				}
				if (maxDelta == 0f)
				{
					return true;
				}
				if (vector.magnitude > maxDelta)
				{
					vector = vector.normalized * maxDelta;
				}
				this.scrollPosition += vector;
				this.apply = true;
				return true;
			}

			// Token: 0x06001ADF RID: 6879 RVA: 0x0001F34C File Offset: 0x0001D54C
			internal Vector2 ScrollNeeded(Rect position)
			{
				Rect rect = this.visibleRect;
				rect.x += this.scrollPosition.x;
				rect.y += this.scrollPosition.y;
				float num = position.width - this.visibleRect.width;
				if (num > 0f)
				{
					position.width -= num;
					position.x += num * 0.5f;
				}
				num = position.height - this.visibleRect.height;
				if (num > 0f)
				{
					position.height -= num;
					position.y += num * 0.5f;
				}
				Vector2 zero = Vector2.zero;
				if (position.xMax > rect.xMax)
				{
					zero.x += position.xMax - rect.xMax;
				}
				else if (position.xMin < rect.xMin)
				{
					zero.x -= rect.xMin - position.xMin;
				}
				if (position.yMax > rect.yMax)
				{
					zero.y += position.yMax - rect.yMax;
				}
				else if (position.yMin < rect.yMin)
				{
					zero.y -= rect.yMin - position.yMin;
				}
				Rect rect2 = this.viewRect;
				rect2.width = Mathf.Max(rect2.width, this.visibleRect.width);
				rect2.height = Mathf.Max(rect2.height, this.visibleRect.height);
				zero.x = Mathf.Clamp(zero.x, rect2.xMin - this.scrollPosition.x, rect2.xMax - this.visibleRect.width - this.scrollPosition.x);
				zero.y = Mathf.Clamp(zero.y, rect2.yMin - this.scrollPosition.y, rect2.yMax - this.visibleRect.height - this.scrollPosition.y);
				return zero;
			}

			// Token: 0x040006F4 RID: 1780
			public Rect position;

			// Token: 0x040006F5 RID: 1781
			public Rect visibleRect;

			// Token: 0x040006F6 RID: 1782
			public Rect viewRect;

			// Token: 0x040006F7 RID: 1783
			public Vector2 scrollPosition;

			// Token: 0x040006F8 RID: 1784
			public bool apply;

			// Token: 0x040006F9 RID: 1785
			public bool hasScrollTo;
		}

		// Token: 0x020001C9 RID: 457
		public abstract class Scope : IDisposable
		{
			// Token: 0x06001AE1 RID: 6881
			protected abstract void CloseScope();

			// Token: 0x06001AE2 RID: 6882 RVA: 0x0001F5B8 File Offset: 0x0001D7B8
			~Scope()
			{
				if (!this.m_Disposed)
				{
					Debug.LogError("Scope was not disposed! You should use the 'using' keyword or manually call Dispose.");
					this.Dispose();
				}
			}

			// Token: 0x06001AE3 RID: 6883 RVA: 0x00009BC1 File Offset: 0x00007DC1
			public void Dispose()
			{
				if (this.m_Disposed)
				{
					return;
				}
				this.m_Disposed = true;
				this.CloseScope();
			}

			// Token: 0x040006FA RID: 1786
			private bool m_Disposed;
		}

		/// <summary>
		///   <para>Disposable helper class for managing BeginGroup / EndGroup.</para>
		/// </summary>
		// Token: 0x020001CA RID: 458
		public class GroupScope : GUI.Scope
		{
			/// <summary>
			///   <para>Create a new GroupScope and begin the corresponding group.</para>
			/// </summary>
			/// <param name="position">Rectangle on the screen to use for the group.</param>
			/// <param name="text">Text to display on the group.</param>
			/// <param name="image">Texture to display on the group.</param>
			/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
			/// <param name="style">The style to use for the background.</param>
			// Token: 0x06001AE4 RID: 6884 RVA: 0x00009BDC File Offset: 0x00007DDC
			public GroupScope(Rect position)
			{
				GUI.BeginGroup(position);
			}

			/// <summary>
			///   <para>Create a new GroupScope and begin the corresponding group.</para>
			/// </summary>
			/// <param name="position">Rectangle on the screen to use for the group.</param>
			/// <param name="text">Text to display on the group.</param>
			/// <param name="image">Texture to display on the group.</param>
			/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
			/// <param name="style">The style to use for the background.</param>
			// Token: 0x06001AE5 RID: 6885 RVA: 0x00009BEA File Offset: 0x00007DEA
			public GroupScope(Rect position, string text)
			{
				GUI.BeginGroup(position, text);
			}

			/// <summary>
			///   <para>Create a new GroupScope and begin the corresponding group.</para>
			/// </summary>
			/// <param name="position">Rectangle on the screen to use for the group.</param>
			/// <param name="text">Text to display on the group.</param>
			/// <param name="image">Texture to display on the group.</param>
			/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
			/// <param name="style">The style to use for the background.</param>
			// Token: 0x06001AE6 RID: 6886 RVA: 0x00009BF9 File Offset: 0x00007DF9
			public GroupScope(Rect position, Texture image)
			{
				GUI.BeginGroup(position, image);
			}

			/// <summary>
			///   <para>Create a new GroupScope and begin the corresponding group.</para>
			/// </summary>
			/// <param name="position">Rectangle on the screen to use for the group.</param>
			/// <param name="text">Text to display on the group.</param>
			/// <param name="image">Texture to display on the group.</param>
			/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
			/// <param name="style">The style to use for the background.</param>
			// Token: 0x06001AE7 RID: 6887 RVA: 0x00009C08 File Offset: 0x00007E08
			public GroupScope(Rect position, GUIContent content)
			{
				GUI.BeginGroup(position, content);
			}

			/// <summary>
			///   <para>Create a new GroupScope and begin the corresponding group.</para>
			/// </summary>
			/// <param name="position">Rectangle on the screen to use for the group.</param>
			/// <param name="text">Text to display on the group.</param>
			/// <param name="image">Texture to display on the group.</param>
			/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
			/// <param name="style">The style to use for the background.</param>
			// Token: 0x06001AE8 RID: 6888 RVA: 0x00009C17 File Offset: 0x00007E17
			public GroupScope(Rect position, GUIStyle style)
			{
				GUI.BeginGroup(position, style);
			}

			/// <summary>
			///   <para>Create a new GroupScope and begin the corresponding group.</para>
			/// </summary>
			/// <param name="position">Rectangle on the screen to use for the group.</param>
			/// <param name="text">Text to display on the group.</param>
			/// <param name="image">Texture to display on the group.</param>
			/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
			/// <param name="style">The style to use for the background.</param>
			// Token: 0x06001AE9 RID: 6889 RVA: 0x00009C26 File Offset: 0x00007E26
			public GroupScope(Rect position, string text, GUIStyle style)
			{
				GUI.BeginGroup(position, text, style);
			}

			/// <summary>
			///   <para>Create a new GroupScope and begin the corresponding group.</para>
			/// </summary>
			/// <param name="position">Rectangle on the screen to use for the group.</param>
			/// <param name="text">Text to display on the group.</param>
			/// <param name="image">Texture to display on the group.</param>
			/// <param name="content">Text, image and tooltip for this group. If supplied, any mouse clicks are "captured" by the group and not If left out, no background is rendered, and mouse clicks are passed.</param>
			/// <param name="style">The style to use for the background.</param>
			// Token: 0x06001AEA RID: 6890 RVA: 0x00009C36 File Offset: 0x00007E36
			public GroupScope(Rect position, Texture image, GUIStyle style)
			{
				GUI.BeginGroup(position, image, style);
			}

			// Token: 0x06001AEB RID: 6891 RVA: 0x00009C46 File Offset: 0x00007E46
			protected override void CloseScope()
			{
				GUI.EndGroup();
			}
		}

		/// <summary>
		///   <para>Disposable helper class for managing BeginScrollView / EndScrollView.</para>
		/// </summary>
		// Token: 0x020001CB RID: 459
		public class ScrollViewScope : GUI.Scope
		{
			/// <summary>
			///   <para>Create a new ScrollViewScope and begin the corresponding ScrollView.</para>
			/// </summary>
			/// <param name="position">Rectangle on the screen to use for the ScrollView.</param>
			/// <param name="scrollPosition">The pixel distance that the view is scrolled in the X and Y directions.</param>
			/// <param name="viewRect">The rectangle used inside the scrollview.</param>
			/// <param name="alwaysShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when clientRect is wider than position.</param>
			/// <param name="alwaysShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when clientRect is taller than position.</param>
			/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
			/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
			// Token: 0x06001AEC RID: 6892 RVA: 0x00009C4D File Offset: 0x00007E4D
			public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUI.BeginScrollView(position, scrollPosition, viewRect);
			}

			/// <summary>
			///   <para>Create a new ScrollViewScope and begin the corresponding ScrollView.</para>
			/// </summary>
			/// <param name="position">Rectangle on the screen to use for the ScrollView.</param>
			/// <param name="scrollPosition">The pixel distance that the view is scrolled in the X and Y directions.</param>
			/// <param name="viewRect">The rectangle used inside the scrollview.</param>
			/// <param name="alwaysShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when clientRect is wider than position.</param>
			/// <param name="alwaysShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when clientRect is taller than position.</param>
			/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
			/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
			// Token: 0x06001AED RID: 6893 RVA: 0x00009C6A File Offset: 0x00007E6A
			public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical);
			}

			/// <summary>
			///   <para>Create a new ScrollViewScope and begin the corresponding ScrollView.</para>
			/// </summary>
			/// <param name="position">Rectangle on the screen to use for the ScrollView.</param>
			/// <param name="scrollPosition">The pixel distance that the view is scrolled in the X and Y directions.</param>
			/// <param name="viewRect">The rectangle used inside the scrollview.</param>
			/// <param name="alwaysShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when clientRect is wider than position.</param>
			/// <param name="alwaysShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when clientRect is taller than position.</param>
			/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
			/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
			// Token: 0x06001AEE RID: 6894 RVA: 0x00009C8B File Offset: 0x00007E8B
			public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUI.BeginScrollView(position, scrollPosition, viewRect, horizontalScrollbar, verticalScrollbar);
			}

			/// <summary>
			///   <para>Create a new ScrollViewScope and begin the corresponding ScrollView.</para>
			/// </summary>
			/// <param name="position">Rectangle on the screen to use for the ScrollView.</param>
			/// <param name="scrollPosition">The pixel distance that the view is scrolled in the X and Y directions.</param>
			/// <param name="viewRect">The rectangle used inside the scrollview.</param>
			/// <param name="alwaysShowHorizontal">Optional parameter to always show the horizontal scrollbar. If false or left out, it is only shown when clientRect is wider than position.</param>
			/// <param name="alwaysShowVertical">Optional parameter to always show the vertical scrollbar. If false or left out, it is only shown when clientRect is taller than position.</param>
			/// <param name="horizontalScrollbar">Optional GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.</param>
			/// <param name="verticalScrollbar">Optional GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.</param>
			// Token: 0x06001AEF RID: 6895 RVA: 0x00009CAC File Offset: 0x00007EAC
			public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar);
			}

			// Token: 0x06001AF0 RID: 6896 RVA: 0x0001F5FC File Offset: 0x0001D7FC
			internal ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
			{
				this.handleScrollWheel = true;
				this.scrollPosition = GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background);
			}

			/// <summary>
			///   <para>The modified scrollPosition. Feed this back into the variable you pass in, as shown in the example.</para>
			/// </summary>
			// Token: 0x1700073F RID: 1855
			// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x00009CD1 File Offset: 0x00007ED1
			// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x00009CD9 File Offset: 0x00007ED9
			public Vector2 scrollPosition { get; private set; }

			/// <summary>
			///   <para>Whether this ScrollView should handle scroll wheel events. (default: true).</para>
			/// </summary>
			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x00009CE2 File Offset: 0x00007EE2
			// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x00009CEA File Offset: 0x00007EEA
			public bool handleScrollWheel { get; set; }

			// Token: 0x06001AF5 RID: 6901 RVA: 0x00009CF3 File Offset: 0x00007EF3
			protected override void CloseScope()
			{
				GUI.EndScrollView(this.handleScrollWheel);
			}
		}

		// Token: 0x020001CC RID: 460
		public class ClipScope : GUI.Scope
		{
			// Token: 0x06001AF6 RID: 6902 RVA: 0x00009D00 File Offset: 0x00007F00
			public ClipScope(Rect position)
			{
				GUI.BeginClip(position);
			}

			// Token: 0x06001AF7 RID: 6903 RVA: 0x00009D0E File Offset: 0x00007F0E
			protected override void CloseScope()
			{
				GUI.EndClip();
			}
		}

		/// <summary>
		///   <para>Callback to draw GUI within a window (used with GUI.Window).</para>
		/// </summary>
		/// <param name="id"></param>
		// Token: 0x020001CD RID: 461
		// (Invoke) Token: 0x06001AF9 RID: 6905
		public delegate void WindowFunction(int id);
	}
}
