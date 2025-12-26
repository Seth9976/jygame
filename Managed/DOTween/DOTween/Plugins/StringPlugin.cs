using System;
using System.Text;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000034 RID: 52
	public class StringPlugin : ABSTweenPlugin<string, string, StringOptions>
	{
		// Token: 0x06000176 RID: 374 RVA: 0x000098A8 File Offset: 0x00007AA8
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, bool isRelative)
		{
			string endValue = t.endValue;
			t.endValue = t.getter();
			t.startValue = endValue;
			t.setter(t.startValue);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000098E8 File Offset: 0x00007AE8
		public override void Reset(TweenerCore<string, string, StringOptions> t)
		{
			t.startValue = (t.endValue = (t.changeValue = null));
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000990E File Offset: 0x00007B0E
		public override string ConvertToStartValue(TweenerCore<string, string, StringOptions> t, string value)
		{
			return value;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00009911 File Offset: 0x00007B11
		public override void SetRelativeEndValue(TweenerCore<string, string, StringOptions> t)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00009913 File Offset: 0x00007B13
		public override void SetChangeValue(TweenerCore<string, string, StringOptions> t)
		{
			t.changeValue = t.endValue;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00009924 File Offset: 0x00007B24
		public override float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue)
		{
			float num = (float)changeValue.Length / unitsXSecond;
			if (num < 0f)
			{
				num = -num;
			}
			return num;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00009948 File Offset: 0x00007B48
		public override void EvaluateAndApply(StringOptions options, Tween t, bool isRelative, DOGetter<string> getter, DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration)
		{
			StringPlugin._Buffer.Remove(0, StringPlugin._Buffer.Length);
			if (isRelative && t.loopType == LoopType.Incremental)
			{
				int num = (t.isComplete ? (t.completedLoops - 1) : t.completedLoops);
				if (num > 0)
				{
					StringPlugin._Buffer.Append(startValue);
					for (int i = 0; i < num; i++)
					{
						StringPlugin._Buffer.Append(changeValue);
					}
					startValue = StringPlugin._Buffer.ToString();
					StringPlugin._Buffer.Remove(0, StringPlugin._Buffer.Length);
				}
			}
			int length = startValue.Length;
			int length2 = changeValue.Length;
			int num2 = (int)Math.Round((double)EaseManager.Evaluate(t, elapsed, 0f, (float)length2, duration, t.easeOvershootOrAmplitude, t.easePeriod));
			if (num2 > length2)
			{
				num2 = length2;
			}
			else if (num2 < 0)
			{
				num2 = 0;
			}
			if (isRelative)
			{
				StringPlugin._Buffer.Append(startValue);
				if (options.scramble)
				{
					setter(StringPlugin._Buffer.Append(changeValue, 0, num2).AppendScrambledChars(length2 - num2, options.scrambledChars ?? StringPluginExtensions.ScrambledChars).ToString());
					return;
				}
				setter(StringPlugin._Buffer.Append(changeValue, 0, num2).ToString());
				return;
			}
			else
			{
				if (options.scramble)
				{
					setter(StringPlugin._Buffer.Append(changeValue, 0, num2).AppendScrambledChars(length2 - num2, options.scrambledChars ?? StringPluginExtensions.ScrambledChars).ToString());
					return;
				}
				int num3 = length - length2;
				int num4 = length;
				if (num3 > 0)
				{
					float num5 = (float)num2 / (float)length2;
					num4 -= (int)((float)num4 * num5);
				}
				else
				{
					num4 -= num2;
				}
				StringPlugin._Buffer.Append(changeValue, 0, num2);
				if (num2 < length2 && num2 < length)
				{
					StringPlugin._Buffer.Append(startValue, num2, num4);
				}
				setter(StringPlugin._Buffer.ToString());
				return;
			}
		}

		// Token: 0x04000100 RID: 256
		private static readonly StringBuilder _Buffer = new StringBuilder();
	}
}
