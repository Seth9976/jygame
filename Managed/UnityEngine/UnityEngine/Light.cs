using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine
{
	/// <summary>
	///   <para>Script interface for.</para>
	/// </summary>
	// Token: 0x020000C8 RID: 200
	public sealed class Light : Behaviour
	{
		/// <summary>
		///   <para>The type of the light.</para>
		/// </summary>
		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000B9F RID: 2975
		// (set) Token: 0x06000BA0 RID: 2976
		public extern LightType type
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The color of the light.</para>
		/// </summary>
		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x00017224 File Offset: 0x00015424
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x00006166 File Offset: 0x00004366
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

		// Token: 0x06000BA3 RID: 2979
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_color(out Color value);

		// Token: 0x06000BA4 RID: 2980
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_color(ref Color value);

		/// <summary>
		///   <para>The Intensity of a light is multiplied with the Light color.</para>
		/// </summary>
		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000BA5 RID: 2981
		// (set) Token: 0x06000BA6 RID: 2982
		public extern float intensity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The multiplier that defines the strength of the bounce lighting.</para>
		/// </summary>
		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000BA7 RID: 2983
		// (set) Token: 0x06000BA8 RID: 2984
		public extern float bounceIntensity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How this light casts shadows</para>
		/// </summary>
		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000BA9 RID: 2985
		// (set) Token: 0x06000BAA RID: 2986
		public extern LightShadows shadows
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Strength of light's shadows.</para>
		/// </summary>
		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000BAB RID: 2987
		// (set) Token: 0x06000BAC RID: 2988
		public extern float shadowStrength
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Shadow mapping constant bias.</para>
		/// </summary>
		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000BAD RID: 2989
		// (set) Token: 0x06000BAE RID: 2990
		public extern float shadowBias
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Shadow mapping normal-based bias.</para>
		/// </summary>
		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000BAF RID: 2991
		// (set) Token: 0x06000BB0 RID: 2992
		public extern float shadowNormalBias
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000BB1 RID: 2993
		// (set) Token: 0x06000BB2 RID: 2994
		[Obsolete("Shadow softness is removed in Unity 5.0+")]
		public extern float shadowSoftness
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000BB3 RID: 2995
		// (set) Token: 0x06000BB4 RID: 2996
		[Obsolete("Shadow softness is removed in Unity 5.0+")]
		public extern float shadowSoftnessFade
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The range of the light.</para>
		/// </summary>
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000BB5 RID: 2997
		// (set) Token: 0x06000BB6 RID: 2998
		public extern float range
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The angle of the light's spotlight cone in degrees.</para>
		/// </summary>
		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000BB7 RID: 2999
		// (set) Token: 0x06000BB8 RID: 3000
		public extern float spotAngle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The size of a directional light's cookie.</para>
		/// </summary>
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000BB9 RID: 3001
		// (set) Token: 0x06000BBA RID: 3002
		public extern float cookieSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The cookie texture projected by the light.</para>
		/// </summary>
		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000BBB RID: 3003
		// (set) Token: 0x06000BBC RID: 3004
		public extern Texture cookie
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The to use for this light.</para>
		/// </summary>
		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000BBD RID: 3005
		// (set) Token: 0x06000BBE RID: 3006
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
		///   <para>How to render the light.</para>
		/// </summary>
		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000BBF RID: 3007
		// (set) Token: 0x06000BC0 RID: 3008
		public extern LightRenderMode renderMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Has the light already been lightmapped.</para>
		/// </summary>
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000BC1 RID: 3009
		// (set) Token: 0x06000BC2 RID: 3010
		public extern bool alreadyLightmapped
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>This is used to light certain objects in the scene selectively.</para>
		/// </summary>
		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000BC3 RID: 3011
		// (set) Token: 0x06000BC4 RID: 3012
		public extern int cullingMask
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Add a command buffer to be executed at a specified place.</para>
		/// </summary>
		/// <param name="evt">When to execute the command buffer during rendering.</param>
		/// <param name="buffer">The buffer to execute.</param>
		// Token: 0x06000BC5 RID: 3013
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddCommandBuffer(LightEvent evt, CommandBuffer buffer);

		/// <summary>
		///   <para>Remove command buffer from execution at a specified place.</para>
		/// </summary>
		/// <param name="evt">When to execute the command buffer during rendering.</param>
		/// <param name="buffer">The buffer to execute.</param>
		// Token: 0x06000BC6 RID: 3014
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer);

		/// <summary>
		///   <para>Remove command buffers from execution at a specified place.</para>
		/// </summary>
		/// <param name="evt">When to execute the command buffer during rendering.</param>
		// Token: 0x06000BC7 RID: 3015
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveCommandBuffers(LightEvent evt);

		/// <summary>
		///   <para>Remove all command buffers set on this light.</para>
		/// </summary>
		// Token: 0x06000BC8 RID: 3016
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveAllCommandBuffers();

		/// <summary>
		///   <para>Get command buffers to be executed at a specified place.</para>
		/// </summary>
		/// <param name="evt">When to execute the command buffer during rendering.</param>
		/// <returns>
		///   <para>Array of command buffers.</para>
		/// </returns>
		// Token: 0x06000BC9 RID: 3017
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern CommandBuffer[] GetCommandBuffers(LightEvent evt);

		/// <summary>
		///   <para>Number of command buffers set up on this light (Read Only).</para>
		/// </summary>
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000BCA RID: 3018
		public extern int commandBufferCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000BCB RID: 3019
		// (set) Token: 0x06000BCC RID: 3020
		public static extern int pixelLightCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000BCD RID: 3021
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Light[] GetLights(LightType type, int layer);

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x00006170 File Offset: 0x00004370
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("light.shadowConstantBias was removed, use light.shadowBias", true)]
		public float shadowConstantBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x00006170 File Offset: 0x00004370
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("light.shadowObjectSizeBias was removed, use light.shadowBias", true)]
		public float shadowObjectSizeBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x000021E1 File Offset: 0x000003E1
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("light.attenuate was removed; all lights always attenuate now", true)]
		public bool attenuate
		{
			get
			{
				return true;
			}
			set
			{
			}
		}
	}
}
