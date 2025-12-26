using System;
using System.Security.Cryptography.X509Certificates;

namespace System.Net
{
	// Token: 0x02000305 RID: 773
	internal class DefaultCertificatePolicy : ICertificatePolicy
	{
		// Token: 0x06001A45 RID: 6725 RVA: 0x0004E624 File Offset: 0x0004C824
		public bool CheckValidationResult(ServicePoint point, X509Certificate certificate, WebRequest request, int certificateProblem)
		{
			return ServicePointManager.ServerCertificateValidationCallback != null || certificateProblem == -2146762495 || certificateProblem == 0;
		}
	}
}
