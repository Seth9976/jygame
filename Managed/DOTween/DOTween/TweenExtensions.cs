using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000015 RID: 21
	public static class TweenExtensions
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00005110 File Offset: 0x00003310
		public static void Complete(this Tween t)
		{
			if (t == null)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogNullTween(t);
				}
				return;
			}
			if (!t.active)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			if (t.isSequenced)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			TweenManager.Complete(t, true);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005168 File Offset: 0x00003368
		public static void Flip(this Tween t)
		{
			if (t == null)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogNullTween(t);
				}
				return;
			}
			if (!t.active)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			if (t.isSequenced)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			TweenManager.Flip(t);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000051BC File Offset: 0x000033BC
		public static void Goto(this Tween t, float to, bool andPlay = false)
		{
			if (t == null)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogNullTween(t);
				}
				return;
			}
			if (!t.active)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			if (t.isSequenced)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			if (to < 0f)
			{
				to = 0f;
			}
			TweenManager.Goto(t, to, andPlay, UpdateMode.Goto);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005224 File Offset: 0x00003424
		public static void Kill(this Tween t, bool complete = false)
		{
			if (t == null)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogNullTween(t);
				}
				return;
			}
			if (!t.active)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			if (t.isSequenced)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			if (complete)
			{
				TweenManager.Complete(t, true);
				if (t.autoKill)
				{
					return;
				}
			}
			if (TweenManager.isUpdateLoop)
			{
				t.active = false;
				return;
			}
			TweenManager.Despawn(t, true);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000529C File Offset: 0x0000349C
		public static T Pause<T>(this T t) where T : Tween
		{
			if (t == null)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogNullTween(t);
				}
				return t;
			}
			if (!t.active)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return t;
			}
			if (t.isSequenced)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return t;
			}
			TweenManager.Pause(t);
			return t;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005318 File Offset: 0x00003518
		public static T Play<T>(this T t) where T : Tween
		{
			if (t == null)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogNullTween(t);
				}
				return t;
			}
			if (!t.active)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return t;
			}
			if (t.isSequenced)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return t;
			}
			TweenManager.Play(t);
			return t;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005394 File Offset: 0x00003594
		public static void PlayBackwards(this Tween t)
		{
			if (t == null)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogNullTween(t);
				}
				return;
			}
			if (!t.active)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			if (t.isSequenced)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			TweenManager.PlayBackwards(t);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000053E8 File Offset: 0x000035E8
		public static void PlayForward(this Tween t)
		{
			if (t == null)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogNullTween(t);
				}
				return;
			}
			if (!t.active)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			if (t.isSequenced)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			TweenManager.PlayForward(t);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000543C File Offset: 0x0000363C
		public static void Restart(this Tween t, bool includeDelay = true)
		{
			if (t == null)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogNullTween(t);
				}
				return;
			}
			if (!t.active)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			if (t.isSequenced)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			TweenManager.Restart(t, includeDelay);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005494 File Offset: 0x00003694
		public static void Rewind(this Tween t, bool includeDelay = true)
		{
			if (t == null)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogNullTween(t);
				}
				return;
			}
			if (!t.active)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			if (t.isSequenced)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			TweenManager.Rewind(t, includeDelay);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000054EC File Offset: 0x000036EC
		public static void TogglePause(this Tween t)
		{
			if (t == null)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogNullTween(t);
				}
				return;
			}
			if (!t.active)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			if (t.isSequenced)
			{
				if (Debugger.logPriority > 1)
				{
					Debugger.LogInvalidTween(t);
				}
				return;
			}
			TweenManager.TogglePause(t);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005540 File Offset: 0x00003740
		public static YieldInstruction WaitForCompletion(this Tween t)
		{
			if (!t.active)
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return DOTween.instance.StartCoroutine(DOTween.instance.WaitForCompletion(t));
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000556F File Offset: 0x0000376F
		public static YieldInstruction WaitForKill(this Tween t)
		{
			if (!t.active)
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return DOTween.instance.StartCoroutine(DOTween.instance.WaitForKill(t));
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000559E File Offset: 0x0000379E
		public static YieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			if (!t.active)
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return DOTween.instance.StartCoroutine(DOTween.instance.WaitForElapsedLoops(t, elapsedLoops));
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000055CE File Offset: 0x000037CE
		public static YieldInstruction WaitForPosition(this Tween t, float position)
		{
			if (!t.active)
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return DOTween.instance.StartCoroutine(DOTween.instance.WaitForPosition(t, position));
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000055FE File Offset: 0x000037FE
		public static Coroutine WaitForStart(this Tween t)
		{
			if (!t.active)
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return DOTween.instance.StartCoroutine(DOTween.instance.WaitForStart(t));
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000562D File Offset: 0x0000382D
		public static int CompletedLoops(this Tween t)
		{
			if (!t.active)
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogInvalidTween(t);
				}
				return 0;
			}
			return t.completedLoops;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000564D File Offset: 0x0000384D
		public static float Delay(this Tween t)
		{
			if (!t.active)
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogInvalidTween(t);
				}
				return 0f;
			}
			return t.delay;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005674 File Offset: 0x00003874
		public static float Duration(this Tween t, bool includeLoops = true)
		{
			if (!t.active)
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogInvalidTween(t);
				}
				return 0f;
			}
			if (!includeLoops)
			{
				return t.duration;
			}
			if (t.loops != -1)
			{
				return t.duration * (float)t.loops;
			}
			return float.PositiveInfinity;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000056C4 File Offset: 0x000038C4
		public static float Elapsed(this Tween t, bool includeLoops = true)
		{
			if (!t.active)
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogInvalidTween(t);
				}
				return 0f;
			}
			if (includeLoops)
			{
				int num = ((t.position >= t.duration) ? (t.completedLoops - 1) : t.completedLoops);
				return (float)num * t.duration + t.position;
			}
			return t.position;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005728 File Offset: 0x00003928
		public static float ElapsedPercentage(this Tween t, bool includeLoops = true)
		{
			if (!t.active)
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogInvalidTween(t);
				}
				return 0f;
			}
			if (includeLoops)
			{
				int num = ((t.position >= t.duration) ? (t.completedLoops - 1) : t.completedLoops);
				return ((float)num * t.duration + t.position) / t.fullDuration;
			}
			return t.position / t.duration;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00005798 File Offset: 0x00003998
		public static bool IsActive(this Tween t)
		{
			return t.active;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000057A0 File Offset: 0x000039A0
		public static bool IsBackwards(this Tween t)
		{
			if (!t.active)
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogInvalidTween(t);
				}
				return false;
			}
			return t.isBackwards;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000057C0 File Offset: 0x000039C0
		public static bool IsPlaying(this Tween t)
		{
			if (!t.active)
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogInvalidTween(t);
				}
				return false;
			}
			return t.isPlaying;
		}
	}
}
