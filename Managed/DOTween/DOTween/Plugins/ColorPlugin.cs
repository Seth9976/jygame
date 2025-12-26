using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000036 RID: 54
	public class ColorPlugin : ABSTweenPlugin<Color, Color, ColorOptions>
	{
		// Token: 0x06000182 RID: 386 RVA: 0x00009C2A File Offset: 0x00007E2A
		public override void Reset(TweenerCore<Color, Color, ColorOptions> t)
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00009C2C File Offset: 0x00007E2C
		public override void SetFrom(TweenerCore<Color, Color, ColorOptions> t, bool isRelative)
		{
			Color endValue = t.endValue;
			t.endValue = t.getter();
			t.startValue = (isRelative ? (t.endValue + endValue) : endValue);
			Color color = t.endValue;
			if (!t.plugOptions.alphaOnly)
			{
				color = t.startValue;
			}
			else
			{
				color.a = t.startValue.a;
			}
			t.setter(color);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00009CA4 File Offset: 0x00007EA4
		public override Color ConvertToStartValue(TweenerCore<Color, Color, ColorOptions> t, Color value)
		{
			return value;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00009CA7 File Offset: 0x00007EA7
		public override void SetRelativeEndValue(TweenerCore<Color, Color, ColorOptions> t)
		{
			t.endValue += t.startValue;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00009CC0 File Offset: 0x00007EC0
		public override void SetChangeValue(TweenerCore<Color, Color, ColorOptions> t)
		{
			t.changeValue = t.endValue - t.startValue;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00009CD9 File Offset: 0x00007ED9
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color changeValue)
		{
			return 1f / unitsXSecond;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00009CE4 File Offset: 0x00007EE4
		public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color> getter, DOSetter<Color> setter, float elapsed, Color startValue, Color changeValue, float duration)
		{
			if (t.loopType == LoopType.Incremental)
			{
				startValue += changeValue * (float)(t.isComplete ? (t.completedLoops - 1) : t.completedLoops);
			}
			if (t.isSequenced && t.sequenceParent.loopType == LoopType.Incremental)
			{
				startValue += changeValue * (float)((t.loopType == LoopType.Incremental) ? t.loops : 1) * (float)(t.sequenceParent.isComplete ? (t.sequenceParent.completedLoops - 1) : t.sequenceParent.completedLoops);
			}
			if (!options.alphaOnly)
			{
				startValue.r = EaseManager.Evaluate(t, elapsed, startValue.r, changeValue.r, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				startValue.g = EaseManager.Evaluate(t, elapsed, startValue.g, changeValue.g, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				startValue.b = EaseManager.Evaluate(t, elapsed, startValue.b, changeValue.b, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				startValue.a = EaseManager.Evaluate(t, elapsed, startValue.a, changeValue.a, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				setter(startValue);
				return;
			}
			Color color = getter();
			color.a = EaseManager.Evaluate(t, elapsed, startValue.a, changeValue.a, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			setter(color);
		}
	}
}
