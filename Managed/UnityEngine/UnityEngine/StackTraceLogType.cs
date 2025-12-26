using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Stack trace logging options.</para>
	/// </summary>
	// Token: 0x020002E2 RID: 738
	public enum StackTraceLogType
	{
		/// <summary>
		///   <para>No stack trace will be outputed to log.</para>
		/// </summary>
		// Token: 0x04000B6E RID: 2926
		None,
		/// <summary>
		///   <para>Only managed stack trace will be outputed.</para>
		/// </summary>
		// Token: 0x04000B6F RID: 2927
		ScriptOnly,
		/// <summary>
		///   <para>Native and managed stack trace will be logged.</para>
		/// </summary>
		// Token: 0x04000B70 RID: 2928
		Full
	}
}
