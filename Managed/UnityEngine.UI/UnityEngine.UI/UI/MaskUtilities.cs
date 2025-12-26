using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000060 RID: 96
	public class MaskUtilities
	{
		// Token: 0x0600031E RID: 798 RVA: 0x0000F78C File Offset: 0x0000D98C
		public static void Notify2DMaskStateChanged(Component mask)
		{
			List<Component> list = ListPool<Component>.Get();
			mask.GetComponentsInChildren<Component>(list);
			for (int i = 0; i < list.Count; i++)
			{
				if (!(list[i] == null) && !(list[i].gameObject == mask.gameObject))
				{
					IClippable clippable = list[i] as IClippable;
					if (clippable != null)
					{
						clippable.RecalculateClipping();
					}
				}
			}
			ListPool<Component>.Release(list);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000F810 File Offset: 0x0000DA10
		public static void NotifyStencilStateChanged(Component mask)
		{
			List<Component> list = ListPool<Component>.Get();
			mask.GetComponentsInChildren<Component>(list);
			for (int i = 0; i < list.Count; i++)
			{
				if (!(list[i] == null) && !(list[i].gameObject == mask.gameObject))
				{
					IMaskable maskable = list[i] as IMaskable;
					if (maskable != null)
					{
						maskable.RecalculateMasking();
					}
				}
			}
			ListPool<Component>.Release(list);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000F894 File Offset: 0x0000DA94
		public static Transform FindRootSortOverrideCanvas(Transform start)
		{
			Transform transform = start;
			Transform transform2 = null;
			while (transform != null)
			{
				Canvas component = transform.GetComponent<Canvas>();
				if (component != null && component.overrideSorting)
				{
					return transform;
				}
				if (component != null)
				{
					transform2 = transform;
				}
				transform = transform.parent;
			}
			return transform2;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000F8EC File Offset: 0x0000DAEC
		public static int GetStencilDepth(Transform transform, Transform stopAfter)
		{
			int num = 0;
			if (transform == stopAfter)
			{
				return num;
			}
			Transform transform2 = transform.parent;
			List<Component> list = ListPool<Component>.Get();
			while (transform2 != null)
			{
				transform2.GetComponents(typeof(Mask), list);
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i] != null && ((Mask)list[i]).IsActive() && ((Mask)list[i]).graphic.IsActive())
					{
						num++;
						break;
					}
				}
				if (transform2 == stopAfter)
				{
					break;
				}
				transform2 = transform2.parent;
			}
			ListPool<Component>.Release(list);
			return num;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000F9BC File Offset: 0x0000DBBC
		public static RectMask2D GetRectMaskForClippable(IClippable transform)
		{
			Transform transform2 = transform.rectTransform.parent;
			List<Component> list = ListPool<Component>.Get();
			while (transform2 != null)
			{
				transform2.GetComponents(typeof(RectMask2D), list);
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i] != null && ((RectMask2D)list[i]).IsActive())
					{
						RectMask2D rectMask2D = (RectMask2D)list[i];
						ListPool<Component>.Release(list);
						return rectMask2D;
					}
				}
				Canvas component = transform2.GetComponent<Canvas>();
				if (component)
				{
					break;
				}
				transform2 = transform2.parent;
			}
			ListPool<Component>.Release(list);
			return null;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000FA78 File Offset: 0x0000DC78
		public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks)
		{
			masks.Clear();
			Transform transform = clipper.transform;
			List<Component> list = ListPool<Component>.Get();
			while (transform != null)
			{
				transform.GetComponents(typeof(RectMask2D), list);
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i] != null && ((RectMask2D)list[i]).IsActive())
					{
						masks.Add((RectMask2D)list[i]);
					}
				}
				Canvas component = transform.GetComponent<Canvas>();
				if (component)
				{
					break;
				}
				transform = transform.parent;
			}
			ListPool<Component>.Release(list);
		}
	}
}
