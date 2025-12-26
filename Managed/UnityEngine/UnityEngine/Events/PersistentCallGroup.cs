using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x020002EE RID: 750
	[Serializable]
	internal class PersistentCallGroup
	{
		// Token: 0x060022B5 RID: 8885 RVA: 0x0000E2E3 File Offset: 0x0000C4E3
		public PersistentCallGroup()
		{
			this.m_Calls = new List<PersistentCall>();
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x0000E2F6 File Offset: 0x0000C4F6
		public int Count
		{
			get
			{
				return this.m_Calls.Count;
			}
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x0000E303 File Offset: 0x0000C503
		public PersistentCall GetListener(int index)
		{
			return this.m_Calls[index];
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0000E311 File Offset: 0x0000C511
		public IEnumerable<PersistentCall> GetListeners()
		{
			return this.m_Calls;
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x0000E319 File Offset: 0x0000C519
		public void AddListener()
		{
			this.m_Calls.Add(new PersistentCall());
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x0000E32B File Offset: 0x0000C52B
		public void AddListener(PersistentCall call)
		{
			this.m_Calls.Add(call);
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x0000E339 File Offset: 0x0000C539
		public void RemoveListener(int index)
		{
			this.m_Calls.RemoveAt(index);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x0000E347 File Offset: 0x0000C547
		public void Clear()
		{
			this.m_Calls.Clear();
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x0002D540 File Offset: 0x0002B740
		public void RegisterEventPersistentListener(int index, Object targetObj, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, methodName);
			listener.mode = PersistentListenerMode.EventDefined;
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x0002D564 File Offset: 0x0002B764
		public void RegisterVoidPersistentListener(int index, Object targetObj, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, methodName);
			listener.mode = PersistentListenerMode.Void;
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x0002D588 File Offset: 0x0002B788
		public void RegisterObjectPersistentListener(int index, Object targetObj, Object argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, methodName);
			listener.mode = PersistentListenerMode.Object;
			listener.arguments.unityObjectArgument = argument;
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x0002D5BC File Offset: 0x0002B7BC
		public void RegisterIntPersistentListener(int index, Object targetObj, int argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, methodName);
			listener.mode = PersistentListenerMode.Int;
			listener.arguments.intArgument = argument;
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x0002D5F0 File Offset: 0x0002B7F0
		public void RegisterFloatPersistentListener(int index, Object targetObj, float argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, methodName);
			listener.mode = PersistentListenerMode.Float;
			listener.arguments.floatArgument = argument;
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x0002D624 File Offset: 0x0002B824
		public void RegisterStringPersistentListener(int index, Object targetObj, string argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, methodName);
			listener.mode = PersistentListenerMode.String;
			listener.arguments.stringArgument = argument;
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x0002D658 File Offset: 0x0002B858
		public void RegisterBoolPersistentListener(int index, Object targetObj, bool argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, methodName);
			listener.mode = PersistentListenerMode.Bool;
			listener.arguments.boolArgument = argument;
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x0002D68C File Offset: 0x0002B88C
		public void UnregisterPersistentListener(int index)
		{
			PersistentCall listener = this.GetListener(index);
			listener.UnregisterPersistentListener();
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x0002D6A8 File Offset: 0x0002B8A8
		public void RemoveListeners(Object target, string methodName)
		{
			List<PersistentCall> list = new List<PersistentCall>();
			for (int i = 0; i < this.m_Calls.Count; i++)
			{
				if (this.m_Calls[i].target == target && this.m_Calls[i].methodName == methodName)
				{
					list.Add(this.m_Calls[i]);
				}
			}
			this.m_Calls.RemoveAll(new Predicate<PersistentCall>(list.Contains));
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x0002D73C File Offset: 0x0002B93C
		public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase)
		{
			foreach (PersistentCall persistentCall in this.m_Calls)
			{
				if (persistentCall.IsValid())
				{
					BaseInvokableCall runtimeCall = persistentCall.GetRuntimeCall(unityEventBase);
					if (runtimeCall != null)
					{
						invokableList.AddPersistentInvokableCall(runtimeCall);
					}
				}
			}
		}

		// Token: 0x04000B91 RID: 2961
		[FormerlySerializedAs("m_Listeners")]
		[SerializeField]
		private List<PersistentCall> m_Calls;
	}
}
