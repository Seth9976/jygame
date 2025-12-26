using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>(Legacy Particles) Renders particles on to the screen.</para>
	/// </summary>
	// Token: 0x020000EE RID: 238
	public sealed class ParticleRenderer : Renderer
	{
		/// <summary>
		///   <para>How particles are drawn.</para>
		/// </summary>
		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000E22 RID: 3618
		// (set) Token: 0x06000E23 RID: 3619
		public extern ParticleRenderMode particleRenderMode
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
		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000E24 RID: 3620
		// (set) Token: 0x06000E25 RID: 3621
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
		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000E26 RID: 3622
		// (set) Token: 0x06000E27 RID: 3623
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
		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000E28 RID: 3624
		// (set) Token: 0x06000E29 RID: 3625
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
		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000E2A RID: 3626
		// (set) Token: 0x06000E2B RID: 3627
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
		///   <para>Set horizontal tiling count.</para>
		/// </summary>
		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000E2C RID: 3628
		// (set) Token: 0x06000E2D RID: 3629
		public extern int uvAnimationXTile
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set vertical tiling count.</para>
		/// </summary>
		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000E2E RID: 3630
		// (set) Token: 0x06000E2F RID: 3631
		public extern int uvAnimationYTile
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set uv animation cycles.</para>
		/// </summary>
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000E30 RID: 3632
		// (set) Token: 0x06000E31 RID: 3633
		public extern float uvAnimationCycles
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x00006B8A File Offset: 0x00004D8A
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x00006B92 File Offset: 0x00004D92
		[Obsolete("animatedTextureCount has been replaced by uvAnimationXTile and uvAnimationYTile.")]
		public int animatedTextureCount
		{
			get
			{
				return this.uvAnimationXTile;
			}
			set
			{
				this.uvAnimationXTile = value;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00006B9B File Offset: 0x00004D9B
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00006BA3 File Offset: 0x00004DA3
		public float maxPartileSize
		{
			get
			{
				return this.maxParticleSize;
			}
			set
			{
				this.maxParticleSize = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000E36 RID: 3638
		// (set) Token: 0x06000E37 RID: 3639
		public extern Rect[] uvTiles
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("This function has been removed.", true)]
		public AnimationCurve widthCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("This function has been removed.", true)]
		public AnimationCurve heightCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("This function has been removed.", true)]
		public AnimationCurve rotationCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
