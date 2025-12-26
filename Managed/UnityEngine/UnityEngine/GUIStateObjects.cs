using System;
using System.Collections.Generic;
using System.Security;

namespace UnityEngine
{
	// Token: 0x02000297 RID: 663
	internal class GUIStateObjects
	{
		// Token: 0x060020AF RID: 8367 RVA: 0x000285C0 File Offset: 0x000267C0
		[SecuritySafeCritical]
		internal static object GetStateObject(Type t, int controlID)
		{
			object obj;
			if (!GUIStateObjects.s_StateCache.TryGetValue(controlID, out obj) || obj.GetType() != t)
			{
				obj = Activator.CreateInstance(t);
				GUIStateObjects.s_StateCache[controlID] = obj;
			}
			return obj;
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00028600 File Offset: 0x00026800
		internal static object QueryStateObject(Type t, int controlID)
		{
			object obj = GUIStateObjects.s_StateCache[controlID];
			if (t.IsInstanceOfType(obj))
			{
				return obj;
			}
			return null;
		}

		// Token: 0x04000A7C RID: 2684
		private static Dictionary<int, object> s_StateCache = new Dictionary<int, object>();
	}
}
