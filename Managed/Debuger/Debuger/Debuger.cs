using System;
using UnityEngine;

namespace Junfine.Debuger
{
	// Token: 0x02000002 RID: 2
	public class Debuger
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void Log(string str, params object[] args)
		{
			if (!Debuger.enableLog)
			{
				return;
			}
			str = string.Format(str, args);
			Debug.Log(str);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002069 File Offset: 0x00000269
		public static void LogWarning(string str, params object[] args)
		{
			if (!Debuger.enableLog)
			{
				return;
			}
			str = string.Format(str, args);
			Debug.LogWarning(str);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002082 File Offset: 0x00000282
		public static void LogError(string str, params object[] args)
		{
			if (!Debuger.enableLog)
			{
				return;
			}
			str = string.Format(str, args);
			Debug.LogError(str);
		}

		// Token: 0x04000001 RID: 1
		public static bool enableLog = true;
	}
}
