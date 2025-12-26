using System;
using System.Collections;
using System.Threading;

namespace System.Diagnostics
{
	/// <summary>Provides trace event data specific to a thread and a process.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000260 RID: 608
	public class TraceEventCache
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TraceEventCache" /> class. </summary>
		// Token: 0x0600154E RID: 5454 RVA: 0x00042268 File Offset: 0x00040468
		public TraceEventCache()
		{
			this.started = DateTime.Now;
			this.manager = Trace.CorrelationManager;
			this.callstack = Environment.StackTrace;
			this.timestamp = Stopwatch.GetTimestamp();
			this.thread = Thread.CurrentThread.Name;
			this.process = Process.GetCurrentProcess().Id;
		}

		/// <summary>Gets the call stack for the current thread.</summary>
		/// <returns>A string containing stack trace information. This value can be an empty string ("").</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" />
		/// </PermissionSet>
		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x00010689 File Offset: 0x0000E889
		public string Callstack
		{
			get
			{
				return this.callstack;
			}
		}

		/// <summary>Gets the date and time at which the event trace occurred.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> structure whose value is a date and time expressed in Coordinated Universal Time (UTC).</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x00010691 File Offset: 0x0000E891
		public DateTime DateTime
		{
			get
			{
				return this.started;
			}
		}

		/// <summary>Gets the correlation data, contained in a stack. </summary>
		/// <returns>A <see cref="T:System.Collections.Stack" /> containing correlation data.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x00010699 File Offset: 0x0000E899
		public Stack LogicalOperationStack
		{
			get
			{
				return this.manager.LogicalOperationStack;
			}
		}

		/// <summary>Gets the unique identifier of the current process.</summary>
		/// <returns>The system-generated unique identifier of the current process.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x000106A6 File Offset: 0x0000E8A6
		public int ProcessId
		{
			get
			{
				return this.process;
			}
		}

		/// <summary>Gets a unique identifier for the current managed thread.  </summary>
		/// <returns>A string that represents a unique integer identifier for this managed thread.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x000106AE File Offset: 0x0000E8AE
		public string ThreadId
		{
			get
			{
				return this.thread;
			}
		}

		/// <summary>Gets the current number of ticks in the timer mechanism.</summary>
		/// <returns>The tick counter value of the underlying timer mechanism.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x000106B6 File Offset: 0x0000E8B6
		public long Timestamp
		{
			get
			{
				return this.timestamp;
			}
		}

		// Token: 0x04000690 RID: 1680
		private DateTime started;

		// Token: 0x04000691 RID: 1681
		private CorrelationManager manager;

		// Token: 0x04000692 RID: 1682
		private string callstack;

		// Token: 0x04000693 RID: 1683
		private string thread;

		// Token: 0x04000694 RID: 1684
		private int process;

		// Token: 0x04000695 RID: 1685
		private long timestamp;
	}
}
