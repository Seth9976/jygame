using System;
using UnityEngine;

namespace UnityEngineInternal
{
	// Token: 0x02000309 RID: 777
	public sealed class APIUpdaterRuntimeServices
	{
		// Token: 0x06002372 RID: 9074 RVA: 0x0000EBAC File Offset: 0x0000CDAC
		[Obsolete("Method is not meant to be used at runtime. Please, replace this call with GameObject.AddComponent<T>()/GameObject.AddComponent(Type).", true)]
		public static Component AddComponent(GameObject go, string sourceInfo, string name)
		{
			throw new Exception();
		}
	}
}
