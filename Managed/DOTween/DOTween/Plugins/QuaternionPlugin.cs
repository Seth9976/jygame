using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000023 RID: 35
	public class QuaternionPlugin : ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions>
	{
		// Token: 0x06000130 RID: 304 RVA: 0x000081AC File Offset: 0x000063AC
		public override void Reset(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000081B0 File Offset: 0x000063B0
		public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool isRelative)
		{
			Vector3 endValue = t.endValue;
			t.endValue = t.getter().eulerAngles;
			if (t.plugOptions.rotateMode == RotateMode.Fast && !t.isRelative)
			{
				t.startValue = endValue;
			}
			else if (t.plugOptions.rotateMode == RotateMode.FastBeyond360)
			{
				t.startValue = t.endValue + endValue;
			}
			else
			{
				Quaternion quaternion = t.getter();
				if (t.plugOptions.rotateMode == RotateMode.WorldAxisAdd)
				{
					t.startValue = (quaternion * Quaternion.Inverse(quaternion) * Quaternion.Euler(endValue) * quaternion).eulerAngles;
				}
				else
				{
					t.startValue = (quaternion * Quaternion.Euler(endValue)).eulerAngles;
				}
				t.endValue = -endValue;
			}
			t.setter(Quaternion.Euler(t.startValue));
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000082A4 File Offset: 0x000064A4
		public override Vector3 ConvertToStartValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Quaternion value)
		{
			return value.eulerAngles;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000082AD File Offset: 0x000064AD
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
		{
			t.endValue += t.startValue;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000082C8 File Offset: 0x000064C8
		public override void SetChangeValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
		{
			if (t.plugOptions.rotateMode == RotateMode.Fast && !t.isRelative)
			{
				Vector3 endValue = t.endValue;
				if (endValue.x > 360f)
				{
					endValue.x %= 360f;
				}
				if (endValue.y > 360f)
				{
					endValue.y %= 360f;
				}
				if (endValue.z > 360f)
				{
					endValue.z %= 360f;
				}
				Vector3 vector = endValue - t.startValue;
				float num = ((vector.x > 0f) ? vector.x : (-vector.x));
				if (num > 180f)
				{
					vector.x = ((vector.x > 0f) ? (-(360f - num)) : (360f - num));
				}
				num = ((vector.y > 0f) ? vector.y : (-vector.y));
				if (num > 180f)
				{
					vector.y = ((vector.y > 0f) ? (-(360f - num)) : (360f - num));
				}
				num = ((vector.z > 0f) ? vector.z : (-vector.z));
				if (num > 180f)
				{
					vector.z = ((vector.z > 0f) ? (-(360f - num)) : (360f - num));
				}
				t.changeValue = vector;
				return;
			}
			if (t.plugOptions.rotateMode == RotateMode.FastBeyond360)
			{
				t.changeValue = t.endValue - t.startValue;
				return;
			}
			t.changeValue = t.endValue;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000848E File Offset: 0x0000668E
		public override float GetSpeedBasedDuration(QuaternionOptions options, float unitsXSecond, Vector3 changeValue)
		{
			return changeValue.magnitude / unitsXSecond;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000849C File Offset: 0x0000669C
		public override void EvaluateAndApply(QuaternionOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration)
		{
			Vector3 vector = startValue;
			if (t.loopType == LoopType.Incremental)
			{
				vector += changeValue * (float)(t.isComplete ? (t.completedLoops - 1) : t.completedLoops);
			}
			if (t.isSequenced && t.sequenceParent.loopType == LoopType.Incremental)
			{
				vector += changeValue * (float)((t.loopType == LoopType.Incremental) ? t.loops : 1) * (float)(t.sequenceParent.isComplete ? (t.sequenceParent.completedLoops - 1) : t.sequenceParent.completedLoops);
			}
			switch (options.rotateMode)
			{
			case RotateMode.WorldAxisAdd:
			case RotateMode.LocalAxisAdd:
			{
				Quaternion quaternion = Quaternion.Euler(startValue);
				vector.x = EaseManager.Evaluate(t, elapsed, 0f, changeValue.x, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				vector.y = EaseManager.Evaluate(t, elapsed, 0f, changeValue.y, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				vector.z = EaseManager.Evaluate(t, elapsed, 0f, changeValue.z, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				if (options.rotateMode == RotateMode.WorldAxisAdd)
				{
					setter(quaternion * Quaternion.Inverse(quaternion) * Quaternion.Euler(vector) * quaternion);
					return;
				}
				setter(quaternion * Quaternion.Euler(vector));
				return;
			}
			default:
				vector.x = EaseManager.Evaluate(t, elapsed, vector.x, changeValue.x, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				vector.y = EaseManager.Evaluate(t, elapsed, vector.y, changeValue.y, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				vector.z = EaseManager.Evaluate(t, elapsed, vector.z, changeValue.z, duration, t.easeOvershootOrAmplitude, t.easePeriod);
				setter(Quaternion.Euler(vector));
				return;
			}
		}
	}
}
