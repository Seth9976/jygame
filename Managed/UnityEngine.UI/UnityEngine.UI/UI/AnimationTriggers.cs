using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000036 RID: 54
	[Serializable]
	public class AnimationTriggers
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0000580C File Offset: 0x00003A0C
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00005814 File Offset: 0x00003A14
		public string normalTrigger
		{
			get
			{
				return this.m_NormalTrigger;
			}
			set
			{
				this.m_NormalTrigger = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00005820 File Offset: 0x00003A20
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00005828 File Offset: 0x00003A28
		public string highlightedTrigger
		{
			get
			{
				return this.m_HighlightedTrigger;
			}
			set
			{
				this.m_HighlightedTrigger = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00005834 File Offset: 0x00003A34
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0000583C File Offset: 0x00003A3C
		public string pressedTrigger
		{
			get
			{
				return this.m_PressedTrigger;
			}
			set
			{
				this.m_PressedTrigger = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00005848 File Offset: 0x00003A48
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00005850 File Offset: 0x00003A50
		public string disabledTrigger
		{
			get
			{
				return this.m_DisabledTrigger;
			}
			set
			{
				this.m_DisabledTrigger = value;
			}
		}

		// Token: 0x040000A1 RID: 161
		private const string kDefaultNormalAnimName = "Normal";

		// Token: 0x040000A2 RID: 162
		private const string kDefaultSelectedAnimName = "Highlighted";

		// Token: 0x040000A3 RID: 163
		private const string kDefaultPressedAnimName = "Pressed";

		// Token: 0x040000A4 RID: 164
		private const string kDefaultDisabledAnimName = "Disabled";

		// Token: 0x040000A5 RID: 165
		[FormerlySerializedAs("normalTrigger")]
		[SerializeField]
		private string m_NormalTrigger = "Normal";

		// Token: 0x040000A6 RID: 166
		[FormerlySerializedAs("highlightedTrigger")]
		[SerializeField]
		[FormerlySerializedAs("m_SelectedTrigger")]
		private string m_HighlightedTrigger = "Highlighted";

		// Token: 0x040000A7 RID: 167
		[SerializeField]
		[FormerlySerializedAs("pressedTrigger")]
		private string m_PressedTrigger = "Pressed";

		// Token: 0x040000A8 RID: 168
		[FormerlySerializedAs("disabledTrigger")]
		[SerializeField]
		private string m_DisabledTrigger = "Disabled";
	}
}
