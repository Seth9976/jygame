using System;
using DG.Tweening.Core.Enums;

namespace DG.Tweening.Core
{
	// Token: 0x02000009 RID: 9
	public static class Extensions
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00002F44 File Offset: 0x00001144
		internal static T SetSpecialStartupMode<T>(this T t, SpecialStartupMode mode) where T : Tween
		{
			t.specialStartupMode = mode;
			return t;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002F53 File Offset: 0x00001153
		internal static TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct
		{
			t.isFromAllowed = false;
			return t;
		}
	}
}
