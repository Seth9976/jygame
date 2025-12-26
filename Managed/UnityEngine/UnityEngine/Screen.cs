using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Access to display information.</para>
	/// </summary>
	// Token: 0x02000034 RID: 52
	public sealed class Screen
	{
		/// <summary>
		///   <para>All fullscreen resolutions supported by the monitor (Read Only).</para>
		/// </summary>
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000291 RID: 657
		public static extern Resolution[] resolutions
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Should the cursor be locked?</para>
		/// </summary>
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00002790 File Offset: 0x00000990
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0000279A File Offset: 0x0000099A
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property lockCursor has been deprecated. Use Cursor.lockState and Cursor.visible instead.")]
		public static bool lockCursor
		{
			get
			{
				return CursorLockMode.None == Cursor.lockState;
			}
			set
			{
				if (value)
				{
					Cursor.visible = false;
					Cursor.lockState = CursorLockMode.Locked;
				}
				else
				{
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
				}
			}
		}

		/// <summary>
		///   <para>The current screen resolution (Read Only).</para>
		/// </summary>
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000294 RID: 660
		public static extern Resolution currentResolution
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Switches the screen resolution.</para>
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="fullscreen"></param>
		/// <param name="preferredRefreshRate"></param>
		// Token: 0x06000295 RID: 661
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetResolution(int width, int height, bool fullscreen, [UnityEngine.Internal.DefaultValue("0")] int preferredRefreshRate);

		/// <summary>
		///   <para>Switches the screen resolution.</para>
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="fullscreen"></param>
		/// <param name="preferredRefreshRate"></param>
		// Token: 0x06000296 RID: 662 RVA: 0x0000FB60 File Offset: 0x0000DD60
		[ExcludeFromDocs]
		public static void SetResolution(int width, int height, bool fullscreen)
		{
			int num = 0;
			Screen.SetResolution(width, height, fullscreen, num);
		}

		/// <summary>
		///   <para>The current width of the screen window in pixels (Read Only).</para>
		/// </summary>
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000297 RID: 663
		public static extern int width
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The current height of the screen window in pixels (Read Only).</para>
		/// </summary>
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000298 RID: 664
		public static extern int height
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The current DPI of the screen / device (Read Only).</para>
		/// </summary>
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000299 RID: 665
		public static extern float dpi
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Is the game running fullscreen?</para>
		/// </summary>
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600029A RID: 666
		// (set) Token: 0x0600029B RID: 667
		public static extern bool fullScreen
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Allow auto-rotation to portrait?</para>
		/// </summary>
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600029C RID: 668
		// (set) Token: 0x0600029D RID: 669
		public static extern bool autorotateToPortrait
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Allow auto-rotation to portrait, upside down?</para>
		/// </summary>
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600029E RID: 670
		// (set) Token: 0x0600029F RID: 671
		public static extern bool autorotateToPortraitUpsideDown
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Allow auto-rotation to landscape left?</para>
		/// </summary>
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002A0 RID: 672
		// (set) Token: 0x060002A1 RID: 673
		public static extern bool autorotateToLandscapeLeft
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Allow auto-rotation to landscape right?</para>
		/// </summary>
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002A2 RID: 674
		// (set) Token: 0x060002A3 RID: 675
		public static extern bool autorotateToLandscapeRight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Specifies logical orientation of the screen.</para>
		/// </summary>
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002A4 RID: 676
		// (set) Token: 0x060002A5 RID: 677
		public static extern ScreenOrientation orientation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>A power saving setting, allowing the screen to dim some time after the last active user interaction.</para>
		/// </summary>
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002A6 RID: 678
		// (set) Token: 0x060002A7 RID: 679
		public static extern int sleepTimeout
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
