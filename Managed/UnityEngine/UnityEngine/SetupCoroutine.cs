using System;
using System.Reflection;

namespace UnityEngine
{
	// Token: 0x02000252 RID: 594
	internal class SetupCoroutine
	{
		// Token: 0x0600207B RID: 8315 RVA: 0x00028490 File Offset: 0x00026690
		public static object InvokeMember(object behaviour, string name, object variable)
		{
			object[] array = null;
			if (variable != null)
			{
				array = new object[] { variable };
			}
			return behaviour.GetType().InvokeMember(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, behaviour, array, null, null, null);
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x000284C8 File Offset: 0x000266C8
		public static object InvokeStatic(Type klass, string name, object variable)
		{
			object[] array = null;
			if (variable != null)
			{
				array = new object[] { variable };
			}
			return klass.InvokeMember(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, null, array, null, null, null);
		}
	}
}
