using System;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Provides the abstract base class for the listeners who monitor trace and debug output.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000267 RID: 615
	public abstract class TraceListener : MarshalByRefObject, IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TraceListener" /> class.</summary>
		// Token: 0x060015A0 RID: 5536 RVA: 0x00010A8B File Offset: 0x0000EC8B
		protected TraceListener()
			: this(string.Empty)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TraceListener" /> class using the specified name as the listener.</summary>
		/// <param name="name">The name of the <see cref="T:System.Diagnostics.TraceListener" />. </param>
		// Token: 0x060015A1 RID: 5537 RVA: 0x00010A98 File Offset: 0x0000EC98
		protected TraceListener(string name)
		{
			this.Name = name;
		}

		/// <summary>Gets or sets the indent level.</summary>
		/// <returns>The indent level. The default is zero.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00010AC0 File Offset: 0x0000ECC0
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x00010AC8 File Offset: 0x0000ECC8
		public int IndentLevel
		{
			get
			{
				return this.indentLevel;
			}
			set
			{
				this.indentLevel = value;
			}
		}

		/// <summary>Gets or sets the number of spaces in an indent.</summary>
		/// <returns>The number of spaces in an indent. The default is four spaces.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Set operation failed because the value is less than zero.</exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x00010AD1 File Offset: 0x0000ECD1
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x00010AD9 File Offset: 0x0000ECD9
		public int IndentSize
		{
			get
			{
				return this.indentSize;
			}
			set
			{
				this.indentSize = value;
			}
		}

		/// <summary>Gets or sets a name for this <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <returns>A name for this <see cref="T:System.Diagnostics.TraceListener" />. The default is an empty string ("").</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x00010AE2 File Offset: 0x0000ECE2
		// (set) Token: 0x060015A7 RID: 5543 RVA: 0x00010AEA File Offset: 0x0000ECEA
		public virtual string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether to indent the output.</summary>
		/// <returns>true if the output should be indented; otherwise, false.</returns>
		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x00010AF3 File Offset: 0x0000ECF3
		// (set) Token: 0x060015A9 RID: 5545 RVA: 0x00010AFB File Offset: 0x0000ECFB
		protected bool NeedIndent
		{
			get
			{
				return this.needIndent;
			}
			set
			{
				this.needIndent = value;
			}
		}

		/// <summary>Gets a value indicating whether the trace listener is thread safe. </summary>
		/// <returns>true if the trace listener is thread safe; otherwise, false. The default is false.</returns>
		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[global::System.MonoLimitation("This property exists but is never considered.")]
		public virtual bool IsThreadSafe
		{
			get
			{
				return false;
			}
		}

		/// <summary>When overridden in a derived class, closes the output stream so it no longer receives tracing or debugging output.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060015AB RID: 5547 RVA: 0x00010B04 File Offset: 0x0000ED04
		public virtual void Close()
		{
			this.Dispose();
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060015AC RID: 5548 RVA: 0x00010B0C File Offset: 0x0000ED0C
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Diagnostics.TraceListener" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		// Token: 0x060015AD RID: 5549 RVA: 0x000029F5 File Offset: 0x00000BF5
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Emits an error message to the listener you create when you implement the <see cref="T:System.Diagnostics.TraceListener" /> class.</summary>
		/// <param name="message">A message to emit. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060015AE RID: 5550 RVA: 0x00010B1B File Offset: 0x0000ED1B
		public virtual void Fail(string message)
		{
			this.Fail(message, string.Empty);
		}

		/// <summary>Emits an error message and a detailed error message to the listener you create when you implement the <see cref="T:System.Diagnostics.TraceListener" /> class.</summary>
		/// <param name="message">A message to emit. </param>
		/// <param name="detailMessage">A detailed message to emit. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060015AF RID: 5551 RVA: 0x00010B29 File Offset: 0x0000ED29
		public virtual void Fail(string message, string detailMessage)
		{
			this.WriteLine("---- DEBUG ASSERTION FAILED ----");
			this.WriteLine("---- Assert Short Message ----");
			this.WriteLine(message);
			this.WriteLine("---- Assert Long Message ----");
			this.WriteLine(detailMessage);
			this.WriteLine(string.Empty);
		}

		/// <summary>When overridden in a derived class, flushes the output buffer.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060015B0 RID: 5552 RVA: 0x000029F5 File Offset: 0x00000BF5
		public virtual void Flush()
		{
		}

		/// <summary>Writes the value of the object's <see cref="M:System.Object.ToString" /> method to the listener you create when you implement the <see cref="T:System.Diagnostics.TraceListener" /> class.</summary>
		/// <param name="o">An <see cref="T:System.Object" /> whose fully qualified class name you want to write. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060015B1 RID: 5553 RVA: 0x00010B65 File Offset: 0x0000ED65
		public virtual void Write(object o)
		{
			this.Write(o.ToString());
		}

		/// <summary>When overridden in a derived class, writes the specified message to the listener you create in the derived class.</summary>
		/// <param name="message">A message to write. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060015B2 RID: 5554
		public abstract void Write(string message);

		/// <summary>Writes a category name and the value of the object's <see cref="M:System.Object.ToString" /> method to the listener you create when you implement the <see cref="T:System.Diagnostics.TraceListener" /> class.</summary>
		/// <param name="o">An <see cref="T:System.Object" /> whose fully qualified class name you want to write. </param>
		/// <param name="category">A category name used to organize the output. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060015B3 RID: 5555 RVA: 0x00010B73 File Offset: 0x0000ED73
		public virtual void Write(object o, string category)
		{
			this.Write(o.ToString(), category);
		}

		/// <summary>Writes a category name and a message to the listener you create when you implement the <see cref="T:System.Diagnostics.TraceListener" /> class.</summary>
		/// <param name="message">A message to write. </param>
		/// <param name="category">A category name used to organize the output. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060015B4 RID: 5556 RVA: 0x00010B82 File Offset: 0x0000ED82
		public virtual void Write(string message, string category)
		{
			this.Write(category + ": " + message);
		}

		/// <summary>Writes the indent to the listener you create when you implement this class, and resets the <see cref="P:System.Diagnostics.TraceListener.NeedIndent" /> property to false.</summary>
		// Token: 0x060015B5 RID: 5557 RVA: 0x00042D40 File Offset: 0x00040F40
		protected virtual void WriteIndent()
		{
			this.NeedIndent = false;
			string text = new string(' ', this.IndentLevel * this.IndentSize);
			this.Write(text);
		}

		/// <summary>Writes the value of the object's <see cref="M:System.Object.ToString" /> method to the listener you create when you implement the <see cref="T:System.Diagnostics.TraceListener" /> class, followed by a line terminator.</summary>
		/// <param name="o">An <see cref="T:System.Object" /> whose fully qualified class name you want to write. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060015B6 RID: 5558 RVA: 0x00010B96 File Offset: 0x0000ED96
		public virtual void WriteLine(object o)
		{
			this.WriteLine(o.ToString());
		}

		/// <summary>When overridden in a derived class, writes a message to the listener you create in the derived class, followed by a line terminator.</summary>
		/// <param name="message">A message to write. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060015B7 RID: 5559
		public abstract void WriteLine(string message);

		/// <summary>Writes a category name and the value of the object's <see cref="M:System.Object.ToString" /> method to the listener you create when you implement the <see cref="T:System.Diagnostics.TraceListener" /> class, followed by a line terminator.</summary>
		/// <param name="o">An <see cref="T:System.Object" /> whose fully qualified class name you want to write. </param>
		/// <param name="category">A category name used to organize the output. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060015B8 RID: 5560 RVA: 0x00010BA4 File Offset: 0x0000EDA4
		public virtual void WriteLine(object o, string category)
		{
			this.WriteLine(o.ToString(), category);
		}

		/// <summary>Writes a category name and a message to the listener you create when you implement the <see cref="T:System.Diagnostics.TraceListener" /> class, followed by a line terminator.</summary>
		/// <param name="message">A message to write. </param>
		/// <param name="category">A category name used to organize the output. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060015B9 RID: 5561 RVA: 0x00010BB3 File Offset: 0x0000EDB3
		public virtual void WriteLine(string message, string category)
		{
			this.WriteLine(category + ": " + message);
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00042D70 File Offset: 0x00040F70
		internal static string FormatArray(ICollection list, string joiner)
		{
			string[] array = new string[list.Count];
			int num = 0;
			foreach (object obj in list)
			{
				array[num++] = ((obj == null) ? string.Empty : obj.ToString());
			}
			return string.Join(joiner, array);
		}

		/// <summary>Writes trace information, a data object and event information to the listener specific output.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="data">The trace data to emit.</param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x060015BB RID: 5563 RVA: 0x00042DF8 File Offset: 0x00040FF8
		[ComVisible(false)]
		public virtual void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
		{
			if (this.Filter != null && !this.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, data, null))
			{
				return;
			}
			this.WriteLine(string.Format("{0} {1}: {2} : {3}", new object[] { source, eventType, id, data }));
			if (eventCache == null)
			{
				return;
			}
			if ((this.TraceOutputOptions & TraceOptions.ProcessId) != TraceOptions.None)
			{
				this.WriteLine("    ProcessId=" + eventCache.ProcessId);
			}
			if ((this.TraceOutputOptions & TraceOptions.LogicalOperationStack) != TraceOptions.None)
			{
				this.WriteLine("    LogicalOperationStack=" + TraceListener.FormatArray(eventCache.LogicalOperationStack, ", "));
			}
			if ((this.TraceOutputOptions & TraceOptions.ThreadId) != TraceOptions.None)
			{
				this.WriteLine("    ThreadId=" + eventCache.ThreadId);
			}
			if ((this.TraceOutputOptions & TraceOptions.DateTime) != TraceOptions.None)
			{
				this.WriteLine("    DateTime=" + eventCache.DateTime.ToString("o"));
			}
			if ((this.TraceOutputOptions & TraceOptions.Timestamp) != TraceOptions.None)
			{
				this.WriteLine("    Timestamp=" + eventCache.Timestamp);
			}
			if ((this.TraceOutputOptions & TraceOptions.Callstack) != TraceOptions.None)
			{
				this.WriteLine("    Callstack=" + eventCache.Callstack);
			}
		}

		/// <summary>Writes trace information, an array of data objects and event information to the listener specific output.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="data">An array of objects to emit as data.</param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x060015BC RID: 5564 RVA: 0x00042F5C File Offset: 0x0004115C
		[ComVisible(false)]
		public virtual void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data)
		{
			if (this.Filter != null && !this.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, null, data))
			{
				return;
			}
			this.TraceData(eventCache, source, eventType, id, TraceListener.FormatArray(data, " "));
		}

		/// <summary>Writes trace and event information to the listener specific output.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x060015BD RID: 5565 RVA: 0x00010BC7 File Offset: 0x0000EDC7
		[ComVisible(false)]
		public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id)
		{
			this.TraceEvent(eventCache, source, eventType, id, null);
		}

		/// <summary>Writes trace information, a message, and event information to the listener specific output.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="message">A message to write.</param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x060015BE RID: 5566 RVA: 0x00010BD5 File Offset: 0x0000EDD5
		[ComVisible(false)]
		public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
			this.TraceData(eventCache, source, eventType, id, message);
		}

		/// <summary>Writes trace information, a formatted array of objects and event information to the listener specific output.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="format">A format string that contains zero or more format items, which correspond to objects in the <paramref name="args" /> array.</param>
		/// <param name="args">An object array containing zero or more objects to format.</param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x060015BF RID: 5567 RVA: 0x00010BE4 File Offset: 0x0000EDE4
		[ComVisible(false)]
		public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args)
		{
			this.TraceEvent(eventCache, source, eventType, id, string.Format(format, args));
		}

		/// <summary>Writes trace information, a message, a related activity identity and event information to the listener specific output.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="message">A message to write.</param>
		/// <param name="relatedActivityId"> A <see cref="T:System.Guid" />  object identifying a related activity.</param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x060015C0 RID: 5568 RVA: 0x00010BFA File Offset: 0x0000EDFA
		[ComVisible(false)]
		public virtual void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId)
		{
			this.TraceEvent(eventCache, source, TraceEventType.Transfer, id, string.Format("{0}, relatedActivityId={1}", message, relatedActivityId));
		}

		/// <summary>Gets the custom attributes supported by the trace listener.</summary>
		/// <returns>A string array naming the custom attributes supported by the trace listener, or null if there are no custom attributes.</returns>
		// Token: 0x060015C1 RID: 5569 RVA: 0x00002A97 File Offset: 0x00000C97
		protected internal virtual string[] GetSupportedAttributes()
		{
			return null;
		}

		/// <summary>Gets the custom trace listener attributes defined in the application configuration file.</summary>
		/// <returns>A <see cref="T:System.Collections.Specialized.StringDictionary" /> containing the custom attributes for the trace listener.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x00010C1D File Offset: 0x0000EE1D
		public global::System.Collections.Specialized.StringDictionary Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		/// <summary>Gets and sets the trace filter for the trace listener.</summary>
		/// <returns>An object derived from the <see cref="T:System.Diagnostics.TraceFilter" /> base class.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060015C3 RID: 5571 RVA: 0x00010C25 File Offset: 0x0000EE25
		// (set) Token: 0x060015C4 RID: 5572 RVA: 0x00010C2D File Offset: 0x0000EE2D
		[ComVisible(false)]
		public TraceFilter Filter
		{
			get
			{
				return this.filter;
			}
			set
			{
				this.filter = value;
			}
		}

		/// <summary>Gets or sets the trace output options.</summary>
		/// <returns>A bitwise combination of the enumeration values. The default is <see cref="F:System.Diagnostics.TraceOptions.None" />. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Set operation failed because the value is invalid.</exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060015C5 RID: 5573 RVA: 0x00010C36 File Offset: 0x0000EE36
		// (set) Token: 0x060015C6 RID: 5574 RVA: 0x00010C3E File Offset: 0x0000EE3E
		[ComVisible(false)]
		public TraceOptions TraceOutputOptions
		{
			get
			{
				return this.options;
			}
			set
			{
				this.options = value;
			}
		}

		// Token: 0x040006B4 RID: 1716
		[ThreadStatic]
		private int indentLevel;

		// Token: 0x040006B5 RID: 1717
		[ThreadStatic]
		private int indentSize = 4;

		// Token: 0x040006B6 RID: 1718
		[ThreadStatic]
		private global::System.Collections.Specialized.StringDictionary attributes = new global::System.Collections.Specialized.StringDictionary();

		// Token: 0x040006B7 RID: 1719
		[ThreadStatic]
		private TraceFilter filter;

		// Token: 0x040006B8 RID: 1720
		[ThreadStatic]
		private TraceOptions options;

		// Token: 0x040006B9 RID: 1721
		private string name;

		// Token: 0x040006BA RID: 1722
		private bool needIndent = true;
	}
}
