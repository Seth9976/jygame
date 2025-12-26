using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	// Token: 0x02000098 RID: 152
	public class LayoutRebuilder : ICanvasElement
	{
		// Token: 0x06000543 RID: 1347 RVA: 0x0001731C File Offset: 0x0001551C
		static LayoutRebuilder()
		{
			RectTransform.reapplyDrivenProperties += LayoutRebuilder.ReapplyDrivenProperties;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00017358 File Offset: 0x00015558
		private void Initialize(RectTransform controller)
		{
			this.m_ToRebuild = controller;
			this.m_CachedHashFromTransform = controller.GetHashCode();
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00017370 File Offset: 0x00015570
		private void Clear()
		{
			this.m_ToRebuild = null;
			this.m_CachedHashFromTransform = 0;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00017380 File Offset: 0x00015580
		private static void ReapplyDrivenProperties(RectTransform driven)
		{
			LayoutRebuilder.MarkLayoutForRebuild(driven);
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00017388 File Offset: 0x00015588
		public Transform transform
		{
			get
			{
				return this.m_ToRebuild;
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00017390 File Offset: 0x00015590
		public bool IsDestroyed()
		{
			return this.m_ToRebuild == null;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000173A0 File Offset: 0x000155A0
		private static void StripDisabledBehavioursFromList(List<Component> components)
		{
			components.RemoveAll((Component e) => e is Behaviour && !((Behaviour)e).isActiveAndEnabled);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000173D4 File Offset: 0x000155D4
		public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot)
		{
			LayoutRebuilder layoutRebuilder = LayoutRebuilder.s_Rebuilders.Get();
			layoutRebuilder.Initialize(layoutRoot);
			layoutRebuilder.Rebuild(CanvasUpdate.Layout);
			LayoutRebuilder.s_Rebuilders.Release(layoutRebuilder);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00017408 File Offset: 0x00015608
		public void Rebuild(CanvasUpdate executing)
		{
			if (executing == CanvasUpdate.Layout)
			{
				this.PerformLayoutCalculation(this.m_ToRebuild, delegate(Component e)
				{
					(e as ILayoutElement).CalculateLayoutInputHorizontal();
				});
				this.PerformLayoutControl(this.m_ToRebuild, delegate(Component e)
				{
					(e as ILayoutController).SetLayoutHorizontal();
				});
				this.PerformLayoutCalculation(this.m_ToRebuild, delegate(Component e)
				{
					(e as ILayoutElement).CalculateLayoutInputVertical();
				});
				this.PerformLayoutControl(this.m_ToRebuild, delegate(Component e)
				{
					(e as ILayoutController).SetLayoutVertical();
				});
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x000174CC File Offset: 0x000156CC
		private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action)
		{
			if (rect == null)
			{
				return;
			}
			List<Component> list = ListPool<Component>.Get();
			rect.GetComponents(typeof(ILayoutController), list);
			LayoutRebuilder.StripDisabledBehavioursFromList(list);
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i] is ILayoutSelfController)
					{
						action(list[i]);
					}
				}
				for (int j = 0; j < list.Count; j++)
				{
					if (!(list[j] is ILayoutSelfController))
					{
						action(list[j]);
					}
				}
				for (int k = 0; k < rect.childCount; k++)
				{
					this.PerformLayoutControl(rect.GetChild(k) as RectTransform, action);
				}
			}
			ListPool<Component>.Release(list);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x000175AC File Offset: 0x000157AC
		private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action)
		{
			if (rect == null)
			{
				return;
			}
			List<Component> list = ListPool<Component>.Get();
			rect.GetComponents(typeof(ILayoutElement), list);
			LayoutRebuilder.StripDisabledBehavioursFromList(list);
			if (list.Count > 0)
			{
				for (int i = 0; i < rect.childCount; i++)
				{
					this.PerformLayoutCalculation(rect.GetChild(i) as RectTransform, action);
				}
				for (int j = 0; j < list.Count; j++)
				{
					action(list[j]);
				}
			}
			ListPool<Component>.Release(list);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00017644 File Offset: 0x00015844
		public static void MarkLayoutForRebuild(RectTransform rect)
		{
			if (rect == null)
			{
				return;
			}
			RectTransform rectTransform = rect;
			for (;;)
			{
				RectTransform rectTransform2 = rectTransform.parent as RectTransform;
				if (!LayoutRebuilder.ValidLayoutGroup(rectTransform2))
				{
					break;
				}
				rectTransform = rectTransform2;
			}
			if (rectTransform == rect && !LayoutRebuilder.ValidController(rectTransform))
			{
				return;
			}
			LayoutRebuilder.MarkLayoutRootForRebuild(rectTransform);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x000176A4 File Offset: 0x000158A4
		private static bool ValidLayoutGroup(RectTransform parent)
		{
			if (parent == null)
			{
				return false;
			}
			List<Component> list = ListPool<Component>.Get();
			parent.GetComponents(typeof(ILayoutGroup), list);
			LayoutRebuilder.StripDisabledBehavioursFromList(list);
			bool flag = list.Count > 0;
			ListPool<Component>.Release(list);
			return flag;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000176F0 File Offset: 0x000158F0
		private static bool ValidController(RectTransform layoutRoot)
		{
			if (layoutRoot == null)
			{
				return false;
			}
			List<Component> list = ListPool<Component>.Get();
			layoutRoot.GetComponents(typeof(ILayoutController), list);
			LayoutRebuilder.StripDisabledBehavioursFromList(list);
			bool flag = list.Count > 0;
			ListPool<Component>.Release(list);
			return flag;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0001773C File Offset: 0x0001593C
		private static void MarkLayoutRootForRebuild(RectTransform controller)
		{
			if (controller == null)
			{
				return;
			}
			LayoutRebuilder layoutRebuilder = LayoutRebuilder.s_Rebuilders.Get();
			layoutRebuilder.Initialize(controller);
			if (!CanvasUpdateRegistry.TryRegisterCanvasElementForLayoutRebuild(layoutRebuilder))
			{
				LayoutRebuilder.s_Rebuilders.Release(layoutRebuilder);
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00017780 File Offset: 0x00015980
		public void LayoutComplete()
		{
			LayoutRebuilder.s_Rebuilders.Release(this);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00017790 File Offset: 0x00015990
		public void GraphicUpdateComplete()
		{
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00017794 File Offset: 0x00015994
		public override int GetHashCode()
		{
			return this.m_CachedHashFromTransform;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0001779C File Offset: 0x0001599C
		public override bool Equals(object obj)
		{
			return obj.GetHashCode() == this.GetHashCode();
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000177AC File Offset: 0x000159AC
		public override string ToString()
		{
			return "(Layout Rebuilder for) " + this.m_ToRebuild;
		}

		// Token: 0x0400028D RID: 653
		private RectTransform m_ToRebuild;

		// Token: 0x0400028E RID: 654
		private int m_CachedHashFromTransform;

		// Token: 0x0400028F RID: 655
		private static ObjectPool<LayoutRebuilder> s_Rebuilders = new ObjectPool<LayoutRebuilder>(null, delegate(LayoutRebuilder x)
		{
			x.Clear();
		});
	}
}
