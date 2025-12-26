using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes different levels of log information the network layer supports.</para>
	/// </summary>
	// Token: 0x0200006B RID: 107
	public enum NetworkLogLevel
	{
		/// <summary>
		///   <para>Only report errors, otherwise silent.</para>
		/// </summary>
		// Token: 0x0400013F RID: 319
		Off,
		/// <summary>
		///   <para>Report informational messages like connectivity events.</para>
		/// </summary>
		// Token: 0x04000140 RID: 320
		Informational,
		/// <summary>
		///   <para>Full debug level logging down to each individual message being reported.</para>
		/// </summary>
		// Token: 0x04000141 RID: 321
		Full = 3
	}
}
