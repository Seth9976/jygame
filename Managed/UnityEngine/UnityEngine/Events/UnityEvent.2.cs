using System;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	/// <summary>
	///   <para>One argument version of UnityEvent.</para>
	/// </summary>
	// Token: 0x020002F2 RID: 754
	[Serializable]
	public abstract class UnityEvent<T0> : UnityEventBase
	{
		// Token: 0x060022EB RID: 8939 RVA: 0x0000E56D File Offset: 0x0000C76D
		public void AddListener(UnityAction<T0> call)
		{
			base.AddCall(UnityEvent<T0>.GetDelegate(call));
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x0000E517 File Offset: 0x0000C717
		public void RemoveListener(UnityAction<T0> call)
		{
			base.RemoveListener(call.Target, call.GetMethodInfo());
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x0000E57B File Offset: 0x0000C77B
		protected override MethodInfo FindMethod_Impl(string name, object targetObj)
		{
			return UnityEventBase.GetValidMethodInfo(targetObj, name, new Type[] { typeof(T0) });
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x0000E597 File Offset: 0x0000C797
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return new InvokableCall<T0>(target, theFunction);
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
		private static BaseInvokableCall GetDelegate(UnityAction<T0> action)
		{
			return new InvokableCall<T0>(action);
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x0000E5A8 File Offset: 0x0000C7A8
		public void Invoke(T0 arg0)
		{
			this.m_InvokeArray[0] = arg0;
			base.Invoke(this.m_InvokeArray);
		}

		// Token: 0x04000B9B RID: 2971
		private readonly object[] m_InvokeArray = new object[1];
	}
}
