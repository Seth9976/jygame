using System;
using System.Runtime.Serialization;

namespace System.Configuration
{
	/// <summary>Provides an exception for <see cref="T:System.Configuration.SettingsProperty" /> objects that are not found.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020001FB RID: 507
	[Serializable]
	public class SettingsPropertyNotFoundException : Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.SettingsPropertyNotFoundException" /> class. </summary>
		// Token: 0x06001157 RID: 4439 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		public SettingsPropertyNotFoundException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.SettingsPropertyNotFoundException" /> class, based on a supplied parameter.</summary>
		/// <param name="message"></param>
		// Token: 0x06001158 RID: 4440 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
		public SettingsPropertyNotFoundException(string message)
			: base(message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.SettingsPropertyNotFoundException" /> class, based on supplied parameters.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		// Token: 0x06001159 RID: 4441 RVA: 0x0000E0BD File Offset: 0x0000C2BD
		protected SettingsPropertyNotFoundException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.SettingsPropertyNotFoundException" /> class, based on supplied parameters.</summary>
		/// <param name="message"></param>
		/// <param name="innerException">The exception that is the cause of the current exception.</param>
		// Token: 0x0600115A RID: 4442 RVA: 0x0000E0C7 File Offset: 0x0000C2C7
		public SettingsPropertyNotFoundException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
