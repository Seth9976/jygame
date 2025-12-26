using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	// Token: 0x02000045 RID: 69
	internal class NetworkMessageHandlers
	{
		// Token: 0x060002EC RID: 748 RVA: 0x0000E8D4 File Offset: 0x0000CAD4
		internal void RegisterHandlerSafe(short msgType, NetworkMessageDelegate handler)
		{
			if (handler == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("RegisterHandlerSafe id:" + msgType + " handler is null");
				}
				return;
			}
			if (LogFilter.logDebug)
			{
				Debug.Log(string.Concat(new object[]
				{
					"RegisterHandlerSafe id:",
					msgType,
					" handler:",
					handler.Method.Name
				}));
			}
			if (this.m_MsgHandlers.ContainsKey(msgType))
			{
				return;
			}
			this.m_MsgHandlers.Add(msgType, handler);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000E96C File Offset: 0x0000CB6C
		public void RegisterHandler(short msgType, NetworkMessageDelegate handler)
		{
			if (handler == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("RegisterHandler id:" + msgType + " handler is null");
				}
				return;
			}
			if (msgType <= 31)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("RegisterHandler: Cannot replace system message handler " + msgType);
				}
				return;
			}
			if (this.m_MsgHandlers.ContainsKey(msgType))
			{
				if (LogFilter.logDebug)
				{
					Debug.Log("RegisterHandler replacing " + msgType);
				}
				this.m_MsgHandlers.Remove(msgType);
			}
			if (LogFilter.logDebug)
			{
				Debug.Log(string.Concat(new object[]
				{
					"RegisterHandler id:",
					msgType,
					" handler:",
					handler.Method.Name
				}));
			}
			this.m_MsgHandlers.Add(msgType, handler);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000EA58 File Offset: 0x0000CC58
		public void UnregisterHandler(short msgType)
		{
			this.m_MsgHandlers.Remove(msgType);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000EA68 File Offset: 0x0000CC68
		internal NetworkMessageDelegate GetHandler(short msgType)
		{
			if (this.m_MsgHandlers.ContainsKey(msgType))
			{
				return this.m_MsgHandlers[msgType];
			}
			return null;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000EA8C File Offset: 0x0000CC8C
		internal Dictionary<short, NetworkMessageDelegate> GetHandlers()
		{
			return this.m_MsgHandlers;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000EA94 File Offset: 0x0000CC94
		internal void ClearMessageHandlers()
		{
			this.m_MsgHandlers.Clear();
		}

		// Token: 0x04000157 RID: 343
		private Dictionary<short, NetworkMessageDelegate> m_MsgHandlers = new Dictionary<short, NetworkMessageDelegate>();
	}
}
