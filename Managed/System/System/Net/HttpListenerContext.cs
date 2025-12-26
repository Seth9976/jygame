using System;
using System.Security.Principal;
using System.Text;

namespace System.Net
{
	/// <summary>Provides access to the request and response objects used by the <see cref="T:System.Net.HttpListener" /> class. This class cannot be inherited.</summary>
	// Token: 0x0200032B RID: 811
	public sealed class HttpListenerContext
	{
		// Token: 0x06001BD0 RID: 7120 RVA: 0x00014245 File Offset: 0x00012445
		internal HttpListenerContext(HttpConnection cnc)
		{
			this.cnc = cnc;
			this.request = new HttpListenerRequest(this);
			this.response = new HttpListenerResponse(this);
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x00014277 File Offset: 0x00012477
		// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x0001427F File Offset: 0x0001247F
		internal int ErrorStatus
		{
			get
			{
				return this.err_status;
			}
			set
			{
				this.err_status = value;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x00014288 File Offset: 0x00012488
		// (set) Token: 0x06001BD4 RID: 7124 RVA: 0x00014290 File Offset: 0x00012490
		internal string ErrorMessage
		{
			get
			{
				return this.error;
			}
			set
			{
				this.error = value;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x00014299 File Offset: 0x00012499
		internal bool HaveError
		{
			get
			{
				return this.error != null;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x000142A7 File Offset: 0x000124A7
		internal HttpConnection Connection
		{
			get
			{
				return this.cnc;
			}
		}

		/// <summary>Gets the <see cref="T:System.Net.HttpListenerRequest" /> that represents a client's request for a resource.</summary>
		/// <returns>An <see cref="T:System.Net.HttpListenerRequest" /> object that represents the client request.</returns>
		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x000142AF File Offset: 0x000124AF
		public HttpListenerRequest Request
		{
			get
			{
				return this.request;
			}
		}

		/// <summary>Gets the <see cref="T:System.Net.HttpListenerResponse" /> object that will be sent to the client in response to the client's request. </summary>
		/// <returns>An <see cref="T:System.Net.HttpListenerResponse" /> object used to send a response back to the client.</returns>
		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x000142B7 File Offset: 0x000124B7
		public HttpListenerResponse Response
		{
			get
			{
				return this.response;
			}
		}

		/// <summary>Gets an object used to obtain identity, authentication information, and security roles for the client whose request is represented by this <see cref="T:System.Net.HttpListenerContext" /> object. </summary>
		/// <returns>An <see cref="T:System.Security.Principal.IPrincipal" /> object that describes the client, or null if the <see cref="T:System.Net.HttpListener" /> that supplied this <see cref="T:System.Net.HttpListenerContext" /> does not require authentication.</returns>
		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x000142BF File Offset: 0x000124BF
		public IPrincipal User
		{
			get
			{
				return this.user;
			}
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x00053A14 File Offset: 0x00051C14
		internal void ParseAuthentication(AuthenticationSchemes expectedSchemes)
		{
			if (expectedSchemes == AuthenticationSchemes.Anonymous)
			{
				return;
			}
			string text = this.request.Headers["Authorization"];
			if (text == null || text.Length < 2)
			{
				return;
			}
			string[] array = text.Split(new char[] { ' ' }, 2);
			if (string.Compare(array[0], "basic", true) == 0)
			{
				this.user = this.ParseBasicAuthentication(array[1]);
			}
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x00053A8C File Offset: 0x00051C8C
		internal IPrincipal ParseBasicAuthentication(string authData)
		{
			IPrincipal principal;
			try
			{
				string text = Encoding.Default.GetString(Convert.FromBase64String(authData));
				int num = text.IndexOf(':');
				string text2 = text.Substring(num + 1);
				text = text.Substring(0, num);
				num = text.IndexOf('\\');
				string text3;
				if (num > 0)
				{
					text3 = text.Substring(num);
				}
				else
				{
					text3 = text;
				}
				HttpListenerBasicIdentity httpListenerBasicIdentity = new HttpListenerBasicIdentity(text3, text2);
				principal = new GenericPrincipal(httpListenerBasicIdentity, new string[0]);
			}
			catch (Exception)
			{
				principal = null;
			}
			return principal;
		}

		// Token: 0x04001119 RID: 4377
		private HttpListenerRequest request;

		// Token: 0x0400111A RID: 4378
		private HttpListenerResponse response;

		// Token: 0x0400111B RID: 4379
		private IPrincipal user;

		// Token: 0x0400111C RID: 4380
		private HttpConnection cnc;

		// Token: 0x0400111D RID: 4381
		private string error;

		// Token: 0x0400111E RID: 4382
		private int err_status = 400;

		// Token: 0x0400111F RID: 4383
		internal HttpListener Listener;
	}
}
