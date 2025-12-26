using System;
using UnityEngine;

namespace DG.Tweening.Core.Easing
{
	// Token: 0x0200002A RID: 42
	internal class EaseCurve
	{
		// Token: 0x06000159 RID: 345 RVA: 0x0000962E File Offset: 0x0000782E
		public EaseCurve(AnimationCurve animCurve)
		{
			this._animCurve = animCurve;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00009640 File Offset: 0x00007840
		public float Evaluate(float time, float startValue, float changeValue, float duration, float unusedOvershoot, float unusedPeriod)
		{
			float time2 = this._animCurve[this._animCurve.length - 1].time;
			float num = time / duration;
			float num2 = this._animCurve.Evaluate(num * time2);
			return changeValue * num2 + startValue;
		}

		// Token: 0x040000CA RID: 202
		private readonly AnimationCurve _animCurve;
	}
}
