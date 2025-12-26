using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000040 RID: 64
	public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions>
	{
		// Token: 0x060001AA RID: 426 RVA: 0x0000AE3A File Offset: 0x0000903A
		public override void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000AE3C File Offset: 0x0000903C
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, bool isRelative)
		{
			Vector2 endValue = t.endValue;
			t.endValue = t.getter();
			t.startValue = (isRelative ? (t.endValue + endValue) : endValue);
			Vector2 vector = t.endValue;
			switch (t.plugOptions.axisConstraint)
			{
			case AxisConstraint.X:
				vector.x = t.startValue.x;
				goto IL_0088;
			case AxisConstraint.Y:
				vector.y = t.startValue.y;
				goto IL_0088;
			}
			vector = t.startValue;
			IL_0088:
			if (t.plugOptions.snapping)
			{
				vector.x = (float)Math.Round((double)vector.x);
				vector.y = (float)Math.Round((double)vector.y);
			}
			t.setter(vector);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000AF14 File Offset: 0x00009114
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value)
		{
			return value;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000AF17 File Offset: 0x00009117
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t)
		{
			t.endValue += t.startValue;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000AF30 File Offset: 0x00009130
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t)
		{
			switch (t.plugOptions.axisConstraint)
			{
			case AxisConstraint.X:
				t.changeValue = new Vector2(t.endValue.x - t.startValue.x, 0f);
				return;
			case AxisConstraint.Y:
				t.changeValue = new Vector2(0f, t.endValue.y - t.startValue.y);
				return;
			}
			t.changeValue = t.endValue - t.startValue;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000AFC6 File Offset: 0x000091C6
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue)
		{
			return changeValue.magnitude / unitsXSecond;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000AFD4 File Offset: 0x000091D4
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration)
		{
			if (t.loopType == LoopType.Incremental)
			{
				startValue += changeValue * (float)(t.isComplete ? (t.completedLoops - 1) : t.completedLoops);
			}
			if (t.isSequenced && t.sequenceParent.loopType == LoopType.Incremental)
			{
				startValue += changeValue * (float)((t.loopType == LoopType.Incremental) ? t.loops : 1) * (float)(t.sequenceParent.isComplete ? (t.sequenceParent.completedLoops - 1) : t.sequenceParent.completedLoops);
			}
			switch (options.axisConstraint)
			{
			case AxisConstraint.X:
			{
				Vector2 vector = getter();
				vector.x = EaseManager.Evaluate(t, elapsed, startValue.x, changeValue.x, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				if (options.snapping)
				{
					vector.x = (float)Math.Round((double)vector.x);
				}
				setter(vector);
				return;
			}
			case AxisConstraint.Y:
			{
				Vector2 vector2 = getter();
				vector2.y = EaseManager.Evaluate(t, elapsed, startValue.y, changeValue.y, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				if (options.snapping)
				{
					vector2.y = (float)Math.Round((double)vector2.y);
				}
				setter(vector2);
				return;
			}
			}
			startValue.x = EaseManager.Evaluate(t, elapsed, startValue.x, changeValue.x, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			startValue.y = EaseManager.Evaluate(t, elapsed, startValue.y, changeValue.y, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			if (options.snapping)
			{
				startValue.x = (float)Math.Round((double)startValue.x);
				startValue.y = (float)Math.Round((double)startValue.y);
			}
			setter(startValue);
		}
	}
}
