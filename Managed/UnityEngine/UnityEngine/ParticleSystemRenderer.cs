using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Renders particles on to the screen (Shuriken).</para>
	/// </summary>
	// Token: 0x020000E3 RID: 227
	public sealed class ParticleSystemRenderer : Renderer
	{
		/// <summary>
		///   <para>How particles are drawn.</para>
		/// </summary>
		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000DAB RID: 3499
		// (set) Token: 0x06000DAC RID: 3500
		public extern ParticleSystemRenderMode renderMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How much are the particles stretched in their direction of motion.</para>
		/// </summary>
		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000DAD RID: 3501
		// (set) Token: 0x06000DAE RID: 3502
		public extern float lengthScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How much are the particles strectched depending on "how fast they move".</para>
		/// </summary>
		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000DAF RID: 3503
		// (set) Token: 0x06000DB0 RID: 3504
		public extern float velocityScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How much are the particles strected depending on the Camera's speed.</para>
		/// </summary>
		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000DB1 RID: 3505
		// (set) Token: 0x06000DB2 RID: 3506
		public extern float cameraVelocityScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Clamp the maximum particle size.</para>
		/// </summary>
		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000DB3 RID: 3507
		// (set) Token: 0x06000DB4 RID: 3508
		public extern float maxParticleSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Mesh used as particle instead of billboarded texture.</para>
		/// </summary>
		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000DB5 RID: 3509
		// (set) Token: 0x06000DB6 RID: 3510
		public extern Mesh mesh
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
