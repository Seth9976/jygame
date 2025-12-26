using System;

namespace UnityEngine.UI
{
	// Token: 0x02000061 RID: 97
	internal static class Misc
	{
		// Token: 0x06000324 RID: 804 RVA: 0x0000FB30 File Offset: 0x0000DD30
		public static void Destroy(Object obj)
		{
			if (obj != null)
			{
				if (Application.isPlaying)
				{
					if (obj is GameObject)
					{
						GameObject gameObject = obj as GameObject;
						gameObject.transform.parent = null;
					}
					Object.Destroy(obj);
				}
				else
				{
					Object.DestroyImmediate(obj);
				}
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000FB84 File Offset: 0x0000DD84
		public static void DestroyImmediate(Object obj)
		{
			if (obj != null)
			{
				if (Application.isEditor)
				{
					Object.DestroyImmediate(obj);
				}
				else
				{
					Object.Destroy(obj);
				}
			}
		}
	}
}
