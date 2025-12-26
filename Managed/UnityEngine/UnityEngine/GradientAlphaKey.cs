using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Alpha key used by Gradient.</para>
	/// </summary>
	// Token: 0x0200004E RID: 78
	public struct GradientAlphaKey
	{
		/// <summary>
		///   <para>Gradient alpha key.</para>
		/// </summary>
		/// <param name="alpha">Alpha of key (0 - 1).</param>
		/// <param name="time">Time of the key (0 - 1).</param>
		// Token: 0x06000423 RID: 1059 RVA: 0x00002C11 File Offset: 0x00000E11
		public GradientAlphaKey(float alpha, float time)
		{
			this.alpha = alpha;
			this.time = time;
		}

		/// <summary>
		///   <para>Alpha channel of key.</para>
		/// </summary>
		// Token: 0x040000BE RID: 190
		public float alpha;

		/// <summary>
		///   <para>Time of the key (0 - 1).</para>
		/// </summary>
		// Token: 0x040000BF RID: 191
		public float time;
	}
}
