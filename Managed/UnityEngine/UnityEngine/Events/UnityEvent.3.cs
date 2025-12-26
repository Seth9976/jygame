using System;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	/// <summary>
	///   <para>Two argument version of UnityEvent.</para>
	/// </summary>
	// Token: 0x020002F3 RID: 755
	[Serializable]
	public abstract class UnityEvent<T0, T1> : UnityEventBase
	{
		// Token: 0x060022F2 RID: 8946 RVA: 0x0000E5D8 File Offset: 0x0000C7D8
		public void AddListener(UnityAction<T0, T1> call)
		{
			base.AddCall(UnityEvent<T0, T1>.GetDelegate(call));
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x0000E517 File Offset: 0x0000C717
		public void RemoveListener(UnityAction<T0, T1> call)
		{
			base.RemoveListener(call.Target, call.GetMethodInfo());
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x0000E5E6 File Offset: 0x0000C7E6
		protected override MethodInfo FindMethod_Impl(string name, object targetObj)
		{
			return UnityEventBase.GetValidMethodInfo(targetObj, name, new Type[]
			{
				typeof(T0),
				typeof(T1)
			});
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x0000E60F File Offset: 0x0000C80F
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return new InvokableCall<T0, T1>(target, theFunction);
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x0000E618 File Offset: 0x0000C818
		private static BaseInvokableCall GetDelegate(UnityAction<T0, T1> action)
		{
			return new InvokableCall<T0, T1>(action);
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x0000E620 File Offset: 0x0000C820
		public void Invoke(T0 arg0, T1 arg1)
		{
			this.m_InvokeArray[0] = arg0;
			this.m_InvokeArray[1] = arg1;
			base.Invoke(this.m_InvokeArray);
		}

		// Token: 0x04000B9C RID: 2972
		private readonly object[] m_InvokeArray = new object[2];
	}
}
