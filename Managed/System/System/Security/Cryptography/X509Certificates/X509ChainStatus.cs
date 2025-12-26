using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Provides a simple structure for storing X509 chain status and error information.</summary>
	// Token: 0x02000466 RID: 1126
	public struct X509ChainStatus
	{
		// Token: 0x06002825 RID: 10277 RVA: 0x0001BF83 File Offset: 0x0001A183
		internal X509ChainStatus(X509ChainStatusFlags flag)
		{
			this.status = flag;
			this.info = X509ChainStatus.GetInformation(flag);
		}

		/// <summary>Specifies the status of the X509 chain.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainStatusFlags" /> value.</returns>
		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002826 RID: 10278 RVA: 0x0001BF98 File Offset: 0x0001A198
		// (set) Token: 0x06002827 RID: 10279 RVA: 0x0001BFA0 File Offset: 0x0001A1A0
		public X509ChainStatusFlags Status
		{
			get
			{
				return this.status;
			}
			set
			{
				this.status = value;
			}
		}

		/// <summary>Specifies a description of the <see cref="P:System.Security.Cryptography.X509Certificates.X509Chain.ChainStatus" /> value.</summary>
		/// <returns>A localizable string.</returns>
		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002828 RID: 10280 RVA: 0x0001BFA9 File Offset: 0x0001A1A9
		// (set) Token: 0x06002829 RID: 10281 RVA: 0x0001BFB1 File Offset: 0x0001A1B1
		public string StatusInformation
		{
			get
			{
				return this.info;
			}
			set
			{
				this.info = value;
			}
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00077D3C File Offset: 0x00075F3C
		internal static string GetInformation(X509ChainStatusFlags flags)
		{
			switch (flags)
			{
			case X509ChainStatusFlags.NoError:
				goto IL_00FF;
			case X509ChainStatusFlags.NotTimeValid:
			case X509ChainStatusFlags.NotTimeNested:
			case X509ChainStatusFlags.Revoked:
			case X509ChainStatusFlags.NotSignatureValid:
				break;
			default:
				if (flags != X509ChainStatusFlags.NotValidForUsage && flags != X509ChainStatusFlags.UntrustedRoot && flags != X509ChainStatusFlags.RevocationStatusUnknown && flags != X509ChainStatusFlags.Cyclic && flags != X509ChainStatusFlags.InvalidExtension && flags != X509ChainStatusFlags.InvalidPolicyConstraints && flags != X509ChainStatusFlags.InvalidBasicConstraints && flags != X509ChainStatusFlags.InvalidNameConstraints && flags != X509ChainStatusFlags.HasNotSupportedNameConstraint && flags != X509ChainStatusFlags.HasNotDefinedNameConstraint && flags != X509ChainStatusFlags.HasNotPermittedNameConstraint && flags != X509ChainStatusFlags.HasExcludedNameConstraint && flags != X509ChainStatusFlags.PartialChain && flags != X509ChainStatusFlags.CtlNotTimeValid && flags != X509ChainStatusFlags.CtlNotSignatureValid && flags != X509ChainStatusFlags.CtlNotValidForUsage && flags != X509ChainStatusFlags.OfflineRevocation && flags != X509ChainStatusFlags.NoIssuanceChainPolicy)
				{
					goto IL_00FF;
				}
				break;
			}
			return global::Locale.GetText(flags.ToString());
			IL_00FF:
			return string.Empty;
		}

		// Token: 0x04001868 RID: 6248
		private X509ChainStatusFlags status;

		// Token: 0x04001869 RID: 6249
		private string info;
	}
}
