using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000045 RID: 69
	public static class FontUpdateTracker
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x00008344 File Offset: 0x00006544
		public static void TrackText(Text t)
		{
			if (t.font == null)
			{
				return;
			}
			List<Text> list;
			FontUpdateTracker.m_Tracked.TryGetValue(t.font, out list);
			if (list == null)
			{
				if (FontUpdateTracker.m_Tracked.Count == 0)
				{
					Font.textureRebuilt += FontUpdateTracker.RebuildForFont;
				}
				list = new List<Text>();
				FontUpdateTracker.m_Tracked.Add(t.font, list);
			}
			if (!list.Contains(t))
			{
				list.Add(t);
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000083C8 File Offset: 0x000065C8
		private static void RebuildForFont(Font f)
		{
			List<Text> list;
			FontUpdateTracker.m_Tracked.TryGetValue(f, out list);
			if (list == null)
			{
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].FontTextureChanged();
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00008410 File Offset: 0x00006610
		public static void UntrackText(Text t)
		{
			if (t.font == null)
			{
				return;
			}
			List<Text> list;
			FontUpdateTracker.m_Tracked.TryGetValue(t.font, out list);
			if (list == null)
			{
				return;
			}
			list.Remove(t);
			if (list.Count == 0)
			{
				FontUpdateTracker.m_Tracked.Remove(t.font);
				if (FontUpdateTracker.m_Tracked.Count == 0)
				{
					Font.textureRebuilt -= FontUpdateTracker.RebuildForFont;
				}
			}
		}

		// Token: 0x040000EC RID: 236
		private static Dictionary<Font, List<Text>> m_Tracked = new Dictionary<Font, List<Text>>();
	}
}
