using System;
using System.Collections;

namespace System.Net
{
	// Token: 0x02000313 RID: 787
	internal sealed class EndPointManager
	{
		// Token: 0x06001AB1 RID: 6833 RVA: 0x000021C3 File Offset: 0x000003C3
		private EndPointManager()
		{
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0004FF50 File Offset: 0x0004E150
		public static void AddListener(HttpListener listener)
		{
			ArrayList arrayList = new ArrayList();
			try
			{
				Hashtable hashtable = EndPointManager.ip_to_endpoints;
				lock (hashtable)
				{
					foreach (string text in listener.Prefixes)
					{
						EndPointManager.AddPrefixInternal(text, listener);
						arrayList.Add(text);
					}
				}
			}
			catch
			{
				foreach (object obj in arrayList)
				{
					string text2 = (string)obj;
					EndPointManager.RemovePrefix(text2, listener);
				}
				throw;
			}
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x00050048 File Offset: 0x0004E248
		public static void AddPrefix(string prefix, HttpListener listener)
		{
			Hashtable hashtable = EndPointManager.ip_to_endpoints;
			lock (hashtable)
			{
				EndPointManager.AddPrefixInternal(prefix, listener);
			}
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x00050084 File Offset: 0x0004E284
		private static void AddPrefixInternal(string p, HttpListener listener)
		{
			ListenerPrefix listenerPrefix = new ListenerPrefix(p);
			if (listenerPrefix.Path.IndexOf('%') != -1)
			{
				throw new HttpListenerException(400, "Invalid path.");
			}
			if (listenerPrefix.Path.IndexOf("//") != -1)
			{
				throw new HttpListenerException(400, "Invalid path.");
			}
			EndPointListener eplistener = EndPointManager.GetEPListener(IPAddress.Any, listenerPrefix.Port, listener, listenerPrefix.Secure);
			eplistener.AddPrefix(listenerPrefix, listener);
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00050104 File Offset: 0x0004E304
		private static EndPointListener GetEPListener(IPAddress addr, int port, HttpListener listener, bool secure)
		{
			Hashtable hashtable;
			if (EndPointManager.ip_to_endpoints.ContainsKey(addr))
			{
				hashtable = (Hashtable)EndPointManager.ip_to_endpoints[addr];
			}
			else
			{
				hashtable = new Hashtable();
				EndPointManager.ip_to_endpoints[addr] = hashtable;
			}
			EndPointListener endPointListener;
			if (hashtable.ContainsKey(port))
			{
				endPointListener = (EndPointListener)hashtable[port];
			}
			else
			{
				endPointListener = new EndPointListener(addr, port, secure);
				hashtable[port] = endPointListener;
			}
			return endPointListener;
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0005018C File Offset: 0x0004E38C
		public static void RemoveEndPoint(EndPointListener epl, IPEndPoint ep)
		{
			Hashtable hashtable = EndPointManager.ip_to_endpoints;
			lock (hashtable)
			{
				Hashtable hashtable2 = (Hashtable)EndPointManager.ip_to_endpoints[ep.Address];
				hashtable2.Remove(ep.Port);
				if (hashtable2.Count == 0)
				{
					EndPointManager.ip_to_endpoints.Remove(ep.Address);
				}
				epl.Close();
			}
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0005020C File Offset: 0x0004E40C
		public static void RemoveListener(HttpListener listener)
		{
			Hashtable hashtable = EndPointManager.ip_to_endpoints;
			lock (hashtable)
			{
				foreach (string text in listener.Prefixes)
				{
					EndPointManager.RemovePrefixInternal(text, listener);
				}
			}
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x00050288 File Offset: 0x0004E488
		public static void RemovePrefix(string prefix, HttpListener listener)
		{
			Hashtable hashtable = EndPointManager.ip_to_endpoints;
			lock (hashtable)
			{
				EndPointManager.RemovePrefixInternal(prefix, listener);
			}
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x000502C4 File Offset: 0x0004E4C4
		private static void RemovePrefixInternal(string prefix, HttpListener listener)
		{
			ListenerPrefix listenerPrefix = new ListenerPrefix(prefix);
			if (listenerPrefix.Path.IndexOf('%') != -1)
			{
				return;
			}
			if (listenerPrefix.Path.IndexOf("//") != -1)
			{
				return;
			}
			EndPointListener eplistener = EndPointManager.GetEPListener(IPAddress.Any, listenerPrefix.Port, listener, listenerPrefix.Secure);
			eplistener.RemovePrefix(listenerPrefix, listener);
		}

		// Token: 0x04001068 RID: 4200
		private static Hashtable ip_to_endpoints = new Hashtable();
	}
}
