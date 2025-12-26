using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The trail renderer is used to make trails behind objects in the scene as they move about.</para>
	/// </summary>
	// Token: 0x02000027 RID: 39
	public sealed class TrailRenderer : Renderer
	{
		/// <summary>
		///   <para>How long does the trail take to fade out.</para>
		/// </summary>
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001DE RID: 478
		// (set) Token: 0x060001DF RID: 479
		public extern float time
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The width of the trail at the spawning point.</para>
		/// </summary>
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001E0 RID: 480
		// (set) Token: 0x060001E1 RID: 481
		public extern float startWidth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The width of the trail at the end of the trail.</para>
		/// </summary>
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001E2 RID: 482
		// (set) Token: 0x060001E3 RID: 483
		public extern float endWidth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Does the GameObject of this trail renderer auto destructs?</para>
		/// </summary>
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001E4 RID: 484
		// (set) Token: 0x060001E5 RID: 485
		public extern bool autodestruct
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
