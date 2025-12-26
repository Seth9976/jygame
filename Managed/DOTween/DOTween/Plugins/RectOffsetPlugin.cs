using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000019 RID: 25
	public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions>
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00005DB8 File Offset: 0x00003FB8
		public override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t)
		{
			t.startValue = (t.endValue = (t.changeValue = null));
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00005DE0 File Offset: 0x00003FE0
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, bool isRelative)
		{
			RectOffset endValue = t.endValue;
			t.endValue = t.getter();
			t.startValue = endValue;
			if (isRelative)
			{
				t.startValue.left += t.endValue.left;
				t.startValue.right += t.endValue.right;
				t.startValue.top += t.endValue.top;
				t.startValue.bottom += t.endValue.bottom;
			}
			t.setter(t.startValue);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005E94 File Offset: 0x00004094
		public override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value)
		{
			return new RectOffset(value.left, value.right, value.top, value.bottom);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005EB4 File Offset: 0x000040B4
		public override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t)
		{
			t.endValue.left += t.startValue.left;
			t.endValue.right += t.startValue.right;
			t.endValue.top += t.startValue.top;
			t.endValue.bottom += t.startValue.bottom;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00005F38 File Offset: 0x00004138
		public override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t)
		{
			t.changeValue = new RectOffset(t.endValue.left - t.startValue.left, t.endValue.right - t.startValue.right, t.endValue.top - t.startValue.top, t.endValue.bottom - t.startValue.bottom);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005FAC File Offset: 0x000041AC
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue)
		{
			float num = (float)changeValue.right;
			if (num < 0f)
			{
				num = -num;
			}
			float num2 = (float)changeValue.bottom;
			if (num2 < 0f)
			{
				num2 = -num2;
			}
			float num3 = (float)Math.Sqrt((double)(num * num + num2 * num2));
			return num3 / unitsXSecond;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005FF4 File Offset: 0x000041F4
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration)
		{
			RectOffsetPlugin._r.left = startValue.left;
			RectOffsetPlugin._r.right = startValue.right;
			RectOffsetPlugin._r.top = startValue.top;
			RectOffsetPlugin._r.bottom = startValue.bottom;
			if (t.loopType == LoopType.Incremental)
			{
				int num = (t.isComplete ? (t.completedLoops - 1) : t.completedLoops);
				RectOffsetPlugin._r.left += changeValue.left * num;
				RectOffsetPlugin._r.right += changeValue.right * num;
				RectOffsetPlugin._r.top += changeValue.top * num;
				RectOffsetPlugin._r.bottom += changeValue.bottom * num;
			}
			if (t.isSequenced && t.sequenceParent.loopType == LoopType.Incremental)
			{
				int num2 = ((t.loopType == LoopType.Incremental) ? t.loops : 1) * (t.sequenceParent.isComplete ? (t.sequenceParent.completedLoops - 1) : t.sequenceParent.completedLoops);
				RectOffsetPlugin._r.left += changeValue.left * num2;
				RectOffsetPlugin._r.right += changeValue.right * num2;
				RectOffsetPlugin._r.top += changeValue.top * num2;
				RectOffsetPlugin._r.bottom += changeValue.bottom * num2;
			}
			setter(new RectOffset((int)Math.Round((double)EaseManager.Evaluate(t, elapsed, (float)RectOffsetPlugin._r.left, (float)changeValue.left, duration, t.easeOvershootOrAmplitude, t.easePeriod)), (int)Math.Round((double)EaseManager.Evaluate(t, elapsed, (float)RectOffsetPlugin._r.right, (float)changeValue.right, duration, t.easeOvershootOrAmplitude, t.easePeriod)), (int)Math.Round((double)EaseManager.Evaluate(t, elapsed, (float)RectOffsetPlugin._r.top, (float)changeValue.top, duration, t.easeOvershootOrAmplitude, t.easePeriod)), (int)Math.Round((double)EaseManager.Evaluate(t, elapsed, (float)RectOffsetPlugin._r.bottom, (float)changeValue.bottom, duration, t.easeOvershootOrAmplitude, t.easePeriod))));
		}

		// Token: 0x0400007B RID: 123
		private static RectOffset _r = new RectOffset();
	}
}
