using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Replaces the standard common language runtime (CLR) free-threaded marshaler with the standard OLE STA marshaler. </summary>
	// Token: 0x020004E9 RID: 1257
	[global::System.MonoLimitation("The runtime does nothing special apart from what it already does with marshal-by-ref objects")]
	[ComVisible(true)]
	public class StandardOleMarshalObject : MarshalByRefObject
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.StandardOleMarshalObject" /> class. </summary>
		// Token: 0x06002C61 RID: 11361 RVA: 0x0001B2CD File Offset: 0x000194CD
		protected StandardOleMarshalObject()
		{
		}
	}
}
