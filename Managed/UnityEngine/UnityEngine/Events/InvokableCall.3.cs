using System;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020002E8 RID: 744
	internal class InvokableCall<T1, T2> : BaseInvokableCall
	{
		// Token: 0x06002294 RID: 8852 RVA: 0x0000E044 File Offset: 0x0000C244
		public InvokableCall(object target, MethodInfo theFunction)
			: base(target, theFunction)
		{
			this.Delegate = (UnityAction<T1, T2>)theFunction.CreateDelegate(typeof(UnityAction<T1, T2>), target);
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x0000E06A File Offset: 0x0000C26A
		public InvokableCall(UnityAction<T1, T2> action)
		{
			this.Delegate = (UnityAction<T1, T2>)global::System.Delegate.Combine(this.Delegate, action);
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06002296 RID: 8854 RVA: 0x0000E089 File Offset: 0x0000C289
		// (remove) Token: 0x06002297 RID: 8855 RVA: 0x0000E0A2 File Offset: 0x0000C2A2
		protected event UnityAction<T1, T2> Delegate;

		// Token: 0x06002298 RID: 8856 RVA: 0x0002D234 File Offset: 0x0002B434
		public override void Invoke(object[] args)
		{
			if (args.Length != 2)
			{
				throw new ArgumentException("Passed argument 'args' is invalid size. Expected size is 1");
			}
			BaseInvokableCall.ThrowOnInvalidArg<T1>(args[0]);
			BaseInvokableCall.ThrowOnInvalidArg<T2>(args[1]);
			if (BaseInvokableCall.AllowInvoke(this.Delegate))
			{
				this.Delegate((T1)((object)args[0]), (T2)((object)args[1]));
			}
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x0000E0BB File Offset: 0x0000C2BB
		public override bool Find(object targetObj, MethodInfo method)
		{
			return this.Delegate.Target == targetObj && this.Delegate.GetMethodInfo() == method;
		}
	}
}
