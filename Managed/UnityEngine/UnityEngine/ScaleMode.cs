using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Scaling mode to draw textures with.</para>
	/// </summary>
	// Token: 0x020001C6 RID: 454
	public enum ScaleMode
	{
		/// <summary>
		///   <para>Stretches the texture to fill the complete rectangle passed in to GUI.DrawTexture.</para>
		/// </summary>
		// Token: 0x040006E2 RID: 1762
		StretchToFill,
		/// <summary>
		///   <para>Scales the texture, maintaining aspect ratio, so it completely covers the position rectangle passed to GUI.DrawTexture. If the texture is being draw to a rectangle with a different aspect ratio than the original, the image is cropped.</para>
		/// </summary>
		// Token: 0x040006E3 RID: 1763
		ScaleAndCrop,
		/// <summary>
		///   <para>Scales the texture, maintaining aspect ratio, so it completely fits withing the position rectangle passed to GUI.DrawTexture.</para>
		/// </summary>
		// Token: 0x040006E4 RID: 1764
		ScaleToFit
	}
}
