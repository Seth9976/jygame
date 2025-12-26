using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000044 RID: 68
	[Serializable]
	public class FontData : ISerializationCallbackReceiver
	{
		// Token: 0x060001DE RID: 478 RVA: 0x000081A0 File Offset: 0x000063A0
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000081A4 File Offset: 0x000063A4
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			this.m_FontSize = Mathf.Clamp(this.m_FontSize, 0, 300);
			this.m_MinSize = Mathf.Clamp(this.m_MinSize, 0, 300);
			this.m_MaxSize = Mathf.Clamp(this.m_MaxSize, 0, 300);
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000081F8 File Offset: 0x000063F8
		public static FontData defaultFontData
		{
			get
			{
				return new FontData
				{
					m_FontSize = 14,
					m_LineSpacing = 1f,
					m_FontStyle = FontStyle.Normal,
					m_BestFit = false,
					m_MinSize = 10,
					m_MaxSize = 40,
					m_Alignment = TextAnchor.UpperLeft,
					m_HorizontalOverflow = HorizontalWrapMode.Wrap,
					m_VerticalOverflow = VerticalWrapMode.Truncate,
					m_RichText = true
				};
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000825C File Offset: 0x0000645C
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00008264 File Offset: 0x00006464
		public Font font
		{
			get
			{
				return this.m_Font;
			}
			set
			{
				this.m_Font = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00008270 File Offset: 0x00006470
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00008278 File Offset: 0x00006478
		public int fontSize
		{
			get
			{
				return this.m_FontSize;
			}
			set
			{
				this.m_FontSize = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00008284 File Offset: 0x00006484
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x0000828C File Offset: 0x0000648C
		public FontStyle fontStyle
		{
			get
			{
				return this.m_FontStyle;
			}
			set
			{
				this.m_FontStyle = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00008298 File Offset: 0x00006498
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x000082A0 File Offset: 0x000064A0
		public bool bestFit
		{
			get
			{
				return this.m_BestFit;
			}
			set
			{
				this.m_BestFit = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000082AC File Offset: 0x000064AC
		// (set) Token: 0x060001EA RID: 490 RVA: 0x000082B4 File Offset: 0x000064B4
		public int minSize
		{
			get
			{
				return this.m_MinSize;
			}
			set
			{
				this.m_MinSize = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000082C0 File Offset: 0x000064C0
		// (set) Token: 0x060001EC RID: 492 RVA: 0x000082C8 File Offset: 0x000064C8
		public int maxSize
		{
			get
			{
				return this.m_MaxSize;
			}
			set
			{
				this.m_MaxSize = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001ED RID: 493 RVA: 0x000082D4 File Offset: 0x000064D4
		// (set) Token: 0x060001EE RID: 494 RVA: 0x000082DC File Offset: 0x000064DC
		public TextAnchor alignment
		{
			get
			{
				return this.m_Alignment;
			}
			set
			{
				this.m_Alignment = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000082E8 File Offset: 0x000064E8
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x000082F0 File Offset: 0x000064F0
		public bool richText
		{
			get
			{
				return this.m_RichText;
			}
			set
			{
				this.m_RichText = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x000082FC File Offset: 0x000064FC
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00008304 File Offset: 0x00006504
		public HorizontalWrapMode horizontalOverflow
		{
			get
			{
				return this.m_HorizontalOverflow;
			}
			set
			{
				this.m_HorizontalOverflow = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00008310 File Offset: 0x00006510
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00008318 File Offset: 0x00006518
		public VerticalWrapMode verticalOverflow
		{
			get
			{
				return this.m_VerticalOverflow;
			}
			set
			{
				this.m_VerticalOverflow = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00008324 File Offset: 0x00006524
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x0000832C File Offset: 0x0000652C
		public float lineSpacing
		{
			get
			{
				return this.m_LineSpacing;
			}
			set
			{
				this.m_LineSpacing = value;
			}
		}

		// Token: 0x040000E1 RID: 225
		[FormerlySerializedAs("font")]
		[SerializeField]
		private Font m_Font;

		// Token: 0x040000E2 RID: 226
		[FormerlySerializedAs("fontSize")]
		[SerializeField]
		private int m_FontSize;

		// Token: 0x040000E3 RID: 227
		[FormerlySerializedAs("fontStyle")]
		[SerializeField]
		private FontStyle m_FontStyle;

		// Token: 0x040000E4 RID: 228
		[SerializeField]
		private bool m_BestFit;

		// Token: 0x040000E5 RID: 229
		[SerializeField]
		private int m_MinSize;

		// Token: 0x040000E6 RID: 230
		[SerializeField]
		private int m_MaxSize;

		// Token: 0x040000E7 RID: 231
		[FormerlySerializedAs("alignment")]
		[SerializeField]
		private TextAnchor m_Alignment;

		// Token: 0x040000E8 RID: 232
		[SerializeField]
		[FormerlySerializedAs("richText")]
		private bool m_RichText;

		// Token: 0x040000E9 RID: 233
		[SerializeField]
		private HorizontalWrapMode m_HorizontalOverflow;

		// Token: 0x040000EA RID: 234
		[SerializeField]
		private VerticalWrapMode m_VerticalOverflow;

		// Token: 0x040000EB RID: 235
		[SerializeField]
		private float m_LineSpacing;
	}
}
