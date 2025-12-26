using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes phase of a finger touch.</para>
	/// </summary>
	// Token: 0x020000B9 RID: 185
	public enum TouchPhase
	{
		/// <summary>
		///   <para>A finger touched the screen.</para>
		/// </summary>
		// Token: 0x0400021C RID: 540
		Began,
		/// <summary>
		///   <para>A finger moved on the screen.</para>
		/// </summary>
		// Token: 0x0400021D RID: 541
		Moved,
		/// <summary>
		///   <para>A finger is touching the screen but hasn't moved.</para>
		/// </summary>
		// Token: 0x0400021E RID: 542
		Stationary,
		/// <summary>
		///   <para>A finger was lifted from the screen. This is the final phase of a touch.</para>
		/// </summary>
		// Token: 0x0400021F RID: 543
		Ended,
		/// <summary>
		///   <para>The system cancelled tracking for the touch.</para>
		/// </summary>
		// Token: 0x04000220 RID: 544
		Canceled
	}
}
