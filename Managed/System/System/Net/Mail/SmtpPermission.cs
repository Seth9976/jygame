using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net.Mail
{
	/// <summary>Controls access to Simple Mail Transport Protocol (SMTP) servers.</summary>
	// Token: 0x02000362 RID: 866
	[Serializable]
	public sealed class SmtpPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Mail.SmtpPermission" /> class with the specified state.</summary>
		/// <param name="unrestricted">true if the new permission is unrestricted; otherwise, false.</param>
		// Token: 0x06001E5F RID: 7775 RVA: 0x0001605A File Offset: 0x0001425A
		public SmtpPermission(bool unrestricted)
		{
			this.unrestricted = unrestricted;
			this.access = ((!unrestricted) ? SmtpAccess.None : SmtpAccess.ConnectToUnrestrictedPort);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Mail.SmtpPermission" /> class using the specified permission state value.</summary>
		/// <param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" /> values. </param>
		// Token: 0x06001E60 RID: 7776 RVA: 0x0001607C File Offset: 0x0001427C
		public SmtpPermission(PermissionState state)
		{
			this.unrestricted = state == PermissionState.Unrestricted;
			this.access = ((!this.unrestricted) ? SmtpAccess.None : SmtpAccess.ConnectToUnrestrictedPort);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Mail.SmtpPermission" /> class using the specified access level.</summary>
		/// <param name="access">One of the <see cref="T:System.Net.Mail.SmtpAccess" /> values.</param>
		// Token: 0x06001E61 RID: 7777 RVA: 0x000160A6 File Offset: 0x000142A6
		public SmtpPermission(SmtpAccess access)
		{
			this.access = access;
		}

		/// <summary>Gets the level of access to SMTP servers controlled by the permission.</summary>
		/// <returns>One of the <see cref="T:System.Net.Mail.SmtpAccess" /> values. </returns>
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x000160B5 File Offset: 0x000142B5
		public SmtpAccess Access
		{
			get
			{
				return this.access;
			}
		}

		/// <summary>Adds the specified access level value to the permission. </summary>
		/// <param name="access">One of the <see cref="T:System.Net.Mail.SmtpAccess" /> values.</param>
		// Token: 0x06001E63 RID: 7779 RVA: 0x000160BD File Offset: 0x000142BD
		public void AddPermission(SmtpAccess access)
		{
			if (!this.unrestricted && access > this.access)
			{
				this.access = access;
			}
		}

		/// <summary>Creates and returns an identical copy of the current permission. </summary>
		/// <returns>An <see cref="T:System.Net.Mail.SmtpPermission" /> that is identical to the current permission.</returns>
		// Token: 0x06001E64 RID: 7780 RVA: 0x000160DD File Offset: 0x000142DD
		public override IPermission Copy()
		{
			if (this.unrestricted)
			{
				return new SmtpPermission(true);
			}
			return new SmtpPermission(this.access);
		}

		/// <summary>Creates and returns a permission that is the intersection of the current permission and the specified permission.</summary>
		/// <returns>An <see cref="T:System.Net.Mail.SmtpPermission" /> that represents the intersection of the current permission and the specified permission. Returns null if the intersection is empty or <paramref name="target" /> is null.</returns>
		/// <param name="target">An <see cref="T:System.Security.IPermission" /> to intersect with the current permission. It must be of the same type as the current permission.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> is not an <see cref="T:System.Net.Mail.SmtpPermission" />.</exception>
		// Token: 0x06001E65 RID: 7781 RVA: 0x0005EB98 File Offset: 0x0005CD98
		public override IPermission Intersect(IPermission target)
		{
			SmtpPermission smtpPermission = this.Cast(target);
			if (smtpPermission == null)
			{
				return null;
			}
			if (this.unrestricted && smtpPermission.unrestricted)
			{
				return new SmtpPermission(true);
			}
			if (this.access > smtpPermission.access)
			{
				return new SmtpPermission(smtpPermission.access);
			}
			return new SmtpPermission(this.access);
		}

		/// <summary>Returns a value indicating whether the current permission is a subset of the specified permission. </summary>
		/// <returns>true if the current permission is a subset of the specified permission; otherwise, false.</returns>
		/// <param name="target">An <see cref="T:System.Security.IPermission" /> that is to be tested for the subset relationship. This permission must be of the same type as the current permission.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> is not an <see cref="T:System.Net.Mail.SmtpPermission" />.</exception>
		// Token: 0x06001E66 RID: 7782 RVA: 0x0005EBFC File Offset: 0x0005CDFC
		public override bool IsSubsetOf(IPermission target)
		{
			SmtpPermission smtpPermission = this.Cast(target);
			if (smtpPermission == null)
			{
				return this.IsEmpty();
			}
			if (this.unrestricted)
			{
				return smtpPermission.unrestricted;
			}
			return this.access <= smtpPermission.access;
		}

		/// <summary>Returns a value indicating whether the current permission is unrestricted.</summary>
		/// <returns>true if the current permission is unrestricted; otherwise, false.</returns>
		// Token: 0x06001E67 RID: 7783 RVA: 0x000160FC File Offset: 0x000142FC
		public bool IsUnrestricted()
		{
			return this.unrestricted;
		}

		/// <summary>Creates an XML encoding of the state of the permission. </summary>
		/// <returns>A <see cref="T:System.Security.SecurityElement" /> that contains an XML encoding of the current permission.</returns>
		// Token: 0x06001E68 RID: 7784 RVA: 0x0005EC44 File Offset: 0x0005CE44
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = global::System.Security.Permissions.PermissionHelper.Element(typeof(SmtpPermission), 1);
			if (this.unrestricted)
			{
				securityElement.AddAttribute("Unrestricted", "true");
			}
			else
			{
				SmtpAccess smtpAccess = this.access;
				if (smtpAccess != SmtpAccess.Connect)
				{
					if (smtpAccess == SmtpAccess.ConnectToUnrestrictedPort)
					{
						securityElement.AddAttribute("Access", "ConnectToUnrestrictedPort");
					}
				}
				else
				{
					securityElement.AddAttribute("Access", "Connect");
				}
			}
			return securityElement;
		}

		/// <summary>Sets the state of the permission using the specified XML encoding.</summary>
		/// <param name="securityElement">The XML encoding to use to set the state of the current permission.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="securityElement" /> does not describe an <see cref="T:System.Net.Mail.SmtpPermission" /> object.-or-<paramref name="securityElement" /> does not contain the required state information to reconstruct the permission.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="securityElement" /> is null.</exception>
		// Token: 0x06001E69 RID: 7785 RVA: 0x0005ECC8 File Offset: 0x0005CEC8
		public override void FromXml(SecurityElement securityElement)
		{
			global::System.Security.Permissions.PermissionHelper.CheckSecurityElement(securityElement, "securityElement", 1, 1);
			if (securityElement.Tag != "IPermission")
			{
				throw new ArgumentException("securityElement");
			}
			if (global::System.Security.Permissions.PermissionHelper.IsUnrestricted(securityElement))
			{
				this.access = SmtpAccess.Connect;
			}
			else
			{
				this.access = SmtpAccess.None;
			}
		}

		/// <summary>Creates a permission that is the union of the current permission and the specified permission. </summary>
		/// <returns>A new <see cref="T:System.Net.Mail.SmtpPermission" /> permission that represents the union of the current permission and the specified permission.</returns>
		/// <param name="target">An <see cref="T:System.Security.IPermission" /> to combine with the current permission. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> is not an <see cref="T:System.Net.Mail.SmtpPermission" />.</exception>
		// Token: 0x06001E6A RID: 7786 RVA: 0x0005ED24 File Offset: 0x0005CF24
		public override IPermission Union(IPermission target)
		{
			SmtpPermission smtpPermission = this.Cast(target);
			if (smtpPermission == null)
			{
				return this.Copy();
			}
			if (this.unrestricted || smtpPermission.unrestricted)
			{
				return new SmtpPermission(true);
			}
			if (this.access > smtpPermission.access)
			{
				return new SmtpPermission(this.access);
			}
			return new SmtpPermission(smtpPermission.access);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00016104 File Offset: 0x00014304
		private bool IsEmpty()
		{
			return !this.unrestricted && this.access == SmtpAccess.None;
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0005ED8C File Offset: 0x0005CF8C
		private SmtpPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			SmtpPermission smtpPermission = target as SmtpPermission;
			if (smtpPermission == null)
			{
				global::System.Security.Permissions.PermissionHelper.ThrowInvalidPermission(target, typeof(SmtpPermission));
			}
			return smtpPermission;
		}

		// Token: 0x040012A9 RID: 4777
		private const int version = 1;

		// Token: 0x040012AA RID: 4778
		private bool unrestricted;

		// Token: 0x040012AB RID: 4779
		private SmtpAccess access;
	}
}
