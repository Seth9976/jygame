using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000011 RID: 17
	public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions>
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x00004C68 File Offset: 0x00002E68
		public override void Reset(TweenerCore<Rect, Rect, RectOptions> t)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004C6C File Offset: 0x00002E6C
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative)
		{
			Rect endValue = t.endValue;
			t.endValue = t.getter();
			t.startValue = endValue;
			if (isRelative)
			{
				t.startValue.x = t.startValue.x + t.endValue.x;
				t.startValue.y = t.startValue.y + t.endValue.y;
				t.startValue.width = t.startValue.width + t.endValue.width;
				t.startValue.height = t.startValue.height + t.endValue.height;
			}
			Rect startValue = t.startValue;
			if (t.plugOptions.snapping)
			{
				startValue.x = (float)Math.Round((double)startValue.x);
				startValue.y = (float)Math.Round((double)startValue.y);
				startValue.width = (float)Math.Round((double)startValue.width);
				startValue.height = (float)Math.Round((double)startValue.height);
			}
			t.setter(startValue);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004D83 File Offset: 0x00002F83
		public override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value)
		{
			return value;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004D88 File Offset: 0x00002F88
		public override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t)
		{
			t.endValue.x = t.endValue.x + t.startValue.x;
			t.endValue.y = t.endValue.y + t.startValue.y;
			t.endValue.width = t.endValue.width + t.startValue.width;
			t.endValue.height = t.endValue.height + t.startValue.height;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004E0C File Offset: 0x0000300C
		public override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t)
		{
			t.changeValue = new Rect(t.endValue.x - t.startValue.x, t.endValue.y - t.startValue.y, t.endValue.width - t.startValue.width, t.endValue.height - t.startValue.height);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00004E80 File Offset: 0x00003080
		public override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue)
		{
			float width = changeValue.width;
			float height = changeValue.height;
			float num = (float)Math.Sqrt((double)(width * width + height * height));
			return num / unitsXSecond;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004EB0 File Offset: 0x000030B0
		public override void EvaluateAndApply(RectOptions options, Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration)
		{
			if (t.loopType == LoopType.Incremental)
			{
				int num = (t.isComplete ? (t.completedLoops - 1) : t.completedLoops);
				startValue.x += changeValue.x * (float)num;
				startValue.y += changeValue.y * (float)num;
				startValue.width += changeValue.width * (float)num;
				startValue.height += changeValue.height * (float)num;
			}
			if (t.isSequenced && t.sequenceParent.loopType == LoopType.Incremental)
			{
				int num2 = ((t.loopType == LoopType.Incremental) ? t.loops : 1) * (t.sequenceParent.isComplete ? (t.sequenceParent.completedLoops - 1) : t.sequenceParent.completedLoops);
				startValue.x += changeValue.x * (float)num2;
				startValue.y += changeValue.y * (float)num2;
				startValue.width += changeValue.width * (float)num2;
				startValue.height += changeValue.height * (float)num2;
			}
			startValue.x = EaseManager.Evaluate(t, elapsed, startValue.x, changeValue.x, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			startValue.y = EaseManager.Evaluate(t, elapsed, startValue.y, changeValue.y, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			startValue.width = EaseManager.Evaluate(t, elapsed, startValue.width, changeValue.width, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			startValue.height = EaseManager.Evaluate(t, elapsed, startValue.height, changeValue.height, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			if (options.snapping)
			{
				startValue.x = (float)Math.Round((double)startValue.x);
				startValue.y = (float)Math.Round((double)startValue.y);
				startValue.width = (float)Math.Round((double)startValue.width);
				startValue.height = (float)Math.Round((double)startValue.height);
			}
			setter(startValue);
		}
	}
}
