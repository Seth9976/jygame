using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000079 RID: 121
	[AddComponentMenu("UI/Text", 10)]
	public class Text : MaskableGraphic, ILayoutElement
	{
		// Token: 0x06000445 RID: 1093 RVA: 0x000144DC File Offset: 0x000126DC
		protected Text()
		{
			base.useLegacyMeshGeneration = false;
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00014514 File Offset: 0x00012714
		public TextGenerator cachedTextGenerator
		{
			get
			{
				TextGenerator textGenerator;
				if ((textGenerator = this.m_TextCache) == null)
				{
					textGenerator = (this.m_TextCache = ((this.m_Text.Length == 0) ? new TextGenerator() : new TextGenerator(this.m_Text.Length)));
				}
				return textGenerator;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x00014564 File Offset: 0x00012764
		public TextGenerator cachedTextGeneratorForLayout
		{
			get
			{
				TextGenerator textGenerator;
				if ((textGenerator = this.m_TextCacheForLayout) == null)
				{
					textGenerator = (this.m_TextCacheForLayout = new TextGenerator());
				}
				return textGenerator;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0001458C File Offset: 0x0001278C
		public override Texture mainTexture
		{
			get
			{
				if (this.font != null && this.font.material != null && this.font.material.mainTexture != null)
				{
					return this.font.material.mainTexture;
				}
				if (this.m_Material != null)
				{
					return this.m_Material.mainTexture;
				}
				return base.mainTexture;
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00014610 File Offset: 0x00012810
		public void FontTextureChanged()
		{
			if (!this)
			{
				FontUpdateTracker.UntrackText(this);
				return;
			}
			if (this.m_DisableFontTextureRebuiltCallback)
			{
				return;
			}
			this.cachedTextGenerator.Invalidate();
			if (!this.IsActive())
			{
				return;
			}
			if (CanvasUpdateRegistry.IsRebuildingGraphics() || CanvasUpdateRegistry.IsRebuildingLayout())
			{
				this.UpdateGeometry();
			}
			else
			{
				this.SetAllDirty();
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00014678 File Offset: 0x00012878
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00014688 File Offset: 0x00012888
		public Font font
		{
			get
			{
				return this.m_FontData.font;
			}
			set
			{
				if (this.m_FontData.font == value)
				{
					return;
				}
				FontUpdateTracker.UntrackText(this);
				this.m_FontData.font = value;
				FontUpdateTracker.TrackText(this);
				this.SetAllDirty();
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x000146CC File Offset: 0x000128CC
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x000146D4 File Offset: 0x000128D4
		public virtual string text
		{
			get
			{
				return this.m_Text;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					if (string.IsNullOrEmpty(this.m_Text))
					{
						return;
					}
					this.m_Text = string.Empty;
					this.SetVerticesDirty();
				}
				else if (this.m_Text != value)
				{
					this.m_Text = value;
					this.SetVerticesDirty();
					this.SetLayoutDirty();
				}
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00014738 File Offset: 0x00012938
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00014748 File Offset: 0x00012948
		public bool supportRichText
		{
			get
			{
				return this.m_FontData.richText;
			}
			set
			{
				if (this.m_FontData.richText == value)
				{
					return;
				}
				this.m_FontData.richText = value;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00014780 File Offset: 0x00012980
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x00014790 File Offset: 0x00012990
		public bool resizeTextForBestFit
		{
			get
			{
				return this.m_FontData.bestFit;
			}
			set
			{
				if (this.m_FontData.bestFit == value)
				{
					return;
				}
				this.m_FontData.bestFit = value;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x000147C8 File Offset: 0x000129C8
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x000147D8 File Offset: 0x000129D8
		public int resizeTextMinSize
		{
			get
			{
				return this.m_FontData.minSize;
			}
			set
			{
				if (this.m_FontData.minSize == value)
				{
					return;
				}
				this.m_FontData.minSize = value;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00014810 File Offset: 0x00012A10
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00014820 File Offset: 0x00012A20
		public int resizeTextMaxSize
		{
			get
			{
				return this.m_FontData.maxSize;
			}
			set
			{
				if (this.m_FontData.maxSize == value)
				{
					return;
				}
				this.m_FontData.maxSize = value;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00014858 File Offset: 0x00012A58
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00014868 File Offset: 0x00012A68
		public TextAnchor alignment
		{
			get
			{
				return this.m_FontData.alignment;
			}
			set
			{
				if (this.m_FontData.alignment == value)
				{
					return;
				}
				this.m_FontData.alignment = value;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x000148A0 File Offset: 0x00012AA0
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x000148B0 File Offset: 0x00012AB0
		public int fontSize
		{
			get
			{
				return this.m_FontData.fontSize;
			}
			set
			{
				if (this.m_FontData.fontSize == value)
				{
					return;
				}
				this.m_FontData.fontSize = value;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x000148E8 File Offset: 0x00012AE8
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x000148F8 File Offset: 0x00012AF8
		public HorizontalWrapMode horizontalOverflow
		{
			get
			{
				return this.m_FontData.horizontalOverflow;
			}
			set
			{
				if (this.m_FontData.horizontalOverflow == value)
				{
					return;
				}
				this.m_FontData.horizontalOverflow = value;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00014930 File Offset: 0x00012B30
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00014940 File Offset: 0x00012B40
		public VerticalWrapMode verticalOverflow
		{
			get
			{
				return this.m_FontData.verticalOverflow;
			}
			set
			{
				if (this.m_FontData.verticalOverflow == value)
				{
					return;
				}
				this.m_FontData.verticalOverflow = value;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00014978 File Offset: 0x00012B78
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x00014988 File Offset: 0x00012B88
		public float lineSpacing
		{
			get
			{
				return this.m_FontData.lineSpacing;
			}
			set
			{
				if (this.m_FontData.lineSpacing == value)
				{
					return;
				}
				this.m_FontData.lineSpacing = value;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x000149C0 File Offset: 0x00012BC0
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x000149D0 File Offset: 0x00012BD0
		public FontStyle fontStyle
		{
			get
			{
				return this.m_FontData.fontStyle;
			}
			set
			{
				if (this.m_FontData.fontStyle == value)
				{
					return;
				}
				this.m_FontData.fontStyle = value;
				this.SetVerticesDirty();
				this.SetLayoutDirty();
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00014A08 File Offset: 0x00012C08
		public float pixelsPerUnit
		{
			get
			{
				Canvas canvas = base.canvas;
				if (!canvas)
				{
					return 1f;
				}
				if (!this.font || this.font.dynamic)
				{
					return canvas.scaleFactor;
				}
				if (this.m_FontData.fontSize <= 0 || this.font.fontSize <= 0)
				{
					return 1f;
				}
				return (float)this.font.fontSize / (float)this.m_FontData.fontSize;
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00014A98 File Offset: 0x00012C98
		protected override void OnEnable()
		{
			base.OnEnable();
			this.cachedTextGenerator.Invalidate();
			FontUpdateTracker.TrackText(this);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00014AB4 File Offset: 0x00012CB4
		protected override void OnDisable()
		{
			FontUpdateTracker.UntrackText(this);
			base.OnDisable();
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00014AC4 File Offset: 0x00012CC4
		protected override void UpdateGeometry()
		{
			if (this.font != null)
			{
				base.UpdateGeometry();
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00014AE0 File Offset: 0x00012CE0
		public TextGenerationSettings GetGenerationSettings(Vector2 extents)
		{
			TextGenerationSettings textGenerationSettings = default(TextGenerationSettings);
			textGenerationSettings.generationExtents = extents;
			if (this.font != null && this.font.dynamic)
			{
				textGenerationSettings.fontSize = this.m_FontData.fontSize;
				textGenerationSettings.resizeTextMinSize = this.m_FontData.minSize;
				textGenerationSettings.resizeTextMaxSize = this.m_FontData.maxSize;
			}
			textGenerationSettings.textAnchor = this.m_FontData.alignment;
			textGenerationSettings.scaleFactor = this.pixelsPerUnit;
			textGenerationSettings.color = base.color;
			textGenerationSettings.font = this.font;
			textGenerationSettings.pivot = base.rectTransform.pivot;
			textGenerationSettings.richText = this.m_FontData.richText;
			textGenerationSettings.lineSpacing = this.m_FontData.lineSpacing;
			textGenerationSettings.fontStyle = this.m_FontData.fontStyle;
			textGenerationSettings.resizeTextForBestFit = this.m_FontData.bestFit;
			textGenerationSettings.updateBounds = false;
			textGenerationSettings.horizontalOverflow = this.m_FontData.horizontalOverflow;
			textGenerationSettings.verticalOverflow = this.m_FontData.verticalOverflow;
			return textGenerationSettings;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00014C14 File Offset: 0x00012E14
		public static Vector2 GetTextAnchorPivot(TextAnchor anchor)
		{
			switch (anchor)
			{
			case TextAnchor.UpperLeft:
				return new Vector2(0f, 1f);
			case TextAnchor.UpperCenter:
				return new Vector2(0.5f, 1f);
			case TextAnchor.UpperRight:
				return new Vector2(1f, 1f);
			case TextAnchor.MiddleLeft:
				return new Vector2(0f, 0.5f);
			case TextAnchor.MiddleCenter:
				return new Vector2(0.5f, 0.5f);
			case TextAnchor.MiddleRight:
				return new Vector2(1f, 0.5f);
			case TextAnchor.LowerLeft:
				return new Vector2(0f, 0f);
			case TextAnchor.LowerCenter:
				return new Vector2(0.5f, 0f);
			case TextAnchor.LowerRight:
				return new Vector2(1f, 0f);
			default:
				return Vector2.zero;
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00014CE8 File Offset: 0x00012EE8
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
			if (this.font == null)
			{
				return;
			}
			this.m_DisableFontTextureRebuiltCallback = true;
			Vector2 size = base.rectTransform.rect.size;
			TextGenerationSettings generationSettings = this.GetGenerationSettings(size);
			this.cachedTextGenerator.Populate(this.text, generationSettings);
			Rect rect = base.rectTransform.rect;
			Vector2 textAnchorPivot = Text.GetTextAnchorPivot(this.m_FontData.alignment);
			Vector2 zero = Vector2.zero;
			zero.x = ((textAnchorPivot.x != 1f) ? rect.xMin : rect.xMax);
			zero.y = ((textAnchorPivot.y != 0f) ? rect.yMax : rect.yMin);
			Vector2 vector = base.PixelAdjustPoint(zero) - zero;
			IList<UIVertex> verts = this.cachedTextGenerator.verts;
			float num = 1f / this.pixelsPerUnit;
			int num2 = verts.Count - 4;
			toFill.Clear();
			if (vector != Vector2.zero)
			{
				for (int i = 0; i < num2; i++)
				{
					int num3 = i & 3;
					this.m_TempVerts[num3] = verts[i];
					UIVertex[] tempVerts = this.m_TempVerts;
					int num4 = num3;
					tempVerts[num4].position = tempVerts[num4].position * num;
					UIVertex[] tempVerts2 = this.m_TempVerts;
					int num5 = num3;
					tempVerts2[num5].position.x = tempVerts2[num5].position.x + vector.x;
					UIVertex[] tempVerts3 = this.m_TempVerts;
					int num6 = num3;
					tempVerts3[num6].position.y = tempVerts3[num6].position.y + vector.y;
					if (num3 == 3)
					{
						toFill.AddUIVertexQuad(this.m_TempVerts);
					}
				}
			}
			else
			{
				for (int j = 0; j < num2; j++)
				{
					int num7 = j & 3;
					this.m_TempVerts[num7] = verts[j];
					UIVertex[] tempVerts4 = this.m_TempVerts;
					int num8 = num7;
					tempVerts4[num8].position = tempVerts4[num8].position * num;
					if (num7 == 3)
					{
						toFill.AddUIVertexQuad(this.m_TempVerts);
					}
				}
			}
			this.m_DisableFontTextureRebuiltCallback = false;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00014F34 File Offset: 0x00013134
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00014F38 File Offset: 0x00013138
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00014F3C File Offset: 0x0001313C
		public virtual float minWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00014F44 File Offset: 0x00013144
		public virtual float preferredWidth
		{
			get
			{
				TextGenerationSettings generationSettings = this.GetGenerationSettings(Vector2.zero);
				return this.cachedTextGeneratorForLayout.GetPreferredWidth(this.m_Text, generationSettings) / this.pixelsPerUnit;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00014F78 File Offset: 0x00013178
		public virtual float flexibleWidth
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00014F80 File Offset: 0x00013180
		public virtual float minHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00014F88 File Offset: 0x00013188
		public virtual float preferredHeight
		{
			get
			{
				TextGenerationSettings generationSettings = this.GetGenerationSettings(new Vector2(base.rectTransform.rect.size.x, 0f));
				return this.cachedTextGeneratorForLayout.GetPreferredHeight(this.m_Text, generationSettings) / this.pixelsPerUnit;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00014FDC File Offset: 0x000131DC
		public virtual float flexibleHeight
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00014FE4 File Offset: 0x000131E4
		public virtual int layoutPriority
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x04000224 RID: 548
		[SerializeField]
		private FontData m_FontData = FontData.defaultFontData;

		// Token: 0x04000225 RID: 549
		[SerializeField]
		[TextArea(3, 10)]
		protected string m_Text = string.Empty;

		// Token: 0x04000226 RID: 550
		private TextGenerator m_TextCache;

		// Token: 0x04000227 RID: 551
		private TextGenerator m_TextCacheForLayout;

		// Token: 0x04000228 RID: 552
		protected static Material s_DefaultText;

		// Token: 0x04000229 RID: 553
		[NonSerialized]
		protected bool m_DisableFontTextureRebuiltCallback;

		// Token: 0x0400022A RID: 554
		private readonly UIVertex[] m_TempVerts = new UIVertex[4];
	}
}
