using System;
using System.Runtime.InteropServices;

namespace System.Configuration
{
	/// <summary>Provides standard configuration methods.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020001E5 RID: 485
	[ComVisible(false)]
	public interface IConfigurationSystem
	{
		/// <summary>Gets the specified configuration.</summary>
		/// <returns>The object representing the configuration.</returns>
		/// <param name="configKey">The configuration key.</param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060010D1 RID: 4305
		object GetConfig(string configKey);

		/// <summary>Used for initialization.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060010D2 RID: 4306
		void Init();
	}
}
