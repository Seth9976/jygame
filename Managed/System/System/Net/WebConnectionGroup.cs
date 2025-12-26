using System;
using System.Collections;

namespace System.Net
{
	// Token: 0x02000431 RID: 1073
	internal class WebConnectionGroup
	{
		// Token: 0x060025EB RID: 9707 RVA: 0x0001A9DA File Offset: 0x00018BDA
		public WebConnectionGroup(ServicePoint sPoint, string name)
		{
			this.sPoint = sPoint;
			this.name = name;
			this.connections = new ArrayList(1);
			this.queue = new Queue();
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x00070498 File Offset: 0x0006E698
		public void Close()
		{
			ArrayList arrayList = this.connections;
			lock (arrayList)
			{
				int count = this.connections.Count;
				for (int i = 0; i < count; i++)
				{
					WeakReference weakReference = (WeakReference)this.connections[i];
					WebConnection webConnection = weakReference.Target as WebConnection;
					if (webConnection != null)
					{
						webConnection.Close(false);
					}
				}
				this.connections.Clear();
			}
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x00070530 File Offset: 0x0006E730
		public WebConnection GetConnection(HttpWebRequest request)
		{
			WebConnection webConnection = null;
			ArrayList arrayList = this.connections;
			lock (arrayList)
			{
				int count = this.connections.Count;
				ArrayList arrayList2 = null;
				for (int i = 0; i < count; i++)
				{
					WeakReference weakReference = (WeakReference)this.connections[i];
					webConnection = weakReference.Target as WebConnection;
					if (webConnection == null)
					{
						if (arrayList2 == null)
						{
							arrayList2 = new ArrayList(1);
						}
						arrayList2.Add(i);
					}
				}
				if (arrayList2 != null)
				{
					for (int j = arrayList2.Count - 1; j >= 0; j--)
					{
						this.connections.RemoveAt((int)arrayList2[j]);
					}
				}
				webConnection = this.CreateOrReuseConnection(request);
			}
			return webConnection;
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x0007061C File Offset: 0x0006E81C
		private static void PrepareSharingNtlm(WebConnection cnc, HttpWebRequest request)
		{
			if (!cnc.NtlmAuthenticated)
			{
				return;
			}
			bool flag = false;
			NetworkCredential ntlmCredential = cnc.NtlmCredential;
			NetworkCredential credential = request.Credentials.GetCredential(request.RequestUri, "NTLM");
			if (ntlmCredential.Domain != credential.Domain || ntlmCredential.UserName != credential.UserName || ntlmCredential.Password != credential.Password)
			{
				flag = true;
			}
			if (!flag)
			{
				bool unsafeAuthenticatedConnectionSharing = request.UnsafeAuthenticatedConnectionSharing;
				bool unsafeAuthenticatedConnectionSharing2 = cnc.UnsafeAuthenticatedConnectionSharing;
				flag = !unsafeAuthenticatedConnectionSharing || unsafeAuthenticatedConnectionSharing != unsafeAuthenticatedConnectionSharing2;
			}
			if (flag)
			{
				cnc.Close(false);
				cnc.ResetNtlm();
			}
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x000706D4 File Offset: 0x0006E8D4
		private WebConnection CreateOrReuseConnection(HttpWebRequest request)
		{
			int num = this.connections.Count;
			WebConnection webConnection;
			for (int i = 0; i < num; i++)
			{
				WeakReference weakReference = this.connections[i] as WeakReference;
				webConnection = weakReference.Target as WebConnection;
				if (webConnection == null)
				{
					this.connections.RemoveAt(i);
					num--;
					i--;
				}
				else if (!webConnection.Busy)
				{
					WebConnectionGroup.PrepareSharingNtlm(webConnection, request);
					return webConnection;
				}
			}
			if (this.sPoint.ConnectionLimit > num)
			{
				webConnection = new WebConnection(this, this.sPoint);
				this.connections.Add(new WeakReference(webConnection));
				return webConnection;
			}
			if (this.rnd == null)
			{
				this.rnd = new Random();
			}
			int num2 = ((num <= 1) ? 0 : this.rnd.Next(0, num - 1));
			WeakReference weakReference2 = (WeakReference)this.connections[num2];
			webConnection = weakReference2.Target as WebConnection;
			if (webConnection == null)
			{
				webConnection = new WebConnection(this, this.sPoint);
				this.connections.RemoveAt(num2);
				this.connections.Add(new WeakReference(webConnection));
			}
			return webConnection;
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x0001AA07 File Offset: 0x00018C07
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x0001AA0F File Offset: 0x00018C0F
		internal Queue Queue
		{
			get
			{
				return this.queue;
			}
		}

		// Token: 0x04001751 RID: 5969
		private ServicePoint sPoint;

		// Token: 0x04001752 RID: 5970
		private string name;

		// Token: 0x04001753 RID: 5971
		private ArrayList connections;

		// Token: 0x04001754 RID: 5972
		private Random rnd;

		// Token: 0x04001755 RID: 5973
		private Queue queue;
	}
}
