using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Options for how to send a message.</para>
	/// </summary>
	// Token: 0x02000006 RID: 6
	public enum SendMessageOptions
	{
		/// <summary>
		///   <para>A receiver is required for SendMessage.</para>
		/// </summary>
		// Token: 0x04000005 RID: 5
		RequireReceiver,
		/// <summary>
		///   <para>No receiver is required for SendMessage.</para>
		/// </summary>
		// Token: 0x04000006 RID: 6
		DontRequireReceiver
	}
}
