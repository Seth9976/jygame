using System;
using System.IO;
using System.Threading;
using System.Xml;

namespace System.Diagnostics
{
	/// <summary>Directs tracing or debugging output as XML-encoded data to a <see cref="T:System.IO.TextWriter" /> or to a <see cref="T:System.IO.Stream" />, such as a <see cref="T:System.IO.FileStream" />.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x02000272 RID: 626
	public class XmlWriterTraceListener : TextWriterTraceListener
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> class, using the specified file as the recipient of the debugging and tracing output. </summary>
		/// <param name="filename">The name of the file to write to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="filename" /> is null. </exception>
		// Token: 0x06001624 RID: 5668 RVA: 0x00010E10 File Offset: 0x0000F010
		public XmlWriterTraceListener(string filename)
			: this(filename, XmlWriterTraceListener.default_name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> class with the specified name, using the specified file as the recipient of the debugging and tracing output.  </summary>
		/// <param name="filename">The name of the file to write to. </param>
		/// <param name="name">The name of the new instance. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> is null. </exception>
		// Token: 0x06001625 RID: 5669 RVA: 0x00010E1E File Offset: 0x0000F01E
		public XmlWriterTraceListener(string filename, string name)
			: this(new StreamWriter(new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.ReadWrite)), name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> class, using the specified stream as the recipient of the debugging and tracing output. </summary>
		/// <param name="stream">A <see cref="T:System.IO.Stream" /> that represents the stream the trace listener writes to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> is null. </exception>
		// Token: 0x06001626 RID: 5670 RVA: 0x00010E35 File Offset: 0x0000F035
		public XmlWriterTraceListener(Stream stream)
			: this(stream, XmlWriterTraceListener.default_name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> class with the specified name, using the specified stream as the recipient of the debugging and tracing output. </summary>
		/// <param name="stream">A <see cref="T:System.IO.Stream" /> that represents the stream the trace listener writes to. </param>
		/// <param name="name">The name of the new instance. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> is null. </exception>
		// Token: 0x06001627 RID: 5671 RVA: 0x00010E43 File Offset: 0x0000F043
		public XmlWriterTraceListener(Stream writer, string name)
			: this(new StreamWriter(writer), name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> class using the specified writer as the recipient of the debugging and tracing output. </summary>
		/// <param name="writer">A <see cref="T:System.IO.TextWriter" /> that receives the output from the trace listener.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="writer" /> is null. </exception>
		// Token: 0x06001628 RID: 5672 RVA: 0x00010E52 File Offset: 0x0000F052
		public XmlWriterTraceListener(TextWriter writer)
			: this(writer, XmlWriterTraceListener.default_name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> class with the specified name, using the specified writer as the recipient of the debugging and tracing output. </summary>
		/// <param name="writer">A <see cref="T:System.IO.TextWriter" /> that receives the output from the trace listener. </param>
		/// <param name="name">The name of the new instance. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="writer" /> is null. </exception>
		// Token: 0x06001629 RID: 5673 RVA: 0x000447B8 File Offset: 0x000429B8
		public XmlWriterTraceListener(TextWriter writer, string name)
			: base(name)
		{
			this.w = XmlWriter.Create(writer, new XmlWriterSettings
			{
				OmitXmlDeclaration = true
			});
		}

		/// <summary>Closes the <see cref="P:System.Diagnostics.TextWriterTraceListener.Writer" /> for this listener so that it no longer receives tracing or debugging output.</summary>
		// Token: 0x0600162B RID: 5675 RVA: 0x00010E80 File Offset: 0x0000F080
		public override void Close()
		{
			this.w.Close();
		}

		/// <summary>Writes trace information including an error message and a detailed error message to the file or stream.</summary>
		/// <param name="message">The error message to write.</param>
		/// <param name="detailMessage">The detailed error message to append to the error message.</param>
		// Token: 0x0600162C RID: 5676 RVA: 0x00010E8D File Offset: 0x0000F08D
		public override void Fail(string message, string detailMessage)
		{
			this.TraceEvent(null, null, TraceEventType.Error, 0, message + " " + detailMessage);
		}

		/// <summary>Writes trace information, a data object, and event information to the file or stream.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">The source name. </param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="data">A data object to emit.</param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x0600162D RID: 5677 RVA: 0x000447E8 File Offset: 0x000429E8
		public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
		{
			this.TraceCore(eventCache, source, eventType, id, false, Guid.Empty, 2, true, new object[] { data });
		}

		/// <summary>Writes trace information, data objects, and event information to the file or stream.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">The source name. </param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="data">An array of data objects to emit.</param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x0600162E RID: 5678 RVA: 0x00044814 File Offset: 0x00042A14
		[global::System.MonoLimitation("level is not always correct")]
		public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data)
		{
			this.TraceCore(eventCache, source, eventType, id, false, Guid.Empty, 2, true, data);
		}

		/// <summary>Writes trace information, a message, and event information to the file or stream.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">The source name. </param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="message">The message to write.</param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x0600162F RID: 5679 RVA: 0x00044838 File Offset: 0x00042A38
		[global::System.MonoLimitation("level is not always correct")]
		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
			this.TraceCore(eventCache, source, TraceEventType.Transfer, id, false, Guid.Empty, 2, true, new object[] { message });
		}

		/// <summary>Writes trace information, a formatted message, and event information to the file or stream.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">The source name. </param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="format">A format string that contains zero or more format items that correspond to objects in the <paramref name="args" /> array.</param>
		/// <param name="args">An object array containing zero or more objects to format.</param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06001630 RID: 5680 RVA: 0x00044868 File Offset: 0x00042A68
		[global::System.MonoLimitation("level is not always correct")]
		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args)
		{
			this.TraceCore(eventCache, source, TraceEventType.Transfer, id, false, Guid.Empty, 2, true, new object[] { string.Format(format, args) });
		}

		/// <summary>Writes trace information including the identity of a related activity, a message, and event information to the file or stream.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">The source name. </param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="message">A trace message to write.</param>
		/// <param name="relatedActivityId">A <see cref="T:System.Guid" /> structure that identifies a related activity.</param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06001631 RID: 5681 RVA: 0x000448A0 File Offset: 0x00042AA0
		public override void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId)
		{
			this.TraceCore(eventCache, source, TraceEventType.Transfer, id, true, relatedActivityId, 255, true, new object[] { message });
		}

		/// <summary>Writes a verbatim message without any additional context information to the file or stream.</summary>
		/// <param name="message">The message to write.</param>
		// Token: 0x06001632 RID: 5682 RVA: 0x00010EA5 File Offset: 0x0000F0A5
		public override void Write(string message)
		{
			this.WriteLine(message);
		}

		/// <summary>Writes a verbatim message without any additional context information followed by the current line terminator to the file or stream.</summary>
		/// <param name="message">The message to write.</param>
		// Token: 0x06001633 RID: 5683 RVA: 0x000448D0 File Offset: 0x00042AD0
		[global::System.MonoLimitation("level is not always correct")]
		public override void WriteLine(string message)
		{
			this.TraceCore(null, "Trace", TraceEventType.Information, 0, false, Guid.Empty, 8, false, new object[] { message });
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00044900 File Offset: 0x00042B00
		private void TraceCore(TraceEventCache eventCache, string source, TraceEventType eventType, int id, bool hasRelatedActivity, Guid relatedActivity, int level, bool wrapData, params object[] data)
		{
			Process process = ((eventCache == null) ? Process.GetCurrentProcess() : Process.GetProcessById(eventCache.ProcessId));
			this.w.WriteStartElement("E2ETraceEvent", XmlWriterTraceListener.e2e_ns);
			this.w.WriteStartElement("System", XmlWriterTraceListener.sys_ns);
			this.w.WriteStartElement("EventID", XmlWriterTraceListener.sys_ns);
			this.w.WriteString(XmlConvert.ToString(id));
			this.w.WriteEndElement();
			this.w.WriteStartElement("Type", XmlWriterTraceListener.sys_ns);
			this.w.WriteString("3");
			this.w.WriteEndElement();
			this.w.WriteStartElement("SubType", XmlWriterTraceListener.sys_ns);
			this.w.WriteAttributeString("Name", eventType.ToString());
			this.w.WriteString("0");
			this.w.WriteEndElement();
			this.w.WriteStartElement("Level", XmlWriterTraceListener.sys_ns);
			this.w.WriteString(level.ToString());
			this.w.WriteEndElement();
			this.w.WriteStartElement("TimeCreated", XmlWriterTraceListener.sys_ns);
			this.w.WriteAttributeString("SystemTime", XmlConvert.ToString((eventCache == null) ? DateTime.Now : eventCache.DateTime));
			this.w.WriteEndElement();
			this.w.WriteStartElement("Source", XmlWriterTraceListener.sys_ns);
			this.w.WriteAttributeString("Name", source);
			this.w.WriteEndElement();
			this.w.WriteStartElement("Correlation", XmlWriterTraceListener.sys_ns);
			this.w.WriteAttributeString("ActivityID", "{" + Guid.Empty + "}");
			this.w.WriteEndElement();
			this.w.WriteStartElement("Execution", XmlWriterTraceListener.sys_ns);
			this.w.WriteAttributeString("ProcessName", process.MainModule.ModuleName);
			this.w.WriteAttributeString("ProcessID", process.Id.ToString());
			this.w.WriteAttributeString("ThreadID", (eventCache == null) ? Thread.CurrentThread.ManagedThreadId.ToString() : eventCache.ThreadId);
			this.w.WriteEndElement();
			this.w.WriteStartElement("Channel", XmlWriterTraceListener.sys_ns);
			this.w.WriteEndElement();
			this.w.WriteStartElement("Computer");
			this.w.WriteString(process.MachineName);
			this.w.WriteEndElement();
			this.w.WriteEndElement();
			this.w.WriteStartElement("ApplicationData", XmlWriterTraceListener.e2e_ns);
			foreach (object obj in data)
			{
				if (wrapData)
				{
					this.w.WriteStartElement("TraceData", XmlWriterTraceListener.e2e_ns);
				}
				if (obj != null)
				{
					this.w.WriteString(obj.ToString());
				}
				if (wrapData)
				{
					this.w.WriteEndElement();
				}
			}
			this.w.WriteEndElement();
			this.w.WriteEndElement();
		}

		// Token: 0x040006E7 RID: 1767
		private static readonly string e2e_ns = "http://schemas.microsoft.com/2004/06/E2ETraceEvent";

		// Token: 0x040006E8 RID: 1768
		private static readonly string sys_ns = "http://schemas.microsoft.com/2004/06/windows/eventlog/system";

		// Token: 0x040006E9 RID: 1769
		private static readonly string default_name = "XmlWriter";

		// Token: 0x040006EA RID: 1770
		private XmlWriter w;
	}
}
