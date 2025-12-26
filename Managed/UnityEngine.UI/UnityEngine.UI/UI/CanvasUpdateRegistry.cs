using System;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x0200003B RID: 59
	public class CanvasUpdateRegistry
	{
		// Token: 0x0600016E RID: 366 RVA: 0x0000592C File Offset: 0x00003B2C
		protected CanvasUpdateRegistry()
		{
			Canvas.willRenderCanvases += this.PerformUpdate;
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00005970 File Offset: 0x00003B70
		public static CanvasUpdateRegistry instance
		{
			get
			{
				if (CanvasUpdateRegistry.s_Instance == null)
				{
					CanvasUpdateRegistry.s_Instance = new CanvasUpdateRegistry();
				}
				return CanvasUpdateRegistry.s_Instance;
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000598C File Offset: 0x00003B8C
		private bool ObjectValidForUpdate(ICanvasElement element)
		{
			bool flag = element != null;
			bool flag2 = element is Object;
			if (flag2)
			{
				flag = element as Object != null;
			}
			return flag;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000059C0 File Offset: 0x00003BC0
		private void CleanInvalidItems()
		{
			for (int i = this.m_LayoutRebuildQueue.Count - 1; i >= 0; i--)
			{
				ICanvasElement canvasElement = this.m_LayoutRebuildQueue[i];
				if (canvasElement == null)
				{
					this.m_LayoutRebuildQueue.RemoveAt(i);
				}
				else if (canvasElement.IsDestroyed())
				{
					this.m_LayoutRebuildQueue.RemoveAt(i);
					canvasElement.LayoutComplete();
				}
			}
			for (int j = this.m_GraphicRebuildQueue.Count - 1; j >= 0; j--)
			{
				ICanvasElement canvasElement2 = this.m_GraphicRebuildQueue[j];
				if (canvasElement2 == null)
				{
					this.m_GraphicRebuildQueue.RemoveAt(j);
				}
				else if (canvasElement2.IsDestroyed())
				{
					this.m_GraphicRebuildQueue.RemoveAt(j);
					canvasElement2.GraphicUpdateComplete();
				}
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00005A8C File Offset: 0x00003C8C
		private void PerformUpdate()
		{
			this.CleanInvalidItems();
			this.m_PerformingLayoutUpdate = true;
			this.m_LayoutRebuildQueue.Sort(CanvasUpdateRegistry.s_SortLayoutFunction);
			for (int i = 0; i <= 2; i++)
			{
				for (int j = 0; j < this.m_LayoutRebuildQueue.Count; j++)
				{
					ICanvasElement canvasElement = CanvasUpdateRegistry.instance.m_LayoutRebuildQueue[j];
					try
					{
						if (this.ObjectValidForUpdate(canvasElement))
						{
							canvasElement.Rebuild((CanvasUpdate)i);
						}
					}
					catch (Exception ex)
					{
						Debug.LogException(ex, canvasElement.transform);
					}
				}
			}
			for (int k = 0; k < this.m_LayoutRebuildQueue.Count; k++)
			{
				this.m_LayoutRebuildQueue[k].LayoutComplete();
			}
			CanvasUpdateRegistry.instance.m_LayoutRebuildQueue.Clear();
			this.m_PerformingLayoutUpdate = false;
			ClipperRegistry.instance.Cull();
			this.m_PerformingGraphicUpdate = true;
			for (int l = 3; l < 5; l++)
			{
				for (int m = 0; m < CanvasUpdateRegistry.instance.m_GraphicRebuildQueue.Count; m++)
				{
					try
					{
						ICanvasElement canvasElement2 = CanvasUpdateRegistry.instance.m_GraphicRebuildQueue[m];
						if (this.ObjectValidForUpdate(canvasElement2))
						{
							canvasElement2.Rebuild((CanvasUpdate)l);
						}
					}
					catch (Exception ex2)
					{
						Debug.LogException(ex2, CanvasUpdateRegistry.instance.m_GraphicRebuildQueue[m].transform);
					}
				}
			}
			for (int n = 0; n < this.m_GraphicRebuildQueue.Count; n++)
			{
				this.m_GraphicRebuildQueue[n].LayoutComplete();
			}
			CanvasUpdateRegistry.instance.m_GraphicRebuildQueue.Clear();
			this.m_PerformingGraphicUpdate = false;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00005C80 File Offset: 0x00003E80
		private static int ParentCount(Transform child)
		{
			if (child == null)
			{
				return 0;
			}
			Transform transform = child.parent;
			int num = 0;
			while (transform != null)
			{
				num++;
				transform = transform.parent;
			}
			return num;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00005CC4 File Offset: 0x00003EC4
		private static int SortLayoutList(ICanvasElement x, ICanvasElement y)
		{
			Transform transform = x.transform;
			Transform transform2 = y.transform;
			return CanvasUpdateRegistry.ParentCount(transform) - CanvasUpdateRegistry.ParentCount(transform2);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005CEC File Offset: 0x00003EEC
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			CanvasUpdateRegistry.instance.InternalRegisterCanvasElementForLayoutRebuild(element);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00005CFC File Offset: 0x00003EFC
		public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			return CanvasUpdateRegistry.instance.InternalRegisterCanvasElementForLayoutRebuild(element);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00005D0C File Offset: 0x00003F0C
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			if (this.m_LayoutRebuildQueue.Contains(element))
			{
				return false;
			}
			this.m_LayoutRebuildQueue.Add(element);
			return true;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00005D3C File Offset: 0x00003F3C
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			CanvasUpdateRegistry.instance.InternalRegisterCanvasElementForGraphicRebuild(element);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00005D4C File Offset: 0x00003F4C
		public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			return CanvasUpdateRegistry.instance.InternalRegisterCanvasElementForGraphicRebuild(element);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00005D5C File Offset: 0x00003F5C
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			if (this.m_PerformingGraphicUpdate)
			{
				Debug.LogError(string.Format("Trying to add {0} for graphic rebuild while we are already inside a graphic rebuild loop. This is not supported.", element));
				return false;
			}
			if (this.m_GraphicRebuildQueue.Contains(element))
			{
				return false;
			}
			this.m_GraphicRebuildQueue.Add(element);
			return true;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00005DA8 File Offset: 0x00003FA8
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
		{
			CanvasUpdateRegistry.instance.InternalUnRegisterCanvasElementForLayoutRebuild(element);
			CanvasUpdateRegistry.instance.InternalUnRegisterCanvasElementForGraphicRebuild(element);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00005DC0 File Offset: 0x00003FC0
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			if (this.m_PerformingLayoutUpdate)
			{
				Debug.LogError(string.Format("Trying to remove {0} from rebuild list while we are already inside a rebuild loop. This is not supported.", element));
				return;
			}
			element.LayoutComplete();
			CanvasUpdateRegistry.instance.m_LayoutRebuildQueue.Remove(element);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00005DF8 File Offset: 0x00003FF8
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			if (this.m_PerformingGraphicUpdate)
			{
				Debug.LogError(string.Format("Trying to remove {0} from rebuild list while we are already inside a rebuild loop. This is not supported.", element));
				return;
			}
			element.GraphicUpdateComplete();
			CanvasUpdateRegistry.instance.m_GraphicRebuildQueue.Remove(element);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00005E30 File Offset: 0x00004030
		public static bool IsRebuildingLayout()
		{
			return CanvasUpdateRegistry.instance.m_PerformingLayoutUpdate;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00005E3C File Offset: 0x0000403C
		public static bool IsRebuildingGraphics()
		{
			return CanvasUpdateRegistry.instance.m_PerformingGraphicUpdate;
		}

		// Token: 0x040000B1 RID: 177
		private static CanvasUpdateRegistry s_Instance;

		// Token: 0x040000B2 RID: 178
		private bool m_PerformingLayoutUpdate;

		// Token: 0x040000B3 RID: 179
		private bool m_PerformingGraphicUpdate;

		// Token: 0x040000B4 RID: 180
		private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue = new IndexedSet<ICanvasElement>();

		// Token: 0x040000B5 RID: 181
		private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue = new IndexedSet<ICanvasElement>();

		// Token: 0x040000B6 RID: 182
		private static readonly Comparison<ICanvasElement> s_SortLayoutFunction = new Comparison<ICanvasElement>(CanvasUpdateRegistry.SortLayoutList);
	}
}
