using System;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020002EA RID: 746
	internal class InvokableCall<T1, T2, T3, T4> : BaseInvokableCall
	{
		// Token: 0x060022A0 RID: 8864 RVA: 0x0000E17A File Offset: 0x0000C37A
		public InvokableCall(object target, MethodInfo theFunction)
			: base(target, theFunction)
		{
			this.Delegate = (UnityAction<T1, T2, T3, T4>)theFunction.CreateDelegate(typeof(UnityAction<T1, T2, T3, T4>), target);
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x0000E1A0 File Offset: 0x0000C3A0
		public InvokableCall(UnityAction<T1, T2, T3, T4> action)
		{
			this.Delegate = (UnityAction<T1, T2, T3, T4>)global::System.Delegate.Combine(this.Delegate, action);
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060022A2 RID: 8866 RVA: 0x0000E1BF File Offset: 0x0000C3BF
		// (remove) Token: 0x060022A3 RID: 8867 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		protected event UnityAction<T1, T2, T3, T4> Delegate;

		// Token: 0x060022A4 RID: 8868 RVA: 0x0002D2FC File Offset: 0x0002B4FC
		public override void Invoke(object[] args)
		{
			if (args.Length != 4)
			{
				throw new ArgumentException("Passed argument 'args' is invalid size. Expected size is 1");
			}
			BaseInvokableCall.ThrowOnInvalidArg<T1>(args[0]);
			BaseInvokableCall.ThrowOnInvalidArg<T2>(args[1]);
			BaseInvokableCall.ThrowOnInvalidArg<T3>(args[2]);
			BaseInvokableCall.ThrowOnInvalidArg<T4>(args[3]);
			if (BaseInvokableCall.AllowInvoke(this.Delegate))
			{
				this.Delegate((T1)((object)args[0]), (T2)((object)args[1]), (T3)((object)args[2]), (T4)((object)args[3]));
			}
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x0000E1F1 File Offset: 0x0000C3F1
		public override bool Find(object targetObj, MethodInfo method)
		{
			return this.Delegate.Target == targetObj && this.Delegate.GetMethodInfo() == method;
		}
	}
}
