using System;
using System.Collections;

namespace System.Configuration
{
	/// <summary>Represents a collection of key/value pairs used to describe a configuration object as well as a <see cref="T:System.Configuration.SettingsProperty" /> object.</summary>
	// Token: 0x020001F4 RID: 500
	[Serializable]
	public class SettingsAttributeDictionary : Hashtable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.SettingsAttributeDictionary" /> class. </summary>
		// Token: 0x06001118 RID: 4376 RVA: 0x0000DED0 File Offset: 0x0000C0D0
		public SettingsAttributeDictionary()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.SettingsAttributeDictionary" /> class. </summary>
		/// <param name="attributes"></param>
		// Token: 0x06001119 RID: 4377 RVA: 0x0000DED8 File Offset: 0x0000C0D8
		public SettingsAttributeDictionary(SettingsAttributeDictionary attributes)
			: base(attributes)
		{
		}
	}
}
