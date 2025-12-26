using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Represents an element of an X.509 chain.</summary>
	// Token: 0x02000463 RID: 1123
	public class X509ChainElement
	{
		// Token: 0x06002808 RID: 10248 RVA: 0x0001BDF6 File Offset: 0x00019FF6
		internal X509ChainElement(X509Certificate2 certificate)
		{
			this.certificate = certificate;
			this.info = string.Empty;
		}

		/// <summary>Gets the X.509 certificate at a particular chain element.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object.</returns>
		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x0001BE10 File Offset: 0x0001A010
		public X509Certificate2 Certificate
		{
			get
			{
				return this.certificate;
			}
		}

		/// <summary>Gets the error status of the current X.509 certificate in a chain.</summary>
		/// <returns>An array of <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainStatus" /> objects.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x0600280A RID: 10250 RVA: 0x0001BE18 File Offset: 0x0001A018
		public X509ChainStatus[] ChainElementStatus
		{
			get
			{
				return this.status;
			}
		}

		/// <summary>Gets additional error information from an unmanaged certificate chain structure.</summary>
		/// <returns>A string representing the pwszExtendedErrorInfo member of the unmanaged CERT_CHAIN_ELEMENT structure in the Crypto API.</returns>
		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x0001BE20 File Offset: 0x0001A020
		public string Information
		{
			get
			{
				return this.info;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x0600280C RID: 10252 RVA: 0x0001BE28 File Offset: 0x0001A028
		// (set) Token: 0x0600280D RID: 10253 RVA: 0x0001BE30 File Offset: 0x0001A030
		internal X509ChainStatusFlags StatusFlags
		{
			get
			{
				return this.compressed_status_flags;
			}
			set
			{
				this.compressed_status_flags = value;
			}
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x00077A54 File Offset: 0x00075C54
		private int Count(X509ChainStatusFlags flags)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 1;
			while (num2++ < 32)
			{
				if ((flags & (X509ChainStatusFlags)num3) == (X509ChainStatusFlags)num3)
				{
					num++;
				}
				num3 <<= 1;
			}
			return num;
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x0001BE39 File Offset: 0x0001A039
		private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask)
		{
			if ((flags & mask) != X509ChainStatusFlags.NoError)
			{
				status[position].Status = mask;
				status[position].StatusInformation = X509ChainStatus.GetInformation(mask);
				position++;
			}
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x00077A8C File Offset: 0x00075C8C
		internal void UncompressFlags()
		{
			if (this.compressed_status_flags == X509ChainStatusFlags.NoError)
			{
				this.status = new X509ChainStatus[0];
			}
			else
			{
				int num = this.Count(this.compressed_status_flags);
				this.status = new X509ChainStatus[num];
				int num2 = 0;
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.UntrustedRoot);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.NotTimeValid);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.NotTimeNested);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.Revoked);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.NotSignatureValid);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.NotValidForUsage);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.RevocationStatusUnknown);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.Cyclic);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.InvalidExtension);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.InvalidPolicyConstraints);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.InvalidBasicConstraints);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.InvalidNameConstraints);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.HasNotSupportedNameConstraint);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.HasNotDefinedNameConstraint);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.HasNotPermittedNameConstraint);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.HasExcludedNameConstraint);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.PartialChain);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.CtlNotTimeValid);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.CtlNotSignatureValid);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.CtlNotValidForUsage);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.OfflineRevocation);
				this.Set(this.status, ref num2, this.compressed_status_flags, X509ChainStatusFlags.NoIssuanceChainPolicy);
			}
		}

		// Token: 0x0400185B RID: 6235
		private X509Certificate2 certificate;

		// Token: 0x0400185C RID: 6236
		private X509ChainStatus[] status;

		// Token: 0x0400185D RID: 6237
		private string info;

		// Token: 0x0400185E RID: 6238
		private X509ChainStatusFlags compressed_status_flags;
	}
}
