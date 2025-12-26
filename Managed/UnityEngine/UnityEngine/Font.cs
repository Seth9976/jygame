using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Script interface for.</para>
	/// </summary>
	// Token: 0x020001B4 RID: 436
	public sealed class Font : Object
	{
		/// <summary>
		///   <para>Create a new Font.</para>
		/// </summary>
		/// <param name="name">The name of the created Font object.</param>
		// Token: 0x0600192B RID: 6443 RVA: 0x00008E2F File Offset: 0x0000702F
		public Font()
		{
			Font.Internal_CreateFont(this, null);
		}

		/// <summary>
		///   <para>Create a new Font.</para>
		/// </summary>
		/// <param name="name">The name of the created Font object.</param>
		// Token: 0x0600192C RID: 6444 RVA: 0x00008E3E File Offset: 0x0000703E
		public Font(string name)
		{
			Font.Internal_CreateFont(this, name);
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00008E4D File Offset: 0x0000704D
		private Font(string[] names, int size)
		{
			Font.Internal_CreateDynamicFont(this, names, size);
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600192E RID: 6446 RVA: 0x00008E5D File Offset: 0x0000705D
		// (remove) Token: 0x0600192F RID: 6447 RVA: 0x00008E74 File Offset: 0x00007074
		public static event Action<Font> textureRebuilt;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06001930 RID: 6448 RVA: 0x00008E8B File Offset: 0x0000708B
		// (remove) Token: 0x06001931 RID: 6449 RVA: 0x00008EA4 File Offset: 0x000070A4
		private event Font.FontTextureRebuildCallback m_FontTextureRebuildCallback;

		/// <summary>
		///   <para>Get names of fonts installed on the machine.</para>
		/// </summary>
		/// <returns>
		///   <para>An array of the names of all fonts installed on the machine.</para>
		/// </returns>
		// Token: 0x06001932 RID: 6450
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string[] GetOSInstalledFontNames();

		// Token: 0x06001933 RID: 6451
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateFont([Writable] Font _font, string name);

		// Token: 0x06001934 RID: 6452
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateDynamicFont([Writable] Font _font, string[] _names, int size);

		/// <summary>
		///   <para>Creates a Font object which lets you render a font installed on the user machine.</para>
		/// </summary>
		/// <param name="fontname">The name of the OS font to use for this font object.</param>
		/// <param name="size">The default character size of the generated font.</param>
		/// <param name="fontnames">Am array of names of OS fonts to use for this font object. When rendering characters using this font object, the first font which is installed on the machine, which contains the requested character will be used.</param>
		/// <returns>
		///   <para>The generate Font object.</para>
		/// </returns>
		// Token: 0x06001935 RID: 6453 RVA: 0x0001BA24 File Offset: 0x00019C24
		public static Font CreateDynamicFontFromOSFont(string fontname, int size)
		{
			return new Font(new string[] { fontname }, size);
		}

		/// <summary>
		///   <para>Creates a Font object which lets you render a font installed on the user machine.</para>
		/// </summary>
		/// <param name="fontname">The name of the OS font to use for this font object.</param>
		/// <param name="size">The default character size of the generated font.</param>
		/// <param name="fontnames">Am array of names of OS fonts to use for this font object. When rendering characters using this font object, the first font which is installed on the machine, which contains the requested character will be used.</param>
		/// <returns>
		///   <para>The generate Font object.</para>
		/// </returns>
		// Token: 0x06001936 RID: 6454 RVA: 0x0001BA44 File Offset: 0x00019C44
		public static Font CreateDynamicFontFromOSFont(string[] fontnames, int size)
		{
			return new Font(fontnames, size);
		}

		/// <summary>
		///   <para>The material used for the font display.</para>
		/// </summary>
		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001937 RID: 6455
		// (set) Token: 0x06001938 RID: 6456
		public extern Material material
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Does this font have a specific character?</para>
		/// </summary>
		/// <param name="c">The character to check for.</param>
		/// <returns>
		///   <para>Whether or not the font has the character specified.</para>
		/// </returns>
		// Token: 0x06001939 RID: 6457
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool HasCharacter(char c);

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600193A RID: 6458
		// (set) Token: 0x0600193B RID: 6459
		public extern string[] fontNames
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Access an array of all characters contained in the font texture.</para>
		/// </summary>
		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600193C RID: 6460
		// (set) Token: 0x0600193D RID: 6461
		public extern CharacterInfo[] characterInfo
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Request characters to be added to the font texture (dynamic fonts only).</para>
		/// </summary>
		/// <param name="characters">The characters which are needed to be in the font texture.</param>
		/// <param name="size">The size of the requested characters (the default value of zero will use the font's default size).</param>
		/// <param name="style">The style of the requested characters.</param>
		// Token: 0x0600193E RID: 6462
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RequestCharactersInTexture(string characters, [UnityEngine.Internal.DefaultValue("0")] int size, [UnityEngine.Internal.DefaultValue("FontStyle.Normal")] FontStyle style);

		// Token: 0x0600193F RID: 6463 RVA: 0x0001BA5C File Offset: 0x00019C5C
		[ExcludeFromDocs]
		public void RequestCharactersInTexture(string characters, int size)
		{
			FontStyle fontStyle = FontStyle.Normal;
			this.RequestCharactersInTexture(characters, size, fontStyle);
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0001BA74 File Offset: 0x00019C74
		[ExcludeFromDocs]
		public void RequestCharactersInTexture(string characters)
		{
			FontStyle fontStyle = FontStyle.Normal;
			int num = 0;
			this.RequestCharactersInTexture(characters, num, fontStyle);
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x0001BA90 File Offset: 0x00019C90
		private static void InvokeTextureRebuilt_Internal(Font font)
		{
			Action<Font> action = Font.textureRebuilt;
			if (action != null)
			{
				action(font);
			}
			if (font.m_FontTextureRebuildCallback != null)
			{
				font.m_FontTextureRebuildCallback();
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x00008EBD File Offset: 0x000070BD
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x00008EC5 File Offset: 0x000070C5
		[Obsolete("Font.textureRebuildCallback has been deprecated. Use Font.textureRebuilt instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Font.FontTextureRebuildCallback textureRebuildCallback
		{
			get
			{
				return this.m_FontTextureRebuildCallback;
			}
			set
			{
				this.m_FontTextureRebuildCallback = value;
			}
		}

		/// <summary>
		///   <para>Returns the maximum number of verts that the text generator may return for a given string.</para>
		/// </summary>
		/// <param name="str">Input string.</param>
		// Token: 0x06001944 RID: 6468 RVA: 0x00008ECE File Offset: 0x000070CE
		public static int GetMaxVertsForString(string str)
		{
			return str.Length * 4 + 4;
		}

		// Token: 0x06001945 RID: 6469
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool GetCharacterInfo(char ch, out CharacterInfo info, [UnityEngine.Internal.DefaultValue("0")] int size, [UnityEngine.Internal.DefaultValue("FontStyle.Normal")] FontStyle style);

		// Token: 0x06001946 RID: 6470 RVA: 0x0001BAC8 File Offset: 0x00019CC8
		[ExcludeFromDocs]
		public bool GetCharacterInfo(char ch, out CharacterInfo info, int size)
		{
			FontStyle fontStyle = FontStyle.Normal;
			return this.GetCharacterInfo(ch, out info, size, fontStyle);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0001BAE4 File Offset: 0x00019CE4
		[ExcludeFromDocs]
		public bool GetCharacterInfo(char ch, out CharacterInfo info)
		{
			FontStyle fontStyle = FontStyle.Normal;
			int num = 0;
			return this.GetCharacterInfo(ch, out info, num, fontStyle);
		}

		/// <summary>
		///   <para>Is the font a dynamic font.</para>
		/// </summary>
		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001948 RID: 6472
		public extern bool dynamic
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The ascent of the font.</para>
		/// </summary>
		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001949 RID: 6473
		public extern int ascent
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The line height of the font.</para>
		/// </summary>
		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600194A RID: 6474
		public extern int lineHeight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The default size of the font.</para>
		/// </summary>
		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600194B RID: 6475
		public extern int fontSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x020001B5 RID: 437
		// (Invoke) Token: 0x0600194D RID: 6477
		[EditorBrowsable(EditorBrowsableState.Never)]
		public delegate void FontTextureRebuildCallback();
	}
}
