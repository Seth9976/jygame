using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Renders a Sprite for 2D graphics.</para>
	/// </summary>
	// Token: 0x02000099 RID: 153
	public sealed class SpriteRenderer : Renderer
	{
		/// <summary>
		///   <para>The Sprite to render.</para>
		/// </summary>
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x000054FA File Offset: 0x000036FA
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00005502 File Offset: 0x00003702
		public Sprite sprite
		{
			get
			{
				return this.GetSprite_INTERNAL();
			}
			set
			{
				this.SetSprite_INTERNAL(value);
			}
		}

		// Token: 0x060008B4 RID: 2228
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Sprite GetSprite_INTERNAL();

		// Token: 0x060008B5 RID: 2229
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetSprite_INTERNAL(Sprite sprite);

		/// <summary>
		///   <para>Rendering color for the Sprite graphic.</para>
		/// </summary>
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x000156E0 File Offset: 0x000138E0
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x0000550B File Offset: 0x0000370B
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

		// Token: 0x060008B8 RID: 2232
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_color(out Color value);

		// Token: 0x060008B9 RID: 2233
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_color(ref Color value);
	}
}
