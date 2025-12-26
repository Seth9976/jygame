using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Specification for how to render a character from the font texture. See Font.characterInfo.</para>
	/// </summary>
	// Token: 0x020001B3 RID: 435
	public struct CharacterInfo
	{
		/// <summary>
		///   <para>The horizontal distance from the origin of this character to the origin of the next character.</para>
		/// </summary>
		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x0600190B RID: 6411 RVA: 0x00008BC6 File Offset: 0x00006DC6
		// (set) Token: 0x0600190C RID: 6412 RVA: 0x00008BCF File Offset: 0x00006DCF
		public int advance
		{
			get
			{
				return (int)this.width;
			}
			set
			{
				this.width = (float)value;
			}
		}

		/// <summary>
		///   <para>The width of the glyph image.</para>
		/// </summary>
		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x00008BD9 File Offset: 0x00006DD9
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x00008BE7 File Offset: 0x00006DE7
		public int glyphWidth
		{
			get
			{
				return (int)this.vert.width;
			}
			set
			{
				this.vert.width = (float)value;
			}
		}

		/// <summary>
		///   <para>The height of the glyph image.</para>
		/// </summary>
		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x00008BF6 File Offset: 0x00006DF6
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x0001B80C File Offset: 0x00019A0C
		public int glyphHeight
		{
			get
			{
				return (int)(-(int)this.vert.height);
			}
			set
			{
				float height = this.vert.height;
				this.vert.height = (float)(-(float)value);
				this.vert.y = this.vert.y + (height - this.vert.height);
			}
		}

		/// <summary>
		///   <para>The horizontal distance from the origin of this glyph to the begining of the glyph image.</para>
		/// </summary>
		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x00008C05 File Offset: 0x00006E05
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x00008C13 File Offset: 0x00006E13
		public int bearing
		{
			get
			{
				return (int)this.vert.x;
			}
			set
			{
				this.vert.x = (float)value;
			}
		}

		/// <summary>
		///   <para>The minimum extend of the glyph image in the y-axis.</para>
		/// </summary>
		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x00008C22 File Offset: 0x00006E22
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x00008C43 File Offset: 0x00006E43
		public int minY
		{
			get
			{
				return this.ascent + (int)(this.vert.y + this.vert.height);
			}
			set
			{
				this.vert.height = (float)(value - this.ascent) - this.vert.y;
			}
		}

		/// <summary>
		///   <para>The maximum extend of the glyph image in the y-axis.</para>
		/// </summary>
		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x00008C65 File Offset: 0x00006E65
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x0001B854 File Offset: 0x00019A54
		public int maxY
		{
			get
			{
				return this.ascent + (int)this.vert.y;
			}
			set
			{
				float y = this.vert.y;
				this.vert.y = (float)(value - this.ascent);
				this.vert.height = this.vert.height + (y - this.vert.y);
			}
		}

		/// <summary>
		///   <para>The minium extend of the glyph image in the x-axis.</para>
		/// </summary>
		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x00008C05 File Offset: 0x00006E05
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x0001B8A0 File Offset: 0x00019AA0
		public int minX
		{
			get
			{
				return (int)this.vert.x;
			}
			set
			{
				float x = this.vert.x;
				this.vert.x = (float)value;
				this.vert.width = this.vert.width + (x - this.vert.x);
			}
		}

		/// <summary>
		///   <para>The maximum extend of the glyph image in the x-axis.</para>
		/// </summary>
		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x00008C7A File Offset: 0x00006E7A
		// (set) Token: 0x0600191A RID: 6426 RVA: 0x00008C94 File Offset: 0x00006E94
		public int maxX
		{
			get
			{
				return (int)(this.vert.x + this.vert.width);
			}
			set
			{
				this.vert.width = (float)value - this.vert.x;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x00008CAF File Offset: 0x00006EAF
		// (set) Token: 0x0600191C RID: 6428 RVA: 0x0001B8E8 File Offset: 0x00019AE8
		internal Vector2 uvBottomLeftUnFlipped
		{
			get
			{
				return new Vector2(this.uv.x, this.uv.y);
			}
			set
			{
				Vector2 uvTopRightUnFlipped = this.uvTopRightUnFlipped;
				this.uv.x = value.x;
				this.uv.y = value.y;
				this.uv.width = uvTopRightUnFlipped.x - this.uv.x;
				this.uv.height = uvTopRightUnFlipped.y - this.uv.y;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x00008CCC File Offset: 0x00006ECC
		// (set) Token: 0x0600191E RID: 6430 RVA: 0x0001B95C File Offset: 0x00019B5C
		internal Vector2 uvBottomRightUnFlipped
		{
			get
			{
				return new Vector2(this.uv.x + this.uv.width, this.uv.y);
			}
			set
			{
				Vector2 uvTopRightUnFlipped = this.uvTopRightUnFlipped;
				this.uv.width = value.x - this.uv.x;
				this.uv.y = value.y;
				this.uv.height = uvTopRightUnFlipped.y - this.uv.y;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x00008CF5 File Offset: 0x00006EF5
		// (set) Token: 0x06001920 RID: 6432 RVA: 0x00008D2A File Offset: 0x00006F2A
		internal Vector2 uvTopRightUnFlipped
		{
			get
			{
				return new Vector2(this.uv.x + this.uv.width, this.uv.y + this.uv.height);
			}
			set
			{
				this.uv.width = value.x - this.uv.x;
				this.uv.height = value.y - this.uv.y;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x00008D68 File Offset: 0x00006F68
		// (set) Token: 0x06001922 RID: 6434 RVA: 0x0001B9C0 File Offset: 0x00019BC0
		internal Vector2 uvTopLeftUnFlipped
		{
			get
			{
				return new Vector2(this.uv.x, this.uv.y + this.uv.height);
			}
			set
			{
				Vector2 uvTopRightUnFlipped = this.uvTopRightUnFlipped;
				this.uv.x = value.x;
				this.uv.height = value.y - this.uv.y;
				this.uv.width = uvTopRightUnFlipped.x - this.uv.x;
			}
		}

		/// <summary>
		///   <para>The uv coordinate matching the bottom left of the glyph image in the font texture.</para>
		/// </summary>
		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x00008D91 File Offset: 0x00006F91
		// (set) Token: 0x06001924 RID: 6436 RVA: 0x00008D99 File Offset: 0x00006F99
		public Vector2 uvBottomLeft
		{
			get
			{
				return this.uvBottomLeftUnFlipped;
			}
			set
			{
				this.uvBottomLeftUnFlipped = value;
			}
		}

		/// <summary>
		///   <para>The uv coordinate matching the bottom right of the glyph image in the font texture.</para>
		/// </summary>
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x00008DA2 File Offset: 0x00006FA2
		// (set) Token: 0x06001926 RID: 6438 RVA: 0x00008DC0 File Offset: 0x00006FC0
		public Vector2 uvBottomRight
		{
			get
			{
				return (!this.flipped) ? this.uvBottomRightUnFlipped : this.uvTopLeftUnFlipped;
			}
			set
			{
				if (this.flipped)
				{
					this.uvTopLeftUnFlipped = value;
				}
				else
				{
					this.uvBottomRightUnFlipped = value;
				}
			}
		}

		/// <summary>
		///   <para>The uv coordinate matching the top right of the glyph image in the font texture.</para>
		/// </summary>
		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x00008DE0 File Offset: 0x00006FE0
		// (set) Token: 0x06001928 RID: 6440 RVA: 0x00008DE8 File Offset: 0x00006FE8
		public Vector2 uvTopRight
		{
			get
			{
				return this.uvTopRightUnFlipped;
			}
			set
			{
				this.uvTopRightUnFlipped = value;
			}
		}

		/// <summary>
		///   <para>The uv coordinate matching the top left of the glyph image in the font texture.</para>
		/// </summary>
		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x00008DF1 File Offset: 0x00006FF1
		// (set) Token: 0x0600192A RID: 6442 RVA: 0x00008E0F File Offset: 0x0000700F
		public Vector2 uvTopLeft
		{
			get
			{
				return (!this.flipped) ? this.uvTopLeftUnFlipped : this.uvBottomRightUnFlipped;
			}
			set
			{
				if (this.flipped)
				{
					this.uvBottomRightUnFlipped = value;
				}
				else
				{
					this.uvTopLeftUnFlipped = value;
				}
			}
		}

		/// <summary>
		///   <para>Unicode value of the character.</para>
		/// </summary>
		// Token: 0x0400054B RID: 1355
		public int index;

		/// <summary>
		///   <para>UV coordinates for the character in the texture.</para>
		/// </summary>
		// Token: 0x0400054C RID: 1356
		[Obsolete("CharacterInfo.uv is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead.")]
		public Rect uv;

		/// <summary>
		///   <para>Screen coordinates for the character in generated text meshes.</para>
		/// </summary>
		// Token: 0x0400054D RID: 1357
		[Obsolete("CharacterInfo.vert is deprecated. Use minX, maxX, minY, maxY instead.")]
		public Rect vert;

		/// <summary>
		///   <para>How far to advance between the beginning of this charcater and the next.</para>
		/// </summary>
		// Token: 0x0400054E RID: 1358
		[Obsolete("CharacterInfo.width is deprecated. Use advance instead.")]
		public float width;

		/// <summary>
		///   <para>The size of the character or 0 if it is the default font size.</para>
		/// </summary>
		// Token: 0x0400054F RID: 1359
		public int size;

		/// <summary>
		///   <para>The style of the character.</para>
		/// </summary>
		// Token: 0x04000550 RID: 1360
		public FontStyle style;

		/// <summary>
		///   <para>Is the character flipped?</para>
		/// </summary>
		// Token: 0x04000551 RID: 1361
		[Obsolete("CharacterInfo.flipped is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead, which will be correct regardless of orientation.")]
		public bool flipped;

		// Token: 0x04000552 RID: 1362
		private int ascent;
	}
}
