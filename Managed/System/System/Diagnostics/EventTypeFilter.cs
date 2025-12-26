using System;

namespace System.Diagnostics
{
	/// <summary>Indicates whether a listener should trace based on the event type.</summary>
	// Token: 0x02000231 RID: 561
	public class EventTypeFilter : TraceFilter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventTypeFilter" /> class. </summary>
		/// <param name="level">A bitwise combination of the <see cref="T:System.Diagnostics.SourceLevels" /> values that specifies the event type of the messages to trace. </param>
		// Token: 0x06001318 RID: 4888 RVA: 0x0000F346 File Offset: 0x0000D546
		public EventTypeFilter(SourceLevels eventType)
		{
			this.event_type = eventType;
		}

		/// <summary>Gets or sets the event type of the messages to trace.</summary>
		/// <returns>A bitwise combination of the <see cref="T:System.Diagnostics.SourceLevels" /> values.</returns>
		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x0000F355 File Offset: 0x0000D555
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x0000F35D File Offset: 0x0000D55D
		public SourceLevels EventType
		{
			get
			{
				return this.event_type;
			}
			set
			{
				this.event_type = value;
			}
		}

		/// <summary>Determines whether the trace listener should trace the event. </summary>
		/// <returns>trueif the trace should be produced; otherwise, false.</returns>
		/// <param name="cache">A <see cref="T:System.Diagnostics.TraceEventCache" /> that represents the information cache for the trace event.</param>
		/// <param name="source">The name of the source.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values. </param>
		/// <param name="id">A trace identifier number.</param>
		/// <param name="formatOrMessage">The format to use for writing an array of arguments, or a message to write.</param>
		/// <param name="args">An array of argument objects.</param>
		/// <param name="data1">A trace data object.</param>
		/// <param name="data">An array of trace data objects.</param>
		// Token: 0x0600131B RID: 4891 RVA: 0x0003EED8 File Offset: 0x0003D0D8
		public override bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data)
		{
			switch (eventType)
			{
			case TraceEventType.Critical:
				return (this.event_type & SourceLevels.Critical) != SourceLevels.Off;
			case TraceEventType.Error:
				return (this.event_type & SourceLevels.Error) != SourceLevels.Off;
			default:
				if (eventType == TraceEventType.Verbose)
				{
					return (this.event_type & SourceLevels.Verbose) != SourceLevels.Off;
				}
				if (eventType != TraceEventType.Start && eventType != TraceEventType.Stop && eventType != TraceEventType.Suspend && eventType != TraceEventType.Resume && eventType != TraceEventType.Transfer)
				{
					return this.event_type != SourceLevels.Off;
				}
				return (this.event_type & SourceLevels.ActivityTracing) != SourceLevels.Off;
			case TraceEventType.Warning:
				return (this.event_type & SourceLevels.Warning) != SourceLevels.Off;
			case TraceEventType.Information:
				return (this.event_type & SourceLevels.Information) != SourceLevels.Off;
			}
		}

		// Token: 0x0400057F RID: 1407
		private SourceLevels event_type;
	}
}
