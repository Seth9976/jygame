using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Element that can be used for screen rendering.</para>
	/// </summary>
	// Token: 0x020001BA RID: 442
	public sealed class Canvas : Behaviour
	{
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06001973 RID: 6515 RVA: 0x00009032 File Offset: 0x00007232
		// (remove) Token: 0x06001974 RID: 6516 RVA: 0x00009049 File Offset: 0x00007249
		public static event Canvas.WillRenderCanvases willRenderCanvases;

		/// <summary>
		///   <para>Is the Canvas in World or Overlay mode?</para>
		/// </summary>
		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001975 RID: 6517
		// (set) Token: 0x06001976 RID: 6518
		public extern RenderMode renderMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is this the root Canvas?</para>
		/// </summary>
		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001977 RID: 6519
		public extern bool isRootCanvas
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Camera used for sizing the Canvas when in Screen Space - Camera. Also used as the Camera that events will be sent through for a World Space [[Canvas].</para>
		/// </summary>
		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001978 RID: 6520
		// (set) Token: 0x06001979 RID: 6521
		public extern Camera worldCamera
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Get the render rect for the Canvas.</para>
		/// </summary>
		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x0001BD90 File Offset: 0x00019F90
		public Rect pixelRect
		{
			get
			{
				Rect rect;
				this.INTERNAL_get_pixelRect(out rect);
				return rect;
			}
		}

		// Token: 0x0600197B RID: 6523
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_pixelRect(out Rect value);

		/// <summary>
		///   <para>Used to scale the entire canvas, while still making it fit the screen. Only applies with renderMode is Screen Space.</para>
		/// </summary>
		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600197C RID: 6524
		// (set) Token: 0x0600197D RID: 6525
		public extern float scaleFactor
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The number of pixels per unit that is considered the default.</para>
		/// </summary>
		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600197E RID: 6526
		// (set) Token: 0x0600197F RID: 6527
		public extern float referencePixelsPerUnit
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Allows for nested canvases to override pixelPerfect settings inherited from parent canvases.</para>
		/// </summary>
		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001980 RID: 6528
		// (set) Token: 0x06001981 RID: 6529
		public extern bool overridePixelPerfect
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Force elements in the canvas to be aligned with pixels. Only applies with renderMode is Screen Space.</para>
		/// </summary>
		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001982 RID: 6530
		// (set) Token: 0x06001983 RID: 6531
		public extern bool pixelPerfect
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How far away from the camera is the Canvas generated.</para>
		/// </summary>
		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001984 RID: 6532
		// (set) Token: 0x06001985 RID: 6533
		public extern float planeDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The render order in which the canvas is being emitted to the scene.</para>
		/// </summary>
		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001986 RID: 6534
		public extern int renderOrder
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Override the sorting of canvas.</para>
		/// </summary>
		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001987 RID: 6535
		// (set) Token: 0x06001988 RID: 6536
		public extern bool overrideSorting
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Canvas' order within a sorting layer.</para>
		/// </summary>
		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001989 RID: 6537
		// (set) Token: 0x0600198A RID: 6538
		public extern int sortingOrder
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Unique ID of the Canvas' sorting layer.</para>
		/// </summary>
		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x0600198B RID: 6539
		// (set) Token: 0x0600198C RID: 6540
		public extern int sortingLayerID
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Cached calculated value based upon SortingLayerID.</para>
		/// </summary>
		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x0600198D RID: 6541
		public extern int cachedSortingLayerValue
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Name of the Canvas' sorting layer.</para>
		/// </summary>
		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x0600198E RID: 6542
		// (set) Token: 0x0600198F RID: 6543
		public extern string sortingLayerName
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns the default material that can be used for rendering normal elements on the Canvas.</para>
		/// </summary>
		// Token: 0x06001990 RID: 6544
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Material GetDefaultCanvasMaterial();

		/// <summary>
		///   <para>Returns the default material that can be used for rendering text elements on the Canvas.</para>
		/// </summary>
		// Token: 0x06001991 RID: 6545
		[WrapperlessIcall]
		[Obsolete("Shared default material now used for text and general UI elements, call Canvas.GetDefaultCanvasMaterial()")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Material GetDefaultCanvasTextMaterial();

		// Token: 0x06001992 RID: 6546 RVA: 0x00009060 File Offset: 0x00007260
		private static void SendWillRenderCanvases()
		{
			if (Canvas.willRenderCanvases != null)
			{
				Canvas.willRenderCanvases();
			}
		}

		/// <summary>
		///   <para>Force all canvases to update their content.</para>
		/// </summary>
		// Token: 0x06001993 RID: 6547 RVA: 0x00009076 File Offset: 0x00007276
		public static void ForceUpdateCanvases()
		{
			Canvas.SendWillRenderCanvases();
		}

		// Token: 0x020001BB RID: 443
		// (Invoke) Token: 0x06001995 RID: 6549
		public delegate void WillRenderCanvases();
	}
}
