using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200003C RID: 60
	[Serializable]
	public struct ColorBlock
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00005E48 File Offset: 0x00004048
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00005E50 File Offset: 0x00004050
		public Color normalColor
		{
			get
			{
				return this.m_NormalColor;
			}
			set
			{
				this.m_NormalColor = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00005E5C File Offset: 0x0000405C
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00005E64 File Offset: 0x00004064
		public Color highlightedColor
		{
			get
			{
				return this.m_HighlightedColor;
			}
			set
			{
				this.m_HighlightedColor = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00005E70 File Offset: 0x00004070
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00005E78 File Offset: 0x00004078
		public Color pressedColor
		{
			get
			{
				return this.m_PressedColor;
			}
			set
			{
				this.m_PressedColor = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00005E84 File Offset: 0x00004084
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00005E8C File Offset: 0x0000408C
		public Color disabledColor
		{
			get
			{
				return this.m_DisabledColor;
			}
			set
			{
				this.m_DisabledColor = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00005E98 File Offset: 0x00004098
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00005EA0 File Offset: 0x000040A0
		public float colorMultiplier
		{
			get
			{
				return this.m_ColorMultiplier;
			}
			set
			{
				this.m_ColorMultiplier = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00005EAC File Offset: 0x000040AC
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00005EB4 File Offset: 0x000040B4
		public float fadeDuration
		{
			get
			{
				return this.m_FadeDuration;
			}
			set
			{
				this.m_FadeDuration = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00005EC0 File Offset: 0x000040C0
		public static ColorBlock defaultColorBlock
		{
			get
			{
				return new ColorBlock
				{
					m_NormalColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue),
					m_HighlightedColor = new Color32(245, 245, 245, byte.MaxValue),
					m_PressedColor = new Color32(200, 200, 200, byte.MaxValue),
					m_DisabledColor = new Color32(200, 200, 200, 128),
					colorMultiplier = 1f,
					fadeDuration = 0.1f
				};
			}
		}

		// Token: 0x040000B7 RID: 183
		[FormerlySerializedAs("normalColor")]
		[SerializeField]
		private Color m_NormalColor;

		// Token: 0x040000B8 RID: 184
		[FormerlySerializedAs("highlightedColor")]
		[FormerlySerializedAs("m_SelectedColor")]
		[SerializeField]
		private Color m_HighlightedColor;

		// Token: 0x040000B9 RID: 185
		[SerializeField]
		[FormerlySerializedAs("pressedColor")]
		private Color m_PressedColor;

		// Token: 0x040000BA RID: 186
		[SerializeField]
		[FormerlySerializedAs("disabledColor")]
		private Color m_DisabledColor;

		// Token: 0x040000BB RID: 187
		[SerializeField]
		[Range(1f, 5f)]
		private float m_ColorMultiplier;

		// Token: 0x040000BC RID: 188
		[SerializeField]
		[FormerlySerializedAs("fadeDuration")]
		private float m_FadeDuration;
	}
}
