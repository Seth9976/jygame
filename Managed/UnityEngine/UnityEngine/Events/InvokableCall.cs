using System;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	// Token: 0x020002E6 RID: 742
	internal class InvokableCall : BaseInvokableCall
	{
		// Token: 0x06002288 RID: 8840 RVA: 0x0000DED1 File Offset: 0x0000C0D1
		public InvokableCall(object target, MethodInfo theFunction)
			: base(target, theFunction)
		{
			this.Delegate = (UnityAction)global::System.Delegate.Combine(this.Delegate, (UnityAction)theFunction.CreateDelegate(typeof(UnityAction), target));
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x0000DF07 File Offset: 0x0000C107
		public InvokableCall(UnityAction action)
		{
			this.Delegate = (UnityAction)global::System.Delegate.Combine(this.Delegate, action);
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600228A RID: 8842 RVA: 0x0000DF26 File Offset: 0x0000C126
		// (remove) Token: 0x0600228B RID: 8843 RVA: 0x0000DF3F File Offset: 0x0000C13F
		private event UnityAction Delegate;

		// Token: 0x0600228C RID: 8844 RVA: 0x0000DF58 File Offset: 0x0000C158
		public override void Invoke(object[] args)
		{
			if (BaseInvokableCall.AllowInvoke(this.Delegate))
			{
				this.Delegate();
			}
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x0000DF75 File Offset: 0x0000C175
		public override bool Find(object targetObj, MethodInfo method)
		{
			return this.Delegate.Target == targetObj && this.Delegate.GetMethodInfo() == method;
		}
	}
}
