using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A texture image used in a 2D GUI.</para>
	/// </summary>
	// Token: 0x0200003C RID: 60
	public sealed class GUITexture : GUIElement
	{
		/// <summary>
		///   <para>The color of the GUI texture.</para>
		/// </summary>
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0000FBDC File Offset: 0x0000DDDC
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00002885 File Offset: 0x00000A85
		public Color color
		{
			get
			{
				Color color;
				this.INTERNAL_get_color(out color);
				return color;
			}
			set
			{
				this.INTERNAL_set_color(ref value);
			}
		}

		// Token: 0x060002F0 RID: 752
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_color(out Color value);

		// Token: 0x060002F1 RID: 753
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_color(ref Color value);

		/// <summary>
		///   <para>The texture used for drawing.</para>
		/// </summary>
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002F2 RID: 754
		// (set) Token: 0x060002F3 RID: 755
		public extern Texture texture
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Pixel inset used for pixel adjustments for size and position.</para>
		/// </summary>
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000FBF4 File Offset: 0x0000DDF4
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x0000288F File Offset: 0x00000A8F
		public Rect pixelInset
		{
			get
			{
				Rect rect;
				this.INTERNAL_get_pixelInset(out rect);
				return rect;
			}
			set
			{
				this.INTERNAL_set_pixelInset(ref value);
			}
		}

		// Token: 0x060002F6 RID: 758
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_pixelInset(out Rect value);

		// Token: 0x060002F7 RID: 759
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_pixelInset(ref Rect value);

		/// <summary>
		///   <para>The border defines the number of pixels from the edge that are not affected by scale.</para>
		/// </summary>
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002F8 RID: 760
		// (set) Token: 0x060002F9 RID: 761
		public extern RectOffset border
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}
	}
}
