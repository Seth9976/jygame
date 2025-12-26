using System;
using System.Collections.Generic;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Core.Enums;

namespace DG.Tweening
{
	// Token: 0x0200003E RID: 62
	public sealed class Sequence : Tween
	{
		// Token: 0x0600019B RID: 411 RVA: 0x0000A5D8 File Offset: 0x000087D8
		internal Sequence()
		{
			this.tweenType = TweenType.Sequence;
			this.Reset();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000A604 File Offset: 0x00008804
		internal static Sequence DoPrepend(Sequence inSequence, Tween t)
		{
			if (t.loops == -1)
			{
				t.loops = 1;
			}
			float num = t.delay + t.duration * (float)t.loops;
			inSequence.duration += num;
			int count = inSequence._sequencedObjs.Count;
			for (int i = 0; i < count; i++)
			{
				ABSSequentiable abssequentiable = inSequence._sequencedObjs[i];
				abssequentiable.sequencedPosition += num;
				abssequentiable.sequencedEndPosition += num;
			}
			return Sequence.DoInsert(inSequence, t, 0f);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000A694 File Offset: 0x00008894
		internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition)
		{
			TweenManager.AddActiveTweenToSequence(t);
			atPosition += t.delay;
			inSequence.lastTweenInsertTime = atPosition;
			t.isSequenced = (t.creationLocked = true);
			t.sequenceParent = inSequence;
			if (t.loops == -1)
			{
				t.loops = 1;
			}
			float num = t.duration * (float)t.loops;
			t.autoKill = false;
			t.delay = (t.elapsedDelay = 0f);
			t.delayComplete = true;
			t.isSpeedBased = false;
			t.sequencedPosition = atPosition;
			t.sequencedEndPosition = atPosition + num;
			if (t.sequencedEndPosition > inSequence.duration)
			{
				inSequence.duration = t.sequencedEndPosition;
			}
			inSequence._sequencedObjs.Add(t);
			inSequence.sequencedTweens.Add(t);
			return inSequence;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000A75A File Offset: 0x0000895A
		internal static Sequence DoAppendInterval(Sequence inSequence, float interval)
		{
			inSequence.duration += interval;
			return inSequence;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000A76C File Offset: 0x0000896C
		internal static Sequence DoPrependInterval(Sequence inSequence, float interval)
		{
			inSequence.duration += interval;
			int count = inSequence._sequencedObjs.Count;
			for (int i = 0; i < count; i++)
			{
				ABSSequentiable abssequentiable = inSequence._sequencedObjs[i];
				abssequentiable.sequencedPosition += interval;
				abssequentiable.sequencedEndPosition += interval;
			}
			return inSequence;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000A7CC File Offset: 0x000089CC
		internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition)
		{
			SequenceCallback sequenceCallback = new SequenceCallback(atPosition, callback);
			ABSSequentiable abssequentiable = sequenceCallback;
			sequenceCallback.sequencedEndPosition = atPosition;
			abssequentiable.sequencedPosition = atPosition;
			inSequence._sequencedObjs.Add(sequenceCallback);
			if (inSequence.duration < atPosition)
			{
				inSequence.duration = atPosition;
			}
			return inSequence;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000A80E File Offset: 0x00008A0E
		internal override void Reset()
		{
			base.Reset();
			this.sequencedTweens.Clear();
			this._sequencedObjs.Clear();
			this.lastTweenInsertTime = 0f;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000A838 File Offset: 0x00008A38
		internal override bool Validate()
		{
			int count = this.sequencedTweens.Count;
			for (int i = 0; i < count; i++)
			{
				if (!this.sequencedTweens[i].Validate())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000A873 File Offset: 0x00008A73
		internal override bool Startup()
		{
			return Sequence.DoStartup(this);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000A87B File Offset: 0x00008A7B
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode)
		{
			return Sequence.DoApplyTween(this, prevPosition, prevCompletedLoops, newCompletedSteps, useInversePosition, updateMode);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000A88C File Offset: 0x00008A8C
		internal static void Setup(Sequence s)
		{
			s.autoKill = DOTween.defaultAutoKill;
			s.isRecyclable = DOTween.defaultRecyclable;
			s.isPlaying = DOTween.defaultAutoPlay == AutoPlay.All || DOTween.defaultAutoPlay == AutoPlay.AutoPlaySequences;
			s.loopType = DOTween.defaultLoopType;
			s.easeType = Ease.Linear;
			s.easeOvershootOrAmplitude = DOTween.defaultEaseOvershootOrAmplitude;
			s.easePeriod = DOTween.defaultEasePeriod;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		internal static bool DoStartup(Sequence s)
		{
			if (s.sequencedTweens.Count == 0 && s._sequencedObjs.Count == 0)
			{
				return false;
			}
			s.startupDone = true;
			s.fullDuration = ((s.loops > -1) ? (s.duration * (float)s.loops) : float.PositiveInfinity);
			s._sequencedObjs.Sort(new Comparison<ABSSequentiable>(Sequence.SortSequencedObjs));
			return true;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000A95C File Offset: 0x00008B5C
		internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode)
		{
			float num = prevPosition;
			float num2 = s.position;
			if (s.easeType != Ease.Linear)
			{
				num = EaseManager.Evaluate(s, num, 0f, s.duration, s.duration, s.easeOvershootOrAmplitude, s.easePeriod);
				num2 = EaseManager.Evaluate(s, num2, 0f, s.duration, s.duration, s.easeOvershootOrAmplitude, s.easePeriod);
			}
			float num3 = 0f;
			bool flag = s.loopType == LoopType.Yoyo && ((num < s.duration) ? (prevCompletedLoops % 2 != 0) : (prevCompletedLoops % 2 == 0));
			if (s.isBackwards)
			{
				flag = !flag;
			}
			float num5;
			if (newCompletedSteps > 0)
			{
				int num4 = newCompletedSteps;
				int i = 0;
				num5 = num;
				if (updateMode == UpdateMode.Update)
				{
					while (i < num4)
					{
						if (i > 0)
						{
							num5 = num3;
						}
						else if (flag && !s.isBackwards)
						{
							num5 = s.duration - num5;
						}
						num3 = (flag ? 0f : s.duration);
						if (Sequence.ApplyInternalCycle(s, num5, num3, updateMode, useInversePosition, flag, true))
						{
							return true;
						}
						i++;
						if (s.loopType == LoopType.Yoyo)
						{
							flag = !flag;
						}
					}
				}
				else
				{
					if (s.loopType == LoopType.Yoyo && newCompletedSteps % 2 != 0)
					{
						flag = !flag;
						num = s.duration - num;
					}
					newCompletedSteps = 0;
				}
			}
			if (newCompletedSteps == 1 && s.isComplete)
			{
				return false;
			}
			if (newCompletedSteps > 0 && !s.isComplete)
			{
				num5 = (useInversePosition ? s.duration : 0f);
			}
			else
			{
				num5 = (useInversePosition ? (s.duration - num) : num);
			}
			return Sequence.ApplyInternalCycle(s, num5, useInversePosition ? (s.duration - num2) : num2, updateMode, useInversePosition, flag, false);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000AAF4 File Offset: 0x00008CF4
		private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false)
		{
			bool flag = toPos < fromPos;
			if (flag)
			{
				int num = s._sequencedObjs.Count - 1;
				for (int i = num; i > -1; i--)
				{
					if (!s.active)
					{
						return true;
					}
					ABSSequentiable abssequentiable = s._sequencedObjs[i];
					if (abssequentiable.sequencedEndPosition >= toPos && abssequentiable.sequencedPosition <= fromPos)
					{
						if (abssequentiable.tweenType == TweenType.Callback)
						{
							if (updateMode == UpdateMode.Update && prevPosIsInverse)
							{
								abssequentiable.onStart();
							}
						}
						else
						{
							float num2 = toPos - abssequentiable.sequencedPosition;
							if (num2 < 0f)
							{
								num2 = 0f;
							}
							Tween tween = (Tween)abssequentiable;
							if (tween.startupDone)
							{
								tween.isBackwards = true;
								if (TweenManager.Goto(tween, num2, false, updateMode))
								{
									return true;
								}
								if (multiCycleStep && tween.tweenType == TweenType.Sequence)
								{
									if (s.position <= 0f && s.completedLoops == 0)
									{
										tween.position = 0f;
									}
									else
									{
										bool flag2 = s.completedLoops == 0 || (s.isBackwards && (s.completedLoops < s.loops || s.loops == -1));
										if (tween.isBackwards)
										{
											flag2 = !flag2;
										}
										if (useInverse)
										{
											flag2 = !flag2;
										}
										if (s.isBackwards && !useInverse && !prevPosIsInverse)
										{
											flag2 = !flag2;
										}
										tween.position = (flag2 ? 0f : tween.duration);
									}
								}
							}
						}
					}
				}
			}
			else
			{
				int count = s._sequencedObjs.Count;
				for (int j = 0; j < count; j++)
				{
					if (!s.active)
					{
						return true;
					}
					ABSSequentiable abssequentiable2 = s._sequencedObjs[j];
					if (abssequentiable2.sequencedPosition <= toPos && abssequentiable2.sequencedEndPosition >= fromPos)
					{
						if (abssequentiable2.tweenType == TweenType.Callback)
						{
							if (updateMode == UpdateMode.Update)
							{
								bool flag3 = (!s.isBackwards && !useInverse && !prevPosIsInverse) || (s.isBackwards && useInverse && !prevPosIsInverse);
								if (flag3)
								{
									abssequentiable2.onStart();
								}
							}
						}
						else
						{
							float num3 = toPos - abssequentiable2.sequencedPosition;
							if (num3 < 0f)
							{
								num3 = 0f;
							}
							Tween tween2 = (Tween)abssequentiable2;
							tween2.isBackwards = false;
							if (TweenManager.Goto(tween2, num3, false, updateMode))
							{
								return true;
							}
							if (multiCycleStep && tween2.tweenType == TweenType.Sequence)
							{
								if (s.position <= 0f && s.completedLoops == 0)
								{
									tween2.position = 0f;
								}
								else
								{
									bool flag4 = s.completedLoops == 0 || (!s.isBackwards && (s.completedLoops < s.loops || s.loops == -1));
									if (tween2.isBackwards)
									{
										flag4 = !flag4;
									}
									if (useInverse)
									{
										flag4 = !flag4;
									}
									if (s.isBackwards && !useInverse && !prevPosIsInverse)
									{
										flag4 = !flag4;
									}
									tween2.position = (flag4 ? 0f : tween2.duration);
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000AE17 File Offset: 0x00009017
		private static int SortSequencedObjs(ABSSequentiable a, ABSSequentiable b)
		{
			if (a.sequencedPosition > b.sequencedPosition)
			{
				return 1;
			}
			if (a.sequencedPosition < b.sequencedPosition)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x0400011B RID: 283
		internal readonly List<Tween> sequencedTweens = new List<Tween>();

		// Token: 0x0400011C RID: 284
		private readonly List<ABSSequentiable> _sequencedObjs = new List<ABSSequentiable>();

		// Token: 0x0400011D RID: 285
		internal float lastTweenInsertTime;
	}
}
