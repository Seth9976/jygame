using System;

namespace DG.Tweening.Core.Easing
{
	// Token: 0x02000042 RID: 66
	public static class EaseManager
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x0000B1E8 File Offset: 0x000093E8
		public static float Evaluate(Tween t, float time, float startValue, float changeValue, float duration, float overshootOrAmplitude, float period)
		{
			switch (t.easeType)
			{
			case Ease.Linear:
				return changeValue * time / duration + startValue;
			case Ease.InSine:
				return -changeValue * (float)Math.Cos((double)(time / duration * 1.5707964f)) + changeValue + startValue;
			case Ease.OutSine:
				return changeValue * (float)Math.Sin((double)(time / duration * 1.5707964f)) + startValue;
			case Ease.InOutSine:
				return -changeValue * 0.5f * ((float)Math.Cos((double)(3.1415927f * time / duration)) - 1f) + startValue;
			case Ease.InQuad:
				return changeValue * (time /= duration) * time + startValue;
			case Ease.OutQuad:
				return -changeValue * (time /= duration) * (time - 2f) + startValue;
			case Ease.InOutQuad:
				if ((time /= duration * 0.5f) < 1f)
				{
					return changeValue * 0.5f * time * time + startValue;
				}
				return -changeValue * 0.5f * ((time -= 1f) * (time - 2f) - 1f) + startValue;
			case Ease.InCubic:
				return changeValue * (time /= duration) * time * time + startValue;
			case Ease.OutCubic:
				return changeValue * ((time = time / duration - 1f) * time * time + 1f) + startValue;
			case Ease.InOutCubic:
				if ((time /= duration * 0.5f) < 1f)
				{
					return changeValue * 0.5f * time * time * time + startValue;
				}
				return changeValue * 0.5f * ((time -= 2f) * time * time + 2f) + startValue;
			case Ease.InQuart:
				return changeValue * (time /= duration) * time * time * time + startValue;
			case Ease.OutQuart:
				return -changeValue * ((time = time / duration - 1f) * time * time * time - 1f) + startValue;
			case Ease.InOutQuart:
				if ((time /= duration * 0.5f) < 1f)
				{
					return changeValue * 0.5f * time * time * time * time + startValue;
				}
				return -changeValue * 0.5f * ((time -= 2f) * time * time * time - 2f) + startValue;
			case Ease.InQuint:
				return changeValue * (time /= duration) * time * time * time * time + startValue;
			case Ease.OutQuint:
				return changeValue * ((time = time / duration - 1f) * time * time * time * time + 1f) + startValue;
			case Ease.InOutQuint:
				if ((time /= duration * 0.5f) < 1f)
				{
					return changeValue * 0.5f * time * time * time * time * time + startValue;
				}
				return changeValue * 0.5f * ((time -= 2f) * time * time * time * time + 2f) + startValue;
			case Ease.InExpo:
				if (time != 0f)
				{
					return changeValue * (float)Math.Pow(2.0, (double)(10f * (time / duration - 1f))) + startValue;
				}
				return startValue;
			case Ease.OutExpo:
				if (time == duration)
				{
					return startValue + changeValue;
				}
				return changeValue * (-(float)Math.Pow(2.0, (double)(-10f * time / duration)) + 1f) + startValue;
			case Ease.InOutExpo:
				if (time == 0f)
				{
					return startValue;
				}
				if (time == duration)
				{
					return startValue + changeValue;
				}
				if ((time /= duration * 0.5f) < 1f)
				{
					return changeValue * 0.5f * (float)Math.Pow(2.0, (double)(10f * (time - 1f))) + startValue;
				}
				return changeValue * 0.5f * (-(float)Math.Pow(2.0, (double)(-10f * (time -= 1f))) + 2f) + startValue;
			case Ease.InCirc:
				return -changeValue * ((float)Math.Sqrt((double)(1f - (time /= duration) * time)) - 1f) + startValue;
			case Ease.OutCirc:
				return changeValue * (float)Math.Sqrt((double)(1f - (time = time / duration - 1f) * time)) + startValue;
			case Ease.InOutCirc:
				if ((time /= duration * 0.5f) < 1f)
				{
					return -changeValue * 0.5f * ((float)Math.Sqrt((double)(1f - time * time)) - 1f) + startValue;
				}
				return changeValue * 0.5f * ((float)Math.Sqrt((double)(1f - (time -= 2f) * time)) + 1f) + startValue;
			case Ease.InElastic:
			{
				if (time == 0f)
				{
					return startValue;
				}
				if ((time /= duration) == 1f)
				{
					return startValue + changeValue;
				}
				if (period == 0f)
				{
					period = duration * 0.3f;
				}
				float num;
				if (overshootOrAmplitude == 0f || (changeValue > 0f && overshootOrAmplitude < changeValue) || (changeValue < 0f && overshootOrAmplitude < -changeValue))
				{
					overshootOrAmplitude = changeValue;
					num = period / 4f;
				}
				else
				{
					num = period / 6.2831855f * (float)Math.Asin((double)(changeValue / overshootOrAmplitude));
				}
				return -(overshootOrAmplitude * (float)Math.Pow(2.0, (double)(10f * (time -= 1f))) * (float)Math.Sin((double)((time * duration - num) * 6.2831855f / period))) + startValue;
			}
			case Ease.OutElastic:
			{
				if (time == 0f)
				{
					return startValue;
				}
				if ((time /= duration) == 1f)
				{
					return startValue + changeValue;
				}
				if (period == 0f)
				{
					period = duration * 0.3f;
				}
				float num2;
				if (overshootOrAmplitude == 0f || (changeValue > 0f && overshootOrAmplitude < changeValue) || (changeValue < 0f && overshootOrAmplitude < -changeValue))
				{
					overshootOrAmplitude = changeValue;
					num2 = period / 4f;
				}
				else
				{
					num2 = period / 6.2831855f * (float)Math.Asin((double)(changeValue / overshootOrAmplitude));
				}
				return overshootOrAmplitude * (float)Math.Pow(2.0, (double)(-10f * time)) * (float)Math.Sin((double)((time * duration - num2) * 6.2831855f / period)) + changeValue + startValue;
			}
			case Ease.InOutElastic:
			{
				if (time == 0f)
				{
					return startValue;
				}
				if ((time /= duration * 0.5f) == 2f)
				{
					return startValue + changeValue;
				}
				if (period == 0f)
				{
					period = duration * 0.45000002f;
				}
				float num3;
				if (overshootOrAmplitude == 0f || (changeValue > 0f && overshootOrAmplitude < changeValue) || (changeValue < 0f && overshootOrAmplitude < -changeValue))
				{
					overshootOrAmplitude = changeValue;
					num3 = period / 4f;
				}
				else
				{
					num3 = period / 6.2831855f * (float)Math.Asin((double)(changeValue / overshootOrAmplitude));
				}
				if (time < 1f)
				{
					return -0.5f * (overshootOrAmplitude * (float)Math.Pow(2.0, (double)(10f * (time -= 1f))) * (float)Math.Sin((double)((time * duration - num3) * 6.2831855f / period))) + startValue;
				}
				return overshootOrAmplitude * (float)Math.Pow(2.0, (double)(-10f * (time -= 1f))) * (float)Math.Sin((double)((time * duration - num3) * 6.2831855f / period)) * 0.5f + changeValue + startValue;
			}
			case Ease.InBack:
				return changeValue * (time /= duration) * time * ((overshootOrAmplitude + 1f) * time - overshootOrAmplitude) + startValue;
			case Ease.OutBack:
				return changeValue * ((time = time / duration - 1f) * time * ((overshootOrAmplitude + 1f) * time + overshootOrAmplitude) + 1f) + startValue;
			case Ease.InOutBack:
				if ((time /= duration * 0.5f) < 1f)
				{
					return changeValue * 0.5f * (time * time * (((overshootOrAmplitude *= 1.525f) + 1f) * time - overshootOrAmplitude)) + startValue;
				}
				return changeValue / 2f * ((time -= 2f) * time * (((overshootOrAmplitude *= 1.525f) + 1f) * time + overshootOrAmplitude) + 2f) + startValue;
			case Ease.InBounce:
				return Bounce.EaseIn(time, startValue, changeValue, duration, overshootOrAmplitude, period);
			case Ease.OutBounce:
				return Bounce.EaseOut(time, startValue, changeValue, duration, overshootOrAmplitude, period);
			case Ease.InOutBounce:
				return Bounce.EaseInOut(time, startValue, changeValue, duration, overshootOrAmplitude, period);
			case Ease.INTERNAL_Zero:
				return startValue + changeValue;
			case Ease.INTERNAL_Custom:
				return t.customEase(time, startValue, changeValue, duration, overshootOrAmplitude, period);
			default:
				return -changeValue * (time /= duration) * (time - 2f) + startValue;
			}
		}

		// Token: 0x04000124 RID: 292
		private const float _PiOver2 = 1.5707964f;

		// Token: 0x04000125 RID: 293
		private const float _TwoPi = 6.2831855f;
	}
}
