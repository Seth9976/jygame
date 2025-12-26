using System;

namespace System.Configuration
{
	/// <summary>Specifies the special setting category of a application settings property.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x0200020B RID: 523
	public enum SpecialSetting
	{
		/// <summary>The configuration property represents a connection string, typically for a data store or network resource. </summary>
		// Token: 0x04000515 RID: 1301
		ConnectionString,
		/// <summary>The configuration property represents a Uniform Resource Locator (URL) to a Web service.</summary>
		// Token: 0x04000516 RID: 1302
		WebServiceUrl
	}
}
