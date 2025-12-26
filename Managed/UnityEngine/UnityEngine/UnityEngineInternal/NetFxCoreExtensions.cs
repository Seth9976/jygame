using System;
using System.Reflection;

namespace UnityEngineInternal
{
	// Token: 0x0200030D RID: 781
	internal static class NetFxCoreExtensions
	{
		// Token: 0x06002377 RID: 9079 RVA: 0x0000EBE5 File Offset: 0x0000CDE5
		public static Delegate CreateDelegate(this MethodInfo self, Type delegateType, object target)
		{
			return Delegate.CreateDelegate(delegateType, target, self);
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x0000EBEF File Offset: 0x0000CDEF
		public static MethodInfo GetMethodInfo(this Delegate self)
		{
			return self.Method;
		}
	}
}
