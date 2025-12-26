using System;

namespace System.ComponentModel
{
	// Token: 0x02000180 RID: 384
	internal class LicFileLicense : License
	{
		// Token: 0x06000D27 RID: 3367 RVA: 0x0000AEF4 File Offset: 0x000090F4
		public LicFileLicense(string key)
		{
			this._key = key;
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x0000AF03 File Offset: 0x00009103
		public override string LicenseKey
		{
			get
			{
				return this._key;
			}
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void Dispose()
		{
		}

		// Token: 0x0400039D RID: 925
		private string _key;
	}
}
