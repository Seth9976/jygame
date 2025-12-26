using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000018 RID: 24
	public class Vector4Plugin : ABSTweenPlugin<Vector4, Vector4, VectorOptions>
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x000057E0 File Offset: 0x000039E0
		public override void Reset(TweenerCore<Vector4, Vector4, VectorOptions> t)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000057E4 File Offset: 0x000039E4
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, bool isRelative)
		{
			Vector4 endValue = t.endValue;
			t.endValue = t.getter();
			t.startValue = (isRelative ? (t.endValue + endValue) : endValue);
			Vector4 vector = t.endValue;
			AxisConstraint axisConstraint = t.plugOptions.axisConstraint;
			switch (axisConstraint)
			{
			case AxisConstraint.X:
				vector.x = t.startValue.x;
				goto IL_00B9;
			case (AxisConstraint)3:
				break;
			case AxisConstraint.Y:
				vector.y = t.startValue.y;
				goto IL_00B9;
			default:
				if (axisConstraint == AxisConstraint.Z)
				{
					vector.z = t.startValue.z;
					goto IL_00B9;
				}
				if (axisConstraint == AxisConstraint.W)
				{
					vector.w = t.startValue.w;
					goto IL_00B9;
				}
				break;
			}
			vector = t.startValue;
			IL_00B9:
			if (t.plugOptions.snapping)
			{
				vector.x = (float)Math.Round((double)vector.x);
				vector.y = (float)Math.Round((double)vector.y);
				vector.z = (float)Math.Round((double)vector.z);
				vector.w = (float)Math.Round((double)vector.w);
			}
			t.setter(vector);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005917 File Offset: 0x00003B17
		public override Vector4 ConvertToStartValue(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 value)
		{
			return value;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000591A File Offset: 0x00003B1A
		public override void SetRelativeEndValue(TweenerCore<Vector4, Vector4, VectorOptions> t)
		{
			t.endValue += t.startValue;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005934 File Offset: 0x00003B34
		public override void SetChangeValue(TweenerCore<Vector4, Vector4, VectorOptions> t)
		{
			AxisConstraint axisConstraint = t.plugOptions.axisConstraint;
			switch (axisConstraint)
			{
			case AxisConstraint.X:
				t.changeValue = new Vector4(t.endValue.x - t.startValue.x, 0f, 0f, 0f);
				return;
			case (AxisConstraint)3:
				break;
			case AxisConstraint.Y:
				t.changeValue = new Vector4(0f, t.endValue.y - t.startValue.y, 0f, 0f);
				return;
			default:
				if (axisConstraint == AxisConstraint.Z)
				{
					t.changeValue = new Vector4(0f, 0f, t.endValue.z - t.startValue.z, 0f);
					return;
				}
				if (axisConstraint == AxisConstraint.W)
				{
					t.changeValue = new Vector4(0f, 0f, 0f, t.endValue.w - t.startValue.w);
					return;
				}
				break;
			}
			t.changeValue = t.endValue - t.startValue;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005A51 File Offset: 0x00003C51
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue)
		{
			return changeValue.magnitude / unitsXSecond;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00005A5C File Offset: 0x00003C5C
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector4> getter, DOSetter<Vector4> setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration)
		{
			if (t.loopType == LoopType.Incremental)
			{
				startValue += changeValue * (float)(t.isComplete ? (t.completedLoops - 1) : t.completedLoops);
			}
			if (t.isSequenced && t.sequenceParent.loopType == LoopType.Incremental)
			{
				startValue += changeValue * (float)((t.loopType == LoopType.Incremental) ? t.loops : 1) * (float)(t.sequenceParent.isComplete ? (t.sequenceParent.completedLoops - 1) : t.sequenceParent.completedLoops);
			}
			AxisConstraint axisConstraint = options.axisConstraint;
			switch (axisConstraint)
			{
			case AxisConstraint.X:
			{
				Vector4 vector = getter();
				vector.x = EaseManager.Evaluate(t, elapsed, startValue.x, changeValue.x, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				if (options.snapping)
				{
					vector.x = (float)Math.Round((double)vector.x);
				}
				setter(vector);
				return;
			}
			case (AxisConstraint)3:
				break;
			case AxisConstraint.Y:
			{
				Vector4 vector2 = getter();
				vector2.y = EaseManager.Evaluate(t, elapsed, startValue.y, changeValue.y, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				if (options.snapping)
				{
					vector2.y = (float)Math.Round((double)vector2.y);
				}
				setter(vector2);
				return;
			}
			default:
				if (axisConstraint == AxisConstraint.Z)
				{
					Vector4 vector3 = getter();
					vector3.z = EaseManager.Evaluate(t, elapsed, startValue.z, changeValue.z, duration, t.easeOvershootOrAmplitude, t.easePeriod);
					if (options.snapping)
					{
						vector3.z = (float)Math.Round((double)vector3.z);
					}
					setter(vector3);
					return;
				}
				if (axisConstraint == AxisConstraint.W)
				{
					Vector4 vector4 = getter();
					vector4.w = EaseManager.Evaluate(t, elapsed, startValue.w, changeValue.w, duration, t.easeOvershootOrAmplitude, t.easePeriod);
					if (options.snapping)
					{
						vector4.w = (float)Math.Round((double)vector4.w);
					}
					setter(vector4);
					return;
				}
				break;
			}
			startValue.x = EaseManager.Evaluate(t, elapsed, startValue.x, changeValue.x, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			startValue.y = EaseManager.Evaluate(t, elapsed, startValue.y, changeValue.y, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			startValue.z = EaseManager.Evaluate(t, elapsed, startValue.z, changeValue.z, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			startValue.w = EaseManager.Evaluate(t, elapsed, startValue.w, changeValue.w, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			if (options.snapping)
			{
				startValue.x = (float)Math.Round((double)startValue.x);
				startValue.y = (float)Math.Round((double)startValue.y);
				startValue.z = (float)Math.Round((double)startValue.z);
				startValue.w = (float)Math.Round((double)startValue.w);
			}
			setter(startValue);
		}
	}
}
