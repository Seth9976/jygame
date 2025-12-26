using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Spectrum analysis windowing types.</para>
	/// </summary>
	// Token: 0x02000159 RID: 345
	public enum FFTWindow
	{
		/// <summary>
		///   <para>W[n] = 1.0.</para>
		/// </summary>
		// Token: 0x040003C7 RID: 967
		Rectangular,
		/// <summary>
		///   <para>W[n] = TRI(2n/N).</para>
		/// </summary>
		// Token: 0x040003C8 RID: 968
		Triangle,
		/// <summary>
		///   <para>W[n] = 0.54 - (0.46 * COS(n/N) ).</para>
		/// </summary>
		// Token: 0x040003C9 RID: 969
		Hamming,
		/// <summary>
		///   <para>W[n] = 0.5 * (1.0 - COS(n/N) ).</para>
		/// </summary>
		// Token: 0x040003CA RID: 970
		Hanning,
		/// <summary>
		///   <para>W[n] = 0.42 - (0.5 * COS(nN) ) + (0.08 * COS(2.0 * nN) ).</para>
		/// </summary>
		// Token: 0x040003CB RID: 971
		Blackman,
		/// <summary>
		///   <para>W[n] = 0.35875 - (0.48829 * COS(1.0 * nN)) + (0.14128 * COS(2.0 * nN)) - (0.01168 * COS(3.0 * n/N)).</para>
		/// </summary>
		// Token: 0x040003CC RID: 972
		BlackmanHarris
	}
}
