using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The type of the log message in the delegate registered with Application.RegisterLogCallback.</para>
	/// </summary>
	// Token: 0x0200000B RID: 11
	public enum LogType
	{
		/// <summary>
		///   <para>LogType used for Errors.</para>
		/// </summary>
		// Token: 0x0400005D RID: 93
		Error,
		/// <summary>
		///   <para>LogType used for Asserts. (These could also indicate an error inside Unity itself.)</para>
		/// </summary>
		// Token: 0x0400005E RID: 94
		Assert,
		/// <summary>
		///   <para>LogType used for Warnings.</para>
		/// </summary>
		// Token: 0x0400005F RID: 95
		Warning,
		/// <summary>
		///   <para>LogType used for regular log messages.</para>
		/// </summary>
		// Token: 0x04000060 RID: 96
		Log,
		/// <summary>
		///   <para>LogType used for Exceptions.</para>
		/// </summary>
		// Token: 0x04000061 RID: 97
		Exception
	}
}
