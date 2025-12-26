using System;
using DG.Tweening.Core;

namespace DG.Tweening.Plugins.Core
{
	// Token: 0x0200000B RID: 11
	public interface IPlugSetter<T1, out T2, TPlugin, out TPlugOptions>
	{
		// Token: 0x06000056 RID: 86
		DOGetter<T1> Getter();

		// Token: 0x06000057 RID: 87
		DOSetter<T1> Setter();

		// Token: 0x06000058 RID: 88
		T2 EndValue();

		// Token: 0x06000059 RID: 89
		TPlugOptions GetOptions();
	}
}
