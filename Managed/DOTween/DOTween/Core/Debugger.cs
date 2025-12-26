using System;
using UnityEngine;

namespace DG.Tweening.Core
{
	// Token: 0x0200004C RID: 76
	internal static class Debugger
	{
		// Token: 0x0600020B RID: 523 RVA: 0x0000D9B8 File Offset: 0x0000BBB8
		internal static void Log(object message)
		{
			Debug.Log("DOTWEEN :: " + message);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000D9CA File Offset: 0x0000BBCA
		internal static void LogWarning(object message)
		{
			Debug.LogWarning("DOTWEEN :: " + message);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000D9DC File Offset: 0x0000BBDC
		internal static void LogError(object message)
		{
			Debug.LogError("DOTWEEN :: " + message);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000D9EE File Offset: 0x0000BBEE
		internal static void LogReport(object message)
		{
			Debug.Log("<color=#00B500FF>DOTWEEN :: " + message + "</color>");
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000DA05 File Offset: 0x0000BC05
		internal static void LogInvalidTween(Tween t)
		{
			Debugger.LogWarning("This Tween has been killed and is now invalid");
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000DA11 File Offset: 0x0000BC11
		internal static void LogNestedTween(Tween t)
		{
			Debugger.LogWarning("This Tween was added to a Sequence and can't be controlled directly");
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000DA1D File Offset: 0x0000BC1D
		internal static void LogNullTween(Tween t)
		{
			Debugger.LogWarning("Null Tween");
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000DA2C File Offset: 0x0000BC2C
		internal static void SetLogPriority(LogBehaviour logBehaviour)
		{
			switch (logBehaviour)
			{
			case LogBehaviour.Default:
				Debugger.logPriority = 1;
				return;
			case LogBehaviour.Verbose:
				Debugger.logPriority = 2;
				return;
			default:
				Debugger.logPriority = 0;
				return;
			}
		}

		// Token: 0x04000136 RID: 310
		internal static int logPriority;
	}
}
