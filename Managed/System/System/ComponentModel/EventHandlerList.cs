using System;

namespace System.ComponentModel
{
	/// <summary>Provides a simple list of delegates. This class cannot be inherited.</summary>
	// Token: 0x0200014F RID: 335
	public sealed class EventHandlerList : IDisposable
	{
		/// <summary>Gets or sets the delegate for the specified object.</summary>
		/// <returns>The delegate for the specified key, or null if a delegate does not exist.</returns>
		/// <param name="key">An object to find in the list. </param>
		// Token: 0x170002C7 RID: 711
		public Delegate this[object key]
		{
			get
			{
				if (key == null)
				{
					return this.null_entry;
				}
				ListEntry listEntry = this.FindEntry(key);
				if (listEntry != null)
				{
					return listEntry.value;
				}
				return null;
			}
			set
			{
				this.AddHandler(key, value);
			}
		}

		/// <summary>Adds a delegate to the list.</summary>
		/// <param name="key">The object that owns the event. </param>
		/// <param name="value">The delegate to add to the list. </param>
		// Token: 0x06000C4F RID: 3151 RVA: 0x00031E10 File Offset: 0x00030010
		public void AddHandler(object key, Delegate value)
		{
			if (key == null)
			{
				this.null_entry = Delegate.Combine(this.null_entry, value);
				return;
			}
			ListEntry listEntry = this.FindEntry(key);
			if (listEntry == null)
			{
				listEntry = new ListEntry();
				listEntry.key = key;
				listEntry.value = null;
				listEntry.next = this.entries;
				this.entries = listEntry;
			}
			listEntry.value = Delegate.Combine(listEntry.value, value);
		}

		/// <summary>Adds a list of delegates to the current list.</summary>
		/// <param name="listToAddFrom">The list to add.</param>
		// Token: 0x06000C50 RID: 3152 RVA: 0x00031E80 File Offset: 0x00030080
		public void AddHandlers(EventHandlerList listToAddFrom)
		{
			if (listToAddFrom == null)
			{
				return;
			}
			for (ListEntry next = listToAddFrom.entries; next != null; next = next.next)
			{
				this.AddHandler(next.key, next.value);
			}
		}

		/// <summary>Removes a delegate from the list.</summary>
		/// <param name="key">The object that owns the event. </param>
		/// <param name="value">The delegate to remove from the list. </param>
		// Token: 0x06000C51 RID: 3153 RVA: 0x00031EC0 File Offset: 0x000300C0
		public void RemoveHandler(object key, Delegate value)
		{
			if (key == null)
			{
				this.null_entry = Delegate.Remove(this.null_entry, value);
				return;
			}
			ListEntry listEntry = this.FindEntry(key);
			if (listEntry == null)
			{
				return;
			}
			listEntry.value = Delegate.Remove(listEntry.value, value);
		}

		/// <summary>Disposes the delegate list.</summary>
		// Token: 0x06000C52 RID: 3154 RVA: 0x0000A9E5 File Offset: 0x00008BE5
		public void Dispose()
		{
			this.entries = null;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00031F08 File Offset: 0x00030108
		private ListEntry FindEntry(object key)
		{
			for (ListEntry next = this.entries; next != null; next = next.next)
			{
				if (next.key == key)
				{
					return next;
				}
			}
			return null;
		}

		// Token: 0x0400037F RID: 895
		private ListEntry entries;

		// Token: 0x04000380 RID: 896
		private Delegate null_entry;
	}
}
