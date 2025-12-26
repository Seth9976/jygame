using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Provides access to a display / screen for rendering operations. </para>
	/// </summary>
	// Token: 0x020000B3 RID: 179
	public sealed class Display
	{
		// Token: 0x06000A99 RID: 2713 RVA: 0x00005C50 File Offset: 0x00003E50
		internal Display()
		{
			this.nativeDisplay = new IntPtr(0);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00005C64 File Offset: 0x00003E64
		internal Display(IntPtr nativeDisplay)
		{
			this.nativeDisplay = nativeDisplay;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00005C73 File Offset: 0x00003E73
		// Note: this type is marked as 'beforefieldinit'.
		static Display()
		{
			Display.onDisplaysUpdated = null;
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000A9C RID: 2716 RVA: 0x00005C9A File Offset: 0x00003E9A
		// (remove) Token: 0x06000A9D RID: 2717 RVA: 0x00005CB1 File Offset: 0x00003EB1
		public static event Display.DisplaysUpdatedDelegate onDisplaysUpdated;

		/// <summary>
		///   <para>Rendering Width.</para>
		/// </summary>
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x00016DA0 File Offset: 0x00014FA0
		public int renderingWidth
		{
			get
			{
				int num = 0;
				int num2 = 0;
				Display.GetRenderingExtImpl(this.nativeDisplay, out num, out num2);
				return num;
			}
		}

		/// <summary>
		///   <para>Rendering Height.</para>
		/// </summary>
		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00016DC4 File Offset: 0x00014FC4
		public int renderingHeight
		{
			get
			{
				int num = 0;
				int num2 = 0;
				Display.GetRenderingExtImpl(this.nativeDisplay, out num, out num2);
				return num2;
			}
		}

		/// <summary>
		///   <para>System Width.</para>
		/// </summary>
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x00016DE8 File Offset: 0x00014FE8
		public int systemWidth
		{
			get
			{
				int num = 0;
				int num2 = 0;
				Display.GetSystemExtImpl(this.nativeDisplay, out num, out num2);
				return num;
			}
		}

		/// <summary>
		///   <para>System Height.</para>
		/// </summary>
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00016E0C File Offset: 0x0001500C
		public int systemHeight
		{
			get
			{
				int num = 0;
				int num2 = 0;
				Display.GetSystemExtImpl(this.nativeDisplay, out num, out num2);
				return num2;
			}
		}

		/// <summary>
		///   <para>Color RenderBuffer.</para>
		/// </summary>
		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00016E30 File Offset: 0x00015030
		public RenderBuffer colorBuffer
		{
			get
			{
				RenderBuffer renderBuffer;
				RenderBuffer renderBuffer2;
				Display.GetRenderingBuffersImpl(this.nativeDisplay, out renderBuffer, out renderBuffer2);
				return renderBuffer;
			}
		}

		/// <summary>
		///   <para>Depth RenderBuffer.</para>
		/// </summary>
		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00016E50 File Offset: 0x00015050
		public RenderBuffer depthBuffer
		{
			get
			{
				RenderBuffer renderBuffer;
				RenderBuffer renderBuffer2;
				Display.GetRenderingBuffersImpl(this.nativeDisplay, out renderBuffer, out renderBuffer2);
				return renderBuffer2;
			}
		}

		/// <summary>
		///   <para>Activate an external display. Eg. Secondary Monitors connected to the System.</para>
		/// </summary>
		// Token: 0x06000AA4 RID: 2724 RVA: 0x00005CC8 File Offset: 0x00003EC8
		public void Activate()
		{
			Display.ActivateDisplayImpl(this.nativeDisplay, 0, 0, 60);
		}

		/// <summary>
		///   <para>This overloaded function available for Windows allows specifying desired Window Width, Height and Refresh Rate.</para>
		/// </summary>
		/// <param name="width">Desired Width of the Window (for Windows only. On Linux and Mac uses Screen Width).</param>
		/// <param name="height">Desired Height of the Window (for Windows only. On Linux and Mac uses Screen Height).</param>
		/// <param name="refreshRate">Desired Refresh Rate.</param>
		// Token: 0x06000AA5 RID: 2725 RVA: 0x00005CD9 File Offset: 0x00003ED9
		public void Activate(int width, int height, int refreshRate)
		{
			Display.ActivateDisplayImpl(this.nativeDisplay, width, height, refreshRate);
		}

		/// <summary>
		///   <para>This Windows only function can be used to set Size and Position of the Screen when Multi-Display is enabled.</para>
		/// </summary>
		/// <param name="width">Change Window Width (Windows Only).</param>
		/// <param name="height">Change Window Height (Windows Only).</param>
		/// <param name="x">Change Window Position X (Windows Only).</param>
		/// <param name="y">Change Window Position Y (Windows Only).</param>
		// Token: 0x06000AA6 RID: 2726 RVA: 0x00005CE9 File Offset: 0x00003EE9
		public void SetParams(int width, int height, int x, int y)
		{
			Display.SetParamsImpl(this.nativeDisplay, width, height, x, y);
		}

		/// <summary>
		///   <para>Sets Rendering resolution for the display.</para>
		/// </summary>
		/// <param name="w">Rendering width.</param>
		/// <param name="h">Rendering height.</param>
		// Token: 0x06000AA7 RID: 2727 RVA: 0x00005CFB File Offset: 0x00003EFB
		public void SetRenderingResolution(int w, int h)
		{
			Display.SetRenderingResolutionImpl(this.nativeDisplay, w, h);
		}

		/// <summary>
		///   <para>Check if MultiDisplayLicense is enabled.</para>
		/// </summary>
		// Token: 0x06000AA8 RID: 2728 RVA: 0x00005D0A File Offset: 0x00003F0A
		public static bool MultiDisplayLicense()
		{
			return Display.MultiDisplayLicenseImpl();
		}

		/// <summary>
		///   <para>Query relative mouse coordinates.</para>
		/// </summary>
		/// <param name="inputMouseCoordinates">Mouse Input Position as Coordinates.</param>
		// Token: 0x06000AA9 RID: 2729 RVA: 0x00016E70 File Offset: 0x00015070
		public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
		{
			int num = 0;
			int num2 = 0;
			int num3 = (int)inputMouseCoordinates.x;
			int num4 = (int)inputMouseCoordinates.y;
			Vector3 vector;
			vector.z = (float)Display.RelativeMouseAtImpl(num3, num4, out num, out num2);
			vector.x = (float)num;
			vector.y = (float)num2;
			return vector;
		}

		/// <summary>
		///   <para>Main Display.
		/// </para>
		/// </summary>
		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x00005D11 File Offset: 0x00003F11
		public static Display main
		{
			get
			{
				return Display._mainDisplay;
			}
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00016EBC File Offset: 0x000150BC
		private static void RecreateDisplayList(IntPtr[] nativeDisplay)
		{
			Display.displays = new Display[nativeDisplay.Length];
			for (int i = 0; i < nativeDisplay.Length; i++)
			{
				Display.displays[i] = new Display(nativeDisplay[i]);
			}
			Display._mainDisplay = Display.displays[0];
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00005D18 File Offset: 0x00003F18
		private static void FireDisplaysUpdated()
		{
			if (Display.onDisplaysUpdated != null)
			{
				Display.onDisplaysUpdated();
			}
		}

		// Token: 0x06000AAD RID: 2733
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h);

		// Token: 0x06000AAE RID: 2734
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h);

		// Token: 0x06000AAF RID: 2735
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth);

		// Token: 0x06000AB0 RID: 2736
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetRenderingResolutionImpl(IntPtr nativeDisplay, int w, int h);

		// Token: 0x06000AB1 RID: 2737
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ActivateDisplayImpl(IntPtr nativeDisplay, int width, int height, int refreshRate);

		// Token: 0x06000AB2 RID: 2738
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetParamsImpl(IntPtr nativeDisplay, int width, int height, int x, int y);

		// Token: 0x06000AB3 RID: 2739
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool MultiDisplayLicenseImpl();

		// Token: 0x06000AB4 RID: 2740
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int RelativeMouseAtImpl(int x, int y, out int rx, out int ry);

		// Token: 0x04000217 RID: 535
		internal IntPtr nativeDisplay;

		/// <summary>
		///   <para>The list of currently connected Displays. Contains at least one (main) display.</para>
		/// </summary>
		// Token: 0x04000218 RID: 536
		public static Display[] displays = new Display[]
		{
			new Display()
		};

		// Token: 0x04000219 RID: 537
		private static Display _mainDisplay = Display.displays[0];

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x06000AB6 RID: 2742
		public delegate void DisplaysUpdatedDelegate();
	}
}
