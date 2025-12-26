using System;
using System.Reflection;

namespace UnityEngine
{
	// Token: 0x020002CF RID: 719
	public static class Types
	{
		// Token: 0x060021C3 RID: 8643 RVA: 0x00029894 File Offset: 0x00027A94
		public static Type GetType(string typeName, string assemblyName)
		{
			Type type;
			try
			{
				type = Assembly.Load(assemblyName).GetType(typeName);
			}
			catch (Exception)
			{
				type = null;
			}
			return type;
		}
	}
}
