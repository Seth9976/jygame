using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A script interface for the.</para>
	/// </summary>
	// Token: 0x020001B2 RID: 434
	public sealed class TextMesh : Component
	{
		/// <summary>
		///   <para>The text that is displayed.</para>
		/// </summary>
		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060018F1 RID: 6385
		// (set) Token: 0x060018F2 RID: 6386
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
		///   <para>The Font used.</para>
		/// </summary>
		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060018F3 RID: 6387
		// (set) Token: 0x060018F4 RID: 6388
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
		///   <para>The font size to use (for dynamic fonts).</para>
		/// </summary>
		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060018F5 RID: 6389
		// (set) Token: 0x060018F6 RID: 6390
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
		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060018F7 RID: 6391
		// (set) Token: 0x060018F8 RID: 6392
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
		///   <para>How far should the text be offset from the transform.position.z when drawing.</para>
		/// </summary>
		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060018F9 RID: 6393
		// (set) Token: 0x060018FA RID: 6394
		public extern float offsetZ
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How lines of text are aligned (Left, Right, Center).</para>
		/// </summary>
		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060018FB RID: 6395
		// (set) Token: 0x060018FC RID: 6396
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
		///   <para>Which point of the text shares the position of the Transform.</para>
		/// </summary>
		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060018FD RID: 6397
		// (set) Token: 0x060018FE RID: 6398
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
		///   <para>The size of each character (This scales the whole text).</para>
		/// </summary>
		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060018FF RID: 6399
		// (set) Token: 0x06001900 RID: 6400
		public extern float characterSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How much space will be in-between lines of text.</para>
		/// </summary>
		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001901 RID: 6401
		// (set) Token: 0x06001902 RID: 6402
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
		///   <para>How much space will be inserted for a tab '\t' character. This is a multiplum of the 'spacebar' character offset.</para>
		/// </summary>
		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001903 RID: 6403
		// (set) Token: 0x06001904 RID: 6404
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
		///   <para>Enable HTML-style tags for Text Formatting Markup.</para>
		/// </summary>
		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001905 RID: 6405
		// (set) Token: 0x06001906 RID: 6406
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
		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x0001B7F4 File Offset: 0x000199F4
		// (set) Token: 0x06001908 RID: 6408 RVA: 0x00008BBC File Offset: 0x00006DBC
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

		// Token: 0x06001909 RID: 6409
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_color(out Color value);

		// Token: 0x0600190A RID: 6410
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_color(ref Color value);
	}
}
