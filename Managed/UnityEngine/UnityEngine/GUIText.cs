using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A text string displayed in a GUI.</para>
	/// </summary>
	// Token: 0x020001B1 RID: 433
	public sealed class GUIText : GUIElement
	{
		/// <summary>
		///   <para>The text to display.</para>
		/// </summary>
		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060018D3 RID: 6355
		// (set) Token: 0x060018D4 RID: 6356
		public extern string text
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The Material to use for rendering.</para>
		/// </summary>
		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060018D5 RID: 6357
		// (set) Token: 0x060018D6 RID: 6358
		public extern Material material
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x060018D7 RID: 6359
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_GetPixelOffset(out Vector2 output);

		// Token: 0x060018D8 RID: 6360 RVA: 0x00008B9F File Offset: 0x00006D9F
		private void Internal_SetPixelOffset(Vector2 p)
		{
			GUIText.INTERNAL_CALL_Internal_SetPixelOffset(this, ref p);
		}

		// Token: 0x060018D9 RID: 6361
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_SetPixelOffset(GUIText self, ref Vector2 p);

		/// <summary>
		///   <para>The pixel offset of the text.</para>
		/// </summary>
		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x0001B7C4 File Offset: 0x000199C4
		// (set) Token: 0x060018DB RID: 6363 RVA: 0x00008BA9 File Offset: 0x00006DA9
		public Vector2 pixelOffset
		{
			get
			{
				Vector2 vector;
				this.Internal_GetPixelOffset(out vector);
				return vector;
			}
			set
			{
				this.Internal_SetPixelOffset(value);
			}
		}

		/// <summary>
		///   <para>The font used for the text.</para>
		/// </summary>
		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060018DC RID: 6364
		// (set) Token: 0x060018DD RID: 6365
		public extern Font font
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The alignment of the text.</para>
		/// </summary>
		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060018DE RID: 6366
		// (set) Token: 0x060018DF RID: 6367
		public extern TextAlignment alignment
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The anchor of the text.</para>
		/// </summary>
		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060018E0 RID: 6368
		// (set) Token: 0x060018E1 RID: 6369
		public extern TextAnchor anchor
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The line spacing multiplier.</para>
		/// </summary>
		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060018E2 RID: 6370
		// (set) Token: 0x060018E3 RID: 6371
		public extern float lineSpacing
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The tab width multiplier.</para>
		/// </summary>
		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060018E4 RID: 6372
		// (set) Token: 0x060018E5 RID: 6373
		public extern float tabSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The font size to use (for dynamic fonts).</para>
		/// </summary>
		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060018E6 RID: 6374
		// (set) Token: 0x060018E7 RID: 6375
		public extern int fontSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The font style to use (for dynamic fonts).</para>
		/// </summary>
		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060018E8 RID: 6376
		// (set) Token: 0x060018E9 RID: 6377
		public extern FontStyle fontStyle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Enable HTML-style tags for Text Formatting Markup.</para>
		/// </summary>
		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060018EA RID: 6378
		// (set) Token: 0x060018EB RID: 6379
		public extern bool richText
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The color used to render the text.</para>
		/// </summary>
		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x0001B7DC File Offset: 0x000199DC
		// (set) Token: 0x060018ED RID: 6381 RVA: 0x00008BB2 File Offset: 0x00006DB2
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

		// Token: 0x060018EE RID: 6382
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_color(out Color value);

		// Token: 0x060018EF RID: 6383
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_color(ref Color value);
	}
}
