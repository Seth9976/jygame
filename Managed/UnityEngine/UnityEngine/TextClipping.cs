using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Different methods for how the GUI system handles text being too large to fit the rectangle allocated.</para>
	/// </summary>
	// Token: 0x020001E8 RID: 488
	public enum TextClipping
	{
		/// <summary>
		///   <para>Text flows freely outside the element.</para>
		/// </summary>
		// Token: 0x04000798 RID: 1944
		Overflow,
		/// <summary>
		///   <para>Text gets clipped to be inside the element.</para>
		/// </summary>
		// Token: 0x04000799 RID: 1945
		Clip
	}
}
