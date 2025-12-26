using System;

namespace System.Configuration
{
	/// <summary>Determines the serialization scheme used to store application settings.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000203 RID: 515
	public enum SettingsSerializeAs
	{
		/// <summary>The settings property is serialized as plain text.</summary>
		// Token: 0x04000509 RID: 1289
		String,
		/// <summary>The settings property is serialized as XML using XML serialization.</summary>
		// Token: 0x0400050A RID: 1290
		Xml,
		/// <summary>The settings property is serialized using binary object serialization.</summary>
		// Token: 0x0400050B RID: 1291
		Binary,
		/// <summary>The settings provider has implicit knowledge of the property or its type and picks an appropriate serialization mechanism. Often used for custom serialization.</summary>
		// Token: 0x0400050C RID: 1292
		ProviderSpecific
	}
}
