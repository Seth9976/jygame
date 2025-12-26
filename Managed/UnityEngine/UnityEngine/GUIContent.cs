using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The contents of a GUI element.</para>
	/// </summary>
	// Token: 0x020001CE RID: 462
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class GUIContent
	{
		/// <summary>
		///   <para>Constructor for GUIContent in all shapes and sizes.</para>
		/// </summary>
		// Token: 0x06001AFC RID: 6908 RVA: 0x00009D15 File Offset: 0x00007F15
		public GUIContent()
		{
		}

		/// <summary>
		///   <para>Build a GUIContent object containing only text.</para>
		/// </summary>
		/// <param name="text"></param>
		// Token: 0x06001AFD RID: 6909 RVA: 0x00009D33 File Offset: 0x00007F33
		public GUIContent(string text)
		{
			this.m_Text = text;
		}

		/// <summary>
		///   <para>Build a GUIContent object containing only an image.</para>
		/// </summary>
		/// <param name="image"></param>
		// Token: 0x06001AFE RID: 6910 RVA: 0x00009D58 File Offset: 0x00007F58
		public GUIContent(Texture image)
		{
			this.m_Image = image;
		}

		/// <summary>
		///   <para>Build a GUIContent object containing both text and an image.</para>
		/// </summary>
		/// <param name="text"></param>
		/// <param name="image"></param>
		// Token: 0x06001AFF RID: 6911 RVA: 0x00009D7D File Offset: 0x00007F7D
		public GUIContent(string text, Texture image)
		{
			this.m_Text = text;
			this.m_Image = image;
		}

		/// <summary>
		///   <para>Build a GUIContent containing some text. When the user hovers the mouse over it, the global GUI.tooltip is set to the tooltip.</para>
		/// </summary>
		/// <param name="text"></param>
		/// <param name="tooltip"></param>
		// Token: 0x06001B00 RID: 6912 RVA: 0x00009DA9 File Offset: 0x00007FA9
		public GUIContent(string text, string tooltip)
		{
			this.m_Text = text;
			this.m_Tooltip = tooltip;
		}

		/// <summary>
		///   <para>Build a GUIContent containing an image. When the user hovers the mouse over it, the global GUI.tooltip is set to the tooltip.</para>
		/// </summary>
		/// <param name="image"></param>
		/// <param name="tooltip"></param>
		// Token: 0x06001B01 RID: 6913 RVA: 0x00009DD5 File Offset: 0x00007FD5
		public GUIContent(Texture image, string tooltip)
		{
			this.m_Image = image;
			this.m_Tooltip = tooltip;
		}

		/// <summary>
		///   <para>Build a GUIContent that contains both text, an image and has a tooltip defined. When the user hovers the mouse over it, the global GUI.tooltip is set to the tooltip.</para>
		/// </summary>
		/// <param name="text"></param>
		/// <param name="image"></param>
		/// <param name="tooltip"></param>
		// Token: 0x06001B02 RID: 6914 RVA: 0x00009E01 File Offset: 0x00008001
		public GUIContent(string text, Texture image, string tooltip)
		{
			this.m_Text = text;
			this.m_Image = image;
			this.m_Tooltip = tooltip;
		}

		/// <summary>
		///   <para>Build a GUIContent as a copy of another GUIContent.</para>
		/// </summary>
		/// <param name="src"></param>
		// Token: 0x06001B03 RID: 6915 RVA: 0x0001F630 File Offset: 0x0001D830
		public GUIContent(GUIContent src)
		{
			this.m_Text = src.m_Text;
			this.m_Image = src.m_Image;
			this.m_Tooltip = src.m_Tooltip;
		}

		/// <summary>
		///   <para>The text contained.</para>
		/// </summary>
		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x00009E63 File Offset: 0x00008063
		// (set) Token: 0x06001B06 RID: 6918 RVA: 0x00009E6B File Offset: 0x0000806B
		public string text
		{
			get
			{
				return this.m_Text;
			}
			set
			{
				this.m_Text = value;
			}
		}

		/// <summary>
		///   <para>The icon image contained.</para>
		/// </summary>
		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x00009E74 File Offset: 0x00008074
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x00009E7C File Offset: 0x0000807C
		public Texture image
		{
			get
			{
				return this.m_Image;
			}
			set
			{
				this.m_Image = value;
			}
		}

		/// <summary>
		///   <para>The tooltip of this element.</para>
		/// </summary>
		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x00009E85 File Offset: 0x00008085
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x00009E8D File Offset: 0x0000808D
		public string tooltip
		{
			get
			{
				return this.m_Tooltip;
			}
			set
			{
				this.m_Tooltip = value;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x0001F680 File Offset: 0x0001D880
		internal int hash
		{
			get
			{
				int num = 0;
				if (!string.IsNullOrEmpty(this.m_Text))
				{
					num = this.m_Text.GetHashCode() * 37;
				}
				return num;
			}
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00009E96 File Offset: 0x00008096
		internal static GUIContent Temp(string t)
		{
			GUIContent.s_Text.m_Text = t;
			GUIContent.s_Text.m_Tooltip = string.Empty;
			return GUIContent.s_Text;
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x00009EB7 File Offset: 0x000080B7
		internal static GUIContent Temp(string t, string tooltip)
		{
			GUIContent.s_Text.m_Text = t;
			GUIContent.s_Text.m_Tooltip = tooltip;
			return GUIContent.s_Text;
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00009ED4 File Offset: 0x000080D4
		internal static GUIContent Temp(Texture i)
		{
			GUIContent.s_Image.m_Image = i;
			GUIContent.s_Image.m_Tooltip = string.Empty;
			return GUIContent.s_Image;
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x00009EF5 File Offset: 0x000080F5
		internal static GUIContent Temp(Texture i, string tooltip)
		{
			GUIContent.s_Image.m_Image = i;
			GUIContent.s_Image.m_Tooltip = tooltip;
			return GUIContent.s_Image;
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x00009F12 File Offset: 0x00008112
		internal static GUIContent Temp(string t, Texture i)
		{
			GUIContent.s_TextImage.m_Text = t;
			GUIContent.s_TextImage.m_Image = i;
			return GUIContent.s_TextImage;
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0001F6B0 File Offset: 0x0001D8B0
		internal static void ClearStaticCache()
		{
			GUIContent.s_Text.m_Text = null;
			GUIContent.s_Text.m_Tooltip = string.Empty;
			GUIContent.s_Image.m_Image = null;
			GUIContent.s_Image.m_Tooltip = string.Empty;
			GUIContent.s_TextImage.m_Text = null;
			GUIContent.s_TextImage.m_Image = null;
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0001F708 File Offset: 0x0001D908
		internal static GUIContent[] Temp(string[] texts)
		{
			GUIContent[] array = new GUIContent[texts.Length];
			for (int i = 0; i < texts.Length; i++)
			{
				array[i] = new GUIContent(texts[i]);
			}
			return array;
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0001F740 File Offset: 0x0001D940
		internal static GUIContent[] Temp(Texture[] images)
		{
			GUIContent[] array = new GUIContent[images.Length];
			for (int i = 0; i < images.Length; i++)
			{
				array[i] = new GUIContent(images[i]);
			}
			return array;
		}

		// Token: 0x040006FD RID: 1789
		[SerializeField]
		private string m_Text = string.Empty;

		// Token: 0x040006FE RID: 1790
		[SerializeField]
		private Texture m_Image;

		// Token: 0x040006FF RID: 1791
		[SerializeField]
		private string m_Tooltip = string.Empty;

		// Token: 0x04000700 RID: 1792
		private static readonly GUIContent s_Text = new GUIContent();

		// Token: 0x04000701 RID: 1793
		private static readonly GUIContent s_Image = new GUIContent();

		// Token: 0x04000702 RID: 1794
		private static readonly GUIContent s_TextImage = new GUIContent();

		/// <summary>
		///   <para>Shorthand for empty content.</para>
		/// </summary>
		// Token: 0x04000703 RID: 1795
		public static GUIContent none = new GUIContent(string.Empty);
	}
}
