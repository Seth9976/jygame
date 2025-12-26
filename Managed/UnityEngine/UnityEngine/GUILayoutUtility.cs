using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngineInternal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Utility functions for implementing and extending the GUILayout class.</para>
	/// </summary>
	// Token: 0x020001D5 RID: 469
	public class GUILayoutUtility
	{
		// Token: 0x06001BAD RID: 7085 RVA: 0x0001FE00 File Offset: 0x0001E000
		internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow)
		{
			Dictionary<int, GUILayoutUtility.LayoutCache> dictionary = ((!isWindow) ? GUILayoutUtility.s_StoredLayouts : GUILayoutUtility.s_StoredWindows);
			GUILayoutUtility.LayoutCache layoutCache;
			if (!dictionary.TryGetValue(instanceID, out layoutCache))
			{
				layoutCache = new GUILayoutUtility.LayoutCache();
				dictionary[instanceID] = layoutCache;
			}
			GUILayoutUtility.current.topLevel = layoutCache.topLevel;
			GUILayoutUtility.current.layoutGroups = layoutCache.layoutGroups;
			GUILayoutUtility.current.windows = layoutCache.windows;
			return layoutCache;
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x0001FE78 File Offset: 0x0001E078
		internal static void Begin(int instanceID)
		{
			GUILayoutUtility.LayoutCache layoutCache = GUILayoutUtility.SelectIDList(instanceID, false);
			if (Event.current.type == EventType.Layout)
			{
				GUILayoutUtility.current.topLevel = (layoutCache.topLevel = new GUILayoutGroup());
				GUILayoutUtility.current.layoutGroups.Clear();
				GUILayoutUtility.current.layoutGroups.Push(GUILayoutUtility.current.topLevel);
				GUILayoutUtility.current.windows = (layoutCache.windows = new GUILayoutGroup());
			}
			else
			{
				GUILayoutUtility.current.topLevel = layoutCache.topLevel;
				GUILayoutUtility.current.layoutGroups = layoutCache.layoutGroups;
				GUILayoutUtility.current.windows = layoutCache.windows;
			}
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0001FF2C File Offset: 0x0001E12C
		internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options)
		{
			GUILayoutUtility.LayoutCache layoutCache = GUILayoutUtility.SelectIDList(windowID, true);
			if (Event.current.type == EventType.Layout)
			{
				GUILayoutUtility.current.topLevel = (layoutCache.topLevel = new GUILayoutGroup());
				GUILayoutUtility.current.topLevel.style = style;
				GUILayoutUtility.current.topLevel.windowID = windowID;
				if (options != null)
				{
					GUILayoutUtility.current.topLevel.ApplyOptions(options);
				}
				GUILayoutUtility.current.layoutGroups.Clear();
				GUILayoutUtility.current.layoutGroups.Push(GUILayoutUtility.current.topLevel);
				GUILayoutUtility.current.windows = (layoutCache.windows = new GUILayoutGroup());
			}
			else
			{
				GUILayoutUtility.current.topLevel = layoutCache.topLevel;
				GUILayoutUtility.current.layoutGroups = layoutCache.layoutGroups;
				GUILayoutUtility.current.windows = layoutCache.windows;
			}
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00002753 File Offset: 0x00000953
		public static void BeginGroup(string GroupName)
		{
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00002753 File Offset: 0x00000953
		public static void EndGroup(string groupName)
		{
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00020014 File Offset: 0x0001E214
		internal static void Layout()
		{
			if (GUILayoutUtility.current.topLevel.windowID == -1)
			{
				GUILayoutUtility.current.topLevel.CalcWidth();
				GUILayoutUtility.current.topLevel.SetHorizontal(0f, Mathf.Min((float)Screen.width / GUIUtility.pixelsPerPoint, GUILayoutUtility.current.topLevel.maxWidth));
				GUILayoutUtility.current.topLevel.CalcHeight();
				GUILayoutUtility.current.topLevel.SetVertical(0f, Mathf.Min((float)Screen.height / GUIUtility.pixelsPerPoint, GUILayoutUtility.current.topLevel.maxHeight));
				GUILayoutUtility.LayoutFreeGroup(GUILayoutUtility.current.windows);
			}
			else
			{
				GUILayoutUtility.LayoutSingleGroup(GUILayoutUtility.current.topLevel);
				GUILayoutUtility.LayoutFreeGroup(GUILayoutUtility.current.windows);
			}
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x000200F0 File Offset: 0x0001E2F0
		internal static void LayoutFromEditorWindow()
		{
			GUILayoutUtility.current.topLevel.CalcWidth();
			GUILayoutUtility.current.topLevel.SetHorizontal(0f, (float)Screen.width / GUIUtility.pixelsPerPoint);
			GUILayoutUtility.current.topLevel.CalcHeight();
			GUILayoutUtility.current.topLevel.SetVertical(0f, (float)Screen.height / GUIUtility.pixelsPerPoint);
			GUILayoutUtility.LayoutFreeGroup(GUILayoutUtility.current.windows);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0002016C File Offset: 0x0001E36C
		internal static float LayoutFromInspector(float width)
		{
			if (GUILayoutUtility.current.topLevel != null && GUILayoutUtility.current.topLevel.windowID == -1)
			{
				GUILayoutUtility.current.topLevel.CalcWidth();
				GUILayoutUtility.current.topLevel.SetHorizontal(0f, width);
				GUILayoutUtility.current.topLevel.CalcHeight();
				GUILayoutUtility.current.topLevel.SetVertical(0f, Mathf.Min((float)Screen.height / GUIUtility.pixelsPerPoint, GUILayoutUtility.current.topLevel.maxHeight));
				float minHeight = GUILayoutUtility.current.topLevel.minHeight;
				GUILayoutUtility.LayoutFreeGroup(GUILayoutUtility.current.windows);
				return minHeight;
			}
			if (GUILayoutUtility.current.topLevel != null)
			{
				GUILayoutUtility.LayoutSingleGroup(GUILayoutUtility.current.topLevel);
			}
			return 0f;
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x00020248 File Offset: 0x0001E448
		internal static void LayoutFreeGroup(GUILayoutGroup toplevel)
		{
			foreach (GUILayoutEntry guilayoutEntry in toplevel.entries)
			{
				GUILayoutGroup guilayoutGroup = (GUILayoutGroup)guilayoutEntry;
				GUILayoutUtility.LayoutSingleGroup(guilayoutGroup);
			}
			toplevel.ResetCursor();
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x000202AC File Offset: 0x0001E4AC
		private static void LayoutSingleGroup(GUILayoutGroup i)
		{
			if (!i.isWindow)
			{
				float minWidth = i.minWidth;
				float maxWidth = i.maxWidth;
				i.CalcWidth();
				i.SetHorizontal(i.rect.x, Mathf.Clamp(i.maxWidth, minWidth, maxWidth));
				float minHeight = i.minHeight;
				float maxHeight = i.maxHeight;
				i.CalcHeight();
				i.SetVertical(i.rect.y, Mathf.Clamp(i.maxHeight, minHeight, maxHeight));
			}
			else
			{
				i.CalcWidth();
				Rect rect = GUILayoutUtility.Internal_GetWindowRect(i.windowID);
				i.SetHorizontal(rect.x, Mathf.Clamp(rect.width, i.minWidth, i.maxWidth));
				i.CalcHeight();
				i.SetVertical(rect.y, Mathf.Clamp(rect.height, i.minHeight, i.maxHeight));
				GUILayoutUtility.Internal_MoveWindow(i.windowID, i.rect);
			}
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x0000A95D File Offset: 0x00008B5D
		[SecuritySafeCritical]
		private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType)
		{
			if (!typeof(GUILayoutGroup).IsAssignableFrom(LayoutType))
			{
				throw new ArgumentException("LayoutType needs to be of type GUILayoutGroup");
			}
			return (GUILayoutGroup)Activator.CreateInstance(LayoutType);
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x000203A4 File Offset: 0x0001E5A4
		internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType)
		{
			EventType type = Event.current.type;
			GUILayoutGroup guilayoutGroup;
			if (type != EventType.Layout && type != EventType.Used)
			{
				guilayoutGroup = GUILayoutUtility.current.topLevel.GetNext() as GUILayoutGroup;
				if (guilayoutGroup == null)
				{
					throw new ArgumentException("GUILayout: Mismatched LayoutGroup." + Event.current.type);
				}
				guilayoutGroup.ResetCursor();
			}
			else
			{
				guilayoutGroup = GUILayoutUtility.CreateGUILayoutGroupInstanceOfType(layoutType);
				guilayoutGroup.style = style;
				if (options != null)
				{
					guilayoutGroup.ApplyOptions(options);
				}
				GUILayoutUtility.current.topLevel.Add(guilayoutGroup);
			}
			GUILayoutUtility.current.layoutGroups.Push(guilayoutGroup);
			GUILayoutUtility.current.topLevel = guilayoutGroup;
			return guilayoutGroup;
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00020464 File Offset: 0x0001E664
		internal static void EndLayoutGroup()
		{
			EventType type = Event.current.type;
			GUILayoutUtility.current.layoutGroups.Pop();
			GUILayoutUtility.current.topLevel = (GUILayoutGroup)GUILayoutUtility.current.layoutGroups.Peek();
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x000204AC File Offset: 0x0001E6AC
		internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType)
		{
			EventType type = Event.current.type;
			GUILayoutGroup guilayoutGroup;
			if (type != EventType.Layout && type != EventType.Used)
			{
				guilayoutGroup = GUILayoutUtility.current.windows.GetNext() as GUILayoutGroup;
				if (guilayoutGroup == null)
				{
					throw new ArgumentException("GUILayout: Mismatched LayoutGroup." + Event.current.type);
				}
				guilayoutGroup.ResetCursor();
			}
			else
			{
				guilayoutGroup = GUILayoutUtility.CreateGUILayoutGroupInstanceOfType(layoutType);
				guilayoutGroup.style = style;
				GUILayoutUtility.current.windows.Add(guilayoutGroup);
			}
			GUILayoutUtility.current.layoutGroups.Push(guilayoutGroup);
			GUILayoutUtility.current.topLevel = guilayoutGroup;
			return guilayoutGroup;
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0000A98A File Offset: 0x00008B8A
		internal static GUILayoutGroup DoBeginLayoutArea(GUIStyle style, Type layoutType)
		{
			return GUILayoutUtility.BeginLayoutArea(style, layoutType);
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x0000A993 File Offset: 0x00008B93
		internal static GUILayoutGroup topLevel
		{
			get
			{
				return GUILayoutUtility.current.topLevel;
			}
		}

		/// <summary>
		///   <para>Reserve layout space for a rectangle for displaying some contents with a specific style.</para>
		/// </summary>
		/// <param name="content">The content to make room for displaying.</param>
		/// <param name="style">The GUIStyle to layout for.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>A rectangle that is large enough to contain content when rendered in style.</para>
		/// </returns>
		// Token: 0x06001BBD RID: 7101 RVA: 0x0000A99F File Offset: 0x00008B9F
		public static Rect GetRect(GUIContent content, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(content, style, null);
		}

		/// <summary>
		///   <para>Reserve layout space for a rectangle for displaying some contents with a specific style.</para>
		/// </summary>
		/// <param name="content">The content to make room for displaying.</param>
		/// <param name="style">The GUIStyle to layout for.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>A rectangle that is large enough to contain content when rendered in style.</para>
		/// </returns>
		// Token: 0x06001BBE RID: 7102 RVA: 0x0000A9A9 File Offset: 0x00008BA9
		public static Rect GetRect(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.DoGetRect(content, style, options);
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x0002055C File Offset: 0x0001E75C
		private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			GUIUtility.CheckOnGUI();
			EventType type = Event.current.type;
			if (type == EventType.Layout)
			{
				if (style.isHeightDependantOnWidth)
				{
					GUILayoutUtility.current.topLevel.Add(new GUIWordWrapSizer(style, content, options));
				}
				else
				{
					Vector2 vector = style.CalcSize(content);
					GUILayoutUtility.current.topLevel.Add(new GUILayoutEntry(vector.x, vector.x, vector.y, vector.y, style, options));
				}
				return GUILayoutUtility.kDummyRect;
			}
			if (type != EventType.Used)
			{
				return GUILayoutUtility.current.topLevel.GetNext().rect;
			}
			return GUILayoutUtility.kDummyRect;
		}

		/// <summary>
		///   <para>Reserve layout space for a rectangle with a fixed content area.</para>
		/// </summary>
		/// <param name="width">The width of the area you want.</param>
		/// <param name="height">The height of the area you want.</param>
		/// <param name="style">An optional GUIStyle to layout for. If specified, the style's padding value will be added to your sizes &amp; its margin value will be used for spacing.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The rectanlge to put your control in.</para>
		/// </returns>
		// Token: 0x06001BC0 RID: 7104 RVA: 0x0000A9B3 File Offset: 0x00008BB3
		public static Rect GetRect(float width, float height)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, GUIStyle.none, null);
		}

		/// <summary>
		///   <para>Reserve layout space for a rectangle with a fixed content area.</para>
		/// </summary>
		/// <param name="width">The width of the area you want.</param>
		/// <param name="height">The height of the area you want.</param>
		/// <param name="style">An optional GUIStyle to layout for. If specified, the style's padding value will be added to your sizes &amp; its margin value will be used for spacing.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The rectanlge to put your control in.</para>
		/// </returns>
		// Token: 0x06001BC1 RID: 7105 RVA: 0x0000A9C4 File Offset: 0x00008BC4
		public static Rect GetRect(float width, float height, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, style, null);
		}

		/// <summary>
		///   <para>Reserve layout space for a rectangle with a fixed content area.</para>
		/// </summary>
		/// <param name="width">The width of the area you want.</param>
		/// <param name="height">The height of the area you want.</param>
		/// <param name="style">An optional GUIStyle to layout for. If specified, the style's padding value will be added to your sizes &amp; its margin value will be used for spacing.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The rectanlge to put your control in.</para>
		/// </returns>
		// Token: 0x06001BC2 RID: 7106 RVA: 0x0000A9D1 File Offset: 0x00008BD1
		public static Rect GetRect(float width, float height, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, GUIStyle.none, options);
		}

		/// <summary>
		///   <para>Reserve layout space for a rectangle with a fixed content area.</para>
		/// </summary>
		/// <param name="width">The width of the area you want.</param>
		/// <param name="height">The height of the area you want.</param>
		/// <param name="style">An optional GUIStyle to layout for. If specified, the style's padding value will be added to your sizes &amp; its margin value will be used for spacing.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The rectanlge to put your control in.</para>
		/// </returns>
		// Token: 0x06001BC3 RID: 7107 RVA: 0x0000A9E2 File Offset: 0x00008BE2
		public static Rect GetRect(float width, float height, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, style, options);
		}

		/// <summary>
		///   <para>Reserve layout space for a flexible rect.</para>
		/// </summary>
		/// <param name="minWidth">The minimum width of the area passed back.</param>
		/// <param name="maxWidth">The maximum width of the area passed back.</param>
		/// <param name="minHeight">The minimum width of the area passed back.</param>
		/// <param name="maxHeight">The maximum width of the area passed back.</param>
		/// <param name="style">An optional style. If specified, the style's padding value will be added to the sizes requested &amp; the style's margin values will be used for spacing.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>A rectangle with size between minWidth &amp; maxWidth on both axes.</para>
		/// </returns>
		// Token: 0x06001BC4 RID: 7108 RVA: 0x0000A9EF File Offset: 0x00008BEF
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, GUIStyle.none, null);
		}

		/// <summary>
		///   <para>Reserve layout space for a flexible rect.</para>
		/// </summary>
		/// <param name="minWidth">The minimum width of the area passed back.</param>
		/// <param name="maxWidth">The maximum width of the area passed back.</param>
		/// <param name="minHeight">The minimum width of the area passed back.</param>
		/// <param name="maxHeight">The maximum width of the area passed back.</param>
		/// <param name="style">An optional style. If specified, the style's padding value will be added to the sizes requested &amp; the style's margin values will be used for spacing.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>A rectangle with size between minWidth &amp; maxWidth on both axes.</para>
		/// </returns>
		// Token: 0x06001BC5 RID: 7109 RVA: 0x0000AA00 File Offset: 0x00008C00
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, style, null);
		}

		/// <summary>
		///   <para>Reserve layout space for a flexible rect.</para>
		/// </summary>
		/// <param name="minWidth">The minimum width of the area passed back.</param>
		/// <param name="maxWidth">The maximum width of the area passed back.</param>
		/// <param name="minHeight">The minimum width of the area passed back.</param>
		/// <param name="maxHeight">The maximum width of the area passed back.</param>
		/// <param name="style">An optional style. If specified, the style's padding value will be added to the sizes requested &amp; the style's margin values will be used for spacing.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>A rectangle with size between minWidth &amp; maxWidth on both axes.</para>
		/// </returns>
		// Token: 0x06001BC6 RID: 7110 RVA: 0x0000AA0E File Offset: 0x00008C0E
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, GUIStyle.none, options);
		}

		/// <summary>
		///   <para>Reserve layout space for a flexible rect.</para>
		/// </summary>
		/// <param name="minWidth">The minimum width of the area passed back.</param>
		/// <param name="maxWidth">The maximum width of the area passed back.</param>
		/// <param name="minHeight">The minimum width of the area passed back.</param>
		/// <param name="maxHeight">The maximum width of the area passed back.</param>
		/// <param name="style">An optional style. If specified, the style's padding value will be added to the sizes requested &amp; the style's margin values will be used for spacing.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>A rectangle with size between minWidth &amp; maxWidth on both axes.</para>
		/// </returns>
		// Token: 0x06001BC7 RID: 7111 RVA: 0x0000AA20 File Offset: 0x00008C20
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, style, options);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00020610 File Offset: 0x0001E810
		private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options)
		{
			EventType type = Event.current.type;
			if (type == EventType.Layout)
			{
				GUILayoutUtility.current.topLevel.Add(new GUILayoutEntry(minWidth, maxWidth, minHeight, maxHeight, style, options));
				return GUILayoutUtility.kDummyRect;
			}
			if (type != EventType.Used)
			{
				return GUILayoutUtility.current.topLevel.GetNext().rect;
			}
			return GUILayoutUtility.kDummyRect;
		}

		/// <summary>
		///   <para>Get the rectangle last used by GUILayout for a control.</para>
		/// </summary>
		/// <returns>
		///   <para>The last used rectangle.</para>
		/// </returns>
		// Token: 0x06001BC9 RID: 7113 RVA: 0x00020678 File Offset: 0x0001E878
		public static Rect GetLastRect()
		{
			EventType type = Event.current.type;
			if (type == EventType.Layout)
			{
				return GUILayoutUtility.kDummyRect;
			}
			if (type != EventType.Used)
			{
				return GUILayoutUtility.current.topLevel.GetLast();
			}
			return GUILayoutUtility.kDummyRect;
		}

		/// <summary>
		///   <para>Reserve layout space for a rectangle with a specific aspect ratio.</para>
		/// </summary>
		/// <param name="aspect">The aspect ratio of the element (width / height).</param>
		/// <param name="style">An optional style. If specified, the style's padding value will be added to the sizes of the returned rectangle &amp; the style's margin values will be used for spacing.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The rect for the control.</para>
		/// </returns>
		// Token: 0x06001BCA RID: 7114 RVA: 0x0000AA2F File Offset: 0x00008C2F
		public static Rect GetAspectRect(float aspect)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, GUIStyle.none, null);
		}

		/// <summary>
		///   <para>Reserve layout space for a rectangle with a specific aspect ratio.</para>
		/// </summary>
		/// <param name="aspect">The aspect ratio of the element (width / height).</param>
		/// <param name="style">An optional style. If specified, the style's padding value will be added to the sizes of the returned rectangle &amp; the style's margin values will be used for spacing.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The rect for the control.</para>
		/// </returns>
		// Token: 0x06001BCB RID: 7115 RVA: 0x0000AA3D File Offset: 0x00008C3D
		public static Rect GetAspectRect(float aspect, GUIStyle style)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, style, null);
		}

		/// <summary>
		///   <para>Reserve layout space for a rectangle with a specific aspect ratio.</para>
		/// </summary>
		/// <param name="aspect">The aspect ratio of the element (width / height).</param>
		/// <param name="style">An optional style. If specified, the style's padding value will be added to the sizes of the returned rectangle &amp; the style's margin values will be used for spacing.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The rect for the control.</para>
		/// </returns>
		// Token: 0x06001BCC RID: 7116 RVA: 0x0000AA47 File Offset: 0x00008C47
		public static Rect GetAspectRect(float aspect, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, GUIStyle.none, options);
		}

		/// <summary>
		///   <para>Reserve layout space for a rectangle with a specific aspect ratio.</para>
		/// </summary>
		/// <param name="aspect">The aspect ratio of the element (width / height).</param>
		/// <param name="style">An optional style. If specified, the style's padding value will be added to the sizes of the returned rectangle &amp; the style's margin values will be used for spacing.</param>
		/// <param name="options">An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.&lt;br&gt;
		/// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight, 
		/// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
		/// <returns>
		///   <para>The rect for the control.</para>
		/// </returns>
		// Token: 0x06001BCD RID: 7117 RVA: 0x0000AA55 File Offset: 0x00008C55
		public static Rect GetAspectRect(float aspect, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, GUIStyle.none, options);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x000206C0 File Offset: 0x0001E8C0
		private static Rect DoGetAspectRect(float aspect, GUIStyle style, GUILayoutOption[] options)
		{
			EventType type = Event.current.type;
			if (type == EventType.Layout)
			{
				GUILayoutUtility.current.topLevel.Add(new GUIAspectSizer(aspect, options));
				return GUILayoutUtility.kDummyRect;
			}
			if (type != EventType.Used)
			{
				return GUILayoutUtility.current.topLevel.GetNext().rect;
			}
			return GUILayoutUtility.kDummyRect;
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x0000AA63 File Offset: 0x00008C63
		internal static GUIStyle spaceStyle
		{
			get
			{
				if (GUILayoutUtility.s_SpaceStyle == null)
				{
					GUILayoutUtility.s_SpaceStyle = new GUIStyle();
				}
				GUILayoutUtility.s_SpaceStyle.stretchWidth = false;
				return GUILayoutUtility.s_SpaceStyle;
			}
		}

		// Token: 0x06001BD0 RID: 7120
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Rect Internal_GetWindowRect(int windowID);

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0000AA89 File Offset: 0x00008C89
		private static void Internal_MoveWindow(int windowID, Rect r)
		{
			GUILayoutUtility.INTERNAL_CALL_Internal_MoveWindow(windowID, ref r);
		}

		// Token: 0x06001BD2 RID: 7122
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_MoveWindow(int windowID, ref Rect r);

		// Token: 0x06001BD3 RID: 7123
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Rect GetWindowsBounds();

		// Token: 0x0400070A RID: 1802
		private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts = new Dictionary<int, GUILayoutUtility.LayoutCache>();

		// Token: 0x0400070B RID: 1803
		private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows = new Dictionary<int, GUILayoutUtility.LayoutCache>();

		// Token: 0x0400070C RID: 1804
		internal static GUILayoutUtility.LayoutCache current = new GUILayoutUtility.LayoutCache();

		// Token: 0x0400070D RID: 1805
		private static readonly Rect kDummyRect = new Rect(0f, 0f, 1f, 1f);

		// Token: 0x0400070E RID: 1806
		private static GUIStyle s_SpaceStyle;

		// Token: 0x020001D6 RID: 470
		internal sealed class LayoutCache
		{
			// Token: 0x06001BD4 RID: 7124 RVA: 0x0000AA93 File Offset: 0x00008C93
			internal LayoutCache()
			{
				this.layoutGroups.Push(this.topLevel);
			}

			// Token: 0x06001BD5 RID: 7125 RVA: 0x00020724 File Offset: 0x0001E924
			internal LayoutCache(GUILayoutUtility.LayoutCache other)
			{
				this.topLevel = other.topLevel;
				this.layoutGroups = other.layoutGroups;
				this.windows = other.windows;
			}

			// Token: 0x0400070F RID: 1807
			internal GUILayoutGroup topLevel = new GUILayoutGroup();

			// Token: 0x04000710 RID: 1808
			internal GenericStack layoutGroups = new GenericStack();

			// Token: 0x04000711 RID: 1809
			internal GUILayoutGroup windows = new GUILayoutGroup();
		}
	}
}
