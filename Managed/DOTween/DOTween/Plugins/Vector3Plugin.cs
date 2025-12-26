using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000004 RID: 4
	public class Vector3Plugin : ABSTweenPlugin<Vector3, Vector3, VectorOptions>
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002058 File Offset: 0x00000258
		public override void Reset(TweenerCore<Vector3, Vector3, VectorOptions> t)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000205C File Offset: 0x0000025C
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, bool isRelative)
		{
			Vector3 endValue = t.endValue;
			t.endValue = t.getter();
			t.startValue = (isRelative ? (t.endValue + endValue) : endValue);
			Vector3 vector = t.endValue;
			AxisConstraint axisConstraint = t.plugOptions.axisConstraint;
			switch (axisConstraint)
			{
			case AxisConstraint.X:
				vector.x = t.startValue.x;
				goto IL_00A0;
			case (AxisConstraint)3:
				break;
			case AxisConstraint.Y:
				vector.y = t.startValue.y;
				goto IL_00A0;
			default:
				if (axisConstraint == AxisConstraint.Z)
				{
					vector.z = t.startValue.z;
					goto IL_00A0;
				}
				break;
			}
			vector = t.startValue;
			IL_00A0:
			if (t.plugOptions.snapping)
			{
				vector.x = (float)Math.Round((double)vector.x);
				vector.y = (float)Math.Round((double)vector.y);
				vector.z = (float)Math.Round((double)vector.z);
			}
			t.setter(vector);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002161 File Offset: 0x00000361
		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 value)
		{
			return value;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002164 File Offset: 0x00000364
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, VectorOptions> t)
		{
			t.endValue += t.startValue;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002180 File Offset: 0x00000380
		public override void SetChangeValue(TweenerCore<Vector3, Vector3, VectorOptions> t)
		{
			AxisConstraint axisConstraint = t.plugOptions.axisConstraint;
			switch (axisConstraint)
			{
			case AxisConstraint.X:
				t.changeValue = new Vector3(t.endValue.x - t.startValue.x, 0f, 0f);
				return;
			case (AxisConstraint)3:
				break;
			case AxisConstraint.Y:
				t.changeValue = new Vector3(0f, t.endValue.y - t.startValue.y, 0f);
				return;
			default:
				if (axisConstraint == AxisConstraint.Z)
				{
					t.changeValue = new Vector3(0f, 0f, t.endValue.z - t.startValue.z);
					return;
				}
				break;
			}
			t.changeValue = t.endValue - t.startValue;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002254 File Offset: 0x00000454
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue)
		{
			return changeValue.magnitude / unitsXSecond;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002260 File Offset: 0x00000460
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration)
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
				Vector3 vector = getter();
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
				Vector3 vector2 = getter();
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
					Vector3 vector3 = getter();
					vector3.z = EaseManager.Evaluate(t, elapsed, startValue.z, changeValue.z, duration, t.easeOvershootOrAmplitude, t.easePeriod);
					if (options.snapping)
					{
						vector3.z = (float)Math.Round((double)vector3.z);
					}
					setter(vector3);
					return;
				}
				break;
			}
			startValue.x = EaseManager.Evaluate(t, elapsed, startValue.x, changeValue.x, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			startValue.y = EaseManager.Evaluate(t, elapsed, startValue.y, changeValue.y, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			startValue.z = EaseManager.Evaluate(t, elapsed, startValue.z, changeValue.z, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			if (options.snapping)
			{
				startValue.x = (float)Math.Round((double)startValue.x);
				startValue.y = (float)Math.Round((double)startValue.y);
				startValue.z = (float)Math.Round((double)startValue.z);
			}
			setter(startValue);
		}
	}
}
