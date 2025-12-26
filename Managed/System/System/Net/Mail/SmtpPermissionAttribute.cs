using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net.Mail
{
	/// <summary>Controls access to Simple Mail Transport Protocol (SMTP) servers.</summary>
	// Token: 0x02000363 RID: 867
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class SmtpPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Mail.SmtpPermissionAttribute" /> class. </summary>
		/// <param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values that specifies the permission behavior.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="action" /> is not a valid <see cref="T:System.Security.Permissions.SecurityAction" />.</exception>
		// Token: 0x06001E6D RID: 7789 RVA: 0x0001388B File Offset: 0x00011A8B
		public SmtpPermissionAttribute(SecurityAction action)
			: base(action)
		{
		}

		/// <summary>Gets or sets the level of access to SMTP servers controlled by the attribute.</summary>
		/// <returns>A <see cref="T:System.String" /> value. Valid values are "Connect" and "None".</returns>
		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x0001611D File Offset: 0x0001431D
		// (set) Token: 0x06001E6F RID: 7791 RVA: 0x00016125 File Offset: 0x00014325
		public string Access
		{
			get
			{
				return this.access;
			}
			set
			{
				this.access = value;
			}
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x0005EDC0 File Offset: 0x0005CFC0
		private SmtpAccess GetSmtpAccess()
		{
			if (this.access == null)
			{
				return SmtpAccess.None;
			}
			string text = this.access.ToLowerInvariant();
			switch (text)
			{
			case "connecttounrestrictedport":
				return SmtpAccess.ConnectToUnrestrictedPort;
			case "connect":
				return SmtpAccess.Connect;
			case "none":
				return SmtpAccess.None;
			}
			string text2 = global::Locale.GetText("Invalid Access='{0}' value.", new object[] { this.access });
			throw new ArgumentException("Access", text2);
		}

		/// <summary>Creates a permission object that can be stored with the <see cref="T:System.Security.Permissions.SecurityAction" /> in an assembly's metadata.</summary>
		/// <returns>An <see cref="T:System.Net.Mail.SmtpPermission" /> instance.</returns>
		// Token: 0x06001E71 RID: 7793 RVA: 0x0001612E File Offset: 0x0001432E
		public override IPermission CreatePermission()
		{
			if (base.Unrestricted)
			{
				return new SmtpPermission(true);
			}
			return new SmtpPermission(this.GetSmtpAccess());
		}

		// Token: 0x040012AC RID: 4780
		private string access;
	}
}
