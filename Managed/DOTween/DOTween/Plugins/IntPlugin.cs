using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
	// Token: 0x0200002F RID: 47
	public class IntPlugin : ABSTweenPlugin<int, int, NoOptions>
	{
		// Token: 0x0600016B RID: 363 RVA: 0x00009687 File Offset: 0x00007887
		public override void Reset(TweenerCore<int, int, NoOptions> t)
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000968C File Offset: 0x0000788C
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, bool isRelative)
		{
			int endValue = t.endValue;
			t.endValue = t.getter();
			t.startValue = (isRelative ? (t.endValue + endValue) : endValue);
			t.setter(t.startValue);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000096D6 File Offset: 0x000078D6
		public override int ConvertToStartValue(TweenerCore<int, int, NoOptions> t, int value)
		{
			return value;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000096D9 File Offset: 0x000078D9
		public override void SetRelativeEndValue(TweenerCore<int, int, NoOptions> t)
		{
			t.endValue += t.startValue;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000096EE File Offset: 0x000078EE
		public override void SetChangeValue(TweenerCore<int, int, NoOptions> t)
		{
			t.changeValue = t.endValue - t.startValue;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00009704 File Offset: 0x00007904
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue)
		{
			float num = (float)changeValue / unitsXSecond;
			if (num < 0f)
			{
				num = -num;
			}
			return num;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00009724 File Offset: 0x00007924
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<int> getter, DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration)
		{
			if (t.loopType == LoopType.Incremental)
			{
				startValue += changeValue * (t.isComplete ? (t.completedLoops - 1) : t.completedLoops);
			}
			setter((int)Math.Round((double)EaseManager.Evaluate(t, elapsed, (float)startValue, (float)changeValue, duration, t.easeOvershootOrAmplitude, t.easePeriod)));
		}
	}
}
