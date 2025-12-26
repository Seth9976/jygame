using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000022 RID: 34
	public class TweenParams
	{
		// Token: 0x06000119 RID: 281 RVA: 0x00007F4F File Offset: 0x0000614F
		public TweenParams()
		{
			this.Clear();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00007F60 File Offset: 0x00006160
		public TweenParams Clear()
		{
			this.id = (this.target = null);
			this.updateType = UpdateType.Default;
			this.isIndependentUpdate = false;
			this.onStart = (this.onPlay = (this.onRewind = (this.onUpdate = (this.onStepComplete = (this.onComplete = (this.onKill = null))))));
			this.isRecyclable = DOTween.defaultRecyclable;
			this.isSpeedBased = false;
			this.autoKill = DOTween.defaultAutoKill;
			this.loops = 1;
			this.loopType = DOTween.defaultLoopType;
			this.delay = 0f;
			this.isRelative = false;
			this.easeType = Ease.Unset;
			this.customEase = null;
			this.easeOvershootOrAmplitude = DOTween.defaultEaseOvershootOrAmplitude;
			this.easePeriod = DOTween.defaultEasePeriod;
			return this;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00008034 File Offset: 0x00006234
		public TweenParams SetAutoKill(bool autoKillOnCompletion = true)
		{
			this.autoKill = autoKillOnCompletion;
			return this;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000803E File Offset: 0x0000623E
		public TweenParams SetId(object id)
		{
			this.id = id;
			return this;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00008048 File Offset: 0x00006248
		public TweenParams SetTarget(object target)
		{
			this.target = target;
			return this;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00008052 File Offset: 0x00006252
		public TweenParams SetLoops(int loops, LoopType? loopType = null)
		{
			if (loops < -1)
			{
				loops = -1;
			}
			else if (loops == 0)
			{
				loops = 1;
			}
			this.loops = loops;
			if (loopType != null)
			{
				this.loopType = loopType.Value;
			}
			return this;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00008084 File Offset: 0x00006284
		public TweenParams SetEase(Ease ease, float? overshootOrAmplitude = null, float? period = null)
		{
			this.easeType = ease;
			this.easeOvershootOrAmplitude = ((overshootOrAmplitude != null) ? overshootOrAmplitude.Value : DOTween.defaultEaseOvershootOrAmplitude);
			this.easePeriod = ((period != null) ? period.Value : DOTween.defaultEasePeriod);
			this.customEase = null;
			return this;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000080DC File Offset: 0x000062DC
		public TweenParams SetEase(AnimationCurve animCurve)
		{
			this.easeType = Ease.INTERNAL_Custom;
			this.customEase = new EaseFunction(new EaseCurve(animCurve).Evaluate);
			return this;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000080FE File Offset: 0x000062FE
		public TweenParams SetEase(EaseFunction customEase)
		{
			this.easeType = Ease.INTERNAL_Custom;
			this.customEase = customEase;
			return this;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00008110 File Offset: 0x00006310
		public TweenParams SetRecyclable(bool recyclable = true)
		{
			this.isRecyclable = recyclable;
			return this;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000811A File Offset: 0x0000631A
		public TweenParams SetUpdate(bool isIndependentUpdate)
		{
			this.updateType = UpdateType.Default;
			this.isIndependentUpdate = isIndependentUpdate;
			return this;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000812B File Offset: 0x0000632B
		public TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = false)
		{
			this.updateType = updateType;
			this.isIndependentUpdate = isIndependentUpdate;
			return this;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000813C File Offset: 0x0000633C
		public TweenParams OnStart(TweenCallback action)
		{
			this.onStart = action;
			return this;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00008146 File Offset: 0x00006346
		public TweenParams OnPlay(TweenCallback action)
		{
			this.onPlay = action;
			return this;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00008150 File Offset: 0x00006350
		public TweenParams OnRewind(TweenCallback action)
		{
			this.onRewind = action;
			return this;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000815A File Offset: 0x0000635A
		public TweenParams OnUpdate(TweenCallback action)
		{
			this.onUpdate = action;
			return this;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00008164 File Offset: 0x00006364
		public TweenParams OnStepComplete(TweenCallback action)
		{
			this.onStepComplete = action;
			return this;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000816E File Offset: 0x0000636E
		public TweenParams OnComplete(TweenCallback action)
		{
			this.onComplete = action;
			return this;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00008178 File Offset: 0x00006378
		public TweenParams OnKill(TweenCallback action)
		{
			this.onKill = action;
			return this;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00008182 File Offset: 0x00006382
		public TweenParams SetDelay(float delay)
		{
			this.delay = delay;
			return this;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000818C File Offset: 0x0000638C
		public TweenParams SetRelative(bool isRelative = true)
		{
			this.isRelative = isRelative;
			return this;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00008196 File Offset: 0x00006396
		public TweenParams SetSpeedBased(bool isSpeedBased = true)
		{
			this.isSpeedBased = isSpeedBased;
			return this;
		}

		// Token: 0x040000A4 RID: 164
		public static readonly TweenParams Params = new TweenParams();

		// Token: 0x040000A5 RID: 165
		internal object id;

		// Token: 0x040000A6 RID: 166
		internal object target;

		// Token: 0x040000A7 RID: 167
		internal UpdateType updateType;

		// Token: 0x040000A8 RID: 168
		internal bool isIndependentUpdate;

		// Token: 0x040000A9 RID: 169
		internal TweenCallback onStart;

		// Token: 0x040000AA RID: 170
		internal TweenCallback onPlay;

		// Token: 0x040000AB RID: 171
		internal TweenCallback onRewind;

		// Token: 0x040000AC RID: 172
		internal TweenCallback onUpdate;

		// Token: 0x040000AD RID: 173
		internal TweenCallback onStepComplete;

		// Token: 0x040000AE RID: 174
		internal TweenCallback onComplete;

		// Token: 0x040000AF RID: 175
		internal TweenCallback onKill;

		// Token: 0x040000B0 RID: 176
		internal bool isRecyclable;

		// Token: 0x040000B1 RID: 177
		internal bool isSpeedBased;

		// Token: 0x040000B2 RID: 178
		internal bool autoKill;

		// Token: 0x040000B3 RID: 179
		internal int loops;

		// Token: 0x040000B4 RID: 180
		internal LoopType loopType;

		// Token: 0x040000B5 RID: 181
		internal float delay;

		// Token: 0x040000B6 RID: 182
		internal bool isRelative;

		// Token: 0x040000B7 RID: 183
		internal Ease easeType;

		// Token: 0x040000B8 RID: 184
		internal EaseFunction customEase;

		// Token: 0x040000B9 RID: 185
		internal float easeOvershootOrAmplitude;

		// Token: 0x040000BA RID: 186
		internal float easePeriod;
	}
}
