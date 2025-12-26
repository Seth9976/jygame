using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>A struct that stores the settings for TextGeneration.</para>
	/// </summary>
	// Token: 0x020002DF RID: 735
	public struct TextGenerationSettings
	{
		// Token: 0x06002268 RID: 8808 RVA: 0x0002CEF0 File Offset: 0x0002B0F0
		private bool CompareColors(Color left, Color right)
		{
			return Mathf.Approximately(left.r, right.r) && Mathf.Approximately(left.g, right.g) && Mathf.Approximately(left.b, right.b) && Mathf.Approximately(left.a, right.a);
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x0000DD65 File Offset: 0x0000BF65
		private bool CompareVector2(Vector2 left, Vector2 right)
		{
			return Mathf.Approximately(left.x, right.x) && Mathf.Approximately(left.y, right.y);
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x0002CF5C File Offset: 0x0002B15C
		public bool Equals(TextGenerationSettings other)
		{
			return this.CompareColors(this.color, other.color) && this.fontSize == other.fontSize && Mathf.Approximately(this.scaleFactor, other.scaleFactor) && this.resizeTextMinSize == other.resizeTextMinSize && this.resizeTextMaxSize == other.resizeTextMaxSize && Mathf.Approximately(this.lineSpacing, other.lineSpacing) && this.fontStyle == other.fontStyle && this.richText == other.richText && this.textAnchor == other.textAnchor && this.resizeTextForBestFit == other.resizeTextForBestFit && this.resizeTextMinSize == other.resizeTextMinSize && this.resizeTextMaxSize == other.resizeTextMaxSize && this.resizeTextForBestFit == other.resizeTextForBestFit && this.updateBounds == other.updateBounds && this.horizontalOverflow == other.horizontalOverflow && this.verticalOverflow == other.verticalOverflow && this.CompareVector2(this.generationExtents, other.generationExtents) && this.CompareVector2(this.pivot, other.pivot) && this.font == other.font;
		}

		/// <summary>
		///   <para>Font to use for generation.</para>
		/// </summary>
		// Token: 0x04000B5A RID: 2906
		public Font font;

		/// <summary>
		///   <para>The base color for the text generation.</para>
		/// </summary>
		// Token: 0x04000B5B RID: 2907
		public Color color;

		/// <summary>
		///   <para>Font size.</para>
		/// </summary>
		// Token: 0x04000B5C RID: 2908
		public int fontSize;

		/// <summary>
		///   <para>The line spacing multiplier.</para>
		/// </summary>
		// Token: 0x04000B5D RID: 2909
		public float lineSpacing;

		/// <summary>
		///   <para>Allow rich text markup in generation.</para>
		/// </summary>
		// Token: 0x04000B5E RID: 2910
		public bool richText;

		/// <summary>
		///   <para>A scale factor for the text. This is useful if the Text is on a Canvas and the canvas is scaled.</para>
		/// </summary>
		// Token: 0x04000B5F RID: 2911
		public float scaleFactor;

		/// <summary>
		///   <para>Font style.</para>
		/// </summary>
		// Token: 0x04000B60 RID: 2912
		public FontStyle fontStyle;

		/// <summary>
		///   <para>How is the generated text anchored.</para>
		/// </summary>
		// Token: 0x04000B61 RID: 2913
		public TextAnchor textAnchor;

		/// <summary>
		///   <para>Should the text be resized to fit the configured bounds?</para>
		/// </summary>
		// Token: 0x04000B62 RID: 2914
		public bool resizeTextForBestFit;

		/// <summary>
		///   <para>Minimum size for resized text.</para>
		/// </summary>
		// Token: 0x04000B63 RID: 2915
		public int resizeTextMinSize;

		/// <summary>
		///   <para>Maximum size for resized text.</para>
		/// </summary>
		// Token: 0x04000B64 RID: 2916
		public int resizeTextMaxSize;

		/// <summary>
		///   <para>Should the text generator update the bounds from the generated text.</para>
		/// </summary>
		// Token: 0x04000B65 RID: 2917
		public bool updateBounds;

		/// <summary>
		///   <para>What happens to text when it reaches the bottom generation bounds.</para>
		/// </summary>
		// Token: 0x04000B66 RID: 2918
		public VerticalWrapMode verticalOverflow;

		/// <summary>
		///   <para>What happens to text when it reaches the horizontal generation bounds.</para>
		/// </summary>
		// Token: 0x04000B67 RID: 2919
		public HorizontalWrapMode horizontalOverflow;

		/// <summary>
		///   <para>Extents that the generator will attempt to fit the text in.</para>
		/// </summary>
		// Token: 0x04000B68 RID: 2920
		public Vector2 generationExtents;

		/// <summary>
		///   <para>Generated vertices are offset by the pivot.</para>
		/// </summary>
		// Token: 0x04000B69 RID: 2921
		public Vector2 pivot;

		/// <summary>
		///   <para>Continue to generate characters even if the text runs out of bounds.</para>
		/// </summary>
		// Token: 0x04000B6A RID: 2922
		public bool generateOutOfBounds;
	}
}
