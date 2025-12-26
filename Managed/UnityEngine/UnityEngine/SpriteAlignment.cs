using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>How a Sprite's graphic rectangle is aligned with its pivot point.</para>
	/// </summary>
	// Token: 0x02000094 RID: 148
	public enum SpriteAlignment
	{
		/// <summary>
		///   <para>Pivot is at the center of the graphic rectangle.</para>
		/// </summary>
		// Token: 0x040001D2 RID: 466
		Center,
		/// <summary>
		///   <para>Pivot is at the top left corner of the graphic rectangle.</para>
		/// </summary>
		// Token: 0x040001D3 RID: 467
		TopLeft,
		/// <summary>
		///   <para>Pivot is at the center of the top edge of the graphic rectangle.</para>
		/// </summary>
		// Token: 0x040001D4 RID: 468
		TopCenter,
		/// <summary>
		///   <para>Pivot is at the top right corner of the graphic rectangle.</para>
		/// </summary>
		// Token: 0x040001D5 RID: 469
		TopRight,
		/// <summary>
		///   <para>Pivot is at the center of the left edge of the graphic rectangle.</para>
		/// </summary>
		// Token: 0x040001D6 RID: 470
		LeftCenter,
		/// <summary>
		///   <para>Pivot is at the center of the right edge of the graphic rectangle.</para>
		/// </summary>
		// Token: 0x040001D7 RID: 471
		RightCenter,
		/// <summary>
		///   <para>Pivot is at the bottom left corner of the graphic rectangle.</para>
		/// </summary>
		// Token: 0x040001D8 RID: 472
		BottomLeft,
		/// <summary>
		///   <para>Pivot is at the center of the bottom edge of the graphic rectangle.</para>
		/// </summary>
		// Token: 0x040001D9 RID: 473
		BottomCenter,
		/// <summary>
		///   <para>Pivot is at the bottom right corner of the graphic rectangle.</para>
		/// </summary>
		// Token: 0x040001DA RID: 474
		BottomRight,
		/// <summary>
		///   <para>Pivot is at a custom position within the graphic rectangle.</para>
		/// </summary>
		// Token: 0x040001DB RID: 475
		Custom
	}
}
