using System;

namespace System.ComponentModel
{
	/// <summary>Specifies that this object supports a simple, transacted notification for batch initialization.</summary>
	// Token: 0x02000173 RID: 371
	public interface ISupportInitialize
	{
		/// <summary>Signals the object that initialization is starting.</summary>
		// Token: 0x06000CEB RID: 3307
		void BeginInit();

		/// <summary>Signals the object that initialization is complete.</summary>
		// Token: 0x06000CEC RID: 3308
		void EndInit();
	}
}
