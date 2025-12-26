using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Suspends the coroutine execution for the given amount of seconds.</para>
	/// </summary>
	// Token: 0x0200000E RID: 14
	[StructLayout(LayoutKind.Sequential)]
	public sealed class WaitForSeconds : YieldInstruction
	{
		/// <summary>
		///   <para>Creates a yield instruction to wait for a given number of seconds.</para>
		/// </summary>
		/// <param name="seconds"></param>
		// Token: 0x0600005A RID: 90 RVA: 0x000021E4 File Offset: 0x000003E4
		public WaitForSeconds(float seconds)
		{
			this.m_Seconds = seconds;
		}

		// Token: 0x04000067 RID: 103
		internal float m_Seconds;
	}
}
