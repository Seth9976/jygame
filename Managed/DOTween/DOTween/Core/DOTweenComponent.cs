using System;
using System.Collections;
using UnityEngine;

namespace DG.Tweening.Core
{
	// Token: 0x02000043 RID: 67
	public class DOTweenComponent : MonoBehaviour, IDOTweenInit
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x0000B9B1 File Offset: 0x00009BB1
		private void Awake()
		{
			this.inspectorUpdater = 0;
			this._unscaledTime = Time.realtimeSinceStartup;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000B9C5 File Offset: 0x00009BC5
		private void Start()
		{
			if (DOTween.instance != this)
			{
				this._duplicateToDestroy = true;
				global::UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		private void Update()
		{
			this._unscaledDeltaTime = Time.realtimeSinceStartup - this._unscaledTime;
			if (TweenManager.hasActiveDefaultTweens)
			{
				TweenManager.Update(UpdateType.Default, Time.deltaTime * DOTween.timeScale, this._unscaledDeltaTime * DOTween.timeScale);
			}
			this._unscaledTime = Time.realtimeSinceStartup;
			if (DOTween.isUnityEditor)
			{
				this.inspectorUpdater++;
				if (DOTween.showUnityEditorReport && TweenManager.hasActiveTweens)
				{
					if (TweenManager.totActiveTweeners > DOTween.maxActiveTweenersReached)
					{
						DOTween.maxActiveTweenersReached = TweenManager.totActiveTweeners;
					}
					if (TweenManager.totActiveSequences > DOTween.maxActiveSequencesReached)
					{
						DOTween.maxActiveSequencesReached = TweenManager.totActiveSequences;
					}
				}
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000BA85 File Offset: 0x00009C85
		private void LateUpdate()
		{
			if (TweenManager.hasActiveLateTweens)
			{
				TweenManager.Update(UpdateType.Late, Time.deltaTime * DOTween.timeScale, this._unscaledDeltaTime * DOTween.timeScale);
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000BAAB File Offset: 0x00009CAB
		private void OnLevelWasLoaded()
		{
			if (DOTween.useSafeMode)
			{
				DOTween.Validate();
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000BABC File Offset: 0x00009CBC
		private void OnDrawGizmos()
		{
			int count = DOTween.GizmosDelegates.Count;
			if (count == 0)
			{
				return;
			}
			for (int i = 0; i < count; i++)
			{
				DOTween.GizmosDelegates[i]();
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000BAF4 File Offset: 0x00009CF4
		private void OnDestroy()
		{
			if (this._duplicateToDestroy)
			{
				return;
			}
			if (DOTween.showUnityEditorReport)
			{
				string text = string.Concat(new object[]
				{
					"REPORT > Max overall simultaneous active Tweeners/Sequences: ",
					DOTween.maxActiveTweenersReached,
					"/",
					DOTween.maxActiveSequencesReached
				});
				Debugger.LogReport(text);
			}
			DOTween.initialized = false;
			DOTween.instance = null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000BB5B File Offset: 0x00009D5B
		private void OnApplicationQuit()
		{
			DOTween.isQuitting = true;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000BB63 File Offset: 0x00009D63
		public IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity)
		{
			TweenManager.SetCapacities(tweenersCapacity, sequencesCapacity);
			return this;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		internal IEnumerator WaitForCompletion(Tween t)
		{
			while (t.active && !t.isComplete)
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000BC98 File Offset: 0x00009E98
		internal IEnumerator WaitForKill(Tween t)
		{
			while (t.active)
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000BD4C File Offset: 0x00009F4C
		internal IEnumerator WaitForElapsedLoops(Tween t, int elapsedLoops)
		{
			while (t.active && t.completedLoops < elapsedLoops)
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000BE14 File Offset: 0x0000A014
		internal IEnumerator WaitForPosition(Tween t, float position)
		{
			while (t.active && t.position * (float)(t.completedLoops + 1) < position)
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		internal IEnumerator WaitForStart(Tween t)
		{
			while (t.active && !t.playedOnce)
			{
				yield return null;
			}
			yield break;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000BEEC File Offset: 0x0000A0EC
		internal static void Create()
		{
			if (DOTween.instance != null)
			{
				return;
			}
			GameObject gameObject = new GameObject("[DOTween]");
			global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
			DOTween.instance = gameObject.AddComponent<DOTweenComponent>();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000BF23 File Offset: 0x0000A123
		internal static void DestroyInstance()
		{
			if (DOTween.instance != null)
			{
				global::UnityEngine.Object.Destroy(DOTween.instance.gameObject);
			}
			DOTween.instance = null;
		}

		// Token: 0x04000126 RID: 294
		public int inspectorUpdater;

		// Token: 0x04000127 RID: 295
		private float _unscaledTime;

		// Token: 0x04000128 RID: 296
		private float _unscaledDeltaTime;

		// Token: 0x04000129 RID: 297
		private bool _duplicateToDestroy;
	}
}
