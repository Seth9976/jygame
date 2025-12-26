using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x0200000C RID: 12
	public static class TweenSettingsExtensions
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00002FE8 File Offset: 0x000011E8
		public static T SetAutoKill<T>(this T t) where T : Tween
		{
			if (!t.active || t.creationLocked)
			{
				return t;
			}
			t.autoKill = true;
			return t;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003013 File Offset: 0x00001213
		public static T SetAutoKill<T>(this T t, bool autoKillOnCompletion) where T : Tween
		{
			if (!t.active || t.creationLocked)
			{
				return t;
			}
			t.autoKill = autoKillOnCompletion;
			return t;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000303E File Offset: 0x0000123E
		public static T SetId<T>(this T t, object id) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.id = id;
			return t;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000305C File Offset: 0x0000125C
		public static T SetTarget<T>(this T t, object target) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.target = target;
			return t;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000307C File Offset: 0x0000127C
		public static T SetLoops<T>(this T t, int loops) where T : Tween
		{
			if (!t.active || t.creationLocked)
			{
				return t;
			}
			if (loops < -1)
			{
				loops = -1;
			}
			else if (loops == 0)
			{
				loops = 1;
			}
			t.loops = loops;
			if (t.tweenType == TweenType.Tweener)
			{
				if (loops > -1)
				{
					t.fullDuration = t.duration * (float)loops;
				}
				else
				{
					t.fullDuration = float.PositiveInfinity;
				}
			}
			return t;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003100 File Offset: 0x00001300
		public static T SetLoops<T>(this T t, int loops, LoopType loopType) where T : Tween
		{
			if (!t.active || t.creationLocked)
			{
				return t;
			}
			if (loops < -1)
			{
				loops = -1;
			}
			else if (loops == 0)
			{
				loops = 1;
			}
			t.loops = loops;
			t.loopType = loopType;
			if (t.tweenType == TweenType.Tweener)
			{
				if (loops > -1)
				{
					t.fullDuration = t.duration * (float)loops;
				}
				else
				{
					t.fullDuration = float.PositiveInfinity;
				}
			}
			return t;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000318D File Offset: 0x0000138D
		public static T SetEase<T>(this T t, Ease ease) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.easeType = ease;
			t.customEase = null;
			return t;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000031B7 File Offset: 0x000013B7
		public static T SetEase<T>(this T t, Ease ease, float overshoot) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.easeType = ease;
			t.easeOvershootOrAmplitude = overshoot;
			t.customEase = null;
			return t;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000031F0 File Offset: 0x000013F0
		public static T SetEase<T>(this T t, Ease ease, float amplitude, float period) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.easeType = ease;
			t.easeOvershootOrAmplitude = amplitude;
			t.easePeriod = period;
			t.customEase = null;
			return t;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000323D File Offset: 0x0000143D
		public static T SetEase<T>(this T t, AnimationCurve animCurve) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.easeType = Ease.INTERNAL_Custom;
			t.customEase = new EaseFunction(new EaseCurve(animCurve).Evaluate);
			return t;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003278 File Offset: 0x00001478
		public static T SetEase<T>(this T t, EaseFunction customEase) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.easeType = Ease.INTERNAL_Custom;
			t.customEase = customEase;
			return t;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000032A3 File Offset: 0x000014A3
		public static T SetRecyclable<T>(this T t) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.isRecyclable = true;
			return t;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000032C1 File Offset: 0x000014C1
		public static T SetRecyclable<T>(this T t, bool recyclable) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.isRecyclable = recyclable;
			return t;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000032DF File Offset: 0x000014DF
		public static T SetUpdate<T>(this T t, bool isIndependentUpdate) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			TweenManager.SetUpdateType(t, UpdateType.Default, isIndependentUpdate);
			return t;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000032FE File Offset: 0x000014FE
		public static T SetUpdate<T>(this T t, UpdateType updateType, bool isIndependentUpdate = false) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			TweenManager.SetUpdateType(t, updateType, isIndependentUpdate);
			return t;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000331D File Offset: 0x0000151D
		public static T OnStart<T>(this T t, TweenCallback action) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.onStart = action;
			return t;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000333B File Offset: 0x0000153B
		public static T OnPlay<T>(this T t, TweenCallback action) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.onPlay = action;
			return t;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003359 File Offset: 0x00001559
		public static T OnPause<T>(this T t, TweenCallback action) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.onPause = action;
			return t;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003377 File Offset: 0x00001577
		public static T OnRewind<T>(this T t, TweenCallback action) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.onRewind = action;
			return t;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003395 File Offset: 0x00001595
		public static T OnUpdate<T>(this T t, TweenCallback action) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.onUpdate = action;
			return t;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000033B3 File Offset: 0x000015B3
		public static T OnStepComplete<T>(this T t, TweenCallback action) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.onStepComplete = action;
			return t;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000033D1 File Offset: 0x000015D1
		public static T OnComplete<T>(this T t, TweenCallback action) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.onComplete = action;
			return t;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000033EF File Offset: 0x000015EF
		public static T OnKill<T>(this T t, TweenCallback action) where T : Tween
		{
			if (!t.active)
			{
				return t;
			}
			t.onKill = action;
			return t;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003410 File Offset: 0x00001610
		public static T SetAs<T>(this T t, Tween asTween) where T : Tween
		{
			if (!t.active || t.creationLocked)
			{
				return t;
			}
			t.timeScale = asTween.timeScale;
			t.isBackwards = asTween.isBackwards;
			TweenManager.SetUpdateType(t, asTween.updateType, asTween.isIndependentUpdate);
			t.id = asTween.id;
			t.onStart = asTween.onStart;
			t.onPlay = asTween.onPlay;
			t.onRewind = asTween.onRewind;
			t.onUpdate = asTween.onUpdate;
			t.onStepComplete = asTween.onStepComplete;
			t.onComplete = asTween.onComplete;
			t.onKill = asTween.onKill;
			t.isRecyclable = asTween.isRecyclable;
			t.isSpeedBased = asTween.isSpeedBased;
			t.autoKill = asTween.autoKill;
			t.loops = asTween.loops;
			t.loopType = asTween.loopType;
			if (t.tweenType == TweenType.Tweener)
			{
				if (t.loops > -1)
				{
					t.fullDuration = t.duration * (float)t.loops;
				}
				else
				{
					t.fullDuration = float.PositiveInfinity;
				}
			}
			t.delay = asTween.delay;
			t.delayComplete = t.delay <= 0f;
			t.isRelative = asTween.isRelative;
			t.easeType = asTween.easeType;
			t.customEase = asTween.customEase;
			t.easeOvershootOrAmplitude = asTween.easeOvershootOrAmplitude;
			t.easePeriod = asTween.easePeriod;
			return t;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003628 File Offset: 0x00001828
		public static T SetAs<T>(this T t, TweenParams tweenParams) where T : Tween
		{
			if (!t.active || t.creationLocked)
			{
				return t;
			}
			TweenManager.SetUpdateType(t, tweenParams.updateType, tweenParams.isIndependentUpdate);
			t.id = tweenParams.id;
			t.onStart = tweenParams.onStart;
			t.onPlay = tweenParams.onPlay;
			t.onRewind = tweenParams.onRewind;
			t.onUpdate = tweenParams.onUpdate;
			t.onStepComplete = tweenParams.onStepComplete;
			t.onComplete = tweenParams.onComplete;
			t.onKill = tweenParams.onKill;
			t.isRecyclable = tweenParams.isRecyclable;
			t.isSpeedBased = tweenParams.isSpeedBased;
			t.autoKill = tweenParams.autoKill;
			t.loops = tweenParams.loops;
			t.loopType = tweenParams.loopType;
			if (t.tweenType == TweenType.Tweener)
			{
				if (t.loops > -1)
				{
					t.fullDuration = t.duration * (float)t.loops;
				}
				else
				{
					t.fullDuration = float.PositiveInfinity;
				}
			}
			t.delay = tweenParams.delay;
			t.delayComplete = t.delay <= 0f;
			t.isRelative = tweenParams.isRelative;
			if (tweenParams.easeType == Ease.Unset)
			{
				if (t.tweenType == TweenType.Sequence)
				{
					t.easeType = Ease.Linear;
				}
				else
				{
					t.easeType = DOTween.defaultEaseType;
				}
			}
			else
			{
				t.easeType = tweenParams.easeType;
			}
			t.customEase = tweenParams.customEase;
			t.easeOvershootOrAmplitude = tweenParams.easeOvershootOrAmplitude;
			t.easePeriod = tweenParams.easePeriod;
			return t;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003852 File Offset: 0x00001A52
		public static Sequence Append(this Sequence s, Tween t)
		{
			if (!s.active || s.creationLocked)
			{
				return s;
			}
			if (t == null || !t.active)
			{
				return s;
			}
			Sequence.DoInsert(s, t, s.duration);
			return s;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003882 File Offset: 0x00001A82
		public static Sequence Prepend(this Sequence s, Tween t)
		{
			if (!s.active || s.creationLocked)
			{
				return s;
			}
			if (t == null || !t.active)
			{
				return s;
			}
			Sequence.DoPrepend(s, t);
			return s;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000038AC File Offset: 0x00001AAC
		public static Sequence Join(this Sequence s, Tween t)
		{
			if (!s.active || s.creationLocked)
			{
				return s;
			}
			if (t == null || !t.active)
			{
				return s;
			}
			Sequence.DoInsert(s, t, s.lastTweenInsertTime);
			return s;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000038DC File Offset: 0x00001ADC
		public static Sequence Insert(this Sequence s, float atPosition, Tween t)
		{
			if (!s.active || s.creationLocked)
			{
				return s;
			}
			if (t == null || !t.active)
			{
				return s;
			}
			Sequence.DoInsert(s, t, atPosition);
			return s;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003907 File Offset: 0x00001B07
		public static Sequence AppendInterval(this Sequence s, float interval)
		{
			if (!s.active || s.creationLocked)
			{
				return s;
			}
			Sequence.DoAppendInterval(s, interval);
			return s;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003924 File Offset: 0x00001B24
		public static Sequence PrependInterval(this Sequence s, float interval)
		{
			if (!s.active || s.creationLocked)
			{
				return s;
			}
			Sequence.DoPrependInterval(s, interval);
			return s;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003941 File Offset: 0x00001B41
		public static Sequence AppendCallback(this Sequence s, TweenCallback callback)
		{
			if (!s.active || s.creationLocked)
			{
				return s;
			}
			if (callback == null)
			{
				return s;
			}
			Sequence.DoInsertCallback(s, callback, s.duration);
			return s;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003969 File Offset: 0x00001B69
		public static Sequence PrependCallback(this Sequence s, TweenCallback callback)
		{
			if (!s.active || s.creationLocked)
			{
				return s;
			}
			if (callback == null)
			{
				return s;
			}
			Sequence.DoInsertCallback(s, callback, 0f);
			return s;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003990 File Offset: 0x00001B90
		public static Sequence InsertCallback(this Sequence s, float atPosition, TweenCallback callback)
		{
			if (!s.active || s.creationLocked)
			{
				return s;
			}
			if (callback == null)
			{
				return s;
			}
			Sequence.DoInsertCallback(s, callback, atPosition);
			return s;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000039B4 File Offset: 0x00001BB4
		public static T From<T>(this T t) where T : Tweener
		{
			if (!t.active || t.creationLocked || !t.isFromAllowed)
			{
				return t;
			}
			t.isFrom = true;
			t.SetFrom(false);
			return t;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003A08 File Offset: 0x00001C08
		public static T From<T>(this T t, bool isRelative) where T : Tweener
		{
			if (!t.active || t.creationLocked || !t.isFromAllowed)
			{
				return t;
			}
			t.isFrom = true;
			t.SetFrom(isRelative);
			return t;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003A5C File Offset: 0x00001C5C
		public static T SetDelay<T>(this T t, float delay) where T : Tween
		{
			if (!t.active || t.creationLocked)
			{
				return t;
			}
			t.delay = delay;
			t.delayComplete = delay <= 0f;
			return t;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003AA8 File Offset: 0x00001CA8
		public static T SetRelative<T>(this T t) where T : Tween
		{
			if (!t.active || t.creationLocked || t.isFrom)
			{
				return t;
			}
			t.isRelative = true;
			return t;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003AE0 File Offset: 0x00001CE0
		public static T SetRelative<T>(this T t, bool isRelative) where T : Tween
		{
			if (!t.active || t.creationLocked || t.isFrom)
			{
				return t;
			}
			t.isRelative = isRelative;
			return t;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003B18 File Offset: 0x00001D18
		public static T SetSpeedBased<T>(this T t) where T : Tween
		{
			if (!t.active || t.creationLocked)
			{
				return t;
			}
			t.isSpeedBased = true;
			return t;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003B43 File Offset: 0x00001D43
		public static T SetSpeedBased<T>(this T t, bool isSpeedBased) where T : Tween
		{
			if (!t.active || t.creationLocked)
			{
				return t;
			}
			t.isSpeedBased = isSpeedBased;
			return t;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003B6E File Offset: 0x00001D6E
		public static Tweener SetOptions(this TweenerCore<float, float, FloatOptions> t, bool snapping)
		{
			if (!t.active)
			{
				return t;
			}
			t.plugOptions.snapping = snapping;
			return t;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003B87 File Offset: 0x00001D87
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping)
		{
			if (!t.active)
			{
				return t;
			}
			t.plugOptions.snapping = snapping;
			return t;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003BA0 File Offset: 0x00001DA0
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			if (!t.active)
			{
				return t;
			}
			t.plugOptions.axisConstraint = axisConstraint;
			t.plugOptions.snapping = snapping;
			return t;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003BC5 File Offset: 0x00001DC5
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping)
		{
			if (!t.active)
			{
				return t;
			}
			t.plugOptions.snapping = snapping;
			return t;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003BDE File Offset: 0x00001DDE
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			if (!t.active)
			{
				return t;
			}
			t.plugOptions.axisConstraint = axisConstraint;
			t.plugOptions.snapping = snapping;
			return t;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003C03 File Offset: 0x00001E03
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping)
		{
			if (!t.active)
			{
				return t;
			}
			t.plugOptions.snapping = snapping;
			return t;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003C1C File Offset: 0x00001E1C
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			if (!t.active)
			{
				return t;
			}
			t.plugOptions.axisConstraint = axisConstraint;
			t.plugOptions.snapping = snapping;
			return t;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003C41 File Offset: 0x00001E41
		public static Tweener SetOptions(this TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true)
		{
			if (!t.active)
			{
				return t;
			}
			t.plugOptions.rotateMode = (useShortest360Route ? RotateMode.Fast : RotateMode.FastBeyond360);
			return t;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003C60 File Offset: 0x00001E60
		public static Tweener SetOptions(this TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly)
		{
			if (!t.active)
			{
				return t;
			}
			t.plugOptions.alphaOnly = alphaOnly;
			return t;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003C79 File Offset: 0x00001E79
		public static Tweener SetOptions(this TweenerCore<Rect, Rect, RectOptions> t, bool snapping)
		{
			if (!t.active)
			{
				return t;
			}
			t.plugOptions.snapping = snapping;
			return t;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003C94 File Offset: 0x00001E94
		public static Tweener SetOptions(this TweenerCore<string, string, StringOptions> t, bool scramble, string scrambleChars = null)
		{
			if (!t.active)
			{
				return t;
			}
			t.plugOptions.scramble = scramble;
			if (!string.IsNullOrEmpty(scrambleChars))
			{
				if (scrambleChars.Length <= 1)
				{
					scrambleChars += scrambleChars;
				}
				t.plugOptions.scrambledChars = scrambleChars.ToCharArray();
				t.plugOptions.scrambledChars.ScrambleChars();
			}
			return t;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003CF3 File Offset: 0x00001EF3
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping)
		{
			if (!t.active)
			{
				return t;
			}
			t.plugOptions.snapping = snapping;
			return t;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003D0C File Offset: 0x00001F0C
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			if (!t.active)
			{
				return t;
			}
			t.plugOptions.axisConstraint = axisConstraint;
			t.plugOptions.snapping = snapping;
			return t;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003D31 File Offset: 0x00001F31
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = AxisConstraint.None)
		{
			return t.SetOptions(false, lockPosition, lockRotation);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003D3C File Offset: 0x00001F3C
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = AxisConstraint.None, AxisConstraint lockRotation = AxisConstraint.None)
		{
			t.plugOptions.isClosedPath = closePath;
			t.plugOptions.lockPositionAxis = lockPosition;
			t.plugOptions.lockRotationAxis = lockRotation;
			return t;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003D63 File Offset: 0x00001F63
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Vector3? forwardDirection = null, Vector3? up = null)
		{
			t.plugOptions.orientType = OrientType.LookAtPosition;
			t.plugOptions.lookAtPosition = lookAtPosition;
			t.SetPathForwardDirection(forwardDirection, up);
			return t;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003D86 File Offset: 0x00001F86
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Vector3? forwardDirection = null, Vector3? up = null)
		{
			t.plugOptions.orientType = OrientType.LookAtTransform;
			t.plugOptions.lookAtTransform = lookAtTransform;
			t.SetPathForwardDirection(forwardDirection, up);
			return t;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003DA9 File Offset: 0x00001FA9
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Vector3? forwardDirection = null, Vector3? up = null)
		{
			t.plugOptions.orientType = OrientType.ToPath;
			if (lookAhead < 0.0001f)
			{
				lookAhead = 0.0001f;
			}
			t.plugOptions.lookAhead = lookAhead;
			t.SetPathForwardDirection(forwardDirection, up);
			return t;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003DDC File Offset: 0x00001FDC
		private static void SetPathForwardDirection(this TweenerCore<Vector3, Path, PathOptions> t, Vector3? forwardDirection = null, Vector3? up = null)
		{
			t.plugOptions.hasCustomForwardDirection = (forwardDirection != null && forwardDirection != Vector3.zero) || (up != null && up != Vector3.zero);
			if (t.plugOptions.hasCustomForwardDirection)
			{
				if (forwardDirection == Vector3.zero)
				{
					forwardDirection = new Vector3?(Vector3.forward);
				}
				t.plugOptions.forward = Quaternion.LookRotation((forwardDirection == null) ? Vector3.forward : forwardDirection.Value, (up == null) ? Vector3.up : up.Value);
			}
		}
	}
}
