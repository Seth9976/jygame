using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Defines the type of mesh generated for a sprite.</para>
	/// </summary>
	// Token: 0x02000097 RID: 151
	public enum SpriteMeshType
	{
		/// <summary>
		///   <para>Rectangle mesh equal to the user specified sprite size.</para>
		/// </summary>
		// Token: 0x040001E3 RID: 483
		FullRect,
		/// <summary>
		///   <para>Tight mesh based on pixel alpha values. As many excess pixels are cropped as possible.</para>
		/// </summary>
		// Token: 0x040001E4 RID: 484
		Tight
	}
}
