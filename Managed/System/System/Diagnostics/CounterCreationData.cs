using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	/// <summary>Defines the counter type, name, and Help string for a custom counter.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000216 RID: 534
	[global::System.ComponentModel.TypeConverter("System.Diagnostics.Design.CounterCreationDataConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[Serializable]
	public class CounterCreationData
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.CounterCreationData" /> class, to a counter of type NumberOfItems32, and with empty name and help strings.</summary>
		// Token: 0x060011C8 RID: 4552 RVA: 0x0000E528 File Offset: 0x0000C728
		public CounterCreationData()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.CounterCreationData" /> class, to a counter of the specified type, using the specified counter name and Help strings.</summary>
		/// <param name="counterName">The name of the counter, which must be unique within its category. </param>
		/// <param name="counterHelp">The text that describes the counter's behavior. </param>
		/// <param name="counterType">A <see cref="T:System.Diagnostics.PerformanceCounterType" /> that identifies the counter's behavior. </param>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">You have specified a value for <paramref name="counterType" /> that is not a member of the <see cref="T:System.Diagnostics.PerformanceCounterType" /> enumeration. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="counterHelp" /> is null. </exception>
		// Token: 0x060011C9 RID: 4553 RVA: 0x0000E53B File Offset: 0x0000C73B
		public CounterCreationData(string counterName, string counterHelp, PerformanceCounterType counterType)
		{
			this.CounterName = counterName;
			this.CounterHelp = counterHelp;
			this.CounterType = counterType;
		}

		/// <summary>Gets or sets the custom counter's description.</summary>
		/// <returns>The text that describes the counter's behavior.</returns>
		/// <exception cref="T:System.ArgumentNullException">The specified value is null.</exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x0000E563 File Offset: 0x0000C763
		// (set) Token: 0x060011CB RID: 4555 RVA: 0x0000E56B File Offset: 0x0000C76B
		[global::System.ComponentModel.DefaultValue("")]
		[MonitoringDescription("Description of this counter.")]
		public string CounterHelp
		{
			get
			{
				return this.help;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.help = value;
			}
		}

		/// <summary>Gets or sets the name of the custom counter.</summary>
		/// <returns>A name for the counter, which is unique in its category.</returns>
		/// <exception cref="T:System.ArgumentNullException">The specified value is null.</exception>
		/// <exception cref="T:System.ArgumentException">The specified value is not between 1 and 80 characters long or contains double quotes, control characters or leading or trailing spaces.</exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x0000E585 File Offset: 0x0000C785
		// (set) Token: 0x060011CD RID: 4557 RVA: 0x0000E58D File Offset: 0x0000C78D
		[global::System.ComponentModel.TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[MonitoringDescription("Name of this counter.")]
		[global::System.ComponentModel.DefaultValue("")]
		public string CounterName
		{
			get
			{
				return this.name;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (value == string.Empty)
				{
					throw new ArgumentException("value");
				}
				this.name = value;
			}
		}

		/// <summary>Gets or sets the performance counter type of the custom counter.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.PerformanceCounterType" /> that defines the behavior of the performance counter.</returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">You have specified a type that is not a member of the <see cref="T:System.Diagnostics.PerformanceCounterType" /> enumeration. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x0000E5C2 File Offset: 0x0000C7C2
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x0000E5CA File Offset: 0x0000C7CA
		[MonitoringDescription("Type of this counter.")]
		[global::System.ComponentModel.DefaultValue(typeof(PerformanceCounterType), "NumberOfItems32")]
		public PerformanceCounterType CounterType
		{
			get
			{
				return this.type;
			}
			set
			{
				if (!Enum.IsDefined(typeof(PerformanceCounterType), value))
				{
					throw new global::System.ComponentModel.InvalidEnumArgumentException();
				}
				this.type = value;
			}
		}

		// Token: 0x0400051D RID: 1309
		private string help = string.Empty;

		// Token: 0x0400051E RID: 1310
		private string name;

		// Token: 0x0400051F RID: 1311
		private PerformanceCounterType type;
	}
}
