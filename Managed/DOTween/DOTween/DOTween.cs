using System;
using System.Collections.Generic;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000008 RID: 8
	public class DOTween
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002525 File Offset: 0x00000725
		// (set) Token: 0x06000014 RID: 20 RVA: 0x0000252C File Offset: 0x0000072C
		public static LogBehaviour logBehaviour
		{
			get
			{
				return DOTween._logBehaviour;
			}
			set
			{
				DOTween._logBehaviour = value;
				Debugger.SetLogPriority(DOTween._logBehaviour);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000025B4 File Offset: 0x000007B4
		public static IDOTweenInit Init(bool recycleAllByDefault = false, bool useSafeMode = true, LogBehaviour logBehaviour = LogBehaviour.ErrorsOnly)
		{
			if (DOTween.initialized)
			{
				return DOTween.instance;
			}
			if (!Application.isPlaying || DOTween.isQuitting)
			{
				return null;
			}
			DOTween.initialized = true;
			DOTween.defaultRecyclable = recycleAllByDefault;
			DOTween.useSafeMode = useSafeMode;
			DOTween.logBehaviour = logBehaviour;
			DOTweenComponent.Create();
			if (Debugger.logPriority >= 2)
			{
				Debugger.Log(string.Concat(new object[] { "DOTween initialization (useSafeMode: ", useSafeMode, ", logBehaviour: ", logBehaviour, ")" }));
			}
			return DOTween.instance;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002644 File Offset: 0x00000844
		public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity)
		{
			TweenManager.SetCapacities(tweenersCapacity, sequencesCapacity);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002650 File Offset: 0x00000850
		public static void Clear(bool destroy = false)
		{
			TweenManager.PurgeAll();
			PluginsManager.PurgeAll();
			if (!destroy)
			{
				return;
			}
			DOTween.initialized = false;
			DOTween.useSafeMode = false;
			DOTween.showUnityEditorReport = false;
			DOTween.timeScale = 1f;
			DOTween.logBehaviour = LogBehaviour.ErrorsOnly;
			DOTween.defaultEaseType = Ease.OutQuad;
			DOTween.defaultEaseOvershootOrAmplitude = 1.70158f;
			DOTween.defaultEasePeriod = 0f;
			DOTween.defaultAutoPlay = AutoPlay.All;
			DOTween.defaultLoopType = LoopType.Restart;
			DOTween.defaultAutoKill = true;
			DOTween.defaultRecyclable = false;
			DOTween.maxActiveTweenersReached = (DOTween.maxActiveSequencesReached = 0);
			DOTweenComponent.DestroyInstance();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000026D0 File Offset: 0x000008D0
		public static void ClearCachedTweens()
		{
			TweenManager.PurgePools();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000026D7 File Offset: 0x000008D7
		public static int Validate()
		{
			return TweenManager.Validate();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000026DE File Offset: 0x000008DE
		public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration)
		{
			return DOTween.ApplyTo<float, float, FloatOptions>(getter, setter, endValue, duration, null);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000026EA File Offset: 0x000008EA
		public static Tweener To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration)
		{
			return DOTween.ApplyTo<int, int, NoOptions>(getter, setter, endValue, duration, null);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000026F6 File Offset: 0x000008F6
		public static Tweener To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration)
		{
			return DOTween.ApplyTo<uint, uint, NoOptions>(getter, setter, endValue, duration, null);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002702 File Offset: 0x00000902
		public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration)
		{
			return DOTween.ApplyTo<string, string, StringOptions>(getter, setter, endValue, duration, null);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000270E File Offset: 0x0000090E
		public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration)
		{
			return DOTween.ApplyTo<Vector2, Vector2, VectorOptions>(getter, setter, endValue, duration, null);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000271A File Offset: 0x0000091A
		public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration)
		{
			return DOTween.ApplyTo<Vector3, Vector3, VectorOptions>(getter, setter, endValue, duration, null);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002726 File Offset: 0x00000926
		public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration)
		{
			return DOTween.ApplyTo<Vector4, Vector4, VectorOptions>(getter, setter, endValue, duration, null);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002732 File Offset: 0x00000932
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration)
		{
			return DOTween.ApplyTo<Quaternion, Vector3, QuaternionOptions>(getter, setter, endValue, duration, null);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000273E File Offset: 0x0000093E
		public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration)
		{
			return DOTween.ApplyTo<Color, Color, ColorOptions>(getter, setter, endValue, duration, null);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000274A File Offset: 0x0000094A
		public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration)
		{
			return DOTween.ApplyTo<Rect, Rect, RectOptions>(getter, setter, endValue, duration, null);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002756 File Offset: 0x00000956
		public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration)
		{
			return DOTween.ApplyTo<RectOffset, RectOffset, NoOptions>(getter, setter, endValue, duration, null);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002762 File Offset: 0x00000962
		public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) where TPlugOptions : struct
		{
			return DOTween.ApplyTo<T1, T2, TPlugOptions>(getter, setter, endValue, duration, plugin);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002770 File Offset: 0x00000970
		public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = AxisConstraint.X)
		{
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = DOTween.ApplyTo<Vector3, Vector3, VectorOptions>(getter, setter, new Vector3(endValue, endValue, endValue), duration, null);
			tweenerCore.plugOptions.axisConstraint = axisConstraint;
			return tweenerCore;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000279D File Offset: 0x0000099D
		public static Tweener ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration)
		{
			return DOTween.ApplyTo<Color, Color, ColorOptions>(getter, setter, new Color(0f, 0f, 0f, endValue), duration, null).SetOptions(true);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000027F0 File Offset: 0x000009F0
		public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration)
		{
			return DOTween.To(() => startValue, delegate(float x)
			{
				startValue = x;
				setter(startValue);
			}, endValue, duration).NoFrom<float, float, FloatOptions>();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002838 File Offset: 0x00000A38
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1f)
		{
			if (elasticity > 1f)
			{
				elasticity = 1f;
			}
			else if (elasticity < 0f)
			{
				elasticity = 0f;
			}
			float num = direction.magnitude;
			int num2 = (int)((float)vibrato * duration);
			if (num2 < 2)
			{
				num2 = 2;
			}
			float num3 = num / (float)num2;
			float[] array = new float[num2];
			float num4 = 0f;
			for (int i = 0; i < num2; i++)
			{
				float num5 = (float)(i + 1) / (float)num2;
				float num6 = duration * num5;
				num4 += num6;
				array[i] = num6;
			}
			float num7 = duration / num4;
			for (int j = 0; j < num2; j++)
			{
				array[j] *= num7;
			}
			Vector3[] array2 = new Vector3[num2];
			for (int k = 0; k < num2; k++)
			{
				if (k < num2 - 1)
				{
					if (k == 0)
					{
						array2[k] = direction;
					}
					else if (k % 2 != 0)
					{
						array2[k] = -Vector3.ClampMagnitude(direction, num * elasticity);
					}
					else
					{
						array2[k] = Vector3.ClampMagnitude(direction, num);
					}
					num -= num3;
				}
				else
				{
					array2[k] = Vector3.zero;
				}
			}
			return DOTween.ToArray(getter, setter, array2, array).NoFrom<Vector3, Vector3[], Vector3ArrayOptions>().SetSpecialStartupMode(SpecialStartupMode.SetPunch);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002979 File Offset: 0x00000B79
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3f, int vibrato = 10, float randomness = 90f, bool ignoreZAxis = true)
		{
			return DOTween.Shake(getter, setter, duration, new Vector3(strength, strength, strength), vibrato, randomness, ignoreZAxis, false);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002992 File Offset: 0x00000B92
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f)
		{
			return DOTween.Shake(getter, setter, duration, strength, vibrato, randomness, false, true);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000029A4 File Offset: 0x00000BA4
		private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased)
		{
			float num = (vectorBased ? strength.magnitude : strength.x);
			int num2 = (int)((float)vibrato * duration);
			if (num2 < 2)
			{
				num2 = 2;
			}
			float num3 = num / (float)num2;
			float[] array = new float[num2];
			float num4 = 0f;
			for (int i = 0; i < num2; i++)
			{
				float num5 = (float)(i + 1) / (float)num2;
				float num6 = duration * num5;
				num4 += num6;
				array[i] = num6;
			}
			float num7 = duration / num4;
			for (int j = 0; j < num2; j++)
			{
				array[j] *= num7;
			}
			float num8 = global::UnityEngine.Random.Range(0f, 360f);
			Vector3[] array2 = new Vector3[num2];
			for (int k = 0; k < num2; k++)
			{
				if (k < num2 - 1)
				{
					if (k > 0)
					{
						num8 = num8 - 180f + global::UnityEngine.Random.Range(-randomness, randomness);
					}
					if (vectorBased)
					{
						Quaternion quaternion = Quaternion.AngleAxis(global::UnityEngine.Random.Range(-randomness, randomness), Vector3.up);
						Vector3 vector = quaternion * Utils.Vector3FromAngle(num8, num);
						vector.x = Vector3.ClampMagnitude(vector, strength.x).x;
						vector.y = Vector3.ClampMagnitude(vector, strength.y).y;
						vector.z = Vector3.ClampMagnitude(vector, strength.z).z;
						array2[k] = vector;
						num -= num3;
						strength = Vector3.ClampMagnitude(strength, num);
					}
					else
					{
						if (ignoreZAxis)
						{
							array2[k] = Utils.Vector3FromAngle(num8, num);
						}
						else
						{
							Quaternion quaternion2 = Quaternion.AngleAxis(global::UnityEngine.Random.Range(-randomness, randomness), Vector3.up);
							array2[k] = quaternion2 * Utils.Vector3FromAngle(num8, num);
						}
						num -= num3;
					}
				}
				else
				{
					array2[k] = Vector3.zero;
				}
			}
			return DOTween.ToArray(getter, setter, array2, array).NoFrom<Vector3, Vector3[], Vector3ArrayOptions>().SetSpecialStartupMode(SpecialStartupMode.SetShake);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002BA0 File Offset: 0x00000DA0
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations)
		{
			int num = durations.Length;
			if (num != endValues.Length)
			{
				Debugger.LogError("To Vector3 array tween: endValues and durations arrays must have the same length");
				return null;
			}
			Vector3[] array = new Vector3[num];
			float[] array2 = new float[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = endValues[i];
				array2[i] = durations[i];
			}
			float num2 = 0f;
			for (int j = 0; j < num; j++)
			{
				num2 += array2[j];
			}
			TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> tweenerCore = DOTween.ApplyTo<Vector3, Vector3[], Vector3ArrayOptions>(getter, setter, array, num2, null).NoFrom<Vector3, Vector3[], Vector3ArrayOptions>();
			tweenerCore.plugOptions.durations = array2;
			return tweenerCore;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002C3C File Offset: 0x00000E3C
		internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration)
		{
			return DOTween.ApplyTo<Color2, Color2, ColorOptions>(getter, setter, endValue, duration, null);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002C48 File Offset: 0x00000E48
		public static Sequence Sequence()
		{
			DOTween.InitCheck();
			Sequence sequence = TweenManager.GetSequence();
			DG.Tweening.Sequence.Setup(sequence);
			return sequence;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002C67 File Offset: 0x00000E67
		public static int Complete()
		{
			return TweenManager.FilteredOperation(OperationType.Complete, FilterType.All, null, false, 0f);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002C77 File Offset: 0x00000E77
		public static int Complete(object targetOrId)
		{
			if (targetOrId == null)
			{
				return 0;
			}
			return TweenManager.FilteredOperation(OperationType.Complete, FilterType.TargetOrId, targetOrId, false, 0f);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002C8C File Offset: 0x00000E8C
		internal static int CompleteAndReturnKilledTot()
		{
			return TweenManager.FilteredOperation(OperationType.Complete, FilterType.All, null, true, 0f);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002C9C File Offset: 0x00000E9C
		internal static int CompleteAndReturnKilledTot(object targetOrId)
		{
			if (targetOrId == null)
			{
				return 0;
			}
			return TweenManager.FilteredOperation(OperationType.Complete, FilterType.TargetOrId, targetOrId, true, 0f);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002CB1 File Offset: 0x00000EB1
		public static int Flip()
		{
			return TweenManager.FilteredOperation(OperationType.Flip, FilterType.All, null, false, 0f);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002CC1 File Offset: 0x00000EC1
		public static int Flip(object targetOrId)
		{
			if (targetOrId == null)
			{
				return 0;
			}
			return TweenManager.FilteredOperation(OperationType.Flip, FilterType.TargetOrId, targetOrId, false, 0f);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002CD6 File Offset: 0x00000ED6
		public static int Goto(float to, bool andPlay = false)
		{
			return TweenManager.FilteredOperation(OperationType.Goto, FilterType.All, null, andPlay, to);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002CE2 File Offset: 0x00000EE2
		public static int Goto(object targetOrId, float to, bool andPlay = false)
		{
			if (targetOrId == null)
			{
				return 0;
			}
			return TweenManager.FilteredOperation(OperationType.Goto, FilterType.TargetOrId, targetOrId, andPlay, to);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002CF4 File Offset: 0x00000EF4
		public static int Kill(bool complete = false)
		{
			int num = (complete ? DOTween.CompleteAndReturnKilledTot() : 0);
			return num + TweenManager.DespawnAll();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002D14 File Offset: 0x00000F14
		public static int Kill(object targetOrId, bool complete = false)
		{
			if (targetOrId == null)
			{
				return 0;
			}
			int num = (complete ? DOTween.CompleteAndReturnKilledTot(targetOrId) : 0);
			return num + TweenManager.FilteredOperation(OperationType.Despawn, FilterType.TargetOrId, targetOrId, false, 0f);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002D43 File Offset: 0x00000F43
		public static int Pause()
		{
			return TweenManager.FilteredOperation(OperationType.Pause, FilterType.All, null, false, 0f);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002D53 File Offset: 0x00000F53
		public static int Pause(object targetOrId)
		{
			if (targetOrId == null)
			{
				return 0;
			}
			return TweenManager.FilteredOperation(OperationType.Pause, FilterType.TargetOrId, targetOrId, false, 0f);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002D68 File Offset: 0x00000F68
		public static int Play()
		{
			return TweenManager.FilteredOperation(OperationType.Play, FilterType.All, null, false, 0f);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002D78 File Offset: 0x00000F78
		public static int Play(object targetOrId)
		{
			if (targetOrId == null)
			{
				return 0;
			}
			return TweenManager.FilteredOperation(OperationType.Play, FilterType.TargetOrId, targetOrId, false, 0f);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002D8D File Offset: 0x00000F8D
		public static int PlayBackwards()
		{
			return TweenManager.FilteredOperation(OperationType.PlayBackwards, FilterType.All, null, false, 0f);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002D9D File Offset: 0x00000F9D
		public static int PlayBackwards(object targetOrId)
		{
			if (targetOrId == null)
			{
				return 0;
			}
			return TweenManager.FilteredOperation(OperationType.PlayBackwards, FilterType.TargetOrId, targetOrId, false, 0f);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002DB2 File Offset: 0x00000FB2
		public static int PlayForward()
		{
			return TweenManager.FilteredOperation(OperationType.PlayForward, FilterType.All, null, false, 0f);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002DC2 File Offset: 0x00000FC2
		public static int PlayForward(object targetOrId)
		{
			if (targetOrId == null)
			{
				return 0;
			}
			return TweenManager.FilteredOperation(OperationType.PlayForward, FilterType.TargetOrId, targetOrId, false, 0f);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002DD7 File Offset: 0x00000FD7
		public static int Restart(bool includeDelay = true)
		{
			return TweenManager.FilteredOperation(OperationType.Restart, FilterType.All, null, includeDelay, 0f);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002DE8 File Offset: 0x00000FE8
		public static int Restart(object targetOrId, bool includeDelay = true)
		{
			if (targetOrId == null)
			{
				return 0;
			}
			return TweenManager.FilteredOperation(OperationType.Restart, FilterType.TargetOrId, targetOrId, includeDelay, 0f);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002DFE File Offset: 0x00000FFE
		public static int Rewind(bool includeDelay = true)
		{
			return TweenManager.FilteredOperation(OperationType.Rewind, FilterType.All, null, includeDelay, 0f);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002E0E File Offset: 0x0000100E
		public static int Rewind(object targetOrId, bool includeDelay = true)
		{
			if (targetOrId == null)
			{
				return 0;
			}
			return TweenManager.FilteredOperation(OperationType.Rewind, FilterType.TargetOrId, targetOrId, includeDelay, 0f);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002E23 File Offset: 0x00001023
		public static int TogglePause()
		{
			return TweenManager.FilteredOperation(OperationType.TogglePause, FilterType.All, null, false, 0f);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002E34 File Offset: 0x00001034
		public static int TogglePause(object targetOrId)
		{
			if (targetOrId == null)
			{
				return 0;
			}
			return TweenManager.FilteredOperation(OperationType.TogglePause, FilterType.TargetOrId, targetOrId, false, 0f);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002E4A File Offset: 0x0000104A
		public static bool IsTweening(object targetOrId)
		{
			return TweenManager.FilteredOperation(OperationType.IsTweening, FilterType.TargetOrId, targetOrId, false, 0f) > 0;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002E5E File Offset: 0x0000105E
		public static int TotalPlayingTweens()
		{
			return TweenManager.TotalPlayingTweens();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002E65 File Offset: 0x00001065
		public static List<Tween> PlayingTweens()
		{
			return TweenManager.GetActiveTweens(true);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002E6D File Offset: 0x0000106D
		public static List<Tween> PausedTweens()
		{
			return TweenManager.GetActiveTweens(false);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002E78 File Offset: 0x00001078
		private static void InitCheck()
		{
			if (DOTween.initialized || !Application.isPlaying || DOTween.isQuitting)
			{
				return;
			}
			DOTween.Init(DOTween.defaultRecyclable, DOTween.useSafeMode, DOTween.logBehaviour);
			Debugger.LogWarning(string.Concat(new object[]
			{
				"DOTween auto-initialized with default settings (recycleAllByDefault: ",
				DOTween.defaultRecyclable,
				", useSafeMode: ",
				DOTween.useSafeMode,
				", logBehaviour: ",
				DOTween.logBehaviour,
				"). Call DOTween.Init before creating your first tween in order to choose the settings yourself"
			}));
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002F0C File Offset: 0x0000110C
		private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null) where TPlugOptions : struct
		{
			DOTween.InitCheck();
			TweenerCore<T1, T2, TPlugOptions> tweener = TweenManager.GetTweener<T1, T2, TPlugOptions>();
			if (!Tweener.Setup<T1, T2, TPlugOptions>(tweener, getter, setter, endValue, duration, plugin))
			{
				TweenManager.Despawn(tweener, true);
				return null;
			}
			return tweener;
		}

		// Token: 0x04000008 RID: 8
		public static readonly string Version = "0.9.490";

		// Token: 0x04000009 RID: 9
		public static bool useSafeMode = true;

		// Token: 0x0400000A RID: 10
		public static bool showUnityEditorReport = false;

		// Token: 0x0400000B RID: 11
		public static float timeScale = 1f;

		// Token: 0x0400000C RID: 12
		private static LogBehaviour _logBehaviour = LogBehaviour.ErrorsOnly;

		// Token: 0x0400000D RID: 13
		public static AutoPlay defaultAutoPlay = AutoPlay.All;

		// Token: 0x0400000E RID: 14
		public static bool defaultAutoKill = true;

		// Token: 0x0400000F RID: 15
		public static LoopType defaultLoopType = LoopType.Restart;

		// Token: 0x04000010 RID: 16
		public static bool defaultRecyclable;

		// Token: 0x04000011 RID: 17
		public static Ease defaultEaseType = Ease.InOutQuad;

		// Token: 0x04000012 RID: 18
		public static float defaultEaseOvershootOrAmplitude = 1.70158f;

		// Token: 0x04000013 RID: 19
		public static float defaultEasePeriod = 0f;

		// Token: 0x04000014 RID: 20
		internal static DOTweenComponent instance;

		// Token: 0x04000015 RID: 21
		internal static bool isUnityEditor = Application.isEditor;

		// Token: 0x04000016 RID: 22
		internal static bool isDebugBuild;

		// Token: 0x04000017 RID: 23
		internal static int maxActiveTweenersReached;

		// Token: 0x04000018 RID: 24
		internal static int maxActiveSequencesReached;

		// Token: 0x04000019 RID: 25
		internal static readonly List<TweenCallback> GizmosDelegates = new List<TweenCallback>();

		// Token: 0x0400001A RID: 26
		internal static bool initialized;

		// Token: 0x0400001B RID: 27
		internal static bool isQuitting;
	}
}
