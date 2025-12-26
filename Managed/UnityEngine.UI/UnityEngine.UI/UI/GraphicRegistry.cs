using System;
using System.Collections.Generic;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000049 RID: 73
	public class GraphicRegistry
	{
		// Token: 0x06000241 RID: 577 RVA: 0x000096B4 File Offset: 0x000078B4
		protected GraphicRegistry()
		{
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000243 RID: 579 RVA: 0x000096E0 File Offset: 0x000078E0
		public static GraphicRegistry instance
		{
			get
			{
				if (GraphicRegistry.s_Instance == null)
				{
					GraphicRegistry.s_Instance = new GraphicRegistry();
				}
				return GraphicRegistry.s_Instance;
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000096FC File Offset: 0x000078FC
		public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
			if (c == null)
			{
				return;
			}
			IndexedSet<Graphic> indexedSet;
			GraphicRegistry.instance.m_Graphics.TryGetValue(c, out indexedSet);
			if (indexedSet != null)
			{
				indexedSet.Add(graphic);
				return;
			}
			indexedSet = new IndexedSet<Graphic>();
			indexedSet.Add(graphic);
			GraphicRegistry.instance.m_Graphics.Add(c, indexedSet);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00009758 File Offset: 0x00007958
		public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
			if (c == null)
			{
				return;
			}
			IndexedSet<Graphic> indexedSet;
			if (GraphicRegistry.instance.m_Graphics.TryGetValue(c, out indexedSet))
			{
				indexedSet.Remove(graphic);
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00009794 File Offset: 0x00007994
		public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas)
		{
			IndexedSet<Graphic> indexedSet;
			if (GraphicRegistry.instance.m_Graphics.TryGetValue(canvas, out indexedSet))
			{
				return indexedSet;
			}
			return GraphicRegistry.s_EmptyList;
		}

		// Token: 0x0400010B RID: 267
		private static GraphicRegistry s_Instance;

		// Token: 0x0400010C RID: 268
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics = new Dictionary<Canvas, IndexedSet<Graphic>>();

		// Token: 0x0400010D RID: 269
		private static readonly List<Graphic> s_EmptyList = new List<Graphic>();
	}
}
