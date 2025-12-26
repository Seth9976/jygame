using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Mono.Security.Authenticode;

namespace System.Net
{
	// Token: 0x02000312 RID: 786
	internal sealed class EndPointListener
	{
		// Token: 0x06001AA4 RID: 6820 RVA: 0x0004F710 File Offset: 0x0004D910
		public EndPointListener(IPAddress addr, int port, bool secure)
		{
			if (secure)
			{
				this.secure = secure;
				this.LoadCertificateAndKey(addr, port);
			}
			this.endpoint = new IPEndPoint(addr, port);
			this.sock = new global::System.Net.Sockets.Socket(addr.AddressFamily, global::System.Net.Sockets.SocketType.Stream, global::System.Net.Sockets.ProtocolType.Tcp);
			this.sock.Bind(this.endpoint);
			this.sock.Listen(500);
			this.sock.BeginAccept(new AsyncCallback(EndPointListener.OnAccept), this);
			this.prefixes = new Hashtable();
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0004F7A0 File Offset: 0x0004D9A0
		private void LoadCertificateAndKey(IPAddress addr, int port)
		{
			try
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				string text = Path.Combine(folderPath, ".mono");
				text = Path.Combine(text, "httplistener");
				string text2 = Path.Combine(text, string.Format("{0}.cer", port));
				string text3 = Path.Combine(text, string.Format("{0}.pvk", port));
				this.cert = new global::System.Security.Cryptography.X509Certificates.X509Certificate2(text2);
				this.key = PrivateKey.CreateFromFile(text3).RSA;
			}
			catch
			{
			}
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0004F834 File Offset: 0x0004DA34
		private static void OnAccept(IAsyncResult ares)
		{
			EndPointListener endPointListener = (EndPointListener)ares.AsyncState;
			global::System.Net.Sockets.Socket socket = null;
			try
			{
				socket = endPointListener.sock.EndAccept(ares);
			}
			catch
			{
			}
			finally
			{
				try
				{
					endPointListener.sock.BeginAccept(new AsyncCallback(EndPointListener.OnAccept), endPointListener);
				}
				catch
				{
					if (socket != null)
					{
						try
						{
							socket.Close();
						}
						catch
						{
						}
						socket = null;
					}
				}
			}
			if (socket == null)
			{
				return;
			}
			if (endPointListener.secure && (endPointListener.cert == null || endPointListener.key == null))
			{
				socket.Close();
				return;
			}
			HttpConnection httpConnection = new HttpConnection(socket, endPointListener, endPointListener.secure, endPointListener.cert, endPointListener.key);
			httpConnection.BeginReadRequest();
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x0004F928 File Offset: 0x0004DB28
		public bool BindContext(HttpListenerContext context)
		{
			HttpListenerRequest request = context.Request;
			ListenerPrefix listenerPrefix;
			HttpListener httpListener = this.SearchListener(request.UserHostName, request.Url, out listenerPrefix);
			if (httpListener == null)
			{
				return false;
			}
			context.Listener = httpListener;
			context.Connection.Prefix = listenerPrefix;
			httpListener.RegisterContext(context);
			return true;
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x0004F974 File Offset: 0x0004DB74
		public void UnbindContext(HttpListenerContext context)
		{
			if (context == null || context.Request == null)
			{
				return;
			}
			HttpListenerRequest request = context.Request;
			ListenerPrefix listenerPrefix;
			HttpListener httpListener = this.SearchListener(request.UserHostName, request.Url, out listenerPrefix);
			if (httpListener != null)
			{
				httpListener.UnregisterContext(context);
			}
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0004F9BC File Offset: 0x0004DBBC
		private HttpListener SearchListener(string host, global::System.Uri uri, out ListenerPrefix prefix)
		{
			prefix = null;
			if (uri == null)
			{
				return null;
			}
			if (host != null)
			{
				int num = host.IndexOf(':');
				if (num >= 0)
				{
					host = host.Substring(0, num);
				}
			}
			string text = HttpUtility.UrlDecode(uri.AbsolutePath);
			string text2 = ((text[text.Length - 1] != '/') ? (text + "/") : text);
			HttpListener httpListener = null;
			int num2 = -1;
			Hashtable hashtable = this.prefixes;
			lock (hashtable)
			{
				if (host != null && host != string.Empty)
				{
					foreach (object obj in this.prefixes.Keys)
					{
						ListenerPrefix listenerPrefix = (ListenerPrefix)obj;
						string path = listenerPrefix.Path;
						if (path.Length >= num2)
						{
							if (listenerPrefix.Host == host && (text.StartsWith(path) || text2.StartsWith(path)))
							{
								num2 = path.Length;
								httpListener = (HttpListener)this.prefixes[listenerPrefix];
								prefix = listenerPrefix;
							}
						}
					}
					if (num2 != -1)
					{
						return httpListener;
					}
				}
				httpListener = this.MatchFromList(host, text, this.unhandled, out prefix);
				if (httpListener != null)
				{
					return httpListener;
				}
				httpListener = this.MatchFromList(host, text, this.all, out prefix);
				if (httpListener != null)
				{
					return httpListener;
				}
			}
			return null;
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x0004FB9C File Offset: 0x0004DD9C
		private HttpListener MatchFromList(string host, string path, ArrayList list, out ListenerPrefix prefix)
		{
			prefix = null;
			if (list == null)
			{
				return null;
			}
			HttpListener httpListener = null;
			int num = -1;
			foreach (object obj in list)
			{
				ListenerPrefix listenerPrefix = (ListenerPrefix)obj;
				string path2 = listenerPrefix.Path;
				if (path2.Length >= num)
				{
					if (path.StartsWith(path2))
					{
						num = path2.Length;
						httpListener = listenerPrefix.Listener;
						prefix = listenerPrefix;
					}
				}
			}
			return httpListener;
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0004FC44 File Offset: 0x0004DE44
		private void AddSpecial(ArrayList coll, ListenerPrefix prefix)
		{
			if (coll == null)
			{
				return;
			}
			foreach (object obj in coll)
			{
				ListenerPrefix listenerPrefix = (ListenerPrefix)obj;
				if (listenerPrefix.Path == prefix.Path)
				{
					throw new HttpListenerException(400, "Prefix already in use.");
				}
			}
			coll.Add(prefix);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0004FCD0 File Offset: 0x0004DED0
		private void RemoveSpecial(ArrayList coll, ListenerPrefix prefix)
		{
			if (coll == null)
			{
				return;
			}
			int count = coll.Count;
			for (int i = 0; i < count; i++)
			{
				ListenerPrefix listenerPrefix = (ListenerPrefix)coll[i];
				if (listenerPrefix.Path == prefix.Path)
				{
					coll.RemoveAt(i);
					this.CheckIfRemove();
					return;
				}
			}
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0004FD30 File Offset: 0x0004DF30
		private void CheckIfRemove()
		{
			if (this.prefixes.Count > 0)
			{
				return;
			}
			if (this.unhandled != null && this.unhandled.Count > 0)
			{
				return;
			}
			if (this.all != null && this.all.Count > 0)
			{
				return;
			}
			EndPointManager.RemoveEndPoint(this, this.endpoint);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0001392E File Offset: 0x00011B2E
		public void Close()
		{
			this.sock.Close();
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0004FD98 File Offset: 0x0004DF98
		public void AddPrefix(ListenerPrefix prefix, HttpListener listener)
		{
			Hashtable hashtable = this.prefixes;
			lock (hashtable)
			{
				if (prefix.Host == "*")
				{
					if (this.unhandled == null)
					{
						this.unhandled = new ArrayList();
					}
					prefix.Listener = listener;
					this.AddSpecial(this.unhandled, prefix);
				}
				else if (prefix.Host == "+")
				{
					if (this.all == null)
					{
						this.all = new ArrayList();
					}
					prefix.Listener = listener;
					this.AddSpecial(this.all, prefix);
				}
				else if (this.prefixes.ContainsKey(prefix))
				{
					HttpListener httpListener = (HttpListener)this.prefixes[prefix];
					if (httpListener != listener)
					{
						throw new HttpListenerException(400, "There's another listener for " + prefix);
					}
				}
				else
				{
					this.prefixes[prefix] = listener;
				}
			}
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0004FEA8 File Offset: 0x0004E0A8
		public void RemovePrefix(ListenerPrefix prefix, HttpListener listener)
		{
			Hashtable hashtable = this.prefixes;
			lock (hashtable)
			{
				if (prefix.Host == "*")
				{
					this.RemoveSpecial(this.unhandled, prefix);
				}
				else if (prefix.Host == "+")
				{
					this.RemoveSpecial(this.all, prefix);
				}
				else if (this.prefixes.ContainsKey(prefix))
				{
					this.prefixes.Remove(prefix);
					this.CheckIfRemove();
				}
			}
		}

		// Token: 0x04001060 RID: 4192
		private IPEndPoint endpoint;

		// Token: 0x04001061 RID: 4193
		private global::System.Net.Sockets.Socket sock;

		// Token: 0x04001062 RID: 4194
		private Hashtable prefixes;

		// Token: 0x04001063 RID: 4195
		private ArrayList unhandled;

		// Token: 0x04001064 RID: 4196
		private ArrayList all;

		// Token: 0x04001065 RID: 4197
		private global::System.Security.Cryptography.X509Certificates.X509Certificate2 cert;

		// Token: 0x04001066 RID: 4198
		private AsymmetricAlgorithm key;

		// Token: 0x04001067 RID: 4199
		private bool secure;
	}
}
