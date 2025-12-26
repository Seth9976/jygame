using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net
{
	/// <summary>Specifies permission to access Internet resources. This class cannot be inherited.</summary>
	// Token: 0x02000436 RID: 1078
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class WebPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebPermissionAttribute" /> class with a value that specifies the security actions that can be performed on this class.</summary>
		/// <param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="action" /> is not a valid <see cref="T:System.Security.Permissions.SecurityAction" /> value. </exception>
		// Token: 0x0600265C RID: 9820 RVA: 0x0001388B File Offset: 0x00011A8B
		public WebPermissionAttribute(SecurityAction action)
			: base(action)
		{
		}

		/// <summary>Gets or sets the URI string accepted by the current <see cref="T:System.Net.WebPermissionAttribute" />.</summary>
		/// <returns>A string containing the URI accepted by the current <see cref="T:System.Net.WebPermissionAttribute" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Net.WebPermissionAttribute.Accept" /> is not null when you attempt to set the value. If you wish to specify more than one Accept URI, use an additional attribute declaration statement. </exception>
		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x0001AE04 File Offset: 0x00019004
		// (set) Token: 0x0600265E RID: 9822 RVA: 0x0001AE23 File Offset: 0x00019023
		public string Accept
		{
			get
			{
				if (this.m_accept == null)
				{
					return null;
				}
				return (this.m_accept as WebPermissionInfo).Info;
			}
			set
			{
				if (this.m_accept != null)
				{
					this.AlreadySet("Accept", "Accept");
				}
				this.m_accept = new WebPermissionInfo(WebPermissionInfoType.InfoString, value);
			}
		}

		/// <summary>Gets or sets a regular expression pattern that describes the URI accepted by the current <see cref="T:System.Net.WebPermissionAttribute" />.</summary>
		/// <returns>A string containing a regular expression pattern that describes the URI accepted by the current <see cref="T:System.Net.WebPermissionAttribute" />. This string must be escaped according to the rules for encoding a <see cref="T:System.Text.RegularExpressions.Regex" /> constructor string.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Net.WebPermissionAttribute.AcceptPattern" /> is not null when you attempt to set the value. If you wish to specify more than one Accept URI, use an additional attribute declaration statement. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x0001AE04 File Offset: 0x00019004
		// (set) Token: 0x06002660 RID: 9824 RVA: 0x0001AE4D File Offset: 0x0001904D
		public string AcceptPattern
		{
			get
			{
				if (this.m_accept == null)
				{
					return null;
				}
				return (this.m_accept as WebPermissionInfo).Info;
			}
			set
			{
				if (this.m_accept != null)
				{
					this.AlreadySet("Accept", "AcceptPattern");
				}
				if (value == null)
				{
					throw new ArgumentNullException("AcceptPattern");
				}
				this.m_accept = new WebPermissionInfo(WebPermissionInfoType.InfoUnexecutedRegex, value);
			}
		}

		/// <summary>Gets or sets the URI connection string controlled by the current <see cref="T:System.Net.WebPermissionAttribute" />.</summary>
		/// <returns>A string containing the URI connection controlled by the current <see cref="T:System.Net.WebPermissionAttribute" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Net.WebPermissionAttribute.Connect" /> is not null when you attempt to set the value. If you wish to specify more than one Connect URI, use an additional attribute declaration statement. </exception>
		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x0001AE88 File Offset: 0x00019088
		// (set) Token: 0x06002662 RID: 9826 RVA: 0x0001AEA7 File Offset: 0x000190A7
		public string Connect
		{
			get
			{
				if (this.m_connect == null)
				{
					return null;
				}
				return (this.m_connect as WebPermissionInfo).Info;
			}
			set
			{
				if (this.m_connect != null)
				{
					this.AlreadySet("Connect", "Connect");
				}
				this.m_connect = new WebPermissionInfo(WebPermissionInfoType.InfoString, value);
			}
		}

		/// <summary>Gets or sets a regular expression pattern that describes the URI connection controlled by the current <see cref="T:System.Net.WebPermissionAttribute" />.</summary>
		/// <returns>A string containing a regular expression pattern that describes the URI connection controlled by this <see cref="T:System.Net.WebPermissionAttribute" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Net.WebPermissionAttribute.ConnectPattern" /> is not null when you attempt to set the value. If you wish to specify more than one connect URI, use an additional attribute declaration statement. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002663 RID: 9827 RVA: 0x0001AE88 File Offset: 0x00019088
		// (set) Token: 0x06002664 RID: 9828 RVA: 0x0001AED1 File Offset: 0x000190D1
		public string ConnectPattern
		{
			get
			{
				if (this.m_connect == null)
				{
					return null;
				}
				return (this.m_connect as WebPermissionInfo).Info;
			}
			set
			{
				if (this.m_connect != null)
				{
					this.AlreadySet("Connect", "ConnectConnectPattern");
				}
				if (value == null)
				{
					throw new ArgumentNullException("ConnectPattern");
				}
				this.m_connect = new WebPermissionInfo(WebPermissionInfoType.InfoUnexecutedRegex, value);
			}
		}

		/// <summary>Creates and returns a new instance of the <see cref="T:System.Net.WebPermission" /> class.</summary>
		/// <returns>A <see cref="T:System.Net.WebPermission" /> corresponding to the security declaration.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x06002665 RID: 9829 RVA: 0x000728AC File Offset: 0x00070AAC
		public override IPermission CreatePermission()
		{
			if (base.Unrestricted)
			{
				return new WebPermission(PermissionState.Unrestricted);
			}
			WebPermission webPermission = new WebPermission();
			if (this.m_accept != null)
			{
				webPermission.AddPermission(NetworkAccess.Accept, (WebPermissionInfo)this.m_accept);
			}
			if (this.m_connect != null)
			{
				webPermission.AddPermission(NetworkAccess.Connect, (WebPermissionInfo)this.m_connect);
			}
			return webPermission;
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00072914 File Offset: 0x00070B14
		internal void AlreadySet(string parameter, string property)
		{
			string text = global::Locale.GetText("The parameter '{0}' can be set only once.");
			throw new ArgumentException(string.Format(text, parameter), property);
		}

		// Token: 0x0400178E RID: 6030
		private object m_accept;

		// Token: 0x0400178F RID: 6031
		private object m_connect;
	}
}
