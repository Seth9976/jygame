using System;
using System.Collections.Generic;
using DG.Tweening.Core.Enums;

namespace DG.Tweening.Core
{
	// Token: 0x0200001E RID: 30
	internal static class TweenManager
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x00006C84 File Offset: 0x00004E84
		internal static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>() where TPlugOptions : struct
		{
			TweenerCore<T1, T2, TPlugOptions> tweenerCore;
			if (TweenManager.totPooledTweeners > 0)
			{
				Type typeFromHandle = typeof(T1);
				Type typeFromHandle2 = typeof(T2);
				Type typeFromHandle3 = typeof(TPlugOptions);
				for (int i = TweenManager._maxPooledTweenerId; i > TweenManager._minPooledTweenerId - 1; i--)
				{
					Tween tween = TweenManager._pooledTweeners[i];
					if (tween != null && tween.typeofT1 == typeFromHandle && tween.typeofT2 == typeFromHandle2 && tween.typeofTPlugOptions == typeFromHandle3)
					{
						tweenerCore = (TweenerCore<T1, T2, TPlugOptions>)tween;
						TweenManager.AddActiveTween(tweenerCore);
						TweenManager._pooledTweeners[i] = null;
						if (TweenManager._maxPooledTweenerId != TweenManager._minPooledTweenerId)
						{
							if (i == TweenManager._maxPooledTweenerId)
							{
								TweenManager._maxPooledTweenerId--;
							}
							else if (i == TweenManager._minPooledTweenerId)
							{
								TweenManager._minPooledTweenerId++;
							}
						}
						TweenManager.totPooledTweeners--;
						return tweenerCore;
					}
				}
				if (TweenManager.totTweeners >= TweenManager.maxTweeners)
				{
					TweenManager._pooledTweeners[TweenManager._maxPooledTweenerId] = null;
					TweenManager._maxPooledTweenerId--;
					TweenManager.totPooledTweeners--;
					TweenManager.totTweeners--;
				}
			}
			else if (TweenManager.totTweeners >= TweenManager.maxTweeners)
			{
				if (Debugger.logPriority >= 1)
				{
					Debugger.LogWarning("Max Tweens reached: capacity will be automatically increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup".Replace("#0", TweenManager.maxTweeners + "/" + TweenManager.maxSequences).Replace("#1", TweenManager.maxTweeners + 200 + "/" + TweenManager.maxSequences));
				}
				TweenManager.IncreaseCapacities(TweenManager.CapacityIncreaseMode.TweenersOnly);
			}
			tweenerCore = new TweenerCore<T1, T2, TPlugOptions>();
			TweenManager.totTweeners++;
			TweenManager.AddActiveTween(tweenerCore);
			return tweenerCore;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00006E3C File Offset: 0x0000503C
		internal static Sequence GetSequence()
		{
			Sequence sequence;
			if (TweenManager.totPooledSequences > 0)
			{
				sequence = (Sequence)TweenManager._PooledSequences.Pop();
				TweenManager.AddActiveTween(sequence);
				TweenManager.totPooledSequences--;
				return sequence;
			}
			if (TweenManager.totSequences >= TweenManager.maxSequences)
			{
				if (Debugger.logPriority >= 1)
				{
					Debugger.LogWarning("Max Tweens reached: capacity will be automatically increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup".Replace("#0", TweenManager.maxTweeners + "/" + TweenManager.maxSequences).Replace("#1", TweenManager.maxTweeners + "/" + (TweenManager.maxSequences + 50)));
				}
				TweenManager.IncreaseCapacities(TweenManager.CapacityIncreaseMode.SequencesOnly);
			}
			sequence = new Sequence();
			TweenManager.totSequences++;
			TweenManager.AddActiveTween(sequence);
			return sequence;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00006F08 File Offset: 0x00005108
		internal static void SetUpdateType(Tween t, UpdateType updateType, bool isIndependentUpdate)
		{
			if (!t.active || t.updateType == updateType)
			{
				t.updateType = updateType;
				t.isIndependentUpdate = isIndependentUpdate;
				return;
			}
			if (t.updateType == UpdateType.Default)
			{
				TweenManager.totActiveDefaultTweens--;
				TweenManager.hasActiveDefaultTweens = TweenManager.totActiveDefaultTweens > 0;
			}
			else
			{
				TweenManager.totActiveLateTweens--;
				TweenManager.hasActiveLateTweens = TweenManager.totActiveLateTweens > 0;
			}
			t.updateType = updateType;
			t.isIndependentUpdate = isIndependentUpdate;
			if (updateType == UpdateType.Default)
			{
				TweenManager.totActiveDefaultTweens++;
				TweenManager.hasActiveDefaultTweens = true;
				return;
			}
			TweenManager.totActiveLateTweens++;
			TweenManager.hasActiveLateTweens = true;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00006FA7 File Offset: 0x000051A7
		internal static void AddActiveTweenToSequence(Tween t)
		{
			TweenManager.RemoveActiveTween(t);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00006FB0 File Offset: 0x000051B0
		internal static int DespawnAll()
		{
			int num = TweenManager.totActiveTweens;
			for (int i = 0; i < TweenManager._maxActiveLookupId + 1; i++)
			{
				Tween tween = TweenManager._activeTweens[i];
				if (tween != null)
				{
					TweenManager.Despawn(tween, false);
				}
			}
			TweenManager.ClearTweenArray(TweenManager._activeTweens);
			TweenManager.hasActiveTweens = (TweenManager.hasActiveDefaultTweens = (TweenManager.hasActiveLateTweens = false));
			TweenManager.totActiveTweens = (TweenManager.totActiveDefaultTweens = (TweenManager.totActiveLateTweens = 0));
			TweenManager.totActiveTweeners = (TweenManager.totActiveSequences = 0);
			TweenManager._maxActiveLookupId = (TweenManager._reorganizeFromId = -1);
			TweenManager._requiresActiveReorganization = false;
			return num;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007034 File Offset: 0x00005234
		internal static void Despawn(Tween t, bool modifyActiveLists = true)
		{
			if (t.onKill != null)
			{
				t.onKill();
			}
			if (modifyActiveLists)
			{
				TweenManager.RemoveActiveTween(t);
			}
			if (t.isRecyclable)
			{
				switch (t.tweenType)
				{
				case TweenType.Tweener:
					if (TweenManager._maxPooledTweenerId == -1)
					{
						TweenManager._maxPooledTweenerId = TweenManager.maxTweeners - 1;
						TweenManager._minPooledTweenerId = TweenManager.maxTweeners - 1;
					}
					if (TweenManager._maxPooledTweenerId < TweenManager.maxTweeners - 1)
					{
						TweenManager._pooledTweeners[TweenManager._maxPooledTweenerId + 1] = t;
						TweenManager._maxPooledTweenerId++;
						if (TweenManager._minPooledTweenerId > TweenManager._maxPooledTweenerId)
						{
							TweenManager._minPooledTweenerId = TweenManager._maxPooledTweenerId;
						}
					}
					else
					{
						int i = TweenManager._maxPooledTweenerId;
						while (i > -1)
						{
							if (TweenManager._pooledTweeners[i] == null)
							{
								TweenManager._pooledTweeners[i] = t;
								if (i < TweenManager._minPooledTweenerId)
								{
									TweenManager._minPooledTweenerId = i;
								}
								if (TweenManager._maxPooledTweenerId < TweenManager._minPooledTweenerId)
								{
									TweenManager._maxPooledTweenerId = TweenManager._minPooledTweenerId;
									break;
								}
								break;
							}
							else
							{
								i--;
							}
						}
					}
					TweenManager.totPooledTweeners++;
					break;
				case TweenType.Sequence:
				{
					TweenManager._PooledSequences.Push(t);
					TweenManager.totPooledSequences++;
					Sequence sequence = (Sequence)t;
					int count = sequence.sequencedTweens.Count;
					for (int j = 0; j < count; j++)
					{
						TweenManager.Despawn(sequence.sequencedTweens[j], false);
					}
					break;
				}
				}
			}
			else
			{
				switch (t.tweenType)
				{
				case TweenType.Tweener:
					TweenManager.totTweeners--;
					break;
				case TweenType.Sequence:
				{
					TweenManager.totSequences--;
					Sequence sequence2 = (Sequence)t;
					int count2 = sequence2.sequencedTweens.Count;
					for (int k = 0; k < count2; k++)
					{
						TweenManager.Despawn(sequence2.sequencedTweens[k], false);
					}
					break;
				}
				}
			}
			t.active = false;
			t.Reset();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00007204 File Offset: 0x00005404
		internal static void PurgeAll()
		{
			for (int i = 0; i < TweenManager.totActiveTweens; i++)
			{
				Tween tween = TweenManager._activeTweens[i];
				if (tween != null && tween.onKill != null)
				{
					tween.onKill();
				}
			}
			TweenManager.ClearTweenArray(TweenManager._activeTweens);
			TweenManager.hasActiveTweens = (TweenManager.hasActiveDefaultTweens = (TweenManager.hasActiveLateTweens = false));
			TweenManager.totActiveTweens = (TweenManager.totActiveDefaultTweens = (TweenManager.totActiveLateTweens = 0));
			TweenManager.totActiveTweeners = (TweenManager.totActiveSequences = 0);
			TweenManager._maxActiveLookupId = (TweenManager._reorganizeFromId = -1);
			TweenManager._requiresActiveReorganization = false;
			TweenManager.PurgePools();
			TweenManager.ResetCapacities();
			TweenManager.totTweeners = (TweenManager.totSequences = 0);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000072A4 File Offset: 0x000054A4
		internal static void PurgePools()
		{
			TweenManager.totTweeners -= TweenManager.totPooledTweeners;
			TweenManager.totSequences -= TweenManager.totPooledSequences;
			TweenManager.ClearTweenArray(TweenManager._pooledTweeners);
			TweenManager._PooledSequences.Clear();
			TweenManager.totPooledTweeners = (TweenManager.totPooledSequences = 0);
			TweenManager._minPooledTweenerId = (TweenManager._maxPooledTweenerId = -1);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000072FD File Offset: 0x000054FD
		internal static void ResetCapacities()
		{
			TweenManager.SetCapacities(200, 50);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000730C File Offset: 0x0000550C
		internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity)
		{
			if (tweenersCapacity < sequencesCapacity)
			{
				tweenersCapacity = sequencesCapacity;
			}
			TweenManager.maxActive = tweenersCapacity;
			TweenManager.maxTweeners = tweenersCapacity;
			TweenManager.maxSequences = sequencesCapacity;
			Array.Resize<Tween>(ref TweenManager._activeTweens, TweenManager.maxActive);
			Array.Resize<Tween>(ref TweenManager._pooledTweeners, tweenersCapacity);
			TweenManager._KillList.Capacity = TweenManager.maxActive;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000735C File Offset: 0x0000555C
		internal static int Validate()
		{
			if (TweenManager._requiresActiveReorganization)
			{
				TweenManager.ReorganizeActiveTweens();
			}
			int num = 0;
			for (int i = 0; i < TweenManager._maxActiveLookupId + 1; i++)
			{
				Tween tween = TweenManager._activeTweens[i];
				if (!tween.Validate())
				{
					num++;
					TweenManager.MarkForKilling(tween);
				}
			}
			if (num > 0)
			{
				TweenManager.DespawnTweens(TweenManager._KillList, false);
				int num2 = TweenManager._KillList.Count - 1;
				for (int j = num2; j > -1; j--)
				{
					TweenManager.RemoveActiveTween(TweenManager._KillList[j]);
				}
				TweenManager._KillList.Clear();
			}
			return num;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000073EC File Offset: 0x000055EC
		internal static void Update(UpdateType updateType, float deltaTime, float independentTime)
		{
			if (TweenManager._requiresActiveReorganization)
			{
				TweenManager.ReorganizeActiveTweens();
			}
			TweenManager.isUpdateLoop = true;
			bool flag = false;
			for (int i = 0; i < TweenManager._maxActiveLookupId + 1; i++)
			{
				Tween tween = TweenManager._activeTweens[i];
				if (tween != null && tween.updateType == updateType)
				{
					if (!tween.active)
					{
						flag = true;
						TweenManager.MarkForKilling(tween);
					}
					else if (tween.isPlaying)
					{
						tween.creationLocked = true;
						float num = (tween.isIndependentUpdate ? independentTime : deltaTime) * tween.timeScale;
						if (!tween.delayComplete)
						{
							num = tween.UpdateDelay(tween.elapsedDelay + num);
							if (num <= -1f)
							{
								flag = true;
								TweenManager.MarkForKilling(tween);
								goto IL_019F;
							}
							if (num <= 0f)
							{
								goto IL_019F;
							}
						}
						float num2 = tween.position;
						bool flag2 = num2 >= tween.duration;
						int num3 = tween.completedLoops;
						if (tween.duration <= 0f)
						{
							num2 = 0f;
							num3 = ((tween.loops == -1) ? (tween.completedLoops + 1) : tween.loops);
						}
						else
						{
							if (tween.isBackwards)
							{
								num2 -= num;
								while (num2 < 0f)
								{
									if (num3 <= 0)
									{
										break;
									}
									num2 += tween.duration;
									num3--;
								}
							}
							else
							{
								num2 += num;
								while (num2 > tween.duration && (tween.loops == -1 || num3 < tween.loops))
								{
									num2 -= tween.duration;
									num3++;
								}
							}
							if (flag2)
							{
								num3--;
							}
							if (tween.loops != -1 && num3 >= tween.loops)
							{
								num2 = tween.duration;
							}
						}
						bool flag3 = Tween.DoGoto(tween, num2, num3, UpdateMode.Update);
						if (flag3)
						{
							flag = true;
							TweenManager.MarkForKilling(tween);
						}
					}
				}
				IL_019F:;
			}
			if (flag)
			{
				TweenManager.DespawnTweens(TweenManager._KillList, false);
				int num4 = TweenManager._KillList.Count - 1;
				for (int j = num4; j > -1; j--)
				{
					TweenManager.RemoveActiveTween(TweenManager._KillList[j]);
				}
				TweenManager._KillList.Clear();
			}
			TweenManager.isUpdateLoop = false;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000075F8 File Offset: 0x000057F8
		internal static int FilteredOperation(OperationType operationType, FilterType filterType, object id, bool optionalBool, float optionalFloat)
		{
			int num = 0;
			bool flag = false;
			for (int i = TweenManager._maxActiveLookupId; i > -1; i--)
			{
				Tween tween = TweenManager._activeTweens[i];
				if (tween != null && tween.active)
				{
					bool flag2 = false;
					switch (filterType)
					{
					case FilterType.All:
						flag2 = true;
						break;
					case FilterType.TargetOrId:
						flag2 = id.Equals(tween.id) || id.Equals(tween.target);
						break;
					}
					if (flag2)
					{
						switch (operationType)
						{
						case OperationType.Complete:
						{
							bool autoKill = tween.autoKill;
							if (TweenManager.Complete(tween, false))
							{
								num += ((!optionalBool) ? 1 : (autoKill ? 1 : 0));
								if (autoKill)
								{
									if (TweenManager.isUpdateLoop)
									{
										tween.active = false;
									}
									else
									{
										flag = true;
										TweenManager._KillList.Add(tween);
									}
								}
							}
							break;
						}
						case OperationType.Despawn:
							num++;
							if (TweenManager.isUpdateLoop)
							{
								tween.active = false;
							}
							else
							{
								TweenManager.Despawn(tween, false);
								flag = true;
								TweenManager._KillList.Add(tween);
							}
							break;
						case OperationType.Flip:
							if (TweenManager.Flip(tween))
							{
								num++;
							}
							break;
						case OperationType.Goto:
							TweenManager.Goto(tween, optionalFloat, optionalBool, UpdateMode.Goto);
							num++;
							break;
						case OperationType.Pause:
							if (TweenManager.Pause(tween))
							{
								num++;
							}
							break;
						case OperationType.Play:
							if (TweenManager.Play(tween))
							{
								num++;
							}
							break;
						case OperationType.PlayForward:
							if (TweenManager.PlayForward(tween))
							{
								num++;
							}
							break;
						case OperationType.PlayBackwards:
							if (TweenManager.PlayBackwards(tween))
							{
								num++;
							}
							break;
						case OperationType.Rewind:
							if (TweenManager.Rewind(tween, optionalBool))
							{
								num++;
							}
							break;
						case OperationType.Restart:
							if (TweenManager.Restart(tween, optionalBool))
							{
								num++;
							}
							break;
						case OperationType.TogglePause:
							if (TweenManager.TogglePause(tween))
							{
								num++;
							}
							break;
						case OperationType.IsTweening:
							num++;
							break;
						}
					}
				}
			}
			if (flag)
			{
				int num2 = TweenManager._KillList.Count - 1;
				for (int j = num2; j > -1; j--)
				{
					TweenManager.RemoveActiveTween(TweenManager._KillList[j]);
				}
				TweenManager._KillList.Clear();
			}
			return num;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00007800 File Offset: 0x00005A00
		internal static bool Complete(Tween t, bool modifyActiveLists = true)
		{
			if (t.loops == -1)
			{
				return false;
			}
			if (!t.isComplete)
			{
				Tween.DoGoto(t, t.duration, t.loops, UpdateMode.Goto);
				t.isPlaying = false;
				if (t.autoKill)
				{
					if (TweenManager.isUpdateLoop)
					{
						t.active = false;
					}
					else
					{
						TweenManager.Despawn(t, modifyActiveLists);
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000785D File Offset: 0x00005A5D
		internal static bool Flip(Tween t)
		{
			t.isBackwards = !t.isBackwards;
			return true;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00007870 File Offset: 0x00005A70
		internal static bool Goto(Tween t, float to, bool andPlay = false, UpdateMode updateMode = UpdateMode.Goto)
		{
			bool isPlaying = t.isPlaying;
			t.isPlaying = andPlay;
			t.delayComplete = true;
			t.elapsedDelay = t.delay;
			int num = (int)(to / t.duration);
			float num2 = to % t.duration;
			if (t.loops != -1 && num >= t.loops)
			{
				num = t.loops;
				num2 = t.duration;
			}
			else if (num2 >= t.duration)
			{
				num2 = 0f;
			}
			bool flag = Tween.DoGoto(t, num2, num, updateMode);
			if (!andPlay && isPlaying && !flag && t.onPause != null)
			{
				t.onPause();
			}
			return flag;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00007909 File Offset: 0x00005B09
		internal static bool Pause(Tween t)
		{
			if (t.isPlaying)
			{
				t.isPlaying = false;
				if (t.onPause != null)
				{
					t.onPause();
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00007930 File Offset: 0x00005B30
		internal static bool Play(Tween t)
		{
			if (!t.isPlaying && ((!t.isBackwards && !t.isComplete) || (t.isBackwards && (t.completedLoops > 0 || t.position > 0f))))
			{
				t.isPlaying = true;
				if (t.playedOnce && t.onPlay != null)
				{
					t.onPlay();
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00007998 File Offset: 0x00005B98
		internal static bool PlayBackwards(Tween t)
		{
			if (!t.isBackwards)
			{
				t.isBackwards = true;
				TweenManager.Play(t);
				return true;
			}
			return TweenManager.Play(t);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000079B8 File Offset: 0x00005BB8
		internal static bool PlayForward(Tween t)
		{
			if (t.isBackwards)
			{
				t.isBackwards = false;
				TweenManager.Play(t);
				return true;
			}
			return TweenManager.Play(t);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000079D8 File Offset: 0x00005BD8
		internal static bool Restart(Tween t, bool includeDelay = true)
		{
			bool isPlaying = t.isPlaying;
			t.isBackwards = false;
			TweenManager.Rewind(t, includeDelay);
			t.isPlaying = true;
			if (isPlaying && t.playedOnce && t.onPlay != null)
			{
				t.onPlay();
			}
			return true;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00007A24 File Offset: 0x00005C24
		internal static bool Rewind(Tween t, bool includeDelay = true)
		{
			bool isPlaying = t.isPlaying;
			t.isPlaying = false;
			bool flag = false;
			if (t.delay > 0f)
			{
				if (includeDelay)
				{
					flag = t.delay > 0f && t.elapsedDelay > 0f;
					t.elapsedDelay = 0f;
					t.delayComplete = false;
				}
				else
				{
					flag = t.elapsedDelay < t.delay;
					t.elapsedDelay = t.delay;
					t.delayComplete = true;
				}
			}
			if (t.position > 0f || t.completedLoops > 0 || !t.startupDone)
			{
				flag = true;
				if (!Tween.DoGoto(t, 0f, 0, UpdateMode.Goto) && isPlaying && t.onPause != null)
				{
					t.onPause();
				}
			}
			return flag;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00007AED File Offset: 0x00005CED
		internal static bool TogglePause(Tween t)
		{
			if (t.isPlaying)
			{
				return TweenManager.Pause(t);
			}
			return TweenManager.Play(t);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00007B04 File Offset: 0x00005D04
		internal static int TotalPooledTweens()
		{
			return TweenManager.totPooledTweeners + TweenManager.totPooledSequences;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00007B14 File Offset: 0x00005D14
		internal static int TotalPlayingTweens()
		{
			if (!TweenManager.hasActiveTweens)
			{
				return 0;
			}
			int num = 0;
			for (int i = 0; i < TweenManager._maxActiveLookupId + 1; i++)
			{
				Tween tween = TweenManager._activeTweens[i];
				if (tween != null && tween.isPlaying)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00007B58 File Offset: 0x00005D58
		internal static List<Tween> GetActiveTweens(bool playing)
		{
			if (TweenManager.totActiveTweens <= 0)
			{
				return null;
			}
			int num = TweenManager.totActiveTweens;
			List<Tween> list = new List<Tween>(num);
			for (int i = 0; i < num; i++)
			{
				Tween tween = TweenManager._activeTweens[i];
				if (tween.isPlaying == playing)
				{
					list.Add(tween);
				}
			}
			if (list.Count > 0)
			{
				return list;
			}
			return null;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00007BAC File Offset: 0x00005DAC
		private static void MarkForKilling(Tween t)
		{
			t.active = false;
			TweenManager._KillList.Add(t);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00007BC0 File Offset: 0x00005DC0
		private static void AddActiveTween(Tween t)
		{
			if (TweenManager._requiresActiveReorganization)
			{
				TweenManager.ReorganizeActiveTweens();
			}
			t.active = true;
			t.updateType = UpdateType.Default;
			t.isIndependentUpdate = false;
			t.activeId = (TweenManager._maxActiveLookupId = TweenManager.totActiveTweens);
			TweenManager._activeTweens[TweenManager.totActiveTweens] = t;
			TweenManager.hasActiveDefaultTweens = true;
			TweenManager.totActiveDefaultTweens++;
			TweenManager.totActiveTweens++;
			if (t.tweenType == TweenType.Tweener)
			{
				TweenManager.totActiveTweeners++;
			}
			else
			{
				TweenManager.totActiveSequences++;
			}
			TweenManager.hasActiveTweens = true;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00007C54 File Offset: 0x00005E54
		private static void ReorganizeActiveTweens()
		{
			if (TweenManager.totActiveTweens <= 0)
			{
				TweenManager._maxActiveLookupId = -1;
				TweenManager._requiresActiveReorganization = false;
				TweenManager._reorganizeFromId = -1;
				return;
			}
			if (TweenManager._reorganizeFromId == TweenManager._maxActiveLookupId)
			{
				TweenManager._maxActiveLookupId--;
				TweenManager._requiresActiveReorganization = false;
				TweenManager._reorganizeFromId = -1;
				return;
			}
			int num = 1;
			int num2 = TweenManager._maxActiveLookupId + 1;
			TweenManager._maxActiveLookupId = TweenManager._reorganizeFromId - 1;
			for (int i = TweenManager._reorganizeFromId + 1; i < num2; i++)
			{
				Tween tween = TweenManager._activeTweens[i];
				if (tween == null)
				{
					num++;
				}
				else
				{
					tween.activeId = (TweenManager._maxActiveLookupId = i - num);
					TweenManager._activeTweens[i - num] = tween;
					TweenManager._activeTweens[i] = null;
				}
			}
			TweenManager._requiresActiveReorganization = false;
			TweenManager._reorganizeFromId = -1;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00007D08 File Offset: 0x00005F08
		private static void DespawnTweens(List<Tween> tweens, bool modifyActiveLists = true)
		{
			int count = tweens.Count;
			for (int i = 0; i < count; i++)
			{
				TweenManager.Despawn(tweens[i], modifyActiveLists);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00007D38 File Offset: 0x00005F38
		private static void RemoveActiveTween(Tween t)
		{
			int activeId = t.activeId;
			t.activeId = -1;
			TweenManager._requiresActiveReorganization = true;
			if (TweenManager._reorganizeFromId == -1 || TweenManager._reorganizeFromId > activeId)
			{
				TweenManager._reorganizeFromId = activeId;
			}
			TweenManager._activeTweens[activeId] = null;
			if (t.updateType == UpdateType.Default)
			{
				TweenManager.totActiveDefaultTweens--;
				TweenManager.hasActiveDefaultTweens = TweenManager.totActiveDefaultTweens > 0;
			}
			else
			{
				TweenManager.totActiveLateTweens--;
				TweenManager.hasActiveLateTweens = TweenManager.totActiveLateTweens > 0;
			}
			TweenManager.totActiveTweens--;
			TweenManager.hasActiveTweens = TweenManager.totActiveTweens > 0;
			if (t.tweenType == TweenType.Tweener)
			{
				TweenManager.totActiveTweeners--;
				return;
			}
			TweenManager.totActiveSequences--;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00007DF0 File Offset: 0x00005FF0
		private static void ClearTweenArray(Tween[] tweens)
		{
			int num = tweens.Length;
			for (int i = 0; i < num; i++)
			{
				tweens[i] = null;
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00007E14 File Offset: 0x00006014
		private static void IncreaseCapacities(TweenManager.CapacityIncreaseMode increaseMode)
		{
			int num = 0;
			switch (increaseMode)
			{
			case TweenManager.CapacityIncreaseMode.TweenersOnly:
				num += 200;
				TweenManager.maxTweeners += 200;
				Array.Resize<Tween>(ref TweenManager._pooledTweeners, TweenManager.maxTweeners);
				break;
			case TweenManager.CapacityIncreaseMode.SequencesOnly:
				num += 50;
				TweenManager.maxSequences += 50;
				break;
			default:
				num += 200;
				TweenManager.maxTweeners += 200;
				TweenManager.maxSequences += 50;
				Array.Resize<Tween>(ref TweenManager._pooledTweeners, TweenManager.maxTweeners);
				break;
			}
			TweenManager.maxActive = TweenManager.maxTweeners;
			Array.Resize<Tween>(ref TweenManager._activeTweens, TweenManager.maxActive);
			if (num > 0)
			{
				TweenManager._KillList.Capacity += num;
			}
		}

		// Token: 0x0400007C RID: 124
		private const int _DefaultMaxTweeners = 200;

		// Token: 0x0400007D RID: 125
		private const int _DefaultMaxSequences = 50;

		// Token: 0x0400007E RID: 126
		private const string _MaxTweensReached = "Max Tweens reached: capacity will be automatically increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup";

		// Token: 0x0400007F RID: 127
		internal static int maxActive = 200;

		// Token: 0x04000080 RID: 128
		internal static int maxTweeners = 200;

		// Token: 0x04000081 RID: 129
		internal static int maxSequences = 50;

		// Token: 0x04000082 RID: 130
		internal static bool hasActiveTweens;

		// Token: 0x04000083 RID: 131
		internal static bool hasActiveDefaultTweens;

		// Token: 0x04000084 RID: 132
		internal static bool hasActiveLateTweens;

		// Token: 0x04000085 RID: 133
		internal static int totActiveTweens;

		// Token: 0x04000086 RID: 134
		internal static int totActiveDefaultTweens;

		// Token: 0x04000087 RID: 135
		internal static int totActiveLateTweens;

		// Token: 0x04000088 RID: 136
		internal static int totActiveTweeners;

		// Token: 0x04000089 RID: 137
		internal static int totActiveSequences;

		// Token: 0x0400008A RID: 138
		internal static int totPooledTweeners;

		// Token: 0x0400008B RID: 139
		internal static int totPooledSequences;

		// Token: 0x0400008C RID: 140
		internal static int totTweeners;

		// Token: 0x0400008D RID: 141
		internal static int totSequences;

		// Token: 0x0400008E RID: 142
		internal static bool isUpdateLoop;

		// Token: 0x0400008F RID: 143
		private static Tween[] _activeTweens = new Tween[200];

		// Token: 0x04000090 RID: 144
		private static Tween[] _pooledTweeners = new Tween[200];

		// Token: 0x04000091 RID: 145
		private static readonly Stack<Tween> _PooledSequences = new Stack<Tween>();

		// Token: 0x04000092 RID: 146
		private static readonly List<Tween> _KillList = new List<Tween>(200);

		// Token: 0x04000093 RID: 147
		private static int _maxActiveLookupId = -1;

		// Token: 0x04000094 RID: 148
		private static bool _requiresActiveReorganization;

		// Token: 0x04000095 RID: 149
		private static int _reorganizeFromId = -1;

		// Token: 0x04000096 RID: 150
		private static int _minPooledTweenerId = -1;

		// Token: 0x04000097 RID: 151
		private static int _maxPooledTweenerId = -1;

		// Token: 0x0200001F RID: 31
		internal enum CapacityIncreaseMode
		{
			// Token: 0x04000099 RID: 153
			TweenersAndSequences,
			// Token: 0x0400009A RID: 154
			TweenersOnly,
			// Token: 0x0400009B RID: 155
			SequencesOnly
		}
	}
}
