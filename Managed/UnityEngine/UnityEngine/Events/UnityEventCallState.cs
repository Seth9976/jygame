using System;

namespace UnityEngine.Events
{
	/// <summary>
	///   <para>Controls the scope of UnityEvent callbacks.</para>
	/// </summary>
	// Token: 0x020002EC RID: 748
	public enum UnityEventCallState
	{
		/// <summary>
		///   <para>Callback is not issued.</para>
		/// </summary>
		// Token: 0x04000B89 RID: 2953
		Off,
		/// <summary>
		///   <para>Callback is always issued.</para>
		/// </summary>
		// Token: 0x04000B8A RID: 2954
		EditorAndRuntime,
		/// <summary>
		///   <para>Callback is only issued in the Runtime and Editor playmode.</para>
		/// </summary>
		// Token: 0x04000B8B RID: 2955
		RuntimeOnly
	}
}
