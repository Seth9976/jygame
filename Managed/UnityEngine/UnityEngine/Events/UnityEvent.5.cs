using System;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	/// <summary>
	///   <para>Four argument version of UnityEvent.</para>
	/// </summary>
	// Token: 0x020002F5 RID: 757
	[Serializable]
	public abstract class UnityEvent<T0, T1, T2, T3> : UnityEventBase
	{
		// Token: 0x06002300 RID: 8960 RVA: 0x0000E6FF File Offset: 0x0000C8FF
		public void AddListener(UnityAction<T0, T1, T2, T3> call)
		{
			base.AddCall(UnityEvent<T0, T1, T2, T3>.GetDelegate(call));
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x0000E517 File Offset: 0x0000C717
		public void RemoveListener(UnityAction<T0, T1, T2, T3> call)
		{
			base.RemoveListener(call.Target, call.GetMethodInfo());
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0002DB38 File Offset: 0x0002BD38
		protected override MethodInfo FindMethod_Impl(string name, object targetObj)
		{
			return UnityEventBase.GetValidMethodInfo(targetObj, name, new Type[]
			{
				typeof(T0),
				typeof(T1),
				typeof(T2),
				typeof(T3)
			});
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x0000E70D File Offset: 0x0000C90D
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return new InvokableCall<T0, T1, T2, T3>(target, theFunction);
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x0000E716 File Offset: 0x0000C916
		private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2, T3> action)
		{
			return new InvokableCall<T0, T1, T2, T3>(action);
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x0002DB88 File Offset: 0x0002BD88
		public void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
		{
			this.m_InvokeArray[0] = arg0;
			this.m_InvokeArray[1] = arg1;
			this.m_InvokeArray[2] = arg2;
			this.m_InvokeArray[3] = arg3;
			base.Invoke(this.m_InvokeArray);
		}

		// Token: 0x04000B9E RID: 2974
		private readonly object[] m_InvokeArray = new object[4];
	}
}
