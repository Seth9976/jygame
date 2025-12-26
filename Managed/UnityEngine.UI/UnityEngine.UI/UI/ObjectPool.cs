using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	// Token: 0x0200009E RID: 158
	internal class ObjectPool<T> where T : new()
	{
		// Token: 0x0600058B RID: 1419 RVA: 0x00017E88 File Offset: 0x00016088
		public ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease)
		{
			this.m_ActionOnGet = actionOnGet;
			this.m_ActionOnRelease = actionOnRelease;
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00017EAC File Offset: 0x000160AC
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x00017EB4 File Offset: 0x000160B4
		public int countAll { get; private set; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00017EC0 File Offset: 0x000160C0
		public int countActive
		{
			get
			{
				return this.countAll - this.countInactive;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00017ED0 File Offset: 0x000160D0
		public int countInactive
		{
			get
			{
				return this.m_Stack.Count;
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00017EE0 File Offset: 0x000160E0
		public T Get()
		{
			T t;
			if (this.m_Stack.Count == 0)
			{
				t = ((default(T) == null) ? new T() : default(T));
				this.countAll++;
			}
			else
			{
				t = this.m_Stack.Pop();
			}
			if (this.m_ActionOnGet != null)
			{
				this.m_ActionOnGet(t);
			}
			return t;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00017F58 File Offset: 0x00016158
		public void Release(T element)
		{
			if (this.m_Stack.Count > 0 && object.ReferenceEquals(this.m_Stack.Peek(), element))
			{
				Debug.LogError("Internal error. Trying to destroy object that is already released to pool.");
			}
			if (this.m_ActionOnRelease != null)
			{
				this.m_ActionOnRelease(element);
			}
			this.m_Stack.Push(element);
		}

		// Token: 0x040002A2 RID: 674
		private readonly Stack<T> m_Stack = new Stack<T>();

		// Token: 0x040002A3 RID: 675
		private readonly UnityAction<T> m_ActionOnGet;

		// Token: 0x040002A4 RID: 676
		private readonly UnityAction<T> m_ActionOnRelease;
	}
}
