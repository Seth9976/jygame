using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Class that can be used to generate text for rendering.</para>
	/// </summary>
	// Token: 0x020001B8 RID: 440
	[StructLayout(LayoutKind.Sequential)]
	public sealed class TextGenerator : IDisposable
	{
		/// <summary>
		///   <para>Create a TextGenerator.</para>
		/// </summary>
		/// <param name="initialCapacity"></param>
		// Token: 0x06001950 RID: 6480 RVA: 0x00008EDA File Offset: 0x000070DA
		public TextGenerator()
			: this(50)
		{
		}

		/// <summary>
		///   <para>Create a TextGenerator.</para>
		/// </summary>
		/// <param name="initialCapacity"></param>
		// Token: 0x06001951 RID: 6481 RVA: 0x00008EE4 File Offset: 0x000070E4
		public TextGenerator(int initialCapacity)
		{
			this.m_Verts = new List<UIVertex>((initialCapacity + 1) * 4);
			this.m_Characters = new List<UICharInfo>(initialCapacity + 1);
			this.m_Lines = new List<UILineInfo>(20);
			this.Init();
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00008F1D File Offset: 0x0000711D
		void IDisposable.Dispose()
		{
			this.Dispose_cpp();
		}

		// Token: 0x06001953 RID: 6483
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init();

		// Token: 0x06001954 RID: 6484
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Dispose_cpp();

		// Token: 0x06001955 RID: 6485 RVA: 0x0001BB00 File Offset: 0x00019D00
		internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds)
		{
			return this.Populate_Internal_cpp(str, font, color, fontSize, scaleFactor, lineSpacing, style, richText, resizeTextForBestFit, resizeTextMinSize, resizeTextMaxSize, (int)verticalOverFlow, (int)horizontalOverflow, updateBounds, anchor, extents.x, extents.y, pivot.x, pivot.y, generateOutOfBounds);
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x0001BB4C File Offset: 0x00019D4C
		internal bool Populate_Internal_cpp(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds)
		{
			return TextGenerator.INTERNAL_CALL_Populate_Internal_cpp(this, str, font, ref color, fontSize, scaleFactor, lineSpacing, style, richText, resizeTextForBestFit, resizeTextMinSize, resizeTextMaxSize, verticalOverFlow, horizontalOverflow, updateBounds, anchor, extentsX, extentsY, pivotX, pivotY, generateOutOfBounds);
		}

		// Token: 0x06001957 RID: 6487
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Populate_Internal_cpp(TextGenerator self, string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds);

		/// <summary>
		///   <para>Extents of the generated text in rect format.</para>
		/// </summary>
		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x0001BB88 File Offset: 0x00019D88
		public Rect rectExtents
		{
			get
			{
				Rect rect;
				this.INTERNAL_get_rectExtents(out rect);
				return rect;
			}
		}

		// Token: 0x06001959 RID: 6489
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rectExtents(out Rect value);

		/// <summary>
		///   <para>Number of vertices generated.</para>
		/// </summary>
		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600195A RID: 6490
		public extern int vertexCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x0600195B RID: 6491
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetVerticesInternal(object vertices);

		/// <summary>
		///   <para>Returns the current UILineInfo.</para>
		/// </summary>
		/// <returns>
		///   <para>Vertices.</para>
		/// </returns>
		// Token: 0x0600195C RID: 6492
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern UIVertex[] GetVerticesArray();

		/// <summary>
		///   <para>The number of characters that have been generated.</para>
		/// </summary>
		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600195D RID: 6493
		public extern int characterCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The number of characters that have been generated and are included in the visible lines.</para>
		/// </summary>
		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x00008F25 File Offset: 0x00007125
		public int characterCountVisible
		{
			get
			{
				return (!string.IsNullOrEmpty(this.m_LastString)) ? Mathf.Min(this.m_LastString.Length, Mathf.Max(0, (this.vertexCount - 4) / 4)) : 0;
			}
		}

		// Token: 0x0600195F RID: 6495
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetCharactersInternal(object characters);

		/// <summary>
		///   <para>Returns the current UICharInfo.</para>
		/// </summary>
		/// <returns>
		///   <para>Character information.</para>
		/// </returns>
		// Token: 0x06001960 RID: 6496
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern UICharInfo[] GetCharactersArray();

		/// <summary>
		///   <para>Number of text lines generated.</para>
		/// </summary>
		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001961 RID: 6497
		public extern int lineCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06001962 RID: 6498
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetLinesInternal(object lines);

		/// <summary>
		///   <para>Returns the current UILineInfo.</para>
		/// </summary>
		/// <returns>
		///   <para>Line information.</para>
		/// </returns>
		// Token: 0x06001963 RID: 6499
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern UILineInfo[] GetLinesArray();

		/// <summary>
		///   <para>The size of the font that was found if using best fit mode.</para>
		/// </summary>
		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001964 RID: 6500
		public extern int fontSizeUsedForBestFit
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x0001BBA0 File Offset: 0x00019DA0
		~TextGenerator()
		{
			((IDisposable)this).Dispose();
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings)
		{
			if (settings.font != null && settings.font.dynamic)
			{
				return settings;
			}
			if (settings.fontSize != 0 || settings.fontStyle != FontStyle.Normal)
			{
				Debug.LogWarning("Font size and style overrides are only supported for dynamic fonts.");
				settings.fontSize = 0;
				settings.fontStyle = FontStyle.Normal;
			}
			if (settings.resizeTextForBestFit)
			{
				Debug.LogWarning("BestFit is only suppoerted for dynamic fonts.");
				settings.resizeTextForBestFit = false;
			}
			return settings;
		}

		/// <summary>
		///   <para>Mark the text generator as invalid. This will force a full text generation the next time Populate is called.</para>
		/// </summary>
		// Token: 0x06001967 RID: 6503 RVA: 0x00008F5D File Offset: 0x0000715D
		public void Invalidate()
		{
			this.m_HasGenerated = false;
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x00008F66 File Offset: 0x00007166
		public void GetCharacters(List<UICharInfo> characters)
		{
			this.GetCharactersInternal(characters);
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00008F6F File Offset: 0x0000716F
		public void GetLines(List<UILineInfo> lines)
		{
			this.GetLinesInternal(lines);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00008F78 File Offset: 0x00007178
		public void GetVertices(List<UIVertex> vertices)
		{
			this.GetVerticesInternal(vertices);
		}

		/// <summary>
		///   <para>Given a string and settings, returns the preferred width for a container that would hold this text.</para>
		/// </summary>
		/// <param name="str">Generation text.</param>
		/// <param name="settings">Settings for generation.</param>
		/// <returns>
		///   <para>Preferred width.</para>
		/// </returns>
		// Token: 0x0600196B RID: 6507 RVA: 0x0001BC54 File Offset: 0x00019E54
		public float GetPreferredWidth(string str, TextGenerationSettings settings)
		{
			settings.horizontalOverflow = HorizontalWrapMode.Overflow;
			settings.verticalOverflow = VerticalWrapMode.Overflow;
			settings.updateBounds = true;
			this.Populate(str, settings);
			return this.rectExtents.width;
		}

		/// <summary>
		///   <para>Given a string and settings, returns the preferred height for a container that would hold this text.</para>
		/// </summary>
		/// <param name="str">Generation text.</param>
		/// <param name="settings">Settings for generation.</param>
		/// <returns>
		///   <para>Preferred height.</para>
		/// </returns>
		// Token: 0x0600196C RID: 6508 RVA: 0x0001BC90 File Offset: 0x00019E90
		public float GetPreferredHeight(string str, TextGenerationSettings settings)
		{
			settings.verticalOverflow = VerticalWrapMode.Overflow;
			settings.updateBounds = true;
			this.Populate(str, settings);
			return this.rectExtents.height;
		}

		/// <summary>
		///   <para>Will generate the vertices and other data for the given string with the given settings.</para>
		/// </summary>
		/// <param name="str">String to generate.</param>
		/// <param name="settings">Settings.</param>
		// Token: 0x0600196D RID: 6509 RVA: 0x00008F81 File Offset: 0x00007181
		public bool Populate(string str, TextGenerationSettings settings)
		{
			if (this.m_HasGenerated && str == this.m_LastString && settings.Equals(this.m_LastSettings))
			{
				return this.m_LastValid;
			}
			return this.PopulateAlways(str, settings);
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x0001BCC4 File Offset: 0x00019EC4
		private bool PopulateAlways(string str, TextGenerationSettings settings)
		{
			this.m_LastString = str;
			this.m_HasGenerated = true;
			this.m_CachedVerts = false;
			this.m_CachedCharacters = false;
			this.m_CachedLines = false;
			this.m_LastSettings = settings;
			TextGenerationSettings textGenerationSettings = this.ValidatedSettings(settings);
			this.m_LastValid = this.Populate_Internal(str, textGenerationSettings.font, textGenerationSettings.color, textGenerationSettings.fontSize, textGenerationSettings.scaleFactor, textGenerationSettings.lineSpacing, textGenerationSettings.fontStyle, textGenerationSettings.richText, textGenerationSettings.resizeTextForBestFit, textGenerationSettings.resizeTextMinSize, textGenerationSettings.resizeTextMaxSize, textGenerationSettings.verticalOverflow, textGenerationSettings.horizontalOverflow, textGenerationSettings.updateBounds, textGenerationSettings.textAnchor, textGenerationSettings.generationExtents, textGenerationSettings.pivot, textGenerationSettings.generateOutOfBounds);
			return this.m_LastValid;
		}

		/// <summary>
		///   <para>Array of generated vertices.</para>
		/// </summary>
		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x00008FC0 File Offset: 0x000071C0
		public IList<UIVertex> verts
		{
			get
			{
				if (!this.m_CachedVerts)
				{
					this.GetVertices(this.m_Verts);
					this.m_CachedVerts = true;
				}
				return this.m_Verts;
			}
		}

		/// <summary>
		///   <para>Array of generated characters.</para>
		/// </summary>
		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x00008FE6 File Offset: 0x000071E6
		public IList<UICharInfo> characters
		{
			get
			{
				if (!this.m_CachedCharacters)
				{
					this.GetCharacters(this.m_Characters);
					this.m_CachedCharacters = true;
				}
				return this.m_Characters;
			}
		}

		/// <summary>
		///   <para>Information about each generated text line.</para>
		/// </summary>
		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x0000900C File Offset: 0x0000720C
		public IList<UILineInfo> lines
		{
			get
			{
				if (!this.m_CachedLines)
				{
					this.GetLines(this.m_Lines);
					this.m_CachedLines = true;
				}
				return this.m_Lines;
			}
		}

		// Token: 0x04000559 RID: 1369
		internal IntPtr m_Ptr;

		// Token: 0x0400055A RID: 1370
		private string m_LastString;

		// Token: 0x0400055B RID: 1371
		private TextGenerationSettings m_LastSettings;

		// Token: 0x0400055C RID: 1372
		private bool m_HasGenerated;

		// Token: 0x0400055D RID: 1373
		private bool m_LastValid;

		// Token: 0x0400055E RID: 1374
		private readonly List<UIVertex> m_Verts;

		// Token: 0x0400055F RID: 1375
		private readonly List<UICharInfo> m_Characters;

		// Token: 0x04000560 RID: 1376
		private readonly List<UILineInfo> m_Lines;

		// Token: 0x04000561 RID: 1377
		private bool m_CachedVerts;

		// Token: 0x04000562 RID: 1378
		private bool m_CachedCharacters;

		// Token: 0x04000563 RID: 1379
		private bool m_CachedLines;
	}
}
