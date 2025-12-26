using System;

namespace DG.Tweening.Core.Easing
{
	// Token: 0x02000032 RID: 50
	public static class Bounce
	{
		// Token: 0x06000173 RID: 371 RVA: 0x0000978C File Offset: 0x0000798C
		public static float EaseIn(float time, float startValue, float changeValue, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			return changeValue - Bounce.EaseOut(duration - time, 0f, changeValue, duration, -1f, -1f) + startValue;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000097AC File Offset: 0x000079AC
		public static float EaseOut(float time, float startValue, float changeValue, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			if ((time /= duration) < 0.36363637f)
			{
				return changeValue * (7.5625f * time * time) + startValue;
			}
			if (time < 0.72727275f)
			{
				return changeValue * (7.5625f * (time -= 0.54545456f) * time + 0.75f) + startValue;
			}
			if (time < 0.90909094f)
			{
				return changeValue * (7.5625f * (time -= 0.8181818f) * time + 0.9375f) + startValue;
			}
			return changeValue * (7.5625f * (time -= 0.95454544f) * time + 0.984375f) + startValue;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000983C File Offset: 0x00007A3C
		public static float EaseInOut(float time, float startValue, float changeValue, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			if (time < duration * 0.5f)
			{
				return Bounce.EaseIn(time * 2f, 0f, changeValue, duration, -1f, -1f) * 0.5f + startValue;
			}
			return Bounce.EaseOut(time * 2f - duration, 0f, changeValue, duration, -1f, -1f) * 0.5f + changeValue * 0.5f + startValue;
		}
	}
}
