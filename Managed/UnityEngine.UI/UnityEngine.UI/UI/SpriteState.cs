using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000076 RID: 118
	[Serializable]
	public struct SpriteState
	{
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00014044 File Offset: 0x00012244
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x0001404C File Offset: 0x0001224C
		public Sprite highlightedSprite
		{
			get
			{
				return this.m_HighlightedSprite;
			}
			set
			{
				this.m_HighlightedSprite = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00014058 File Offset: 0x00012258
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00014060 File Offset: 0x00012260
		public Sprite pressedSprite
		{
			get
			{
				return this.m_PressedSprite;
			}
			set
			{
				this.m_PressedSprite = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0001406C File Offset: 0x0001226C
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x00014074 File Offset: 0x00012274
		public Sprite disabledSprite
		{
			get
			{
				return this.m_DisabledSprite;
			}
			set
			{
				this.m_DisabledSprite = value;
			}
		}

		// Token: 0x04000216 RID: 534
		[SerializeField]
		[FormerlySerializedAs("m_SelectedSprite")]
		[FormerlySerializedAs("highlightedSprite")]
		private Sprite m_HighlightedSprite;

		// Token: 0x04000217 RID: 535
		[SerializeField]
		[FormerlySerializedAs("pressedSprite")]
		private Sprite m_PressedSprite;

		// Token: 0x04000218 RID: 536
		[SerializeField]
		[FormerlySerializedAs("disabledSprite")]
		private Sprite m_DisabledSprite;
	}
}
