using System;

namespace UnityEngine.Events
{
	/// <summary>
	///   <para>THe mode that a listener is operating in.</para>
	/// </summary>
	// Token: 0x020002E3 RID: 739
	[Serializable]
	public enum PersistentListenerMode
	{
		/// <summary>
		///   <para>The listener will use the function binding specified by the even.</para>
		/// </summary>
		// Token: 0x04000B72 RID: 2930
		EventDefined,
		/// <summary>
		///   <para>The listener will bind to zero argument functions.</para>
		/// </summary>
		// Token: 0x04000B73 RID: 2931
		Void,
		/// <summary>
		///   <para>The listener will bind to one argument Object functions.</para>
		/// </summary>
		// Token: 0x04000B74 RID: 2932
		Object,
		/// <summary>
		///   <para>The listener will bind to one argument int functions.</para>
		/// </summary>
		// Token: 0x04000B75 RID: 2933
		Int,
		/// <summary>
		///   <para>The listener will bind to one argument float functions.</para>
		/// </summary>
		// Token: 0x04000B76 RID: 2934
		Float,
		/// <summary>
		///   <para>The listener will bind to one argument string functions.</para>
		/// </summary>
		// Token: 0x04000B77 RID: 2935
		String,
		/// <summary>
		///   <para>The listener will bind to one argument bool functions.</para>
		/// </summary>
		// Token: 0x04000B78 RID: 2936
		Bool
	}
}
