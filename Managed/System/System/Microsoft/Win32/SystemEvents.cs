using System;
using System.Collections;
using System.ComponentModel;
using System.Security.Permissions;
using System.Timers;

namespace Microsoft.Win32
{
	/// <summary>Provides access to system event notifications. This class cannot be inherited.</summary>
	// Token: 0x0200001A RID: 26
	[PermissionSet((SecurityAction)14, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	public sealed class SystemEvents
	{
		// Token: 0x060000FC RID: 252 RVA: 0x000021C3 File Offset: 0x000003C3
		private SystemEvents()
		{
		}

		/// <summary>Occurs when the user changes the display settings.</summary>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000FE RID: 254 RVA: 0x000029F5 File Offset: 0x00000BF5
		// (remove) Token: 0x060000FF RID: 255 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO]
		public static event EventHandler DisplaySettingsChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs when the display settings are changing.</summary>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000100 RID: 256 RVA: 0x000029F5 File Offset: 0x00000BF5
		// (remove) Token: 0x06000101 RID: 257 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO("Currently does nothing on Mono")]
		public static event EventHandler DisplaySettingsChanging
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs before the thread that listens for system events is terminated.</summary>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000102 RID: 258 RVA: 0x000029F5 File Offset: 0x00000BF5
		// (remove) Token: 0x06000103 RID: 259 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO("Currently does nothing on Mono")]
		public static event EventHandler EventsThreadShutdown
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs when the user adds fonts to or removes fonts from the system.</summary>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000104 RID: 260 RVA: 0x000029F5 File Offset: 0x00000BF5
		// (remove) Token: 0x06000105 RID: 261 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO("Currently does nothing on Mono")]
		public static event EventHandler InstalledFontsChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs when the system is running out of available RAM.</summary>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000106 RID: 262 RVA: 0x000029F5 File Offset: 0x00000BF5
		// (remove) Token: 0x06000107 RID: 263 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		[Obsolete("")]
		[global::System.MonoTODO("Currently does nothing on Mono")]
		public static event EventHandler LowMemory
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs when the user switches to an application that uses a different palette.</summary>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000108 RID: 264 RVA: 0x000029F5 File Offset: 0x00000BF5
		// (remove) Token: 0x06000109 RID: 265 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO("Currently does nothing on Mono")]
		public static event EventHandler PaletteChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs when the user suspends or resumes the system.</summary>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600010A RID: 266 RVA: 0x000029F5 File Offset: 0x00000BF5
		// (remove) Token: 0x0600010B RID: 267 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO("Currently does nothing on Mono")]
		public static event PowerModeChangedEventHandler PowerModeChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs when the user is logging off or shutting down the system.</summary>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600010C RID: 268 RVA: 0x000029F5 File Offset: 0x00000BF5
		// (remove) Token: 0x0600010D RID: 269 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO("Currently does nothing on Mono")]
		public static event SessionEndedEventHandler SessionEnded
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs when the user is trying to log off or shut down the system.</summary>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600010E RID: 270 RVA: 0x000029F5 File Offset: 0x00000BF5
		// (remove) Token: 0x0600010F RID: 271 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO("Currently does nothing on Mono")]
		public static event SessionEndingEventHandler SessionEnding
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs when the currently logged-in user has changed.</summary>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000110 RID: 272 RVA: 0x000029F5 File Offset: 0x00000BF5
		// (remove) Token: 0x06000111 RID: 273 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO("Currently does nothing on Mono")]
		public static event SessionSwitchEventHandler SessionSwitch
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs when the user changes the time on the system clock.</summary>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000112 RID: 274 RVA: 0x000029F5 File Offset: 0x00000BF5
		// (remove) Token: 0x06000113 RID: 275 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO("Currently does nothing on Mono")]
		public static event EventHandler TimeChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs when a windows timer interval has expired.</summary>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000114 RID: 276 RVA: 0x000029F7 File Offset: 0x00000BF7
		// (remove) Token: 0x06000115 RID: 277 RVA: 0x00002A0E File Offset: 0x00000C0E
		public static event TimerElapsedEventHandler TimerElapsed;

		/// <summary>Occurs when a user preference has changed.</summary>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000116 RID: 278 RVA: 0x000029F5 File Offset: 0x00000BF5
		// (remove) Token: 0x06000117 RID: 279 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO("Currently does nothing on Mono")]
		public static event UserPreferenceChangedEventHandler UserPreferenceChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Occurs when a user preference is changing.</summary>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000118 RID: 280 RVA: 0x000029F5 File Offset: 0x00000BF5
		// (remove) Token: 0x06000119 RID: 281 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO("Currently does nothing on Mono")]
		public static event UserPreferenceChangingEventHandler UserPreferenceChanging
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Creates a new window timer associated with the system events window.</summary>
		/// <returns>The ID of the new timer.</returns>
		/// <param name="interval">Specifies the interval between timer notifications, in milliseconds.</param>
		/// <exception cref="T:System.ArgumentException">The interval is less than or equal to zero. </exception>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed, or the attempt to create the timer did not succeed.</exception>
		// Token: 0x0600011A RID: 282 RVA: 0x00025EA8 File Offset: 0x000240A8
		public static IntPtr CreateTimer(int interval)
		{
			int hashCode = Guid.NewGuid().GetHashCode();
			global::System.Timers.Timer timer = new global::System.Timers.Timer((double)interval);
			timer.Elapsed += SystemEvents.InternalTimerElapsed;
			SystemEvents.TimerStore.Add(hashCode, timer);
			return new IntPtr(hashCode);
		}

		/// <summary>Terminates the timer specified by the given id.</summary>
		/// <param name="timerId">The ID of the timer to terminate. </param>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed, or the attempt to terminate the timer did not succeed. </exception>
		// Token: 0x0600011B RID: 283 RVA: 0x00025EF4 File Offset: 0x000240F4
		public static void KillTimer(IntPtr timerId)
		{
			global::System.Timers.Timer timer = (global::System.Timers.Timer)SystemEvents.TimerStore[timerId.GetHashCode()];
			timer.Stop();
			timer.Elapsed -= SystemEvents.InternalTimerElapsed;
			timer.Dispose();
			SystemEvents.TimerStore.Remove(timerId.GetHashCode());
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002A25 File Offset: 0x00000C25
		private static void InternalTimerElapsed(object e, global::System.Timers.ElapsedEventArgs args)
		{
			if (SystemEvents.TimerElapsed != null)
			{
				SystemEvents.TimerElapsed(null, new TimerElapsedEventArgs(IntPtr.Zero));
			}
		}

		/// <summary>Invokes the specified delegate using the thread that listens for system events.</summary>
		/// <param name="method">A delegate to invoke using the thread that listens for system events. </param>
		/// <exception cref="T:System.InvalidOperationException">System event notifications are not supported under the current context. Server processes, for example, might not support global system event notifications.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The attempt to create a system events window thread did not succeed.</exception>
		// Token: 0x0600011D RID: 285 RVA: 0x00002664 File Offset: 0x00000864
		[global::System.MonoTODO]
		public static void InvokeOnEventsThread(Delegate method)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000049 RID: 73
		private static Hashtable TimerStore = new Hashtable();
	}
}
