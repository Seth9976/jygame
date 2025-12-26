using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Xml.Serialization;

namespace System.Diagnostics
{
	/// <summary>Provides an abstract base class to create new debugging and tracing switches.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000257 RID: 599
	public abstract class Switch
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Switch" /> class.</summary>
		/// <param name="displayName">The name of the switch. </param>
		/// <param name="description">The description for the switch. </param>
		// Token: 0x060014F1 RID: 5361 RVA: 0x00010230 File Offset: 0x0000E430
		protected Switch(string displayName, string description)
		{
			this.name = displayName;
			this.description = description;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Switch" /> class, specifying the display name, description, and default value for the switch. </summary>
		/// <param name="displayName">The name of the switch. </param>
		/// <param name="description">The description of the switch. </param>
		/// <param name="defaultSwitchValue">The default value for the switch.</param>
		// Token: 0x060014F2 RID: 5362 RVA: 0x00010251 File Offset: 0x0000E451
		protected Switch(string displayName, string description, string defaultSwitchValue)
			: this(displayName, description)
		{
			this.defaultSwitchValue = defaultSwitchValue;
		}

		/// <summary>Gets a description of the switch.</summary>
		/// <returns>The description of the switch. The default value is an empty string ("").</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x00010262 File Offset: 0x0000E462
		public string Description
		{
			get
			{
				return this.description;
			}
		}

		/// <summary>Gets a name used to identify the switch.</summary>
		/// <returns>The name used to identify the switch. The default value is an empty string ("").</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x0001026A File Offset: 0x0000E46A
		public string DisplayName
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets or sets the current setting for this switch.</summary>
		/// <returns>The current setting for this switch. The default is zero.</returns>
		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x00010272 File Offset: 0x0000E472
		// (set) Token: 0x060014F6 RID: 5366 RVA: 0x00010298 File Offset: 0x0000E498
		protected int SwitchSetting
		{
			get
			{
				if (!this.initialized)
				{
					this.initialized = true;
					this.GetConfigFileSetting();
					this.OnSwitchSettingChanged();
				}
				return this.switchSetting;
			}
			set
			{
				if (this.switchSetting != value)
				{
					this.switchSetting = value;
					this.OnSwitchSettingChanged();
				}
				this.initialized = true;
			}
		}

		/// <summary>Gets the custom switch attributes defined in the application configuration file.</summary>
		/// <returns>A <see cref="T:System.Collections.Specialized.StringDictionary" /> containing the case-insensitive custom attributes for the trace switch.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x000102BA File Offset: 0x0000E4BA
		[XmlIgnore]
		public global::System.Collections.Specialized.StringDictionary Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		/// <summary>Gets or sets the value of the switch.</summary>
		/// <returns>A string representing the value of the switch.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">The value is null.-or-The value does not consist solely of an optional negative sign followed by a sequence of digits ranging from 0 to 9.-or-The value represents a number less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x000102C2 File Offset: 0x0000E4C2
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x00042070 File Offset: 0x00040270
		protected string Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
				try
				{
					this.OnValueChanged();
				}
				catch (Exception ex)
				{
					string text = string.Format("The config value for Switch '{0}' was invalid.", this.DisplayName);
					throw new ConfigurationErrorsException(text, ex);
				}
			}
		}

		/// <summary>Gets the custom attributes supported by the switch.</summary>
		/// <returns>A string array that contains the names of the custom attributes supported by the switch, or null if there no custom attributes are supported.</returns>
		// Token: 0x060014FA RID: 5370 RVA: 0x00002A97 File Offset: 0x00000C97
		protected internal virtual string[] GetSupportedAttributes()
		{
			return null;
		}

		/// <summary>Invoked when the <see cref="P:System.Diagnostics.Switch.Value" /> property is changed.</summary>
		// Token: 0x060014FB RID: 5371 RVA: 0x000029F5 File Offset: 0x00000BF5
		protected virtual void OnValueChanged()
		{
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x000420C0 File Offset: 0x000402C0
		private void GetConfigFileSetting()
		{
			IDictionary dictionary = (IDictionary)DiagnosticsConfiguration.Settings["switches"];
			if (dictionary != null && dictionary.Contains(this.name))
			{
				this.Value = dictionary[this.name] as string;
				return;
			}
			if (this.defaultSwitchValue != null)
			{
				this.value = this.defaultSwitchValue;
				this.OnValueChanged();
			}
		}

		/// <summary>Invoked when the <see cref="P:System.Diagnostics.Switch.SwitchSetting" /> property is changed.</summary>
		// Token: 0x060014FD RID: 5373 RVA: 0x000029F5 File Offset: 0x00000BF5
		protected virtual void OnSwitchSettingChanged()
		{
		}

		// Token: 0x0400065F RID: 1631
		private string name;

		// Token: 0x04000660 RID: 1632
		private string description;

		// Token: 0x04000661 RID: 1633
		private int switchSetting;

		// Token: 0x04000662 RID: 1634
		private string value;

		// Token: 0x04000663 RID: 1635
		private string defaultSwitchValue;

		// Token: 0x04000664 RID: 1636
		private bool initialized;

		// Token: 0x04000665 RID: 1637
		private global::System.Collections.Specialized.StringDictionary attributes = new global::System.Collections.Specialized.StringDictionary();
	}
}
