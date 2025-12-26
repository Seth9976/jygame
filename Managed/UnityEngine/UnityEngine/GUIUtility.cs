using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Utility class for making new GUI controls.</para>
	/// </summary>
	// Token: 0x020001EB RID: 491
	public class GUIUtility
	{
		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x0000B478 File Offset: 0x00009678
		internal static float pixelsPerPoint
		{
			get
			{
				return GUIUtility.Internal_GetPixelsPerPoint();
			}
		}

		/// <summary>
		///   <para>Get a unique ID for a control.</para>
		/// </summary>
		/// <param name="focus"></param>
		/// <param name="position"></param>
		// Token: 0x06001CDF RID: 7391 RVA: 0x0000B47F File Offset: 0x0000967F
		public static int GetControlID(FocusType focus)
		{
			return GUIUtility.GetControlID(0, focus);
		}

		/// <summary>
		///   <para>Get a unique ID for a control, using a the label content as a hint to help ensure correct matching of IDs to controls.</para>
		/// </summary>
		/// <param name="contents"></param>
		/// <param name="focus"></param>
		/// <param name="position"></param>
		// Token: 0x06001CE0 RID: 7392 RVA: 0x0000B488 File Offset: 0x00009688
		public static int GetControlID(GUIContent contents, FocusType focus)
		{
			return GUIUtility.GetControlID(contents.hash, focus);
		}

		/// <summary>
		///   <para>Get a unique ID for a control.</para>
		/// </summary>
		/// <param name="focus"></param>
		/// <param name="position"></param>
		// Token: 0x06001CE1 RID: 7393 RVA: 0x0000B496 File Offset: 0x00009696
		public static int GetControlID(FocusType focus, Rect position)
		{
			return GUIUtility.Internal_GetNextControlID2(0, focus, position);
		}

		/// <summary>
		///   <para>Get a unique ID for a control, using an integer as a hint to help ensure correct matching of IDs to controls.</para>
		/// </summary>
		/// <param name="hint"></param>
		/// <param name="focus"></param>
		/// <param name="position"></param>
		// Token: 0x06001CE2 RID: 7394 RVA: 0x0000B4A0 File Offset: 0x000096A0
		public static int GetControlID(int hint, FocusType focus, Rect position)
		{
			return GUIUtility.Internal_GetNextControlID2(hint, focus, position);
		}

		/// <summary>
		///   <para>Get a unique ID for a control, using a the label content as a hint to help ensure correct matching of IDs to controls.</para>
		/// </summary>
		/// <param name="contents"></param>
		/// <param name="focus"></param>
		/// <param name="position"></param>
		// Token: 0x06001CE3 RID: 7395 RVA: 0x0000B4AA File Offset: 0x000096AA
		public static int GetControlID(GUIContent contents, FocusType focus, Rect position)
		{
			return GUIUtility.Internal_GetNextControlID2(contents.hash, focus, position);
		}

		/// <summary>
		///   <para>Get a state object from a controlID.</para>
		/// </summary>
		/// <param name="t"></param>
		/// <param name="controlID"></param>
		// Token: 0x06001CE4 RID: 7396 RVA: 0x0000B4B9 File Offset: 0x000096B9
		public static object GetStateObject(Type t, int controlID)
		{
			return GUIStateObjects.GetStateObject(t, controlID);
		}

		/// <summary>
		///   <para>Get an existing state object from a controlID.</para>
		/// </summary>
		/// <param name="t"></param>
		/// <param name="controlID"></param>
		// Token: 0x06001CE5 RID: 7397 RVA: 0x0000B4C2 File Offset: 0x000096C2
		public static object QueryStateObject(Type t, int controlID)
		{
			return GUIStateObjects.QueryStateObject(t, controlID);
		}

		/// <summary>
		///   <para>The controlID of the current hot control.</para>
		/// </summary>
		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x0000B4CB File Offset: 0x000096CB
		// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x0000B4D2 File Offset: 0x000096D2
		public static int hotControl
		{
			get
			{
				return GUIUtility.Internal_GetHotControl();
			}
			set
			{
				GUIUtility.Internal_SetHotControl(value);
			}
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x0000B4DA File Offset: 0x000096DA
		public static void ExitGUI()
		{
			throw new ExitGUIException();
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0000B4E1 File Offset: 0x000096E1
		internal static GUISkin GetDefaultSkin()
		{
			return GUIUtility.Internal_GetDefaultSkin(GUIUtility.s_SkinMode);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x0000B4ED File Offset: 0x000096ED
		internal static GUISkin GetBuiltinSkin(int skin)
		{
			return GUIUtility.Internal_GetBuiltinSkin(skin) as GUISkin;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0000B4FA File Offset: 0x000096FA
		internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout)
		{
			GUIUtility.s_SkinMode = skinMode;
			GUIUtility.s_OriginalID = instanceID;
			GUI.skin = null;
			if (useGUILayout != 0)
			{
				GUILayoutUtility.SelectIDList(instanceID, false);
				GUILayoutUtility.Begin(instanceID);
			}
			GUI.changed = false;
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x000237C0 File Offset: 0x000219C0
		internal static void EndGUI(int layoutType)
		{
			try
			{
				if (Event.current.type == EventType.Layout)
				{
					switch (layoutType)
					{
					case 1:
						GUILayoutUtility.Layout();
						break;
					case 2:
						GUILayoutUtility.LayoutFromEditorWindow();
						break;
					}
				}
				GUILayoutUtility.SelectIDList(GUIUtility.s_OriginalID, false);
				GUIContent.ClearStaticCache();
			}
			finally
			{
				GUIUtility.Internal_ExitGUI();
			}
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x0000B528 File Offset: 0x00009728
		internal static bool EndGUIFromException(Exception exception)
		{
			if (exception == null)
			{
				return false;
			}
			if (!(exception is ExitGUIException) && !(exception.InnerException is ExitGUIException))
			{
				return false;
			}
			GUIUtility.Internal_ExitGUI();
			return true;
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0000B555 File Offset: 0x00009755
		internal static void CheckOnGUI()
		{
			if (GUIUtility.Internal_GetGUIDepth() <= 0)
			{
				throw new ArgumentException("You can only call GUI functions from inside OnGUI.");
			}
		}

		/// <summary>
		///   <para>Convert a point from GUI position to screen space.</para>
		/// </summary>
		/// <param name="guiPoint"></param>
		// Token: 0x06001CEF RID: 7407 RVA: 0x0000B56D File Offset: 0x0000976D
		public static Vector2 GUIToScreenPoint(Vector2 guiPoint)
		{
			return GUIClip.Unclip(guiPoint) + GUIUtility.s_EditorScreenPointOffset;
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0002383C File Offset: 0x00021A3C
		internal static Rect GUIToScreenRect(Rect guiRect)
		{
			Vector2 vector = GUIUtility.GUIToScreenPoint(new Vector2(guiRect.x, guiRect.y));
			guiRect.x = vector.x;
			guiRect.y = vector.y;
			return guiRect;
		}

		/// <summary>
		///   <para>Convert a point from screen space to GUI position.</para>
		/// </summary>
		/// <param name="screenPoint"></param>
		// Token: 0x06001CF1 RID: 7409 RVA: 0x0000B57F File Offset: 0x0000977F
		public static Vector2 ScreenToGUIPoint(Vector2 screenPoint)
		{
			return GUIClip.Clip(screenPoint) - GUIUtility.s_EditorScreenPointOffset;
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00023880 File Offset: 0x00021A80
		public static Rect ScreenToGUIRect(Rect screenRect)
		{
			Vector2 vector = GUIUtility.ScreenToGUIPoint(new Vector2(screenRect.x, screenRect.y));
			screenRect.x = vector.x;
			screenRect.y = vector.y;
			return screenRect;
		}

		/// <summary>
		///   <para>Helper function to rotate the GUI around a point.</para>
		/// </summary>
		/// <param name="angle"></param>
		/// <param name="pivotPoint"></param>
		// Token: 0x06001CF3 RID: 7411 RVA: 0x000238C4 File Offset: 0x00021AC4
		public static void RotateAroundPivot(float angle, Vector2 pivotPoint)
		{
			Matrix4x4 matrix = GUI.matrix;
			GUI.matrix = Matrix4x4.identity;
			Vector2 vector = GUIClip.Unclip(pivotPoint);
			Matrix4x4 matrix4x = Matrix4x4.TRS(vector, Quaternion.Euler(0f, 0f, angle), Vector3.one) * Matrix4x4.TRS(-vector, Quaternion.identity, Vector3.one);
			GUI.matrix = matrix4x * matrix;
		}

		/// <summary>
		///   <para>Helper function to scale the GUI around a point.</para>
		/// </summary>
		/// <param name="scale"></param>
		/// <param name="pivotPoint"></param>
		// Token: 0x06001CF4 RID: 7412 RVA: 0x00023934 File Offset: 0x00021B34
		public static void ScaleAroundPivot(Vector2 scale, Vector2 pivotPoint)
		{
			Matrix4x4 matrix = GUI.matrix;
			Vector2 vector = GUIClip.Unclip(pivotPoint);
			Matrix4x4 matrix4x = Matrix4x4.TRS(vector, Quaternion.identity, new Vector3(scale.x, scale.y, 1f)) * Matrix4x4.TRS(-vector, Quaternion.identity, Vector3.one);
			GUI.matrix = matrix4x * matrix;
		}

		// Token: 0x06001CF5 RID: 7413
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetPixelsPerPoint();

		/// <summary>
		///   <para>Get a unique ID for a control, using an integer as a hint to help ensure correct matching of IDs to controls.</para>
		/// </summary>
		/// <param name="hint"></param>
		/// <param name="focus"></param>
		/// <param name="position"></param>
		// Token: 0x06001CF6 RID: 7414
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetControlID(int hint, FocusType focus);

		// Token: 0x06001CF7 RID: 7415 RVA: 0x0000B591 File Offset: 0x00009791
		private static int Internal_GetNextControlID2(int hint, FocusType focusType, Rect rect)
		{
			return GUIUtility.INTERNAL_CALL_Internal_GetNextControlID2(hint, focusType, ref rect);
		}

		// Token: 0x06001CF8 RID: 7416
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_Internal_GetNextControlID2(int hint, FocusType focusType, ref Rect rect);

		// Token: 0x06001CF9 RID: 7417
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetPermanentControlID();

		// Token: 0x06001CFA RID: 7418
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetHotControl();

		// Token: 0x06001CFB RID: 7419
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetHotControl(int value);

		// Token: 0x06001CFC RID: 7420
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void UpdateUndoName();

		/// <summary>
		///   <para>The controlID of the control that has keyboard focus.</para>
		/// </summary>
		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001CFD RID: 7421
		// (set) Token: 0x06001CFE RID: 7422
		public static extern int keyboardControl
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001CFF RID: 7423
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetDidGUIWindowsEatLastEvent(bool value);

		/// <summary>
		///   <para>Get access to the system-wide pasteboard.</para>
		/// </summary>
		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001D00 RID: 7424
		// (set) Token: 0x06001D01 RID: 7425
		public static extern string systemCopyBuffer
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001D02 RID: 7426
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern GUISkin Internal_GetDefaultSkin(int skinMode);

		// Token: 0x06001D03 RID: 7427
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Object Internal_GetBuiltinSkin(int skin);

		// Token: 0x06001D04 RID: 7428
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ExitGUI();

		// Token: 0x06001D05 RID: 7429
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Internal_GetGUIDepth();

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001D06 RID: 7430
		// (set) Token: 0x06001D07 RID: 7431
		internal static extern bool mouseUsed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>A global property, which is true if a ModalWindow is being displayed, false otherwise.</para>
		/// </summary>
		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001D08 RID: 7432
		public static extern bool hasModalWindow
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001D09 RID: 7433
		// (set) Token: 0x06001D0A RID: 7434
		internal static extern bool textFieldInput
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x0400079E RID: 1950
		internal static int s_SkinMode;

		// Token: 0x0400079F RID: 1951
		internal static int s_OriginalID;

		// Token: 0x040007A0 RID: 1952
		internal static Vector2 s_EditorScreenPointOffset = Vector2.zero;

		// Token: 0x040007A1 RID: 1953
		internal static bool s_HasKeyboardFocus = false;
	}
}
