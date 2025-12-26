using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000026 RID: 38
	internal class Color2Plugin : ABSTweenPlugin<Color2, Color2, ColorOptions>
	{
		// Token: 0x06000141 RID: 321 RVA: 0x00008CA7 File Offset: 0x00006EA7
		public override void Reset(TweenerCore<Color2, Color2, ColorOptions> t)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00008CAC File Offset: 0x00006EAC
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, bool isRelative)
		{
			Color2 endValue = t.endValue;
			t.endValue = t.getter();
			if (isRelative)
			{
				t.startValue = new Color2(t.endValue.ca + endValue.ca, t.endValue.cb + endValue.cb);
			}
			else
			{
				t.startValue = new Color2(endValue.ca, endValue.cb);
			}
			Color2 color = t.endValue;
			if (!t.plugOptions.alphaOnly)
			{
				color = t.startValue;
			}
			else
			{
				color.ca.a = t.startValue.ca.a;
				color.cb.a = t.startValue.cb.a;
			}
			t.setter(color);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00008D89 File Offset: 0x00006F89
		public override Color2 ConvertToStartValue(TweenerCore<Color2, Color2, ColorOptions> t, Color2 value)
		{
			return value;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00008D8C File Offset: 0x00006F8C
		public override void SetRelativeEndValue(TweenerCore<Color2, Color2, ColorOptions> t)
		{
			t.endValue += t.startValue;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00008DA5 File Offset: 0x00006FA5
		public override void SetChangeValue(TweenerCore<Color2, Color2, ColorOptions> t)
		{
			t.changeValue = t.endValue - t.startValue;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00008DBE File Offset: 0x00006FBE
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color2 changeValue)
		{
			return 1f / unitsXSecond;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00008DC8 File Offset: 0x00006FC8
		public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color2> getter, DOSetter<Color2> setter, float elapsed, Color2 startValue, Color2 changeValue, float duration)
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
				startValue.ca.r = EaseManager.Evaluate(t, elapsed, startValue.ca.r, changeValue.ca.r, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				startValue.ca.g = EaseManager.Evaluate(t, elapsed, startValue.ca.g, changeValue.ca.g, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				startValue.ca.b = EaseManager.Evaluate(t, elapsed, startValue.ca.b, changeValue.ca.b, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				startValue.ca.a = EaseManager.Evaluate(t, elapsed, startValue.ca.a, changeValue.ca.a, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				startValue.cb.r = EaseManager.Evaluate(t, elapsed, startValue.cb.r, changeValue.cb.r, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				startValue.cb.g = EaseManager.Evaluate(t, elapsed, startValue.cb.g, changeValue.cb.g, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				startValue.cb.b = EaseManager.Evaluate(t, elapsed, startValue.cb.b, changeValue.cb.b, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				startValue.cb.a = EaseManager.Evaluate(t, elapsed, startValue.cb.a, changeValue.cb.a, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				setter(startValue);
				return;
			}
			Color2 color = getter();
			color.ca.a = EaseManager.Evaluate(t, elapsed, startValue.ca.a, changeValue.ca.a, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			color.cb.a = EaseManager.Evaluate(t, elapsed, startValue.cb.a, changeValue.cb.a, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			setter(color);
		}
	}
}
