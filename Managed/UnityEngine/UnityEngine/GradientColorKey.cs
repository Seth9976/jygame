using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Color key used by Gradient.</para>
	/// </summary>
	// Token: 0x0200004D RID: 77
	public struct GradientColorKey
	{
		/// <summary>
		///   <para>Gradient color key.</para>
		/// </summary>
		/// <param name="color">Color of key.</param>
		/// <param name="time">Time of the key (0 - 1).</param>
		/// <param name="col"></param>
		// Token: 0x06000422 RID: 1058 RVA: 0x00002C01 File Offset: 0x00000E01
		public GradientColorKey(Color col, float time)
		{
			this.color = col;
			this.time = time;
		}

		/// <summary>
		///   <para>Color of key.</para>
		/// </summary>
		// Token: 0x040000BC RID: 188
		public Color color;

		/// <summary>
		///   <para>Time of the key (0 - 1).</para>
		/// </summary>
		// Token: 0x040000BD RID: 189
		public float time;
	}
}
