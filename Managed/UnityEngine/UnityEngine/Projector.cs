using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A script interface for a.</para>
	/// </summary>
	// Token: 0x02000025 RID: 37
	public sealed class Projector : Behaviour
	{
		/// <summary>
		///   <para>The near clipping plane distance.</para>
		/// </summary>
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001CA RID: 458
		// (set) Token: 0x060001CB RID: 459
		public extern float nearClipPlane
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The far clipping plane distance.</para>
		/// </summary>
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001CC RID: 460
		// (set) Token: 0x060001CD RID: 461
		public extern float farClipPlane
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The field of view of the projection in degrees.</para>
		/// </summary>
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001CE RID: 462
		// (set) Token: 0x060001CF RID: 463
		public extern float fieldOfView
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The aspect ratio of the projection.</para>
		/// </summary>
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001D0 RID: 464
		// (set) Token: 0x060001D1 RID: 465
		public extern float aspectRatio
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is the projection orthographic (true) or perspective (false)?</para>
		/// </summary>
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001D2 RID: 466
		// (set) Token: 0x060001D3 RID: 467
		public extern bool orthographic
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Projection's half-size when in orthographic mode.</para>
		/// </summary>
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001D4 RID: 468
		// (set) Token: 0x060001D5 RID: 469
		public extern float orthographicSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Which object layers are ignored by the projector.</para>
		/// </summary>
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001D6 RID: 470
		// (set) Token: 0x060001D7 RID: 471
		public extern int ignoreLayers
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The material that will be projected onto every object.</para>
		/// </summary>
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001D8 RID: 472
		// (set) Token: 0x060001D9 RID: 473
		public extern Material material
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
