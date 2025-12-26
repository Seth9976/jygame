using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Overrides the global Physics.queriesHitTriggers.</para>
	/// </summary>
	// Token: 0x02000100 RID: 256
	public enum QueryTriggerInteraction
	{
		/// <summary>
		///   <para>Queries use the global Physics.queriesHitTriggers setting.</para>
		/// </summary>
		// Token: 0x04000301 RID: 769
		UseGlobal,
		/// <summary>
		///   <para>Queries never report Trigger hits.</para>
		/// </summary>
		// Token: 0x04000302 RID: 770
		Ignore,
		/// <summary>
		///   <para>Queries always report Trigger hits.</para>
		/// </summary>
		// Token: 0x04000303 RID: 771
		Collide
	}
}
