using System;
using System.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020002EB RID: 747
	internal class CachedInvokableCall<T> : InvokableCall<T>
	{
		// Token: 0x060022A6 RID: 8870 RVA: 0x0000E215 File Offset: 0x0000C415
		public CachedInvokableCall(Object target, MethodInfo theFunction, T argument)
			: base(target, theFunction)
		{
			this.m_Arg1[0] = argument;
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x0000E239 File Offset: 0x0000C439
		public override void Invoke(object[] args)
		{
			base.Invoke(this.m_Arg1);
		}

		// Token: 0x04000B87 RID: 2951
		private readonly object[] m_Arg1 = new object[1];
	}
}
