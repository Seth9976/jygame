using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	/// <summary>Represents language-neutral information for an event log entry.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000222 RID: 546
	public class EventInstance
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventInstance" /> class using the specified resource identifiers for the localized message and category text of the event entry.</summary>
		/// <param name="instanceId">A resource identifier that corresponds to a string defined in the message resource file of the event source.</param>
		/// <param name="categoryId">A resource identifier that corresponds to a string defined in the category resource file of the event source, or zero to specify no category for the event. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="instanceId" /> parameter is a negative value or a value larger than <see cref="F:System.UInt32.MaxValue" />.-or- The <paramref name="categoryId" /> parameter is a negative value or a value larger than <see cref="F:System.UInt16.MaxValue" />. </exception>
		// Token: 0x0600124A RID: 4682 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		public EventInstance(long instanceId, int categoryId)
			: this(instanceId, categoryId, EventLogEntryType.Information)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventInstance" /> class using the specified resource identifiers for the localized message and category text of the event entry and the specified event log entry type.</summary>
		/// <param name="instanceId">A resource identifier that corresponds to a string defined in the message resource file of the event source. </param>
		/// <param name="categoryId">A resource identifier that corresponds to a string defined in the category resource file of the event source, or zero to specify no category for the event. </param>
		/// <param name="entryType">An <see cref="T:System.Diagnostics.EventLogEntryType" /> value that indicates the event type. </param>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="entryType" /> is not a valid <see cref="T:System.Diagnostics.EventLogEntryType" /> value. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="instanceId" /> is a negative value or a value larger than <see cref="F:System.UInt32.MaxValue" />.-or- <paramref name="categoryId" /> is a negative value or a value larger than <see cref="F:System.UInt16.MaxValue" />. </exception>
		// Token: 0x0600124B RID: 4683 RVA: 0x0000EACB File Offset: 0x0000CCCB
		public EventInstance(long instanceId, int categoryId, EventLogEntryType entryType)
		{
			this.InstanceId = instanceId;
			this.CategoryId = categoryId;
			this.EntryType = entryType;
		}

		/// <summary>Gets or sets the resource identifier that specifies the application-defined category of the event entry.</summary>
		/// <returns>A numeric category value or resource identifier that corresponds to a string defined in the category resource file of the event source. The default is zero, which signifies that no category will be displayed for the event entry.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The property is set to a negative value or to a value larger than <see cref="F:System.UInt16.MaxValue" />. </exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		public int CategoryId
		{
			get
			{
				return this._categoryId;
			}
			set
			{
				if (value < 0 || value > 65535)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._categoryId = value;
			}
		}

		/// <summary>Gets or sets the event type of the event log entry.</summary>
		/// <returns>An <see cref="T:System.Diagnostics.EventLogEntryType" /> value that indicates the event entry type. The default value is <see cref="F:System.Diagnostics.EventLogEntryType.Information" />.</returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The property is not set to a valid <see cref="T:System.Diagnostics.EventLogEntryType" /> value. </exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x0000EB16 File Offset: 0x0000CD16
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x0000EB1E File Offset: 0x0000CD1E
		public EventLogEntryType EntryType
		{
			get
			{
				return this._entryType;
			}
			set
			{
				if (!Enum.IsDefined(typeof(EventLogEntryType), value))
				{
					throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(EventLogEntryType));
				}
				this._entryType = value;
			}
		}

		/// <summary>Gets or sets the resource identifier that designates the message text of the event entry.</summary>
		/// <returns>A resource identifier that corresponds to a string defined in the message resource file of the event source.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The property is set to a negative value or to a value larger than <see cref="F:System.UInt32.MaxValue" />. </exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x0000EB57 File Offset: 0x0000CD57
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x0000EB5F File Offset: 0x0000CD5F
		public long InstanceId
		{
			get
			{
				return this._instanceId;
			}
			set
			{
				if (value < 0L || value > (long)((ulong)(-1)))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._instanceId = value;
			}
		}

		// Token: 0x04000541 RID: 1345
		private int _categoryId;

		// Token: 0x04000542 RID: 1346
		private EventLogEntryType _entryType;

		// Token: 0x04000543 RID: 1347
		private long _instanceId;
	}
}
