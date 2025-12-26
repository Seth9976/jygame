using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000044 RID: 68
	public class UintPlugin : ABSTweenPlugin<uint, uint, NoOptions>
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x0000BF4F File Offset: 0x0000A14F
		public override void Reset(TweenerCore<uint, uint, NoOptions> t)
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000BF54 File Offset: 0x0000A154
		public override void SetFrom(TweenerCore<uint, uint, NoOptions> t, bool isRelative)
		{
			uint endValue = t.endValue;
			t.endValue = t.getter();
			t.startValue = (isRelative ? (t.endValue + endValue) : endValue);
			t.setter(t.startValue);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000BF9E File Offset: 0x0000A19E
		public override uint ConvertToStartValue(TweenerCore<uint, uint, NoOptions> t, uint value)
		{
			return value;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000BFA1 File Offset: 0x0000A1A1
		public override void SetRelativeEndValue(TweenerCore<uint, uint, NoOptions> t)
		{
			t.endValue += t.startValue;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000BFB6 File Offset: 0x0000A1B6
		public override void SetChangeValue(TweenerCore<uint, uint, NoOptions> t)
		{
			t.changeValue = t.endValue - t.startValue;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, uint changeValue)
		{
			float num = changeValue / unitsXSecond;
			if (num < 0f)
			{
				num = -num;
			}
			return num;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000BFEC File Offset: 0x0000A1EC
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<uint> getter, DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration)
		{
			if (t.loopType == LoopType.Incremental)
			{
				startValue += (uint)((ulong)changeValue * (ulong)((long)(t.isComplete ? (t.completedLoops - 1) : t.completedLoops)));
			}
			if (t.isSequenced && t.sequenceParent.loopType == LoopType.Incremental)
			{
				startValue += (uint)((ulong)changeValue * (ulong)((long)((t.loopType == LoopType.Incremental) ? t.loops : 1)) * (ulong)((long)(t.sequenceParent.isComplete ? (t.sequenceParent.completedLoops - 1) : t.sequenceParent.completedLoops)));
			}
			setter((uint)Math.Round((double)EaseManager.Evaluate(t, elapsed, startValue, changeValue, duration, t.easeOvershootOrAmplitude, t.easePeriod)));
		}
	}
}
