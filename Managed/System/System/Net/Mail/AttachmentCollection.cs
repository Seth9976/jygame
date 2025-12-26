using System;
using System.Collections.ObjectModel;

namespace System.Net.Mail
{
	/// <summary>Stores attachments to be sent as part of an e-mail message.</summary>
	// Token: 0x0200034D RID: 845
	public sealed class AttachmentCollection : Collection<Attachment>, IDisposable
	{
		// Token: 0x06001D97 RID: 7575 RVA: 0x0001566C File Offset: 0x0001386C
		internal AttachmentCollection()
		{
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Net.Mail.AttachmentCollection" />. </summary>
		// Token: 0x06001D98 RID: 7576 RVA: 0x0005C764 File Offset: 0x0005A964
		public void Dispose()
		{
			for (int i = 0; i < this.Count; i++)
			{
				this[i].Dispose();
			}
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00015674 File Offset: 0x00013874
		protected override void ClearItems()
		{
			base.ClearItems();
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x0001567C File Offset: 0x0001387C
		protected override void InsertItem(int index, Attachment item)
		{
			base.InsertItem(index, item);
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00015686 File Offset: 0x00013886
		protected override void RemoveItem(int index)
		{
			base.RemoveItem(index);
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x0001568F File Offset: 0x0001388F
		protected override void SetItem(int index, Attachment item)
		{
			base.SetItem(index, item);
		}
	}
}
