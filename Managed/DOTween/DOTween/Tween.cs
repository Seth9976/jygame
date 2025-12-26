using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;

namespace DG.Tweening
{
	// Token: 0x0200000F RID: 15
	public abstract class Tween : ABSSequentiable
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x000043F0 File Offset: 0x000025F0
		internal virtual void Reset()
		{
			this.timeScale = 1f;
			this.isBackwards = false;
			this.id = null;
			this.updateType = UpdateType.Default;
			this.isIndependentUpdate = false;
			this.onStart = (this.onPlay = (this.onRewind = (this.onUpdate = (this.onComplete = (this.onStepComplete = (this.onKill = null))))));
			this.target = null;
			this.isFrom = false;
			this.isSpeedBased = false;
			this.duration = 0f;
			this.loops = 1;
			this.delay = 0f;
			this.isRelative = false;
			this.customEase = null;
			this.isSequenced = false;
			this.sequenceParent = null;
			this.specialStartupMode = SpecialStartupMode.None;
			this.creationLocked = (this.startupDone = (this.playedOnce = false));
			this.position = (this.fullDuration = (float)(this.completedLoops = 0));
			this.isPlaying = (this.isComplete = false);
			this.elapsedDelay = 0f;
			this.delayComplete = true;
		}

		// Token: 0x060000A2 RID: 162
		internal abstract bool Validate();

		// Token: 0x060000A3 RID: 163 RVA: 0x00004519 File Offset: 0x00002719
		internal virtual float UpdateDelay(float elapsed)
		{
			return 0f;
		}

		// Token: 0x060000A4 RID: 164
		internal abstract bool Startup();

		// Token: 0x060000A5 RID: 165
		internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode);

		// Token: 0x060000A6 RID: 166 RVA: 0x00004520 File Offset: 0x00002720
		internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode)
		{
			if (!t.startupDone && !t.Startup())
			{
				return true;
			}
			if (!t.playedOnce && updateMode == UpdateMode.Update)
			{
				t.playedOnce = true;
				if (t.onStart != null)
				{
					t.onStart();
					if (!t.active)
					{
						return true;
					}
				}
				if (t.onPlay != null)
				{
					t.onPlay();
					if (!t.active)
					{
						return true;
					}
				}
			}
			float num = t.position;
			int num2 = t.completedLoops;
			t.completedLoops = toCompletedLoops;
			bool flag = t.position <= 0f && num2 <= 0;
			bool flag2 = t.isComplete;
			if (t.loops != -1)
			{
				t.isComplete = t.completedLoops == t.loops;
			}
			int num3 = 0;
			if (updateMode == UpdateMode.Update)
			{
				if (t.isBackwards)
				{
					num3 = ((t.completedLoops < num2) ? (num2 - t.completedLoops) : ((toPosition <= 0f && !flag) ? 1 : 0));
					if (flag2)
					{
						num3--;
					}
				}
				else
				{
					num3 = ((t.completedLoops > num2) ? (t.completedLoops - num2) : 0);
				}
			}
			else if (t.tweenType == TweenType.Sequence)
			{
				num3 = num2 - toCompletedLoops;
				if (num3 < 0)
				{
					num3 = -num3;
				}
			}
			t.position = toPosition;
			if (t.position > t.duration)
			{
				t.position = t.duration;
			}
			else if (t.position <= 0f)
			{
				if (t.completedLoops > 0 || t.isComplete)
				{
					t.position = t.duration;
				}
				else
				{
					t.position = 0f;
				}
			}
			bool flag3 = t.isPlaying;
			if (t.isPlaying)
			{
				if (!t.isBackwards)
				{
					t.isPlaying = !t.isComplete;
				}
				else
				{
					t.isPlaying = t.completedLoops != 0 || t.position > 0f;
				}
			}
			bool flag4 = t.loopType == LoopType.Yoyo && ((t.position < t.duration) ? (t.completedLoops % 2 != 0) : (t.completedLoops % 2 == 0));
			if (t.ApplyTween(num, num2, num3, flag4, updateMode))
			{
				return true;
			}
			if (t.onUpdate != null)
			{
				t.onUpdate();
			}
			if (t.position <= 0f && t.completedLoops <= 0 && !flag && t.onRewind != null)
			{
				t.onRewind();
			}
			if (num3 > 0 && updateMode == UpdateMode.Update && t.onStepComplete != null)
			{
				for (int i = 0; i < num3; i++)
				{
					t.onStepComplete();
				}
			}
			if (t.isComplete && !flag2 && t.onComplete != null)
			{
				t.onComplete();
			}
			if (!t.isPlaying && flag3 && (!t.isComplete || !t.autoKill) && t.onPause != null)
			{
				t.onPause();
			}
			return t.autoKill && t.isComplete;
		}

		// Token: 0x04000034 RID: 52
		public float timeScale;

		// Token: 0x04000035 RID: 53
		public bool isBackwards;

		// Token: 0x04000036 RID: 54
		public object id;

		// Token: 0x04000037 RID: 55
		public object target;

		// Token: 0x04000038 RID: 56
		internal UpdateType updateType;

		// Token: 0x04000039 RID: 57
		internal bool isIndependentUpdate;

		// Token: 0x0400003A RID: 58
		internal TweenCallback onPlay;

		// Token: 0x0400003B RID: 59
		internal TweenCallback onPause;

		// Token: 0x0400003C RID: 60
		internal TweenCallback onRewind;

		// Token: 0x0400003D RID: 61
		internal TweenCallback onUpdate;

		// Token: 0x0400003E RID: 62
		internal TweenCallback onStepComplete;

		// Token: 0x0400003F RID: 63
		internal TweenCallback onComplete;

		// Token: 0x04000040 RID: 64
		internal TweenCallback onKill;

		// Token: 0x04000041 RID: 65
		internal bool isFrom;

		// Token: 0x04000042 RID: 66
		internal bool isRecyclable;

		// Token: 0x04000043 RID: 67
		internal bool isSpeedBased;

		// Token: 0x04000044 RID: 68
		internal bool autoKill;

		// Token: 0x04000045 RID: 69
		internal float duration;

		// Token: 0x04000046 RID: 70
		internal int loops;

		// Token: 0x04000047 RID: 71
		internal LoopType loopType;

		// Token: 0x04000048 RID: 72
		internal float delay;

		// Token: 0x04000049 RID: 73
		internal bool isRelative;

		// Token: 0x0400004A RID: 74
		internal Ease easeType;

		// Token: 0x0400004B RID: 75
		internal EaseFunction customEase;

		// Token: 0x0400004C RID: 76
		public float easeOvershootOrAmplitude;

		// Token: 0x0400004D RID: 77
		public float easePeriod;

		// Token: 0x0400004E RID: 78
		internal Type typeofT1;

		// Token: 0x0400004F RID: 79
		internal Type typeofT2;

		// Token: 0x04000050 RID: 80
		internal Type typeofTPlugOptions;

		// Token: 0x04000051 RID: 81
		internal bool active;

		// Token: 0x04000052 RID: 82
		internal bool isSequenced;

		// Token: 0x04000053 RID: 83
		internal Sequence sequenceParent;

		// Token: 0x04000054 RID: 84
		internal int activeId = -1;

		// Token: 0x04000055 RID: 85
		internal SpecialStartupMode specialStartupMode;

		// Token: 0x04000056 RID: 86
		internal bool creationLocked;

		// Token: 0x04000057 RID: 87
		internal bool startupDone;

		// Token: 0x04000058 RID: 88
		internal bool playedOnce;

		// Token: 0x04000059 RID: 89
		internal float position;

		// Token: 0x0400005A RID: 90
		internal float fullDuration;

		// Token: 0x0400005B RID: 91
		internal int completedLoops;

		// Token: 0x0400005C RID: 92
		internal bool isPlaying;

		// Token: 0x0400005D RID: 93
		internal bool isComplete;

		// Token: 0x0400005E RID: 94
		internal float elapsedDelay;

		// Token: 0x0400005F RID: 95
		internal bool delayComplete = true;
	}
}
