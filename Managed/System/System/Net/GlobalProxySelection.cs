using System;

namespace System.Net
{
	/// <summary>Contains a global default proxy instance for all HTTP requests.</summary>
	// Token: 0x02000325 RID: 805
	[Obsolete("Use WebRequest.DefaultProxy instead")]
	public class GlobalProxySelection
	{
		/// <summary>Gets or sets the global HTTP proxy.</summary>
		/// <returns>An <see cref="T:System.Net.IWebProxy" /> that every call to <see cref="M:System.Net.HttpWebRequest.GetResponse" /> uses.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value specified for a set operation was null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have permission for the requested operation. </exception>
		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x00014168 File Offset: 0x00012368
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x0001416F File Offset: 0x0001236F
		public static IWebProxy Select
		{
			get
			{
				return WebRequest.DefaultWebProxy;
			}
			set
			{
				WebRequest.DefaultWebProxy = value;
			}
		}

		/// <summary>Returns an empty proxy instance.</summary>
		/// <returns>An <see cref="T:System.Net.IWebProxy" /> that contains no information.</returns>
		// Token: 0x06001BB3 RID: 7091 RVA: 0x00014177 File Offset: 0x00012377
		public static IWebProxy GetEmptyWebProxy()
		{
			return new GlobalProxySelection.EmptyWebProxy();
		}

		// Token: 0x02000326 RID: 806
		internal class EmptyWebProxy : IWebProxy
		{
			// Token: 0x06001BB4 RID: 7092 RVA: 0x000021C3 File Offset: 0x000003C3
			internal EmptyWebProxy()
			{
			}

			// Token: 0x170006A7 RID: 1703
			// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x0001417E File Offset: 0x0001237E
			// (set) Token: 0x06001BB6 RID: 7094 RVA: 0x00014186 File Offset: 0x00012386
			public ICredentials Credentials
			{
				get
				{
					return this.credentials;
				}
				set
				{
					this.credentials = value;
				}
			}

			// Token: 0x06001BB7 RID: 7095 RVA: 0x00009093 File Offset: 0x00007293
			public global::System.Uri GetProxy(global::System.Uri destination)
			{
				return destination;
			}

			// Token: 0x06001BB8 RID: 7096 RVA: 0x000025B7 File Offset: 0x000007B7
			public bool IsBypassed(global::System.Uri host)
			{
				return true;
			}

			// Token: 0x040010FD RID: 4349
			private ICredentials credentials;
		}
	}
}
