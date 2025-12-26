using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200009D RID: 157
	internal static class ListPool<T>
	{
		// Token: 0x06000588 RID: 1416 RVA: 0x00017E64 File Offset: 0x00016064
		public static List<T> Get()
		{
			return ListPool<T>.s_ListPool.Get();
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00017E70 File Offset: 0x00016070
		public static void Release(List<T> toRelease)
		{
			ListPool<T>.s_ListPool.Release(toRelease);
		}

		// Token: 0x040002A0 RID: 672
		private static readonly ObjectPool<List<T>> s_ListPool = new ObjectPool<List<T>>(null, delegate(List<T> l)
		{
			l.Clear();
		});
	}
}
