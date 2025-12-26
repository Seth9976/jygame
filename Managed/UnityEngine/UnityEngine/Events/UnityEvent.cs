using System;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.Events
{
	/// <summary>
	///   <para>A zero argument persistent callback that can be saved with the scene.</para>
	/// </summary>
	// Token: 0x020002F1 RID: 753
	[Serializable]
	public class UnityEvent : UnityEventBase
	{
		/// <summary>
		///   <para>Add a non persistent listener to the UnityEvent.</para>
		/// </summary>
		/// <param name="call">Callback function.</param>
		// Token: 0x060022E4 RID: 8932 RVA: 0x0000E509 File Offset: 0x0000C709
		public void AddListener(UnityAction call)
		{
			base.AddCall(UnityEvent.GetDelegate(call));
		}

		/// <summary>
		///   <para>Remove a non persistent listener from the UnityEvent.</para>
		/// </summary>
		/// <param name="call">Callback function.</param>
		// Token: 0x060022E5 RID: 8933 RVA: 0x0000E517 File Offset: 0x0000C717
		public void RemoveListener(UnityAction call)
		{
			base.RemoveListener(call.Target, call.GetMethodInfo());
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x0000E52B File Offset: 0x0000C72B
		protected override MethodInfo FindMethod_Impl(string name, object targetObj)
		{
			return UnityEventBase.GetValidMethodInfo(targetObj, name, new Type[0]);
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x0000E53A File Offset: 0x0000C73A
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return new InvokableCall(target, theFunction);
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x0000E543 File Offset: 0x0000C743
		private static BaseInvokableCall GetDelegate(UnityAction action)
		{
			return new InvokableCall(action);
		}

		/// <summary>
		///   <para>Invoke all registered callbacks (runtime and peristent).</para>
		/// </summary>
		// Token: 0x060022E9 RID: 8937 RVA: 0x0000E54B File Offset: 0x0000C74B
		public void Invoke()
		{
			base.Invoke(this.m_InvokeArray);
		}

		// Token: 0x04000B9A RID: 2970
		private readonly object[] m_InvokeArray = new object[0];
	}
}
