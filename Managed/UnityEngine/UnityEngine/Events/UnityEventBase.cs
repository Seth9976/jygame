using System;
using System.Reflection;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	/// <summary>
	///   <para>Abstract base class for UnityEvents.</para>
	/// </summary>
	// Token: 0x020002F0 RID: 752
	[Serializable]
	public abstract class UnityEventBase : ISerializationCallbackReceiver
	{
		// Token: 0x060022CF RID: 8911 RVA: 0x0000E3EF File Offset: 0x0000C5EF
		protected UnityEventBase()
		{
			this.m_Calls = new InvokableCallList();
			this.m_PersistentCalls = new PersistentCallGroup();
			this.m_TypeName = base.GetType().AssemblyQualifiedName;
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x00002753 File Offset: 0x00000953
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x0000E425 File Offset: 0x0000C625
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			this.DirtyPersistentCalls();
			this.m_TypeName = base.GetType().AssemblyQualifiedName;
		}

		// Token: 0x060022D2 RID: 8914
		protected abstract MethodInfo FindMethod_Impl(string name, object targetObj);

		// Token: 0x060022D3 RID: 8915
		internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

		// Token: 0x060022D4 RID: 8916 RVA: 0x0002D8AC File Offset: 0x0002BAAC
		internal MethodInfo FindMethod(PersistentCall call)
		{
			Type type = typeof(Object);
			if (!string.IsNullOrEmpty(call.arguments.unityObjectArgumentAssemblyTypeName))
			{
				type = Type.GetType(call.arguments.unityObjectArgumentAssemblyTypeName, false) ?? typeof(Object);
			}
			return this.FindMethod(call.methodName, call.target, call.mode, type);
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x0002D918 File Offset: 0x0002BB18
		internal MethodInfo FindMethod(string name, object listener, PersistentListenerMode mode, Type argumentType)
		{
			switch (mode)
			{
			case PersistentListenerMode.EventDefined:
				return this.FindMethod_Impl(name, listener);
			case PersistentListenerMode.Void:
				return UnityEventBase.GetValidMethodInfo(listener, name, new Type[0]);
			case PersistentListenerMode.Object:
				return UnityEventBase.GetValidMethodInfo(listener, name, new Type[] { argumentType ?? typeof(Object) });
			case PersistentListenerMode.Int:
				return UnityEventBase.GetValidMethodInfo(listener, name, new Type[] { typeof(int) });
			case PersistentListenerMode.Float:
				return UnityEventBase.GetValidMethodInfo(listener, name, new Type[] { typeof(float) });
			case PersistentListenerMode.String:
				return UnityEventBase.GetValidMethodInfo(listener, name, new Type[] { typeof(string) });
			case PersistentListenerMode.Bool:
				return UnityEventBase.GetValidMethodInfo(listener, name, new Type[] { typeof(bool) });
			default:
				return null;
			}
		}

		/// <summary>
		///   <para>Get the number of registered persistent listeners.</para>
		/// </summary>
		// Token: 0x060022D6 RID: 8918 RVA: 0x0000E43E File Offset: 0x0000C63E
		public int GetPersistentEventCount()
		{
			return this.m_PersistentCalls.Count;
		}

		/// <summary>
		///   <para>Get the target component of the listener at index index.</para>
		/// </summary>
		/// <param name="index">Index of the listener to query.</param>
		// Token: 0x060022D7 RID: 8919 RVA: 0x0002D9F8 File Offset: 0x0002BBF8
		public Object GetPersistentTarget(int index)
		{
			PersistentCall listener = this.m_PersistentCalls.GetListener(index);
			return (listener == null) ? null : listener.target;
		}

		/// <summary>
		///   <para>Get the target method name of the listener at index index.</para>
		/// </summary>
		/// <param name="index">Index of the listener to query.</param>
		// Token: 0x060022D8 RID: 8920 RVA: 0x0002DA24 File Offset: 0x0002BC24
		public string GetPersistentMethodName(int index)
		{
			PersistentCall listener = this.m_PersistentCalls.GetListener(index);
			return (listener == null) ? string.Empty : listener.methodName;
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x0000E44B File Offset: 0x0000C64B
		private void DirtyPersistentCalls()
		{
			this.m_Calls.ClearPersistent();
			this.m_CallsDirty = true;
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x0000E45F File Offset: 0x0000C65F
		private void RebuildPersistentCallsIfNeeded()
		{
			if (this.m_CallsDirty)
			{
				this.m_PersistentCalls.Initialize(this.m_Calls, this);
				this.m_CallsDirty = false;
			}
		}

		/// <summary>
		///   <para>Modify the execution state of a persistent listener.</para>
		/// </summary>
		/// <param name="index">Index of the listener to query.</param>
		/// <param name="state">State to set.</param>
		// Token: 0x060022DB RID: 8923 RVA: 0x0002DA54 File Offset: 0x0002BC54
		public void SetPersistentListenerState(int index, UnityEventCallState state)
		{
			PersistentCall listener = this.m_PersistentCalls.GetListener(index);
			if (listener != null)
			{
				listener.callState = state;
			}
			this.DirtyPersistentCalls();
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x0000E485 File Offset: 0x0000C685
		protected void AddListener(object targetObj, MethodInfo method)
		{
			this.m_Calls.AddListener(this.GetDelegate(targetObj, method));
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x0000E49A File Offset: 0x0000C69A
		internal void AddCall(BaseInvokableCall call)
		{
			this.m_Calls.AddListener(call);
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		protected void RemoveListener(object targetObj, MethodInfo method)
		{
			this.m_Calls.RemoveListener(targetObj, method);
		}

		/// <summary>
		///   <para>Remove all listeners from the event.</para>
		/// </summary>
		// Token: 0x060022DF RID: 8927 RVA: 0x0000E4B7 File Offset: 0x0000C6B7
		public void RemoveAllListeners()
		{
			this.m_Calls.Clear();
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x0000E4C4 File Offset: 0x0000C6C4
		protected void Invoke(object[] parameters)
		{
			this.RebuildPersistentCallsIfNeeded();
			this.m_Calls.Invoke(parameters);
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		public override string ToString()
		{
			return base.ToString() + " " + base.GetType().FullName;
		}

		/// <summary>
		///   <para>Given an object, function name, and a list of argument types; find the method that matches.</para>
		/// </summary>
		/// <param name="obj">Object to search for the method.</param>
		/// <param name="functionName">Function name to search for.</param>
		/// <param name="argumentTypes">Argument types for the function.</param>
		// Token: 0x060022E2 RID: 8930 RVA: 0x0002DA84 File Offset: 0x0002BC84
		public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes)
		{
			Type type = obj.GetType();
			while (type != typeof(object) && type != null)
			{
				MethodInfo method = type.GetMethod(functionName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, argumentTypes, null);
				if (method != null)
				{
					ParameterInfo[] parameters = method.GetParameters();
					bool flag = true;
					int num = 0;
					foreach (ParameterInfo parameterInfo in parameters)
					{
						Type type2 = argumentTypes[num];
						Type parameterType = parameterInfo.ParameterType;
						flag = type2.IsPrimitive == parameterType.IsPrimitive;
						if (!flag)
						{
							break;
						}
						num++;
					}
					if (flag)
					{
						return method;
					}
				}
				type = type.BaseType;
			}
			return null;
		}

		// Token: 0x04000B96 RID: 2966
		private InvokableCallList m_Calls;

		// Token: 0x04000B97 RID: 2967
		[SerializeField]
		[FormerlySerializedAs("m_PersistentListeners")]
		private PersistentCallGroup m_PersistentCalls;

		// Token: 0x04000B98 RID: 2968
		[SerializeField]
		private string m_TypeName;

		// Token: 0x04000B99 RID: 2969
		private bool m_CallsDirty = true;
	}
}
