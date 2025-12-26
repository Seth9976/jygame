using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Base class for texture handling. Contains functionality that is common to both Texture2D and RenderTexture classes.</para>
	/// </summary>
	// Token: 0x0200003E RID: 62
	public class Texture : Object
	{
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002FE RID: 766
		// (set) Token: 0x060002FF RID: 767
		public static extern int masterTextureLimit
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000300 RID: 768
		// (set) Token: 0x06000301 RID: 769
		public static extern AnisotropicFiltering anisotropicFiltering
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Sets Anisotropic limits.</para>
		/// </summary>
		/// <param name="forcedMin"></param>
		/// <param name="globalMax"></param>
		// Token: 0x06000302 RID: 770
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax);

		// Token: 0x06000303 RID: 771
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetWidth(Texture mono);

		// Token: 0x06000304 RID: 772
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetHeight(Texture mono);

		/// <summary>
		///   <para>Width of the texture in pixels. (Read Only)</para>
		/// </summary>
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000305 RID: 773 RVA: 0x000028A3 File Offset: 0x00000AA3
		// (set) Token: 0x06000306 RID: 774 RVA: 0x000028AB File Offset: 0x00000AAB
		public virtual int width
		{
			get
			{
				return Texture.Internal_GetWidth(this);
			}
			set
			{
				throw new Exception("not implemented");
			}
		}

		/// <summary>
		///   <para>Height of the texture in pixels. (Read Only)</para>
		/// </summary>
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000307 RID: 775 RVA: 0x000028B7 File Offset: 0x00000AB7
		// (set) Token: 0x06000308 RID: 776 RVA: 0x000028AB File Offset: 0x00000AAB
		public virtual int height
		{
			get
			{
				return Texture.Internal_GetHeight(this);
			}
			set
			{
				throw new Exception("not implemented");
			}
		}

		/// <summary>
		///   <para>Filtering mode of the texture.</para>
		/// </summary>
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000309 RID: 777
		// (set) Token: 0x0600030A RID: 778
		public extern FilterMode filterMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Anisotropic filtering level of the texture.</para>
		/// </summary>
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600030B RID: 779
		// (set) Token: 0x0600030C RID: 780
		public extern int anisoLevel
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Wrap mode (Repeat or Clamp) of the texture.</para>
		/// </summary>
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600030D RID: 781
		// (set) Token: 0x0600030E RID: 782
		public extern TextureWrapMode wrapMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Mip map bias of the texture.</para>
		/// </summary>
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600030F RID: 783
		// (set) Token: 0x06000310 RID: 784
		public extern float mipMapBias
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0000FC0C File Offset: 0x0000DE0C
		public Vector2 texelSize
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_texelSize(out vector);
				return vector;
			}
		}

		// Token: 0x06000312 RID: 786
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_texelSize(out Vector2 value);

		/// <summary>
		///   <para>Retrieve native ('hardware') pointer to a texture.</para>
		/// </summary>
		// Token: 0x06000313 RID: 787
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern IntPtr GetNativeTexturePtr();

		// Token: 0x06000314 RID: 788
		[WrapperlessIcall]
		[Obsolete("Use GetNativeTexturePtr instead.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetNativeTextureID();
	}
}
