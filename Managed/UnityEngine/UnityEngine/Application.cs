using System;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Access to application run-time data.</para>
	/// </summary>
	// Token: 0x020000A8 RID: 168
	public sealed class Application
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000953 RID: 2387 RVA: 0x000057BC File Offset: 0x000039BC
		// (remove) Token: 0x06000954 RID: 2388 RVA: 0x000057E4 File Offset: 0x000039E4
		public static event Application.LogCallback logMessageReceived
		{
			add
			{
				Application.s_LogCallbackHandler = (Application.LogCallback)Delegate.Combine(Application.s_LogCallbackHandler, value);
				Application.SetLogCallbackDefined(true, Application.s_LogCallbackHandlerThreaded != null);
			}
			remove
			{
				Application.s_LogCallbackHandler = (Application.LogCallback)Delegate.Remove(Application.s_LogCallbackHandler, value);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000955 RID: 2389 RVA: 0x000057FB File Offset: 0x000039FB
		// (remove) Token: 0x06000956 RID: 2390 RVA: 0x00005819 File Offset: 0x00003A19
		public static event Application.LogCallback logMessageReceivedThreaded
		{
			add
			{
				Application.s_LogCallbackHandlerThreaded = (Application.LogCallback)Delegate.Combine(Application.s_LogCallbackHandlerThreaded, value);
				Application.SetLogCallbackDefined(true, true);
			}
			remove
			{
				Application.s_LogCallbackHandlerThreaded = (Application.LogCallback)Delegate.Remove(Application.s_LogCallbackHandlerThreaded, value);
			}
		}

		/// <summary>
		///   <para>Quits the player application.</para>
		/// </summary>
		// Token: 0x06000957 RID: 2391
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Quit();

		/// <summary>
		///   <para>Cancels quitting the application. This is useful for showing a splash screen at the end of a game.</para>
		/// </summary>
		// Token: 0x06000958 RID: 2392
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CancelQuit();

		/// <summary>
		///   <para>The level index that was last loaded (Read Only).</para>
		/// </summary>
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000959 RID: 2393
		public static extern int loadedLevel
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The name of the level that was last loaded (Read Only).</para>
		/// </summary>
		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600095A RID: 2394
		public static extern string loadedLevelName
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Loads the level by its name or index.</para>
		/// </summary>
		/// <param name="index">The level to load.</param>
		/// <param name="name">The name of the level to load.</param>
		// Token: 0x0600095B RID: 2395 RVA: 0x00005830 File Offset: 0x00003A30
		public static void LoadLevel(int index)
		{
			Application.LoadLevelAsync(null, index, false, true);
		}

		/// <summary>
		///   <para>Loads the level by its name or index.</para>
		/// </summary>
		/// <param name="index">The level to load.</param>
		/// <param name="name">The name of the level to load.</param>
		// Token: 0x0600095C RID: 2396 RVA: 0x0000583C File Offset: 0x00003A3C
		public static void LoadLevel(string name)
		{
			Application.LoadLevelAsync(name, -1, false, true);
		}

		/// <summary>
		///   <para>Loads the level asynchronously in the background.</para>
		/// </summary>
		/// <param name="index"></param>
		/// <param name="levelName"></param>
		// Token: 0x0600095D RID: 2397 RVA: 0x00005848 File Offset: 0x00003A48
		public static AsyncOperation LoadLevelAsync(int index)
		{
			return Application.LoadLevelAsync(null, index, false, false);
		}

		/// <summary>
		///   <para>Loads the level asynchronously in the background.</para>
		/// </summary>
		/// <param name="index"></param>
		/// <param name="levelName"></param>
		// Token: 0x0600095E RID: 2398 RVA: 0x00005853 File Offset: 0x00003A53
		public static AsyncOperation LoadLevelAsync(string levelName)
		{
			return Application.LoadLevelAsync(levelName, -1, false, false);
		}

		/// <summary>
		///   <para>Loads the level additively and asynchronously in the background.</para>
		/// </summary>
		/// <param name="index"></param>
		/// <param name="levelName"></param>
		// Token: 0x0600095F RID: 2399 RVA: 0x0000585E File Offset: 0x00003A5E
		public static AsyncOperation LoadLevelAdditiveAsync(int index)
		{
			return Application.LoadLevelAsync(null, index, true, false);
		}

		/// <summary>
		///   <para>Loads the level additively and asynchronously in the background.</para>
		/// </summary>
		/// <param name="index"></param>
		/// <param name="levelName"></param>
		// Token: 0x06000960 RID: 2400 RVA: 0x00005869 File Offset: 0x00003A69
		public static AsyncOperation LoadLevelAdditiveAsync(string levelName)
		{
			return Application.LoadLevelAsync(levelName, -1, true, false);
		}

		// Token: 0x06000961 RID: 2401
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AsyncOperation LoadLevelAsync(string monoLevelName, int index, bool additive, bool mustCompleteNextFrame);

		/// <summary>
		///   <para>Unloads all GameObject associated with the given scene. Note that assets are currently not unloaded, in order to free up asset memory call Resources.UnloadAllUnusedAssets.</para>
		/// </summary>
		/// <param name="index">Index of the scene in the PlayerSettings to unload.</param>
		/// <param name="scenePath">Name of the scene to Unload.</param>
		/// <returns>
		///   <para>Return true if the scene is unloaded.</para>
		/// </returns>
		// Token: 0x06000962 RID: 2402 RVA: 0x00005874 File Offset: 0x00003A74
		public static bool UnloadLevel(int index)
		{
			return Application.UnloadLevel(string.Empty, index);
		}

		/// <summary>
		///   <para>Unloads all GameObject associated with the given scene. Note that assets are currently not unloaded, in order to free up asset memory call Resources.UnloadAllUnusedAssets.</para>
		/// </summary>
		/// <param name="index">Index of the scene in the PlayerSettings to unload.</param>
		/// <param name="scenePath">Name of the scene to Unload.</param>
		/// <returns>
		///   <para>Return true if the scene is unloaded.</para>
		/// </returns>
		// Token: 0x06000963 RID: 2403 RVA: 0x00005881 File Offset: 0x00003A81
		public static bool UnloadLevel(string scenePath)
		{
			return Application.UnloadLevel(scenePath, -1);
		}

		// Token: 0x06000964 RID: 2404
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool UnloadLevel(string monoScenePath, int index);

		/// <summary>
		///   <para>Loads a level additively.</para>
		/// </summary>
		/// <param name="index"></param>
		/// <param name="name"></param>
		// Token: 0x06000965 RID: 2405 RVA: 0x0000588A File Offset: 0x00003A8A
		public static void LoadLevelAdditive(int index)
		{
			Application.LoadLevelAsync(null, index, true, true);
		}

		/// <summary>
		///   <para>Loads a level additively.</para>
		/// </summary>
		/// <param name="index"></param>
		/// <param name="name"></param>
		// Token: 0x06000966 RID: 2406 RVA: 0x00005896 File Offset: 0x00003A96
		public static void LoadLevelAdditive(string name)
		{
			Application.LoadLevelAsync(name, -1, true, true);
		}

		/// <summary>
		///   <para>Is some level being loaded? (Read Only)</para>
		/// </summary>
		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000967 RID: 2407
		[Obsolete("This property is deprecated, please use LoadLevelAsync to detect if a specific scene is currently loading.")]
		public static extern bool isLoadingLevel
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The total number of levels available (Read Only).</para>
		/// </summary>
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000968 RID: 2408
		public static extern int levelCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000969 RID: 2409
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float GetStreamProgressForLevelByName(string levelName);

		/// <summary>
		///   <para>How far has the download progressed? [0...1].</para>
		/// </summary>
		/// <param name="levelIndex"></param>
		// Token: 0x0600096A RID: 2410
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetStreamProgressForLevel(int levelIndex);

		/// <summary>
		///   <para>How far has the download progressed? [0...1].</para>
		/// </summary>
		/// <param name="levelName"></param>
		// Token: 0x0600096B RID: 2411 RVA: 0x000058A2 File Offset: 0x00003AA2
		public static float GetStreamProgressForLevel(string levelName)
		{
			return Application.GetStreamProgressForLevelByName(levelName);
		}

		/// <summary>
		///   <para>How many bytes have we downloaded from the main unity web stream (Read Only).</para>
		/// </summary>
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600096C RID: 2412
		public static extern int streamedBytes
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x0600096D RID: 2413
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool CanStreamedLevelBeLoadedByName(string levelName);

		/// <summary>
		///   <para>Can the streamed level be loaded?</para>
		/// </summary>
		/// <param name="levelIndex"></param>
		// Token: 0x0600096E RID: 2414
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CanStreamedLevelBeLoaded(int levelIndex);

		/// <summary>
		///   <para>Can the streamed level be loaded?</para>
		/// </summary>
		/// <param name="levelName"></param>
		// Token: 0x0600096F RID: 2415 RVA: 0x000058AA File Offset: 0x00003AAA
		public static bool CanStreamedLevelBeLoaded(string levelName)
		{
			return Application.CanStreamedLevelBeLoadedByName(levelName);
		}

		/// <summary>
		///   <para>Returns true when in any kind of player (Read Only).</para>
		/// </summary>
		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000970 RID: 2416
		public static extern bool isPlaying
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Are we running inside the Unity editor? (Read Only)</para>
		/// </summary>
		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000971 RID: 2417
		public static extern bool isEditor
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Are we running inside a web player? (Read Only)</para>
		/// </summary>
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000972 RID: 2418
		public static extern bool isWebPlayer
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns the platform the game is running (Read Only).</para>
		/// </summary>
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000973 RID: 2419
		public static extern RuntimePlatform platform
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Is the current Runtime platform a known mobile platform.</para>
		/// </summary>
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x000167D4 File Offset: 0x000149D4
		public static bool isMobilePlatform
		{
			get
			{
				switch (Application.platform)
				{
				case RuntimePlatform.IPhonePlayer:
				case RuntimePlatform.Android:
				case RuntimePlatform.MetroPlayerX86:
				case RuntimePlatform.MetroPlayerX64:
				case RuntimePlatform.MetroPlayerARM:
				case RuntimePlatform.WP8Player:
				case RuntimePlatform.BlackBerryPlayer:
				case RuntimePlatform.TizenPlayer:
					return true;
				}
				return false;
			}
		}

		/// <summary>
		///   <para>Is the current Runtime platform a known console platform.</para>
		/// </summary>
		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x00016838 File Offset: 0x00014A38
		public static bool isConsolePlatform
		{
			get
			{
				RuntimePlatform platform = Application.platform;
				return platform == RuntimePlatform.PS3 || platform == RuntimePlatform.PS4 || platform == RuntimePlatform.XBOX360 || platform == RuntimePlatform.XboxOne;
			}
		}

		/// <summary>
		///   <para>Captures a screenshot at path filename as a PNG file.</para>
		/// </summary>
		/// <param name="filename">Pathname to save the screenshot file to.</param>
		/// <param name="superSize">Factor by which to increase resolution.</param>
		// Token: 0x06000976 RID: 2422
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CaptureScreenshot(string filename, [DefaultValue("0")] int superSize);

		/// <summary>
		///   <para>Captures a screenshot at path filename as a PNG file.</para>
		/// </summary>
		/// <param name="filename">Pathname to save the screenshot file to.</param>
		/// <param name="superSize">Factor by which to increase resolution.</param>
		// Token: 0x06000977 RID: 2423 RVA: 0x0001686C File Offset: 0x00014A6C
		[ExcludeFromDocs]
		public static void CaptureScreenshot(string filename)
		{
			int num = 0;
			Application.CaptureScreenshot(filename, num);
		}

		/// <summary>
		///   <para>Should the player be running when the application is in the background?</para>
		/// </summary>
		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000978 RID: 2424
		// (set) Token: 0x06000979 RID: 2425
		public static extern bool runInBackground
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x000058B2 File Offset: 0x00003AB2
		[Obsolete("use Application.isEditor instead")]
		public static bool isPlayer
		{
			get
			{
				return !Application.isEditor;
			}
		}

		/// <summary>
		///   <para>Is Unity activated with the Pro license?</para>
		/// </summary>
		// Token: 0x0600097B RID: 2427
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasProLicense();

		// Token: 0x0600097C RID: 2428
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool HasAdvancedLicense();

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600097D RID: 2429
		internal static extern bool isBatchmode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600097E RID: 2430
		internal static extern bool isHumanControllingUs
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600097F RID: 2431
		internal static extern bool isRunningUnitTests
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000980 RID: 2432
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool HasARGV(string name);

		// Token: 0x06000981 RID: 2433
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string GetValueForARGV(string name);

		// Token: 0x06000982 RID: 2434
		[Obsolete("Use Object.DontDestroyOnLoad instead")]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DontDestroyOnLoad(Object mono);

		/// <summary>
		///   <para>Contains the path to the game data folder (Read Only).</para>
		/// </summary>
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000983 RID: 2435
		public static extern string dataPath
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Contains the path to the StreamingAssets folder (Read Only).</para>
		/// </summary>
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000984 RID: 2436
		public static extern string streamingAssetsPath
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Contains the path to a persistent data directory (Read Only).</para>
		/// </summary>
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000985 RID: 2437
		[SecurityCritical]
		public static extern string persistentDataPath
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Contains the path to a temporary data / cache directory (Read Only).</para>
		/// </summary>
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000986 RID: 2438
		public static extern string temporaryCachePath
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The path to the web player data file relative to the html file (Read Only).</para>
		/// </summary>
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000987 RID: 2439
		public static extern string srcValue
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The absolute path to the web player data file (Read Only).</para>
		/// </summary>
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000988 RID: 2440
		public static extern string absoluteURL
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00016884 File Offset: 0x00014A84
		private static string ObjectToJSString(object o)
		{
			if (o == null)
			{
				return "null";
			}
			if (o is string)
			{
				string text = o.ToString().Replace("\\", "\\\\");
				text = text.Replace("\"", "\\\"");
				text = text.Replace("\n", "\\n");
				text = text.Replace("\r", "\\r");
				text = text.Replace("\0", string.Empty);
				text = text.Replace("\u2028", string.Empty);
				text = text.Replace("\u2029", string.Empty);
				return '"' + text + '"';
			}
			if (o is int || o is short || o is uint || o is ushort || o is byte)
			{
				return o.ToString();
			}
			if (o is float)
			{
				NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
				return ((float)o).ToString(numberFormat);
			}
			if (o is double)
			{
				NumberFormatInfo numberFormat2 = CultureInfo.InvariantCulture.NumberFormat;
				return ((double)o).ToString(numberFormat2);
			}
			if (o is char)
			{
				if ((char)o == '"')
				{
					return "\"\\\"\"";
				}
				return '"' + o.ToString() + '"';
			}
			else
			{
				if (o is IList)
				{
					IList list = (IList)o;
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("new Array(");
					int count = list.Count;
					for (int i = 0; i < count; i++)
					{
						if (i != 0)
						{
							stringBuilder.Append(", ");
						}
						stringBuilder.Append(Application.ObjectToJSString(list[i]));
					}
					stringBuilder.Append(")");
					return stringBuilder.ToString();
				}
				return Application.ObjectToJSString(o.ToString());
			}
		}

		/// <summary>
		///   <para>Calls a function in the containing web page (Web Player only).</para>
		/// </summary>
		/// <param name="functionName"></param>
		/// <param name="args"></param>
		// Token: 0x0600098A RID: 2442 RVA: 0x000058BC File Offset: 0x00003ABC
		public static void ExternalCall(string functionName, params object[] args)
		{
			Application.Internal_ExternalCall(Application.BuildInvocationForArguments(functionName, args));
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00016A8C File Offset: 0x00014C8C
		private static string BuildInvocationForArguments(string functionName, params object[] args)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(functionName);
			stringBuilder.Append('(');
			int num = args.Length;
			for (int i = 0; i < num; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(Application.ObjectToJSString(args[i]));
			}
			stringBuilder.Append(')');
			stringBuilder.Append(';');
			return stringBuilder.ToString();
		}

		/// <summary>
		///   <para>Evaluates script function in the containing web page.</para>
		/// </summary>
		/// <param name="script">The Javascript function to call.</param>
		// Token: 0x0600098C RID: 2444 RVA: 0x000058CA File Offset: 0x00003ACA
		public static void ExternalEval(string script)
		{
			if (script.Length > 0 && script[script.Length - 1] != ';')
			{
				script += ';';
			}
			Application.Internal_ExternalCall(script);
		}

		// Token: 0x0600098D RID: 2445
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ExternalCall(string script);

		/// <summary>
		///   <para>The version of the Unity runtime used to play the content.</para>
		/// </summary>
		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600098E RID: 2446
		public static extern string unityVersion
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x0600098F RID: 2447
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetBuildUnityVersion();

		// Token: 0x06000990 RID: 2448
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetNumericUnityVersion(string version);

		/// <summary>
		///   <para>Returns application version number  (Read Only).</para>
		/// </summary>
		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000991 RID: 2449
		public static extern string version
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns application bundle identifier at runtime.</para>
		/// </summary>
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000992 RID: 2450
		public static extern string bundleIdentifier
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns application install mode (Read Only).</para>
		/// </summary>
		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000993 RID: 2451
		public static extern ApplicationInstallMode installMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns application running in sandbox (Read Only).</para>
		/// </summary>
		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000994 RID: 2452
		public static extern ApplicationSandboxType sandboxType
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns application product name (Read Only).</para>
		/// </summary>
		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000995 RID: 2453
		public static extern string productName
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Return application company name (Read Only).</para>
		/// </summary>
		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000996 RID: 2454
		public static extern string companyName
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>A unique cloud project identifier. It is unique for every project (Read Only).</para>
		/// </summary>
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000997 RID: 2455
		public static extern string cloudProjectId
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00005902 File Offset: 0x00003B02
		internal static void InvokeOnAdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled)
		{
			if (Application.OnAdvertisingIdentifierCallback != null)
			{
				Application.OnAdvertisingIdentifierCallback(advertisingId, trackingEnabled);
			}
		}

		/// <summary>
		///   <para>Indicates whether Unity's webplayer security model is enabled.</para>
		/// </summary>
		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000999 RID: 2457
		public static extern bool webSecurityEnabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600099A RID: 2458
		public static extern string webSecurityHostUrl
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Opens the url in a browser.</para>
		/// </summary>
		/// <param name="url"></param>
		// Token: 0x0600099B RID: 2459
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OpenURL(string url);

		// Token: 0x0600099C RID: 2460
		[WrapperlessIcall]
		[Obsolete("For internal use only")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CommitSuicide(int mode);

		/// <summary>
		///   <para>Instructs game to try to render at a specified frame rate.</para>
		/// </summary>
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600099D RID: 2461
		// (set) Token: 0x0600099E RID: 2462
		public static extern int targetFrameRate
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The language the user's operating system is running in.</para>
		/// </summary>
		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600099F RID: 2463
		public static extern SystemLanguage systemLanguage
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00016B00 File Offset: 0x00014D00
		private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
		{
			if (invokedOnMainThread)
			{
				Application.LogCallback logCallback = Application.s_LogCallbackHandler;
				if (logCallback != null)
				{
					logCallback(logString, stackTrace, type);
				}
			}
			Application.LogCallback logCallback2 = Application.s_LogCallbackHandlerThreaded;
			if (logCallback2 != null)
			{
				logCallback2(logString, stackTrace, type);
			}
		}

		// Token: 0x060009A1 RID: 2465
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetLogCallbackDefined(bool defined, bool threaded);

		/// <summary>
		///   <para>Stack trace logging options. The default value is StackTraceLogType.ScriptOnly.</para>
		/// </summary>
		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060009A2 RID: 2466
		// (set) Token: 0x060009A3 RID: 2467
		public static extern StackTraceLogType stackTraceLogType
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Priority of background loading thread.</para>
		/// </summary>
		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060009A4 RID: 2468
		// (set) Token: 0x060009A5 RID: 2469
		public static extern ThreadPriority backgroundLoadingPriority
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns the type of Internet reachability currently possible on the device.</para>
		/// </summary>
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060009A6 RID: 2470
		public static extern NetworkReachability internetReachability
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns false if application is altered in any way after it was built.</para>
		/// </summary>
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060009A7 RID: 2471
		public static extern bool genuine
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns true if application integrity can be confirmed.</para>
		/// </summary>
		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060009A8 RID: 2472
		public static extern bool genuineCheckAvailable
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Request authorization to use the webcam or microphone in the Web Player.</para>
		/// </summary>
		/// <param name="mode"></param>
		// Token: 0x060009A9 RID: 2473
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AsyncOperation RequestUserAuthorization(UserAuthorization mode);

		/// <summary>
		///   <para>Check if the user has authorized use of the webcam or microphone in the Web Player.</para>
		/// </summary>
		/// <param name="mode"></param>
		// Token: 0x060009AA RID: 2474
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasUserAuthorization(UserAuthorization mode);

		// Token: 0x060009AB RID: 2475
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void ReplyToUserAuthorizationRequest(bool reply, [DefaultValue("false")] bool remember);

		// Token: 0x060009AC RID: 2476 RVA: 0x00016B40 File Offset: 0x00014D40
		[ExcludeFromDocs]
		internal static void ReplyToUserAuthorizationRequest(bool reply)
		{
			bool flag = false;
			Application.ReplyToUserAuthorizationRequest(reply, flag);
		}

		// Token: 0x060009AD RID: 2477
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetUserAuthorizationRequestMode_Internal();

		// Token: 0x060009AE RID: 2478 RVA: 0x0000591A File Offset: 0x00003B1A
		internal static UserAuthorization GetUserAuthorizationRequestMode()
		{
			return (UserAuthorization)Application.GetUserAuthorizationRequestMode_Internal();
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060009AF RID: 2479
		internal static extern bool submitAnalytics
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Checks whether splash screen is being shown.</para>
		/// </summary>
		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060009B0 RID: 2480
		public static extern bool isShowingSplashScreen
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00005921 File Offset: 0x00003B21
		[Obsolete("Application.RegisterLogCallback is deprecated. Use Application.logMessageReceived instead.")]
		public static void RegisterLogCallback(Application.LogCallback handler)
		{
			Application.RegisterLogCallback(handler, false);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0000592A File Offset: 0x00003B2A
		[Obsolete("Application.RegisterLogCallbackThreaded is deprecated. Use Application.logMessageReceivedThreaded instead.")]
		public static void RegisterLogCallbackThreaded(Application.LogCallback handler)
		{
			Application.RegisterLogCallback(handler, true);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00016B58 File Offset: 0x00014D58
		private static void RegisterLogCallback(Application.LogCallback handler, bool threaded)
		{
			if (Application.s_RegisterLogCallbackDeprecated != null)
			{
				Application.logMessageReceived -= Application.s_RegisterLogCallbackDeprecated;
				Application.logMessageReceivedThreaded -= Application.s_RegisterLogCallbackDeprecated;
			}
			Application.s_RegisterLogCallbackDeprecated = handler;
			if (handler != null)
			{
				if (threaded)
				{
					Application.logMessageReceivedThreaded += handler;
				}
				else
				{
					Application.logMessageReceived += handler;
				}
			}
		}

		// Token: 0x04000200 RID: 512
		internal static AdvertisingIdentifierCallback OnAdvertisingIdentifierCallback;

		// Token: 0x04000201 RID: 513
		private static Application.LogCallback s_LogCallbackHandler;

		// Token: 0x04000202 RID: 514
		private static Application.LogCallback s_LogCallbackHandlerThreaded;

		// Token: 0x04000203 RID: 515
		private static volatile Application.LogCallback s_RegisterLogCallbackDeprecated;

		/// <summary>
		///   <para>Use this delegate type with Application.logMessageReceived or Application.logMessageReceivedThreaded to monitor what gets logged.</para>
		/// </summary>
		/// <param name="condition"></param>
		/// <param name="stackTrace"></param>
		/// <param name="type"></param>
		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x060009B5 RID: 2485
		public delegate void LogCallback(string condition, string stackTrace, LogType type);
	}
}
