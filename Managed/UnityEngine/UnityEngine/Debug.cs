using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Class containing methods to ease debugging while developing a game.</para>
	/// </summary>
	// Token: 0x020000B2 RID: 178
	public sealed class Debug
	{
		/// <summary>
		///   <para>Draws a line between specified start and end points.</para>
		/// </summary>
		/// <param name="start">Point in world space where the line should start.</param>
		/// <param name="end">Point in world space where the line should end.</param>
		/// <param name="color">Color of the line.</param>
		/// <param name="duration">How long the line should be visible for.</param>
		/// <param name="depthTest">Should the line be obscured by objects closer to the camera?</param>
		// Token: 0x06000A74 RID: 2676 RVA: 0x00005B3E File Offset: 0x00003D3E
		public static void DrawLine(Vector3 start, Vector3 end, [DefaultValue("Color.white")] Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest)
		{
			Debug.INTERNAL_CALL_DrawLine(ref start, ref end, ref color, duration, depthTest);
		}

		/// <summary>
		///   <para>Draws a line between specified start and end points.</para>
		/// </summary>
		/// <param name="start">Point in world space where the line should start.</param>
		/// <param name="end">Point in world space where the line should end.</param>
		/// <param name="color">Color of the line.</param>
		/// <param name="duration">How long the line should be visible for.</param>
		/// <param name="depthTest">Should the line be obscured by objects closer to the camera?</param>
		// Token: 0x06000A75 RID: 2677 RVA: 0x00016CD4 File Offset: 0x00014ED4
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
		{
			bool flag = true;
			Debug.INTERNAL_CALL_DrawLine(ref start, ref end, ref color, duration, flag);
		}

		/// <summary>
		///   <para>Draws a line between specified start and end points.</para>
		/// </summary>
		/// <param name="start">Point in world space where the line should start.</param>
		/// <param name="end">Point in world space where the line should end.</param>
		/// <param name="color">Color of the line.</param>
		/// <param name="duration">How long the line should be visible for.</param>
		/// <param name="depthTest">Should the line be obscured by objects closer to the camera?</param>
		// Token: 0x06000A76 RID: 2678 RVA: 0x00016CF0 File Offset: 0x00014EF0
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end, Color color)
		{
			bool flag = true;
			float num = 0f;
			Debug.INTERNAL_CALL_DrawLine(ref start, ref end, ref color, num, flag);
		}

		/// <summary>
		///   <para>Draws a line between specified start and end points.</para>
		/// </summary>
		/// <param name="start">Point in world space where the line should start.</param>
		/// <param name="end">Point in world space where the line should end.</param>
		/// <param name="color">Color of the line.</param>
		/// <param name="duration">How long the line should be visible for.</param>
		/// <param name="depthTest">Should the line be obscured by objects closer to the camera?</param>
		// Token: 0x06000A77 RID: 2679 RVA: 0x00016D14 File Offset: 0x00014F14
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end)
		{
			bool flag = true;
			float num = 0f;
			Color white = Color.white;
			Debug.INTERNAL_CALL_DrawLine(ref start, ref end, ref white, num, flag);
		}

		// Token: 0x06000A78 RID: 2680
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawLine(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest);

		/// <summary>
		///   <para>Draws a line from start to start + dir in world coordinates.</para>
		/// </summary>
		/// <param name="start">Point in world space where the ray should start.</param>
		/// <param name="dir">Direction and length of the ray.</param>
		/// <param name="color">Color of the drawn line.</param>
		/// <param name="duration">How long the line will be visible for (in seconds).</param>
		/// <param name="depthTest">Should the line be obscured by other objects closer to the camera?</param>
		// Token: 0x06000A79 RID: 2681 RVA: 0x00016D3C File Offset: 0x00014F3C
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
		{
			bool flag = true;
			Debug.DrawRay(start, dir, color, duration, flag);
		}

		/// <summary>
		///   <para>Draws a line from start to start + dir in world coordinates.</para>
		/// </summary>
		/// <param name="start">Point in world space where the ray should start.</param>
		/// <param name="dir">Direction and length of the ray.</param>
		/// <param name="color">Color of the drawn line.</param>
		/// <param name="duration">How long the line will be visible for (in seconds).</param>
		/// <param name="depthTest">Should the line be obscured by other objects closer to the camera?</param>
		// Token: 0x06000A7A RID: 2682 RVA: 0x00016D58 File Offset: 0x00014F58
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir, Color color)
		{
			bool flag = true;
			float num = 0f;
			Debug.DrawRay(start, dir, color, num, flag);
		}

		/// <summary>
		///   <para>Draws a line from start to start + dir in world coordinates.</para>
		/// </summary>
		/// <param name="start">Point in world space where the ray should start.</param>
		/// <param name="dir">Direction and length of the ray.</param>
		/// <param name="color">Color of the drawn line.</param>
		/// <param name="duration">How long the line will be visible for (in seconds).</param>
		/// <param name="depthTest">Should the line be obscured by other objects closer to the camera?</param>
		// Token: 0x06000A7B RID: 2683 RVA: 0x00016D78 File Offset: 0x00014F78
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir)
		{
			bool flag = true;
			float num = 0f;
			Color white = Color.white;
			Debug.DrawRay(start, dir, white, num, flag);
		}

		/// <summary>
		///   <para>Draws a line from start to start + dir in world coordinates.</para>
		/// </summary>
		/// <param name="start">Point in world space where the ray should start.</param>
		/// <param name="dir">Direction and length of the ray.</param>
		/// <param name="color">Color of the drawn line.</param>
		/// <param name="duration">How long the line will be visible for (in seconds).</param>
		/// <param name="depthTest">Should the line be obscured by other objects closer to the camera?</param>
		// Token: 0x06000A7C RID: 2684 RVA: 0x00005B4E File Offset: 0x00003D4E
		public static void DrawRay(Vector3 start, Vector3 dir, [DefaultValue("Color.white")] Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest)
		{
			Debug.DrawLine(start, start + dir, color, duration, depthTest);
		}

		/// <summary>
		///   <para>Pauses the editor.</para>
		/// </summary>
		// Token: 0x06000A7D RID: 2685
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Break();

		// Token: 0x06000A7E RID: 2686
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DebugBreak();

		// Token: 0x06000A7F RID: 2687
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Log(int level, string msg, [Writable] Object obj);

		// Token: 0x06000A80 RID: 2688
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_LogException(Exception exception, [Writable] Object obj);

		/// <summary>
		///   <para>Logs message to the Unity Console.</para>
		/// </summary>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		/// <param name="context">Object to which the message applies.</param>
		// Token: 0x06000A81 RID: 2689 RVA: 0x00002753 File Offset: 0x00000953
		public static void Log(object message)
		{
		}

		/// <summary>
		///   <para>Logs message to the Unity Console.</para>
		/// </summary>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		/// <param name="context">Object to which the message applies.</param>
		// Token: 0x06000A82 RID: 2690 RVA: 0x00002753 File Offset: 0x00000953
		public static void Log(object message, Object context)
		{
		}

		/// <summary>
		///   <para>Logs a formatted message to the Unity Console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		/// <param name="context">Object to which the message applies.</param>
		// Token: 0x06000A83 RID: 2691 RVA: 0x00005B61 File Offset: 0x00003D61
		public static void LogFormat(string format, params object[] args)
		{
			Debug.Log(string.Format(format, args));
		}

		/// <summary>
		///   <para>Logs a formatted message to the Unity Console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		/// <param name="context">Object to which the message applies.</param>
		// Token: 0x06000A84 RID: 2692 RVA: 0x00005B6F File Offset: 0x00003D6F
		public static void LogFormat(Object context, string format, params object[] args)
		{
			Debug.Log(string.Format(format, args), context);
		}

		/// <summary>
		///   <para>A variant of Debug.Log that logs an error message to the console.</para>
		/// </summary>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		/// <param name="context">Object to which the message applies.</param>
		// Token: 0x06000A85 RID: 2693 RVA: 0x00005B7E File Offset: 0x00003D7E
		public static void LogError(object message)
		{
			Debug.Internal_Log(2, (message == null) ? "Null" : message.ToString(), null);
		}

		/// <summary>
		///   <para>A variant of Debug.Log that logs an error message to the console.</para>
		/// </summary>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		/// <param name="context">Object to which the message applies.</param>
		// Token: 0x06000A86 RID: 2694 RVA: 0x00005B9D File Offset: 0x00003D9D
		public static void LogError(object message, Object context)
		{
			Debug.Internal_Log(2, message.ToString(), context);
		}

		/// <summary>
		///   <para>Logs a formatted error message to the Unity console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		/// <param name="context">Object to which the message applies.</param>
		// Token: 0x06000A87 RID: 2695 RVA: 0x00005BAC File Offset: 0x00003DAC
		public static void LogErrorFormat(string format, params object[] args)
		{
			Debug.LogError(string.Format(format, args));
		}

		/// <summary>
		///   <para>Logs a formatted error message to the Unity console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		/// <param name="context">Object to which the message applies.</param>
		// Token: 0x06000A88 RID: 2696 RVA: 0x00005BBA File Offset: 0x00003DBA
		public static void LogErrorFormat(Object context, string format, params object[] args)
		{
			Debug.LogError(string.Format(format, args), context);
		}

		/// <summary>
		///   <para>Clears errors from the developer console.</para>
		/// </summary>
		// Token: 0x06000A89 RID: 2697
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearDeveloperConsole();

		/// <summary>
		///   <para>Opens or closes developer console.</para>
		/// </summary>
		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000A8A RID: 2698
		// (set) Token: 0x06000A8B RID: 2699
		public static extern bool developerConsoleVisible
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000A8C RID: 2700
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void WriteLineToLogFile(string message);

		/// <summary>
		///   <para>A variant of Debug.Log that logs an error message to the console.</para>
		/// </summary>
		/// <param name="exception"></param>
		/// <param name="context"></param>
		// Token: 0x06000A8D RID: 2701 RVA: 0x00005BC9 File Offset: 0x00003DC9
		public static void LogException(Exception exception)
		{
			Debug.Internal_LogException(exception, null);
		}

		/// <summary>
		///   <para>A variant of Debug.Log that logs an error message to the console.</para>
		/// </summary>
		/// <param name="exception"></param>
		/// <param name="context"></param>
		// Token: 0x06000A8E RID: 2702 RVA: 0x00005BD2 File Offset: 0x00003DD2
		public static void LogException(Exception exception, Object context)
		{
			Debug.Internal_LogException(exception, context);
		}

		/// <summary>
		///   <para>A variant of Debug.Log that logs a warning message to the console.</para>
		/// </summary>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		/// <param name="context">Object to which the message applies.</param>
		// Token: 0x06000A8F RID: 2703 RVA: 0x00005BDB File Offset: 0x00003DDB
		public static void LogWarning(object message)
		{
			Debug.Internal_Log(1, message.ToString(), null);
		}

		/// <summary>
		///   <para>A variant of Debug.Log that logs a warning message to the console.</para>
		/// </summary>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		/// <param name="context">Object to which the message applies.</param>
		// Token: 0x06000A90 RID: 2704 RVA: 0x00005BEA File Offset: 0x00003DEA
		public static void LogWarning(object message, Object context)
		{
			Debug.Internal_Log(1, message.ToString(), context);
		}

		/// <summary>
		///   <para>Logs a formatted warning message to the Unity Console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		/// <param name="context">Object to which the message applies.</param>
		// Token: 0x06000A91 RID: 2705 RVA: 0x00005BF9 File Offset: 0x00003DF9
		public static void LogWarningFormat(string format, params object[] args)
		{
			Debug.LogWarning(string.Format(format, args));
		}

		/// <summary>
		///   <para>Logs a formatted warning message to the Unity Console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		/// <param name="context">Object to which the message applies.</param>
		// Token: 0x06000A92 RID: 2706 RVA: 0x00005C07 File Offset: 0x00003E07
		public static void LogWarningFormat(Object context, string format, params object[] args)
		{
			Debug.LogWarning(string.Format(format, args), context);
		}

		/// <summary>
		///   <para>Assert the condition.</para>
		/// </summary>
		/// <param name="condition">Condition you expect to be true.</param>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		/// <param name="format">Formatted string for display.</param>
		/// <param name="args">Arguments for the formatted string.</param>
		// Token: 0x06000A93 RID: 2707 RVA: 0x00005C16 File Offset: 0x00003E16
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition)
		{
			if (!condition)
			{
				Debug.LogAssertion(null);
			}
		}

		/// <summary>
		///   <para>Assert the condition.</para>
		/// </summary>
		/// <param name="condition">Condition you expect to be true.</param>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		/// <param name="format">Formatted string for display.</param>
		/// <param name="args">Arguments for the formatted string.</param>
		// Token: 0x06000A94 RID: 2708 RVA: 0x00005C24 File Offset: 0x00003E24
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string message)
		{
			if (!condition)
			{
				Debug.LogAssertion(message);
			}
		}

		/// <summary>
		///   <para>Assert the condition.</para>
		/// </summary>
		/// <param name="condition">Condition you expect to be true.</param>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		/// <param name="format">Formatted string for display.</param>
		/// <param name="args">Arguments for the formatted string.</param>
		// Token: 0x06000A95 RID: 2709 RVA: 0x00005C32 File Offset: 0x00003E32
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string format, params object[] args)
		{
			if (!condition)
			{
				Debug.LogAssertion(string.Format(format, args));
			}
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00005C46 File Offset: 0x00003E46
		internal static void LogAssertion(string message)
		{
			Debug.Internal_Log(3, message, null);
		}

		/// <summary>
		///   <para>In the Build Settings dialog there is a check box called "Development Build".</para>
		/// </summary>
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000A97 RID: 2711
		public static extern bool isDebugBuild
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000A98 RID: 2712
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void OpenConsoleFile();
	}
}
