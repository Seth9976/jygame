using System;
using UnityEngine.Serialization;
using UnityEngine.Sprites;

namespace UnityEngine.UI
{
	// Token: 0x0200004B RID: 75
	[AddComponentMenu("UI/Image", 11)]
	public class Image : MaskableGraphic, ICanvasRaycastFilter, ISerializationCallbackReceiver, ILayoutElement
	{
		// Token: 0x06000248 RID: 584 RVA: 0x000097C0 File Offset: 0x000079C0
		protected Image()
		{
			base.useLegacyMeshGeneration = false;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00009844 File Offset: 0x00007A44
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0000984C File Offset: 0x00007A4C
		public Sprite sprite
		{
			get
			{
				return this.m_Sprite;
			}
			set
			{
				if (SetPropertyUtility.SetClass<Sprite>(ref this.m_Sprite, value))
				{
					this.SetAllDirty();
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00009868 File Offset: 0x00007A68
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00009898 File Offset: 0x00007A98
		public Sprite overrideSprite
		{
			get
			{
				return (!(this.m_OverrideSprite == null)) ? this.m_OverrideSprite : this.sprite;
			}
			set
			{
				if (SetPropertyUtility.SetClass<Sprite>(ref this.m_OverrideSprite, value))
				{
					this.SetAllDirty();
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000098B4 File Offset: 0x00007AB4
		// (set) Token: 0x0600024F RID: 591 RVA: 0x000098BC File Offset: 0x00007ABC
		public Image.Type type
		{
			get
			{
				return this.m_Type;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<Image.Type>(ref this.m_Type, value))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000098D8 File Offset: 0x00007AD8
		// (set) Token: 0x06000251 RID: 593 RVA: 0x000098E0 File Offset: 0x00007AE0
		public bool preserveAspect
		{
			get
			{
				return this.m_PreserveAspect;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<bool>(ref this.m_PreserveAspect, value))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000252 RID: 594 RVA: 0x000098FC File Offset: 0x00007AFC
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00009904 File Offset: 0x00007B04
		public bool fillCenter
		{
			get
			{
				return this.m_FillCenter;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<bool>(ref this.m_FillCenter, value))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00009920 File Offset: 0x00007B20
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00009928 File Offset: 0x00007B28
		public Image.FillMethod fillMethod
		{
			get
			{
				return this.m_FillMethod;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<Image.FillMethod>(ref this.m_FillMethod, value))
				{
					this.SetVerticesDirty();
					this.m_FillOrigin = 0;
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00009948 File Offset: 0x00007B48
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00009950 File Offset: 0x00007B50
		public float fillAmount
		{
			get
			{
				return this.m_FillAmount;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_FillAmount, Mathf.Clamp01(value)))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00009970 File Offset: 0x00007B70
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00009978 File Offset: 0x00007B78
		public bool fillClockwise
		{
			get
			{
				return this.m_FillClockwise;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<bool>(ref this.m_FillClockwise, value))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00009994 File Offset: 0x00007B94
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0000999C File Offset: 0x00007B9C
		public int fillOrigin
		{
			get
			{
				return this.m_FillOrigin;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<int>(ref this.m_FillOrigin, value))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600025C RID: 604 RVA: 0x000099B8 File Offset: 0x00007BB8
		// (set) Token: 0x0600025D RID: 605 RVA: 0x000099C0 File Offset: 0x00007BC0
		public float eventAlphaThreshold
		{
			get
			{
				return this.m_EventAlphaThreshold;
			}
			set
			{
				this.m_EventAlphaThreshold = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000099CC File Offset: 0x00007BCC
		public override Texture mainTexture
		{
			get
			{
				if (!(this.overrideSprite == null))
				{
					return this.overrideSprite.texture;
				}
				if (this.material != null && this.material.mainTexture != null)
				{
					return this.material.mainTexture;
				}
				return Graphic.s_WhiteTexture;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00009A30 File Offset: 0x00007C30
		public bool hasBorder
		{
			get
			{
				return this.overrideSprite != null && this.overrideSprite.border.sqrMagnitude > 0f;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00009A6C File Offset: 0x00007C6C
		public float pixelsPerUnit
		{
			get
			{
				float num = 100f;
				if (this.sprite)
				{
					num = this.sprite.pixelsPerUnit;
				}
				float num2 = 100f;
				if (base.canvas)
				{
					num2 = base.canvas.referencePixelsPerUnit;
				}
				return num / num2;
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00009AC0 File Offset: 0x00007CC0
		public virtual void OnBeforeSerialize()
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00009AC4 File Offset: 0x00007CC4
		public virtual void OnAfterDeserialize()
		{
			if (this.m_FillOrigin < 0)
			{
				this.m_FillOrigin = 0;
			}
			else if (this.m_FillMethod == Image.FillMethod.Horizontal && this.m_FillOrigin > 1)
			{
				this.m_FillOrigin = 0;
			}
			else if (this.m_FillMethod == Image.FillMethod.Vertical && this.m_FillOrigin > 1)
			{
				this.m_FillOrigin = 0;
			}
			else if (this.m_FillOrigin > 3)
			{
				this.m_FillOrigin = 0;
			}
			this.m_FillAmount = Mathf.Clamp(this.m_FillAmount, 0f, 1f);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00009B60 File Offset: 0x00007D60
		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
		{
			Vector4 vector = ((!(this.overrideSprite == null)) ? DataUtility.GetPadding(this.overrideSprite) : Vector4.zero);
			Vector2 vector2 = ((!(this.overrideSprite == null)) ? new Vector2(this.overrideSprite.rect.width, this.overrideSprite.rect.height) : Vector2.zero);
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			int num = Mathf.RoundToInt(vector2.x);
			int num2 = Mathf.RoundToInt(vector2.y);
			Vector4 vector3 = new Vector4(vector.x / (float)num, vector.y / (float)num2, ((float)num - vector.z) / (float)num, ((float)num2 - vector.w) / (float)num2);
			if (shouldPreserveAspect && vector2.sqrMagnitude > 0f)
			{
				float num3 = vector2.x / vector2.y;
				float num4 = pixelAdjustedRect.width / pixelAdjustedRect.height;
				if (num3 > num4)
				{
					float height = pixelAdjustedRect.height;
					pixelAdjustedRect.height = pixelAdjustedRect.width * (1f / num3);
					pixelAdjustedRect.y += (height - pixelAdjustedRect.height) * base.rectTransform.pivot.y;
				}
				else
				{
					float width = pixelAdjustedRect.width;
					pixelAdjustedRect.width = pixelAdjustedRect.height * num3;
					pixelAdjustedRect.x += (width - pixelAdjustedRect.width) * base.rectTransform.pivot.x;
				}
			}
			vector3 = new Vector4(pixelAdjustedRect.x + pixelAdjustedRect.width * vector3.x, pixelAdjustedRect.y + pixelAdjustedRect.height * vector3.y, pixelAdjustedRect.x + pixelAdjustedRect.width * vector3.z, pixelAdjustedRect.y + pixelAdjustedRect.height * vector3.w);
			return vector3;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00009D78 File Offset: 0x00007F78
		public override void SetNativeSize()
		{
			if (this.overrideSprite != null)
			{
				float num = this.overrideSprite.rect.width / this.pixelsPerUnit;
				float num2 = this.overrideSprite.rect.height / this.pixelsPerUnit;
				base.rectTransform.anchorMax = base.rectTransform.anchorMin;
				base.rectTransform.sizeDelta = new Vector2(num, num2);
				this.SetAllDirty();
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00009DFC File Offset: 0x00007FFC
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
			if (this.overrideSprite == null)
			{
				base.OnPopulateMesh(toFill);
				return;
			}
			switch (this.type)
			{
			case Image.Type.Simple:
				this.GenerateSimpleSprite(toFill, this.m_PreserveAspect);
				break;
			case Image.Type.Sliced:
				this.GenerateSlicedSprite(toFill);
				break;
			case Image.Type.Tiled:
				this.GenerateTiledSprite(toFill);
				break;
			case Image.Type.Filled:
				this.GenerateFilledSprite(toFill, this.m_PreserveAspect);
				break;
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00009E80 File Offset: 0x00008080
		private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect)
		{
			Vector4 drawingDimensions = this.GetDrawingDimensions(lPreserveAspect);
			Vector4 vector = ((!(this.overrideSprite != null)) ? Vector4.zero : DataUtility.GetOuterUV(this.overrideSprite));
			Color color = base.color;
			vh.Clear();
			vh.AddVert(new Vector3(drawingDimensions.x, drawingDimensions.y), color, new Vector2(vector.x, vector.y));
			vh.AddVert(new Vector3(drawingDimensions.x, drawingDimensions.w), color, new Vector2(vector.x, vector.w));
			vh.AddVert(new Vector3(drawingDimensions.z, drawingDimensions.w), color, new Vector2(vector.z, vector.w));
			vh.AddVert(new Vector3(drawingDimensions.z, drawingDimensions.y), color, new Vector2(vector.z, vector.y));
			vh.AddTriangle(0, 1, 2);
			vh.AddTriangle(2, 3, 0);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00009FA4 File Offset: 0x000081A4
		private void GenerateSlicedSprite(VertexHelper toFill)
		{
			if (!this.hasBorder)
			{
				this.GenerateSimpleSprite(toFill, false);
				return;
			}
			Vector4 vector;
			Vector4 vector2;
			Vector4 vector3;
			Vector4 vector4;
			if (this.overrideSprite != null)
			{
				vector = DataUtility.GetOuterUV(this.overrideSprite);
				vector2 = DataUtility.GetInnerUV(this.overrideSprite);
				vector3 = DataUtility.GetPadding(this.overrideSprite);
				vector4 = this.overrideSprite.border;
			}
			else
			{
				vector = Vector4.zero;
				vector2 = Vector4.zero;
				vector3 = Vector4.zero;
				vector4 = Vector4.zero;
			}
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			vector4 = this.GetAdjustedBorders(vector4 / this.pixelsPerUnit, pixelAdjustedRect);
			vector3 /= this.pixelsPerUnit;
			Image.s_VertScratch[0] = new Vector2(vector3.x, vector3.y);
			Image.s_VertScratch[3] = new Vector2(pixelAdjustedRect.width - vector3.z, pixelAdjustedRect.height - vector3.w);
			Image.s_VertScratch[1].x = vector4.x;
			Image.s_VertScratch[1].y = vector4.y;
			Image.s_VertScratch[2].x = pixelAdjustedRect.width - vector4.z;
			Image.s_VertScratch[2].y = pixelAdjustedRect.height - vector4.w;
			for (int i = 0; i < 4; i++)
			{
				Vector2[] array = Image.s_VertScratch;
				int num = i;
				array[num].x = array[num].x + pixelAdjustedRect.x;
				Vector2[] array2 = Image.s_VertScratch;
				int num2 = i;
				array2[num2].y = array2[num2].y + pixelAdjustedRect.y;
			}
			Image.s_UVScratch[0] = new Vector2(vector.x, vector.y);
			Image.s_UVScratch[1] = new Vector2(vector2.x, vector2.y);
			Image.s_UVScratch[2] = new Vector2(vector2.z, vector2.w);
			Image.s_UVScratch[3] = new Vector2(vector.z, vector.w);
			toFill.Clear();
			for (int j = 0; j < 3; j++)
			{
				int num3 = j + 1;
				for (int k = 0; k < 3; k++)
				{
					if (this.m_FillCenter || j != 1 || k != 1)
					{
						int num4 = k + 1;
						Image.AddQuad(toFill, new Vector2(Image.s_VertScratch[j].x, Image.s_VertScratch[k].y), new Vector2(Image.s_VertScratch[num3].x, Image.s_VertScratch[num4].y), base.color, new Vector2(Image.s_UVScratch[j].x, Image.s_UVScratch[k].y), new Vector2(Image.s_UVScratch[num3].x, Image.s_UVScratch[num4].y));
					}
				}
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000A2FC File Offset: 0x000084FC
		private void GenerateTiledSprite(VertexHelper toFill)
		{
			Vector4 vector;
			Vector4 vector2;
			Vector4 vector3;
			Vector2 vector4;
			if (this.overrideSprite != null)
			{
				vector = DataUtility.GetOuterUV(this.overrideSprite);
				vector2 = DataUtility.GetInnerUV(this.overrideSprite);
				vector3 = this.overrideSprite.border;
				vector4 = this.overrideSprite.rect.size;
			}
			else
			{
				vector = Vector4.zero;
				vector2 = Vector4.zero;
				vector3 = Vector4.zero;
				vector4 = Vector2.one * 100f;
			}
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			float num = (vector4.x - vector3.x - vector3.z) / this.pixelsPerUnit;
			float num2 = (vector4.y - vector3.y - vector3.w) / this.pixelsPerUnit;
			vector3 = this.GetAdjustedBorders(vector3 / this.pixelsPerUnit, pixelAdjustedRect);
			Vector2 vector5 = new Vector2(vector2.x, vector2.y);
			Vector2 vector6 = new Vector2(vector2.z, vector2.w);
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = base.color;
			float x = vector3.x;
			float num3 = pixelAdjustedRect.width - vector3.z;
			float y = vector3.y;
			float num4 = pixelAdjustedRect.height - vector3.w;
			toFill.Clear();
			Vector2 vector7 = vector6;
			if (num == 0f)
			{
				num = num3 - x;
			}
			if (num2 == 0f)
			{
				num2 = num4 - y;
			}
			if (this.m_FillCenter)
			{
				for (float num5 = y; num5 < num4; num5 += num2)
				{
					float num6 = num5 + num2;
					if (num6 > num4)
					{
						vector7.y = vector5.y + (vector6.y - vector5.y) * (num4 - num5) / (num6 - num5);
						num6 = num4;
					}
					vector7.x = vector6.x;
					for (float num7 = x; num7 < num3; num7 += num)
					{
						float num8 = num7 + num;
						if (num8 > num3)
						{
							vector7.x = vector5.x + (vector6.x - vector5.x) * (num3 - num7) / (num8 - num7);
							num8 = num3;
						}
						Image.AddQuad(toFill, new Vector2(num7, num5) + pixelAdjustedRect.position, new Vector2(num8, num6) + pixelAdjustedRect.position, base.color, vector5, vector7);
					}
				}
			}
			if (this.hasBorder)
			{
				vector7 = vector6;
				for (float num9 = y; num9 < num4; num9 += num2)
				{
					float num10 = num9 + num2;
					if (num10 > num4)
					{
						vector7.y = vector5.y + (vector6.y - vector5.y) * (num4 - num9) / (num10 - num9);
						num10 = num4;
					}
					Image.AddQuad(toFill, new Vector2(0f, num9) + pixelAdjustedRect.position, new Vector2(x, num10) + pixelAdjustedRect.position, base.color, new Vector2(vector.x, vector5.y), new Vector2(vector5.x, vector7.y));
					Image.AddQuad(toFill, new Vector2(num3, num9) + pixelAdjustedRect.position, new Vector2(pixelAdjustedRect.width, num10) + pixelAdjustedRect.position, base.color, new Vector2(vector6.x, vector5.y), new Vector2(vector.z, vector7.y));
				}
				vector7 = vector6;
				for (float num11 = x; num11 < num3; num11 += num)
				{
					float num12 = num11 + num;
					if (num12 > num3)
					{
						vector7.x = vector5.x + (vector6.x - vector5.x) * (num3 - num11) / (num12 - num11);
						num12 = num3;
					}
					Image.AddQuad(toFill, new Vector2(num11, 0f) + pixelAdjustedRect.position, new Vector2(num12, y) + pixelAdjustedRect.position, base.color, new Vector2(vector5.x, vector.y), new Vector2(vector7.x, vector5.y));
					Image.AddQuad(toFill, new Vector2(num11, num4) + pixelAdjustedRect.position, new Vector2(num12, pixelAdjustedRect.height) + pixelAdjustedRect.position, base.color, new Vector2(vector5.x, vector6.y), new Vector2(vector7.x, vector.w));
				}
				Image.AddQuad(toFill, new Vector2(0f, 0f) + pixelAdjustedRect.position, new Vector2(x, y) + pixelAdjustedRect.position, base.color, new Vector2(vector.x, vector.y), new Vector2(vector5.x, vector5.y));
				Image.AddQuad(toFill, new Vector2(num3, 0f) + pixelAdjustedRect.position, new Vector2(pixelAdjustedRect.width, y) + pixelAdjustedRect.position, base.color, new Vector2(vector6.x, vector.y), new Vector2(vector.z, vector5.y));
				Image.AddQuad(toFill, new Vector2(0f, num4) + pixelAdjustedRect.position, new Vector2(x, pixelAdjustedRect.height) + pixelAdjustedRect.position, base.color, new Vector2(vector.x, vector6.y), new Vector2(vector5.x, vector.w));
				Image.AddQuad(toFill, new Vector2(num3, num4) + pixelAdjustedRect.position, new Vector2(pixelAdjustedRect.width, pixelAdjustedRect.height) + pixelAdjustedRect.position, base.color, new Vector2(vector6.x, vector6.y), new Vector2(vector.z, vector.w));
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000A980 File Offset: 0x00008B80
		private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs)
		{
			int currentVertCount = vertexHelper.currentVertCount;
			for (int i = 0; i < 4; i++)
			{
				vertexHelper.AddVert(quadPositions[i], color, quadUVs[i]);
			}
			vertexHelper.AddTriangle(currentVertCount, currentVertCount + 1, currentVertCount + 2);
			vertexHelper.AddTriangle(currentVertCount + 2, currentVertCount + 3, currentVertCount);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000A9E4 File Offset: 0x00008BE4
		private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax)
		{
			int currentVertCount = vertexHelper.currentVertCount;
			vertexHelper.AddVert(new Vector3(posMin.x, posMin.y, 0f), color, new Vector2(uvMin.x, uvMin.y));
			vertexHelper.AddVert(new Vector3(posMin.x, posMax.y, 0f), color, new Vector2(uvMin.x, uvMax.y));
			vertexHelper.AddVert(new Vector3(posMax.x, posMax.y, 0f), color, new Vector2(uvMax.x, uvMax.y));
			vertexHelper.AddVert(new Vector3(posMax.x, posMin.y, 0f), color, new Vector2(uvMax.x, uvMin.y));
			vertexHelper.AddTriangle(currentVertCount, currentVertCount + 1, currentVertCount + 2);
			vertexHelper.AddTriangle(currentVertCount + 2, currentVertCount + 3, currentVertCount);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000AADC File Offset: 0x00008CDC
		private Vector4 GetAdjustedBorders(Vector4 border, Rect rect)
		{
			for (int i = 0; i <= 1; i++)
			{
				float num = border[i] + border[i + 2];
				if (rect.size[i] < num && num != 0f)
				{
					float num2 = rect.size[i] / num;
					ref Vector4 ptr = ref border;
					int num4;
					int num3 = (num4 = i);
					float num5 = ptr[num4];
					border[num3] = num5 * num2;
					ref Vector4 ptr2 = ref border;
					int num6 = (num4 = i + 2);
					num5 = ptr2[num4];
					border[num6] = num5 * num2;
				}
			}
			return border;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000AB84 File Offset: 0x00008D84
		private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect)
		{
			toFill.Clear();
			if (this.m_FillAmount < 0.001f)
			{
				return;
			}
			Vector4 drawingDimensions = this.GetDrawingDimensions(preserveAspect);
			Vector4 vector = ((!(this.overrideSprite != null)) ? Vector4.zero : DataUtility.GetOuterUV(this.overrideSprite));
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = base.color;
			float num = vector.x;
			float num2 = vector.y;
			float num3 = vector.z;
			float num4 = vector.w;
			if (this.m_FillMethod == Image.FillMethod.Horizontal || this.m_FillMethod == Image.FillMethod.Vertical)
			{
				if (this.fillMethod == Image.FillMethod.Horizontal)
				{
					float num5 = (num3 - num) * this.m_FillAmount;
					if (this.m_FillOrigin == 1)
					{
						drawingDimensions.x = drawingDimensions.z - (drawingDimensions.z - drawingDimensions.x) * this.m_FillAmount;
						num = num3 - num5;
					}
					else
					{
						drawingDimensions.z = drawingDimensions.x + (drawingDimensions.z - drawingDimensions.x) * this.m_FillAmount;
						num3 = num + num5;
					}
				}
				else if (this.fillMethod == Image.FillMethod.Vertical)
				{
					float num6 = (num4 - num2) * this.m_FillAmount;
					if (this.m_FillOrigin == 1)
					{
						drawingDimensions.y = drawingDimensions.w - (drawingDimensions.w - drawingDimensions.y) * this.m_FillAmount;
						num2 = num4 - num6;
					}
					else
					{
						drawingDimensions.w = drawingDimensions.y + (drawingDimensions.w - drawingDimensions.y) * this.m_FillAmount;
						num4 = num2 + num6;
					}
				}
			}
			Image.s_Xy[0] = new Vector2(drawingDimensions.x, drawingDimensions.y);
			Image.s_Xy[1] = new Vector2(drawingDimensions.x, drawingDimensions.w);
			Image.s_Xy[2] = new Vector2(drawingDimensions.z, drawingDimensions.w);
			Image.s_Xy[3] = new Vector2(drawingDimensions.z, drawingDimensions.y);
			Image.s_Uv[0] = new Vector2(num, num2);
			Image.s_Uv[1] = new Vector2(num, num4);
			Image.s_Uv[2] = new Vector2(num3, num4);
			Image.s_Uv[3] = new Vector2(num3, num2);
			if (this.m_FillAmount < 1f && this.m_FillMethod != Image.FillMethod.Horizontal && this.m_FillMethod != Image.FillMethod.Vertical)
			{
				if (this.fillMethod == Image.FillMethod.Radial90)
				{
					if (Image.RadialCut(Image.s_Xy, Image.s_Uv, this.m_FillAmount, this.m_FillClockwise, this.m_FillOrigin))
					{
						Image.AddQuad(toFill, Image.s_Xy, base.color, Image.s_Uv);
					}
				}
				else if (this.fillMethod == Image.FillMethod.Radial180)
				{
					for (int i = 0; i < 2; i++)
					{
						int num7 = ((this.m_FillOrigin <= 1) ? 0 : 1);
						float num8;
						float num9;
						float num10;
						float num11;
						if (this.m_FillOrigin == 0 || this.m_FillOrigin == 2)
						{
							num8 = 0f;
							num9 = 1f;
							if (i == num7)
							{
								num10 = 0f;
								num11 = 0.5f;
							}
							else
							{
								num10 = 0.5f;
								num11 = 1f;
							}
						}
						else
						{
							num10 = 0f;
							num11 = 1f;
							if (i == num7)
							{
								num8 = 0.5f;
								num9 = 1f;
							}
							else
							{
								num8 = 0f;
								num9 = 0.5f;
							}
						}
						Image.s_Xy[0].x = Mathf.Lerp(drawingDimensions.x, drawingDimensions.z, num10);
						Image.s_Xy[1].x = Image.s_Xy[0].x;
						Image.s_Xy[2].x = Mathf.Lerp(drawingDimensions.x, drawingDimensions.z, num11);
						Image.s_Xy[3].x = Image.s_Xy[2].x;
						Image.s_Xy[0].y = Mathf.Lerp(drawingDimensions.y, drawingDimensions.w, num8);
						Image.s_Xy[1].y = Mathf.Lerp(drawingDimensions.y, drawingDimensions.w, num9);
						Image.s_Xy[2].y = Image.s_Xy[1].y;
						Image.s_Xy[3].y = Image.s_Xy[0].y;
						Image.s_Uv[0].x = Mathf.Lerp(num, num3, num10);
						Image.s_Uv[1].x = Image.s_Uv[0].x;
						Image.s_Uv[2].x = Mathf.Lerp(num, num3, num11);
						Image.s_Uv[3].x = Image.s_Uv[2].x;
						Image.s_Uv[0].y = Mathf.Lerp(num2, num4, num8);
						Image.s_Uv[1].y = Mathf.Lerp(num2, num4, num9);
						Image.s_Uv[2].y = Image.s_Uv[1].y;
						Image.s_Uv[3].y = Image.s_Uv[0].y;
						float num12 = ((!this.m_FillClockwise) ? (this.m_FillAmount * 2f - (float)(1 - i)) : (this.fillAmount * 2f - (float)i));
						if (Image.RadialCut(Image.s_Xy, Image.s_Uv, Mathf.Clamp01(num12), this.m_FillClockwise, (i + this.m_FillOrigin + 3) % 4))
						{
							Image.AddQuad(toFill, Image.s_Xy, base.color, Image.s_Uv);
						}
					}
				}
				else if (this.fillMethod == Image.FillMethod.Radial360)
				{
					for (int j = 0; j < 4; j++)
					{
						float num13;
						float num14;
						if (j < 2)
						{
							num13 = 0f;
							num14 = 0.5f;
						}
						else
						{
							num13 = 0.5f;
							num14 = 1f;
						}
						float num15;
						float num16;
						if (j == 0 || j == 3)
						{
							num15 = 0f;
							num16 = 0.5f;
						}
						else
						{
							num15 = 0.5f;
							num16 = 1f;
						}
						Image.s_Xy[0].x = Mathf.Lerp(drawingDimensions.x, drawingDimensions.z, num13);
						Image.s_Xy[1].x = Image.s_Xy[0].x;
						Image.s_Xy[2].x = Mathf.Lerp(drawingDimensions.x, drawingDimensions.z, num14);
						Image.s_Xy[3].x = Image.s_Xy[2].x;
						Image.s_Xy[0].y = Mathf.Lerp(drawingDimensions.y, drawingDimensions.w, num15);
						Image.s_Xy[1].y = Mathf.Lerp(drawingDimensions.y, drawingDimensions.w, num16);
						Image.s_Xy[2].y = Image.s_Xy[1].y;
						Image.s_Xy[3].y = Image.s_Xy[0].y;
						Image.s_Uv[0].x = Mathf.Lerp(num, num3, num13);
						Image.s_Uv[1].x = Image.s_Uv[0].x;
						Image.s_Uv[2].x = Mathf.Lerp(num, num3, num14);
						Image.s_Uv[3].x = Image.s_Uv[2].x;
						Image.s_Uv[0].y = Mathf.Lerp(num2, num4, num15);
						Image.s_Uv[1].y = Mathf.Lerp(num2, num4, num16);
						Image.s_Uv[2].y = Image.s_Uv[1].y;
						Image.s_Uv[3].y = Image.s_Uv[0].y;
						float num17 = ((!this.m_FillClockwise) ? (this.m_FillAmount * 4f - (float)(3 - (j + this.m_FillOrigin) % 4)) : (this.m_FillAmount * 4f - (float)((j + this.m_FillOrigin) % 4)));
						if (Image.RadialCut(Image.s_Xy, Image.s_Uv, Mathf.Clamp01(num17), this.m_FillClockwise, (j + 2) % 4))
						{
							Image.AddQuad(toFill, Image.s_Xy, base.color, Image.s_Uv);
						}
					}
				}
			}
			else
			{
				Image.AddQuad(toFill, Image.s_Xy, base.color, Image.s_Uv);
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000B524 File Offset: 0x00009724
		private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner)
		{
			if (fill < 0.001f)
			{
				return false;
			}
			if ((corner & 1) == 1)
			{
				invert = !invert;
			}
			if (!invert && fill > 0.999f)
			{
				return true;
			}
			float num = Mathf.Clamp01(fill);
			if (invert)
			{
				num = 1f - num;
			}
			num *= 1.5707964f;
			float num2 = Mathf.Cos(num);
			float num3 = Mathf.Sin(num);
			Image.RadialCut(xy, num2, num3, invert, corner);
			Image.RadialCut(uv, num2, num3, invert, corner);
			return true;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000B5A4 File Offset: 0x000097A4
		private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner)
		{
			int num = (corner + 1) % 4;
			int num2 = (corner + 2) % 4;
			int num3 = (corner + 3) % 4;
			if ((corner & 1) == 1)
			{
				if (sin > cos)
				{
					cos /= sin;
					sin = 1f;
					if (invert)
					{
						xy[num].x = Mathf.Lerp(xy[corner].x, xy[num2].x, cos);
						xy[num2].x = xy[num].x;
					}
				}
				else if (cos > sin)
				{
					sin /= cos;
					cos = 1f;
					if (!invert)
					{
						xy[num2].y = Mathf.Lerp(xy[corner].y, xy[num2].y, sin);
						xy[num3].y = xy[num2].y;
					}
				}
				else
				{
					cos = 1f;
					sin = 1f;
				}
				if (!invert)
				{
					xy[num3].x = Mathf.Lerp(xy[corner].x, xy[num2].x, cos);
				}
				else
				{
					xy[num].y = Mathf.Lerp(xy[corner].y, xy[num2].y, sin);
				}
			}
			else
			{
				if (cos > sin)
				{
					sin /= cos;
					cos = 1f;
					if (!invert)
					{
						xy[num].y = Mathf.Lerp(xy[corner].y, xy[num2].y, sin);
						xy[num2].y = xy[num].y;
					}
				}
				else if (sin > cos)
				{
					cos /= sin;
					sin = 1f;
					if (invert)
					{
						xy[num2].x = Mathf.Lerp(xy[corner].x, xy[num2].x, cos);
						xy[num3].x = xy[num2].x;
					}
				}
				else
				{
					cos = 1f;
					sin = 1f;
				}
				if (invert)
				{
					xy[num3].y = Mathf.Lerp(xy[corner].y, xy[num2].y, sin);
				}
				else
				{
					xy[num].x = Mathf.Lerp(xy[corner].x, xy[num2].x, cos);
				}
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000B834 File Offset: 0x00009A34
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000B838 File Offset: 0x00009A38
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000B83C File Offset: 0x00009A3C
		public virtual float minWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000B844 File Offset: 0x00009A44
		public virtual float preferredWidth
		{
			get
			{
				if (this.overrideSprite == null)
				{
					return 0f;
				}
				if (this.type == Image.Type.Sliced || this.type == Image.Type.Tiled)
				{
					return DataUtility.GetMinSize(this.overrideSprite).x / this.pixelsPerUnit;
				}
				return this.overrideSprite.rect.size.x / this.pixelsPerUnit;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000B8C0 File Offset: 0x00009AC0
		public virtual float flexibleWidth
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		public virtual float minHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		public virtual float preferredHeight
		{
			get
			{
				if (this.overrideSprite == null)
				{
					return 0f;
				}
				if (this.type == Image.Type.Sliced || this.type == Image.Type.Tiled)
				{
					return DataUtility.GetMinSize(this.overrideSprite).y / this.pixelsPerUnit;
				}
				return this.overrideSprite.rect.size.y / this.pixelsPerUnit;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0000B94C File Offset: 0x00009B4C
		public virtual float flexibleHeight
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000B954 File Offset: 0x00009B54
		public virtual int layoutPriority
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000B958 File Offset: 0x00009B58
		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			if (this.m_EventAlphaThreshold >= 1f)
			{
				return true;
			}
			Sprite overrideSprite = this.overrideSprite;
			if (overrideSprite == null)
			{
				return true;
			}
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(base.rectTransform, screenPoint, eventCamera, out vector);
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			vector.x += base.rectTransform.pivot.x * pixelAdjustedRect.width;
			vector.y += base.rectTransform.pivot.y * pixelAdjustedRect.height;
			vector = this.MapCoordinate(vector, pixelAdjustedRect);
			Rect textureRect = overrideSprite.textureRect;
			Vector2 vector2 = new Vector2(vector.x / textureRect.width, vector.y / textureRect.height);
			float num = Mathf.Lerp(textureRect.x, textureRect.xMax, vector2.x) / (float)overrideSprite.texture.width;
			float num2 = Mathf.Lerp(textureRect.y, textureRect.yMax, vector2.y) / (float)overrideSprite.texture.height;
			bool flag;
			try
			{
				flag = overrideSprite.texture.GetPixelBilinear(num, num2).a >= this.m_EventAlphaThreshold;
			}
			catch (UnityException ex)
			{
				Debug.LogError("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. " + ex.Message + " Also make sure to disable sprite packing for this sprite.", this);
				flag = true;
			}
			return flag;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000BAF8 File Offset: 0x00009CF8
		private Vector2 MapCoordinate(Vector2 local, Rect rect)
		{
			Rect rect2 = this.sprite.rect;
			if (this.type == Image.Type.Simple || this.type == Image.Type.Filled)
			{
				return new Vector2(local.x * rect2.width / rect.width, local.y * rect2.height / rect.height);
			}
			Vector4 border = this.sprite.border;
			Vector4 adjustedBorders = this.GetAdjustedBorders(border / this.pixelsPerUnit, rect);
			for (int i = 0; i < 2; i++)
			{
				if (local[i] > adjustedBorders[i])
				{
					if (rect.size[i] - local[i] <= adjustedBorders[i + 2])
					{
						ref Vector2 ptr = ref local;
						int num2;
						int num = (num2 = i);
						float num3 = ptr[num2];
						local[num] = num3 - (rect.size[i] - rect2.size[i]);
					}
					else if (this.type == Image.Type.Sliced)
					{
						float num4 = Mathf.InverseLerp(adjustedBorders[i], rect.size[i] - adjustedBorders[i + 2], local[i]);
						local[i] = Mathf.Lerp(border[i], rect2.size[i] - border[i + 2], num4);
					}
					else
					{
						ref Vector2 ptr2 = ref local;
						int num2;
						int num5 = (num2 = i);
						float num3 = ptr2[num2];
						local[num5] = num3 - adjustedBorders[i];
						local[i] = Mathf.Repeat(local[i], rect2.size[i] - border[i] - border[i + 2]);
						ref Vector2 ptr3 = ref local;
						int num6 = (num2 = i);
						num3 = ptr3[num2];
						local[num6] = num3 + border[i];
					}
				}
			}
			return local;
		}

		// Token: 0x0400010E RID: 270
		[SerializeField]
		[FormerlySerializedAs("m_Frame")]
		private Sprite m_Sprite;

		// Token: 0x0400010F RID: 271
		[NonSerialized]
		private Sprite m_OverrideSprite;

		// Token: 0x04000110 RID: 272
		[SerializeField]
		private Image.Type m_Type;

		// Token: 0x04000111 RID: 273
		[SerializeField]
		private bool m_PreserveAspect;

		// Token: 0x04000112 RID: 274
		[SerializeField]
		private bool m_FillCenter = true;

		// Token: 0x04000113 RID: 275
		[SerializeField]
		private Image.FillMethod m_FillMethod = Image.FillMethod.Radial360;

		// Token: 0x04000114 RID: 276
		[Range(0f, 1f)]
		[SerializeField]
		private float m_FillAmount = 1f;

		// Token: 0x04000115 RID: 277
		[SerializeField]
		private bool m_FillClockwise = true;

		// Token: 0x04000116 RID: 278
		[SerializeField]
		private int m_FillOrigin;

		// Token: 0x04000117 RID: 279
		private float m_EventAlphaThreshold = 1f;

		// Token: 0x04000118 RID: 280
		private static readonly Vector2[] s_VertScratch = new Vector2[4];

		// Token: 0x04000119 RID: 281
		private static readonly Vector2[] s_UVScratch = new Vector2[4];

		// Token: 0x0400011A RID: 282
		private static readonly Vector3[] s_Xy = new Vector3[4];

		// Token: 0x0400011B RID: 283
		private static readonly Vector3[] s_Uv = new Vector3[4];

		// Token: 0x0200004C RID: 76
		public enum Type
		{
			// Token: 0x0400011D RID: 285
			Simple,
			// Token: 0x0400011E RID: 286
			Sliced,
			// Token: 0x0400011F RID: 287
			Tiled,
			// Token: 0x04000120 RID: 288
			Filled
		}

		// Token: 0x0200004D RID: 77
		public enum FillMethod
		{
			// Token: 0x04000122 RID: 290
			Horizontal,
			// Token: 0x04000123 RID: 291
			Vertical,
			// Token: 0x04000124 RID: 292
			Radial90,
			// Token: 0x04000125 RID: 293
			Radial180,
			// Token: 0x04000126 RID: 294
			Radial360
		}

		// Token: 0x0200004E RID: 78
		public enum OriginHorizontal
		{
			// Token: 0x04000128 RID: 296
			Left,
			// Token: 0x04000129 RID: 297
			Right
		}

		// Token: 0x0200004F RID: 79
		public enum OriginVertical
		{
			// Token: 0x0400012B RID: 299
			Bottom,
			// Token: 0x0400012C RID: 300
			Top
		}

		// Token: 0x02000050 RID: 80
		public enum Origin90
		{
			// Token: 0x0400012E RID: 302
			BottomLeft,
			// Token: 0x0400012F RID: 303
			TopLeft,
			// Token: 0x04000130 RID: 304
			TopRight,
			// Token: 0x04000131 RID: 305
			BottomRight
		}

		// Token: 0x02000051 RID: 81
		public enum Origin180
		{
			// Token: 0x04000133 RID: 307
			Bottom,
			// Token: 0x04000134 RID: 308
			Left,
			// Token: 0x04000135 RID: 309
			Top,
			// Token: 0x04000136 RID: 310
			Right
		}

		// Token: 0x02000052 RID: 82
		public enum Origin360
		{
			// Token: 0x04000138 RID: 312
			Bottom,
			// Token: 0x04000139 RID: 313
			Right,
			// Token: 0x0400013A RID: 314
			Top,
			// Token: 0x0400013B RID: 315
			Left
		}
	}
}
