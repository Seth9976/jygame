using System;
using System.Reflection;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x020002ED RID: 749
	[Serializable]
	internal class PersistentCall
	{
		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x0000E261 File Offset: 0x0000C461
		public Object target
		{
			get
			{
				return this.m_Target;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x0000E269 File Offset: 0x0000C469
		public string methodName
		{
			get
			{
				return this.m_MethodName;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x0000E271 File Offset: 0x0000C471
		// (set) Token: 0x060022AC RID: 8876 RVA: 0x0000E279 File Offset: 0x0000C479
		public PersistentListenerMode mode
		{
			get
			{
				return this.m_Mode;
			}
			set
			{
				this.m_Mode = value;
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x0000E282 File Offset: 0x0000C482
		public ArgumentCache arguments
		{
			get
			{
				return this.m_Arguments;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x0000E28A File Offset: 0x0000C48A
		// (set) Token: 0x060022AF RID: 8879 RVA: 0x0000E292 File Offset: 0x0000C492
		public UnityEventCallState callState
		{
			get
			{
				return this.m_CallState;
			}
			set
			{
				this.m_CallState = value;
			}
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x0000E29B File Offset: 0x0000C49B
		public bool IsValid()
		{
			return this.target != null && !string.IsNullOrEmpty(this.methodName);
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x0002D378 File Offset: 0x0002B578
		public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent)
		{
			if (this.m_CallState == UnityEventCallState.Off || theEvent == null)
			{
				return null;
			}
			MethodInfo methodInfo = theEvent.FindMethod(this);
			if (methodInfo == null)
			{
				return null;
			}
			switch (this.m_Mode)
			{
			case PersistentListenerMode.EventDefined:
				return theEvent.GetDelegate(this.target, methodInfo);
			case PersistentListenerMode.Void:
				return new InvokableCall(this.target, methodInfo);
			case PersistentListenerMode.Object:
				return PersistentCall.GetObjectCall(this.target, methodInfo, this.m_Arguments);
			case PersistentListenerMode.Int:
				return new CachedInvokableCall<int>(this.target, methodInfo, this.m_Arguments.intArgument);
			case PersistentListenerMode.Float:
				return new CachedInvokableCall<float>(this.target, methodInfo, this.m_Arguments.floatArgument);
			case PersistentListenerMode.String:
				return new CachedInvokableCall<string>(this.target, methodInfo, this.m_Arguments.stringArgument);
			case PersistentListenerMode.Bool:
				return new CachedInvokableCall<bool>(this.target, methodInfo, this.m_Arguments.boolArgument);
			default:
				return null;
			}
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x0002D468 File Offset: 0x0002B668
		private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments)
		{
			Type type = typeof(Object);
			if (!string.IsNullOrEmpty(arguments.unityObjectArgumentAssemblyTypeName))
			{
				type = Type.GetType(arguments.unityObjectArgumentAssemblyTypeName, false) ?? typeof(Object);
			}
			Type typeFromHandle = typeof(CachedInvokableCall<>);
			Type type2 = typeFromHandle.MakeGenericType(new Type[] { type });
			ConstructorInfo constructor = type2.GetConstructor(new Type[]
			{
				typeof(Object),
				typeof(MethodInfo),
				type
			});
			Object @object = arguments.unityObjectArgument;
			if (@object != null && !type.IsAssignableFrom(@object.GetType()))
			{
				@object = null;
			}
			return constructor.Invoke(new object[] { target, method, @object }) as BaseInvokableCall;
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x0000E2BF File Offset: 0x0000C4BF
		public void RegisterPersistentListener(Object ttarget, string mmethodName)
		{
			this.m_Target = ttarget;
			this.m_MethodName = mmethodName;
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x0000E2CF File Offset: 0x0000C4CF
		public void UnregisterPersistentListener()
		{
			this.m_MethodName = string.Empty;
			this.m_Target = null;
		}

		// Token: 0x04000B8C RID: 2956
		[FormerlySerializedAs("instance")]
		[SerializeField]
		private Object m_Target;

		// Token: 0x04000B8D RID: 2957
		[FormerlySerializedAs("methodName")]
		[SerializeField]
		private string m_MethodName;

		// Token: 0x04000B8E RID: 2958
		[FormerlySerializedAs("mode")]
		[SerializeField]
		private PersistentListenerMode m_Mode;

		// Token: 0x04000B8F RID: 2959
		[SerializeField]
		[FormerlySerializedAs("arguments")]
		private ArgumentCache m_Arguments = new ArgumentCache();

		// Token: 0x04000B90 RID: 2960
		[FormerlySerializedAs("enabled")]
		[SerializeField]
		[FormerlySerializedAs("m_Enabled")]
		private UnityEventCallState m_CallState = UnityEventCallState.RuntimeOnly;
	}
}
