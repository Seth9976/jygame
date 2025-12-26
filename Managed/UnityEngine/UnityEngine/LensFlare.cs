using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Script interface for a.</para>
	/// </summary>
	// Token: 0x02000023 RID: 35
	public sealed class LensFlare : Behaviour
	{
		/// <summary>
		///   <para>The to use.</para>
		/// </summary>
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000186 RID: 390
		// (set) Token: 0x06000187 RID: 391
		public extern Flare flare
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The strength of the flare.</para>
		/// </summary>
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000188 RID: 392
		// (set) Token: 0x06000189 RID: 393
		public extern float brightness
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The fade speed of the flare.</para>
		/// </summary>
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600018A RID: 394
		// (set) Token: 0x0600018B RID: 395
		public extern float fadeSpeed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The color of the flare.</para>
		/// </summary>
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0000F360 File Offset: 0x0000D560
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00002442 File Offset: 0x00000642
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

		// Token: 0x0600018E RID: 398
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_color(out Color value);

		// Token: 0x0600018F RID: 399
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_color(ref Color value);
	}
}
