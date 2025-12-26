using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Represents a Sprite object for use in 2D gameplay.</para>
	/// </summary>
	// Token: 0x02000098 RID: 152
	public sealed class Sprite : Object
	{
		// Token: 0x06000895 RID: 2197 RVA: 0x000054E7 File Offset: 0x000036E7
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, [DefaultValue("100.0f")] float pixelsPerUnit, [DefaultValue("0")] uint extrude, [DefaultValue("SpriteMeshType.Tight")] SpriteMeshType meshType, [DefaultValue("Vector4.zero")] Vector4 border)
		{
			return Sprite.INTERNAL_CALL_Create(texture, ref rect, ref pivot, pixelsPerUnit, extrude, meshType, ref border);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x000155B0 File Offset: 0x000137B0
		[ExcludeFromDocs]
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType)
		{
			Vector4 zero = Vector4.zero;
			return Sprite.INTERNAL_CALL_Create(texture, ref rect, ref pivot, pixelsPerUnit, extrude, meshType, ref zero);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000155D4 File Offset: 0x000137D4
		[ExcludeFromDocs]
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude)
		{
			Vector4 zero = Vector4.zero;
			SpriteMeshType spriteMeshType = SpriteMeshType.Tight;
			return Sprite.INTERNAL_CALL_Create(texture, ref rect, ref pivot, pixelsPerUnit, extrude, spriteMeshType, ref zero);
		}

		/// <summary>
		///   <para>Create a new Sprite object.</para>
		/// </summary>
		/// <param name="texture">Texture from which to obtain the sprite graphic.</param>
		/// <param name="rect">Rectangular section of the texture to use for the sprite.</param>
		/// <param name="pivot">Sprite's pivot point relative to its graphic rectangle.</param>
		/// <param name="pixelsToUnits">Scaling to map pixels in the image to world space units.</param>
		/// <param name="pixelsPerUnit"></param>
		/// <param name="extrude"></param>
		/// <param name="meshType"></param>
		/// <param name="border"></param>
		// Token: 0x06000898 RID: 2200 RVA: 0x000155FC File Offset: 0x000137FC
		[ExcludeFromDocs]
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit)
		{
			Vector4 zero = Vector4.zero;
			SpriteMeshType spriteMeshType = SpriteMeshType.Tight;
			uint num = 0U;
			return Sprite.INTERNAL_CALL_Create(texture, ref rect, ref pivot, pixelsPerUnit, num, spriteMeshType, ref zero);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00015624 File Offset: 0x00013824
		[ExcludeFromDocs]
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot)
		{
			Vector4 zero = Vector4.zero;
			SpriteMeshType spriteMeshType = SpriteMeshType.Tight;
			uint num = 0U;
			float num2 = 100f;
			return Sprite.INTERNAL_CALL_Create(texture, ref rect, ref pivot, num2, num, spriteMeshType, ref zero);
		}

		// Token: 0x0600089A RID: 2202
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Sprite INTERNAL_CALL_Create(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border);

		/// <summary>
		///   <para>Bounds of the Sprite, specified by its center and extents in world space units.</para>
		/// </summary>
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x00015650 File Offset: 0x00013850
		public Bounds bounds
		{
			get
			{
				Bounds bounds;
				this.INTERNAL_get_bounds(out bounds);
				return bounds;
			}
		}

		// Token: 0x0600089C RID: 2204
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bounds(out Bounds value);

		/// <summary>
		///   <para>Location of the Sprite on the original Texture, specified in pixels.</para>
		/// </summary>
		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x00015668 File Offset: 0x00013868
		public Rect rect
		{
			get
			{
				Rect rect;
				this.INTERNAL_get_rect(out rect);
				return rect;
			}
		}

		// Token: 0x0600089E RID: 2206
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rect(out Rect value);

		/// <summary>
		///   <para>The number of pixels in the sprite that correspond to one unit in world space. (Read Only)</para>
		/// </summary>
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600089F RID: 2207
		public extern float pixelsPerUnit
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Get the reference to the used texture. If packed this will point to the atlas, if not packed will point to the source sprite.</para>
		/// </summary>
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060008A0 RID: 2208
		public extern Texture2D texture
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns the texture that contains the alpha channel from the source texture. Unity generates this texture under the hood for sprites that have alpha in the source, and need to be compressed using techniques like ETC1.
		///
		/// Returns NULL if there is no associated alpha texture for the source sprite. This is the case if the sprite has not been setup to use ETC1 compression.</para>
		/// </summary>
		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060008A1 RID: 2209
		public extern Texture2D associatedAlphaSplitTexture
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Get the rectangle this sprite uses on its texture. Raises an exception if this sprite is tightly packed in an atlas.</para>
		/// </summary>
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00015680 File Offset: 0x00013880
		public Rect textureRect
		{
			get
			{
				Rect rect;
				this.INTERNAL_get_textureRect(out rect);
				return rect;
			}
		}

		// Token: 0x060008A3 RID: 2211
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_textureRect(out Rect value);

		/// <summary>
		///   <para>Gets the offset of the rectangle this sprite uses on its texture to the original sprite bounds. If sprite mesh type is FullRect, offset is zero.</para>
		/// </summary>
		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00015698 File Offset: 0x00013898
		public Vector2 textureRectOffset
		{
			get
			{
				Vector2 vector;
				Sprite.Internal_GetTextureRectOffset(this, out vector);
				return vector;
			}
		}

		/// <summary>
		///   <para>Returns true if this Sprite is packed in an atlas.</para>
		/// </summary>
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060008A5 RID: 2213
		public extern bool packed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>If Sprite is packed (see Sprite.packed), returns its SpritePackingMode.</para>
		/// </summary>
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060008A6 RID: 2214
		public extern SpritePackingMode packingMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>If Sprite is packed (see Sprite.packed), returns its SpritePackingRotation.</para>
		/// </summary>
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060008A7 RID: 2215
		public extern SpritePackingRotation packingRotation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x060008A8 RID: 2216
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetTextureRectOffset(Sprite sprite, out Vector2 output);

		// Token: 0x060008A9 RID: 2217
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetPivot(Sprite sprite, out Vector2 output);

		/// <summary>
		///   <para>Location of the Sprite's center point in the Rect on the original Texture, specified in pixels.</para>
		/// </summary>
		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x000156B0 File Offset: 0x000138B0
		public Vector2 pivot
		{
			get
			{
				Vector2 vector;
				Sprite.Internal_GetPivot(this, out vector);
				return vector;
			}
		}

		/// <summary>
		///   <para>Returns the border sizes of the sprite.</para>
		/// </summary>
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x000156C8 File Offset: 0x000138C8
		public Vector4 border
		{
			get
			{
				Vector4 vector;
				this.INTERNAL_get_border(out vector);
				return vector;
			}
		}

		// Token: 0x060008AC RID: 2220
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_border(out Vector4 value);

		/// <summary>
		///   <para>Returns a copy of the array containing sprite mesh vertex positions.</para>
		/// </summary>
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060008AD RID: 2221
		public extern Vector2[] vertices
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns a copy of the array containing sprite mesh triangles.</para>
		/// </summary>
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060008AE RID: 2222
		public extern ushort[] triangles
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The base texture coordinates of the sprite mesh.</para>
		/// </summary>
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060008AF RID: 2223
		public extern Vector2[] uv
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Sets up new Sprite geometry.</para>
		/// </summary>
		/// <param name="vertices">Array of vertex positions in Sprite Rect space.</param>
		/// <param name="triangles">Array of sprite mesh triangle indices.</param>
		// Token: 0x060008B0 RID: 2224
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void OverrideGeometry(Vector2[] vertices, ushort[] triangles);
	}
}
