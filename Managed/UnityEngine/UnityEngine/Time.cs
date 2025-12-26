using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The interface to get time information from Unity.</para>
	/// </summary>
	// Token: 0x020000CC RID: 204
	public sealed class Time
	{
		/// <summary>
		///   <para>The time at the beginning of this frame (Read Only). This is the time in seconds since the start of the game.</para>
		/// </summary>
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000C81 RID: 3201
		public static extern float time
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The time this frame has started (Read Only). This is the time in seconds since the last level has been loaded.</para>
		/// </summary>
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000C82 RID: 3202
		public static extern float timeSinceLevelLoad
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The time in seconds it took to complete the last frame (Read Only).</para>
		/// </summary>
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000C83 RID: 3203
		public static extern float deltaTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The time the latest MonoBehaviour.FixedUpdate has started (Read Only). This is the time in seconds since the start of the game.</para>
		/// </summary>
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000C84 RID: 3204
		public static extern float fixedTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The timeScale-independant time at the beginning of this frame (Read Only). This is the time in seconds since the start of the game.</para>
		/// </summary>
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000C85 RID: 3205
		public static extern float unscaledTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The timeScale-independent time in seconds it took to complete the last frame (Read Only).</para>
		/// </summary>
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000C86 RID: 3206
		public static extern float unscaledDeltaTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The interval in seconds at which physics and other fixed frame rate updates (like MonoBehaviour's MonoBehaviour.FixedUpdate) are performed.</para>
		/// </summary>
		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000C87 RID: 3207
		// (set) Token: 0x06000C88 RID: 3208
		public static extern float fixedDeltaTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The maximum time a frame can take. Physics and other fixed frame rate updates (like MonoBehaviour's MonoBehaviour.FixedUpdate).</para>
		/// </summary>
		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000C89 RID: 3209
		// (set) Token: 0x06000C8A RID: 3210
		public static extern float maximumDeltaTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>A smoothed out Time.deltaTime (Read Only).</para>
		/// </summary>
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000C8B RID: 3211
		public static extern float smoothDeltaTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The scale at which the time is passing. This can be used for slow motion effects.</para>
		/// </summary>
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000C8C RID: 3212
		// (set) Token: 0x06000C8D RID: 3213
		public static extern float timeScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The total number of frames that have passed (Read Only).</para>
		/// </summary>
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000C8E RID: 3214
		public static extern int frameCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000C8F RID: 3215
		public static extern int renderedFrameCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The real time in seconds since the game started (Read Only).</para>
		/// </summary>
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000C90 RID: 3216
		public static extern float realtimeSinceStartup
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Slows game playback time to allow screenshots to be saved between frames.</para>
		/// </summary>
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000C91 RID: 3217
		// (set) Token: 0x06000C92 RID: 3218
		public static extern int captureFramerate
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
