using System;

namespace System.Diagnostics
{
	/// <summary>Provides a multilevel switch to control tracing and debug output without recompiling your code.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000256 RID: 598
	public class SourceSwitch : Switch
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.SourceSwitch" /> class, specifying the name of the source.</summary>
		/// <param name="name">The name of the source.</param>
		// Token: 0x060014EB RID: 5355 RVA: 0x000101E3 File Offset: 0x0000E3E3
		public SourceSwitch(string displayName)
			: this(displayName, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.SourceSwitch" /> class, specifying the display name and the default value for the source switch.</summary>
		/// <param name="displayName">The name of the source switch. </param>
		/// <param name="defaultSwitchValue">The default value for the switch. </param>
		// Token: 0x060014EC RID: 5356 RVA: 0x000101ED File Offset: 0x0000E3ED
		public SourceSwitch(string displayName, string defaultSwitchValue)
			: base(displayName, "Source switch.", defaultSwitchValue)
		{
		}

		/// <summary>Gets or sets the level of the switch.</summary>
		/// <returns>One of the <see cref="T:System.Diagnostics.SourceLevels" /> values that represents the event level of the switch.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x000101FC File Offset: 0x0000E3FC
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x00010204 File Offset: 0x0000E404
		public SourceLevels Level
		{
			get
			{
				return (SourceLevels)base.SwitchSetting;
			}
			set
			{
				base.SwitchSetting = (int)value;
			}
		}

		/// <summary>Determines if trace listeners should be called, based on the trace event type.</summary>
		/// <returns>True if the trace listeners should be called; otherwise, false.</returns>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values.</param>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060014EF RID: 5359 RVA: 0x00041F94 File Offset: 0x00040194
		public bool ShouldTrace(TraceEventType eventType)
		{
			switch (eventType)
			{
			case TraceEventType.Critical:
				return (this.Level & SourceLevels.Critical) != SourceLevels.Off;
			case TraceEventType.Error:
				return (this.Level & SourceLevels.Error) != SourceLevels.Off;
			default:
				if (eventType != TraceEventType.Verbose)
				{
					if (eventType != TraceEventType.Start && eventType != TraceEventType.Stop && eventType != TraceEventType.Suspend && eventType != TraceEventType.Resume && eventType != TraceEventType.Transfer)
					{
					}
					return (this.Level & SourceLevels.ActivityTracing) != SourceLevels.Off;
				}
				return (this.Level & SourceLevels.Verbose) != SourceLevels.Off;
			case TraceEventType.Warning:
				return (this.Level & SourceLevels.Warning) != SourceLevels.Off;
			case TraceEventType.Information:
				return (this.Level & SourceLevels.Information) != SourceLevels.Off;
			}
		}

		/// <summary>Invoked when the value of the <see cref="P:System.Diagnostics.Switch.Value" /> property changes.</summary>
		/// <exception cref="T:System.ArgumentException">The new value of <see cref="P:System.Diagnostics.Switch.Value" /> is not one of the <see cref="T:System.Diagnostics.SourceLevels" /> values.</exception>
		// Token: 0x060014F0 RID: 5360 RVA: 0x0001020D File Offset: 0x0000E40D
		protected override void OnValueChanged()
		{
			base.SwitchSetting = (int)Enum.Parse(typeof(SourceLevels), base.Value, true);
		}

		// Token: 0x0400065E RID: 1630
		private const string description = "Source switch.";
	}
}
