using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Cursor API for setting the cursor that is used for rendering.</para>
	/// </summary>
	// Token: 0x02000018 RID: 24
	public sealed class Cursor
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00002260 File Offset: 0x00000460
		private static void SetCursor(Texture2D texture, CursorMode cursorMode)
		{
			Cursor.SetCursor(texture, Vector2.zero, cursorMode);
		}

		/// <summary>
		///   <para>Specify a custom cursor that you wish to use as a cursor.</para>
		/// </summary>
		/// <param name="texture">The texture to use for the cursor or null to set the default cursor. Note that a texture needs to be imported with "Read/Write enabled" in the texture importer (or using the "Cursor" defaults), in order to be used as a cursor.</param>
		/// <param name="hotspot">The offset from the top left of the texture to use as the target point (must be within the bounds of the cursor).</param>
		/// <param name="cursorMode">Allow this cursor to render as a hardware cursor on supported platforms, or force software cursor.</param>
		// Token: 0x0600008B RID: 139 RVA: 0x0000226E File Offset: 0x0000046E
		public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
		{
			Cursor.INTERNAL_CALL_SetCursor(texture, ref hotspot, cursorMode);
		}

		// Token: 0x0600008C RID: 140
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetCursor(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode);

		/// <summary>
		///   <para>Should the cursor be visible?</para>
		/// </summary>
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600008D RID: 141
		// (set) Token: 0x0600008E RID: 142
		public static extern bool visible
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How should the cursor be handled?</para>
		/// </summary>
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600008F RID: 143
		// (set) Token: 0x06000090 RID: 144
		public static extern CursorLockMode lockState
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
