using System;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	/// <summary>
	///   <para>Three argument version of UnityEvent.</para>
	/// </summary>
	// Token: 0x020002F4 RID: 756
	[Serializable]
	public abstract class UnityEvent<T0, T1, T2> : UnityEventBase
	{
		// Token: 0x060022F9 RID: 8953 RVA: 0x0000E65E File Offset: 0x0000C85E
		public void AddListener(UnityAction<T0, T1, T2> call)
		{
			base.AddCall(UnityEvent<T0, T1, T2>.GetDelegate(call));
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x0000E517 File Offset: 0x0000C717
		public void RemoveListener(UnityAction<T0, T1, T2> call)
		{
			base.RemoveListener(call.Target, call.GetMethodInfo());
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x0000E66C File Offset: 0x0000C86C
		protected override MethodInfo FindMethod_Impl(string name, object targetObj)
		{
			return UnityEventBase.GetValidMethodInfo(targetObj, name, new Type[]
			{
				typeof(T0),
				typeof(T1),
				typeof(T2)
			});
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x0000E6A2 File Offset: 0x0000C8A2
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return new InvokableCall<T0, T1, T2>(target, theFunction);
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x0000E6AB File Offset: 0x0000C8AB
		private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2> action)
		{
			return new InvokableCall<T0, T1, T2>(action);
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x0000E6B3 File Offset: 0x0000C8B3
		public void Invoke(T0 arg0, T1 arg1, T2 arg2)
		{
			this.m_InvokeArray[0] = arg0;
			this.m_InvokeArray[1] = arg1;
			this.m_InvokeArray[2] = arg2;
			base.Invoke(this.m_InvokeArray);
		}

		// Token: 0x04000B9D RID: 2973
		private readonly object[] m_InvokeArray = new object[3];
	}
}
