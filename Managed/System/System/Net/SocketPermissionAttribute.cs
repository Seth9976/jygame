using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net
{
	/// <summary>Specifies security actions to control <see cref="T:System.Net.Sockets.Socket" /> connections. This class cannot be inherited.</summary>
	// Token: 0x02000403 RID: 1027
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class SocketPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.SocketPermissionAttribute" /> class with the specified <see cref="T:System.Security.Permissions.SecurityAction" /> value.</summary>
		/// <param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="action" /> is not a valid <see cref="T:System.Security.Permissions.SecurityAction" /> value. </exception>
		// Token: 0x06002313 RID: 8979 RVA: 0x0001388B File Offset: 0x00011A8B
		public SocketPermissionAttribute(SecurityAction action)
			: base(action)
		{
		}

		/// <summary>Gets or sets the network access method that is allowed by this <see cref="T:System.Net.SocketPermissionAttribute" />.</summary>
		/// <returns>A string that contains the network access method that is allowed by this instance of <see cref="T:System.Net.SocketPermissionAttribute" />. Valid values are "Accept" and "Connect." </returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Net.SocketPermissionAttribute.Access" /> property is not null when you attempt to set the value. To specify more than one Access method, use an additional attribute declaration statement. </exception>
		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x00018C20 File Offset: 0x00016E20
		// (set) Token: 0x06002315 RID: 8981 RVA: 0x00018C28 File Offset: 0x00016E28
		public string Access
		{
			get
			{
				return this.m_access;
			}
			set
			{
				if (this.m_access != null)
				{
					this.AlreadySet("Access");
				}
				this.m_access = value;
			}
		}

		/// <summary>Gets or sets the DNS host name or IP address that is specified by this <see cref="T:System.Net.SocketPermissionAttribute" />.</summary>
		/// <returns>A string that contains the DNS host name or IP address that is associated with this instance of <see cref="T:System.Net.SocketPermissionAttribute" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Net.SocketPermissionAttribute.Host" /> is not null when you attempt to set the value. To specify more than one host, use an additional attribute declaration statement. </exception>
		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x00018C47 File Offset: 0x00016E47
		// (set) Token: 0x06002317 RID: 8983 RVA: 0x00018C4F File Offset: 0x00016E4F
		public string Host
		{
			get
			{
				return this.m_host;
			}
			set
			{
				if (this.m_host != null)
				{
					this.AlreadySet("Host");
				}
				this.m_host = value;
			}
		}

		/// <summary>Gets or sets the port number that is associated with this <see cref="T:System.Net.SocketPermissionAttribute" />.</summary>
		/// <returns>A string that contains the port number that is associated with this instance of <see cref="T:System.Net.SocketPermissionAttribute" />.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Net.SocketPermissionAttribute.Port" /> property is null when you attempt to set the value. To specify more than one port, use an additional attribute declaration statement. </exception>
		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x00018C6E File Offset: 0x00016E6E
		// (set) Token: 0x06002319 RID: 8985 RVA: 0x00018C76 File Offset: 0x00016E76
		public string Port
		{
			get
			{
				return this.m_port;
			}
			set
			{
				if (this.m_port != null)
				{
					this.AlreadySet("Port");
				}
				this.m_port = value;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Net.TransportType" /> that is specified by this <see cref="T:System.Net.SocketPermissionAttribute" />.</summary>
		/// <returns>A string that contains the <see cref="T:System.Net.TransportType" /> that is associated with this <see cref="T:System.Net.SocketPermissionAttribute" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Net.SocketPermissionAttribute.Transport" /> is not null when you attempt to set the value. To specify more than one transport type, use an additional attribute declaration statement. </exception>
		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x00018C95 File Offset: 0x00016E95
		// (set) Token: 0x0600231B RID: 8987 RVA: 0x00018C9D File Offset: 0x00016E9D
		public string Transport
		{
			get
			{
				return this.m_transport;
			}
			set
			{
				if (this.m_transport != null)
				{
					this.AlreadySet("Transport");
				}
				this.m_transport = value;
			}
		}

		/// <summary>Creates and returns a new instance of the <see cref="T:System.Net.SocketPermission" /> class.</summary>
		/// <returns>An instance of the <see cref="T:System.Net.SocketPermission" /> class that corresponds to the security declaration.</returns>
		/// <exception cref="T:System.ArgumentException">One or more of the current instance's <see cref="P:System.Net.SocketPermissionAttribute.Access" />, <see cref="P:System.Net.SocketPermissionAttribute.Host" />, <see cref="P:System.Net.SocketPermissionAttribute.Transport" />, or <see cref="P:System.Net.SocketPermissionAttribute.Port" /> properties is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x0600231C RID: 8988 RVA: 0x00064EE0 File Offset: 0x000630E0
		public override IPermission CreatePermission()
		{
			if (base.Unrestricted)
			{
				return new SocketPermission(PermissionState.Unrestricted);
			}
			string text = string.Empty;
			if (this.m_access == null)
			{
				text += "Access, ";
			}
			if (this.m_host == null)
			{
				text += "Host, ";
			}
			if (this.m_port == null)
			{
				text += "Port, ";
			}
			if (this.m_transport == null)
			{
				text += "Transport, ";
			}
			if (text.Length > 0)
			{
				string text2 = global::Locale.GetText("The value(s) for {0} must be specified.");
				text = text.Substring(0, text.Length - 2);
				throw new ArgumentException(string.Format(text2, text));
			}
			int num = -1;
			NetworkAccess networkAccess;
			if (string.Compare(this.m_access, "Connect", true) == 0)
			{
				networkAccess = NetworkAccess.Connect;
			}
			else
			{
				if (string.Compare(this.m_access, "Accept", true) != 0)
				{
					string text3 = global::Locale.GetText("The parameter value for 'Access', '{1}, is invalid.");
					throw new ArgumentException(string.Format(text3, this.m_access));
				}
				networkAccess = NetworkAccess.Accept;
			}
			if (string.Compare(this.m_port, "All", true) != 0)
			{
				try
				{
					num = int.Parse(this.m_port);
				}
				catch
				{
					string text4 = global::Locale.GetText("The parameter value for 'Port', '{1}, is invalid.");
					throw new ArgumentException(string.Format(text4, this.m_port));
				}
				new IPEndPoint(1L, num);
			}
			TransportType transportType;
			try
			{
				transportType = (TransportType)((int)Enum.Parse(typeof(TransportType), this.m_transport, true));
			}
			catch
			{
				string text5 = global::Locale.GetText("The parameter value for 'Transport', '{1}, is invalid.");
				throw new ArgumentException(string.Format(text5, this.m_transport));
			}
			SocketPermission socketPermission = new SocketPermission(PermissionState.None);
			socketPermission.AddPermission(networkAccess, transportType, this.m_host, num);
			return socketPermission;
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x000650CC File Offset: 0x000632CC
		internal void AlreadySet(string property)
		{
			string text = global::Locale.GetText("The parameter '{0}' can be set only once.");
			throw new ArgumentException(string.Format(text, property), property);
		}

		// Token: 0x04001553 RID: 5459
		private string m_access;

		// Token: 0x04001554 RID: 5460
		private string m_host;

		// Token: 0x04001555 RID: 5461
		private string m_port;

		// Token: 0x04001556 RID: 5462
		private string m_transport;
	}
}
