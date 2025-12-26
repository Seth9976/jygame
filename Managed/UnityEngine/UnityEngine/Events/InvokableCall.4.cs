using System;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020002E9 RID: 745
	internal class InvokableCall<T1, T2, T3> : BaseInvokableCall
	{
		// Token: 0x0600229A RID: 8858 RVA: 0x0000E0DF File Offset: 0x0000C2DF
		public InvokableCall(object target, MethodInfo theFunction)
			: base(target, theFunction)
		{
			this.Delegate = (UnityAction<T1, T2, T3>)theFunction.CreateDelegate(typeof(UnityAction<T1, T2, T3>), target);
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x0000E105 File Offset: 0x0000C305
		public InvokableCall(UnityAction<T1, T2, T3> action)
		{
			this.Delegate = (UnityAction<T1, T2, T3>)global::System.Delegate.Combine(this.Delegate, action);
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0600229C RID: 8860 RVA: 0x0000E124 File Offset: 0x0000C324
		// (remove) Token: 0x0600229D RID: 8861 RVA: 0x0000E13D File Offset: 0x0000C33D
		protected event UnityAction<T1, T2, T3> Delegate;

		// Token: 0x0600229E RID: 8862 RVA: 0x0002D290 File Offset: 0x0002B490
		public override void Invoke(object[] args)
		{
			if (args.Length != 3)
			{
				throw new ArgumentException("Passed argument 'args' is invalid size. Expected size is 1");
			}
			BaseInvokableCall.ThrowOnInvalidArg<T1>(args[0]);
			BaseInvokableCall.ThrowOnInvalidArg<T2>(args[1]);
			BaseInvokableCall.ThrowOnInvalidArg<T3>(args[2]);
			if (BaseInvokableCall.AllowInvoke(this.Delegate))
			{
				this.Delegate((T1)((object)args[0]), (T2)((object)args[1]), (T3)((object)args[2]));
			}
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x0000E156 File Offset: 0x0000C356
		public override bool Find(object targetObj, MethodInfo method)
		{
			return this.Delegate.Target == targetObj && this.Delegate.GetMethodInfo() == method;
		}
	}
}
