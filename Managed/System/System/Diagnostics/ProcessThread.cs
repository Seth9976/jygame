using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	/// <summary>Represents an operating system process thread.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000252 RID: 594
	[global::System.ComponentModel.Designer("System.Diagnostics.Design.ProcessThreadDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public class ProcessThread : global::System.ComponentModel.Component
	{
		// Token: 0x060014D5 RID: 5333 RVA: 0x00004F3E File Offset: 0x0000313E
		[global::System.MonoTODO("Parse parameters")]
		internal ProcessThread()
		{
		}

		/// <summary>Gets the base priority of the thread.</summary>
		/// <returns>The base priority of the thread, which the operating system computes by combining the process priority class with the priority level of the associated thread.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[global::System.MonoTODO]
		[MonitoringDescription("The base priority of this thread.")]
		public int BasePriority
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Gets the current priority of the thread.</summary>
		/// <returns>The current priority of the thread, which may deviate from the base priority based on how the operating system is scheduling the thread. The priority may be temporarily boosted for an active thread.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[MonitoringDescription("The current priority of this thread.")]
		[global::System.MonoTODO]
		public int CurrentPriority
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Gets the unique identifier of the thread.</summary>
		/// <returns>The unique identifier associated with a specific thread.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[global::System.MonoTODO]
		[MonitoringDescription("The ID of this thread.")]
		public int Id
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Sets the preferred processor for this thread to run on.</summary>
		/// <returns>The preferred processor for the thread, used when the system schedules threads, to determine which processor to run the thread on.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The system could not set the thread to start on the specified processor. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition. </exception>
		/// <exception cref="T:System.NotSupportedException">The process is on a remote computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x170004F3 RID: 1267
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.ComponentModel.Browsable(false)]
		[global::System.MonoTODO]
		public int IdealProcessor
		{
			set
			{
			}
		}

		/// <summary>Gets or sets a value indicating whether the operating system should temporarily boost the priority of the associated thread whenever the main window of the thread's process receives the focus.</summary>
		/// <returns>true to boost the thread's priority when the user interacts with the process's interface; otherwise, false. The default is false.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The priority boost information could not be retrieved.-or-The priority boost information could not be set. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition. </exception>
		/// <exception cref="T:System.NotSupportedException">The process is on a remote computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x00002AA1 File Offset: 0x00000CA1
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO]
		[MonitoringDescription("Thread gets a priority boot when interactively used by a user.")]
		public bool PriorityBoostEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the priority level of the thread.</summary>
		/// <returns>One of the <see cref="T:System.Diagnostics.ThreadPriorityLevel" /> values, specifying a range that bounds the thread's priority.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The thread priority level information could not be retrieved. -or-The thread priority level could not be set.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition. </exception>
		/// <exception cref="T:System.NotSupportedException">The process is on a remote computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x00010178 File Offset: 0x0000E378
		// (set) Token: 0x060014DD RID: 5341 RVA: 0x000029F5 File Offset: 0x00000BF5
		[MonitoringDescription("The priority level of this thread.")]
		[global::System.MonoTODO]
		public ThreadPriorityLevel PriorityLevel
		{
			get
			{
				return ThreadPriorityLevel.Idle;
			}
			set
			{
			}
		}

		/// <summary>Gets the amount of time that the thread has spent running code inside the operating system core.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> indicating the amount of time that the thread has spent running code inside the operating system core.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The thread time could not be retrieved. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition. </exception>
		/// <exception cref="T:System.NotSupportedException">The process is on a remote computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x0001017C File Offset: 0x0000E37C
		[global::System.MonoTODO]
		[MonitoringDescription("The amount of CPU time used in privileged mode.")]
		public TimeSpan PrivilegedProcessorTime
		{
			get
			{
				return new TimeSpan(0L);
			}
		}

		/// <summary>Sets the processors on which the associated thread can run.</summary>
		/// <returns>An <see cref="T:System.IntPtr" /> that points to a set of bits, each of which represents a processor that the thread can run on.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The processor affinity could not be set. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition. </exception>
		/// <exception cref="T:System.NotSupportedException">The process is on a remote computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x170004F7 RID: 1271
		// (set) Token: 0x060014DF RID: 5343 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO]
		[global::System.ComponentModel.Browsable(false)]
		public IntPtr ProcessorAffinity
		{
			set
			{
			}
		}

		/// <summary>Gets the memory address of the function that the operating system called that started this thread.</summary>
		/// <returns>The thread's starting address, which points to the application-defined function that the thread executes.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition. </exception>
		/// <exception cref="T:System.NotSupportedException">The process is on a remote computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x0000FC6E File Offset: 0x0000DE6E
		[global::System.MonoTODO]
		[MonitoringDescription("The start address in memory of this thread.")]
		public IntPtr StartAddress
		{
			get
			{
				return (IntPtr)0;
			}
		}

		/// <summary>Gets the time that the operating system started the thread.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> representing the time that was on the system when the operating system started the thread.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The thread time could not be retrieved. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition. </exception>
		/// <exception cref="T:System.NotSupportedException">The process is on a remote computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x00010185 File Offset: 0x0000E385
		[MonitoringDescription("The time this thread was started.")]
		[global::System.MonoTODO]
		public DateTime StartTime
		{
			get
			{
				return new DateTime(0L);
			}
		}

		/// <summary>Gets the current state of this thread.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.ThreadState" /> that indicates the thread's execution, for example, running, waiting, or terminated.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition. </exception>
		/// <exception cref="T:System.NotSupportedException">The process is on a remote computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[MonitoringDescription("The current state of this thread.")]
		[global::System.MonoTODO]
		public ThreadState ThreadState
		{
			get
			{
				return ThreadState.Initialized;
			}
		}

		/// <summary>Gets the total amount of time that this thread has spent using the processor.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> that indicates the amount of time that the thread has had control of the processor.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The thread time could not be retrieved. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition. </exception>
		/// <exception cref="T:System.NotSupportedException">The process is on a remote computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x0001017C File Offset: 0x0000E37C
		[global::System.MonoTODO]
		[MonitoringDescription("The total amount of CPU time used.")]
		public TimeSpan TotalProcessorTime
		{
			get
			{
				return new TimeSpan(0L);
			}
		}

		/// <summary>Gets the amount of time that the associated thread has spent running code inside the application.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> indicating the amount of time that the thread has spent running code inside the application, as opposed to inside the operating system core.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The thread time could not be retrieved. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition. </exception>
		/// <exception cref="T:System.NotSupportedException">The process is on a remote computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x0001017C File Offset: 0x0000E37C
		[global::System.MonoTODO]
		[MonitoringDescription("The amount of CPU time used in user mode.")]
		public TimeSpan UserProcessorTime
		{
			get
			{
				return new TimeSpan(0L);
			}
		}

		/// <summary>Gets the reason that the thread is waiting.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.ThreadWaitReason" /> representing the reason that the thread is in the wait state.</returns>
		/// <exception cref="T:System.InvalidOperationException">The thread is not in the wait state. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition. </exception>
		/// <exception cref="T:System.NotSupportedException">The process is on a remote computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[global::System.MonoTODO]
		[MonitoringDescription("The reason why this thread is waiting.")]
		public ThreadWaitReason WaitReason
		{
			get
			{
				return ThreadWaitReason.Executive;
			}
		}

		/// <summary>Resets the ideal processor for this thread to indicate that there is no single ideal processor. In other words, so that any processor is ideal.</summary>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The ideal processor could not be reset. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition. </exception>
		/// <exception cref="T:System.NotSupportedException">The process is on a remote computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x060014E6 RID: 5350 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO]
		public void ResetIdealProcessor()
		{
		}
	}
}
