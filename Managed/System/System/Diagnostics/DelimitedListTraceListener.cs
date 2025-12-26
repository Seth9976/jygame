using System;
using System.IO;
using System.Text;

namespace System.Diagnostics
{
	/// <summary>Directs tracing or debugging output to a text writer, such as a stream writer, or to a stream, such as a file stream.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x0200021D RID: 541
	public class DelimitedListTraceListener : TextWriterTraceListener
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DelimitedListTraceListener" /> class that writes to the specified file.  </summary>
		/// <param name="fileName">The name of the file to receive the output.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="fileName" /> is null. </exception>
		// Token: 0x0600121C RID: 4636 RVA: 0x0000E8E1 File Offset: 0x0000CAE1
		public DelimitedListTraceListener(string fileName)
			: base(fileName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DelimitedListTraceListener" /> class that writes to the specified file and has the specified name. </summary>
		/// <param name="fileName">The name of the file to receive the output. </param>
		/// <param name="name">The name of the new instance of the trace listener. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="fileName" /> is null. </exception>
		// Token: 0x0600121D RID: 4637 RVA: 0x0000E8F5 File Offset: 0x0000CAF5
		public DelimitedListTraceListener(string fileName, string name)
			: base(fileName, name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DelimitedListTraceListener" /> class that writes to the specified output stream. </summary>
		/// <param name="stream">The <see cref="T:System.IO.Stream" /> to receive the output.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> is null. </exception>
		// Token: 0x0600121E RID: 4638 RVA: 0x0000E90A File Offset: 0x0000CB0A
		public DelimitedListTraceListener(Stream stream)
			: base(stream)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DelimitedListTraceListener" /> class that writes to the specified output stream and has the specified name. </summary>
		/// <param name="stream">The <see cref="T:System.IO.Stream" /> to receive the output.</param>
		/// <param name="name">The name of the new instance of the trace listener. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> is null. </exception>
		// Token: 0x0600121F RID: 4639 RVA: 0x0000E91E File Offset: 0x0000CB1E
		public DelimitedListTraceListener(Stream stream, string name)
			: base(stream, name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DelimitedListTraceListener" /> class that writes to the specified text writer. </summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> to receive the output.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="writer" /> is null. </exception>
		// Token: 0x06001220 RID: 4640 RVA: 0x0000E933 File Offset: 0x0000CB33
		public DelimitedListTraceListener(TextWriter writer)
			: base(writer)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DelimitedListTraceListener" /> class that writes to the specified text writer and has the specified name. </summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> to receive the output.</param>
		/// <param name="name">The name of the new instance of the trace listener. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="writer" /> is null. </exception>
		// Token: 0x06001221 RID: 4641 RVA: 0x0000E947 File Offset: 0x0000CB47
		public DelimitedListTraceListener(TextWriter writer, string name)
			: base(writer, name)
		{
		}

		/// <summary>Gets or sets the delimiter for the delimited list.</summary>
		/// <returns>The delimiter for the delimited list.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <see cref="P:System.Diagnostics.DelimitedListTraceListener.Delimiter" /> is set to null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Diagnostics.DelimitedListTraceListener.Delimiter" /> is set to an empty string ("").</exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x0000E971 File Offset: 0x0000CB71
		// (set) Token: 0x06001224 RID: 4644 RVA: 0x0000E979 File Offset: 0x0000CB79
		public string Delimiter
		{
			get
			{
				return this.delimiter;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.delimiter = value;
			}
		}

		/// <summary>Returns the custom configuration file attribute supported by the delimited trace listener.</summary>
		/// <returns>A string array that contains the single value "delimiter".</returns>
		// Token: 0x06001225 RID: 4645 RVA: 0x0000E993 File Offset: 0x0000CB93
		protected internal override string[] GetSupportedAttributes()
		{
			return DelimitedListTraceListener.attributes;
		}

		/// <summary>Writes trace information, a data object, and event information to the output file or stream.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="data">A data object to write to the output file or stream.</param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06001226 RID: 4646 RVA: 0x0003CBA0 File Offset: 0x0003ADA0
		public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
		{
			this.TraceCore(eventCache, source, eventType, id, null, new object[] { data });
		}

		/// <summary>Writes trace information, an array of data objects, and event information to the output file or stream.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="data">An array of data objects to write to the output file or stream.</param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06001227 RID: 4647 RVA: 0x0000E99A File Offset: 0x0000CB9A
		public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data)
		{
			this.TraceCore(eventCache, source, eventType, id, null, data);
		}

		/// <summary>Writes trace information, a message, and event information to the output file or stream.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="message">The trace message to write to the output file or stream.</param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06001228 RID: 4648 RVA: 0x0000E9AA File Offset: 0x0000CBAA
		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
			this.TraceCore(eventCache, source, eventType, id, message, new object[0]);
		}

		/// <summary>Writes trace information, a formatted array of objects, and event information to the output file or stream.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="format">A format string that contains zero or more format items that correspond to objects in the <paramref name="args" /> array.</param>
		/// <param name="args">An array containing zero or more objects to format.</param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06001229 RID: 4649 RVA: 0x0000E9BF File Offset: 0x0000CBBF
		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args)
		{
			this.TraceCore(eventCache, source, eventType, id, string.Format(format, args), new object[0]);
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0003CBC4 File Offset: 0x0003ADC4
		private void TraceCore(TraceEventCache c, string source, TraceEventType eventType, int id, string message, params object[] data)
		{
			this.Write(string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}{12}", new object[]
			{
				this.delimiter,
				(source == null) ? null : ("\"" + source.Replace("\"", "\"\"") + "\""),
				eventType,
				id,
				(message == null) ? null : ("\"" + message.Replace("\"", "\"\"") + "\""),
				this.FormatData(data),
				(!this.IsTarget(c, TraceOptions.ProcessId)) ? null : c.ProcessId.ToString(),
				(!this.IsTarget(c, TraceOptions.LogicalOperationStack)) ? null : TraceListener.FormatArray(c.LogicalOperationStack, ", "),
				(!this.IsTarget(c, TraceOptions.ThreadId)) ? null : c.ThreadId,
				(!this.IsTarget(c, TraceOptions.DateTime)) ? null : c.DateTime.ToString("o"),
				(!this.IsTarget(c, TraceOptions.Timestamp)) ? null : c.Timestamp.ToString(),
				(!this.IsTarget(c, TraceOptions.Callstack)) ? null : c.Callstack,
				Environment.NewLine
			}));
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0000E9DB File Offset: 0x0000CBDB
		private bool IsTarget(TraceEventCache c, TraceOptions opt)
		{
			return c != null && (base.TraceOutputOptions & opt) != TraceOptions.None;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0003CD4C File Offset: 0x0003AF4C
		private string FormatData(object[] data)
		{
			if (data == null || data.Length == 0)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < data.Length; i++)
			{
				if (data[i] != null)
				{
					stringBuilder.Append('"').Append(data[i].ToString().Replace("\"", "\"\"")).Append('"');
				}
				if (i + 1 < data.Length)
				{
					stringBuilder.Append(',');
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000538 RID: 1336
		private static readonly string[] attributes = new string[] { "delimiter" };

		// Token: 0x04000539 RID: 1337
		private string delimiter = ";";
	}
}
