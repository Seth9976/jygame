using System;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x0200007E RID: 126
	public class ClipperRegistry
	{
		// Token: 0x06000495 RID: 1173 RVA: 0x000154DC File Offset: 0x000136DC
		protected ClipperRegistry()
		{
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x000154FC File Offset: 0x000136FC
		public static ClipperRegistry instance
		{
			get
			{
				if (ClipperRegistry.s_Instance == null)
				{
					ClipperRegistry.s_Instance = new ClipperRegistry();
				}
				return ClipperRegistry.s_Instance;
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00015518 File Offset: 0x00013718
		public void Cull()
		{
			for (int i = 0; i < this.m_Clippers.Count; i++)
			{
				this.m_Clippers[i].PerformClipping();
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00015554 File Offset: 0x00013754
		public static void Register(IClipper c)
		{
			if (c == null)
			{
				return;
			}
			ClipperRegistry.instance.m_Clippers.Add(c);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00015570 File Offset: 0x00013770
		public static void Unregister(IClipper c)
		{
			ClipperRegistry.instance.m_Clippers.Remove(c);
		}

		// Token: 0x04000237 RID: 567
		private static ClipperRegistry s_Instance;

		// Token: 0x04000238 RID: 568
		private readonly IndexedSet<IClipper> m_Clippers = new IndexedSet<IClipper>();
	}
}
