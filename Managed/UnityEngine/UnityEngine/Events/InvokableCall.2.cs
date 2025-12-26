using System;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020002E7 RID: 743
	internal class InvokableCall<T1> : BaseInvokableCall
	{
		// Token: 0x0600228E RID: 8846 RVA: 0x0000DF99 File Offset: 0x0000C199
		public InvokableCall(object target, MethodInfo theFunction)
			: base(target, theFunction)
		{
			this.Delegate = (UnityAction<T1>)global::System.Delegate.Combine(this.Delegate, (UnityAction<T1>)theFunction.CreateDelegate(typeof(UnityAction<T1>), target));
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x0000DFCF File Offset: 0x0000C1CF
		public InvokableCall(UnityAction<T1> action)
		{
			this.Delegate = (UnityAction<T1>)global::System.Delegate.Combine(this.Delegate, action);
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06002290 RID: 8848 RVA: 0x0000DFEE File Offset: 0x0000C1EE
		// (remove) Token: 0x06002291 RID: 8849 RVA: 0x0000E007 File Offset: 0x0000C207
		protected event UnityAction<T1> Delegate;

		// Token: 0x06002292 RID: 8850 RVA: 0x0002D1E8 File Offset: 0x0002B3E8
		public override void Invoke(object[] args)
		{
			if (args.Length != 1)
			{
				throw new ArgumentException("Passed argument 'args' is invalid size. Expected size is 1");
			}
			BaseInvokableCall.ThrowOnInvalidArg<T1>(args[0]);
			if (BaseInvokableCall.AllowInvoke(this.Delegate))
			{
				this.Delegate((T1)((object)args[0]));
			}
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x0000E020 File Offset: 0x0000C220
		public override bool Find(object targetObj, MethodInfo method)
		{
			return this.Delegate.Target == targetObj && this.Delegate.GetMethodInfo() == method;
		}
	}
}
