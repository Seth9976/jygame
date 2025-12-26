using System;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.Serialization;

namespace UnityEngine
{
	// Token: 0x02000251 RID: 593
	internal static class ClassLibraryInitializer
	{
		// Token: 0x06002079 RID: 8313 RVA: 0x0000CD23 File Offset: 0x0000AF23
		private static void Init()
		{
			UnityLogWriter.Init();
			if (Application.platform.ToString().Contains("WebPlayer"))
			{
				BinaryFormatter.DefaultSurrogateSelector = new UnitySurrogateSelector();
			}
		}
	}
}
