using System;
using System.Collections.ObjectModel;

namespace System.Net.Mail
{
	/// <summary>Stores linked resources to be sent as part of an e-mail message.</summary>
	// Token: 0x02000350 RID: 848
	public sealed class LinkedResourceCollection : Collection<LinkedResource>, IDisposable
	{
		// Token: 0x06001DAC RID: 7596 RVA: 0x0001578B File Offset: 0x0001398B
		internal LinkedResourceCollection()
		{
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Net.Mail.LinkedResourceCollection" />.</summary>
		// Token: 0x06001DAD RID: 7597 RVA: 0x00015793 File Offset: 0x00013993
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x000029F5 File Offset: 0x00000BF5
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x000157A2 File Offset: 0x000139A2
		protected override void ClearItems()
		{
			base.ClearItems();
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x000157AA File Offset: 0x000139AA
		protected override void InsertItem(int index, LinkedResource item)
		{
			base.InsertItem(index, item);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x000157B4 File Offset: 0x000139B4
		protected override void RemoveItem(int index)
		{
			base.RemoveItem(index);
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x000157BD File Offset: 0x000139BD
		protected override void SetItem(int index, LinkedResource item)
		{
			base.SetItem(index, item);
		}
	}
}
