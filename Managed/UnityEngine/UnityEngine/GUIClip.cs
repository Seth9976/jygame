using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	// Token: 0x020001EC RID: 492
	internal sealed class GUIClip
	{
		// Token: 0x06001D0C RID: 7436 RVA: 0x0000B59C File Offset: 0x0000979C
		public static Vector2 Unclip(Vector2 pos)
		{
			GUIClip.Unclip_Vector2(ref pos);
			return pos;
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x0000B5A6 File Offset: 0x000097A6
		public static Rect Unclip(Rect rect)
		{
			GUIClip.Unclip_Rect(ref rect);
			return rect;
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x0000B5B0 File Offset: 0x000097B0
		public static Vector2 Clip(Vector2 absolutePos)
		{
			GUIClip.Clip_Vector2(ref absolutePos);
			return absolutePos;
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x0000B5BA File Offset: 0x000097BA
		public static Rect Clip(Rect absoluteRect)
		{
			GUIClip.Internal_Clip_Rect(ref absoluteRect);
			return absoluteRect;
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x000239A4 File Offset: 0x00021BA4
		public static Vector2 GetAbsoluteMousePosition()
		{
			Vector2 vector;
			GUIClip.Internal_GetAbsoluteMousePosition(out vector);
			return vector;
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x0000B5C4 File Offset: 0x000097C4
		internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			GUIClip.INTERNAL_CALL_Push(ref screenRect, ref scrollOffset, ref renderOffset, resetOffset);
		}

		// Token: 0x06001D12 RID: 7442
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Push(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset);

		// Token: 0x06001D13 RID: 7443
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Pop();

		// Token: 0x06001D14 RID: 7444
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Rect GetTopRect();

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001D15 RID: 7445
		public static extern bool enabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x0000B5D2 File Offset: 0x000097D2
		private static void Unclip_Vector2(ref Vector2 pos)
		{
			GUIClip.INTERNAL_CALL_Unclip_Vector2(ref pos);
		}

		// Token: 0x06001D17 RID: 7447
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Unclip_Vector2(ref Vector2 pos);

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x000239BC File Offset: 0x00021BBC
		public static Rect topmostRect
		{
			get
			{
				Rect rect;
				GUIClip.INTERNAL_get_topmostRect(out rect);
				return rect;
			}
		}

		// Token: 0x06001D19 RID: 7449
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_topmostRect(out Rect value);

		// Token: 0x06001D1A RID: 7450 RVA: 0x0000B5DA File Offset: 0x000097DA
		private static void Unclip_Rect(ref Rect rect)
		{
			GUIClip.INTERNAL_CALL_Unclip_Rect(ref rect);
		}

		// Token: 0x06001D1B RID: 7451
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Unclip_Rect(ref Rect rect);

		// Token: 0x06001D1C RID: 7452 RVA: 0x0000B5E2 File Offset: 0x000097E2
		private static void Clip_Vector2(ref Vector2 absolutePos)
		{
			GUIClip.INTERNAL_CALL_Clip_Vector2(ref absolutePos);
		}

		// Token: 0x06001D1D RID: 7453
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Clip_Vector2(ref Vector2 absolutePos);

		// Token: 0x06001D1E RID: 7454 RVA: 0x0000B5EA File Offset: 0x000097EA
		private static void Internal_Clip_Rect(ref Rect absoluteRect)
		{
			GUIClip.INTERNAL_CALL_Internal_Clip_Rect(ref absoluteRect);
		}

		// Token: 0x06001D1F RID: 7455
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_Clip_Rect(ref Rect absoluteRect);

		// Token: 0x06001D20 RID: 7456
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Reapply();

		// Token: 0x06001D21 RID: 7457
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Matrix4x4 GetMatrix();

		// Token: 0x06001D22 RID: 7458 RVA: 0x0000B5F2 File Offset: 0x000097F2
		internal static void SetMatrix(Matrix4x4 m)
		{
			GUIClip.INTERNAL_CALL_SetMatrix(ref m);
		}

		// Token: 0x06001D23 RID: 7459
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetMatrix(ref Matrix4x4 m);

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x000239D4 File Offset: 0x00021BD4
		public static Rect visibleRect
		{
			get
			{
				Rect rect;
				GUIClip.INTERNAL_get_visibleRect(out rect);
				return rect;
			}
		}

		// Token: 0x06001D25 RID: 7461
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_visibleRect(out Rect value);

		// Token: 0x06001D26 RID: 7462
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetAbsoluteMousePosition(out Vector2 output);
	}
}
