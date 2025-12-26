using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Sprites
{
	/// <summary>
	///   <para>Helper utilities for accessing Sprite data.</para>
	/// </summary>
	// Token: 0x0200009A RID: 154
	public sealed class DataUtility
	{
		/// <summary>
		///   <para>Inner UV's of the Sprite.</para>
		/// </summary>
		/// <param name="sprite"></param>
		// Token: 0x060008BB RID: 2235
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Vector4 GetInnerUV(Sprite sprite);

		/// <summary>
		///   <para>Outer UV's of the Sprite.</para>
		/// </summary>
		/// <param name="sprite"></param>
		// Token: 0x060008BC RID: 2236
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Vector4 GetOuterUV(Sprite sprite);

		/// <summary>
		///   <para>Return the padding on the sprite.</para>
		/// </summary>
		/// <param name="sprite"></param>
		// Token: 0x060008BD RID: 2237
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Vector4 GetPadding(Sprite sprite);

		/// <summary>
		///   <para>Minimum width and height of the Sprite.</para>
		/// </summary>
		/// <param name="sprite"></param>
		// Token: 0x060008BE RID: 2238 RVA: 0x000156F8 File Offset: 0x000138F8
		public static Vector2 GetMinSize(Sprite sprite)
		{
			Vector2 vector;
			DataUtility.Internal_GetMinSize(sprite, out vector);
			return vector;
		}

		// Token: 0x060008BF RID: 2239
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetMinSize(Sprite sprite, out Vector2 output);
	}
}
