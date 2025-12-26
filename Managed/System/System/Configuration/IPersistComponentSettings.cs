using System;

namespace System.Configuration
{
	/// <summary>Defines standard functionality for controls or libraries that store and retrieve application settings.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020001EA RID: 490
	public interface IPersistComponentSettings
	{
		/// <summary>Gets or sets a value indicating whether the control should automatically persist its application settings properties.</summary>
		/// <returns>true if the control should automatically persist its state; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060010E5 RID: 4325
		// (set) Token: 0x060010E6 RID: 4326
		bool SaveSettings { get; set; }

		/// <summary>Gets or sets the value of the application settings key for the current instance of the control.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the settings key for the current instance of the control.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060010E7 RID: 4327
		// (set) Token: 0x060010E8 RID: 4328
		string SettingsKey { get; set; }

		/// <summary>Reads the control's application settings into their corresponding properties and updates the control's state.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060010E9 RID: 4329
		void LoadComponentSettings();

		/// <summary>Resets the control's application settings properties to their default values.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x060010EA RID: 4330
		void ResetComponentSettings();

		/// <summary>Persists the control's application settings properties.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060010EB RID: 4331
		void SaveComponentSettings();
	}
}
