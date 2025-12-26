using System;
using System.Collections.ObjectModel;

namespace System.Net.Mail
{
	/// <summary>Represents a collection of <see cref="T:System.Net.Mail.AlternateView" /> objects.</summary>
	// Token: 0x02000349 RID: 841
	public sealed class AlternateViewCollection : Collection<AlternateView>, IDisposable
	{
		// Token: 0x06001D72 RID: 7538 RVA: 0x00015439 File Offset: 0x00013639
		internal AlternateViewCollection()
		{
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Net.Mail.AlternateViewCollection" />.</summary>
		// Token: 0x06001D73 RID: 7539 RVA: 0x000029F5 File Offset: 0x00000BF5
		public void Dispose()
		{
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00015441 File Offset: 0x00013641
		protected override void ClearItems()
		{
			base.ClearItems();
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00015449 File Offset: 0x00013649
		protected override void InsertItem(int index, AlternateView item)
		{
			base.InsertItem(index, item);
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00015453 File Offset: 0x00013653
		protected override void RemoveItem(int index)
		{
			base.RemoveItem(index);
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x0001545C File Offset: 0x0001365C
		protected override void SetItem(int index, AlternateView item)
		{
			base.SetItem(index, item);
		}
	}
}
